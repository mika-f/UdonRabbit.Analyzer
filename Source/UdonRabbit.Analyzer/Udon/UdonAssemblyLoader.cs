﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

using Microsoft.CodeAnalysis;

using UdonRabbit.Analyzer.Extensions;

namespace UdonRabbit.Analyzer.Udon
{
    public static class UdonAssemblyLoader
    {
        private static readonly object LockObj = new();
        private static UdonAssemblyResolver _resolver;

        private static readonly HashSet<string> UdonAllowAssemblies = new()
        {
            "VRC.Udon",
            "VRCSDK3",
            "VRCSDKBase"
        };

        private static readonly HashSet<string> UdonAllowedOptionalAssemblies = new()
        {
            "Cinemachine",
            "Unity.Postprocessing.Runtime",
            "Unity.TextMeshPro"
        };

        private static readonly HashSet<string> UdonExternalAssemblies = new()
        {
            "UdonSharp.Runtime",
            "VRC.Udon.VRCGraphModules",
            "VRC.Udon.VRCTypeResolverModules"
        };

        public static bool IsAssemblyLoaded { get; private set; }

        public static Assembly UdonEditorAssembly { get; private set; }

        public static Assembly UdonAssembly { get; private set; }

        private static IEnumerable<string> FindAssetsDirectoryFromPath(string path)
        {
            var paths = new List<string>();

            var lastIndex = 0;
            while (path.IndexOf("Assets", lastIndex, StringComparison.InvariantCulture) >= 0)
            {
                var idx = path.IndexOf("Assets", lastIndex, StringComparison.InvariantCulture);
                paths.Add(path.Substring(0, idx));

                lastIndex = idx + "Assets".Length;
            }

            paths.Reverse();
            return paths;
        }

        public static void LoadUdonAssemblies(List<MetadataReference> references)
        {
            lock (LockObj)
            {
                if (IsAssemblyLoaded)
                    return;

                UdonAssemblyVersion.Initialize(references);

                var path = references.First(w => w.ToFilePath().EndsWith("VRCSDK3.dll"));
                _resolver = new UdonAssemblyResolver(FindAssetsDirectoryFromPath(path.ToFilePath()));

                AppDomain.CurrentDomain.AssemblyResolve += (_, args) =>
                {
                    var name = args.Name.Split(',').First();
                    if (name.EndsWith(".resources"))
                        return null;

                    if (_resolver.CanResolve($"{name}.dll"))
                        return Assembly.LoadFrom(_resolver.Resolve($"{name}.dll"));

                    if (references.Any(w => w.ToFilePath().EndsWith($"{name}.dll")))
                        return Assembly.LoadFrom(references.First(w => w.ToFilePath().EndsWith($"{name}.dll")).ToFilePath());
                    return null;
                };

                var assembly = Assembly.LoadFrom(_resolver.Resolve("VRC.Udon.Editor.dll"));
                if (assembly.GetType("VRC.Udon.Editor.UdonEditorManager") == null)
                    return;

                foreach (var reference in references.Where(w => Path.GetFileNameWithoutExtension(w.ToFilePath()).Contains("UnityEngine")))
                    AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(reference.ToFilePath()));
                foreach (var external in UdonExternalAssemblies)
                    AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(_resolver.Resolve($"{external}.dll")));
                foreach (var allowed in UdonAllowAssemblies)
                    AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(_resolver.Resolve($"{allowed}.dll")));
                foreach (var allowed in UdonAllowedOptionalAssemblies.Where(w => !string.IsNullOrWhiteSpace(_resolver.Resolve($"{w}.dll"))))
                    AppDomain.CurrentDomain.Load(AssemblyName.GetAssemblyName(_resolver.Resolve($"{allowed}.dll")));

                AppDomain.CurrentDomain.ProcessExit += CurrentDomainOnProcessExit;

                UdonAssembly = AppDomain.CurrentDomain.GetAssemblies().First(w => w.GetName().Name == "VRC.Udon");
                UdonEditorAssembly = assembly;
                IsAssemblyLoaded = true;
            }
        }

        private static void CurrentDomainOnProcessExit(object sender, EventArgs e)
        {
            _resolver.Cleanup();
        }
    }
}
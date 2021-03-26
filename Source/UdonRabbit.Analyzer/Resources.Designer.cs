﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UdonRabbit.Analyzer {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("UdonRabbit.Analyzer.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Type names should be all uppercase. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AnalyzerDescription {
            get {
                return ResourceManager.GetString("AnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Type name &apos;{0}&apos; contains lowercase letters に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AnalyzerMessageFormat {
            get {
                return ResourceManager.GetString("AnalyzerMessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Type name contains lowercase letters に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string AnalyzerTitle {
            get {
                return ResourceManager.GetString("AnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Should not use method that does not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0001Description {
            get {
                return ResourceManager.GetString("URA0001Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Method &apos;{0}&apos; is not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0001MessageFormat {
            get {
                return ResourceManager.GetString("URA0001MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Method is not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0001Title {
            get {
                return ResourceManager.GetString("URA0001Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Should not use field accessor that does not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0002Description {
            get {
                return ResourceManager.GetString("URA0002Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Field Accessor &apos;{0}&apos; is not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0002MessageFormat {
            get {
                return ResourceManager.GetString("URA0002MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Field Accessor is not exposed to Udon. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0002Title {
            get {
                return ResourceManager.GetString("URA0002Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   UdonSharp only supports 1 type generic methods at the moment に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0003Description {
            get {
                return ResourceManager.GetString("URA0003Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   UdonSharp only supports 1 type generic methods, but you use {0} type generic method. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0003MessageFormat {
            get {
                return ResourceManager.GetString("URA0003MessageFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   U# only support 1 type generics. に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string URA0003Title {
            get {
                return ResourceManager.GetString("URA0003Title", resourceCulture);
            }
        }
    }
}

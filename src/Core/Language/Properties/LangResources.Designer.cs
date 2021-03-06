﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotChocolate.Language.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class LangResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LangResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HotChocolate.Language.Properties.LangResources", typeof(LangResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to The graphQLData mustn&apos;t be empty..
        /// </summary>
        internal static string GraphQLData_Empty {
            get {
                return ResourceManager.GetString("GraphQLData_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a {0} token but found `{1}`..
        /// </summary>
        internal static string ParseMany_InvalidOpenToken {
            get {
                return ResourceManager.GetString("ParseMany_InvalidOpenToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a `Int`-, `Float`-, `String`- or `BlockString`-token, but found a `{0}`-token..
        /// </summary>
        internal static string Parser_InvalidScalarToken {
            get {
                return ResourceManager.GetString("Parser_InvalidScalarToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a `{0}`-token, but found a `{1}`-token..
        /// </summary>
        internal static string Parser_InvalidToken {
            get {
                return ResourceManager.GetString("Parser_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The given syntax node is not supported by this rewriter..
        /// </summary>
        internal static string QuerySyntaxRewriter_NotSupported {
            get {
                return ResourceManager.GetString("QuerySyntaxRewriter_NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected a `{0}`-token..
        /// </summary>
        internal static string Reader_InvalidToken {
            get {
                return ResourceManager.GetString("Reader_InvalidToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected punctuator token `{0}`..
        /// </summary>
        internal static string Reader_UnexpectedPunctuatorToken {
            get {
                return ResourceManager.GetString("Reader_UnexpectedPunctuatorToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The source text mustn&apos;t be null or empty..
        /// </summary>
        internal static string SourceText_Empty {
            get {
                return ResourceManager.GetString("SourceText_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The escape char `{0}` is invalid..
        /// </summary>
        internal static string Utf8Helper_InvalidEscapeChar {
            get {
                return ResourceManager.GetString("Utf8Helper_InvalidEscapeChar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The quote escape string has to consist of three quotes `\&quot;&quot;&quot;`..
        /// </summary>
        internal static string Utf8Helper_InvalidQuoteEscapeCount {
            get {
                return ResourceManager.GetString("Utf8Helper_InvalidQuoteEscapeCount", resourceCulture);
            }
        }
    }
}

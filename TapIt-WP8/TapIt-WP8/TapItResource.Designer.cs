﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TapIt_WP8 {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TapItResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TapItResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TapIt_WP8.TapItResource", typeof(TapItResource).Assembly);
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
        ///   Looks up a localized string similar to No Data Available for AdPrompt.
        /// </summary>
        internal static string AdPromptData {
            get {
                return ResourceManager.GetString("AdPromptData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://dev.tapit.com/~npenteado/adrequest.php.
        /// </summary>
        internal static string BaseUrl {
            get {
                return ResourceManager.GetString("BaseUrl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to http://ec2-107-20-3-62.compute-1.amazonaws.com/~chetanch/adrequest.php.
        /// </summary>
        internal static string BaseUrl_Local {
            get {
                return ResourceManager.GetString("BaseUrl_Local", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TapItAdViewControl.
        /// </summary>
        internal static string BrowserName {
            get {
                return ResourceManager.GetString("BrowserName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to json.
        /// </summary>
        internal static string Format {
            get {
                return ResourceManager.GetString("Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please Load New Ad.
        /// </summary>
        internal static string LoadNewAd {
            get {
                return ResourceManager.GetString("LoadNewAd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to wp-v1.0.0.
        /// </summary>
        internal static string SdkVersion {
            get {
                return ResourceManager.GetString("SdkVersion", resourceCulture);
            }
        }
    }
}

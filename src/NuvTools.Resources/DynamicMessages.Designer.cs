﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuvTools.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class DynamicMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DynamicMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuvTools.Resources.DynamicMessages", typeof(DynamicMessages).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please confirm your account by &lt;a href=&apos;{0}&apos;&gt;clicking here&lt;/a&gt;..
        /// </summary>
        public static string EmailConfirmationContentWithLinkX {
            get {
                return ResourceManager.GetString("EmailConfirmationContentWithLinkX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please reset your password by &lt;a href=&apos;{0}&apos;&gt;clicking here&lt;/a&gt;..
        /// </summary>
        public static string PasswordResetEmailContentWithLinkX {
            get {
                return ResourceManager.GetString("PasswordResetEmailContentWithLinkX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is no {0} registered so far..
        /// </summary>
        public static string ThereIsNoXRegisteredSoFar {
            get {
                return ResourceManager.GetString("ThereIsNoXRegisteredSoFar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome {0}..
        /// </summary>
        public static string WelcomeX {
            get {
                return ResourceManager.GetString("WelcomeX", resourceCulture);
            }
        }
    }
}

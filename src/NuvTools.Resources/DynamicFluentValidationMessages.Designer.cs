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
    public class DynamicFluentValidationMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DynamicFluentValidationMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuvTools.Resources.DynamicFluentValidationMessages", typeof(DynamicFluentValidationMessages).Assembly);
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
        ///   Looks up a localized string similar to {PropertyName} is invalid..
        /// </summary>
        public static string XInvalid {
            get {
                return ResourceManager.GetString("XInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PropertyName} must be equal {ComparisonProperty}..
        /// </summary>
        public static string XMustBeEqualY {
            get {
                return ResourceManager.GetString("XMustBeEqualY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PropertyName} must contain at least {MinLength} character(s)..
        /// </summary>
        public static string XMustContainAtLeastYCharacters {
            get {
                return ResourceManager.GetString("XMustContainAtLeastYCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PropertyName} must contain between {From} and {To} characters..
        /// </summary>
        public static string XMustContainBetweenYandZCharacters {
            get {
                return ResourceManager.GetString("XMustContainBetweenYandZCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PropertyName} must contain {MinLength} character(s)..
        /// </summary>
        public static string XMustContainYCharacters {
            get {
                return ResourceManager.GetString("XMustContainYCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The {PropertyName} must be up to {MaxLength} character(s)..
        /// </summary>
        public static string XMustHaveUpToYCharacters {
            get {
                return ResourceManager.GetString("XMustHaveUpToYCharacters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {PropertyName} is required..
        /// </summary>
        public static string XRequired {
            get {
                return ResourceManager.GetString("XRequired", resourceCulture);
            }
        }
    }
}

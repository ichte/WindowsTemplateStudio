﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Templates.Wizard.Steps.DevFeatures {
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
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Templates.Wizard.Steps.DevFeatures.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Add.
        /// </summary>
        public static string AddCommand {
            get {
                return ResourceManager.GetString("AddCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cancel.
        /// </summary>
        public static string CancelCommand {
            get {
                return ResourceManager.GetString("CancelCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No features available. Lorem ipsum.
        /// </summary>
        public static string NoDevFeatAvailableMessage {
            get {
                return ResourceManager.GetString("NoDevFeatAvailableMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add features pushing add button. Lorem ipsum.
        /// </summary>
        public static string NoFeaturesMessage {
            get {
                return ResourceManager.GetString("NoFeaturesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ok.
        /// </summary>
        public static string OkCommand {
            get {
                return ResourceManager.GetString("OkCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Page name:.
        /// </summary>
        public static string PageName_Text {
            get {
                return ResourceManager.GetString("PageName_Text", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select your developer features:.
        /// </summary>
        public static string PageTitle {
            get {
                return ResourceManager.GetString("PageTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove.
        /// </summary>
        public static string RemoveCommand {
            get {
                return ResourceManager.GetString("RemoveCommand", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name already exists.
        /// </summary>
        public static string ValidationError_AlreadyExists {
            get {
                return ResourceManager.GetString("ValidationError_AlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only alphanumeric and &apos;-&apos; characters are allowed.
        /// </summary>
        public static string ValidationError_BadFormat {
            get {
                return ResourceManager.GetString("ValidationError_BadFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name cannot be empty.
        /// </summary>
        public static string ValidationError_Empty {
            get {
                return ResourceManager.GetString("ValidationError_Empty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Name is reserved.
        /// </summary>
        public static string ValidationError_ReservedName {
            get {
                return ResourceManager.GetString("ValidationError_ReservedName", resourceCulture);
            }
        }
    }
}

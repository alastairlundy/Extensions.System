﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlastairLundy.DotExtensions.Localizations {
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
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlastairLundy.DotExtensions.Localizations.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to KeyValuePair not found within the collection.
        /// </summary>
        internal static string Exceptions_KeyValuePairNotFound {
            get {
                return ResourceManager.GetString("Exceptions.KeyValuePairNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot skip more elements than the target span contains..
        /// </summary>
        internal static string Exceptions_Span_SkipCountTooLarge {
            get {
                return ResourceManager.GetString("Exceptions.Span.SkipCountTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value {x} Not Found within Key Value Pair.
        /// </summary>
        internal static string Exceptions_ValueNotFound {
            get {
                return ResourceManager.GetString("Exceptions.ValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process {x} could not be found but a similarly named process {y} was found..
        /// </summary>
        internal static string Processes_Exceptions_IncorrectProcessName {
            get {
                return ResourceManager.GetString("Processes.Exceptions.IncorrectProcessName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Process {x} is not currently running. Please try again later..
        /// </summary>
        internal static string Processes_Exceptions_ProcessNotRunning {
            get {
                return ResourceManager.GetString("Processes.Exceptions.ProcessNotRunning", resourceCulture);
            }
        }
    }
}

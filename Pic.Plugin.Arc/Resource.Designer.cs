﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pic.Plugin.Arc {
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
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pic.Plugin.Arc.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to         public ParameterStack Parameters
        ///        {
        ///            get
        ///            {
        ///                ParameterStack stack = new ParameterStack();
        ///                stack.AddDoubleParameter(&quot;a0&quot;, &quot;Start angle&quot;, 0.0, 0.0);
        ///                stack.AddDoubleParameter(&quot;a1&quot;, &quot;End angle&quot;, 90.0, 0.0);
        ///                stack.AddBoolParameter(&quot;bbox&quot;, &quot;Show bounding box&quot;, false);
        ///                return stack;
        ///            }
        ///        }
        ///
        ///        public void CreateFactoryEntities(PicFactory factory, ParameterStack stack [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SourceCode {
            get {
                return ResourceManager.GetString("SourceCode", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap Thumbnail {
            get {
                object obj = ResourceManager.GetObject("Thumbnail", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetroTools.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MetroTools.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Select 
        ///	LS.DOCDATE,
        ///	cc.SOPNUMBE,
        ///	cc.CARDNAME,
        ///	cc.RCTNCCRD
        ///FROM Metro.dbo.SOP10103 cc
        ///Join (
        ///	select * from Metro.dbo.SOP30200 h
        ///	Where h.CUSTNMBR = &apos;{0}&apos; AND h.SOPTYPE = 3
        ///	AND h.DOCDATE &gt; dateadd(m, -12, getdate() - datepart(d, getdate()) + 1)
        ///) LS
        ///
        ///ON LS.SOPNUMBE = cc.SOPNUMBE
        ///ORDER BY LS.DOCDATE DESC.
        /// </summary>
        internal static string ccQuery {
            get {
                return ResourceManager.GetString("ccQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select * From SOP10202 Where CMMTTEXT like &apos;%{0}%&apos; and SOPTYPE=3.
        /// </summary>
        internal static string serialQuery {
            get {
                return ResourceManager.GetString("serialQuery", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select * From SOP10107 Where Tracking_Number=&apos;{0}&apos; and SOPTYPE=3.
        /// </summary>
        internal static string trxQuery {
            get {
                return ResourceManager.GetString("trxQuery", resourceCulture);
            }
        }
    }
}

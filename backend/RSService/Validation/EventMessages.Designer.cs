﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSService.Validation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class EventMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal EventMessages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RSService.Validation.EventMessages", typeof(EventMessages).Assembly);
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
        ///   Looks up a localized string similar to Event.AttendeeId.CancelSomeoneElseBooking.
        /// </summary>
        internal static string CancellationOwnBooking {
            get {
                return ResourceManager.GetString("CancellationOwnBooking", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.LessThan15Minutes.
        /// </summary>
        internal static string CancellationTimeSpanLess {
            get {
                return ResourceManager.GetString("CancellationTimeSpanLess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.EndDate.Empty.
        /// </summary>
        internal static string EmptyEndDate {
            get {
                return ResourceManager.GetString("EmptyEndDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.Empty.
        /// </summary>
        internal static string EmptyStartDate {
            get {
                return ResourceManager.GetString("EmptyStartDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.EndDate.TimeSpan.
        /// </summary>
        internal static string InvalidTimeSpan {
            get {
                return ResourceManager.GetString("InvalidTimeSpan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.LimitPerDay.
        /// </summary>
        internal static string Limit {
            get {
                return ResourceManager.GetString("Limit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.GreaterThanTwoMonths.
        /// </summary>
        internal static string StartDateFuture {
            get {
                return ResourceManager.GetString("StartDateFuture", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.IsInThePast.
        /// </summary>
        internal static string StartDatePast {
            get {
                return ResourceManager.GetString("StartDatePast", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event.StartDate.IncorrectMinutesFormat.
        /// </summary>
        internal static string StartDateSpecific {
            get {
                return ResourceManager.GetString("StartDateSpecific", resourceCulture);
            }
        }
    }
}

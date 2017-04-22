﻿#region copyright
////////////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2014 Varian Medical Systems, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal 
// in the Software without restriction, including without limitation the rights 
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is 
// furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in 
//  all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.
//////////////////////////////////////////////////////////////////////////////////
#endregion

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoApp.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DemoApp.Properties.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Create new patient.
        /// </summary>
        public static string MainWindowViewModel_Command_CreateNewPatient {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_CreateNewPatient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time filter.
        /// </summary>
        public static string MainWindowViewModel_Command_SelectPatients {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_SelectPatients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site filter.
        /// </summary>
        public static string MainWindowViewModel_Command_SelectSites {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_SelectSites", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Structure volume filter.
        /// </summary>
        public static string MainWindowViewModel_Command_SelectVolume {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_SelectVolume", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View all patients.
        /// </summary>
        public static string MainWindowViewModel_Command_ViewAllPatients {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_ViewAllPatients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View selected patients.
        /// </summary>
        public static string MainWindowViewModel_Command_ViewSelectedPatients {
            get {
                return ResourceManager.GetString("MainWindowViewModel_Command_ViewSelectedPatients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MVVM Demo App.
        /// </summary>
        public static string MainWindowViewModel_DisplayName {
            get {
                return ResourceManager.GetString("MainWindowViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MRN is invalid.
        /// </summary>
        public static string Patient_Error_InvalidMRN {
            get {
                return ResourceManager.GetString("Patient_Error_InvalidMRN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to First name is missing.
        /// </summary>
        public static string Patient_Error_MissingFirstName {
            get {
                return ResourceManager.GetString("Patient_Error_MissingFirstName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Last name is missing.
        /// </summary>
        public static string Patient_Error_MissingLastName {
            get {
                return ResourceManager.GetString("Patient_Error_MissingLastName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MRN  is missing.
        /// </summary>
        public static string Patient_Error_MissingMRN {
            get {
                return ResourceManager.GetString("Patient_Error_MissingMRN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Time filter.
        /// </summary>
        public static string PatientsViewModel_DisplayName {
            get {
                return ResourceManager.GetString("PatientsViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Patient type must be selected.
        /// </summary>
        public static string PatientViewModel_Error_MissingPatientType {
            get {
                return ResourceManager.GetString("PatientViewModel_Error_MissingPatientType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Female.
        /// </summary>
        public static string PatientViewModel_PatientTypeOption_Female {
            get {
                return ResourceManager.GetString("PatientViewModel_PatientTypeOption_Female", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Male.
        /// </summary>
        public static string PatientViewModel_PatientTypeOption_Male {
            get {
                return ResourceManager.GetString("PatientViewModel_PatientTypeOption_Male", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Selected Patient.
        /// </summary>
        public static string SelectedPatientsViewModel_DisplayName {
            get {
                return ResourceManager.GetString("SelectedPatientsViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing name.
        /// </summary>
        public static string Site_Error_MissingName {
            get {
                return ResourceManager.GetString("Site_Error_MissingName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sites filter.
        /// </summary>
        public static string SitesViewModel_DisplayName {
            get {
                return ResourceManager.GetString("SitesViewModel_DisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Missing key.
        /// </summary>
        public static string Volume_Error_MissingKey {
            get {
                return ResourceManager.GetString("Volume_Error_MissingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Volume filter.
        /// </summary>
        public static string VolumesViewModel_DisplayName {
            get {
                return ResourceManager.GetString("VolumesViewModel_DisplayName", resourceCulture);
            }
        }
    }
}

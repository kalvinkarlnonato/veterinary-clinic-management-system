﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VCMS.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64, 64, 64")]
        public global::System.Drawing.Color GlobalFontColor {
            get {
                return ((global::System.Drawing.Color)(this["GlobalFontColor"]));
            }
            set {
                this["GlobalFontColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control")]
        public global::System.Drawing.Color GlobalBackColor {
            get {
                return ((global::System.Drawing.Color)(this["GlobalBackColor"]));
            }
            set {
                this["GlobalBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Tahoma, 9.75pt")]
        public global::System.Drawing.Font GlobalFontStyle {
            get {
                return ((global::System.Drawing.Font)(this["GlobalFontStyle"]));
            }
            set {
                this["GlobalFontStyle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Normal")]
        public global::System.Windows.Forms.FormWindowState GlobalWindowState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["GlobalWindowState"]));
            }
            set {
                this["GlobalWindowState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100, 70")]
        public global::System.Drawing.Point GlobalWindowLocation {
            get {
                return ((global::System.Drawing.Point)(this["GlobalWindowLocation"]));
            }
            set {
                this["GlobalWindowLocation"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1000, 500")]
        public global::System.Drawing.Size GlobalWindowSize {
            get {
                return ((global::System.Drawing.Size)(this["GlobalWindowSize"]));
            }
            set {
                this["GlobalWindowSize"] = value;
            }
        }
    }
}

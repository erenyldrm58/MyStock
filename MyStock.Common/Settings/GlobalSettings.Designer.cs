﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyStock.Common.Settings {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class GlobalSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static GlobalSettings defaultInstance = ((GlobalSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new GlobalSettings())));
        
        public static GlobalSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool IsTest {
            get {
                return ((bool)(this["IsTest"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-GV8VLNM\\SQLEXPRESS2017;Initial Catalog=MyStockDbTest;User ID=" +
            "sa;Password=MsSqlPass")]
        public string MyStockDbTest {
            get {
                return ((string)(this["MyStockDbTest"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=.;Initial Catalog=MyStockDb;User ID=sa;Password=MsSqlPass")]
        public string MyStockDb {
            get {
                return ((string)(this["MyStockDb"]));
            }
        }
    }
}

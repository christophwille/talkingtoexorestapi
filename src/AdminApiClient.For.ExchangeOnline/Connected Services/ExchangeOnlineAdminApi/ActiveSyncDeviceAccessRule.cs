﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 1/31/2023 2:36:10 PM
namespace AdminApiClient.For.ExchangeOnline.OData
{
    /// <summary>
    /// There are no comments for ActiveSyncDeviceAccessRuleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveSyncDeviceAccessRuleSingle")]
    public partial class ActiveSyncDeviceAccessRuleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ActiveSyncDeviceAccessRule>
    {
        /// <summary>
        /// Initialize a new ActiveSyncDeviceAccessRuleSingle object.
        /// </summary>
        public ActiveSyncDeviceAccessRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ActiveSyncDeviceAccessRuleSingle object.
        /// </summary>
        public ActiveSyncDeviceAccessRuleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ActiveSyncDeviceAccessRuleSingle object.
        /// </summary>
        public ActiveSyncDeviceAccessRuleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ActiveSyncDeviceAccessRule> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ActiveSyncDeviceAccessRule in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Guid")]
    [global::Microsoft.OData.Client.EntitySet("ActiveSyncDeviceAccessRule")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ActiveSyncDeviceAccessRule")]
    public partial class ActiveSyncDeviceAccessRule : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Guid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Guid")]
        public virtual string Guid
        {
            get
            {
                return this._Guid;
            }
            set
            {
                this.OnGuidChanging(value);
                this._Guid = value;
                this.OnGuidChanged();
                this.OnPropertyChanged("Guid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Guid;
        partial void OnGuidChanging(string value);
        partial void OnGuidChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property QueryString in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("QueryString")]
        public virtual string QueryString
        {
            get
            {
                return this._QueryString;
            }
            set
            {
                this.OnQueryStringChanging(value);
                this._QueryString = value;
                this.OnQueryStringChanged();
                this.OnPropertyChanged("QueryString");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _QueryString;
        partial void OnQueryStringChanging(string value);
        partial void OnQueryStringChanged();
        /// <summary>
        /// There are no comments for Property Characteristic in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Characteristic")]
        public virtual string Characteristic
        {
            get
            {
                return this._Characteristic;
            }
            set
            {
                this.OnCharacteristicChanging(value);
                this._Characteristic = value;
                this.OnCharacteristicChanged();
                this.OnPropertyChanged("Characteristic");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Characteristic;
        partial void OnCharacteristicChanging(string value);
        partial void OnCharacteristicChanged();
        /// <summary>
        /// There are no comments for Property AccessLevel in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AccessLevel")]
        public virtual string AccessLevel
        {
            get
            {
                return this._AccessLevel;
            }
            set
            {
                this.OnAccessLevelChanging(value);
                this._AccessLevel = value;
                this.OnAccessLevelChanged();
                this.OnPropertyChanged("AccessLevel");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AccessLevel;
        partial void OnAccessLevelChanging(string value);
        partial void OnAccessLevelChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}

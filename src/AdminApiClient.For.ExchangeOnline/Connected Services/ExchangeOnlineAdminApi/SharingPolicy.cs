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
    /// There are no comments for SharingPolicySingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("SharingPolicySingle")]
    public partial class SharingPolicySingle : global::Microsoft.OData.Client.DataServiceQuerySingle<SharingPolicy>
    {
        /// <summary>
        /// Initialize a new SharingPolicySingle object.
        /// </summary>
        public SharingPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SharingPolicySingle object.
        /// </summary>
        public SharingPolicySingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SharingPolicySingle object.
        /// </summary>
        public SharingPolicySingle(global::Microsoft.OData.Client.DataServiceQuerySingle<SharingPolicy> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for SharingPolicy in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Identity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Identity")]
    [global::Microsoft.OData.Client.EntitySet("SharingPolicy")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("SharingPolicy")]
    public partial class SharingPolicy : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Identity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Identity")]
        public virtual string Identity
        {
            get
            {
                return this._Identity;
            }
            set
            {
                this.OnIdentityChanging(value);
                this._Identity = value;
                this.OnIdentityChanged();
                this.OnPropertyChanged("Identity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Identity;
        partial void OnIdentityChanging(string value);
        partial void OnIdentityChanged();
        /// <summary>
        /// There are no comments for Property AdminDisplayName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AdminDisplayName")]
        public virtual string AdminDisplayName
        {
            get
            {
                return this._AdminDisplayName;
            }
            set
            {
                this.OnAdminDisplayNameChanging(value);
                this._AdminDisplayName = value;
                this.OnAdminDisplayNameChanged();
                this.OnPropertyChanged("AdminDisplayName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdminDisplayName;
        partial void OnAdminDisplayNameChanging(string value);
        partial void OnAdminDisplayNameChanged();
        /// <summary>
        /// There are no comments for Property Default in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Default")]
        public virtual global::System.Nullable<bool> Default
        {
            get
            {
                return this._Default;
            }
            set
            {
                this.OnDefaultChanging(value);
                this._Default = value;
                this.OnDefaultChanged();
                this.OnPropertyChanged("Default");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _Default;
        partial void OnDefaultChanging(global::System.Nullable<bool> value);
        partial void OnDefaultChanged();
        /// <summary>
        /// There are no comments for Property IsValid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsValid")]
        public virtual global::System.Nullable<bool> IsValid
        {
            get
            {
                return this._IsValid;
            }
            set
            {
                this.OnIsValidChanging(value);
                this._IsValid = value;
                this.OnIsValidChanged();
                this.OnPropertyChanged("IsValid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsValid;
        partial void OnIsValidChanging(global::System.Nullable<bool> value);
        partial void OnIsValidChanged();
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
        /// There are no comments for Property WhenChangedUTC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WhenChangedUTC")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> WhenChangedUTC
        {
            get
            {
                return this._WhenChangedUTC;
            }
            set
            {
                this.OnWhenChangedUTCChanging(value);
                this._WhenChangedUTC = value;
                this.OnWhenChangedUTCChanged();
                this.OnPropertyChanged("WhenChangedUTC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _WhenChangedUTC;
        partial void OnWhenChangedUTCChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnWhenChangedUTCChanged();
        /// <summary>
        /// There are no comments for Property WhenCreatedUTC in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WhenCreatedUTC")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> WhenCreatedUTC
        {
            get
            {
                return this._WhenCreatedUTC;
            }
            set
            {
                this.OnWhenCreatedUTCChanging(value);
                this._WhenCreatedUTC = value;
                this.OnWhenCreatedUTCChanged();
                this.OnPropertyChanged("WhenCreatedUTC");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _WhenCreatedUTC;
        partial void OnWhenCreatedUTCChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnWhenCreatedUTCChanged();
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

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
    /// There are no comments for ExchangeManagementScopeSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeManagementScopeSingle")]
    public partial class ExchangeManagementScopeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ExchangeManagementScope>
    {
        /// <summary>
        /// Initialize a new ExchangeManagementScopeSingle object.
        /// </summary>
        public ExchangeManagementScopeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ExchangeManagementScopeSingle object.
        /// </summary>
        public ExchangeManagementScopeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ExchangeManagementScopeSingle object.
        /// </summary>
        public ExchangeManagementScopeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ExchangeManagementScope> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for ExchangeManagementScope in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("id")]
    [global::Microsoft.OData.Client.EntitySet("ExchangeManagementScope")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeManagementScope")]
    public partial class ExchangeManagementScope : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("id")]
        public virtual string Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Id;
        partial void OnIdChanging(string value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property RecipientRoot in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("recipientRoot")]
        public virtual string RecipientRoot
        {
            get
            {
                return this._RecipientRoot;
            }
            set
            {
                this.OnRecipientRootChanging(value);
                this._RecipientRoot = value;
                this.OnRecipientRootChanged();
                this.OnPropertyChanged("recipientRoot");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientRoot;
        partial void OnRecipientRootChanging(string value);
        partial void OnRecipientRootChanged();
        /// <summary>
        /// There are no comments for Property Filter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("filter")]
        public virtual string Filter
        {
            get
            {
                return this._Filter;
            }
            set
            {
                this.OnFilterChanging(value);
                this._Filter = value;
                this.OnFilterChanged();
                this.OnPropertyChanged("filter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Filter;
        partial void OnFilterChanging(string value);
        partial void OnFilterChanged();
        /// <summary>
        /// There are no comments for Property RecipientFilter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("recipientFilter")]
        public virtual string RecipientFilter
        {
            get
            {
                return this._RecipientFilter;
            }
            set
            {
                this.OnRecipientFilterChanging(value);
                this._RecipientFilter = value;
                this.OnRecipientFilterChanged();
                this.OnPropertyChanged("recipientFilter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientFilter;
        partial void OnRecipientFilterChanging(string value);
        partial void OnRecipientFilterChanged();
        /// <summary>
        /// There are no comments for Property ServerFilter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("serverFilter")]
        public virtual string ServerFilter
        {
            get
            {
                return this._ServerFilter;
            }
            set
            {
                this.OnServerFilterChanging(value);
                this._ServerFilter = value;
                this.OnServerFilterChanged();
                this.OnPropertyChanged("serverFilter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ServerFilter;
        partial void OnServerFilterChanging(string value);
        partial void OnServerFilterChanged();
        /// <summary>
        /// There are no comments for Property DatabaseFilter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("databaseFilter")]
        public virtual string DatabaseFilter
        {
            get
            {
                return this._DatabaseFilter;
            }
            set
            {
                this.OnDatabaseFilterChanging(value);
                this._DatabaseFilter = value;
                this.OnDatabaseFilterChanged();
                this.OnPropertyChanged("databaseFilter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DatabaseFilter;
        partial void OnDatabaseFilterChanging(string value);
        partial void OnDatabaseFilterChanged();
        /// <summary>
        /// There are no comments for Property TenantOrganizationFilter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("tenantOrganizationFilter")]
        public virtual string TenantOrganizationFilter
        {
            get
            {
                return this._TenantOrganizationFilter;
            }
            set
            {
                this.OnTenantOrganizationFilterChanging(value);
                this._TenantOrganizationFilter = value;
                this.OnTenantOrganizationFilterChanged();
                this.OnPropertyChanged("tenantOrganizationFilter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TenantOrganizationFilter;
        partial void OnTenantOrganizationFilterChanging(string value);
        partial void OnTenantOrganizationFilterChanged();
        /// <summary>
        /// There are no comments for Property ScopeRestrictionType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("scopeRestrictionType")]
        public virtual global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> ScopeRestrictionType
        {
            get
            {
                return this._ScopeRestrictionType;
            }
            set
            {
                this.OnScopeRestrictionTypeChanging(value);
                this._ScopeRestrictionType = value;
                this.OnScopeRestrictionTypeChanged();
                this.OnPropertyChanged("scopeRestrictionType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> _ScopeRestrictionType;
        partial void OnScopeRestrictionTypeChanging(global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> value);
        partial void OnScopeRestrictionTypeChanged();
        /// <summary>
        /// There are no comments for Property Exclusive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("exclusive")]
        public virtual global::System.Nullable<bool> Exclusive
        {
            get
            {
                return this._Exclusive;
            }
            set
            {
                this.OnExclusiveChanging(value);
                this._Exclusive = value;
                this.OnExclusiveChanged();
                this.OnPropertyChanged("exclusive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _Exclusive;
        partial void OnExclusiveChanging(global::System.Nullable<bool> value);
        partial void OnExclusiveChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("name")]
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
                this.OnPropertyChanged("name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property AdminDisplayName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("adminDisplayName")]
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
                this.OnPropertyChanged("adminDisplayName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _AdminDisplayName;
        partial void OnAdminDisplayNameChanging(string value);
        partial void OnAdminDisplayNameChanged();
        /// <summary>
        /// There are no comments for Property Version in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("version")]
        public virtual string Version
        {
            get
            {
                return this._Version;
            }
            set
            {
                this.OnVersionChanging(value);
                this._Version = value;
                this.OnVersionChanged();
                this.OnPropertyChanged("version");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Version;
        partial void OnVersionChanging(string value);
        partial void OnVersionChanged();
        /// <summary>
        /// There are no comments for Property DistinguishedName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("distinguishedName")]
        public virtual string DistinguishedName
        {
            get
            {
                return this._DistinguishedName;
            }
            set
            {
                this.OnDistinguishedNameChanging(value);
                this._DistinguishedName = value;
                this.OnDistinguishedNameChanged();
                this.OnPropertyChanged("distinguishedName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DistinguishedName;
        partial void OnDistinguishedNameChanging(string value);
        partial void OnDistinguishedNameChanged();
        /// <summary>
        /// There are no comments for Property Guid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("guid")]
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
                this.OnPropertyChanged("guid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Guid;
        partial void OnGuidChanging(string value);
        partial void OnGuidChanged();
        /// <summary>
        /// There are no comments for Property Identity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("identity")]
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
                this.OnPropertyChanged("identity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Identity;
        partial void OnIdentityChanging(string value);
        partial void OnIdentityChanged();
        /// <summary>
        /// There are no comments for Property RecipientRestrictionFilter in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("recipientRestrictionFilter")]
        public virtual string RecipientRestrictionFilter
        {
            get
            {
                return this._RecipientRestrictionFilter;
            }
            set
            {
                this.OnRecipientRestrictionFilterChanging(value);
                this._RecipientRestrictionFilter = value;
                this.OnRecipientRestrictionFilterChanged();
                this.OnPropertyChanged("recipientRestrictionFilter");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientRestrictionFilter;
        partial void OnRecipientRestrictionFilterChanging(string value);
        partial void OnRecipientRestrictionFilterChanged();
        /// <summary>
        /// There are no comments for Property Type in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("type")]
        public virtual global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this.OnTypeChanging(value);
                this._Type = value;
                this.OnTypeChanged();
                this.OnPropertyChanged("type");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> _Type;
        partial void OnTypeChanging(global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.ScopeRestrictionType> value);
        partial void OnTypeChanged();
        /// <summary>
        /// There are no comments for Property DisplayName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("displayName")]
        public virtual string DisplayName
        {
            get
            {
                return this._DisplayName;
            }
            set
            {
                this.OnDisplayNameChanging(value);
                this._DisplayName = value;
                this.OnDisplayNameChanged();
                this.OnPropertyChanged("displayName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DisplayName;
        partial void OnDisplayNameChanging(string value);
        partial void OnDisplayNameChanged();
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
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
    /// There are no comments for RoleDefinitionsSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RoleDefinitionsSingle")]
    public partial class RoleDefinitionsSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RoleDefinitions>
    {
        /// <summary>
        /// Initialize a new RoleDefinitionsSingle object.
        /// </summary>
        public RoleDefinitionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RoleDefinitionsSingle object.
        /// </summary>
        public RoleDefinitionsSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RoleDefinitionsSingle object.
        /// </summary>
        public RoleDefinitionsSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RoleDefinitions> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for InheritsPermissionsFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("inheritsPermissionsFrom")]
        public virtual global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitionsSingle InheritsPermissionsFrom
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._InheritsPermissionsFrom == null))
                {
                    this._InheritsPermissionsFrom = new global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitionsSingle(this.Context, GetPath("inheritsPermissionsFrom"));
                }
                return this._InheritsPermissionsFrom;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitionsSingle _InheritsPermissionsFrom;
    }
    /// <summary>
    /// There are no comments for RoleDefinitions in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("id")]
    [global::Microsoft.OData.Client.EntitySet("RoleDefinitions")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("RoleDefinitions")]
    public partial class RoleDefinitions : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RoleDefinitions object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="parent">Initial value of Parent.</param>
        /// <param name="inheritsPermissionsFrom">Initial value of InheritsPermissionsFrom.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RoleDefinitions CreateRoleDefinitions(string ID, string parent, global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitions inheritsPermissionsFrom)
        {
            RoleDefinitions roleDefinitions = new RoleDefinitions();
            roleDefinitions.Id = ID;
            roleDefinitions.Parent = parent;
            if ((inheritsPermissionsFrom == null))
            {
                throw new global::System.ArgumentNullException("inheritsPermissionsFrom");
            }
            roleDefinitions.InheritsPermissionsFrom = inheritsPermissionsFrom;
            return roleDefinitions;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
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
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("description")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
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
        /// There are no comments for Property Parent in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("parent")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Parent is required.")]
        public virtual string Parent
        {
            get
            {
                return this._Parent;
            }
            set
            {
                this.OnParentChanging(value);
                this._Parent = value;
                this.OnParentChanged();
                this.OnPropertyChanged("parent");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Parent;
        partial void OnParentChanging(string value);
        partial void OnParentChanged();
        /// <summary>
        /// There are no comments for Property RoleEntries in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("roleEntries")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> RoleEntries
        {
            get
            {
                return this._RoleEntries;
            }
            set
            {
                this.OnRoleEntriesChanging(value);
                this._RoleEntries = value;
                this.OnRoleEntriesChanged();
                this.OnPropertyChanged("roleEntries");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _RoleEntries = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnRoleEntriesChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnRoleEntriesChanged();
        /// <summary>
        /// There are no comments for Property RolePermissions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("rolePermissions")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.RolePermission> RolePermissions
        {
            get
            {
                return this._RolePermissions;
            }
            set
            {
                this.OnRolePermissionsChanging(value);
                this._RolePermissions = value;
                this.OnRolePermissionsChanged();
                this.OnPropertyChanged("rolePermissions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.RolePermission> _RolePermissions = new global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.RolePermission>();
        partial void OnRolePermissionsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.RolePermission> value);
        partial void OnRolePermissionsChanged();
        /// <summary>
        /// There are no comments for Property ImplicitRecipientReadScope in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("implicitRecipientReadScope")]
        public virtual string ImplicitRecipientReadScope
        {
            get
            {
                return this._ImplicitRecipientReadScope;
            }
            set
            {
                this.OnImplicitRecipientReadScopeChanging(value);
                this._ImplicitRecipientReadScope = value;
                this.OnImplicitRecipientReadScopeChanged();
                this.OnPropertyChanged("implicitRecipientReadScope");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ImplicitRecipientReadScope;
        partial void OnImplicitRecipientReadScopeChanging(string value);
        partial void OnImplicitRecipientReadScopeChanged();
        /// <summary>
        /// There are no comments for Property ImplicitRecipientWriteScope in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("implicitRecipientWriteScope")]
        public virtual string ImplicitRecipientWriteScope
        {
            get
            {
                return this._ImplicitRecipientWriteScope;
            }
            set
            {
                this.OnImplicitRecipientWriteScopeChanging(value);
                this._ImplicitRecipientWriteScope = value;
                this.OnImplicitRecipientWriteScopeChanged();
                this.OnPropertyChanged("implicitRecipientWriteScope");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ImplicitRecipientWriteScope;
        partial void OnImplicitRecipientWriteScopeChanging(string value);
        partial void OnImplicitRecipientWriteScopeChanged();
        /// <summary>
        /// There are no comments for Property ImplicitConfigReadScope in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("implicitConfigReadScope")]
        public virtual string ImplicitConfigReadScope
        {
            get
            {
                return this._ImplicitConfigReadScope;
            }
            set
            {
                this.OnImplicitConfigReadScopeChanging(value);
                this._ImplicitConfigReadScope = value;
                this.OnImplicitConfigReadScopeChanged();
                this.OnPropertyChanged("implicitConfigReadScope");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ImplicitConfigReadScope;
        partial void OnImplicitConfigReadScopeChanging(string value);
        partial void OnImplicitConfigReadScopeChanged();
        /// <summary>
        /// There are no comments for Property ImplicitConfigWriteScope in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("implicitConfigWriteScope")]
        public virtual string ImplicitConfigWriteScope
        {
            get
            {
                return this._ImplicitConfigWriteScope;
            }
            set
            {
                this.OnImplicitConfigWriteScopeChanging(value);
                this._ImplicitConfigWriteScope = value;
                this.OnImplicitConfigWriteScopeChanged();
                this.OnPropertyChanged("implicitConfigWriteScope");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ImplicitConfigWriteScope;
        partial void OnImplicitConfigWriteScopeChanging(string value);
        partial void OnImplicitConfigWriteScopeChanged();
        /// <summary>
        /// There are no comments for Property IsRootRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isRootRole")]
        public virtual global::System.Nullable<bool> IsRootRole
        {
            get
            {
                return this._IsRootRole;
            }
            set
            {
                this.OnIsRootRoleChanging(value);
                this._IsRootRole = value;
                this.OnIsRootRoleChanged();
                this.OnPropertyChanged("isRootRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsRootRole;
        partial void OnIsRootRoleChanging(global::System.Nullable<bool> value);
        partial void OnIsRootRoleChanged();
        /// <summary>
        /// There are no comments for Property IsEndUserRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isEndUserRole")]
        public virtual global::System.Nullable<bool> IsEndUserRole
        {
            get
            {
                return this._IsEndUserRole;
            }
            set
            {
                this.OnIsEndUserRoleChanging(value);
                this._IsEndUserRole = value;
                this.OnIsEndUserRoleChanged();
                this.OnPropertyChanged("isEndUserRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsEndUserRole;
        partial void OnIsEndUserRoleChanging(global::System.Nullable<bool> value);
        partial void OnIsEndUserRoleChanged();
        /// <summary>
        /// There are no comments for Property IsEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isEnabled")]
        public virtual global::System.Nullable<bool> IsEnabled
        {
            get
            {
                return this._IsEnabled;
            }
            set
            {
                this.OnIsEnabledChanging(value);
                this._IsEnabled = value;
                this.OnIsEnabledChanged();
                this.OnPropertyChanged("isEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsEnabled;
        partial void OnIsEnabledChanging(global::System.Nullable<bool> value);
        partial void OnIsEnabledChanged();
        /// <summary>
        /// There are no comments for Property IsDeprecated in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isDeprecated")]
        public virtual global::System.Nullable<bool> IsDeprecated
        {
            get
            {
                return this._IsDeprecated;
            }
            set
            {
                this.OnIsDeprecatedChanging(value);
                this._IsDeprecated = value;
                this.OnIsDeprecatedChanged();
                this.OnPropertyChanged("isDeprecated");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsDeprecated;
        partial void OnIsDeprecatedChanging(global::System.Nullable<bool> value);
        partial void OnIsDeprecatedChanged();
        /// <summary>
        /// There are no comments for Property IsValid in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isValid")]
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
                this.OnPropertyChanged("isValid");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsValid;
        partial void OnIsValidChanging(global::System.Nullable<bool> value);
        partial void OnIsValidChanged();
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
        /// There are no comments for Property RoleType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("roleType")]
        public virtual string RoleType
        {
            get
            {
                return this._RoleType;
            }
            set
            {
                this.OnRoleTypeChanging(value);
                this._RoleType = value;
                this.OnRoleTypeChanged();
                this.OnPropertyChanged("roleType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RoleType;
        partial void OnRoleTypeChanging(string value);
        partial void OnRoleTypeChanged();
        /// <summary>
        /// There are no comments for Property EnabledCmdlets in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("enabledCmdlets")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> EnabledCmdlets
        {
            get
            {
                return this._EnabledCmdlets;
            }
            set
            {
                this.OnEnabledCmdletsChanging(value);
                this._EnabledCmdlets = value;
                this.OnEnabledCmdletsChanged();
                this.OnPropertyChanged("enabledCmdlets");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _EnabledCmdlets = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEnabledCmdletsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEnabledCmdletsChanged();
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
        /// There are no comments for Property IsBuiltIn in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isBuiltIn")]
        public virtual global::System.Nullable<bool> IsBuiltIn
        {
            get
            {
                return this._IsBuiltIn;
            }
            set
            {
                this.OnIsBuiltInChanging(value);
                this._IsBuiltIn = value;
                this.OnIsBuiltInChanged();
                this.OnPropertyChanged("isBuiltIn");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsBuiltIn;
        partial void OnIsBuiltInChanging(global::System.Nullable<bool> value);
        partial void OnIsBuiltInChanged();
        /// <summary>
        /// There are no comments for Property TemplateId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("templateId")]
        public virtual string TemplateId
        {
            get
            {
                return this._TemplateId;
            }
            set
            {
                this.OnTemplateIdChanging(value);
                this._TemplateId = value;
                this.OnTemplateIdChanged();
                this.OnPropertyChanged("templateId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TemplateId;
        partial void OnTemplateIdChanging(string value);
        partial void OnTemplateIdChanged();
        /// <summary>
        /// There are no comments for Property IsServicePrincipalRole in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("isServicePrincipalRole")]
        public virtual global::System.Nullable<bool> IsServicePrincipalRole
        {
            get
            {
                return this._IsServicePrincipalRole;
            }
            set
            {
                this.OnIsServicePrincipalRoleChanging(value);
                this._IsServicePrincipalRole = value;
                this.OnIsServicePrincipalRoleChanged();
                this.OnPropertyChanged("isServicePrincipalRole");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsServicePrincipalRole;
        partial void OnIsServicePrincipalRoleChanging(global::System.Nullable<bool> value);
        partial void OnIsServicePrincipalRoleChanged();
        /// <summary>
        /// There are no comments for Property AllowedPrincipalTypes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("allowedPrincipalTypes")]
        public virtual global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.RolePrincipalTypes> AllowedPrincipalTypes
        {
            get
            {
                return this._AllowedPrincipalTypes;
            }
            set
            {
                this.OnAllowedPrincipalTypesChanging(value);
                this._AllowedPrincipalTypes = value;
                this.OnAllowedPrincipalTypesChanged();
                this.OnPropertyChanged("allowedPrincipalTypes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.RolePrincipalTypes> _AllowedPrincipalTypes;
        partial void OnAllowedPrincipalTypesChanging(global::System.Nullable<global::AdminApiClient.For.ExchangeOnline.OData.RolePrincipalTypes> value);
        partial void OnAllowedPrincipalTypesChanged();
        /// <summary>
        /// There are no comments for Property InheritsPermissionsFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("inheritsPermissionsFrom")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "InheritsPermissionsFrom is required.")]
        public virtual global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitions InheritsPermissionsFrom
        {
            get
            {
                return this._InheritsPermissionsFrom;
            }
            set
            {
                this.OnInheritsPermissionsFromChanging(value);
                this._InheritsPermissionsFrom = value;
                this.OnInheritsPermissionsFromChanged();
                this.OnPropertyChanged("inheritsPermissionsFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitions _InheritsPermissionsFrom;
        partial void OnInheritsPermissionsFromChanging(global::AdminApiClient.For.ExchangeOnline.OData.RoleDefinitions value);
        partial void OnInheritsPermissionsFromChanged();
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

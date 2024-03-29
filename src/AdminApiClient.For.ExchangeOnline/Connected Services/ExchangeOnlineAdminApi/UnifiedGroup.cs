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
    /// There are no comments for UnifiedGroupSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("UnifiedGroupSingle")]
    public partial class UnifiedGroupSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<UnifiedGroup>
    {
        /// <summary>
        /// Initialize a new UnifiedGroupSingle object.
        /// </summary>
        public UnifiedGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new UnifiedGroupSingle object.
        /// </summary>
        public UnifiedGroupSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new UnifiedGroupSingle object.
        /// </summary>
        public UnifiedGroupSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<UnifiedGroup> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for UnifiedGroup in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Guid")]
    [global::Microsoft.OData.Client.EntitySet("UnifiedGroup")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("UnifiedGroup")]
    public partial class UnifiedGroup : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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
        /// There are no comments for Property GrantSendOnBehalfTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("GrantSendOnBehalfTo")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> GrantSendOnBehalfTo
        {
            get
            {
                return this._GrantSendOnBehalfTo;
            }
            set
            {
                this.OnGrantSendOnBehalfToChanging(value);
                this._GrantSendOnBehalfTo = value;
                this.OnGrantSendOnBehalfToChanged();
                this.OnPropertyChanged("GrantSendOnBehalfTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _GrantSendOnBehalfTo = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnGrantSendOnBehalfToChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnGrantSendOnBehalfToChanged();
        /// <summary>
        /// There are no comments for Property Language in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Language")]
        public virtual string Language
        {
            get
            {
                return this._Language;
            }
            set
            {
                this.OnLanguageChanging(value);
                this._Language = value;
                this.OnLanguageChanged();
                this.OnPropertyChanged("Language");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Language;
        partial void OnLanguageChanging(string value);
        partial void OnLanguageChanged();
        /// <summary>
        /// There are no comments for Property MigrationToUnifiedGroupInProgress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MigrationToUnifiedGroupInProgress")]
        public virtual global::System.Nullable<bool> MigrationToUnifiedGroupInProgress
        {
            get
            {
                return this._MigrationToUnifiedGroupInProgress;
            }
            set
            {
                this.OnMigrationToUnifiedGroupInProgressChanging(value);
                this._MigrationToUnifiedGroupInProgress = value;
                this.OnMigrationToUnifiedGroupInProgressChanged();
                this.OnPropertyChanged("MigrationToUnifiedGroupInProgress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _MigrationToUnifiedGroupInProgress;
        partial void OnMigrationToUnifiedGroupInProgressChanging(global::System.Nullable<bool> value);
        partial void OnMigrationToUnifiedGroupInProgressChanged();
        /// <summary>
        /// There are no comments for Property RejectMessagesFromSendersOrMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RejectMessagesFromSendersOrMembers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> RejectMessagesFromSendersOrMembers
        {
            get
            {
                return this._RejectMessagesFromSendersOrMembers;
            }
            set
            {
                this.OnRejectMessagesFromSendersOrMembersChanging(value);
                this._RejectMessagesFromSendersOrMembers = value;
                this.OnRejectMessagesFromSendersOrMembersChanged();
                this.OnPropertyChanged("RejectMessagesFromSendersOrMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _RejectMessagesFromSendersOrMembers = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnRejectMessagesFromSendersOrMembersChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnRejectMessagesFromSendersOrMembersChanged();
        /// <summary>
        /// There are no comments for Property AcceptMessagesOnlyFromSendersOrMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AcceptMessagesOnlyFromSendersOrMembers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> AcceptMessagesOnlyFromSendersOrMembers
        {
            get
            {
                return this._AcceptMessagesOnlyFromSendersOrMembers;
            }
            set
            {
                this.OnAcceptMessagesOnlyFromSendersOrMembersChanging(value);
                this._AcceptMessagesOnlyFromSendersOrMembers = value;
                this.OnAcceptMessagesOnlyFromSendersOrMembersChanged();
                this.OnPropertyChanged("AcceptMessagesOnlyFromSendersOrMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _AcceptMessagesOnlyFromSendersOrMembers = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnAcceptMessagesOnlyFromSendersOrMembersChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnAcceptMessagesOnlyFromSendersOrMembersChanged();
        /// <summary>
        /// There are no comments for Property SendAsPermissionList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SendAsPermissionList")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> SendAsPermissionList
        {
            get
            {
                return this._SendAsPermissionList;
            }
            set
            {
                this.OnSendAsPermissionListChanging(value);
                this._SendAsPermissionList = value;
                this.OnSendAsPermissionListChanged();
                this.OnPropertyChanged("SendAsPermissionList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _SendAsPermissionList = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnSendAsPermissionListChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnSendAsPermissionListChanged();
        /// <summary>
        /// There are no comments for Property ObjectId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ObjectId")]
        public virtual string ObjectId
        {
            get
            {
                return this._ObjectId;
            }
            set
            {
                this.OnObjectIdChanging(value);
                this._ObjectId = value;
                this.OnObjectIdChanged();
                this.OnPropertyChanged("ObjectId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ObjectId;
        partial void OnObjectIdChanging(string value);
        partial void OnObjectIdChanged();
        /// <summary>
        /// There are no comments for Property DistinguishedName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DistinguishedName")]
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
                this.OnPropertyChanged("DistinguishedName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _DistinguishedName;
        partial void OnDistinguishedNameChanging(string value);
        partial void OnDistinguishedNameChanged();
        /// <summary>
        /// There are no comments for Property WindowsLiveID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("WindowsLiveID")]
        public virtual string WindowsLiveID
        {
            get
            {
                return this._WindowsLiveID;
            }
            set
            {
                this.OnWindowsLiveIDChanging(value);
                this._WindowsLiveID = value;
                this.OnWindowsLiveIDChanged();
                this.OnPropertyChanged("WindowsLiveID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _WindowsLiveID;
        partial void OnWindowsLiveIDChanging(string value);
        partial void OnWindowsLiveIDChanged();
        /// <summary>
        /// There are no comments for Property RecipientType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecipientType")]
        public virtual string RecipientType
        {
            get
            {
                return this._RecipientType;
            }
            set
            {
                this.OnRecipientTypeChanging(value);
                this._RecipientType = value;
                this.OnRecipientTypeChanged();
                this.OnPropertyChanged("RecipientType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientType;
        partial void OnRecipientTypeChanging(string value);
        partial void OnRecipientTypeChanged();
        /// <summary>
        /// There are no comments for Property RecipientTypeDetails in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RecipientTypeDetails")]
        public virtual string RecipientTypeDetails
        {
            get
            {
                return this._RecipientTypeDetails;
            }
            set
            {
                this.OnRecipientTypeDetailsChanging(value);
                this._RecipientTypeDetails = value;
                this.OnRecipientTypeDetailsChanged();
                this.OnPropertyChanged("RecipientTypeDetails");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RecipientTypeDetails;
        partial void OnRecipientTypeDetailsChanging(string value);
        partial void OnRecipientTypeDetailsChanged();
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

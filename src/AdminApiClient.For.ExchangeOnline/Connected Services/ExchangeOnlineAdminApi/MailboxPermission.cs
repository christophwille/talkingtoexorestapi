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
    /// There are no comments for MailboxPermissionSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MailboxPermissionSingle")]
    public partial class MailboxPermissionSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MailboxPermission>
    {
        /// <summary>
        /// Initialize a new MailboxPermissionSingle object.
        /// </summary>
        public MailboxPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MailboxPermissionSingle object.
        /// </summary>
        public MailboxPermissionSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MailboxPermissionSingle object.
        /// </summary>
        public MailboxPermissionSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MailboxPermission> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MailboxPermission in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PermissionId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PermissionId")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MailboxPermission")]
    public partial class MailboxPermission : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property PermissionId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PermissionId")]
        public virtual string PermissionId
        {
            get
            {
                return this._PermissionId;
            }
            set
            {
                this.OnPermissionIdChanging(value);
                this._PermissionId = value;
                this.OnPermissionIdChanged();
                this.OnPropertyChanged("PermissionId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PermissionId;
        partial void OnPermissionIdChanging(string value);
        partial void OnPermissionIdChanged();
        /// <summary>
        /// There are no comments for Property MailboxIdentity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MailboxIdentity")]
        public virtual string MailboxIdentity
        {
            get
            {
                return this._MailboxIdentity;
            }
            set
            {
                this.OnMailboxIdentityChanging(value);
                this._MailboxIdentity = value;
                this.OnMailboxIdentityChanged();
                this.OnPropertyChanged("MailboxIdentity");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MailboxIdentity;
        partial void OnMailboxIdentityChanging(string value);
        partial void OnMailboxIdentityChanged();
        /// <summary>
        /// There are no comments for Property User in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("User")]
        public virtual string User
        {
            get
            {
                return this._User;
            }
            set
            {
                this.OnUserChanging(value);
                this._User = value;
                this.OnUserChanged();
                this.OnPropertyChanged("User");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _User;
        partial void OnUserChanging(string value);
        partial void OnUserChanged();
        /// <summary>
        /// There are no comments for Property IsOwner in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsOwner")]
        public virtual global::System.Nullable<bool> IsOwner
        {
            get
            {
                return this._IsOwner;
            }
            set
            {
                this.OnIsOwnerChanging(value);
                this._IsOwner = value;
                this.OnIsOwnerChanged();
                this.OnPropertyChanged("IsOwner");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsOwner;
        partial void OnIsOwnerChanging(global::System.Nullable<bool> value);
        partial void OnIsOwnerChanged();
        /// <summary>
        /// There are no comments for Property PermissionList in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PermissionList")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.MailboxPermissionInfo> PermissionList
        {
            get
            {
                return this._PermissionList;
            }
            set
            {
                this.OnPermissionListChanging(value);
                this._PermissionList = value;
                this.OnPermissionListChanged();
                this.OnPropertyChanged("PermissionList");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.MailboxPermissionInfo> _PermissionList = new global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.MailboxPermissionInfo>();
        partial void OnPermissionListChanging(global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.MailboxPermissionInfo> value);
        partial void OnPermissionListChanged();
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
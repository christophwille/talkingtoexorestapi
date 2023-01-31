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
    /// There are no comments for InboundConnectorSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("InboundConnectorSingle")]
    public partial class InboundConnectorSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<InboundConnector>
    {
        /// <summary>
        /// Initialize a new InboundConnectorSingle object.
        /// </summary>
        public InboundConnectorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new InboundConnectorSingle object.
        /// </summary>
        public InboundConnectorSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new InboundConnectorSingle object.
        /// </summary>
        public InboundConnectorSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<InboundConnector> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for InboundConnector in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Guid
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Guid")]
    [global::Microsoft.OData.Client.EntitySet("InboundConnector")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("InboundConnector")]
    public partial class InboundConnector : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ConnectorType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConnectorType")]
        public virtual string ConnectorType
        {
            get
            {
                return this._ConnectorType;
            }
            set
            {
                this.OnConnectorTypeChanging(value);
                this._ConnectorType = value;
                this.OnConnectorTypeChanged();
                this.OnPropertyChanged("ConnectorType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConnectorType;
        partial void OnConnectorTypeChanging(string value);
        partial void OnConnectorTypeChanged();
        /// <summary>
        /// There are no comments for Property ConnectorSource in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ConnectorSource")]
        public virtual string ConnectorSource
        {
            get
            {
                return this._ConnectorSource;
            }
            set
            {
                this.OnConnectorSourceChanging(value);
                this._ConnectorSource = value;
                this.OnConnectorSourceChanged();
                this.OnPropertyChanged("ConnectorSource");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ConnectorSource;
        partial void OnConnectorSourceChanging(string value);
        partial void OnConnectorSourceChanged();
        /// <summary>
        /// There are no comments for Property Enabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Enabled")]
        public virtual global::System.Nullable<bool> Enabled
        {
            get
            {
                return this._Enabled;
            }
            set
            {
                this.OnEnabledChanging(value);
                this._Enabled = value;
                this.OnEnabledChanged();
                this.OnPropertyChanged("Enabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _Enabled;
        partial void OnEnabledChanging(global::System.Nullable<bool> value);
        partial void OnEnabledChanged();
        /// <summary>
        /// There are no comments for Property Comment in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Comment")]
        public virtual string Comment
        {
            get
            {
                return this._Comment;
            }
            set
            {
                this.OnCommentChanging(value);
                this._Comment = value;
                this.OnCommentChanged();
                this.OnPropertyChanged("Comment");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Comment;
        partial void OnCommentChanging(string value);
        partial void OnCommentChanged();
        /// <summary>
        /// There are no comments for Property SenderIPAddresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SenderIPAddresses")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> SenderIPAddresses
        {
            get
            {
                return this._SenderIPAddresses;
            }
            set
            {
                this.OnSenderIPAddressesChanging(value);
                this._SenderIPAddresses = value;
                this.OnSenderIPAddressesChanged();
                this.OnPropertyChanged("SenderIPAddresses");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _SenderIPAddresses = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnSenderIPAddressesChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnSenderIPAddressesChanged();
        /// <summary>
        /// There are no comments for Property SenderDomains in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SenderDomains")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> SenderDomains
        {
            get
            {
                return this._SenderDomains;
            }
            set
            {
                this.OnSenderDomainsChanging(value);
                this._SenderDomains = value;
                this.OnSenderDomainsChanged();
                this.OnPropertyChanged("SenderDomains");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _SenderDomains = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnSenderDomainsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnSenderDomainsChanged();
        /// <summary>
        /// There are no comments for Property AssociatedAcceptedDomains in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AssociatedAcceptedDomains")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> AssociatedAcceptedDomains
        {
            get
            {
                return this._AssociatedAcceptedDomains;
            }
            set
            {
                this.OnAssociatedAcceptedDomainsChanging(value);
                this._AssociatedAcceptedDomains = value;
                this.OnAssociatedAcceptedDomainsChanged();
                this.OnPropertyChanged("AssociatedAcceptedDomains");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _AssociatedAcceptedDomains = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnAssociatedAcceptedDomainsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnAssociatedAcceptedDomainsChanged();
        /// <summary>
        /// There are no comments for Property RequireTls in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RequireTls")]
        public virtual global::System.Nullable<bool> RequireTls
        {
            get
            {
                return this._RequireTls;
            }
            set
            {
                this.OnRequireTlsChanging(value);
                this._RequireTls = value;
                this.OnRequireTlsChanged();
                this.OnPropertyChanged("RequireTls");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _RequireTls;
        partial void OnRequireTlsChanging(global::System.Nullable<bool> value);
        partial void OnRequireTlsChanged();
        /// <summary>
        /// There are no comments for Property RestrictDomainsToIPAddresses in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RestrictDomainsToIPAddresses")]
        public virtual global::System.Nullable<bool> RestrictDomainsToIPAddresses
        {
            get
            {
                return this._RestrictDomainsToIPAddresses;
            }
            set
            {
                this.OnRestrictDomainsToIPAddressesChanging(value);
                this._RestrictDomainsToIPAddresses = value;
                this.OnRestrictDomainsToIPAddressesChanged();
                this.OnPropertyChanged("RestrictDomainsToIPAddresses");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _RestrictDomainsToIPAddresses;
        partial void OnRestrictDomainsToIPAddressesChanging(global::System.Nullable<bool> value);
        partial void OnRestrictDomainsToIPAddressesChanged();
        /// <summary>
        /// There are no comments for Property RestrictDomainsToCertificate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("RestrictDomainsToCertificate")]
        public virtual global::System.Nullable<bool> RestrictDomainsToCertificate
        {
            get
            {
                return this._RestrictDomainsToCertificate;
            }
            set
            {
                this.OnRestrictDomainsToCertificateChanging(value);
                this._RestrictDomainsToCertificate = value;
                this.OnRestrictDomainsToCertificateChanged();
                this.OnPropertyChanged("RestrictDomainsToCertificate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _RestrictDomainsToCertificate;
        partial void OnRestrictDomainsToCertificateChanging(global::System.Nullable<bool> value);
        partial void OnRestrictDomainsToCertificateChanged();
        /// <summary>
        /// There are no comments for Property CloudServicesMailEnabled in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CloudServicesMailEnabled")]
        public virtual global::System.Nullable<bool> CloudServicesMailEnabled
        {
            get
            {
                return this._CloudServicesMailEnabled;
            }
            set
            {
                this.OnCloudServicesMailEnabledChanging(value);
                this._CloudServicesMailEnabled = value;
                this.OnCloudServicesMailEnabledChanged();
                this.OnPropertyChanged("CloudServicesMailEnabled");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _CloudServicesMailEnabled;
        partial void OnCloudServicesMailEnabledChanging(global::System.Nullable<bool> value);
        partial void OnCloudServicesMailEnabledChanged();
        /// <summary>
        /// There are no comments for Property TreatMessagesAsInternal in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TreatMessagesAsInternal")]
        public virtual global::System.Nullable<bool> TreatMessagesAsInternal
        {
            get
            {
                return this._TreatMessagesAsInternal;
            }
            set
            {
                this.OnTreatMessagesAsInternalChanging(value);
                this._TreatMessagesAsInternal = value;
                this.OnTreatMessagesAsInternalChanged();
                this.OnPropertyChanged("TreatMessagesAsInternal");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _TreatMessagesAsInternal;
        partial void OnTreatMessagesAsInternalChanging(global::System.Nullable<bool> value);
        partial void OnTreatMessagesAsInternalChanged();
        /// <summary>
        /// There are no comments for Property TlsSenderCertificateName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TlsSenderCertificateName")]
        public virtual string TlsSenderCertificateName
        {
            get
            {
                return this._TlsSenderCertificateName;
            }
            set
            {
                this.OnTlsSenderCertificateNameChanging(value);
                this._TlsSenderCertificateName = value;
                this.OnTlsSenderCertificateNameChanged();
                this.OnPropertyChanged("TlsSenderCertificateName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TlsSenderCertificateName;
        partial void OnTlsSenderCertificateNameChanging(string value);
        partial void OnTlsSenderCertificateNameChanged();
        /// <summary>
        /// There are no comments for Property EFTestMode in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EFTestMode")]
        public virtual global::System.Nullable<bool> EFTestMode
        {
            get
            {
                return this._EFTestMode;
            }
            set
            {
                this.OnEFTestModeChanging(value);
                this._EFTestMode = value;
                this.OnEFTestModeChanged();
                this.OnPropertyChanged("EFTestMode");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _EFTestMode;
        partial void OnEFTestModeChanging(global::System.Nullable<bool> value);
        partial void OnEFTestModeChanged();
        /// <summary>
        /// There are no comments for Property ScanAndDropRecipients in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ScanAndDropRecipients")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> ScanAndDropRecipients
        {
            get
            {
                return this._ScanAndDropRecipients;
            }
            set
            {
                this.OnScanAndDropRecipientsChanging(value);
                this._ScanAndDropRecipients = value;
                this.OnScanAndDropRecipientsChanged();
                this.OnPropertyChanged("ScanAndDropRecipients");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _ScanAndDropRecipients = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnScanAndDropRecipientsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnScanAndDropRecipientsChanged();
        /// <summary>
        /// There are no comments for Property EFSkipLastIP in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EFSkipLastIP")]
        public virtual global::System.Nullable<bool> EFSkipLastIP
        {
            get
            {
                return this._EFSkipLastIP;
            }
            set
            {
                this.OnEFSkipLastIPChanging(value);
                this._EFSkipLastIP = value;
                this.OnEFSkipLastIPChanged();
                this.OnPropertyChanged("EFSkipLastIP");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _EFSkipLastIP;
        partial void OnEFSkipLastIPChanging(global::System.Nullable<bool> value);
        partial void OnEFSkipLastIPChanged();
        /// <summary>
        /// There are no comments for Property EFSkipIPs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EFSkipIPs")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> EFSkipIPs
        {
            get
            {
                return this._EFSkipIPs;
            }
            set
            {
                this.OnEFSkipIPsChanging(value);
                this._EFSkipIPs = value;
                this.OnEFSkipIPsChanged();
                this.OnPropertyChanged("EFSkipIPs");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _EFSkipIPs = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEFSkipIPsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEFSkipIPsChanged();
        /// <summary>
        /// There are no comments for Property EFSkipMailGateway in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EFSkipMailGateway")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> EFSkipMailGateway
        {
            get
            {
                return this._EFSkipMailGateway;
            }
            set
            {
                this.OnEFSkipMailGatewayChanging(value);
                this._EFSkipMailGateway = value;
                this.OnEFSkipMailGatewayChanged();
                this.OnPropertyChanged("EFSkipMailGateway");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _EFSkipMailGateway = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEFSkipMailGatewayChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEFSkipMailGatewayChanged();
        /// <summary>
        /// There are no comments for Property EFUsers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EFUsers")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> EFUsers
        {
            get
            {
                return this._EFUsers;
            }
            set
            {
                this.OnEFUsersChanging(value);
                this._EFUsers = value;
                this.OnEFUsersChanged();
                this.OnPropertyChanged("EFUsers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _EFUsers = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnEFUsersChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnEFUsersChanged();
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

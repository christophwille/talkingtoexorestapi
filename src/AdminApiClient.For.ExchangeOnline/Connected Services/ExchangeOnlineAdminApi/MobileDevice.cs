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
    /// There are no comments for MobileDeviceSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MobileDeviceSingle")]
    public partial class MobileDeviceSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<MobileDevice>
    {
        /// <summary>
        /// Initialize a new MobileDeviceSingle object.
        /// </summary>
        public MobileDeviceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new MobileDeviceSingle object.
        /// </summary>
        public MobileDeviceSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new MobileDeviceSingle object.
        /// </summary>
        public MobileDeviceSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<MobileDevice> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for MobileDevice in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Identity
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Identity")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("MobileDevice")]
    public partial class MobileDevice : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
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

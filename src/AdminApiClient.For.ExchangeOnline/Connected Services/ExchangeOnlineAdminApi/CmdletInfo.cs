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
    /// There are no comments for CmdletInfoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("CmdletInfoSingle")]
    public partial class CmdletInfoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<CmdletInfo>
    {
        /// <summary>
        /// Initialize a new CmdletInfoSingle object.
        /// </summary>
        public CmdletInfoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new CmdletInfoSingle object.
        /// </summary>
        public CmdletInfoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new CmdletInfoSingle object.
        /// </summary>
        public CmdletInfoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<CmdletInfo> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for CmdletInfo in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CmdletName
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("CmdletName")]
    [global::Microsoft.OData.Client.EntitySet("CmdletInfo")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("CmdletInfo")]
    public partial class CmdletInfo : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property CmdletName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CmdletName")]
        public virtual string CmdletName
        {
            get
            {
                return this._CmdletName;
            }
            set
            {
                this.OnCmdletNameChanging(value);
                this._CmdletName = value;
                this.OnCmdletNameChanged();
                this.OnPropertyChanged("CmdletName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CmdletName;
        partial void OnCmdletNameChanging(string value);
        partial void OnCmdletNameChanged();
        /// <summary>
        /// There are no comments for Property Parameters in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Parameters")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> Parameters
        {
            get
            {
                return this._Parameters;
            }
            set
            {
                this.OnParametersChanging(value);
                this._Parameters = value;
                this.OnParametersChanged();
                this.OnPropertyChanged("Parameters");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _Parameters = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnParametersChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnParametersChanged();
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

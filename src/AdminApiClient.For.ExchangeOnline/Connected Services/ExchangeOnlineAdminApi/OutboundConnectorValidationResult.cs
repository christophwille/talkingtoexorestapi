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
    /// There are no comments for OutboundConnectorValidationResult in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OutboundConnectorValidationResult")]
    public partial class OutboundConnectorValidationResult : ComplexEntry
    {
        /// <summary>
        /// There are no comments for Property IsTaskSuccessful in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsTaskSuccessful")]
        public virtual global::System.Nullable<bool> IsTaskSuccessful
        {
            get
            {
                return this._IsTaskSuccessful;
            }
            set
            {
                this.OnIsTaskSuccessfulChanging(value);
                this._IsTaskSuccessful = value;
                this.OnIsTaskSuccessfulChanged();
                this.OnPropertyChanged("IsTaskSuccessful");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsTaskSuccessful;
        partial void OnIsTaskSuccessfulChanging(global::System.Nullable<bool> value);
        partial void OnIsTaskSuccessfulChanged();
        /// <summary>
        /// There are no comments for Property TaskName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaskName")]
        public virtual string TaskName
        {
            get
            {
                return this._TaskName;
            }
            set
            {
                this.OnTaskNameChanging(value);
                this._TaskName = value;
                this.OnTaskNameChanged();
                this.OnPropertyChanged("TaskName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskName;
        partial void OnTaskNameChanging(string value);
        partial void OnTaskNameChanged();
        /// <summary>
        /// There are no comments for Property TaskDetail in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TaskDetail")]
        public virtual string TaskDetail
        {
            get
            {
                return this._TaskDetail;
            }
            set
            {
                this.OnTaskDetailChanging(value);
                this._TaskDetail = value;
                this.OnTaskDetailChanged();
                this.OnPropertyChanged("TaskDetail");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TaskDetail;
        partial void OnTaskDetailChanging(string value);
        partial void OnTaskDetailChanged();
        /// <summary>
        /// There are no comments for Property SubTaskResults in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubTaskResults")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.OutboundConnectorValidationResult> SubTaskResults
        {
            get
            {
                return this._SubTaskResults;
            }
            set
            {
                this.OnSubTaskResultsChanging(value);
                this._SubTaskResults = value;
                this.OnSubTaskResultsChanged();
                this.OnPropertyChanged("SubTaskResults");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.OutboundConnectorValidationResult> _SubTaskResults = new global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.OutboundConnectorValidationResult>();
        partial void OnSubTaskResultsChanging(global::System.Collections.ObjectModel.ObservableCollection<global::AdminApiClient.For.ExchangeOnline.OData.OutboundConnectorValidationResult> value);
        partial void OnSubTaskResultsChanged();
    }
}

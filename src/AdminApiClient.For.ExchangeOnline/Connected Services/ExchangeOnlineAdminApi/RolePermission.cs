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
    /// There are no comments for RolePermission in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("RolePermission")]
    public partial class RolePermission : ComplexEntry
    {
        /// <summary>
        /// There are no comments for Property AllowedResourceActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("allowedResourceActions")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> AllowedResourceActions
        {
            get
            {
                return this._AllowedResourceActions;
            }
            set
            {
                this.OnAllowedResourceActionsChanging(value);
                this._AllowedResourceActions = value;
                this.OnAllowedResourceActionsChanged();
                this.OnPropertyChanged("allowedResourceActions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _AllowedResourceActions = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnAllowedResourceActionsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnAllowedResourceActionsChanged();
        /// <summary>
        /// There are no comments for Property ExcludedResourceActions in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("excludedResourceActions")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> ExcludedResourceActions
        {
            get
            {
                return this._ExcludedResourceActions;
            }
            set
            {
                this.OnExcludedResourceActionsChanging(value);
                this._ExcludedResourceActions = value;
                this.OnExcludedResourceActionsChanged();
                this.OnPropertyChanged("excludedResourceActions");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _ExcludedResourceActions = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnExcludedResourceActionsChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnExcludedResourceActionsChanged();
        /// <summary>
        /// There are no comments for Property Condition in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("condition")]
        public virtual string Condition
        {
            get
            {
                return this._Condition;
            }
            set
            {
                this.OnConditionChanging(value);
                this._Condition = value;
                this.OnConditionChanged();
                this.OnPropertyChanged("condition");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Condition;
        partial void OnConditionChanging(string value);
        partial void OnConditionChanged();
    }
}

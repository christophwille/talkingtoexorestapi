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
    /// There are no comments for ComplexEntry in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ComplexEntry")]
    public abstract partial class ComplexEntry : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// There are no comments for Property ChangedProperties in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ChangedProperties")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> ChangedProperties
        {
            get
            {
                return this._ChangedProperties;
            }
            set
            {
                this.OnChangedPropertiesChanging(value);
                this._ChangedProperties = value;
                this.OnChangedPropertiesChanged();
                this.OnPropertyChanged("ChangedProperties");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.ObservableCollection<string> _ChangedProperties = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnChangedPropertiesChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnChangedPropertiesChanged();
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

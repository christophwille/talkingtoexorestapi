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
    /// There are no comments for MailboxRecoverableItemsQuery in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("MailboxRecoverableItemsQuery")]
    public partial class MailboxRecoverableItemsQuery : ComplexEntry
    {
        /// <summary>
        /// There are no comments for Property Identity in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Identity")]
        public virtual global::System.Collections.ObjectModel.ObservableCollection<string> Identity
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
        private global::System.Collections.ObjectModel.ObservableCollection<string> _Identity = new global::System.Collections.ObjectModel.ObservableCollection<string>();
        partial void OnIdentityChanging(global::System.Collections.ObjectModel.ObservableCollection<string> value);
        partial void OnIdentityChanged();
        /// <summary>
        /// There are no comments for Property SubjectContains in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SubjectContains")]
        public virtual string SubjectContains
        {
            get
            {
                return this._SubjectContains;
            }
            set
            {
                this.OnSubjectContainsChanging(value);
                this._SubjectContains = value;
                this.OnSubjectContainsChanged();
                this.OnPropertyChanged("SubjectContains");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SubjectContains;
        partial void OnSubjectContainsChanging(string value);
        partial void OnSubjectContainsChanged();
        /// <summary>
        /// There are no comments for Property FilterItemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilterItemType")]
        public virtual string FilterItemType
        {
            get
            {
                return this._FilterItemType;
            }
            set
            {
                this.OnFilterItemTypeChanging(value);
                this._FilterItemType = value;
                this.OnFilterItemTypeChanged();
                this.OnPropertyChanged("FilterItemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FilterItemType;
        partial void OnFilterItemTypeChanging(string value);
        partial void OnFilterItemTypeChanged();
        /// <summary>
        /// There are no comments for Property FilterStartTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilterStartTime")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FilterStartTime
        {
            get
            {
                return this._FilterStartTime;
            }
            set
            {
                this.OnFilterStartTimeChanging(value);
                this._FilterStartTime = value;
                this.OnFilterStartTimeChanged();
                this.OnPropertyChanged("FilterStartTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FilterStartTime;
        partial void OnFilterStartTimeChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFilterStartTimeChanged();
        /// <summary>
        /// There are no comments for Property FilterEndTime in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FilterEndTime")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> FilterEndTime
        {
            get
            {
                return this._FilterEndTime;
            }
            set
            {
                this.OnFilterEndTimeChanging(value);
                this._FilterEndTime = value;
                this.OnFilterEndTimeChanged();
                this.OnPropertyChanged("FilterEndTime");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _FilterEndTime;
        partial void OnFilterEndTimeChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnFilterEndTimeChanged();
        /// <summary>
        /// There are no comments for Property EntryID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("EntryID")]
        public virtual string EntryID
        {
            get
            {
                return this._EntryID;
            }
            set
            {
                this.OnEntryIDChanging(value);
                this._EntryID = value;
                this.OnEntryIDChanged();
                this.OnPropertyChanged("EntryID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _EntryID;
        partial void OnEntryIDChanging(string value);
        partial void OnEntryIDChanged();
        /// <summary>
        /// There are no comments for Property SourceFolder in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("SourceFolder")]
        public virtual string SourceFolder
        {
            get
            {
                return this._SourceFolder;
            }
            set
            {
                this.OnSourceFolderChanging(value);
                this._SourceFolder = value;
                this.OnSourceFolderChanged();
                this.OnPropertyChanged("SourceFolder");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _SourceFolder;
        partial void OnSourceFolderChanging(string value);
        partial void OnSourceFolderChanged();
        /// <summary>
        /// There are no comments for Property LastParentFolderID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastParentFolderID")]
        public virtual string LastParentFolderID
        {
            get
            {
                return this._LastParentFolderID;
            }
            set
            {
                this.OnLastParentFolderIDChanging(value);
                this._LastParentFolderID = value;
                this.OnLastParentFolderIDChanged();
                this.OnPropertyChanged("LastParentFolderID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LastParentFolderID;
        partial void OnLastParentFolderIDChanging(string value);
        partial void OnLastParentFolderIDChanged();
        /// <summary>
        /// There are no comments for Property ResultSize in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ResultSize")]
        public virtual global::System.Nullable<int> ResultSize
        {
            get
            {
                return this._ResultSize;
            }
            set
            {
                this.OnResultSizeChanging(value);
                this._ResultSize = value;
                this.OnResultSizeChanged();
                this.OnPropertyChanged("ResultSize");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<int> _ResultSize;
        partial void OnResultSizeChanging(global::System.Nullable<int> value);
        partial void OnResultSizeChanged();
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace xmlTester.Models
{
    // 
    // This source code was auto-generated by xsd, Version=4.6.1055.0.
    // 


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("returnList", Namespace = "", IsNullable = false)]
    public partial class returnListType
    {

        private partyReturnListType partyReturnListField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public partyReturnListType partyReturnList
        {
            get
            {
                return this.partyReturnListField;
            }
            set
            {
                this.partyReturnListField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class partyReturnListType
    {

        private sectorType sectorField;

        private object[] itemsField;

        private string aBNField;

        private string entityNameField;

        private string partyIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public sectorType sector
        {
            get
            {
                return this.sectorField;
            }
            set
            {
                this.sectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("return", typeof(returnType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlElementAttribute("returnPackage", typeof(returnPackageType), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ABN
        {
            get
            {
                return this.aBNField;
            }
            set
            {
                this.aBNField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string entityName
        {
            get
            {
                return this.entityNameField;
            }
            set
            {
                this.entityNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string partyID
        {
            get
            {
                return this.partyIDField;
            }
            set
            {
                this.partyIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class sectorType
    {

        private sectorType sectorField;

        private string codeField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public sectorType sector
        {
            get
            {
                return this.sectorField;
            }
            set
            {
                this.sectorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class formType
    {

        private string codeField;

        private string nameField;

        private string precisionField;

        private yesNoType receivedDataField;

        private string reportingConsolidationField;

        private string reportingConsolidationIDField;

        private string reportingConsolidationTypeField;

        private string reportingSubField;

        private string scaleFactorField;

        private string seqNumFormField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesNoType receivedData
        {
            get
            {
                return this.receivedDataField;
            }
            set
            {
                this.receivedDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportingConsolidation
        {
            get
            {
                return this.reportingConsolidationField;
            }
            set
            {
                this.reportingConsolidationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportingConsolidationID
        {
            get
            {
                return this.reportingConsolidationIDField;
            }
            set
            {
                this.reportingConsolidationIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportingConsolidationType
        {
            get
            {
                return this.reportingConsolidationTypeField;
            }
            set
            {
                this.reportingConsolidationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reportingSub
        {
            get
            {
                return this.reportingSubField;
            }
            set
            {
                this.reportingSubField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string scaleFactor
        {
            get
            {
                return this.scaleFactorField;
            }
            set
            {
                this.scaleFactorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seqNumForm
        {
            get
            {
                return this.seqNumFormField;
            }
            set
            {
                this.seqNumFormField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum yesNoType
    {

        /// <remarks/>
        Y,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class periodType
    {

        private formType[] formField;

        private System.DateTime displayPeriodField;

        private System.DateTime dueDateField;

        private System.DateTime periodField;

        private yesNoType trusteeCertificateRequiredField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("form", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public formType[] form
        {
            get
            {
                return this.formField;
            }
            set
            {
                this.formField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime displayPeriod
        {
            get
            {
                return this.displayPeriodField;
            }
            set
            {
                this.displayPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime dueDate
        {
            get
            {
                return this.dueDateField;
            }
            set
            {
                this.dueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public yesNoType trusteeCertificateRequired
        {
            get
            {
                return this.trusteeCertificateRequiredField;
            }
            set
            {
                this.trusteeCertificateRequiredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class returnType
    {

        private periodType[] periodField;

        private string nameField;

        private string returnIdField;

        private string seqNumReturnField;

        private string versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("period", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public periodType[] period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returnId
        {
            get
            {
                return this.returnIdField;
            }
            set
            {
                this.returnIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seqNumReturn
        {
            get
            {
                return this.seqNumReturnField;
            }
            set
            {
                this.seqNumReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class returnPackageType
    {

        private returnType[] returnField;

        private string packageIdField;

        private string packageNmeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("return", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public returnType[] @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string packageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string packageNme
        {
            get
            {
                return this.packageNmeField;
            }
            set
            {
                this.packageNmeField = value;
            }
        }
    }
}
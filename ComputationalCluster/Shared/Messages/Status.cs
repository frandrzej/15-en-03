﻿namespace ComputationalCluster.Shared.Messages.StatusNamespace
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     This code was generated by a tool.
    //     Runtime Version:4.0.30319.18444
    //
    //     Changes to this file may cause incorrect behavior and will be lost if
    //     the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------

    using System.Xml.Serialization;

    // 
    // This source code was auto-generated by xsd, Version=4.0.30319.33440.
    // 

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mini.pw.edu.pl/ucc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.mini.pw.edu.pl/ucc", IsNullable = false)]
    public partial class Status : Message 
    {

        private ulong idField;

        private StatusThreadsThread[] threadsField;

        /// <remarks/>
        public ulong Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Thread", typeof(StatusThreadsThread), IsNullable = false)]
        public StatusThreadsThread[] Threads {
            get {
                return this.threadsField;
            }
            set {
                this.threadsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mini.pw.edu.pl/ucc")]
    public partial class StatusThreadsThread {

        private string stateField;

        private ulong howLongField;

        private bool howLongFieldSpecified;

        private ulong problemInstanceIdField;

        private bool problemInstanceIdFieldSpecified;

        private ulong taskIdField;

        private bool taskIdFieldSpecified;

        private string problemTypeField;

        /// <remarks/>
        public string State {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public ulong HowLong {
            get {
                return this.howLongField;
            }
            set {
                this.howLongField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HowLongSpecified {
            get {
                return this.howLongFieldSpecified;
            }
            set {
                this.howLongFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ulong ProblemInstanceId {
            get {
                return this.problemInstanceIdField;
            }
            set {
                this.problemInstanceIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProblemInstanceIdSpecified {
            get {
                return this.problemInstanceIdFieldSpecified;
            }
            set {
                this.problemInstanceIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ulong TaskId {
            get {
                return this.taskIdField;
            }
            set {
                this.taskIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaskIdSpecified
        {
            get {
                return this.taskIdFieldSpecified;
            }
            set {
                this.taskIdFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ProblemType {
            get {
                return this.problemTypeField;
            }
            set {
                this.problemTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mini.pw.edu.pl/ucc")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.mini.pw.edu.pl/ucc", IsNullable = false)]
    public partial class NewDataSet {

        private Status[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Status")]
        public Status[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeathStarClientConsole.DeathStarSupply {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SupplyItem", Namespace="http://schemas.datacontract.org/2004/07/DeathStarSupply")]
    [System.SerializableAttribute()]
    public partial class SupplyItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal PriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available {
            get {
                return this.AvailableField;
            }
            set {
                if ((this.AvailableField.Equals(value) != true)) {
                    this.AvailableField = value;
                    this.RaisePropertyChanged("Available");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeathStarSupply.ISupplyService")]
    public interface ISupplyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplyService/GetSupplies", ReplyAction="http://tempuri.org/ISupplyService/GetSuppliesResponse")]
        DeathStarClientConsole.DeathStarSupply.SupplyItem[] GetSupplies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplyService/GetSupplies", ReplyAction="http://tempuri.org/ISupplyService/GetSuppliesResponse")]
        System.Threading.Tasks.Task<DeathStarClientConsole.DeathStarSupply.SupplyItem[]> GetSuppliesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplyService/OrderItem", ReplyAction="http://tempuri.org/ISupplyService/OrderItemResponse")]
        System.DateTimeOffset OrderItem(string code, int quantity, System.DateTimeOffset requiredDate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISupplyService/OrderItem", ReplyAction="http://tempuri.org/ISupplyService/OrderItemResponse")]
        System.Threading.Tasks.Task<System.DateTimeOffset> OrderItemAsync(string code, int quantity, System.DateTimeOffset requiredDate);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISupplyServiceChannel : DeathStarClientConsole.DeathStarSupply.ISupplyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SupplyServiceClient : System.ServiceModel.ClientBase<DeathStarClientConsole.DeathStarSupply.ISupplyService>, DeathStarClientConsole.DeathStarSupply.ISupplyService {
        
        public SupplyServiceClient() {
        }
        
        public SupplyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SupplyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SupplyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DeathStarClientConsole.DeathStarSupply.SupplyItem[] GetSupplies() {
            return base.Channel.GetSupplies();
        }
        
        public System.Threading.Tasks.Task<DeathStarClientConsole.DeathStarSupply.SupplyItem[]> GetSuppliesAsync() {
            return base.Channel.GetSuppliesAsync();
        }
        
        public System.DateTimeOffset OrderItem(string code, int quantity, System.DateTimeOffset requiredDate) {
            return base.Channel.OrderItem(code, quantity, requiredDate);
        }
        
        public System.Threading.Tasks.Task<System.DateTimeOffset> OrderItemAsync(string code, int quantity, System.DateTimeOffset requiredDate) {
            return base.Channel.OrderItemAsync(code, quantity, requiredDate);
        }
    }
}
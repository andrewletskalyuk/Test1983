﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientCalculatorDuplex.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculatorService", CallbackContract=typeof(ClientCalculatorDuplex.ServiceReference1.ICalculatorServiceCallback))]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/AddTo")]
        void AddTo(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/AddTo")]
        System.Threading.Tasks.Task AddToAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/SubtructFrom")]
        void SubtructFrom(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/SubtructFrom")]
        System.Threading.Tasks.Task SubtructFromAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/DivideBy")]
        void DivideBy(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/DivideBy")]
        System.Threading.Tasks.Task DivideByAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/MultiplyBy")]
        void MultiplyBy(double value);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/MultiplyBy")]
        System.Threading.Tasks.Task MultiplyByAsync(double value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/ClearResult", ReplyAction="http://tempuri.org/ICalculatorService/ClearResultResponse")]
        void ClearResult();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/ClearResult", ReplyAction="http://tempuri.org/ICalculatorService/ClearResultResponse")]
        System.Threading.Tasks.Task ClearResultAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/Equels")]
        void Equels(double result);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalculatorService/Result")]
        void Result([System.ServiceModel.MessageParameterAttribute(Name="result")] double result1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : ClientCalculatorDuplex.ServiceReference1.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.DuplexClientBase<ClientCalculatorDuplex.ServiceReference1.ICalculatorService>, ClientCalculatorDuplex.ServiceReference1.ICalculatorService {
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void AddTo(double value) {
            base.Channel.AddTo(value);
        }
        
        public System.Threading.Tasks.Task AddToAsync(double value) {
            return base.Channel.AddToAsync(value);
        }
        
        public void SubtructFrom(double value) {
            base.Channel.SubtructFrom(value);
        }
        
        public System.Threading.Tasks.Task SubtructFromAsync(double value) {
            return base.Channel.SubtructFromAsync(value);
        }
        
        public void DivideBy(double value) {
            base.Channel.DivideBy(value);
        }
        
        public System.Threading.Tasks.Task DivideByAsync(double value) {
            return base.Channel.DivideByAsync(value);
        }
        
        public void MultiplyBy(double value) {
            base.Channel.MultiplyBy(value);
        }
        
        public System.Threading.Tasks.Task MultiplyByAsync(double value) {
            return base.Channel.MultiplyByAsync(value);
        }
        
        public void ClearResult() {
            base.Channel.ClearResult();
        }
        
        public System.Threading.Tasks.Task ClearResultAsync() {
            return base.Channel.ClearResultAsync();
        }
    }
}
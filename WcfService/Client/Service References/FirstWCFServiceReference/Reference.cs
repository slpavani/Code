﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.FirstWCFServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FirstWCFServiceReference.IFirstWCFService")]
    public interface IFirstWCFService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/Message", ReplyAction="http://tempuri.org/IFirstWCFService/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/Message", ReplyAction="http://tempuri.org/IFirstWCFService/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/add", ReplyAction="http://tempuri.org/IFirstWCFService/addResponse")]
        int add(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFirstWCFService/add", ReplyAction="http://tempuri.org/IFirstWCFService/addResponse")]
        System.Threading.Tasks.Task<int> addAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFirstWCFServiceChannel : Client.FirstWCFServiceReference.IFirstWCFService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FirstWCFServiceClient : System.ServiceModel.ClientBase<Client.FirstWCFServiceReference.IFirstWCFService>, Client.FirstWCFServiceReference.IFirstWCFService {
        
        public FirstWCFServiceClient() {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWCFServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FirstWCFServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
        
        public int add(int x, int y) {
            return base.Channel.add(x, y);
        }
        
        public System.Threading.Tasks.Task<int> addAsync(int x, int y) {
            return base.Channel.addAsync(x, y);
        }
    }
}
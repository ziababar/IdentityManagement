﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingStartedClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="ServiceReference1.IEcho")]
    public interface IEcho {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IEcho/MessageEcho", ReplyAction="http://Microsoft.ServiceModel.Samples/IEcho/MessageEchoResponse")]
        void MessageEcho([System.ServiceModel.MessageParameterAttribute(Name="messageEcho")] string messageEcho1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/IEcho/MessageEcho", ReplyAction="http://Microsoft.ServiceModel.Samples/IEcho/MessageEchoResponse")]
        System.Threading.Tasks.Task MessageEchoAsync(string messageEcho);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEchoChannel : GettingStartedClient.ServiceReference1.IEcho, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EchoClient : System.ServiceModel.ClientBase<GettingStartedClient.ServiceReference1.IEcho>, GettingStartedClient.ServiceReference1.IEcho {
        
        public EchoClient() {
        }
        
        public EchoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EchoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EchoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void MessageEcho(string messageEcho1) {
            base.Channel.MessageEcho(messageEcho1);
        }
        
        public System.Threading.Tasks.Task MessageEchoAsync(string messageEcho) {
            return base.Channel.MessageEchoAsync(messageEcho);
        }
    }
}

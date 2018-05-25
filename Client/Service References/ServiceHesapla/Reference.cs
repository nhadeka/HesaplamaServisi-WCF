﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceHesapla {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceHesapla.IHesaplamaService")]
    public interface IHesaplamaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Carpma", ReplyAction="http://tempuri.org/IHesaplamaService/CarpmaResponse")]
        double Carpma(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Carpma", ReplyAction="http://tempuri.org/IHesaplamaService/CarpmaResponse")]
        System.Threading.Tasks.Task<double> CarpmaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Bolme", ReplyAction="http://tempuri.org/IHesaplamaService/BolmeResponse")]
        double Bolme(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Bolme", ReplyAction="http://tempuri.org/IHesaplamaService/BolmeResponse")]
        System.Threading.Tasks.Task<double> BolmeAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Toplama", ReplyAction="http://tempuri.org/IHesaplamaService/ToplamaResponse")]
        double Toplama(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Toplama", ReplyAction="http://tempuri.org/IHesaplamaService/ToplamaResponse")]
        System.Threading.Tasks.Task<double> ToplamaAsync(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Cikarma", ReplyAction="http://tempuri.org/IHesaplamaService/CikarmaResponse")]
        double Cikarma(double a, double b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHesaplamaService/Cikarma", ReplyAction="http://tempuri.org/IHesaplamaService/CikarmaResponse")]
        System.Threading.Tasks.Task<double> CikarmaAsync(double a, double b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHesaplamaServiceChannel : Client.ServiceHesapla.IHesaplamaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HesaplamaServiceClient : System.ServiceModel.ClientBase<Client.ServiceHesapla.IHesaplamaService>, Client.ServiceHesapla.IHesaplamaService {
        
        public HesaplamaServiceClient() {
        }
        
        public HesaplamaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HesaplamaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HesaplamaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HesaplamaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Carpma(double a, double b) {
            return base.Channel.Carpma(a, b);
        }
        
        public System.Threading.Tasks.Task<double> CarpmaAsync(double a, double b) {
            return base.Channel.CarpmaAsync(a, b);
        }
        
        public double Bolme(double a, double b) {
            return base.Channel.Bolme(a, b);
        }
        
        public System.Threading.Tasks.Task<double> BolmeAsync(double a, double b) {
            return base.Channel.BolmeAsync(a, b);
        }
        
        public double Toplama(double a, double b) {
            return base.Channel.Toplama(a, b);
        }
        
        public System.Threading.Tasks.Task<double> ToplamaAsync(double a, double b) {
            return base.Channel.ToplamaAsync(a, b);
        }
        
        public double Cikarma(double a, double b) {
            return base.Channel.Cikarma(a, b);
        }
        
        public System.Threading.Tasks.Task<double> CikarmaAsync(double a, double b) {
            return base.Channel.CikarmaAsync(a, b);
        }
    }
}

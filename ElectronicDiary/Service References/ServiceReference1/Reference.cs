﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicDiary.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IRequests")]
    public interface IRequests {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRequests/GetStudentSchedule", ReplyAction="http://tempuri.org/IRequests/GetStudentScheduleResponse")]
        string GetStudentSchedule(string dayOfWeek, string NameOfGroup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRequests/GetStudentSchedule", ReplyAction="http://tempuri.org/IRequests/GetStudentScheduleResponse")]
        System.Threading.Tasks.Task<string> GetStudentScheduleAsync(string dayOfWeek, string NameOfGroup);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRequestsChannel : ElectronicDiary.ServiceReference1.IRequests, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RequestsClient : System.ServiceModel.ClientBase<ElectronicDiary.ServiceReference1.IRequests>, ElectronicDiary.ServiceReference1.IRequests {
        
        public RequestsClient() {
        }
        
        public RequestsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RequestsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RequestsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RequestsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetStudentSchedule(string dayOfWeek, string NameOfGroup) {
            return base.Channel.GetStudentSchedule(dayOfWeek, NameOfGroup);
        }
        
        public System.Threading.Tasks.Task<string> GetStudentScheduleAsync(string dayOfWeek, string NameOfGroup) {
            return base.Channel.GetStudentScheduleAsync(dayOfWeek, NameOfGroup);
        }
    }
}
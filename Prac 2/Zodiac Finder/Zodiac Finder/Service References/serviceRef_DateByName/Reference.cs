﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zodiac_Finder.serviceRef_DateByName {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="serviceRef_DateByName.webSvc_DateByNameSoap")]
    public interface webSvc_DateByNameSoap {
        
        // CODEGEN: Generating message contract since element name dateInterval from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindDateByZodiac", ReplyAction="*")]
        Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse FindDateByZodiac(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindDateByZodiac", ReplyAction="*")]
        System.Threading.Tasks.Task<Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse> FindDateByZodiacAsync(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindDateByZodiacRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindDateByZodiac", Namespace="http://tempuri.org/", Order=0)]
        public Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequestBody Body;
        
        public FindDateByZodiacRequest() {
        }
        
        public FindDateByZodiacRequest(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindDateByZodiacRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string dateInterval;
        
        public FindDateByZodiacRequestBody() {
        }
        
        public FindDateByZodiacRequestBody(string dateInterval) {
            this.dateInterval = dateInterval;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindDateByZodiacResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindDateByZodiacResponse", Namespace="http://tempuri.org/", Order=0)]
        public Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponseBody Body;
        
        public FindDateByZodiacResponse() {
        }
        
        public FindDateByZodiacResponse(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindDateByZodiacResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindDateByZodiacResult;
        
        public FindDateByZodiacResponseBody() {
        }
        
        public FindDateByZodiacResponseBody(string FindDateByZodiacResult) {
            this.FindDateByZodiacResult = FindDateByZodiacResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface webSvc_DateByNameSoapChannel : Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class webSvc_DateByNameSoapClient : System.ServiceModel.ClientBase<Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap>, Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap {
        
        public webSvc_DateByNameSoapClient() {
        }
        
        public webSvc_DateByNameSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public webSvc_DateByNameSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webSvc_DateByNameSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public webSvc_DateByNameSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap.FindDateByZodiac(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest request) {
            return base.Channel.FindDateByZodiac(request);
        }
        
        public string FindDateByZodiac(string dateInterval) {
            Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest inValue = new Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest();
            inValue.Body = new Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequestBody();
            inValue.Body.dateInterval = dateInterval;
            Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse retVal = ((Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap)(this)).FindDateByZodiac(inValue);
            return retVal.Body.FindDateByZodiacResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse> Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap.FindDateByZodiacAsync(Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest request) {
            return base.Channel.FindDateByZodiacAsync(request);
        }
        
        public System.Threading.Tasks.Task<Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacResponse> FindDateByZodiacAsync(string dateInterval) {
            Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest inValue = new Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequest();
            inValue.Body = new Zodiac_Finder.serviceRef_DateByName.FindDateByZodiacRequestBody();
            inValue.Body.dateInterval = dateInterval;
            return ((Zodiac_Finder.serviceRef_DateByName.webSvc_DateByNameSoap)(this)).FindDateByZodiacAsync(inValue);
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.BookPurchaseServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookPurchaseServiceReference.IBookPurchaseService")]
    public interface IBookPurchaseService {
        
        // CODEGEN: Generating message contract since the wrapper name (BookPurchaseInfo) of message BookPurchaseInfo does not match the default value (PurchaseBooks)
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/PurchaseBooks", ReplyAction="http://tempuri.org/IBookPurchaseService/PurchaseBooksResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IBookPurchaseService/PurchaseBooksExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        BookStore.BookPurchaseServiceReference.BookPurchaseResponse PurchaseBooks(BookStore.BookPurchaseServiceReference.BookPurchaseInfo request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookPurchaseService/PurchaseBooks", ReplyAction="http://tempuri.org/IBookPurchaseService/PurchaseBooksResponse")]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseResponse> PurchaseBooksAsync(BookStore.BookPurchaseServiceReference.BookPurchaseInfo request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BookPurchaseInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BookPurchaseInfo {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public float budget;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public System.Collections.Generic.Dictionary<int, int> items;
        
        public BookPurchaseInfo() {
        }
        
        public BookPurchaseInfo(float budget, System.Collections.Generic.Dictionary<int, int> items) {
            this.budget = budget;
            this.items = items;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BookPurchaseResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class BookPurchaseResponse {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public string response;
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public bool result;
        
        public BookPurchaseResponse() {
        }
        
        public BookPurchaseResponse(string response, bool result) {
            this.response = response;
            this.result = result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookPurchaseServiceChannel : BookStore.BookPurchaseServiceReference.IBookPurchaseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookPurchaseServiceClient : System.ServiceModel.ClientBase<BookStore.BookPurchaseServiceReference.IBookPurchaseService>, BookStore.BookPurchaseServiceReference.IBookPurchaseService {
        
        public BookPurchaseServiceClient() {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookPurchaseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookPurchaseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BookStore.BookPurchaseServiceReference.BookPurchaseResponse BookStore.BookPurchaseServiceReference.IBookPurchaseService.PurchaseBooks(BookStore.BookPurchaseServiceReference.BookPurchaseInfo request) {
            return base.Channel.PurchaseBooks(request);
        }
        
        public string PurchaseBooks(float budget, System.Collections.Generic.Dictionary<int, int> items, out bool result) {
            BookStore.BookPurchaseServiceReference.BookPurchaseInfo inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseInfo();
            inValue.budget = budget;
            inValue.items = items;
            BookStore.BookPurchaseServiceReference.BookPurchaseResponse retVal = ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).PurchaseBooks(inValue);
            result = retVal.result;
            return retVal.response;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseResponse> BookStore.BookPurchaseServiceReference.IBookPurchaseService.PurchaseBooksAsync(BookStore.BookPurchaseServiceReference.BookPurchaseInfo request) {
            return base.Channel.PurchaseBooksAsync(request);
        }
        
        public System.Threading.Tasks.Task<BookStore.BookPurchaseServiceReference.BookPurchaseResponse> PurchaseBooksAsync(float budget, System.Collections.Generic.Dictionary<int, int> items) {
            BookStore.BookPurchaseServiceReference.BookPurchaseInfo inValue = new BookStore.BookPurchaseServiceReference.BookPurchaseInfo();
            inValue.budget = budget;
            inValue.items = items;
            return ((BookStore.BookPurchaseServiceReference.IBookPurchaseService)(this)).PurchaseBooksAsync(inValue);
        }
    }
}

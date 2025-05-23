﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ActivityTrackerClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ActivityWebApplication", ConfigurationName="ServiceReference.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name userJSON from namespace ActivityWebApplication is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/CreateUser", ReplyAction="*")]
        ActivityTrackerClient.ServiceReference.CreateUserResponse CreateUser(ActivityTrackerClient.ServiceReference.CreateUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/CreateUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateUserResponse> CreateUserAsync(ActivityTrackerClient.ServiceReference.CreateUserRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace ActivityWebApplication is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/GetUser", ReplyAction="*")]
        ActivityTrackerClient.ServiceReference.GetUserResponse GetUser(ActivityTrackerClient.ServiceReference.GetUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/GetUser", ReplyAction="*")]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetUserResponse> GetUserAsync(ActivityTrackerClient.ServiceReference.GetUserRequest request);
        
        // CODEGEN: Generating message contract since element name activityJSON from namespace ActivityWebApplication is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/CreateActivity", ReplyAction="*")]
        ActivityTrackerClient.ServiceReference.CreateActivityResponse CreateActivity(ActivityTrackerClient.ServiceReference.CreateActivityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/CreateActivity", ReplyAction="*")]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateActivityResponse> CreateActivityAsync(ActivityTrackerClient.ServiceReference.CreateActivityRequest request);
        
        // CODEGEN: Generating message contract since element name filter from namespace ActivityWebApplication is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/GetActivities", ReplyAction="*")]
        ActivityTrackerClient.ServiceReference.GetActivitiesResponse GetActivities(ActivityTrackerClient.ServiceReference.GetActivitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/GetActivities", ReplyAction="*")]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetActivitiesResponse> GetActivitiesAsync(ActivityTrackerClient.ServiceReference.GetActivitiesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/DeleteActivity", ReplyAction="*")]
        bool DeleteActivity(int activityID);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/DeleteActivity", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> DeleteActivityAsync(int activityID);
        
        // CODEGEN: Generating message contract since element name userJSON from namespace ActivityWebApplication is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/ChangePassword", ReplyAction="*")]
        ActivityTrackerClient.ServiceReference.ChangePasswordResponse ChangePassword(ActivityTrackerClient.ServiceReference.ChangePasswordRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="ActivityWebApplication/ChangePassword", ReplyAction="*")]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.ChangePasswordResponse> ChangePasswordAsync(ActivityTrackerClient.ServiceReference.ChangePasswordRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUser", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.CreateUserRequestBody Body;
        
        public CreateUserRequest() {
        }
        
        public CreateUserRequest(ActivityTrackerClient.ServiceReference.CreateUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class CreateUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userJSON;
        
        public CreateUserRequestBody() {
        }
        
        public CreateUserRequestBody(string userJSON) {
            this.userJSON = userJSON;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateUserResponse", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.CreateUserResponseBody Body;
        
        public CreateUserResponse() {
        }
        
        public CreateUserResponse(ActivityTrackerClient.ServiceReference.CreateUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class CreateUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateUserResult;
        
        public CreateUserResponseBody() {
        }
        
        public CreateUserResponseBody(bool CreateUserResult) {
            this.CreateUserResult = CreateUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUser", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.GetUserRequestBody Body;
        
        public GetUserRequest() {
        }
        
        public GetUserRequest(ActivityTrackerClient.ServiceReference.GetUserRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class GetUserRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public GetUserRequestBody() {
        }
        
        public GetUserRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetUserResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetUserResponse", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.GetUserResponseBody Body;
        
        public GetUserResponse() {
        }
        
        public GetUserResponse(ActivityTrackerClient.ServiceReference.GetUserResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class GetUserResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetUserResult;
        
        public GetUserResponseBody() {
        }
        
        public GetUserResponseBody(string GetUserResult) {
            this.GetUserResult = GetUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateActivityRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateActivity", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.CreateActivityRequestBody Body;
        
        public CreateActivityRequest() {
        }
        
        public CreateActivityRequest(ActivityTrackerClient.ServiceReference.CreateActivityRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class CreateActivityRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string activityJSON;
        
        public CreateActivityRequestBody() {
        }
        
        public CreateActivityRequestBody(int userID, string activityJSON) {
            this.userID = userID;
            this.activityJSON = activityJSON;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CreateActivityResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CreateActivityResponse", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.CreateActivityResponseBody Body;
        
        public CreateActivityResponse() {
        }
        
        public CreateActivityResponse(ActivityTrackerClient.ServiceReference.CreateActivityResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class CreateActivityResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool CreateActivityResult;
        
        public CreateActivityResponseBody() {
        }
        
        public CreateActivityResponseBody(bool CreateActivityResult) {
            this.CreateActivityResult = CreateActivityResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetActivitiesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetActivities", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.GetActivitiesRequestBody Body;
        
        public GetActivitiesRequest() {
        }
        
        public GetActivitiesRequest(ActivityTrackerClient.ServiceReference.GetActivitiesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class GetActivitiesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int userID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string filter;
        
        public GetActivitiesRequestBody() {
        }
        
        public GetActivitiesRequestBody(int userID, string filter) {
            this.userID = userID;
            this.filter = filter;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetActivitiesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetActivitiesResponse", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.GetActivitiesResponseBody Body;
        
        public GetActivitiesResponse() {
        }
        
        public GetActivitiesResponse(ActivityTrackerClient.ServiceReference.GetActivitiesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class GetActivitiesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetActivitiesResult;
        
        public GetActivitiesResponseBody() {
        }
        
        public GetActivitiesResponseBody(string GetActivitiesResult) {
            this.GetActivitiesResult = GetActivitiesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangePasswordRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangePassword", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.ChangePasswordRequestBody Body;
        
        public ChangePasswordRequest() {
        }
        
        public ChangePasswordRequest(ActivityTrackerClient.ServiceReference.ChangePasswordRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class ChangePasswordRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userJSON;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string newPassword;
        
        public ChangePasswordRequestBody() {
        }
        
        public ChangePasswordRequestBody(string userJSON, string newPassword) {
            this.userJSON = userJSON;
            this.newPassword = newPassword;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ChangePasswordResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ChangePasswordResponse", Namespace="ActivityWebApplication", Order=0)]
        public ActivityTrackerClient.ServiceReference.ChangePasswordResponseBody Body;
        
        public ChangePasswordResponse() {
        }
        
        public ChangePasswordResponse(ActivityTrackerClient.ServiceReference.ChangePasswordResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="ActivityWebApplication")]
    public partial class ChangePasswordResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool ChangePasswordResult;
        
        public ChangePasswordResponseBody() {
        }
        
        public ChangePasswordResponseBody(bool ChangePasswordResult) {
            this.ChangePasswordResult = ChangePasswordResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : ActivityTrackerClient.ServiceReference.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<ActivityTrackerClient.ServiceReference.WebServiceSoap>, ActivityTrackerClient.ServiceReference.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTrackerClient.ServiceReference.CreateUserResponse ActivityTrackerClient.ServiceReference.WebServiceSoap.CreateUser(ActivityTrackerClient.ServiceReference.CreateUserRequest request) {
            return base.Channel.CreateUser(request);
        }
        
        public bool CreateUser(string userJSON) {
            ActivityTrackerClient.ServiceReference.CreateUserRequest inValue = new ActivityTrackerClient.ServiceReference.CreateUserRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.CreateUserRequestBody();
            inValue.Body.userJSON = userJSON;
            ActivityTrackerClient.ServiceReference.CreateUserResponse retVal = ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).CreateUser(inValue);
            return retVal.Body.CreateUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateUserResponse> ActivityTrackerClient.ServiceReference.WebServiceSoap.CreateUserAsync(ActivityTrackerClient.ServiceReference.CreateUserRequest request) {
            return base.Channel.CreateUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateUserResponse> CreateUserAsync(string userJSON) {
            ActivityTrackerClient.ServiceReference.CreateUserRequest inValue = new ActivityTrackerClient.ServiceReference.CreateUserRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.CreateUserRequestBody();
            inValue.Body.userJSON = userJSON;
            return ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).CreateUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTrackerClient.ServiceReference.GetUserResponse ActivityTrackerClient.ServiceReference.WebServiceSoap.GetUser(ActivityTrackerClient.ServiceReference.GetUserRequest request) {
            return base.Channel.GetUser(request);
        }
        
        public string GetUser(string email, string password) {
            ActivityTrackerClient.ServiceReference.GetUserRequest inValue = new ActivityTrackerClient.ServiceReference.GetUserRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.GetUserRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            ActivityTrackerClient.ServiceReference.GetUserResponse retVal = ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).GetUser(inValue);
            return retVal.Body.GetUserResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetUserResponse> ActivityTrackerClient.ServiceReference.WebServiceSoap.GetUserAsync(ActivityTrackerClient.ServiceReference.GetUserRequest request) {
            return base.Channel.GetUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetUserResponse> GetUserAsync(string email, string password) {
            ActivityTrackerClient.ServiceReference.GetUserRequest inValue = new ActivityTrackerClient.ServiceReference.GetUserRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.GetUserRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).GetUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTrackerClient.ServiceReference.CreateActivityResponse ActivityTrackerClient.ServiceReference.WebServiceSoap.CreateActivity(ActivityTrackerClient.ServiceReference.CreateActivityRequest request) {
            return base.Channel.CreateActivity(request);
        }
        
        public bool CreateActivity(int userID, string activityJSON) {
            ActivityTrackerClient.ServiceReference.CreateActivityRequest inValue = new ActivityTrackerClient.ServiceReference.CreateActivityRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.CreateActivityRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.activityJSON = activityJSON;
            ActivityTrackerClient.ServiceReference.CreateActivityResponse retVal = ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).CreateActivity(inValue);
            return retVal.Body.CreateActivityResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateActivityResponse> ActivityTrackerClient.ServiceReference.WebServiceSoap.CreateActivityAsync(ActivityTrackerClient.ServiceReference.CreateActivityRequest request) {
            return base.Channel.CreateActivityAsync(request);
        }
        
        public System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.CreateActivityResponse> CreateActivityAsync(int userID, string activityJSON) {
            ActivityTrackerClient.ServiceReference.CreateActivityRequest inValue = new ActivityTrackerClient.ServiceReference.CreateActivityRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.CreateActivityRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.activityJSON = activityJSON;
            return ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).CreateActivityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTrackerClient.ServiceReference.GetActivitiesResponse ActivityTrackerClient.ServiceReference.WebServiceSoap.GetActivities(ActivityTrackerClient.ServiceReference.GetActivitiesRequest request) {
            return base.Channel.GetActivities(request);
        }
        
        public string GetActivities(int userID, string filter) {
            ActivityTrackerClient.ServiceReference.GetActivitiesRequest inValue = new ActivityTrackerClient.ServiceReference.GetActivitiesRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.GetActivitiesRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.filter = filter;
            ActivityTrackerClient.ServiceReference.GetActivitiesResponse retVal = ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).GetActivities(inValue);
            return retVal.Body.GetActivitiesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetActivitiesResponse> ActivityTrackerClient.ServiceReference.WebServiceSoap.GetActivitiesAsync(ActivityTrackerClient.ServiceReference.GetActivitiesRequest request) {
            return base.Channel.GetActivitiesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.GetActivitiesResponse> GetActivitiesAsync(int userID, string filter) {
            ActivityTrackerClient.ServiceReference.GetActivitiesRequest inValue = new ActivityTrackerClient.ServiceReference.GetActivitiesRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.GetActivitiesRequestBody();
            inValue.Body.userID = userID;
            inValue.Body.filter = filter;
            return ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).GetActivitiesAsync(inValue);
        }
        
        public bool DeleteActivity(int activityID) {
            return base.Channel.DeleteActivity(activityID);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteActivityAsync(int activityID) {
            return base.Channel.DeleteActivityAsync(activityID);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ActivityTrackerClient.ServiceReference.ChangePasswordResponse ActivityTrackerClient.ServiceReference.WebServiceSoap.ChangePassword(ActivityTrackerClient.ServiceReference.ChangePasswordRequest request) {
            return base.Channel.ChangePassword(request);
        }
        
        public bool ChangePassword(string userJSON, string newPassword) {
            ActivityTrackerClient.ServiceReference.ChangePasswordRequest inValue = new ActivityTrackerClient.ServiceReference.ChangePasswordRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.ChangePasswordRequestBody();
            inValue.Body.userJSON = userJSON;
            inValue.Body.newPassword = newPassword;
            ActivityTrackerClient.ServiceReference.ChangePasswordResponse retVal = ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).ChangePassword(inValue);
            return retVal.Body.ChangePasswordResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.ChangePasswordResponse> ActivityTrackerClient.ServiceReference.WebServiceSoap.ChangePasswordAsync(ActivityTrackerClient.ServiceReference.ChangePasswordRequest request) {
            return base.Channel.ChangePasswordAsync(request);
        }
        
        public System.Threading.Tasks.Task<ActivityTrackerClient.ServiceReference.ChangePasswordResponse> ChangePasswordAsync(string userJSON, string newPassword) {
            ActivityTrackerClient.ServiceReference.ChangePasswordRequest inValue = new ActivityTrackerClient.ServiceReference.ChangePasswordRequest();
            inValue.Body = new ActivityTrackerClient.ServiceReference.ChangePasswordRequestBody();
            inValue.Body.userJSON = userJSON;
            inValue.Body.newPassword = newPassword;
            return ((ActivityTrackerClient.ServiceReference.WebServiceSoap)(this)).ChangePasswordAsync(inValue);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReferencePostComment
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/Lab5_Client", IsReference=true)]
    public partial class Post : object
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public System.DateTime Date { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/Lab5_Client", IsReference=true)]
    public partial class Comment : object
    {
        public int CommentId { get; set; }
        public int PostPostId { get; set; }
        public string Text { get; set; }

        public virtual Post Post { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferencePostComment.IPostCommentService")]
    public interface IPostCommentService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.AddPostResponse> AddPostAsync(ServiceReferencePostComment.AddPostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.UpdatePostResponse> UpdatePostAsync(ServiceReferencePostComment.UpdatePostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.DeletePostResponse> DeletePostAsync(ServiceReferencePostComment.DeletePostRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.GetPostByIdResponse> GetPostByIdAsync(ServiceReferencePostComment.GetPostByIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.GetPostsResponse> GetPostsAsync(ServiceReferencePostComment.GetPostsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.AddCommentResponse> AddCommentAsync(ServiceReferencePostComment.AddCommentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.UpdateCommentResponse> UpdateCommentAsync(ServiceReferencePostComment.UpdateCommentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
        System.Threading.Tasks.Task<ServiceReferencePostComment.GetCommentByIdResponse> GetCommentByIdAsync(ServiceReferencePostComment.GetCommentByIdRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddPost", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddPostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Post post;
        
        public AddPostRequest()
        {
        }
        
        public AddPostRequest(ServiceReferencePostComment.Post post)
        {
            this.post = post;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddPostResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddPostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AddPostResult;
        
        public AddPostResponse()
        {
        }
        
        public AddPostResponse(bool AddPostResult)
        {
            this.AddPostResult = AddPostResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdatePost", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdatePostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Post post;
        
        public UpdatePostRequest()
        {
        }
        
        public UpdatePostRequest(ServiceReferencePostComment.Post post)
        {
            this.post = post;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdatePostResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdatePostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Post UpdatePostResult;
        
        public UpdatePostResponse()
        {
        }
        
        public UpdatePostResponse(ServiceReferencePostComment.Post UpdatePostResult)
        {
            this.UpdatePostResult = UpdatePostResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeletePost", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeletePostRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        public DeletePostRequest()
        {
        }
        
        public DeletePostRequest(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeletePostResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DeletePostResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int DeletePostResult;
        
        public DeletePostResponse()
        {
        }
        
        public DeletePostResponse(int DeletePostResult)
        {
            this.DeletePostResult = DeletePostResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPostById", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPostByIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        public GetPostByIdRequest()
        {
        }
        
        public GetPostByIdRequest(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPostByIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPostByIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Post GetPostByIdResult;
        
        public GetPostByIdResponse()
        {
        }
        
        public GetPostByIdResponse(ServiceReferencePostComment.Post GetPostByIdResult)
        {
            this.GetPostByIdResult = GetPostByIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPosts", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPostsRequest
    {
        
        public GetPostsRequest()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetPostsResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetPostsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public System.Collections.Generic.List<ServiceReferencePostComment.Post> GetPostsResult;
        
        public GetPostsResponse()
        {
        }
        
        public GetPostsResponse(System.Collections.Generic.List<ServiceReferencePostComment.Post> GetPostsResult)
        {
            this.GetPostsResult = GetPostsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddComment", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddCommentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Comment comment;
        
        public AddCommentRequest()
        {
        }
        
        public AddCommentRequest(ServiceReferencePostComment.Comment comment)
        {
            this.comment = comment;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddCommentResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddCommentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public bool AddCommentResult;
        
        public AddCommentResponse()
        {
        }
        
        public AddCommentResponse(bool AddCommentResult)
        {
            this.AddCommentResult = AddCommentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateComment", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateCommentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Comment newComment;
        
        public UpdateCommentRequest()
        {
        }
        
        public UpdateCommentRequest(ServiceReferencePostComment.Comment newComment)
        {
            this.newComment = newComment;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateCommentResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class UpdateCommentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Comment UpdateCommentResult;
        
        public UpdateCommentResponse()
        {
        }
        
        public UpdateCommentResponse(ServiceReferencePostComment.Comment UpdateCommentResult)
        {
            this.UpdateCommentResult = UpdateCommentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCommentById", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCommentByIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int id;
        
        public GetCommentByIdRequest()
        {
        }
        
        public GetCommentByIdRequest(int id)
        {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetCommentByIdResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetCommentByIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public ServiceReferencePostComment.Comment GetCommentByIdResult;
        
        public GetCommentByIdResponse()
        {
        }
        
        public GetCommentByIdResponse(ServiceReferencePostComment.Comment GetCommentByIdResult)
        {
            this.GetCommentByIdResult = GetCommentByIdResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPostCommentServiceChannel : ServiceReferencePostComment.IPostCommentService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PostCommentServiceClient : System.ServiceModel.ClientBase<ServiceReferencePostComment.IPostCommentService>, ServiceReferencePostComment.IPostCommentService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PostCommentServiceClient() : 
                base(PostCommentServiceClient.GetDefaultBinding(), PostCommentServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPostComment.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PostCommentServiceClient.GetBindingForEndpoint(endpointConfiguration), PostCommentServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PostCommentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PostCommentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.AddPostResponse> AddPostAsync(ServiceReferencePostComment.AddPostRequest request)
        {
            return base.Channel.AddPostAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.UpdatePostResponse> UpdatePostAsync(ServiceReferencePostComment.UpdatePostRequest request)
        {
            return base.Channel.UpdatePostAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.DeletePostResponse> DeletePostAsync(ServiceReferencePostComment.DeletePostRequest request)
        {
            return base.Channel.DeletePostAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.GetPostByIdResponse> GetPostByIdAsync(ServiceReferencePostComment.GetPostByIdRequest request)
        {
            return base.Channel.GetPostByIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.GetPostsResponse> GetPostsAsync(ServiceReferencePostComment.GetPostsRequest request)
        {
            return base.Channel.GetPostsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.AddCommentResponse> AddCommentAsync(ServiceReferencePostComment.AddCommentRequest request)
        {
            return base.Channel.AddCommentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.UpdateCommentResponse> UpdateCommentAsync(ServiceReferencePostComment.UpdateCommentRequest request)
        {
            return base.Channel.UpdateCommentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceReferencePostComment.GetCommentByIdResponse> GetCommentByIdAsync(ServiceReferencePostComment.GetCommentByIdRequest request)
        {
            return base.Channel.GetCommentByIdAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPostComment))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8000/PC");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PostCommentServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PostCommentServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPostComment);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPostComment,
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5_Client
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/Lab5_Client", IsReference=true)]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/Lab5_Client", IsReference=true)]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPostCommentService")]
public interface IPostCommentService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
    bool AddPost(Lab5_Client.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
    System.Threading.Tasks.Task<bool> AddPostAsync(Lab5_Client.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
    Lab5_Client.Post UpdatePost(Lab5_Client.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
    System.Threading.Tasks.Task<Lab5_Client.Post> UpdatePostAsync(Lab5_Client.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
    int DeletePost(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
    System.Threading.Tasks.Task<int> DeletePostAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
    Lab5_Client.Post GetPostById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
    System.Threading.Tasks.Task<Lab5_Client.Post> GetPostByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
    Lab5_Client.Post[] GetPosts();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
    System.Threading.Tasks.Task<Lab5_Client.Post[]> GetPostsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
    bool AddComment(Lab5_Client.Comment comment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
    System.Threading.Tasks.Task<bool> AddCommentAsync(Lab5_Client.Comment comment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
    Lab5_Client.Comment UpdateComment(Lab5_Client.Comment newComment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
    System.Threading.Tasks.Task<Lab5_Client.Comment> UpdateCommentAsync(Lab5_Client.Comment newComment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
    Lab5_Client.Comment GetCommentById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
    System.Threading.Tasks.Task<Lab5_Client.Comment> GetCommentByIdAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPostCommentServiceChannel : IPostCommentService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PostCommentServiceClient : System.ServiceModel.ClientBase<IPostCommentService>, IPostCommentService
{
    
    public PostCommentServiceClient()
    {
    }
    
    public PostCommentServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PostCommentServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostCommentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostCommentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool AddPost(Lab5_Client.Post post)
    {
        return base.Channel.AddPost(post);
    }
    
    public System.Threading.Tasks.Task<bool> AddPostAsync(Lab5_Client.Post post)
    {
        return base.Channel.AddPostAsync(post);
    }
    
    public Lab5_Client.Post UpdatePost(Lab5_Client.Post post)
    {
        return base.Channel.UpdatePost(post);
    }
    
    public System.Threading.Tasks.Task<Lab5_Client.Post> UpdatePostAsync(Lab5_Client.Post post)
    {
        return base.Channel.UpdatePostAsync(post);
    }
    
    public int DeletePost(int id)
    {
        return base.Channel.DeletePost(id);
    }
    
    public System.Threading.Tasks.Task<int> DeletePostAsync(int id)
    {
        return base.Channel.DeletePostAsync(id);
    }
    
    public Lab5_Client.Post GetPostById(int id)
    {
        return base.Channel.GetPostById(id);
    }
    
    public System.Threading.Tasks.Task<Lab5_Client.Post> GetPostByIdAsync(int id)
    {
        return base.Channel.GetPostByIdAsync(id);
    }
    
    public Lab5_Client.Post[] GetPosts()
    {
        return base.Channel.GetPosts();
    }
    
    public System.Threading.Tasks.Task<Lab5_Client.Post[]> GetPostsAsync()
    {
        return base.Channel.GetPostsAsync();
    }
    
    public bool AddComment(Lab5_Client.Comment comment)
    {
        return base.Channel.AddComment(comment);
    }
    
    public System.Threading.Tasks.Task<bool> AddCommentAsync(Lab5_Client.Comment comment)
    {
        return base.Channel.AddCommentAsync(comment);
    }
    
    public Lab5_Client.Comment UpdateComment(Lab5_Client.Comment newComment)
    {
        return base.Channel.UpdateComment(newComment);
    }
    
    public System.Threading.Tasks.Task<Lab5_Client.Comment> UpdateCommentAsync(Lab5_Client.Comment newComment)
    {
        return base.Channel.UpdateCommentAsync(newComment);
    }
    
    public Lab5_Client.Comment GetCommentById(int id)
    {
        return base.Channel.GetCommentById(id);
    }
    
    public System.Threading.Tasks.Task<Lab5_Client.Comment> GetCommentByIdAsync(int id)
    {
        return base.Channel.GetCommentByIdAsync(id);
    }
}

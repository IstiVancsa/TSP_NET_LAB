using Lab5_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Lab5_Server
{
    [ServiceContract]
    interface InterfacePost
    {
        [OperationContract]
        bool AddPost(Post post);
        [OperationContract]
        Post UpdatePost(Post post);
        [OperationContract]
        int DeletePost(int id);
        [OperationContract]
        Post GetPostById(int id);
        [OperationContract]
        List<Post> GetPosts();
    }
    [ServiceContract]
    interface InterfaceComment
    {
        [OperationContract]
        bool AddComment(Comment comment);
        [OperationContract]
        Comment UpdateComment(Comment newComment);
        [OperationContract]
        Comment GetCommentById(int id);
    }
    [ServiceContract]
    interface IPostCommentService : InterfacePost, InterfaceComment
    {
    }
}

using Grpc.Net.Client;
using GRPCServer.Protos;
using System;
using System.Threading.Tasks;

namespace GRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var postCommentClient = new PostComment.PostCommentClient(channel);
            #region GetAllComments
            using (var call = postCommentClient.GetComments(new CommentEmptyModel()))
            {
                while (await call.ResponseStream.MoveNext(new System.Threading.CancellationToken()))
                {
                    var currentComment = call.ResponseStream.Current;
                    Console.WriteLine($"{currentComment.CommentId} { currentComment.Text} { currentComment.PostPostId}");
                }
            }
            #endregion
            #region GetAllPosts
            using (var call = postCommentClient.GetPosts(new PostEmptyModel()))
            {
                while (await call.ResponseStream.MoveNext(new System.Threading.CancellationToken()))
                {
                    var currentPost = call.ResponseStream.Current;
                    Console.WriteLine($"{currentPost.PostId} { currentPost.Domain} { currentPost.Description} {currentPost.Date}");
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}

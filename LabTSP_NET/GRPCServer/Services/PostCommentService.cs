using Grpc.Core;
using GRPCServer.Protos;
using Lab5_Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace GRPCServer.Services
{
    public class PostCommentService : PostComment.PostCommentBase
    {
        private readonly ILogger<PostCommentService> _logger;
        public PostCommentService(ILogger<PostCommentService> logger)
        {
            this._logger = logger;
        }
        public override Task<CommentEmptyModel> AddComment(CommentEmptyModel request, ServerCallContext context)
        {
            Comment comment = new Comment();
            comment.AddComment();

            CommentEmptyModel output = new CommentEmptyModel();
            return Task.FromResult(output);
        }
        public override Task<PostEmptyModel> AddPost(PostEmptyModel request, ServerCallContext context)
        {
            Post post = new Post();
            post.AddPost();

            PostEmptyModel output = new PostEmptyModel();
            return Task.FromResult(output);
        }
        public override Task<CommentEmptyModel> DeleteComment(CommentIdModel request, ServerCallContext context)
        {
            return base.DeleteComment(request, context);
        }
        public override Task<PostEmptyModel> DeletePost(PostIdModel request, ServerCallContext context)
        {
            Post post = new Post();
            post.DeletePost(request.PostId);

            PostEmptyModel output = new PostEmptyModel();
            return Task.FromResult(output);
        }
        public override Task<CommentFullModel> GetCommentById(CommentIdModel request, ServerCallContext context)
        {
            Comment comment = new Comment();
            var result = comment.GetCommentById(request.CommentId);

            CommentFullModel output = new CommentFullModel();
            output.CommentId = result.CommentId;
            output.PostPostId = result.PostPostId;
            output.Text = result.Text;
            return Task.FromResult(output);
        }
        public override Task<PostFullModel> GetPostById(PostIdModel request, ServerCallContext context)
        {
            Post post = new Post();
            var result = post.GetPostById(request.PostId);

            PostFullModel output = new PostFullModel();
            output.PostId = result.PostId;
            output.Domain = result.Domain;
            output.Description = result.Description;
            output.Date = result.Date.ToString();
            foreach (var comment in result.Comments)
            {
                output.Comments.Add(new CommentFullModel
                {
                    CommentId = comment.CommentId,
                    PostPostId = comment.PostPostId,
                    Text = comment.Text
                });
            }
            return Task.FromResult(output);
        }
        public override async Task GetComments(CommentEmptyModel request, IServerStreamWriter<CommentFullModel> responseStream, ServerCallContext context)
        {
            Comment comment = new Comment();
            var comments = comment.GetAllComments();
            foreach (var currentComment in comments)
            {
                await responseStream.WriteAsync(new CommentFullModel
                {
                    CommentId = currentComment.CommentId,
                    PostPostId = currentComment.PostPostId,
                    Text = currentComment.Text
                });
            }
        }
        public override async Task GetPosts(PostEmptyModel request, IServerStreamWriter<PostFullModel> responseStream, ServerCallContext context)
        {
            Post post = new Post();
            var posts = post.GetAllPosts();
            foreach (var currentPost in posts)
            {
                var result = new PostFullModel
                {
                    PostId = currentPost.PostId,
                    Date = currentPost.Date.ToString(),
                    Description = currentPost.Description,
                    Domain = currentPost.Domain
                };
                foreach (var currentComment in currentPost.Comments)
                {
                    result.Comments.Add(new CommentFullModel
                    {
                        CommentId = currentComment.CommentId,
                        PostPostId = currentComment.PostPostId,
                        Text = currentComment.Text
                    });
                }
                await responseStream.WriteAsync(result);
            }
        }
        public override Task<CommentEmptyModel> UpdateComment(CommentFullModel request, ServerCallContext context)
        {
            Comment comment = new Comment();
            Post post = new Post();
            var result = post.GetPostById(request.PostPostId);
            comment.UpdateComment(new Comment
            {
                CommentId = request.CommentId,
                Text = request.Text,
                PostPostId = request.PostPostId,
                Post = result
            });

            CommentEmptyModel output = new CommentEmptyModel();
            return Task.FromResult(output);
        }
        public override Task<PostEmptyModel> UpdatePost(PostFullModel request, ServerCallContext context)
        {
            Comment comment = new Comment();
            Post post = new Post();
            var result = post.GetPostById(request.PostId);
            DateTime formatted = DateTime.ParseExact(request.Date,
                             "M/d/yyyy h:mm:ss tt",
                             CultureInfo.InvariantCulture);
            var postComments = new List<Comment>();
            foreach (var currentComment in request.Comments)
            {
                var currentPost = post.GetPostById(currentComment.PostPostId);
                postComments.Add(new Comment
                {
                    CommentId = currentComment.CommentId,
                    Text = currentComment.Text,
                    PostPostId = currentComment.PostPostId,
                    Post = currentPost
                });
            }
            post.UpdatePost(new Post
            {
                Date = formatted,
                PostId = request.PostId,
                Comments = postComments,
                Description = request.Description,
                Domain = request.Domain
            });

            PostEmptyModel output = new PostEmptyModel();
            return Task.FromResult(output);
        }
    }
}

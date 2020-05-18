using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Vancsa_Istvan_Rp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace Asp_Vancsa_Istvan_Rp.Comments
{
    public class CreateModel : PageModel
    {
        PostCommentServiceClient pcc = new PostCommentServiceClient();
        public CreateModel()
        {
            CommentDTO = new CommentDTO();
        }
        [BindProperty] public CommentDTO CommentDTO { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id.HasValue)
            {
                var itemPost = await pcc.GetPostByIdAsync(new GetPostByIdRequest(id.Value));
                ViewData["id"] = id.Value.ToString() + " : " + itemPost.GetPostByIdResult.Description;
                CommentDTO.PostPostId = id.Value;
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (!ModelState.IsValid) { return Page(); }
            Comment comment = new Comment(); 
            int postId = 0; postId = id.Value; 
            comment.PostPostId = postId; 
            comment.Text = CommentDTO.Text; 
            var result = await pcc.AddCommentAsync(new AddCommentRequest(comment)); 
            if (result != null) 
            { 
                return RedirectToAction("Error"); 
            } 
            return RedirectToPage("/Posts/Index"); }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Vancsa_Istvan_Rp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;

namespace Asp_Vancsa_Istvan_Rp.Posts
{
    public class DeleteModel : PageModel
    {
        PostCommentServiceClient pcc = new PostCommentServiceClient();
        [BindProperty] 
        public PostDTO PostDTO { get; set; }
        public DeleteModel() { }
        public async Task<IActionResult> OnGetAsync(int? id) 
        { 
            if (id == null) return NotFound(); 
            var post = await pcc.GetPostByIdAsync(new GetPostByIdRequest { id = id.Value }); 
            if (post != null) 
            { 
                PostDTO = new PostDTO();
                PostDTO.PostId = post.GetPostByIdResult.PostId; 
                PostDTO.Domain = post.GetPostByIdResult.Domain; 
                PostDTO.Description = post.GetPostByIdResult.Description; 
                PostDTO.Date = post.GetPostByIdResult.Date; return Page(); 
            } 
            else 
                return NotFound(); }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) 
            { 
                return NotFound(); 
            } 
            try 
            { 
                var result = await pcc.DeletePostAsync(new DeletePostRequest(id.Value)); 
            } catch(Exception ex) 
            { 
                return RedirectToPage("/Error"); 
            } 
            return RedirectToPage("./Index"); }
        }
}

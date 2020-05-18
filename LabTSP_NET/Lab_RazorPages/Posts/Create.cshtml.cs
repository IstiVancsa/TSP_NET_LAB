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
    public class CreateModel : PageModel
    {
        [BindProperty]
        public PostDTO PostDTO { get; set; }
        PostCommentServiceClient pcc = new PostCommentServiceClient();
        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Post post = new Post();
            post.Domain = PostDTO.Domain;
            post.Description = PostDTO.Description;
            post.Date = PostDTO.Date;
            var result = await pcc.AddPostAsync(new AddPostRequest(post));
            if (result == null)
            {
                return RedirectToAction("Error");
            }
            return RedirectToPage("./Index");
        }
    }
}

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
    public class ListModel : PageModel
    {
        PostCommentServiceClient pcc = new PostCommentServiceClient(); 
        public List<CommentDTO> Comments { get; set; }
        public ListModel() { Comments = new List<CommentDTO>(); }
        public async Task OnGetAsync(int? id) 
        { if (!id.HasValue) 
                return; 
            var item = await pcc.GetPostByIdAsync(new GetPostByIdRequest(id.Value)); 
            ViewData["Post"] = item.GetPostByIdResult.PostId.ToString() + " : " + item.GetPostByIdResult.Description.Trim(); 
            foreach (var cc in item.GetPostByIdResult.Comments) 
            { 
                CommentDTO cdto = new CommentDTO(); 
                cdto.PostPostId = cc.PostPostId; 
                cdto.Text = cc.Text; 
                cdto.CommentId = cc.CommentId; 
                Comments.Add(cdto); } }
    }
}

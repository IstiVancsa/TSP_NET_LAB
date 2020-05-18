using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Vancsa_Istvan_Rp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferencePostComment;

namespace Lab_RazorPages.Pages
{
    public class IndexModel : PageModel
    {
        PostCommentServiceClient pcc = new PostCommentServiceClient();
        public List<PostDTO> Posts { get; set; }
        public IndexModel() { Posts = new List<PostDTO>(); }
        public async Task OnGetAsync()
        {
            var posts = (await pcc.GetPostsAsync(new GetPostsRequest()));
            foreach (var item in posts.GetPostsResult)
            {
                //Fisierele nu s-au generat corect
                //Post si Comment sunt 2 fis goale
                PostDTO pd = new PostDTO(); 
                pd.Description = item.Description; 
                pd.PostId = item.PostId; 
                pd.Domain = item.Domain; 
                pd.Date = item.Date; 
                foreach (var cc in item.Comments) 
                { CommentDTO cdto = new CommentDTO(); 
                    cdto.PostPostId = cc.PostPostId; 
                    cdto.Text = cc.Text;
                    pd.Comments.Add(cdto); 
                }
                Posts.Add(pd);
            }
        }
    }
}

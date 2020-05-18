using ServiceReferencePostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Vancsa_Istvan_Rp.Models
{
    public class CommentDTO
    {
        public int CommentId { get; set; }
        public int PostPostId { get; set; }
        public string Text { get; set; }

        public virtual PostDTO Post { get; set; }
    }
}

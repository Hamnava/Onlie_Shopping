using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class CommentsForProductViewModel
    {
        public string userfullName { get; set; }
        public DateTime CreateCommentdate { get; set; }
        public byte IslikeProduct { get; set; }
        public string commentTitle { get; set; }
        public string CommentDescription { get; set; }
        public int CommentLike { get; set; }
        public int CommentDislike { get; set; }
    }
}

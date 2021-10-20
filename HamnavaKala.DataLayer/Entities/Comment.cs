using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Display(Name = " عنوان نظر ")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string CommentTitle { get; set; }

        [Display(Name = " توضیحات نظر ")]
        [MaxLength(500, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(10, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string CommentDescription { get; set; }
        public int CommentLike { get; set; }
        public int CommentDeslike { get; set; }
        public byte Recommend { get; set; }
        public bool IsActive { get; set; }
        public DateTime CommentCreate { get; set; }
        public int productId { get; set; }
        public int userId { get; set; }

        #region Relation ship
        [ForeignKey("productId")]
        public Product product { get; set; }
        [ForeignKey("userId")]
        public User User { get; set; }
        #endregion
    }
}

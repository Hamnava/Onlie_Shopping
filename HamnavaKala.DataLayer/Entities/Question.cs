using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class Question
    {
        [Key]
        public int QuestionId { get; set; }

        [Display(Name = " توضیحات سوال ")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string QuestionDescription { get; set; }
        public DateTime QCreate { get; set; }
        public bool IsActive { get; set; }
        public int userId { get; set; }
        public int productId { get; set; }

        #region Relations to other 
        [ForeignKey("userId")]
        public User User { get; set; }
        [ForeignKey("productId")]
        public Product Product { get; set; }
        #endregion
    }
}

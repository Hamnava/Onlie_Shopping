using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class AnswerQ
    {
        [Key]
        public int AnswerId { get; set; }

        [Display(Name = "جواب سوال")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string AnswerDescription { get; set; }
        public DateTime AnswerDate { get; set; }
        public int userid { get; set; }
        public int QuestionId { get; set; }
        #region Relations
        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
        [ForeignKey("userid")]
        public User User { get; set; }
        #endregion
    }
}

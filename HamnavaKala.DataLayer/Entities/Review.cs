using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Display(Name = "توضیحات محصول ")]
        public string ReviewDescription { get; set; }

        [Display(Name = "نقات ضعف ")]
        [MaxLength(1000, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        public string ReviewNegative { get; set; }

        [Display(Name = "نقات قوت ")]
        [MaxLength(1000, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        public string ReviewPositive { get; set; }

        [Display(Name = "عنوان مقاله ")]
        [MaxLength(2000, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        public string ArticleTitle { get; set; }

        [Display(Name = "توضیحات مقاله ")]
        public string ArticleDescription { get; set; }


        //Relation with product
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}

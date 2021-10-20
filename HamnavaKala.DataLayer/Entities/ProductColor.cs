using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductColor
    {
        [Key]
        public int productColorId { get; set; }

        [Display(Name = "نام رنگ")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string colorName { get; set; }

        [Display(Name = "کد رنگ")]
        [MaxLength(20, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(6, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string colorCode { get; set; }

        #region Relations
        public List<ProductPrice> productPrices { get; set; }
        #endregion


    }
}

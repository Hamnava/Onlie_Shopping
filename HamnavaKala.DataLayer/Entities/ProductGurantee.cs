using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductGurantee
    {
        [Key]
        public int GuranteeId { get; set; }
        [Display(Name = "نام گارانتی ")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string GuranteeName { get; set; }

        #region Relations to other table
        public List<ProductPrice> productPrices { get; set; }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductPrice
    {
        [Key]
        public int ProductpriceId { get; set; }

        [Display(Name = " قیمت اصلی ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int mainPrice { get; set; }

        [Display(Name = " قیمت ویژه ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int specialprice { get; set; }

        [Display(Name = "  تعداد کالا ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int count { get; set; }

        [Display(Name = "تعداد خرید کاربر ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int maxorderCount { get; set; }


        public DateTime CteateDate { get; set; }
        public DateTime EndDateDiscount { get; set; }
        public int productColor { get; set; }
        public int productGurantee { get; set; }
        public int ProductId { get; set; }

        #region Relations to other tables
        [ForeignKey("ProductId")]
        public Product product { get; set; }
        [ForeignKey("productColor")]
        public ProductColor ProductColor { get; set; }
        [ForeignKey("productGurantee")]
        public ProductGurantee ProductGurantee { get; set; }
        #endregion
    }
}

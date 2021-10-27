using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class showPriceForProductViewModel
    {
        public int ProductpriceId { get; set; }

        [Display(Name = " قیمت اصلی ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int mainPrice { get; set; }

        [Display(Name = " قیمت ویژه ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int? specialprice { get; set; }

        [Display(Name = "  تعداد کالا ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int count { get; set; }

        [Display(Name = "تعداد خرید کاربر ")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public int maxorderCount { get; set; }

        [Display(Name ="تاریخ ایجاد")]
        public DateTime CteateDate { get; set; }
        [Display(Name ="تاریخ ختم تخفیف")]
        public DateTime? EndDateDiscount { get; set; }
        public string ColorName { get; set; }
        public string GuranteeName { get; set; }
        public int ProductId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HamnavaKala.DataLayer.Entities.Address
{
    public class city
    {
        [Key]
        public int cityid { get; set; }


        [Display(Name = "نام شهر")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(2, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string cityname { get; set; }
        public bool isdelete { get; set; }
        public int provinceid { get; set; }

        #region Relation

        [ForeignKey(nameof(provinceid))]
        public Province Province { get; set; }


        #endregion
    }
}

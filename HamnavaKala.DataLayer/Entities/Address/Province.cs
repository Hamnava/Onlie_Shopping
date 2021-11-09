using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HamnavaKala.DataLayer.Entities.Address
{
    public class Province
    {
        [Key]
        public int provinceid { get; set; }

        [Display(Name = "نام استان")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(2, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string provincename { get; set; }


        public bool isDelete { get; set; }
        #region Relation

        public List<city> cities { get; set; }


        #endregion
    }
}

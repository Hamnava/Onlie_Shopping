using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HamnavaKala.DataLayer.Entities.Address
{
    public class useraddress
    {

        [Key]
        public int addresid { get; set; }


        [Display(Name = "نام تحویل گیرنده ")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(2, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string Recipientname { get; set; }


        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string phone { get; set; }


        [Display(Name = "تلفن ثابت")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        [MinLength(11, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد")]
        [MaxLength(11, ErrorMessage = "{0} نمیتواند بیشتر از {1} باید")]
        public string Landlinephonenumber { get; set; }

        [Display(Name = "پلاک")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        public int Plaque { get; set; }

        [Display(Name = "واحد")]
        public int unit { get; set; }

        [Display(Name = "کد پستی")]
        [Required(ErrorMessage = "وارد کردن {0} اجباری می باشد .")]
        public int postalCode { get; set; }


        [Display(Name = "آدرس کامل")]
        public string FullAddress { get; set; }

        public bool Isdelete { get; set; }

        //-----------
        public int provinceid { get; set; }
        public int cityid { get; set; }
        public int userid { get; set; }

        #region Relation

        [ForeignKey(nameof(provinceid))]
        public Province province { get; set; }


        [ForeignKey(nameof(cityid))]
        public city city { get; set; }

        [ForeignKey(nameof(userid))]
        public User user { get; set; }

        #endregion
    }
}

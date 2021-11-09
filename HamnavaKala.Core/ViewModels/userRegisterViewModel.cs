using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class userRegisterViewModel
    {
        [Display(Name ="ایمیل")]
        [Required(ErrorMessage ="وارد نمودن {0} الزامی میباشد.")]
        public string Email { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی میباشد.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "تایید رمز عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage ="رمز عبور با تکرار رمز عبور مطابقت ندارد.")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی میباشد.")]
        public string username { get; set; }
        [Range(typeof(bool), "true", "true", ErrorMessage ="موافقت نمودن با قوانین سایت ما اجباری میباشد.")]
        public bool IsAccept { get; set; }
    }

    public class forgotpasswordViewModel
    {
        public int userid { get; set; }
        [Display(Name = "رمز عبور")]
        [Required(ErrorMessage = "وارد نمودن {0} الزامی میباشد.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "تایید رمز عبور")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "رمز عبور با تکرار رمز عبور مطابقت ندارد.")]
        public string confirmpassword { get; set; }
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Display(Name ="نام فارسی ")]
        [MaxLength(300, ErrorMessage ="{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string ProductFaName { get; set; }

        [Display(Name = "نام انگلیسی ")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string ProductEnName { get; set; }

        [Display(Name = "تعداد فروش")]
        public int ProductSell { get; set; }

        [Display(Name = "عکس محصول ")]
        public string ProductImage { get; set; }

        [Display(Name = "امتیاز محصول ")]
        public byte ProductStar { get; set; }

        [Display(Name = "وزن محصول ")]
        public int ProductWeight { get; set; }

        public DateTime ProductCreate { get; set; }
        public DateTime ProductUpate { get; set; }

        [Display(Name = "برچسب محصول ")]
        public string ProductTag { get; set; }

        [Display(Name = "فعال باشد؟ ")]
        public bool IsActive { get; set; }

        [Display(Name = "اورجینال است؟ ")]
        public bool IsOriginal { get; set; }
        public bool IsDelete { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }


        #region Relations 
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        public List<PropertyValue> propertyValues { get; set; }
        public List<ProductGallery> productGallery { get; set; }
        public List<Comment> Comment { get; set; }
        public List<Question> Questions { get; set; }
        public List<Review> reviews { get; set; }
        public List<ProductPrice> productPrices { get; set; }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "نام دسته بندی به فارسی ")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string CategoryFaName { get; set; }

        [Display(Name = "نام دسته بندی به انگلیسی ")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string CategoryEnName { get; set; }

        public bool IsDelete { get; set; }
        public int? SubCategory { get; set; }

        // Relations to other tables
        public List<Product> Products { get; set; }
        [ForeignKey("SubCategory")]
        public Category category { get; set; }
        public List<ProductProperty_Category> productProperty_Categories { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Display(Name = "نام دسته بندی ")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string CategoryName { get; set; }

        // Relations to other tables
        public List<Product> Products { get; set; }
        public List<ProductProperty_Category> productProperty_Categories { get; set; }

    }
}

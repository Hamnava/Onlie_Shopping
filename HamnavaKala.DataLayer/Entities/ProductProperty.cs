using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductProperty
    {
        [Key]
        public int ProductPropertyId { get; set; }

        [Display(Name = "عنوان مشخصه محصول ")]
        [MaxLength(100, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(3, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string ProductPropertyTitle { get; set; }
        public bool IsDelete { get; set; }

        // Relations to other tables
        public List<ProductProperty_Category> productProperty_Categories { get; set; }
        public List<PropertyValue> propertyValues { get; set; }
    }
}

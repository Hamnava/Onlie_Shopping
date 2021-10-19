using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
    public class PropertyValue
    {
        [Key]
        public int PropertyValueId { get; set; }

        [Display(Name = " مقدار خصوصیات ")]
        [MaxLength(50, ErrorMessage = "{0} نمیتواند بیشتر از {1} باشد.")]
        [MinLength(5, ErrorMessage = "{0} نمیتواند کمتر از {1} باشد.")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string Propertvalue { get; set; }

        public int ProductId { get; set; }

        // Relations to other tables
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}

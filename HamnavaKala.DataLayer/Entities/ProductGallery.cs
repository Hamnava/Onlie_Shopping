using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductGallery
    {
        [Key]
        public int ProductGalleryId { get; set; }
        [Display(Name = " تصویر محصول")]
        [Required(ErrorMessage = "{0} نمیتواند خالی باشد.")]
        public string Imgname { get; set; }

        public int ProductId { get; set; }

        // Relations to other tables
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}

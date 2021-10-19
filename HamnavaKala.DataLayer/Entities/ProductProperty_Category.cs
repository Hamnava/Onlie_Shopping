using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class ProductProperty_Category
    {
        public int ProductProperty_CategoryId { get; set; }
        public int ProductPropertyId { get; set; }
        public int CategroyId { get; set; }

        // Relations between these two tables
        [ForeignKey("CategroyId")]
        public Category Category { get; set; }
        [ForeignKey("ProductPropertyId")]
        public ProductProperty ProductProperty { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class ProductDetailsViewModel
    {
        public int productid { get; set; }
        public string productfaname { get; set; }
        public string productenname { get; set; }
        public string productTag { get; set; }
        public string  colorname { get; set; }
        public string colorCode { get; set; }
        public string guranteename { get; set; }
        public int productsell { get; set; }
        public int productStar { get; set; }
        public string categoryName { get; set; }
        public string brandName { get; set; }
        public int mainPrice { get; set; }
        public int? specialPrice { get; set; }
        public DateTime? EndDiescount { get; set; }
        public string productImg { get; set; }
    }
}

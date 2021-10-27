using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
    public class SliderForCategoryViewModel
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public string productImg { get; set; }
        public int mainprice { get; set; }
        public int? specialprice { get; set; }
    }
}

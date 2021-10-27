using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.ViewModels
{
   public class specialproductViewModel
    {
        public int productid { get; set; }
        public string productfaname { get; set; }
        public int mainprice { get; set; }
        public int? specialprice { get; set; }
        public DateTime? Enddatespecialprice { get; set; }
        public List<ValueViewModel> ValuesList { get; set; }
        public string Productimg { get; set; }
    }

    public class ValueViewModel
    {
        public string propname { get; set; }
        public string value { get; set; }
    }
}

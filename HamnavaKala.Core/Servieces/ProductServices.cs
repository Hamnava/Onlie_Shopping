using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Servieces
{
    public class ProductServices : IProductServices
    {
        private readonly HamnavaKalaContext _context;
        public ProductServices(HamnavaKalaContext context)
        {
            _context = context;
        }
        public int AddColor(ProductColor productColor)
        {
            try
            {
                _context.ProductColors.Add(productColor);
                _context.SaveChanges();
                return productColor.productColorId;
            }
            catch (Exception)
            {
                return 0;
            }
            
        }

        public bool ExistColor(string colorname, string colorcode, int colorid)
        {
            return _context.ProductColors.Any(c => c.colorCode == colorcode && c.colorName == colorname && c.productColorId != colorid);
        }

        public ProductColor GetColorById(int id)
        {
            return _context.ProductColors.Find(id);
        }

        public List<ProductColor> ShowAllProduct()
        {
            return _context.ProductColors.ToList();
        }

        public bool UpdateColor(ProductColor productColor)
        {
            try
            {
                _context.ProductColors.Update(productColor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

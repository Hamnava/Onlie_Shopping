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
    public class BrandService : IBrand
    {
        private readonly HamnavaKalaContext _context;
        public BrandService(HamnavaKalaContext context)
        {
            _context = context;
        }
        public List<Brand> ShowAllBrands()
        {
            return _context.Brands.ToList();
        }
    }
}

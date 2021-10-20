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
    public class GuranteeService : IGurantee
    {
        private readonly HamnavaKalaContext _context;
        public GuranteeService(HamnavaKalaContext context)
        {
            _context = context;
        }
        public int AddGurantee(ProductGurantee gurantee)
        {
            try
            {
                _context.ProductGurantees.Add(gurantee);
                _context.SaveChanges();
                return gurantee.GuranteeId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DeleteGurantee(ProductGurantee gurantee)
        {
            try
            {
                gurantee.IsDelete = true;
                _context.ProductGurantees.Remove(gurantee);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExistGurantee(string guranteeName, int granteId)
        {
            return _context.ProductGurantees.Any(g => g.GuranteeName == guranteeName && g.GuranteeId != granteId);
        }

        public ProductGurantee GetGuranteebyId(int id)
        {
            return _context.ProductGurantees.Find(id);
        }

        public List<ProductGurantee> showAllGurantee()
        {
            return _context.ProductGurantees.Where(g=> g.IsDelete == false).ToList();
        }

        public bool UpdateGurantee(ProductGurantee gurantee)
        {
            try
            {
                _context.ProductGurantees.Update(gurantee);
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

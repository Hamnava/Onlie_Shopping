using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Interfaces
{
   public interface IGurantee
    {
        List<ProductGurantee> showAllGurantee();
        bool UpdateGurantee(ProductGurantee gurantee);
        bool DeleteGurantee(ProductGurantee gurantee);
        ProductGurantee GetGuranteebyId(int id);
        bool ExistGurantee(string guranteeName, int granteId);
        int AddGurantee(ProductGurantee gurantee);
    }
}

using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Interfaces
{
   public interface IProductServices
    {
        #region ProductColor
        List<ProductColor> ShowAllProduct();
        int AddColor(ProductColor productColor);
        bool UpdateColor(ProductColor productColor);
        ProductColor GetColorById(int id);
        bool ExistColor(string colorname, string colorcode,int colorid);
        #endregion

        #region ProductPropertyName
        List<ProductProperty> ShowAllProperty();
        int AddPropertyName(ProductProperty property);
        bool ExistProperty(string name, int id);
        bool AddpropertyForCategory(List<ProductProperty_Category> categories);
        #endregion
    }
}

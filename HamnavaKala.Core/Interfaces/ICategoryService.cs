using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Interfaces
{
   public interface ICategoryService
    {
        List<Category> ShowAllCategory();
        int AddCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        Category GetCategoryById(int categoryid);
        List<Category> ShowAllsubcategory(int categoryid);
        bool ExistCategory(string catfaName, string catEnName, int catid);
        List<Category> Showsubcategory();
    }
}

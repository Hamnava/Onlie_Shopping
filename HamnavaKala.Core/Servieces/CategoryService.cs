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
    public class CategoryService : ICategoryService
    {
        private readonly HamnavaKalaContext _context;
        public CategoryService(HamnavaKalaContext context)
        {
            _context = context;
        }
        public int AddCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return category.CategoryId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DeleteCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Category GetCategoryById(int categoryid)
        {
            return _context.Categories.Find(categoryid);
        }

        public List<Category> ShowAllCategory()
        {
            return _context.Categories.Where(c => c.IsDelete == false && c.SubCategory == null).ToList();
        }

        public List<Category> ShowAllsubcategory(int categoryid)
        {
            return _context.Categories.Where(c => c.IsDelete == false && c.SubCategory == categoryid).ToList();
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ExistCategory(string catfaName, string catEnName, int catid)
        {
            return _context.Categories.Any(c => c.CategoryEnName == catEnName && c.CategoryFaName == catfaName && c.CategoryId != catid);
        }
    }
}

using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities;
using HamnavaKala.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;

namespace HamnavaKala.Core.Servieces
{
    public class ProductServices : IProductServices
    {
        private readonly HamnavaKalaContext _context;
        public ProductServices(HamnavaKalaContext context)
        {
            _context = context;
        }


        #region ProductColor Property
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

        public List<ProductColor> ShowAllProductColor()
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
        #endregion

        #region ProductPropertyName
        public List<ProductProperty> ShowAllProperty()
        {
            return _context.ProductProperties.Where(p=> p.IsDelete == false).ToList();
        }

        public int AddPropertyName(ProductProperty property)
        {
            try
            {
                property.IsDelete = false;
                _context.ProductProperties.Add(property);
                _context.SaveChanges();
                return property.ProductPropertyId;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public bool ExistProperty(string name, int id)
        {
            return _context.ProductProperties.Any(p => p.ProductPropertyTitle == name && p.ProductPropertyId != id);
        }

        public bool AddpropertyForCategory(List<ProductProperty_Category> categories)
        {
            try
            {
                _context.ProductProperty_Categories.AddRange(categories);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UpdateproductPropertyViewModel> FindProductPropertyNameForUpdate(int Productpropertyid)
        {
            List<UpdateproductPropertyViewModel> updates = (from pc in _context.ProductProperty_Categories
                                                            join p in _context.ProductProperties on pc.ProductPropertyId equals p.ProductPropertyId
                                                            where (pc.ProductPropertyId == Productpropertyid)
                                                            select new UpdateproductPropertyViewModel
                                                            {
                                                                pcid = pc.ProductProperty_CategoryId,
                                                                productproId = p.ProductPropertyId,
                                                                productpropTitle = p.ProductPropertyTitle,
                                                                catid = pc.CategroyId,
                                                            }).ToList();
            return updates;
        }

        public bool DeletePropertyforCategory(int propid)
        {
            try
            {
                List<ProductProperty_Category> categories = _context.ProductProperty_Categories.Where(c => c.ProductPropertyId == propid).ToList();
                _context.ProductProperty_Categories.RemoveRange(categories);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateProductProperty(ProductProperty property)
        {
            try
            {
                _context.ProductProperties.Update(property);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ProductProperty GetProductPropertyById(int id)
        {
            return _context.ProductProperties.Find(id);
        }


        #endregion

        #region Product
        public List<Product> ShowallProduct()
        {
            return _context.Products.Where(p => p.IsDelete == false).ToList();
        }
        public int AddProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return product.ProductId;
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int FindCategoryForproduct(int productid)
        {
            return _context.Products.Where(p => p.ProductId == productid).Select(c => c.CategoryId).FirstOrDefault();
        }

        public List<ProductProperty> showallPropertyforCategory(int categoryid)
        {
            List<ProductProperty> productProperties = (from pc in _context.ProductProperty_Categories
                                                      join pp in _context.ProductProperties on
                                                      pc.ProductPropertyId equals pp.ProductPropertyId
                                                      where (pc.CategroyId == categoryid)
                                                      select new ProductProperty
                                                       {
                                                           ProductPropertyTitle = pp.ProductPropertyTitle,
                                                           ProductPropertyId = pp.ProductPropertyId
                                                       }).ToList();
            return productProperties;
         }


        public bool DeletePropertyValueforProduct(int productid)
        {
            try
            {
                List<PropertyValue> propertyValues = _context.PropertyValues.Where(p => p.ProductId == productid).ToList();
                _context.PropertyValues.RemoveRange(propertyValues);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool AddOrUpdateproductPropertyForProduct(int productid, List<PropertyValue> propertyValues)
        {
            try
            {
                if (DeletePropertyValueforProduct(productid))
                {
                    _context.PropertyValues.AddRange(propertyValues);
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<PropertyValue> showpropertyValue(int productid)
        {
            return _context.PropertyValues.Where(p => p.ProductId == productid).ToList();
        }

       
        #endregion

        #region Review
        public Review Findreviewbyproduct(int productid)
        {
            return _context.Reviews.Where(r => r.ProductId == productid).FirstOrDefault();
        }

        public bool AddOrupdatereview(Review review)
        {
            try
            {
                _context.Reviews.Add(review);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteReview(int productid)
        {
            try
            {
                Review review = _context.Reviews.Where(r=> r.ProductId == productid).FirstOrDefault();
                if (review != null)
                {
                    _context.Reviews.Remove(review);
                    _context.SaveChanges();
                    return true;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

        #region ProductPrice
        public List<showPriceForProductViewModel> ShowPriceForProduct(int productid)
        {
            List<showPriceForProductViewModel> price = (from pr in _context.ProductPrices
                                                        join p in _context.Products on pr.ProductId equals p.ProductId
                                                        join c in _context.ProductColors on pr.productColor equals c.productColorId
                                                        join g in _context.ProductGurantees on pr.productGurantee equals g.GuranteeId
                                                        where (pr.ProductId == productid)
                                                        select new showPriceForProductViewModel
                                                        {
                                                            ProductId = p.ProductId,
                                                            ColorName = c.colorName,
                                                            GuranteeName = g.GuranteeName,
                                                            mainPrice = pr.mainPrice,
                                                            maxorderCount = pr.maxorderCount,
                                                            CteateDate = pr.CteateDate,
                                                            EndDateDiscount = pr.EndDateDiscount,
                                                            specialprice = pr.specialprice,
                                                            count = pr.count,
                                                            ProductpriceId = pr.ProductpriceId

                                                        }).ToList();
            return price;
        }

        public int AddProductPrice(ProductPrice price)
        {
            try
            {
                _context.ProductPrices.Add(price);
                _context.SaveChanges();
                return price.ProductpriceId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool UpdateProductPrice(ProductPrice price)
        {
            try
            {
                _context.ProductPrices.Update(price);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public ProductPrice GetPriceById(int id)
        {
            return _context.ProductPrices.Include(p => p.product).FirstOrDefault();
        }

        public bool DeleteProductPrice(ProductPrice price)
        {
            try
            {
                _context.ProductPrices.Remove(price);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion
    }
}

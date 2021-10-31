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

       public List<specialproductViewModel> ShowallSpecialPrice()
        {
            List<specialproductViewModel> specialproducts = (from pr in _context.ProductPrices
                                                             join p in _context.Products on pr.ProductId equals p.ProductId
                                                             where (pr.specialprice < pr.mainPrice && pr.EndDateDiscount >= DateTime.Now.Date)
                                                             select new specialproductViewModel
                                                             {
                                                                 productfaname = p.ProductFaName,
                                                                 productid = p.ProductId,
                                                                 Enddatespecialprice = pr.EndDateDiscount,
                                                                 mainprice = pr.mainPrice,
                                                                 specialprice = pr.specialprice,
                                                                 Productimg = p.ProductImage,
                                                                 ValuesList = (from pv in _context.PropertyValues
                                                                               join pn in _context.ProductProperties on pv.productpropertyid equals pn.ProductPropertyId
                                                                               where(pv.ProductId == pr.ProductId)
                                                                               select new ValueViewModel
                                                                               {
                                                                                   propname = pn.ProductPropertyTitle,
                                                                                   value = pv.Propertvalue
                                                                               }).Take(3).ToList()
                                                             }).ToList();
            return specialproducts;
        }

        public List<SliderForCategoryViewModel> ShowSliderForCategory(int categoryid)
        {
            List<SliderForCategoryViewModel> slider = (from pr in _context.ProductPrices
                                                       join p in _context.Products on pr.ProductId equals p.ProductId
                                                       where (p.CategoryId == categoryid)
                                                       select new SliderForCategoryViewModel
                                                       {
                                                           productid = p.ProductId,
                                                           productImg = p.ProductImage,
                                                           productname = p.ProductFaName,
                                                           mainprice = pr.mainPrice,
                                                           specialprice = pr.EndDateDiscount >= DateTime.Now.Date && pr.specialprice <= pr.mainPrice ? pr.specialprice : pr.mainPrice
                                                       }).ToList();
            return slider;
        }

       

        public List<ProductDetailsViewModel> ShowDetailsProduct(int productid)
        {
            List<ProductDetailsViewModel> detail = (from pr in _context.ProductPrices
                                                        join p in _context.Products on pr.ProductId equals p.ProductId
                                                        join g in _context.ProductGurantees on pr.productGurantee equals g.GuranteeId
                                                        join pc in _context.ProductColors on pr.productColor equals pc.productColorId
                                                        join c in _context.Categories on p.CategoryId equals c.CategoryId
                                                        join b in _context.Brands on p.BrandId equals b.BrandId

                                                        where (pr.ProductId == productid)

                                                        select new ProductDetailsViewModel
                                                        {
                                                            productImg = p.ProductImage,
                                                            productid = p.ProductId,
                                                            productenname = p.ProductEnName,
                                                            productfaname = p.ProductFaName,
                                                            productStar = p.ProductStar,
                                                            productsell = p.ProductSell,
                                                            productTag = p.ProductTag,
                                                            mainPrice = pr.mainPrice,
                                                            specialPrice = pr.mainPrice > pr.specialprice && pr.EndDateDiscount >= DateTime.Now.Date ? pr.specialprice: pr.mainPrice,
                                                            colorCode = pc.colorCode,
                                                            colorname = pc.colorName,
                                                            brandName = b.BrandName,
                                                            categoryName = c.CategoryFaName,
                                                            EndDiescount = pr.EndDateDiscount,
                                                            guranteename = g.GuranteeName
                                                        }).ToList();
            return detail;
        }

        public List<ValueViewModel> showViewforProduct(int productid)
        {
            List<ValueViewModel> value = (from pv in _context.PropertyValues
                                          join pp in _context.ProductProperties on pv.productpropertyid equals pp.ProductPropertyId
                                          where (pv.ProductId == productid)
                                          select new ValueViewModel
                                          { 
                                              propname = pp.ProductPropertyTitle,
                                              value = pv.Propertvalue
                                          }).Take(4).ToList();
            return value;

        }

        public List<ValueViewModel> ShowAllPropertyforProduct(int productid)
        {
            List<ValueViewModel> property = (from pv in _context.PropertyValues
                                             join pp in _context.ProductProperties on pv.productpropertyid equals pp.ProductPropertyId
                                             where (pv.ProductId == productid)
                                             select new ValueViewModel
                                             {
                                                 propname = pp.ProductPropertyTitle,
                                                 value = pv.Propertvalue
                                             }).ToList();
            return property;
        }

        public List<CommentsForProductViewModel> ShowuserCommentsForProduct(int productid)
        {
            List<CommentsForProductViewModel> comment = (from c in _context.Comments
                                                         join u in _context.Users on c.userId equals u.UserId
                                                         where (c.productId == productid && c.IsActive)
                                                         select new CommentsForProductViewModel
                                                         {
                                                             commentTitle = c.CommentTitle,
                                                             CommentDescription = c.CommentDescription,
                                                             CommentLike = c.CommentLike,
                                                             CommentDislike = c.CommentDeslike,
                                                             CreateCommentdate = c.CommentCreate,
                                                             IslikeProduct = c.Recommend,
                                                             userfullName = u.FirstName + " "+ u.LastName
                                                         }).ToList();
            return comment;

        }

        public List<QuestionAnswerViewModel> ShowallQuestionAnswer(int productid)
        {
            var question = _context.Questions.Where(q => q.IsActive == true && q.productId == productid);

            List<QuestionAnswerViewModel> qavm = (from q in question
                                                  join uq in _context.Users on q.userId equals uq.UserId

                                                  join a in _context.Answers on q.QuestionId equals a.QuestionId into qa
                                                  from a in qa.DefaultIfEmpty()

                                                  join ua in _context.Users on a.userid equals ua.UserId into u
                                                  from ua in u.DefaultIfEmpty()

                                                  select new QuestionAnswerViewModel
                                                  {
                                                      Questionid = q.QuestionId,
                                                      DescriptionQ = q.QuestionDescription,
                                                      CreateQDate = q.QCreate,
                                                      usernameQ = uq.FirstName + " " + uq.LastName,
                                                      showAnswer = new AnswerViewModel
                                                      {
                                                          AnswerId = a.AnswerId,
                                                          CreateADate = a.AnswerDate,
                                                          DescriptionA = a.AnswerDescription,
                                                          usernameA = ua.FirstName +" " + ua.LastName
                                                      }
                                                  }).ToList();
            return qavm;
        }
        #endregion

        #region ProductGallery
       public void addGallery(ProductGallery gallery)
        {
            try
            {
                _context.ProductGalleries.Add(gallery);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ProductGallery GetGalleryById(int id)
        {
            return _context.ProductGalleries.Find(id);
        }
        public void DeleteGallery(int id)
        {
            var gallery = GetGalleryById(id);
            _context.ProductGalleries.Remove(gallery);
            _context.SaveChanges();
        }

        public List<ProductGallery> ShowGallery(int productid)
        {
            return _context.ProductGalleries.Where(g => g.ProductId == productid).ToList();
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

using HamnavaKala.Core.ViewModels;
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
        List<ProductColor> ShowAllProductColor();
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
        List<UpdateproductPropertyViewModel> FindProductPropertyNameForUpdate(int Productpropertyid);
        bool UpdateProductProperty(ProductProperty property);
        bool DeletePropertyforCategory(int propid);
        ProductProperty GetProductPropertyById(int id);
        #endregion

        #region Product
        List<Product> ShowallProduct();
        int AddProduct(Product product);
        Product GetProductById(int id);
        bool UpdateProduct(Product product);
        int FindCategoryForproduct(int productid);
        List<ProductProperty> showallPropertyforCategory(int categoryid);
        bool DeletePropertyValueforProduct(int productid);
        bool AddOrUpdateproductPropertyForProduct(int productid, List<PropertyValue> propertyValues);
        List<PropertyValue> showpropertyValue(int productid);
        List<SliderForCategoryViewModel> ShowSliderForCategory(int categoryid);
        List<specialproductViewModel> ShowallSpecialPrice();
        List<ProductDetailsViewModel> ShowDetailsProduct(int productid);
        List<ValueViewModel> showViewforProduct(int productid);
        List<ValueViewModel> ShowAllPropertyforProduct(int productid);
        List<CommentsForProductViewModel> ShowuserCommentsForProduct(int productid);
        List<QuestionAnswerViewModel> ShowallQuestionAnswer(int productid);
        #endregion

        #region ProductGallery
        ProductGallery GetGalleryById(int id);
        void addGallery(ProductGallery gallery);
        void DeleteGallery(int id);
        List<ProductGallery> ShowGallery(int productid);
        #endregion

        #region Review
        Review Findreviewbyproduct(int productid);
       bool AddOrupdatereview(Review review);
        bool DeleteReview(int productid);
        #endregion

        #region ProductPrice
        List<showPriceForProductViewModel> ShowPriceForProduct(int productid);
        int AddProductPrice(ProductPrice price);
        bool UpdateProductPrice(ProductPrice price);
        ProductPrice GetPriceById(int id);
        bool DeleteProductPrice(ProductPrice price);
        #endregion
    }
}

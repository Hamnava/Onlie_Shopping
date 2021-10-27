using HamnavaKala.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Components
{
    [ViewComponent(Name = "SliderForCategoryViewComponent")]
    public class SliderForCategoryViewComponent : ViewComponent
    {
        private readonly IProductServices _product;
        public SliderForCategoryViewComponent(IProductServices product)
        {
            _product = product;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult(View("showprodcutforcategory", _product.ShowSliderForCategory(id)));
        }
    }
}

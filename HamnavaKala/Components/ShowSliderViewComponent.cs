using HamnavaKala.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HamnavaKala.Components
{
    [ViewComponent (Name = "ShowSliderViewComponent")]
    public class ShowSliderViewComponent : ViewComponent
    {
        private readonly ISlider _slider;
        public ShowSliderViewComponent(ISlider slider)
        {
            _slider = slider;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View("showSliderForUser", _slider.ShowSliderForUser()));
        }
    }
}

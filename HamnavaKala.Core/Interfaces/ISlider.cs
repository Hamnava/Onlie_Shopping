using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Interfaces
{
   public interface ISlider
    {
        List<Slider> ShowSlider();
        Slider GetSliderById(int sliderId);
        int AddSlider(Slider slider);
        bool UpdateSlider(Slider slider);
        bool DeleteSlider(int id);
    }
}

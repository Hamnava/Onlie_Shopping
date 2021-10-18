using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Entities
{
   public class Slider
    {
        [Key]
        public int SliderId { get; set; }
        [Display(Name ="عنوان سلایدر")]
        public string SliderTitle { get; set; }
        [Display(Name ="لینک سلایدر")]
        public string SliderLink { get; set; }
        [Display(Name ="حالت سلایدر")]
        public bool IsActive { get; set; }
        [Display(Name ="ترتیب سلایدر")]
        public int SliderSort { get; set; }
        [Display(Name =" Alt سلایدر")]
        public string SliderAlt { get; set; }
        [Display(Name = "عکس سلایدر")]
        public string ImgSlider { get; set; }
    }
}

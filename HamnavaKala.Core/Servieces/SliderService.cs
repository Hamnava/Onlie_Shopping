﻿using HamnavaKala.Core.Interfaces;
using HamnavaKala.DataLayer.Context;
using HamnavaKala.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Servieces
{
    public class SliderService : ISlider
    {
        private readonly HamnavaKalaContext _context;
        public SliderService(HamnavaKalaContext context)
        {
            _context = context;
        }

        public int AddSlider(Slider slider)
        {
            try
            {
                _context.Sliders.Add(slider);
                _context.SaveChanges();
                return slider.SliderId;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DeleteSlider(int id)
        {
            var slider = _context.Sliders.Find(id);
            try
            {
                _context.Sliders.Remove(slider);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Slider GetSliderById(int sliderId)
        {
          return  _context.Sliders.Find(sliderId);
        }

        public List<Slider> ShowSlider(int page)
        {
            int skip = (page - 1) * 2;
           return _context.Sliders.OrderBy(s=> s.SliderSort).Skip(skip).Take(2).ToList();
        }

        public bool UpdateSlider(Slider slider)
        {
            try
            {
                _context.Sliders.Update(slider);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int SliderCount()
        {
            int SliderCount = _context.Sliders.Count();
            if (SliderCount % 2 != 0)
                SliderCount++;

            SliderCount = SliderCount / 2;
            return SliderCount;
        }
    }
}

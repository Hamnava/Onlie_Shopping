﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Classes
{
   public static class uploadImg
    {
        public static string CreateImg(IFormFile file)
        {
            try
            {
                string imgname = GeneratCode.GuidCode() + Path.GetExtension(file.FileName);
                string ImgPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/assets/images/slider-main", imgname);

                using (var stream = new FileStream(ImgPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                return imgname;
            }
            catch (Exception)
            {

                return "false";
            }
            
        }
    }
}

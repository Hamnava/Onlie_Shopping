using HamnavaKala.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.DataLayer.Context
{
   public class HamnavaKalaContext : DbContext
    {
        public HamnavaKalaContext(DbContextOptions<HamnavaKalaContext> options) : base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
    }
}

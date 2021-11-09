using HamnavaKala.DataLayer.Entities;
using HamnavaKala.DataLayer.Entities.Address;
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
        public DbSet<User> Users { get; set; }

        #region FaQ
        public DbSet<AnswerQ> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        #endregion

        #region Products
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductGallery> ProductGalleries{ get; set; }
        public DbSet<ProductGurantee> ProductGurantees { get; set; }
        public DbSet<ProductProperty> ProductProperties { get; set; }
        public DbSet<PropertyValue> PropertyValues { get; set; }
        public DbSet<ProductProperty_Category> ProductProperty_Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ProductPrice> ProductPrices { get; set; }
        #endregion

        #region Address
        public DbSet<city> cities { get; set; }
        public DbSet<Province> provinces { get; set; }
        public DbSet<useraddress> Useraddresses { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var casecadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in casecadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

            base.OnModelCreating(modelBuilder);
        }
    }
}

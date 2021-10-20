﻿// <auto-generated />
using System;
using HamnavaKala.DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HamnavaKala.DataLayer.Migrations
{
    [DbContext(typeof(HamnavaKalaContext))]
    [Migration("20211020121311_mig-productPrice")]
    partial class migproductPrice
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.AnswerQ", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AnswerDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AnswerDescription")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryEnName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CategoryFaName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("SubCategory")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("SubCategory");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CommentCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommentDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("CommentDeslike")
                        .HasColumnType("int");

                    b.Property<int>("CommentLike")
                        .HasColumnType("int");

                    b.Property<string>("CommentTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<byte>("Recommend")
                        .HasColumnType("tinyint");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("productId");

                    b.HasIndex("userId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOriginal")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ProductCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductEnName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ProductFaName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductSell")
                        .HasColumnType("int");

                    b.Property<byte>("ProductStar")
                        .HasColumnType("tinyint");

                    b.Property<string>("ProductTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductUpate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductWeight")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductColor", b =>
                {
                    b.Property<int>("productColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("colorCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("colorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("productColorId");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductGallery", b =>
                {
                    b.Property<int>("ProductGalleryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imgname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductGalleryId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductGalleries");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductGurantee", b =>
                {
                    b.Property<int>("GuranteeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GuranteeName")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("GuranteeId");

                    b.ToTable("ProductGurantees");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductPrice", b =>
                {
                    b.Property<int>("ProductpriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CteateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateDiscount")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("count")
                        .HasColumnType("int");

                    b.Property<int>("mainPrice")
                        .HasColumnType("int");

                    b.Property<int>("maxorderCount")
                        .HasColumnType("int");

                    b.Property<int>("productColor")
                        .HasColumnType("int");

                    b.Property<int>("productGurantee")
                        .HasColumnType("int");

                    b.Property<int>("specialprice")
                        .HasColumnType("int");

                    b.HasKey("ProductpriceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("productColor");

                    b.HasIndex("productGurantee");

                    b.ToTable("ProductPrices");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductProperty", b =>
                {
                    b.Property<int>("ProductPropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductPropertyTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ProductPropertyId");

                    b.ToTable("ProductProperties");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductProperty_Category", b =>
                {
                    b.Property<int>("ProductProperty_CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategroyId")
                        .HasColumnType("int");

                    b.Property<int>("ProductPropertyId")
                        .HasColumnType("int");

                    b.HasKey("ProductProperty_CategoryId");

                    b.HasIndex("CategroyId");

                    b.HasIndex("ProductPropertyId");

                    b.ToTable("ProductProperty_Categories");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.PropertyValue", b =>
                {
                    b.Property<int>("PropertyValueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Propertvalue")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PropertyValueId");

                    b.HasIndex("ProductId");

                    b.ToTable("PropertyValues");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("QCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QuestionDescription")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("productId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("productId");

                    b.HasIndex("userId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArticleDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArticleTitle")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ReviewDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ReviewNegative")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ReviewPositive")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgSlider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SliderAlt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SliderLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SliderSort")
                        .HasColumnType("int");

                    b.Property<string>("SliderTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SliderId");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("userAccount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.AnswerQ", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Category", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Category", "category")
                        .WithMany()
                        .HasForeignKey("SubCategory")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Comment", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "product")
                        .WithMany("Comment")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Product", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Brand", "Brand")
                        .WithMany("products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductGallery", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "Product")
                        .WithMany("productGallery")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductPrice", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "product")
                        .WithMany("productPrices")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.ProductColor", "ProductColor")
                        .WithMany("productPrices")
                        .HasForeignKey("productColor")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.ProductGurantee", "ProductGurantee")
                        .WithMany("productPrices")
                        .HasForeignKey("productGurantee")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("ProductColor");

                    b.Navigation("ProductGurantee");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductProperty_Category", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Category", "Category")
                        .WithMany("productProperty_Categories")
                        .HasForeignKey("CategroyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.ProductProperty", "ProductProperty")
                        .WithMany("productProperty_Categories")
                        .HasForeignKey("ProductPropertyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("ProductProperty");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.PropertyValue", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "Product")
                        .WithMany("propertyValues")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Question", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "Product")
                        .WithMany("Questions")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("HamnavaKala.DataLayer.Entities.User", "User")
                        .WithMany("Questions")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Review", b =>
                {
                    b.HasOne("HamnavaKala.DataLayer.Entities.Product", "Product")
                        .WithMany("reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Brand", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Category", b =>
                {
                    b.Navigation("productProperty_Categories");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.Product", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("productGallery");

                    b.Navigation("productPrices");

                    b.Navigation("propertyValues");

                    b.Navigation("Questions");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductColor", b =>
                {
                    b.Navigation("productPrices");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductGurantee", b =>
                {
                    b.Navigation("productPrices");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.ProductProperty", b =>
                {
                    b.Navigation("productProperty_Categories");
                });

            modelBuilder.Entity("HamnavaKala.DataLayer.Entities.User", b =>
                {
                    b.Navigation("Comment");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}

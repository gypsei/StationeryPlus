﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StationeryPlus.Server.Data;

#nullable disable

namespace StationeryPlus.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StationeryPlus.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                            Price = 80m,
                            Title = "Nataraj 621 Pencils"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                            Price = 80m,
                            Title = "Nataraj 621 Pencils"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                            Price = 80m,
                            Title = "Nataraj 621 Pencils"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                            Price = 80m,
                            Title = "Nataraj 621 Pencils"
                        });
                });

            modelBuilder.Entity("StationeryPlus.Shared.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Shop now for the best variety of school supplies, teaching solutions and essentials to transform the teaching environment.",
                            ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                            Name = "School Supplies",
                            Url = "school-supplies"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Shop now for the best variety of Office Supplies, equipments and essentials to transform the Office Environment.",
                            ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                            Name = "Office Supplies",
                            Url = "office-supplies"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Best Stationaries for Home, working from Home.",
                            ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                            Name = "Home Supplies",
                            Url = "home-supplies"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Explore art supplies and materials for any activity drawing, painting, sculpting, printmaking, calligraphy, and more.",
                            ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                            Name = "Art Supplies",
                            Url = "art-supplies"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Check out for very best, unique and custom gifts and decorations for any occasion.",
                            ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                            Name = "Gift and Decorations",
                            Url = "gifts-and-decorations"
                        });
                });

            modelBuilder.Entity("StationeryPlus.Shared.Product", b =>
                {
                    b.HasOne("StationeryPlus.Shared.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}

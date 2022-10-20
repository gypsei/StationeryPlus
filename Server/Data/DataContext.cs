﻿using Microsoft.EntityFrameworkCore;

namespace StationeryPlus.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder) 
        //{

        //    modelBuilder.Entity<Product>().HasData(
        //         new Product
        //         {
        //             Id = 1,
        //             Title = "Nataraj 621 Pencils",
        //             Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
        //             ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
        //             Price = 80,
        //         },
        //new Product
        //{
        //    Id = 2,
        //    Title = "Nataraj 621 Pencils",
        //    Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
        //    ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
        //    Price = 80,
        //},
        //new Product
        //{
        //    Id = 3,
        //    Title = "Nataraj 621 Pencils",
        //    Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
        //    ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
        //    Price = 80,
        //},
        //new Product
        //{
        //    Id = 4,
        //    Title = "Nataraj 621 Pencils",
        //    Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
        //    ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
        //    Price = 80,
        //}
        //        );
        //}

        public DbSet<Product> Products { get; set; }

    }
}
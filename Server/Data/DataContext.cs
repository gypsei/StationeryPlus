using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace StationeryPlus.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType
                {
                    Id = 1, Name = "Default"
                },
                new ProductType
                {
                    Id = 2,
                    Name = "Nataraj"
                },
                new ProductType
                {
                    Id = 3,
                    Name = "Doms"
                },
                new ProductType
                {
                    Id = 4,
                    Name = "X1"
                },
                new ProductType
                {
                    Id = 5,
                    Name = "Gululu"
                }


                );


            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.ProductTypeId});



modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Nataraj 621 Pencils",
                     Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                     ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                     CategoryId = 1,
                 },
                 new Product
        {
            Id = 2,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            CategoryId = 1,

                 },
                 new Product
        {
            Id = 3,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            CategoryId = 1,

                 },
                 new Product
        {
            Id = 4,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            CategoryId = 2,

                 }
                );


            modelBuilder.Entity<ProductCategory>().HasData(
            new ProductCategory()
            {
                Id = 1,
                Name = "School Supplies",
                Description = "Shop now for the best variety of school supplies, teaching solutions and essentials to transform the teaching environment.",
                ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                Url = "school-supplies",


            },
            new ProductCategory()
            {
                Id = 2,
                Name = "Office Supplies",
                Description = "Shop now for the best variety of Office Supplies, equipments and essentials to transform the Office Environment.",
                ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                Url = "office-supplies",
                

            },
            new ProductCategory()
            {
                Id = 3,
                Name = "Home Supplies",
                Description = "Best Stationaries for Home, working from Home.",
                ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                Url = "home-supplies",

            },
            new ProductCategory()
            {
                Id = 4,
                Name = "Art Supplies",
                Description = "Explore art supplies and materials for any activity drawing, painting, sculpting, printmaking, calligraphy, and more.",
                ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                Url = "art-supplies",

            },
            new ProductCategory()
            {
                Id = 5,
                Name = "Gift and Decorations",
                Description = "Check out for very best, unique and custom gifts and decorations for any occasion.",
                ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
                Url = "gifts-and-decorations",

            }
            );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId =1 ,
                    ProductTypeId =1 ,
                    Price = 80.46M,
                    OriginalPrice = 89.00M 
                },

                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 90.55M,
                    OriginalPrice = 20.12M
                },

                new ProductVariant
                {
                    ProductId =3 ,
                    ProductTypeId = 5,
                    Price = 50.55M,
                    OriginalPrice = 100.00M
                },
                new ProductVariant
                {
                    ProductId =1 ,
                    ProductTypeId = 2 ,
                    Price = 300M,
                    OriginalPrice =500M,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 4,
                    Price = 5.0M,
                    OriginalPrice =10.0M
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 5,
                    Price = 15.0M,
                    OriginalPrice =20.0M
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 4,
                    Price = 40.99M,
                    OriginalPrice =50.99M
                },
                new ProductVariant
                {
                    ProductId =4 ,
                    ProductTypeId = 2,
                    Price = 100M,
                    OriginalPrice = 200M
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 50M,
                    OriginalPrice = 100M

                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 1,
                    Price = 100M,
                    OriginalPrice = 100M
                }

                );

            //modelBuilder.Entity<ProductSubCategory>().HasData(
            //new ProductSubCategory()
            //{
            //    Id = 1,
            //    Name = "School Supplies",
            //    Description = "Shop now for the best variety of school supplies, teaching solutions and essentials to transform the teaching environment.",
            //    ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
            //    Url = "school-supplies",

            //},
            //new ProductSubCategory()
            //{
            //    Id = 2,
            //    Name = "Office Supplies",
            //    Description = "Shop now for the best variety of Office Supplies, equipments and essentials to transform the Office Environment.",
            //    ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
            //    Url = "office-supplies",

            //},
            //new ProductSubCategory()
            //{
            //    Id = 3,
            //    Name = "Home Supplies",
            //    Description = "Best Stationaries for Home, working from Home.",
            //    ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
            //    Url = "home-supplies",

            //},
            //new ProductSubCategory()
            //{
            //    Id = 4,
            //    Name = "Art Supplies",
            //    Description = "Explore art supplies and materials for any activity drawing, painting, sculpting, printmaking, calligraphy, and more.",
            //    ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
            //    Url = "art-supplies",

            //},
            //new ProductSubCategory()
            //{
            //    Id = 5,
            //    Name = "Gift and Decorations",
            //    Description = "Check out for very best, unique and custom gifts and decorations for any occasion.",
            //    ImageUrl = "https://img.freepik.com/premium-vector/school-supplies-backpack-pencils-brushes-paints-ruler-sharpener-stickers-calculator-books_647843-6.jpg?w=2000",
            //    Url = "gifts-and-decorations",

            //}
            //);



        }
        public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> Categories { get; set; }
    public DbSet<ProductType> ProductTypes { get; set; }
    public DbSet<ProductVariant> ProductVariants { get; set; }
    }

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
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace StationeryPlus.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Nataraj 621 Pencils",
                     Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
                     ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
                     Price = 80,
                     CategoryId = 1,
                 },
                 new Product
        {
            Id = 2,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            Price = 80,
            CategoryId = 1,

                 },
                 new Product
        {
            Id = 3,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            Price = 80,
            CategoryId = 1,

                 },
                 new Product
        {
            Id = 4,
            Title = "Nataraj 621 Pencils",
            Description = "HB Pencils, Superior hb bonded, lead resists breakage, Clear and sharp writing",
            ImageURL = "https://m.media-amazon.com/images/I/71lOR49VkwL._SL1500_.jpg",
            Price = 80,
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
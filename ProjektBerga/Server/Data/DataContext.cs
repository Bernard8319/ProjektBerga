using Microsoft.EntityFrameworkCore;
using ProjektBerga.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektBerga.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Grafičke kartice", Url = "Grafičke kartice", Icon = "aperture" },
                new Category { Id = 2, Name = "Mobiteli", Url = "Mobiteli", Icon = "aperture" },
                new Category { Id = 3, Name = "Slušalice", Url = "Slušalice", Icon = "aperture" }
              );
            modelBuilder.Entity<Product>().HasData(
                  new Product
                  {

                      Id = 1,
                      CategoryId = 1,
                      Title = "XFX AMD Radeon RX 550",
                      Description = " 2GB RAM",
                      Image = "https://www.hgspot.hr/image/cachewebp/catalog/slike/145204-878-640x480.webp",
                      Price = 2500,
                      OriginalPrice = 3500,
                  },
             new Product
             {
                 Id = 2,
                 CategoryId = 1,
                 Title = "Sapphire Pulse AMD Radeon RX 550",
                 Description = " 2GB RAM",
                 Image = "https://www.instar-informatika.hr/slike/velike/11268-21-20g.jpg",
                 Price = 2500,
                 OriginalPrice = 3500,
             },
             new Product
             {
                 Id = 3,
                 CategoryId = 2,
                 Title = "Samsung Galaxy Z Fold 3",
                 Description = " 5G, 256 GB/12 GB,12MP+12MP+12MP/4MP",
                 Image = "https://www.hgspot.hr/image/catalog/slike/167318-878.jpg",
                 Price = 10000,
                 OriginalPrice = 12000,
             },
            new Product
            {
                Id = 4,
                CategoryId = 2,
                Title = "Apple iPhone 13 Mini",
                Description = "5G,128GB, Midnight",
                Image = "https://www.hgspot.hr/image/catalog/slike/162633-878.jpg ",
                Price = 4500,
                OriginalPrice = 6500,
            },

           new Product
           {
               Id = 5,
               CategoryId = 3,
               Title = "Slušalice + mikrofon MARSHALL Major III ",
               Description = "DRIVERS 40 mm,DRIVER TYPE Dynamic,DRIVER IMPEDANCE 32 OHM,DRIVER SENSITIVITY 97 dB SPL,FREQUENCY RESPONSE 20Hz-20kHz ",
               Image = "https://www.hgspot.hr/image/catalog/slike/126934-878.jpg ",
               Price = 1200,
               OriginalPrice = 1500,
           }
               );
        }
    }
}

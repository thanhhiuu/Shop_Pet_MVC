using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop_Pet.Models;

namespace Shop_Pet.Data
{
    public class Shop_PetContext : DbContext
    {
        public Shop_PetContext (DbContextOptions<Shop_PetContext> options)
            : base(options)
        {
        }

        public DbSet<Shop_Pet.Models.Accounts> Account { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accounts>().HasData(
                    new Accounts { Id="1", Name = "admin", Password = "123", Email="admin@gmail.com" , LoaiUser = 1 },
                    new Accounts { Id="2", Name = "hieu", Password = "123", Email="hieu@gmail.com" , LoaiUser = 0 }
                );
            modelBuilder.Entity<Categorycs>().HasData(
                   new Categorycs { Id = 1, NamePet = "Cat" ,  HienThi = "1"},
                   new Categorycs { Id = 2, NamePet = "Dog" ,  HienThi = "2"},
                   new Categorycs { Id = 3, NamePet = "Mouse", HienThi = "3"}
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, Name = "Husky", Gia = 200, ChuThich = "Khôn", ImageUrl = "dog1.png",  CategoryId = 2}, 
                    new Product { Id = 2, Name = "Mèo Ba Tư", Gia = 500, ChuThich = "Siêu đẹp", ImageUrl = "cat1.png",  CategoryId = 1}, 
                    new Product { Id = 3,Name = "Chuột Hamter", Gia = 1000, ChuThich = "Màu Xám", ImageUrl = "mouse1.png",  CategoryId = 3}
                );          
        }

        public DbSet<Shop_Pet.Models.Categorycs> Categorycs { get; set; } = default!;
    }
}

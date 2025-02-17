using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext:DbContext
    {
        // Veritabanına yansıyacak sınıflar (tablolar) burada yer alacak
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Product>  Products { get; set; }
        public DbSet<Order>  Orders { get; set; }
        public DbSet<Customer>  Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }


        /*
         *DbSet<Category>   ->  burada yer alan "Category" C# tarafında yer alan sınıf ismi 
         *Categories { get; set; }  -> burada yer alan "Categories" SQL tarafında yer alan tablo ismi 
         *Sınıf ile Tablo bir birine karışmasın diye böyle bir ayrım yapılmış
         */
    }
}

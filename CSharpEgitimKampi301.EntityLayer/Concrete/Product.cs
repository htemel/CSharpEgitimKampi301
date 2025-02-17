using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }

        public int CategoryI { get; set; } //her ürünün bir kategorisi olması gerektiği için ekliyoruz.
        public virtual Category Category { get; set; }// Category tablosunda ki değerlere ulaşmak için ekliyoruz.
        /*
         (Contect->Product->Category->CategoryName ulaşmak için bunu eklememiz gerekir. Ayrıca Categry tablosunuda bundan haberdar
          etmek için 
        "public List<Product> Products { get; set; }" 
        eklemeliyiz yoksa bir birinden haberdar olmazlar.
         */
        
        public List<Order> Orders { get; set; }// bu tabloya sen Order tablosu ile çalışcaksın diyoruz.
    }
}

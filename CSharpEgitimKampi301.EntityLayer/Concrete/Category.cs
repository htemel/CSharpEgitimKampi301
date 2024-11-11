  using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; } // Category sınıf adını kullanıp Id yazmalıyız yoksa birincil anahtar olarak algılamaz.
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; } //Product çoğul olarak elendi
    }
}
/*
 Field-Variable-Property
 */

/*
 * sınıfın içinde tanımlanırsa
 int x; -->Field

*sınıf için de aşağıdaki şekilde tanımlanırsa property
    public int x{get; set;} -->Property

*sınıf içinde ve metot içinde tanımlanırsa değişken
    void Test()
{
int x
}
 */
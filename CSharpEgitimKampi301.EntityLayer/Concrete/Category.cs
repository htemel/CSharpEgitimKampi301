using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }// bu tabloya sen Product tablosu ile çalışcaksın diyoruz.

    }
}


/*
 * Field-Variable-Property


* int x; -->Field (Direk sınıfın içinde tanımlanırsa bu bir "field" dir.

* public int x { get; set; } --> Property ( sınıf için de "x" get ve set ile tanımlanırsa  bu "property" olur)

* void text() { int x; } --> Variable  (bir sınıfta "x" metot içinde tanımlanırsa bu variable olur)


* Değerler veritabanına gönderilirken property olarak tanımlanması gerekir. (public string CategoryName { get; set; })
* birincil anahtar olarak tanımlayacağımız property sınıf ismi ile aynı olacak sonunda Id gelecek yoksa yanlış olur. Birincil anahtar olduğunu algılamaz. (public int CategoryId { get; set; })
* 

 */
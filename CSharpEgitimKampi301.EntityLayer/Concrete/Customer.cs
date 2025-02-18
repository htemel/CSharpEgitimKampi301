using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public List<Order> Orders { get; set; }// bu tabloya sen Order tablosu ile çalışcaksın diyoruz.
        public bool CustomerStatus { get; set; } // burayı sonra ekledik bunu veritabanına yansıtmak için console ekranında "add-migration 'mig1' " ile yeni bir migration ekliyecez sonra veritabanını güncelleyecez. Bunu console da DataAccessLayer seçip yapacaz.
        // mig1 migration oluştuktan sonra veritabanına yanstımak için console ekranında "update-database" çalıştıracaz

    }
}

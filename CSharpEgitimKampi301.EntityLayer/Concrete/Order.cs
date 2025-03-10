﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; } //hangi ürünü sattığımızı burdan bileceğiz
        public virtual Product Product { get; set; } // Product tablosunda ki değerlere ulaşmak için ekliyoruz.

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; } // Customer tablosunda ki değerlere ulaşmak için ekliyoruz.


    }
}

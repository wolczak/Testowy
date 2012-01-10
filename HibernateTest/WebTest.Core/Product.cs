using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebTest.Core
{
    public class Product
    {
        public virtual decimal ID { get; set; }

        public virtual string Name { get; set; }

        public virtual decimal Quantity { get; set; }

        public virtual decimal PriceID { get; set; }

        public virtual ProductPrice Price { get; set; }
    }
}

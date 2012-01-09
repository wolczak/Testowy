// -----------------------------------------------------------------------
// <copyright file="Product.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace HibernateTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Product
    {
        public virtual decimal ID { get; set; }

        public virtual string Name { get; set; }

        public virtual decimal Quantity { get; set; }
    }
}

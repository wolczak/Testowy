// -----------------------------------------------------------------------
// <copyright file="ProductPriceMap.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using FluentNHibernate.Mapping;
using WebTest.Core;

namespace WebTest.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class ProductPriceMap : ClassMap<ProductPrice>
    {
        public ProductPriceMap()
        {
            Table("Product_Price");
            Id(x => x.ID);
            Map(x => x.Price);
        }
    }
}

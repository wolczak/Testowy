// -----------------------------------------------------------------------
// <copyright file="ProductMap.cs" company="">
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
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Table("PRODUCT");
            Id(x => x.ID).Column("ID");
            Map(x => x.Name);
            Map(x => x.Quantity).Column("QUANTITY");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NHibernate;
using NHibernate.Cfg;
using WebTest.Core;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using WebTest.Data;

namespace WebTest
{
    public partial class _Default : System.Web.UI.Page
    {
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(OracleClientConfiguration.Oracle10.ConnectionString(c => c.FromAppSetting("ConnectionString")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProductMap>()).BuildSessionFactory();

            //Configuration config = new Configuration();
            //config.Configure();
            //return config.BuildSessionFactory();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //var configuration = new Configuration().Configure(Server.MapPath("hibernate.cfg.xml"));
            //configuration.AddAssembly("HibernateTest");

            var sessionFactory = CreateSessionFactory();
            var session = sessionFactory.OpenSession();

            var list = session.CreateCriteria<Product>().List<Product>();
            var prices = session.CreateCriteria<ProductPrice>().List<ProductPrice>();

            foreach (var l in list)
            {
                string price = l.Price != null ? l.Price.Price.ToString() : "- - -";
                Response.Write(string.Format("{0} | {1:40} | {2} | {3} | {4}", l.ID, l.Name, l.Quantity, price, "<br/ >"));
            }
        }
    }
}

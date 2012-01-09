using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate;

namespace HibernateTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new Configuration().Configure("hibernate.cfg.xml");
            //configuration.AddAssembly("HibernateTest");
            var sessionFactory = configuration.BuildSessionFactory();
            var session = sessionFactory.OpenSession();

            var list = session.CreateCriteria<Product>().List<Product>();

            foreach (var l in list)
            {
                Console.WriteLine("{0:3} | {1:40} | {2:4}", l.ID, l.Name, l.Quantity);
            }

            using(ITransaction trans = session.BeginTransaction())
            {
                Product product = new Product();

                product.Name = "dupa";
                product.Quantity = 66;

                session.Save(product);
                trans.Commit();
            }
            
            Console.Read();
            session.Close();
        }
    }
}

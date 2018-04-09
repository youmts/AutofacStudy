using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.CommonServiceLocator;
using AutofacModule;
using CommonServiceLocator;
using LibraryInterface;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new ConnectionModule()
            {
                Name = "alpha", 
                ConnectionString = "connect to my database alpha"
            });
            builder.RegisterModule(new ConnectionModule()
            {
                Name = "BETA",
                ConnectionString = "connect to my database BETA"
            });

            builder.RegisterModule(new ModelModule());

            IContainer container = builder.Build();
            var csl = new AutofacServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => csl);

            Execute();
        }

        private static void Execute()
        {
            var conn = ServiceLocator.Current.GetInstance<IConnection>("alpha");
            conn.Open();

            var conn2 = ServiceLocator.Current.GetInstance<IConnection>("BETA");
            conn2.Open();
        }
    }
}

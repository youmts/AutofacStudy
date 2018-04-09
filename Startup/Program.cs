using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using LibraryImplement;
using LibraryInterface;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Connection>().As<IConnection>();

            IContainer container = builder.Build();

            var conn = container.Resolve<IConnection>();
            conn.Open();
        }
    }
}

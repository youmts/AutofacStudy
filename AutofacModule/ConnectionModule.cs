using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extras.DynamicProxy;
using LibraryImplement;
using LibraryInterface;

namespace AutofacModule
{
    public class ConnectionModule : Module
    {
        public string Name { get; set; }
        public string ConnectionString { get; set; }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Connection>()
                .Named<IConnection>(Name)
                .WithParameter("connectionString", ConnectionString)
                .EnableInterfaceInterceptors()
                .InterceptedBy(typeof(CallLogger));

            builder.Register(c => new CallLogger());
        }
    }
}

using Autofac;
using Autofac.Extras.DynamicProxy;
using LibraryImplement;

namespace AutofacModule
{
    public class ModelModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Model>()
                .EnableClassInterceptors()
                .InterceptedBy(typeof(CallLogger));
            builder.Register(c => new CallLogger());
        }
    }
}
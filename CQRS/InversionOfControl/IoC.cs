using System.Reflection;
using Autofac;

namespace CQRS.InversionOfControl
{
    public class IoC
    {
        public static IContainer Container { get; private set; }

        public static void Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyTypes(Assembly.GetEntryAssembly()).AsSelf();
            builder.RegisterAssemblyModules(Assembly.GetEntryAssembly());

            Container = builder.Build();
        }
    }
}
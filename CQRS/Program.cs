using System;
using Autofac;
using CQRS.EventsTest;
using CQRS.InversionOfControl;

namespace CQRS
{
    class Program
    {
        static void Main(string[] args)
        {
            IoC.Configure();
            using (var container = IoC.Container.BeginLifetimeScope())
            {
                var main = container.Resolve<Main>();
                main.Start();
            }
        }
    }
}
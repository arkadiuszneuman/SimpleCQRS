using System;
using System.Collections.Generic;
using Autofac;
using CQRS.Core.Event;

namespace CQRS.InversionOfControl
{
    public class EventsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);
 
            builder.RegisterAssemblyTypes(ThisAssembly)
                .Where(x => x.IsAssignableTo<IHandleEvent>())
                .AsImplementedInterfaces()
                .SingleInstance();
 
            builder.Register<Func<Type, IEnumerable<IHandleEvent>>>(c =>
            {
                var ctx = c.Resolve<IComponentContext>();
                return t =>
                {
                    var handlerType = typeof(IHandleEvent<>).MakeGenericType(t);
                    var handlersCollectionType = typeof(IEnumerable<>).MakeGenericType(handlerType);
                    return (IEnumerable<IHandleEvent>)ctx.Resolve(handlersCollectionType);
                };
            });
 
            builder.RegisterType<EventsBus>()
                .AsImplementedInterfaces();
        }
    }
}
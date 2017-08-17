using System;

namespace CQRS.Core.Command
{
    public class CommandsBus : ICommandsBus
    {
        private readonly Func<Type, IHandleCommand> _handlersFactory;

        public CommandsBus(Func<Type, IHandleCommand> handlersFactory)
        {
            _handlersFactory = handlersFactory;
        }

        public void Send<TCommand>(TCommand command) where TCommand : ICommand
        {
            var hander = (IHandleCommand<TCommand>)_handlersFactory(typeof(TCommand));
            hander.Handle(command);
        }
    }
}
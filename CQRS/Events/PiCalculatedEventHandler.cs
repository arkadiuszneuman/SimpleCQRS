using CQRS.Commands;
using CQRS.Core.Command;
using CQRS.Core.Event;

namespace CQRS.Events
{
    public class PiCalculatedEventHandler : IHandleEvent<PiCalculatedEvent>
    {
        private readonly ICommandsBus _commandsBus;

        public PiCalculatedEventHandler(ICommandsBus commandsBus)
        {
            _commandsBus = commandsBus;
        }

        public void Handle(PiCalculatedEvent @event)
        {
            _commandsBus.Send(new WriteConsoleCommand(@event.Pi));
        }
    }
}
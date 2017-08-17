using CQRS.Core.Event;

namespace CQRS.Events
{
    public class PiCalculatedEvent : IEvent
    {
        public PiCalculatedEvent(string pi)
        {
            Pi = pi;
        }

        public string Pi { get; set; }
    }
}
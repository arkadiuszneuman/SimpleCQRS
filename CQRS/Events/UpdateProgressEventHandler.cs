using System;
using System.Threading.Tasks;
using CQRS.Core.Event;

namespace CQRS.Events
{
    public class UpdateProgressEventHandler : IHandleEvent<UpdateProgressEvent>
    {
        private long _lastPercentage = -1;

        public void Handle(UpdateProgressEvent @event)
        {
            int percentage = Convert.ToInt32(100.0 * @event.Progress / @event.Total);

            if (percentage != _lastPercentage)
            {
                _lastPercentage = percentage;
                Console.CursorLeft = 0;
                Console.Write(@event.Item + " [" + new string('=', percentage / 2) + "] " + percentage + "%");
            }
        }
    }
}
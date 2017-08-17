using CQRS.Core.Event;

namespace CQRS.Events
{
    public class UpdateProgressEvent : IEvent
    {
        public string Item { get; }
        public long Progress { get; }
        public long Total { get; }
        
        public UpdateProgressEvent(string item, long progress, long total)
        {
            Item = item;
            Progress = progress;
            Total = total;
        }
    }
}
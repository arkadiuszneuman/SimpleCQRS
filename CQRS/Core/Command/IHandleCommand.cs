namespace CQRS.Core.Command
{
    public interface IHandleCommand
    {
        
    }

    public interface IHandleCommand<TCommand> : IHandleCommand
    {
        void Handle(TCommand command);
    }
}
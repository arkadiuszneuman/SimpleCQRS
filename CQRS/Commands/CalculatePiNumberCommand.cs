using CQRS.Core.Command;

namespace CQRS.Commands
{
    public class CalculatePiNumberCommand : ICommand
    {
        public long Num { get; }

        public CalculatePiNumberCommand(long num)
        {
            Num = num;
        }
    }
}
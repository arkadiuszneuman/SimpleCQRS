using System;
using CQRS.Core.Command;

namespace CQRS.Commands
{
    public class WriteToConsoleCommandHandler : IHandleCommand<WriteConsoleCommand>
    {
        public void Handle(WriteConsoleCommand command)
        {
            Console.WriteLine(command.Text);
        }
    }
}
using CQRS.Core.Command;

namespace CQRS.Commands
{
    public class WriteConsoleCommand : ICommand
    {
        public string Text { get; set; }

        public WriteConsoleCommand(string text)
        {
            Text = text;
        }
    }
}
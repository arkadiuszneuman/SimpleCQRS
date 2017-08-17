using System;
using System.Threading;
using CQRS.Commands;
using CQRS.Core.Command;

namespace CQRS.EventsTest
{
    public class Main
    {
        private readonly ICommandsBus _commandsBus;

        public Main(ICommandsBus commandsBus)
        {
            _commandsBus = commandsBus;
        }

        public void Start()
        {
            _commandsBus.Send(new WriteConsoleCommand("Arek to mistrz"));
            _commandsBus.Send(new CalculatePiNumberCommand(1000));

//            for (int i = 0; i <= 100; i++)
//            {
//                Thread.Sleep(30);
//            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LimitedSizeStack;
namespace LimitedSizeStack.Command_pattern
{
    //Any mistake here

    public class Invoker<TItem>
    {
        private LimitedSizeStack<Command<TItem>> _commands;

        public Invoker(int undoLimit)
        {
            _commands = new LimitedSizeStack<Command<TItem>>(undoLimit);
        }

        public void SetCommand(Command<TItem> command)
        {
            //Next line maybe wrong
            command.Execute();
            _commands.Push(command);
        }

        public void Undo()
        {
            var command = _commands.Pop();
            command.Undo();
        }

        public bool CanUndo()
        {
            return _commands.Count > 0;
        }
    }
}

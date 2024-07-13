using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LimitedSizeStack;
namespace LimitedSizeStack.Command_pattern
{
    public class Invoker<TItem>
    {
        private LimitedSizeStack<Command<TItem>> _commands;

        public Invoker(int undoLimit)
        {
            _commands = new LimitedSizeStack<Command<TItem>>(undoLimit);
        }

        public void SetCommand(Command<TItem> command)
        {
            _commands.Push(command);
        }

        public void Run()
        {
            while(_commands.Count > 0)
            {
                var command = _commands.Pop();
                command.Execute();
            }
        }

        public void Undo()
        {
            _commands.Pop();
        }

        public bool CanUndo()
        {
            return _commands.Count > 0;
        }
    }
}

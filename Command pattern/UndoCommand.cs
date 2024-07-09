using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    internal class UndoCommand<T> : ICommand
    {
        LimitedSizeStack<T> limitedSizeStack;

        public UndoCommand(LimitedSizeStack<T> stack) 
        {
            limitedSizeStack = stack;
        }
        public bool CanUndo()
        {
            return limitedSizeStack.Count > 0;
        }

        public void Undo()
        {
            limitedSizeStack.Pop();
        }
    }
}

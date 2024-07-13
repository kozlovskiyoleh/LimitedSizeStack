using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    internal class RemoveCommand<TItem> : Command<TItem>
    {
        Receiver<TItem> receiver;
        LastRemovedElement<TItem> lastRemovedElement;
        int index;

        public RemoveCommand(Receiver<TItem> receiverSet, int index) 
        {
            receiver = receiverSet;
            this.index = index;
        }

        public override void Execute()
        {
            lastRemovedElement = new LastRemovedElement<TItem>(receiver.GetItem(index), index);
            receiver.RemoveItem(index);
        }

        public void Undo()
        {
            receiver.Insert(lastRemovedElement.Value, lastRemovedElement.Index);
        }
    }
}

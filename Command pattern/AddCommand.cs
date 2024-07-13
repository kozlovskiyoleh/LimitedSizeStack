using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    internal class AddCommand<TItem>: Command<TItem>
    {
        Receiver<TItem> receiver;
        TItem item;

        public AddCommand(Receiver<TItem> receiverSet, TItem item)
        {
            receiver = receiverSet;
            this.item = item;
        }

        public override void Execute()
        {
            receiver.AddItem(item);
        }

        public void Undo()
        {
            receiver.RemoveItem(receiver.LastElementIndex);
        }
    }
}

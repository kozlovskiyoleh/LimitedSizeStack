using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    internal class RemoveCommand<TItem> : Command<TItem>
    {
        Receiver<TItem> receiver;
        int index;

        public RemoveCommand(Receiver<TItem> receiverSet, int index) 
        {
            receiver = receiverSet;
            this.index = index;
        }

        public override void Execute()
        {
            receiver.RemoveItem(index);
        }
    }
}

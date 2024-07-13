using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimitedSizeStack.Command_pattern
{
    public class ListModel1<TItem>
    {
        public List<TItem> Items
        { 
            get 
            {
                return receiver._items;
            } 
        }

        public int UndoLimit;
        Invoker<TItem> invoker;
        Receiver<TItem> receiver = new();

        public ListModel1(int undoLimit) : this(new List<TItem>(), undoLimit)
        {

        }

        public ListModel1(List<TItem> items, int undoLimit)
        {
            UndoLimit = undoLimit;
            invoker = new Invoker<TItem>(undoLimit);
        }

        public void AddItem(TItem item)
        {
            var command = new AddCommand<TItem>(receiver, item);
            invoker.SetCommand(command);
        }

	    public void RemoveItem(int index)
	    {
		    var command = new RemoveCommand<TItem>(receiver, index);
            invoker.SetCommand(command);
        }

        public bool CanUndo()
        {
            return invoker.CanUndo();
        }

        public void Undo()
        {
            invoker.Undo();
        }
    }
}

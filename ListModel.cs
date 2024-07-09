using Microsoft.CodeAnalysis.CSharp.Syntax;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LimitedSizeStack;

public class ListModel<TItem>
{
	public List<TItem> Items { get; }
	public int UndoLimit;
	private LimitedSizeStack<TItem> saveChangesStack;
        
	public ListModel(int undoLimit) : this(new List<TItem>(), undoLimit)
	{
		
	}

	public ListModel(List<TItem> items, int undoLimit)
	{
		UndoLimit = undoLimit;
        saveChangesStack = new LimitedSizeStack<TItem>(undoLimit);
    }

	public void AddItem(TItem item)
    {
		//Items.Add(item);
        saveChangesStack.Push(item);
    }

	public void RemoveItem(int index)
	{
		Items.RemoveAt(index);
        //saveChangesStack.;
    }

	public bool CanUndo()
	{
		if(saveChangesStack.Count > 0 && UndoLimit > 0)
		{
			return true;
		}
		return false;
	}

	public void Undo()
	{
		saveChangesStack.Pop();
        UndoLimit--;
    }
}
using System;
using System.Collections.Generic;

namespace LimitedSizeStack;

public class LimitedSizeStack<T>
{
    private readonly int _limitSize;
	public readonly LinkedList<T> _stack = new();
    public int Count => _stack.Count;

    public LimitedSizeStack(int undoLimit)
	{
		_limitSize = undoLimit;
	}

	public void Push(T item)
	{
		if (_limitSize == 0) return;
		if (_stack.Count < _limitSize)
		{
			_stack.AddFirst(item);
		}
        else
        {
			_stack.RemoveLast();
			_stack.AddFirst(item);
        }
	}

	public T Pop()
	{
		var result = _stack.First.Value;
		_stack.RemoveFirst();
        return result;
	}
}
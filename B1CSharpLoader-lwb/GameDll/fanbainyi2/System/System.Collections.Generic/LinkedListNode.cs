using System.Runtime.InteropServices;

namespace System.Collections.Generic;

[ComVisible(false)]
[global::__DynamicallyInvokable]
public sealed class LinkedListNode<T>
{
	internal LinkedList<T> list;

	internal LinkedListNode<T> next;

	internal LinkedListNode<T> prev;

	internal T item;

	[global::__DynamicallyInvokable]
	public LinkedList<T> List
	{
		[global::__DynamicallyInvokable]
		get
		{
			return list;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> Next
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (next != null && next != list.head)
			{
				return next;
			}
			return null;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode<T> Previous
	{
		[global::__DynamicallyInvokable]
		get
		{
			if (prev != null && this != list.head)
			{
				return prev;
			}
			return null;
		}
	}

	[global::__DynamicallyInvokable]
	public T Value
	{
		[global::__DynamicallyInvokable]
		get
		{
			return item;
		}
		[global::__DynamicallyInvokable]
		set
		{
			item = value;
		}
	}

	[global::__DynamicallyInvokable]
	public LinkedListNode(T value)
	{
		item = value;
	}

	internal LinkedListNode(LinkedList<T> list, T value)
	{
		this.list = list;
		item = value;
	}

	internal void Invalidate()
	{
		list = null;
		next = null;
		prev = null;
	}
}

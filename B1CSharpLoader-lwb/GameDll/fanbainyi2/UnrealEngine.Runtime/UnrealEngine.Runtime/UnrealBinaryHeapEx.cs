using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class UnrealBinaryHeapEx<T> where T : BinaryHeapItem, IComparable<T>
{
	private List<T> items;

	public int Count => items.Count;

	public UnrealBinaryHeapEx()
	{
		items = new List<T>();
	}

	public UnrealBinaryHeapEx(int capacity)
	{
		items = new List<T>(capacity);
	}

	public List<T> ToList()
	{
		return new List<T>(items);
	}

	public List<T> GetList()
	{
		return items;
	}

	public int HeapPush(T item)
	{
		items.Add(item);
		return item.BinaryHeapIndex = SiftUp(0, Count - 1);
	}

	public T HeapPop()
	{
		T result = items[0];
		RemoveAtSwap(0);
		SiftDown(0, Count);
		return result;
	}

	public void HeapPopDiscard()
	{
		RemoveAtSwap(0);
		SiftDown(0, Count);
	}

	public T HeapTop()
	{
		return items[0];
	}

	private void HeapRemoveAt(int index)
	{
		RemoveAtSwap(index);
		SiftDown(index, Count);
		SiftUp(0, Math.Min(index, Count - 1));
	}

	public void HeapRemove(T item)
	{
		HeapRemoveAt(item.BinaryHeapIndex);
	}

	public bool VerifyHeap()
	{
		for (int i = 1; i < Count; i++)
		{
			int indexB = HeapGetParentIndex(i);
			if (Predicate(i, indexB))
			{
				return false;
			}
		}
		return true;
	}

	private void Heapify()
	{
		for (int num = HeapGetParentIndex(Count - 1); num >= 0; num--)
		{
			SiftDown(num, Count);
		}
	}

	private int HeapGetLeftChildIndex(int index)
	{
		return index * 2 + 1;
	}

	private bool HeapIsLeaf(int index, int count)
	{
		return HeapGetLeftChildIndex(index) >= count;
	}

	private int HeapGetParentIndex(int index)
	{
		return (index - 1) / 2;
	}

	private void RemoveAtSwap(int index)
	{
		items[index].BinaryHeapIndex = -1;
		items[items.Count - 1].BinaryHeapIndex = index;
		items[index] = items[items.Count - 1];
		items.RemoveAt(items.Count - 1);
	}

	private void HeapSort()
	{
		Heapify();
		for (int num = Count - 1; num > 0; num--)
		{
			Exchange(0, num);
			SiftDown(0, num);
		}
	}

	private void SiftDown(int index, int count)
	{
		while (!HeapIsLeaf(index, count))
		{
			int num = HeapGetLeftChildIndex(index);
			int num2 = num + 1;
			int num3 = num;
			if (num2 < count)
			{
				num3 = (Predicate(num, num2) ? num : num2);
			}
			if (Predicate(num3, index))
			{
				Exchange(index, num3);
				index = num3;
				continue;
			}
			break;
		}
	}

	private int SiftUp(int rootIndex, int nodeIndex)
	{
		while (nodeIndex > rootIndex)
		{
			int num = HeapGetParentIndex(nodeIndex);
			if (!Predicate(nodeIndex, num))
			{
				break;
			}
			Exchange(nodeIndex, num);
			nodeIndex = num;
		}
		return nodeIndex;
	}

	private void Exchange(int indexA, int indexB)
	{
		T value = items[indexA];
		items[indexA] = items[indexB];
		items[indexB] = value;
		items[indexA].BinaryHeapIndex = indexA;
		items[indexB].BinaryHeapIndex = indexB;
	}

	private bool Predicate(int indexA, int indexB)
	{
		return items[indexA].CompareTo(items[indexB]) < 0;
	}
}

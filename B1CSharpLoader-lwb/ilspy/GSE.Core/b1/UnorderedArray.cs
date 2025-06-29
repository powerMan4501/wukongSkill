using System;
using System.Collections.Generic;

namespace b1;

public class UnorderedArray<T>
{
	private int mItrIdx;

	private int mArrayLen = 4;

	private int mSize;

	private T[] mLoopArr = new T[4];

	public T this[int Idx]
	{
		get
		{
			return mLoopArr[Idx];
		}
		set
		{
			mLoopArr[Idx] = value;
		}
	}

	public UnorderedArray()
	{
		mLoopArr = new T[4];
	}

	public UnorderedArray(int initLen)
	{
		if (initLen > 0)
		{
			mArrayLen = initLen;
		}
		mLoopArr = new T[mArrayLen];
	}

	private void ExpandArray()
	{
		int num = mArrayLen * 2;
		T[] destinationArray = new T[num];
		Array.Copy(mLoopArr, destinationArray, mArrayLen);
		mArrayLen = num;
		mLoopArr = destinationArray;
	}

	public int Remove(T value)
	{
		for (int i = 0; i < mSize; i++)
		{
			ref readonly T reference = ref mLoopArr[i];
			object obj = value;
			if (reference.Equals(obj))
			{
				RemoveAt(i);
				return i;
			}
		}
		return -1;
	}

	public void Remove()
	{
		if (mItrIdx > 0 && mItrIdx <= mSize)
		{
			RemoveAt(mItrIdx - 1);
		}
	}

	public void Remove(out T RemoveItem)
	{
		if (mItrIdx > 0 && mItrIdx <= mSize)
		{
			RemoveItem = mLoopArr[mItrIdx - 1];
			RemoveAt(mItrIdx - 1);
		}
		else
		{
			RemoveItem = default(T);
		}
	}

	public void RemoveAt(int idx)
	{
		if (idx >= 0 || idx < mSize)
		{
			mLoopArr[idx] = mLoopArr[mSize - 1];
			mLoopArr[mSize - 1] = default(T);
			if (idx < mItrIdx)
			{
				mItrIdx--;
			}
			mSize--;
		}
	}

	public int GetSize()
	{
		return mSize;
	}

	public void Add(T value)
	{
		if (value != null)
		{
			if (mSize >= mArrayLen)
			{
				ExpandArray();
			}
			int num = mSize;
			mSize++;
			mLoopArr[num] = value;
		}
	}

	public void BeginItr()
	{
		mItrIdx = 0;
	}

	public bool NextItr(out T output)
	{
		bool result = false;
		if (mItrIdx >= mSize)
		{
			output = default(T);
		}
		else
		{
			output = mLoopArr[mItrIdx];
			result = true;
		}
		mItrIdx++;
		return result;
	}

	public void Clear()
	{
		mItrIdx = 0;
		mSize = 0;
		for (int i = 0; i < mArrayLen; i++)
		{
			mLoopArr[i] = default(T);
		}
	}

	public T Get(int Idx)
	{
		return mLoopArr[Idx];
	}

	public T Set(int Idx, T Value)
	{
		mLoopArr[Idx] = Value;
		return mLoopArr[Idx];
	}

	public void Sort(IComparer<T> Comparer)
	{
		Array.Sort(mLoopArr, 0, mSize, Comparer);
	}
}

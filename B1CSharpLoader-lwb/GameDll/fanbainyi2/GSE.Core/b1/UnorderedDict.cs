using System;
using System.Collections.Generic;

namespace b1;

public class UnorderedDict<TKey, TValue>
{
	private int mItrIdx;

	private int mArrayLen = 4;

	private int mSize;

	private Dictionary<TKey, int> mKey2Idx = new Dictionary<TKey, int>();

	private TKey[] mIdx2Key = new TKey[4];

	private TValue[] mLoopArr = new TValue[4];

	public TValue this[TKey key]
	{
		get
		{
			if (Find(key, out var output))
			{
				return output;
			}
			throw new IndexOutOfRangeException();
		}
		set
		{
			Set(key, value);
		}
	}

	public UnorderedDict()
	{
		mIdx2Key = new TKey[4];
		mLoopArr = new TValue[4];
	}

	public UnorderedDict(int initLen)
	{
		mArrayLen = initLen;
		mIdx2Key = new TKey[mArrayLen];
		mLoopArr = new TValue[mArrayLen];
	}

	private void ExpandArray()
	{
		int num = mArrayLen * 2;
		TKey[] destinationArray = new TKey[num];
		TValue[] destinationArray2 = new TValue[num];
		Array.Copy(mIdx2Key, destinationArray, mArrayLen);
		Array.Copy(mLoopArr, destinationArray2, mArrayLen);
		mArrayLen = num;
		mIdx2Key = destinationArray;
		mLoopArr = destinationArray2;
	}

	public void Remove()
	{
		if (mItrIdx > 0 && mItrIdx <= mSize)
		{
			Remove(mIdx2Key[mItrIdx - 1]);
		}
	}

	public void Remove(TKey key)
	{
		int value = -1;
		if (mKey2Idx.TryGetValue(key, out value) && (value >= 0 || value < mSize))
		{
			TKey val = mIdx2Key[mSize - 1];
			mLoopArr[value] = mLoopArr[mSize - 1];
			mLoopArr[mSize - 1] = default(TValue);
			mIdx2Key[value] = val;
			mIdx2Key[mSize - 1] = default(TKey);
			mKey2Idx[val] = value;
			mKey2Idx.Remove(key);
			if (value < mItrIdx)
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

	public bool Find(TKey key, out TValue output)
	{
		int value = -1;
		if (mKey2Idx.TryGetValue(key, out value))
		{
			output = mLoopArr[value];
			return true;
		}
		output = default(TValue);
		return false;
	}

	public void Set(TKey key, TValue value)
	{
		if (key == null)
		{
			return;
		}
		if (value == null)
		{
			Remove(key);
			return;
		}
		int value2 = -1;
		if (mKey2Idx.TryGetValue(key, out value2))
		{
			mLoopArr[value2] = value;
			return;
		}
		if (mSize >= mArrayLen)
		{
			ExpandArray();
		}
		int num = mSize;
		mSize++;
		mLoopArr[num] = value;
		mKey2Idx[key] = num;
		mIdx2Key[num] = key;
	}

	public void BeginItr()
	{
		mItrIdx = 0;
	}

	public bool NextItr(ref int CurIdx, out TKey oKey, out TValue oVal)
	{
		bool result = false;
		if (CurIdx >= mSize)
		{
			oKey = default(TKey);
			oVal = default(TValue);
		}
		else
		{
			oKey = mIdx2Key[CurIdx];
			oVal = mLoopArr[CurIdx];
			result = true;
		}
		CurIdx++;
		return result;
	}

	public bool NextItr(out TKey oKey, out TValue oVal)
	{
		bool result = false;
		if (mItrIdx >= mSize)
		{
			oKey = default(TKey);
			oVal = default(TValue);
		}
		else
		{
			oKey = mIdx2Key[mItrIdx];
			oVal = mLoopArr[mItrIdx];
			result = true;
		}
		mItrIdx++;
		return result;
	}

	public bool NextItr(out TValue output)
	{
		bool result = false;
		if (mItrIdx >= mSize)
		{
			output = default(TValue);
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
		mKey2Idx.Clear();
		mItrIdx = 0;
		mSize = 0;
		for (int i = 0; i < mArrayLen; i++)
		{
			mIdx2Key[i] = default(TKey);
			mLoopArr[i] = default(TValue);
		}
	}
}

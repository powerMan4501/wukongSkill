using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPrimitiveList<T> : IEnumerable<T>, IEnumerable
{
	private RepeatedField<T> mData;

	public T this[int Index] => mData[Index];

	public int Count => mData.Count;

	public ReadOnlyPrimitiveList(RepeatedField<T> pbData)
	{
		mData = pbData;
	}

	public RepeatedField<T> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<T> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<T> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return mData[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyServerMailDataList : IEnumerable<ReadOnlyServerMailData>, IEnumerable
{
	private RepeatedField<ServerMailData> mData;

	public ReadOnlyServerMailData this[int Index] => new ReadOnlyServerMailData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyServerMailDataList(RepeatedField<ServerMailData> data)
	{
		mData = data;
	}

	public RepeatedField<ServerMailData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ServerMailData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyServerMailData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyServerMailData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

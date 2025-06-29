using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyServerMailContentList : IEnumerable<ReadOnlyServerMailContent>, IEnumerable
{
	private RepeatedField<ServerMailContent> mData;

	public ReadOnlyServerMailContent this[int Index] => new ReadOnlyServerMailContent(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyServerMailContentList(RepeatedField<ServerMailContent> data)
	{
		mData = data;
	}

	public RepeatedField<ServerMailContent> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ServerMailContent> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyServerMailContent> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyServerMailContent(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

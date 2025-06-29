using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPlayerMailContentList : IEnumerable<ReadOnlyPlayerMailContent>, IEnumerable
{
	private RepeatedField<PlayerMailContent> mData;

	public ReadOnlyPlayerMailContent this[int Index] => new ReadOnlyPlayerMailContent(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPlayerMailContentList(RepeatedField<PlayerMailContent> data)
	{
		mData = data;
	}

	public RepeatedField<PlayerMailContent> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PlayerMailContent> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPlayerMailContent> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPlayerMailContent(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

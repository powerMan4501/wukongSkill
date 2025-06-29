using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwardItemList : IEnumerable<ReadOnlyAwardItem>, IEnumerable
{
	private RepeatedField<AwardItem> mData;

	public ReadOnlyAwardItem this[int Index] => new ReadOnlyAwardItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwardItemList(RepeatedField<AwardItem> data)
	{
		mData = data;
	}

	public RepeatedField<AwardItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwardItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwardItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwardItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

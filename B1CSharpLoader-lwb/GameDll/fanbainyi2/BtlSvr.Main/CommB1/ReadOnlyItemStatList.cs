using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyItemStatList : IEnumerable<ReadOnlyItemStat>, IEnumerable
{
	private RepeatedField<ItemStat> mData;

	public ReadOnlyItemStat this[int Index] => new ReadOnlyItemStat(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyItemStatList(RepeatedField<ItemStat> data)
	{
		mData = data;
	}

	public RepeatedField<ItemStat> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ItemStat> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyItemStat> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyItemStat(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

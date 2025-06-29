using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAttrItemList : IEnumerable<ReadOnlyAttrItem>, IEnumerable
{
	private RepeatedField<AttrItem> mData;

	public ReadOnlyAttrItem this[int Index] => new ReadOnlyAttrItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAttrItemList(RepeatedField<AttrItem> data)
	{
		mData = data;
	}

	public RepeatedField<AttrItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AttrItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAttrItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAttrItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

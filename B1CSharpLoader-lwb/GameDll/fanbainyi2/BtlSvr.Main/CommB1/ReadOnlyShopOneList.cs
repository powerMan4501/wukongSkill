using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShopOneList : IEnumerable<ReadOnlyShopOne>, IEnumerable
{
	private RepeatedField<ShopOne> mData;

	public ReadOnlyShopOne this[int Index] => new ReadOnlyShopOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyShopOneList(RepeatedField<ShopOne> data)
	{
		mData = data;
	}

	public RepeatedField<ShopOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ShopOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyShopOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyShopOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

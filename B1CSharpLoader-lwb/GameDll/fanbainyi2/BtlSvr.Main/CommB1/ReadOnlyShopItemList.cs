using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShopItemList : IEnumerable<ReadOnlyShopItem>, IEnumerable
{
	private RepeatedField<ShopItem> mData;

	public ReadOnlyShopItem this[int Index] => new ReadOnlyShopItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyShopItemList(RepeatedField<ShopItem> data)
	{
		mData = data;
	}

	public RepeatedField<ShopItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ShopItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyShopItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyShopItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

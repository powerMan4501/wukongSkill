using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShopBuyRecordList : IEnumerable<ReadOnlyShopBuyRecord>, IEnumerable
{
	private RepeatedField<ShopBuyRecord> mData;

	public ReadOnlyShopBuyRecord this[int Index] => new ReadOnlyShopBuyRecord(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyShopBuyRecordList(RepeatedField<ShopBuyRecord> data)
	{
		mData = data;
	}

	public RepeatedField<ShopBuyRecord> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ShopBuyRecord> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyShopBuyRecord> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyShopBuyRecord(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

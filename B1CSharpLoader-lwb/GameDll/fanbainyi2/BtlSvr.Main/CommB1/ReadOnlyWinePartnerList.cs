using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyWinePartnerList : IEnumerable<ReadOnlyWinePartner>, IEnumerable
{
	private RepeatedField<WinePartner> mData;

	public ReadOnlyWinePartner this[int Index] => new ReadOnlyWinePartner(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyWinePartnerList(RepeatedField<WinePartner> data)
	{
		mData = data;
	}

	public RepeatedField<WinePartner> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<WinePartner> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyWinePartner> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyWinePartner(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyDataList : IEnumerable<ReadOnlyPartyData>, IEnumerable
{
	private RepeatedField<PartyData> mData;

	public ReadOnlyPartyData this[int Index] => new ReadOnlyPartyData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyDataList(RepeatedField<PartyData> data)
	{
		mData = data;
	}

	public RepeatedField<PartyData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

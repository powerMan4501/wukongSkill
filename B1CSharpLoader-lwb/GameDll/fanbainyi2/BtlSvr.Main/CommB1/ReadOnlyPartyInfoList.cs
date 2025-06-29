using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyInfoList : IEnumerable<ReadOnlyPartyInfo>, IEnumerable
{
	private RepeatedField<PartyInfo> mData;

	public ReadOnlyPartyInfo this[int Index] => new ReadOnlyPartyInfo(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyInfoList(RepeatedField<PartyInfo> data)
	{
		mData = data;
	}

	public RepeatedField<PartyInfo> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyInfo> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyInfo> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyInfo(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyTaskParamList : IEnumerable<ReadOnlyPartyTaskParam>, IEnumerable
{
	private RepeatedField<PartyTaskParam> mData;

	public ReadOnlyPartyTaskParam this[int Index] => new ReadOnlyPartyTaskParam(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyTaskParamList(RepeatedField<PartyTaskParam> data)
	{
		mData = data;
	}

	public RepeatedField<PartyTaskParam> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyTaskParam> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyTaskParam> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyTaskParam(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

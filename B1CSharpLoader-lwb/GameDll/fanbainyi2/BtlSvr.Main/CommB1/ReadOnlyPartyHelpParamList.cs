using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyHelpParamList : IEnumerable<ReadOnlyPartyHelpParam>, IEnumerable
{
	private RepeatedField<PartyHelpParam> mData;

	public ReadOnlyPartyHelpParam this[int Index] => new ReadOnlyPartyHelpParam(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyHelpParamList(RepeatedField<PartyHelpParam> data)
	{
		mData = data;
	}

	public RepeatedField<PartyHelpParam> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyHelpParam> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyHelpParam> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyHelpParam(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

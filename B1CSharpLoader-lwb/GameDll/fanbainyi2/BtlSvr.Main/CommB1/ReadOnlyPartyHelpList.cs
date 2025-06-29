using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyHelpList : IEnumerable<ReadOnlyPartyHelp>, IEnumerable
{
	private RepeatedField<PartyHelp> mData;

	public ReadOnlyPartyHelp this[int Index] => new ReadOnlyPartyHelp(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyHelpList(RepeatedField<PartyHelp> data)
	{
		mData = data;
	}

	public RepeatedField<PartyHelp> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyHelp> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyHelp> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyHelp(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

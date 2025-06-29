using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyMemberList : IEnumerable<ReadOnlyPartyMember>, IEnumerable
{
	private RepeatedField<PartyMember> mData;

	public ReadOnlyPartyMember this[int Index] => new ReadOnlyPartyMember(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyMemberList(RepeatedField<PartyMember> data)
	{
		mData = data;
	}

	public RepeatedField<PartyMember> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyMember> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyMember> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyMember(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartyTaskList : IEnumerable<ReadOnlyPartyTask>, IEnumerable
{
	private RepeatedField<PartyTask> mData;

	public ReadOnlyPartyTask this[int Index] => new ReadOnlyPartyTask(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartyTaskList(RepeatedField<PartyTask> data)
	{
		mData = data;
	}

	public RepeatedField<PartyTask> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartyTask> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartyTask> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartyTask(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

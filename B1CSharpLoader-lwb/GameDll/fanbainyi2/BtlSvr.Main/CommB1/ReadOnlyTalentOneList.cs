using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyTalentOneList : IEnumerable<ReadOnlyTalentOne>, IEnumerable
{
	private RepeatedField<TalentOne> mData;

	public ReadOnlyTalentOne this[int Index] => new ReadOnlyTalentOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyTalentOneList(RepeatedField<TalentOne> data)
	{
		mData = data;
	}

	public RepeatedField<TalentOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<TalentOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyTalentOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyTalentOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

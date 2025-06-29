using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyArchiveStaticsOneList : IEnumerable<ReadOnlyArchiveStaticsOne>, IEnumerable
{
	private RepeatedField<ArchiveStaticsOne> mData;

	public ReadOnlyArchiveStaticsOne this[int Index] => new ReadOnlyArchiveStaticsOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyArchiveStaticsOneList(RepeatedField<ArchiveStaticsOne> data)
	{
		mData = data;
	}

	public RepeatedField<ArchiveStaticsOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ArchiveStaticsOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyArchiveStaticsOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyArchiveStaticsOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

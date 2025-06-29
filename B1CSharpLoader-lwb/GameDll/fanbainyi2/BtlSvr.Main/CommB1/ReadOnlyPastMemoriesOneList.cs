using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPastMemoriesOneList : IEnumerable<ReadOnlyPastMemoriesOne>, IEnumerable
{
	private RepeatedField<PastMemoriesOne> mData;

	public ReadOnlyPastMemoriesOne this[int Index] => new ReadOnlyPastMemoriesOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPastMemoriesOneList(RepeatedField<PastMemoriesOne> data)
	{
		mData = data;
	}

	public RepeatedField<PastMemoriesOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PastMemoriesOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPastMemoriesOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPastMemoriesOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

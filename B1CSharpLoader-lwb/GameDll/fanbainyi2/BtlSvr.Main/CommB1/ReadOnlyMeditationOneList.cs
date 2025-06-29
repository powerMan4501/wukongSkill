using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMeditationOneList : IEnumerable<ReadOnlyMeditationOne>, IEnumerable
{
	private RepeatedField<MeditationOne> mData;

	public ReadOnlyMeditationOne this[int Index] => new ReadOnlyMeditationOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMeditationOneList(RepeatedField<MeditationOne> data)
	{
		mData = data;
	}

	public RepeatedField<MeditationOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MeditationOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMeditationOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMeditationOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

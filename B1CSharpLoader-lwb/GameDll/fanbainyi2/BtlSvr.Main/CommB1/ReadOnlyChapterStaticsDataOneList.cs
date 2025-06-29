using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyChapterStaticsDataOneList : IEnumerable<ReadOnlyChapterStaticsDataOne>, IEnumerable
{
	private RepeatedField<ChapterStaticsDataOne> mData;

	public ReadOnlyChapterStaticsDataOne this[int Index] => new ReadOnlyChapterStaticsDataOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyChapterStaticsDataOneList(RepeatedField<ChapterStaticsDataOne> data)
	{
		mData = data;
	}

	public RepeatedField<ChapterStaticsDataOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ChapterStaticsDataOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyChapterStaticsDataOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyChapterStaticsDataOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyChapterDataList : IEnumerable<ReadOnlyChapterData>, IEnumerable
{
	private RepeatedField<ChapterData> mData;

	public ReadOnlyChapterData this[int Index] => new ReadOnlyChapterData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyChapterDataList(RepeatedField<ChapterData> data)
	{
		mData = data;
	}

	public RepeatedField<ChapterData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ChapterData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyChapterData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyChapterData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

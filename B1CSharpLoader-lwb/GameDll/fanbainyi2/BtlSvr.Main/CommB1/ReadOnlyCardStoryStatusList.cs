using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCardStoryStatusList : IEnumerable<ReadOnlyCardStoryStatus>, IEnumerable
{
	private RepeatedField<CardStoryStatus> mData;

	public ReadOnlyCardStoryStatus this[int Index] => new ReadOnlyCardStoryStatus(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCardStoryStatusList(RepeatedField<CardStoryStatus> data)
	{
		mData = data;
	}

	public RepeatedField<CardStoryStatus> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CardStoryStatus> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCardStoryStatus> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCardStoryStatus(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

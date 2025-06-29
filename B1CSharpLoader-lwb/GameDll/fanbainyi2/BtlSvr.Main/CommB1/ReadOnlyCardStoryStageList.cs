using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCardStoryStageList : IEnumerable<ReadOnlyCardStoryStage>, IEnumerable
{
	private RepeatedField<CardStoryStage> mData;

	public ReadOnlyCardStoryStage this[int Index] => new ReadOnlyCardStoryStage(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCardStoryStageList(RepeatedField<CardStoryStage> data)
	{
		mData = data;
	}

	public RepeatedField<CardStoryStage> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CardStoryStage> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCardStoryStage> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCardStoryStage(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

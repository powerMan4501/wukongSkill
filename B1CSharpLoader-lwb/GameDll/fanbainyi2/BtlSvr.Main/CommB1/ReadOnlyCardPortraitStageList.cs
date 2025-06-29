using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCardPortraitStageList : IEnumerable<ReadOnlyCardPortraitStage>, IEnumerable
{
	private RepeatedField<CardPortraitStage> mData;

	public ReadOnlyCardPortraitStage this[int Index] => new ReadOnlyCardPortraitStage(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCardPortraitStageList(RepeatedField<CardPortraitStage> data)
	{
		mData = data;
	}

	public RepeatedField<CardPortraitStage> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CardPortraitStage> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCardPortraitStage> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCardPortraitStage(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

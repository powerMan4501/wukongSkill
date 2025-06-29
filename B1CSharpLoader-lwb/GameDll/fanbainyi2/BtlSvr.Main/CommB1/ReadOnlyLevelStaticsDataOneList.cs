using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLevelStaticsDataOneList : IEnumerable<ReadOnlyLevelStaticsDataOne>, IEnumerable
{
	private RepeatedField<LevelStaticsDataOne> mData;

	public ReadOnlyLevelStaticsDataOne this[int Index] => new ReadOnlyLevelStaticsDataOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyLevelStaticsDataOneList(RepeatedField<LevelStaticsDataOne> data)
	{
		mData = data;
	}

	public RepeatedField<LevelStaticsDataOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<LevelStaticsDataOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyLevelStaticsDataOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyLevelStaticsDataOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

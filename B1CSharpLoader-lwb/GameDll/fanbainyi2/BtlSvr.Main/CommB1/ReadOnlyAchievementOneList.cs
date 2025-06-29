using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAchievementOneList : IEnumerable<ReadOnlyAchievementOne>, IEnumerable
{
	private RepeatedField<AchievementOne> mData;

	public ReadOnlyAchievementOne this[int Index] => new ReadOnlyAchievementOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAchievementOneList(RepeatedField<AchievementOne> data)
	{
		mData = data;
	}

	public RepeatedField<AchievementOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AchievementOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAchievementOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAchievementOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

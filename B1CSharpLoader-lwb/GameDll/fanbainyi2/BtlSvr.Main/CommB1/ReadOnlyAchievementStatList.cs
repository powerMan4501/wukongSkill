using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAchievementStatList : IEnumerable<ReadOnlyAchievementStat>, IEnumerable
{
	private RepeatedField<AchievementStat> mData;

	public ReadOnlyAchievementStat this[int Index] => new ReadOnlyAchievementStat(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAchievementStatList(RepeatedField<AchievementStat> data)
	{
		mData = data;
	}

	public RepeatedField<AchievementStat> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AchievementStat> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAchievementStat> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAchievementStat(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

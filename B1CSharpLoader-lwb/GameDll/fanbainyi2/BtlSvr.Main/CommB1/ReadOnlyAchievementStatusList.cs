using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAchievementStatusList : IEnumerable<ReadOnlyAchievementStatus>, IEnumerable
{
	private RepeatedField<AchievementStatus> mData;

	public ReadOnlyAchievementStatus this[int Index] => new ReadOnlyAchievementStatus(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAchievementStatusList(RepeatedField<AchievementStatus> data)
	{
		mData = data;
	}

	public RepeatedField<AchievementStatus> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AchievementStatus> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAchievementStatus> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAchievementStatus(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

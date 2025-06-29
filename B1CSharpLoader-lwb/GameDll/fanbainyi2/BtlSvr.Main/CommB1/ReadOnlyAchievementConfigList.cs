using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAchievementConfigList : IEnumerable<ReadOnlyAchievementConfig>, IEnumerable
{
	private RepeatedField<AchievementConfig> mData;

	public ReadOnlyAchievementConfig this[int Index] => new ReadOnlyAchievementConfig(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAchievementConfigList(RepeatedField<AchievementConfig> data)
	{
		mData = data;
	}

	public RepeatedField<AchievementConfig> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AchievementConfig> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAchievementConfig> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAchievementConfig(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushContinuousFightGroupList : IEnumerable<ReadOnlyBossRushContinuousFightGroup>, IEnumerable
{
	private RepeatedField<BossRushContinuousFightGroup> mData;

	public ReadOnlyBossRushContinuousFightGroup this[int Index] => new ReadOnlyBossRushContinuousFightGroup(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushContinuousFightGroupList(RepeatedField<BossRushContinuousFightGroup> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushContinuousFightGroup> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushContinuousFightGroup> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushContinuousFightGroup> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushContinuousFightGroup(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

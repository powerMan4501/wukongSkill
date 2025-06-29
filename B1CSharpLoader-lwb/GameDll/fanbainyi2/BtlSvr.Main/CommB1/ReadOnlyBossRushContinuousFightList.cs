using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushContinuousFightList : IEnumerable<ReadOnlyBossRushContinuousFight>, IEnumerable
{
	private RepeatedField<BossRushContinuousFight> mData;

	public ReadOnlyBossRushContinuousFight this[int Index] => new ReadOnlyBossRushContinuousFight(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushContinuousFightList(RepeatedField<BossRushContinuousFight> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushContinuousFight> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushContinuousFight> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushContinuousFight> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushContinuousFight(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

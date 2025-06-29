using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushRefightBossList : IEnumerable<ReadOnlyBossRushRefightBoss>, IEnumerable
{
	private RepeatedField<BossRushRefightBoss> mData;

	public ReadOnlyBossRushRefightBoss this[int Index] => new ReadOnlyBossRushRefightBoss(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushRefightBossList(RepeatedField<BossRushRefightBoss> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushRefightBoss> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushRefightBoss> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushRefightBoss> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushRefightBoss(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

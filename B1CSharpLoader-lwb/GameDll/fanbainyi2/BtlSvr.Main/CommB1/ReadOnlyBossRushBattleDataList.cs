using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushBattleDataList : IEnumerable<ReadOnlyBossRushBattleData>, IEnumerable
{
	private RepeatedField<BossRushBattleData> mData;

	public ReadOnlyBossRushBattleData this[int Index] => new ReadOnlyBossRushBattleData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushBattleDataList(RepeatedField<BossRushBattleData> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushBattleData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushBattleData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushBattleData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushBattleData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

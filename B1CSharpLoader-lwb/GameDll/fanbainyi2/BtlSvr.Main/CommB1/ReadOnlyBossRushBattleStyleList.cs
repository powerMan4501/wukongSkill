using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushBattleStyleList : IEnumerable<ReadOnlyBossRushBattleStyle>, IEnumerable
{
	private RepeatedField<BossRushBattleStyle> mData;

	public ReadOnlyBossRushBattleStyle this[int Index] => new ReadOnlyBossRushBattleStyle(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushBattleStyleList(RepeatedField<BossRushBattleStyle> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushBattleStyle> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushBattleStyle> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushBattleStyle> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushBattleStyle(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

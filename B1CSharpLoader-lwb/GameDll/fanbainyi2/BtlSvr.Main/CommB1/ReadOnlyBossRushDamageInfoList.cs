using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushDamageInfoList : IEnumerable<ReadOnlyBossRushDamageInfo>, IEnumerable
{
	private RepeatedField<BossRushDamageInfo> mData;

	public ReadOnlyBossRushDamageInfo this[int Index] => new ReadOnlyBossRushDamageInfo(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushDamageInfoList(RepeatedField<BossRushDamageInfo> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushDamageInfo> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushDamageInfo> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushDamageInfo> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushDamageInfo(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

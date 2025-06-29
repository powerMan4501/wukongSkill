using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushContinuousFightRecordList : IEnumerable<ReadOnlyBossRushContinuousFightRecord>, IEnumerable
{
	private RepeatedField<BossRushContinuousFightRecord> mData;

	public ReadOnlyBossRushContinuousFightRecord this[int Index] => new ReadOnlyBossRushContinuousFightRecord(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushContinuousFightRecordList(RepeatedField<BossRushContinuousFightRecord> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushContinuousFightRecord> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushContinuousFightRecord> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushContinuousFightRecord> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushContinuousFightRecord(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

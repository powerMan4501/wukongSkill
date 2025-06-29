using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushRefightRecordList : IEnumerable<ReadOnlyBossRushRefightRecord>, IEnumerable
{
	private RepeatedField<BossRushRefightRecord> mData;

	public ReadOnlyBossRushRefightRecord this[int Index] => new ReadOnlyBossRushRefightRecord(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushRefightRecordList(RepeatedField<BossRushRefightRecord> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushRefightRecord> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushRefightRecord> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushRefightRecord> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushRefightRecord(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushRefightList : IEnumerable<ReadOnlyBossRushRefight>, IEnumerable
{
	private RepeatedField<BossRushRefight> mData;

	public ReadOnlyBossRushRefight this[int Index] => new ReadOnlyBossRushRefight(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushRefightList(RepeatedField<BossRushRefight> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushRefight> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushRefight> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushRefight> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushRefight(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushCastCountList : IEnumerable<ReadOnlyBossRushCastCount>, IEnumerable
{
	private RepeatedField<BossRushCastCount> mData;

	public ReadOnlyBossRushCastCount this[int Index] => new ReadOnlyBossRushCastCount(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushCastCountList(RepeatedField<BossRushCastCount> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushCastCount> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushCastCount> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushCastCount> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushCastCount(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

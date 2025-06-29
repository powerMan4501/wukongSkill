using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyBossRushRoleBaseList : IEnumerable<ReadOnlyBossRushRoleBase>, IEnumerable
{
	private RepeatedField<BossRushRoleBase> mData;

	public ReadOnlyBossRushRoleBase this[int Index] => new ReadOnlyBossRushRoleBase(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyBossRushRoleBaseList(RepeatedField<BossRushRoleBase> data)
	{
		mData = data;
	}

	public RepeatedField<BossRushRoleBase> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<BossRushRoleBase> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyBossRushRoleBase> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyBossRushRoleBase(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleBossRushList : IEnumerable<ReadOnlyRoleBossRush>, IEnumerable
{
	private RepeatedField<RoleBossRush> mData;

	public ReadOnlyRoleBossRush this[int Index] => new ReadOnlyRoleBossRush(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleBossRushList(RepeatedField<RoleBossRush> data)
	{
		mData = data;
	}

	public RepeatedField<RoleBossRush> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleBossRush> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleBossRush> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleBossRush(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleOnlineList : IEnumerable<ReadOnlyRoleOnline>, IEnumerable
{
	private RepeatedField<RoleOnline> mData;

	public ReadOnlyRoleOnline this[int Index] => new ReadOnlyRoleOnline(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleOnlineList(RepeatedField<RoleOnline> data)
	{
		mData = data;
	}

	public RepeatedField<RoleOnline> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleOnline> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleOnline> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleOnline(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

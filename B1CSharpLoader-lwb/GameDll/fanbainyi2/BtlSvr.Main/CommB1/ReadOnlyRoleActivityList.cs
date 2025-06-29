using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleActivityList : IEnumerable<ReadOnlyRoleActivity>, IEnumerable
{
	private RepeatedField<RoleActivity> mData;

	public ReadOnlyRoleActivity this[int Index] => new ReadOnlyRoleActivity(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleActivityList(RepeatedField<RoleActivity> data)
	{
		mData = data;
	}

	public RepeatedField<RoleActivity> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleActivity> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleActivity> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleActivity(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

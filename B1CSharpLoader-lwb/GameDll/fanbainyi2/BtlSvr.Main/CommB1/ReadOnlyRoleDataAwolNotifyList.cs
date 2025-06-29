using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDataAwolNotifyList : IEnumerable<ReadOnlyRoleDataAwolNotify>, IEnumerable
{
	private RepeatedField<RoleDataAwolNotify> mData;

	public ReadOnlyRoleDataAwolNotify this[int Index] => new ReadOnlyRoleDataAwolNotify(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDataAwolNotifyList(RepeatedField<RoleDataAwolNotify> data)
	{
		mData = data;
	}

	public RepeatedField<RoleDataAwolNotify> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleDataAwolNotify> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleDataAwolNotify> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleDataAwolNotify(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

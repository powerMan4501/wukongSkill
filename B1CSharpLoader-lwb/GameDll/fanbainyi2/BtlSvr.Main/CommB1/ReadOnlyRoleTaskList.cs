using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleTaskList : IEnumerable<ReadOnlyRoleTask>, IEnumerable
{
	private RepeatedField<RoleTask> mData;

	public ReadOnlyRoleTask this[int Index] => new ReadOnlyRoleTask(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleTaskList(RepeatedField<RoleTask> data)
	{
		mData = data;
	}

	public RepeatedField<RoleTask> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleTask> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleTask> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleTask(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

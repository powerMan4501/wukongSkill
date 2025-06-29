using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDataCSList : IEnumerable<ReadOnlyRoleDataCS>, IEnumerable
{
	private RepeatedField<RoleDataCS> mData;

	public ReadOnlyRoleDataCS this[int Index] => new ReadOnlyRoleDataCS(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDataCSList(RepeatedField<RoleDataCS> data)
	{
		mData = data;
	}

	public RepeatedField<RoleDataCS> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleDataCS> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleDataCS> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleDataCS(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

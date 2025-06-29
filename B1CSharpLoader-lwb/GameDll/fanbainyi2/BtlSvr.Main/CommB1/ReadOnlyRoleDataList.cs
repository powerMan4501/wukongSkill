using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDataList : IEnumerable<ReadOnlyRoleData>, IEnumerable
{
	private RepeatedField<RoleData> mData;

	public ReadOnlyRoleData this[int Index] => new ReadOnlyRoleData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDataList(RepeatedField<RoleData> data)
	{
		mData = data;
	}

	public RepeatedField<RoleData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

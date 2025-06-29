using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDataClientList : IEnumerable<ReadOnlyRoleDataClient>, IEnumerable
{
	private RepeatedField<RoleDataClient> mData;

	public ReadOnlyRoleDataClient this[int Index] => new ReadOnlyRoleDataClient(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDataClientList(RepeatedField<RoleDataClient> data)
	{
		mData = data;
	}

	public RepeatedField<RoleDataClient> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleDataClient> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleDataClient> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleDataClient(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

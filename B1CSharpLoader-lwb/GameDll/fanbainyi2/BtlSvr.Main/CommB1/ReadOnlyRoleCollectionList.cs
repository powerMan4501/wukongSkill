using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleCollectionList : IEnumerable<ReadOnlyRoleCollection>, IEnumerable
{
	private RepeatedField<RoleCollection> mData;

	public ReadOnlyRoleCollection this[int Index] => new ReadOnlyRoleCollection(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleCollectionList(RepeatedField<RoleCollection> data)
	{
		mData = data;
	}

	public RepeatedField<RoleCollection> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleCollection> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleCollection> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleCollection(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

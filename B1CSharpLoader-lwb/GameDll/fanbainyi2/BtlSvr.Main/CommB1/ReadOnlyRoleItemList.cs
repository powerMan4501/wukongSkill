using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleItemList : IEnumerable<ReadOnlyRoleItem>, IEnumerable
{
	private RepeatedField<RoleItem> mData;

	public ReadOnlyRoleItem this[int Index] => new ReadOnlyRoleItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleItemList(RepeatedField<RoleItem> data)
	{
		mData = data;
	}

	public RepeatedField<RoleItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

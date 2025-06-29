using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleMuseumList : IEnumerable<ReadOnlyRoleMuseum>, IEnumerable
{
	private RepeatedField<RoleMuseum> mData;

	public ReadOnlyRoleMuseum this[int Index] => new ReadOnlyRoleMuseum(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleMuseumList(RepeatedField<RoleMuseum> data)
	{
		mData = data;
	}

	public RepeatedField<RoleMuseum> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleMuseum> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleMuseum> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleMuseum(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

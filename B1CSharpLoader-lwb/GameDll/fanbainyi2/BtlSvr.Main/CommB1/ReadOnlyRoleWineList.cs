using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleWineList : IEnumerable<ReadOnlyRoleWine>, IEnumerable
{
	private RepeatedField<RoleWine> mData;

	public ReadOnlyRoleWine this[int Index] => new ReadOnlyRoleWine(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleWineList(RepeatedField<RoleWine> data)
	{
		mData = data;
	}

	public RepeatedField<RoleWine> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleWine> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleWine> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleWine(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

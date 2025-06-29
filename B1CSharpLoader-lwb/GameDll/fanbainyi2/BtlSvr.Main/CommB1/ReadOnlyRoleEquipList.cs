using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleEquipList : IEnumerable<ReadOnlyRoleEquip>, IEnumerable
{
	private RepeatedField<RoleEquip> mData;

	public ReadOnlyRoleEquip this[int Index] => new ReadOnlyRoleEquip(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleEquipList(RepeatedField<RoleEquip> data)
	{
		mData = data;
	}

	public RepeatedField<RoleEquip> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleEquip> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleEquip> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleEquip(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

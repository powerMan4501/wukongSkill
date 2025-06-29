using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleShopList : IEnumerable<ReadOnlyRoleShop>, IEnumerable
{
	private RepeatedField<RoleShop> mData;

	public ReadOnlyRoleShop this[int Index] => new ReadOnlyRoleShop(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleShopList(RepeatedField<RoleShop> data)
	{
		mData = data;
	}

	public RepeatedField<RoleShop> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleShop> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleShop> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleShop(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

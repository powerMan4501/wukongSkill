using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleMoneyList : IEnumerable<ReadOnlyRoleMoney>, IEnumerable
{
	private RepeatedField<RoleMoney> mData;

	public ReadOnlyRoleMoney this[int Index] => new ReadOnlyRoleMoney(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleMoneyList(RepeatedField<RoleMoney> data)
	{
		mData = data;
	}

	public RepeatedField<RoleMoney> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleMoney> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleMoney> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleMoney(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

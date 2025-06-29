using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleBaseList : IEnumerable<ReadOnlyRoleBase>, IEnumerable
{
	private RepeatedField<RoleBase> mData;

	public ReadOnlyRoleBase this[int Index] => new ReadOnlyRoleBase(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleBaseList(RepeatedField<RoleBase> data)
	{
		mData = data;
	}

	public RepeatedField<RoleBase> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleBase> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleBase> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleBase(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

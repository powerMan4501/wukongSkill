using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDropList : IEnumerable<ReadOnlyRoleDrop>, IEnumerable
{
	private RepeatedField<RoleDrop> mData;

	public ReadOnlyRoleDrop this[int Index] => new ReadOnlyRoleDrop(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDropList(RepeatedField<RoleDrop> data)
	{
		mData = data;
	}

	public RepeatedField<RoleDrop> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleDrop> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleDrop> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleDrop(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

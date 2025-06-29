using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleGardenList : IEnumerable<ReadOnlyRoleGarden>, IEnumerable
{
	private RepeatedField<RoleGarden> mData;

	public ReadOnlyRoleGarden this[int Index] => new ReadOnlyRoleGarden(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleGardenList(RepeatedField<RoleGarden> data)
	{
		mData = data;
	}

	public RepeatedField<RoleGarden> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleGarden> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleGarden> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleGarden(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

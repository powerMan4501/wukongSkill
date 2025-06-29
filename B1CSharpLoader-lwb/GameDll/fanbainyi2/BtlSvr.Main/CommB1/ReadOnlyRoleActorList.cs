using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleActorList : IEnumerable<ReadOnlyRoleActor>, IEnumerable
{
	private RepeatedField<RoleActor> mData;

	public ReadOnlyRoleActor this[int Index] => new ReadOnlyRoleActor(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleActorList(RepeatedField<RoleActor> data)
	{
		mData = data;
	}

	public RepeatedField<RoleActor> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleActor> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleActor> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleActor(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

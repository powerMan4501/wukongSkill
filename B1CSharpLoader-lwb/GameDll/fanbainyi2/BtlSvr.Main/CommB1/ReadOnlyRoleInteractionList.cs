using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleInteractionList : IEnumerable<ReadOnlyRoleInteraction>, IEnumerable
{
	private RepeatedField<RoleInteraction> mData;

	public ReadOnlyRoleInteraction this[int Index] => new ReadOnlyRoleInteraction(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleInteractionList(RepeatedField<RoleInteraction> data)
	{
		mData = data;
	}

	public RepeatedField<RoleInteraction> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleInteraction> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleInteraction> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleInteraction(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

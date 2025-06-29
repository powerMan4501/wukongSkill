using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMemberRoleDataList : IEnumerable<ReadOnlyMemberRoleData>, IEnumerable
{
	private RepeatedField<MemberRoleData> mData;

	public ReadOnlyMemberRoleData this[int Index] => new ReadOnlyMemberRoleData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMemberRoleDataList(RepeatedField<MemberRoleData> data)
	{
		mData = data;
	}

	public RepeatedField<MemberRoleData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MemberRoleData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMemberRoleData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMemberRoleData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

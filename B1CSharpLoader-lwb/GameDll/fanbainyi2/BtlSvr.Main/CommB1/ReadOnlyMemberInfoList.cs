using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMemberInfoList : IEnumerable<ReadOnlyMemberInfo>, IEnumerable
{
	private RepeatedField<MemberInfo> mData;

	public ReadOnlyMemberInfo this[int Index] => new ReadOnlyMemberInfo(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMemberInfoList(RepeatedField<MemberInfo> data)
	{
		mData = data;
	}

	public RepeatedField<MemberInfo> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MemberInfo> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMemberInfo> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMemberInfo(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

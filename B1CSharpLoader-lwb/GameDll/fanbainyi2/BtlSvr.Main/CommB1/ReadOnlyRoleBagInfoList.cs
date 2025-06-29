using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleBagInfoList : IEnumerable<ReadOnlyRoleBagInfo>, IEnumerable
{
	private RepeatedField<RoleBagInfo> mData;

	public ReadOnlyRoleBagInfo this[int Index] => new ReadOnlyRoleBagInfo(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleBagInfoList(RepeatedField<RoleBagInfo> data)
	{
		mData = data;
	}

	public RepeatedField<RoleBagInfo> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleBagInfo> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleBagInfo> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleBagInfo(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

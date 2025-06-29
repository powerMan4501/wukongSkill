using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleStaticsDataList : IEnumerable<ReadOnlyRoleStaticsData>, IEnumerable
{
	private RepeatedField<RoleStaticsData> mData;

	public ReadOnlyRoleStaticsData this[int Index] => new ReadOnlyRoleStaticsData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleStaticsDataList(RepeatedField<RoleStaticsData> data)
	{
		mData = data;
	}

	public RepeatedField<RoleStaticsData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleStaticsData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleStaticsData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleStaticsData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

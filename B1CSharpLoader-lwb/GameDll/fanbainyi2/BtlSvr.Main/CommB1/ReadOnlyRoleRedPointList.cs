using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleRedPointList : IEnumerable<ReadOnlyRoleRedPoint>, IEnumerable
{
	private RepeatedField<RoleRedPoint> mData;

	public ReadOnlyRoleRedPoint this[int Index] => new ReadOnlyRoleRedPoint(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleRedPointList(RepeatedField<RoleRedPoint> data)
	{
		mData = data;
	}

	public RepeatedField<RoleRedPoint> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleRedPoint> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleRedPoint> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleRedPoint(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

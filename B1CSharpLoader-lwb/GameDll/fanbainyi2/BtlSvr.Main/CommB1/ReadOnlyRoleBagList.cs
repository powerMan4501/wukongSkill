using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleBagList : IEnumerable<ReadOnlyRoleBag>, IEnumerable
{
	private RepeatedField<RoleBag> mData;

	public ReadOnlyRoleBag this[int Index] => new ReadOnlyRoleBag(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleBagList(RepeatedField<RoleBag> data)
	{
		mData = data;
	}

	public RepeatedField<RoleBag> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleBag> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleBag> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleBag(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

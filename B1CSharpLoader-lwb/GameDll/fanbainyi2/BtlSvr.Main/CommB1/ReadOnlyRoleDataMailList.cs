using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleDataMailList : IEnumerable<ReadOnlyRoleDataMail>, IEnumerable
{
	private RepeatedField<RoleDataMail> mData;

	public ReadOnlyRoleDataMail this[int Index] => new ReadOnlyRoleDataMail(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleDataMailList(RepeatedField<RoleDataMail> data)
	{
		mData = data;
	}

	public RepeatedField<RoleDataMail> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleDataMail> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleDataMail> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleDataMail(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

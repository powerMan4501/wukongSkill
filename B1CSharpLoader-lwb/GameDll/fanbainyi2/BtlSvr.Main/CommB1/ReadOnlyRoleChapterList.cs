using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleChapterList : IEnumerable<ReadOnlyRoleChapter>, IEnumerable
{
	private RepeatedField<RoleChapter> mData;

	public ReadOnlyRoleChapter this[int Index] => new ReadOnlyRoleChapter(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleChapterList(RepeatedField<RoleChapter> data)
	{
		mData = data;
	}

	public RepeatedField<RoleChapter> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleChapter> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleChapter> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleChapter(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

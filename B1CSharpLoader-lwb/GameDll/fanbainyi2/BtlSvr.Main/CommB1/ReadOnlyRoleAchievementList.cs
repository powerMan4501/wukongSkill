using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleAchievementList : IEnumerable<ReadOnlyRoleAchievement>, IEnumerable
{
	private RepeatedField<RoleAchievement> mData;

	public ReadOnlyRoleAchievement this[int Index] => new ReadOnlyRoleAchievement(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleAchievementList(RepeatedField<RoleAchievement> data)
	{
		mData = data;
	}

	public RepeatedField<RoleAchievement> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleAchievement> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleAchievement> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleAchievement(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

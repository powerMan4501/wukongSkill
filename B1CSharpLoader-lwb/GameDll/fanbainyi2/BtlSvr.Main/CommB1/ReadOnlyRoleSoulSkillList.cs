using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRoleSoulSkillList : IEnumerable<ReadOnlyRoleSoulSkill>, IEnumerable
{
	private RepeatedField<RoleSoulSkill> mData;

	public ReadOnlyRoleSoulSkill this[int Index] => new ReadOnlyRoleSoulSkill(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRoleSoulSkillList(RepeatedField<RoleSoulSkill> data)
	{
		mData = data;
	}

	public RepeatedField<RoleSoulSkill> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RoleSoulSkill> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRoleSoulSkill> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRoleSoulSkill(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

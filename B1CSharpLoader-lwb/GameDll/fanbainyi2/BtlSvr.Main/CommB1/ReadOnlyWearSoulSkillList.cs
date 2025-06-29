using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyWearSoulSkillList : IEnumerable<ReadOnlyWearSoulSkill>, IEnumerable
{
	private RepeatedField<WearSoulSkill> mData;

	public ReadOnlyWearSoulSkill this[int Index] => new ReadOnlyWearSoulSkill(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyWearSoulSkillList(RepeatedField<WearSoulSkill> data)
	{
		mData = data;
	}

	public RepeatedField<WearSoulSkill> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<WearSoulSkill> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyWearSoulSkill> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyWearSoulSkill(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

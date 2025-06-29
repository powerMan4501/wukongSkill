using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySoulSkillDropRecordList : IEnumerable<ReadOnlySoulSkillDropRecord>, IEnumerable
{
	private RepeatedField<SoulSkillDropRecord> mData;

	public ReadOnlySoulSkillDropRecord this[int Index] => new ReadOnlySoulSkillDropRecord(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlySoulSkillDropRecordList(RepeatedField<SoulSkillDropRecord> data)
	{
		mData = data;
	}

	public RepeatedField<SoulSkillDropRecord> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<SoulSkillDropRecord> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlySoulSkillDropRecord> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlySoulSkillDropRecord(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

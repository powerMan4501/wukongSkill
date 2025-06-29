using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLegacyTalentList : IEnumerable<ReadOnlyLegacyTalent>, IEnumerable
{
	private RepeatedField<LegacyTalent> mData;

	public ReadOnlyLegacyTalent this[int Index] => new ReadOnlyLegacyTalent(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyLegacyTalentList(RepeatedField<LegacyTalent> data)
	{
		mData = data;
	}

	public RepeatedField<LegacyTalent> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<LegacyTalent> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyLegacyTalent> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyLegacyTalent(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

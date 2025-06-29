using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyLegacyAbilityList : IEnumerable<ReadOnlyLegacyAbility>, IEnumerable
{
	private RepeatedField<LegacyAbility> mData;

	public ReadOnlyLegacyAbility this[int Index] => new ReadOnlyLegacyAbility(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyLegacyAbilityList(RepeatedField<LegacyAbility> data)
	{
		mData = data;
	}

	public RepeatedField<LegacyAbility> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<LegacyAbility> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyLegacyAbility> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyLegacyAbility(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

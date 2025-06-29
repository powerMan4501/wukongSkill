using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPartySettingList : IEnumerable<ReadOnlyPartySetting>, IEnumerable
{
	private RepeatedField<PartySetting> mData;

	public ReadOnlyPartySetting this[int Index] => new ReadOnlyPartySetting(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPartySettingList(RepeatedField<PartySetting> data)
	{
		mData = data;
	}

	public RepeatedField<PartySetting> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PartySetting> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPartySetting> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPartySetting(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

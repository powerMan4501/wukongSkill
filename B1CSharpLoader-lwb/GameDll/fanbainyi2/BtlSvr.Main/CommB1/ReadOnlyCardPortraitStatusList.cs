using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCardPortraitStatusList : IEnumerable<ReadOnlyCardPortraitStatus>, IEnumerable
{
	private RepeatedField<CardPortraitStatus> mData;

	public ReadOnlyCardPortraitStatus this[int Index] => new ReadOnlyCardPortraitStatus(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCardPortraitStatusList(RepeatedField<CardPortraitStatus> data)
	{
		mData = data;
	}

	public RepeatedField<CardPortraitStatus> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CardPortraitStatus> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCardPortraitStatus> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCardPortraitStatus(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyWearAccessoryList : IEnumerable<ReadOnlyWearAccessory>, IEnumerable
{
	private RepeatedField<WearAccessory> mData;

	public ReadOnlyWearAccessory this[int Index] => new ReadOnlyWearAccessory(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyWearAccessoryList(RepeatedField<WearAccessory> data)
	{
		mData = data;
	}

	public RepeatedField<WearAccessory> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<WearAccessory> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyWearAccessory> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyWearAccessory(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

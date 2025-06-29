using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCropList : IEnumerable<ReadOnlyCrop>, IEnumerable
{
	private RepeatedField<Crop> mData;

	public ReadOnlyCrop this[int Index] => new ReadOnlyCrop(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCropList(RepeatedField<Crop> data)
	{
		mData = data;
	}

	public RepeatedField<Crop> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<Crop> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCrop> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCrop(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

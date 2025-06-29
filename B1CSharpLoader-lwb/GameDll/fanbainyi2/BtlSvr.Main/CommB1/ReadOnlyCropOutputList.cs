using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCropOutputList : IEnumerable<ReadOnlyCropOutput>, IEnumerable
{
	private RepeatedField<CropOutput> mData;

	public ReadOnlyCropOutput this[int Index] => new ReadOnlyCropOutput(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCropOutputList(RepeatedField<CropOutput> data)
	{
		mData = data;
	}

	public RepeatedField<CropOutput> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CropOutput> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCropOutput> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCropOutput(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

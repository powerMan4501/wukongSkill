using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMuseumRedPointList : IEnumerable<ReadOnlyMuseumRedPoint>, IEnumerable
{
	private RepeatedField<MuseumRedPoint> mData;

	public ReadOnlyMuseumRedPoint this[int Index] => new ReadOnlyMuseumRedPoint(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMuseumRedPointList(RepeatedField<MuseumRedPoint> data)
	{
		mData = data;
	}

	public RepeatedField<MuseumRedPoint> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MuseumRedPoint> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMuseumRedPoint> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMuseumRedPoint(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

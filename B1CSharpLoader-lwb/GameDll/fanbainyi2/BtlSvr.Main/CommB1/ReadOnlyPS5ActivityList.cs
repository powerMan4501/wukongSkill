using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPS5ActivityList : IEnumerable<ReadOnlyPS5Activity>, IEnumerable
{
	private RepeatedField<PS5Activity> mData;

	public ReadOnlyPS5Activity this[int Index] => new ReadOnlyPS5Activity(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPS5ActivityList(RepeatedField<PS5Activity> data)
	{
		mData = data;
	}

	public RepeatedField<PS5Activity> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PS5Activity> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPS5Activity> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPS5Activity(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

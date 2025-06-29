using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPS5TaskList : IEnumerable<ReadOnlyPS5Task>, IEnumerable
{
	private RepeatedField<PS5Task> mData;

	public ReadOnlyPS5Task this[int Index] => new ReadOnlyPS5Task(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPS5TaskList(RepeatedField<PS5Task> data)
	{
		mData = data;
	}

	public RepeatedField<PS5Task> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PS5Task> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPS5Task> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPS5Task(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

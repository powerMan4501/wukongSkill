using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyDropRecordList : IEnumerable<ReadOnlyDropRecord>, IEnumerable
{
	private RepeatedField<DropRecord> mData;

	public ReadOnlyDropRecord this[int Index] => new ReadOnlyDropRecord(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyDropRecordList(RepeatedField<DropRecord> data)
	{
		mData = data;
	}

	public RepeatedField<DropRecord> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<DropRecord> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyDropRecord> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyDropRecord(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

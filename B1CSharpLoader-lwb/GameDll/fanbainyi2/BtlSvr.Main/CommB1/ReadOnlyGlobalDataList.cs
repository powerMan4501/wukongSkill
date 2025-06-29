using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyGlobalDataList : IEnumerable<ReadOnlyGlobalData>, IEnumerable
{
	private RepeatedField<GlobalData> mData;

	public ReadOnlyGlobalData this[int Index] => new ReadOnlyGlobalData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyGlobalDataList(RepeatedField<GlobalData> data)
	{
		mData = data;
	}

	public RepeatedField<GlobalData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<GlobalData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyGlobalData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyGlobalData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

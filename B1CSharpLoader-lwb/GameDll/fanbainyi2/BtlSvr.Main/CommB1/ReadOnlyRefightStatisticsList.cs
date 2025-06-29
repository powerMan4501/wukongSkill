using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyRefightStatisticsList : IEnumerable<ReadOnlyRefightStatistics>, IEnumerable
{
	private RepeatedField<RefightStatistics> mData;

	public ReadOnlyRefightStatistics this[int Index] => new ReadOnlyRefightStatistics(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyRefightStatisticsList(RepeatedField<RefightStatistics> data)
	{
		mData = data;
	}

	public RepeatedField<RefightStatistics> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<RefightStatistics> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyRefightStatistics> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyRefightStatistics(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

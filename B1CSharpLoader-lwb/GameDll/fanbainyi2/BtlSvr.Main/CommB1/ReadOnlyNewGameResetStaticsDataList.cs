using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyNewGameResetStaticsDataList : IEnumerable<ReadOnlyNewGameResetStaticsData>, IEnumerable
{
	private RepeatedField<NewGameResetStaticsData> mData;

	public ReadOnlyNewGameResetStaticsData this[int Index] => new ReadOnlyNewGameResetStaticsData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyNewGameResetStaticsDataList(RepeatedField<NewGameResetStaticsData> data)
	{
		mData = data;
	}

	public RepeatedField<NewGameResetStaticsData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<NewGameResetStaticsData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyNewGameResetStaticsData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyNewGameResetStaticsData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

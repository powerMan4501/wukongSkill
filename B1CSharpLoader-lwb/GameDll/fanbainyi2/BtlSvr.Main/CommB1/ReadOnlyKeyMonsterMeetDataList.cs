using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyKeyMonsterMeetDataList : IEnumerable<ReadOnlyKeyMonsterMeetData>, IEnumerable
{
	private RepeatedField<KeyMonsterMeetData> mData;

	public ReadOnlyKeyMonsterMeetData this[int Index] => new ReadOnlyKeyMonsterMeetData(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyKeyMonsterMeetDataList(RepeatedField<KeyMonsterMeetData> data)
	{
		mData = data;
	}

	public RepeatedField<KeyMonsterMeetData> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<KeyMonsterMeetData> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyKeyMonsterMeetData> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyKeyMonsterMeetData(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMonsterCollectionList : IEnumerable<ReadOnlyMonsterCollection>, IEnumerable
{
	private RepeatedField<MonsterCollection> mData;

	public ReadOnlyMonsterCollection this[int Index] => new ReadOnlyMonsterCollection(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMonsterCollectionList(RepeatedField<MonsterCollection> data)
	{
		mData = data;
	}

	public RepeatedField<MonsterCollection> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MonsterCollection> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMonsterCollection> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMonsterCollection(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

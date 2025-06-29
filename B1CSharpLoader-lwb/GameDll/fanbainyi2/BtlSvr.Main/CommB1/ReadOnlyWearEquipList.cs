using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyWearEquipList : IEnumerable<ReadOnlyWearEquip>, IEnumerable
{
	private RepeatedField<WearEquip> mData;

	public ReadOnlyWearEquip this[int Index] => new ReadOnlyWearEquip(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyWearEquipList(RepeatedField<WearEquip> data)
	{
		mData = data;
	}

	public RepeatedField<WearEquip> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<WearEquip> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyWearEquip> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyWearEquip(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

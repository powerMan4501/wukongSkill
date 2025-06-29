using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEquipMantraList : IEnumerable<ReadOnlyEquipMantra>, IEnumerable
{
	private RepeatedField<EquipMantra> mData;

	public ReadOnlyEquipMantra this[int Index] => new ReadOnlyEquipMantra(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyEquipMantraList(RepeatedField<EquipMantra> data)
	{
		mData = data;
	}

	public RepeatedField<EquipMantra> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<EquipMantra> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyEquipMantra> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyEquipMantra(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

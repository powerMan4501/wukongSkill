using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySpellItemList : IEnumerable<ReadOnlySpellItem>, IEnumerable
{
	private RepeatedField<SpellItem> mData;

	public ReadOnlySpellItem this[int Index] => new ReadOnlySpellItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlySpellItemList(RepeatedField<SpellItem> data)
	{
		mData = data;
	}

	public RepeatedField<SpellItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<SpellItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlySpellItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlySpellItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

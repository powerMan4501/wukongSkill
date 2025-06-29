using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyShortcutItemList : IEnumerable<ReadOnlyShortcutItem>, IEnumerable
{
	private RepeatedField<ShortcutItem> mData;

	public ReadOnlyShortcutItem this[int Index] => new ReadOnlyShortcutItem(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyShortcutItemList(RepeatedField<ShortcutItem> data)
	{
		mData = data;
	}

	public RepeatedField<ShortcutItem> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ShortcutItem> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyShortcutItem> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyShortcutItem(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

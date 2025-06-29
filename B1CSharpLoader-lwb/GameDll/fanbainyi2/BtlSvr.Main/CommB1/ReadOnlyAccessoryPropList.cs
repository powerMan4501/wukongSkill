using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAccessoryPropList : IEnumerable<ReadOnlyAccessoryProp>, IEnumerable
{
	private RepeatedField<AccessoryProp> mData;

	public ReadOnlyAccessoryProp this[int Index] => new ReadOnlyAccessoryProp(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAccessoryPropList(RepeatedField<AccessoryProp> data)
	{
		mData = data;
	}

	public RepeatedField<AccessoryProp> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AccessoryProp> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAccessoryProp> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAccessoryProp(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

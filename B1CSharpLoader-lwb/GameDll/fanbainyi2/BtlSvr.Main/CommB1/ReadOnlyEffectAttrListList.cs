using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEffectAttrListList : IEnumerable<ReadOnlyEffectAttrList>, IEnumerable
{
	private RepeatedField<EffectAttrList> mData;

	public ReadOnlyEffectAttrList this[int Index] => new ReadOnlyEffectAttrList(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyEffectAttrListList(RepeatedField<EffectAttrList> data)
	{
		mData = data;
	}

	public RepeatedField<EffectAttrList> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<EffectAttrList> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyEffectAttrList> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyEffectAttrList(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

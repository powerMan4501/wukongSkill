using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyEffectAttrFloatList : IEnumerable<ReadOnlyEffectAttrFloat>, IEnumerable
{
	private RepeatedField<EffectAttrFloat> mData;

	public ReadOnlyEffectAttrFloat this[int Index] => new ReadOnlyEffectAttrFloat(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyEffectAttrFloatList(RepeatedField<EffectAttrFloat> data)
	{
		mData = data;
	}

	public RepeatedField<EffectAttrFloat> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<EffectAttrFloat> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyEffectAttrFloat> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyEffectAttrFloat(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

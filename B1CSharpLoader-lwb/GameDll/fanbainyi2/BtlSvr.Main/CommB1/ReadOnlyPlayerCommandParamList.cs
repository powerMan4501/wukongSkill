using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyPlayerCommandParamList : IEnumerable<ReadOnlyPlayerCommandParam>, IEnumerable
{
	private RepeatedField<PlayerCommandParam> mData;

	public ReadOnlyPlayerCommandParam this[int Index] => new ReadOnlyPlayerCommandParam(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyPlayerCommandParamList(RepeatedField<PlayerCommandParam> data)
	{
		mData = data;
	}

	public RepeatedField<PlayerCommandParam> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<PlayerCommandParam> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyPlayerCommandParam> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyPlayerCommandParam(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

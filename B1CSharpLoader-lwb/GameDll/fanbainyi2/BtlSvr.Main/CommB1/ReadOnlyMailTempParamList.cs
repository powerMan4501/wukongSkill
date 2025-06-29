using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailTempParamList : IEnumerable<ReadOnlyMailTempParam>, IEnumerable
{
	private RepeatedField<MailTempParam> mData;

	public ReadOnlyMailTempParam this[int Index] => new ReadOnlyMailTempParam(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMailTempParamList(RepeatedField<MailTempParam> data)
	{
		mData = data;
	}

	public RepeatedField<MailTempParam> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MailTempParam> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMailTempParam> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMailTempParam(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

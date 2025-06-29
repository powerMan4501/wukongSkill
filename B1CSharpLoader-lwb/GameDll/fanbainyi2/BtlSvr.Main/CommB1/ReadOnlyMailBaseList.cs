using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailBaseList : IEnumerable<ReadOnlyMailBase>, IEnumerable
{
	private RepeatedField<MailBase> mData;

	public ReadOnlyMailBase this[int Index] => new ReadOnlyMailBase(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMailBaseList(RepeatedField<MailBase> data)
	{
		mData = data;
	}

	public RepeatedField<MailBase> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MailBase> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMailBase> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMailBase(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailExtList : IEnumerable<ReadOnlyMailExt>, IEnumerable
{
	private RepeatedField<MailExt> mData;

	public ReadOnlyMailExt this[int Index] => new ReadOnlyMailExt(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMailExtList(RepeatedField<MailExt> data)
	{
		mData = data;
	}

	public RepeatedField<MailExt> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MailExt> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMailExt> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMailExt(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

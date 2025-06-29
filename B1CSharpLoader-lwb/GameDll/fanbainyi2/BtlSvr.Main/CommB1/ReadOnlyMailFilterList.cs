using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailFilterList : IEnumerable<ReadOnlyMailFilter>, IEnumerable
{
	private RepeatedField<MailFilter> mData;

	public ReadOnlyMailFilter this[int Index] => new ReadOnlyMailFilter(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMailFilterList(RepeatedField<MailFilter> data)
	{
		mData = data;
	}

	public RepeatedField<MailFilter> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MailFilter> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMailFilter> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMailFilter(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

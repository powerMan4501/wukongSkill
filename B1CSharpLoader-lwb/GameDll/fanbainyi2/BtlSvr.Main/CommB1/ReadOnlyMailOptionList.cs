using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyMailOptionList : IEnumerable<ReadOnlyMailOption>, IEnumerable
{
	private RepeatedField<MailOption> mData;

	public ReadOnlyMailOption this[int Index] => new ReadOnlyMailOption(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyMailOptionList(RepeatedField<MailOption> data)
	{
		mData = data;
	}

	public RepeatedField<MailOption> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<MailOption> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyMailOption> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyMailOption(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

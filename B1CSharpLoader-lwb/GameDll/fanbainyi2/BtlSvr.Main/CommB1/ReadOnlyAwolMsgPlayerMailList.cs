using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerMailList : IEnumerable<ReadOnlyAwolMsgPlayerMail>, IEnumerable
{
	private RepeatedField<AwolMsgPlayerMail> mData;

	public ReadOnlyAwolMsgPlayerMail this[int Index] => new ReadOnlyAwolMsgPlayerMail(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwolMsgPlayerMailList(RepeatedField<AwolMsgPlayerMail> data)
	{
		mData = data;
	}

	public RepeatedField<AwolMsgPlayerMail> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwolMsgPlayerMail> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwolMsgPlayerMail> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwolMsgPlayerMail(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

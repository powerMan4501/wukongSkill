using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgServerMailList : IEnumerable<ReadOnlyAwolMsgServerMail>, IEnumerable
{
	private RepeatedField<AwolMsgServerMail> mData;

	public ReadOnlyAwolMsgServerMail this[int Index] => new ReadOnlyAwolMsgServerMail(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwolMsgServerMailList(RepeatedField<AwolMsgServerMail> data)
	{
		mData = data;
	}

	public RepeatedField<AwolMsgServerMail> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwolMsgServerMail> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwolMsgServerMail> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwolMsgServerMail(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerChatList : IEnumerable<ReadOnlyAwolMsgPlayerChat>, IEnumerable
{
	private RepeatedField<AwolMsgPlayerChat> mData;

	public ReadOnlyAwolMsgPlayerChat this[int Index] => new ReadOnlyAwolMsgPlayerChat(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwolMsgPlayerChatList(RepeatedField<AwolMsgPlayerChat> data)
	{
		mData = data;
	}

	public RepeatedField<AwolMsgPlayerChat> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwolMsgPlayerChat> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwolMsgPlayerChat> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwolMsgPlayerChat(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

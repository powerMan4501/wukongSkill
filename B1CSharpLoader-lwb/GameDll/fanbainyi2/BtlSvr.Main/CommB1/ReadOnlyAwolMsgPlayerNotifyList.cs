using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerNotifyList : IEnumerable<ReadOnlyAwolMsgPlayerNotify>, IEnumerable
{
	private RepeatedField<AwolMsgPlayerNotify> mData;

	public ReadOnlyAwolMsgPlayerNotify this[int Index] => new ReadOnlyAwolMsgPlayerNotify(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwolMsgPlayerNotifyList(RepeatedField<AwolMsgPlayerNotify> data)
	{
		mData = data;
	}

	public RepeatedField<AwolMsgPlayerNotify> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwolMsgPlayerNotify> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwolMsgPlayerNotify> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwolMsgPlayerNotify(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

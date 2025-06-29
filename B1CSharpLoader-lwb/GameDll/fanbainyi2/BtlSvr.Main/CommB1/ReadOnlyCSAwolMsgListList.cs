using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCSAwolMsgListList : IEnumerable<ReadOnlyCSAwolMsgList>, IEnumerable
{
	private RepeatedField<CSAwolMsgList> mData;

	public ReadOnlyCSAwolMsgList this[int Index] => new ReadOnlyCSAwolMsgList(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCSAwolMsgListList(RepeatedField<CSAwolMsgList> data)
	{
		mData = data;
	}

	public RepeatedField<CSAwolMsgList> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CSAwolMsgList> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCSAwolMsgList> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCSAwolMsgList(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

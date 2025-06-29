using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyCSAwolMsgOneList : IEnumerable<ReadOnlyCSAwolMsgOne>, IEnumerable
{
	private RepeatedField<CSAwolMsgOne> mData;

	public ReadOnlyCSAwolMsgOne this[int Index] => new ReadOnlyCSAwolMsgOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyCSAwolMsgOneList(RepeatedField<CSAwolMsgOne> data)
	{
		mData = data;
	}

	public RepeatedField<CSAwolMsgOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<CSAwolMsgOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyCSAwolMsgOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyCSAwolMsgOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

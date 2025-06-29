using System.Collections;
using System.Collections.Generic;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAwolMsgPlayerCommandList : IEnumerable<ReadOnlyAwolMsgPlayerCommand>, IEnumerable
{
	private RepeatedField<AwolMsgPlayerCommand> mData;

	public ReadOnlyAwolMsgPlayerCommand this[int Index] => new ReadOnlyAwolMsgPlayerCommand(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAwolMsgPlayerCommandList(RepeatedField<AwolMsgPlayerCommand> data)
	{
		mData = data;
	}

	public RepeatedField<AwolMsgPlayerCommand> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AwolMsgPlayerCommand> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAwolMsgPlayerCommand> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAwolMsgPlayerCommand(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

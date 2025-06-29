using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyOutputConfigList : IEnumerable<ReadOnlyOutputConfig>, IEnumerable
{
	private RepeatedField<OutputConfig> mData;

	public ReadOnlyOutputConfig this[int Index] => new ReadOnlyOutputConfig(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyOutputConfigList(RepeatedField<OutputConfig> data)
	{
		mData = data;
	}

	public RepeatedField<OutputConfig> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<OutputConfig> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyOutputConfig> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyOutputConfig(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

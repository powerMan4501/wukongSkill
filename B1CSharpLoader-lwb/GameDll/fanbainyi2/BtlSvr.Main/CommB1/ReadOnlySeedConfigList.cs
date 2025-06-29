using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlySeedConfigList : IEnumerable<ReadOnlySeedConfig>, IEnumerable
{
	private RepeatedField<SeedConfig> mData;

	public ReadOnlySeedConfig this[int Index] => new ReadOnlySeedConfig(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlySeedConfigList(RepeatedField<SeedConfig> data)
	{
		mData = data;
	}

	public RepeatedField<SeedConfig> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<SeedConfig> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlySeedConfig> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlySeedConfig(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

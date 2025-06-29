using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyAlchemyNpcCommunicationStatusList : IEnumerable<ReadOnlyAlchemyNpcCommunicationStatus>, IEnumerable
{
	private RepeatedField<AlchemyNpcCommunicationStatus> mData;

	public ReadOnlyAlchemyNpcCommunicationStatus this[int Index] => new ReadOnlyAlchemyNpcCommunicationStatus(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyAlchemyNpcCommunicationStatusList(RepeatedField<AlchemyNpcCommunicationStatus> data)
	{
		mData = data;
	}

	public RepeatedField<AlchemyNpcCommunicationStatus> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<AlchemyNpcCommunicationStatus> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyAlchemyNpcCommunicationStatus> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyAlchemyNpcCommunicationStatus(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

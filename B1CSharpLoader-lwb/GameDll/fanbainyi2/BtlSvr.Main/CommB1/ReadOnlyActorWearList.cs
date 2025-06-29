using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyActorWearList : IEnumerable<ReadOnlyActorWear>, IEnumerable
{
	private RepeatedField<ActorWear> mData;

	public ReadOnlyActorWear this[int Index] => new ReadOnlyActorWear(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyActorWearList(RepeatedField<ActorWear> data)
	{
		mData = data;
	}

	public RepeatedField<ActorWear> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ActorWear> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyActorWear> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyActorWear(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyActorProgressList : IEnumerable<ReadOnlyActorProgress>, IEnumerable
{
	private RepeatedField<ActorProgress> mData;

	public ReadOnlyActorProgress this[int Index] => new ReadOnlyActorProgress(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyActorProgressList(RepeatedField<ActorProgress> data)
	{
		mData = data;
	}

	public RepeatedField<ActorProgress> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<ActorProgress> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyActorProgress> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyActorProgress(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

using System.Collections;
using System.Collections.Generic;
using ArchiveB1;
using Google.Protobuf.Collections;

namespace CommB1;

public class ReadOnlyQuestStageOneList : IEnumerable<ReadOnlyQuestStageOne>, IEnumerable
{
	private RepeatedField<QuestStageOne> mData;

	public ReadOnlyQuestStageOne this[int Index] => new ReadOnlyQuestStageOne(mData[Index]);

	public int Count => mData.Count;

	public ReadOnlyQuestStageOneList(RepeatedField<QuestStageOne> data)
	{
		mData = data;
	}

	public RepeatedField<QuestStageOne> ForceGetRef()
	{
		return mData;
	}

	public RepeatedField<QuestStageOne> CloneData()
	{
		return mData.Clone();
	}

	public IEnumerator<ReadOnlyQuestStageOne> GetEnumerator()
	{
		for (int i = 0; i < Count; i++)
		{
			yield return new ReadOnlyQuestStageOne(mData[i]);
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}

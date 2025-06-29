using System.Collections.Generic;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

public class SeqDataTracker : DataTrackerBase
{
	private BGC_MovieData MovieData;

	private Dictionary<MovieInstance, int> MovieReqDic = new Dictionary<MovieInstance, int>();

	private Dictionary<ALevelSequenceActor, int> SeqReqDic = new Dictionary<ALevelSequenceActor, int>();

	public SeqDataTracker(UObject InWorldContext)
		: base(InWorldContext)
	{
		MovieData = BGU_DataUtil.GetGameStateReadonlyData<BGC_MovieData>(InWorldContext);
	}

	public override ETrackerType GetTrackerType()
	{
		return ETrackerType.Seq;
	}

	public override void OnTick(float InDeltaTime)
	{
		List<MovieInstance> list = new List<MovieInstance>();
		if (MovieData != null)
		{
			foreach (TStrongObjectPtr<MovieInstance> value3 in MovieData.MovieInstances.Values)
			{
				MovieInstance movieInstance = value3.Get();
				if (!movieInstance.IsNullOrDestroyed())
				{
					if (!MovieReqDic.ContainsKey(movieInstance))
					{
						int sequenceId = movieInstance.SequenceId;
						DebugDrawMessage debugData = new DebugDrawMessage(-1f, $"开始播放Seq, SeqId = {sequenceId}");
						int value = Request(debugData);
						MovieReqDic.Add(movieInstance, value);
					}
					list.Add(movieInstance);
				}
			}
		}
		List<MovieInstance> list2 = new List<MovieInstance>();
		foreach (KeyValuePair<MovieInstance, int> item in MovieReqDic)
		{
			if (!list.Contains(item.Key))
			{
				Release(item.Value);
				list2.Add(item.Key);
			}
		}
		foreach (MovieInstance item2 in list2)
		{
			MovieReqDic.Remove(item2);
		}
		List<ALevelSequenceActor> list3 = new List<ALevelSequenceActor>();
		ACalliopeLevelSequenceActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACalliopeLevelSequenceActor>(WorldContext);
		if (allActorsOfClass != null)
		{
			ACalliopeLevelSequenceActor[] array = allActorsOfClass;
			foreach (ACalliopeLevelSequenceActor aCalliopeLevelSequenceActor in array)
			{
				ULevelSequencePlayer sequencePlayer = aCalliopeLevelSequenceActor.GetSequencePlayer();
				ULevelSequence sequence = aCalliopeLevelSequenceActor.GetSequence();
				if (!sequencePlayer.IsNullOrDestroyed() && !sequence.IsNullOrDestroyed())
				{
					if (!SeqReqDic.ContainsKey(aCalliopeLevelSequenceActor))
					{
						DebugDrawSeqStat debugData2 = new DebugDrawSeqStat(-1f, aCalliopeLevelSequenceActor);
						int value2 = Request(debugData2);
						SeqReqDic.Add(aCalliopeLevelSequenceActor, value2);
					}
					list3.Add(aCalliopeLevelSequenceActor);
				}
			}
		}
		List<ALevelSequenceActor> list4 = new List<ALevelSequenceActor>();
		foreach (KeyValuePair<ALevelSequenceActor, int> item3 in SeqReqDic)
		{
			if (!list3.Contains(item3.Key))
			{
				Release(item3.Value);
				list4.Add(item3.Key);
			}
		}
		foreach (ALevelSequenceActor item4 in list4)
		{
			SeqReqDic.Remove(item4);
		}
	}
}

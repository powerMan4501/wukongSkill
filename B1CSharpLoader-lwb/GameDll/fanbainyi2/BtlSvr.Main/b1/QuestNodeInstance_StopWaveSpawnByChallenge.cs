using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class QuestNodeInstance_StopWaveSpawnByChallenge : QuestNodeInstance
{
	private List<string> ObservedUnitGuids { get; set; } = new List<string>();

	private int ChallengeId { get; set; }

	private QuestCustom_StopWaveSpawnByChallenge CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_StopWaveSpawnByChallenge();
		CustomData.MergeFrom(base.Node.NodeData);
		foreach (string item in CustomData.ObserveActorGuid)
		{
			ObservedUnitGuids.Add(item);
		}
		ChallengeId = CustomData.ChallengeId;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		foreach (string observedUnitGuid in ObservedUnitGuids)
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, observedUnitGuid);
			if (actorByGuid != null)
			{
				BUS_EventCollectionCS.Get(actorByGuid).Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.SceneObjCommonEventTag.JumpToState0);
			}
		}
		TriggerFirstOutput(bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] CustomData)
	{
	}

	public override void RecoverActiveState()
	{
		TriggerFirstOutput(bFinish: true);
	}
}

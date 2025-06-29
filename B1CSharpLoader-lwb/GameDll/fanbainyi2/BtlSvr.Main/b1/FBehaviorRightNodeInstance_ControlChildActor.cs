using System.Collections.Generic;
using BtlShare;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_ControlChildActor : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.ControlChildActor;

	public BehaviorCustom_ControlChildActor CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_ControlChildActor();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
		FChildActorActionInfo fChildActorActionInfo = BED_CalliopeFuncLib.DeserializeChildActorActionInfo(CustomData.Action);
		List<string> list = BGUFunctionLibraryCS.FetchChildActorGuidByMatchInfo(base.Owner, BED_CalliopeFuncLib.DeserializeTamerFamilyMatchChildInfo(CustomData.MatchInfo));
		switch (fChildActorActionInfo.ActionType)
		{
		case EChildActorActionType.CastSkill:
		{
			int skillId = fChildActorActionInfo.SkillId;
			bool needCheckSkillCanCast = fChildActorActionInfo.NeedCheckSkillCanCast;
			{
				foreach (string item in list)
				{
					AActor actorByGuid3 = BGU_DataUtil.GetActorByGuid(base.Owner, item);
					if (actorByGuid3 != null)
					{
						FCastSkillInfo cSI = new FCastSkillInfo(skillId, ECastSkillSourceType.CBG);
						cSI.NeedCheckSkillCanCast = needCheckSkillCanCast;
						BUS_EventCollectionCS.Get(actorByGuid3)?.Evt_UnitCastSkillTry.Invoke(cSI);
					}
				}
				break;
			}
		}
		case EChildActorActionType.AddBuff:
		{
			foreach (string item2 in list)
			{
				AActor actorByGuid2 = BGU_DataUtil.GetActorByGuid(base.Owner, item2);
				if (actorByGuid2 != null)
				{
					int buffId2 = fChildActorActionInfo.BuffId;
					int buffLayer2 = fChildActorActionInfo.BuffLayer;
					int buffDuration = fChildActorActionInfo.BuffDuration;
					for (int i = 0; i < buffLayer2; i++)
					{
						BUS_EventCollectionCS.Get(actorByGuid2)?.Evt_BuffAdd.Invoke(buffId2, base.Owner, base.Owner, buffDuration, EBuffSourceType.BehaviorGraph);
					}
				}
			}
			break;
		}
		case EChildActorActionType.RemoveBuff:
		{
			foreach (string item3 in list)
			{
				AActor actorByGuid = BGU_DataUtil.GetActorByGuid(base.Owner, item3);
				if (actorByGuid != null)
				{
					int buffId = fChildActorActionInfo.BuffId;
					int buffLayer = fChildActorActionInfo.BuffLayer;
					bool triggerRemoveEffect = fChildActorActionInfo.TriggerRemoveEffect;
					BUS_EventCollectionCS.Get(actorByGuid)?.Evt_BuffRemove.Invoke(buffId, EBuffEffectTriggerType.None, buffLayer, triggerRemoveEffect);
				}
			}
			break;
		}
		case EChildActorActionType.SpawnSocketAttachTamer:
			base.BGSEventCollection.Evt_UnMarkSocketTamerNeverSpawn.Invoke(base.Owner, BED_CalliopeFuncLib.DeserializeTamerFamilyMatchChildInfo(CustomData.MatchInfo));
			break;
		}
	}
}

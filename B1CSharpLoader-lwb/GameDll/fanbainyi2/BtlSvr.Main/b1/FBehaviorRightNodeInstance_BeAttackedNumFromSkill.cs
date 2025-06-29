using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_BeAttackedNumFromSkill : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_BeAttackedNumFromSkill CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.BeAttackedNumFromSkill;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_BeAttackedNumFromSkill();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeAttackedFromSkill = (Del_Void_ActorInt)Delegate.Combine(bGWEventCollection.Evt_BGW_BeAttackedFromSkill, new Del_Void_ActorInt(BeAttackedNumFromSkill));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeAttackedFromSkill = (Del_Void_ActorInt)Delegate.Remove(bGWEventCollection.Evt_BGW_BeAttackedFromSkill, new Del_Void_ActorInt(BeAttackedNumFromSkill));
	}

	private void BeAttackedNumFromSkill(AActor Victim, int SkillID)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(Victim) == base.ListenerFlagID) || SkillID != CustomData.SkillId)
		{
			return;
		}
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BeAttackData>(Victim);
		if (readOnlyData != null)
		{
			int skillBeHitCounter = readOnlyData.GetSkillBeHitCounter(SkillID, Victim.World.GetTimeSeconds(), CustomData.TimeDuration);
			bool flag = false;
			switch ((EValueCompareOperationType)(byte)CustomData.CompareOperation)
			{
			case EValueCompareOperationType.EqualTo:
				flag = skillBeHitCounter == CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.NotEqualTo:
				flag = skillBeHitCounter != CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.LessThan:
				flag = skillBeHitCounter < CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.LessThanOrEqualTo:
				flag = skillBeHitCounter <= CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.GreaterThan:
				flag = skillBeHitCounter > CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.GreaterThanOrEqualTo:
				flag = skillBeHitCounter >= CustomData.BeHittedNum;
				break;
			}
			if (flag)
			{
				NotifyTriggerInput();
			}
		}
	}
}

using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_BeAttackedNumFromSkillEffect : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_BeAttackedNumFromSkillEffect CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.BeAttackedNumFromSkillEffect;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_BeAttackedNumFromSkillEffect();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeAttackedFromSkillEffect = (Del_Void_ActorInt)Delegate.Combine(bGWEventCollection.Evt_BGW_BeAttackedFromSkillEffect, new Del_Void_ActorInt(BeAttackedNumFromSkillEffect));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_BeAttackedFromSkillEffect = (Del_Void_ActorInt)Delegate.Remove(bGWEventCollection.Evt_BGW_BeAttackedFromSkillEffect, new Del_Void_ActorInt(BeAttackedNumFromSkillEffect));
	}

	private void BeAttackedNumFromSkillEffect(AActor Victim, int SkillEffectID)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(Victim) == base.ListenerFlagID) || SkillEffectID != CustomData.SkillEffectId)
		{
			return;
		}
		IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BeAttackData>(Victim);
		if (readOnlyData != null)
		{
			int skillEffectBeHitCounter = readOnlyData.GetSkillEffectBeHitCounter(SkillEffectID, Victim.World.GetTimeSeconds(), CustomData.TimeDuration);
			bool flag = false;
			switch ((EValueCompareOperationType)(byte)CustomData.CompareOperation)
			{
			case EValueCompareOperationType.EqualTo:
				flag = skillEffectBeHitCounter == CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.NotEqualTo:
				flag = skillEffectBeHitCounter != CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.LessThan:
				flag = skillEffectBeHitCounter < CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.LessThanOrEqualTo:
				flag = skillEffectBeHitCounter <= CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.GreaterThan:
				flag = skillEffectBeHitCounter > CustomData.BeHittedNum;
				break;
			case EValueCompareOperationType.GreaterThanOrEqualTo:
				flag = skillEffectBeHitCounter >= CustomData.BeHittedNum;
				break;
			}
			if (flag)
			{
				NotifyTriggerInput();
			}
		}
	}
}

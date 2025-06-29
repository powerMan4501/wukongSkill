using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_TriggerAttackStiff_ListenAttacker : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_TriggerAttackStiff_ListenAttacker CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.TriggerAttackStiff_ListenAttacker;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_TriggerAttackStiff_ListenAttacker();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.AttackerUnitType, CustomData.AttackerSmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff_ListenAttacker = (Del_Void_ActorActorInt)Delegate.Combine(bGWEventCollection.Evt_BGW_TriggerAttackStiff_ListenAttacker, new Del_Void_ActorActorInt(OnTriggerAttackStiff_ListenAttacker));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff_ListenAttacker = (Del_Void_ActorActorInt)Delegate.Remove(bGWEventCollection.Evt_BGW_TriggerAttackStiff_ListenAttacker, new Del_Void_ActorActorInt(OnTriggerAttackStiff_ListenAttacker));
	}

	private void OnTriggerAttackStiff_ListenAttacker(AActor Victim, AActor Attacker, int StiffLevel)
	{
		string unitFlagId = BGUFunctionLibraryCS.GetUnitFlagId(Attacker);
		if (!(base.ListenerFlagID == unitFlagId))
		{
			return;
		}
		bool flag = false;
		switch ((EValueCompareOperationType)(byte)CustomData.CompareOperation)
		{
		case EValueCompareOperationType.EqualTo:
			flag = StiffLevel == CustomData.StiffLevel;
			break;
		case EValueCompareOperationType.NotEqualTo:
			flag = StiffLevel != CustomData.StiffLevel;
			break;
		case EValueCompareOperationType.LessThan:
			flag = StiffLevel < CustomData.StiffLevel;
			break;
		case EValueCompareOperationType.LessThanOrEqualTo:
			flag = StiffLevel <= CustomData.StiffLevel;
			break;
		case EValueCompareOperationType.GreaterThan:
			flag = StiffLevel > CustomData.StiffLevel;
			break;
		case EValueCompareOperationType.GreaterThanOrEqualTo:
			flag = StiffLevel >= CustomData.StiffLevel;
			break;
		}
		if (flag)
		{
			AActor detectUnitActor = BGUFunctionLibraryCS.GetDetectUnitActor(base.Owner, (EDetectedUnitType)CustomData.VictimUnitType, CustomData.VictimSmartUnitGuid);
			if (!(detectUnitActor == null) && detectUnitActor == Victim)
			{
				NotifyTriggerInput();
			}
		}
	}
}

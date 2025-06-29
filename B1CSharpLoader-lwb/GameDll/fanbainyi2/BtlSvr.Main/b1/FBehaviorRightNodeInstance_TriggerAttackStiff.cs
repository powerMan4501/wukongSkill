using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_TriggerAttackStiff : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_TriggerAttackStiff CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.TriggerAttackStiff;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_TriggerAttackStiff();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff = (Del_Void_ActorActorInt)Delegate.Combine(bGWEventCollection.Evt_BGW_TriggerAttackStiff, new Del_Void_ActorActorInt(OnTriggerAttackStiff));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_TriggerAttackStiff = (Del_Void_ActorActorInt)Delegate.Remove(bGWEventCollection.Evt_BGW_TriggerAttackStiff, new Del_Void_ActorActorInt(OnTriggerAttackStiff));
	}

	private void OnTriggerAttackStiff(AActor Victim, AActor Attacker, int StiffLevel)
	{
		if (!(BGUFunctionLibraryCS.GetUnitFlagId(Victim) == base.ListenerFlagID))
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
		if (!flag)
		{
			return;
		}
		AActor detectUnitActor = BGUFunctionLibraryCS.GetDetectUnitActor(base.Owner, (EDetectedUnitType)CustomData.AttackerUnitType, CustomData.AttackerSmartUnitGuid);
		if (!(detectUnitActor == null))
		{
			BGUCharacterCS bGUCharacterCS = Attacker as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				bGUCharacterCS = ((IBUC_MasterData)BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Attacker)).GetMasterActor() as BGUCharacterCS;
			}
			if (detectUnitActor == bGUCharacterCS)
			{
				NotifyTriggerInput();
			}
		}
	}
}

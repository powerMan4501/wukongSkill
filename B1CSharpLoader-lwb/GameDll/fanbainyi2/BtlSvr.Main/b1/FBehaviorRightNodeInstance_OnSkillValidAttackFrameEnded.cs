using System;
using b1.EventDelDefine;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;

namespace b1;

public class FBehaviorRightNodeInstance_OnSkillValidAttackFrameEnded : FBehaviorRightNodeInstance_ListenerTrigger
{
	private BehaviorCustom_OnSkillValidAttackFrameEnded CustomData { get; set; }

	public override string NodeName => B1CalliopeDef.BehaviorNode.OnSkillValidAttackFrameEnded;

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_OnSkillValidAttackFrameEnded();
		CustomData.MergeFrom(base.Node.NodeData);
		base.ListenerFlagID = BGUFunctionLibraryCS.GetDetectUnitActorFlagId(base.Owner, (EDetectedUnitType)CustomData.UnitType, CustomData.SmartUnitGuid);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_OnSkillValidAttackFrameEnded = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Combine(bGWEventCollection.Evt_BGW_OnSkillValidAttackFrameEnded, new Del_BGW_OnSkillValidAttackFrameEnded(OnSkillValidAttackFrameEnded));
	}

	protected override void Shutdown()
	{
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_BGW_OnSkillValidAttackFrameEnded = (Del_BGW_OnSkillValidAttackFrameEnded)Delegate.Remove(bGWEventCollection.Evt_BGW_OnSkillValidAttackFrameEnded, new Del_BGW_OnSkillValidAttackFrameEnded(OnSkillValidAttackFrameEnded));
		base.Shutdown();
	}

	private void OnSkillValidAttackFrameEnded(AActor Attacker, int SkillID)
	{
		if (BGUFunctionLibraryCS.GetUnitFlagId(Attacker) == base.ListenerFlagID && SkillID == CustomData.SkillId)
		{
			NotifyTriggerInput();
		}
	}
}

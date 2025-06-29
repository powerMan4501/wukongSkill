using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_BACCTemplateList : GameInstanceSystemBase
{
	public Dictionary<EAiConversationConditionType, BACC_Base> ConditionMap;

	public static BGW_BACCTemplateList Get(UObject WorldContext)
	{
		return BGWGameInstanceCS.GetObject<BGW_BACCTemplateList>(WorldContext);
	}

	public override void OnInit()
	{
		InitEffectTemplates();
	}

	private void InitEffectTemplates()
	{
		ConditionMap = new Dictionary<EAiConversationConditionType, BACC_Base>();
		ConditionMap.Add(EAiConversationConditionType.LifeState, new BACC_CheckLifeState());
		ConditionMap.Add(EAiConversationConditionType.SceneObjStateMachine, new BACC_CheckSceneObjStateMachine());
		ConditionMap.Add(EAiConversationConditionType.PartnerAround, new BACC_PartnerAround());
		ConditionMap.Add(EAiConversationConditionType.ActorWithTagAround, new BACC_TagActorsAround());
		ConditionMap.Add(EAiConversationConditionType.Hp, new BACC_CheckHPPercent());
		ConditionMap.Add(EAiConversationConditionType.DistanceToSpeaker2D, new BACC_DistanceToSpeaker2D());
		ConditionMap.Add(EAiConversationConditionType.SimpleState, new BACC_HasSimpleState());
		ConditionMap.Add(EAiConversationConditionType.CheckResId, new BACC_CheckResID());
		ConditionMap.Add(EAiConversationConditionType.BlackboardData, new BACC_BlackboardData());
		ConditionMap.Add(EAiConversationConditionType.BagItemExist, new BACC_BagItemExist());
		ConditionMap.Add(EAiConversationConditionType.IsInFsmState, new BACC_IsInFsmState());
	}

	public BACC_Base GetConditionTemplate(EAiConversationConditionType ConditionType)
	{
		if (ConditionMap.TryGetValue(ConditionType, out var value))
		{
			return value;
		}
		return null;
	}
}

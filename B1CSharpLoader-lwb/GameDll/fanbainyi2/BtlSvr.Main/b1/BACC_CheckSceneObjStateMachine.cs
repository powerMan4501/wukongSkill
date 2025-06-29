using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BACC_CheckSceneObjStateMachine : BACC_Base
{
	public override bool PocessCondition(AActor Speaker, FAiConversationConditionInstData ConditionInstData)
	{
		if (Speaker.IsNullOrDestroyed())
		{
			return false;
		}
		if (ConditionInstData.Target != null)
		{
			string actorGuid = BGU_DataUtil.GetActorGuid(ConditionInstData.Target);
			if (!string.IsNullOrEmpty(actorGuid))
			{
				IBIC_StateMachineData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_StateMachineData, BIC_StateMachineData>(UGameplayStatics.GetGameState(Speaker.World));
				if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.GetCurrentSceneObjState(actorGuid, out var GameplayTagContainerRef) && GameplayTagContainerRef.HasTag(GameplayTagExtension.MakeGameplayTag(ConditionInstData.ConditionValue)))
				{
					return true;
				}
			}
		}
		return false;
	}
}

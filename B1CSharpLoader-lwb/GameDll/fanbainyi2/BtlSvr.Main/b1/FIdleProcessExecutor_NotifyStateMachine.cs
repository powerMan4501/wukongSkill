using CommB1;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_NotifyStateMachine : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.NotifyStateMachine;

	private string GameplayTag { get; set; }

	private string TargetActorGuid { get; set; }

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
		GameplayTag = InIdleProcessAction.GameplayTag;
		TargetActorGuid = InIdleProcessAction.TargetActorGuid;
	}

	public override void Run(UObject InWorldContext)
	{
		BGW_EventCollection.Get(InWorldContext)?.Evt_SendSceneObjEvent(TargetActorGuid, GameplayTagExtension.MakeGameplayTag(GameplayTag));
	}
}

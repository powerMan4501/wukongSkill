using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class FIdleProcessExecutor_ClearAllBloodBar : FIdleProcessExecutorBase
{
	public override EIdleProcessActionType ActionType => EIdleProcessActionType.ClearAllBloodBar;

	public override void Initial(CalliopeCustom_IdleProcessAction InIdleProcessAction, PsmNodeInstance InPsmNodeInstance)
	{
	}

	public override void Run(UObject InWorldContext)
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(InWorldContext, 0);
		if (playerCharacter != null)
		{
			_ = BUS_EventCollectionCS.Get(playerCharacter) != null;
		}
	}
}

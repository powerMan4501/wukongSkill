using UnrealEngine.Runtime;

namespace b1;

public class FsmState_Battle : FsmState_Flag
{
	public override FGameplayTag StateTag => BGW_FlowUtils.NormalAIFsmStateTag.AIBattle;
}

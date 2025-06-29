using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_FsmData
{
	bool bFsmPaused { get; }

	bool bFsmInstancePaused { get; }

	MultiMap<FName, FGameplayTag> CurrentStatesMapping { get; }

	bool IsInFsmState(FGameplayTag StateTag);

	bool IsInFsmState(EBGUFSMStateName StateNameEnum);

	List<FGameplayTag> GetCurrentStates();

	FsmInstancePhaseComp GetPhaseComp();

	List<string> GetPhaseDebugInfo();

	bool HasOverrideSubMachine(FGameplayTag NeedCheckStateTag);
}

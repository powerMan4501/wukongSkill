using System;
using System.Collections.Generic;
using ArchiveB1;
using b1.CppExport;
using UnrealEngine.Runtime;

namespace b1;

public interface IBIC_StateMachineData
{
	StateMachineArchiveData ArchiveData { get; }

	bool GetCurrentSceneObjState(string GetFinalGuid, out GameplayTagContainerRef GameplayTagContainerRef, bool bOuterQuery = true);

	bool GetUnhandledSceneObjEvents(string UnitGuid, in List<FName> GameplayTagContainerRef, out List<FGameplayTag> FGameplayTags);

	bool IsStateMachineNeedReset(string UnitGuid);

	BUS_StateMachineCompBase.GSStateBase GetState(Type StateType);

	bool IsAllActionFinished(string PsmGuid, Guid InNodeGuid);

	bool IsAiConversationChainEnd(string PsmGuid, Guid InNodeGuid);

	int GetAllSceneObjState(out Dictionary<string, GameplayTagContainerRef> OutSceneObjState);

	int GetAllSceneObjTransientState(out Dictionary<string, Dictionary<FGameplayTag, FGameplayTag>> OutSceneObjTransientState);
}

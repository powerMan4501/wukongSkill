using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Hotfix;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Hotfix.EUpdateState", "Hotfix", UnrealModuleType.EnginePlugin)]
public enum EUpdateState : byte
{
	UpdateIdle,
	UpdatePending,
	CheckingForPatch,
	DetectingPlatformEnvironment,
	CheckingForHotfix,
	WaitingOnInitialLoad,
	InitialLoadComplete,
	UpdateComplete
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Hotfix;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Hotfix.EUpdateCompletionStatus", "Hotfix", UnrealModuleType.EnginePlugin)]
public enum EUpdateCompletionStatus : byte
{
	UpdateUnknown,
	UpdateSuccess,
	UpdateSuccess_NoChange,
	UpdateSuccess_NeedsReload,
	UpdateSuccess_NeedsRelaunch,
	UpdateSuccess_NeedsPatch,
	UpdateFailure_PatchCheck,
	UpdateFailure_HotfixCheck,
	UpdateFailure_NotLoggedIn
}

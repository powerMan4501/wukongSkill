using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Hotfix;

[UEnum]
[UMetaPath("/Script/Hotfix.EHotfixResult", "Hotfix", UnrealModuleType.EnginePlugin)]
public enum EHotfixResult
{
	Failed,
	Success,
	SuccessNoChange,
	SuccessNeedsReload,
	SuccessNeedsRelaunch
}

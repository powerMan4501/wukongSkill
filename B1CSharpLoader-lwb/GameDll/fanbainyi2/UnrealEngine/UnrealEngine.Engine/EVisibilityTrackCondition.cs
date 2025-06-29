using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVisibilityTrackCondition", "Engine", UnrealModuleType.Engine)]
public enum EVisibilityTrackCondition
{
	EVTC_Always,
	EVTC_GoreEnabled,
	EVTC_GoreDisabled
}

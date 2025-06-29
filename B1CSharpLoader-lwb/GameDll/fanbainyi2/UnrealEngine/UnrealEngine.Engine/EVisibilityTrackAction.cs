using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVisibilityTrackAction", "Engine", UnrealModuleType.Engine)]
public enum EVisibilityTrackAction
{
	EVTA_Hide,
	EVTA_Show,
	EVTA_Toggle
}

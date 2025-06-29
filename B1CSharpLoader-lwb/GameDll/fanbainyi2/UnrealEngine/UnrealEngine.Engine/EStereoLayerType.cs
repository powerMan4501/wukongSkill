using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStereoLayerType", "Engine", UnrealModuleType.Engine)]
public enum EStereoLayerType
{
	SLT_WorldLocked,
	SLT_TrackerLocked,
	SLT_FaceLocked
}

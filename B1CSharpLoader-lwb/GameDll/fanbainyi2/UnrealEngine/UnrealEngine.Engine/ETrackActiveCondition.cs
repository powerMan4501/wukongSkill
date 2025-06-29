using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETrackActiveCondition", "Engine", UnrealModuleType.Engine)]
public enum ETrackActiveCondition
{
	ETAC_Always,
	ETAC_GoreEnabled,
	ETAC_GoreDisabled
}

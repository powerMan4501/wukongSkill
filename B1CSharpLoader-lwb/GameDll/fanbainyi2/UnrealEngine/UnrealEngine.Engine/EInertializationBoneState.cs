using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EInertializationBoneState", "Engine", UnrealModuleType.Engine)]
public enum EInertializationBoneState
{
	Invalid,
	Valid,
	Excluded
}

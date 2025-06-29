using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EReflectionSourceType", "Engine", UnrealModuleType.Engine)]
public enum EReflectionSourceType
{
	CapturedScene,
	SpecifiedCubemap
}

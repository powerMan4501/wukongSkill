using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESkyLightSourceType", "Engine", UnrealModuleType.Engine)]
public enum ESkyLightSourceType
{
	SLS_CapturedScene,
	SLS_SpecifiedCubemap
}

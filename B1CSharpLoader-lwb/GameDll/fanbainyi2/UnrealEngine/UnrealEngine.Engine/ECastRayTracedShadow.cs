using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECastRayTracedShadow", "Engine", UnrealModuleType.Engine)]
public enum ECastRayTracedShadow
{
	Disabled,
	UseProjectSetting,
	Enabled
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialShadingRate", "Engine", UnrealModuleType.Engine)]
public enum EMaterialShadingRate
{
	MSR_1x1,
	MSR_2x1,
	MSR_1x2,
	MSR_2x2,
	MSR_4x2,
	MSR_2x4,
	MSR_4x4,
	MSR_Count
}

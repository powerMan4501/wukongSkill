using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERayTracingGroupCullingPriority", "Engine", UnrealModuleType.Engine)]
public enum ERayTracingGroupCullingPriority
{
	CP_0_NEVER_CULL,
	CP_1,
	CP_2,
	CP_3,
	CP_4_DEFAULT,
	CP_5,
	CP_6,
	CP_7,
	CP_8_QUICKLY_CULL
}

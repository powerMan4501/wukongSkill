using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EOcclusionCombineMode", "Engine", UnrealModuleType.Engine)]
public enum EOcclusionCombineMode
{
	OCM_Minimum,
	OCM_Multiply
}

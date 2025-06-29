using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ESimulationSpace", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ESimulationSpace
{
	ComponentSpace,
	WorldSpace,
	BaseBoneSpace
}

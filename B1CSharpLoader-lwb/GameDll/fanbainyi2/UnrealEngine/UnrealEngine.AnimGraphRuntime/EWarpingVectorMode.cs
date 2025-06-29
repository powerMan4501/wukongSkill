using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EWarpingVectorMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EWarpingVectorMode : byte
{
	ComponentSpaceVector,
	ActorSpaceVector,
	WorldSpaceVector,
	IKFootRootLocalSpaceVector
}

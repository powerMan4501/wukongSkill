using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.AnimPhysSimSpaceType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EAnimPhysSimSpaceType : byte
{
	Component,
	Actor,
	World,
	RootRelative,
	BoneRelative
}

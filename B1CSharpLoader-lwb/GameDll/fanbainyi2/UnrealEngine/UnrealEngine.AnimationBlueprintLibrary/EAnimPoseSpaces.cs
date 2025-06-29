using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationBlueprintLibrary.EAnimPoseSpaces", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public enum EAnimPoseSpaces : byte
{
	Local,
	World
}

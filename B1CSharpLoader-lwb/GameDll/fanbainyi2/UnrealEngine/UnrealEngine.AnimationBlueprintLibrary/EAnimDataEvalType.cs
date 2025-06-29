using UnrealEngine.Runtime;

namespace UnrealEngine.AnimationBlueprintLibrary;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimationBlueprintLibrary.EAnimDataEvalType", "AnimationBlueprintLibrary", UnrealModuleType.Engine)]
public enum EAnimDataEvalType : byte
{
	Source,
	Raw,
	Compressed
}

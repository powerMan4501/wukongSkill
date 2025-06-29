using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EScaleChainInitialLength", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EScaleChainInitialLength : byte
{
	FixedDefaultLengthValue,
	Distance,
	ChainLength
}

using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.ESequenceEvalReinit", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ESequenceEvalReinit : byte
{
	NoReset,
	StartPosition,
	ExplicitTime
}

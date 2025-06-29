using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.CopyBoneDeltaMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ECopyBoneDeltaMode
{
	Accumulate,
	Copy_
}

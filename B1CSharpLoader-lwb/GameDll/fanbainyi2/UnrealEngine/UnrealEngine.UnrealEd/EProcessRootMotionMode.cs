using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EProcessRootMotionMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EProcessRootMotionMode
{
	Ignore,
	Loop,
	LoopAndReset
}

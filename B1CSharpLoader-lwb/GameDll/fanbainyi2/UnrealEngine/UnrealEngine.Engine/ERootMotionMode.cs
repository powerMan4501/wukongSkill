using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionMode", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionMode
{
	NoRootMotionExtraction,
	IgnoreRootMotion,
	RootMotionFromEverything,
	RootMotionFromMontagesOnly
}

using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EPoseDriverType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EPoseDriverType
{
	SwingAndTwist,
	SwingOnly,
	Translation
}

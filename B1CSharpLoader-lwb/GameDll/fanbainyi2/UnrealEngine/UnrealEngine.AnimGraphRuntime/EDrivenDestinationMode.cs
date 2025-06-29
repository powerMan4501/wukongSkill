using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EDrivenDestinationMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EDrivenDestinationMode
{
	Bone,
	MorphTarget,
	MaterialParameter
}

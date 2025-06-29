using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EDrivenBoneModificationMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EDrivenBoneModificationMode
{
	AddToInput,
	ReplaceComponent,
	AddToRefPose
}

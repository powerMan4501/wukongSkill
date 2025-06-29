using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.EBlendListTransitionType", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EBlendListTransitionType
{
	StandardBlend,
	Inertialization
}

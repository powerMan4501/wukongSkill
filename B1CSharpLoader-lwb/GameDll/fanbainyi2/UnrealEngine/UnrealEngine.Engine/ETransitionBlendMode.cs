using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETransitionBlendMode", "Engine", UnrealModuleType.Engine)]
public enum ETransitionBlendMode
{
	TBM_Linear,
	TBM_Cubic
}

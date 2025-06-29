using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAspectRatioAxisConstraint", "Engine", UnrealModuleType.Engine)]
public enum EAspectRatioAxisConstraint
{
	AspectRatio_MaintainYFOV,
	AspectRatio_MaintainXFOV,
	AspectRatio_MajorAxisFOV
}

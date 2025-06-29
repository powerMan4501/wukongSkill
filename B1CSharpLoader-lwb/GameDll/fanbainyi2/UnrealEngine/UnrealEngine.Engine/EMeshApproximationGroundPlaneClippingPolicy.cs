using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshApproximationGroundPlaneClippingPolicy", "Engine", UnrealModuleType.Engine)]
public enum EMeshApproximationGroundPlaneClippingPolicy
{
	NoGroundClipping,
	DiscardWithZPlane,
	CutWithZPlane,
	CutAndFillWithZPlane
}

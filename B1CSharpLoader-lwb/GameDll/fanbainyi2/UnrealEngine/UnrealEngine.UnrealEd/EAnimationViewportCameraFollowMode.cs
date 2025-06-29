using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EAnimationViewportCameraFollowMode", "UnrealEd", UnrealModuleType.Engine)]
public enum EAnimationViewportCameraFollowMode
{
	None,
	Bounds,
	Bone
}

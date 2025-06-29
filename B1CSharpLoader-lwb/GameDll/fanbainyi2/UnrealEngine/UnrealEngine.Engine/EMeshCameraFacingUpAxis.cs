using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshCameraFacingUpAxis", "Engine", UnrealModuleType.Engine)]
public enum EMeshCameraFacingUpAxis
{
	CameraFacing_NoneUP,
	CameraFacing_ZUp,
	CameraFacing_NegativeZUp,
	CameraFacing_YUp,
	CameraFacing_NegativeYUp
}

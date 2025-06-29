using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UEnum]
[UMetaPath("/Script/CinematicCamera.ECameraFocusMethod", "CinematicCamera", UnrealModuleType.Engine)]
public enum ECameraFocusMethod
{
	DoNotOverride,
	Manual,
	Tracking,
	Disable
}

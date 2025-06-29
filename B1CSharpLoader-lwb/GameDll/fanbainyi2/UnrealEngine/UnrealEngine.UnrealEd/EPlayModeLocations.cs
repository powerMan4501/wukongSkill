using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EPlayModeLocations", "UnrealEd", UnrealModuleType.Engine)]
public enum EPlayModeLocations
{
	PlayLocation_CurrentCameraLocation,
	PlayLocation_DefaultPlayerStart
}

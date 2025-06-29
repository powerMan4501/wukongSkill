using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.EMediaVideoCaptureDeviceFilter", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaVideoCaptureDeviceFilter : byte
{
	None = 0,
	Card = 1,
	Software = 2,
	Unknown = 4,
	Webcam = 8
}

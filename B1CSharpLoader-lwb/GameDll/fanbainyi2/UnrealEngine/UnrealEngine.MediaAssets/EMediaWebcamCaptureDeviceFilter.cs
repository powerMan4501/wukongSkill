using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.EMediaWebcamCaptureDeviceFilter", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaWebcamCaptureDeviceFilter : byte
{
	None = 0,
	DepthSensor = 1,
	Front = 2,
	Rear = 4,
	Unknown = 8
}

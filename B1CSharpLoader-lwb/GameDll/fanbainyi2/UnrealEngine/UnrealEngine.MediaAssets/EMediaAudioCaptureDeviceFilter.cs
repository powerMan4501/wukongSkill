using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.EMediaAudioCaptureDeviceFilter", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaAudioCaptureDeviceFilter : byte
{
	None = 0,
	Card = 1,
	Microphone = 2,
	Software = 4,
	Unknown = 8
}

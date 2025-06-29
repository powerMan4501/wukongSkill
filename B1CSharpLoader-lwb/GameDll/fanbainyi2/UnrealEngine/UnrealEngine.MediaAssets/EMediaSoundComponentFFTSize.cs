using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.EMediaSoundComponentFFTSize", "MediaAssets", UnrealModuleType.Engine)]
public enum EMediaSoundComponentFFTSize : byte
{
	Min_64,
	Small_256,
	Medium_512,
	Large_1024
}

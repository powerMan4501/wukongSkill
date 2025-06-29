using UnrealEngine.Runtime;

namespace UnrealEngine.AudioExtensions;

[UEnum]
[UMetaPath("/Script/AudioExtensions.EPcmBitDepthConversion", "AudioExtensions", UnrealModuleType.Engine)]
public enum EPcmBitDepthConversion
{
	SameAsSource,
	Int16,
	Float32
}

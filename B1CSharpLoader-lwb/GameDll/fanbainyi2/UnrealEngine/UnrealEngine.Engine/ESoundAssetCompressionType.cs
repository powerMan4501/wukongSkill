using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESoundAssetCompressionType", "Engine", UnrealModuleType.Engine)]
public enum ESoundAssetCompressionType : byte
{
	BinkAudio,
	ADPCM,
	PCM,
	PlatformSpecific
}

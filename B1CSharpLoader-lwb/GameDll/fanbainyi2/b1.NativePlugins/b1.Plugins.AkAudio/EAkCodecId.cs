using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkCodecId", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkCodecId : byte
{
	None = 0,
	PCM = 1,
	ADPCM = 2,
	XMA = 3,
	Vorbis = 4,
	ATRAC9 = 12,
	OpusNX = 17,
	AkOpus = 19,
	AkOpusWEM = 20
}

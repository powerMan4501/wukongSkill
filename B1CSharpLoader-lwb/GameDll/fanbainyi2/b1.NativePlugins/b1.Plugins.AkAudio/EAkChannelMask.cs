using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.EAkChannelMask", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkChannelMask
{
	FrontLeft = 0,
	FrontRight = 1,
	FrontCenter = 2,
	LowFrequency = 3,
	BackLeft = 4,
	BackRight = 5,
	BackCenter = 8,
	SideLeft = 9,
	SideRight = 10,
	Top = 11,
	HeightFrontLeft = 12,
	HeightFrontCenter = 13,
	HeightFrontRight = 14,
	HeightBackLeft = 15,
	HeightBackCenter = 16,
	HeightBackRight = 17
}

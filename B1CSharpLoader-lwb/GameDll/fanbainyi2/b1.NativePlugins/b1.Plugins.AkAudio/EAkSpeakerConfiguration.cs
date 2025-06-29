using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[UMetaPath("/Script/AkAudio.AkSpeakerConfiguration", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkSpeakerConfiguration
{
	Ak_Speaker_Front_Left = 1,
	Ak_Speaker_Front_Right = 2,
	Ak_Speaker_Front_Center = 4,
	Ak_Speaker_Low_Frequency = 8,
	Ak_Speaker_Back_Left = 0x10,
	Ak_Speaker_Back_Right = 0x20,
	Ak_Speaker_Back_Center = 0x100,
	Ak_Speaker_Side_Left = 0x200,
	Ak_Speaker_Side_Right = 0x400,
	Ak_Speaker_Top = 0x800,
	Ak_Speaker_Height_Front_Left = 0x1000,
	Ak_Speaker_Height_Front_Center = 0x2000,
	Ak_Speaker_Height_Front_Right = 0x4000,
	Ak_Speaker_Height_Back_Left = 0x8000,
	Ak_Speaker_Height_Back_Center = 0x10000,
	Ak_Speaker_Height_Back_Right = 0x20000
}

using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.EAkCurveInterpolation", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EAkCurveInterpolation : byte
{
	Log3 = 0,
	Sine = 1,
	Log1 = 2,
	InvSCurve = 3,
	Linear = 4,
	SCurve = 5,
	Exp1 = 6,
	SineRecip = 7,
	Exp3 = 8,
	LastFadeCurve = 8,
	Constant = 9
}

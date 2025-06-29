using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.AkCurveInterpolationCS")]
public enum EAkCurveInterpolationCS : byte
{
	Log3 = 0,
	Sine = 1,
	Log1 = 2,
	InvSCurve = 3,
	Linear = 4,
	SCurve = 5,
	Exp1 = 6,
	SineReciprocal = 7,
	Exp3 = 8,
	LastFadeCurve = 8,
	Constant = 9
}

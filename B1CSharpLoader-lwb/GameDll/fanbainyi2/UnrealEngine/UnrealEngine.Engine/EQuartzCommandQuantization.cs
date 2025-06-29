using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuartzCommandQuantization", "Engine", UnrealModuleType.Engine)]
public enum EQuartzCommandQuantization : byte
{
	Bar,
	Beat,
	ThirtySecondNote,
	SixteenthNote,
	EighthNote,
	QuarterNote,
	HalfNote,
	WholeNote,
	DottedSixteenthNote,
	DottedEighthNote,
	DottedQuarterNote,
	DottedHalfNote,
	DottedWholeNote,
	SixteenthNoteTriplet,
	EighthNoteTriplet,
	QuarterNoteTriplet,
	HalfNoteTriplet,
	Tick,
	Count,
	None
}

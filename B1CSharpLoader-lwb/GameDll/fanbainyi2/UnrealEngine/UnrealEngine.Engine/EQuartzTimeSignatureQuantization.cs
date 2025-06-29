using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EQuartzTimeSignatureQuantization", "Engine", UnrealModuleType.Engine)]
public enum EQuartzTimeSignatureQuantization : byte
{
	HalfNote,
	QuarterNote,
	EighthNote,
	SixteenthNote,
	ThirtySecondNote,
	Count
}

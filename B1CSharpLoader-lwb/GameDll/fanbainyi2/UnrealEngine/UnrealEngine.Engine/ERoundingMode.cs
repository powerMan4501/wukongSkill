using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERoundingMode", "Engine", UnrealModuleType.Engine)]
public enum ERoundingMode : byte
{
	HalfToEven,
	HalfFromZero,
	HalfToZero,
	FromZero,
	ToZero,
	ToNegativeInfinity,
	ToPositiveInfinity
}

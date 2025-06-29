using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGMetadataTypes", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataTypes : byte
{
	Float = 0,
	Double = 1,
	Integer32 = 2,
	Integer64 = 3,
	Vector2 = 4,
	Vector = 5,
	Vector4 = 6,
	Quaternion = 7,
	Transform = 8,
	String = 9,
	Boolean = 10,
	Rotator = 11,
	Name = 12,
	Count = 13,
	Unknown = byte.MaxValue
}

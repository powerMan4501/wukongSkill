using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETransformCurveChannel", "Engine", UnrealModuleType.Engine)]
public enum ETransformCurveChannel : byte
{
	Position,
	Rotation,
	Scale,
	Invalid
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldPhysicsDefaultFields", "Chaos", UnrealModuleType.Engine)]
public enum EFieldPhysicsDefaultFields : byte
{
	Field_RadialIntMask,
	Field_RadialFalloff,
	Field_UniformVector,
	Field_RadialVector,
	Field_RadialVectorFalloff,
	Field_EFieldPhysicsDefaultFields_Max
}

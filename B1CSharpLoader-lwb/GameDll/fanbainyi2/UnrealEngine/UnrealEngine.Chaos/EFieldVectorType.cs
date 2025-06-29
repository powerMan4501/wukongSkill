using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldVectorType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldVectorType : byte
{
	Vector_LinearForce,
	Vector_LinearVelocity,
	Vector_AngularVelocity,
	Vector_AngularTorque,
	Vector_PositionTarget,
	Vector_InitialLinearVelocity,
	Vector_InitialAngularVelocity,
	Vector_TargetMax
}

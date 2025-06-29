using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EGeometryCollectionPhysicsTypeEnum", "Chaos", UnrealModuleType.Engine)]
public enum EGeometryCollectionPhysicsTypeEnum : byte
{
	Chaos_AngularVelocity,
	Chaos_DynamicState,
	Chaos_LinearVelocity,
	Chaos_InitialAngularVelocity,
	Chaos_InitialLinearVelocity,
	Chaos_CollisionGroup,
	Chaos_LinearForce,
	Chaos_AngularTorque,
	Chaos_DisableThreshold,
	Chaos_SleepingThreshold,
	Chaos_Max
}

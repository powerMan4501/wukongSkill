using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldPhysicsType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldPhysicsType : byte
{
	Field_None,
	Field_DynamicState,
	Field_LinearForce,
	Field_ExternalClusterStrain,
	Field_Kill,
	Field_LinearVelocity,
	Field_AngularVelociy,
	Field_AngularTorque,
	Field_InternalClusterStrain,
	Field_DisableThreshold,
	Field_SleepingThreshold,
	Field_PositionStatic,
	Field_PositionAnimated,
	Field_PositionTarget,
	Field_DynamicConstraint,
	Field_CollisionGroup,
	Field_ActivateDisabled,
	Field_InitialLinearVelocity,
	Field_InitialAngularVelocity,
	Field_PhysicsType_Max
}

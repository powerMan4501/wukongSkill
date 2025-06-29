using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldScalarType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldScalarType : byte
{
	Scalar_ExternalClusterStrain,
	Scalar_Kill,
	Scalar_DisableThreshold,
	Scalar_SleepingThreshold,
	Scalar_InternalClusterStrain,
	Scalar_DynamicConstraint,
	Scalar_TargetMax
}

using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProjectileScaleCurveXAxisType")]
public enum EProjectileScaleCurveXAxisType : byte
{
	None,
	Time,
	DistWithMaster,
	EnumMax
}

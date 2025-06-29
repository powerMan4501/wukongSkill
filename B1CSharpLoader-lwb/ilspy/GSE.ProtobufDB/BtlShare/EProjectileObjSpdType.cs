using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProjectileObjSpdType")]
public enum EProjectileObjSpdType : byte
{
	None,
	Normal,
	ByTime,
	CurveByTime,
	CurveByDist
}

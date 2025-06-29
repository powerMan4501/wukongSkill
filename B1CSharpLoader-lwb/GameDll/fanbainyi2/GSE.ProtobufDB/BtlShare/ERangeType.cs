using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.RangeType")]
public enum ERangeType : byte
{
	TargetBaseObj,
	Circle,
	Rect,
	Cylinder,
	Sphere,
	Sector,
	ForwardRect,
	Ring,
	AnnularSector,
	VelocityDirSphere,
	MultiTargetTurn,
	GroupTarget,
	FamilyTarget
}

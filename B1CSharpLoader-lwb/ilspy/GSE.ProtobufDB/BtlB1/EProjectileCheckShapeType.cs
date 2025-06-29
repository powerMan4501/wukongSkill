using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProjectileCheckShapeType")]
public enum EProjectileCheckShapeType : byte
{
	DefaultShape,
	BoxShape,
	SphereShape,
	CapsuleShape,
	SceneItem,
	CustomShape,
	LineTrace
}

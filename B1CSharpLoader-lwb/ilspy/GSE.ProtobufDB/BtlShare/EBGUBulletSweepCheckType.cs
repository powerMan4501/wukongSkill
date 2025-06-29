using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUBulletSweepCheckType")]
public enum EBGUBulletSweepCheckType : byte
{
	BoxShape,
	SphereShape,
	CapsuleShape,
	EbgubulletSweepCheckTypeSceneItem,
	CustomShape,
	EnumMax
}

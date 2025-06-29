using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUBulletRecoveryMode")]
public enum EBGUBulletRecoveryMode : byte
{
	HitDestroy,
	FlyBackByTime,
	HitNotDestroy,
	EnumMax
}

using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProjectileResetDirType")]
public enum EProjectileResetDirType : byte
{
	None,
	WorldSpace,
	CasterLocalSpace,
	CasterControllerLocalSpace,
	Fpstype,
	LookAtTarget
}

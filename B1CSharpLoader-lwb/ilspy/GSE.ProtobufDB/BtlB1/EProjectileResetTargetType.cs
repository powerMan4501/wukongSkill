using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.ProjectileResetTargetType")]
public enum EProjectileResetTargetType : byte
{
	None = 0,
	ProjectileSpawner = 1,
	CurTargetProjectileSpawner = 4,
	UsePointSetCached = 5,
	UseSkillBaseTarget = 7,
	SceneItemCached = 8,
	InnerTarget = 9,
	EQSPoint = 10
}

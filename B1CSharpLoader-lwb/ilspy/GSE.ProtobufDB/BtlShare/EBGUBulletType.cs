using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUBulletType")]
public enum EBGUBulletType : byte
{
	NormalSpawn = 0,
	Weapon = 1,
	SceneItem = 2,
	ModularActor = 5,
	WeaponSceneItem = 6,
	MultiTarget = 7,
	EnumMax = 8
}

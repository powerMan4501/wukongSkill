using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EECSDataInitType")]
public enum EECSDataInitType : byte
{
	PlayerAttr,
	PlayerBirthPoint,
	MonsterAttr
}

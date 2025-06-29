using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EGSQTESyncType")]
public enum EGSQTESyncType : byte
{
	None = 0,
	MoveEnemy = 1,
	MovePlayer = 2,
	BothInTurn = 3,
	BothSameTime = 4,
	AutoEnemyFirst = 5,
	AutoPlayerFirst = 6,
	EnumMax = byte.MaxValue
}

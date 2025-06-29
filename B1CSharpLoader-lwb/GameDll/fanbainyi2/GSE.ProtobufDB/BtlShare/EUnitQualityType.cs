using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitQualityType")]
public enum EUnitQualityType : byte
{
	None = 0,
	Minion = 1,
	Soldier = 2,
	Captain = 3,
	Chief = 4,
	NormalElite = 5,
	CoreElite = 6,
	NormalBoss = 7,
	FinalBoss = 8,
	PlayerSummon = 98,
	Player = 99
}

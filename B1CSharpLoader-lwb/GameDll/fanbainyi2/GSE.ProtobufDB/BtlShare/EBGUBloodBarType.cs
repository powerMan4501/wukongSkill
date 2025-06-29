using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUBloodBarType")]
public enum EBGUBloodBarType : byte
{
	None,
	BossBar,
	EnemyBar,
	EliteBar,
	PlayerBar,
	EnumMax
}

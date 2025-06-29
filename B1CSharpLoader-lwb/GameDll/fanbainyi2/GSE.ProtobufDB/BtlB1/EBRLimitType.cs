using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBRLimitType")]
public enum EBRLimitType : byte
{
	None,
	AttrOverride,
	Talent,
	Buff,
	BattleTimeLimit
}

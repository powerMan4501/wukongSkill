using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.PlayerTransType")]
public enum EPlayerTransType : byte
{
	BattleUnit,
	NoBattleUnit,
	Ride
}

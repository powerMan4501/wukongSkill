using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitSquadMemberType")]
public enum EUnitSquadMemberType : byte
{
	None = 0,
	TeamMate = 1,
	Captain = 2,
	EnumMax = byte.MaxValue
}

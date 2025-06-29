using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EGSRoarWeightLevel")]
public enum EGSRoarWeightLevel : byte
{
	NoFeeling,
	Light,
	Medium,
	Heavy,
	EnumMax
}

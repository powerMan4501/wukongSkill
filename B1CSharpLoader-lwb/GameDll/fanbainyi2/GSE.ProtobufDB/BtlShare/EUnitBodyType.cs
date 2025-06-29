using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.UnitBodyType")]
public enum EUnitBodyType : byte
{
	None,
	Small,
	Medium,
	MediumBig,
	Big,
	Huge
}

using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.FixFunctionType")]
public enum EFixFunctionType : byte
{
	None,
	AttrBaseModifyAttr,
	AttrBaseAbsModifyAttr,
	PlayerCountAttr,
	PlayerDashengTalentAttr,
	PlayerWinePartnerAttr,
	AttrMulModifyAttr
}

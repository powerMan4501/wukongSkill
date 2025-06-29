using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffTickRuleBySSType")]
public enum EBuffTickRuleBySSType : byte
{
	None,
	BlackList,
	WhiteList
}

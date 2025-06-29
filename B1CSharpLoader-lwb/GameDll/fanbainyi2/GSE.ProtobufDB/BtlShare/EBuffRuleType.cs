using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffRuleType")]
public enum EBuffRuleType : byte
{
	BuffRuleNone,
	BrReplace,
	BrExclude,
	BrCoexist,
	BrCompose,
	BrPrecondition
}

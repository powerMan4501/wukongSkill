using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EACFactDataOperateType")]
public enum EACFactDataOperateType : byte
{
	None,
	Replace,
	Increase,
	Decrease,
	Or,
	And
}

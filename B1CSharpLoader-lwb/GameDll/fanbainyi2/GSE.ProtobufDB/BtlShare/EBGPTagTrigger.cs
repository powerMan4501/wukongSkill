using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGPTagTrigger")]
public enum EBGPTagTrigger : byte
{
	None,
	TransformBegin,
	TransformEnd,
	PauseEneryBegin,
	PauseEneryEnd,
	DisableTransformBegin,
	DisableTransformEnd,
	EnumMax
}

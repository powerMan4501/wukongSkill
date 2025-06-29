using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SmartSelectShapeType")]
public enum ESmartSelectShapeType : byte
{
	SssNone,
	SssFixedCircle,
	SssSector,
	SssArrow,
	SssRectangle,
	SssInCircle,
	SssCircle,
	SssArrowToCircle,
	SssShootUi
}

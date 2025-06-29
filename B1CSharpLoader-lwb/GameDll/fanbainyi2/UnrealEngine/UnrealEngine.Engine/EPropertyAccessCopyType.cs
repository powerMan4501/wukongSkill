using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EPropertyAccessCopyType", "Engine", UnrealModuleType.Engine)]
public enum EPropertyAccessCopyType
{
	None,
	Plain,
	Complex,
	Bool,
	Struct,
	Object,
	Name,
	Array,
	PromoteBoolToByte,
	PromoteBoolToInt32,
	PromoteBoolToInt64,
	PromoteBoolToFloat,
	PromoteBoolToDouble,
	PromoteByteToInt32,
	PromoteByteToInt64,
	PromoteByteToFloat,
	PromoteByteToDouble,
	PromoteInt32ToInt64,
	PromoteInt32ToFloat,
	PromoteInt32ToDouble,
	PromoteFloatToDouble,
	DemoteDoubleToFloat,
	PromoteArrayFloatToDouble,
	DemoteArrayDoubleToFloat
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.ESetMaskConditionType", "Chaos", UnrealModuleType.Engine)]
public enum ESetMaskConditionType : byte
{
	Field_Set_Always,
	Field_Set_IFF_NOT_Interior,
	Field_Set_IFF_NOT_Exterior,
	Field_MaskCondition_Max
}

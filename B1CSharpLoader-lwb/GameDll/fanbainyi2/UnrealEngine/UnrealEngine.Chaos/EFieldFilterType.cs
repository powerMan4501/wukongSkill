using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldFilterType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldFilterType : byte
{
	Field_Filter_Dynamic,
	Field_Filter_Kinematic,
	Field_Filter_Static,
	Field_Filter_All,
	Field_Filter_Sleeping,
	Field_Filter_Disabled,
	Field_Filter_Max
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldFalloffType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldFalloffType : byte
{
	Field_FallOff_None,
	Field_Falloff_Linear,
	Field_Falloff_Inverse,
	Field_Falloff_Squared,
	Field_Falloff_Logarithmic,
	Field_Falloff_Max
}

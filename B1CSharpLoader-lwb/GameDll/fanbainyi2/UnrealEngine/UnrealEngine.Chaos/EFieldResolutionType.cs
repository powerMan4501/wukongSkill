using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldResolutionType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldResolutionType : byte
{
	Field_Resolution_Minimal,
	Field_Resolution_DisabledParents,
	Field_Resolution_Maximum,
	Field_Resolution_Max
}

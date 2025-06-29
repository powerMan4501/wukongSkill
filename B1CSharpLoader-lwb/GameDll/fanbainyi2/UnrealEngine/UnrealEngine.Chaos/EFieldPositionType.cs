using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldPositionType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldPositionType : byte
{
	Field_Position_CenterOfMass,
	Field_Position_PivotPoint,
	Field_Position_Max
}

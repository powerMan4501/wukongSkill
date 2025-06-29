using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EFieldOutputType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldOutputType
{
	Field_Output_Vector,
	Field_Output_Scalar,
	Field_Output_Integer,
	Field_Output_Max
}

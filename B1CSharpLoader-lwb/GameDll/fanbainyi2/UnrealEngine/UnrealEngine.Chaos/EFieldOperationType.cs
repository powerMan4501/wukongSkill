using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldOperationType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldOperationType : byte
{
	Field_Multiply,
	Field_Divide,
	Field_Add,
	Field_Substract,
	Field_Operation_Max
}

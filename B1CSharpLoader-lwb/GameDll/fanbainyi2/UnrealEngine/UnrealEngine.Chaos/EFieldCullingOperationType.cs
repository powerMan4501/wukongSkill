using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EFieldCullingOperationType", "Chaos", UnrealModuleType.Engine)]
public enum EFieldCullingOperationType : byte
{
	Field_Culling_Inside,
	Field_Culling_Outside,
	Field_Culling_Operation_Max
}

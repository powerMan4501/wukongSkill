using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ERichCurveTangentWeightMode", "Engine", UnrealModuleType.Engine)]
public enum ERichCurveTangentWeightMode : byte
{
	RCTWM_WeightedNone,
	RCTWM_WeightedArrive,
	RCTWM_WeightedLeave,
	RCTWM_WeightedBoth
}

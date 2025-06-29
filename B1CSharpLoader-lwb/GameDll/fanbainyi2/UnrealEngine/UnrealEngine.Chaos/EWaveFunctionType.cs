using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EWaveFunctionType", "Chaos", UnrealModuleType.Engine)]
public enum EWaveFunctionType : byte
{
	Field_Wave_Cosine,
	Field_Wave_Gaussian,
	Field_Wave_Falloff,
	Field_Wave_Decay,
	Field_Wave_Max
}

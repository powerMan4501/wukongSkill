using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Chaos.EEmissionPatternTypeEnum", "Chaos", UnrealModuleType.Engine)]
public enum EEmissionPatternTypeEnum : byte
{
	Chaos_Emission_Pattern_First_Frame,
	Chaos_Emission_Pattern_On_Demand,
	Chaos_Max
}

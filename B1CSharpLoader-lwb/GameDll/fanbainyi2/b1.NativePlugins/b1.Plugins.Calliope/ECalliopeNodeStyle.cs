using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.ECalliopeNodeStyle", "Calliope", UnrealModuleType.GamePlugin)]
public enum ECalliopeNodeStyle : byte
{
	Condition,
	Default,
	InOut,
	Latent,
	Logic,
	SubGraph,
	Transit
}

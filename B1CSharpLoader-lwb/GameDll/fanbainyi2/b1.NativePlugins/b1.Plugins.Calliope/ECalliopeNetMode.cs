using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.ECalliopeNetMode", "Calliope", UnrealModuleType.GamePlugin)]
public enum ECalliopeNetMode : byte
{
	Any,
	Authority,
	ClientOnly,
	ServerOnly,
	SinglePlayerOnly
}

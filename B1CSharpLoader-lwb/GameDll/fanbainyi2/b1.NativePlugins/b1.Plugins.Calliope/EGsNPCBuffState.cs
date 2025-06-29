using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsNPCBuffState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsNPCBuffState : byte
{
	Add,
	Remove
}

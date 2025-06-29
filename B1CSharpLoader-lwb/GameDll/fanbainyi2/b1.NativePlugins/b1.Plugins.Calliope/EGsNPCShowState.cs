using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsNPCShowState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsNPCShowState : byte
{
	Show,
	Hide
}

using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsInteractorState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsInteractorState : byte
{
	Interactive,
	NotInteractive
}

using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.ECalliopeActivationState", "Calliope", UnrealModuleType.GamePlugin)]
public enum ECalliopeActivationState : byte
{
	NeverActivated,
	Active,
	WasActive
}

using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsInteractorManagePolice", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsInteractorManagePolice : byte
{
	SameAsPrevious,
	KeepInteractive,
	KeepNotInteractive
}

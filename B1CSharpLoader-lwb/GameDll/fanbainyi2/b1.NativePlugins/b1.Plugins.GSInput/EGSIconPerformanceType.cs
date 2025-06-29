using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSIconPerformanceType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSIconPerformanceType : byte
{
	Normal,
	HoldInteract,
	Combo
}

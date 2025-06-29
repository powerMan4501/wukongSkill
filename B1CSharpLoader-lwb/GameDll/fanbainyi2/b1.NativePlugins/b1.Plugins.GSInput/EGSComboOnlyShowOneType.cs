using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSComboOnlyShowOneType", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSComboOnlyShowOneType : byte
{
	First,
	Second,
	Both
}

using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSInput.EGSInputProcOrder", "GSInput", UnrealModuleType.GamePlugin)]
public enum EGSInputProcOrder : byte
{
	Setting,
	General
}

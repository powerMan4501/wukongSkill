using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.EEffectTypeManagerCullMode", "UnrealExtent", UnrealModuleType.Game)]
public enum EEffectTypeManagerCullMode : byte
{
	Enabled,
	Paused,
	Disabled
}

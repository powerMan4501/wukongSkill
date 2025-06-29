using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.EFOVScalingType", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EFOVScalingType
{
	Standard,
	UE4_BackCompat
}

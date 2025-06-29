using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.EInputActionValueType", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EInputActionValueType : byte
{
	Boolean,
	Axis1D,
	Axis2D,
	Axis3D
}

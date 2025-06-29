using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UEnum]
[UMetaPath("/Script/EnhancedInput.EInputAxisSwizzle", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public enum EInputAxisSwizzle
{
	YXZ,
	ZYX,
	XZY,
	YZX,
	ZXY
}

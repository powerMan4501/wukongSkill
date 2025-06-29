using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EViewTargetBlendFunction", "Engine", UnrealModuleType.Engine)]
public enum EViewTargetBlendFunction
{
	VTBlend_Linear,
	VTBlend_Cubic,
	VTBlend_EaseIn,
	VTBlend_EaseOut,
	VTBlend_EaseInOut,
	VTBlend_PreBlended
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDynamicGlobalIlluminationMethod", "Engine", UnrealModuleType.Engine)]
public enum EDynamicGlobalIlluminationMethod
{
	None,
	Lumen,
	ScreenSpace,
	RayTraced,
	Plugin
}

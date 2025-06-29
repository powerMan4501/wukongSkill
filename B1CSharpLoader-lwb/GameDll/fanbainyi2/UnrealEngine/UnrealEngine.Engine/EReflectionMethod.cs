using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EReflectionMethod", "Engine", UnrealModuleType.Engine)]
public enum EReflectionMethod
{
	None,
	Lumen,
	ScreenSpace,
	RayTraced
}

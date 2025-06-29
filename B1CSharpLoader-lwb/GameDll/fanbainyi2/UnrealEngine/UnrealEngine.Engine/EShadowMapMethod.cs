using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EShadowMapMethod", "Engine", UnrealModuleType.Engine)]
public enum EShadowMapMethod
{
	ShadowMaps,
	VirtualShadowMaps
}

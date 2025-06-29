using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialFunctionUsage", "Engine", UnrealModuleType.Engine)]
public enum EMaterialFunctionUsage
{
	Default,
	MaterialLayer,
	MaterialLayerBlend
}

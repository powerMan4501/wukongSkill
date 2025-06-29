using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMeshSelectorMaterialOverrideMode", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMeshSelectorMaterialOverrideMode
{
	NoOverride,
	StaticOverride,
	ByAttributeOverride
}

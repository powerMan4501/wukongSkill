using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGDebugVisScaleMethod", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGDebugVisScaleMethod
{
	Relative,
	Absolute,
	Extents
}

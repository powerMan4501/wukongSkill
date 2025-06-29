using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGTypeConversion", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGTypeConversion
{
	NoConversionRequired,
	CollapseToPoint,
	Filter,
	MakeConcrete,
	Failed
}

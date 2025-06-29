using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataOp", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataOp
{
	Min,
	Max,
	Sub,
	Add,
	Mul,
	Div,
	SourceValue,
	TargetValue
}

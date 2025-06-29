using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointFilterOperator", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointFilterOperator
{
	Greater,
	GreaterOrEqual,
	Lesser,
	LesserOrEqual,
	Equal,
	NotEqual,
	InRange,
	Substring,
	Matches
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepGeometryOperations;

[UEnum]
[UMetaPath("/Script/DataprepGeometryOperations.EPlaneCutKeepSide", "DataprepGeometryOperations", UnrealModuleType.EnginePlugin)]
public enum EPlaneCutKeepSide
{
	Positive,
	Negative,
	Both
}

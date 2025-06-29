using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ECSGOperation", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ECSGOperation
{
	DifferenceAB,
	DifferenceBA,
	Intersect,
	Union
}

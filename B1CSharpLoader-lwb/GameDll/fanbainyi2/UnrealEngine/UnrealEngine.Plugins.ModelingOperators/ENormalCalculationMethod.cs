using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ENormalCalculationMethod", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ENormalCalculationMethod
{
	AreaWeighted,
	AngleWeighted,
	AreaAngleWeighting
}

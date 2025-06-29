using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERemeshSmoothingType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERemeshSmoothingType
{
	Uniform,
	Cotangent,
	MeanValue
}

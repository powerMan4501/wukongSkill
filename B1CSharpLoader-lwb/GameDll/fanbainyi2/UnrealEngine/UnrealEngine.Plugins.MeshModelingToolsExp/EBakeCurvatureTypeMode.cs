using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EBakeCurvatureTypeMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EBakeCurvatureTypeMode
{
	MeanAverage,
	Max,
	Min,
	Gaussian
}

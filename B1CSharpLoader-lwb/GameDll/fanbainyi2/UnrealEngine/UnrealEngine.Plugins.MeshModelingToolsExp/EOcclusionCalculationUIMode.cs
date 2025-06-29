using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EOcclusionCalculationUIMode", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EOcclusionCalculationUIMode
{
	GeneralizedWindingNumber,
	RaycastOcclusionSamples
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[UMetaPath("/Script/ModelingComponents.ESpaceCurveControlPointTransformMode", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum ESpaceCurveControlPointTransformMode
{
	Shared,
	PerVertex
}

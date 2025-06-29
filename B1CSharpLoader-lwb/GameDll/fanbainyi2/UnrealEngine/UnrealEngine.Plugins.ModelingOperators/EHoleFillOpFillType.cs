using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.EHoleFillOpFillType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum EHoleFillOpFillType
{
	TriangleFan,
	PolygonEarClipping,
	Planar,
	Minimal,
	Smooth
}

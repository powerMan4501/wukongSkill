using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EMeshVertexSculptBrushType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EMeshVertexSculptBrushType
{
	Move,
	PullKelvin,
	PullSharpKelvin,
	Smooth,
	SmoothFill,
	Offset,
	SculptView,
	SculptMax,
	Inflate,
	ScaleKelvin,
	Pinch,
	TwistKelvin,
	Flatten,
	Plane,
	PlaneViewAligned,
	FixedPlane,
	LastValue
}

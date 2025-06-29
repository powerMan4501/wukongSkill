using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.EDynamicMeshSculptBrushType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum EDynamicMeshSculptBrushType
{
	Move,
	PullKelvin,
	PullSharpKelvin,
	Smooth,
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
	Resample,
	LastValue
}

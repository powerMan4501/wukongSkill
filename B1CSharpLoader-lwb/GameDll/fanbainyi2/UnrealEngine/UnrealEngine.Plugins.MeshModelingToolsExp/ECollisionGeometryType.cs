using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MeshModelingToolsExp;

[UEnum]
[UMetaPath("/Script/MeshModelingToolsExp.ECollisionGeometryType", "MeshModelingToolsExp", UnrealModuleType.EnginePlugin)]
public enum ECollisionGeometryType
{
	KeepExisting = 0,
	AlignedBoxes = 1,
	OrientedBoxes = 2,
	MinimalSpheres = 3,
	Capsules = 4,
	ConvexHulls = 5,
	SweptHulls = 6,
	MinVolume = 10,
	None = 11
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.EGeometryScriptCollisionGenerationMethod", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public enum EGeometryScriptCollisionGenerationMethod : byte
{
	AlignedBoxes,
	OrientedBoxes,
	MinimalSpheres,
	Capsules,
	ConvexHulls,
	SweptHulls,
	MinVolumeShapes
}

using UnrealEngine.Runtime;

namespace UnrealEngine.PhysicsUtilities;

[UEnum]
[UMetaPath("/Script/PhysicsUtilities.EPhysAssetFitGeomType", "PhysicsUtilities", UnrealModuleType.Engine)]
public enum EPhysAssetFitGeomType
{
	EFG_Box,
	EFG_Sphyl,
	EFG_Sphere,
	EFG_TaperedCapsule,
	EFG_SingleConvexHull,
	EFG_MultiConvexHull
}

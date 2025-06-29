using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EThumbnailPrimType", "UnrealEd", UnrealModuleType.Engine)]
public enum EThumbnailPrimType
{
	TPT_None,
	TPT_Sphere,
	TPT_Cube,
	TPT_Plane,
	TPT_Cylinder
}

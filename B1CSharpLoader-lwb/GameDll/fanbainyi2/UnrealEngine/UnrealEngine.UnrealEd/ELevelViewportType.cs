using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ELevelViewportType", "UnrealEd", UnrealModuleType.Engine)]
public enum ELevelViewportType
{
	LVT_OrthoXY = 0,
	LVT_OrthoXZ = 1,
	LVT_OrthoYZ = 2,
	LVT_Perspective = 3,
	LVT_OrthoFreelook = 4,
	LVT_OrthoNegativeXY = 5,
	LVT_OrthoNegativeXZ = 6,
	LVT_OrthoNegativeYZ = 7,
	LVT_MAX = 8,
	LVT_None = 255
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Landscape;

[UEnum]
[UMetaPath("/Script/Landscape.ELandscapeGizmoType", "Landscape", UnrealModuleType.Engine)]
public enum ELandscapeGizmoType
{
	LGT_None,
	LGT_Height,
	LGT_Weight
}

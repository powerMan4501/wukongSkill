using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EWidgetGeometryMode", "UMG", UnrealModuleType.Engine)]
public enum EWidgetGeometryMode : byte
{
	Plane,
	Cylinder
}

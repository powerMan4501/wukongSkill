using UnrealEngine.Runtime;

namespace b1.Plugins.UMGSpline;

[UEnum]
[UMetaPath("/Script/UMGSpline.EUMGSplineCoordinateSpace", "UMGSpline", UnrealModuleType.GamePlugin)]
public enum EUMGSplineCoordinateSpace
{
	Local,
	Viewport,
	Screen
}

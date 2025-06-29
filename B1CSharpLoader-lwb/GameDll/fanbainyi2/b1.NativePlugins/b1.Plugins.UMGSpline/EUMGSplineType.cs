using UnrealEngine.Runtime;

namespace b1.Plugins.UMGSpline;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMGSpline.EUMGSplineType", "UMGSpline", UnrealModuleType.GamePlugin)]
public enum EUMGSplineType : byte
{
	Linear,
	Curve
}

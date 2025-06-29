using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MaterialLayerParamType")]
public enum EMaterialLayerParamType : byte
{
	[UMeta(MD.Hidden)]
	None,
	Scalar,
	LinearColor,
	ScalarCurve,
	ColorCurve
}

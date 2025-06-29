using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MaterialLayerParamEvaluateType")]
public enum EMaterialLayerParamEvaluateType : byte
{
	[UMeta(MD.Hidden)]
	None,
	Override,
	Additive
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECurveBlendOption", "Engine", UnrealModuleType.Engine)]
public enum ECurveBlendOption
{
	Override,
	DoNotOverride,
	NormalizeByWeight,
	BlendByWeight,
	UseBasePose,
	UseMaxValue,
	UseMinValue
}

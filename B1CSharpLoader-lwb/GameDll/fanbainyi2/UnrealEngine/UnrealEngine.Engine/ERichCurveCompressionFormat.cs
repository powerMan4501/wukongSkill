using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERichCurveCompressionFormat", "Engine", UnrealModuleType.Engine)]
public enum ERichCurveCompressionFormat
{
	RCCF_Empty,
	RCCF_Constant,
	RCCF_Linear,
	RCCF_Cubic,
	RCCF_Mixed,
	RCCF_Weighted
}

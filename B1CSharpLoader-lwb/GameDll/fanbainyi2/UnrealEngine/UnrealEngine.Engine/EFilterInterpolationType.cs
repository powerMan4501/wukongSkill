using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFilterInterpolationType", "Engine", UnrealModuleType.Engine)]
public enum EFilterInterpolationType
{
	BSIT_Average,
	BSIT_Linear,
	BSIT_Cubic,
	BSIT_EaseInOut,
	BSIT_ExponentialDecay,
	BSIT_SpringDamper
}

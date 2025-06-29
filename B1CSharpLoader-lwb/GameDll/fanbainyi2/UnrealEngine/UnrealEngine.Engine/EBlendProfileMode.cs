using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlendProfileMode", "Engine", UnrealModuleType.Engine)]
public enum EBlendProfileMode
{
	TimeFactor,
	WeightFactor,
	BlendMask
}

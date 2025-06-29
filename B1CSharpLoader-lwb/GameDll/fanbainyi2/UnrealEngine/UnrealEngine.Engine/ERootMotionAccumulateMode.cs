using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionAccumulateMode", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionAccumulateMode
{
	Override,
	Additive
}

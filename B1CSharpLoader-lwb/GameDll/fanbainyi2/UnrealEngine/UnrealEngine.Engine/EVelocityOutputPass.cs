using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVelocityOutputPass", "Engine", UnrealModuleType.Engine)]
public enum EVelocityOutputPass
{
	DepthPass,
	BasePass,
	AfterBasePass
}

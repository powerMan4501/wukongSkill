using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionSourceStatusFlags", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionSourceStatusFlags
{
	Prepared = 1,
	Finished = 2,
	MarkedForRemoval = 4
}

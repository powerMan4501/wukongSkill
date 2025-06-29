using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERootMotionRootLock", "Engine", UnrealModuleType.Engine)]
public enum ERootMotionRootLock
{
	RefPose,
	AnimFirstFrame,
	Zero
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMouseLockMode", "Engine", UnrealModuleType.Engine)]
public enum EMouseLockMode
{
	DoNotLock,
	LockOnCapture,
	LockAlways,
	LockInFullscreen
}

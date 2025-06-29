using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EParticleAxisLock", "Engine", UnrealModuleType.Engine)]
public enum EParticleAxisLock
{
	EPAL_NONE,
	EPAL_X,
	EPAL_Y,
	EPAL_Z,
	EPAL_NEGATIVE_X,
	EPAL_NEGATIVE_Y,
	EPAL_NEGATIVE_Z,
	EPAL_ROTATE_X,
	EPAL_ROTATE_Y,
	EPAL_ROTATE_Z
}

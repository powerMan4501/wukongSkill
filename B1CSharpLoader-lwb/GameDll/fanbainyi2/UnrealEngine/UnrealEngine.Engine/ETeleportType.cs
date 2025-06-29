using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETeleportType", "Engine", UnrealModuleType.Engine)]
public enum ETeleportType
{
	None,
	TeleportPhysics,
	ResetPhysics
}

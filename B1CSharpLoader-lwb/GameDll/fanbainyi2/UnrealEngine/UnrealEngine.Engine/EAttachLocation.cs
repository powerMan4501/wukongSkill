using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAttachLocation", "Engine", UnrealModuleType.Engine)]
public enum EAttachLocation
{
	KeepRelativeOffset,
	KeepWorldPosition,
	SnapToTarget,
	SnapToTargetIncludingScale
}

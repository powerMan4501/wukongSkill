using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAttachmentRule", "Engine", UnrealModuleType.Engine)]
public enum EAttachmentRule
{
	KeepRelative,
	KeepWorld,
	SnapToTarget
}

using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDetachmentRule", "Engine", UnrealModuleType.Engine)]
public enum EDetachmentRule
{
	KeepRelative,
	KeepWorld
}

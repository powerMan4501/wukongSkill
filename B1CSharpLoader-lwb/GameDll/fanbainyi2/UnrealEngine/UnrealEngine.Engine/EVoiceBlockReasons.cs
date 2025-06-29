using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVoiceBlockReasons", "Engine", UnrealModuleType.Engine)]
public enum EVoiceBlockReasons
{
	None = 0,
	Muted = 1,
	MutedBy = 2,
	Gameplay = 4,
	Blocked = 8,
	BlockedBy = 0x10
}

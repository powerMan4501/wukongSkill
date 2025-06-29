using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.ETextCommit", "SlateCore", UnrealModuleType.Engine)]
public enum ETextCommit : byte
{
	Default,
	OnEnter,
	OnUserMovedFocus,
	OnCleared
}

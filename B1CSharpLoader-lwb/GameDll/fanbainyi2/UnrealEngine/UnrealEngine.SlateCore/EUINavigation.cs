using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/SlateCore.EUINavigation", "SlateCore", UnrealModuleType.Engine)]
public enum EUINavigation : byte
{
	Left,
	Right,
	Up,
	Down,
	Next,
	Previous,
	Num,
	Invalid
}

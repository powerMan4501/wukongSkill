using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EScrollWhenFocusChanges", "Slate", UnrealModuleType.Engine)]
public enum EScrollWhenFocusChanges : byte
{
	NoScroll,
	InstantScroll,
	AnimatedScroll
}

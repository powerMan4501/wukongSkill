using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FocusReason")]
public enum EFocusReason : byte
{
	Init,
	ManualSet
}

using UnrealEngine.Runtime;

namespace b1.UI;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EnShortcutType")]
public enum EnShortcutType : byte
{
	INIT,
	ITEM,
	SPELL,
	TRANSSPELL
}

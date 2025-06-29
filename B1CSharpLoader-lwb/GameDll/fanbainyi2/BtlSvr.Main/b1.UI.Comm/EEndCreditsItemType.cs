using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[USharpPath("/Script/b1-Managed.EndCreditsItemType")]
public enum EEndCreditsItemType : byte
{
	None,
	Text,
	Image,
	Item,
	Page
}

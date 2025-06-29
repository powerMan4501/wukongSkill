using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.KeyBoardShowFocusType")]
public enum EKeyBoardShowFocusType : byte
{
	[DisplayName("不显示")]
	Hide,
	[DisplayName("仅Hover时显示")]
	OnlyHover,
	[DisplayName("永远显示")]
	Always
}

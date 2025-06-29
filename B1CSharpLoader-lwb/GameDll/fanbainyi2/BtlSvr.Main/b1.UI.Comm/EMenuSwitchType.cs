using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.MenuSwitchType")]
public enum EMenuSwitchType : byte
{
	[DisplayName("手动激活")]
	Normal,
	[DisplayName("子项Focused时激活")]
	FocusActived,
	[DisplayName("子项Aiming时激活")]
	AimingActived,
	[DisplayName("手柄下项Focused或键鼠时激活")]
	KeyBoardOrFocusActived
}

using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ComboTargetType")]
public enum EComboTargetType : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("当前AI目标")]
	CurrentAITarget,
	[Tooltip("选取的是距离最近的Player")]
	[DisplayName("玩家")]
	Player
}

using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AiBreakInteractionType")]
public enum EAiBreakInteractionType : byte
{
	[DisplayName("进入战斗")]
	Battle,
	[DisplayName("玩家超级远离")]
	PlayerFaraway,
	[DisplayName("玩家离开交互区域")]
	PlayerLeaveInteractArea,
	[DisplayName("其他")]
	Other
}

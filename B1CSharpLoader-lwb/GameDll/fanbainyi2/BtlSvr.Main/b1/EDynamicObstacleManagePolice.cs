using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DynamicObstacleManagePolice")]
public enum EDynamicObstacleManagePolice : byte
{
	[DisplayName("与前状态保持一致")]
	SameAsPrevious,
	[DisplayName("保持常开")]
	KeepOpen,
	[DisplayName("保持常关")]
	KeepClose,
	[Tooltip("仅战斗模板下有效，入口门在战斗前开启，接战后关闭，结束战斗后开启")]
	[DisplayName("视作战场入口门")]
	AsBattleInDoor,
	[Tooltip("仅战斗模板下有效，出口门在战斗结束后开启，否则保持关闭")]
	[DisplayName("视作战场出口门")]
	AsBattleOutDoor
}

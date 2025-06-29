using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSForceFightTargetType")]
public enum EGSForceFightTargetType : byte
{
	[DisplayName("清除目标")]
	[Tooltip("清除目标，进行脱战，执行回家逻辑\n注：需要怪物行为树支持回家逻辑")]
	None,
	[DisplayName("停止追踪进入僵持")]
	[Tooltip("保持当前目标，但停止追踪，进入僵持。\n注：僵持怪仍有可能被玩家勾引离开当前区域")]
	KeepCurrentAndStalemate,
	[Tooltip("选择进入区域的第一个非本阵营且不是被触发单位的单位作为目标；若区域内没有可选单位，则不做改变。")]
	[DisplayName("区域内首个敌对单位")]
	CollisionOverlappedUnit,
	[Tooltip("将手动选择的单位作为目标")]
	[DisplayName("手动选择目标单位")]
	SelectedTargetUnit
}

using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SpawnWaveStartConditionType")]
public enum ESpawnWaveStartConditionType : byte
{
	[UMeta(MD.DisplayName, "直接开始")]
	Auto,
	[UMeta(MD.DisplayName, "上一波清完")]
	PreviousClear,
	[UMeta(MD.DisplayName, "基于时间")]
	TimeAfterPrevious,
	[UMeta(MD.DisplayName, "上波清完后再过一段时间")]
	TimeAfterPreviousClear,
	[UMeta(MD.DisplayName, "SpawnWave组全局CD结束")]
	GlobleCDFinished
}

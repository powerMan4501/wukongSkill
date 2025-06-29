using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.MultiTargetConditionType")]
public enum EMultiTargetConditionType : byte
{
	[DisplayName("无筛选")]
	None,
	[DisplayName("是否有Buff")]
	HasBuff,
	[DisplayName("是否有UnitState")]
	HasState,
	[DisplayName("是否有SimpleState")]
	HasSimpleState,
	[DisplayName("HP万分比是否在范围内")]
	HPPercentInRange
}

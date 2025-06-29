using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EBGMVolumeConditionType")]
public enum EBGMVolumeConditionType : byte
{
	[DisplayName("无")]
	None,
	[DisplayName("单位存活")]
	UnitAlive,
	[DisplayName("单位处于混战")]
	UnitInBattle,
	[DisplayName("IntervalTrigger正在激活")]
	IntervalTriggerActive
}

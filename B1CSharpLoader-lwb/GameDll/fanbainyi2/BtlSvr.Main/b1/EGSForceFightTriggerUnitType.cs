using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EGSForceFightTriggerUnitType")]
public enum EGSForceFightTriggerUnitType : byte
{
	[DisplayName("无")]
	[Tooltip("无")]
	Default,
	[Tooltip("触发条件的单位\n1. 触发条件为进入区域，则为进入区域的单位\n2.触发条件为检测单位状态，则为所有被检测单位。")]
	[DisplayName("触发条件的单位")]
	TriggerConditionUnit,
	[DisplayName("将'触发条件单位'作为目标的单位")]
	[Tooltip("把所有将触发条件单位作为目标的单位，作为被触发单位")]
	TriggerConditionUnitEnemy
}

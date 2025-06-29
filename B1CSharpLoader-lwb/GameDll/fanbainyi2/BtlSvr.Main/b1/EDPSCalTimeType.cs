using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EDPSCalTimeType")]
public enum EDPSCalTimeType : byte
{
	[Tooltip("DPS统计自首次命中开始，固定一段时间内的伤害")]
	[DisplayName("固定时长")]
	Total,
	[Tooltip("DPS统计自首次命中开始，每次攻击都会重置延续结束时间")]
	[DisplayName("命中延时")]
	FromLastHit
}

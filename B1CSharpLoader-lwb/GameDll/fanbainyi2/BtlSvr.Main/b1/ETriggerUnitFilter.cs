using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.TriggerUnitFilter")]
public enum ETriggerUnitFilter : byte
{
	[DisplayName("主角悟空")]
	WuKongOnly,
	[DisplayName("悟空阵营")]
	WuKongTeam,
	[DisplayName("指定ResID")]
	SpecifiedResID,
	[DisplayName("全员")]
	All
}

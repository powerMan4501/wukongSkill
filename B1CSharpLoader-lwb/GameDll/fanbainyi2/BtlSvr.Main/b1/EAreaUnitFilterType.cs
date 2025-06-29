using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AreaUnitFilterType")]
public enum EAreaUnitFilterType : byte
{
	[DisplayName("所有单位")]
	All,
	[DisplayName("所有玩家")]
	Player,
	[DisplayName("本地玩家")]
	LocalPlayer,
	[DisplayName("仅悟空")]
	WukongOnly,
	[DisplayName("指定ResID")]
	SpecifiedResID,
	[DisplayName("悟空阵营")]
	WukongTeam
}

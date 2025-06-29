using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGSAutoTestPlayerCastConditionType")]
public enum EGSAutoTestPlayerCastConditionType : byte
{
	[DisplayName("单位属性值")]
	UnitAttr = 0,
	[DisplayName("UnitState")]
	UnitState = 1,
	[DisplayName("持有物品")]
	HasItem = 64,
	[DisplayName("棍势等级")]
	PELevel = 65,
	[DisplayName("不在Preload期间")]
	NotPreloading = 128
}

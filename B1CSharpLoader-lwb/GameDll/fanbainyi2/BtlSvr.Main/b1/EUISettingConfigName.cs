using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EUISettingConfigName")]
public enum EUISettingConfigName : byte
{
	[DisplayName("伤害显示")]
	DmgNumShow,
	[DisplayName("状态信息显示")]
	HudShow
}

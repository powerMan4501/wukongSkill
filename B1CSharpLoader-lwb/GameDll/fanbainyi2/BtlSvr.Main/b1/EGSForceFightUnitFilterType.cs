using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EGSForceFightUnitFilterType")]
public enum EGSForceFightUnitFilterType : byte
{
	[DisplayName("无筛选")]
	[Tooltip("无筛选")]
	None,
	[DisplayName("白名单筛选")]
	[Tooltip("仅被筛选的单位为可触发单位。")]
	WhiteListFilter,
	[Tooltip("被筛选的单位为不可触发单位。")]
	[DisplayName("黑名单筛选")]
	BlackListFilter
}

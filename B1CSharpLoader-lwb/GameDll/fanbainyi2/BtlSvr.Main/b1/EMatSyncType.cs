using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MatSyncType")]
public enum EMatSyncType : byte
{
	[DisplayName("不同步")]
	UnSync,
	[DisplayName("同步MainTex")]
	SyncMainTex,
	[DisplayName("同步品质色")]
	SyncTierState,
	[DisplayName("同步百分比")]
	SyncPercent,
	[DisplayName("同步MainTex及品质色")]
	SyncMainTexAndTier,
	[DisplayName("同步所有参数(Quick)")]
	SyncAllQuick,
	[DisplayName("同步所有参数")]
	SyncAll
}

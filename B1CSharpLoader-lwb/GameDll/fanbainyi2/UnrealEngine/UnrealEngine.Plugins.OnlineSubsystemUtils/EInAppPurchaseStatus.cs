using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.EInAppPurchaseStatus", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum EInAppPurchaseStatus : byte
{
	Invalid,
	Failed,
	Deferred,
	Canceled,
	Purchased,
	Restored
}

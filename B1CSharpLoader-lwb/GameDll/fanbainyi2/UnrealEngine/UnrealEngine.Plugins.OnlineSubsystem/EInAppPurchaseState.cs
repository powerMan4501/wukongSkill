using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystem;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystem.EInAppPurchaseState", "OnlineSubsystem", UnrealModuleType.EnginePlugin)]
public enum EInAppPurchaseState : byte
{
	Unknown,
	Success,
	Failed,
	Cancelled,
	Invalid,
	NotAllowed,
	Restored,
	AlreadyOwned
}

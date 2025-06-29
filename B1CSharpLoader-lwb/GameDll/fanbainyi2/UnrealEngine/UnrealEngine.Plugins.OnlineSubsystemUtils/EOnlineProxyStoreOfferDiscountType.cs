using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/OnlineSubsystemUtils.EOnlineProxyStoreOfferDiscountType", "OnlineSubsystemUtils", UnrealModuleType.EnginePlugin)]
public enum EOnlineProxyStoreOfferDiscountType : byte
{
	NotOnSale,
	Percentage,
	DiscountAmount,
	PayAmount
}

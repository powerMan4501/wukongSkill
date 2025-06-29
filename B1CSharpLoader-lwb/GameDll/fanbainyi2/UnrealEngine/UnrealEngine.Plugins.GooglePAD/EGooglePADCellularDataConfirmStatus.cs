using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GooglePAD;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GooglePAD.EGooglePADCellularDataConfirmStatus", "GooglePAD", UnrealModuleType.EnginePlugin)]
public enum EGooglePADCellularDataConfirmStatus : byte
{
	AssetPack_CONFIRM_UNKNOWN,
	AssetPack_CONFIRM_PENDING,
	AssetPack_CONFIRM_USER_APPROVED,
	AssetPack_CONFIRM_USER_CANCELED
}

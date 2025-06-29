using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GooglePAD;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GooglePAD.EGooglePADStorageMethod", "GooglePAD", UnrealModuleType.EnginePlugin)]
public enum EGooglePADStorageMethod : byte
{
	AssetPack_STORAGE_FILES,
	AssetPack_STORAGE_APK,
	AssetPack_STORAGE_UNKNOWN,
	AssetPack_STORAGE_NOT_INSTALLED
}

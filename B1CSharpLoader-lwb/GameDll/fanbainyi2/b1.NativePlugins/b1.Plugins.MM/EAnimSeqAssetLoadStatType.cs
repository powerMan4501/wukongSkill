using UnrealEngine.Runtime;

namespace b1.Plugins.MM;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/MM.EAnimSeqAssetLoadStatType", "MM", UnrealModuleType.GamePlugin)]
public enum EAnimSeqAssetLoadStatType : byte
{
	INVALID,
	UNLOAD,
	LOADING,
	LOADED
}

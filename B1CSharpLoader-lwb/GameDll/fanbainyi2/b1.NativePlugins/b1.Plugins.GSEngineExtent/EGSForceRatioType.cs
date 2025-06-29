using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.EGSForceRatioType", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public enum EGSForceRatioType : byte
{
	Auto,
	Force16_9,
	Force21_9
}

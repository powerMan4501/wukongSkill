using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.EGSConstraintAspectRatioType", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public enum EGSConstraintAspectRatioType : byte
{
	None,
	UpDown,
	LeftRight
}

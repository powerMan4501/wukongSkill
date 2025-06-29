using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.EIKFootRootLocalAxis", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public enum EIKFootRootLocalAxis : byte
{
	NONE,
	X,
	Y,
	Z
}

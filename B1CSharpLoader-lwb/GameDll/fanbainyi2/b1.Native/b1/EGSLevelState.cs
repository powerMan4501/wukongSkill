using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EGSLevelState", "b1", UnrealModuleType.Game)]
public enum EGSLevelState : byte
{
	Auto,
	LoadedVisible,
	LoadedInvisible,
	Unloaded
}

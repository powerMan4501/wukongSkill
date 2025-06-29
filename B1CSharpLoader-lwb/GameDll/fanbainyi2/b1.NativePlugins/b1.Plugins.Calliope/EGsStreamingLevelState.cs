using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsStreamingLevelState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsStreamingLevelState : byte
{
	LoadedAndShown,
	Unloaded
}

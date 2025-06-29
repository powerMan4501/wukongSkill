using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsOverlapState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsOverlapState : byte
{
	Enabled,
	Disabled
}

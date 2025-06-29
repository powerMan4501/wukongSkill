using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Calliope.EGsDynamicObstacleState", "Calliope", UnrealModuleType.GamePlugin)]
public enum EGsDynamicObstacleState : byte
{
	Opened,
	Closed
}

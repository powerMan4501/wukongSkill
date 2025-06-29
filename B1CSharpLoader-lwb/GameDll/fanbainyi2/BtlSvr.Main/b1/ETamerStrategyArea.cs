using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TamerStrategyArea")]
public enum ETamerStrategyArea : byte
{
	None,
	[DisplayName("悬塑")]
	SuspendedSculptures,
	[DisplayName("地牢")]
	Dungeon
}

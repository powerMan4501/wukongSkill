using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.FlowActorType")]
public enum EFlowActorType : byte
{
	None = 0,
	Overlap = 2,
	DynamicObstacle = 3,
	Spawn = 4,
	Checker = 5
}

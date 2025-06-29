using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ManagedSceneObjType")]
public enum EManagedSceneObjType : byte
{
	None,
	DynamicObstacle,
	Overlap,
	Interactor,
	Unit,
	Spawner
}

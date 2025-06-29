using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CircusMemberType")]
public enum CircusMemberType : byte
{
	Unknown,
	Tamer,
	InteractiveObj,
	SpawnWaves,
	Overlap,
	JJSObstacle
}

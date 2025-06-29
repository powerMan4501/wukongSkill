using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.PointsGenType")]
public enum PointsGenType : byte
{
	ByEQS_Async,
	ByEQS_Sync,
	BySocket,
	BySceneItem,
	ExplodeLineTrace
}

using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.PatrolType")]
public enum EPatrolType : byte
{
	None,
	Random,
	Spline,
	Leisure,
	Follow,
	Group,
	MultiSpline
}

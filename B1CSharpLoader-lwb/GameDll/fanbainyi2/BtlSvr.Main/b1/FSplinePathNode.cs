using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal struct FSplinePathNode
{
	public FVector Pos;

	public float WaitTime;

	public UAnimMontage WaitAM;

	public UAnimMontage JumpAM;

	public bool IsJumpPoint;

	public float JumpForce;
}

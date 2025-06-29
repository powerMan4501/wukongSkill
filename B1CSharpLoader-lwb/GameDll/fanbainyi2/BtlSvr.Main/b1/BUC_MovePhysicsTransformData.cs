using UnrealEngine.Runtime;

namespace b1;

internal class BUC_MovePhysicsTransformData : b1.IBUC_MovePhysicsTransformData
{
	public bool bEnableMovePhysicsTransform { get; set; }

	public float GravityAddValue { get; set; }

	public EMovePhysicsRotationType RotationTypeDurningPhysicsState { get; set; }

	public bool bSimulatingPhysics { get; set; }

	public FVector PhysicsVelocity { get; set; }

	public float CheckPhysicsStateFinishTimer { get; set; }

	public float ComponentHitTimer { get; set; }
}

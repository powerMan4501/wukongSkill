using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_PhysicalMoveData : b1.IBUC_PhysicalMoveData
{
	public bool bConfigEnablePhysicalMove { get; set; }

	public bool bTempDisablePhysicalMove { get; set; }

	public FVector PhysicalMoveVelocity { get; set; }

	public float GravityAddValue { get; set; }

	public List<int> PhysicalMoveBuff { get; set; }

	public float PhysicalMoveBuffNeedSpeed { get; set; }

	public float PhysicalMoveBuffProtectTime { get; set; }

	public bool bUseSocketDirection { get; set; }

	public FName DirectionBaseSocekt { get; set; }

	public FName ForwardSocket { get; set; }

	public float AccuratelyMoveDistance { get; set; }

	public bool bNeedDelayTickPhysicalMove { get; set; }

	public bool bSimulatePhysicsWhenAttacking { get; set; }

	public float DefaultGravityZ { get; set; }

	public uint GravityScaleHandleID { get; set; }

	public uint MovementModeHandleID { get; set; }

	public float PhysicalMoveBuffTimer { get; set; }

	public bool bShouldAddPhysicalMoveBuff { get; set; }

	public bool bPauseByImmobilize { get; set; }

	public FVector LinearVelocityWhenImmobilize { get; set; }

	public FVector AngularVelocityWhenImmobilize { get; set; }
}

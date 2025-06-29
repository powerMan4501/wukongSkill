using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_CliffFallData
{
	public bool EnableCollisionToAirWall;

	public List<EObjectTypeQuery> AirWallObjectType;

	public List<EObjectTypeQuery> DeadZoneObjectType;

	public int NeedDettachCam;

	public bool bCamIsDettach;

	public bool bTransToRagdoll;

	public uint CapsuleCollisionResponseHandleID;

	public uint MeshCollisionResponseHandleID;

	public float PendingDeadCostDmgDelayTimer;

	public AActor PendingDeadAttacker;

	public bool bFlag_DelaySimulate_BindOnLand;

	public bool bFlag_PendingDead;

	public bool ActuallyThroughCliffAirWall;

	public FVector OwnerLastPos;

	public int IgnoreAllInputBuff { get; } = 236;

	public BUC_CliffFallData()
	{
		EnableCollisionToAirWall = true;
		AirWallObjectType = new List<EObjectTypeQuery>();
		AirWallObjectType.Add(EObjectTypeQuery.ObjectTypeQuery15);
		DeadZoneObjectType = new List<EObjectTypeQuery>();
		DeadZoneObjectType.Add(EObjectTypeQuery.ObjectTypeQuery8);
		DeadZoneObjectType.Add(EObjectTypeQuery.ObjectTypeQuery1);
		NeedDettachCam = -1;
		bCamIsDettach = false;
		bTransToRagdoll = false;
		ResetPendingDead();
		bFlag_DelaySimulate_BindOnLand = false;
	}

	public void ResetPendingDead()
	{
		PendingDeadAttacker = null;
		PendingDeadCostDmgDelayTimer = -1f;
		bFlag_PendingDead = false;
		ActuallyThroughCliffAirWall = false;
	}
}

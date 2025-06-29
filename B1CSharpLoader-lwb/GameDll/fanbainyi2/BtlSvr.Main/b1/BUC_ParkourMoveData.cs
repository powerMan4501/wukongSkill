using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ParkourMoveData : IBUC_ParkourMoveData, IPersistentECSData
{
	public bool IsCanParkourMove { get; set; }

	public bool IsPakourMoving { get; set; }

	public float ParkourStartMinHeight { get; set; }

	public float ParkourStartMaxHeight { get; set; }

	public float RunStrideSpeedRate { get; set; }

	public float SprintStrideSpeedRate { get; set; }

	public bool bEnableStrideDown { get; set; }

	public float LastStrideDownTime { get; set; }

	public float CheckParkourStartDistance { get; set; }

	public float ParkourMaxDistance { get; set; }

	public FVector ParkourStartCheckPoint { get; set; }

	public FVector CapsuleBasicLocation { get; set; }

	public List<b1.FParkourLandCheckInfo> ListLandCheckInfo { get; set; }

	public float LandCheckSphereRadius { get; set; }

	public EParkourHeightType ParkourStartHeightType { get; set; }

	public int HighestPointIndex { get; set; }

	public int FirstStandablePointIndex { get; set; }

	public int TargetPointIndex { get; set; }

	public b1.EParkourStartToTargetAngleType ParkourStartToTargetAngleType { get; set; }

	public b1.FParkourActionType ParkourActionType { get; set; }

	public int AfterTargetPointIndex { get; set; }

	public FVector ParkourStartActorLocation { get; set; }

	public b1.FParkourPathDistance ParkourPathDistance { get; set; }

	public EParkourProcessType ParkourProcessType { get; set; }

	public float ParkourForwardMovementRate { get; set; }

	public float ParkourUpMovementRate { get; set; }

	public FVector CurParkourAnimTotalMovement { get; set; }

	public bool bParkourAnimMovementInited { get; set; }

	public float ParkourMoveAdjuestDistance { get; set; }

	public FVector ParkourCurveMoveValue { get; set; }

	public FVector ParkourMoveCurLocation { get; set; }

	public FVector ParkourMoveTargetLocation { get; set; }

	public FVector ParkourDeltaMove { get; set; }

	public FVector ParkourCheckInput { get; set; }

	public bool bContinue { get; set; }

	public EParkourMoveAnimState CurParkourMoveAnimState { get; set; }

	public bool bNeedStopParkour { get; set; }

	public float CapsuleHalfHeight { get; set; }

	public float CapsuleRadius { get; set; }

	public EParkourHeightType GetCurParkourHeightType()
	{
		return ParkourActionType.TargetPoint;
	}

	public bool ConsumeContinueState()
	{
		bool result = bContinue;
		bContinue = false;
		return result;
	}
}

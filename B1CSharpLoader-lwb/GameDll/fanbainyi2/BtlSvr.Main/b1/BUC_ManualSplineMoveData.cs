using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ManualSplineMoveData : IBUC_ManualSplineMoveData
{
	private TWeakObject<USplineComponent> mSplineComp;

	private TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig> mMoveAnimConfig = new TStrongObjectPtr<BGWDataAsset_ManualSplineMoveAnimConfig>();

	public bool bManualSplineMoving { get; set; }

	public float MaxInputAngle { get; set; }

	public float MaxInputAngleCosValue { get; set; }

	public float CameraTraceVelocitySpeedRate { get; set; }

	public float CameraPauseTime { get; set; }

	public bool bBeginWithSplineDirection { get; set; }

	public bool bMoveForward { get; set; }

	public float SplineMoveMaxSpeed { get; set; }

	public float SplineMoveMaxAcceleration { get; set; }

	public float LockDirectionDeltaAngle { get; set; }

	public EManualSplineMoveDirectionType DirectionType { get; set; }

	public EManualSplineMoveTriggerType TriggerType { get; set; }

	public EManualSplineMoveType CurrentManualSplineMoveType { get; set; }

	public EManualSplineMoveStage CurrentManualSplineMoveStage { get; set; }

	public int OverlapCount { get; set; }

	public USplineComponent SplineComp
	{
		get
		{
			return mSplineComp.Get();
		}
		set
		{
			mSplineComp.Set(value);
		}
	}

	public float CurSplineInputKey { get; set; }

	public FVector CurSplineMoveForwardDir { get; set; }

	public BGWDataAsset_ManualSplineMoveAnimConfig MoveAnimConfig
	{
		get
		{
			return mMoveAnimConfig.Get();
		}
		set
		{
			mMoveAnimConfig.Set(value);
		}
	}

	public uint CollisionResponseHandleID { get; set; }

	public float RotationBlendTimer { get; set; }

	public bool IsOverlapedVolume()
	{
		return OverlapCount > 0;
	}

	public bool IsManuaslSplineMovingWithSpecialAnimation()
	{
		if (bManualSplineMoving)
		{
			return CurrentManualSplineMoveType == EManualSplineMoveType.MoveWithSpecialAnimation;
		}
		return false;
	}

	public EManualSplineMoveCameraType GetCameraType()
	{
		if (!(MoveAnimConfig != null))
		{
			return EManualSplineMoveCameraType.None;
		}
		return MoveAnimConfig.CameraType;
	}
}

using UnrealEngine.Engine;

namespace b1;

public class BUC_FXAnimalCommData
{
	public EFXAnimalSpeedType SpeedType;

	public float MoveSpeed_ByConfig;

	public EFXAnimalMoveType MoveType;

	public float Time_LifeTime;

	public float Time_EscapeToDisappear;

	public float Time_DisappearToDestory;

	public EFXAnimalPhase Phase;

	public float Age_Normal;

	public float Age_Escape;

	public float Age_Disappear;

	public float CurSpeed;

	public float SplineMove_Distance;

	public USplineComponent SplineComp;

	public bool bMoveOver;

	public float DistToPlayerCheck_Interval = 1f;

	public float DistToPlayerCheck_RemainTime;

	public bool bCollisionEnable;

	public BUC_FXAnimalCommData()
	{
		Phase = EFXAnimalPhase.Normal;
		SplineComp = null;
		bMoveOver = false;
	}
}

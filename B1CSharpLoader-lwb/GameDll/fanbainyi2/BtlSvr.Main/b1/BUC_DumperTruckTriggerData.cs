using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DumperTruckTriggerData : IBUC_DumperTruckTriggerData, IPersistentECSData
{
	public bool PreviousSpeedBiggerBuff;

	public bool PreviousSpeedSmallerDeBuff;

	public string UnitGuid { get; set; }

	public UClass ABPClass { get; set; }

	public List<USplineComponent> SplineList { get; set; } = new List<USplineComponent>();

	public int TurnSpeed { get; set; }

	public float Acceleration { get; set; }

	public float MaxSpeed { get; set; }

	public float MinSpeed { get; set; }

	public float StartSpeed { get; set; }

	public int MultiSplineDefaultIndex { get; set; }

	public int FirstAccelerationIndex { get; set; }

	public int SecondAccelerationIndex { get; set; }

	public int CurrentIndex { get; set; }

	public bool IsForward { get; set; }

	public int NextIndex { get; set; }

	public bool NeedUpdataSpline { get; set; }

	public float CurrentSpeed { get; set; }

	public float CurrentPlayRate { get; set; }

	public float CurrentAcceleration { get; set; }

	public bool IsRotating { get; set; }

	public bool IsUseCurve { get; set; }

	public FVector RotateTargetPos { get; set; }

	public FVector AIPathMovePos { get; set; }

	public bool IsActive { get; set; }

	public float SpeedRateParam { get; set; }

	public float RotatorWaitTime { get; set; }

	public UCurveFloat SpeedRateParamCurve { get; set; }

	public float UseCurveTime { get; set; }

	public int StartPointIndex { get; set; }

	public bool IsStartForward { get; set; }

	public int ForwardBuffID { get; set; }

	public int BackBuffID { get; set; }

	public ACharacter ControlledUnit { get; set; }

	public UAnimationAsset AnimationAsset { get; set; }

	public float ImmobilizeBuffSpeedThreshold { get; set; }

	public float ImmobilizeDeBuffSpeedThreshold { get; set; }

	public int ImmobilizeBuffID { get; set; }

	public int ImmobilizeDeBuffID { get; set; }

	public float DamageAvailableSpeedThreshold { get; set; }

	public float DamageDisableSpeedThreshold { get; set; }

	public bool CanTickAfterAnim { get; set; }

	public FSweepCheckParamter SweepCheckParamter { get; set; }

	public FAKEventParamter BeginAKEventParamter { get; set; }

	public FAKEventParamter EndAKEventParamter { get; set; }

	public int ObjectID { get; set; }

	public int FromInstanceID { get; set; }
}

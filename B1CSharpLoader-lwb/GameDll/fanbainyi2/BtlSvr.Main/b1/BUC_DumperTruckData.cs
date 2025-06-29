using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_DumperTruckData : b1.IBUC_DumperTruckData, ICloneable, IPersistentECSData
{
	public List<USplineComponent> SplineList { get; set; } = new List<USplineComponent>();

	public ATriggerBase BeginTriggerBase { get; set; }

	public ATriggerBase EndTriggerBase { get; set; }

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

	public object Clone()
	{
		return new BUC_DumperTruckData
		{
			SplineList = SplineList,
			BeginTriggerBase = BeginTriggerBase,
			EndTriggerBase = EndTriggerBase,
			TurnSpeed = TurnSpeed,
			Acceleration = Acceleration,
			MaxSpeed = MaxSpeed,
			MinSpeed = MinSpeed,
			MultiSplineDefaultIndex = MultiSplineDefaultIndex
		};
	}
}

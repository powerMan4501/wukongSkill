using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class SplineMoveConfig
{
	public ESplineFlyUnitType UnitType;

	public string UnitGuid;

	public TSoftObject<AActor> SplineActor;

	public UCurveFloat FlySpeedCurve;

	public float JogSpeed;

	public float RunSpeed;

	public float SprintSpeed;

	public float FlyTime;

	public float DelayTime;

	public SplineMoveConfig(FSplineFlyMoveConfig Config)
	{
		UnitType = Config.UnitType;
		UnitGuid = BGU_DataUtil.GetActorGuid(Config.Unit.Value);
		SplineActor = Config.SplineActor;
		FlySpeedCurve = Config.FlySpeed;
		JogSpeed = Config.JogSpeed;
		RunSpeed = Config.RunSpeed;
		SprintSpeed = Config.SprintSpeed;
		DelayTime = Config.DelayTime;
		FlyTime = 0f;
	}
}

using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPWheelMoveData : b1.IBUC_ABPWheelMoveData
{
	private float LastFrameTargetDistance;

	private UCurveVector MoveNearParamCurve;

	private UCurveVector MoveFarParamCurve;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SpeedCtrlData SpeedCtrlData;

	public UCurveVector MoveParamCurve { get; set; }

	public float MoveSpeedRate { get; set; }

	public float MovePlayRate { get; set; }

	public float BSRotationAdditiveX { get; set; }

	public bool bMoveNearToTarget { get; set; }

	public uint CustomTimeDilationHandleID { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_SimpleStateData InSimpleStateData, IBUC_SpeedCtrlData InSpeedCtrlData)
	{
		SimpleStateData = InSimpleStateData;
		SpeedCtrlData = InSpeedCtrlData;
		MoveParamCurve = null;
		CustomTimeDilationHandleID = 0u;
		MoveNearParamCurve = Setting.WheelMoveSetting.MoveNearParamCurve;
		MoveFarParamCurve = Setting.WheelMoveSetting.MoveFarParamCurve;
	}

	public void Update(AActor Owner, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (MoveNearParamCurve == null)
		{
			MoveParamCurve = null;
			return;
		}
		bMoveNearToTarget = true;
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Owner);
		if (aActor != null)
		{
			float num = FMath.Abs((ChrData.ActorLocation - BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor)).Size());
			bMoveNearToTarget = num < LastFrameTargetDistance;
			LastFrameTargetDistance = num;
		}
		MoveParamCurve = (bMoveNearToTarget ? MoveNearParamCurve : MoveFarParamCurve);
		float mappedSpeed = BasicData.GetMappedSpeed();
		MovePlayRate = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, 3.0), new FVector2D(0.0, 2.0), mappedSpeed);
		float target;
		float interpSpeed;
		if (ChrData.RealAcceleration.Size2D() > 0.1f)
		{
			FVector realAcceleration = ChrData.RealAcceleration;
			realAcceleration.Normalize();
			target = MathLib.InverseTransformDirection(BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner), realAcceleration).Y;
			interpSpeed = mappedSpeed;
		}
		else
		{
			target = 0f;
			interpSpeed = 1f;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter != null)
		{
			if (ChrData.IsMontage)
			{
				target = 0f;
				interpSpeed = 3f;
			}
			USceneComponent rootComponent = aCharacter.GetRootComponent();
			if (rootComponent != null && rootComponent.IsAnySimulatingPhysics())
			{
				target = 0f;
				interpSpeed = 1f;
			}
		}
		BSRotationAdditiveX = FMath.FInterpTo(BSRotationAdditiveX, target, DeltaTime, interpSpeed);
		UpdateMoveSlowly();
	}

	private void UpdateMoveSlowly()
	{
		if (SimpleStateData != null && SpeedCtrlData != null)
		{
			float num = (SimpleStateData.HasSimpleState(EBGUSimpleState.MoveSlowly) ? SpeedCtrlData.GetMoveSpeedSlow() : SpeedCtrlData.GetMoveSpeedFast());
			MoveSpeedRate = num / SpeedCtrlData.GetMoveSpeedFast();
			if (MoveSpeedRate < 1f && MoveSpeedRate > 0f)
			{
				MovePlayRate = 1f / MoveSpeedRate;
			}
		}
	}
}

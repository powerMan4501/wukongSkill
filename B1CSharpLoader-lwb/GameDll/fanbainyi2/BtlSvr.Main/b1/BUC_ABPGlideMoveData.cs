using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPGlideMoveData : b1.IBUC_ABPGlideMoveData
{
	private IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	private IBUC_GlideMoveData GlideMoveData;

	public UCurveVector MoveParamCurve { get; set; }

	public EGlideMoveAnimState GlideMoveAnimState { get; set; }

	public EGlideSlopeType GlideSlopeType { get; set; }

	public float GlideDirCosValue { get; set; }

	public bool bGlideRotationLeft { get; set; }

	public bool bGlideRotationRight { get; set; }

	public float GlideStartSpeedBlendAlpha { get; set; }

	public float GlideLoopSpeedBlendAlpha { get; set; }

	public float GlideDirAdditiveX { get; set; }

	public float GlideDirAdditiveY { get; set; }

	public float GlideLoopInputAdditiveX { get; set; }

	public float GlideLoopInputAdditiveY { get; set; }

	public bool bGlideEndSlow { get; set; }

	public float EnterGlideTimer { get; set; }

	public float EnterGlideGroundFriction { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_ActorBasicData ActorBasicData, IBUC_EnvironmentInteractionMgrData InSurfaceCheckData, IBUC_GlideMoveData InGlideMoveData)
	{
		SurfaceCheckData = InSurfaceCheckData;
		GlideMoveData = InGlideMoveData;
		EnterGlideTimer = 0f;
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			MoveParamCurve = Setting.GlideMoveSetting.MoveParamCurve;
		}
	}

	public void Update(AActor Owner, IBUC_ActorBasicData ActorBasicData, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			UpdateGlideMoving(Owner, SpecialMoveData, BasicData, ChrData, DeltaTime);
			UpdateGlideMoveEnd(Owner, SpecialMoveData, BasicData);
		}
	}

	public void OnEnterGlideMove(IBUC_ABPCharacterData ChrData)
	{
		EnterGlideTimer = 0f;
		EnterGlideGroundFriction = ChrData.GroundFriction;
	}

	private void UpdateGlideMoving(AActor Owner, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPBasicData BasicData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (SpecialMoveData.SpecialMovementMode != ESpecialMovementMode.GlideMove || MoveParamCurve == null || SurfaceCheckData == null || GlideMoveData == null)
		{
			return;
		}
		EnterGlideTimer += DeltaTime;
		float num = MathLib.DegAcos(FVector.DotProduct(ChrData.RightVector, GlideMoveData.GlideDirectionXYPlane));
		float num2 = MathLib.DegAcos(FVector.DotProduct(SurfaceCheckData.SurfaceNormal_Normalized, FVector.UpVector));
		float mappedRangeValueClamped = FMath.GetMappedRangeValueClamped(new FVector2D(90f + GlideMoveData.GlideDirectionMaxHoriAngle, 90f - GlideMoveData.GlideDirectionMaxHoriAngle), new FVector2D(-1.0, 1.0), num);
		float mappedRangeValueClamped2 = FMath.GetMappedRangeValueClamped(new FVector2D(GlideMoveData.MinSpeedAngle, GlideMoveData.MaxGlideSpeed), new FVector2D(1.0, 0.0), num2);
		GlideDirAdditiveX = FMath.FInterpTo(GlideDirAdditiveX, mappedRangeValueClamped, DeltaTime, 6f);
		GlideDirAdditiveY = FMath.FInterpTo(GlideDirAdditiveY, mappedRangeValueClamped2, DeltaTime, 6f);
		GlideSlopeType = ((!(num2 <= GlideMoveData.GlideSlopeEdgeAngle)) ? EGlideSlopeType.Steep : EGlideSlopeType.Flat);
		GlideDirCosValue = FVector.DotProduct(ChrData.ForwardVector, GlideMoveData.GlideDirectionXYPlane);
		bool flag = (bGlideRotationRight = false);
		bGlideRotationLeft = flag;
		FVector safeNormal2D = ChrData.MoveAcceleration.GetSafeNormal2D();
		if (FVector.DotProduct(safeNormal2D, ChrData.ForwardVector) < 0.5f)
		{
			if (FVector.CrossProduct(safeNormal2D, ChrData.ForwardVector).Z > 0f)
			{
				bGlideRotationLeft = true;
			}
			else
			{
				bGlideRotationRight = true;
			}
		}
		GlideStartSpeedBlendAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(BasicData.RunSpeed, BasicData.SprintSpeed), new FVector2D(0.0, 1.0), BasicData.Speed);
		GlideLoopSpeedBlendAlpha = FMath.GetMappedRangeValueClamped(new FVector2D(GlideMoveData.MinGlideSpeed, GlideMoveData.GlideSlopeEdgeSpeed), new FVector2D(0.0, 1.0), BasicData.Speed);
		UpdateGlideLoopInput(Owner, GlideMoveData, ChrData, DeltaTime);
	}

	private void UpdateGlideMoveEnd(AActor Owner, IBUC_ABPSpecialMoveData SpecialMoveData, IBUC_ABPBasicData BasicData)
	{
		if (SpecialMoveData.LastSpecialMovementMode == ESpecialMovementMode.GlideMove && GlideMoveData != null)
		{
			bGlideEndSlow = BasicData.Speed <= (GlideMoveData.MaxGlideSpeed + GlideMoveData.MinGlideSpeed) / 2f;
		}
	}

	private void UpdateGlideLoopInput(AActor Owner, IBUC_GlideMoveData GlideMoveData, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		FVector fVector = ChrData.MoveAcceleration / ChrData.MaxAcceleration - GlideMoveData.GlideDirection * GlideMoveData.GlideDirectionInputScale;
		FVector a = FVector.CrossProduct(FVector.UpVector, GlideMoveData.GlideDirection);
		bool num = GlideMoveData.GlideDirection.IsZero();
		FVector b = (num ? FVector.ZeroVector : fVector.ProjectOnTo(GlideMoveData.GlideDirection));
		FVector b2 = (num ? FVector.ZeroVector : fVector.ProjectOnTo(a));
		float num2 = ((FVector.DotProduct(GlideMoveData.GlideDirection, b) > 0f) ? b.Size() : (0f - b.Size()));
		float num3 = ((FVector.DotProduct(a, b2) > 0f) ? b2.Size() : (0f - b2.Size()));
		num2 /= GlideMoveData.GlideSpeedInputScale;
		num3 /= GlideMoveData.MoveControlReactionSpeed;
		GlideLoopInputAdditiveX = FMath.FInterpTo(GlideLoopInputAdditiveX, num3, DeltaTime, 4f);
		GlideLoopInputAdditiveY = FMath.FInterpTo(GlideLoopInputAdditiveY, num2, DeltaTime, 4f);
	}
}

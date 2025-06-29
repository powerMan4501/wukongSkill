using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_GlideMoveComp : UActorCompBaseCS
{
	private b1.BUC_GlideMoveData GlideMoveData;

	private IBUC_EnvironmentInteractionMgrData SurfaceCheckData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_SkillInstsData SkillInstsData;

	private IBUC_ABPCharacterData ABPChrData;

	private readonly float GlideDirectionMaxHoriAngle = 30f;

	private readonly float GlideDirectionInputScale = 2f;

	private readonly float GlideSpeedInputScale = 0.1f;

	public override void OnAttach()
	{
		GlideMoveData = RequireWritableData<b1.BUC_GlideMoveData>();
		SurfaceCheckData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		ABPChrData = RequireReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>();
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_SetEnterGlideMoveEnabled += new Del_Void_Bool(OnSetEnterGlideMoveEnabled);
	}

	public override void PreBeginPlay()
	{
		InitGlideMoveData();
	}

	public override void OnBeginPlay()
	{
		DoCheckGlideMoveState();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DoCheckGlideMoveState();
		UpdateGlideDirection();
	}

	private void DoCheckGlideMoveState()
	{
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !SimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			if (!UnitStateData.HasState(EBGUUnitState.GlideMoving) && IsGlideSurfaceType(SurfaceCheckData.ResultSurfaceType))
			{
				CheckEnterGlideMove();
			}
			if (UnitStateData.HasState(EBGUUnitState.GlideMoving) && !IsGlideSurfaceType(SurfaceCheckData.ResultSurfaceType))
			{
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EndGlideMove, 0f);
			}
		}
	}

	private void CheckEnterGlideMove()
	{
		if (GlideMoveData.bDisableEnterGlideMove)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		bool flag = false;
		if (aCharacter.Mesh != null)
		{
			UAnimInstance animInstance = aCharacter.Mesh.GetAnimInstance();
			if (animInstance != null)
			{
				flag = animInstance.IsAnyMontagePlaying();
			}
		}
		if (!ABPChrData.IsLandingMove && (!flag || UnitStateData.HasState(EBGUUnitState.AttackMoving)))
		{
			FVector surfaceNormal_Normalized = SurfaceCheckData.SurfaceNormal_Normalized;
			surfaceNormal_Normalized.Z = 0f;
			surfaceNormal_Normalized.Normalize();
			FVector actorForwardVector = aCharacter.GetActorForwardVector();
			actorForwardVector.Z = 0f;
			actorForwardVector.Normalize();
			FVector velocity = aCharacter.GetVelocity();
			velocity.Z = 0f;
			velocity.Normalize();
			if (velocity.Size() > 0f && FVector.DotProduct(surfaceNormal_Normalized, velocity) <= 0f && FVector.DotProduct(surfaceNormal_Normalized, actorForwardVector) <= 0f)
			{
				if (UnitStateData.HasState(EBGUUnitState.AttackMoving))
				{
					base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
					base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("阻断滑行");
				}
				base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(GlideMoveData.PreventGlideSkillID, ECastSkillSourceType.GlideMove));
				if (SkillInstsData.GetLastSkillCastResult() == ECastSkillResult.CSR_OK)
				{
					return;
				}
			}
		}
		if (flag)
		{
			aCharacter.StopAnimMontage(null);
		}
		base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
		base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("进入滑行");
		base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterGlideMove, 0f);
		base.BUSEventCollection.Evt_NotifyEnterGlideMove.Invoke();
	}

	private bool IsGlideSurfaceType(ESceneItemSurfaceType SurfaceType)
	{
		if (SurfaceType == ESceneItemSurfaceType.GlideSandSurface || SurfaceType - 16 <= ESceneItemSurfaceType.GrassSurface)
		{
			return true;
		}
		return false;
	}

	private void InitGlideMoveData()
	{
		GlideMoveData.GlideDirectionMaxHoriAngle = GlideDirectionMaxHoriAngle;
		GlideMoveData.GlideDirectionInputScale = GlideDirectionInputScale;
		GlideMoveData.GlideSpeedInputScale = GlideSpeedInputScale;
		GlideMoveData.GlideSlopeEdgeSpeed = FMath.GetMappedRangeValueClamped(new FVector2D(GlideMoveData.MinSpeedAngle, GlideMoveData.MaxSpeedAngle), new FVector2D(GlideMoveData.MinGlideSpeed, GlideMoveData.MaxGlideSpeed), GlideMoveData.GlideSlopeEdgeAngle);
	}

	private void UpdateGlideDirection()
	{
		if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			FVector surfaceNormal_Normalized = SurfaceCheckData.SurfaceNormal_Normalized;
			surfaceNormal_Normalized.Z = 0f;
			surfaceNormal_Normalized.Normalize();
			FVector glideDirection = FVector.VectorPlaneProject(surfaceNormal_Normalized, SurfaceCheckData.SurfaceNormal_Normalized);
			glideDirection.Normalize();
			GlideMoveData.GlideDirectionXYPlane = surfaceNormal_Normalized;
			GlideMoveData.GlideDirection = glideDirection;
			float num = MathLib.DegAcos(FVector.DotProduct(SurfaceCheckData.SurfaceNormal_Normalized, FVector.UpVector));
			GlideMoveData.GlideDirectionInputScale = FMath.GetMappedRangeValueClamped(new FVector2D(0.0, GlideMoveData.MaxSpeedAngle), new FVector2D(1.0, GlideDirectionInputScale), num);
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (UnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			base.BUSEventCollection.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
		}
	}

	private void OnSetEnterGlideMoveEnabled(bool bEnable)
	{
		GlideMoveData.bDisableEnterGlideMove = !bEnable;
	}
}

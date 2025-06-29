using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_SplineFlyMoveComp : UActorCompBaseCS
{
	private b1.BUC_SplineFlyMoveData SplineFlyMoveData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_MovementData MovementData;

	public override void OnAttach()
	{
		SplineFlyMoveData = RequireWritableData<b1.BUC_SplineFlyMoveData>();
		MovementData = RequireReadOnlyData<IBUC_MovementData, BUC_MovementData>();
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_SetCurFlySpeedRate += new Del_Void_Float(OnFlySpeedRate);
	}

	public override void OnBeginPlay()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!MovementData.IsMoveModeActive(EBGUMoveMode.SplineFlyControl))
		{
			if (SplineFlyMoveData.bSplineFlyMoving)
			{
				OnExitSplineFlyMove();
			}
			return;
		}
		if (!SplineFlyMoveData.bSplineFlyMoving)
		{
			OnEnterSplineFlyMove();
		}
		UpdateFlyMoveSpeedRate();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		BGUFuncLibForMove.BGUSplineFlyMove(bEnableSplineFlyMove: false, GetOwner(), null, default(FGSSplineFlyMoveInfo));
	}

	public void OnFlySpeedRate(float Speed)
	{
		SplineFlyMoveData.CurFlySpeedRate = Speed;
	}

	private void UpdateFlyMoveSpeedRate()
	{
		FVector safeNormal = GetOwner().GetVelocity().GetSafeNormal();
		if (safeNormal == FVector.ZeroVector)
		{
			SplineFlyMoveData.CurFlySpeedRate = 1f;
			return;
		}
		float num = FMath.Clamp(MathLib.DegAcos(FVector.DotProduct(safeNormal, FVector.UpVector)) - 90f, 0f, 45f);
		SplineFlyMoveData.CurFlySpeedRate += (SplineFlyMoveData.FlyDownwardSpeedRate - 1f) / 45f * num;
	}

	private void OnEnterSplineFlyMove()
	{
		SplineFlyMoveData.bSplineFlyMoving = true;
		_ = GetOwner() as ACharacter == null;
	}

	private void OnExitSplineFlyMove()
	{
		SplineFlyMoveData.bSplineFlyMoving = false;
		if (!UnitStateData.HasState(EBGUUnitState.Dead))
		{
			base.BUSEventCollection.Evt_RemoveCheckPoint.Invoke();
		}
	}

	[UFunction]
	private void OnSplineFlyMoveActorHit(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, FHitResult Hit)
	{
		if (!(OtherActor as ACharacter != null))
		{
			base.BUSEventCollection.Evt_UnitDead.Invoke(null, EDeadReason.SkillDamage);
			BGUFuncLibForMove.BGUSplineFlyMove(bEnableSplineFlyMove: false, GetOwner(), null, default(FGSSplineFlyMoveInfo));
		}
	}
}

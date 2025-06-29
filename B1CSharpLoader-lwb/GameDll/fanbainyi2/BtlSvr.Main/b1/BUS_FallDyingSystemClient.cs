using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FallDyingSystemClient : UActorCompBaseCS
{
	private delegate void Del_Void();

	private BUC_FallDyingData FallDyingData;

	private IBUC_SimpleStateData SimpleStateData;

	private Del_Void DoCheckCamera;

	private IBGC_OnlineChallengeData OnlineChallengeData;

	public override void OnAttach()
	{
		base.OnAttach();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		FallDyingData = RequireWritableData<BUC_FallDyingData>();
		OnlineChallengeData = RequireReadOnlyGameStateData<IBGC_OnlineChallengeData, BGC_OnlineChallengeData>();
		FallDyingData.OnUnitFallDyingStateChg += OnUnitFallDyingStateChg;
		base.BUSEventCollection.Evt_TriggerFallDying += new Del_Void_Actor(OnTriggerFallDying);
		base.BUSEventCollection.Evt_FinishRescue += new Del_Actor(FinishRescue);
	}

	private void OnUnitFallDyingStateChg(EFallDyingState OldValue, EFallDyingState NewValue)
	{
		switch (NewValue)
		{
		case EFallDyingState.Alive:
			base.BUSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.Dead);
			break;
		case EFallDyingState.FallDyingBegin:
			base.BUSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(IsEnableCollisionHitMove: false, ECollisionHitMoveEnableReqType.Dead);
			break;
		case EFallDyingState.FallDyingWaiting:
		case EFallDyingState.FallDyingWaitSelfSave:
		case EFallDyingState.FallDyingSelfSaving:
		case EFallDyingState.RealDead:
			break;
		}
	}

	private void OnTriggerFallDying(AActor Attacker)
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		BGS_GSEventCollection.Get(Owner).Evt_BGS_OnlineOnePlayerDead.Invoke(aBGUCharacter?.GetController() as APlayerController);
		if (!OnlineChallengeData.PlayerInChallenge(aBGUCharacter?.GetController() as APlayerController, out var _))
		{
			base.BUSEventCollection.Evt_TriggerFallDyingToUI.Invoke();
		}
		DoCheckCamera = delegate
		{
			if (SimpleStateData != null && SimpleStateData.HasSimpleState(EBGUSimpleState.DeadUseFixCamera))
			{
				APlayerController aPlayerController = OwnerAsCharacterCS.GetController() as APlayerController;
				if (!aPlayerController.IsNullOrDestroyed() && !Attacker.IsNullOrDestroyed())
				{
					aPlayerController.SetViewTargetWithBlend(Attacker, 1f, EViewTargetBlendFunction.VTBlend_EaseOut, 7.3f);
				}
			}
		};
	}

	private void FinishRescue(AActor Saver)
	{
		ABGUCharacter aBGUCharacter = Owner as ABGUCharacter;
		if (!(aBGUCharacter == null))
		{
			base.BUSEventCollection.Evt_TriggerFinishBeSaving.Invoke(aBGUCharacter, Saver);
			FallDyingData.UnitFallDyingState = EFallDyingState.Alive;
			APlayerController aPlayerController = OwnerAsCharacterCS.GetController() as APlayerController;
			if (!aPlayerController.IsNullOrDestroyed())
			{
				aPlayerController.SetViewTargetWithBlend(OwnerAsCharacterCS, 1f, EViewTargetBlendFunction.VTBlend_EaseOut, 7.3f);
			}
		}
	}

	private void OnEnterFallDyingBegin()
	{
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FallDyingData.UnitFallDyingState != EFallDyingState.Alive && DoCheckCamera != null)
		{
			DoCheckCamera();
			DoCheckCamera = null;
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		FallDyingData.OnUnitFallDyingStateChg -= OnUnitFallDyingStateChg;
	}
}

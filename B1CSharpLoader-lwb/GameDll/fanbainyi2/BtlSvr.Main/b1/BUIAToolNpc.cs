using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAToolNpc : BUInteractActionTemplate
{
	public BUIAToolNpc()
	{
		ParamIntNum = 0;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		Player = User;
		if (Action.ParamsString.Count > 0)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[0], ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
			}
		}
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(User);
		bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
		BUS_EventCollectionCS.Get(User).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting);
		return true;
	}

	public override void OnEnd(AActor User)
	{
		base.OnEnd(User);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(User);
		bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Remove(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
	}

	private void OnUiInteractBehaviour(int Behaviour, int ActionID)
	{
		if (Player.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("[BUIAToolNpc] OnUiInteractBehaviour Player=Null 可能是BGWEvent不成对");
			return;
		}
		if (2 == Behaviour)
		{
			BUS_EventCollectionCS.Get(Player).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
			return;
		}
		IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(Player);
		BPC_PlayerInteractData PlayerInteractData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerInteractData>((Player as APawn).PlayerState);
		MovieInstance Instance;
		if (gameInstanceReadonlyData == null || PlayerInteractData == null)
		{
			BGW_EventCollection.Get(Player).Evt_Alchemy_Seq_Fin(0);
			if (PlayerInteractData.bUsingInteractiveUnitViewTarget)
			{
				((Player as APawn).GetController() as APlayerController).SetViewTargetWithBlend(ECSExtension.ToActor(PlayerInteractData.CurrentInteractingEntityRef), 0.5f, EViewTargetBlendFunction.VTBlend_Linear, 1f);
			}
		}
		else
		{
			if (Behaviour != 3)
			{
				return;
			}
			int num = 0;
			BUC_InteractData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(ECSExtension.ToActor(PlayerInteractData.CurrentInteractingEntityRef));
			if (readOnlyData != null)
			{
				num = 990000000 + gameInstanceReadonlyData.CurrentLevelID * 10000 + readOnlyData.InteractiveUnitID;
				FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
				{
					AutoPlay = false,
					PlayRate = 1f,
					StartTime = 0f,
					RandomStartTime = false,
					RestoreState = false,
					DisableMovementInput = true,
					DisableLookAtInput = true,
					HidePlayer = false,
					HideHud = true,
					DisableCameraCuts = false,
					PauseAtEnd = false
				};
				FLevelSequenceCameraSettings cameraSettings = new FLevelSequenceCameraSettings
				{
					AspectRatioAxisConstraint = EAspectRatioAxisConstraint.AspectRatio_MaintainXFOV,
					OverrideAspectRatioAxisConstraint = false
				};
				FMovieGraphPlaySettings inPlaySettings = new FMovieGraphPlaySettings
				{
					PlaybackSettings = playbackSettings,
					CameraSettings = cameraSettings,
					bUsePlayerCamera = false
				};
				Instance = MovieInstance.Create(Player, num, inPlaySettings);
				if (Instance != null)
				{
					MovieInstance movieInstance = Instance;
					movieInstance.MovieFinishCallBack = (Action)Delegate.Combine(movieInstance.MovieFinishCallBack, new Action(LocalAction));
					BGS_EventCollectionCS.Get(Player).Evt_PlayMovieInstance.Invoke(num, Instance);
				}
			}
		}
		void LocalAction()
		{
			MovieInstance movieInstance2 = Instance;
			movieInstance2.MovieFinishCallBack = (Action)Delegate.Remove(movieInstance2.MovieFinishCallBack, new Action(LocalAction));
			BGW_EventCollection.Get(Player).Evt_Alchemy_Seq_Fin(0);
			if (PlayerInteractData.bUsingInteractiveUnitViewTarget)
			{
				((Player as APawn).GetController() as APlayerController).SetViewTargetWithBlend(ECSExtension.ToActor(PlayerInteractData.CurrentInteractingEntityRef), 0.5f, EViewTargetBlendFunction.VTBlend_Linear, 1f);
			}
		}
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		base.OnBreakInteractAction(InteractiveActorID, User, InteractiveActor, Action);
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		if (Action.ParamsString.Count > 1)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(Action.ParamsString[1], ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
			}
		}
	}
}

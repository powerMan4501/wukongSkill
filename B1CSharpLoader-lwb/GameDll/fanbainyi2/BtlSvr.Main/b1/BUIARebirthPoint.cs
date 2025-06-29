using System;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIARebirthPoint : BUInteractActionTemplate
{
	private MovieInstance RBPMovieInstance;

	public BUIARebirthPoint()
	{
		ParamIntNum = 1;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		Player = User;
		HideSpecialEfx(InteractiveActor);
		BGURebirthPointBase bGURebirthPointBase = InteractiveActor as BGURebirthPointBase;
		if (bGURebirthPointBase.IsNullOrDestroyed())
		{
			return false;
		}
		IBUC_RebirthPointData RebirthPointData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_RebirthPointData>(bGURebirthPointBase);
		bool IsFirst;
		if (RebirthPointData != null)
		{
			ABGUCharacter aBGUCharacter = User as ABGUCharacter;
			if (aBGUCharacter != null && aBGUCharacter.PlayerState != null)
			{
				BPS_EventCollectionCS.Get(aBGUCharacter.PlayerState)?.Evt_SetOSSRebirthPointData.Invoke(RebirthPointData.RebirthPointConfigID, RebirthPointData.bActiveState);
				BPS_EventCollectionCS.Get(aBGUCharacter.PlayerState)?.Evt_SetCurrentBirthPoint.Invoke(RebirthPointData.RebirthPointConfigID);
			}
			FUStRebirthPointDesc rebirthPointDesc = BGW_GameDB.GetRebirthPointDesc(RebirthPointData.RebirthPointConfigID);
			if (rebirthPointDesc == null)
			{
				return false;
			}
			IsFirst = false;
			if (!RebirthPointData.bActiveState)
			{
				IsFirst = true;
				BUS_EventCollectionCS.Get(User).Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(Action.ParamsInt[0], ECastSkillSourceType.Interact));
				InteractiveActor.GetAllChildActors(out var _);
				if (Action.ParamsString.Count >= 1)
				{
					UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(InteractiveActor).TryGetCachedResourceObj<UAnimMontage>(rebirthPointDesc.ActiveMontage, ELoadResourceType.SyncLoadAndCache);
					if (uAnimMontage != null)
					{
						BGUFuncLibAnim.BGUActorTryPlayMontage(InteractiveActor, uAnimMontage, FName.None, EMontageBindReason.Interact);
					}
				}
			}
			BPS_EventCollectionCS.Get((User as APawn)?.PlayerState)?.Evt_SetCurrentRebirthPoint.Invoke(RebirthPointData.RebirthPointConfigID);
			BUS_EventCollectionCS.Get(bGURebirthPointBase).Evt_InteractRebirthPoint.Invoke(User);
			if (Action.ParamsBool == EGSYesNo.Yes)
			{
				UGameplayStatics.GetAllActorsOfClassWithTag(User, UClass.GetClass<AActor>(), B1GlobalFNames.RebirthPointCameraCon, out var OutActors);
				foreach (AActor item in OutActors)
				{
					item.SetActorTransform(InteractiveActor.GetActorTransform(), bSweep: false, out var _, bTeleport: false);
				}
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
				string text = BGWGameInstanceCS.Get(User).GetWorldForCS().PathName.Split('.').Last();
				TBLevelDesc tBLevelDesc = GameDBRuntime.GetTBLevelDesc();
				int num = 0;
				foreach (LevelDesc item2 in tBLevelDesc.List)
				{
					if (item2.Path == text)
					{
						num = item2.Id;
						break;
					}
				}
				if (num == 0)
				{
					return true;
				}
				int num2 = 0;
				if (!IsFirst)
				{
					num2 = 1;
				}
				int num3 = num * 1000000 + num2;
				RBPMovieInstance = MovieInstance.Create(User, num3, inPlaySettings);
				if (RBPMovieInstance == null)
				{
					return true;
				}
				BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(User);
				bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
				BUS_EventCollectionCS.Get(User).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting);
				MovieInstance rBPMovieInstance = RBPMovieInstance;
				rBPMovieInstance.MovieFinishCallBack = (Action)Delegate.Combine(rBPMovieInstance.MovieFinishCallBack, new Action(LocalAction));
				BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(num3, RBPMovieInstance);
			}
			if (Action.ParamsBool == EGSYesNo.No)
			{
				BGS_EventCollectionCS.Get(User).Evt_BGS_ShowRebirthPointUI.Invoke(RebirthPointData.RebirthPointConfigID);
				BGW_EventCollection bGW_EventCollection2 = BGW_EventCollection.Get(User);
				bGW_EventCollection2.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Combine(bGW_EventCollection2.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
				BUS_EventCollectionCS.Get(User).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting);
			}
		}
		return true;
		void LocalAction()
		{
			if (!IsFirst)
			{
				BGS_EventCollectionCS.Get(User).Evt_BGS_ShowRebirthPointUI.Invoke(RebirthPointData.RebirthPointConfigID);
			}
			MovieInstance rBPMovieInstance2 = RBPMovieInstance;
			rBPMovieInstance2.MovieFinishCallBack = (Action)Delegate.Remove(rBPMovieInstance2.MovieFinishCallBack, new Action(LocalAction));
		}
	}

	public override void OnEnd(AActor User)
	{
		base.OnEnd(User);
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(User);
		bGW_EventCollection.Evt_UI_Interact_Behaviour = (Del_Void_IntInt)Delegate.Remove(bGW_EventCollection.Evt_UI_Interact_Behaviour, new Del_Void_IntInt(OnUiInteractBehaviour));
	}

	public override void OnBreakInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BUS_EventCollectionCS.Get(User).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		if (!RBPMovieInstance.IsNullOrDestroyed())
		{
			RBPMovieInstance.Shutdown();
		}
		BGS_EventCollectionCS.Get(User).Evt_BGS_HideRebirthPointUI.Invoke();
		CheckAndShowSpecialEfx(InteractiveActor);
	}

	private void OnUiInteractBehaviour(int Behaviour, int ActionID)
	{
		if (6 == Behaviour)
		{
			if (!RBPMovieInstance.IsNullOrDestroyed())
			{
				RBPMovieInstance.Shutdown();
			}
		}
		else if (5 == Behaviour)
		{
			if (!RBPMovieInstance.IsNullOrDestroyed())
			{
				RBPMovieInstance.Shutdown();
			}
			BUS_EventCollectionCS.Get(Player).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.Interacting, IsRemove: true);
		}
	}

	public override void OnFinishInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		CheckAndShowSpecialEfx(InteractiveActor);
	}

	private void HideSpecialEfx(AActor InteractiveActor)
	{
		foreach (UActorComponent item in InteractiveActor.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), new FName("HiddenInInteractAction")))
		{
			if (item is UNiagaraComponent uNiagaraComponent)
			{
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
				uNiagaraComponent.Deactivate();
			}
		}
	}

	private void CheckAndShowSpecialEfx(AActor InteractiveActor)
	{
		foreach (UActorComponent item in InteractiveActor.GetComponentsByTag(UClass.GetClass<UNiagaraComponent>(), new FName("HiddenInInteractAction")))
		{
			if (item is UNiagaraComponent uNiagaraComponent)
			{
				uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: false);
				uNiagaraComponent.Activate();
				uNiagaraComponent.SetVisibility(bNewVisibility: true);
			}
		}
	}
}

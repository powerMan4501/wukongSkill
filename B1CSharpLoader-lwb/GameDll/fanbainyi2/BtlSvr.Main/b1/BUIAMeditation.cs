using System;
using System.Linq;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BUIAMeditation : BUInteractActionTemplate
{
	public BUIAMeditation()
	{
		ParamIntNum = 0;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		BGW_GameDB.GetInteractiveUnitCommDesc(BGU_DataUtil.GetReadOnlyData<BUC_InteractData>(InteractiveActor).InteractiveUnitID);
		BGUMeditationPointBase bGUMeditationPointBase = InteractiveActor as BGUMeditationPointBase;
		if (bGUMeditationPointBase.IsNullOrDestroyed())
		{
			return false;
		}
		IBUC_MeditationPointData MeditationPointData = BGU_DataUtil.GetReadOnlyData<BUC_MeditationPointData>(bGUMeditationPointBase);
		bool IsNeedRecoverAttr;
		MovieInstance Instance;
		if (MeditationPointData != null)
		{
			MeditationPointDesc meditationPointDesc = GameDBRuntime.GetMeditationPointDesc(MeditationPointData.MeditationPointConfigID);
			if (meditationPointDesc == null)
			{
				return false;
			}
			PlayAudio(User, bGUMeditationPointBase, meditationPointDesc.AkEventPath);
			IsNeedRecoverAttr = false;
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(User);
			if (!firstLocalPlayerController.IsNullOrDestroyed())
			{
				BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(firstLocalPlayerController);
				if (readOnlyData != null && !readOnlyData.RoleData.RoleCs.Actor.Progress.AwardMeditationList.Contains(MeditationPointData.MeditationPointConfigID))
				{
					IsNeedRecoverAttr = true;
				}
			}
			if (!MeditationPointData.bActiveState)
			{
				BUS_EventCollectionCS.Get(InteractiveActor).Evt_SceneObjTransitByEvent.Invoke(BGW_FlowUtils.MeditationPointTag.Event_Active);
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
			Instance = MovieInstance.Create(User, meditationPointDesc.SequenceId, inPlaySettings);
			MovieInstance movieInstance = Instance;
			movieInstance.MovieFinishCallBack = (Action)Delegate.Combine(movieInstance.MovieFinishCallBack, new Action(LocalAction));
			BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(meditationPointDesc.SequenceId, Instance);
			BGS_EventCollectionCS.Get(User).Evt_BGS_Meditation.Invoke(MeditationPointData.MeditationPointConfigID);
		}
		return true;
		void LocalAction()
		{
			MovieInstance movieInstance2 = Instance;
			movieInstance2.MovieFinishCallBack = (Action)Delegate.Remove(movieInstance2.MovieFinishCallBack, new Action(LocalAction));
			BGS_EventCollectionCS.Get(User).Evt_BGS_ShowMeditationAward.Invoke(MeditationPointData.MeditationPointConfigID);
			if (IsNeedRecoverAttr && !User.IsNullOrDestroyed())
			{
				BGS_EventCollectionCS.Get(User)?.Evt_MeditationRecoverAttrRecord?.Invoke();
			}
		}
	}

	private void PlayAudio(AActor User, AActor AkSpeaker, string AkEventPath)
	{
		bool flag = IsHasLegacyEars(User);
		UBGUFunctionLibAK.SetUnrealGlobalSwitch(B1GlobalFNames.LegacyEarsAudioSwitchGroup, flag ? B1GlobalFNames.LegacyEarsAudioSwitchStateOn : B1GlobalFNames.LegacyEarsAudioSwitchStateOff);
	}

	private bool IsHasLegacyEars(AActor User)
	{
		BGP_PlayerControllerCS bGP_PlayerControllerCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(User) as BGP_PlayerControllerCS;
		if (!bGP_PlayerControllerCS.IsNullOrDestroyed())
		{
			BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(bGP_PlayerControllerCS);
			int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.DashenEarsLegacyId);
			if (commLogicCfgValue > 0)
			{
				return RoleDataHelper.HasItem(readOnlyData, commLogicCfgValue);
			}
		}
		return false;
	}
}

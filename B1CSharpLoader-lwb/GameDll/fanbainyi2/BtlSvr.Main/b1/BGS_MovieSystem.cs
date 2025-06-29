using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AsyncLoadingScreen;
using BtlB1;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

internal class BGS_MovieSystem : GameStateSystemBase
{
	private BGC_MovieData MovieData { get; set; }

	private BIC_MovieData GlobalMovieData { get; set; }

	private BGW_GameArchiveMgr ArchivedMgr { get; set; }

	private IBGC_AnimationSyncData AnimationSyncData { get; set; }

	public override void OnAttach()
	{
		MovieData = RequireWritableData<BGC_MovieData>();
		GlobalMovieData = BGWGameInstanceCS.GetObject<BGW_GameDataMgr>(Owner)?.GetGameInstanceWritableData<BIC_MovieData>();
		ArchivedMgr = BGW_GameArchiveMgr.Get(Owner);
		AnimationSyncData = RequireReadOnlyGameStateData<IBGC_AnimationSyncData, BGC_AnimationSyncData>();
		BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(Owner);
		if (bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			bGWGameInstanceCS.SwitchLoadingScreenThread(UseSlateThread: true);
		}
		BGWDataAsset_PerformerConfig bGWDataAsset_PerformerConfig = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<BGWDataAsset_PerformerConfig>("BGWDataAsset_PerformerConfig'/Game/00Main/DataAsset/DA_PerformerConfig.DA_PerformerConfig'", ELoadResourceType.SyncLoadAndCache);
		if (bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			bGWGameInstanceCS.SwitchLoadingScreenThread(UseSlateThread: false);
		}
		if (bGWDataAsset_PerformerConfig != null)
		{
			foreach (KeyValuePair<FName, FPerformerInfo> item in bGWDataAsset_PerformerConfig.PerformerInfoMapping)
			{
				if (item.Key != FName.None && GameplayTagExtension.IsValid(item.Value.PerformerActorFixedGuid))
				{
					MovieData.PerformerIds.Add(item.Key, item.Value.PerformerActorFixedGuid);
				}
			}
		}
		base.BGSEventCollection.Evt_PreviewMovie += new Del_Void_IntAction(OnPreviewMovie);
		base.BGSEventCollection.Evt_PlayMovieInstance += new Del_Void_PlayMovieInstance(OnPlayMovieInstance);
		base.BGSEventCollection.Evt_MovieInstanceFinish += new Del_Void_IntInt(OnMovieInstanceFinished);
		base.BGSEventCollection.Evt_PauseCurrentMovie += new Del_Void(OnPauseAllMovie);
		base.BGSEventCollection.Evt_ResumeCurrentMovie += new Del_Void(OnResumeAllMovie);
		base.BGSEventCollection.Evt_CurrentMovieNotifyEnd += new Del_Void_Int(OnCurrentMovieNotifyEnd);
		base.BGSEventCollection.Evt_MarkCanFinishLoopMovie += new Del_Void(OnMarkAllMovieCanFinishLoop);
		base.BGSEventCollection.Evt_RegisterCameraObj += new Del_Void_ICamera(OnRegisterCameraObj);
		base.BGSEventCollection.Evt_UnregisterCameraObj += new Del_Void_ICamera(OnUnregisterCameraObj);
		base.BGSEventCollection.Evt_SkipCurrentMovie += new Del_Void(OnSkipCurrentCameraMovie);
		base.BGSEventCollection.Evt_TriggerCustomMovieEvent += new Del_Void_IntGameplayTag(OnTriggerCustomMovieEvent);
		base.BGSEventCollection.Evt_MarkMovieCanBeSkipped += new Del_Void_IntBool(MarkMovieCanBeSkipped);
		base.BGSEventCollection.Evt_ConvertToNoCameraMovie += new Del_Void_ConvertToNoCameraMovie(ConvertToNoCameraMovie);
		base.BGSEventCollection.Evt_GiveBackControlRightForMonster += new Del_Void_GiveBackControlRightForMonster(GiveBackControlRightForMonster);
		base.BGSEventCollection.Evt_TerminateAllMovies += new Del_Void(TerminateAllMovies);
		base.BGSEventCollection.Evt_BeginDefeatSlowTime += new Del_BeginDefeatSlowTime(OnBeginDefeatSlowTime);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Combine(bGWEventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
		base.BGSEventCollection.Evt_BGS_EnterSeqMove += new Del_Void(OnEnterSeqMove);
		base.BGSEventCollection.Evt_BGS_LeftSeqMove += new Del_Void(OnLeftSeqMove);
		base.BGSEventCollection.Evt_QueryIsPlayingCameraMovie += new Del_Bool_Void(IsPlayingCameraMovie);
		base.BGSEventCollection.Evt_QueryPlayingSequenceID += new Del_Int_Void(GetPlayingSequenceID);
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_CallTickForMovieSystem = (Del_Void_Float)Delegate.Combine(bGWEventCollection2.Evt_CallTickForMovieSystem, new Del_Void_Float(TickForMovieSystem));
	}

	private void OnEnterSeqMove()
	{
		foreach (KeyValuePair<int, TStrongObjectPtr<MovieInstance>> movieInstance2 in MovieData.MovieInstances)
		{
			MovieInstance movieInstance = movieInstance2.Value.Get();
			if (movieInstance != null)
			{
				movieInstance.OnEnterSeqMove();
			}
		}
	}

	private void OnLeftSeqMove()
	{
		foreach (KeyValuePair<int, TStrongObjectPtr<MovieInstance>> movieInstance2 in MovieData.MovieInstances)
		{
			MovieInstance movieInstance = movieInstance2.Value.Get();
			if (movieInstance != null)
			{
				movieInstance.OnLeaveSeqMove();
			}
		}
	}

	public override void OnBeginPlay()
	{
		ACameraActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<ACameraActor>(Owner);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			if (allActorsOfClass[i] is ICameraObj inCameraObj)
			{
				OnRegisterCameraObj(inCameraObj);
			}
		}
		ACameraRig_Rail[] allActorsOfClass2 = UGameplayStatics.GetAllActorsOfClass<ACameraRig_Rail>(Owner);
		for (int i = 0; i < allActorsOfClass2.Length; i++)
		{
			if (allActorsOfClass2[i] is ICameraObj inCameraObj2)
			{
				OnRegisterCameraObj(inCameraObj2);
			}
		}
		ACameraRig_Crane[] allActorsOfClass3 = UGameplayStatics.GetAllActorsOfClass<ACameraRig_Crane>(Owner);
		for (int i = 0; i < allActorsOfClass3.Length; i++)
		{
			if (allActorsOfClass3[i] is ICameraObj inCameraObj3)
			{
				OnRegisterCameraObj(inCameraObj3);
			}
		}
	}

	private void TerminateAllMovies()
	{
		foreach (TStrongObjectPtr<MovieInstance> item in MovieData.MovieInstances.Values.ToList())
		{
			item.Get()?.Shutdown();
		}
	}

	private void MarkMovieCanBeSkipped(int MovieId, bool bInCanBeSkipped)
	{
		MovieInstance cameraMovieInstance = MovieData.CameraMovieInstance;
		if ((object)cameraMovieInstance != null && cameraMovieInstance.MovieId == MovieId)
		{
			MovieData.CameraMovieInstance.MarkCanBeSkipped(bInCanBeSkipped);
		}
	}

	private void OnTriggerCustomMovieEvent(int MovieId, FGameplayTag EventTag)
	{
		if (MovieData.MovieInstances.TryGetValue(MovieId, out var value))
		{
			value.Get()?.OnTriggerCustomMovieEvent(EventTag);
		}
	}

	private void OnSkipCurrentCameraMovie()
	{
		MovieInstance cameraMovieInstance = MovieData.CameraMovieInstance;
		if (cameraMovieInstance != null && cameraMovieInstance.CanSkipMovie())
		{
			cameraMovieInstance.SkipMovie();
		}
	}

	private bool IsPlayingCameraMovie()
	{
		return MovieData.CameraMovieInstance != null;
	}

	private int GetPlayingSequenceID()
	{
		if (!(MovieData.CameraMovieInstance != null))
		{
			return 0;
		}
		return MovieData.CameraMovieInstance.SequenceId;
	}

	private void OnFinishTransBack()
	{
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.Imperceptible, IsRemove: false);
		BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.CantBeBaseTarget, IsRemove: false);
		MovieData.CameraMovieInstance.StartGraph();
	}

	private void OnPreviewMovie(int SequenceID, Action CallBack)
	{
		if (GSGameplayCVar.CVar_MoviePreviewEnable.GetValueInGameThread() == 0)
		{
			return;
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
			bUsePlayerCamera = false,
			bTriggerMonsterGoHome = false
		};
		MovieInstance movieInstance = MovieInstance.Create(Owner, SequenceID, inPlaySettings);
		if (movieInstance == null)
		{
			return;
		}
		if (MovieData.CameraMovieInstance != null)
		{
			MovieData.CameraMovieInstance.DisableCameraCutWithBlendOut();
		}
		SetCurrentCameraMovieInstance(movieInstance);
		MovieData.MovieInstances.Add(movieInstance.MovieId, new TStrongObjectPtr<MovieInstance>(movieInstance));
		if (MovieData.IsPlaying())
		{
			BGW_EventCollection.Get(Owner).Evt_ActiveSkipMovieUI?.Invoke(P1: true);
		}
		APawn controlledPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner).GetControlledPawn();
		if (controlledPawn != null)
		{
			float transBackDurationTime = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>(controlledPawn).TransBackDurationTime;
			if (transBackDurationTime > 0f)
			{
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_TriggerTransBack.Invoke();
				MovieData.TransBackTimeForPreviewMovie = transBackDurationTime;
				return;
			}
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.Imperceptible, IsRemove: false);
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(controlledPawn, EBGUSimpleState.CantBeBaseTarget, IsRemove: false);
		}
		MovieInstance cameraMovieInstance = MovieData.CameraMovieInstance;
		cameraMovieInstance.MovieFinishCallBack = (Action)Delegate.Combine(cameraMovieInstance.MovieFinishCallBack, CallBack);
		MovieData.CameraMovieInstance.StartGraph();
	}

	private void OnPlayMovieInstance(int SequenceId, MovieInstance Instance)
	{
		if (Instance == null)
		{
			return;
		}
		if (!Instance.bCanRepeatPlay && GlobalMovieData.IsSequencePlayed(SequenceId))
		{
			Instance.BeforePlayFinishCallBack();
			Instance.MovieFinishCallBack();
			return;
		}
		if (!Instance.PlaySettings.PlaybackSettings.DisableCameraCuts)
		{
			if (MovieData.CameraMovieInstance != null)
			{
				MovieData.CameraMovieInstance.DisableCameraCutWithBlendOut();
			}
			SetCurrentCameraMovieInstance(Instance);
		}
		MovieData.MovieInstances.Add(Instance.MovieId, new TStrongObjectPtr<MovieInstance>(Instance));
		BGW_LevelStreamingStateMgr.Get(Owner)?.TickForCalcSeqLevelState();
		if (MovieData.IsPlaying())
		{
			BGW_EventCollection.Get(Owner).Evt_ActiveSkipMovieUI?.Invoke(P1: true);
		}
		if (GlobalMovieData.bPauseAllMovie)
		{
			Instance.bNeedPauseAfterPlaying = true;
		}
		Instance.StartGraph();
	}

	private void OnMarkAllMovieCanFinishLoop()
	{
		foreach (TStrongObjectPtr<MovieInstance> value in MovieData.MovieInstances.Values)
		{
			value.Get()?.OnMarkCanFinishLoopMovie();
		}
	}

	private void OnResumeAllMovie()
	{
		foreach (TStrongObjectPtr<MovieInstance> value in MovieData.MovieInstances.Values)
		{
			value.Get()?.OnResumeCurrentMovie();
		}
	}

	private void OnPauseAllMovie()
	{
		foreach (TStrongObjectPtr<MovieInstance> value in MovieData.MovieInstances.Values)
		{
			value.Get()?.OnPauseCurrentMovie();
		}
	}

	private void OnCurrentMovieNotifyEnd(int MovieId)
	{
	}

	public void TickForMovieSystem(float DeltaTime)
	{
		if (!MovieData.bCanTick)
		{
			return;
		}
		if (AnimationSyncData.IsPlayerInAnimationSyncing(Owner))
		{
			MovieData.bAllSeqCantSkip = true;
		}
		else
		{
			MovieData.bAllSeqCantSkip = false;
		}
		while (GlobalMovieData.PlayMovieRequestQueue.Count > 0)
		{
			RequestPlayMovie(GlobalMovieData.PlayMovieRequestQueue.Dequeue());
		}
		foreach (TStrongObjectPtr<MovieInstance> item in MovieData.MovieInstances.Values.ToList())
		{
			item.Get()?.OnTick(DeltaTime);
		}
		if (MovieData.TransBackTimeForPreviewMovie > 1E-08f)
		{
			MovieData.TransBackTimeForPreviewMovie -= DeltaTime;
			if (MovieData.TransBackTimeForPreviewMovie <= 1E-08f)
			{
				MovieData.TransBackTimeForPreviewMovie = -1f;
				OnFinishTransBack();
			}
		}
		TickForDefeatSlowTime(DeltaTime);
		if (GSGameplayCVar.CVar_AutoSkipMovies.GetValueInGameThread() != 0 && MovieData.IsCanSkip())
		{
			OnSkipCurrentCameraMovie();
		}
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		MovieData.bCanTick = false;
		foreach (TStrongObjectPtr<MovieInstance> item in MovieData.MovieInstances.Values.ToList())
		{
			item.Get()?.Shutdown();
			item.Set(null);
		}
		MovieData.MovieInstances.Clear();
		SetCurrentCameraMovieInstance(null);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_PlayerDelayBeginPlayFinished = (Del_Void)Delegate.Remove(bGWEventCollection.Evt_PlayerDelayBeginPlayFinished, new Del_Void(OnPlayerDelayBeginPlayFinished));
		BGW_EventCollection bGWEventCollection2 = base.BGWEventCollection;
		bGWEventCollection2.Evt_CallTickForMovieSystem = (Del_Void_Float)Delegate.Remove(bGWEventCollection2.Evt_CallTickForMovieSystem, new Del_Void_Float(TickForMovieSystem));
	}

	private void OnRegisterCameraObj(ICameraObj InCameraObj)
	{
		AActor aActor = InCameraObj as AActor;
		if (aActor == null)
		{
			return;
		}
		TWeakObject<AActor> inValue = new TWeakObject<AActor>(aActor);
		List<FName> list = aActor.Tags.ToList();
		if (list.Count <= 0)
		{
			return;
		}
		foreach (FName item in list)
		{
			MovieData.TagCameraMap.Add(item, inValue);
		}
		MovieData.RegisteredCameras.Add(aActor, list);
	}

	private void OnUnregisterCameraObj(ICameraObj InCameraObj)
	{
		AActor aActor = InCameraObj as AActor;
		if (aActor == null || !MovieData.RegisteredCameras.ContainsKey(aActor))
		{
			return;
		}
		TWeakObject<AActor> item = new TWeakObject<AActor>(aActor);
		foreach (FName item2 in MovieData.RegisteredCameras[aActor])
		{
			if (MovieData.TagCameraMap.ContainsKey(item2))
			{
				List<TWeakObject<AActor>> list = MovieData.TagCameraMap[item2];
				if (list.Count == 1)
				{
					MovieData.TagCameraMap.Remove(item2);
				}
				else
				{
					list.Remove(item);
				}
			}
		}
		MovieData.RegisteredCameras.Remove(aActor);
	}

	private void ConvertToNoCameraMovie(MovieInstance Instance)
	{
		if (MovieData.CameraMovieInstance == Instance)
		{
			MovieData.CameraMovieInstance.DisableCameraCutWithBlendOut();
			SetCurrentCameraMovieInstance(null);
		}
	}

	private void GiveBackControlRightForMonster(MovieInstance Instance, string MonsterGuid)
	{
		Instance.GiveBackControlRightForMonster(MonsterGuid);
	}

	private void OnMovieInstanceFinished(int InMovieId, int MovieSequenceID)
	{
		MovieInstance cameraMovieInstance = MovieData.CameraMovieInstance;
		if ((object)cameraMovieInstance != null && cameraMovieInstance.MovieId == InMovieId)
		{
			MovieData.bLastCameraMovieBlendOutCamera = MovieData.CameraMovieInstance.BlendOutBeforeCamera;
			SetCurrentCameraMovieInstance(null);
			BGW_EventCollection.Get(Owner).Evt_ActiveSkipMovieUI?.Invoke(P1: false);
		}
		if (MovieData.MovieInstances.ContainsKey(InMovieId))
		{
			BGW_EventCollection.Get(Owner).Evt_NotifyMovieInstanceFinished(MovieSequenceID);
			BGW_EventCollection.Get(Owner).Evt_MarkMoviePlayed(MovieSequenceID);
			MovieData.MovieInstances.Remove(InMovieId);
		}
	}

	public ULevelSequencePlayer BetaGetWorkingSequencePlayer()
	{
		if (MovieData.CameraMovieInstance == null)
		{
			return null;
		}
		return MovieData.CameraMovieInstance.BetaGetSequencePlayer();
	}

	private void SetCurrentCameraMovieInstance(MovieInstance InCameraMovieInstance)
	{
		if (!(MovieData.CameraMovieInstance == InCameraMovieInstance))
		{
			MovieData.CameraMovieInstance = InCameraMovieInstance;
		}
	}

	private void OnPlayerDelayBeginPlayFinished()
	{
		MovieData.bCanTick = true;
	}

	private void RequestPlayMovie(FPlayMovieRequest Request)
	{
		if (GSGameplayCVar.CVar_SkipAllPlaySequenceNode.GetValueInGameThread() == 1)
		{
			Request.BeforePlayFinishCallback?.Invoke();
			Request.MovieFinishCallback?.Invoke();
			return;
		}
		FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
		{
			AutoPlay = false,
			PlayRate = 1f,
			StartTime = 0f,
			RandomStartTime = false,
			RestoreState = false,
			DisableMovementInput = true,
			DisableLookAtInput = Request.bDisableLookAtInput,
			HidePlayer = Request.bHidePlayer,
			HideHud = Request.bHideHud,
			DisableCameraCuts = !Request.bDisablePlayerControl,
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
			bUsePlayerCamera = !Request.bDisablePlayerControl,
			bTriggerMonsterGoHome = false
		};
		MovieInstance movieInstance = MovieInstance.Create(Owner, Request.SequenceID, inPlaySettings);
		if (movieInstance == null)
		{
			Request.BeforePlayFinishCallback?.Invoke();
			Request.MovieFinishCallback?.Invoke();
			return;
		}
		AActor actorByGuid = BGU_DataUtil.GetActorByGuid(Owner, Request.OverlapBoxGuid);
		if (actorByGuid != null)
		{
			movieInstance.OverlapGuid = Request.OverlapBoxGuid;
			List<UActorComponent> componentsByTag = actorByGuid.GetComponentsByTag(UClass.GetClass(typeof(USceneComponent)), B1GlobalFNames.MatchPointA);
			if (componentsByTag.Count > 0)
			{
				movieInstance.PointAPos = ((USceneComponent)componentsByTag[0]).GetWorldTransform();
			}
			componentsByTag = actorByGuid.GetComponentsByTag(UClass.GetClass(typeof(USceneComponent)), B1GlobalFNames.MatchPointB);
			if (componentsByTag.Count > 0)
			{
				movieInstance.PointBPos = ((USceneComponent)componentsByTag[0]).GetWorldTransform();
			}
			movieInstance.MatchingPosType = Request.MatchType;
		}
		else
		{
			movieInstance.OverlapGuid = "";
		}
		if (Request.BeforePlayFinishCallback != null)
		{
			movieInstance.BeforePlayFinishCallBack = (Action)Delegate.Combine(movieInstance.BeforePlayFinishCallBack, Request.BeforePlayFinishCallback);
		}
		if (Request.MovieFinishCallback != null)
		{
			movieInstance.MovieFinishCallBack = (Action)Delegate.Combine(movieInstance.MovieFinishCallBack, Request.MovieFinishCallback);
		}
		OnPlayMovieInstance(Request.SequenceID, movieInstance);
	}

	private void OnBeginDefeatSlowTime(int InBattleExtendID, EDefeatUITriggerType DefeatUITriggerType)
	{
		if (!DebugConfig.CricketBattleMode)
		{
			BeginDefeatSlowTimeInternal(InBattleExtendID, DefeatUITriggerType);
			EndDefeatSlowTime();
		}
	}

	private bool BeginDefeatSlowTimeInternal(int InBattleExtendID, EDefeatUITriggerType DefeatUITriggerType)
	{
		if (InBattleExtendID <= 0)
		{
			return false;
		}
		if (MovieData.DefeatSlowTotalTime > 0f)
		{
			return false;
		}
		FUStDefeatSlowTimeConfigDesc slowTimeConfigDescByExtendID = BGW_GameDB.GetSlowTimeConfigDescByExtendID(InBattleExtendID);
		if (slowTimeConfigDescByExtendID != null)
		{
			MovieData.TimeDilationCurve = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UCurveFloat>(slowTimeConfigDescByExtendID.TimeDilationCurve, ELoadResourceType.SyncLoadAndCache);
			MovieData.CurrentDefeatExtendID = InBattleExtendID;
			MovieData.DefeatSlowTotalTime = slowTimeConfigDescByExtendID.TotalTime;
			MovieData.CurrentDefeatSlowTime = 0f;
			BPS_EventCollectionCS.GetLocal(Owner).Evt_DefeatedStateChange.Invoke(InBattleExtendID, DefeatUITriggerType);
			return true;
		}
		return false;
	}

	private void TickForDefeatSlowTime(float InDeltaTime)
	{
		if (!(MovieData.DefeatSlowTotalTime <= 1E-08f))
		{
			float globalTimeDilation = UGameplayStatics.GetGlobalTimeDilation(Owner);
			MovieData.CurrentDefeatSlowTime += ((globalTimeDilation > 0f) ? (InDeltaTime / globalTimeDilation) : InDeltaTime);
			if (MovieData.TimeDilationCurve != null)
			{
				globalTimeDilation = MovieData.TimeDilationCurve.GetFloatValue(MovieData.CurrentDefeatSlowTime);
				UGameplayStatics.SetGlobalTimeDilation(Owner, globalTimeDilation);
			}
			if (MovieData.CurrentDefeatSlowTime >= MovieData.DefeatSlowTotalTime)
			{
				UGameplayStatics.SetGlobalTimeDilation(Owner, 1f);
				EndDefeatSlowTime();
			}
		}
	}

	private void EndDefeatSlowTime()
	{
		if (!(MovieData.CurrentDefeatSlowTime <= 0f))
		{
			int currentDefeatExtendID = MovieData.CurrentDefeatExtendID;
			MovieData.DefeatSlowTotalTime = -1f;
			MovieData.CurrentDefeatSlowTime = -1f;
			MovieData.CurrentDefeatExtendID = 0;
			MovieData.TimeDilationCurve = null;
			base.BGSEventCollection.Evt_EndDefeatSlowTime.Invoke(currentDefeatExtendID);
		}
	}
}

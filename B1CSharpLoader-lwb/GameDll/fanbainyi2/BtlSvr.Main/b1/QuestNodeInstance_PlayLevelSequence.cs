using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

public class QuestNodeInstance_PlayLevelSequence : QuestNodeInstance
{
	private QuestCustom_PlayLevelSequence CustomData { get; set; }

	private TWeakObject<MovieInstance> MovieInstancePtr { get; set; }

	private float WaitTransbackTime { get; set; }

	protected override void PostCreate()
	{
		CustomData = new QuestCustom_PlayLevelSequence();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (InputPin == "Start")
		{
			TriggerOutput("PreStart", bFinish: false);
			OnPrePlaySequence();
		}
		else if (InputPin == "Stop")
		{
			BGS_EventCollectionCS.Get(base.Owner)?.Evt_SkipCurrentMovie.Invoke();
			TriggerOutput("Stopped", bFinish: true);
		}
	}

	private void OnPrePlaySequence()
	{
		if (CustomData.IsTriggerTransback)
		{
			APawn playerPawn = UGameplayStatics.GetPlayerPawn(base.Owner, 0);
			float transBackDurationTime = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>(playerPawn).TransBackDurationTime;
			if (transBackDurationTime > 0f)
			{
				BUS_EventCollectionCS.Get(playerPawn)?.Evt_TriggerTransBack.Invoke();
				if (FTimerManager.PIEWorld == null)
				{
					_ = FTimerManager.GameInstance;
				}
				WaitTransbackTime = transBackDurationTime;
				return;
			}
			IBUC_MagicallyChangeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>(playerPawn);
			float vigorSkillReEnterWaitTime = unPersistentReadOnlyData.VigorSkillReEnterWaitTime;
			if (unPersistentReadOnlyData.IsDurMagicallyChange() && vigorSkillReEnterWaitTime > 0f)
			{
				BUS_EventCollectionCS.Get(playerPawn)?.Evt_OnMagicallyChangeRecover.Invoke(0);
				WaitTransbackTime = vigorSkillReEnterWaitTime;
				return;
			}
		}
		OnStartPlaySequence();
	}

	public override void Tick(float DeltaTime)
	{
		if (WaitTransbackTime > 0f)
		{
			WaitTransbackTime -= DeltaTime;
			if (WaitTransbackTime <= 0f)
			{
				WaitTransbackTime = -1f;
				OnFinishTransBack();
			}
		}
	}

	public void OnFinishTransBack()
	{
		OnStartPlaySequence();
	}

	private void OnStartPlaySequence()
	{
		if (GSGameplayCVar.CVar_SkipAllPlaySequenceNode.GetValueInGameThread() == 1)
		{
			TriggerOutput("Started", bFinish: false);
			TriggerFirstOutput(bFinish: false);
			TriggerOutput("Completed", bFinish: true);
			return;
		}
		FMovieSceneSequencePlaybackSettings playbackSettings = new FMovieSceneSequencePlaybackSettings
		{
			AutoPlay = false,
			PlayRate = 1f,
			StartTime = CustomData.StartTime,
			RandomStartTime = false,
			RestoreState = false,
			DisableMovementInput = CustomData.IsDisableMovementInput,
			DisableLookAtInput = CustomData.IsDisableLookAtInput,
			HidePlayer = CustomData.IsHidePlayer,
			HideHud = CustomData.IsHideHud,
			DisableCameraCuts = CustomData.IsDisableCameraCuts,
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
			bUsePlayerCamera = CustomData.IsUsePlayerCamera,
			bTriggerMonsterGoHome = false
		};
		MovieInstance movieInstance = MovieInstance.Create(base.Owner, CustomData.SequenceId, inPlaySettings);
		if (movieInstance == null)
		{
			TriggerFirstOutput(bFinish: true);
			return;
		}
		movieInstance.BeforePlayFinishCallBack = (Action)Delegate.Combine(movieInstance.BeforePlayFinishCallBack, new Action(OnFinishBeforePlay));
		movieInstance.MovieFinishCallBack = (Action)Delegate.Combine(movieInstance.MovieFinishCallBack, new Action(OnSequenceFinished));
		MovieInstancePtr = new TWeakObject<MovieInstance>(movieInstance);
		BGS_EventCollectionCS.Get(base.Owner)?.Evt_PlayMovieInstance.Invoke(CustomData.SequenceId, movieInstance);
		TriggerFirstOutput(bFinish: false);
	}

	private void OnFinishBeforePlay()
	{
		MovieInstance movieInstance = MovieInstancePtr.Get();
		movieInstance.BeforePlayFinishCallBack = (Action)Delegate.Remove(movieInstance.BeforePlayFinishCallBack, new Action(OnFinishBeforePlay));
		TriggerOutput("Started", bFinish: false);
	}

	private void OnSequenceFinished()
	{
		MovieInstance movieInstance = MovieInstancePtr.Get();
		movieInstance.MovieFinishCallBack = (Action)Delegate.Remove(movieInstance.MovieFinishCallBack, new Action(OnSequenceFinished));
		TriggerOutput("Completed", bFinish: true);
	}

	public override byte[] GetNodeCustomData()
	{
		return null;
	}

	public override void SetNodeCustomData(byte[] InCustomData)
	{
	}

	public override void RecoverActiveState()
	{
		OnPrePlaySequence();
	}
}

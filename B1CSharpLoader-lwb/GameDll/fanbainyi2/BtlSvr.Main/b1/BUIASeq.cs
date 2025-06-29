using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;

namespace b1;

internal class BUIASeq : BUInteractActionTemplate
{
	public BUIASeq()
	{
		ParamIntNum = 1;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
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
			DisableCameraCuts = (Action.ParamsBool == EGSYesNo.Yes),
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
		BGS_EventCollectionCS.Get(User).Evt_PlayMovieInstance.Invoke(Action.ParamsInt[0], MovieInstance.Create(User, Action.ParamsInt[0], inPlaySettings));
		return true;
	}
}

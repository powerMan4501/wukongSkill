using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;

namespace b1;

public class FBehaviorRightNodeInstance_PlayLevelSeq : FBehaviorRightNodeInstance
{
	public override string NodeName => B1CalliopeDef.BehaviorNode.PlayLevelSeq;

	public BehaviorCustom_PlayLevelSequence CustomData { get; set; }

	protected override void PostCreate()
	{
		CustomData = new BehaviorCustom_PlayLevelSequence();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	protected override void TriggerInput(string InputPin)
	{
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
			bUsePlayerCamera = CustomData.IsUsePlayerCamera
		};
		base.BGSEventCollection.Evt_PlayMovieInstance.Invoke(CustomData.SequenceId, MovieInstance.Create(base.Owner, CustomData.SequenceId, inPlaySettings));
	}
}

using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_SeqCameraData : IPersistentECSData
{
	public EB1CameraMode CameraMode;

	public FGSCameraSequencePlaySetting PlaySetting;

	public ECameraSequencePlayingState PlayingState;

	public float RunTime;

	public float BlendInEndTime;

	public float BlendOutStartTime;

	public float BlendOutDuration;

	public float BlendInDuration;

	public float CameraNormalModePitchMax { get; set; }

	public float CameraNormalModePitchMin { get; set; }

	[UProperty(Flags = PropFlags.Transient)]
	public ALevelSequenceActor LevelSequenceActorForCamera { get; set; }

	public bool bUseCinematicCamera { get; set; }

	public AActor CameraActorForSeq { get; set; }

	public void ResetPlayingData()
	{
		PlayingState = ECameraSequencePlayingState.None;
		RunTime = 0f;
		BlendInEndTime = 0f;
		BlendOutStartTime = 0f;
		BlendOutDuration = 0f;
		BlendInDuration = 0f;
	}

	public override string ToString()
	{
		return "CameraData:" + $"CameraMode:{CameraMode},";
	}
}

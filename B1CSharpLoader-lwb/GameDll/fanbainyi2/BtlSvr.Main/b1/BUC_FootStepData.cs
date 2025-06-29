using b1.ECS;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_FootStepData : IBUC_FootStepData, IPersistentECSData
{
	private TStrongObjectPtr<UAkAudioEvent> mStepAudio = new TStrongObjectPtr<UAkAudioEvent>();

	private TStrongObjectPtr<UMaterial> mDecalMaterial = new TStrongObjectPtr<UMaterial>();

	public int CurLevelID { get; set; }

	public bool DrawDebugLine { get; set; }

	public bool bShowFootSpeed { get; set; }

	public bool bShowFootHeight { get; set; }

	public bool bUseFarStepAudio { get; set; }

	public TSubclassOf<UMatineeCameraShake> CameraShake { get; set; }

	public bool bPrintStepAudioSwitchState { get; set; }

	public bool bMultiSpdForStepAK { get; set; }

	public bool bMyriapods { get; set; }

	public int MyriapodsFootStepEventID { get; set; }

	public bool bMyriapodsMoving { get; set; }

	public FSoftObjectPath StepAudioPath { get; set; }

	public int MoveActionTypeID { get; set; }

	public FSoftObjectPath DecalMaterialPath { get; set; }

	public FVector FootStepDecalSize { get; set; }

	public FVector FootStepDecalOffset { get; set; }

	public float FootStepDecalStartFadeOutTime { get; set; }

	public float FootStepDecalFadeOutDuration { get; set; }

	public UAkAudioEvent StepAudio
	{
		get
		{
			return mStepAudio.Get();
		}
		set
		{
			mStepAudio.Set(value);
		}
	}

	public UMaterial DecalMaterial
	{
		get
		{
			return mDecalMaterial.Get();
		}
		set
		{
			mDecalMaterial.Set(value);
		}
	}
}

using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUC_FixCameraTriggerConfigData
{
	public int CanRetriggerCount;

	private TStrongObjectPtr<ACameraActor> mTargetCamera = new TStrongObjectPtr<ACameraActor>();

	public FVector TargetCameraOffset;

	public float BlendCameraDuration;

	public EViewTargetBlendFunction BlendFunction;

	public float BlendExp;

	public ACameraActor TargetCamera
	{
		get
		{
			return mTargetCamera.Get();
		}
		set
		{
			mTargetCamera.Set(value);
		}
	}
}

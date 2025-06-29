using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

public class GSCameraShakeCtrlInfo
{
	public TStrongObjectPtr<UMatineeCameraShake> CamShakeInst_Ptr;

	public FVector EpicenterLoc;

	public bool EpicenterIsAttach;

	public FName SocketName;

	public AActor AttachActor;

	public UCurveFloat CamShakeScaleByDistCurve;

	public float ReqID;

	public bool bPaused;

	public float OscillatorTimeRemainingOnPause;

	public UMatineeCameraShake CamShakeInst
	{
		get
		{
			return CamShakeInst_Ptr.Get();
		}
		set
		{
			if (CamShakeInst_Ptr != null)
			{
				CamShakeInst_Ptr.Set(value);
			}
			else
			{
				CamShakeInst_Ptr = new TStrongObjectPtr<UMatineeCameraShake>(value);
			}
		}
	}
}

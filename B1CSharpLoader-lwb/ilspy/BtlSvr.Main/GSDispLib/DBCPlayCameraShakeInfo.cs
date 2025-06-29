using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayCameraShakeInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_PlayCameraShake SourceRequest;

	public UMatineeCameraShake CameraShakeInst;

	public float ForceCameraShakeIntensityScale = 1f;

	public bool HasSpawn;

	public float OscillatorTimeRemainingOnPause;

	public bool UseDistanceDamping { get; private set; }

	public FVector SocketPosOnStart { get; private set; }

	public DBCPCurveScalar CustomScaleCurve { get; private set; }

	public bool DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_PlayCameraShake _SourceRequest, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _SourceRequest;
		PausePriority = SourceRequest.PausePriority;
		PlayAtTime = CurTime + _SourceRequest.Delay;
		ForceCameraShakeIntensityScale = 1f;
		if (SourceRequest.CustomScaleCurve.IsValid())
		{
			CustomScaleCurve = new DBCPCurveScalar(SourceRequest.CustomScaleCurve);
		}
		UseDistanceDamping = SourceRequest.UseDistanceDamping;
		if (UseDistanceDamping)
		{
			SocketPosOnStart = base.SourceDispOwnerComp.GetSocketLocation(SourceRequest.AttachedTargetSocketName);
		}
		return true;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_PlayCameraShake _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delay = SourceRequest.Delay;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		ForceCameraShakeIntensityScale = AbstractEvent.ForceCameraShakeIntensityScale;
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		PausePriority = SourceRequest.PausePriority;
		if (SourceRequest.CustomScaleCurve.IsValid())
		{
			float startAge = AbstractEvent.AbstractEventGameAge - delay;
			CustomScaleCurve = new DBCPCurveScalar(SourceRequest.CustomScaleCurve, startAge);
		}
		UseDistanceDamping = SourceRequest.UseDistanceDamping;
		if (UseDistanceDamping)
		{
			SocketPosOnStart = base.SourceDispOwnerComp.GetSocketLocation(SourceRequest.AttachedTargetSocketName);
		}
		return true;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}

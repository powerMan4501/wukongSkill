using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayCustomCameraShakeInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_PlayCustomCameraShake SourceRequest;

	public UMatineeCameraShake CameraShakeInst;

	public EOscillatorWaveform RO_Noise;

	public EOscillatorWaveform LO_Noise;

	public EOscillatorWaveform FOV_Noise;

	public DBCPCurveScalar[] RO_PCurveDataArray;

	public DBCPCurveScalar[] LO_PCurveDataArray;

	public DBCPCurveScalar[] FOV_PCurveDataArray;

	public float ForceCameraShakeIntensityScale = 1f;

	public bool HasSpawn;

	public float OscillatorTimeRemainingOnPause;

	public bool OnEndDispStage;

	public bool UseDistanceDamping { get; private set; }

	public FVector SocketPosOnStart { get; private set; }

	public bool DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_PlayCustomCameraShake _SourceRequest, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _SourceRequest;
		PlayAtTime = CurTime + _SourceRequest.Delay;
		EndAtTime = PlayAtTime + SourceRequest.TotalTime;
		PausePriority = SourceRequest.PausePriority;
		ForceCameraShakeIntensityScale = 1f;
		if (SourceRequest.CtrlRO)
		{
			RO_Noise = SourceRequest.RO_Noise;
			RO_PCurveDataArray = new DBCPCurveScalar[6];
			RO_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.RO_Pitch_Amplitude);
			RO_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.RO_Pitch_Frequency);
			RO_PCurveDataArray[2] = new DBCPCurveScalar(SourceRequest.RO_Yaw_Amplitude);
			RO_PCurveDataArray[3] = new DBCPCurveScalar(SourceRequest.RO_Yaw_Frequency);
			RO_PCurveDataArray[4] = new DBCPCurveScalar(SourceRequest.RO_Roll_Amplitude);
			RO_PCurveDataArray[5] = new DBCPCurveScalar(SourceRequest.RO_Roll_Frequency);
		}
		if (SourceRequest.CtrlLO)
		{
			LO_Noise = SourceRequest.LO_Noise;
			LO_PCurveDataArray = new DBCPCurveScalar[6];
			LO_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.LO_X_Amplitude);
			LO_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.LO_X_Frequency);
			LO_PCurveDataArray[2] = new DBCPCurveScalar(SourceRequest.LO_Y_Amplitude);
			LO_PCurveDataArray[3] = new DBCPCurveScalar(SourceRequest.LO_Y_Frequency);
			LO_PCurveDataArray[4] = new DBCPCurveScalar(SourceRequest.LO_Z_Amplitude);
			LO_PCurveDataArray[5] = new DBCPCurveScalar(SourceRequest.LO_Z_Frequency);
		}
		if (SourceRequest.CtrlFOV)
		{
			FOV_Noise = SourceRequest.FOV_Noise;
			FOV_PCurveDataArray = new DBCPCurveScalar[6];
			FOV_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.FOV_Amplitude);
			FOV_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.FOV_Frequency);
		}
		UseDistanceDamping = SourceRequest.UseDistanceDamping;
		if (UseDistanceDamping)
		{
			SocketPosOnStart = base.SourceDispOwnerComp.GetSocketLocation(SourceRequest.AttachedTargetSocketName);
		}
		return true;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_PlayCustomCameraShake _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delay = SourceRequest.Delay;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		EndAtTime = PlayAtTime + SourceRequest.TotalTime;
		ForceCameraShakeIntensityScale = AbstractEvent.ForceCameraShakeIntensityScale;
		if (CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		PausePriority = SourceRequest.PausePriority;
		float startAge = AbstractEvent.AbstractEventGameAge - delay;
		if (SourceRequest.CtrlRO)
		{
			RO_Noise = SourceRequest.RO_Noise;
			RO_PCurveDataArray = new DBCPCurveScalar[6];
			RO_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.RO_Pitch_Amplitude, startAge);
			RO_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.RO_Pitch_Frequency, startAge);
			RO_PCurveDataArray[2] = new DBCPCurveScalar(SourceRequest.RO_Yaw_Amplitude, startAge);
			RO_PCurveDataArray[3] = new DBCPCurveScalar(SourceRequest.RO_Yaw_Frequency, startAge);
			RO_PCurveDataArray[4] = new DBCPCurveScalar(SourceRequest.RO_Roll_Amplitude, startAge);
			RO_PCurveDataArray[5] = new DBCPCurveScalar(SourceRequest.RO_Roll_Frequency, startAge);
		}
		if (SourceRequest.CtrlLO)
		{
			LO_Noise = SourceRequest.LO_Noise;
			LO_PCurveDataArray = new DBCPCurveScalar[6];
			LO_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.LO_X_Amplitude, startAge);
			LO_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.LO_X_Frequency, startAge);
			LO_PCurveDataArray[2] = new DBCPCurveScalar(SourceRequest.LO_Y_Amplitude, startAge);
			LO_PCurveDataArray[3] = new DBCPCurveScalar(SourceRequest.LO_Y_Frequency, startAge);
			LO_PCurveDataArray[4] = new DBCPCurveScalar(SourceRequest.LO_Z_Amplitude, startAge);
			LO_PCurveDataArray[5] = new DBCPCurveScalar(SourceRequest.LO_Z_Frequency, startAge);
		}
		if (SourceRequest.CtrlFOV)
		{
			FOV_Noise = SourceRequest.FOV_Noise;
			FOV_PCurveDataArray = new DBCPCurveScalar[6];
			FOV_PCurveDataArray[0] = new DBCPCurveScalar(SourceRequest.FOV_Amplitude, startAge);
			FOV_PCurveDataArray[1] = new DBCPCurveScalar(SourceRequest.FOV_Frequency, startAge);
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

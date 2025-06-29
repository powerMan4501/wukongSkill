using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCWEFMWindEventInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_WEFMWind SourceRequest;

	public uint RequesterUniqueID;

	public DispLibDBCEndMode EndMode;

	public bool StartExecute;

	public int WindType;

	public FVector LastFrameSocketPosWS;

	public DBCAdvProcessScalar m_RadiusProcess { get; set; }

	public DBCAdvProcessScalar m_BaseIntensityProcess { get; set; }

	public DBCAdvProcessScalar m_ScaleSecondVelocityProcess { get; set; }

	public void DBCInfoInit(uint _IdentityID, float _CurTime, BUC_DispLibDBC_WEFMWind _SourceRequest, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		RequesterUniqueID = 0u;
		SourceRequest = _SourceRequest;
		PlayAtTime = _CurTime + _SourceRequest.Delay;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 1f;
		}
		PausePriority = SourceRequest.PausePriority;
		WindType = (int)_SourceRequest.WindMotorMode;
		m_RadiusProcess = new DBCAdvProcessScalar(_SourceRequest.Radius);
		m_BaseIntensityProcess = new DBCAdvProcessScalar(_SourceRequest.BaseIntensity);
		m_ScaleSecondVelocityProcess = new DBCAdvProcessScalar(_SourceRequest.ScaleSecondVelocity);
		LastFrameSocketPosWS = base.SourceDispOwnerComp.GetSocketLocation(_SourceRequest.SocketName);
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_WEFMWind _RealRequest)
	{
		SourceRequest = _RealRequest;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + SourceRequest.Delay;
		EndMode = SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 1f;
		}
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
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
		RequesterUniqueID = 0u;
		PausePriority = SourceRequest.PausePriority;
		WindType = (int)SourceRequest.WindMotorMode;
		float startAge = AbstractEvent.AbstractEventGameAge - SourceRequest.Delay;
		m_RadiusProcess = new DBCAdvProcessScalar(SourceRequest.Radius, startAge);
		m_BaseIntensityProcess = new DBCAdvProcessScalar(SourceRequest.BaseIntensity, startAge);
		m_ScaleSecondVelocityProcess = new DBCAdvProcessScalar(SourceRequest.ScaleSecondVelocity, startAge);
		LastFrameSocketPosWS = base.SourceDispOwnerComp.GetSocketLocation(SourceRequest.SocketName);
		return true;
	}

	public void UpdataProcessParams(float DeltaTime, float VelocityLength)
	{
		m_BaseIntensityProcess.UpdateValue(DeltaTime, VelocityLength);
		m_RadiusProcess.UpdateValue(DeltaTime, VelocityLength);
		m_ScaleSecondVelocityProcess.UpdateValue(DeltaTime, VelocityLength);
	}

	public override bool CheckHasTag(FName Tag)
	{
		return SourceRequest.EventName == Tag;
	}
}

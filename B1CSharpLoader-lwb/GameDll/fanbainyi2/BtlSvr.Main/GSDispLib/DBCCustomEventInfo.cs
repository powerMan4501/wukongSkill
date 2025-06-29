using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCCustomEventInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_CustomEvent SourceRequest;

	public bool HasTrigger;

	public bool OnEndDispStage;

	public uint CustomEventID { get; private set; }

	public DBCTransformParam DBCOverrideTransform { get; private set; }

	public USceneComponent MinorDispOwnerComp { get; private set; }

	public DispLibDBCCustomEventDataAssetBase ParametersDataAssets { get; private set; }

	public float DelayTimeAfterStop { get; private set; }

	public DispLibDBCEndMode RealEndMode { get; private set; }

	public DispLibDBCCustomEventTriggerMode RealTriggerMode { get; private set; }

	public void DBCInfoInit(float CurTime, uint _IdentityID, uint _CustomEventID, BUC_DispLibDBC_CustomEvent _SourceRequest, USceneComponent _SourceDispOwnerComp, USceneComponent _MinorDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam))
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		CustomEventID = _CustomEventID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _SourceRequest;
		DBCOverrideTransform = _DBCOverrideTransform;
		MinorDispOwnerComp = _MinorDispOwnerComp;
		ParametersDataAssets = SourceRequest.ParametersDataAssets;
		RealEndMode = (ParametersDataAssets.AllowOverrideEndMode() ? SourceRequest.EndMode : ParametersDataAssets.GetDefaultEndMode());
		RealTriggerMode = (ParametersDataAssets.AllowOverrideTriggerMode() ? SourceRequest.TriggerMode : ParametersDataAssets.GetDefaultTriggerMode());
		switch (RealTriggerMode)
		{
		case DispLibDBCCustomEventTriggerMode.Immediate:
			PlayAtTime = CurTime;
			break;
		case DispLibDBCCustomEventTriggerMode.Standard:
			PlayAtTime = CurTime + _SourceRequest.DelayTime;
			break;
		}
		switch (RealEndMode)
		{
		case DispLibDBCEndMode.AutoRelease:
			EndAtTime = PlayAtTime + 8f;
			break;
		case DispLibDBCEndMode.FixDuration:
			EndAtTime = PlayAtTime + SourceRequest.Duration;
			break;
		case DispLibDBCEndMode.ProcedureNotity:
			EndAtTime = -1f;
			break;
		}
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_CustomEvent _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delayTime = SourceRequest.DelayTime;
		ParametersDataAssets = SourceRequest.ParametersDataAssets;
		RealEndMode = (ParametersDataAssets.AllowOverrideEndMode() ? SourceRequest.EndMode : ParametersDataAssets.GetDefaultEndMode());
		RealTriggerMode = (ParametersDataAssets.AllowOverrideTriggerMode() ? SourceRequest.TriggerMode : ParametersDataAssets.GetDefaultTriggerMode());
		switch (RealTriggerMode)
		{
		case DispLibDBCCustomEventTriggerMode.Immediate:
			PlayAtTime = AbstractEvent.AbstractEventStartAtTime;
			break;
		case DispLibDBCCustomEventTriggerMode.Standard:
			PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delayTime;
			break;
		}
		switch (RealEndMode)
		{
		case DispLibDBCEndMode.AutoRelease:
			RealEndMode = DispLibDBCEndMode.FixDuration;
			EndAtTime = PlayAtTime + 8f;
			break;
		case DispLibDBCEndMode.FixDuration:
			EndAtTime = PlayAtTime + SourceRequest.Duration;
			break;
		case DispLibDBCEndMode.ProcedureNotity:
			EndAtTime = -1f;
			break;
		}
		if (RealEndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		base.IdentityID = AbstractEvent.IdentityID;
		CustomEventID = AbstractEvent.CustomEventID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		DBCOverrideTransform = AbstractEvent.DBCOverrideTransform;
		MinorDispOwnerComp = AbstractEvent.MinorDispOwnerComp;
		return true;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}

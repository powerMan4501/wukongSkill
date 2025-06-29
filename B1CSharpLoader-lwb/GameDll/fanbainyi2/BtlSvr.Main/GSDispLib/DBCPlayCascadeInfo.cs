using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayCascadeInfo : DBCPauseableEventInfo
{
	public DispLibDBCEndMode EndMode;

	public EPSCPoolMethod UEPoolMode;

	public DBCTransformParam DBCOverrideTransform;

	public bool HasSpawn;

	public BUS_DispLibEventCollection.Del_DBCFXCallback SpawnCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreDestroyCallback;

	public BUC_DispLibDBC_PlayCascade SourceRequest { get; set; }

	public UParticleSystemComponent CascadeComponent { get; set; }

	public override bool CheckHasTag(FName Tag)
	{
		return CascadeComponent.ComponentHasTag(Tag);
	}

	public void DBCInfoInit(float CurTime, uint _IdentityID, BUC_DispLibDBC_PlayCascade _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), string _RequestInfo = null)
	{
		DBCInfoInit(_SourceDispOwnerComp);
		HasSpawn = false;
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		PlayAtTime = CurTime + _Request.Delay;
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
			EndAtTime = PlayAtTime + 8f;
		}
		UEPoolMode = DispLibFuncUtil.GetPSCPoolMethodByDBCEndMode(EndMode);
		DBCOverrideTransform = _DBCOverrideTransform;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, CallbackParams.SpawnCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, CallbackParams.PreDestroyCallback);
	}
}

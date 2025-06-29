using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCPlayNiagaraInfo : DBCFXInfoBase
{
	public BUC_DispLibDBC_PlayNiagara SourceRequest { get; set; }

	public void DBCInfoInit(float CurTime, uint _IdentityID, int _EventIndexInDA, uint _DBCDataAssetUniqueID, USceneComponent _SourceDispOwnerComp, BUC_DispLibDBC_PlayNiagara _Request, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams))
	{
		DBCInfoInit(_SourceDispOwnerComp);
		NGInstanceLifeState = DispLibDBCNiagaraInstanceState.WaitForSpawn;
		base.IdentityID = _IdentityID;
		base.EventIndexInDataAsset = _EventIndexInDA;
		DBCDataAssetUniqueID = _DBCDataAssetUniqueID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		base.SourceActorDeath = false;
		SourceRequest = _Request;
		base.Template = SourceRequest.Template;
		base.OverrideMeshCompTagName = SourceRequest.OverrideMeshCompTagName;
		OffsetInLocalSpace = SourceRequest.OffsetInLocalSpace;
		AttachedTargetLocationOffset = SourceRequest.LocationOffset;
		DBCOverrideTransform = _DBCOverrideTransform;
		SnapGround = SourceRequest.SnapGround;
		SnapGroundRotationMode = SourceRequest.SnapGroundRotationMode;
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		if (DBCOverrideTransform.IsValid() && DBCOverrideTransform.AttachedTargetSocketName != FName.None)
		{
			AttachedTargetSocketName = DBCOverrideTransform.AttachedTargetSocketName;
		}
		else
		{
			AttachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		}
		base.FXAttachComp = base.SourceDispOwnerComp;
		if (base.OverrideMeshCompTagName != FName.None)
		{
			BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(base.SourceDispOwnerComp.GetOwner());
			if (readOnlyData != null && readOnlyData.GetFirstMatchMeshComp(base.OverrideMeshCompTagName, out var Result))
			{
				base.FXAttachComp = Result;
			}
		}
		PlayAtTime = CurTime + _Request.Delay;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		GameAge = 0f;
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
		if (SourceRequest.ForcePoolModeNone)
		{
			UEPoolMode = ENCPoolMethod.None;
		}
		else
		{
			UEPoolMode = DispLibFuncUtil.GetNCPoolMethodByDBCEndMode(EndMode);
		}
		PausePriority = SourceRequest.PausePriority;
		PauseMode = SourceRequest.PauseMode;
		EndStagePriority = SourceRequest.EndStagePriority;
		ForceChangeVisibleStateDEFPriority = SourceRequest.ForceChangeVisibleStateDEFPriority;
		ForceVisibleStateDefaultMode = SourceRequest.ForceVisibleStateDefaultMode;
		MetaString = SourceRequest.MetaString;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, CallbackParams.SpawnCallback);
		OverTickCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(OverTickCallback, CallbackParams.OverTickCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, CallbackParams.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, CallbackParams.PreDestroyCallback);
	}

	public override bool CheckHasTag(FName Tag)
	{
		UNiagaraComponent uNiagaraComponent = base.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return false;
		}
		if (!uNiagaraComponent.ComponentHasTag(Tag))
		{
			return MetaString == Tag;
		}
		return true;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, int _EventIndex, uint _DBCDataAssetUniqueID, float CurTime, BUC_DispLibDBC_PlayNiagara _RealRequest)
	{
		SourceRequest = _RealRequest;
		GameAge = AbstractEvent.AbstractEventGameAge;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + SourceRequest.Delay;
		base.ForceNiagaraVisibleState = AbstractEvent.ForceNiagaraVisibleState;
		ForceChangeVisibleStateDEFPriority = SourceRequest.ForceChangeVisibleStateDEFPriority;
		ForceVisibleStateDefaultMode = SourceRequest.ForceVisibleStateDefaultMode;
		if (base.ForceNiagaraVisibleState != -1 && ForceChangeVisibleStateDEFPriority > AbstractEvent.ForceNiagaraVisibleStateRequestATKPriority)
		{
			base.ForceNiagaraVisibleState = -1;
		}
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
		if (EndMode == DispLibDBCEndMode.FixDuration && CurTime > EndAtTime)
		{
			return false;
		}
		base.IsPause = false;
		base.PauseAtTime = 0f;
		base.PauseRequestOperationCounter = 0;
		DBCInfoInit(AbstractEvent.SourceDispOwnerComp);
		NGInstanceLifeState = DispLibDBCNiagaraInstanceState.WaitForSpawn;
		base.IdentityID = AbstractEvent.IdentityID;
		base.EventIndexInDataAsset = _EventIndex;
		DBCDataAssetUniqueID = _DBCDataAssetUniqueID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		DBCOverrideTransform = AbstractEvent.DBCOverrideTransform;
		base.SourceActorDeath = false;
		base.Template = SourceRequest.Template;
		base.OverrideMeshCompTagName = SourceRequest.OverrideMeshCompTagName;
		OffsetInLocalSpace = SourceRequest.OffsetInLocalSpace;
		AttachedTargetLocationOffset = SourceRequest.LocationOffset;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		SnapGround = SourceRequest.SnapGround;
		SnapGroundRotationMode = SourceRequest.SnapGroundRotationMode;
		isAttach_SourceSetting = SourceRequest.AttachedTarget;
		if (DBCOverrideTransform.IsValid() && DBCOverrideTransform.AttachedTargetSocketName != FName.None)
		{
			AttachedTargetSocketName = DBCOverrideTransform.AttachedTargetSocketName;
		}
		else
		{
			AttachedTargetSocketName = SourceRequest.AttachedTargetSocketName;
		}
		base.FXAttachComp = base.SourceDispOwnerComp;
		if (base.OverrideMeshCompTagName != FName.None)
		{
			BUC_DispLibUnitRendererBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(base.SourceDispOwnerComp.GetOwner());
			if (readOnlyData != null && readOnlyData.GetFirstMatchMeshComp(base.OverrideMeshCompTagName, out var Result))
			{
				base.FXAttachComp = Result;
			}
		}
		if (SourceRequest.ForcePoolModeNone)
		{
			UEPoolMode = ENCPoolMethod.None;
		}
		else
		{
			UEPoolMode = DispLibFuncUtil.GetNCPoolMethodByDBCEndMode(EndMode);
		}
		PausePriority = SourceRequest.PausePriority;
		PauseMode = SourceRequest.PauseMode;
		EndStagePriority = SourceRequest.EndStagePriority;
		MetaString = SourceRequest.MetaString;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, AbstractEvent.SpawnCallback);
		OverTickCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(OverTickCallback, AbstractEvent.OverTickCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, AbstractEvent.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, AbstractEvent.PreDestroyCallback);
		return true;
	}
}

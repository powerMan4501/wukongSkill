using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCSpawnSimpleActorInfo : DBCPauseableEventInfo
{
	public BUC_DispLibDBC_SpawnSimpleActor SourceRequest;

	public AActor SpawnedSimpleActor;

	public bool HasSpawn;

	public int EndStagePriority;

	public float DelayTimeAfterStop;

	public bool OnEndDispStage;

	public FVector MinorDispCompPosWSOnSpawn;

	public FVector MinorDispCompPosWSLastFrame;

	public DispLibDBCEndMode EndMode;

	public BUS_DispLibEventCollection.Del_DBCFXCallback SpawnCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreEndCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreDestroyCallback;

	public DBCTransformParam DBCOverrideTransform;

	public USceneComponent MinorDispOwnerComp { get; set; }

	public void DBCInfoInit(float CurTime, uint _IdentityID, USceneComponent _EmitterDispOwnerComp, FVector _EmitterPosWSOnSpawn, BUC_DispLibDBC_SpawnSimpleActor _Request, USceneComponent _SourceDispOwnerComp, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam))
	{
		DBCInfoInit(_SourceDispOwnerComp);
		base.IdentityID = _IdentityID;
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		SourceRequest = _Request;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		EndMode = SourceRequest.EndMode;
		if (EndMode == DispLibDBCEndMode.AutoRelease)
		{
			EndMode = DispLibDBCEndMode.FixDuration;
		}
		MinorDispOwnerComp = _EmitterDispOwnerComp;
		if (_EmitterPosWSOnSpawn == default(FVector) && MinorDispOwnerComp != null)
		{
			MinorDispCompPosWSOnSpawn = MinorDispOwnerComp.GetSocketLocation(SourceRequest.AttachedEmitterSocketName);
		}
		else
		{
			MinorDispCompPosWSOnSpawn = _EmitterPosWSOnSpawn;
		}
		MinorDispCompPosWSLastFrame = _EmitterPosWSOnSpawn;
		PlayAtTime = CurTime + SourceRequest.Delay;
		if (EndMode == DispLibDBCEndMode.FixDuration)
		{
			EndAtTime = PlayAtTime + SourceRequest.Duration;
		}
		else
		{
			EndAtTime = -1f;
		}
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, CallbackParams.SpawnCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, CallbackParams.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, CallbackParams.PreDestroyCallback);
		DBCOverrideTransform = _DBCOverrideTransform;
	}

	public bool DBCInfoInitFromAbstractEvent(DBCAbstractEventInfo AbstractEvent, float CurTime, BUC_DispLibDBC_SpawnSimpleActor _RealRequest)
	{
		SourceRequest = _RealRequest;
		float delay = SourceRequest.Delay;
		PlayAtTime = AbstractEvent.AbstractEventStartAtTime + delay;
		DelayTimeAfterStop = SourceRequest.DelayTimeAfterStop;
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
		base.IdentityID = AbstractEvent.IdentityID;
		base.AnimNotifyUniqueID = AbstractEvent.AnimNotifyUniqueID;
		base.MontageUniqueID = AbstractEvent.MontageUniqueID;
		PausePriority = SourceRequest.PausePriority;
		EndStagePriority = SourceRequest.EndStagePriority;
		MinorDispOwnerComp = AbstractEvent.MinorDispOwnerComp;
		if (AbstractEvent.MinorPosWSOnSpawn == default(FVector) && MinorDispOwnerComp != null)
		{
			MinorDispCompPosWSOnSpawn = MinorDispOwnerComp.GetSocketLocation(SourceRequest.AttachedEmitterSocketName);
		}
		else
		{
			MinorDispCompPosWSOnSpawn = AbstractEvent.MinorPosWSOnSpawn;
		}
		MinorDispCompPosWSLastFrame = AbstractEvent.MinorPosWSOnSpawn;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, AbstractEvent.SpawnCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, AbstractEvent.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, AbstractEvent.PreDestroyCallback);
		DBCOverrideTransform = AbstractEvent.DBCOverrideTransform;
		return true;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return SpawnedSimpleActor.ActorHasTag(Tag);
	}
}

using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class DBCAbstractEventInfo : DBCPauseableEventInfo
{
	public float AbstractEventGameAge;

	public float AbstractEventUnpausedAge;

	public DBCTransformParam DBCOverrideTransform;

	public USceneComponent MinorDispOwnerComp;

	public FVector MinorPosWSOnSpawn;

	public FVector MinorPosWSLastFrame;

	public BUS_DispLibEventCollection.Del_DBCFXCallback SpawnCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback OverTickCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreEndCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreDestroyCallback;

	public float AbstractEventStartAtTime { get; protected set; }

	public uint CustomEventID { get; protected set; }

	public int ForceNiagaraVisibleStateRequestATKPriority { get; set; }

	public int ForceNiagaraVisibleState { get; set; } = -1;

	public int ForceAudioMute { get; set; } = -1;

	public float ForceCameraShakeIntensityScale { get; set; } = 1f;

	public void DBCAbstractEventInfoInit(float CurTime, uint _IdentityID, USceneComponent _SourceDispOwnerComp, USceneComponent _MinorDispOwnerComp, FVector _MinorPosWSOnSpawn, uint _ANID = 0u, uint _MontageUniqueID = 0u, DBCTransformParam _DBCOverrideTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint _CustomEventID = 0u)
	{
		AbstractEventStartAtTime = CurTime;
		base.IdentityID = _IdentityID;
		base.SourceDispOwnerComp = _SourceDispOwnerComp;
		MinorDispOwnerComp = _MinorDispOwnerComp;
		MinorPosWSOnSpawn = _MinorPosWSOnSpawn;
		AActor owner = base.SourceDispOwnerComp.GetOwner();
		base.OwnerActorUniqueID = owner.GetUniqueID();
		base.AnimNotifyUniqueID = _ANID;
		base.MontageUniqueID = _MontageUniqueID;
		DBCOverrideTransform = _DBCOverrideTransform;
		SpawnCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(SpawnCallback, CallbackParams.SpawnCallback);
		OverTickCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(OverTickCallback, CallbackParams.OverTickCallback);
		PreEndCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreEndCallback, CallbackParams.PreEndCallback);
		PreDestroyCallback = (BUS_DispLibEventCollection.Del_DBCFXCallback)Delegate.Combine(PreDestroyCallback, CallbackParams.PreDestroyCallback);
		CustomEventID = _CustomEventID;
	}

	public override bool CheckHasTag(FName Tag)
	{
		return false;
	}
}

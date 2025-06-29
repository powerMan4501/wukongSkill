using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public abstract class DBCFXInfoBase : DBCPauseableEventInfo
{
	public uint DBCDataAssetUniqueID;

	public BUS_DispLibEventCollection.Del_DBCFXCallback SpawnCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback OverTickCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreEndCallback;

	public BUS_DispLibEventCollection.Del_DBCFXCallback PreDestroyCallback;

	public int ForceChangeVisibleStateDEFPriority;

	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode;

	public DispLibDBCEndMode EndMode;

	public ENCPoolMethod UEPoolMode;

	public bool OffsetInLocalSpace;

	public FVector AttachedTargetLocationOffset;

	public bool SnapGround;

	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode;

	public bool isAttach_SourceSetting;

	public FName AttachedTargetSocketName;

	public DBCTransformParam DBCOverrideTransform;

	public FName MetaString;

	public DispLibDBCNiagaraInstanceState NGInstanceLifeState;

	public float DelayTimeAfterStop;

	public bool OnEndDispStage;

	public int EndStagePriority;

	public float GameAge;

	public int EventIndexInDataAsset { get; protected set; }

	public TStrongObjectPtr<UNiagaraComponent> NiagaraComponent { get; set; } = new TStrongObjectPtr<UNiagaraComponent>();

	public USceneComponent FXAttachComp { get; protected set; }

	public UNiagaraSystem Template { get; protected set; }

	public FName OverrideMeshCompTagName { get; protected set; }

	public bool SourceActorDeath { get; set; }

	public int ForceNiagaraVisibleState { get; set; } = -1;

	public virtual bool IsValidInfo()
	{
		return NGInstanceLifeState switch
		{
			DispLibDBCNiagaraInstanceState.HasSpawn => NiagaraComponent.IsValid(), 
			DispLibDBCNiagaraInstanceState.WaitForSpawn => true, 
			DispLibDBCNiagaraInstanceState.BeReuseByScalability => NiagaraComponent.IsValid(), 
			_ => NiagaraComponent.IsValid(), 
		};
	}

	public bool IsNiagaraCanBeReuse()
	{
		if (!NiagaraComponent.IsValid())
		{
			return false;
		}
		if (NGInstanceLifeState == DispLibDBCNiagaraInstanceState.HasSpawn)
		{
			return true;
		}
		return false;
	}
}

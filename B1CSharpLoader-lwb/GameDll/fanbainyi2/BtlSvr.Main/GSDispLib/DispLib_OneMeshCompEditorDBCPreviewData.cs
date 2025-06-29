using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
public class DispLib_OneMeshCompEditorDBCPreviewData
{
	public bool PerFrameAnimPause;

	public float PerFrameAnimPosition;

	public BUS_DispLibDBCManageComp RuntimeCompUseAsEditor_ActorDBCComp;

	public BUS_DispLibUnitMaterialsManageComp RuntimeCompUseAsEditor_ActorMatMgrComp;

	private BUC_DispLibUnitArtFresnelRequestsQueueData Editor_UAFRequestsQueueData = new BUC_DispLibUnitArtFresnelRequestsQueueData();

	private BUC_DispLibUnitRendererBaseData Editor_UnitRendererBaseData = new BUC_DispLibUnitRendererBaseData();

	private BUC_DispLibSetUnitMaterialsParamsRequestsQueueData Editor_UnitMaterialsParamsRequestsQueueData = new BUC_DispLibSetUnitMaterialsParamsRequestsQueueData();

	private BUC_DispLibDBCQueueData Editor_ActorDBCQueueData = new BUC_DispLibDBCQueueData();

	private BUC_DispLibDBCBaseData Editor_ActorDBCBaseData = new BUC_DispLibDBCBaseData();

	private List<uint> DBCCommonNiagaraEventID;

	private bool isWaiting4AllDBCEffectsEnd;

	private float TimeACCInWaitingStage;

	private float MaxWaitingTime = 1f;

	private bool PauseFXOnAnimPause;

	public DispLib_EditorDBCPreviewToolActor LeaderToolActor { get; set; }

	public USceneComponent DispOwnerComp { get; set; }

	public USkeletalMeshComponent DispOwnerComp_SKC { get; set; }

	public float SpawnedTime { get; set; }

	public BUS_DispLibEventCollection Editor_DispLibEventCollection { get; protected set; }

	public BUS_GSEventCollection Editor_BUS_GSEventCollection { get; protected set; }

	public void Init(DispLib_EditorDBCPreviewToolActor _LeaderToolActor, USceneComponent _DispOwnerComp)
	{
	}

	public void OnDestroy(DispLib_EditorDBCPreviewToolActor _LeaderToolActor)
	{
	}

	public void Editor_OnTick(float DeltaSeconds)
	{
	}

	public void ForceStopAllDBCNiagara()
	{
	}

	public bool IsAnimSecquenceCanContinuePlay()
	{
		return false;
	}

	private void Evt_DBCFXPreDestroyCallback(DispLibRefParam Receipt)
	{
	}

	public uint RequestApplyModMat(BUC_DispLibDBC_ModifyMaterial D, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		return 0u;
	}

	public void RequestPauseDBCEffect(uint IdentityID, bool Pause, int PausePriority, string PauseReason)
	{
	}

	public uint RquestPlayOneDBCCommonNiagara(DispLibRefParam DBCRefParam, BUC_DispLibDBC_PlayNiagara SpawnData, uint AnimNotifyUniqueID, uint MontageUniqueID, DBCNCPoolModeOverride PoolModeOverride = default(DBCNCPoolModeOverride))
	{
		DBCRefParam.Clean();
		return 0u;
	}

	public void RquestEndModMatByDBCID(uint DBCID, int EndStagePriority = -1, bool ForceDestroyComponent = false)
	{
	}

	public void RquestEndModMatByAnimNotifyUniqueID(uint AnimNotifyUniqueID, int EndStagePriority = -1, bool ForceDestroyComponent = false)
	{
	}

	public void RquestEndNiagaraByAnimNotifyUniqueID(uint AnimNotifyUniqueID, int EndStagePriority, bool ForceDestroyComponent)
	{
	}

	public void RquestEndNiagaraByDBCID(uint DBCID, int EndStagePriority, bool ForceDestroyComponent)
	{
	}

	public void RquestEndNiagaraByTag(FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1)
	{
	}
}

using System;
using System.Collections.Generic;
using b1;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BUS_DispLibDBCManageComp : BUS_DispLibCompBase
{
	private BUC_DispLibDBCBaseData DBCBaseData;

	private BUC_DispLibDBCQueueData QueueData;

	public BWS_DispLibEventCollection DLDWorldEventCollection { get; private set; }

	private void UserCustom_OnAttach()
	{
		base.DispLibEventCollection.Evt_DBCTriggerOneCustomEvent = OnCustomEventTrigger;
		base.DispLibEventCollection.Evt_DBCPauseOneCustomEvent = OnCustomEventSetPause;
		base.DispLibEventCollection.Evt_DBCOneCustomEventTriggerEndDispStage = OnCustomEventTriggerEndDispStage;
		base.DispLibEventCollection.Evt_DBCRealEndOneCustomEvent = OnCustomEventRealEnd;
	}

	private void OnCustomEventTrigger(uint DBCID, uint CustomEventID, DispLibDBCCustomEventDataAssetBase ParamsDA, DBCCustomEventTimeInfo TimeInfo, DBCCustomEventAdditionalInfo AdditionalInfo)
	{
		DispLibDBCCustomEventType eventType = ParamsDA.GetEventType();
		if (eventType != DispLibDBCCustomEventType.Free_One)
		{
			_ = 2;
		}
	}

	private void OnCustomEventSetPause(uint DBCID, uint CustomEventID, bool Pause, int PausePriority, string PauseReason)
	{
	}

	private void OnCustomEventTriggerEndDispStage(uint DBCID, uint CustomEventID)
	{
	}

	private void OnCustomEventRealEnd(uint DBCID, uint CustomEventID)
	{
	}

	private AActor GetWorldContext()
	{
		AActor aActor = GetOwner();
		if (aActor.IsNullOrDestroyed())
		{
			aActor = (DBCBaseData.DispOwnerComp.IsNullOrDestroyed() ? DBCBaseData.OwnerActor : DBCBaseData.DispOwnerComp.GetOwner());
		}
		return aActor;
	}

	public override void OnAttach()
	{
		base.OnAttach();
		DBCBaseData = RequireWritableData<BUC_DispLibDBCBaseData>();
		QueueData = RequireWritableData<BUC_DispLibDBCQueueData>();
		if (!DBCBaseData.DataInitOver)
		{
			USceneComponent uSceneComponent = Owner.GetComponentByClass<USkeletalMeshComponent>();
			if (uSceneComponent.IsNullOrDestroyed())
			{
				uSceneComponent = Owner.GetRootComponent();
			}
			IBUC_ActorBasicData iBUC_ActorBasicData = RequireReadOnlyData<IBUC_ActorBasicData, BUC_ActorBasicData>();
			DispLibDBCActorGroup dispLibDBCActorGroup = DispLibDBCActorGroup.None;
			dispLibDBCActorGroup = iBUC_ActorBasicData.ActorType switch
			{
				BGU_ActorType.CharacterAI => DispLibDBCActorGroup.BattleUnit, 
				BGU_ActorType.CharacterPlayer => DispLibDBCActorGroup.BattleUnit, 
				BGU_ActorType.CharacterEmptyPlayer => DispLibDBCActorGroup.BattleUnit, 
				BGU_ActorType.Bullet => DispLibDBCActorGroup.Projectile, 
				BGU_ActorType.MagicField => DispLibDBCActorGroup.Projectile, 
				BGU_ActorType.RebirthPoint => DispLibDBCActorGroup.Interact, 
				BGU_ActorType.Collection => DispLibDBCActorGroup.Interact, 
				BGU_ActorType.Weapon => DispLibDBCActorGroup.BattleUnit, 
				_ => DispLibDBCActorGroup.None, 
			};
			DBCBaseData.Init(uSceneComponent, dispLibDBCActorGroup, Owner);
		}
		if (!QueueData.DataInitOver)
		{
			QueueData.Init();
		}
		if (DBCBaseData.DataInitOver && QueueData.DataInitOver)
		{
			BindEvent(base.DispLibEventCollection, base.GamePlayEventCollection);
			UserCustom_OnAttach();
			if (DBCBaseData.DataInitOver)
			{
				GetDLDWorldEventCollection()?.Evt_RequestRegisterActor(DBCBaseData.DispOwnerComp, DBCBaseData.ActorGroup);
			}
		}
	}

	private void BindEvent(BUS_DispLibEventCollection DispLibEventCollection, BUS_GSEventCollection BUSGSEventCollection)
	{
		BUSGSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnActorDead);
		DispLibEventCollection.Evt_DispLibPreDestroy = (BUS_DispLibEventCollection.Del_Void)Delegate.Combine(DispLibEventCollection.Evt_DispLibPreDestroy, new BUS_DispLibEventCollection.Del_Void(PreDestroy));
		DispLibEventCollection.Evt_AddOrChangeInterfaceSocket = AddOrChangeInterfaceSocket;
		DispLibEventCollection.Evt_StartCheckSourceActorHiddenStateSyncDBCEvent = StartCheckSourceActorHiddenStateSyncDBCEvent;
		DispLibEventCollection.Evt_StopCheckSourceActorHiddenStateSyncDBCEvent = StopCheckSourceActorHiddenStateSyncDBCEvent;
		DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset = RequestApplyOneDBCDataAsset;
		BUSGSEventCollection.Evt_RequestSpawnFXByDispConfig += new Del_RequestSpawnFXByDispConfig(RequestApplyOneDBCDataAssetByDAPath);
		BUSGSEventCollection.Evt_RequestSpawnFXByDispConfigWithEmitterInfo += new Del_RequestSpawnFXByDispConfigWithEmitterInfo(RequestApplyOneDBCDataAssetByDAPathWithEmitterInfo);
		BUSGSEventCollection.Evt_RequestDestroyByFXRequestID += new Del_Void_Int(RequestEndDBCEffectsByGamePlayDispReqID);
		BUSGSEventCollection.Evt_RequestSpawnFXByDispConfigDA += new Del_RequestSpawnFXByDispConfigDA(RequestApplyOneDBCDataAssetByDispConfigDA);
		DispLibEventCollection.Evt_RequestSpawn_One_Simple_Niagara = RequestSpawn_One_Simple_Niagara;
		DispLibEventCollection.Evt_RequestSpawn_One_Common_Niagara = RequestSpawn_One_Common_Niagara;
		DispLibEventCollection.Evt_RequestSpawn_One_Advance_Niagara = RequestSpawn_One_Advance_Niagara;
		DispLibEventCollection.Evt_RequestSpawn_One_Simple_Actor = RequestSpawn_One_Simple_Actor;
		DispLibEventCollection.Evt_RequestApply_One_CameraShake = RequestApply_One_CameraShake;
		DispLibEventCollection.Evt_RequestApply_One_CustomCameraShake = RequestApply_One_CustomCameraShake;
		DispLibEventCollection.Evt_RequestPlayAudio = RequestPlayAudio;
		DispLibEventCollection.Evt_RequestSetDBCEffectsPause = RequestSetDBCEffectsPause;
		DispLibEventCollection.Evt_RequestSetDBCEffectsTransform = RequestSetEffectsTransform;
		DispLibEventCollection.Evt_RequestGetFirstDBCNiagaraTransform = RequestGetFirstDBCNiagaraTransform;
		DispLibEventCollection.Evt_RequestResetAllEffects = RequestResetAllEffects;
		DispLibEventCollection.Evt_RequestSetDBCEffectsDetachFromParent = RequestSetDBCEffectsDetachFromParent;
		DispLibEventCollection.Evt_RequestSetDBCEffectsAttachToNewSocket = RequestSetDBCEffectsAttachToNewSocket;
		DispLibEventCollection.Evt_RequestEndDBCEffects = RequestEndDBCEffects;
		DispLibEventCollection.Evt_RequestEndDBCEffectsAdvance = RequestEndDBCEffectsAdvance;
		DispLibEventCollection.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID = RequestEndDBCEffectsByAnimNotifyUniqueID;
		DispLibEventCollection.Evt_RequestEndDBCEffectsByTag = RequestEndDBCEffectsByTag;
		DispLibEventCollection.Evt_RequestApply_One_ModMPC = RequesttApply_One_ModMPC;
		DispLibEventCollection.Evt_RequestApply_One_ModMat = RequesttApply_One_ModMat;
		DispLibEventCollection.Evt_RequestSetMatScalarParam = RequestSetMatScalarParam;
		DispLibEventCollection.Evt_RequestSetMatLinearColorParam = RequestSetMatLinearColorParam;
		DispLibEventCollection.Evt_RequestSetMatTextureParam = RequestSetMatTextureParam;
		DispLibEventCollection.Evt_RequestUpdateMatScalarParam = RequestUpdateMatScalarParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam = RequestSetDBCNiagaraFloatParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam = RequestSetDBCNiagaraVectorParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraBoolParam = RequestSetDBCNiagaraBoolParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraIntParam = RequestSetDBCNiagaraIntParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam = RequestSetDBCNiagaraFloatArrayParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam = RequestSetDBCNiagaraVectorArrayParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVector4ArrayParam = RequestSetDBCNiagaraVector4ArrayParam;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParamValue = RequestSetDBCNiagaraFloatArrayParamValue;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParamValue = RequestSetDBCNiagaraVectorArrayParamValue;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVector4ArrayParamValue = RequestSetDBCNiagaraVector4ArrayParamValue;
		DispLibEventCollection.Evt_RequestSetDBCNiagaraVisibleState = RequestSetDBCNiagaraVisibleState;
		DispLibEventCollection.Evt_RequestSetDBCAudioMuteState = RequestSetDBCAudioMuteState;
		DispLibEventCollection.Evt_RequestSetDBCCameraShakeIntensityScale = RequestSetDBCCameraShakeIntensityScale;
	}

	private BWS_DispLibEventCollection GetDLDWorldEventCollection()
	{
		if (DLDWorldEventCollection != null)
		{
			return DLDWorldEventCollection;
		}
		AActor worldContext = GetWorldContext();
		if (worldContext.IsNullOrDestroyed())
		{
			return null;
		}
		DispLibDispWorld instance = DispLibDispWorld.GetInstance(worldContext);
		if (instance.IsNullOrDestroyed())
		{
			return null;
		}
		DLDWorldEventCollection = BWS_DispLibEventCollection.Get(instance);
		return DLDWorldEventCollection;
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		AActor worldContext = GetWorldContext();
		if (!worldContext.IsNullOrDestroyed())
		{
			worldContext.GetName();
		}
		PreDestroy();
	}

	private void AddOrChangeInterfaceSocket(FName InterfaceName, FName OriginSocketName)
	{
		if (DBCBaseData.InterfaceSockets.ContainsKey(InterfaceName))
		{
			DBCBaseData.InterfaceSockets[InterfaceName] = OriginSocketName;
		}
		else
		{
			DBCBaseData.InterfaceSockets.Add(InterfaceName, OriginSocketName);
		}
	}

	private void StartCheckSourceActorHiddenStateSyncDBCEvent()
	{
		DBCBaseData.SetListenDispOwnerActorHiddenState(isListening: true, 50);
		Interior_SetAllDBCEventsPalpableState(!DBCBaseData.OwnerActor.Hidden);
	}

	private void StopCheckSourceActorHiddenStateSyncDBCEvent()
	{
		DBCBaseData.SetListenDispOwnerActorHiddenState(isListening: false, -1);
		Interior_SetAllDBCEventsPalpableState(!DBCBaseData.OwnerActor.Hidden);
	}

	private void OnActorDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
	}

	private void PreDestroy()
	{
		BWS_DispLibEventCollection dLDWorldEventCollection = GetDLDWorldEventCollection();
		if (dLDWorldEventCollection == null)
		{
			AActor worldContext = GetWorldContext();
			if (!worldContext.IsNullOrDestroyed())
			{
				worldContext.GetName();
			}
		}
		else if (DBCBaseData == null)
		{
			AActor worldContext2 = GetWorldContext();
			if (!worldContext2.IsNullOrDestroyed())
			{
				worldContext2.GetName();
			}
		}
		else if (DBCBaseData.DispOwnerComp.IsNullOrDestroyed())
		{
			AActor worldContext3 = GetWorldContext();
			if (!worldContext3.IsNullOrDestroyed())
			{
				worldContext3.GetName();
			}
		}
		else
		{
			dLDWorldEventCollection.Evt_RequestEndDBCEffects(DBCBaseData.DispOwnerComp, 0u, OnlyEndFX: false, OnlyEndProcedureEndMode: false);
		}
	}

	private void RequestSetDBCEffectsDetachFromParent(int GamePlayDispReqID, bool MaintainWorldPosition, bool CallModify = true)
	{
		uint output = 0u;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCEffectsDetachFromParent(DBCBaseData.DispOwnerComp, output, MaintainWorldPosition, CallModify);
	}

	private void RequestSetDBCEffectsAttachToNewSocket(int GamePlayDispReqID, FName NewSocketName, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepWorld, bool bWeldSimulatedBodies = false)
	{
		uint output = 0u;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCEffectsAttachToNewSocket?.Invoke(DBCBaseData.DispOwnerComp, output, NewSocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
	}

	private void RequestSetDBCEffectsPause(int GamePlayDispReqID, bool Puase, int PausePriority, string PauseReason)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCEffectsPause?.Invoke(DBCBaseData.DispOwnerComp, output, Puase, PausePriority, PauseReason);
	}

	private void RequestSetDBCNiagaraVisibleState(int GamePlayDispReqID, bool isVisible, int ATKPriority)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVisibleState?.Invoke(DBCBaseData.DispOwnerComp, output, isVisible, ATKPriority);
	}

	private void RequestSetDBCAudioMuteState(int GamePlayDispReqID, bool isMute)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCAudioMuteState?.Invoke(DBCBaseData.DispOwnerComp, output, isMute);
	}

	private void RequestSetDBCCameraShakeIntensityScale(int GamePlayDispReqID, float IntensityScale)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCCameraShakeIntensityScale?.Invoke(DBCBaseData.DispOwnerComp, output, IntensityScale);
	}

	private void RequestSetDBCNiagaraFloatParam(int GamePlayDispReqID, FName ParamName, float Value)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraFloatParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Value);
	}

	private void RequestSetDBCNiagaraVectorParam(int GamePlayDispReqID, FName ParamName, FVector Value)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVectorParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Value);
	}

	private void RequestSetDBCNiagaraBoolParam(int GamePlayDispReqID, FName ParamName, bool Value)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraBoolParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Value);
	}

	private void RequestSetDBCNiagaraIntParam(int GamePlayDispReqID, FName ParamName, int Value)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraIntParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Value);
	}

	private void RequestSetDBCNiagaraFloatArrayParam(int GamePlayDispReqID, FName ParamName, List<float> ArrayData)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraFloatArrayParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, ArrayData);
	}

	private void RequestSetDBCNiagaraVectorArrayParam(int GamePlayDispReqID, FName ParamName, List<FVector> ArrayData)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVectorArrayParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, ArrayData);
	}

	private void RequestSetDBCNiagaraVector4ArrayParam(int GamePlayDispReqID, FName ParamName, List<FVector4> ArrayData)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVector4ArrayParam?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, ArrayData);
	}

	private void RequestSetDBCNiagaraFloatArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, float Value, bool SizeToFit)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraFloatArrayParamValue?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Index, Value, SizeToFit);
	}

	private void RequestSetDBCNiagaraVectorArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, FVector Value, bool SizeToFit)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVectorArrayParamValue?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Index, Value, SizeToFit);
	}

	private void RequestSetDBCNiagaraVector4ArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, FVector4 Value, bool SizeToFit)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCNiagaraVector4ArrayParamValue?.Invoke(DBCBaseData.DispOwnerComp, output, ParamName, Index, Value, SizeToFit);
	}

	private void RequestEndDBCEffects(int GamePlayDispReqID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = false, int EndStagePriority = -1, bool ForceDestroyComponent = false)
	{
		uint output;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else
		{
			if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output))
			{
				return;
			}
			QueueData.GamePlayDispReqIDToDBCID.Remove(GamePlayDispReqID);
			if (output == 0)
			{
				return;
			}
		}
		GetDLDWorldEventCollection()?.Evt_RequestEndDBCEffects(DBCBaseData.DispOwnerComp, output, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDestroyComponent);
	}

	private void RequestEndDBCEffectsByAnimNotifyUniqueID(uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = false, int EndStagePriority = -1, bool ForceDestroyComponent = false)
	{
		GetDLDWorldEventCollection()?.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID(DBCBaseData.DispOwnerComp, AnimNotifyUniqueID, MontageUniqueID, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDestroyComponent);
	}

	private void RequestEndDBCEffectsByTag(FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false)
	{
		GetDLDWorldEventCollection()?.Evt_RequestEndDBCEffectsByTag(DBCBaseData.DispOwnerComp, CompTag, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDestroyComponent);
	}

	private void RequestEndDBCEffectsAdvance(DispLibDBCEffectType EffectType, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float ForceDestroyAfterTime = -1f, int EndReasonMark = 0)
	{
		GetDLDWorldEventCollection()?.Evt_RequestEndDBCEffectsAdvance(DBCBaseData.DispOwnerComp, EffectType, FilterMode, ForceDestroyAfterTime, EndReasonMark);
	}

	private void RequestSetEffectsTransform(int GamePlayDispReqID, DBCTransformParam DBCTransform, bool OnlySetFX = false, bool ForceDetachAndSet = false)
	{
		uint output = 0u;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestSetDBCEffectsTransform?.Invoke(DBCBaseData.DispOwnerComp, output, DBCTransform, OnlySetFX, ForceDetachAndSet);
	}

	private bool RequestGetFirstDBCNiagaraTransform(int GamePlayDispReqID, out FTransform ResTransform)
	{
		ResTransform = FTransform.Default;
		uint output = 0u;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return false;
		}
		return GetDLDWorldEventCollection()?.Evt_RequestGetFirstDBCNiagaraTransform(DBCBaseData.DispOwnerComp, output, out ResTransform) ?? false;
	}

	private void RequestResetAllEffects(int GamePlayDispReqID, bool OnlyResetFX = false, bool ResetNonProcedureEndFX = true)
	{
		uint output = 0u;
		if (GamePlayDispReqID == 0)
		{
			output = 0u;
		}
		else if (!QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out output) || output == 0)
		{
			return;
		}
		GetDLDWorldEventCollection()?.Evt_RequestResetAllEffects?.Invoke(DBCBaseData.DispOwnerComp, output, OnlyResetFX, ResetNonProcedureEndFX);
	}

	private int RequestSpawn_One_Simple_Niagara(UNiagaraSystem Template, DispLibDBCEndMode EndMode, float Duration, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int num = QueueData.RequestNewGamePlayDispReqID();
		BWS_DispLibEventCollection dLDWorldEventCollection = GetDLDWorldEventCollection();
		if (dLDWorldEventCollection == null)
		{
			return num;
		}
		uint value = dLDWorldEventCollection.Evt_RequestSpawn_One_Common_Niagara(DBCBaseData.DispOwnerComp, new BUC_DispLibDBC_PlayNiagara(Duration, EndMode, Template), DBCRefParam, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(num, value);
		return num;
	}

	private int RequestSpawn_One_Common_Niagara(BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int num = QueueData.RequestNewGamePlayDispReqID();
		BWS_DispLibEventCollection dLDWorldEventCollection = GetDLDWorldEventCollection();
		if (dLDWorldEventCollection == null)
		{
			return num;
		}
		uint value = dLDWorldEventCollection.Evt_RequestSpawn_One_Common_Niagara(DBCBaseData.DispOwnerComp, D, DBCRefParam, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(num, value);
		return num;
	}

	private int RequestSpawn_One_Advance_Niagara(BUC_DispLibDBC_PlayAdvanceNiagara D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int num = QueueData.RequestNewGamePlayDispReqID();
		BWS_DispLibEventCollection dLDWorldEventCollection = GetDLDWorldEventCollection();
		if (dLDWorldEventCollection == null)
		{
			return num;
		}
		uint value = dLDWorldEventCollection.Evt_RequestSpawn_One_Advance_Niagara(DBCBaseData.DispOwnerComp, D, DBCRefParam, MinorDispOwnerComp, MinorPosWSOnSpawn, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(num, value);
		return num;
	}

	private void RequestApply_One_CameraShake(BUC_DispLibDBC_PlayCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_CameraShake(DBCBaseData.DispOwnerComp, D, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void RequestApply_One_CustomCameraShake(BUC_DispLibDBC_PlayCustomCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_CustomCameraShake(DBCBaseData.DispOwnerComp, D, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void RequestSpawn_One_Simple_Actor(BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		GetDLDWorldEventCollection()?.Evt_RequestSpawn_One_Simple_Actor(DBCBaseData.DispOwnerComp, D, DBCRefParam, MinorDispOwnerComp, MinorPosWSOnSpawn, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void RequestPlayAudio(BUC_DispLibDBC_PlayAudio D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestPlayAudio(DBCBaseData.DispOwnerComp, D, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private void RequesttApply_One_ModMat(BUC_DispLibDBC_ModifyMaterial D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_ModMat(DBCBaseData.DispOwnerComp, D, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private void RequesttApply_One_ModMPC(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_ModMPC(DBCBaseData.DispOwnerComp, D, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private void RequestSetMatLinearColorParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ColorParamName, FLinearColor ColorValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		BUC_DispLibUtil_DBCAdvProcessFLinearColor processValue = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).SetCustomData(ColorValue, (EndMode == DispLibDBCEndMode.ProcedureNotity) ? 0f : Duration);
		BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam item = default(BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ColorParamName, processValue);
		BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(FilterMode, Delay, EndMode, Duration, DelayTimeAfterStop, null, DispLibMaterialParamsInheritMode.NoInherit, null, null, null, null, new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> { item }, null, null, null, PausePriority, EndStagePriority, ModMatPriority, ModMatEndStagePriority);
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_ModMat(DBCBaseData.DispOwnerComp, d, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private void RequestUpdateMatScalarParam(int GamePlayDispReqID, float NewScalarValue)
	{
		if (QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out var output))
		{
			GetDLDWorldEventCollection()?.Evt_RequestUpdateMatScalarParam(DBCBaseData.DispOwnerCompUniqueID, output, NewScalarValue);
		}
	}

	private void RequestSetMatScalarParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ScalarParamName, float ScalarValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(ScalarValue, (EndMode == DispLibDBCEndMode.ProcedureNotity) ? 0f : Duration);
		BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam item = default(BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ScalarParamName, processValue);
		BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(FilterMode, Delay, EndMode, Duration, DelayTimeAfterStop, null, DispLibMaterialParamsInheritMode.NoInherit, null, null, null, new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> { item }, null, null, null, null, PausePriority, EndStagePriority, ModMatPriority, ModMatEndStagePriority);
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_ModMat(DBCBaseData.DispOwnerComp, d, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private void RequestSetMatTextureParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName TexParamName, UTexture TexValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		BUC_DispLibUtil_DBCTexture textureValue = default(BUC_DispLibUtil_DBCTexture).SetCustomData(TexValue, (EndMode == DispLibDBCEndMode.ProcedureNotity) ? 0f : Duration);
		BUC_DispLibUtil_DBCTextureMatLayerParam item = default(BUC_DispLibUtil_DBCTextureMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, TexParamName, textureValue);
		BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(FilterMode, Delay, EndMode, Duration, DelayTimeAfterStop, null, DispLibMaterialParamsInheritMode.NoInherit, null, null, null, null, null, new List<BUC_DispLibUtil_DBCTextureMatLayerParam> { item }, null, null, PausePriority, EndStagePriority, ModMatPriority, ModMatEndStagePriority);
		uint IdentityID = 0u;
		GetDLDWorldEventCollection()?.Evt_RequestApply_One_ModMat(DBCBaseData.DispOwnerComp, d, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
		QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
	}

	private uint Interior_ApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		uint IdentityID = 0u;
		AActor worldContext = GetWorldContext();
		if (worldContext.IsNullOrDestroyed())
		{
			return IdentityID;
		}
		DispLibDispWorld instance = DispLibDispWorld.GetInstance(worldContext);
		if (instance.IsNullOrDestroyed())
		{
			return IdentityID;
		}
		BWS_DispLibEventCollection bWS_DispLibEventCollection = BWS_DispLibEventCollection.Get(instance);
		if (bWS_DispLibEventCollection == null)
		{
			return IdentityID;
		}
		bWS_DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(DBCDataAsset, out IdentityID, DBCBaseData.DispOwnerComp, MinorDispOwnerComp, MinorPosWSOnSpawn, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		return IdentityID;
	}

	private void RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		uint num = Interior_ApplyOneDBCDataAsset(DBCDataAsset, MinorDispOwnerComp, MinorPosWSOnSpawn, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		if (num != 0)
		{
			QueueData.GamePlayDispReqIDToDBCID.Set(key, num);
		}
	}

	private uint Interior_CreateOneDBCAbstractDataAsset(USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		uint IdentityID = 0u;
		AActor worldContext = GetWorldContext();
		if (worldContext.IsNullOrDestroyed())
		{
			return IdentityID;
		}
		DispLibDispWorld instance = DispLibDispWorld.GetInstance(worldContext);
		if (instance.IsNullOrDestroyed())
		{
			return IdentityID;
		}
		BWS_DispLibEventCollection.Get(instance)?.Evt_RequestApplyOneDBCAbstractDataAsset(out IdentityID, DBCBaseData.DispOwnerComp, MinorDispOwnerComp, MinorPosWSOnSpawn, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
		return IdentityID;
	}

	private void OnPostDBCDAAsyncLoad(int GamePlayDispReqID, UObject Obj)
	{
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = Obj as BUC_DispLibDispBaseConfigDataAsset;
		if (bUC_DispLibDispBaseConfigDataAsset == null)
		{
			return;
		}
		AActor worldContext = GetWorldContext();
		if (!worldContext.IsNullOrDestroyed())
		{
			DispLibDispWorld instance = DispLibDispWorld.GetInstance(worldContext);
			if (!instance.IsNullOrDestroyed() && QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out var output) && output != 0)
			{
				BWS_DispLibEventCollection.Get(instance)?.Evt_RequestConverDBCAbstractDataAsset(bUC_DispLibDispBaseConfigDataAsset, DBCBaseData.DispOwnerComp, output);
			}
		}
	}

	public bool ValidateDBC(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent DispOwnerComp)
	{
		if (DBCDataAsset.IsNullOrDestroyed() || DispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	private void RequestApplyOneDBCDataAssetByDAPath(string DispConfigDAPath, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform))
	{
		int num = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = bGW_PreloadAssetMgr.TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(DispConfigDAPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, null, -1, DBCBaseData.ResID);
		if ((object)bUC_DispLibDispBaseConfigDataAsset != null)
		{
			uint num2 = Interior_ApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, MinorDispOwnerComp, default(FVector), new DBCTransformParam(NeedSetSpawnTransform, SpawnTransform));
			if (num2 != 0)
			{
				QueueData.GamePlayDispReqIDToDBCID.Set(num, num2);
			}
			return;
		}
		uint num3 = Interior_CreateOneDBCAbstractDataAsset(MinorDispOwnerComp, default(FVector), new DBCTransformParam(NeedSetSpawnTransform, SpawnTransform));
		if (num3 != 0)
		{
			QueueData.GamePlayDispReqIDToDBCID.Set(num, num3);
			bGW_PreloadAssetMgr.TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(DispConfigDAPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, OnPostDBCDAAsyncLoad, num, DBCBaseData.ResID);
		}
	}

	private void RequestApplyOneDBCDataAssetByDAPathWithEmitterInfo(string DispConfigDAPath, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp, FVector MinorDispPosWSOnSpawn)
	{
		int num = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(Owner);
		BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = bGW_PreloadAssetMgr.TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(DispConfigDAPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium);
		if ((object)bUC_DispLibDispBaseConfigDataAsset != null)
		{
			uint num2 = Interior_ApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, MinorDispOwnerComp, MinorDispPosWSOnSpawn);
			if (num2 != 0)
			{
				QueueData.GamePlayDispReqIDToDBCID.Set(num, num2);
			}
			return;
		}
		uint num3 = Interior_CreateOneDBCAbstractDataAsset(MinorDispOwnerComp, MinorDispPosWSOnSpawn);
		if (num3 != 0)
		{
			QueueData.GamePlayDispReqIDToDBCID.Set(num, num3);
			bGW_PreloadAssetMgr.TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(DispConfigDAPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Medium, OnPostDBCDAAsyncLoad, num);
		}
	}

	private void RequestApplyOneDBCDataAssetByDispConfigDA(UBGWDataAsset DispConfig, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams))
	{
		int key = (GamePlayDispReqID = QueueData.RequestNewGamePlayDispReqID());
		if (DispConfig is BUC_DispLibDispBaseConfigDataAsset dBCDataAsset)
		{
			uint IdentityID = 0u;
			GetDLDWorldEventCollection()?.Evt_RequestApplyOneDBCDataAsset(dBCDataAsset, out IdentityID, DBCBaseData.DispOwnerComp, MinorDispOwnerComp, default(FVector), new DBCTransformParam(NeedSetSpawnTransform, SpawnTransform), CallbackParams);
			if (IdentityID != 0)
			{
				QueueData.GamePlayDispReqIDToDBCID.Set(key, IdentityID);
			}
		}
	}

	private void RequestEndDBCEffectsByGamePlayDispReqID(int GamePlayDispReqID)
	{
		if (QueueData.GamePlayDispReqIDToDBCID.Find(GamePlayDispReqID, out var output))
		{
			QueueData.GamePlayDispReqIDToDBCID.Remove(GamePlayDispReqID);
			if (output != 0)
			{
				GetDLDWorldEventCollection()?.Evt_RequestEndDBCEffects(DBCBaseData.DispOwnerComp, output, OnlyEndFX: false, OnlyEndProcedureEndMode: false);
			}
		}
	}

	private void Interior_SetAllDBCEventsPalpableState(bool isPalpable)
	{
		BWS_DispLibEventCollection dLDWorldEventCollection = GetDLDWorldEventCollection();
		if (dLDWorldEventCollection != null)
		{
			dLDWorldEventCollection.Evt_RequestSetDBCNiagaraVisibleState?.Invoke(DBCBaseData.DispOwnerComp, 0u, isPalpable, DBCBaseData.RequestSyncDispOwnerActorHiddenStateATKPriority);
			dLDWorldEventCollection.Evt_RequestSetDBCAudioMuteState?.Invoke(DBCBaseData.DispOwnerComp, 0u, !isPalpable);
			dLDWorldEventCollection.Evt_RequestSetDBCCameraShakeIntensityScale?.Invoke(DBCBaseData.DispOwnerComp, 0u, isPalpable ? 1f : 0f);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (TickGroup == 1024)
		{
			OnTick(DeltaTime);
		}
	}

	public void OnTick(float DeltaTime)
	{
		if (DBCBaseData.DataInitOver && DBCBaseData.isSyncDispOwnerActorHiddenState && !DBCBaseData.OwnerActor.IsNullOrDestroyed())
		{
			Interior_SetAllDBCEventsPalpableState(!DBCBaseData.OwnerActor.Hidden);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using b1;
using b1.CppExport;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class BWS_DispLibDBCManageComp : BWS_DispLibCompBase
{
	public struct SnapshootUtilInfo
	{
		public string ActorPath;

		public string ActorFullName;

		public string ActorName;

		public string ActorLocation;

		public string ActorHidden;

		public string DispOwnerCompPath;

		public string DispOwnerCompFullName;

		public string DispOwnerCompName;

		public string DispOwnerCompLocation;

		public string DispOwnerCompMesh;

		public string DispOwnerCompIsVisible;

		public string DispOwnerCompHiddenInGame;

		public string DispOwnerCompRenderInMainPass;

		public string FXAttachCompPath;

		public string FXAttachCompFullName;

		public string FXAttachCompName;

		public string FXAttachCompLocation;

		public string FXAttachCompMesh;

		public string FXAttachCompIsVisible;

		public string FXAttachCompHiddenInGame;

		public string FXAttachCompRenderInMainPass;

		public string UtilInfoLog;
	}

	private BUC_DispLibDBCBaseData DBCBaseData;

	private BWC_DispLibDispWorldDBCQueueData Queue;

	private BWC_DispLibCameraData DispLibCameraData;

	private BWC_DispLibDispWorldGlobalData GlobalData;

	private IBIC_LevelData LevelData;

	public override float GetAccumulatedDeltaTime()
	{
		if (!HasBegunPlay())
		{
			return -1f;
		}
		return 0f;
	}

	public override void OnAttach()
	{
		Queue = RequireWritableData<BWC_DispLibDispWorldDBCQueueData>();
		DBCBaseData = RequireWritableData<BUC_DispLibDBCBaseData>();
		DispLibCameraData = RequireWritableData<BWC_DispLibCameraData>();
		GlobalData = RequireWritableData<BWC_DispLibDispWorldGlobalData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		base.BWSDispLibEventCollection.Evt_RequestRegisterActor = RequestRegisterActor;
		base.BWSDispLibEventCollection.Evt_RequestUnregisterActor = RequestRegisterActor;
		base.BWSDispLibEventCollection.Evt_RequestApplyOneDBCDataAsset = RequestApplyOneDBCDataAsset;
		base.BWSDispLibEventCollection.Evt_RequestApplyOneDBCAbstractDataAsset = RequestApplyOneDBCAbstractDataAsset;
		base.BWSDispLibEventCollection.Evt_RequestConverDBCAbstractDataAsset = RequestConverDBCAbstractDataAsset;
		base.BWSDispLibEventCollection.Evt_RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID = RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID;
		base.BWSDispLibEventCollection.Evt_RequestSpawn_One_Common_Niagara = RequestSpawn_One_Common_Niagara;
		base.BWSDispLibEventCollection.Evt_RequestSpawn_One_Advance_Niagara = RequestSpawn_One_Advance_Niagara;
		base.BWSDispLibEventCollection.Evt_RequestSpawn_One_Simple_Actor = RequestSpawn_One_Simple_Actor;
		base.BWSDispLibEventCollection.Evt_RequestApply_One_CameraShake = RequestApply_One_CameraShake;
		base.BWSDispLibEventCollection.Evt_RequestApply_One_CustomCameraShake = RequestApply_One_CustomCameraShake;
		base.BWSDispLibEventCollection.Evt_RequestApplyOneScenePhysicalInteractorDataAsset = RequestApplyOneScenePhysicalInteractorDataAsset;
		base.BWSDispLibEventCollection.Evt_RequestPlayAudio = RequestPlayAudio;
		base.BWSDispLibEventCollection.Evt_RequestApply_One_ModMat = RequestApply_One_ModMat;
		base.BWSDispLibEventCollection.Evt_RequestApply_One_ModMPC = RequestApply_One_ModMPC;
		base.BWSDispLibEventCollection.Evt_RequestUpdateMatScalarParam = RequestUpdateMatScalarParam;
		base.BWSDispLibEventCollection.Evt_OnGameEffectQualityChanged = OnGameEffectQualityChanged;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCEffectsTransform = RequestSetEffectsTransform;
		base.BWSDispLibEventCollection.Evt_RequestGetFirstDBCNiagaraTransform = RequestGetFirstDBCNiagaraTransform;
		base.BWSDispLibEventCollection.Evt_RequestResetAllEffects = RequestResetAllEffects;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCEffectsPause = RequestSetDBCEffectsPause;
		base.BWSDispLibEventCollection.Evt_RequestEndDBCEffects = RequestEndDBCEffects;
		base.BWSDispLibEventCollection.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID = RequestEndDBCEffectsByAnimNotifyUniqueID;
		base.BWSDispLibEventCollection.Evt_RequestEndDBCEffectsByTag = RequestEndDBCEffectsByTag;
		base.BWSDispLibEventCollection.Evt_RequestEndDBCEffectsAdvance = RequestEndDBCEffectsAdvance;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVisibleState = RequestSetDBCNiagaraVisibleState;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatParam = RequestSetDBCNiagaraFloatParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam = RequestSetDBCNiagaraVectorParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraBoolParam = RequestSetDBCNiagaraBoolParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraIntParam = RequestSetDBCNiagaraIntParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParam = RequestSetDBCNiagaraVectorArrayParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVectorArrayParamValue = RequestSetDBCNiagaraVectorArrayParamValue;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVector4ArrayParam = RequestSetDBCNiagaraVector4ArrayParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraVector4ArrayParamValue = RequestSetDBCNiagaraVector4ArrayParamValue;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParam = RequestSetDBCNiagaraFloatArrayParam;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCNiagaraFloatArrayParamValue = RequestSetDBCNiagaraFloatArrayParamValue;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCAudioMuteState = RequestSetDBCAudioMuteState;
		base.BWSDispLibEventCollection.Evt_RequestSetDBCCameraShakeIntensityScale = RequestSetDBCCameraShakeIntensityScale;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestApplyOneDBCDataAsset = DLDWorld_RequestApplyOneDBCDataAsset;
		base.BWSDispLibEventCollection.Evt_GetMPCScalarParamValue = DLDWorld_GetMPCScalarParamValue;
		base.BWSDispLibEventCollection.Evt_GetMPCColorParamValue = DLDWorld_GetMPCColorParamValue;
		base.BWSDispLibEventCollection.Evt_GetMPCScalarParamInitialValue = DLDWorld_GetMPCScalarParamInitialValue;
		base.BWSDispLibEventCollection.Evt_GetMPCColorParamInitialValue = DLDWorld_GetMPCColorParamInitialValue;
		base.BWSDispLibEventCollection.Evt_DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState = DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestDirectInject_Wind = DLDWorld_RequestDirectInject_Wind;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestDirectInject_Heat = DLDWorld_RequestInject_Heat;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestSetWEFMSystemState = DLDWorld_RequestSetWEFMSystemState;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestSpawnOneSimpleNiagara = DLDWorld_RequestSpawn_One_Simple_Niagara;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestSpawnOneCommonNiagara = DLDWorld_RequestSpawn_One_Common_Niagara;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestApply_One_ModMPC = DLDWorld_RequestApply_One_ModMPC;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestApplyOneCameraShake = DLDWorld_RequestApply_One_CameraShake;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestApplyOneCustomCameraShake = DLDWorld_RequestApply_One_CustomCameraShake;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestSpawnOneSimpleActor = DLDWorld_RequestSpawn_One_Simple_Actor;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestEndDBCEffects = DLDWorld_RequestEndDBCEffects;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestEndDBCEffectsByANID = DLDWorld_RequestEndDBCEffectsByANID;
		base.BWSDispLibEventCollection.Evt_DLDWorld_RequestEndDBCEffectsByTag = DLDWorld_RequestEndDBCEffectsByTag;
		BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(GetOwner());
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetWEFMSystemPaused += new Del_Void_BoolString(DLDWorld_SetWEFMSystemPaused);
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetDBCEffectsPaused += new Del_Void_BoolIntString(DLDWorld_SetDBCEffectsPaused);
			bGS_GSEventCollection.Evt_BGS_DLDWorld_SetCameraEnvFXPaused += new Del_Void_BoolString(DLDWorld_SetCameraEnvFXPaused);
		}
	}

	private float GetCurTime()
	{
		return BGU_DispLibDataUtil.GSTimeAfterBeginPlay(GetOwner());
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

	private string GetSeverityErrorDebugString(AActor Actor, UObject ErrorObj)
	{
		string text = (Actor.IsNullOrDestroyed() ? "NullActor" : Actor.GetName());
		string text2 = (Actor.IsNullOrDestroyed() ? "UnknowActorLocation" : Actor.GetActorLocation().ToString());
		string text3 = (ErrorObj.IsNullOrDestroyed() ? "NullErrorObj" : ErrorObj.GetName());
		return "( " + text + " at " + text2 + " has DebugObj___" + text3 + ")";
	}

	private string GetSeverityErrorDebugString(AActor Actor, string ActorName, string ErrorObjName)
	{
		string text = (Actor.IsNullOrDestroyed() ? "UnknowActorLocation" : Actor.GetActorLocation().ToString());
		return "( " + ActorName + " at " + text + " has DebugObj___" + ErrorObjName + ")";
	}

	private string GetSeverityErrorDebugString(AActor Actor, string ErrorObjName)
	{
		string text = (Actor.IsNullOrDestroyed() ? "NullActor" : Actor.GetName());
		string text2 = (Actor.IsNullOrDestroyed() ? "UnknowActorLocation" : Actor.GetActorLocation().ToString());
		return "( " + text + " at " + text2 + " has DebugObj___" + ErrorObjName + ")";
	}

	public static string GetSeverityErrorDebugString(USceneComponent DispOwnerComp, string ErrorObjName)
	{
		AActor aActor = (DispOwnerComp.IsNullOrDestroyed() ? null : DispOwnerComp.GetOwner());
		string text = (aActor.IsNullOrDestroyed() ? "NullActor" : aActor.GetName());
		string text2 = (aActor.IsNullOrDestroyed() ? "UnknowActorLocation" : aActor.GetActorLocation().ToString());
		return "( " + text + " at " + text2 + " has DebugObj___" + ErrorObjName + ")";
	}

	public static string GetSeverityErrorDebugString(USceneComponent DispOwnerComp, UObject ErrorObj)
	{
		AActor aActor = (DispOwnerComp.IsNullOrDestroyed() ? null : DispOwnerComp.GetOwner());
		string text = (aActor.IsNullOrDestroyed() ? "NullActor" : aActor.GetName());
		string text2 = (aActor.IsNullOrDestroyed() ? "UnknowActorLocation" : aActor.GetActorLocation().ToString());
		string text3 = (ErrorObj.IsNullOrDestroyed() ? "NullErrorObj" : ErrorObj.GetName());
		return "( " + text + " at " + text2 + " has DebugObj___" + text3 + ")";
	}

	public static SnapshootUtilInfo GetSnapshootNameInfo(BUC_DispLibUnitRendererBaseData UnitRendererBaseData)
	{
		if (UnitRendererBaseData == null)
		{
			return GetSnapshootNameInfo(null, null);
		}
		return GetSnapshootNameInfo(UnitRendererBaseData.OriginMeshComp, UnitRendererBaseData.OriginMeshComp);
	}

	public static SnapshootUtilInfo GetSnapshootNameInfo(USceneComponent DispOwnerComp, USceneComponent FXAttachComp)
	{
		SnapshootUtilInfo result = default(SnapshootUtilInfo);
		AActor aActor = (DispOwnerComp.IsNullOrDestroyed() ? null : DispOwnerComp.GetOwner());
		string text = (aActor.IsNullOrDestroyed() ? "Null" : aActor.GetPathName());
		string text2 = (aActor.IsNullOrDestroyed() ? "Null" : aActor.GetFullName());
		string text3 = (aActor.IsNullOrDestroyed() ? "Null" : aActor.GetName());
		string text4 = (aActor.IsNullOrDestroyed() ? "Unknow Location" : aActor.GetActorLocation().ToString());
		string text5 = (aActor.IsNullOrDestroyed() ? "Null" : aActor.Hidden.ToString());
		string text6 = (DispOwnerComp.IsNullOrDestroyed() ? "Null" : DispOwnerComp.GetPathName());
		string text7 = (DispOwnerComp.IsNullOrDestroyed() ? "Null" : DispOwnerComp.GetFullName());
		string text8 = (DispOwnerComp.IsNullOrDestroyed() ? "Null" : DispOwnerComp.GetName());
		string text9 = (DispOwnerComp.IsNullOrDestroyed() ? "Unknow Location" : DispOwnerComp.GetWorldLocation().ToString());
		string text10 = "Null";
		string text11 = "Not PrimitiveComponent";
		UStaticMeshComponent uStaticMeshComponent = DispOwnerComp as UStaticMeshComponent;
		USkeletalMeshComponent uSkeletalMeshComponent = DispOwnerComp as USkeletalMeshComponent;
		if (!uSkeletalMeshComponent.IsNullOrDestroyed())
		{
			text10 = (uSkeletalMeshComponent.SkeletalMesh.IsNullOrDestroyed() ? "Null" : uSkeletalMeshComponent.SkeletalMesh.GetPathName());
			text11 = uSkeletalMeshComponent.RenderInMainPass.ToString();
		}
		else if (!uStaticMeshComponent.IsNullOrDestroyed())
		{
			text10 = (uStaticMeshComponent.StaticMesh.IsNullOrDestroyed() ? "Null" : uStaticMeshComponent.StaticMesh.GetPathName());
			text11 = uStaticMeshComponent.RenderInMainPass.ToString();
		}
		string text12 = (DispOwnerComp.IsNullOrDestroyed() ? "Null" : DispOwnerComp.Visible.ToString());
		string text13 = (DispOwnerComp.IsNullOrDestroyed() ? "Null" : DispOwnerComp.HiddenInGame.ToString());
		string text14 = (FXAttachComp.IsNullOrDestroyed() ? "Null" : FXAttachComp.GetPathName());
		string text15 = (FXAttachComp.IsNullOrDestroyed() ? "Null" : FXAttachComp.GetFullName());
		string text16 = (FXAttachComp.IsNullOrDestroyed() ? "Null" : FXAttachComp.GetName());
		string text17 = (FXAttachComp.IsNullOrDestroyed() ? "Unknow Location" : FXAttachComp.GetWorldLocation().ToString());
		string text18 = "Null";
		string fXAttachCompRenderInMainPass = "Not PrimitiveComponent";
		UStaticMeshComponent uStaticMeshComponent2 = FXAttachComp as UStaticMeshComponent;
		USkeletalMeshComponent uSkeletalMeshComponent2 = FXAttachComp as USkeletalMeshComponent;
		if (!uSkeletalMeshComponent2.IsNullOrDestroyed())
		{
			text18 = (uSkeletalMeshComponent2.SkeletalMesh.IsNullOrDestroyed() ? "Null" : uSkeletalMeshComponent2.SkeletalMesh.GetPathName());
			fXAttachCompRenderInMainPass = uSkeletalMeshComponent2.RenderInMainPass.ToString();
		}
		else if (!uStaticMeshComponent2.IsNullOrDestroyed())
		{
			text18 = (uStaticMeshComponent2.StaticMesh.IsNullOrDestroyed() ? "Null" : uStaticMeshComponent2.StaticMesh.GetPathName());
			fXAttachCompRenderInMainPass = uStaticMeshComponent2.RenderInMainPass.ToString();
		}
		string text19 = (FXAttachComp.IsNullOrDestroyed() ? "Null" : FXAttachComp.Visible.ToString());
		string text20 = (FXAttachComp.IsNullOrDestroyed() ? "Null" : FXAttachComp.HiddenInGame.ToString());
		result.ActorPath = text;
		result.ActorFullName = text2;
		result.ActorName = text3;
		result.ActorLocation = text4;
		result.ActorHidden = text5;
		result.DispOwnerCompPath = text6;
		result.DispOwnerCompFullName = text7;
		result.DispOwnerCompName = text8;
		result.DispOwnerCompMesh = text10;
		result.DispOwnerCompLocation = text9;
		result.DispOwnerCompIsVisible = text12;
		result.DispOwnerCompHiddenInGame = text13;
		result.DispOwnerCompRenderInMainPass = text11;
		result.FXAttachCompPath = text14;
		result.FXAttachCompFullName = text15;
		result.FXAttachCompName = text16;
		result.FXAttachCompLocation = text17;
		result.FXAttachCompMesh = text18;
		result.FXAttachCompIsVisible = text19;
		result.FXAttachCompHiddenInGame = text20;
		result.FXAttachCompRenderInMainPass = fXAttachCompRenderInMainPass;
		result.UtilInfoLog = "[Actor] \n  ActorPath = " + text + " \n  ActorFullName = " + text2 + " \n  ActorName = " + text3 + " ___ " + text4 + " ___ Hidden:" + text5 + " \n[DispOwnerComp] \n  Mesh = " + text10 + " \n  DispOwnerCompPath = " + text6 + " \n  DispOwnerCompFullName = " + text7 + " \n  DispOwnerCompName = " + text8 + " ___ " + text9 + " ___ Visible:" + text12 + " ___ Hidden:" + text13 + " ___ DispOwnerCompRenderInMainPass:" + text11 + "\n[FXAttachComp] \n  Mesh = " + text18 + " \n  FXAttachCompPath = " + text14 + " \n  FXAttachCompFullName = " + text15 + " \n  FXAttachCompName = " + text16 + " ___ " + text17 + " ___ Visible:" + text19 + " ___ Hidden:" + text20 + " \n";
		return result;
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		Interior_EndAllEffects();
		Interior_CleanAllData();
	}

	public void OnGameEffectQualityChanged(int NewEffectQuality)
	{
		foreach (Dictionary<int, DBCOneNiagaraScalabilityManager> value in Queue.NiagaraScalability_PerDataAssetPool.Values)
		{
			foreach (DBCOneNiagaraScalabilityManager value2 in value.Values)
			{
				value2.OnGameEffectQualityChanged(NewEffectQuality);
			}
		}
	}

	private void DLDWorld_SetWEFMSystemPaused(bool Pause, string PauseReason)
	{
	}

	private void DLDWorld_SetCameraEnvFXPaused(bool Pause, string PauseReason)
	{
		if (!GlobalData.CameraEnvFXComp.IsNullOrDestroyed())
		{
			GlobalData.CameraEnvFXComp.SetVisibility(!Pause);
			GlobalData.CameraEnvFXComp.SetPaused(Pause);
		}
	}

	private void DLDWorld_SetDBCEffectsPaused(bool Pause, int PausePriority, string PauseReason)
	{
		if (!DBCBaseData.DispOwnerComp.IsNullOrDestroyed())
		{
			RequestSetDBCEffectsPause(DBCBaseData.DispOwnerComp, 0u, Pause, PausePriority, PauseReason);
		}
	}

	private void RequestRegisterActor(USceneComponent SourceDispOwnerComp, DispLibDBCActorGroup Group)
	{
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (!Queue.ActorGroupMapSourceDispOwnerCompID.TryGetValue(Group, out var value))
		{
			Queue.ActorGroupMapSourceDispOwnerCompID.Add(Group, new List<uint> { uniqueID });
		}
		else if (!value.Contains(uniqueID))
		{
			value.Add(uniqueID);
		}
	}

	private void RequestUnregisterActor(USceneComponent SourceDispOwnerComp, DispLibDBCActorGroup Group)
	{
	}

	private void RequestResetAllEffects(USceneComponent SourceDispOwnerComp, uint DBCID, bool OnlyResetFX = false, bool ResetNonProcedureEndFX = true)
	{
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		float curTime = GetCurTime();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == DBCID)
				{
					UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
					switch (dBCPlayNiagaraInfo.EndMode)
					{
					case DispLibDBCEndMode.ProcedureNotity:
						if (dBCPlayNiagaraInfo.OnEndDispStage)
						{
							dBCPlayNiagaraInfo.OnEndDispStage = false;
							dBCPlayNiagaraInfo.EndAtTime = -1f;
							uNiagaraComponent.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxStop, InValue: false);
						}
						uNiagaraComponent.ResetSystem();
						break;
					case DispLibDBCEndMode.FixDuration:
						if (ResetNonProcedureEndFX)
						{
							if (dBCPlayNiagaraInfo.OnEndDispStage)
							{
								dBCPlayNiagaraInfo.OnEndDispStage = false;
								uNiagaraComponent.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxStop, InValue: false);
							}
							dBCPlayNiagaraInfo.EndAtTime = curTime + dBCPlayNiagaraInfo.SourceRequest.Duration;
							uNiagaraComponent.ResetSystem();
						}
						break;
					case DispLibDBCEndMode.AutoRelease:
						if (ResetNonProcedureEndFX)
						{
							uNiagaraComponent.ResetSystem();
						}
						break;
					}
				}
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
				if (dBCPlayAdvanceNiagaraInfo.IdentityID == DBCID)
				{
					UNiagaraComponent uNiagaraComponent2 = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
					switch (dBCPlayAdvanceNiagaraInfo.EndMode)
					{
					case DispLibDBCEndMode.ProcedureNotity:
						if (dBCPlayAdvanceNiagaraInfo.OnEndDispStage)
						{
							dBCPlayAdvanceNiagaraInfo.OnEndDispStage = false;
							dBCPlayAdvanceNiagaraInfo.EndDispStageStartTime = -100f;
							dBCPlayAdvanceNiagaraInfo.EndAtTime = -1f;
							uNiagaraComponent2.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxStop, InValue: false);
						}
						uNiagaraComponent2.ResetSystem();
						break;
					case DispLibDBCEndMode.FixDuration:
						if (ResetNonProcedureEndFX)
						{
							if (dBCPlayAdvanceNiagaraInfo.OnEndDispStage)
							{
								dBCPlayAdvanceNiagaraInfo.OnEndDispStage = false;
								dBCPlayAdvanceNiagaraInfo.EndDispStageStartTime = -100f;
								uNiagaraComponent2.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxStop, InValue: false);
							}
							dBCPlayAdvanceNiagaraInfo.EndAtTime = curTime + dBCPlayAdvanceNiagaraInfo.SourceRequest.Duration;
							uNiagaraComponent2.ResetSystem();
						}
						break;
					case DispLibDBCEndMode.AutoRelease:
						if (ResetNonProcedureEndFX)
						{
							uNiagaraComponent2.ResetSystem();
						}
						break;
					}
				}
			}
		}
		if (Queue.PlayCascadeCacheQueue.TryGetValue(uniqueID, out var value3))
		{
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				DBCPlayCascadeInfo dBCPlayCascadeInfo = value3[num3];
				if (dBCPlayCascadeInfo.IdentityID == DBCID)
				{
					switch (dBCPlayCascadeInfo.EndMode)
					{
					case DispLibDBCEndMode.ProcedureNotity:
						dBCPlayCascadeInfo.CascadeComponent.Activate(bReset: true);
						break;
					case DispLibDBCEndMode.FixDuration:
						if (ResetNonProcedureEndFX)
						{
							dBCPlayCascadeInfo.EndAtTime = curTime + dBCPlayCascadeInfo.SourceRequest.Duration;
							dBCPlayCascadeInfo.CascadeComponent.Activate(bReset: true);
						}
						break;
					case DispLibDBCEndMode.AutoRelease:
						if (ResetNonProcedureEndFX)
						{
							dBCPlayCascadeInfo.CascadeComponent.Activate(bReset: true);
						}
						break;
					}
				}
			}
		}
		if (!Queue.WEFMWindEventCacheQueue.TryGetValue(uniqueID, out var value4))
		{
			return;
		}
		for (int num4 = value4.Count - 1; num4 >= 0; num4--)
		{
			DBCWEFMWindEventInfo dBCWEFMWindEventInfo = value4[num4];
			if (dBCWEFMWindEventInfo.IdentityID == DBCID)
			{
				switch (dBCWEFMWindEventInfo.EndMode)
				{
				case DispLibDBCEndMode.FixDuration:
					if (ResetNonProcedureEndFX)
					{
						dBCWEFMWindEventInfo.EndAtTime = curTime + dBCWEFMWindEventInfo.SourceRequest.Duration;
					}
					break;
				case DispLibDBCEndMode.AutoRelease:
					if (ResetNonProcedureEndFX)
					{
						dBCWEFMWindEventInfo.EndAtTime = curTime + 1f;
					}
					break;
				}
			}
		}
	}

	private void RequestSetDBCEffectsPause(USceneComponent SourceDispOwnerComp, uint IdentityID, bool Pause, int PausePriority, string PauseReason)
	{
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		GetCurTime();
		if (Queue.AbstractEventCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo info = value[num];
				if (DBCIdentityCheckFunc(info, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					if (Pause)
					{
						SetPauseAbstractEvent(num, value, PausePriority, PauseReason);
					}
					else
					{
						SetResumeAbstractEvent(num, value, PausePriority, PauseReason);
					}
				}
			}
		}
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayNiagaraInfo info2 = value2[num2];
				if (DBCIdentityCheckFunc(info2, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					if (Pause)
					{
						SetPauseCommonNiagara(num2, value2, PausePriority, PauseReason);
					}
					else
					{
						SetResumeCommonNiagara(num2, value2, PausePriority, PauseReason);
					}
				}
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value3))
		{
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				DBCPlayAdvanceNiagaraInfo info3 = value3[num3];
				if (DBCIdentityCheckFunc(info3, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					if (Pause)
					{
						SetPauseAdvNiagara(num3, value3, PausePriority, PauseReason);
					}
					else
					{
						SetResumeAdvNiagara(num3, value3, PausePriority, PauseReason);
					}
				}
			}
		}
		if (Queue.PlayArtFresnelCacheQueue.TryGetValue(uniqueID, out var value4))
		{
			for (int num4 = value4.Count - 1; num4 >= 0; num4--)
			{
				DBCPlayArtFresnelInfo info4 = value4[num4];
				if (DBCIdentityCheckFunc(info4, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetArtFresnelPauseState(num4, value4, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.PlayCameraShakeCacheQueue.TryGetValue(uniqueID, out var value5))
		{
			for (int num5 = value5.Count - 1; num5 >= 0; num5--)
			{
				DBCPlayCameraShakeInfo info5 = value5[num5];
				if (DBCIdentityCheckFunc(info5, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetCameraShakePauseState(num5, value5, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.PlayCustomCameraShakeCacheQueue.TryGetValue(uniqueID, out var value6))
		{
			for (int num6 = value6.Count - 1; num6 >= 0; num6--)
			{
				DBCPlayCustomCameraShakeInfo info6 = value6[num6];
				if (DBCIdentityCheckFunc(info6, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetCustomCameraShakePauseState(num6, value6, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.PlayAudioCacheQueue.TryGetValue(uniqueID, out var value7))
		{
			for (int num7 = value7.Count - 1; num7 >= 0; num7--)
			{
				DBCPlayAudioInfo info7 = value7[num7];
				if (DBCIdentityCheckFunc(info7, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetAudioPauseState(num7, value7, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.SpawnSimpleActorCacheQueue.TryGetValue(uniqueID, out var value8))
		{
			for (int num8 = value8.Count - 1; num8 >= 0; num8--)
			{
				DBCSpawnSimpleActorInfo info8 = value8[num8];
				if (DBCIdentityCheckFunc(info8, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetSpawnSimpleActorPauseState(num8, value8, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.WEFMWindEventCacheQueue.TryGetValue(uniqueID, out var value9))
		{
			for (int num9 = value9.Count - 1; num9 >= 0; num9--)
			{
				DBCWEFMWindEventInfo info9 = value9[num9];
				if (DBCIdentityCheckFunc(info9, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetWEFMWindEventPauseState(num9, value9, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.PlaySPICacheQueue.TryGetValue(uniqueID, out var value10))
		{
			for (int num10 = value10.Count - 1; num10 >= 0; num10--)
			{
				DBCScenePhysicalInteractorInfo info10 = value10[num10];
				if (DBCIdentityCheckFunc(info10, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					SetSPIPauseState(num10, value10, Pause, PausePriority, PauseReason);
				}
			}
		}
		if (Queue.ModifyMaterialCacheQueue.TryGetValue(uniqueID, out var value11))
		{
			for (int num11 = value11.Count - 1; num11 >= 0; num11--)
			{
				DBCModifyMaterialInfo info11 = value11[num11];
				if (DBCIdentityCheckFunc(info11, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					if (Pause)
					{
						SetPauseModifyMaterial(num11, value11, Pause, PausePriority, PauseReason);
					}
					else
					{
						SetResumeModifyMaterial(num11, value11, Pause, PausePriority, PauseReason);
					}
				}
			}
		}
		if (Queue.ModifyNiagaraParamsCacheQueue.TryGetValue(uniqueID, out var value12))
		{
			for (int num12 = value12.Count - 1; num12 >= 0; num12--)
			{
				DBCModifyNiagaraParamsInfo info12 = value12[num12];
				if (DBCIdentityCheckFunc(info12, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
				{
					if (Pause)
					{
						SetPauseModifyNiagaraParams(num12, value12, Pause, PausePriority, PauseReason);
					}
					else
					{
						SetResumeModifyNiagaraParams(num12, value12, Pause, PausePriority, PauseReason);
					}
				}
			}
		}
		if (!Queue.CustomEventsCacheQueue.TryGetValue(uniqueID, out var value13))
		{
			return;
		}
		for (int num13 = value13.Count - 1; num13 >= 0; num13--)
		{
			DBCCustomEventInfo info13 = value13[num13];
			if (DBCIdentityCheckFunc(info13, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, FName.None))
			{
				SetCustomEventsPauseState(num13, value13, Pause, PausePriority, PauseReason);
			}
		}
	}

	private void GetFirstDBCFXInfoWithReceipt(USceneComponent SourceDispOwnerComp, uint DBCID, DispLibDBCGettingMark GettingMark, DispLibRefParam Receipt)
	{
		Receipt.Clean();
		if (DBCID == 0)
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		Receipt.DBCReturn_uintID = DBCID;
		switch (GettingMark)
		{
		case DispLibDBCGettingMark.AdvNiagara:
		{
			if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayAdvanceNiagaraCacheQueue, out var FindThisInfo6))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo6.NiagaraComponent.Get();
				if (FindThisInfo6.MetaString == default(FName))
				{
					Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
				}
				else
				{
					Receipt.DBCReturn_FirstFXMetaString = FindThisInfo6.MetaString;
				}
			}
			break;
		}
		case DispLibDBCGettingMark.Cascade:
		{
			if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayCascadeCacheQueue, out var FindThisInfo5))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo5.CascadeComponent;
				Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCascadeDefaultMetaString;
			}
			break;
		}
		case DispLibDBCGettingMark.CustomAdvNiagara:
		{
			if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
			{
				break;
			}
			for (int i = value.Count - 1; i >= 0; i++)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value[i];
				if (dBCPlayAdvanceNiagaraInfo.DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.Custom)
				{
					Receipt.DBCReturn_FirstFXSC = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
					Receipt.DBCReturn_FirstNC = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
					if (dBCPlayAdvanceNiagaraInfo.MetaString == default(FName))
					{
						Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
					}
					else
					{
						Receipt.DBCReturn_FirstFXMetaString = dBCPlayAdvanceNiagaraInfo.MetaString;
					}
					break;
				}
			}
			break;
		}
		case DispLibDBCGettingMark.CommonNiagara:
		{
			if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayNiagaraCacheQueue, out var FindThisInfo4))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo4.NiagaraComponent.Get();
				Receipt.DBCReturn_FirstNC = FindThisInfo4.NiagaraComponent.Get();
				if (FindThisInfo4.MetaString == default(FName))
				{
					Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCNiagaraDefaultMetaString;
				}
				else
				{
					Receipt.DBCReturn_FirstFXMetaString = FindThisInfo4.MetaString;
				}
			}
			break;
		}
		case DispLibDBCGettingMark.UFXSystemComponent:
		{
			DBCPlayNiagaraInfo FindThisInfo2;
			DBCPlayAdvanceNiagaraInfo FindThisInfo3;
			if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayCascadeCacheQueue, out var FindThisInfo))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo.CascadeComponent;
				Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCascadeDefaultMetaString;
			}
			else if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayNiagaraCacheQueue, out FindThisInfo2))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo2.NiagaraComponent.Get();
				if (FindThisInfo2.MetaString == default(FName))
				{
					Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCNiagaraDefaultMetaString;
				}
				else
				{
					Receipt.DBCReturn_FirstFXMetaString = FindThisInfo2.MetaString;
				}
			}
			else if (Queue.Get_First_DBCInfo_ByDBCID(uniqueID, DBCID, Queue.PlayAdvanceNiagaraCacheQueue, out FindThisInfo3))
			{
				Receipt.DBCReturn_FirstFXSC = FindThisInfo3.NiagaraComponent.Get();
				if (FindThisInfo3.MetaString == default(FName))
				{
					Receipt.DBCReturn_FirstFXMetaString = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
				}
				else
				{
					Receipt.DBCReturn_FirstFXMetaString = FindThisInfo3.MetaString;
				}
			}
			break;
		}
		}
	}

	private void GetAllDBCFXInfoWithReceipt(USceneComponent SourceDispOwnerComp, uint DBCID, DispLibDBCGettingMark GettingMark, DispLibRefParam Receipt)
	{
		Receipt.Clean();
		if (DBCID == 0)
		{
			return;
		}
		Receipt.DBCReturn_uintID = DBCID;
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		switch (GettingMark)
		{
		case DispLibDBCGettingMark.AdvNiagara:
		{
			if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value5))
			{
				break;
			}
			for (int m = value5.Count - 1; m >= 0; m++)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo3 = value5[m];
				if (dBCPlayAdvanceNiagaraInfo3.IdentityID == DBCID)
				{
					FName fName4 = dBCPlayAdvanceNiagaraInfo3.MetaString;
					if (fName4 == default(FName))
					{
						fName4 = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
					}
					Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(fName4, dBCPlayAdvanceNiagaraInfo3.NiagaraComponent.Get()));
				}
			}
			break;
		}
		case DispLibDBCGettingMark.Cascade:
		{
			if (!Queue.PlayCascadeCacheQueue.TryGetValue(uniqueID, out var value6))
			{
				break;
			}
			for (int n = value6.Count - 1; n >= 0; n++)
			{
				DBCPlayCascadeInfo dBCPlayCascadeInfo2 = value6[n];
				if (dBCPlayCascadeInfo2.IdentityID == DBCID)
				{
					Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCascadeDefaultMetaString, dBCPlayCascadeInfo2.CascadeComponent));
				}
			}
			break;
		}
		case DispLibDBCGettingMark.CustomAdvNiagara:
		{
			if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value4))
			{
				break;
			}
			for (int l = value4.Count - 1; l >= 0; l++)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo2 = value4[l];
				if (dBCPlayAdvanceNiagaraInfo2.IdentityID == DBCID && dBCPlayAdvanceNiagaraInfo2.DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.Custom)
				{
					FName fName3 = dBCPlayAdvanceNiagaraInfo2.MetaString;
					if (fName3 == default(FName))
					{
						fName3 = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
					}
					Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(fName3, dBCPlayAdvanceNiagaraInfo2.NiagaraComponent.Get()));
				}
			}
			break;
		}
		case DispLibDBCGettingMark.CommonNiagara:
		{
			if (!Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value7))
			{
				break;
			}
			for (int num = value7.Count - 1; num >= 0; num++)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo2 = value7[num];
				if (dBCPlayNiagaraInfo2.IdentityID == DBCID)
				{
					FName fName5 = dBCPlayNiagaraInfo2.MetaString;
					if (fName5 == default(FName))
					{
						fName5 = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCNiagaraDefaultMetaString;
					}
					Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(fName5, dBCPlayNiagaraInfo2.NiagaraComponent.Get()));
				}
			}
			break;
		}
		case DispLibDBCGettingMark.UFXSystemComponent:
		{
			if (Queue.PlayCascadeCacheQueue.TryGetValue(uniqueID, out var value))
			{
				for (int i = value.Count - 1; i >= 0; i++)
				{
					DBCPlayCascadeInfo dBCPlayCascadeInfo = value[i];
					if (dBCPlayCascadeInfo.IdentityID == DBCID)
					{
						Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCascadeDefaultMetaString, dBCPlayCascadeInfo.CascadeComponent));
					}
				}
			}
			if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
			{
				for (int j = value2.Count - 1; j >= 0; j++)
				{
					DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value2[j];
					if (dBCPlayNiagaraInfo.IdentityID == DBCID)
					{
						FName fName = dBCPlayNiagaraInfo.MetaString;
						if (fName == default(FName))
						{
							fName = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCNiagaraDefaultMetaString;
						}
						Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(fName, dBCPlayNiagaraInfo.NiagaraComponent.Get()));
					}
				}
			}
			if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value3))
			{
				break;
			}
			for (int k = value3.Count - 1; k >= 0; k++)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value3[k];
				if (dBCPlayAdvanceNiagaraInfo.IdentityID == DBCID)
				{
					FName fName2 = dBCPlayAdvanceNiagaraInfo.MetaString;
					if (fName2 == default(FName))
					{
						fName2 = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCCustomAdvNiagaraDefaultMetaString;
					}
					Receipt.DBCReturn_AllFXSC.Add(new DispLibDBC_FXSCExternalInfo(fName2, dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get()));
				}
			}
			break;
		}
		}
	}

	private uint RequestSpawn_One_Advance_Niagara(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayAdvanceNiagara D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		if (!ValidateDBCPlayAdvanceNiagara(D))
		{
			return 0u;
		}
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		uint num = Queue.RequestNewUniqueID();
		DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = new DBCPlayAdvanceNiagaraInfo();
		dBCPlayAdvanceNiagaraInfo.DBCInfoInit(curTime, num, 0, 0u, SourceDispOwnerComp, D, MinorDispOwnerComp, MinorPosWSOnSpawn, AnimNotifyUniqueID, MontageUniqueID, DBCTransform, CallbackParams, GlobalData.CMDOverride_EnableDBCMergeNiagara);
		if (curTime >= dBCPlayAdvanceNiagaraInfo.PlayAtTime && !DoPlayAdvanceNiagara(dBCPlayAdvanceNiagaraInfo))
		{
			return 0u;
		}
		Queue.AddItem2CacheQueue(uniqueID, dBCPlayAdvanceNiagaraInfo, Queue.PlayAdvanceNiagaraCacheQueue);
		AdvanceNiagaraUpdate(dBCPlayAdvanceNiagaraInfo, curTime);
		return num;
	}

	private uint RequestSpawn_One_Common_Niagara(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		DBCRefParam.Clean();
		if (!ValidateDBCPlayNiagara(D))
		{
			return 0u;
		}
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		uint num = Queue.RequestNewUniqueID();
		DBCPlayNiagaraInfo dBCPlayNiagaraInfo = new DBCPlayNiagaraInfo();
		dBCPlayNiagaraInfo.DBCInfoInit(curTime, num, 0, 0u, SourceDispOwnerComp, D, AnimNotifyUniqueID, MontageUniqueID, DBCTransform, CallbackParams);
		if (curTime >= dBCPlayNiagaraInfo.PlayAtTime && !DoPlayNiagara(dBCPlayNiagaraInfo))
		{
			return 0u;
		}
		Queue.AddItem2CacheQueue(uniqueID, dBCPlayNiagaraInfo, Queue.PlayNiagaraCacheQueue);
		DBCRefParam.Set(num, dBCPlayNiagaraInfo.NiagaraComponent.Get(), (dBCPlayNiagaraInfo.MetaString == default(FName)) ? BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCNiagaraDefaultMetaString : dBCPlayNiagaraInfo.MetaString);
		return num;
	}

	private void RequestApplyOneScenePhysicalInteractorDataAsset(USceneComponent SourceDispOwnerComp, BUC_DispLibSceneInteractorData SceneInteractorData, out uint IdentityID, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = 0u;
		if (SceneInteractorData.IsNullOrDestroyed())
		{
			return;
		}
		IdentityID = Queue.RequestNewUniqueID();
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		foreach (BUC_DispLibDBC_ScenePhysicalInteractor item in SceneInteractorData.ScenePhysicalInteractor)
		{
			if (!ValidateDBCScenePhysicalInteractor(item))
			{
				continue;
			}
			if (item.Delay <= 0.001f)
			{
				if (DoSPI(SourceDispOwnerComp, item))
				{
				}
			}
			else
			{
				Queue.AddItem2CacheQueue(uniqueID, new DBCScenePhysicalInteractorInfo(curTime, item, SourceDispOwnerComp), Queue.PlaySPICacheQueue);
			}
		}
	}

	private void RequestPlayAudio(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayAudio D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = 0u;
		IdentityID = Queue.RequestNewUniqueID();
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		DBCPlayAudioInfo dBCPlayAudioInfo = new DBCPlayAudioInfo();
		dBCPlayAudioInfo.DBCInfoInit(IdentityID, curTime, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
		if (!(curTime >= dBCPlayAudioInfo.PlayAtTime) || DoPlayAudio(dBCPlayAudioInfo))
		{
			Queue.AddItem2CacheQueue(uniqueID, dBCPlayAudioInfo, Queue.PlayAudioCacheQueue);
		}
	}

	private void RequestApply_One_ModMPC(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = 0u;
		if (ValidateDBCModifyMPC(D))
		{
			float curTime = GetCurTime();
			IdentityID = Queue.RequestNewUniqueID();
			DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = new DBCModifyMaterialParameterCollectionInfo();
			dBCModifyMaterialParameterCollectionInfo.DBCInfoInit(curTime, IdentityID, D, DBCBaseData.DispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
			if (!(D.Delay <= 0.001f) || DoModifyMPC(dBCModifyMaterialParameterCollectionInfo))
			{
				Queue.AddItem2CacheQueue(DBCBaseData.DispOwnerComp.GetUniqueID(), dBCModifyMaterialParameterCollectionInfo, Queue.ModifyMPCCacheQueue);
			}
		}
	}

	private void RequestUpdateMatScalarParam(uint SourceDispOwnerCompID, uint IdentityID, float NewScalarValue)
	{
		if (!Queue.ModifyMaterialCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			return;
		}
		for (int num = value.Count - 1; num >= 0; num--)
		{
			DBCModifyMaterialInfo dBCModifyMaterialInfo = value[num];
			if (DBCIdentityCheckFunc(dBCModifyMaterialInfo, DispLibDBCIdentityCheckMode.DBCID, IdentityID, 0u, default(FName)))
			{
				if (dBCModifyMaterialInfo.ScalarParams.Count != 1)
				{
					break;
				}
				dBCModifyMaterialInfo.ScalarParams[0].UpdateStandardModeEventCurFrameValue(NewScalarValue);
			}
		}
	}

	private void RequestApply_One_ModMat(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterial D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = Queue.RequestNewUniqueID();
		if (!ValidateDBCModifyMaterial(D))
		{
			return;
		}
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(SourceDispOwnerComp.GetOwner());
		if (bUS_DispLibEventCollection != null)
		{
			DBCModifyMaterialInfo dBCModifyMaterialInfo = new DBCModifyMaterialInfo();
			dBCModifyMaterialInfo.DBCInfoInit(curTime, IdentityID, D, SourceDispOwnerComp, bUS_DispLibEventCollection, Queue.ModMatCSharpObjectPool, AnimNotifyUniqueID, MontageUniqueID);
			if (!(D.Delay <= 0.001f) || DoModifyMaterial(dBCModifyMaterialInfo))
			{
				Queue.AddItem2CacheQueue(uniqueID, dBCModifyMaterialInfo, Queue.ModifyMaterialCacheQueue);
			}
		}
	}

	private uint RequestSpawn_One_Simple_Actor(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		DBCRefParam.Clean();
		if (!ValidateDBCSpawnSimpleActor(D))
		{
			return 0u;
		}
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		uint num = Queue.RequestNewUniqueID();
		DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = new DBCSpawnSimpleActorInfo();
		dBCSpawnSimpleActorInfo.DBCInfoInit(curTime, num, MinorDispOwnerComp, MinorPosWSOnSpawn, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID, CallbackParams);
		if (D.Delay <= 0.001f && !DoSpawnSimpleActor(dBCSpawnSimpleActorInfo))
		{
			return 0u;
		}
		Queue.AddItem2CacheQueue(uniqueID, dBCSpawnSimpleActorInfo, Queue.SpawnSimpleActorCacheQueue);
		DBCRefParam.Set(num, dBCSpawnSimpleActorInfo.SpawnedSimpleActor);
		return num;
	}

	private void RequestApply_One_CameraShake(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		if (ValidateDBCPlayCameraShake(D))
		{
			float curTime = GetCurTime();
			uint uniqueID = SourceDispOwnerComp.GetUniqueID();
			uint identityID = Queue.RequestNewUniqueID();
			DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = new DBCPlayCameraShakeInfo();
			if (dBCPlayCameraShakeInfo.DBCInfoInit(curTime, identityID, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(D.Delay <= 0.001f) || DoPlayCameraShake(dBCPlayCameraShakeInfo)))
			{
				Queue.AddItem2CacheQueue(uniqueID, dBCPlayCameraShakeInfo, Queue.PlayCameraShakeCacheQueue);
			}
		}
	}

	private void RequestApply_One_CustomCameraShake(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayCustomCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		if (ValidateDBCPlayCustomCameraShake(D))
		{
			float curTime = GetCurTime();
			uint uniqueID = SourceDispOwnerComp.GetUniqueID();
			uint identityID = Queue.RequestNewUniqueID();
			DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = new DBCPlayCustomCameraShakeInfo();
			if (dBCPlayCustomCameraShakeInfo.DBCInfoInit(curTime, identityID, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(D.Delay <= 0.001f) || DoPlayCustomCameraShake(dBCPlayCustomCameraShakeInfo)))
			{
				Queue.AddItem2CacheQueue(uniqueID, dBCPlayCustomCameraShakeInfo, Queue.PlayCustomCameraShakeCacheQueue);
			}
		}
	}

	private void RequestConverDBCAbstractDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent SourceDispOwnerComp, uint DBCID)
	{
		Interior_RequestConverDBCAbstractDataAsset(DBCDataAsset, SourceDispOwnerComp, DispLibDBCIdentityCheckMode.DBCID, DBCID, 0u);
	}

	private void RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		Interior_RequestConverDBCAbstractDataAsset(DBCDataAsset, SourceDispOwnerComp, DispLibDBCIdentityCheckMode.AnimNotifyUniqueID, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void Interior_RequestConverDBCAbstractDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent SourceDispOwnerComp, DispLibDBCIdentityCheckMode CheckMode, uint IdentityID, uint MontageUniqueID)
	{
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		int index = -1;
		DBCAbstractEventInfo dBCAbstractEventInfo = null;
		if (Queue.AbstractEventCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int i = 0; i < value.Count; i++)
			{
				DBCAbstractEventInfo dBCAbstractEventInfo2 = value[i];
				if (DBCIdentityCheckFunc(dBCAbstractEventInfo2, CheckMode, IdentityID, MontageUniqueID, FName.None))
				{
					index = i;
					dBCAbstractEventInfo = dBCAbstractEventInfo2;
					break;
				}
			}
		}
		if (dBCAbstractEventInfo == null)
		{
			return;
		}
		_ = dBCAbstractEventInfo.AnimNotifyUniqueID;
		_ = dBCAbstractEventInfo.MontageUniqueID;
		value.RemoveAt(index);
		if (!ValidateDBC(DBCDataAsset, SourceDispOwnerComp))
		{
			return;
		}
		if (DBCDataAsset.PlayNiagara.Count > 0)
		{
			uint uniqueID2 = DBCDataAsset.GetUniqueID();
			for (int j = 0; j < DBCDataAsset.PlayNiagara.Count; j++)
			{
				BUC_DispLibDBC_PlayNiagara bUC_DispLibDBC_PlayNiagara = DBCDataAsset.PlayNiagara[j];
				if (ValidateDBCPlayNiagara(bUC_DispLibDBC_PlayNiagara))
				{
					DBCPlayNiagaraInfo dBCPlayNiagaraInfo = new DBCPlayNiagaraInfo();
					if (dBCPlayNiagaraInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, j, uniqueID2, curTime, bUC_DispLibDBC_PlayNiagara) && (!(curTime >= dBCPlayNiagaraInfo.PlayAtTime) || DoPlayNiagara(dBCPlayNiagaraInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayNiagaraInfo, Queue.PlayNiagaraCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayAdvanceNiagara.Count > 0)
		{
			uint uniqueID3 = DBCDataAsset.GetUniqueID();
			for (int k = 0; k < DBCDataAsset.PlayAdvanceNiagara.Count; k++)
			{
				BUC_DispLibDBC_PlayAdvanceNiagara bUC_DispLibDBC_PlayAdvanceNiagara = DBCDataAsset.PlayAdvanceNiagara[k];
				if (ValidateDBCPlayAdvanceNiagara(bUC_DispLibDBC_PlayAdvanceNiagara))
				{
					DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = new DBCPlayAdvanceNiagaraInfo();
					if (dBCPlayAdvanceNiagaraInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, k, uniqueID3, curTime, bUC_DispLibDBC_PlayAdvanceNiagara, GlobalData.CMDOverride_EnableDBCMergeNiagara) && (!(curTime >= dBCPlayAdvanceNiagaraInfo.PlayAtTime) || DoPlayAdvanceNiagara(dBCPlayAdvanceNiagaraInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayAdvanceNiagaraInfo, Queue.PlayAdvanceNiagaraCacheQueue);
						AdvanceNiagaraUpdate(dBCPlayAdvanceNiagaraInfo, curTime);
					}
				}
			}
		}
		if (DBCDataAsset.SpawnSimpleActor.Count > 0)
		{
			for (int l = 0; l < DBCDataAsset.SpawnSimpleActor.Count; l++)
			{
				BUC_DispLibDBC_SpawnSimpleActor bUC_DispLibDBC_SpawnSimpleActor = DBCDataAsset.SpawnSimpleActor[l];
				if (ValidateDBCSpawnSimpleActor(bUC_DispLibDBC_SpawnSimpleActor))
				{
					DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = new DBCSpawnSimpleActorInfo();
					if (dBCSpawnSimpleActorInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_SpawnSimpleActor) && (!(curTime >= dBCSpawnSimpleActorInfo.PlayAtTime) || DoSpawnSimpleActor(dBCSpawnSimpleActorInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCSpawnSimpleActorInfo, Queue.SpawnSimpleActorCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayCameraShake.Count > 0)
		{
			for (int m = 0; m < DBCDataAsset.PlayCameraShake.Count; m++)
			{
				BUC_DispLibDBC_PlayCameraShake bUC_DispLibDBC_PlayCameraShake = DBCDataAsset.PlayCameraShake[m];
				if (ValidateDBCPlayCameraShake(bUC_DispLibDBC_PlayCameraShake))
				{
					DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = new DBCPlayCameraShakeInfo();
					if (dBCPlayCameraShakeInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_PlayCameraShake) && (!(curTime >= dBCPlayCameraShakeInfo.PlayAtTime) || DoPlayCameraShake(dBCPlayCameraShakeInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayCameraShakeInfo, Queue.PlayCameraShakeCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayCustomCameraShake.Count > 0)
		{
			for (int n = 0; n < DBCDataAsset.PlayCustomCameraShake.Count; n++)
			{
				BUC_DispLibDBC_PlayCustomCameraShake bUC_DispLibDBC_PlayCustomCameraShake = DBCDataAsset.PlayCustomCameraShake[n];
				if (ValidateDBCPlayCustomCameraShake(bUC_DispLibDBC_PlayCustomCameraShake))
				{
					DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = new DBCPlayCustomCameraShakeInfo();
					if (dBCPlayCustomCameraShakeInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_PlayCustomCameraShake) && (!(curTime >= dBCPlayCustomCameraShakeInfo.PlayAtTime) || DoPlayCustomCameraShake(dBCPlayCustomCameraShakeInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayCustomCameraShakeInfo, Queue.PlayCustomCameraShakeCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayAudio.Count > 0)
		{
			for (int num = 0; num < DBCDataAsset.PlayAudio.Count; num++)
			{
				BUC_DispLibDBC_PlayAudio realRequest = DBCDataAsset.PlayAudio[num];
				DBCPlayAudioInfo dBCPlayAudioInfo = new DBCPlayAudioInfo();
				if (dBCPlayAudioInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, realRequest) && (!(curTime >= dBCPlayAudioInfo.PlayAtTime) || DoPlayAudio(dBCPlayAudioInfo)))
				{
					Queue.AddItem2CacheQueue(uniqueID, dBCPlayAudioInfo, Queue.PlayAudioCacheQueue);
				}
			}
		}
		if (DBCDataAsset.WEFMWind.Count > 0)
		{
			for (int num2 = 0; num2 < DBCDataAsset.WEFMWind.Count; num2++)
			{
				BUC_DispLibDBC_WEFMWind bUC_DispLibDBC_WEFMWind = DBCDataAsset.WEFMWind[num2];
				if (ValidateDBCWEFMWind(bUC_DispLibDBC_WEFMWind))
				{
					DBCWEFMWindEventInfo dBCWEFMWindEventInfo = new DBCWEFMWindEventInfo();
					if (dBCWEFMWindEventInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_WEFMWind))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCWEFMWindEventInfo, Queue.WEFMWindEventCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyMaterial.Count > 0)
		{
			for (int num3 = 0; num3 < DBCDataAsset.ModifyMaterial.Count; num3++)
			{
				BUC_DispLibDBC_ModifyMaterial bUC_DispLibDBC_ModifyMaterial = DBCDataAsset.ModifyMaterial[num3];
				if (!ValidateDBCModifyMaterial(bUC_DispLibDBC_ModifyMaterial))
				{
					continue;
				}
				BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(SourceDispOwnerComp.GetOwner());
				if (bUS_DispLibEventCollection != null)
				{
					DBCModifyMaterialInfo dBCModifyMaterialInfo = new DBCModifyMaterialInfo();
					if (dBCModifyMaterialInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_ModifyMaterial, bUS_DispLibEventCollection, Queue.ModMatCSharpObjectPool) && (!(curTime >= dBCModifyMaterialInfo.PlayAtTime) || DoModifyMaterial(dBCModifyMaterialInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyMaterialInfo, Queue.ModifyMaterialCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyNiagaraParams.Count > 0)
		{
			for (int num4 = 0; num4 < DBCDataAsset.ModifyNiagaraParams.Count; num4++)
			{
				BUC_DispLibDBC_ModifyNiagaraParams bUC_DispLibDBC_ModifyNiagaraParams = DBCDataAsset.ModifyNiagaraParams[num4];
				if (ValidateDBCModifyNiagaraParams(bUC_DispLibDBC_ModifyNiagaraParams))
				{
					DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = new DBCModifyNiagaraParamsInfo();
					if (dBCModifyNiagaraParamsInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_ModifyNiagaraParams) && (!(curTime >= dBCModifyNiagaraParamsInfo.PlayAtTime) || DoModifyNiagaraParams(dBCModifyNiagaraParamsInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyNiagaraParamsInfo, Queue.ModifyNiagaraParamsCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyMPCParams.Count > 0)
		{
			for (int num5 = 0; num5 < DBCDataAsset.ModifyMPCParams.Count; num5++)
			{
				BUC_DispLibDBC_ModifyMaterialParameterCollection bUC_DispLibDBC_ModifyMaterialParameterCollection = DBCDataAsset.ModifyMPCParams[num5];
				if (ValidateDBCModifyMPC(bUC_DispLibDBC_ModifyMaterialParameterCollection))
				{
					DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = new DBCModifyMaterialParameterCollectionInfo();
					if (dBCModifyMaterialParameterCollectionInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_ModifyMaterialParameterCollection) && (!(curTime >= dBCModifyMaterialParameterCollectionInfo.PlayAtTime) || DoModifyMPC(dBCModifyMaterialParameterCollectionInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyMaterialParameterCollectionInfo, Queue.ModifyMPCCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.CustomEvents.Count <= 0)
		{
			return;
		}
		for (int num6 = 0; num6 < DBCDataAsset.CustomEvents.Count; num6++)
		{
			BUC_DispLibDBC_CustomEvent bUC_DispLibDBC_CustomEvent = DBCDataAsset.CustomEvents[num6];
			if (!ValidateDBCCustomEvent(bUC_DispLibDBC_CustomEvent))
			{
				continue;
			}
			DBCCustomEventInfo dBCCustomEventInfo = new DBCCustomEventInfo();
			if (!dBCCustomEventInfo.DBCInfoInitFromAbstractEvent(dBCAbstractEventInfo, curTime, bUC_DispLibDBC_CustomEvent))
			{
				continue;
			}
			switch (dBCCustomEventInfo.RealTriggerMode)
			{
			case DispLibDBCCustomEventTriggerMode.Standard:
				if (curTime >= dBCCustomEventInfo.PlayAtTime && !DoCustomEvent(dBCCustomEventInfo))
				{
					continue;
				}
				break;
			case DispLibDBCCustomEventTriggerMode.Immediate:
				if (!DoCustomEvent(dBCCustomEventInfo))
				{
					continue;
				}
				break;
			}
			Queue.AddItem2CacheQueue(uniqueID, dBCCustomEventInfo, Queue.CustomEventsCacheQueue);
		}
	}

	private void RequestApplyOneDBCAbstractDataAsset(out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCOverrideTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = Queue.RequestNewUniqueID();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		float curTime = GetCurTime();
		DBCAbstractEventInfo dBCAbstractEventInfo = new DBCAbstractEventInfo();
		dBCAbstractEventInfo.DBCAbstractEventInfoInit(curTime, IdentityID, SourceDispOwnerComp, MinorDispOwnerComp, MinorPosWSOnSpawn, AnimNotifyUniqueID, MontageUniqueID, DBCOverrideTransform, CallbackParams, Queue.RequestNewCustomEventID());
		Queue.AddAbstractEvent2CacheQueue(uniqueID, dBCAbstractEventInfo);
	}

	private void RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = Queue.RequestNewUniqueID();
		if (!ValidateDBC(DBCDataAsset, SourceDispOwnerComp))
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		float curTime = GetCurTime();
		if (DBCDataAsset.PlayCascade.Count > 0)
		{
			for (int i = 0; i < DBCDataAsset.PlayCascade.Count; i++)
			{
				BUC_DispLibDBC_PlayCascade bUC_DispLibDBC_PlayCascade = DBCDataAsset.PlayCascade[i];
				if (ValidateDBCPlayCascade(bUC_DispLibDBC_PlayCascade))
				{
					DBCPlayCascadeInfo dBCPlayCascadeInfo = new DBCPlayCascadeInfo();
					dBCPlayCascadeInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_PlayCascade, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID, DBCTransform);
					if (!(bUC_DispLibDBC_PlayCascade.Delay <= 0.001f) || DoPlayCascade(dBCPlayCascadeInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayCascadeInfo, Queue.PlayCascadeCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayNiagara.Count > 0)
		{
			uint uniqueID2 = DBCDataAsset.GetUniqueID();
			for (int j = 0; j < DBCDataAsset.PlayNiagara.Count; j++)
			{
				BUC_DispLibDBC_PlayNiagara bUC_DispLibDBC_PlayNiagara = DBCDataAsset.PlayNiagara[j];
				if (ValidateDBCPlayNiagara(bUC_DispLibDBC_PlayNiagara))
				{
					DBCPlayNiagaraInfo dBCPlayNiagaraInfo = new DBCPlayNiagaraInfo();
					dBCPlayNiagaraInfo.DBCInfoInit(curTime, IdentityID, j, uniqueID2, SourceDispOwnerComp, bUC_DispLibDBC_PlayNiagara, AnimNotifyUniqueID, MontageUniqueID, DBCTransform, CallbackParams);
					if (!(curTime >= dBCPlayNiagaraInfo.PlayAtTime) || DoPlayNiagara(dBCPlayNiagaraInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayNiagaraInfo, Queue.PlayNiagaraCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayAdvanceNiagara.Count > 0)
		{
			uint uniqueID3 = DBCDataAsset.GetUniqueID();
			for (int k = 0; k < DBCDataAsset.PlayAdvanceNiagara.Count; k++)
			{
				BUC_DispLibDBC_PlayAdvanceNiagara bUC_DispLibDBC_PlayAdvanceNiagara = DBCDataAsset.PlayAdvanceNiagara[k];
				if (ValidateDBCPlayAdvanceNiagara(bUC_DispLibDBC_PlayAdvanceNiagara))
				{
					DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = new DBCPlayAdvanceNiagaraInfo();
					dBCPlayAdvanceNiagaraInfo.DBCInfoInit(curTime, IdentityID, k, uniqueID3, SourceDispOwnerComp, bUC_DispLibDBC_PlayAdvanceNiagara, MinorDispOwnerComp, MinorPosWSOnSpawn, AnimNotifyUniqueID, MontageUniqueID, DBCTransform, default(DBCSetCallbackParams), GlobalData.CMDOverride_EnableDBCMergeNiagara);
					if (!(curTime >= dBCPlayAdvanceNiagaraInfo.PlayAtTime) || DoPlayAdvanceNiagara(dBCPlayAdvanceNiagaraInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayAdvanceNiagaraInfo, Queue.PlayAdvanceNiagaraCacheQueue);
						AdvanceNiagaraUpdate(dBCPlayAdvanceNiagaraInfo, curTime);
					}
				}
			}
		}
		if (DBCDataAsset.PlayArtFresnel.Count > 0)
		{
			for (int l = 0; l < DBCDataAsset.PlayArtFresnel.Count; l++)
			{
				BUC_DispLibDBC_PlayArtFresnel bUC_DispLibDBC_PlayArtFresnel = DBCDataAsset.PlayArtFresnel[l];
				if (ValidateDBCPlayArtFresnel(bUC_DispLibDBC_PlayArtFresnel))
				{
					DBCPlayArtFresnelInfo info = new DBCPlayArtFresnelInfo(curTime, IdentityID, bUC_DispLibDBC_PlayArtFresnel, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
					if (!(bUC_DispLibDBC_PlayArtFresnel.Delay <= 0.001f) || DoPlayArtFresnel(info))
					{
						Queue.AddItem2CacheQueue(uniqueID, info, Queue.PlayArtFresnelCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.SpawnSimpleActor.Count > 0)
		{
			for (int m = 0; m < DBCDataAsset.SpawnSimpleActor.Count; m++)
			{
				BUC_DispLibDBC_SpawnSimpleActor bUC_DispLibDBC_SpawnSimpleActor = DBCDataAsset.SpawnSimpleActor[m];
				if (ValidateDBCSpawnSimpleActor(bUC_DispLibDBC_SpawnSimpleActor))
				{
					DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = new DBCSpawnSimpleActorInfo();
					dBCSpawnSimpleActorInfo.DBCInfoInit(curTime, IdentityID, MinorDispOwnerComp, MinorPosWSOnSpawn, bUC_DispLibDBC_SpawnSimpleActor, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID, CallbackParams, DBCTransform);
					if (!(bUC_DispLibDBC_SpawnSimpleActor.Delay <= 0.001f) || DoSpawnSimpleActor(dBCSpawnSimpleActorInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCSpawnSimpleActorInfo, Queue.SpawnSimpleActorCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayCameraShake.Count > 0)
		{
			for (int n = 0; n < DBCDataAsset.PlayCameraShake.Count; n++)
			{
				BUC_DispLibDBC_PlayCameraShake bUC_DispLibDBC_PlayCameraShake = DBCDataAsset.PlayCameraShake[n];
				if (ValidateDBCPlayCameraShake(bUC_DispLibDBC_PlayCameraShake))
				{
					DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = new DBCPlayCameraShakeInfo();
					if (dBCPlayCameraShakeInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_PlayCameraShake, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(bUC_DispLibDBC_PlayCameraShake.Delay <= 0.001f) || DoPlayCameraShake(dBCPlayCameraShakeInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayCameraShakeInfo, Queue.PlayCameraShakeCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayCustomCameraShake.Count > 0)
		{
			for (int num = 0; num < DBCDataAsset.PlayCustomCameraShake.Count; num++)
			{
				BUC_DispLibDBC_PlayCustomCameraShake bUC_DispLibDBC_PlayCustomCameraShake = DBCDataAsset.PlayCustomCameraShake[num];
				if (ValidateDBCPlayCustomCameraShake(bUC_DispLibDBC_PlayCustomCameraShake))
				{
					DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = new DBCPlayCustomCameraShakeInfo();
					if (dBCPlayCustomCameraShakeInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_PlayCustomCameraShake, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(bUC_DispLibDBC_PlayCustomCameraShake.Delay <= 0.001f) || DoPlayCustomCameraShake(dBCPlayCustomCameraShakeInfo)))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCPlayCustomCameraShakeInfo, Queue.PlayCustomCameraShakeCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.PlayAudio.Count > 0)
		{
			for (int num2 = 0; num2 < DBCDataAsset.PlayAudio.Count; num2++)
			{
				BUC_DispLibDBC_PlayAudio sourceRequest = DBCDataAsset.PlayAudio[num2];
				DBCPlayAudioInfo dBCPlayAudioInfo = new DBCPlayAudioInfo();
				dBCPlayAudioInfo.DBCInfoInit(IdentityID, curTime, sourceRequest, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
				if (!(curTime >= dBCPlayAudioInfo.PlayAtTime) || DoPlayAudio(dBCPlayAudioInfo))
				{
					Queue.AddItem2CacheQueue(uniqueID, dBCPlayAudioInfo, Queue.PlayAudioCacheQueue);
				}
			}
		}
		if (DBCDataAsset.WEFMWind.Count > 0)
		{
			for (int num3 = 0; num3 < DBCDataAsset.WEFMWind.Count; num3++)
			{
				BUC_DispLibDBC_WEFMWind bUC_DispLibDBC_WEFMWind = DBCDataAsset.WEFMWind[num3];
				if (ValidateDBCWEFMWind(bUC_DispLibDBC_WEFMWind))
				{
					DBCWEFMWindEventInfo dBCWEFMWindEventInfo = new DBCWEFMWindEventInfo();
					dBCWEFMWindEventInfo.DBCInfoInit(IdentityID, curTime, bUC_DispLibDBC_WEFMWind, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
					Queue.AddItem2CacheQueue(uniqueID, dBCWEFMWindEventInfo, Queue.WEFMWindEventCacheQueue);
				}
			}
		}
		if (DBCDataAsset.ScenePhysicalInteractor.Count > 0)
		{
			for (int num4 = 0; num4 < DBCDataAsset.ScenePhysicalInteractor.Count; num4++)
			{
				BUC_DispLibDBC_ScenePhysicalInteractor bUC_DispLibDBC_ScenePhysicalInteractor = DBCDataAsset.ScenePhysicalInteractor[num4];
				if (!ValidateDBCScenePhysicalInteractor(bUC_DispLibDBC_ScenePhysicalInteractor))
				{
					continue;
				}
				if (bUC_DispLibDBC_ScenePhysicalInteractor.Delay <= 0.001f)
				{
					if (DoSPI(SourceDispOwnerComp, bUC_DispLibDBC_ScenePhysicalInteractor))
					{
					}
				}
				else
				{
					Queue.AddItem2CacheQueue(uniqueID, new DBCScenePhysicalInteractorInfo(curTime, bUC_DispLibDBC_ScenePhysicalInteractor, SourceDispOwnerComp), Queue.PlaySPICacheQueue);
				}
			}
		}
		if (DBCDataAsset.ChangeMaterial.Count > 0)
		{
			for (int num5 = 0; num5 < DBCDataAsset.ChangeMaterial.Count; num5++)
			{
				BUC_DispLibDBC_ChangeMaterial bUC_DispLibDBC_ChangeMaterial = DBCDataAsset.ChangeMaterial[num5];
				if (ValidateDBCChangeMaterial(bUC_DispLibDBC_ChangeMaterial))
				{
					DBCChangeMaterialInfo dBCChangeMaterialInfo = new DBCChangeMaterialInfo();
					dBCChangeMaterialInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_ChangeMaterial, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
					if (!(bUC_DispLibDBC_ChangeMaterial.Delay <= 0.001f) || DoChangeMaterial(dBCChangeMaterialInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCChangeMaterialInfo, Queue.ChangeMaterialCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyMaterial.Count > 0)
		{
			for (int num6 = 0; num6 < DBCDataAsset.ModifyMaterial.Count; num6++)
			{
				BUC_DispLibDBC_ModifyMaterial bUC_DispLibDBC_ModifyMaterial = DBCDataAsset.ModifyMaterial[num6];
				if (!ValidateDBCModifyMaterial(bUC_DispLibDBC_ModifyMaterial))
				{
					continue;
				}
				BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(SourceDispOwnerComp.GetOwner());
				if (bUS_DispLibEventCollection != null)
				{
					DBCModifyMaterialInfo dBCModifyMaterialInfo = new DBCModifyMaterialInfo();
					dBCModifyMaterialInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_ModifyMaterial, SourceDispOwnerComp, bUS_DispLibEventCollection, Queue.ModMatCSharpObjectPool, AnimNotifyUniqueID, MontageUniqueID);
					if (!(bUC_DispLibDBC_ModifyMaterial.Delay <= 0.001f) || DoModifyMaterial(dBCModifyMaterialInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyMaterialInfo, Queue.ModifyMaterialCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyNiagaraParams.Count > 0)
		{
			for (int num7 = 0; num7 < DBCDataAsset.ModifyNiagaraParams.Count; num7++)
			{
				BUC_DispLibDBC_ModifyNiagaraParams bUC_DispLibDBC_ModifyNiagaraParams = DBCDataAsset.ModifyNiagaraParams[num7];
				if (ValidateDBCModifyNiagaraParams(bUC_DispLibDBC_ModifyNiagaraParams))
				{
					DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = new DBCModifyNiagaraParamsInfo();
					dBCModifyNiagaraParamsInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_ModifyNiagaraParams, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
					if (!(bUC_DispLibDBC_ModifyNiagaraParams.Delay <= 0.001f) || DoModifyNiagaraParams(dBCModifyNiagaraParamsInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyNiagaraParamsInfo, Queue.ModifyNiagaraParamsCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.ModifyMPCParams.Count > 0)
		{
			for (int num8 = 0; num8 < DBCDataAsset.ModifyMPCParams.Count; num8++)
			{
				BUC_DispLibDBC_ModifyMaterialParameterCollection bUC_DispLibDBC_ModifyMaterialParameterCollection = DBCDataAsset.ModifyMPCParams[num8];
				if (ValidateDBCModifyMPC(bUC_DispLibDBC_ModifyMaterialParameterCollection))
				{
					DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = new DBCModifyMaterialParameterCollectionInfo();
					dBCModifyMaterialParameterCollectionInfo.DBCInfoInit(curTime, IdentityID, bUC_DispLibDBC_ModifyMaterialParameterCollection, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID);
					if (!(bUC_DispLibDBC_ModifyMaterialParameterCollection.Delay <= 0.001f) || DoModifyMPC(dBCModifyMaterialParameterCollectionInfo))
					{
						Queue.AddItem2CacheQueue(uniqueID, dBCModifyMaterialParameterCollectionInfo, Queue.ModifyMPCCacheQueue);
					}
				}
			}
		}
		if (DBCDataAsset.CustomEvents.Count <= 0)
		{
			return;
		}
		for (int num9 = 0; num9 < DBCDataAsset.CustomEvents.Count; num9++)
		{
			BUC_DispLibDBC_CustomEvent bUC_DispLibDBC_CustomEvent = DBCDataAsset.CustomEvents[num9];
			if (!ValidateDBCCustomEvent(bUC_DispLibDBC_CustomEvent))
			{
				continue;
			}
			DBCCustomEventInfo dBCCustomEventInfo = new DBCCustomEventInfo();
			dBCCustomEventInfo.DBCInfoInit(curTime, IdentityID, Queue.RequestNewCustomEventID(), bUC_DispLibDBC_CustomEvent, SourceDispOwnerComp, MinorDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID, DBCTransform);
			switch (dBCCustomEventInfo.RealTriggerMode)
			{
			case DispLibDBCCustomEventTriggerMode.Standard:
				if (bUC_DispLibDBC_CustomEvent.DelayTime <= 0.001f && !DoCustomEvent(dBCCustomEventInfo))
				{
					continue;
				}
				break;
			case DispLibDBCCustomEventTriggerMode.Immediate:
				if (!DoCustomEvent(dBCCustomEventInfo))
				{
					continue;
				}
				break;
			}
			Queue.AddItem2CacheQueue(uniqueID, dBCCustomEventInfo, Queue.CustomEventsCacheQueue);
		}
	}

	private void AdvanceNiagaraResolveConstraintMode(DBCPlayAdvanceNiagaraInfo Info, float CurTime, float DeltaTime)
	{
		if (Info.IS_MERGED_REQUEST || Info.AttachConstraintMode == DispLibAttachConstraintMode.Fixed)
		{
			return;
		}
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return;
		}
		USceneComponent attachParent = uNiagaraComponent.GetAttachParent();
		if (attachParent.IsNullOrDestroyed())
		{
			return;
		}
		if (Info.AttachConstraintMode == DispLibAttachConstraintMode.FixedTime && CurTime - Info.PlayAtTime >= Info.AttachConstraintValue.X)
		{
			uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
			Info.isAttach_RealAttach = false;
			return;
		}
		if (Info.AttachConstraintMode == DispLibAttachConstraintMode.RootVelocityThreshold && attachParent.GetComponentVelocity().SizeSquared() >= (double)Info.AttachConstraintValue.X)
		{
			uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
			Info.isAttach_RealAttach = false;
			return;
		}
		DeltaTime = Math.Max(DeltaTime, 1E-06f);
		FVector fVector = BGUFuncLibComponentCS.BGUGetSocketLocation(attachParent, ref Info.RealAttachedTargetSocketName);
		FRotator fRotator = BGUFuncLibComponentCS.BGUGetSocketRotation(attachParent, ref Info.RealAttachedTargetSocketName);
		double num = ((fVector - Info.LastTickAttachSocketLocation) / DeltaTime).SizeSquared();
		float num2 = Math.Abs(fRotator.Pitch - Info.AttachSocketRotOnAttach.Pitch);
		float num3 = Math.Abs(fRotator.Yaw - Info.AttachSocketRotOnAttach.Yaw);
		float num4 = Math.Abs(fRotator.Roll - Info.AttachSocketRotOnAttach.Roll);
		Info.AttachSocketDistanceACC += (float)(fVector - Info.LastTickAttachSocketLocation).SizeSquared();
		switch (Info.AttachConstraintMode)
		{
		case DispLibAttachConstraintMode.AttachedSocketVelocityThreshold:
			if (num >= (double)Info.AttachConstraintValue.X)
			{
				uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
				Info.isAttach_RealAttach = false;
			}
			break;
		case DispLibAttachConstraintMode.AttachedSocketVelocityAndTorsionThreshold:
			if (num >= (double)Info.AttachConstraintValue.X || num2 >= Info.AttachConstraintValue.Y || num3 >= Info.AttachConstraintValue.Y || num4 >= Info.AttachConstraintValue.Y)
			{
				uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
				Info.isAttach_RealAttach = false;
			}
			break;
		case DispLibAttachConstraintMode.AttachedSocketDistanceACCAndTorsionThreshold:
			if (Info.AttachSocketDistanceACC >= Info.AttachConstraintValue.X || num2 >= Info.AttachConstraintValue.Y || num3 >= Info.AttachConstraintValue.Y || num4 >= Info.AttachConstraintValue.Y)
			{
				uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
				Info.isAttach_RealAttach = false;
			}
			break;
		}
		Info.LastTickAttachSocketLocation = fVector;
	}

	private void AdvanceNiagaraUpdate(DBCPlayAdvanceNiagaraInfo Info, float CurTime)
	{
		if (Info.IS_MERGED_REQUEST)
		{
			return;
		}
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return;
		}
		bool flag = false;
		if (Info.MinorDispOwnerComp.IsNullOrDestroyed())
		{
			flag = true;
		}
		switch (Info.DispLogicMode)
		{
		case DispLibAdvanceNiagaraDispLogicMode.StandardInteraction:
			if (flag)
			{
				uNiagaraComponent.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterDeath, flag);
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSLastFrame);
			}
			else if (Info.AttachedEmitter)
			{
				FVector fVector = Info.MinorDispOwnerComp.GetSocketTransform(Info.RealAttachedEmitterSocketName).TransformPosition(Info.AttachedEmitterLocationOffset);
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, fVector);
				Info.MinorPosWSLastFrame = fVector;
			}
			else
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
				Info.MinorPosWSLastFrame = Info.MinorPosWSOnSpawn;
			}
			break;
		case DispLibAdvanceNiagaraDispLogicMode.PlanePostProcess:
			AdvanceNiagara_UpdatePlanePP(uNiagaraComponent, Info.isAttach_SourceSetting);
			break;
		}
		if (Info.IsPause)
		{
			return;
		}
		float gameAge = Info.GameAge;
		if (Info.SetCurveScalarParam != null)
		{
			for (int i = 0; i < Info.SetCurveScalarParam.Count; i++)
			{
				if (!Info.SetCurveScalarParam[i].Value.IsNullOrDestroyed())
				{
					uNiagaraComponent.SetVariableFloat(Info.SetCurveScalarParam[i].ParamName, Info.SetCurveScalarParam[i].Value.GetFloatValue(FMath.Clamp(gameAge / Info.SetCurveScalarParam[i].Time, 0f, 1f)));
				}
			}
		}
		if (Info.SetCurveV3Param != null)
		{
			for (int j = 0; j < Info.SetCurveV3Param.Count; j++)
			{
				if (!Info.SetCurveV3Param[j].Value.IsNullOrDestroyed())
				{
					uNiagaraComponent.SetVariableVec3(Info.SetCurveV3Param[j].ParamName, Info.SetCurveV3Param[j].Value.GetVectorValue(FMath.Clamp(gameAge / Info.SetCurveScalarParam[j].Time, 0f, 1f)));
				}
			}
		}
		if (Info.SetCurveLColorParam != null)
		{
			for (int k = 0; k < Info.SetCurveLColorParam.Count; k++)
			{
				if (!Info.SetCurveLColorParam[k].Value.IsNullOrDestroyed())
				{
					uNiagaraComponent.SetVariableLinearColor(Info.SetCurveLColorParam[k].ParamName, Info.SetCurveLColorParam[k].Value.GetLinearColorValue(FMath.Clamp(gameAge / Info.SetCurveScalarParam[k].Time, 0f, 1f)));
				}
			}
		}
		if (Info.OverTickCallback != null)
		{
			Info.OverTickCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent, Info.MetaString));
		}
	}

	private void AdvanceNiagara_UpdatePlanePP(UNiagaraComponent NC, bool AttachCurCharacter)
	{
		if (NC == null)
		{
			return;
		}
		APlayerCameraManager aPlayerCameraManager = DispLibCameraData.PlayerCameraManager.Get();
		APlayerController aPlayerController = DispLibCameraData.PlayerController.Get();
		if (!(aPlayerCameraManager != null))
		{
			return;
		}
		FHitResult SweepHitResult = default(FHitResult);
		bool flag = false;
		FVector fVector = default(FVector);
		FRotator fRotator = default(FRotator);
		float num = 0f;
		if (AttachCurCharacter)
		{
			AActor viewTarget = aPlayerController.GetViewTarget();
			if (viewTarget != null)
			{
				BUC_DispLibDBCBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_DispLibDBCBaseData>(viewTarget);
				if (readOnlyData != null)
				{
					USceneComponent dispOwnerComp = readOnlyData.DispOwnerComp;
					if (dispOwnerComp != null)
					{
						fVector = dispOwnerComp.GetWorldLocation();
						fRotator = dispOwnerComp.GetWorldRotation();
						num = MathLib.Dist(aPlayerCameraManager.GetCameraLocation(), fVector);
						flag = true;
					}
				}
			}
		}
		if (!flag)
		{
			fRotator = aPlayerCameraManager.GetCameraRotation();
			num = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCPlanePPOffset;
			fVector = aPlayerCameraManager.GetCameraLocation() + fRotator.GetForwardVector() * num;
		}
		NC.SetWorldLocationAndRotation(fVector, fRotator, bSweep: false, out SweepHitResult, bTeleport: false);
		float num2 = FMath.Abs(2f * num * FMath.Tan(FMath.DegreesToRadians(aPlayerCameraManager.GetFOVAngle() / 2f)));
		float num3 = (DispLibCameraData.CameraComp.IsValid() ? DispLibCameraData.CameraComp.Get().AspectRatio : aPlayerCameraManager.DefaultAspectRatio);
		NC.SetVariableVec2(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxPlanePPSize, new FVector2D(num2, num2 / num3));
	}

	private void ChangeMaterialUpdate(DBCChangeMaterialInfo Info, float CurTime)
	{
		if (Info.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Info.SourceDispOwnerComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		if (!Info.OnEndDispStage)
		{
			float num = CurTime - Info.PlayAtTime;
			foreach (BUC_DispLibUtil_NameAndScalarCurve item in Info.SetCurveScalarParam)
			{
				if (!item.Value.IsNullOrDestroyed())
				{
					bUS_DispLibEventCollection.Evt_SetUnitMatsScalarParam(Info.FilterMode, item.ParamName, item.Value.GetFloatValue(num / item.Time), Info.PlayAtTime, Info.Priority);
				}
			}
			foreach (BUC_DispLibUtil_NameAndLColorCurve item2 in Info.SetCurveLColorParam)
			{
				if (!(item2.Value == null))
				{
					bUS_DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam(Info.FilterMode, item2.ParamName, item2.Value.GetLinearColorValue(num / item2.Time), Info.PlayAtTime, Info.Priority);
				}
			}
			{
				foreach (BUC_DispLibUtil_NameAndVectorCurve item3 in Info.SetCurveV3Param)
				{
					if (!(item3.Value == null))
					{
						bUS_DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam(Info.FilterMode, item3.ParamName, new FLinearColor(item3.Value.GetVectorValue(num / item3.Time)), Info.PlayAtTime, Info.Priority);
					}
				}
				return;
			}
		}
		float num2 = CurTime - Info.EndStageStartTime;
		for (int i = 0; i < Info.EndStage_SetPCurveScalarParam.Count; i++)
		{
			BUC_DispLibUtil_PCurve_NameAndScalar bUC_DispLibUtil_PCurve_NameAndScalar = Info.EndStage_SetPCurveScalarParam[i];
			bUS_DispLibEventCollection.Evt_SetUnitMatsScalarParam(Info.FilterMode, bUC_DispLibUtil_PCurve_NameAndScalar.ParamName, FMath.Lerp(bUC_DispLibUtil_PCurve_NameAndScalar.ValueOnBreak, bUC_DispLibUtil_PCurve_NameAndScalar.Value, num2 / bUC_DispLibUtil_PCurve_NameAndScalar.TimeStage.X), Info.PlayAtTime, Info.Priority);
		}
		for (int j = 0; j < Info.EndStage_SetPCurveLColorParam.Count; j++)
		{
			BUC_DispLibUtil_PCurve_NameAndLColor bUC_DispLibUtil_PCurve_NameAndLColor = Info.EndStage_SetPCurveLColorParam[j];
			bUS_DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam(Info.FilterMode, bUC_DispLibUtil_PCurve_NameAndLColor.ParamName, FMath.Lerp(bUC_DispLibUtil_PCurve_NameAndLColor.ValueOnBreak, bUC_DispLibUtil_PCurve_NameAndLColor.Value, num2 / bUC_DispLibUtil_PCurve_NameAndLColor.TimeStage.X), Info.PlayAtTime, Info.Priority);
		}
	}

	private void AudioUpdate(DBCPlayAudioInfo Info, float DeltaTime)
	{
		if (!Info.CheckValid() || Info.RTPC == null)
		{
			return;
		}
		float velocityLength = 0f;
		if (Info.NeedCalRootBoneVelocity && GetCurTime() - Info.PlayAtTime >= 0.001f)
		{
			velocityLength = BGU_DispLibDataUtil.GetDispRootBoneVelocity(Info.SourceDispOwnerComp).Size();
		}
		bool ComponentCreated;
		UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(Info.SourceDispOwnerComp, out ComponentCreated, Info.SourceRequest.SocketName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
		if (!akComponent.IsNullOrDestroyed())
		{
			for (int i = 0; i < Info.RTPC.Count; i++)
			{
				DBCAdvProcessScalarParam dBCAdvProcessScalarParam = Info.RTPC[i];
				dBCAdvProcessScalarParam.UpdateValue(DeltaTime, velocityLength);
				akComponent.SetRTPCValue(null, dBCAdvProcessScalarParam.CurFrameValue, 0, dBCAdvProcessScalarParam.ParamName.PlainName);
			}
		}
	}

	private void ModifyNiagaraParamsUpdate(DBCModifyNiagaraParamsInfo Info, float DeltaTime)
	{
		if (!Info.CheckValid() || BUS_DispLibEventCollection.Get(Info.SourceDispOwnerComp.GetOwner()) == null)
		{
			return;
		}
		bool isPause = Info.IsPause;
		FVector velocity = FVector.ZeroVector;
		if (Info.NeedCalRootBoneVelocity && GetCurTime() - Info.PlayAtTime >= 0.001f)
		{
			velocity = BGU_DispLibDataUtil.GetDispRootBoneVelocity(Info.SourceDispOwnerComp);
			velocity.Size();
		}
		foreach (DBCFXInfoBase item in Interior_GetAllMatachedNiagaraInfo(Info.SourceDispOwnerComp, Info.MeshCompFilterInfo, Info.NiagaraCompFilterInfo))
		{
			UNiagaraComponent uNiagaraComponent = item.NiagaraComponent.Get();
			if (uNiagaraComponent.IsNullOrDestroyed())
			{
				continue;
			}
			for (int i = 0; i < Info.BoolParamsInfo.Count; i++)
			{
				ModifyNiagaraParamsBoolParamInfo modifyNiagaraParamsBoolParamInfo = Info.BoolParamsInfo[i];
				if (!isPause)
				{
					modifyNiagaraParamsBoolParamInfo.UpdateValue(DeltaTime);
				}
				if (modifyNiagaraParamsBoolParamInfo.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableBool(modifyNiagaraParamsBoolParamInfo.ParamName, modifyNiagaraParamsBoolParamInfo.CurFrameValue);
				}
			}
			for (int j = 0; j < Info.FloatParamsInfo.Count; j++)
			{
				ModifyNiagaraParamsFloatParamInfo modifyNiagaraParamsFloatParamInfo = Info.FloatParamsInfo[j];
				if (!isPause)
				{
					modifyNiagaraParamsFloatParamInfo.UpdateValue(DeltaTime, velocity);
				}
				if (modifyNiagaraParamsFloatParamInfo.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableFloat(modifyNiagaraParamsFloatParamInfo.ParamName, modifyNiagaraParamsFloatParamInfo.CurFrameValue);
				}
			}
			for (int k = 0; k < Info.Int32ParamsInfo.Count; k++)
			{
				ModifyNiagaraParamsFloatParamInfo modifyNiagaraParamsFloatParamInfo2 = Info.Int32ParamsInfo[k];
				if (!isPause)
				{
					modifyNiagaraParamsFloatParamInfo2.UpdateValue(DeltaTime, velocity);
				}
				if (modifyNiagaraParamsFloatParamInfo2.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableInt(modifyNiagaraParamsFloatParamInfo2.ParamName, (int)modifyNiagaraParamsFloatParamInfo2.CurFrameValue);
				}
			}
			for (int l = 0; l < Info.FVectorParamsInfo.Count; l++)
			{
				ModifyNiagaraParamsFVectorParamInfo modifyNiagaraParamsFVectorParamInfo = Info.FVectorParamsInfo[l];
				if (!isPause)
				{
					modifyNiagaraParamsFVectorParamInfo.UpdateValue(DeltaTime, velocity);
				}
				if (modifyNiagaraParamsFVectorParamInfo.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableVec3(modifyNiagaraParamsFVectorParamInfo.ParamName, modifyNiagaraParamsFVectorParamInfo.CurFrameValue);
				}
			}
			for (int m = 0; m < Info.FLinearColorParamsInfo.Count; m++)
			{
				ModifyNiagaraParamsFLinearColorParamInfo modifyNiagaraParamsFLinearColorParamInfo = Info.FLinearColorParamsInfo[m];
				if (!isPause)
				{
					modifyNiagaraParamsFLinearColorParamInfo.UpdateValue(DeltaTime, velocity);
				}
				if (modifyNiagaraParamsFLinearColorParamInfo.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableLinearColor(modifyNiagaraParamsFLinearColorParamInfo.ParamName, modifyNiagaraParamsFLinearColorParamInfo.CurFrameValue);
				}
			}
			for (int n = 0; n < Info.FLinearColorParamsInfo.Count; n++)
			{
				ModifyNiagaraParamsFLinearColorParamInfo modifyNiagaraParamsFLinearColorParamInfo2 = Info.FLinearColorParamsInfo[n];
				if (!isPause)
				{
					modifyNiagaraParamsFLinearColorParamInfo2.UpdateValue(DeltaTime, velocity);
				}
				if (modifyNiagaraParamsFLinearColorParamInfo2.SetEveryFrame)
				{
					uNiagaraComponent.SetVariableLinearColor(modifyNiagaraParamsFLinearColorParamInfo2.ParamName, modifyNiagaraParamsFLinearColorParamInfo2.CurFrameValue);
				}
			}
			if (!Info.HasAnyEveryFrameSetArrayParam)
			{
				continue;
			}
			for (int num = 0; num < Info.SourceRequest.SetFloatArrayParam.Count; num++)
			{
				BUC_DispLibUtil_NameAndFloatArray bUC_DispLibUtil_NameAndFloatArray = Info.SourceRequest.SetFloatArrayParam[num];
				if (bUC_DispLibUtil_NameAndFloatArray.SetEveryFrame)
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloat(uNiagaraComponent, bUC_DispLibUtil_NameAndFloatArray.ParamName, bUC_DispLibUtil_NameAndFloatArray.FloatArray.ToList());
				}
			}
			for (int num2 = 0; num2 < Info.SourceRequest.SetInt32ArrayParam.Count; num2++)
			{
				BUC_DispLibUtil_NameAndInt32Array bUC_DispLibUtil_NameAndInt32Array = Info.SourceRequest.SetInt32ArrayParam[num2];
				if (bUC_DispLibUtil_NameAndInt32Array.SetEveryFrame)
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(uNiagaraComponent, bUC_DispLibUtil_NameAndInt32Array.ParamName, bUC_DispLibUtil_NameAndInt32Array.Int32Array.ToList());
				}
			}
			for (int num3 = 0; num3 < Info.SourceRequest.SetFVectorArrayParam.Count; num3++)
			{
				BUC_DispLibUtil_NameAndFVectorArray bUC_DispLibUtil_NameAndFVectorArray = Info.SourceRequest.SetFVectorArrayParam[num3];
				if (bUC_DispLibUtil_NameAndFVectorArray.SetEveryFrame)
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(uNiagaraComponent, bUC_DispLibUtil_NameAndFVectorArray.ParamName, bUC_DispLibUtil_NameAndFVectorArray.FVectorArray.ToList());
				}
			}
		}
	}

	private void ModifyMPCUpdate(DBCModifyMaterialParameterCollectionInfo Info, float DeltaTime)
	{
		if (Info.CheckValid())
		{
			UMaterialParameterCollection mPCInstance = GlobalData.LoadAndGetMPCInstance(Info.SourceDispOwnerComp.GetOwner(), Info.MPCAssetPath);
			float velocityLength = 0f;
			if (Info.NeedCalRootBoneVelocity && GetCurTime() - Info.PlayAtTime >= 0.001f)
			{
				velocityLength = BGU_DispLibDataUtil.GetDispRootBoneVelocity(Info.SourceDispOwnerComp).Size();
			}
			for (int i = 0; i < Info.ScalarParams.Count; i++)
			{
				DBCAdvProcessScalarParam dBCAdvProcessScalarParam = Info.ScalarParams[i];
				dBCAdvProcessScalarParam.UpdateValue(DeltaTime, velocityLength);
				SetMPCScalarParam_Immed(mPCInstance, Info.MPCAssetPath, dBCAdvProcessScalarParam.ParamName, dBCAdvProcessScalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			}
			for (int j = 0; j < Info.FLinearColorParams.Count; j++)
			{
				DBCAdvProcessFLinearColorParam dBCAdvProcessFLinearColorParam = Info.FLinearColorParams[j];
				dBCAdvProcessFLinearColorParam.UpdateValue(DeltaTime, velocityLength);
				SetMPCColorParam_Immed(mPCInstance, Info.MPCAssetPath, dBCAdvProcessFLinearColorParam.ParamName, dBCAdvProcessFLinearColorParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			}
			for (int k = 0; k < Info.PCurveScalarParams.Count; k++)
			{
				DBCPCurveScalarParam dBCPCurveScalarParam = Info.PCurveScalarParams[k];
				dBCPCurveScalarParam.UpdateValue(DeltaTime, velocityLength);
				SetMPCScalarParam_Immed(mPCInstance, Info.MPCAssetPath, dBCPCurveScalarParam.ParamName, dBCPCurveScalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			}
			for (int l = 0; l < Info.PCurveFLinearColorParams.Count; l++)
			{
				DBCAdvProcessFLinearColorParam dBCAdvProcessFLinearColorParam2 = Info.FLinearColorParams[l];
				dBCAdvProcessFLinearColorParam2.UpdateValue(DeltaTime, velocityLength);
				SetMPCColorParam_Immed(mPCInstance, Info.MPCAssetPath, dBCAdvProcessFLinearColorParam2.ParamName, dBCAdvProcessFLinearColorParam2.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			}
		}
	}

	private void ModifyMaterialUpdate(DBCModifyMaterialInfo Info, float DeltaTime, bool isRealTick)
	{
		if (!Info.CheckValid())
		{
			return;
		}
		BUS_DispLibEventCollection eventCollection = Info.EventCollection;
		if (eventCollection == null)
		{
			return;
		}
		float velocityLength = 0f;
		if (Info.NeedCalRootBoneVelocity && GetCurTime() - Info.PlayAtTime >= 0.001f)
		{
			velocityLength = BGU_DispLibDataUtil.GetDispRootBoneVelocity(Info.SourceDispOwnerComp).Size();
		}
		for (int num = Info.ScalarParams.Count - 1; num >= 0; num--)
		{
			DBCAdvProcessScalarMatLayerParam dBCAdvProcessScalarMatLayerParam = Info.ScalarParams[num];
			dBCAdvProcessScalarMatLayerParam.UpdateValue(DeltaTime, velocityLength, isRealTick);
			if (dBCAdvProcessScalarMatLayerParam.EventRealEnd)
			{
				eventCollection.Evt_ScalarParamOperationCounterRemove(Info.FilterMode, dBCAdvProcessScalarMatLayerParam.Association, dBCAdvProcessScalarMatLayerParam.LayerFunction, dBCAdvProcessScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName));
				eventCollection.Evt_ScalarParamResetPriority(Info.FilterMode, dBCAdvProcessScalarMatLayerParam.Association, dBCAdvProcessScalarMatLayerParam.LayerFunction, dBCAdvProcessScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				Info.ScalarParams.RemoveAt(num);
			}
			else if (isRealTick)
			{
				eventCollection.Evt_SetUnitMatsScalarParamByInfo_Immed(Info.FilterMode, dBCAdvProcessScalarMatLayerParam.Association, dBCAdvProcessScalarMatLayerParam.ParamName, dBCAdvProcessScalarMatLayerParam.LayerFunction, dBCAdvProcessScalarMatLayerParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			}
		}
		for (int num2 = Info.FLinearColorParams.Count - 1; num2 >= 0; num2--)
		{
			DBCAdvProcessFLinearColorMatLayerParam dBCAdvProcessFLinearColorMatLayerParam = Info.FLinearColorParams[num2];
			dBCAdvProcessFLinearColorMatLayerParam.UpdateValue(DeltaTime, velocityLength, isRealTick);
			if (dBCAdvProcessFLinearColorMatLayerParam.EventRealEnd)
			{
				eventCollection.Evt_ColorParamOperationCounterRemove(Info.FilterMode, dBCAdvProcessFLinearColorMatLayerParam.Association, dBCAdvProcessFLinearColorMatLayerParam.LayerFunction, dBCAdvProcessFLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName));
				eventCollection.Evt_ColorParamResetPriority(Info.FilterMode, dBCAdvProcessFLinearColorMatLayerParam.Association, dBCAdvProcessFLinearColorMatLayerParam.LayerFunction, dBCAdvProcessFLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				Info.FLinearColorParams.RemoveAt(num2);
			}
			else if (isRealTick)
			{
				eventCollection.Evt_SetUnitMatsFLinearColorParamByInfo_Immed(Info.FilterMode, dBCAdvProcessFLinearColorMatLayerParam.Association, dBCAdvProcessFLinearColorMatLayerParam.ParamName, dBCAdvProcessFLinearColorMatLayerParam.LayerFunction, dBCAdvProcessFLinearColorMatLayerParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			}
		}
		for (int num3 = Info.PCurveScalarParams.Count - 1; num3 >= 0; num3--)
		{
			DBCPCurveScalarMatLayerParam dBCPCurveScalarMatLayerParam = Info.PCurveScalarParams[num3];
			dBCPCurveScalarMatLayerParam.UpdateValue(DeltaTime, velocityLength);
			if (dBCPCurveScalarMatLayerParam.EventRealEnd)
			{
				eventCollection.Evt_ScalarParamOperationCounterRemove(Info.FilterMode, dBCPCurveScalarMatLayerParam.Association, dBCPCurveScalarMatLayerParam.LayerFunction, dBCPCurveScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName));
				eventCollection.Evt_ScalarParamResetPriority(Info.FilterMode, dBCPCurveScalarMatLayerParam.Association, dBCPCurveScalarMatLayerParam.LayerFunction, dBCPCurveScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				Info.PCurveScalarParams.RemoveAt(num3);
			}
			else if (isRealTick)
			{
				eventCollection.Evt_SetUnitMatsScalarParamByInfo_Immed(Info.FilterMode, dBCPCurveScalarMatLayerParam.Association, dBCPCurveScalarMatLayerParam.ParamName, dBCPCurveScalarMatLayerParam.LayerFunction, dBCPCurveScalarMatLayerParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			}
		}
		for (int num4 = Info.PCurveFLinearColorParams.Count - 1; num4 >= 0; num4--)
		{
			DBCPCurveLinearColorMatLayerParam dBCPCurveLinearColorMatLayerParam = Info.PCurveFLinearColorParams[num4];
			dBCPCurveLinearColorMatLayerParam.UpdateValue(DeltaTime, velocityLength);
			if (dBCPCurveLinearColorMatLayerParam.EventRealEnd)
			{
				eventCollection.Evt_ColorParamOperationCounterRemove(Info.FilterMode, dBCPCurveLinearColorMatLayerParam.Association, dBCPCurveLinearColorMatLayerParam.LayerFunction, dBCPCurveLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName));
				eventCollection.Evt_ColorParamResetPriority(Info.FilterMode, dBCPCurveLinearColorMatLayerParam.Association, dBCPCurveLinearColorMatLayerParam.LayerFunction, dBCPCurveLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				Info.PCurveFLinearColorParams.RemoveAt(num4);
			}
			else if (isRealTick)
			{
				eventCollection.Evt_SetUnitMatsFLinearColorParamByInfo_Immed(Info.FilterMode, dBCPCurveLinearColorMatLayerParam.Association, dBCPCurveLinearColorMatLayerParam.ParamName, dBCPCurveLinearColorMatLayerParam.LayerFunction, dBCPCurveLinearColorMatLayerParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			}
		}
		for (int num5 = Info.TextureParams.Count - 1; num5 >= 0; num5--)
		{
			DBCTextureMatLayerParam dBCTextureMatLayerParam = Info.TextureParams[num5];
			dBCTextureMatLayerParam.UpdateValue(DeltaTime, velocityLength);
			if (dBCTextureMatLayerParam.EventRealEnd)
			{
				eventCollection.Evt_TextureParamOperationCounterRemove(Info.FilterMode, dBCTextureMatLayerParam.Association, dBCTextureMatLayerParam.LayerFunction, dBCTextureMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName));
				eventCollection.Evt_TextureParamResetPriority(Info.FilterMode, dBCTextureMatLayerParam.Association, dBCTextureMatLayerParam.LayerFunction, dBCTextureMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				Info.TextureParams.RemoveAt(num5);
			}
		}
	}

	private void CameraShakeUpdate(DBCPlayCameraShakeInfo Info, float DeltaTime)
	{
		float num = 1f;
		if (Info.SourceRequest.CamShakeScaleByDistCurve != null)
		{
			APawn playerControllerControlledPawn = GetPlayerControllerControlledPawn();
			if (!playerControllerControlledPawn.IsNullOrDestroyed())
			{
				FVector actorLocation = playerControllerControlledPawn.GetActorLocation();
				FVector v = Info.SocketPosOnStart;
				if (Info.SourceRequest.AttachedTarget)
				{
					v = Info.SourceDispOwnerComp.GetSocketLocation(Info.SourceRequest.AttachedTargetSocketName);
				}
				float num2 = FVector.Dist(actorLocation, v);
				float maxDistance = Info.SourceRequest.MaxDistance;
				num = ((!(maxDistance <= 0.001f)) ? (num * Info.SourceRequest.CamShakeScaleByDistCurve.GetFloatValue(MathLib.Clamp(num2 / maxDistance, 0f, 1f))) : (num * Info.SourceRequest.CamShakeScaleByDistCurve.GetFloatValue(num2)));
			}
		}
		if (Info.CustomScaleCurve != null)
		{
			float length = 0f;
			if (!Info.SourceDispOwnerComp.IsNullOrDestroyed())
			{
				Info.SourceDispOwnerComp.GetOwner().GetVelocity().ToDirectionAndLength(out var _, out length);
			}
			Info.CustomScaleCurve.UpdateValue(DeltaTime, length);
			num *= Info.CustomScaleCurve.CurFrameValue;
		}
		num *= Info.ForceCameraShakeIntensityScale;
		Info.CameraShakeInst.ShakeScale = num;
	}

	private void CustomCameraShakeUpdate(DBCPlayCustomCameraShakeInfo Info, float DeltaTime)
	{
		float length = 0f;
		if (!Info.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			Info.SourceDispOwnerComp.GetOwner().GetVelocity().ToDirectionAndLength(out var _, out length);
		}
		if (Info.RO_PCurveDataArray != null)
		{
			for (int i = 0; i < 6; i++)
			{
				Info.RO_PCurveDataArray[i].UpdateValue(DeltaTime, length);
			}
			FROscillator rotOscillation = default(FROscillator);
			rotOscillation.Pitch.Amplitude = Info.RO_PCurveDataArray[0].CurFrameValue;
			rotOscillation.Yaw.Amplitude = Info.RO_PCurveDataArray[2].CurFrameValue;
			rotOscillation.Roll.Amplitude = Info.RO_PCurveDataArray[4].CurFrameValue;
			rotOscillation.Pitch.Frequency = Info.RO_PCurveDataArray[1].CurFrameValue;
			rotOscillation.Yaw.Frequency = Info.RO_PCurveDataArray[3].CurFrameValue;
			rotOscillation.Roll.Frequency = Info.RO_PCurveDataArray[5].CurFrameValue;
			rotOscillation.Pitch.Waveform = Info.RO_Noise;
			rotOscillation.Yaw.Waveform = Info.RO_Noise;
			rotOscillation.Roll.Waveform = Info.RO_Noise;
			Info.CameraShakeInst.RotOscillation = rotOscillation;
		}
		if (Info.LO_PCurveDataArray != null)
		{
			for (int j = 0; j < 6; j++)
			{
				Info.LO_PCurveDataArray[j].UpdateValue(DeltaTime, length);
			}
			FVOscillator locOscillation = default(FVOscillator);
			locOscillation.X.Amplitude = Info.LO_PCurveDataArray[0].CurFrameValue;
			locOscillation.Y.Amplitude = Info.LO_PCurveDataArray[2].CurFrameValue;
			locOscillation.Z.Amplitude = Info.LO_PCurveDataArray[4].CurFrameValue;
			locOscillation.X.Frequency = Info.LO_PCurveDataArray[1].CurFrameValue;
			locOscillation.Y.Frequency = Info.LO_PCurveDataArray[3].CurFrameValue;
			locOscillation.Z.Frequency = Info.LO_PCurveDataArray[5].CurFrameValue;
			locOscillation.X.Waveform = Info.LO_Noise;
			locOscillation.Y.Waveform = Info.LO_Noise;
			locOscillation.Z.Waveform = Info.LO_Noise;
			Info.CameraShakeInst.LocOscillation = locOscillation;
		}
		if (Info.FOV_PCurveDataArray != null)
		{
			for (int k = 0; k < 2; k++)
			{
				Info.FOV_PCurveDataArray[k].UpdateValue(DeltaTime, length);
			}
			FOscillator fOVOscillation = new FOscillator
			{
				Amplitude = Info.FOV_PCurveDataArray[0].CurFrameValue,
				Frequency = Info.FOV_PCurveDataArray[1].CurFrameValue,
				Waveform = Info.FOV_Noise
			};
			Info.CameraShakeInst.FOVOscillation = fOVOscillation;
		}
		float num = 1f;
		if (Info.SourceRequest.CamShakeScaleByDistCurve != null)
		{
			APawn playerControllerControlledPawn = GetPlayerControllerControlledPawn();
			if (!playerControllerControlledPawn.IsNullOrDestroyed())
			{
				FVector actorLocation = playerControllerControlledPawn.GetActorLocation();
				FVector v = Info.SocketPosOnStart;
				if (Info.SourceRequest.AttachedTarget)
				{
					v = Info.SourceDispOwnerComp.GetSocketLocation(Info.SourceRequest.AttachedTargetSocketName);
				}
				float num2 = FVector.Dist(actorLocation, v);
				float maxDistance = Info.SourceRequest.MaxDistance;
				num = ((!(maxDistance <= 0.001f)) ? (num * Info.SourceRequest.CamShakeScaleByDistCurve.GetFloatValue(MathLib.Clamp(num2 / maxDistance, 0f, 1f))) : (num * Info.SourceRequest.CamShakeScaleByDistCurve.GetFloatValue(num2)));
			}
		}
		Info.CameraShakeInst.ShakeScale = num;
	}

	private void RequestSetEffectsTransform(USceneComponent SourceDispOwnerComp, uint IdentityID, DBCTransformParam DBCTransform, bool OnlySetFX = false, bool ForceDetachAndSet = false)
	{
		if (!DBCTransform.IsValid())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayCascadeCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayCascadeInfo dBCPlayCascadeInfo = value[num];
				if (dBCPlayCascadeInfo.IdentityID == IdentityID && !dBCPlayCascadeInfo.CascadeComponent.IsNullOrDestroyed() && (ForceDetachAndSet || dBCPlayCascadeInfo.CascadeComponent.GetAttachSocketName() == default(FName)))
				{
					dBCPlayCascadeInfo.CascadeComponent.DetachFromParent(bMaintainWorldPosition: true);
					if (DBCTransform.TransformUseAll)
					{
						dBCPlayCascadeInfo.CascadeComponent.SetWorldTransform(DBCTransform.Transform, bSweep: false, out var _, bTeleport: true);
						dBCPlayCascadeInfo.CascadeComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayCascadeInfo.SourceRequest.Scale);
					}
					else
					{
						if (DBCTransform.UseLocation)
						{
							dBCPlayCascadeInfo.CascadeComponent.SetWorldLocation(DBCTransform.Transform.GetLocation(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseRotation)
						{
							dBCPlayCascadeInfo.CascadeComponent.SetWorldRotation(DBCTransform.Transform.Rotator(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseScale)
						{
							dBCPlayCascadeInfo.CascadeComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayCascadeInfo.SourceRequest.Scale);
						}
					}
				}
			}
		}
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value2[num2];
				UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !uNiagaraComponent.IsNullOrDestroyed() && (ForceDetachAndSet || uNiagaraComponent.GetAttachSocketName() == default(FName)))
				{
					uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
					if (DBCTransform.TransformUseAll)
					{
						uNiagaraComponent.SetWorldTransform(DBCTransform.Transform, bSweep: false, out var _, bTeleport: true);
						uNiagaraComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayNiagaraInfo.SourceRequest.Scale);
					}
					else
					{
						if (DBCTransform.UseLocation)
						{
							uNiagaraComponent.SetWorldLocation(DBCTransform.Transform.GetLocation(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseRotation)
						{
							uNiagaraComponent.SetWorldRotation(DBCTransform.Transform.Rotator(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseScale)
						{
							uNiagaraComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayNiagaraInfo.SourceRequest.Scale);
						}
					}
				}
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value3))
		{
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value3[num3];
				UNiagaraComponent uNiagaraComponent2 = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
				if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !uNiagaraComponent2.IsNullOrDestroyed() && (ForceDetachAndSet || uNiagaraComponent2.GetAttachSocketName() == default(FName)))
				{
					uNiagaraComponent2.DetachFromParent(bMaintainWorldPosition: true);
					if (DBCTransform.TransformUseAll)
					{
						uNiagaraComponent2.SetWorldTransform(DBCTransform.Transform, bSweep: false, out var _, bTeleport: true);
						uNiagaraComponent2.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayAdvanceNiagaraInfo.SourceRequest.Scale);
					}
					else
					{
						if (DBCTransform.UseLocation)
						{
							uNiagaraComponent2.SetWorldLocation(DBCTransform.Transform.GetLocation(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseRotation)
						{
							uNiagaraComponent2.SetWorldRotation(DBCTransform.Transform.Rotator(), bSweep: false, out var _, bTeleport: true);
						}
						if (DBCTransform.UseScale)
						{
							uNiagaraComponent2.SetWorldScale3D(DBCTransform.Transform.Scale3D * dBCPlayAdvanceNiagaraInfo.SourceRequest.Scale);
						}
					}
				}
			}
		}
		if (OnlySetFX || !Queue.SpawnSimpleActorCacheQueue.TryGetValue(uniqueID, out var value4))
		{
			return;
		}
		for (int num4 = value4.Count - 1; num4 >= 0; num4--)
		{
			DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = value4[num4];
			if (dBCSpawnSimpleActorInfo.IdentityID == IdentityID && !dBCSpawnSimpleActorInfo.SpawnedSimpleActor.IsNullOrDestroyed() && (ForceDetachAndSet || dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.GetAttachSocketName() == default(FName)))
			{
				dBCSpawnSimpleActorInfo.SpawnedSimpleActor.DetachFromActor();
				if (DBCTransform.TransformUseAll)
				{
					dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.SetWorldTransform(DBCTransform.Transform, bSweep: false, out var _, bTeleport: true);
					dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D);
				}
				else
				{
					if (DBCTransform.UseLocation)
					{
						dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.SetWorldLocation(DBCTransform.Transform.GetLocation(), bSweep: false, out var _, bTeleport: true);
					}
					if (DBCTransform.UseRotation)
					{
						dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.SetWorldRotation(DBCTransform.Transform.Rotator(), bSweep: false, out var _, bTeleport: true);
					}
					if (DBCTransform.UseScale)
					{
						dBCSpawnSimpleActorInfo.SpawnedSimpleActor.RootComponent.SetWorldScale3D(DBCTransform.Transform.Scale3D);
					}
				}
			}
		}
	}

	private bool RequestGetFirstDBCNiagaraTransform(USceneComponent SourceDispOwnerComp, uint IdentityID, out FTransform ResTransform)
	{
		ResTransform = FTransform.Default;
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !uNiagaraComponent.IsNullOrDestroyed())
				{
					ResTransform = uNiagaraComponent.GetWorldTransform();
					return true;
				}
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
				UNiagaraComponent uNiagaraComponent2 = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
				if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !uNiagaraComponent2.IsNullOrDestroyed())
				{
					ResTransform = uNiagaraComponent2.GetWorldTransform();
					return true;
				}
			}
		}
		return false;
	}

	private bool DBCIdentityCheckFunc(DBCIdentityInfoBase Info, DispLibDBCIdentityCheckMode CheckMode, uint IdentityID, uint MontageUniqueID, FName Tag)
	{
		switch (CheckMode)
		{
		case DispLibDBCIdentityCheckMode.DBCID:
			if (IdentityID != 0)
			{
				return Info.IdentityID == IdentityID;
			}
			return true;
		case DispLibDBCIdentityCheckMode.AnimNotifyUniqueID:
			if (IdentityID != 0)
			{
				return Info.AnimNotifyUniqueID == IdentityID;
			}
			return true;
		case DispLibDBCIdentityCheckMode.Tag:
			return Info.CheckHasTag(Tag);
		case DispLibDBCIdentityCheckMode.DBCID_and_Tag:
			if (IdentityID != 0)
			{
				if (Info.IdentityID == IdentityID)
				{
					return Info.CheckHasTag(Tag);
				}
				return false;
			}
			return Info.CheckHasTag(Tag);
		case DispLibDBCIdentityCheckMode.AnimNotifyUniqueID_and_Tag:
			if (IdentityID == 0 || Info.AnimNotifyUniqueID != IdentityID)
			{
				return false;
			}
			if (IdentityID != 0)
			{
				if (Info.AnimNotifyUniqueID == IdentityID)
				{
					return Info.CheckHasTag(Tag);
				}
				return false;
			}
			return Info.CheckHasTag(Tag);
		default:
			return false;
		}
	}

	private void Interior_EndAllEffects()
	{
		if (DBCBaseData == null || Queue == null || DispLibCameraData == null || GlobalData == null)
		{
			return;
		}
		foreach (List<DBCPlayCascadeInfo> value in Queue.PlayCascadeCacheQueue.Values)
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				OnRealEndPlayCascade(num, value);
			}
		}
		foreach (List<DBCPlayNiagaraInfo> value2 in Queue.PlayNiagaraCacheQueue.Values)
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				OnRealEndPlayNiagara(num2, value2, ForceDestroyComponent: true);
			}
		}
		foreach (List<DBCPlayAdvanceNiagaraInfo> value3 in Queue.PlayAdvanceNiagaraCacheQueue.Values)
		{
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				OnRealEndPlayAdvanceNiagara(num3, value3, ForceDestroyComponent: true);
			}
		}
		foreach (List<DBCSpawnSimpleActorInfo> value4 in Queue.SpawnSimpleActorCacheQueue.Values)
		{
			for (int num4 = value4.Count - 1; num4 >= 0; num4--)
			{
				OnRealEndSimpleActor(num4, value4);
			}
		}
		foreach (List<DBCPlayAudioInfo> value5 in Queue.PlayAudioCacheQueue.Values)
		{
			for (int num5 = value5.Count - 1; num5 >= 0; num5--)
			{
				OnRealEndPlayAudio(num5, value5);
			}
		}
		foreach (List<DBCPlayArtFresnelInfo> value6 in Queue.PlayArtFresnelCacheQueue.Values)
		{
			for (int num6 = value6.Count - 1; num6 >= 0; num6--)
			{
				OnRealEndPlayArtFresnel(num6, value6);
			}
		}
		foreach (List<DBCChangeMaterialInfo> value7 in Queue.ChangeMaterialCacheQueue.Values)
		{
			for (int num7 = value7.Count - 1; num7 >= 0; num7--)
			{
				OnRealEndChangeMaterial(num7, value7);
			}
		}
		foreach (List<DBCModifyMaterialInfo> value8 in Queue.ModifyMaterialCacheQueue.Values)
		{
			for (int num8 = value8.Count - 1; num8 >= 0; num8--)
			{
				OnRealEndModifyMaterial(num8, value8, Queue.ModMatCSharpObjectPool);
			}
		}
		foreach (List<DBCModifyNiagaraParamsInfo> value9 in Queue.ModifyNiagaraParamsCacheQueue.Values)
		{
			for (int num9 = value9.Count - 1; num9 >= 0; num9--)
			{
				OnRealEndModifyNiagaraParams(num9, value9);
			}
		}
	}

	private void Interior_CleanAllData()
	{
		DispLibCameraData?.Reset();
		Queue?.Reset();
		GlobalData?.Reset();
		DBCBaseData?.Reset();
	}

	private void Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode CheckMode, USceneComponent SourceDispOwnerComp, uint IdentityID, int EventIndex, uint MontageUniqueID, FName Tag = default(FName), bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = false, int EndStagePriority = -1, bool ForceDeleteComponentOnDestroy = false)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		float curTime = GetCurTime();
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.AbstractEventCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo info = value[num];
				if (DBCIdentityCheckFunc(info, CheckMode, IdentityID, MontageUniqueID, Tag))
				{
					OnRealEndAbstractEvent(num, value, ForceDeleteComponentOnDestroy);
				}
			}
		}
		if (Queue.PlayCascadeCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayCascadeInfo dBCPlayCascadeInfo = value2[num2];
				if (DBCIdentityCheckFunc(dBCPlayCascadeInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCPlayCascadeInfo.EndMode == DispLibDBCEndMode.ProcedureNotity))
				{
					OnRealEndPlayCascade(num2, value2);
				}
			}
		}
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value3))
		{
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value3[num3];
				if ((CheckMode != DispLibDBCIdentityCheckMode.DBCID || EventIndex == -1 || dBCPlayNiagaraInfo.EventIndexInDataAsset == EventIndex) && DBCIdentityCheckFunc(dBCPlayNiagaraInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCPlayNiagaraInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoNiagaraDelayStop(dBCPlayNiagaraInfo, curTime, EndStagePriority, ForceDeleteComponentOnDestroy))
				{
					OnRealEndPlayNiagara(num3, value3, ForceDeleteComponentOnDestroy);
				}
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value4))
		{
			for (int num4 = value4.Count - 1; num4 >= 0; num4--)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value4[num4];
				if ((CheckMode != DispLibDBCIdentityCheckMode.DBCID || EventIndex == -1 || dBCPlayAdvanceNiagaraInfo.EventIndexInDataAsset == EventIndex) && DBCIdentityCheckFunc(dBCPlayAdvanceNiagaraInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCPlayAdvanceNiagaraInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoAdvNiagaraDelayStop(dBCPlayAdvanceNiagaraInfo, curTime, EndStagePriority, ForceDeleteComponentOnDestroy))
				{
					OnRealEndPlayAdvanceNiagara(num4, value4, ForceDeleteComponentOnDestroy);
				}
			}
		}
		if (OnlyEndFX)
		{
			return;
		}
		if (Queue.WEFMWindEventCacheQueue.TryGetValue(uniqueID, out var value5))
		{
			for (int num5 = value5.Count - 1; num5 >= 0; num5--)
			{
				DBCWEFMWindEventInfo dBCWEFMWindEventInfo = value5[num5];
				if (DBCIdentityCheckFunc(dBCWEFMWindEventInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCWEFMWindEventInfo.EndMode == DispLibDBCEndMode.ProcedureNotity))
				{
					OnRealEndWEFMWindEvent(num5, value5);
				}
			}
		}
		if (Queue.SpawnSimpleActorCacheQueue.TryGetValue(uniqueID, out var value6))
		{
			for (int num6 = value6.Count - 1; num6 >= 0; num6--)
			{
				DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = value6[num6];
				if (DBCIdentityCheckFunc(dBCSpawnSimpleActorInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCSpawnSimpleActorInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoSimpleActorDelayStop(dBCSpawnSimpleActorInfo, curTime, EndStagePriority))
				{
					OnRealEndSimpleActor(num6, value6);
				}
			}
		}
		if (CheckMode == DispLibDBCIdentityCheckMode.Tag)
		{
			return;
		}
		if (Queue.PlayAudioCacheQueue.TryGetValue(uniqueID, out var value7))
		{
			for (int num7 = value7.Count - 1; num7 >= 0; num7--)
			{
				DBCPlayAudioInfo info2 = value7[num7];
				if (DBCIdentityCheckFunc(info2, CheckMode, IdentityID, MontageUniqueID, Tag))
				{
					OnRealEndPlayAudio(num7, value7);
				}
			}
		}
		if (Queue.PlayArtFresnelCacheQueue.TryGetValue(uniqueID, out var value8))
		{
			for (int num8 = value8.Count - 1; num8 >= 0; num8--)
			{
				DBCPlayArtFresnelInfo dBCPlayArtFresnelInfo = value8[num8];
				if (DBCIdentityCheckFunc(dBCPlayArtFresnelInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCPlayArtFresnelInfo.EndMode == DispLibDBCEndMode.ProcedureNotity))
				{
					OnRealEndPlayArtFresnel(num8, value8);
				}
			}
		}
		if (Queue.ChangeMaterialCacheQueue.TryGetValue(uniqueID, out var value9))
		{
			for (int num9 = value9.Count - 1; num9 >= 0; num9--)
			{
				DBCChangeMaterialInfo dBCChangeMaterialInfo = value9[num9];
				if (DBCIdentityCheckFunc(dBCChangeMaterialInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCChangeMaterialInfo.EndMode == DispLibDBCEndMode.ProcedureNotity))
				{
					OnRealEndChangeMaterial(num9, value9);
				}
			}
		}
		if (Queue.ModifyMaterialCacheQueue.TryGetValue(uniqueID, out var value10))
		{
			for (int num10 = value10.Count - 1; num10 >= 0; num10--)
			{
				DBCModifyMaterialInfo dBCModifyMaterialInfo = value10[num10];
				if (DBCIdentityCheckFunc(dBCModifyMaterialInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCModifyMaterialInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoModifyMaterialDelayStop(dBCModifyMaterialInfo, curTime, EndStagePriority))
				{
					OnRealEndModifyMaterial(num10, value10, Queue.ModMatCSharpObjectPool);
				}
			}
		}
		if (Queue.ModifyMPCCacheQueue.TryGetValue(uniqueID, out var value11))
		{
			for (int num11 = value11.Count - 1; num11 >= 0; num11--)
			{
				DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = value11[num11];
				if (DBCIdentityCheckFunc(dBCModifyMaterialParameterCollectionInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCModifyMaterialParameterCollectionInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoModifyMPCDelayStop(dBCModifyMaterialParameterCollectionInfo, curTime, EndStagePriority))
				{
					OnRealEndModifyMPC(num11, value11);
				}
			}
		}
		if (!Queue.ModifyNiagaraParamsCacheQueue.TryGetValue(uniqueID, out var value12))
		{
			return;
		}
		for (int num12 = value12.Count - 1; num12 >= 0; num12--)
		{
			DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = value12[num12];
			if (DBCIdentityCheckFunc(dBCModifyNiagaraParamsInfo, CheckMode, IdentityID, MontageUniqueID, Tag) && (!OnlyEndProcedureEndMode || dBCModifyNiagaraParamsInfo.EndMode == DispLibDBCEndMode.ProcedureNotity) && !CheckAndDoModifyNiagaraParamsDelayStop(dBCModifyNiagaraParamsInfo, curTime, EndStagePriority))
			{
				OnRealEndModifyNiagaraParams(num12, value12);
			}
		}
	}

	private void RequestEndDBCEffects(USceneComponent SourceDispOwnerComp, uint DBCID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = false, int EndStagePriority = -1, bool ForceDeleteComponentOnDestroy = false)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, SourceDispOwnerComp, DBCID, -1, 0u, default(FName), OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDeleteComponentOnDestroy);
	}

	private void RequestEndDBCEffectsByTag(USceneComponent SourceDispOwnerComp, FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDeleteComponentOnDestroy = false)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.Tag, SourceDispOwnerComp, 0u, -1, 0u, CompTag, OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDeleteComponentOnDestroy);
	}

	private void RequestEndDBCEffectsByAnimNotifyUniqueID(USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDeleteComponentOnDestroy = false)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.AnimNotifyUniqueID, SourceDispOwnerComp, AnimNotifyUniqueID, -1, MontageUniqueID, default(FName), OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority, ForceDeleteComponentOnDestroy);
	}

	private void RequestEndDBCEffectsAdvance(USceneComponent SourceDispOwnerComp, DispLibDBCEffectType EffectType, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float ForceDestroyAfterTime = -1f, int EndReasonMark = 0)
	{
		if (!SourceDispOwnerComp.IsNullOrDestroyed())
		{
			GetCurTime();
			SourceDispOwnerComp.GetUniqueID();
		}
	}

	private void Interior_RequestSetDBCNiagaraVisibleState(uint SourceDispOwnerCompID, uint IdentityID, bool isVisible, int ATKPriority)
	{
		if (Queue.AbstractEventCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo dBCAbstractEventInfo = value[num];
				if (IdentityID == 0 || dBCAbstractEventInfo.IdentityID == IdentityID)
				{
					dBCAbstractEventInfo.ForceNiagaraVisibleState = (isVisible ? (-1) : 0);
					dBCAbstractEventInfo.ForceNiagaraVisibleStateRequestATKPriority = ATKPriority;
				}
			}
		}
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value2[num2];
				if ((IdentityID == 0 || dBCPlayNiagaraInfo.IdentityID == IdentityID) && dBCPlayNiagaraInfo.ForceChangeVisibleStateDEFPriority <= ATKPriority)
				{
					dBCPlayNiagaraInfo.ForceNiagaraVisibleState = (isVisible ? (-1) : 0);
					UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
					if (!uNiagaraComponent.IsNullOrDestroyed())
					{
						switch (dBCPlayNiagaraInfo.ForceVisibleStateDefaultMode)
						{
						case DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState:
							uNiagaraComponent.SetVisibility(isVisible);
							break;
						case DispLibDBCNiagaraForceVisibleStateMode.SetNiagaraParam:
							uNiagaraComponent.SetVariableInt(B1GlobalFNames.User_GS_EfxForceVisibleState, dBCPlayNiagaraInfo.ForceNiagaraVisibleState);
							break;
						}
					}
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value3))
		{
			return;
		}
		for (int num3 = value3.Count - 1; num3 >= 0; num3--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value3[num3];
			if ((IdentityID == 0 || dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID) && dBCPlayAdvanceNiagaraInfo.ForceChangeVisibleStateDEFPriority <= ATKPriority)
			{
				dBCPlayAdvanceNiagaraInfo.ForceNiagaraVisibleState = (isVisible ? (-1) : 0);
				UNiagaraComponent uNiagaraComponent2 = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
				if (!uNiagaraComponent2.IsNullOrDestroyed())
				{
					DispLibDBCNiagaraForceVisibleStateMode dispLibDBCNiagaraForceVisibleStateMode = dBCPlayAdvanceNiagaraInfo.ForceVisibleStateDefaultMode;
					List<BUC_DispLibUtil_ForceVisibleStateCustomMode> forceVisibleStateCustomMode = dBCPlayAdvanceNiagaraInfo.SourceRequest.ForceVisibleStateCustomMode;
					if (forceVisibleStateCustomMode != null && forceVisibleStateCustomMode.Count != 0)
					{
						for (int i = 0; i < forceVisibleStateCustomMode.Count; i++)
						{
							if (forceVisibleStateCustomMode[i].RequestATKPriority == ATKPriority)
							{
								dispLibDBCNiagaraForceVisibleStateMode = forceVisibleStateCustomMode[i].Mode;
								break;
							}
						}
					}
					switch (dispLibDBCNiagaraForceVisibleStateMode)
					{
					case DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState:
						uNiagaraComponent2.SetVisibility(isVisible);
						break;
					case DispLibDBCNiagaraForceVisibleStateMode.SetNiagaraParam:
						uNiagaraComponent2.SetVariableInt(B1GlobalFNames.User_GS_EfxForceVisibleState, dBCPlayAdvanceNiagaraInfo.ForceNiagaraVisibleState);
						break;
					}
				}
			}
		}
	}

	private void DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState(DispLibDBCActorGroup Filter, bool isVisible, int ATKPriority)
	{
		if (Queue.ActorGroupMapSourceDispOwnerCompID.TryGetValue(Filter, out var value) && value.Count != 0)
		{
			for (int i = 0; i < value.Count; i++)
			{
				uint sourceDispOwnerCompID = value[i];
				Interior_RequestSetDBCNiagaraVisibleState(sourceDispOwnerCompID, 0u, isVisible, ATKPriority);
			}
		}
	}

	private void RequestSetDBCNiagaraVisibleState(USceneComponent SourceDispOwnerComp, uint IdentityID, bool isVisible, int ATKPriority)
	{
		if (!SourceDispOwnerComp.IsNullOrDestroyed())
		{
			uint uniqueID = SourceDispOwnerComp.GetUniqueID();
			Interior_RequestSetDBCNiagaraVisibleState(uniqueID, IdentityID, isVisible, ATKPriority);
		}
	}

	private void RequestSetDBCNiagaraFloatParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, float Value)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					dBCPlayNiagaraInfo.NiagaraComponent.Get().SetVariableFloat(ParamName, Value);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().SetVariableFloat(ParamName, Value);
			}
		}
	}

	private void RequestSetDBCNiagaraVectorParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, FVector Value)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					dBCPlayNiagaraInfo.NiagaraComponent.Get().SetVariableVec3(ParamName, Value);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID)
			{
				if (dBCPlayAdvanceNiagaraInfo.IS_MERGED_REQUEST)
				{
					if (Queue.DBCMergeNiagaraData.TryGetValue(dBCPlayAdvanceNiagaraInfo.MergeMangerSystemTemplateUniqueID, out var value3))
					{
						value3?.OnSetChildEventCustomVectorParam(dBCPlayAdvanceNiagaraInfo, ParamName.PlainName, Value);
					}
				}
				else if (!dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().SetVariableVec3(ParamName, Value);
				}
			}
		}
	}

	private void RequestSetDBCNiagaraBoolParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, bool Value)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					dBCPlayNiagaraInfo.NiagaraComponent.Get().SetBoolParameter(ParamName, Value);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().SetBoolParameter(ParamName, Value);
			}
		}
	}

	private void RequestSetDBCNiagaraIntParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Value)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					dBCPlayNiagaraInfo.NiagaraComponent.Get().SetIntParameter(ParamName, Value);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().SetIntParameter(ParamName, Value);
			}
		}
	}

	private void RequestSetDBCNiagaraVectorArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<FVector> ArrayData)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
			}
		}
	}

	private void RequestSetDBCNiagaraVector4ArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<FVector4> ArrayData)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
			}
		}
	}

	private void RequestSetDBCNiagaraFloatArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<float> ArrayData)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloat(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloat(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, ArrayData);
			}
		}
	}

	private void RequestSetDBCNiagaraVectorArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, FVector Value, bool SizeToFit)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVectorValue(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVectorValue(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
			}
		}
	}

	private void RequestSetDBCNiagaraVector4ArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, FVector4 Value, bool SizeToFit)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4Value(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4Value(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
			}
		}
	}

	private void RequestSetDBCNiagaraFloatArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, float Value, bool SizeToFit)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value[num];
				if (dBCPlayNiagaraInfo.IdentityID == IdentityID && !dBCPlayNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloatValue(dBCPlayNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
				}
			}
		}
		if (!Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value2[num2];
			if (dBCPlayAdvanceNiagaraInfo.IdentityID == IdentityID && !dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get().IsNullOrDestroyed())
			{
				UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloatValue(dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get(), ParamName, Index, Value, SizeToFit);
			}
		}
	}

	private void RequestSetDBCCameraShakeIntensityScale(USceneComponent SourceDispOwnerComp, uint IdentityID, float IntensityScale)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.AbstractEventCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo dBCAbstractEventInfo = value[num];
				if (IdentityID == 0 || dBCAbstractEventInfo.IdentityID == IdentityID)
				{
					dBCAbstractEventInfo.ForceCameraShakeIntensityScale = IntensityScale;
				}
			}
		}
		if (Queue.PlayCameraShakeCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = value2[num2];
				if (IdentityID == 0 || dBCPlayCameraShakeInfo.IdentityID == IdentityID)
				{
					dBCPlayCameraShakeInfo.ForceCameraShakeIntensityScale = IntensityScale;
				}
			}
		}
		if (!Queue.PlayCustomCameraShakeCacheQueue.TryGetValue(uniqueID, out var value3))
		{
			return;
		}
		for (int num3 = value3.Count - 1; num3 >= 0; num3--)
		{
			DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = value3[num3];
			if (IdentityID == 0 || dBCPlayCustomCameraShakeInfo.IdentityID == IdentityID)
			{
				dBCPlayCustomCameraShakeInfo.ForceCameraShakeIntensityScale = IntensityScale;
			}
		}
	}

	private void RequestSetDBCAudioMuteState(USceneComponent SourceDispOwnerComp, uint IdentityID, bool isMute)
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return;
		}
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		if (Queue.AbstractEventCacheQueue.TryGetValue(uniqueID, out var value))
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo dBCAbstractEventInfo = value[num];
				if (IdentityID == 0 || dBCAbstractEventInfo.IdentityID == IdentityID)
				{
					dBCAbstractEventInfo.ForceAudioMute = ((!isMute) ? (-1) : 0);
				}
			}
		}
		if (!Queue.PlayAudioCacheQueue.TryGetValue(uniqueID, out var value2))
		{
			return;
		}
		for (int num2 = value2.Count - 1; num2 >= 0; num2--)
		{
			DBCPlayAudioInfo dBCPlayAudioInfo = value2[num2];
			if (IdentityID == 0 || dBCPlayAudioInfo.IdentityID == IdentityID)
			{
				dBCPlayAudioInfo.ForceAudioMute = ((!isMute) ? (-1) : 0);
				if (dBCPlayAudioInfo.WWiseID != -1)
				{
					UAkGameplayStatics.SetRTPCValueByPlayingID(dBCPlayAudioInfo.WWiseID, (!isMute) ? 1 : 0, B1GlobalFNames.RTPC_Volume_Global_GamePlayLogic);
				}
			}
		}
	}

	private void DLDWorld_RequestEndDBCEffects(int DBCID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, DBCBaseData.DispOwnerComp, (uint)DBCID, -1, 0u, default(FName), OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority);
	}

	private void DLDWorld_RequestEndDBCEffectsByANID(uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.AnimNotifyUniqueID, DBCBaseData.DispOwnerComp, AnimNotifyUniqueID, -1, MontageUniqueID, default(FName), OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority);
	}

	private void DLDWorld_RequestEndDBCEffectsByTag(FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1)
	{
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.Tag, DBCBaseData.DispOwnerComp, 0u, -1, 0u, default(FName), OnlyEndFX, OnlyEndProcedureEndMode, EndStagePriority);
	}

	private void DLDWorld_RequestSetWEFMSystemState(bool Active, int WEFMLODIndex = -1)
	{
		UNiagaraComponent uNiagaraComponent = DispLibDispWorld.GetInstance(GetOwner())?.WEFMManager;
		if (!uNiagaraComponent.IsNullOrDestroyed() && uNiagaraComponent.IsActive() != Active)
		{
			uNiagaraComponent.SetActive(bNewActive: false, bReset: true);
			Queue.InitWindQueue();
			GlobalData.InitWEFMGlobalData(GetOwner(), (WEFMLODIndex == -1) ? GlobalData.WEFMLod : WEFMLODIndex);
			uNiagaraComponent.SetActive(Active, bReset: true);
		}
	}

	private void DLDWorld_RequestDirectInject_Wind(ref uint RequesterUniqueID, FVector CenterPosWS, FVector DirWS, FVector WindSizeV3, float WindIntensity, int WindType, float DistanceDamplingRate, FVector4 WindDataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		if (RequesterUniqueID == 0)
		{
			RequesterUniqueID = Queue.RequestNewWEFMWindRequesterUniqueID();
		}
		if (!BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.UseWEFM || Queue.WEFM_ValidEventsCount + 1 > Queue.WEFMWindBufferMaxCount)
		{
			return;
		}
		if (Queue.WEFM_LastFreeSeatIndex < Queue.WEFM_CurFrameExecuteAtIndex)
		{
			for (int i = Queue.WEFM_CurFrameExecuteAtIndex; i < Queue.WEFMWindBufferMaxCount; i++)
			{
				if (Queue.Wind_ReserveExecuteBuffer[i].RequesterUniqueID == RequesterUniqueID)
				{
					Queue.Wind_ReserveExecuteBuffer[i].MergeData(CenterPosWS, DirWS, WindSizeV3, WindIntensity, WindDataV4);
					return;
				}
			}
			for (int j = 0; j < Queue.WEFM_LastFreeSeatIndex; j++)
			{
				if (Queue.Wind_ReserveExecuteBuffer[j].RequesterUniqueID == RequesterUniqueID)
				{
					Queue.Wind_ReserveExecuteBuffer[j].MergeData(CenterPosWS, DirWS, WindSizeV3, WindIntensity, WindDataV4);
					return;
				}
			}
		}
		else
		{
			for (int k = Queue.WEFM_CurFrameExecuteAtIndex; k < Queue.WEFM_LastFreeSeatIndex; k++)
			{
				if (Queue.Wind_ReserveExecuteBuffer[k].RequesterUniqueID == RequesterUniqueID)
				{
					Queue.Wind_ReserveExecuteBuffer[k].MergeData(CenterPosWS, DirWS, WindSizeV3, WindIntensity, WindDataV4);
					return;
				}
			}
		}
		Queue.WEFM_ValidEventsCount++;
		Queue.Wind_ReserveExecuteBuffer[Queue.WEFM_LastFreeSeatIndex].SetData(RequesterUniqueID, CenterPosWS, DirWS, WindSizeV3, WindIntensity, WindType, DistanceDamplingRate, WindDataV4);
		if (Queue.WEFM_LastFreeSeatIndex + 1 > Queue.WEFMWindBufferMaxCount - 1)
		{
			Queue.WEFM_LastFreeSeatIndex = 0;
		}
		else
		{
			Queue.WEFM_LastFreeSeatIndex++;
		}
	}

	private void DLDWorld_RequestInject_Heat(out uint IdentityID, FVector CenterPosWS, FVector SizeV3, float Intensity, float DistanceDamplingRate, FVector4 DataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		IdentityID = 0u;
	}

	private bool DLDWorld_GetMPCScalarParamValue(string MPCAssetPath, FName ParamName, out float ParamCurValue)
	{
		ParamCurValue = 0f;
		UMaterialParameterCollection uMaterialParameterCollection = GlobalData.LoadAndGetMPCInstance(Owner, MPCAssetPath);
		if (uMaterialParameterCollection.IsNullOrDestroyed())
		{
			return false;
		}
		ParamCurValue = UMaterialLibrary.GetScalarParameterValue(Owner, uMaterialParameterCollection, ParamName);
		return true;
	}

	private bool DLDWorld_GetMPCScalarParamInitialValue(string MPCAssetPath, FName ParamName, out float ParamInitialValue)
	{
		ParamInitialValue = 0f;
		UMaterialParameterCollection mPCInstance = GlobalData.LoadAndGetMPCInstance(Owner, MPCAssetPath);
		bool DataChanged;
		DispLib_One_MPC_ScalarParamState orAdd_One_MPCScalarParamState = Queue.GetOrAdd_One_MPCScalarParamState(out DataChanged, mPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCScalarParamState == null || !orAdd_One_MPCScalarParamState.isInitialValueValid)
		{
			return false;
		}
		ParamInitialValue = orAdd_One_MPCScalarParamState.InitialValue;
		return true;
	}

	private bool DLDWorld_GetMPCColorParamValue(string MPCAssetPath, FName ParamName, out FLinearColor ParamCurValue)
	{
		ParamCurValue = FLinearColor.White;
		UMaterialParameterCollection uMaterialParameterCollection = GlobalData.LoadAndGetMPCInstance(Owner, MPCAssetPath);
		if (uMaterialParameterCollection.IsNullOrDestroyed())
		{
			return false;
		}
		ParamCurValue = UMaterialLibrary.GetVectorParameterValue(Owner, uMaterialParameterCollection, ParamName);
		return true;
	}

	private bool DLDWorld_GetMPCColorParamInitialValue(string MPCAssetPath, FName ParamName, out FLinearColor ParamInitialValue)
	{
		ParamInitialValue = FLinearColor.White;
		UMaterialParameterCollection mPCInstance = GlobalData.LoadAndGetMPCInstance(Owner, MPCAssetPath);
		bool DataChanged;
		DispLib_One_MPC_ColorParamState orAdd_One_MPCColorParamState = Queue.GetOrAdd_One_MPCColorParamState(out DataChanged, mPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCColorParamState == null || !orAdd_One_MPCColorParamState.isInitialValueValid)
		{
			return false;
		}
		ParamInitialValue = orAdd_One_MPCColorParamState.InitialValue;
		return true;
	}

	private void DLDWorld_RequestApply_One_ModMPC(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		RequestApply_One_ModMPC(DBCBaseData.DispOwnerComp, D, out IdentityID, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void DLDWorld_RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, DBCTransformParam DBCTransform = default(DBCTransformParam), USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		RequestApplyOneDBCDataAsset(DBCTransform: new DBCTransformParam(DBCTransform.Transform, DBCTransform.UseLocation, DBCTransform.LocationType, DBCTransform.UseRotation, DBCTransform.RotationType, DBCTransform.UseScale, DBCTransform.ScaleType, DBCTransformOverrdieAttachType.Detach, DBCTransform.AttachedTargetSocketName, DBCTransform.AddDataAssetOffset), DBCDataAsset: DBCDataAsset, IdentityID: out IdentityID, SourceDispOwnerComp: DBCBaseData.DispOwnerComp, MinorDispOwnerComp: MinorDispOwnerComp, MinorPosWSOnSpawn: MinorPosWSOnSpawn, CallbackParams: CallbackParams, AnimNotifyUniqueID: AnimNotifyUniqueID, MontageUniqueID: MontageUniqueID);
	}

	private void DLDWorld_RequestApply_One_CameraShake(BUC_DispLibDBC_PlayCameraShake D, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID = 0u)
	{
		if (ValidateDBCPlayCameraShake(D))
		{
			float curTime = GetCurTime();
			uint identityID = Queue.RequestNewUniqueID();
			if (SourceDispOwnerComp.IsNullOrDestroyed() || SourceDispOwnerComp == DispLibDispWorld.GetInstance(GetOwner()))
			{
				D.UseDistanceDamping = false;
			}
			DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = new DBCPlayCameraShakeInfo();
			if (dBCPlayCameraShakeInfo.DBCInfoInit(curTime, identityID, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(D.Delay <= 0.001f) || DoPlayCameraShake(dBCPlayCameraShakeInfo)))
			{
				Queue.AddItem2CacheQueue(SourceDispOwnerComp.GetUniqueID(), dBCPlayCameraShakeInfo, Queue.PlayCameraShakeCacheQueue);
			}
		}
	}

	private void DLDWorld_RequestApply_One_CustomCameraShake(BUC_DispLibDBC_PlayCustomCameraShake D, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID = 0u)
	{
		if (ValidateDBCPlayCustomCameraShake(D))
		{
			float curTime = GetCurTime();
			uint identityID = Queue.RequestNewUniqueID();
			if (SourceDispOwnerComp.IsNullOrDestroyed() || SourceDispOwnerComp == DispLibDispWorld.GetInstance(GetOwner()))
			{
				D.UseDistanceDamping = false;
			}
			DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = new DBCPlayCustomCameraShakeInfo();
			if (dBCPlayCustomCameraShakeInfo.DBCInfoInit(curTime, identityID, D, SourceDispOwnerComp, AnimNotifyUniqueID, MontageUniqueID) && (!(D.Delay <= 0.001f) || DoPlayCustomCameraShake(dBCPlayCustomCameraShakeInfo)))
			{
				Queue.AddItem2CacheQueue(SourceDispOwnerComp.GetUniqueID(), dBCPlayCustomCameraShakeInfo, Queue.PlayCustomCameraShakeCacheQueue);
			}
		}
	}

	private void DLDWorld_RequestSpawn_One_Simple_Niagara(UNiagaraSystem Template, DispLibDBCEndMode EndMode, float Duration, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		RequestSpawn_One_Common_Niagara(DBCBaseData.DispOwnerComp, new BUC_DispLibDBC_PlayNiagara(Duration, EndMode, Template), DBCRefParam, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void DLDWorld_RequestSpawn_One_Common_Niagara(BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		D.AttachedTarget = false;
		RequestSpawn_One_Common_Niagara(DBCBaseData.DispOwnerComp, D, DBCRefParam, DBCTransform, CallbackParams, AnimNotifyUniqueID, MontageUniqueID);
	}

	private void DLDWorld_RequestSpawn_One_Simple_Actor(BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u)
	{
		RequestSpawn_One_Simple_Actor(DBCTransform: new DBCTransformParam(DBCTransform.Transform, DBCTransform.UseLocation, DBCTransform.LocationType, DBCTransform.UseRotation, DBCTransform.RotationType, DBCTransform.UseScale, DBCTransform.ScaleType, DBCTransformOverrdieAttachType.Detach, DBCTransform.AttachedTargetSocketName, DBCTransform.AddDataAssetOffset), SourceDispOwnerComp: DBCBaseData.DispOwnerComp, D: D, DBCRefParam: DBCRefParam, MinorDispOwnerComp: MinorDispOwnerComp, MinorPosWSOnSpawn: MinorPosWSOnSpawn, CallbackParams: CallbackParams, AnimNotifyUniqueID: AnimNotifyUniqueID, MontageUniqueID: MontageUniqueID);
	}

	private void DoAbstractEventUpdate(float DeltaTime)
	{
		foreach (List<DBCAbstractEventInfo> value in Queue.AbstractEventCacheQueue.Values)
		{
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCAbstractEventInfo dBCAbstractEventInfo = value[num];
				float num2 = DeltaTime * dBCAbstractEventInfo.CustomTimeDilation;
				dBCAbstractEventInfo.AbstractEventUnpausedAge += num2;
				dBCAbstractEventInfo.AbstractEventGameAge += (dBCAbstractEventInfo.IsPause ? 0f : num2);
			}
		}
	}

	public void OnTick(float DeltaTime)
	{
		float curTime = GetCurTime();
		DoGameUtilityDataUpdate();
		DoAbstractEventUpdate(DeltaTime);
		foreach (KeyValuePair<uint, List<DBCWEFMWindEventInfo>> item in Queue.WEFMWindEventCacheQueue)
		{
			List<DBCWEFMWindEventInfo> value = item.Value;
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DBCWEFMWindEventInfo dBCWEFMWindEventInfo = value[num];
				if (dBCWEFMWindEventInfo.StartExecute)
				{
					switch (dBCWEFMWindEventInfo.EndMode)
					{
					case DispLibDBCEndMode.FixDuration:
						if (dBCWEFMWindEventInfo.IsPause)
						{
							dBCWEFMWindEventInfo.EndAtTime += DeltaTime * dBCWEFMWindEventInfo.CustomTimeDilation;
						}
						if (curTime >= dBCWEFMWindEventInfo.EndAtTime)
						{
							OnRealEndWEFMWindEvent(num, value);
						}
						else if (!dBCWEFMWindEventInfo.IsPause)
						{
							ExecuteWEFMWindEventTick(dBCWEFMWindEventInfo, DeltaTime * dBCWEFMWindEventInfo.CustomTimeDilation);
						}
						break;
					}
				}
				else if (curTime >= (dBCWEFMWindEventInfo.IsPause ? (dBCWEFMWindEventInfo.PlayAtTime += DeltaTime * dBCWEFMWindEventInfo.CustomTimeDilation) : dBCWEFMWindEventInfo.PlayAtTime))
				{
					ExecuteWEFMWindEventTick(dBCWEFMWindEventInfo, DeltaTime * dBCWEFMWindEventInfo.CustomTimeDilation);
				}
			}
		}
		if (BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.UseWEFM && GlobalData.WEFMInitComplete)
		{
			RefreshCameraData(DeltaTime);
			DoWEFMField();
			DoWind();
		}
		DoCameraEnvFXUpdate();
		foreach (KeyValuePair<uint, List<DBCPlayCascadeInfo>> item2 in Queue.PlayCascadeCacheQueue)
		{
			List<DBCPlayCascadeInfo> value2 = item2.Value;
			for (int num2 = value2.Count - 1; num2 >= 0; num2--)
			{
				DBCPlayCascadeInfo dBCPlayCascadeInfo = value2[num2];
				if (dBCPlayCascadeInfo.HasSpawn)
				{
					switch (dBCPlayCascadeInfo.EndMode)
					{
					case DispLibDBCEndMode.AutoRelease:
						if (!dBCPlayCascadeInfo.CascadeComponent.IsActive() || dBCPlayCascadeInfo.CascadeComponent.IsNullOrDestroyed())
						{
							value2.RemoveAt(num2);
						}
						break;
					case DispLibDBCEndMode.FixDuration:
						if (curTime >= dBCPlayCascadeInfo.EndAtTime)
						{
							OnRealEndPlayCascade(num2, value2);
						}
						break;
					}
				}
				else if (curTime >= dBCPlayCascadeInfo.PlayAtTime && !DoPlayCascade(dBCPlayCascadeInfo))
				{
					value2.RemoveAt(num2);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayNiagaraInfo>> item3 in Queue.PlayNiagaraCacheQueue)
		{
			List<DBCPlayNiagaraInfo> value3 = item3.Value;
			for (int num3 = value3.Count - 1; num3 >= 0; num3--)
			{
				DBCPlayNiagaraInfo dBCPlayNiagaraInfo = value3[num3];
				if (dBCPlayNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
				{
					if (dBCPlayNiagaraInfo.IsPause)
					{
						dBCPlayNiagaraInfo.PlayAtTime += DeltaTime * dBCPlayNiagaraInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCPlayNiagaraInfo.PlayAtTime && !DoPlayNiagara(dBCPlayNiagaraInfo))
					{
						value3.RemoveAt(num3);
					}
				}
				else
				{
					dBCPlayNiagaraInfo.GameAge += (dBCPlayNiagaraInfo.IsPause ? 0f : (DeltaTime * dBCPlayNiagaraInfo.CustomTimeDilation));
					if (dBCPlayNiagaraInfo.IsPause && (dBCPlayNiagaraInfo.EndMode == DispLibDBCEndMode.FixDuration || dBCPlayNiagaraInfo.OnEndDispStage))
					{
						dBCPlayNiagaraInfo.EndAtTime += DeltaTime * dBCPlayNiagaraInfo.CustomTimeDilation;
					}
					if (dBCPlayNiagaraInfo.OnEndDispStage)
					{
						if (curTime >= dBCPlayNiagaraInfo.EndAtTime)
						{
							OnRealEndPlayNiagara(num3, value3, ForceDestroyComponent: false);
						}
					}
					else
					{
						switch (dBCPlayNiagaraInfo.EndMode)
						{
						case DispLibDBCEndMode.AutoRelease:
						{
							UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
							if (uNiagaraComponent.IsNullOrDestroyed() || !uNiagaraComponent.IsActive())
							{
								OnRealEndPlayNiagara(num3, value3, ForceDestroyComponent: false);
							}
							break;
						}
						case DispLibDBCEndMode.FixDuration:
							if (curTime >= dBCPlayNiagaraInfo.EndAtTime && !CheckAndDoNiagaraDelayStop(dBCPlayNiagaraInfo, curTime, -1, ForceDeleteComponentOnDestroy: false))
							{
								OnRealEndPlayNiagara(num3, value3, ForceDestroyComponent: false);
							}
							break;
						}
					}
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayAdvanceNiagaraInfo>> item4 in Queue.PlayAdvanceNiagaraCacheQueue)
		{
			List<DBCPlayAdvanceNiagaraInfo> value4 = item4.Value;
			for (int num4 = value4.Count - 1; num4 >= 0; num4--)
			{
				DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = value4[num4];
				if (dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
				{
					if (dBCPlayAdvanceNiagaraInfo.IsPause)
					{
						dBCPlayAdvanceNiagaraInfo.PlayAtTime += DeltaTime * dBCPlayAdvanceNiagaraInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCPlayAdvanceNiagaraInfo.PlayAtTime)
					{
						if (!DoPlayAdvanceNiagara(dBCPlayAdvanceNiagaraInfo))
						{
							value4.RemoveAt(num4);
						}
						else
						{
							AdvanceNiagaraUpdate(dBCPlayAdvanceNiagaraInfo, curTime);
						}
					}
				}
				else
				{
					dBCPlayAdvanceNiagaraInfo.GameAge += (dBCPlayAdvanceNiagaraInfo.IsPause ? 0f : (DeltaTime * dBCPlayAdvanceNiagaraInfo.CustomTimeDilation));
					if (dBCPlayAdvanceNiagaraInfo.IsPause && (dBCPlayAdvanceNiagaraInfo.EndMode == DispLibDBCEndMode.FixDuration || dBCPlayAdvanceNiagaraInfo.OnEndDispStage))
					{
						dBCPlayAdvanceNiagaraInfo.EndAtTime += DeltaTime * dBCPlayAdvanceNiagaraInfo.CustomTimeDilation;
					}
					if (!dBCPlayAdvanceNiagaraInfo.IS_MERGED_REQUEST)
					{
						AdvanceNiagaraUpdate(dBCPlayAdvanceNiagaraInfo, curTime);
						AdvanceNiagaraResolveConstraintMode(dBCPlayAdvanceNiagaraInfo, curTime, DeltaTime);
					}
					if (dBCPlayAdvanceNiagaraInfo.OnEndDispStage)
					{
						if (curTime >= dBCPlayAdvanceNiagaraInfo.EndAtTime)
						{
							OnRealEndPlayAdvanceNiagara(num4, value4, ForceDestroyComponent: false);
						}
					}
					else
					{
						switch (dBCPlayAdvanceNiagaraInfo.EndMode)
						{
						case DispLibDBCEndMode.AutoRelease:
						{
							UNiagaraComponent uNiagaraComponent2 = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
							if (uNiagaraComponent2.IsNullOrDestroyed() || !uNiagaraComponent2.IsActive())
							{
								OnRealEndPlayAdvanceNiagara(num4, value4, ForceDestroyComponent: false);
							}
							break;
						}
						case DispLibDBCEndMode.FixDuration:
							if (curTime >= dBCPlayAdvanceNiagaraInfo.EndAtTime && !CheckAndDoAdvNiagaraDelayStop(dBCPlayAdvanceNiagaraInfo, curTime, -1, ForceDeleteComponentOnDestroy: false))
							{
								OnRealEndPlayAdvanceNiagara(num4, value4, ForceDestroyComponent: false);
							}
							break;
						}
					}
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCChangeMaterialInfo>> item5 in Queue.ChangeMaterialCacheQueue)
		{
			List<DBCChangeMaterialInfo> value5 = item5.Value;
			for (int num5 = value5.Count - 1; num5 >= 0; num5--)
			{
				DBCChangeMaterialInfo dBCChangeMaterialInfo = value5[num5];
				if (dBCChangeMaterialInfo.HasSpawn)
				{
					if (dBCChangeMaterialInfo.IsPause && dBCChangeMaterialInfo.EndMode == DispLibDBCEndMode.FixDuration)
					{
						dBCChangeMaterialInfo.EndAtTime += DeltaTime * dBCChangeMaterialInfo.CustomTimeDilation;
					}
					if (dBCChangeMaterialInfo.OnEndDispStage)
					{
						if (curTime >= dBCChangeMaterialInfo.EndAtTime)
						{
							OnRealEndChangeMaterial(num5, value5);
							continue;
						}
					}
					else if (curTime >= dBCChangeMaterialInfo.EndAtTime && !CheckAndDoChangeMaterialDelayStop(dBCChangeMaterialInfo, curTime))
					{
						OnRealEndChangeMaterial(num5, value5);
						continue;
					}
				}
				else if (curTime >= (dBCChangeMaterialInfo.IsPause ? (dBCChangeMaterialInfo.PlayAtTime += DeltaTime * dBCChangeMaterialInfo.CustomTimeDilation) : dBCChangeMaterialInfo.PlayAtTime) && !DoChangeMaterial(dBCChangeMaterialInfo))
				{
					value5.RemoveAt(num5);
				}
				ChangeMaterialUpdate(dBCChangeMaterialInfo, curTime);
			}
		}
		foreach (KeyValuePair<uint, List<DBCModifyMaterialParameterCollectionInfo>> item6 in Queue.ModifyMPCCacheQueue)
		{
			List<DBCModifyMaterialParameterCollectionInfo> value6 = item6.Value;
			for (int num6 = value6.Count - 1; num6 >= 0; num6--)
			{
				DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = value6[num6];
				if (!dBCModifyMaterialParameterCollectionInfo.HasSpawn)
				{
					if (dBCModifyMaterialParameterCollectionInfo.IsPause)
					{
						dBCModifyMaterialParameterCollectionInfo.PlayAtTime += DeltaTime * dBCModifyMaterialParameterCollectionInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCModifyMaterialParameterCollectionInfo.PlayAtTime && !DoModifyMPC(dBCModifyMaterialParameterCollectionInfo))
					{
						value6.RemoveAt(num6);
					}
				}
				else if (!dBCModifyMaterialParameterCollectionInfo.CheckValid())
				{
					OnRealEndModifyMPC(num6, value6);
				}
				else
				{
					dBCModifyMaterialParameterCollectionInfo.GameAge += (dBCModifyMaterialParameterCollectionInfo.IsPause ? 0f : (DeltaTime * dBCModifyMaterialParameterCollectionInfo.CustomTimeDilation));
					if (dBCModifyMaterialParameterCollectionInfo.IsPause && (dBCModifyMaterialParameterCollectionInfo.EndMode == DispLibDBCEndMode.FixDuration || dBCModifyMaterialParameterCollectionInfo.OnEndDispStage))
					{
						dBCModifyMaterialParameterCollectionInfo.EndAtTime += DeltaTime * dBCModifyMaterialParameterCollectionInfo.CustomTimeDilation;
					}
					if (!dBCModifyMaterialParameterCollectionInfo.IsPause)
					{
						ModifyMPCUpdate(dBCModifyMaterialParameterCollectionInfo, DeltaTime * dBCModifyMaterialParameterCollectionInfo.CustomTimeDilation);
					}
					if (dBCModifyMaterialParameterCollectionInfo.OnEndDispStage)
					{
						if (curTime >= dBCModifyMaterialParameterCollectionInfo.EndAtTime)
						{
							OnRealEndModifyMPC(num6, value6);
						}
					}
					else if (dBCModifyMaterialParameterCollectionInfo.EndMode == DispLibDBCEndMode.FixDuration && curTime >= dBCModifyMaterialParameterCollectionInfo.EndAtTime && !CheckAndDoModifyMPCDelayStop(dBCModifyMaterialParameterCollectionInfo, curTime))
					{
						OnRealEndModifyMPC(num6, value6);
					}
				}
			}
		}
		int num7 = 0;
		bool enable = Queue.ModMatScalabilityMgr.Enable;
		int curScalabilityLoopCount = Queue.ModMatScalabilityMgr.CurScalabilityLoopCount;
		int maxAllowRealTickParamEventCount = Queue.ModMatScalabilityMgr.MaxAllowRealTickParamEventCount;
		int num8 = 0;
		foreach (KeyValuePair<uint, List<DBCModifyMaterialInfo>> item7 in Queue.ModifyMaterialCacheQueue)
		{
			List<DBCModifyMaterialInfo> value7 = item7.Value;
			for (int num9 = value7.Count - 1; num9 >= 0; num9--)
			{
				DBCModifyMaterialInfo dBCModifyMaterialInfo = value7[num9];
				if (!dBCModifyMaterialInfo.HasSpawn)
				{
					if (dBCModifyMaterialInfo.IsPause)
					{
						dBCModifyMaterialInfo.PlayAtTime += DeltaTime * dBCModifyMaterialInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCModifyMaterialInfo.PlayAtTime && !DoModifyMaterial(dBCModifyMaterialInfo))
					{
						value7.RemoveAt(num9);
					}
				}
				else if (!dBCModifyMaterialInfo.CheckValid())
				{
					OnRealEndModifyMaterial(num9, value7, Queue.ModMatCSharpObjectPool);
				}
				else
				{
					dBCModifyMaterialInfo.GameAge += (dBCModifyMaterialInfo.IsPause ? 0f : (DeltaTime * dBCModifyMaterialInfo.CustomTimeDilation));
					if (dBCModifyMaterialInfo.IsPause && (dBCModifyMaterialInfo.EndMode == DispLibDBCEndMode.FixDuration || dBCModifyMaterialInfo.OnEndDispStage))
					{
						dBCModifyMaterialInfo.EndAtTime += DeltaTime * dBCModifyMaterialInfo.CustomTimeDilation;
					}
					if (!dBCModifyMaterialInfo.IsPause)
					{
						bool flag = true;
						if (enable)
						{
							if (num8 > maxAllowRealTickParamEventCount)
							{
								flag = false;
							}
							else if (dBCModifyMaterialInfo.Scalability_LastRealUpdateLoopNum > curScalabilityLoopCount)
							{
								dBCModifyMaterialInfo.Scalability_LastRealUpdateLoopNum = curScalabilityLoopCount;
							}
							else if (dBCModifyMaterialInfo.Scalability_LastRealUpdateLoopNum == curScalabilityLoopCount)
							{
								flag = false;
							}
							if (flag)
							{
								num8 += dBCModifyMaterialInfo.Scalability_ParamEventCount;
								dBCModifyMaterialInfo.Scalability_LastRealUpdateLoopNum = curScalabilityLoopCount;
							}
						}
						ModifyMaterialUpdate(dBCModifyMaterialInfo, DeltaTime * dBCModifyMaterialInfo.CustomTimeDilation, flag);
						num7 += dBCModifyMaterialInfo.Scalability_ParamEventCount;
					}
					if (dBCModifyMaterialInfo.OnEndDispStage)
					{
						if (curTime >= dBCModifyMaterialInfo.EndAtTime)
						{
							OnRealEndModifyMaterial(num9, value7, Queue.ModMatCSharpObjectPool);
						}
					}
					else if (dBCModifyMaterialInfo.EndMode == DispLibDBCEndMode.FixDuration && curTime >= dBCModifyMaterialInfo.EndAtTime && !CheckAndDoModifyMaterialDelayStop(dBCModifyMaterialInfo, curTime))
					{
						OnRealEndModifyMaterial(num9, value7, Queue.ModMatCSharpObjectPool);
					}
				}
			}
		}
		if (num7 > maxAllowRealTickParamEventCount)
		{
			Queue.ModMatScalabilityMgr.SetActiveModMatScalability(Active: true);
			Queue.ModMatScalabilityMgr.CurTickLastRealTickParamEventIndex += num8;
			if (num8 == 0 || Queue.ModMatScalabilityMgr.CurTickLastRealTickParamEventIndex >= num7)
			{
				Queue.ModMatScalabilityMgr.CurTickLastRealTickParamEventIndex = 0;
				Queue.ModMatScalabilityMgr.CurScalabilityLoopCount++;
			}
		}
		else
		{
			Queue.ModMatScalabilityMgr.SetActiveModMatScalability(Active: false);
			Queue.ModMatScalabilityMgr.CurScalabilityLoopCount = 1;
			Queue.ModMatScalabilityMgr.CurTickLastRealTickParamEventIndex = 0;
		}
		foreach (KeyValuePair<uint, List<DBCModifyNiagaraParamsInfo>> item8 in Queue.ModifyNiagaraParamsCacheQueue)
		{
			List<DBCModifyNiagaraParamsInfo> value8 = item8.Value;
			for (int num10 = value8.Count - 1; num10 >= 0; num10--)
			{
				DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = value8[num10];
				if (!dBCModifyNiagaraParamsInfo.HasSpawn)
				{
					if (dBCModifyNiagaraParamsInfo.IsPause)
					{
						dBCModifyNiagaraParamsInfo.PlayAtTime += DeltaTime * dBCModifyNiagaraParamsInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCModifyNiagaraParamsInfo.PlayAtTime && !DoModifyNiagaraParams(dBCModifyNiagaraParamsInfo))
					{
						value8.RemoveAt(num10);
					}
				}
				else if (!dBCModifyNiagaraParamsInfo.CheckValid())
				{
					OnRealEndModifyNiagaraParams(num10, value8);
				}
				else
				{
					dBCModifyNiagaraParamsInfo.GameAge += (dBCModifyNiagaraParamsInfo.IsPause ? 0f : (DeltaTime * dBCModifyNiagaraParamsInfo.CustomTimeDilation));
					if (dBCModifyNiagaraParamsInfo.IsPause && (dBCModifyNiagaraParamsInfo.EndMode == DispLibDBCEndMode.FixDuration || dBCModifyNiagaraParamsInfo.OnEndDispStage))
					{
						dBCModifyNiagaraParamsInfo.EndAtTime += DeltaTime * dBCModifyNiagaraParamsInfo.CustomTimeDilation;
					}
					ModifyNiagaraParamsUpdate(dBCModifyNiagaraParamsInfo, DeltaTime * dBCModifyNiagaraParamsInfo.CustomTimeDilation);
					if (dBCModifyNiagaraParamsInfo.OnEndDispStage)
					{
						if (curTime >= dBCModifyNiagaraParamsInfo.EndAtTime)
						{
							OnRealEndModifyNiagaraParams(num10, value8);
						}
					}
					else if (dBCModifyNiagaraParamsInfo.EndMode == DispLibDBCEndMode.FixDuration && curTime >= dBCModifyNiagaraParamsInfo.EndAtTime && !CheckAndDoModifyNiagaraParamsDelayStop(dBCModifyNiagaraParamsInfo, curTime))
					{
						OnRealEndModifyNiagaraParams(num10, value8);
					}
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayArtFresnelInfo>> item9 in Queue.PlayArtFresnelCacheQueue)
		{
			List<DBCPlayArtFresnelInfo> value9 = item9.Value;
			for (int num11 = value9.Count - 1; num11 >= 0; num11--)
			{
				DBCPlayArtFresnelInfo dBCPlayArtFresnelInfo = value9[num11];
				if (dBCPlayArtFresnelInfo.HasSpawn)
				{
					if (dBCPlayArtFresnelInfo.IsPause && dBCPlayArtFresnelInfo.EndMode == DispLibDBCEndMode.FixDuration)
					{
						dBCPlayArtFresnelInfo.EndAtTime += DeltaTime * dBCPlayArtFresnelInfo.CustomTimeDilation;
					}
					if (dBCPlayArtFresnelInfo.EndMode != DispLibDBCEndMode.ProcedureNotity && curTime >= dBCPlayArtFresnelInfo.EndAtTime)
					{
						OnRealEndPlayArtFresnel(num11, value9);
					}
				}
				else if (curTime >= (dBCPlayArtFresnelInfo.IsPause ? (dBCPlayArtFresnelInfo.PlayAtTime += DeltaTime * dBCPlayArtFresnelInfo.CustomTimeDilation) : dBCPlayArtFresnelInfo.PlayAtTime) && !DoPlayArtFresnel(dBCPlayArtFresnelInfo))
				{
					value9.RemoveAt(num11);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCScenePhysicalInteractorInfo>> item10 in Queue.PlaySPICacheQueue)
		{
			List<DBCScenePhysicalInteractorInfo> value10 = item10.Value;
			for (int num12 = value10.Count - 1; num12 >= 0; num12--)
			{
				DBCScenePhysicalInteractorInfo dBCScenePhysicalInteractorInfo = value10[num12];
				if (curTime >= (dBCScenePhysicalInteractorInfo.IsPause ? (dBCScenePhysicalInteractorInfo.PlayAtTime += DeltaTime * dBCScenePhysicalInteractorInfo.CustomTimeDilation) : dBCScenePhysicalInteractorInfo.PlayAtTime))
				{
					DoSPI(dBCScenePhysicalInteractorInfo.SourceDispOwnerComp, dBCScenePhysicalInteractorInfo.SourceRequest);
					value10.RemoveAt(num12);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCSpawnSimpleActorInfo>> item11 in Queue.SpawnSimpleActorCacheQueue)
		{
			List<DBCSpawnSimpleActorInfo> value11 = item11.Value;
			for (int num13 = value11.Count - 1; num13 >= 0; num13--)
			{
				DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = value11[num13];
				if (dBCSpawnSimpleActorInfo.HasSpawn)
				{
					if (dBCSpawnSimpleActorInfo.IsPause && dBCSpawnSimpleActorInfo.EndMode == DispLibDBCEndMode.FixDuration)
					{
						dBCSpawnSimpleActorInfo.EndAtTime += DeltaTime * dBCSpawnSimpleActorInfo.CustomTimeDilation;
					}
					if (dBCSpawnSimpleActorInfo.OnEndDispStage)
					{
						if (curTime >= dBCSpawnSimpleActorInfo.EndAtTime)
						{
							OnRealEndSimpleActor(num13, value11);
						}
					}
					else if (dBCSpawnSimpleActorInfo.EndMode != DispLibDBCEndMode.ProcedureNotity && curTime >= dBCSpawnSimpleActorInfo.EndAtTime && !CheckAndDoSimpleActorDelayStop(dBCSpawnSimpleActorInfo, curTime))
					{
						OnRealEndSimpleActor(num13, value11);
					}
				}
				else if (curTime >= (dBCSpawnSimpleActorInfo.IsPause ? (dBCSpawnSimpleActorInfo.PlayAtTime += DeltaTime * dBCSpawnSimpleActorInfo.CustomTimeDilation) : dBCSpawnSimpleActorInfo.PlayAtTime) && !DoSpawnSimpleActor(dBCSpawnSimpleActorInfo))
				{
					value11.RemoveAt(num13);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayCameraShakeInfo>> item12 in Queue.PlayCameraShakeCacheQueue)
		{
			List<DBCPlayCameraShakeInfo> value12 = item12.Value;
			for (int num14 = value12.Count - 1; num14 >= 0; num14--)
			{
				DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = value12[num14];
				if (dBCPlayCameraShakeInfo.HasSpawn)
				{
					if (dBCPlayCameraShakeInfo.CameraShakeInst.IsNullOrDestroyed() || dBCPlayCameraShakeInfo.CameraShakeInst.OscillatorTimeRemaining <= 0.0001f)
					{
						value12.RemoveAt(num14);
					}
					else if (dBCPlayCameraShakeInfo.IsPause)
					{
						dBCPlayCameraShakeInfo.CameraShakeInst.OscillatorTimeRemaining = dBCPlayCameraShakeInfo.OscillatorTimeRemainingOnPause;
						dBCPlayCameraShakeInfo.CameraShakeInst.ShakeScale = 0f;
					}
					else
					{
						CameraShakeUpdate(dBCPlayCameraShakeInfo, DeltaTime * dBCPlayCameraShakeInfo.CustomTimeDilation);
					}
				}
				else if (curTime >= (dBCPlayCameraShakeInfo.IsPause ? (dBCPlayCameraShakeInfo.PlayAtTime += DeltaTime * dBCPlayCameraShakeInfo.CustomTimeDilation) : dBCPlayCameraShakeInfo.PlayAtTime) && !DoPlayCameraShake(dBCPlayCameraShakeInfo))
				{
					value12.RemoveAt(num14);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayCustomCameraShakeInfo>> item13 in Queue.PlayCustomCameraShakeCacheQueue)
		{
			List<DBCPlayCustomCameraShakeInfo> value13 = item13.Value;
			for (int num15 = value13.Count - 1; num15 >= 0; num15--)
			{
				DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = value13[num15];
				if (dBCPlayCustomCameraShakeInfo.HasSpawn)
				{
					if (dBCPlayCustomCameraShakeInfo.CameraShakeInst.IsNullOrDestroyed())
					{
						value13.RemoveAt(num15);
					}
					else if (dBCPlayCustomCameraShakeInfo.IsPause)
					{
						dBCPlayCustomCameraShakeInfo.CameraShakeInst.OscillatorTimeRemaining = dBCPlayCustomCameraShakeInfo.OscillatorTimeRemainingOnPause;
						dBCPlayCustomCameraShakeInfo.CameraShakeInst.ShakeScale = 0f;
					}
					else if (dBCPlayCustomCameraShakeInfo.OnEndDispStage)
					{
						if (curTime >= dBCPlayCustomCameraShakeInfo.EndAtTime)
						{
							value13.RemoveAt(num15);
						}
					}
					else if (curTime >= dBCPlayCustomCameraShakeInfo.EndAtTime)
					{
						if (!CheckAndDoCustomCameraShakeDelayStop(dBCPlayCustomCameraShakeInfo, curTime))
						{
							value13.RemoveAt(num15);
						}
					}
					else
					{
						CustomCameraShakeUpdate(dBCPlayCustomCameraShakeInfo, DeltaTime * dBCPlayCustomCameraShakeInfo.CustomTimeDilation);
					}
				}
				else if (curTime >= (dBCPlayCustomCameraShakeInfo.IsPause ? (dBCPlayCustomCameraShakeInfo.PlayAtTime += DeltaTime * dBCPlayCustomCameraShakeInfo.CustomTimeDilation) : dBCPlayCustomCameraShakeInfo.PlayAtTime) && !DoPlayCustomCameraShake(dBCPlayCustomCameraShakeInfo))
				{
					value13.RemoveAt(num15);
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCPlayAudioInfo>> item14 in Queue.PlayAudioCacheQueue)
		{
			List<DBCPlayAudioInfo> value14 = item14.Value;
			for (int num16 = value14.Count - 1; num16 >= 0; num16--)
			{
				DBCPlayAudioInfo dBCPlayAudioInfo = value14[num16];
				if (!dBCPlayAudioInfo.HasSpawn)
				{
					if (dBCPlayAudioInfo.IsPause)
					{
						dBCPlayAudioInfo.PlayAtTime += DeltaTime * dBCPlayAudioInfo.CustomTimeDilation;
					}
					else if (curTime >= dBCPlayAudioInfo.PlayAtTime && !DoPlayAudio(dBCPlayAudioInfo))
					{
						value14.RemoveAt(num16);
					}
				}
				else
				{
					if (!dBCPlayAudioInfo.IsPause)
					{
						AudioUpdate(dBCPlayAudioInfo, DeltaTime * dBCPlayAudioInfo.CustomTimeDilation);
					}
					switch (dBCPlayAudioInfo.EndMode)
					{
					case DispLibDBCEndMode.FixDuration:
						if (dBCPlayAudioInfo.IsPause)
						{
							dBCPlayAudioInfo.EndAtTime += DeltaTime * dBCPlayAudioInfo.CustomTimeDilation;
						}
						if (curTime >= dBCPlayAudioInfo.EndAtTime)
						{
							OnRealEndPlayAudio(num16, value14);
						}
						break;
					}
				}
			}
		}
		foreach (KeyValuePair<uint, List<DBCCustomEventInfo>> item15 in Queue.CustomEventsCacheQueue)
		{
			List<DBCCustomEventInfo> value15 = item15.Value;
			for (int num17 = value15.Count - 1; num17 >= 0; num17--)
			{
				DBCCustomEventInfo dBCCustomEventInfo = value15[num17];
				if (dBCCustomEventInfo.HasTrigger)
				{
					switch (dBCCustomEventInfo.RealEndMode)
					{
					case DispLibDBCEndMode.FixDuration:
						if (dBCCustomEventInfo.IsPause)
						{
							dBCCustomEventInfo.EndAtTime += DeltaTime * dBCCustomEventInfo.CustomTimeDilation;
						}
						if (dBCCustomEventInfo.OnEndDispStage)
						{
							if (curTime >= dBCCustomEventInfo.EndAtTime)
							{
								OnRealEndCustomEvent(num17, value15);
							}
						}
						else if (curTime >= dBCCustomEventInfo.EndAtTime && !CheckAndDoCustomEventDelayStop(dBCCustomEventInfo, curTime))
						{
							OnRealEndCustomEvent(num17, value15);
						}
						break;
					}
				}
				else if (curTime >= (dBCCustomEventInfo.IsPause ? (dBCCustomEventInfo.PlayAtTime += DeltaTime * dBCCustomEventInfo.CustomTimeDilation) : dBCCustomEventInfo.PlayAtTime) && !DoCustomEvent(dBCCustomEventInfo))
				{
					value15.RemoveAt(num17);
				}
			}
		}
		DoMPCUpdate();
		DoDBCMergeNiagaraUpdate(curTime);
	}

	private void DoDBCMergeNiagaraUpdate(float CurTime)
	{
		for (int num = Queue.DBCMergeNiagaraData.Count - 1; num >= 0; num--)
		{
			DBCMergeNiagaraMangerInfo value = Queue.DBCMergeNiagaraData.ElementAt(num).Value;
			if (!value.IsValid())
			{
				Queue.DBCMergeNiagaraData.Remove(value.MangerSystemTemplateUniqueID);
				Internal_CleanAndRealEndDBCMergeNiagaraManger(value);
			}
			bool flag = false;
			bool flag2 = false;
			int num2 = 0;
			int num3 = 0;
			for (int num4 = value.CachedChildDBCNiagaraEventInfo.Count - 1; num4 >= 0; num4--)
			{
				KeyValuePair<uint, DBCMergeNiagaraMangerInfo.CachedChildEventInfo> keyValuePair = value.CachedChildDBCNiagaraEventInfo.ElementAt(num4);
				uint key = keyValuePair.Key;
				DBCMergeNiagaraMangerInfo.CachedChildEventInfo value2 = keyValuePair.Value;
				if (value2 == null || value2.Info == null)
				{
					value.CachedChildDBCNiagaraEventInfo.Remove(key);
					continue;
				}
				int eventIndex = value2.EventIndex;
				DBCPlayAdvanceNiagaraInfo info = value2.Info;
				if (value2.Info.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.HasSpawn)
				{
					value.MgrArray_CurTickValidChildEventIndex[num3] = value2.EventIndex;
					num3++;
				}
				if (value2.isCurTickDoPlay && info.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.HasSpawn)
				{
					if (info.FXAttachComp.IsNullOrDestroyed())
					{
						value.CachedChildDBCNiagaraEventInfo.Remove(key);
						continue;
					}
					flag2 = true;
					flag = true;
					value.MgrArray_CurTickNewDoPlayChildEventIndex[num2] = eventIndex;
					num2++;
					value2.SpawnInfoHasSendToMgr = true;
					value2.isCurTickDoPlay = false;
					value.MgrArray_CurTickChildEventLifeState[eventIndex] = new FVector(info.GameAge, 1.0, 0.0);
					Internal_ResolveSpawnNiagaraTransformInfo(out var _, out var _, out var FinalLocationParam, out var FinalRotationParam, out var FinalScaleParam, out var _, info.FXAttachComp, AttachedTarget: false, info.AttachedTargetSocketName, info.OffsetInLocalSpace, info.AttachedTargetLocationOffset, info.AttachedTargetRotatorOffset, info.SourceRequest.Scale, info.DBCOverrideTransform, info.SourceRequest.SetDBCTransformAsParam);
					value.MgrArray_SystemPosWS[eventIndex] = FinalLocationParam;
					if (value.SendRotation)
					{
						value.MgrArray_SystemRotationWS[eventIndex] = FinalRotationParam.Quaternion();
					}
					if (value.SendScaleAtEventSpawn)
					{
						value.MgrArray_SystemScaleWS[eventIndex] = FinalScaleParam;
					}
				}
				else if (info.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.ReleaseToPool || info.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.ForceDestroy || info.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.Deactivate)
				{
					flag = true;
					value.MgrArray_CurTickChildEventLifeState[eventIndex] = new FVector(info.GameAge, -200.0, 0.0);
					value.CachedChildDBCNiagaraEventInfo.Remove(key);
				}
				else if (info.OnEndDispStage)
				{
					flag = true;
					float x = (CurTime - info.EndDispStageStartTime) / info.EndDispStageStartTime;
					x = MathLib.Clamp(x, 0f, 1f);
					value.MgrArray_CurTickChildEventLifeState[eventIndex] = new FVector(info.GameAge, x, 0.0);
				}
				else
				{
					flag = true;
					value.MgrArray_CurTickChildEventLifeState[eventIndex] = new FVector(info.GameAge, 1.0, 0.0);
				}
				if (info.isAttach_RealAttach && !info.FXAttachComp.IsNullOrDestroyed())
				{
					flag2 = true;
					FTransform socketTransform = info.FXAttachComp.GetSocketTransform(info.AttachedTargetSocketName);
					FVector fVector;
					FRotator fRotator;
					if (info.OffsetInLocalSpace)
					{
						fVector = socketTransform.TransformPositionNoScale(info.AttachedTargetLocationOffset);
						fRotator = socketTransform.TransformRotation(info.AttachedTargetRotatorOffset);
					}
					else
					{
						fVector = socketTransform.GetLocation() + info.AttachedTargetLocationOffset;
						fRotator = socketTransform.Rotator() + info.AttachedTargetRotatorOffset;
					}
					value.MgrArray_SystemPosWS[eventIndex] = fVector;
					if (value.SendRotation)
					{
						value.MgrArray_SystemRotationWS[eventIndex] = fRotator.Quaternion();
					}
					if (value.SendScaleEveryTick)
					{
						FVector fVector2 = socketTransform.GetScale3D() * info.SourceRequest.Scale;
						value.MgrArray_SystemScaleWS[eventIndex] = fVector2;
					}
				}
			}
			UNiagaraComponent uNiagaraComponent = value.MangerSystemComp.Get();
			bool num5 = num2 > 0 || value.PreTickHasSendNewEvent;
			value.PreTickHasSendNewEvent = num2 > 0;
			int count = value.MgrArray_CurTickChildEventLifeState.Length;
			if (num5)
			{
				uNiagaraComponent.SetBoolParameter(B1GlobalFNames.GS_M_CurTickHasNewEvent, num2 > 0);
				uNiagaraComponent.SetIntParameter(B1GlobalFNames.GS_M_CurTickNewEventNum, num2);
				GSE_NiagaraFunc.SetNiagaraArrayInt32(uNiagaraComponent.Address, B1GlobalFNames.GS_M_CurTickNewEventIndex_Array, value.MgrArray_CurTickNewDoPlayChildEventIndex, count);
			}
			GSE_NiagaraFunc.SetNiagaraArrayVector(uNiagaraComponent.Address, B1GlobalFNames.GS_M_EventLifeState_Array, value.MgrArray_CurTickChildEventLifeState, count);
			if (flag2)
			{
				GSE_NiagaraFunc.SetNiagaraArrayVector(uNiagaraComponent.Address, B1GlobalFNames.GS_M_SystemPosWS_Array, value.MgrArray_SystemPosWS, count);
				if (value.SendRotation)
				{
					GSE_NiagaraFunc.SetNiagaraArrayQuat(uNiagaraComponent.Address, B1GlobalFNames.GS_M_SystemRotationWS_Array, value.MgrArray_SystemRotationWS, count);
				}
				if (value.SendScaleAtEventSpawn)
				{
					GSE_NiagaraFunc.SetNiagaraArrayVector(uNiagaraComponent.Address, B1GlobalFNames.GS_M_SystemScaleWS_Array, value.MgrArray_SystemScaleWS, count);
				}
			}
			if (flag)
			{
				uNiagaraComponent.SetBoolParameter(B1GlobalFNames.GS_M_CurTickHasValidEvent, num3 > 0);
				uNiagaraComponent.SetIntParameter(B1GlobalFNames.GS_M_CurTickValidEventNum, num3);
				GSE_NiagaraFunc.SetNiagaraArrayInt32(uNiagaraComponent.Address, B1GlobalFNames.GS_M_ValidEventIndex_Array, value.MgrArray_CurTickValidChildEventIndex, count);
			}
			if (value.PreTickHasSendCustomDataEvent)
			{
				if (value.MgrArray_CustomVectorData != null)
				{
					foreach (KeyValuePair<string, FVector[]> mgrArray_CustomVectorDatum in value.MgrArray_CustomVectorData)
					{
						if (mgrArray_CustomVectorDatum.Value != null)
						{
							GSE_NiagaraFunc.SetNiagaraArrayVector(uNiagaraComponent.Address, value.MgrArray_CustomVectorParamNameMapping[mgrArray_CustomVectorDatum.Key], mgrArray_CustomVectorDatum.Value, mgrArray_CustomVectorDatum.Value.Length);
						}
					}
				}
				value.PreTickHasSendCustomDataEvent = false;
			}
			if (value.CachedChildDBCNiagaraEventInfo.Count == 0)
			{
				if (value.ChildEventQueueSleepAtTime < 0f)
				{
					value.ChildEventQueueSleepAtTime = CurTime;
				}
				if (CurTime - value.ChildEventQueueSleepAtTime >= 10f)
				{
					Queue.DBCMergeNiagaraData.Remove(value.MangerSystemTemplateUniqueID);
					Internal_CleanAndRealEndDBCMergeNiagaraManger(value);
				}
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1280;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		switch (TickGroup)
		{
		case 256:
			DispLibCameraData.LastFrameCameraPosWS = DispLibCameraData.CurFrameCameraPosWS;
			break;
		case 1024:
			OnTick(DeltaTime);
			break;
		}
	}

	public static bool TargetCompIsInvalid(USceneComponent TargetComp)
	{
		return TargetComp.IsNullOrDestroyed();
	}

	public bool ValidateDBC(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent DispOwnerComp)
	{
		if (DBCDataAsset.IsNullOrDestroyed() || DispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayNiagara(BUC_DispLibDBC_PlayNiagara D)
	{
		if (D.Template == null)
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayCascade(BUC_DispLibDBC_PlayCascade D)
	{
		if (D.Template == null)
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayAdvanceNiagara(BUC_DispLibDBC_PlayAdvanceNiagara D)
	{
		if (D.Template == null)
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayArtFresnel(BUC_DispLibDBC_PlayArtFresnel DBC_PlayAF)
	{
		if (DBC_PlayAF.CustomUAFDataAsset.IsNullOrDestroyed() || !DBC_PlayAF.FilterMode.isVaild())
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCSpawnSimpleActor(BUC_DispLibDBC_SpawnSimpleActor D)
	{
		if (D.Template == null)
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayCameraShake(BUC_DispLibDBC_PlayCameraShake DBC_PlayCameraShake)
	{
		if (DBC_PlayCameraShake.CameraShake == null)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCPlayCustomCameraShake(BUC_DispLibDBC_PlayCustomCameraShake DBC_PlayCustomCameraShake)
	{
		if (DBC_PlayCustomCameraShake.TotalTime <= 0f || (!DBC_PlayCustomCameraShake.CtrlRO && !DBC_PlayCustomCameraShake.CtrlLO && !DBC_PlayCustomCameraShake.CtrlFOV))
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCModifyMPC(BUC_DispLibDBC_ModifyMaterialParameterCollection D)
	{
		if (D.MPCAssetPath == string.Empty)
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		if (D.SetScalarParam.Count > 0 || D.SetFLinearColorParam.Count > 0 || D.SetPCurveScalarParam.Count > 0 || D.SetPCurveFLinearColorParam.Count > 0)
		{
			return true;
		}
		return false;
	}

	public static bool ValidateDBCWEFMWind(BUC_DispLibDBC_WEFMWind D)
	{
		if (D.Radius.IsZeroData() || D.WindMotorMode == DispLibDBCWindMotorMode.NoWind)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCScenePhysicalInteractor(BUC_DispLibDBC_ScenePhysicalInteractor D)
	{
		if (D.EffectSize.X <= 0f || D.EffectSize.Y <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCChangeMaterial(BUC_DispLibDBC_ChangeMaterial D)
	{
		if (D.Template == null || !D.FilterMode.isVaild())
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCModifyMaterial(BUC_DispLibDBC_ModifyMaterial D)
	{
		if (!D.FilterMode.isVaild())
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCModifyNiagaraParams(BUC_DispLibDBC_ModifyNiagaraParams D)
	{
		if (!D.MeshCompFilterInfo.isVaild())
		{
			return false;
		}
		if (!D.NiagaraCompFilterInfo.isVaild())
		{
			return false;
		}
		if (D.EndMode == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	public static bool ValidateDBCCustomEvent(BUC_DispLibDBC_CustomEvent D)
	{
		if (D.ParametersDataAssets.IsNullOrDestroyed() || D.ParametersDataAssets.GetEventType() == DispLibDBCCustomEventType.None)
		{
			return false;
		}
		if ((D.ParametersDataAssets.AllowOverrideEndMode() ? D.EndMode : D.ParametersDataAssets.GetDefaultEndMode()) == DispLibDBCEndMode.FixDuration && D.Duration <= 0f)
		{
			return false;
		}
		return true;
	}

	private void BrokenCommonNiagaraEndDispStage(DBCPlayNiagaraInfo Info, float CurTime)
	{
		Info.EndAtTime = CurTime;
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (!uNiagaraComponent.IsNullOrDestroyed())
		{
			uNiagaraComponent.SetFloatParameter(B1GlobalFNames.User_GS_EfxEndDispStageTime, 0f);
		}
	}

	private bool CheckAndDoNiagaraDelayStop(DBCPlayNiagaraInfo Info, float CurTime, int EndStagePriority, bool ForceDeleteComponentOnDestroy)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				BrokenCommonNiagaraEndDispStage(Info, CurTime);
				return false;
			}
			return true;
		}
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		DispLibDBCNiagaraInstanceState nGInstanceLifeState = Info.NGInstanceLifeState;
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			if (nGInstanceLifeState != DispLibDBCNiagaraInstanceState.BeReuseByScalability)
			{
				BGW_LogUtil.LogError("DBC CommonNiagara check DelayStop but NC is NULL. TPath = " + Info.SourceRequest.Template.GetPathName(), P1: false, GetOwner());
			}
			return false;
		}
		if (nGInstanceLifeState != DispLibDBCNiagaraInstanceState.HasSpawn)
		{
			_ = 7;
			return false;
		}
		if (Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			if (Info.PreEndCallback != null)
			{
				Info.PreEndCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent));
				if (uNiagaraComponent.IsNullOrDestroyed())
				{
					BGW_LogUtil.LogError("DBC CommonNiagara PreEndCallback destroy the NC. TPath = " + Info.SourceRequest.Template.GetPathName(), P1: false, GetOwner());
					Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ExternalDestroy;
					Info.NiagaraComponent.Set(null);
					return false;
				}
			}
		}
		if (Info.SourceRequest.DetachOnEndDispStageBegin)
		{
			uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
		}
		uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
		uNiagaraComponent.SetFloatParameter(B1GlobalFNames.User_GS_EfxEndDispStageTime, Info.DelayTimeAfterStop);
		if (Info.SourceRequest.DestroyTiming == DispLibDBCEffectDestroyTiming.OnEndDispStageStart)
		{
			DestroyOrReleaseNiagaraInstance(Info, ForceDeleteComponentOnDestroy);
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				BrokenCommonNiagaraEndDispStage(Info, CurTime);
				return false;
			}
			return true;
		}
		return false;
	}

	private void BrokenAdvNiagaraEndDispStage(DBCPlayAdvanceNiagaraInfo Info, float CurTime)
	{
		Info.EndAtTime = CurTime;
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (!Info.IS_MERGED_REQUEST && !uNiagaraComponent.IsNullOrDestroyed())
		{
			uNiagaraComponent.SetFloatParameter(B1GlobalFNames.User_GS_EfxEndDispStageTime, 0f);
		}
	}

	private bool CheckAndDoAdvNiagaraDelayStop(DBCPlayAdvanceNiagaraInfo Info, float CurTime, int EndStagePriority, bool ForceDeleteComponentOnDestroy)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				BrokenAdvNiagaraEndDispStage(Info, CurTime);
				return false;
			}
			return true;
		}
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		DispLibDBCNiagaraInstanceState nGInstanceLifeState = Info.NGInstanceLifeState;
		if (!Info.IS_MERGED_REQUEST && uNiagaraComponent.IsNullOrDestroyed())
		{
			_ = 7;
			return false;
		}
		if (nGInstanceLifeState != DispLibDBCNiagaraInstanceState.HasSpawn)
		{
			_ = 7;
			return false;
		}
		if (Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndDispStageStartTime = CurTime;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			if (Info.PreEndCallback != null)
			{
				Info.PreEndCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent));
				if (!Info.IS_MERGED_REQUEST && uNiagaraComponent.IsNullOrDestroyed())
				{
					Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ExternalDestroy;
					Info.NiagaraComponent.Set(null);
					return false;
				}
			}
		}
		if (!Info.IS_MERGED_REQUEST)
		{
			if (Info.SourceRequest.DetachOnEndDispStageBegin)
			{
				uNiagaraComponent.DetachFromParent(bMaintainWorldPosition: true);
			}
			uNiagaraComponent.SetVariableBool(B1GlobalFNames.User_GS_EfxStop, InValue: true);
			uNiagaraComponent.SetFloatParameter(B1GlobalFNames.User_GS_EfxEndDispStageTime, Info.DelayTimeAfterStop);
		}
		if (Info.SourceRequest.DestroyTiming == DispLibDBCEffectDestroyTiming.OnEndDispStageStart)
		{
			DestroyOrReleaseAdvanceNiagaraInstance(Info, ForceDeleteComponentOnDestroy);
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				BrokenAdvNiagaraEndDispStage(Info, CurTime);
				return false;
			}
			return true;
		}
		return false;
	}

	private bool CheckAndDoChangeMaterialDelayStop(DBCChangeMaterialInfo Info, float CurTime, int EndStagePriority = -1)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (Info.ChangeMatEventID < 0)
		{
			return false;
		}
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		if (!flag && Info.DelayTimeAfterStop >= 0.001f)
		{
			UMeshComponent uMeshComponent = Info.SourceDispOwnerComp as UMeshComponent;
			if (uMeshComponent.IsNullOrDestroyed())
			{
				return false;
			}
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			Info.EndStageStartTime = CurTime;
			List<UMaterialInterface> materials = uMeshComponent.GetMaterials();
			if (materials.Count == 0 || materials[0].IsNullOrDestroyed())
			{
				return false;
			}
			UMaterialInstanceDynamic uMaterialInstanceDynamic = materials[0] as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic.IsNullOrDestroyed())
			{
				return false;
			}
			for (int i = 0; i < Info.EndStage_SetPCurveScalarParam.Count; i++)
			{
				BUC_DispLibUtil_PCurve_NameAndScalar value = Info.EndStage_SetPCurveScalarParam[i];
				value.ValueOnBreak = uMaterialInstanceDynamic.GetScalarParameterValue(value.ParamName);
				Info.EndStage_SetPCurveScalarParam[i] = value;
			}
			for (int j = 0; j < Info.EndStage_SetPCurveLColorParam.Count; j++)
			{
				BUC_DispLibUtil_PCurve_NameAndLColor value2 = Info.EndStage_SetPCurveLColorParam[j];
				value2.ValueOnBreak = uMaterialInstanceDynamic.GetVectorParameterValue(value2.ParamName);
				Info.EndStage_SetPCurveLColorParam[j] = value2;
			}
			return true;
		}
		return false;
	}

	private bool CheckAndDoModifyMPCDelayStop(DBCModifyMaterialParameterCollectionInfo Info, float CurTime, int EndStagePriority = -1)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		if (!flag && Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			Info.EndStageStartTime = CurTime;
			foreach (DBCAdvProcessScalarParam scalarParam in Info.ScalarParams)
			{
				scalarParam.SetEnd();
			}
			foreach (DBCAdvProcessFLinearColorParam fLinearColorParam in Info.FLinearColorParams)
			{
				fLinearColorParam.SetEnd();
			}
			foreach (DBCPCurveScalarParam pCurveScalarParam in Info.PCurveScalarParams)
			{
				pCurveScalarParam.SetEnd();
			}
			foreach (DBCPCurveLinearColorParam pCurveFLinearColorParam in Info.PCurveFLinearColorParams)
			{
				pCurveFLinearColorParam.SetEnd();
			}
			return true;
		}
		return false;
	}

	private bool CheckAndDoModifyNiagaraParamsDelayStop(DBCModifyNiagaraParamsInfo Info, float CurTime, int EndStagePriority = -1)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		if (!flag && Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			Info.EndStageStartTime = CurTime;
			foreach (ModifyNiagaraParamsBoolParamInfo item in Info.BoolParamsInfo)
			{
				item.SetEnd();
			}
			foreach (ModifyNiagaraParamsFloatParamInfo item2 in Info.FloatParamsInfo)
			{
				item2.SetEnd();
			}
			foreach (ModifyNiagaraParamsFloatParamInfo item3 in Info.Int32ParamsInfo)
			{
				item3.SetEnd();
			}
			foreach (ModifyNiagaraParamsFVectorParamInfo item4 in Info.FVectorParamsInfo)
			{
				item4.SetEnd();
			}
			foreach (ModifyNiagaraParamsFLinearColorParamInfo item5 in Info.FLinearColorParamsInfo)
			{
				item5.SetEnd();
			}
			return true;
		}
		return false;
	}

	private bool CheckAndDoModifyMaterialDelayStop(DBCModifyMaterialInfo Info, float CurTime, int EndStagePriority = -1)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (Info.MatManagerReturnID == 0)
		{
			return false;
		}
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		if (!flag && Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			Info.EndStageStartTime = CurTime;
			foreach (DBCAdvProcessScalarMatLayerParam scalarParam in Info.ScalarParams)
			{
				scalarParam.SetEnd();
			}
			foreach (DBCAdvProcessFLinearColorMatLayerParam fLinearColorParam in Info.FLinearColorParams)
			{
				fLinearColorParam.SetEnd();
			}
			foreach (DBCPCurveScalarMatLayerParam pCurveScalarParam in Info.PCurveScalarParams)
			{
				pCurveScalarParam.SetEnd();
			}
			foreach (DBCPCurveLinearColorMatLayerParam pCurveFLinearColorParam in Info.PCurveFLinearColorParams)
			{
				pCurveFLinearColorParam.SetEnd();
			}
			BUS_DispLibEventCollection eventCollection = Info.EventCollection;
			if (eventCollection != null)
			{
				for (int i = 0; i < Info.ScalarParams.Count; i++)
				{
					DBCAdvProcessScalarMatLayerParam dBCAdvProcessScalarMatLayerParam = Info.ScalarParams[i];
					eventCollection.Evt_ScalarParamResetPriority(Info.FilterMode, dBCAdvProcessScalarMatLayerParam.Association, dBCAdvProcessScalarMatLayerParam.LayerFunction, dBCAdvProcessScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				}
				for (int j = 0; j < Info.FLinearColorParams.Count; j++)
				{
					DBCAdvProcessFLinearColorMatLayerParam dBCAdvProcessFLinearColorMatLayerParam = Info.FLinearColorParams[j];
					eventCollection.Evt_ColorParamResetPriority(Info.FilterMode, dBCAdvProcessFLinearColorMatLayerParam.Association, dBCAdvProcessFLinearColorMatLayerParam.LayerFunction, dBCAdvProcessFLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				}
				for (int k = 0; k < Info.TextureParams.Count; k++)
				{
					DBCTextureMatLayerParam dBCTextureMatLayerParam = Info.TextureParams[k];
					eventCollection.Evt_TextureParamResetPriority(Info.FilterMode, dBCTextureMatLayerParam.Association, dBCTextureMatLayerParam.LayerFunction, dBCTextureMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				}
				for (int l = 0; l < Info.PCurveScalarParams.Count; l++)
				{
					DBCPCurveScalarMatLayerParam dBCPCurveScalarMatLayerParam = Info.PCurveScalarParams[l];
					eventCollection.Evt_ScalarParamResetPriority(Info.FilterMode, dBCPCurveScalarMatLayerParam.Association, dBCPCurveScalarMatLayerParam.LayerFunction, dBCPCurveScalarMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				}
				for (int m = 0; m < Info.PCurveFLinearColorParams.Count; m++)
				{
					DBCPCurveLinearColorMatLayerParam dBCPCurveLinearColorMatLayerParam = Info.PCurveFLinearColorParams[m];
					eventCollection.Evt_ColorParamResetPriority(Info.FilterMode, dBCPCurveLinearColorMatLayerParam.Association, dBCPCurveLinearColorMatLayerParam.LayerFunction, dBCPCurveLinearColorMatLayerParam.ParamName, Info.MatManagerReturnID, default(FName), Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
				}
			}
			return true;
		}
		return false;
	}

	private bool CheckAndDoCustomCameraShakeDelayStop(DBCPlayCustomCameraShakeInfo Info, float CurTime, bool ForceNoEndStage = false)
	{
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (ForceNoEndStage)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		bool result = false;
		float delayTimeAfterStop = Info.SourceRequest.DelayTimeAfterStop;
		if (!ForceNoEndStage && delayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + delayTimeAfterStop;
			Info.CameraShakeInst.OscillatorTimeRemaining = delayTimeAfterStop;
			if (Info.RO_PCurveDataArray != null)
			{
				for (int i = 0; i < 6; i++)
				{
					Info.RO_PCurveDataArray[i].SetEnd();
				}
			}
			if (Info.LO_PCurveDataArray != null)
			{
				for (int j = 0; j < 6; j++)
				{
					Info.LO_PCurveDataArray[j].SetEnd();
				}
			}
			if (Info.FOV_PCurveDataArray != null)
			{
				for (int k = 0; k < 2; k++)
				{
					Info.FOV_PCurveDataArray[k].SetEnd();
				}
			}
			result = true;
		}
		return result;
	}

	private bool CheckAndDoSimpleActorDelayStop(DBCSpawnSimpleActorInfo Info, float CurTime, int EndStagePriority = -1)
	{
		bool flag = Info.EndStagePriority < EndStagePriority || EndStagePriority == int.MaxValue;
		if (Info.SpawnedSimpleActor.IsNullOrDestroyed())
		{
			return false;
		}
		if (!Info.HasSpawn)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (flag)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		bool result = false;
		if (!flag && Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			if (Info.PreEndCallback != null)
			{
				Info.PreEndCallback(DispLibRefParam.Instance.Set(Info.IdentityID, Info.SpawnedSimpleActor));
				if (Info.SpawnedSimpleActor.IsNullOrDestroyed())
				{
					return false;
				}
			}
			result = true;
		}
		if (Info.SourceRequest.DetachOnEndDispStageBegin)
		{
			Info.SpawnedSimpleActor.DetachRootComponentFromParent();
		}
		Info.SpawnedSimpleActor.GetComponentByClass<DispLib_DBCSimpleActorBaseData>()?.Evt_OnEndStageStart(Info.DelayTimeAfterStop);
		return result;
	}

	private bool CheckAndDoCustomEventDelayStop(DBCCustomEventInfo Info, float CurTime, bool ForceNoEndStage = false)
	{
		if (!Info.HasTrigger)
		{
			return false;
		}
		if (Info.OnEndDispStage)
		{
			if (ForceNoEndStage)
			{
				Info.EndAtTime = CurTime;
				return false;
			}
			return true;
		}
		if (!ForceNoEndStage && Info.DelayTimeAfterStop >= 0.001f)
		{
			Info.OnEndDispStage = true;
			Info.EndAtTime = CurTime + Info.DelayTimeAfterStop;
			BUS_DispLibEventCollection.Get(Info.SourceDispOwnerComp.GetOwner())?.Evt_DBCOneCustomEventTriggerEndDispStage(Info.IdentityID, Info.CustomEventID);
		}
		return Info.OnEndDispStage;
	}

	private void LogDBCEffectState()
	{
	}

	private void Debug_CacheLogAllNiagara()
	{
	}

	protected virtual UParticleSystemComponent DBCUtilSpawnCascade(USceneComponent SourceDispOwnerComp, DispLibDBCEndMode EndMode, UParticleSystem Template, bool DeactiveAtSpawn, bool AttachedTarget, FName AttachedTargetSocketName, FVector LocationOffset, FRotator RotationOffset, FVector Scale, int TranslucentSortPriority, DBCTransformParam DBCOverrideTransform = default(DBCTransformParam))
	{
		if (SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return null;
		}
		UParticleSystemComponent uParticleSystemComponent = null;
		EPSCPoolMethod pSCPoolMethodByDBCEndMode = DispLibFuncUtil.GetPSCPoolMethodByDBCEndMode(EndMode);
		bool flag = AttachedTarget;
		if (DBCOverrideTransform.AttachType != DBCTransformOverrdieAttachType.NoOverrdie)
		{
			flag = DBCOverrideTransform.AttachType == DBCTransformOverrdieAttachType.Attach;
		}
		if (flag)
		{
			FVector location = ((!DBCOverrideTransform.UseLocation) ? LocationOffset : (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.GetLocation() + LocationOffset) : DBCOverrideTransform.Transform.GetLocation()));
			FRotator rotation = ((!DBCOverrideTransform.UseRotation) ? RotationOffset : (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.GetRotation().Rotator() + RotationOffset) : DBCOverrideTransform.Transform.GetRotation().Rotator()));
			uParticleSystemComponent = UGameplayStatics.SpawnEmitterAttached(Template, SourceDispOwnerComp, AttachedTargetSocketName, location, rotation, FVector.OneVector, EAttachLocation.KeepRelativeOffset, bAutoDestroy: false, pSCPoolMethodByDBCEndMode, bAutoActivate: false);
		}
		else
		{
			FTransform socketTransform = SourceDispOwnerComp.GetSocketTransform(AttachedTargetSocketName);
			FVector location2 = ((!DBCOverrideTransform.UseLocation) ? (socketTransform.GetLocation() + LocationOffset) : (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.GetLocation() + LocationOffset) : DBCOverrideTransform.Transform.GetLocation()));
			FRotator rotation2 = ((!DBCOverrideTransform.UseRotation) ? (socketTransform.GetRotation().Rotator() + RotationOffset) : (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.GetRotation().Rotator() + RotationOffset) : DBCOverrideTransform.Transform.GetRotation().Rotator()));
			uParticleSystemComponent = UGameplayStatics.SpawnEmitterAtLocation(SourceDispOwnerComp, Template, location2, rotation2, FVector.OneVector, bAutoDestroy: false, pSCPoolMethodByDBCEndMode, bAutoActivateSystem: false);
		}
		if (uParticleSystemComponent == null)
		{
			return null;
		}
		FVector fVector = ((Scale == default(FVector)) ? FVector.OneVector : Scale);
		FVector oneVector = FVector.OneVector;
		oneVector = ((!DBCOverrideTransform.UseScale) ? fVector : (DBCOverrideTransform.Transform.GetScale3D() * (DBCOverrideTransform.AddDataAssetOffset ? fVector : FVector.OneVector)));
		if (oneVector != FVector.OneVector)
		{
			uParticleSystemComponent.SetRelativeScale3D(oneVector);
		}
		uParticleSystemComponent.SetTranslucentSortPriority(TranslucentSortPriority);
		if (!DeactiveAtSpawn)
		{
			uParticleSystemComponent.SetActive(bNewActive: true);
		}
		return uParticleSystemComponent;
	}

	private static void Internal_ResolveSpawnNiagaraTransformInfo(out bool SimpleSpawn, out bool FinalAttachParam, out FVector FinalLocationParam, out FRotator FinalRotationParam, out FVector FinalScaleParam, out bool FinalScaleIsRelativeScale, USceneComponent FXAttachComp, bool AttachedTarget, FName AttachedTargetSocketName, bool OffsetInLocalSpace, FVector LocationOffset, FRotator RotationOffset, FVector Scale, DBCTransformParam DBCOverrideTransform = default(DBCTransformParam), bool SetDBCTransformAsParam = false)
	{
		SimpleSpawn = SetDBCTransformAsParam || !DBCOverrideTransform.IsValid();
		if (SimpleSpawn)
		{
			FinalAttachParam = AttachedTarget;
			if (AttachedTarget)
			{
				FinalLocationParam = LocationOffset;
				FinalRotationParam = RotationOffset;
			}
			else
			{
				FTransform socketTransform = FXAttachComp.GetSocketTransform(AttachedTargetSocketName);
				if (OffsetInLocalSpace)
				{
					FinalLocationParam = socketTransform.TransformPositionNoScale(LocationOffset);
				}
				else
				{
					FinalLocationParam = socketTransform.GetLocation() + LocationOffset;
				}
				if (OffsetInLocalSpace)
				{
					FinalRotationParam = socketTransform.TransformRotation(RotationOffset);
				}
				else
				{
					FinalRotationParam = socketTransform.Rotator() + RotationOffset;
				}
			}
			FinalScaleParam = ((Scale == FVector.ZeroVector) ? FVector.OneVector : Scale);
			FinalScaleIsRelativeScale = true;
			return;
		}
		FTransform socketTransform2 = FXAttachComp.GetSocketTransform(AttachedTargetSocketName);
		FTransform relativeTransform = socketTransform2.GetRelativeTransform(DBCOverrideTransform.Transform);
		FinalAttachParam = AttachedTarget;
		if (DBCOverrideTransform.AttachType != DBCTransformOverrdieAttachType.NoOverrdie)
		{
			FinalAttachParam = DBCOverrideTransform.AttachType == DBCTransformOverrdieAttachType.Attach;
		}
		if (FinalAttachParam)
		{
			FinalLocationParam = LocationOffset;
			if (DBCOverrideTransform.UseLocation)
			{
				switch (DBCOverrideTransform.LocationType)
				{
				case DBCTransformType.Absolute:
					FinalLocationParam = (DBCOverrideTransform.AddDataAssetOffset ? (relativeTransform.GetLocation() + LocationOffset) : relativeTransform.GetLocation());
					break;
				case DBCTransformType.OffsetInSocketLocalSpace:
					FinalLocationParam = socketTransform2.TransformVectorNoScale(DBCOverrideTransform.Transform.GetLocation());
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalLocationParam += LocationOffset;
					}
					break;
				case DBCTransformType.OffsetInWorldSpace:
					FinalLocationParam = (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.GetLocation() + LocationOffset) : DBCOverrideTransform.Transform.GetLocation());
					break;
				}
			}
			FinalRotationParam = RotationOffset;
			if (DBCOverrideTransform.UseRotation)
			{
				switch (DBCOverrideTransform.RotationType)
				{
				case DBCTransformType.Absolute:
					FinalRotationParam = (DBCOverrideTransform.AddDataAssetOffset ? (relativeTransform.Rotator() + RotationOffset) : relativeTransform.Rotator());
					break;
				case DBCTransformType.OffsetInSocketLocalSpace:
					FinalRotationParam = socketTransform2.TransformRotation(DBCOverrideTransform.Transform.GetRotation()).Rotator();
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalRotationParam += RotationOffset;
					}
					break;
				case DBCTransformType.OffsetInWorldSpace:
					FinalRotationParam = (DBCOverrideTransform.AddDataAssetOffset ? (DBCOverrideTransform.Transform.Rotator() + RotationOffset) : DBCOverrideTransform.Transform.Rotator());
					break;
				}
			}
		}
		else
		{
			if (DBCOverrideTransform.UseLocation)
			{
				switch (DBCOverrideTransform.LocationType)
				{
				case DBCTransformType.Absolute:
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalLocationParam = (OffsetInLocalSpace ? DBCOverrideTransform.Transform.TransformPositionNoScale(LocationOffset) : (DBCOverrideTransform.Transform.GetLocation() + LocationOffset));
					}
					else
					{
						FinalLocationParam = DBCOverrideTransform.Transform.GetLocation();
					}
					break;
				case DBCTransformType.OffsetInSocketLocalSpace:
					FinalLocationParam = socketTransform2.TransformPositionNoScale(DBCOverrideTransform.Transform.GetLocation());
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalLocationParam += (OffsetInLocalSpace ? socketTransform2.TransformVector(LocationOffset) : LocationOffset);
					}
					break;
				case DBCTransformType.OffsetInWorldSpace:
					FinalLocationParam = socketTransform2.GetLocation() + DBCOverrideTransform.Transform.GetLocation();
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalLocationParam += (OffsetInLocalSpace ? socketTransform2.TransformVectorNoScale(LocationOffset) : LocationOffset);
					}
					break;
				default:
					FinalLocationParam = FVector.ZeroVector;
					break;
				}
			}
			else if (OffsetInLocalSpace)
			{
				FinalLocationParam = socketTransform2.TransformVectorNoScale(LocationOffset);
			}
			else
			{
				FinalLocationParam = socketTransform2.GetLocation() + LocationOffset;
			}
			if (DBCOverrideTransform.UseRotation)
			{
				switch (DBCOverrideTransform.RotationType)
				{
				case DBCTransformType.Absolute:
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalRotationParam = (OffsetInLocalSpace ? DBCOverrideTransform.Transform.TransformRotation(RotationOffset) : (DBCOverrideTransform.Transform.Rotator() + RotationOffset));
					}
					else
					{
						FinalRotationParam = DBCOverrideTransform.Transform.Rotator();
					}
					break;
				case DBCTransformType.OffsetInSocketLocalSpace:
					FinalRotationParam = socketTransform2.TransformRotation(DBCOverrideTransform.Transform.GetRotation()).Rotator();
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalRotationParam += (OffsetInLocalSpace ? socketTransform2.TransformRotation(RotationOffset) : RotationOffset);
					}
					break;
				case DBCTransformType.OffsetInWorldSpace:
					FinalRotationParam = socketTransform2.Rotator() + DBCOverrideTransform.Transform.Rotator();
					if (DBCOverrideTransform.AddDataAssetOffset)
					{
						FinalRotationParam += (OffsetInLocalSpace ? socketTransform2.TransformRotation(RotationOffset) : RotationOffset);
					}
					break;
				default:
					FinalRotationParam = FRotator.ZeroRotator;
					break;
				}
			}
			else if (OffsetInLocalSpace)
			{
				FinalRotationParam = socketTransform2.TransformRotation(RotationOffset);
			}
			else
			{
				FinalRotationParam = socketTransform2.Rotator() + RotationOffset;
			}
		}
		FinalScaleParam = ((Scale == default(FVector)) ? FVector.OneVector : Scale);
		if (DBCOverrideTransform.UseScale && DBCOverrideTransform.Transform.Scale3D != default(FVector))
		{
			FinalScaleParam = DBCOverrideTransform.Transform.Scale3D * (DBCOverrideTransform.AddDataAssetOffset ? FinalScaleParam : FVector.OneVector);
			switch (DBCOverrideTransform.ScaleType)
			{
			case DBCTransformType.Absolute:
				FinalScaleIsRelativeScale = false;
				break;
			case DBCTransformType.OffsetInSocketLocalSpace:
				FinalScaleIsRelativeScale = true;
				break;
			case DBCTransformType.OffsetInWorldSpace:
				FinalScaleIsRelativeScale = true;
				break;
			default:
				FinalScaleIsRelativeScale = true;
				break;
			}
		}
		else
		{
			FinalScaleIsRelativeScale = true;
		}
	}

	public static UNiagaraComponent DBCUtilSpawnNiagara(USceneComponent FXAttachComp, DispLibDBCEndMode EndMode, ENCPoolMethod PoolMode, UNiagaraSystem Template, bool DeactiveAtSpawn, bool AttachedTarget, FName AttachedTargetSocketName, bool OffsetInLocalSpace, FVector LocationOffset, FRotator RotationOffset, FVector Scale, bool EnableShadow, bool EnableVolumetricTranslucentShadow, int TranslucentSortPriority, DBCTransformParam DBCOverrideTransform = default(DBCTransformParam), bool SetDBCTransformAsParam = false, float Duration = -1f, UNiagaraComponent ReuseNiagaraComp = null)
	{
		if (TargetCompIsInvalid(FXAttachComp))
		{
			return null;
		}
		UNiagaraComponent uNiagaraComponent = null;
		bool flag = !ReuseNiagaraComp.IsNullOrDestroyed();
		Internal_ResolveSpawnNiagaraTransformInfo(out var SimpleSpawn, out var FinalAttachParam, out var FinalLocationParam, out var FinalRotationParam, out var FinalScaleParam, out var FinalScaleIsRelativeScale, FXAttachComp, AttachedTarget, AttachedTargetSocketName, OffsetInLocalSpace, LocationOffset, RotationOffset, Scale, DBCOverrideTransform, SetDBCTransformAsParam);
		if (flag)
		{
			uNiagaraComponent = ReuseNiagaraComp;
			if (uNiagaraComponent.IsPaused())
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
			}
			uNiagaraComponent.SetVisibility(bNewVisibility: true);
			uNiagaraComponent.ComponentTags.Clear();
			uNiagaraComponent.SetActive(bNewActive: false, bReset: true);
			uNiagaraComponent.DetachFromComponent();
			uNiagaraComponent.DetachFromParent();
		}
		if (SimpleSpawn)
		{
			if (FinalAttachParam)
			{
				if (flag)
				{
					uNiagaraComponent.AttachToComponent(FXAttachComp, AttachedTargetSocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
					uNiagaraComponent.SetRelativeLocationAndRotation(FinalLocationParam, FinalRotationParam, bSweep: true, out var _, bTeleport: true);
				}
				else
				{
					uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(Template, FXAttachComp, AttachedTargetSocketName, FinalLocationParam, FinalRotationParam, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true, bAutoActivate: false, PoolMode, bPreCullCheck: false);
				}
			}
			else if (flag)
			{
				uNiagaraComponent.SetWorldScale3D(FVector.OneVector);
				uNiagaraComponent.SetWorldLocationAndRotation(FinalLocationParam, FinalRotationParam, bSweep: true, out var _, bTeleport: true);
			}
			else
			{
				uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(FXAttachComp, Template, FinalLocationParam, FinalRotationParam, FVector.OneVector, bAutoDestroy: true, bAutoActivate: false, PoolMode, bPreCullCheck: false);
			}
		}
		else if (FinalAttachParam)
		{
			if (flag)
			{
				uNiagaraComponent.AttachToComponent(FXAttachComp, AttachedTargetSocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
				uNiagaraComponent.SetRelativeLocationAndRotation(FinalLocationParam, FinalRotationParam, bSweep: true, out var _, bTeleport: true);
			}
			else
			{
				uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAttached(Template, FXAttachComp, AttachedTargetSocketName, FinalLocationParam, FinalRotationParam, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true, bAutoActivate: false, PoolMode);
			}
		}
		else if (flag)
		{
			uNiagaraComponent.SetWorldScale3D(FVector.OneVector);
			uNiagaraComponent.SetWorldLocationAndRotation(FinalLocationParam, FinalRotationParam, bSweep: true, out var _, bTeleport: true);
		}
		else
		{
			uNiagaraComponent = UNiagaraFunctionLibrary.SpawnSystemAtLocation(FXAttachComp, Template, FinalLocationParam, FinalRotationParam, FVector.OneVector, bAutoDestroy: true, bAutoActivate: false, PoolMode, bPreCullCheck: false);
		}
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return null;
		}
		if (FinalScaleParam != FVector.OneVector)
		{
			if (FinalScaleIsRelativeScale)
			{
				uNiagaraComponent.SetRelativeScale3D(FinalScaleParam);
			}
			else
			{
				uNiagaraComponent.SetWorldScale3D(FinalScaleParam);
			}
		}
		uNiagaraComponent.SetTranslucentSortPriority(TranslucentSortPriority);
		if (Duration > 0.0001f)
		{
			uNiagaraComponent.SetVariableFloat(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxDuration, Duration);
		}
		if (SetDBCTransformAsParam && DBCOverrideTransform.IsValid())
		{
			uNiagaraComponent.SetVariableVec3(DispLib_EditorFNameCache.EfxOverrideDBCTransform_LO, DBCOverrideTransform.Transform.GetLocation());
			uNiagaraComponent.SetVariableQuat(DispLib_EditorFNameCache.EfxOverrideDBCTransform_RO, DBCOverrideTransform.Transform.Rotator().Quaternion());
			uNiagaraComponent.SetVariableVec3(DispLib_EditorFNameCache.EfxOverrideDBCTransform_S, DBCOverrideTransform.Transform.GetScale3D());
		}
		if (EnableShadow)
		{
			uNiagaraComponent.SetCastShadow(NewCastShadow: true);
		}
		if (EnableVolumetricTranslucentShadow)
		{
			uNiagaraComponent.CastVolumetricTranslucentShadow = true;
		}
		if (!DeactiveAtSpawn)
		{
			uNiagaraComponent.SetActive(bNewActive: true);
		}
		return uNiagaraComponent;
	}

	private bool DoSnapGround<T>(T Info) where T : DBCFXInfoBase
	{
		bool result = Info.isAttach_SourceSetting;
		if (Info.SnapGround)
		{
			if (Info.FXAttachComp.IsNullOrDestroyed())
			{
				return result;
			}
			FVector zeroVector = FVector.ZeroVector;
			zeroVector = ((!Info.DBCOverrideTransform.UseLocation && !Info.DBCOverrideTransform.TransformUseAll) ? Info.FXAttachComp.GetSocketLocation(Info.AttachedTargetSocketName) : Info.DBCOverrideTransform.Transform.GetLocation());
			FVector lineTraceStart = zeroVector + FVector.UpVector * 50.0;
			FVector lineTraceEnd = zeroVector - FVector.UpVector * 1000.0;
			if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(Info.FXAttachComp, lineTraceStart, lineTraceEnd, out var hitResultSimple))
			{
				FRotator rotation = FRotator.ZeroRotator;
				switch (Info.SnapGroundRotationMode)
				{
				case DispLibDBCSnapGroundRotationMode.HitPointNormalProjected:
				{
					float pitch = MathLib.MakeRotFromYZ(FVector.RightVector, hitResultSimple.HitImpactNormal).Pitch;
					float roll = MathLib.MakeRotFromXZ(FVector.ForwardVector, hitResultSimple.HitImpactNormal).Roll;
					rotation = new FRotator(pitch, 0.0, roll);
					break;
				}
				case DispLibDBCSnapGroundRotationMode.CompXAxis:
					rotation = MathLib.MakeRotFromX(Info.FXAttachComp.GetForwardVector());
					break;
				}
				FVector hitLocation = hitResultSimple.HitLocation;
				if (Info.OffsetInLocalSpace)
				{
					hitLocation += Info.FXAttachComp.GetSocketTransform(Info.AttachedTargetSocketName).TransformVectorNoScale(Info.AttachedTargetLocationOffset);
				}
				else
				{
					hitLocation += Info.AttachedTargetLocationOffset;
				}
				Info.DBCOverrideTransform = new DBCTransformParam(new FTransform(rotation, hitLocation), _UseLocation: true, DBCTransformType.Absolute, _UseRotation: true, DBCTransformType.Absolute, _UseScale: false, DBCTransformType.Absolute, DBCTransformOverrdieAttachType.Detach, FName.None, _AddDataAssetOffset: false);
				result = false;
			}
		}
		return result;
	}

	private void Internal_OnNiagaraEventInfoBeReusedByNiagaraScalability(DBCFXInfoBase BeReusedInfo)
	{
		BeReusedInfo.NiagaraComponent.Set(null);
		BeReusedInfo.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.BeReuseByScalability;
		Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, BeReusedInfo.SourceDispOwnerComp, BeReusedInfo.IdentityID, BeReusedInfo.EventIndexInDataAsset, 0u, default(FName), OnlyEndFX: true, OnlyEndProcedureEndMode: false, int.MaxValue);
	}

	private void Internal_CleanAndRealEndDBCMergeNiagaraManger(DBCMergeNiagaraMangerInfo NeedCleanInfo)
	{
		if (NeedCleanInfo.CachedChildDBCNiagaraEventInfo != null)
		{
			foreach (DBCMergeNiagaraMangerInfo.CachedChildEventInfo value in NeedCleanInfo.CachedChildDBCNiagaraEventInfo.Values)
			{
				if (value != null)
				{
					DBCPlayAdvanceNiagaraInfo info = value.Info;
					if (info != null)
					{
						Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, info.SourceDispOwnerComp, info.IdentityID, info.EventIndexInDataAsset, 0u, default(FName), OnlyEndFX: true, OnlyEndProcedureEndMode: false, int.MaxValue);
					}
				}
			}
		}
		NeedCleanInfo.CachedChildDBCNiagaraEventInfo.Clear();
		NeedCleanInfo.CachedChildDBCNiagaraEventInfo = null;
		if (NeedCleanInfo.MangerSystemComp != null)
		{
			UNiagaraComponent uNiagaraComponent = NeedCleanInfo.MangerSystemComp.Get();
			if (uNiagaraComponent != null && !uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.ReleaseToPool();
			}
			NeedCleanInfo.MangerSystemComp.SetNull();
		}
	}

	private bool DoPlayNiagara(DBCPlayNiagaraInfo Info)
	{
		Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.HasSpawn;
		UNiagaraComponent reuseNiagaraComp = null;
		bool attachedTarget = DoSnapGround(Info);
		bool flag = false;
		DBCOneNiagaraScalabilityManager dBCOneNiagaraScalabilityManager = null;
		BUC_DispLibDBC_NiagaraEventScalabilitySettings scalabilitySettings = Info.SourceRequest.ScalabilitySettings;
		if (DispLibFuncUtil.ValidateDBCNiagaraScalabilitySettings(scalabilitySettings))
		{
			dBCOneNiagaraScalabilityManager = Queue.GetNiagaraScalabilityManager(Info, scalabilitySettings);
		}
		if (dBCOneNiagaraScalabilityManager != null && dBCOneNiagaraScalabilityManager.CurEffectQualityScalabilitySettings.Mode == DispLibDBCNiagaraScalabilityKillMode.ReuseByReset)
		{
			DBCFXInfoBase dBCFXInfoBase = dBCOneNiagaraScalabilityManager.PreSpawnNewNiagaraTryFindReuseNiagaraInfo(DispLibCameraData.CurFrameCameraPosWS, DispLibCameraData.CurFrameCameraForwardDir);
			if (dBCFXInfoBase != null)
			{
				flag = true;
				reuseNiagaraComp = dBCFXInfoBase.NiagaraComponent.Get();
				Internal_OnNiagaraEventInfoBeReusedByNiagaraScalability(dBCFXInfoBase);
			}
		}
		reuseNiagaraComp = ((!flag) ? DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, Info.SourceRequest.Template, DeactiveAtSpawn: false, attachedTarget, Info.AttachedTargetSocketName, Info.SourceRequest.OffsetInLocalSpace, Info.SourceRequest.LocationOffset, Info.SourceRequest.RotationOffset, Info.SourceRequest.Scale, Info.SourceRequest.EnableShadow, EnableVolumetricTranslucentShadow: false, Info.SourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, SetDBCTransformAsParam: false, Info.SourceRequest.Duration) : DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, Info.SourceRequest.Template, DeactiveAtSpawn: false, attachedTarget, Info.AttachedTargetSocketName, Info.SourceRequest.OffsetInLocalSpace, Info.SourceRequest.LocationOffset, Info.SourceRequest.RotationOffset, Info.SourceRequest.Scale, Info.SourceRequest.EnableShadow, EnableVolumetricTranslucentShadow: false, Info.SourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, SetDBCTransformAsParam: false, Info.SourceRequest.Duration, reuseNiagaraComp));
		if (reuseNiagaraComp.IsNullOrDestroyed())
		{
			return false;
		}
		reuseNiagaraComp.ComponentTags.Add(B1GlobalFNames.DBCNG);
		if (Info.ForceNiagaraVisibleState != -1)
		{
			reuseNiagaraComp.SetVisibility(Info.ForceNiagaraVisibleState != 0);
		}
		Info.NiagaraComponent.Set(reuseNiagaraComp);
		if (Info.SourceRequest.MetaString != default(FName))
		{
			string[] array = Info.SourceRequest.MetaString.PlainName.Split(',');
			if (array.Length >= 1)
			{
				string[] array2 = array;
				foreach (string name in array2)
				{
					reuseNiagaraComp.ComponentTags.Add(new FName(name));
				}
			}
		}
		if (Info.SpawnCallback != null)
		{
			Info.SpawnCallback(DispLibRefParam.Instance.Set(Info.IdentityID, reuseNiagaraComp, Info.MetaString));
			if (reuseNiagaraComp.IsNullOrDestroyed())
			{
				return false;
			}
		}
		if (dBCOneNiagaraScalabilityManager != null)
		{
			DBCFXInfoBase dBCFXInfoBase2 = dBCOneNiagaraScalabilityManager.PostSpawnNewNiagara(Info, DispLibCameraData.CurFrameCameraPosWS, DispLibCameraData.CurFrameCameraForwardDir);
			if (dBCFXInfoBase2 != null)
			{
				Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, dBCFXInfoBase2.SourceDispOwnerComp, dBCFXInfoBase2.IdentityID, dBCFXInfoBase2.EventIndexInDataAsset, 0u, default(FName), OnlyEndFX: true, OnlyEndProcedureEndMode: false, 0);
			}
		}
		return true;
	}

	private void Interior_SetParamOnModifyMaterialParameterCollectionEventBegin(DBCModifyMaterialParameterCollectionInfo Info)
	{
		UMaterialParameterCollection mPCInstance = GlobalData.LoadAndGetMPCInstance(Owner, Info.MPCAssetPath);
		foreach (DBCAdvProcessScalarParam scalarParam in Info.ScalarParams)
		{
			SetMPCScalarParam_Immed(mPCInstance, Info.MPCAssetPath, scalarParam.ParamName, scalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			Queue.MPCScalarParamOperationCounterAdd(out var _, mPCInstance, Info.MPCAssetPath, scalarParam.ParamName);
		}
		foreach (DBCAdvProcessFLinearColorParam fLinearColorParam in Info.FLinearColorParams)
		{
			SetMPCColorParam_Immed(mPCInstance, Info.MPCAssetPath, fLinearColorParam.ParamName, fLinearColorParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			Queue.MPCColorParamOperationCounterAdd(out var _, mPCInstance, Info.MPCAssetPath, fLinearColorParam.ParamName);
		}
		foreach (DBCPCurveScalarParam pCurveScalarParam in Info.PCurveScalarParams)
		{
			SetMPCScalarParam_Immed(mPCInstance, Info.MPCAssetPath, pCurveScalarParam.ParamName, pCurveScalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			Queue.MPCScalarParamOperationCounterAdd(out var _, mPCInstance, Info.MPCAssetPath, pCurveScalarParam.ParamName);
		}
		foreach (DBCPCurveLinearColorParam pCurveFLinearColorParam in Info.PCurveFLinearColorParams)
		{
			SetMPCColorParam_Immed(mPCInstance, Info.MPCAssetPath, pCurveFLinearColorParam.ParamName, pCurveFLinearColorParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMPCEndStagePriority : Info.ModMPCPriority);
			Queue.MPCColorParamOperationCounterAdd(out var _, mPCInstance, Info.MPCAssetPath, pCurveFLinearColorParam.ParamName);
		}
	}

	private void SetMPCScalarParam_Immed(UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName, float Value, float EventStartTime, int Priority)
	{
		bool DataChanged;
		DispLib_One_MPC_ScalarParamState orAdd_One_MPCScalarParamState = Queue.GetOrAdd_One_MPCScalarParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCScalarParamState != null)
		{
			bool flag = false;
			if (DataChanged || !orAdd_One_MPCScalarParamState.HasValidEvent || (orAdd_One_MPCScalarParamState.Priority < Priority && orAdd_One_MPCScalarParamState.isInitialValueValid && !MathLib.IsNearlyEqual(Value, orAdd_One_MPCScalarParamState.Value)) || (orAdd_One_MPCScalarParamState.Priority == Priority && orAdd_One_MPCScalarParamState.isInitialValueValid && !MathLib.IsNearlyEqual(Value, orAdd_One_MPCScalarParamState.Value) && orAdd_One_MPCScalarParamState.CurRequestStartTime <= EventStartTime))
			{
				flag = true;
				orAdd_One_MPCScalarParamState.SetData(Value, EventStartTime, Priority);
			}
			if (flag)
			{
				UMaterialLibrary.SetScalarParameterValue(Owner, MPCInstance, ParamName, Value);
			}
		}
	}

	private void SetMPCColorParam_Immed(UMaterialParameterCollection MPCInstance, string MPCAssetPath, FName ParamName, FLinearColor Value, float EventStartTime, int Priority)
	{
		bool DataChanged;
		DispLib_One_MPC_ColorParamState orAdd_One_MPCColorParamState = Queue.GetOrAdd_One_MPCColorParamState(out DataChanged, MPCInstance, MPCAssetPath, ParamName);
		if (orAdd_One_MPCColorParamState != null)
		{
			bool flag = false;
			if (DataChanged || !orAdd_One_MPCColorParamState.HasValidEvent || (orAdd_One_MPCColorParamState.Priority < Priority && orAdd_One_MPCColorParamState.isInitialValueValid && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, orAdd_One_MPCColorParamState.Value)) || (orAdd_One_MPCColorParamState.Priority == Priority && orAdd_One_MPCColorParamState.isInitialValueValid && !BGU_DispLibDataUtil.FLinearColorIsNearlyEqual(Value, orAdd_One_MPCColorParamState.Value) && orAdd_One_MPCColorParamState.CurRequestStartTime <= EventStartTime))
			{
				flag = true;
				orAdd_One_MPCColorParamState.SetData(Value, EventStartTime, Priority);
			}
			if (flag)
			{
				UMaterialLibrary.SetVectorParameterValue(Owner, MPCInstance, ParamName, Value);
			}
		}
	}

	private bool DoModifyMPC(DBCModifyMaterialParameterCollectionInfo Info)
	{
		Interior_SetParamOnModifyMaterialParameterCollectionEventBegin(Info);
		Info.HasSpawn = true;
		return true;
	}

	private bool ExecuteWEFMWindEventTick(DBCWEFMWindEventInfo Info, float DeltaTime)
	{
		Info.StartExecute = true;
		BUC_DispLibDBC_WEFMWind sourceRequest = Info.SourceRequest;
		if (FMath.FRand() >= sourceRequest.TriggerProbability)
		{
			return false;
		}
		if (Queue.WEFM_ValidEventsCount + 1 > Queue.WEFMWindBufferMaxCount)
		{
			_ = $"事件_{sourceRequest.EventName}";
			return false;
		}
		FVector zeroVector = FVector.ZeroVector;
		FVector socketLocation = Info.SourceDispOwnerComp.GetSocketLocation(sourceRequest.SocketName);
		zeroVector = (socketLocation - Info.LastFrameSocketPosWS) / DeltaTime;
		Info.LastFrameSocketPosWS = socketLocation;
		zeroVector.ToDirectionAndLength(out var _, out var length);
		Info.UpdataProcessParams(DeltaTime, length);
		if (length < sourceRequest.VelocityThreshold)
		{
			return false;
		}
		FVector centerPosWS = Info.SourceDispOwnerComp.GetSocketTransform(sourceRequest.SocketName).TransformPosition(sourceRequest.SocketLocalOffset);
		FVector axisVector = DispLibFuncUtil.GetAxisVector(sourceRequest.VelocityDir, GetOwner().RootComponent, GetOwner().GetActorTransform(), zeroVector, sourceRequest.VelocityDirLocalRotation);
		FVector axisVector2 = DispLibFuncUtil.GetAxisVector(sourceRequest.RangeAxis, GetOwner().RootComponent, GetOwner().GetActorTransform(), zeroVector, sourceRequest.RangeAxisLocalRotation);
		FVector4 windDataV = new FVector4(axisVector2, sourceRequest.RangeMask);
		if (sourceRequest.WindMotorMode != DispLibDBCWindMotorMode.LocalDirectionalWind)
		{
			axisVector *= (double)Info.m_ScaleSecondVelocityProcess.CurFrameValue;
		}
		float num = Info.m_BaseIntensityProcess.CurFrameValue + sourceRequest.ScaleVelocityIntensity * length;
		if (num <= 0.0001f)
		{
			return false;
		}
		DLDWorld_RequestDirectInject_Wind(WindSizeV3: new FVector(Info.m_RadiusProcess.CurFrameValue, 0.0, 0.0), RequesterUniqueID: ref Info.RequesterUniqueID, CenterPosWS: centerPosWS, DirWS: axisVector, WindIntensity: num, WindType: Info.WindType, DistanceDamplingRate: sourceRequest.DistanceDamplingRate, WindDataV4: windDataV);
		return true;
	}

	private static bool Internal_ResolveDBCNiagaraEventFinalAttachParam(bool SnapGroundAttachParam, DBCTransformParam DBCOverrideTransform = default(DBCTransformParam))
	{
		bool result = SnapGroundAttachParam;
		if (DBCOverrideTransform.AttachType != DBCTransformOverrdieAttachType.NoOverrdie)
		{
			result = DBCOverrideTransform.AttachType == DBCTransformOverrdieAttachType.Attach;
		}
		return result;
	}

	private bool DoPlayAdvanceNiagara(DBCPlayAdvanceNiagaraInfo Info)
	{
		Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.HasSpawn;
		BUC_DispLibDBC_PlayAdvanceNiagara sourceRequest = Info.SourceRequest;
		USceneComponent minorDispOwnerComp = Info.MinorDispOwnerComp;
		bool flag = false;
		if (minorDispOwnerComp.IsNullOrDestroyed())
		{
			flag = true;
		}
		if (Info.SetSelfSKMeshParam)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = Info.FXAttachComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null)
			{
				if (!UGSE_SkeletalMeshFuncLib.IsCPUAccess(uSkeletalMeshComponent.SkeletalMesh))
				{
					return false;
				}
			}
			else
			{
				UStaticMeshComponent uStaticMeshComponent = Info.FXAttachComp as UStaticMeshComponent;
				if (uStaticMeshComponent != null && !UGSE_StaticMeshFunLib.IsCPUAccess(uStaticMeshComponent.StaticMesh))
				{
					return false;
				}
			}
		}
		if (Info.SetMinorSKMeshParam && !flag)
		{
			USkeletalMeshComponent uSkeletalMeshComponent2 = Info.MinorDispOwnerComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent2 != null)
			{
				if (!UGSE_SkeletalMeshFuncLib.IsCPUAccess(uSkeletalMeshComponent2.SkeletalMesh))
				{
					return false;
				}
			}
			else
			{
				UStaticMeshComponent uStaticMeshComponent2 = Info.FXAttachComp as UStaticMeshComponent;
				if (uStaticMeshComponent2 != null && !UGSE_StaticMeshFunLib.IsCPUAccess(uStaticMeshComponent2.StaticMesh))
				{
					return false;
				}
			}
		}
		UNiagaraComponent uNiagaraComponent = null;
		bool flag2 = false;
		DBCOneNiagaraScalabilityManager dBCOneNiagaraScalabilityManager = null;
		BUC_DispLibDBC_NiagaraEventScalabilitySettings scalabilitySettings = Info.SourceRequest.ScalabilitySettings;
		if (DispLibFuncUtil.ValidateDBCNiagaraScalabilitySettings(scalabilitySettings))
		{
			dBCOneNiagaraScalabilityManager = Queue.GetNiagaraScalabilityManager(Info, scalabilitySettings);
		}
		if (dBCOneNiagaraScalabilityManager != null && dBCOneNiagaraScalabilityManager.CurEffectQualityScalabilitySettings.Mode == DispLibDBCNiagaraScalabilityKillMode.ReuseByReset)
		{
			DBCFXInfoBase dBCFXInfoBase = dBCOneNiagaraScalabilityManager.PreSpawnNewNiagaraTryFindReuseNiagaraInfo(DispLibCameraData.CurFrameCameraPosWS, DispLibCameraData.CurFrameCameraForwardDir);
			if (dBCFXInfoBase != null)
			{
				flag2 = true;
				uNiagaraComponent = dBCFXInfoBase.NiagaraComponent.Get();
				Internal_OnNiagaraEventInfoBeReusedByNiagaraScalability(dBCFXInfoBase);
			}
		}
		bool isAttach_RealAttach = Internal_ResolveDBCNiagaraEventFinalAttachParam(DoSnapGround(Info), Info.DBCOverrideTransform);
		Info.isAttach_RealAttach = isAttach_RealAttach;
		bool result = false;
		switch (Info.DispLogicMode)
		{
		case DispLibAdvanceNiagaraDispLogicMode.DBCMergedSystem:
			result = Queue.OnOneDBCMergeNiagaraEventDoPlay(Info);
			break;
		case DispLibAdvanceNiagaraDispLogicMode.Custom:
			uNiagaraComponent = DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, sourceRequest.Template, sourceRequest.DeactiveAtSpawn, Info.isAttach_RealAttach, Info.RealAttachedTargetSocketName, sourceRequest.OffsetInLocalSpace, sourceRequest.AttachedTargetLocationOffset, sourceRequest.AttachedTargetRotationOffset, sourceRequest.Scale, Info.SourceRequest.EnableShadow, Info.SourceRequest.EnableVolumetricTranslucentShadow, sourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, sourceRequest.SetDBCTransformAsParam, sourceRequest.Duration, flag2 ? uNiagaraComponent : null);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
			}
			break;
		case DispLibAdvanceNiagaraDispLogicMode.StandardDirBeHit:
		{
			FVector fVector3 = (Info.DBCOverrideTransform.UseLocation ? Info.DBCOverrideTransform.Transform.GetLocation() : Info.FXAttachComp.GetSocketLocation(Info.RealAttachedTargetSocketName));
			FRotator rotation;
			if (Info.DBCOverrideTransform.UseRotation)
			{
				rotation = Info.DBCOverrideTransform.Transform.Rotator();
			}
			else
			{
				if (!Info.MinorDispOwnerComp.IsNullOrDestroyed())
				{
					Info.MinorPosWSOnSpawn = minorDispOwnerComp.GetSocketLocation(Info.RealAttachedEmitterSocketName);
				}
				rotation = MathLib.FindLookAtRotation(Info.MinorPosWSOnSpawn, fVector3);
			}
			uNiagaraComponent = DBCUtilSpawnNiagara(DBCOverrideTransform: new DBCTransformParam(new FTransform(rotation, fVector3, FVector.OneVector)), FXAttachComp: Info.FXAttachComp, EndMode: Info.EndMode, PoolMode: Info.UEPoolMode, Template: sourceRequest.Template, DeactiveAtSpawn: sourceRequest.DeactiveAtSpawn, AttachedTarget: Info.isAttach_RealAttach, AttachedTargetSocketName: Info.RealAttachedTargetSocketName, OffsetInLocalSpace: sourceRequest.OffsetInLocalSpace, LocationOffset: sourceRequest.AttachedTargetLocationOffset, RotationOffset: sourceRequest.AttachedTargetRotationOffset, Scale: sourceRequest.Scale, EnableShadow: Info.SourceRequest.EnableShadow, EnableVolumetricTranslucentShadow: Info.SourceRequest.EnableVolumetricTranslucentShadow, TranslucentSortPriority: sourceRequest.TranslucentSortPriority, SetDBCTransformAsParam: sourceRequest.SetDBCTransformAsParam, Duration: sourceRequest.Duration, ReuseNiagaraComp: flag2 ? uNiagaraComponent : null);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
			}
			break;
		}
		case DispLibAdvanceNiagaraDispLogicMode.StandardInteraction:
			uNiagaraComponent = DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, sourceRequest.Template, sourceRequest.DeactiveAtSpawn, Info.isAttach_RealAttach, Info.RealAttachedTargetSocketName, sourceRequest.OffsetInLocalSpace, sourceRequest.AttachedTargetLocationOffset, sourceRequest.AttachedTargetRotationOffset, sourceRequest.Scale, Info.SourceRequest.EnableShadow, Info.SourceRequest.EnableVolumetricTranslucentShadow, sourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, sourceRequest.SetDBCTransformAsParam, sourceRequest.Duration, flag2 ? uNiagaraComponent : null);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
			}
			break;
		case DispLibAdvanceNiagaraDispLogicMode.PlanePostProcess:
			uNiagaraComponent = DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, sourceRequest.Template, sourceRequest.DeactiveAtSpawn, AttachedTarget: false, B1GlobalFNames.None, sourceRequest.OffsetInLocalSpace, sourceRequest.AttachedTargetLocationOffset, sourceRequest.AttachedTargetRotationOffset, sourceRequest.Scale, sourceRequest.EnableShadow, sourceRequest.EnableVolumetricTranslucentShadow, sourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, sourceRequest.SetDBCTransformAsParam, sourceRequest.Duration);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				AdvanceNiagara_UpdatePlanePP(uNiagaraComponent, Info.isAttach_SourceSetting);
			}
			break;
		case DispLibAdvanceNiagaraDispLogicMode.TinyOffsetBeHit:
		{
			DBCTransformParam dBCOverrideTransform = Info.DBCOverrideTransform;
			FVector fVector = (Info.MinorDispOwnerComp.IsNullOrDestroyed() ? Info.MinorPosWSOnSpawn : (Info.MinorPosWSOnSpawn = minorDispOwnerComp.GetSocketLocation(Info.RealAttachedEmitterSocketName)));
			if (fVector != FVector.ZeroVector)
			{
				float num = ((Info.SourceRequest.CustomV4Param.X != 0f) ? Info.SourceRequest.CustomV4Param.X : BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCTinyOffsetBeHitDefaultDistance);
				FVector socketLocation = Info.FXAttachComp.GetSocketLocation(Info.SourceRequest.AttachedTargetSocketName);
				FVector fVector2 = socketLocation + new FVector(fVector - socketLocation).Normal() * num;
				fVector2.Z = MathLib.Clamp(fVector2.Z, Math.Min(fVector.Z, socketLocation.Z), Math.Max(fVector.Z, socketLocation.Z));
				FTransform transform = Info.DBCOverrideTransform.Transform;
				dBCOverrideTransform = new DBCTransformParam(new FTransform(transform.Rotation, fVector2 + ((dBCOverrideTransform.AttachType == DBCTransformOverrdieAttachType.Detach) ? FVector.ZeroVector : transform.GetLocation()), transform.Scale3D), DBCTransformType.Absolute, _UseLocation: true, dBCOverrideTransform.UseRotation, dBCOverrideTransform.UseScale, DBCTransformOverrdieAttachType.Detach, FName.None, dBCOverrideTransform.AddDataAssetOffset);
			}
			uNiagaraComponent = DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, sourceRequest.Template, sourceRequest.DeactiveAtSpawn, Info.isAttach_RealAttach, Info.RealAttachedTargetSocketName, sourceRequest.OffsetInLocalSpace, sourceRequest.AttachedTargetLocationOffset, sourceRequest.AttachedTargetRotationOffset, sourceRequest.Scale, sourceRequest.EnableShadow, sourceRequest.EnableVolumetricTranslucentShadow, sourceRequest.TranslucentSortPriority, dBCOverrideTransform, sourceRequest.SetDBCTransformAsParam, sourceRequest.Duration, flag2 ? uNiagaraComponent : null);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
			}
			break;
		}
		case DispLibAdvanceNiagaraDispLogicMode.MatchingToNearestSocket:
		{
			bool setDBCTransformAsParam = false;
			uNiagaraComponent = DBCUtilSpawnNiagara(Info.FXAttachComp, Info.EndMode, Info.UEPoolMode, sourceRequest.Template, sourceRequest.DeactiveAtSpawn, Info.isAttach_RealAttach, Info.RealAttachedTargetSocketName, sourceRequest.OffsetInLocalSpace, sourceRequest.AttachedTargetLocationOffset, sourceRequest.AttachedTargetRotationOffset, sourceRequest.Scale, sourceRequest.EnableShadow, sourceRequest.EnableVolumetricTranslucentShadow, sourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform, setDBCTransformAsParam, sourceRequest.Duration, flag2 ? uNiagaraComponent : null);
			if (!uNiagaraComponent.IsNullOrDestroyed())
			{
				uNiagaraComponent.SetVariableVec3(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterPos, Info.MinorPosWSOnSpawn);
			}
			if (!uNiagaraComponent.IsNullOrDestroyed() && sourceRequest.SetDBCTransformAsParam && Info.DBCOverrideTransform_SourceSetting.IsValid())
			{
				uNiagaraComponent.SetVariableVec3(DispLib_EditorFNameCache.EfxOverrideDBCTransform_LO, Info.DBCOverrideTransform_SourceSetting.Transform.GetLocation());
				uNiagaraComponent.SetVariableQuat(DispLib_EditorFNameCache.EfxOverrideDBCTransform_RO, Info.DBCOverrideTransform_SourceSetting.Transform.Rotation);
				uNiagaraComponent.SetVariableVec3(DispLib_EditorFNameCache.EfxOverrideDBCTransform_S, Info.DBCOverrideTransform_SourceSetting.Transform.GetScale3D());
			}
			break;
		}
		}
		if (Info.DispLogicMode == DispLibAdvanceNiagaraDispLogicMode.DBCMergedSystem)
		{
			return result;
		}
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			return false;
		}
		uNiagaraComponent.ComponentTags.Add(B1GlobalFNames.DBCNG);
		Info.NiagaraComponent.Set(uNiagaraComponent);
		uNiagaraComponent.SetVariableBool(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxEmitterDeath, flag);
		uNiagaraComponent.SetVariableVec4(BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxV4Param, sourceRequest.CustomV4Param);
		if (Info.SetSelfSKMeshParam)
		{
			USkeletalMeshComponent uSkeletalMeshComponent3 = Info.FXAttachComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent3 != null)
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(uNiagaraComponent, "User.GS_EfxSelfSkeletalMesh", uSkeletalMeshComponent3);
			}
			else
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableStaticMeshComponent(uNiagaraComponent, "User.GS_EfxSelfStaticMesh", Info.FXAttachComp as UStaticMeshComponent);
			}
		}
		if (Info.SetMinorSKMeshParam)
		{
			USkeletalMeshComponent uSkeletalMeshComponent4 = Info.MinorDispOwnerComp as USkeletalMeshComponent;
			if (uSkeletalMeshComponent4 != null)
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(uNiagaraComponent, "User.GS_EfxMinorSkeletalMesh", uSkeletalMeshComponent4);
			}
			else
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableStaticMeshComponent(uNiagaraComponent, "User.GS_EfxMinorStaticMesh", Info.MinorDispOwnerComp as UStaticMeshComponent);
			}
		}
		if (Info.UseExtraCustomParams)
		{
			for (int i = 0; i < Info.SetScalarParam.Count; i++)
			{
				uNiagaraComponent.SetVariableFloat(Info.SetScalarParam[i].ParamName, Info.SetScalarParam[i].Value);
			}
			for (int j = 0; j < Info.SetLColorParam.Count; j++)
			{
				uNiagaraComponent.SetVariableLinearColor(Info.SetLColorParam[j].ParamName, Info.SetLColorParam[j].Value);
			}
		}
		if (Info.SourceRequest.MetaString != default(FName))
		{
			string[] array = Info.SourceRequest.MetaString.PlainName.Split(',');
			if (array.Length >= 1)
			{
				string[] array2 = array;
				foreach (string name in array2)
				{
					uNiagaraComponent.ComponentTags.Add(new FName(name));
				}
			}
		}
		if (Info.SpawnCallback != null)
		{
			Info.SpawnCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent, Info.MetaString));
			if (uNiagaraComponent.IsNullOrDestroyed())
			{
				return false;
			}
		}
		if (dBCOneNiagaraScalabilityManager != null)
		{
			DBCFXInfoBase dBCFXInfoBase2 = dBCOneNiagaraScalabilityManager.PostSpawnNewNiagara(Info, DispLibCameraData.CurFrameCameraPosWS, DispLibCameraData.CurFrameCameraForwardDir);
			if (dBCFXInfoBase2 != null)
			{
				Internal_RequestEndDBCEffects(DispLibDBCIdentityCheckMode.DBCID, dBCFXInfoBase2.SourceDispOwnerComp, dBCFXInfoBase2.IdentityID, dBCFXInfoBase2.EventIndexInDataAsset, 0u, default(FName), OnlyEndFX: true, OnlyEndProcedureEndMode: false, 0);
			}
		}
		return true;
	}

	private bool DoPlayCascade(DBCPlayCascadeInfo Info)
	{
		Info.HasSpawn = true;
		UParticleSystemComponent uParticleSystemComponent = DBCUtilSpawnCascade(Info.SourceDispOwnerComp, Info.EndMode, Info.SourceRequest.Template, DeactiveAtSpawn: false, Info.SourceRequest.AttachedTarget, Info.SourceRequest.AttachedTargetSocketName, Info.SourceRequest.LocationOffset, Info.SourceRequest.RotationOffset, Info.SourceRequest.Scale, Info.SourceRequest.TranslucentSortPriority, Info.DBCOverrideTransform);
		if (uParticleSystemComponent.IsNullOrDestroyed())
		{
			return false;
		}
		if (Info.SpawnCallback != null)
		{
			Info.SpawnCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uParticleSystemComponent));
			if (uParticleSystemComponent.IsNullOrDestroyed())
			{
				return false;
			}
		}
		Info.CascadeComponent = uParticleSystemComponent;
		return true;
	}

	private bool DoChangeMaterial(DBCChangeMaterialInfo Info)
	{
		if (TargetCompIsInvalid(Info.SourceDispOwnerComp))
		{
			return false;
		}
		AActor owner = Info.SourceDispOwnerComp.GetOwner();
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = Info.SourceRequest.FilterMode;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(owner);
		if (bUS_DispLibEventCollection == null)
		{
			return false;
		}
		if (Info.InheriParamsMode == DispLibMaterialParamsInheritMode.CustomInheritParamsNameArray)
		{
			bUS_DispLibEventCollection.Evt_CreateNewMaterialsWithCustomParamsByList(DispLibRefParam.Instance, filterMode, Info.SourceRequest.Template, InheritCurParamQueue: true, Info.SourceRequest.InheritScalarParam, Info.SourceRequest.InheritFLinearColorParam, Info.SourceRequest.InheritTextureParam);
		}
		else
		{
			bUS_DispLibEventCollection.Evt_CreateNewMaterials(DispLibRefParam.Instance, filterMode, Info.SourceRequest.Template, Info.InheriParamsMode);
		}
		if (DispLibRefParam.Instance.DBCReturn_uintID == 0)
		{
			return false;
		}
		Info.ChangeMatEventID = DispLibRefParam.Instance.DBCReturn_uintID;
		foreach (BUC_DispLibUtil_NameAndScalar item in Info.SourceRequest.SetScalarParam)
		{
			bUS_DispLibEventCollection.Evt_SetUnitMatsScalarParam(filterMode, item.ParamName, item.Value, Info.PlayAtTime, Info.Priority);
		}
		foreach (BUC_DispLibUtil_NameAndLColor item2 in Info.SourceRequest.SetColorParam)
		{
			bUS_DispLibEventCollection.Evt_SetUnitMatsFLinearColorParam(filterMode, item2.ParamName, item2.Value, Info.PlayAtTime, Info.Priority);
		}
		Info.HasSpawn = true;
		return true;
	}

	private void Interior_SetParamOnModifyMaterialEventBegin(DBCModifyMaterialInfo Info)
	{
		BUS_DispLibEventCollection eventCollection = Info.EventCollection;
		if (eventCollection == null)
		{
			return;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = Info.SourceRequest.FilterMode;
		foreach (DBCAdvProcessScalarMatLayerParam scalarParam in Info.ScalarParams)
		{
			eventCollection.Evt_SetUnitMatsScalarParamByInfo_Immed(filterMode, scalarParam.Association, scalarParam.ParamName, scalarParam.LayerFunction, scalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			eventCollection.Evt_ScalarParamOperationCounterAdd(filterMode, scalarParam.Association, scalarParam.LayerFunction, scalarParam.ParamName, Info.MatManagerReturnID, default(FName));
		}
		foreach (DBCAdvProcessFLinearColorMatLayerParam fLinearColorParam in Info.FLinearColorParams)
		{
			eventCollection.Evt_SetUnitMatsFLinearColorParamByInfo_Immed(filterMode, fLinearColorParam.Association, fLinearColorParam.ParamName, fLinearColorParam.LayerFunction, fLinearColorParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			eventCollection.Evt_ColorParamOperationCounterAdd(filterMode, fLinearColorParam.Association, fLinearColorParam.LayerFunction, fLinearColorParam.ParamName, Info.MatManagerReturnID, default(FName));
		}
		foreach (DBCPCurveScalarMatLayerParam pCurveScalarParam in Info.PCurveScalarParams)
		{
			eventCollection.Evt_SetUnitMatsScalarParamByInfo_Immed(filterMode, pCurveScalarParam.Association, pCurveScalarParam.ParamName, pCurveScalarParam.LayerFunction, pCurveScalarParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			eventCollection.Evt_ScalarParamOperationCounterAdd(filterMode, pCurveScalarParam.Association, pCurveScalarParam.LayerFunction, pCurveScalarParam.ParamName, Info.MatManagerReturnID, default(FName));
		}
		foreach (DBCPCurveLinearColorMatLayerParam pCurveFLinearColorParam in Info.PCurveFLinearColorParams)
		{
			eventCollection.Evt_SetUnitMatsFLinearColorParamByInfo_Immed(filterMode, pCurveFLinearColorParam.Association, pCurveFLinearColorParam.ParamName, pCurveFLinearColorParam.LayerFunction, pCurveFLinearColorParam.CurFrameValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			eventCollection.Evt_ColorParamOperationCounterAdd(filterMode, pCurveFLinearColorParam.Association, pCurveFLinearColorParam.LayerFunction, pCurveFLinearColorParam.ParamName, Info.MatManagerReturnID, default(FName));
		}
		foreach (DBCTextureMatLayerParam textureParam in Info.TextureParams)
		{
			eventCollection.Evt_SetUnitMatsTextureParamByInfo_Immed(filterMode, textureParam.Association, textureParam.ParamName, textureParam.LayerFunction, textureParam.SourceStruct.TextureValue, Info.PlayAtTime, Info.OnEndDispStage ? Info.ModMatEndStagePriority : Info.ModMatPriority);
			eventCollection.Evt_TextureParamOperationCounterAdd(filterMode, textureParam.Association, textureParam.LayerFunction, textureParam.ParamName, Info.MatManagerReturnID, default(FName));
		}
	}

	private bool DoModifyMaterial(DBCModifyMaterialInfo Info)
	{
		if (!Info.CheckValid())
		{
			BGW_LogUtil.LogError("[DBC] [ModMat] [DoModifyMaterial] On DoModifyMaterial begin. CheckValid() = False. Event remove.");
			return false;
		}
		BUS_DispLibEventCollection eventCollection = Info.EventCollection;
		if (eventCollection == null)
		{
			return false;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = Info.SourceRequest.FilterMode;
		if (Info.InheriParamsMode == DispLibMaterialParamsInheritMode.CustomInheritParamsNameArray)
		{
			eventCollection.Evt_CreateNewMaterialsWithCustomParamsByList(DispLibRefParam.Instance, filterMode, Info.SourceRequest.Template, InheritCurParamQueue: true, Info.SourceRequest.InheritScalarParam, Info.SourceRequest.InheritFLinearColorParam, Info.SourceRequest.InheritTextureParam);
		}
		else
		{
			eventCollection.Evt_CreateNewMaterials(DispLibRefParam.Instance, filterMode, Info.SourceRequest.Template, Info.InheriParamsMode);
		}
		if (DispLibRefParam.Instance.DBCReturn_uintID == 0)
		{
			return false;
		}
		Info.MatManagerReturnID = DispLibRefParam.Instance.DBCReturn_uintID;
		Interior_SetParamOnModifyMaterialEventBegin(Info);
		Info.HasSpawn = true;
		return true;
	}

	private bool DoModifyNiagaraParams(DBCModifyNiagaraParamsInfo Info)
	{
		if (!Info.CheckValid())
		{
			BGW_LogUtil.LogError("[DBC] [ModNiagaraParams] [DoDBCModifyNiagaraParamsInfo] On DoDBCModifyNiagaraParamsInfo begin. CheckValid() = False. Event remove.");
			return false;
		}
		AActor owner = Info.SourceDispOwnerComp.GetOwner();
		Info.SourceDispOwnerComp.GetUniqueID();
		_ = Info.NiagaraCompFilterInfo;
		_ = Info.MeshCompFilterInfo;
		if (BUS_DispLibEventCollection.Get(owner) == null)
		{
			return false;
		}
		foreach (DBCFXInfoBase item in Interior_GetAllMatachedNiagaraInfo(Info.SourceDispOwnerComp, Info.MeshCompFilterInfo, Info.NiagaraCompFilterInfo))
		{
			UNiagaraComponent uNiagaraComponent = item.NiagaraComponent.Get();
			if (uNiagaraComponent.IsNullOrDestroyed())
			{
				continue;
			}
			for (int i = 0; i < Info.BoolParamsInfo.Count; i++)
			{
				ModifyNiagaraParamsBoolParamInfo modifyNiagaraParamsBoolParamInfo = Info.BoolParamsInfo[i];
				uNiagaraComponent.SetBoolParameter(modifyNiagaraParamsBoolParamInfo.ParamName, modifyNiagaraParamsBoolParamInfo.CurFrameValue);
			}
			for (int j = 0; j < Info.FloatParamsInfo.Count; j++)
			{
				ModifyNiagaraParamsFloatParamInfo modifyNiagaraParamsFloatParamInfo = Info.FloatParamsInfo[j];
				uNiagaraComponent.SetVariableFloat(modifyNiagaraParamsFloatParamInfo.ParamName, modifyNiagaraParamsFloatParamInfo.CurFrameValue);
			}
			for (int k = 0; k < Info.Int32ParamsInfo.Count; k++)
			{
				ModifyNiagaraParamsFloatParamInfo modifyNiagaraParamsFloatParamInfo2 = Info.Int32ParamsInfo[k];
				uNiagaraComponent.SetVariableInt(modifyNiagaraParamsFloatParamInfo2.ParamName, (int)modifyNiagaraParamsFloatParamInfo2.CurFrameValue);
			}
			for (int l = 0; l < Info.FVectorParamsInfo.Count; l++)
			{
				ModifyNiagaraParamsFVectorParamInfo modifyNiagaraParamsFVectorParamInfo = Info.FVectorParamsInfo[l];
				uNiagaraComponent.SetVariableVec3(modifyNiagaraParamsFVectorParamInfo.ParamName, modifyNiagaraParamsFVectorParamInfo.CurFrameValue);
			}
			for (int m = 0; m < Info.FLinearColorParamsInfo.Count; m++)
			{
				ModifyNiagaraParamsFLinearColorParamInfo modifyNiagaraParamsFLinearColorParamInfo = Info.FLinearColorParamsInfo[m];
				uNiagaraComponent.SetVariableLinearColor(modifyNiagaraParamsFLinearColorParamInfo.ParamName, modifyNiagaraParamsFLinearColorParamInfo.CurFrameValue);
			}
			for (int n = 0; n < Info.FLinearColorParamsInfo.Count; n++)
			{
				ModifyNiagaraParamsFLinearColorParamInfo modifyNiagaraParamsFLinearColorParamInfo2 = Info.FLinearColorParamsInfo[n];
				uNiagaraComponent.SetVariableLinearColor(modifyNiagaraParamsFLinearColorParamInfo2.ParamName, modifyNiagaraParamsFLinearColorParamInfo2.CurFrameValue);
			}
			for (int num = 0; num < Info.SourceRequest.SetFloatArrayParam.Count; num++)
			{
				BUC_DispLibUtil_NameAndFloatArray bUC_DispLibUtil_NameAndFloatArray = Info.SourceRequest.SetFloatArrayParam[num];
				if (bUC_DispLibUtil_NameAndFloatArray.IsValid())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayFloat(uNiagaraComponent, bUC_DispLibUtil_NameAndFloatArray.ParamName, bUC_DispLibUtil_NameAndFloatArray.FloatArray.ToList());
				}
			}
			for (int num2 = 0; num2 < Info.SourceRequest.SetInt32ArrayParam.Count; num2++)
			{
				BUC_DispLibUtil_NameAndInt32Array bUC_DispLibUtil_NameAndInt32Array = Info.SourceRequest.SetInt32ArrayParam[num2];
				if (bUC_DispLibUtil_NameAndInt32Array.IsValid())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayInt32(uNiagaraComponent, bUC_DispLibUtil_NameAndInt32Array.ParamName, bUC_DispLibUtil_NameAndInt32Array.Int32Array.ToList());
				}
			}
			for (int num3 = 0; num3 < Info.SourceRequest.SetFVectorArrayParam.Count; num3++)
			{
				BUC_DispLibUtil_NameAndFVectorArray bUC_DispLibUtil_NameAndFVectorArray = Info.SourceRequest.SetFVectorArrayParam[num3];
				if (bUC_DispLibUtil_NameAndFVectorArray.IsValid())
				{
					UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(uNiagaraComponent, bUC_DispLibUtil_NameAndFVectorArray.ParamName, bUC_DispLibUtil_NameAndFVectorArray.FVectorArray.ToList());
				}
			}
			if (Info.SourceRequest.SetOverrideSelfMeshBones.Count > 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(uNiagaraComponent, "User.GS_EfxSelfSkeletalMesh", Info.SourceRequest.SetOverrideSelfMeshBones.ToList());
			}
			if (Info.SourceRequest.SetOverrideSelfMeshSockets.Count > 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(uNiagaraComponent, "User.GS_EfxSelfSkeletalMesh", Info.SourceRequest.SetOverrideSelfMeshSockets.ToList());
			}
		}
		Info.HasSpawn = true;
		return true;
	}

	private bool Interior_CheckNiagaraInfoMatchedNGFilterInfo<T>(T Info, BUC_DispLibDBC_ModifyNiagaraTargetInfo NG_FilterInfo) where T : DBCFXInfoBase
	{
		if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.AllNiagara)
		{
			return true;
		}
		if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.ByName)
		{
			if (Info.Template.IsNullOrDestroyed())
			{
				return false;
			}
			string name = Info.Template.GetName();
			foreach (FName item in NG_FilterInfo.TargetString)
			{
				if (name.Contains(item.PlainName))
				{
					return true;
				}
			}
			return false;
		}
		if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.ByExcludeName)
		{
			if (Info.Template.IsNullOrDestroyed())
			{
				return false;
			}
			string name2 = Info.Template.GetName();
			foreach (FName item2 in NG_FilterInfo.TargetString)
			{
				if (name2.Contains(item2.PlainName))
				{
					return false;
				}
			}
			return true;
		}
		if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.ByTags)
		{
			UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
			if (uNiagaraComponent.IsNullOrDestroyed())
			{
				return false;
			}
			foreach (FName item3 in NG_FilterInfo.TargetString)
			{
				if (uNiagaraComponent.ComponentHasTag(item3))
				{
					return true;
				}
			}
		}
		else
		{
			if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.ByExcludeTags)
			{
				UNiagaraComponent uNiagaraComponent2 = Info.NiagaraComponent.Get();
				if (uNiagaraComponent2.IsNullOrDestroyed())
				{
					return false;
				}
				foreach (FName item4 in NG_FilterInfo.TargetString)
				{
					if (uNiagaraComponent2.ComponentHasTag(item4))
					{
						return false;
					}
				}
				return true;
			}
			if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.BySystemAsset)
			{
				if (Info.Template.IsNullOrDestroyed())
				{
					return false;
				}
				if (Info.Template == NG_FilterInfo.TargetSystem)
				{
					return true;
				}
			}
			else if (NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.ByExcludeSystemAsset)
			{
				if (Info.Template.IsNullOrDestroyed())
				{
					return false;
				}
				if (Info.Template != NG_FilterInfo.TargetSystem)
				{
					return true;
				}
			}
		}
		return false;
	}

	private List<T> Interior_GetAllMatchedNiagaraInfoInDBCNiagaraInfoPool<T>(BUC_DispLibDBC_EntityEffectTargetInfo Mesh_FilterInfo, BUC_DispLibDBC_ModifyNiagaraTargetInfo NG_FilterInfo, List<T> NiagaraInfoPool) where T : DBCFXInfoBase
	{
		if (Mesh_FilterInfo.CompsFilterMode == DispLibDBCCompsFilterMode.AllComps && NG_FilterInfo.FilterMode == DispLibDBCNiagaraFilterMode.AllNiagara)
		{
			return NiagaraInfoPool;
		}
		List<T> list = new List<T>();
		for (int num = NiagaraInfoPool.Count - 1; num >= 0; num--)
		{
			T val = NiagaraInfoPool[num];
			if (Mesh_FilterInfo.CompsFilterMode == DispLibDBCCompsFilterMode.AllComps)
			{
				if (Interior_CheckNiagaraInfoMatchedNGFilterInfo(val, NG_FilterInfo))
				{
					list.Add(val);
				}
			}
			else if (Mesh_FilterInfo.CompsFilterMode == DispLibDBCCompsFilterMode.ByTags)
			{
				FName item = ((val.OverrideMeshCompTagName == FName.None) ? DispLibDispWorld.MasterComp : val.OverrideMeshCompTagName);
				if (Mesh_FilterInfo.CompTags.Contains(item) && Interior_CheckNiagaraInfoMatchedNGFilterInfo(val, NG_FilterInfo))
				{
					list.Add(val);
				}
			}
			else if (Mesh_FilterInfo.CompsFilterMode == DispLibDBCCompsFilterMode.ByExcludeTags)
			{
				FName item2 = ((val.OverrideMeshCompTagName == FName.None) ? DispLibDispWorld.MasterComp : val.OverrideMeshCompTagName);
				if (!Mesh_FilterInfo.CompTags.Contains(item2) && Interior_CheckNiagaraInfoMatchedNGFilterInfo(val, NG_FilterInfo))
				{
					list.Add(val);
				}
			}
		}
		return list;
	}

	private List<DBCFXInfoBase> Interior_GetAllMatachedNiagaraInfo(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_EntityEffectTargetInfo Mesh_FilterInfo, BUC_DispLibDBC_ModifyNiagaraTargetInfo NG_FilterInfo)
	{
		uint uniqueID = SourceDispOwnerComp.GetUniqueID();
		return Interior_GetAllMatachedNiagaraInfo(uniqueID, Mesh_FilterInfo, NG_FilterInfo);
	}

	private List<DBCFXInfoBase> Interior_GetAllMatachedNiagaraInfo(uint SourceDispOwnerCompID, BUC_DispLibDBC_EntityEffectTargetInfo Mesh_FilterInfo, BUC_DispLibDBC_ModifyNiagaraTargetInfo NG_FilterInfo)
	{
		List<DBCFXInfoBase> list = new List<DBCFXInfoBase>();
		if (Queue.PlayNiagaraCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value))
		{
			foreach (DBCPlayNiagaraInfo item in Interior_GetAllMatchedNiagaraInfoInDBCNiagaraInfoPool(Mesh_FilterInfo, NG_FilterInfo, value))
			{
				list.Add(item);
			}
		}
		if (Queue.PlayAdvanceNiagaraCacheQueue.TryGetValue(SourceDispOwnerCompID, out var value2))
		{
			foreach (DBCPlayAdvanceNiagaraInfo item2 in Interior_GetAllMatchedNiagaraInfoInDBCNiagaraInfoPool(Mesh_FilterInfo, NG_FilterInfo, value2))
			{
				list.Add(item2);
			}
		}
		return list;
	}

	private bool DoPlayArtFresnel(DBCPlayArtFresnelInfo Info)
	{
		if (TargetCompIsInvalid(Info.SourceDispOwnerComp))
		{
			return false;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Info.SourceDispOwnerComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return false;
		}
		Info.HasSpawn = true;
		BUC_DispLibDBC_PlayArtFresnel sourceRequest = Info.SourceRequest;
		bUS_DispLibEventCollection.Evt_RequestOneCustomUAFByDataAsset(sourceRequest.FilterMode, sourceRequest.CustomUAFDataAsset, sourceRequest.Priority, DispLibRefParam.Instance, sourceRequest.OverrideTime, sourceRequest.OverrideOnePeriodTime, sourceRequest.OverrideLoop, sourceRequest.OverrideSimpleProgrammedCurve, sourceRequest.OverrideFadeInTime, sourceRequest.OverrideCommonTime, sourceRequest.OverrideFadeOutTime, sourceRequest.OverrideProgrammedPowerMax);
		Info.UAFID = DispLibRefParam.Instance.DBCReturn_uintID;
		if (Info.UAFID == 0)
		{
			return false;
		}
		return true;
	}

	private bool DoPlayCameraShake(DBCPlayCameraShakeInfo Info)
	{
		float curTime = GetCurTime();
		if (Info.SourceRequest.ForceApply || curTime - GlobalData.CurCameraShakeStartTime > BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCGlobalCameraShakeProtectedTime)
		{
			if (DispLibCameraData.PlayerCameraManager.Get().IsNullOrDestroyed())
			{
				return false;
			}
			Info.HasSpawn = true;
			UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(Info.SourceDispOwnerComp.GetOwner(), Info.SourceRequest.CameraShake.Value);
			if (uMatineeCameraShake.IsNullOrDestroyed())
			{
				return false;
			}
			float override_Oscillation_Duration = Info.SourceRequest.Override_Oscillation_Duration;
			if (override_Oscillation_Duration > 0f)
			{
				uMatineeCameraShake.OscillatorTimeRemaining = override_Oscillation_Duration;
			}
			Info.CameraShakeInst = uMatineeCameraShake;
			GlobalData.CurCameraShakeStartTime = curTime;
			CameraShakeUpdate(Info, 0f);
			return true;
		}
		return false;
	}

	private bool DoPlayCustomCameraShake(DBCPlayCustomCameraShakeInfo Info)
	{
		float curTime = GetCurTime();
		if (Info.SourceRequest.ForceApply || curTime - GlobalData.CurCameraShakeStartTime > BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.DBCGlobalCameraShakeProtectedTime)
		{
			if (DispLibCameraData.PlayerCameraManager.Get().IsNullOrDestroyed())
			{
				return false;
			}
			Info.HasSpawn = true;
			UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(Info.SourceDispOwnerComp.GetOwner(), UObject.GetDefault<UMatineeCameraShake>().GetClass());
			if (uMatineeCameraShake.IsNullOrDestroyed())
			{
				return false;
			}
			Info.CameraShakeInst = uMatineeCameraShake;
			Info.CameraShakeInst.OscillatorTimeRemaining = Info.SourceRequest.TotalTime;
			CustomCameraShakeUpdate(Info, 0f);
			GlobalData.CurCameraShakeStartTime = curTime;
			return true;
		}
		return false;
	}

	private bool DoPlayAudio(DBCPlayAudioInfo Info)
	{
		if (Info.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			return false;
		}
		USceneComponent uSceneComponent = Info.SourceDispOwnerComp;
		FVector zeroVector = FVector.ZeroVector;
		FRotator zeroRotator = FRotator.ZeroRotator;
		if (Info.SourceRequest.CompTag != FName.None && BGU_DataUtil.GetReadOnlyData<BUC_DispLibUnitRendererBaseData>(Info.SourceDispOwnerComp.GetOwner()).GetFirstMatchMeshComp(Info.SourceRequest.CompTag, out var Result))
		{
			uSceneComponent = Result;
		}
		if (uSceneComponent == null)
		{
			return false;
		}
		if (Info.SourceRequest.SocketName != FName.None)
		{
			zeroVector = uSceneComponent.GetSocketLocation(Info.SourceRequest.SocketName);
			zeroRotator = uSceneComponent.GetSocketRotation(Info.SourceRequest.SocketName);
		}
		else
		{
			zeroVector = uSceneComponent.GetWorldLocation();
			zeroRotator = uSceneComponent.GetWorldRotation();
		}
		AActor owner = Info.SourceDispOwnerComp.GetOwner();
		int wWiseID;
		if (Info.SourceRequest.FollowActor)
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(uSceneComponent, out ComponentCreated, Info.SourceRequest.SocketName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			if (akComponent.IsNullOrDestroyed())
			{
				return false;
			}
			if (ComponentCreated)
			{
				akComponent.OcclusionCollisionChannel = (EAkCollisionChannel)27;
				akComponent.SetAutoDestroyCS(_bAutoDestory: true);
			}
			wWiseID = akComponent.PostAkEvent(Info.SourceRequest.AkAudioEvent, 0, null, string.Empty);
		}
		else
		{
			wWiseID = UAkGameplayStatics.PostEventAtLocation(Info.SourceRequest.AkAudioEvent, zeroVector, zeroRotator, string.Empty, owner.World);
		}
		if (Info.RTPC != null)
		{
			bool ComponentCreated2;
			UAkComponent akComponent2 = UAkGameplayStatics.GetAkComponent(Info.SourceDispOwnerComp, out ComponentCreated2, Info.SourceRequest.SocketName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			if (akComponent2.IsNullOrDestroyed())
			{
				return false;
			}
			for (int i = 0; i < Info.RTPC.Count; i++)
			{
				DBCAdvProcessScalarParam dBCAdvProcessScalarParam = Info.RTPC[i];
				dBCAdvProcessScalarParam.UpdateValue(0f, 0f);
				akComponent2.SetRTPCValue(null, dBCAdvProcessScalarParam.CurFrameValue, 0, dBCAdvProcessScalarParam.ParamName.PlainName);
			}
		}
		if (Info.WWiseID != -1 && Info.ForceAudioMute != -1)
		{
			UAkGameplayStatics.SetRTPCValueByPlayingID(Info.WWiseID, (Info.ForceAudioMute != 0) ? 1 : 0, B1GlobalFNames.RTPC_Volume_Global_GamePlayLogic);
		}
		Info.HasSpawn = true;
		Info.WWiseID = wWiseID;
		return true;
	}

	private bool DoSPI(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ScenePhysicalInteractor D)
	{
		if (TargetCompIsInvalid(SourceDispOwnerComp))
		{
			return false;
		}
		AActor owner = SourceDispOwnerComp.GetOwner();
		if (!owner.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_FireImpulseLikeRadialForceComp.Invoke(owner, (EPhysicsForceType)D.EffectType, D.EffectSize.X, FVector.ZeroVector, D.DestructibleDamage, D.Intensity, D.QueryObjectTypes, D.Duration);
		}
		return true;
	}

	private bool DoSpawnSimpleActor(DBCSpawnSimpleActorInfo Info)
	{
		if (TargetCompIsInvalid(Info.SourceDispOwnerComp))
		{
			return false;
		}
		Info.HasSpawn = true;
		BUC_DispLibDBC_SpawnSimpleActor sourceRequest = Info.SourceRequest;
		AActor aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(Info.SourceDispOwnerComp.GetOwner().World, sourceRequest.Template.Value);
		if (aActor.IsNullOrDestroyed())
		{
			return false;
		}
		FHitResult SweepHitResult = default(FHitResult);
		Info.DBCOverrideTransform.IsValid();
		if (Info.DBCOverrideTransform.TransformUseAll)
		{
			aActor.SetActorLocationAndRotation(Info.DBCOverrideTransform.Transform.GetLocation(), Info.DBCOverrideTransform.Transform.Rotator(), bSweep: false, out SweepHitResult, bTeleport: false);
		}
		else if (sourceRequest.AttachedTarget)
		{
			aActor.AttachRootComponentTo(Info.SourceDispOwnerComp, sourceRequest.AttachedTargetSocketName, EAttachLocation.KeepRelativeOffset, bWeldSimulatedBodies: false);
			aActor.SetActorRelativeLocation(sourceRequest.AttachedTargetLocationOffset, bSweep: false, out SweepHitResult, bTeleport: false);
			aActor.SetActorRelativeRotation(sourceRequest.AttachedTargetRotationOffset, bSweep: false, out SweepHitResult, bTeleport: false);
		}
		else
		{
			FTransform socketTransform = Info.SourceDispOwnerComp.GetSocketTransform(sourceRequest.AttachedTargetSocketName);
			FQuat fQuat = new FQuat(sourceRequest.AttachedTargetRotationOffset);
			aActor.SetActorLocationAndRotation(socketTransform.TransformPosition(sourceRequest.AttachedTargetLocationOffset), (socketTransform.GetRotation() * fQuat).Rotator(), bSweep: false, out SweepHitResult, bTeleport: false);
		}
		DispLib_DBCSimpleActorBaseData componentByClass = aActor.GetComponentByClass<DispLib_DBCSimpleActorBaseData>();
		if (!componentByClass.IsNullOrDestroyed())
		{
			componentByClass.Init(sourceRequest.Duration, Info.EndAtTime, Info.MinorDispOwnerComp, Info.MinorDispCompPosWSOnSpawn, Info.SourceDispOwnerComp, Info.SourceDispOwnerComp.GetWorldLocation());
		}
		Info.SpawnedSimpleActor = aActor;
		if (Info.SpawnCallback != null)
		{
			Info.SpawnCallback(DispLibRefParam.Instance.Set(Info.IdentityID, aActor));
			if (aActor.IsNullOrDestroyed())
			{
				return false;
			}
		}
		return true;
	}

	private bool DoCustomEvent(DBCCustomEventInfo Info)
	{
		Info.HasTrigger = true;
		DBCCustomEventTimeInfo timeInfo = new DBCCustomEventTimeInfo(Info.PlayAtTime, Info.RealEndMode, Info.SourceRequest.Duration, Info.DelayTimeAfterStop);
		DBCCustomEventAdditionalInfo additionalInfo = new DBCCustomEventAdditionalInfo(Info.SourceDispOwnerComp, Info.MinorDispOwnerComp, Info.AnimNotifyUniqueID, Info.MontageUniqueID, Info.DBCOverrideTransform);
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Info.SourceDispOwnerComp.GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return false;
		}
		bUS_DispLibEventCollection.Evt_DBCTriggerOneCustomEvent(Info.IdentityID, Info.CustomEventID, Info.ParametersDataAssets, timeInfo, additionalInfo);
		return true;
	}

	private void RefreshCameraData(float DeltaTime)
	{
		APlayerCameraManager aPlayerCameraManager = DispLibCameraData.PlayerCameraManager.Get();
		if (!aPlayerCameraManager.IsNullOrDestroyed())
		{
			FVector cameraLocation = aPlayerCameraManager.GetCameraLocation();
			DispLibCameraData.CurFrameCameraPosWS = cameraLocation;
			if (DispLibCameraData.CameraComp.IsValid())
			{
				DispLibCameraData.CurFrameCameraForwardDir = DispLibCameraData.CameraComp.Get().GetForwardVector();
			}
			else
			{
				DispLibCameraData.CurFrameCameraForwardDir = FVector.ForwardVector;
			}
			DispLibCameraData.CurFrameCameraRotation = aPlayerCameraManager.GetCameraRotation();
			DispLibCameraData.CameraMoveV3 = cameraLocation - DispLibCameraData.LastFrameCameraPosWS;
			DispLibCameraData.CameraVelocity = DispLibCameraData.CameraMoveV3 / DeltaTime;
			DispLibCameraData.CameraVelocityDirection = DispLibCameraData.CameraVelocity.GetSafeNormal();
		}
	}

	private APawn GetPlayerControllerControlledPawn()
	{
		if (DispLibCameraData.PlayerController.Get().IsNullOrDestroyed())
		{
			return null;
		}
		return DispLibCameraData.PlayerController.Get().GetControlledPawn();
	}

	private void DoGameUtilityDataUpdate()
	{
		ACharacter aCharacter = GetPlayerControllerControlledPawn() as ACharacter;
		if (aCharacter.IsNullOrDestroyed())
		{
			return;
		}
		FVector actorLocation = aCharacter.GetActorLocation();
		FVector fVector = aCharacter.GetActorRotation().Conv_RotatorToVector();
		if (!GlobalData.GameUtilityData_NPCInstance.IsNullOrDestroyed())
		{
			GlobalData.GameUtilityData_NPCInstance.SetVectorParameter("GS_PlayerPosWS", actorLocation);
			GlobalData.GameUtilityData_NPCInstance.SetVectorParameter("GS_PlayerRotationWS", fVector);
			if (LevelData != null)
			{
				GlobalData.GameUtilityData_NPCInstance.SetIntParameter("GS_LevelID", LevelData.CurrentLevelID);
			}
			else
			{
				GlobalData.GameUtilityData_NPCInstance.SetIntParameter("GS_LevelID", 0);
			}
		}
		if (!GlobalData.GameUtilityData_MatPCInstance.IsNullOrDestroyed())
		{
			FLinearColor Val = new FLinearColor(actorLocation);
			FLinearColor Val2 = new FLinearColor(fVector);
			GSE_RenderFunc.MaterialSetVectorParameterValue(DBCBaseData.OwnerActor.Address, GlobalData.GameUtilityData_MatPCInstance.Address, B1GlobalFNames.GS_PlayerPosWS, ref Val);
			GSE_RenderFunc.MaterialSetVectorParameterValue(DBCBaseData.OwnerActor.Address, GlobalData.GameUtilityData_MatPCInstance.Address, B1GlobalFNames.GS_PlayerRotationWS, ref Val2);
		}
		if (!GlobalData.GameUtilityData_MatPCInstance_SDF.IsNullOrDestroyed() && aCharacter.CharacterMovement != null)
		{
			FLinearColor Val3 = new FLinearColor(aCharacter.CharacterMovement.Velocity);
			GSE_RenderFunc.MaterialSetVectorParameterValue(DBCBaseData.OwnerActor.Address, GlobalData.GameUtilityData_MatPCInstance_SDF.Address, B1GlobalFNames.GS_PlayerVelocity, ref Val3);
		}
	}

	private void DoMPCUpdate()
	{
		if (!Queue.HasMPCParamNeedReset)
		{
			return;
		}
		foreach (KeyValuePair<string, Dictionary<FName, DispLib_One_MPC_ScalarParamState>> item in Queue.MPC_ScalarParamStateCacheQueue)
		{
			string key = item.Key;
			UMaterialParameterCollection collection = GlobalData.LoadAndGetMPCInstance(DBCBaseData.DispOwnerComp.GetOwner(), key);
			foreach (DispLib_One_MPC_ScalarParamState value in item.Value.Values)
			{
				if (value.CurTickNeedReset2InitialValue)
				{
					if (value.isInitialValueValid)
					{
						UMaterialLibrary.SetScalarParameterValue(DBCBaseData.DispOwnerComp.GetOwner(), collection, value.ParamName, value.InitialValue);
					}
					value.OnParamValueReset();
				}
			}
		}
		foreach (KeyValuePair<string, Dictionary<FName, DispLib_One_MPC_ColorParamState>> item2 in Queue.MPC_ColorParamStateCacheQueue)
		{
			string key2 = item2.Key;
			UMaterialParameterCollection collection2 = GlobalData.LoadAndGetMPCInstance(DBCBaseData.DispOwnerComp.GetOwner(), key2);
			foreach (DispLib_One_MPC_ColorParamState value2 in item2.Value.Values)
			{
				if (value2.CurTickNeedReset2InitialValue)
				{
					if (value2.isInitialValueValid)
					{
						UMaterialLibrary.SetVectorParameterValue(DBCBaseData.DispOwnerComp.GetOwner(), collection2, value2.ParamName, value2.InitialValue);
					}
					value2.OnParamValueReset();
				}
			}
		}
		Queue.HasMPCParamNeedReset = false;
	}

	private void DoCameraEnvFXUpdate()
	{
		if (!GlobalData.CameraEnvFXComp.IsNullOrDestroyed() && !DispLibCameraData.PlayerCameraManager.Get().IsNullOrDestroyed())
		{
			FVector fVector = new FRotator(0.0, DispLibCameraData.CurFrameCameraRotation.Yaw, 0.0).RotateVector(BGW_DispLibGameDB.GameDBDataAsset.CameraEnvFXDA.CameraOffset);
			GlobalData.CameraEnvFXComp.SetWorldLocation(DispLibCameraData.CurFrameCameraPosWS + fVector, bSweep: false, out var _, bTeleport: true);
		}
	}

	private bool CheckRefreshWEFM()
	{
		if (GlobalData.WEFMNeedRefresh)
		{
			GlobalData.WEFMRefreshDelayACC++;
			if (GlobalData.WEFMRefreshDelayACC >= 3)
			{
				GlobalData.WEFMNeedRefresh = false;
				GlobalData.WEFMRefreshDelayACC = 0;
				UNiagaraComponent uNiagaraComponent = DispLibDispWorld.GetInstance(DBCBaseData.DispOwnerComp)?.WEFMManager;
				if (uNiagaraComponent.IsNullOrDestroyed())
				{
					return false;
				}
				uNiagaraComponent.SetActive(bNewActive: true, bReset: true);
				return true;
			}
			return false;
		}
		return true;
	}

	private bool RefreshWEFMNPCSetting(int WEFMLODIndex)
	{
		GlobalData.WEFMNeedRefresh = false;
		GlobalData.WEFMRefreshDelayACC = 0;
		if (WEFMLODIndex < 0 && WEFMLODIndex >= BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMLODSettingArray.Count)
		{
			return false;
		}
		WEFMLODSetting wEFMLODSetting = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMLODSettingArray[WEFMLODIndex];
		if (!wEFMLODSetting.isValid())
		{
			return false;
		}
		UTextureRenderTarget2D wEFM_RT2D = BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFM_RT2D;
		if (wEFM_RT2D.IsNullOrDestroyed())
		{
			return false;
		}
		UNiagaraParameterCollectionInstance wEFM_NPCInstance = GlobalData.WEFM_NPCInstance;
		wEFM_NPCInstance.SetFloatParameter("CellLength", wEFMLODSetting.CellLength);
		wEFM_NPCInstance.GetFloatParameter("CellLength");
		wEFM_NPCInstance.SetVectorParameter("CellNumV3", wEFMLODSetting.CellNumV3);
		wEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCorner_LastFramePosWS", FVector.ZeroVector);
		wEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCornerPosWS", FVector.ZeroVector);
		FVector cellNumV = wEFMLODSetting.CellNumV3;
		cellNumV = new FVector((int)cellNumV.X, (int)cellNumV.Y, (int)cellNumV.Z);
		FVector fVector = cellNumV * wEFMLODSetting.CellLength;
		fVector = new FVector((int)fVector.X, (int)fVector.Y, (int)fVector.Z);
		wEFM_NPCInstance.SetVectorParameter("HalfBoxSizeV3", fVector * 0.5);
		wEFM_NPCInstance.SetVectorParameter("MaxBoxSizeV3", fVector);
		wEFM_NPCInstance.SetVector2DParameter("RT2D_OneCellSizeV2", new FVector2D(cellNumV.X, cellNumV.Y));
		wEFM_NPCInstance.SetFloatParameter("RT2D_OneSideCellCount", (int)Math.Sqrt(cellNumV.Z));
		wEFM_NPCInstance.SetFloatParameter("ScaleRt2DSize", wEFMLODSetting.ScaleRT2DSize);
		URenderingLibrary.ClearRenderTarget2D(DBCBaseData.DispOwnerComp, wEFM_RT2D, new FLinearColor(0.0, 0.0, 0.0, 0.0));
		GlobalData.WEFMNeedRefresh = true;
		return true;
	}

	private void DoWEFMField()
	{
		ACharacter playerCharacter = UGameplayStatics.GetPlayerCharacter(DBCBaseData.DispOwnerComp, 0);
		if (!playerCharacter.IsNullOrDestroyed())
		{
			float floatParameter = GlobalData.WEFM_NPCInstance.GetFloatParameter("CellLength");
			FVector vectorParameter = GlobalData.WEFM_NPCInstance.GetVectorParameter("HalfBoxSizeV3");
			FVector vectorParameter2 = GlobalData.WEFM_NPCInstance.GetVectorParameter("BoxCustomOffset");
			FVector actorLocation = playerCharacter.GetActorLocation();
			actorLocation.Z += vectorParameter.Z * 0.5f;
			FVector fVector = (actorLocation - vectorParameter + vectorParameter2) / floatParameter;
			FVector fVector2 = floatParameter * new FVector((int)fVector.X, (int)fVector.Y, (int)fVector.Z);
			GlobalData.WEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCornerPosWS", fVector2);
			GlobalData.WEFM_NPCInstance.SetVectorParameter("GS_MaxBoxStartCorner_LastFramePosWS", GlobalData.WEFM_LastFrameMaxBoxSCPosWS);
			UMaterialLibrary.SetVectorParameterValue(GetOwner().World, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMMPC, B1GlobalFNames.MaxBoxStartCornerPosWS, new FLinearColor(fVector2));
			UMaterialLibrary.SetVectorParameterValue(GetOwner().World, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMMPC, B1GlobalFNames.MaxBoxStartCorner_LastFramePosWS, new FLinearColor(GlobalData.WEFM_LastFrameMaxBoxSCPosWS));
			GlobalData.WEFM_LastFrameMaxBoxSCPosWS = fVector2;
			FVector vectorParameter3 = GlobalData.WEFM_NPCInstance.GetVectorParameter("MaxBoxSizeV3");
			UMaterialLibrary.SetVectorParameterValue(GetOwner().World, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMMPC, B1GlobalFNames.MaxBoxSizeV3, new FLinearColor(vectorParameter3));
			float floatParameter2 = GlobalData.WEFM_NPCInstance.GetFloatParameter("RT2D_OneSideCellCount");
			UMaterialLibrary.SetScalarParameterValue(GetOwner().World, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMMPC, B1GlobalFNames.RT2D_OneSideCellCount, floatParameter2);
			FVector2D vector2DParameter = GlobalData.WEFM_NPCInstance.GetVector2DParameter("RT2D_OneCellSizeV2");
			UMaterialLibrary.SetVectorParameterValue(GetOwner().World, BGW_DispLibGameDB.GameDBDataAsset.DispConstDA.WEFMMPC, B1GlobalFNames.RT2D_OneCellSizeV2, new FLinearColor(vector2DParameter.X, vector2DParameter.Y, 0f, 0f));
		}
	}

	private void DoWind()
	{
		UNiagaraComponent wEFMManager = DispLibDispWorld.GetInstance(GetOwner()).WEFMManager;
		if (wEFMManager.IsNullOrDestroyed())
		{
			return;
		}
		int num = 0;
		int num2 = Math.Min(Queue.WEFM_ValidEventsCount, Queue.WEFM_EveryFrameExecuteCount);
		if (Queue.WEFM_CurFrameExecuteAtIndex + num2 > Queue.WEFMWindBufferMaxIndex)
		{
			for (int i = Queue.WEFM_CurFrameExecuteAtIndex; i < Queue.WEFM_CurFrameExecuteAtIndex + num2; i++)
			{
				int num3 = i % Queue.WEFMWindBufferMaxCount;
				DBCWEFMWindReserveExecuteInfo dBCWEFMWindReserveExecuteInfo = Queue.Wind_ReserveExecuteBuffer[num3];
				Queue.GS_WSArr_CenterPosWS[num] = dBCWEFMWindReserveExecuteInfo.CenterPosWS;
				Queue.GS_WSArr_DirWS[num] = dBCWEFMWindReserveExecuteInfo.DirWS;
				Queue.GS_WSArr_SizeV3[num] = dBCWEFMWindReserveExecuteInfo.SizeV3;
				Queue.GS_WSArr_WindType[num] = dBCWEFMWindReserveExecuteInfo.WindType;
				Queue.GS_WSArr_WindDistanceDamplingRate[num] = dBCWEFMWindReserveExecuteInfo.DistanceDamplingRate;
				Queue.GS_WSArr_WindDataV4[num] = dBCWEFMWindReserveExecuteInfo.WindDataV4;
				Queue.GS_WSArr_WindIntensity[num] = dBCWEFMWindReserveExecuteInfo.Intensity;
				dBCWEFMWindReserveExecuteInfo.CleanData();
				num++;
			}
			Queue.WEFM_CurFrameExecuteAtIndex = (Queue.WEFM_CurFrameExecuteAtIndex + num2) % Queue.WEFMWindBufferMaxCount;
		}
		else
		{
			for (int j = Queue.WEFM_CurFrameExecuteAtIndex; j < Queue.WEFM_CurFrameExecuteAtIndex + num2; j++)
			{
				DBCWEFMWindReserveExecuteInfo dBCWEFMWindReserveExecuteInfo2 = Queue.Wind_ReserveExecuteBuffer[j];
				Queue.GS_WSArr_CenterPosWS[num] = dBCWEFMWindReserveExecuteInfo2.CenterPosWS;
				Queue.GS_WSArr_DirWS[num] = dBCWEFMWindReserveExecuteInfo2.DirWS;
				Queue.GS_WSArr_SizeV3[num] = dBCWEFMWindReserveExecuteInfo2.SizeV3;
				Queue.GS_WSArr_WindType[num] = dBCWEFMWindReserveExecuteInfo2.WindType;
				Queue.GS_WSArr_WindDistanceDamplingRate[num] = dBCWEFMWindReserveExecuteInfo2.DistanceDamplingRate;
				Queue.GS_WSArr_WindDataV4[num] = dBCWEFMWindReserveExecuteInfo2.WindDataV4;
				Queue.GS_WSArr_WindIntensity[num] = dBCWEFMWindReserveExecuteInfo2.Intensity;
				dBCWEFMWindReserveExecuteInfo2.CleanData();
				num++;
			}
			Queue.WEFM_CurFrameExecuteAtIndex += num2;
		}
		for (int k = num; k < Queue.WEFM_EveryFrameExecuteCount; k++)
		{
			Queue.GS_WSArr_WindType[k] = 0;
		}
		Queue.WEFM_ValidEventsCount = (int)MathLib.Clamp(Queue.WEFM_ValidEventsCount - num2, 0f, Queue.WEFMWindBufferMaxCount);
		wEFMManager.SetIntParameter(B1GlobalFNames.WEFM_CurFrameWindEventCount, num);
		GSE_NiagaraFunc.SetNiagaraArrayVector(wEFMManager.Address, B1GlobalFNames.WEFM_WindCenterPosWS, Queue.GS_WSArr_CenterPosWS, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayVector(wEFMManager.Address, B1GlobalFNames.WEFM_WindDirWS, Queue.GS_WSArr_DirWS, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayVector(wEFMManager.Address, B1GlobalFNames.WEFM_WindSizeV3, Queue.GS_WSArr_SizeV3, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayInt32(wEFMManager.Address, B1GlobalFNames.WEFM_WindType, Queue.GS_WSArr_WindType, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayFloat(wEFMManager.Address, B1GlobalFNames.WEFM_WindIntensity, Queue.GS_WSArr_WindIntensity, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayFloat(wEFMManager.Address, B1GlobalFNames.WEFM_WindDistanceDampingRate, Queue.GS_WSArr_WindDistanceDamplingRate, Queue.WEFM_EveryFrameExecuteCount);
		GSE_NiagaraFunc.SetNiagaraArrayVector4(wEFMManager.Address, B1GlobalFNames.WEFM_WindDataV4, Queue.GS_WSArr_WindDataV4, Queue.WEFM_EveryFrameExecuteCount);
	}

	private void OnRealEndPlayCascade(int QueueIndex, List<DBCPlayCascadeInfo> InfoList)
	{
		DBCPlayCascadeInfo dBCPlayCascadeInfo = InfoList[QueueIndex];
		UParticleSystemComponent cascadeComponent = dBCPlayCascadeInfo.CascadeComponent;
		if (cascadeComponent.IsNullOrDestroyed())
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (dBCPlayCascadeInfo.PreDestroyCallback != null)
		{
			dBCPlayCascadeInfo.PreDestroyCallback(DispLibRefParam.Instance.Set(dBCPlayCascadeInfo.IdentityID, cascadeComponent));
			if (cascadeComponent.IsNullOrDestroyed())
			{
				InfoList.RemoveAt(QueueIndex);
				return;
			}
		}
		if (dBCPlayCascadeInfo.UEPoolMode == EPSCPoolMethod.None)
		{
			cascadeComponent.DestroyComponent(GetOwner());
		}
		else
		{
			cascadeComponent.SetActive(bNewActive: false, bReset: true);
			cascadeComponent.ReleaseToPool();
		}
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndWEFMWindEvent(int QueueIndex, List<DBCWEFMWindEventInfo> InfoList)
	{
		InfoList.RemoveAt(QueueIndex);
	}

	private void DestroyOrReleaseNiagaraInstance(DBCPlayNiagaraInfo Info, bool ForceDestroyComponent)
	{
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (Info.PreDestroyCallback != null)
		{
			Info.PreDestroyCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent));
			if (uNiagaraComponent.IsNullOrDestroyed())
			{
				Info.NiagaraComponent.Delete();
				Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ExternalDestroy;
				return;
			}
		}
		if (ForceDestroyComponent)
		{
			if (Info.UEPoolMode == ENCPoolMethod.ManualRelease)
			{
				uNiagaraComponent.ReleaseToPool();
			}
			UGSE_NiagaraFuncLib.ForceDestroyNiagaraComponent(uNiagaraComponent);
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ForceDestroy;
		}
		else if (Info.UEPoolMode == ENCPoolMethod.None)
		{
			UGSE_NiagaraFuncLib.ForceDestroyNiagaraComponent(uNiagaraComponent);
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ForceDestroy;
		}
		else
		{
			uNiagaraComponent.ReleaseToPool();
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ReleaseToPool;
		}
		Info.NiagaraComponent.Delete();
	}

	private void DestroyOrReleaseAdvanceNiagaraInstance(DBCPlayAdvanceNiagaraInfo Info, bool ForceDestroyComponent)
	{
		UNiagaraComponent uNiagaraComponent = Info.NiagaraComponent.Get();
		if (Info.PreDestroyCallback != null)
		{
			Info.PreDestroyCallback(DispLibRefParam.Instance.Set(Info.IdentityID, uNiagaraComponent));
			if (!Info.IS_MERGED_REQUEST && uNiagaraComponent.IsNullOrDestroyed())
			{
				Info.NiagaraComponent.Delete();
				Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ExternalDestroy;
				return;
			}
		}
		if (Info.IS_MERGED_REQUEST)
		{
			if (ForceDestroyComponent)
			{
				Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ForceDestroy;
			}
			else
			{
				Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ReleaseToPool;
			}
			if (Info.NiagaraComponent != null)
			{
				Info.NiagaraComponent.Delete();
			}
			return;
		}
		if (ForceDestroyComponent)
		{
			if (Info.UEPoolMode == ENCPoolMethod.ManualRelease)
			{
				uNiagaraComponent.ReleaseToPool();
			}
			UGSE_NiagaraFuncLib.ForceDestroyNiagaraComponent(uNiagaraComponent);
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ForceDestroy;
		}
		else if (Info.UEPoolMode == ENCPoolMethod.None)
		{
			UGSE_NiagaraFuncLib.ForceDestroyNiagaraComponent(uNiagaraComponent);
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ForceDestroy;
		}
		else
		{
			uNiagaraComponent.ReleaseToPool();
			Info.NGInstanceLifeState = DispLibDBCNiagaraInstanceState.ReleaseToPool;
		}
		Info.NiagaraComponent.Delete();
	}

	private void OnRealEndAbstractEvent(int QueueIndex, List<DBCAbstractEventInfo> InfoList, bool ForceDestroyComponent)
	{
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndPlayNiagara(int QueueIndex, List<DBCPlayNiagaraInfo> InfoList, bool ForceDestroyComponent)
	{
		DBCPlayNiagaraInfo dBCPlayNiagaraInfo = InfoList[QueueIndex];
		UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			DispLibDBCNiagaraInstanceState nGInstanceLifeState = dBCPlayNiagaraInfo.NGInstanceLifeState;
			if (nGInstanceLifeState == DispLibDBCNiagaraInstanceState.HasSpawn && nGInstanceLifeState != DispLibDBCNiagaraInstanceState.BeReuseByScalability && !dBCPlayNiagaraInfo.SourceRequest.Template.IsNullOrDestroyed())
			{
				dBCPlayNiagaraInfo.SourceRequest.Template.GetPathName();
			}
			dBCPlayNiagaraInfo.NiagaraComponent.Delete();
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (dBCPlayNiagaraInfo.IsPause)
		{
			if (!dBCPlayNiagaraInfo.SourceRequest.Template.IsNullOrDestroyed())
			{
				dBCPlayNiagaraInfo.SourceRequest.Template.GetPathName();
			}
			uNiagaraComponent.SetPaused(bInPaused: false);
		}
		DestroyOrReleaseNiagaraInstance(dBCPlayNiagaraInfo, ForceDestroyComponent);
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndPlayAdvanceNiagara(int QueueIndex, List<DBCPlayAdvanceNiagaraInfo> InfoList, bool ForceDestroyComponent)
	{
		DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = InfoList[QueueIndex];
		UNiagaraComponent uNiagaraComponent = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
		if (!dBCPlayAdvanceNiagaraInfo.IS_MERGED_REQUEST && uNiagaraComponent.IsNullOrDestroyed())
		{
			DispLibDBCNiagaraInstanceState nGInstanceLifeState = dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState;
			if (nGInstanceLifeState == DispLibDBCNiagaraInstanceState.HasSpawn && nGInstanceLifeState != DispLibDBCNiagaraInstanceState.BeReuseByScalability && !dBCPlayAdvanceNiagaraInfo.SourceRequest.Template.IsNullOrDestroyed())
			{
				dBCPlayAdvanceNiagaraInfo.SourceRequest.Template.GetPathName();
			}
			dBCPlayAdvanceNiagaraInfo.NiagaraComponent.SetNull();
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (dBCPlayAdvanceNiagaraInfo.IsPause)
		{
			if (!dBCPlayAdvanceNiagaraInfo.SourceRequest.Template.IsNullOrDestroyed())
			{
				dBCPlayAdvanceNiagaraInfo.SourceRequest.Template.GetPathName();
			}
			if (!dBCPlayAdvanceNiagaraInfo.IS_MERGED_REQUEST)
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
			}
		}
		DestroyOrReleaseAdvanceNiagaraInstance(dBCPlayAdvanceNiagaraInfo, ForceDestroyComponent);
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndChangeMaterial(int QueueIndex, List<DBCChangeMaterialInfo> InfoList)
	{
		DBCChangeMaterialInfo dBCChangeMaterialInfo = InfoList[QueueIndex];
		if (!dBCChangeMaterialInfo.SourceDispOwnerComp.IsNullOrDestroyed() && !dBCChangeMaterialInfo.SourceRequest.Template.IsNullOrDestroyed())
		{
			BUS_DispLibEventCollection.Get(dBCChangeMaterialInfo.SourceDispOwnerComp.GetOwner())?.Evt_ResetUnitMaterials(dBCChangeMaterialInfo.SourceRequest.FilterMode, dBCChangeMaterialInfo.ChangeMatEventID);
		}
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndModifyNiagaraParams(int QueueIndex, List<DBCModifyNiagaraParamsInfo> InfoList)
	{
		DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = InfoList[QueueIndex];
		if (!dBCModifyNiagaraParamsInfo.CheckValid())
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		BUS_DispLibEventCollection.Get(dBCModifyNiagaraParamsInfo.SourceDispOwnerComp.GetOwner());
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndModifyMPC(int QueueIndex, List<DBCModifyMaterialParameterCollectionInfo> InfoList)
	{
		DBCModifyMaterialParameterCollectionInfo dBCModifyMaterialParameterCollectionInfo = InfoList[QueueIndex];
		UMaterialParameterCollection mPCInstance = GlobalData.LoadAndGetMPCInstance(Owner, dBCModifyMaterialParameterCollectionInfo.MPCAssetPath);
		foreach (DBCAdvProcessScalarParam scalarParam in dBCModifyMaterialParameterCollectionInfo.ScalarParams)
		{
			Queue.MPCScalarParamOperationCounterRemove(out var _, mPCInstance, dBCModifyMaterialParameterCollectionInfo.MPCAssetPath, scalarParam.ParamName);
		}
		foreach (DBCAdvProcessFLinearColorParam fLinearColorParam in dBCModifyMaterialParameterCollectionInfo.FLinearColorParams)
		{
			Queue.MPCColorParamOperationCounterRemove(out var _, mPCInstance, dBCModifyMaterialParameterCollectionInfo.MPCAssetPath, fLinearColorParam.ParamName);
		}
		foreach (DBCPCurveScalarParam pCurveScalarParam in dBCModifyMaterialParameterCollectionInfo.PCurveScalarParams)
		{
			Queue.MPCScalarParamOperationCounterRemove(out var _, mPCInstance, dBCModifyMaterialParameterCollectionInfo.MPCAssetPath, pCurveScalarParam.ParamName);
		}
		foreach (DBCPCurveLinearColorParam pCurveFLinearColorParam in dBCModifyMaterialParameterCollectionInfo.PCurveFLinearColorParams)
		{
			Queue.MPCColorParamOperationCounterRemove(out var _, mPCInstance, dBCModifyMaterialParameterCollectionInfo.MPCAssetPath, pCurveFLinearColorParam.ParamName);
		}
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndModifyMaterial(int QueueIndex, List<DBCModifyMaterialInfo> InfoList, DBCModMatCSharpObjectPool CSharpObjectPool)
	{
		DBCModifyMaterialInfo dBCModifyMaterialInfo = InfoList[QueueIndex];
		if (!dBCModifyMaterialInfo.CheckValid())
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		BUS_DispLibEventCollection eventCollection = dBCModifyMaterialInfo.EventCollection;
		if (eventCollection == null)
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (!dBCModifyMaterialInfo.SourceRequest.Template.IsNullOrDestroyed())
		{
			eventCollection?.Evt_ResetUnitMaterials(dBCModifyMaterialInfo.SourceRequest.FilterMode, dBCModifyMaterialInfo.MatManagerReturnID);
		}
		foreach (DBCAdvProcessScalarMatLayerParam scalarParam in dBCModifyMaterialInfo.ScalarParams)
		{
			scalarParam.OnParentEventRealEnd();
			eventCollection.Evt_ScalarParamOperationCounterRemove(dBCModifyMaterialInfo.FilterMode, scalarParam.Association, scalarParam.LayerFunction, scalarParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName));
			eventCollection.Evt_ScalarParamResetPriority(dBCModifyMaterialInfo.FilterMode, scalarParam.Association, scalarParam.LayerFunction, scalarParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			CSharpObjectPool.ReleaseToPoolDBCAdvProcessScalarMatLayerParam(scalarParam);
		}
		foreach (DBCAdvProcessFLinearColorMatLayerParam fLinearColorParam in dBCModifyMaterialInfo.FLinearColorParams)
		{
			fLinearColorParam.OnParentEventRealEnd();
			eventCollection.Evt_ColorParamOperationCounterRemove(dBCModifyMaterialInfo.FilterMode, fLinearColorParam.Association, fLinearColorParam.LayerFunction, fLinearColorParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName));
			eventCollection.Evt_ColorParamResetPriority(dBCModifyMaterialInfo.FilterMode, fLinearColorParam.Association, fLinearColorParam.LayerFunction, fLinearColorParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			CSharpObjectPool.ReleaseToPoolDBCAdvProcessFLinearColorMatLayerParam(fLinearColorParam);
		}
		foreach (DBCPCurveScalarMatLayerParam pCurveScalarParam in dBCModifyMaterialInfo.PCurveScalarParams)
		{
			pCurveScalarParam.OnParentEventRealEnd();
			eventCollection.Evt_ScalarParamOperationCounterRemove(dBCModifyMaterialInfo.FilterMode, pCurveScalarParam.Association, pCurveScalarParam.LayerFunction, pCurveScalarParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName));
			eventCollection.Evt_ScalarParamResetPriority(dBCModifyMaterialInfo.FilterMode, pCurveScalarParam.Association, pCurveScalarParam.LayerFunction, pCurveScalarParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
		}
		foreach (DBCPCurveLinearColorMatLayerParam pCurveFLinearColorParam in dBCModifyMaterialInfo.PCurveFLinearColorParams)
		{
			pCurveFLinearColorParam.OnParentEventRealEnd();
			eventCollection.Evt_ColorParamOperationCounterRemove(dBCModifyMaterialInfo.FilterMode, pCurveFLinearColorParam.Association, pCurveFLinearColorParam.LayerFunction, pCurveFLinearColorParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName));
			eventCollection.Evt_ColorParamResetPriority(dBCModifyMaterialInfo.FilterMode, pCurveFLinearColorParam.Association, pCurveFLinearColorParam.LayerFunction, pCurveFLinearColorParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
		}
		foreach (DBCTextureMatLayerParam textureParam in dBCModifyMaterialInfo.TextureParams)
		{
			eventCollection.Evt_TextureParamOperationCounterRemove(dBCModifyMaterialInfo.FilterMode, textureParam.Association, textureParam.LayerFunction, textureParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName));
			eventCollection.Evt_TextureParamResetPriority(dBCModifyMaterialInfo.FilterMode, textureParam.Association, textureParam.LayerFunction, textureParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
		}
		InfoList.RemoveAt(QueueIndex);
	}

	private bool OnRealEndPlayArtFresnel(int QueueIndex, List<DBCPlayArtFresnelInfo> InfoList)
	{
		DBCPlayArtFresnelInfo dBCPlayArtFresnelInfo = InfoList[QueueIndex];
		if (!dBCPlayArtFresnelInfo.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			BUS_DispLibEventCollection.Get(dBCPlayArtFresnelInfo.SourceDispOwnerComp.GetOwner())?.Evt_RequestEndOneUAF(dBCPlayArtFresnelInfo.SourceRequest.FilterMode, dBCPlayArtFresnelInfo.UAFID);
		}
		InfoList.RemoveAt(QueueIndex);
		return true;
	}

	private void OnRealEndSimpleActor(int QueueIndex, List<DBCSpawnSimpleActorInfo> InfoList)
	{
		DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = InfoList[QueueIndex];
		AActor spawnedSimpleActor = dBCSpawnSimpleActorInfo.SpawnedSimpleActor;
		if (spawnedSimpleActor.IsNullOrDestroyed())
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (dBCSpawnSimpleActorInfo.PreDestroyCallback != null)
		{
			dBCSpawnSimpleActorInfo.PreDestroyCallback(DispLibRefParam.Instance.Set(dBCSpawnSimpleActorInfo.IdentityID, spawnedSimpleActor));
			if (spawnedSimpleActor.IsNullOrDestroyed())
			{
				InfoList.RemoveAt(QueueIndex);
				return;
			}
		}
		BGU_UnrealWorldUtil.DestroyActor(spawnedSimpleActor);
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndPlayAudio(int QueueIndex, List<DBCPlayAudioInfo> InfoList)
	{
		DBCPlayAudioInfo dBCPlayAudioInfo = InfoList[QueueIndex];
		if (dBCPlayAudioInfo.WWiseID == -1)
		{
			InfoList.RemoveAt(QueueIndex);
			return;
		}
		if (dBCPlayAudioInfo.EndMode == DispLibDBCEndMode.ProcedureNotity)
		{
			UBGUFunctionLibAK.BGUAKStopPlayingID(dBCPlayAudioInfo.WWiseID, (int)(dBCPlayAudioInfo.SourceRequest.FadeOutTime * 1000f), 4);
		}
		if (dBCPlayAudioInfo.RTPC != null)
		{
			bool ComponentCreated;
			UAkComponent akComponent = UAkGameplayStatics.GetAkComponent(dBCPlayAudioInfo.SourceDispOwnerComp, out ComponentCreated, dBCPlayAudioInfo.SourceRequest.SocketName, FVector.ZeroVector, EAttachLocation.SnapToTarget);
			if (!akComponent.IsNullOrDestroyed())
			{
				for (int i = 0; i < dBCPlayAudioInfo.RTPC.Count; i++)
				{
					DBCAdvProcessScalarParam dBCAdvProcessScalarParam = dBCPlayAudioInfo.RTPC[i];
					dBCAdvProcessScalarParam.SetEnd();
					dBCAdvProcessScalarParam.UpdateValue(0f, 0f);
					akComponent.SetRTPCValue(null, dBCAdvProcessScalarParam.CurFrameValue, 0, dBCAdvProcessScalarParam.ParamName.PlainName);
				}
			}
		}
		InfoList.RemoveAt(QueueIndex);
	}

	private void OnRealEndCustomEvent(int QueueIndex, List<DBCCustomEventInfo> InfoList)
	{
		DBCCustomEventInfo dBCCustomEventInfo = InfoList[QueueIndex];
		BUS_DispLibEventCollection.Get(dBCCustomEventInfo.SourceDispOwnerComp.GetOwner())?.Evt_DBCRealEndOneCustomEvent(dBCCustomEventInfo.IdentityID, dBCCustomEventInfo.CustomEventID);
		InfoList.RemoveAt(QueueIndex);
	}

	private void SetPauseAbstractEvent(int QueueIndex, List<DBCAbstractEventInfo> InfoList, int PausePriority, string PauseReason)
	{
		InfoList[QueueIndex].ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
	}

	private void SetResumeAbstractEvent(int QueueIndex, List<DBCAbstractEventInfo> InfoList, int PausePriority, string PauseReason)
	{
		InfoList[QueueIndex].ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
	}

	private void SetPauseCommonNiagara(int QueueIndex, List<DBCPlayNiagaraInfo> InfoList, int PausePriority, string PauseReason)
	{
		DBCPlayNiagaraInfo dBCPlayNiagaraInfo = InfoList[QueueIndex];
		if (dBCPlayNiagaraInfo.PauseMode == DispLibDBCPauseMode.None || PausePriority < dBCPlayNiagaraInfo.PausePriority)
		{
			return;
		}
		if (dBCPlayNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
		{
			if (dBCPlayNiagaraInfo.PauseMode == DispLibDBCPauseMode.Pause || dBCPlayNiagaraInfo.PauseMode == DispLibDBCPauseMode.PauseAndHide)
			{
				dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			}
			else
			{
				InfoList.RemoveAt(QueueIndex);
			}
			return;
		}
		UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			_ = dBCPlayNiagaraInfo.NGInstanceLifeState;
			_ = 2;
			return;
		}
		switch (dBCPlayNiagaraInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			uNiagaraComponent.SetPaused(bInPaused: true);
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			uNiagaraComponent.SetPaused(bInPaused: true);
			uNiagaraComponent.SetVisibility(bNewVisibility: false);
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoNiagaraDelayStop(dBCPlayNiagaraInfo, GetCurTime(), -1, ForceDeleteComponentOnDestroy: false))
			{
				OnRealEndPlayNiagara(QueueIndex, InfoList, ForceDestroyComponent: false);
			}
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoNiagaraDelayStop(dBCPlayNiagaraInfo, GetCurTime(), int.MaxValue, ForceDeleteComponentOnDestroy: false))
			{
				OnRealEndPlayNiagara(QueueIndex, InfoList, ForceDestroyComponent: false);
			}
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoNiagaraDelayStop(dBCPlayNiagaraInfo, GetCurTime(), int.MaxValue, ForceDeleteComponentOnDestroy: true))
			{
				OnRealEndPlayNiagara(QueueIndex, InfoList, ForceDestroyComponent: true);
			}
			break;
		case DispLibDBCPauseMode.None:
			break;
		}
	}

	private void SetResumeCommonNiagara(int QueueIndex, List<DBCPlayNiagaraInfo> InfoList, int PausePriority, string PauseReason)
	{
		DBCPlayNiagaraInfo dBCPlayNiagaraInfo = InfoList[QueueIndex];
		if (dBCPlayNiagaraInfo.PauseMode == DispLibDBCPauseMode.None || !dBCPlayNiagaraInfo.IsPause)
		{
			return;
		}
		if (dBCPlayNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
		{
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			return;
		}
		UNiagaraComponent uNiagaraComponent = dBCPlayNiagaraInfo.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			_ = dBCPlayNiagaraInfo.NGInstanceLifeState;
			_ = 2;
			return;
		}
		switch (dBCPlayNiagaraInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			if (!dBCPlayNiagaraInfo.IsPause)
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
			}
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			if (!dBCPlayNiagaraInfo.IsPause)
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
				uNiagaraComponent.SetVisibility(bNewVisibility: true);
			}
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCPlayNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.None:
			break;
		}
	}

	private void SetPauseAdvNiagara(int QueueIndex, List<DBCPlayAdvanceNiagaraInfo> InfoList, int PausePriority, string PauseReason)
	{
		DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = InfoList[QueueIndex];
		if (dBCPlayAdvanceNiagaraInfo.PauseMode == DispLibDBCPauseMode.None || PausePriority < dBCPlayAdvanceNiagaraInfo.PausePriority)
		{
			return;
		}
		if (dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
		{
			if (dBCPlayAdvanceNiagaraInfo.PauseMode == DispLibDBCPauseMode.Pause || dBCPlayAdvanceNiagaraInfo.PauseMode == DispLibDBCPauseMode.PauseAndHide)
			{
				dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			}
			else
			{
				InfoList.RemoveAt(QueueIndex);
			}
			return;
		}
		UNiagaraComponent uNiagaraComponent = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			_ = dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState;
			_ = 2;
			return;
		}
		switch (dBCPlayAdvanceNiagaraInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			uNiagaraComponent.SetPaused(bInPaused: true);
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			uNiagaraComponent.SetPaused(bInPaused: true);
			uNiagaraComponent.SetVisibility(bNewVisibility: false);
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoAdvNiagaraDelayStop(dBCPlayAdvanceNiagaraInfo, GetCurTime(), -1, ForceDeleteComponentOnDestroy: false))
			{
				OnRealEndPlayAdvanceNiagara(QueueIndex, InfoList, ForceDestroyComponent: false);
			}
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoAdvNiagaraDelayStop(dBCPlayAdvanceNiagaraInfo, GetCurTime(), int.MaxValue, ForceDeleteComponentOnDestroy: false))
			{
				OnRealEndPlayAdvanceNiagara(QueueIndex, InfoList, ForceDestroyComponent: false);
			}
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			uNiagaraComponent.SetPaused(bInPaused: false);
			if (!CheckAndDoAdvNiagaraDelayStop(dBCPlayAdvanceNiagaraInfo, GetCurTime(), int.MaxValue, ForceDeleteComponentOnDestroy: true))
			{
				OnRealEndPlayAdvanceNiagara(QueueIndex, InfoList, ForceDestroyComponent: true);
			}
			break;
		case DispLibDBCPauseMode.None:
			break;
		}
	}

	private void SetResumeAdvNiagara(int QueueIndex, List<DBCPlayAdvanceNiagaraInfo> InfoList, int PausePriority, string PauseReason)
	{
		DBCPlayAdvanceNiagaraInfo dBCPlayAdvanceNiagaraInfo = InfoList[QueueIndex];
		if (dBCPlayAdvanceNiagaraInfo.PauseMode == DispLibDBCPauseMode.None || !dBCPlayAdvanceNiagaraInfo.IsPause)
		{
			return;
		}
		if (dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState == DispLibDBCNiagaraInstanceState.WaitForSpawn)
		{
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			return;
		}
		UNiagaraComponent uNiagaraComponent = dBCPlayAdvanceNiagaraInfo.NiagaraComponent.Get();
		if (uNiagaraComponent.IsNullOrDestroyed())
		{
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			_ = dBCPlayAdvanceNiagaraInfo.NGInstanceLifeState;
			_ = 2;
			return;
		}
		switch (dBCPlayAdvanceNiagaraInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			if (!dBCPlayAdvanceNiagaraInfo.IsPause)
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
			}
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			if (!dBCPlayAdvanceNiagaraInfo.IsPause)
			{
				uNiagaraComponent.SetPaused(bInPaused: false);
				uNiagaraComponent.SetVisibility(bNewVisibility: true);
			}
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCPlayAdvanceNiagaraInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.None:
			break;
		}
	}

	private void SetArtFresnelPauseState(int QueueIndex, List<DBCPlayArtFresnelInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCPlayArtFresnelInfo dBCPlayArtFresnelInfo = InfoList[QueueIndex];
		if (dBCPlayArtFresnelInfo.PauseMode != DispLibDBCPauseMode.None && (!Pause || PausePriority >= dBCPlayArtFresnelInfo.PausePriority) && dBCPlayArtFresnelInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false) && !dBCPlayArtFresnelInfo.SourceDispOwnerComp.IsNullOrDestroyed())
		{
			BUS_DispLibEventCollection.Get(dBCPlayArtFresnelInfo.SourceDispOwnerComp.GetOwner())?.Evt_RequestSetPauseOneUAF?.Invoke(dBCPlayArtFresnelInfo.UAFID, Pause);
		}
	}

	private void SetCameraShakePauseState(int QueueIndex, List<DBCPlayCameraShakeInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCPlayCameraShakeInfo dBCPlayCameraShakeInfo = InfoList[QueueIndex];
		if (dBCPlayCameraShakeInfo.PauseMode == DispLibDBCPauseMode.None || (Pause && PausePriority < dBCPlayCameraShakeInfo.PausePriority))
		{
			return;
		}
		dBCPlayCameraShakeInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
		if (dBCPlayCameraShakeInfo.HasSpawn)
		{
			if (dBCPlayCameraShakeInfo.CameraShakeInst.IsNullOrDestroyed())
			{
				InfoList.RemoveAt(QueueIndex);
			}
			else if (Pause)
			{
				dBCPlayCameraShakeInfo.OscillatorTimeRemainingOnPause = dBCPlayCameraShakeInfo.CameraShakeInst.OscillatorTimeRemaining;
			}
		}
	}

	private void SetCustomCameraShakePauseState(int QueueIndex, List<DBCPlayCustomCameraShakeInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCPlayCustomCameraShakeInfo dBCPlayCustomCameraShakeInfo = InfoList[QueueIndex];
		if (dBCPlayCustomCameraShakeInfo.PauseMode == DispLibDBCPauseMode.None || (Pause && PausePriority < dBCPlayCustomCameraShakeInfo.PausePriority))
		{
			return;
		}
		dBCPlayCustomCameraShakeInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
		if (dBCPlayCustomCameraShakeInfo.HasSpawn)
		{
			if (dBCPlayCustomCameraShakeInfo.CameraShakeInst.IsNullOrDestroyed())
			{
				InfoList.RemoveAt(QueueIndex);
			}
			else if (Pause)
			{
				dBCPlayCustomCameraShakeInfo.OscillatorTimeRemainingOnPause = dBCPlayCustomCameraShakeInfo.CameraShakeInst.OscillatorTimeRemaining;
			}
		}
	}

	private void SetAudioPauseState(int QueueIndex, List<DBCPlayAudioInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCPlayAudioInfo dBCPlayAudioInfo = InfoList[QueueIndex];
		if (dBCPlayAudioInfo.PauseMode == DispLibDBCPauseMode.None || (Pause && PausePriority < dBCPlayAudioInfo.PausePriority))
		{
			return;
		}
		dBCPlayAudioInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
		if (dBCPlayAudioInfo.HasSpawn)
		{
			if (dBCPlayAudioInfo.WWiseID == -1)
			{
				InfoList.RemoveAt(QueueIndex);
			}
			else if (Pause)
			{
				UBGUFunctionLibAK.ExecuteActionOnPlayingID(1, dBCPlayAudioInfo.WWiseID);
			}
			else
			{
				UBGUFunctionLibAK.ExecuteActionOnPlayingID(2, dBCPlayAudioInfo.WWiseID);
			}
		}
	}

	private void SetSpawnSimpleActorPauseState(int QueueIndex, List<DBCSpawnSimpleActorInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCSpawnSimpleActorInfo dBCSpawnSimpleActorInfo = InfoList[QueueIndex];
		if (dBCSpawnSimpleActorInfo.PauseMode == DispLibDBCPauseMode.None || (Pause && PausePriority < dBCSpawnSimpleActorInfo.PausePriority))
		{
			return;
		}
		dBCSpawnSimpleActorInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
		if (!dBCSpawnSimpleActorInfo.HasSpawn)
		{
			return;
		}
		if (dBCSpawnSimpleActorInfo.SpawnedSimpleActor.IsNullOrDestroyed())
		{
			OnRealEndSimpleActor(QueueIndex, InfoList);
			return;
		}
		DispLib_DBCSimpleActorBaseData componentByClass = dBCSpawnSimpleActorInfo.SpawnedSimpleActor.GetComponentByClass<DispLib_DBCSimpleActorBaseData>();
		if (!componentByClass.IsNullOrDestroyed())
		{
			componentByClass.isPause = Pause;
			componentByClass.Evt_SetPause?.Invoke(PausePriority, Pause);
		}
	}

	private void SetWEFMWindEventPauseState(int QueueIndex, List<DBCWEFMWindEventInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCWEFMWindEventInfo dBCWEFMWindEventInfo = InfoList[QueueIndex];
		if (dBCWEFMWindEventInfo.PauseMode != DispLibDBCPauseMode.None && (!Pause || PausePriority >= dBCWEFMWindEventInfo.PausePriority))
		{
			dBCWEFMWindEventInfo.ResolveChangePauseState(Pause, PauseReason, ForceResumeByPauseMode: false);
		}
	}

	private void SetSPIPauseState(int QueueIndex, List<DBCScenePhysicalInteractorInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCScenePhysicalInteractorInfo dBCScenePhysicalInteractorInfo = InfoList[QueueIndex];
		if (dBCScenePhysicalInteractorInfo.PauseMode != DispLibDBCPauseMode.None && (!Pause || PausePriority >= dBCScenePhysicalInteractorInfo.PausePriority))
		{
			dBCScenePhysicalInteractorInfo.ResolveChangePauseState(Pause, PauseReason, ForceResumeByPauseMode: false);
		}
	}

	private void SetPauseModifyMaterial(int QueueIndex, List<DBCModifyMaterialInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCModifyMaterialInfo dBCModifyMaterialInfo = InfoList[QueueIndex];
		if (dBCModifyMaterialInfo.PauseMode == DispLibDBCPauseMode.None || PausePriority < dBCModifyMaterialInfo.PausePriority)
		{
			return;
		}
		if (!dBCModifyMaterialInfo.HasSpawn)
		{
			if (dBCModifyMaterialInfo.PauseMode == DispLibDBCPauseMode.Pause || dBCModifyMaterialInfo.PauseMode == DispLibDBCPauseMode.PauseAndHide)
			{
				dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			}
			else
			{
				InfoList.RemoveAt(QueueIndex);
			}
			return;
		}
		switch (dBCModifyMaterialInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			if (!CheckAndDoModifyMaterialDelayStop(dBCModifyMaterialInfo, GetCurTime()))
			{
				OnRealEndModifyMaterial(QueueIndex, InfoList, Queue.ModMatCSharpObjectPool);
			}
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			if (!CheckAndDoModifyMaterialDelayStop(dBCModifyMaterialInfo, GetCurTime(), int.MaxValue))
			{
				OnRealEndModifyMaterial(QueueIndex, InfoList, Queue.ModMatCSharpObjectPool);
			}
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			if (!CheckAndDoModifyMaterialDelayStop(dBCModifyMaterialInfo, GetCurTime(), int.MaxValue))
			{
				OnRealEndModifyMaterial(QueueIndex, InfoList, Queue.ModMatCSharpObjectPool);
			}
			break;
		}
		if (dBCModifyMaterialInfo.PauseMode != DispLibDBCPauseMode.Pause && dBCModifyMaterialInfo.PauseMode != DispLibDBCPauseMode.PauseAndHide)
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(dBCModifyMaterialInfo.SourceDispOwnerComp.GetOwner());
		if (bUS_DispLibEventCollection != null)
		{
			for (int i = 0; i < dBCModifyMaterialInfo.ScalarParams.Count; i++)
			{
				DBCAdvProcessScalarMatLayerParam dBCAdvProcessScalarMatLayerParam = dBCModifyMaterialInfo.ScalarParams[i];
				bUS_DispLibEventCollection.Evt_ScalarParamResetPriority(dBCModifyMaterialInfo.FilterMode, dBCAdvProcessScalarMatLayerParam.Association, dBCAdvProcessScalarMatLayerParam.LayerFunction, dBCAdvProcessScalarMatLayerParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			}
			for (int j = 0; j < dBCModifyMaterialInfo.FLinearColorParams.Count; j++)
			{
				DBCAdvProcessFLinearColorMatLayerParam dBCAdvProcessFLinearColorMatLayerParam = dBCModifyMaterialInfo.FLinearColorParams[j];
				bUS_DispLibEventCollection.Evt_ColorParamResetPriority(dBCModifyMaterialInfo.FilterMode, dBCAdvProcessFLinearColorMatLayerParam.Association, dBCAdvProcessFLinearColorMatLayerParam.LayerFunction, dBCAdvProcessFLinearColorMatLayerParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			}
			for (int k = 0; k < dBCModifyMaterialInfo.TextureParams.Count; k++)
			{
				DBCTextureMatLayerParam dBCTextureMatLayerParam = dBCModifyMaterialInfo.TextureParams[k];
				bUS_DispLibEventCollection.Evt_TextureParamResetPriority(dBCModifyMaterialInfo.FilterMode, dBCTextureMatLayerParam.Association, dBCTextureMatLayerParam.LayerFunction, dBCTextureMatLayerParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			}
			for (int l = 0; l < dBCModifyMaterialInfo.PCurveScalarParams.Count; l++)
			{
				DBCPCurveScalarMatLayerParam dBCPCurveScalarMatLayerParam = dBCModifyMaterialInfo.PCurveScalarParams[l];
				bUS_DispLibEventCollection.Evt_ScalarParamResetPriority(dBCModifyMaterialInfo.FilterMode, dBCPCurveScalarMatLayerParam.Association, dBCPCurveScalarMatLayerParam.LayerFunction, dBCPCurveScalarMatLayerParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			}
			for (int m = 0; m < dBCModifyMaterialInfo.PCurveFLinearColorParams.Count; m++)
			{
				DBCPCurveLinearColorMatLayerParam dBCPCurveLinearColorMatLayerParam = dBCModifyMaterialInfo.PCurveFLinearColorParams[m];
				bUS_DispLibEventCollection.Evt_ColorParamResetPriority(dBCModifyMaterialInfo.FilterMode, dBCPCurveLinearColorMatLayerParam.Association, dBCPCurveLinearColorMatLayerParam.LayerFunction, dBCPCurveLinearColorMatLayerParam.ParamName, dBCModifyMaterialInfo.MatManagerReturnID, default(FName), dBCModifyMaterialInfo.OnEndDispStage ? dBCModifyMaterialInfo.ModMatEndStagePriority : dBCModifyMaterialInfo.ModMatPriority);
			}
		}
	}

	private void SetResumeModifyMaterial(int QueueIndex, List<DBCModifyMaterialInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCModifyMaterialInfo dBCModifyMaterialInfo = InfoList[QueueIndex];
		if (dBCModifyMaterialInfo.PauseMode == DispLibDBCPauseMode.None || !dBCModifyMaterialInfo.IsPause)
		{
			return;
		}
		if (!dBCModifyMaterialInfo.HasSpawn)
		{
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			return;
		}
		switch (dBCModifyMaterialInfo.PauseMode)
		{
		case DispLibDBCPauseMode.Pause:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.PauseAndHide:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.GotoEndDispStage:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.RealEndAndNoEndDispStage:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.ForceDestory:
			dBCModifyMaterialInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCPauseMode.None:
			break;
		}
	}

	private void SetPauseModifyNiagaraParams(int QueueIndex, List<DBCModifyNiagaraParamsInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = InfoList[QueueIndex];
		if (dBCModifyNiagaraParamsInfo.PauseMode == DispLibDBCModNiagaraParamsPauseMode.None || PausePriority < dBCModifyNiagaraParamsInfo.PausePriority)
		{
			return;
		}
		if (!dBCModifyNiagaraParamsInfo.HasSpawn)
		{
			if (dBCModifyNiagaraParamsInfo.PauseMode == DispLibDBCModNiagaraParamsPauseMode.Pause)
			{
				dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			}
			else
			{
				InfoList.RemoveAt(QueueIndex);
			}
			return;
		}
		switch (dBCModifyNiagaraParamsInfo.PauseMode)
		{
		case DispLibDBCModNiagaraParamsPauseMode.Pause:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: true, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCModNiagaraParamsPauseMode.GotoEndDispStage:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			if (!CheckAndDoModifyNiagaraParamsDelayStop(dBCModifyNiagaraParamsInfo, GetCurTime()))
			{
				OnRealEndModifyNiagaraParams(QueueIndex, InfoList);
			}
			break;
		case DispLibDBCModNiagaraParamsPauseMode.RealEndAndNoEndDispStage:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: true);
			if (!CheckAndDoModifyNiagaraParamsDelayStop(dBCModifyNiagaraParamsInfo, GetCurTime(), int.MaxValue))
			{
				OnRealEndModifyNiagaraParams(QueueIndex, InfoList);
			}
			break;
		case DispLibDBCModNiagaraParamsPauseMode.None:
			break;
		}
	}

	private void SetResumeModifyNiagaraParams(int QueueIndex, List<DBCModifyNiagaraParamsInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCModifyNiagaraParamsInfo dBCModifyNiagaraParamsInfo = InfoList[QueueIndex];
		if (dBCModifyNiagaraParamsInfo.PauseMode == DispLibDBCModNiagaraParamsPauseMode.None || !dBCModifyNiagaraParamsInfo.IsPause)
		{
			return;
		}
		if (!dBCModifyNiagaraParamsInfo.HasSpawn)
		{
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			return;
		}
		switch (dBCModifyNiagaraParamsInfo.PauseMode)
		{
		case DispLibDBCModNiagaraParamsPauseMode.Pause:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCModNiagaraParamsPauseMode.GotoEndDispStage:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCModNiagaraParamsPauseMode.RealEndAndNoEndDispStage:
			dBCModifyNiagaraParamsInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			break;
		case DispLibDBCModNiagaraParamsPauseMode.None:
			break;
		}
	}

	private void SetCustomEventsPauseState(int QueueIndex, List<DBCCustomEventInfo> InfoList, bool Pause, int PausePriority, string PauseReason)
	{
		DBCCustomEventInfo dBCCustomEventInfo = InfoList[QueueIndex];
		if (dBCCustomEventInfo.PauseMode != DispLibDBCPauseMode.None && (!Pause || PausePriority >= dBCCustomEventInfo.PausePriority))
		{
			dBCCustomEventInfo.ResolveChangePauseState(NewPauseState: false, PauseReason, ForceResumeByPauseMode: false);
			if (dBCCustomEventInfo.HasTrigger)
			{
				BUS_DispLibEventCollection.Get(dBCCustomEventInfo.SourceDispOwnerComp.GetOwner())?.Evt_DBCPauseOneCustomEvent?.Invoke(dBCCustomEventInfo.IdentityID, dBCCustomEventInfo.CustomEventID, Pause, PausePriority, PauseReason);
			}
		}
	}
}

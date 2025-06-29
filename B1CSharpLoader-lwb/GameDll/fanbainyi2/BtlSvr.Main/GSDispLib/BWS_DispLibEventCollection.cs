using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
public class BWS_DispLibEventCollection
{
	public delegate void Del_Void_TwoVectorIntTwoFloat(FVector VectorValue1, FVector VectorValue2, int IntValue, float floatValue1, float floatValue2);

	public delegate void Del_VoidTwoInt(int IntValue1, int IntValue2);

	public delegate void Del_VoidThreeInt(int IntValue1, int IntValue2, int IntValue3);

	public delegate void Del_Void_ActorTwoIntThreeFloat(AActor Actor, FVector VectorValue, int IntValue0, int InValue1, float floatValue1, float floatValue2, float floatValue3);

	public delegate void Del_Void_Actor(AActor Actor);

	public delegate void Del_VoidIntFloat(int IntValue1, float floatValue1);

	public delegate void Del_VoidInt(int IntValue);

	public delegate void Del_PostProcessEffect(int IntValue1, int IntValue2, int IntValue3, UDispLib_PPEffectParameters Parameters);

	public delegate void Del_RequestRegisterActor(USceneComponent SourceDispOwnerComp, DispLibDBCActorGroup Group);

	public delegate void Del_RequestUnregisterActor(USceneComponent SourceDispOwnerComp, DispLibDBCActorGroup Group);

	public delegate void Del_RequestApplyOneDBCDataAssetInWorld(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, FTransform Transform, bool AddDataAssetOffset, USceneComponent EmitterDispOwnerComp = null, FVector EmitterPosWSOnSpawn = default(FVector), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCDataAssetInWorldWithReceipt(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, DispLibRefParam Receipt, FTransform Transform, bool AddDataAssetOffset, bool ReleaseCustomAdvNCFormDBC = false, USceneComponent EmitterDispOwnerComp = null, FVector EmitterPosWSOnSpawn = default(FVector), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCAbstractDataAsset(out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCDataAssetWithReceipt(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, DispLibRefParam Receipt, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestConverDBCAbstractDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent SourceDispOwnerComp, uint DBCID);

	public delegate void Del_RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID);

	public delegate uint Del_RequestSpawnOneCommonNiagara(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate uint Del_RequestSpawnOneAdvanceNiagara(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayAdvanceNiagara D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate uint Del_RequestSpawnOneSimpleActor(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApply_One_CameraShake(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApply_One_CustomCameraShake(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayCustomCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneScenePhysicalInteractorDataAsset(USceneComponent SourceDispOwnerComp, BUC_DispLibSceneInteractorData SceneInteractorData, out uint IdentityID, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestPlayAudio(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayAudio D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApply_One_ModMat(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterial D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApply_One_ModMPC(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestUpdateMatScalarParam(uint SourceDispOwnerCompID, uint IdentityID, float NewScalarValue);

	public delegate void Del_DBCTriggerOneCustomEvent(int DBCID, uint CustomEventID, DispLibDBCCustomEventDataAssetBase ParamsDA, DBCCustomEventTimeInfo TimeInfo, DBCCustomEventAdditionalInfo AdditionalInfo);

	public delegate void Del_RequestResetAllEffects(USceneComponent SourceDispOwnerComp, uint DBCID, bool OnlyResetFX = false, bool ResetNonProcedureEndFX = true);

	public delegate void Del_RequestSetDBCEffectsDetachFromParent(USceneComponent SourceDispOwnerComp, uint IdentityID, bool MaintainWorldPosition, bool CallModify = true);

	public delegate void Del_RequestSetDBCEffectsAttachToNewSocket(USceneComponent SourceDispOwnerComp, uint IdentityID, FName NewSocketName, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepWorld, bool bWeldSimulatedBodies = false);

	public delegate void Del_RequestSetDBCEffectsTransform(USceneComponent SourceDispOwnerComp, uint IdentityID, DBCTransformParam Transform, bool OnlySetFX = false, bool ForceDetachAndSet = false);

	public delegate bool Del_RequestGetFirstDBCNiagaraTransform(USceneComponent SourceDispOwnerComp, uint IdentityID, out FTransform ResTransform);

	public delegate void Del_RequestEndDBCEffects(USceneComponent SourceDispOwnerComp, uint DBCID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsByAnimNotifyUniqueID(USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsByTag(USceneComponent SourceDispOwnerComp, FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsAdvance(USceneComponent SourceDispOwnerComp, DispLibDBCEffectType EffectType, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float ForeceDestroyAfterTime = -1f, int EndReasonMark = 0);

	public delegate void Del_DBCRealEndOneCustomEvent(USceneComponent SourceDispOwnerComp, uint DBCID, uint CustomEventID);

	public delegate void Del_DBCOneCustomEventTriggerEndDispStage(USceneComponent SourceDispOwnerComp, uint DBCID, uint CustomEventID);

	public delegate void Del_RequestSetDBCEffectsActiveState(USceneComponent SourceDispOwnerComp, uint IdentityID, bool Active, bool Reset = false);

	public delegate void Del_RequestSetDBCEffectsPause(USceneComponent SourceDispOwnerComp, uint IdentityID, bool Pause, int PausePriority, string PauseReason);

	public delegate void Del_RequestSetDBCNiagaraVisibleState(USceneComponent SourceDispOwnerComp, uint IdentityID, bool isVisible, int ATKPriority);

	public delegate void Del_RequestSetDBCNiagaraFloatParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, float Value);

	public delegate void Del_RequestSetDBCNiagaraVectorParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, FVector Value);

	public delegate void Del_RequestSetDBCNiagaraBoolParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, bool Value);

	public delegate void Del_RequestSetDBCNiagaraIntParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Value);

	public delegate void Del_RequestSetDBCNiagaraFloatArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<float> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraFloatArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, float Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCNiagaraVectorArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<FVector> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraVectorArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, FVector Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCNiagaraVector4ArrayParam(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, List<FVector4> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraVector4ArrayParamValue(USceneComponent SourceDispOwnerComp, uint IdentityID, FName ParamName, int Index, FVector4 Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCAudioMuteState(USceneComponent SourceDispOwnerComp, uint IdentityID, bool isMute);

	public delegate void Del_RequestSetDBCCameraShakeIntensityScale(USceneComponent SourceDispOwnerComp, uint IdentityID, float IntensityScale);

	public delegate void Del_RequestSetDBCEffectsCustomTimeDilation(USceneComponent SourceDispOwnerComp, uint IdentityID, float CustomTimeDilation);

	public delegate void Del_DLDWorld_RequestInjectWind(ref uint RequesterUniqueID, FVector CenterPosWS, FVector DirWS, FVector WindSizeV3, float WindIntensity, int WindType, float DistanceDamplingRate, FVector4 WindDataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestInjectHeat(out uint IdentityID, FVector CenterPosWS, FVector SizeV3, float Intensity, float DistanceDamplingRate, FVector4 DataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestSetWEFMSystemState(bool Active, int LODIndex);

	public delegate void Del_DLDWorld_RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, DBCTransformParam DBCTransform = default(DBCTransformParam), USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestSpawnOneCommonNiagara(BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestSpawnOneSimpleNiagara(UNiagaraSystem Template, DispLibDBCEndMode EndMode, float Duration, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestApplyOneModMPC(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestApplyOneCameraShake(BUC_DispLibDBC_PlayCameraShake D, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestApplyOneCustomCameraShake(BUC_DispLibDBC_PlayCustomCameraShake D, USceneComponent SourceDispOwnerComp, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_DLDWorld_RequestEndDBCEffects(int DBCID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1);

	public delegate void Del_DLDWorld_RequestEndDBCEffectsByAnimNotifyUniqueID(uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1);

	public delegate void Del_DLDWorld_RequestEndDBCEffectsByTag(FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1);

	public delegate void Del_DLDWorld_RequestSpawnOneSimpleActor(BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate bool Del_GetMPCScalarParamValue(string MPCAssetPath, FName ParamName, out float ParamCurValue);

	public delegate bool Del_GetMPCScalarParamInitialValue(string MPCAssetPath, FName ParamName, out float ParamInitialValue);

	public delegate bool Del_GetMPCColorParamValue(string MPCAssetPath, FName ParamName, out FLinearColor ParamCurValue);

	public delegate bool Del_GetMPCColorParamInitialValue(string MPCAssetPath, FName ParamName, out FLinearColor ParamInitialValue);

	public delegate void Del_DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState(DispLibDBCActorGroup Filter, bool isVisible, int ATKPriority);

	public delegate void Del_VoidString(string StringValue);

	public delegate void Del_VoidTwoIntString(int IntValue0, int IntValue1, string StringValue);

	public Del_GetMPCScalarParamValue Evt_GetMPCScalarParamValue = delegate(string MPCAssetPath, FName ParamName, out float ParamCurValue)
	{
		ParamCurValue = 0f;
		return false;
	};

	public Del_GetMPCScalarParamInitialValue Evt_GetMPCScalarParamInitialValue = delegate(string MPCAssetPath, FName ParamName, out float ParamInitialValue)
	{
		ParamInitialValue = 0f;
		return false;
	};

	public Del_GetMPCColorParamValue Evt_GetMPCColorParamValue = delegate(string MPCAssetPath, FName ParamName, out FLinearColor ParamCurValue)
	{
		ParamCurValue = FLinearColor.White;
		return false;
	};

	public Del_GetMPCColorParamInitialValue Evt_GetMPCColorParamInitialValue = delegate(string MPCAssetPath, FName ParamName, out FLinearColor ParamInitialValue)
	{
		ParamInitialValue = FLinearColor.White;
		return false;
	};

	public Del_Void_ActorTwoIntThreeFloat Env_RequestScenePhysicalInteractorEvent = delegate
	{
	};

	public Del_Void_Actor Env_RespondScenePhysicalInteractorEvent = delegate
	{
	};

	public Del_PostProcessEffect Env_RequestPostProcessEvent = delegate
	{
	};

	public Del_VoidIntFloat Env_RequestNarrativeEnvEvent = delegate
	{
	};

	public Del_VoidTwoInt Env_RequestFoWEvent = delegate
	{
	};

	public Del_RequestRegisterActor Evt_RequestRegisterActor = delegate
	{
	};

	public Del_RequestUnregisterActor Evt_RequestUnregisterActor = delegate
	{
	};

	public Del_RequestApplyOneDBCDataAsset Evt_RequestApplyOneDBCDataAsset = delegate(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform, DBCSetCallbackParams CallbackParams, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestApplyOneDBCAbstractDataAsset Evt_RequestApplyOneDBCAbstractDataAsset = delegate(out uint IdentityID, USceneComponent SourceDispOwnerComp, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform, DBCSetCallbackParams CallbackParams, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestConverDBCAbstractDataAsset Evt_RequestConverDBCAbstractDataAsset = delegate
	{
	};

	public Del_RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID Evt_RequestConverDBCAbstractDataAssetByAnimNotifyUniqueID = delegate
	{
	};

	public Del_RequestSpawnOneCommonNiagara Evt_RequestSpawn_One_Common_Niagara = (USceneComponent _003Cp0_003E, BUC_DispLibDBC_PlayNiagara _003Cp1_003E, DispLibRefParam _003Cp2_003E, DBCTransformParam _003Cp3_003E, DBCSetCallbackParams _003Cp4_003E, uint _003Cp5_003E, uint _003Cp6_003E) => 0u;

	public Del_RequestSpawnOneAdvanceNiagara Evt_RequestSpawn_One_Advance_Niagara = (USceneComponent _003Cp0_003E, BUC_DispLibDBC_PlayAdvanceNiagara _003Cp1_003E, DispLibRefParam _003Cp2_003E, USceneComponent _003Cp3_003E, FVector _003Cp4_003E, DBCTransformParam _003Cp5_003E, DBCSetCallbackParams _003Cp6_003E, uint _003Cp7_003E, uint _003Cp8_003E) => 0u;

	public Del_RequestSpawnOneSimpleActor Evt_RequestSpawn_One_Simple_Actor = (USceneComponent _003Cp0_003E, BUC_DispLibDBC_SpawnSimpleActor _003Cp1_003E, DispLibRefParam _003Cp2_003E, USceneComponent _003Cp3_003E, FVector _003Cp4_003E, DBCTransformParam _003Cp5_003E, DBCSetCallbackParams _003Cp6_003E, uint _003Cp7_003E, uint _003Cp8_003E) => 0u;

	public Del_RequestApply_One_CameraShake Evt_RequestApply_One_CameraShake = delegate
	{
	};

	public Del_RequestApply_One_CustomCameraShake Evt_RequestApply_One_CustomCameraShake = delegate
	{
	};

	public Del_RequestApplyOneScenePhysicalInteractorDataAsset Evt_RequestApplyOneScenePhysicalInteractorDataAsset = delegate(USceneComponent SourceDispOwnerComp, BUC_DispLibSceneInteractorData SceneInteractorData, out uint IdentityID, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform, DBCSetCallbackParams CallbackParams, uint ANID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestPlayAudio Evt_RequestPlayAudio = delegate(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_PlayAudio D, out uint IdentityID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestApply_One_ModMat Evt_RequestApply_One_ModMat = delegate(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterial D, out uint IdentityID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestApply_One_ModMPC Evt_RequestApply_One_ModMPC = delegate(USceneComponent SourceDispOwnerComp, BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestUpdateMatScalarParam Evt_RequestUpdateMatScalarParam = delegate
	{
	};

	public Del_DBCTriggerOneCustomEvent Evt_DBCTriggerOneCustomEvent = delegate
	{
	};

	public Del_VoidInt Evt_OnGameEffectQualityChanged = delegate
	{
	};

	public Del_RequestSetDBCEffectsTransform Evt_RequestSetDBCEffectsTransform = delegate
	{
	};

	public Del_RequestGetFirstDBCNiagaraTransform Evt_RequestGetFirstDBCNiagaraTransform = delegate(USceneComponent SourceDispOwnerComp, uint IdentityID, out FTransform ResTransform)
	{
		ResTransform = FTransform.Default;
		return false;
	};

	public Del_RequestEndDBCEffects Evt_RequestEndDBCEffects = delegate
	{
	};

	public Del_RequestEndDBCEffectsByAnimNotifyUniqueID Evt_RequestEndDBCEffectsByAnimNotifyUniqueID = delegate
	{
	};

	public Del_RequestEndDBCEffectsByTag Evt_RequestEndDBCEffectsByTag = delegate
	{
	};

	public Del_RequestResetAllEffects Evt_RequestResetAllEffects = delegate
	{
	};

	public Del_RequestEndDBCEffectsAdvance Evt_RequestEndDBCEffectsAdvance = delegate
	{
	};

	public Del_DBCRealEndOneCustomEvent Evt_DBCRealEndOneCustomEvent = delegate
	{
	};

	public Del_DBCOneCustomEventTriggerEndDispStage Evt_DBCOneCustomEventTriggerEndDispStage = delegate
	{
	};

	public Del_DLDWorld_RequestApplyOneDBCDataAsset Evt_DLDWorld_RequestApplyOneDBCDataAsset = delegate(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out uint IdentityID, DBCTransformParam DBCTransform, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCSetCallbackParams CallbackParams, uint ANID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_DLDWorld_RequestSpawnOneSimpleNiagara Evt_DLDWorld_RequestSpawnOneSimpleNiagara = delegate
	{
	};

	public Del_DLDWorld_RequestSpawnOneCommonNiagara Evt_DLDWorld_RequestSpawnOneCommonNiagara = delegate
	{
	};

	public Del_DLDWorld_RequestApplyOneModMPC Evt_DLDWorld_RequestApply_One_ModMPC = delegate(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out uint IdentityID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_DLDWorld_RequestApplyOneCameraShake Evt_DLDWorld_RequestApplyOneCameraShake = delegate
	{
	};

	public Del_DLDWorld_RequestApplyOneCustomCameraShake Evt_DLDWorld_RequestApplyOneCustomCameraShake = delegate
	{
	};

	public Del_DLDWorld_RequestEndDBCEffects Evt_DLDWorld_RequestEndDBCEffects = delegate
	{
	};

	public Del_DLDWorld_RequestEndDBCEffectsByAnimNotifyUniqueID Evt_DLDWorld_RequestEndDBCEffectsByANID = delegate
	{
	};

	public Del_DLDWorld_RequestEndDBCEffectsByTag Evt_DLDWorld_RequestEndDBCEffectsByTag = delegate
	{
	};

	public Del_DLDWorld_RequestSpawnOneSimpleActor Evt_DLDWorld_RequestSpawnOneSimpleActor = delegate
	{
	};

	public Del_DLDWorld_RequestInjectWind Evt_DLDWorld_RequestDirectInject_Wind = delegate
	{
	};

	public Del_DLDWorld_RequestInjectHeat Evt_DLDWorld_RequestDirectInject_Heat = delegate(out uint IdentityID, FVector CenterPosWS, FVector SizeV3, float Intensity, float DistanceDamplingRate, FVector4 DataV4, uint ANID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_DLDWorld_RequestSetWEFMSystemState Evt_DLDWorld_RequestSetWEFMSystemState = delegate
	{
	};

	public Del_DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState Evt_DLDWorld_GlobalControl_RequestSetAllDBCNiagaraVisibleState = delegate
	{
	};

	public Del_RequestSetDBCEffectsDetachFromParent Evt_RequestSetDBCEffectsDetachFromParent = delegate
	{
	};

	public Del_RequestSetDBCEffectsAttachToNewSocket Evt_RequestSetDBCEffectsAttachToNewSocket = delegate
	{
	};

	public Del_RequestSetDBCEffectsPause Evt_RequestSetDBCEffectsPause = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVisibleState Evt_RequestSetDBCNiagaraVisibleState = delegate
	{
	};

	public Del_RequestSetDBCNiagaraFloatParam Evt_RequestSetDBCNiagaraFloatParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVectorParam Evt_RequestSetDBCNiagaraVectorParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraBoolParam Evt_RequestSetDBCNiagaraBoolParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraIntParam Evt_RequestSetDBCNiagaraIntParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVectorArrayParam Evt_RequestSetDBCNiagaraVectorArrayParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVectorArrayParamValue Evt_RequestSetDBCNiagaraVectorArrayParamValue = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVector4ArrayParam Evt_RequestSetDBCNiagaraVector4ArrayParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraVector4ArrayParamValue Evt_RequestSetDBCNiagaraVector4ArrayParamValue = delegate
	{
	};

	public Del_RequestSetDBCNiagaraFloatArrayParam Evt_RequestSetDBCNiagaraFloatArrayParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraFloatArrayParamValue Evt_RequestSetDBCNiagaraFloatArrayParamValue = delegate
	{
	};

	public Del_RequestSetDBCAudioMuteState Evt_RequestSetDBCAudioMuteState = delegate
	{
	};

	public Del_RequestSetDBCCameraShakeIntensityScale Evt_RequestSetDBCCameraShakeIntensityScale = delegate
	{
	};

	public Del_RequestSetDBCEffectsCustomTimeDilation Evt_RequestSetDBCEffectsCustomTimeDilation = delegate
	{
	};

	public Del_VoidString Evt_RequestRemoveCharInteractParticle = delegate
	{
	};

	public Del_VoidTwoIntString Evt_RespondAddCharInteractParticle = delegate
	{
	};

	public static BWS_DispLibEventCollection Get(AActor Actor)
	{
		if (Actor == null)
		{
			return null;
		}
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(Actor);
		if (bGW_ECSWorld == null)
		{
			return null;
		}
		ECSUtil.ToEntity(Actor);
		BWS_DispLibEventCollection bWS_DispLibEventCollection = bGW_ECSWorld.GetObject<BWS_DispLibEventCollection>(ECSUtil.ToEntity(Actor));
		if (bWS_DispLibEventCollection == null)
		{
			_ = BGW_ReplaySystemMgr.Get(Actor).IsPlayingReplay;
		}
		return bWS_DispLibEventCollection;
	}

	public static BWS_DispLibEventCollection Get(UActorCompBaseCS Comp)
	{
		if (Comp == null)
		{
			return null;
		}
		return Get(Comp.GetOwner());
	}

	public static BWS_DispLibEventCollection Get(UBaseActorComp Comp)
	{
		if (Comp == null)
		{
			return null;
		}
		return Get(Comp.GetOwner());
	}
}

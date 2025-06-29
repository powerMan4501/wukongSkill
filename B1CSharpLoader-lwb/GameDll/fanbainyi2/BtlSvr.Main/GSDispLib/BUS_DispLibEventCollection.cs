using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
public class BUS_DispLibEventCollection
{
	public delegate void Del_Void();

	public delegate void Del_OneNiagaraComp(UNiagaraComponent NiagaraComp);

	public delegate void Del_OneInt(int IntValue);

	public delegate void Del_OneUint(uint IntValue);

	public delegate void Del_OneIntBool(int IntValue, bool BoolValue);

	public delegate void Del_OneBoolInt(bool BoolValue, int IntValue);

	public delegate void Del_OneUintBool(uint UintValue, bool BoolValue);

	public delegate void Del_OneFloat(float floatValue);

	public delegate void Del_OneActor(AActor Actor);

	public delegate void Del_OneMeshComp(UPrimitiveComponent MeshComp);

	public delegate void Del_TagAndMeshComp(FName Tag, UPrimitiveComponent MeshComp);

	public delegate void Del_TwoVectorInt(FVector VectorValue1, FVector VectorValue2, int IntValue);

	public delegate void Del_DBCFXCallback(DispLibRefParam Receipt);

	public delegate void Del_SetUnitMatsScalarParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, float ScalarValue, float EventStartTime, int Priority);

	public delegate void Del_SetUnitMatsFLinearColorParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, FLinearColor FLinearColorValue, float EventStartTime, int Priority);

	public delegate void Del_SetUnitMatsTexture2DParamByInfo_Immed(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, FName ParameterName, UMaterialFunctionInterface LayerFunction, UTexture TextureValue, float EventStartTime, int Priority);

	public delegate void Del_SetUnitMatsScalarParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ScalarAttributeName, float ScalarValue, float EventStartTime, int Priority);

	public delegate void Del_SetUnitMatsFLinearColorParam(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, FName ColorAttributeName, FLinearColor FLinearColorValue, float EventStartTime, int Priority);

	public delegate void Del_ResetUnitMatsScalarParam(FName ScalarAttributeName, int Priority = 0, int MatIndex = -1);

	public delegate void Del_ResetUnitMatsColorParam(FName ColorAttributeName, int Priority = 0, int MatIndex = -1);

	public delegate void Del_SetUnitRenderCustomDepth(bool b);

	public delegate void Del_CreatNewMat(DispLibRefParam Receipt, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, UMaterialInterface MatInterface, DispLibMaterialParamsInheritMode InheritMode);

	public delegate void Del_CreatNewMatsWithCustomParamsByList(DispLibRefParam Receipt, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, UMaterialInterface MatInterface, bool InheritCurParamQueue, List<FName> InheritScalarParam, List<FName> InheritFLinearColorParam, List<FName> InheritTextureParam);

	public delegate void Del_ResetMat(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, uint ResetEventID);

	public delegate bool Del_GetMaterialScalarParamValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out float ParamCurValue);

	public delegate bool Del_GetMaterialFLinearColorParamValue(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out FLinearColor ParamCurValue);

	public delegate void Del_ChangeParamOperationCounter(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName);

	public delegate void Del_ResetParamPriority(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, uint MatParamEventID, FName OperationEventName, int EventPriority);

	public delegate void Del_RequestOneUniversalUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, int UniversalDataIndex, int Priority, DispLibRefParam RefParam);

	public delegate void Del_RequestOneOverrideUniversalUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, int UniversalDataIndex, int Priority, DispLibRefParam RefParam, float OverrideTime = 0f, float OverrideOnePeriodTime = 0f, int OverrideLoop = 0, int OverrideSimpleProgrammedCurve = 0, float OverrideFadeInTime = 0f, float OverrideCommonTime = 0f, float OverrideFadeOutTime = 0f, float OverrideProgrammedPowerMax = 0f);

	public delegate void Del_RequestOneCustomUAFByCustomDataAsset(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, BUC_DispLibUnitArtFresnelDataAsset ArtFresnelCustomDataAsset, int Priority, DispLibRefParam RefParam, float OverrideTime = 0f, float OverrideOnePeriodTime = 0f, int OverrideLoop = 0, int OverrideSimpleProgrammedCurve = 0, float OverrideFadeInTime = 0f, float OverrideCommonTime = 0f, float OverrideFadeOutTime = 0f, float OverrideProgrammedPowerMax = 0f);

	public delegate void Del_EndOneUAF(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, uint ID);

	public delegate void Del_RequestInjectWind(ref uint RequesterUniqueID, FVector CenterPosWS, FVector VelocityDirWS, FVector WindSizeV3, float WindIntensity, int WindType, float DistanceDamplingRate, FVector4 WindDataV4, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestPauseWind(FName EventName);

	public delegate void Del_RequestContinueWind(FName EventName);

	public delegate void Del_AddOrChangeInterfaceSocket(FName InterfaceName, FName OriginSocketName);

	public delegate void Del_OnSkeletalMeshAssetChanged(USkeletalMeshComponent MeshComp, USkeletalMesh OldSkeletalMeshAsset, USkeletalMesh NewSkeletalMeshAsset);

	public delegate bool Del_CheckAndCreateMIDyc(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode);

	public delegate void Del_RequestApplyOneDBCDataAsset(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneScenePhysicalInteractorDataAsset(BUC_DispLibSceneInteractorData DBCDataAsset, out uint IdentityID, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCDataAssetWithReceipt(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, DispLibRefParam Receipt, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneDBCDataAssetByDAPath(string DispConfigDAPath, out int RequestID, USceneComponent MinorDispOwnerComp, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform));

	public delegate int Del_RequestSpawnOneSimpleNiagara(UNiagaraSystem Template, DispLibDBCEndMode EndMode, float Duration, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate int Del_RequestSpawnOneCommonNiagara(BUC_DispLibDBC_PlayNiagara D, DispLibRefParam DBCRefParam, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate int Del_RequestSpawnOneAdvanceNiagara(BUC_DispLibDBC_PlayAdvanceNiagara D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneCameraShake(BUC_DispLibDBC_PlayCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneCustomCameraShake(BUC_DispLibDBC_PlayCustomCameraShake D, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestSpawnOneSimpleActor(BUC_DispLibDBC_SpawnSimpleActor D, DispLibRefParam DBCRefParam, USceneComponent MinorDispOwnerComp = null, FVector MinorPosWSOnSpawn = default(FVector), DBCTransformParam DBCTransform = default(DBCTransformParam), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams), uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestPlayAudio(BUC_DispLibDBC_PlayAudio D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneModMat(BUC_DispLibDBC_ModifyMaterial D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestApplyOneModMPC(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out int GamePlayDispReqID, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestSetMatTextureParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName TexParamName, UTexture TexValue, float DelayTimeAfterStop = 0f, int PausePriority = 0, int EndStagePriority = 0, int ModMatPriority = 0, int ModMatEndStagePriority = 0, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestSetMatScalarParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ScalarParamName, float ScalarValue, float DelayTimeAfterStop = 0f, int PausePriority = 0, int EndStagePriority = 0, int ModMatPriority = 0, int ModMatEndStagePriority = 0, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestSetMatLinearColorParam(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ColorParamName, FLinearColor ColorValue, float DelayTimeAfterStop = 0f, int PausePriority = 0, int EndStagePriority = 0, int ModMatPriority = 0, int ModMatEndStagePriority = 0, uint AnimNotifyUniqueID = 0u, uint MontageUniqueID = 0u);

	public delegate void Del_RequestUpdateMatScalarParam(int GamePlayDispReqID, float NewScalarValue);

	public delegate void Del_DBCTriggerOneCustomEvent(uint DBCID, uint CustomEventID, DispLibDBCCustomEventDataAssetBase ParamsDA, DBCCustomEventTimeInfo TimeInfo, DBCCustomEventAdditionalInfo AdditionalInfo);

	public delegate void Del_DBCPauseOneCustomEvent(uint DBCID, uint CustomEventID, bool Pause, int PausePriority, string PauseReason);

	public delegate void Del_DBCOneCustomEventTriggerEndDispStage(uint DBCID, uint CustomEventID);

	public delegate void Del_DBCRealEndOneCustomEvent(uint DBCID, uint CustomEventID);

	public delegate void Del_RequestGetDBCFXInfo_Mark_Receipt(uint IdentityID, DispLibDBCGettingMark GettingMark, DispLibRefParam Receipt);

	public delegate void Del_RequestSetDBCEffectsDetachFromParent(int GamePlayDispReqID, bool MaintainWorldPosition, bool CallModify = true);

	public delegate void Del_RequestSetDBCEffectsAttachToNewSocket(int GamePlayDispReqID, FName NewSocketName, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepWorld, bool bWeldSimulatedBodies = false);

	public delegate void Del_RequestSetDBCEffectsTransform(int GamePlayDispReqID, DBCTransformParam DBCTransform, bool OnlySetFX = false, bool ForceDetachAndSet = false);

	public delegate bool Del_RequestGetFirstDBCNiagaraTransform(int GamePlayDispReqID, out FTransform ResTransform);

	public delegate void Del_RequestSetDBCEffectsPause(int GamePlayDispReqID, bool Pause, int PausePriority, string PauseReason);

	public delegate void Del_RequestSetDBCEffectsCustomTimeDilation(int GamePlayDispReqID, float CustomTimeDilation);

	public delegate void Del_RequestSetDBCNiagaraFloatParam(int GamePlayDispReqID, FName ParamName, float Value);

	public delegate void Del_RequestSetDBCNiagaraVectorParam(int GamePlayDispReqID, FName ParamName, FVector Value);

	public delegate void Del_RequestSetDBCNiagaraBoolParam(int GamePlayDispReqID, FName ParamName, bool Value);

	public delegate void Del_RequestSetDBCNiagaraIntParam(int GamePlayDispReqID, FName ParamName, int Value);

	public delegate void Del_RequestSetDBCNiagaraFloatArrayParam(int GamePlayDispReqID, FName ParamName, List<float> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraVectorArrayParam(int GamePlayDispReqID, FName ParamName, List<FVector> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraVector4ArrayParam(int GamePlayDispReqID, FName ParamName, List<FVector4> ArrayData);

	public delegate void Del_RequestSetDBCNiagaraFloatArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, float Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCNiagaraVectorArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, FVector Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCNiagaraVector4ArrayParamValue(int GamePlayDispReqID, FName ParamName, int Index, FVector4 Value, bool SizeToFit);

	public delegate void Del_RequestSetDBCNiagaraVisibleState(int GamePlayDispReqID, bool isVisible, int ATKPriority);

	public delegate void Del_RequestSetDBCAudioMuteState(int GamePlayDispReqID, bool isMute);

	public delegate void Del_RequestSetDBCCameraShakeIntensityScale(int GamePlayDispReqID, float IntensityScale);

	public delegate void Del_RequestResetAllEffects(int GamePlayDispReqID, bool OnlyResetFX = false, bool OnlyEndProcedureEndMode = false);

	public delegate void Del_RequestEndDBCEffects(int GamePlayDispReqID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsByAnimNotifyUniqueID(uint AnimNotifyUniqueID, uint MontageUniqueID, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsByTag(FName CompTag, bool OnlyEndFX = false, bool OnlyEndProcedureEndMode = true, int EndStagePriority = -1, bool ForceDestroyComponent = false);

	public delegate void Del_RequestEndDBCEffectsAdvance(DispLibDBCEffectType EffectType, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float ForeceDestroyAfterTime = -1f, int EndReasonMark = 0);

	public delegate void Del_AnimNotifySpawnOneNiagara(UNiagaraComponent NiagaraComp, int ANID);

	public Del_Void Evt_DispLibPreDestroy = delegate
	{
	};

	public Del_SetUnitMatsScalarParamByInfo_Immed Evt_SetUnitMatsScalarParamByInfo_Immed = delegate
	{
	};

	public Del_SetUnitMatsFLinearColorParamByInfo_Immed Evt_SetUnitMatsFLinearColorParamByInfo_Immed = delegate
	{
	};

	public Del_SetUnitMatsTexture2DParamByInfo_Immed Evt_SetUnitMatsTextureParamByInfo_Immed = delegate
	{
	};

	public Action Evt_LogActorMaterialQualityInfo = delegate
	{
	};

	public Del_SetUnitMatsScalarParam Evt_SetUnitMatsScalarParam = delegate
	{
	};

	public Del_SetUnitMatsFLinearColorParam Evt_SetUnitMatsFLinearColorParam = delegate
	{
	};

	public Del_ResetUnitMatsScalarParam Evt_ResetUnitMatsScalarParam = delegate
	{
	};

	public Del_ResetUnitMatsColorParam Evt_ResetUnitMatsColorParam = delegate
	{
	};

	public Del_SetUnitRenderCustomDepth Evt_SetUnitRenderCustomDepth = delegate
	{
	};

	public Del_CreatNewMatsWithCustomParamsByList Evt_CreateNewMaterialsWithCustomParamsByList = delegate
	{
	};

	public Del_CreatNewMat Evt_CreateNewMaterials = delegate
	{
	};

	public Del_ResetMat Evt_ResetUnitMaterials = delegate
	{
	};

	public Del_GetMaterialScalarParamValue Evt_GetFirstCacheMaterialScalarParamValue = delegate(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out float ParamCurValue)
	{
		ParamCurValue = 0f;
		return false;
	};

	public Del_GetMaterialScalarParamValue Evt_GetFirstCacheMaterialScalarParamInitialValue = delegate(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out float ParamCurValue)
	{
		ParamCurValue = 0f;
		return false;
	};

	public Del_GetMaterialFLinearColorParamValue Evt_GetFirstCacheMaterialFLinearColorParamValue = delegate(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out FLinearColor ParamCurValue)
	{
		ParamCurValue = FLinearColor.White;
		return false;
	};

	public Del_GetMaterialFLinearColorParamValue Evt_GetFirstCacheMaterialFLinearColorParamInitialValue = delegate(BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParameterName, out FLinearColor ParamCurValue)
	{
		ParamCurValue = FLinearColor.White;
		return false;
	};

	public Del_ChangeParamOperationCounter Evt_ScalarParamOperationCounterAdd = delegate
	{
	};

	public Del_ChangeParamOperationCounter Evt_ColorParamOperationCounterAdd = delegate
	{
	};

	public Del_ChangeParamOperationCounter Evt_TextureParamOperationCounterAdd = delegate
	{
	};

	public Del_ChangeParamOperationCounter Evt_ScalarParamOperationCounterRemove = delegate
	{
	};

	public Del_ChangeParamOperationCounter Evt_ColorParamOperationCounterRemove = delegate
	{
	};

	public Del_ChangeParamOperationCounter Evt_TextureParamOperationCounterRemove = delegate
	{
	};

	public Del_ResetParamPriority Evt_ScalarParamResetPriority = delegate
	{
	};

	public Del_ResetParamPriority Evt_ColorParamResetPriority = delegate
	{
	};

	public Del_ResetParamPriority Evt_TextureParamResetPriority = delegate
	{
	};

	public Del_RequestOneUniversalUAF Evt_RequestOneUniversalUAFFX = delegate
	{
	};

	public Del_RequestOneOverrideUniversalUAF Evt_RequestOneOverrideUniversalUAF = delegate
	{
	};

	public Del_RequestOneCustomUAFByCustomDataAsset Evt_RequestOneCustomUAFByDataAsset = delegate
	{
	};

	public Del_OneUintBool Evt_RequestSetPauseOneUAF = delegate
	{
	};

	public Del_Void Evt_RequestEndAllUAF = delegate
	{
	};

	public Del_EndOneUAF Evt_RequestEndOneUAF = delegate
	{
	};

	public Del_RequestInjectWind Evt_RequestDynamicWindEvent = delegate
	{
	};

	public Del_RequestPauseWind Evt_RequestPauseWind = delegate
	{
	};

	public Del_RequestContinueWind Evt_RequestContinueWind = delegate
	{
	};

	public Del_AddOrChangeInterfaceSocket Evt_AddOrChangeInterfaceSocket = delegate
	{
	};

	public Action Evt_StartCheckSourceActorHiddenStateSyncDBCEvent = delegate
	{
	};

	public Action Evt_StopCheckSourceActorHiddenStateSyncDBCEvent = delegate
	{
	};

	public Del_OnSkeletalMeshAssetChanged Evt_OnSkeletalMeshAssetChanged = delegate
	{
	};

	public Del_OneMeshComp Evt_AddNewMeshCompToManager = delegate
	{
	};

	public Del_TagAndMeshComp Evt_AddNewMeshCompToManagerWithTag = delegate
	{
	};

	public Del_OneActor Evt_AddChildActorMeshCompsToManager = delegate
	{
	};

	public Del_OneActor Evt_RemoveChildActorMeshCompsFromManager = delegate
	{
	};

	public Del_OneMeshComp Evt_RemoveMeshCompFromManager = delegate
	{
	};

	public Del_TagAndMeshComp Evt_MeshCompRemoveTag = delegate
	{
	};

	public Del_TagAndMeshComp Evt_MeshCompAddNewTag = delegate
	{
	};

	public Del_OneMeshComp Evt_MeshCompCleanAllTags = delegate
	{
	};

	public Del_CheckAndCreateMIDyc Evt_CheckAndCreateMIDyc = (BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode) => false;

	public Del_OneMeshComp Evt_AddNewMeshComp_AfterMainDataUpdate = delegate
	{
	};

	public Del_OneMeshComp Evt_RemoveMeshComp_AfterMainDataUpdate = delegate
	{
	};

	public Del_OnSkeletalMeshAssetChanged Evt_SkeletalMeshAssetChanged_AfterMainDataUpdate = delegate
	{
	};

	public Del_RequestApplyOneDBCDataAsset Evt_RequestApplyOneDBCDataAsset = delegate(BUC_DispLibDispBaseConfigDataAsset DBCDataAsset, out int GamePlayDispReqID, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform, DBCSetCallbackParams CallbackParams, uint ANID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestApplyOneScenePhysicalInteractorDataAsset Evt_RequestApplyOneScenePhysicalInteractorDataAsset = delegate(BUC_DispLibSceneInteractorData SceneInteractorData, out uint IdentityID, USceneComponent MinorDispOwnerComp, FVector MinorPosWSOnSpawn, DBCTransformParam DBCTransform, DBCSetCallbackParams CallbackParams, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		IdentityID = 0u;
	};

	public Del_RequestPlayAudio Evt_RequestPlayAudio = delegate(BUC_DispLibDBC_PlayAudio D, out int GamePlayDispReqID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_DBCTriggerOneCustomEvent Evt_DBCTriggerOneCustomEvent = delegate
	{
	};

	public Del_DBCPauseOneCustomEvent Evt_DBCPauseOneCustomEvent = delegate
	{
	};

	public Del_RequestSpawnOneSimpleNiagara Evt_RequestSpawn_One_Simple_Niagara = (UNiagaraSystem _003Cp0_003E, DispLibDBCEndMode _003Cp1_003E, float _003Cp2_003E, DispLibRefParam _003Cp3_003E, DBCTransformParam _003Cp4_003E, DBCSetCallbackParams _003Cp5_003E, uint _003Cp6_003E, uint _003Cp7_003E) => 0;

	public Del_RequestSpawnOneCommonNiagara Evt_RequestSpawn_One_Common_Niagara = (BUC_DispLibDBC_PlayNiagara _003Cp0_003E, DispLibRefParam _003Cp1_003E, DBCTransformParam _003Cp2_003E, DBCSetCallbackParams _003Cp3_003E, uint _003Cp4_003E, uint _003Cp5_003E) => 0;

	public Del_RequestSpawnOneAdvanceNiagara Evt_RequestSpawn_One_Advance_Niagara = (BUC_DispLibDBC_PlayAdvanceNiagara _003Cp0_003E, DispLibRefParam _003Cp1_003E, USceneComponent _003Cp2_003E, FVector _003Cp3_003E, DBCTransformParam _003Cp4_003E, DBCSetCallbackParams _003Cp5_003E, uint _003Cp6_003E, uint _003Cp7_003E) => 0;

	public Del_RequestApplyOneCameraShake Evt_RequestApply_One_CameraShake = delegate
	{
	};

	public Del_RequestApplyOneCustomCameraShake Evt_RequestApply_One_CustomCameraShake = delegate
	{
	};

	public Del_RequestSpawnOneSimpleActor Evt_RequestSpawn_One_Simple_Actor = delegate
	{
	};

	public Del_RequestApplyOneModMat Evt_RequestApply_One_ModMat = delegate(BUC_DispLibDBC_ModifyMaterial D, out int GamePlayDispReqID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestApplyOneModMPC Evt_RequestApply_One_ModMPC = delegate(BUC_DispLibDBC_ModifyMaterialParameterCollection D, out int GamePlayDispReqID, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestSetMatScalarParam Evt_RequestSetMatScalarParam = delegate(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ScalarParamName, float ScalarValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestSetMatTextureParam Evt_RequestSetMatTextureParam = delegate(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName TexParamName, UTexture TexValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestSetMatLinearColorParam Evt_RequestSetMatLinearColorParam = delegate(out int GamePlayDispReqID, BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode, float Delay, DispLibDBCEndMode EndMode, float Duration, FName ColorParamName, FLinearColor ColorValue, float DelayTimeAfterStop, int PausePriority, int EndStagePriority, int ModMatPriority, int ModMatEndStagePriority, uint AnimNotifyUniqueID, uint MontageUniqueID)
	{
		GamePlayDispReqID = 0;
	};

	public Del_RequestUpdateMatScalarParam Evt_RequestUpdateMatScalarParam = delegate
	{
	};

	public Del_RequestGetDBCFXInfo_Mark_Receipt Evt_RequestGetFirstFXInfoWithReceipt = delegate
	{
	};

	public Del_RequestGetDBCFXInfo_Mark_Receipt Evt_RequestGetAllFXInfoWithReceipt = delegate
	{
	};

	public Del_RequestSetDBCEffectsDetachFromParent Evt_RequestSetDBCEffectsDetachFromParent = delegate
	{
	};

	public Del_RequestSetDBCEffectsAttachToNewSocket Evt_RequestSetDBCEffectsAttachToNewSocket = delegate
	{
	};

	public Del_RequestSetDBCEffectsCustomTimeDilation Evt_RequestSetDBCEffectsCustomTimeDilation = delegate
	{
	};

	public Del_RequestSetDBCEffectsTransform Evt_RequestSetDBCEffectsTransform = delegate
	{
	};

	public Del_RequestGetFirstDBCNiagaraTransform Evt_RequestGetFirstDBCNiagaraTransform = delegate(int GamePlayDispReqID, out FTransform ResTransform)
	{
		ResTransform = FTransform.Default;
		return false;
	};

	public Del_RequestSetDBCEffectsPause Evt_RequestSetDBCEffectsPause = delegate
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

	public Del_RequestSetDBCNiagaraFloatArrayParam Evt_RequestSetDBCNiagaraFloatArrayParam = delegate
	{
	};

	public Del_RequestSetDBCNiagaraFloatArrayParamValue Evt_RequestSetDBCNiagaraFloatArrayParamValue = delegate
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

	public Del_RequestSetDBCNiagaraVisibleState Evt_RequestSetDBCNiagaraVisibleState = delegate
	{
	};

	public Del_RequestSetDBCAudioMuteState Evt_RequestSetDBCAudioMuteState = delegate
	{
	};

	public Del_RequestSetDBCCameraShakeIntensityScale Evt_RequestSetDBCCameraShakeIntensityScale = delegate
	{
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

	public Del_RequestEndDBCEffectsAdvance Evt_RequestEndDBCEffectsAdvance = delegate
	{
	};

	public Del_DBCOneCustomEventTriggerEndDispStage Evt_DBCOneCustomEventTriggerEndDispStage = delegate
	{
	};

	public Del_DBCRealEndOneCustomEvent Evt_DBCRealEndOneCustomEvent = delegate
	{
	};

	public Del_RequestResetAllEffects Evt_RequestResetAllEffects = delegate
	{
	};

	public static BUS_DispLibEventCollection Get(AActor Actor)
	{
		if (Actor == null)
		{
			return null;
		}
		return BGW_ECSWorld.Get(Actor)?.GetObject<BUS_DispLibEventCollection>(ECSUtil.ToEntity(Actor));
	}

	public static BUS_DispLibEventCollection Get(USceneComponent Comp)
	{
		if (Comp == null)
		{
			return null;
		}
		return Get(Comp.GetOwner());
	}

	public static BUS_DispLibEventCollection Get(UActorCompBaseCS CompBaseCS)
	{
		if (CompBaseCS == null)
		{
			return null;
		}
		return Get(CompBaseCS.GetOwner());
	}
}

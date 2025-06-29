using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using b1.Protobuf.DataAPI;
using BtlB1;
using BtlShare;
using Google.Protobuf;
using Google.Protobuf.Collections;
using LitJson;
using UnrealEngine.AIModule;
using UnrealEngine.AssetRegistry;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime")]
public class BGUFuncLibNonRuntime : UBlueprintFunctionLibrary
{
	private struct CachedInfo
	{
		public int ID;

		public int HatredPerceptionXYDistance;

		public int HatredPerceptionZDistance;

		public int SearchAOTargetXYDistance;

		public int SearchAOTargetZDistance;

		public int LeaveAOTargetXYDistance;

		public int LeaveAOTargetZDistance;
	}

	private struct OverrideCachedInfo
	{
		public int ID;

		public int CamID;

		public bool CollapseArmorisShowInUI;

		public float MaxBlockCollapseArmorVal;

		public ELockCamMode CamMode;
	}

	private struct SkillEffectArmorHitConfig
	{
		public int ID;

		public float HitValue;

		public int HitLevel;
	}

	private static FName FootPostAnimNotifyTrackName;

	private static bool GetCDO_IsValid;

	private static IntPtr GetCDO_FunctionAddress;

	private static int GetCDO_ParamsSize;

	private static bool GetCDO_Assets_IsValid;

	private static int GetCDO_Assets_Offset;

	private static bool GetCDO_ReturnValue_IsValid;

	private static int GetCDO_ReturnValue_Offset;

	private static bool TestCode_IsValid;

	private static IntPtr TestCode_FunctionAddress;

	private static int TestCode_ParamsSize;

	private static bool TestCode_ReturnValue_IsValid;

	private static int TestCode_ReturnValue_Offset;

	private static FFieldAddress TestCode_ReturnValue_PropertyAddress;

	private static bool SkillSVaild_IsValid;

	private static IntPtr SkillSVaild_FunctionAddress;

	private static int SkillSVaild_ParamsSize;

	private static bool SkillSVaild_Unit_IsValid;

	private static int SkillSVaild_Unit_Offset;

	private static bool SkillSVaild_SkillID_IsValid;

	private static int SkillSVaild_SkillID_Offset;

	private static bool SkillSVaild_ReturnValue_IsValid;

	private static int SkillSVaild_ReturnValue_Offset;

	private static FFieldAddress SkillSVaild_ReturnValue_PropertyAddress;

	private static bool BGUIsFileExist_IsValid;

	private static IntPtr BGUIsFileExist_FunctionAddress;

	private static int BGUIsFileExist_ParamsSize;

	private static bool BGUIsFileExist_PathWithGameHead_IsValid;

	private static int BGUIsFileExist_PathWithGameHead_Offset;

	private static FFieldAddress BGUIsFileExist_PathWithGameHead_PropertyAddress;

	private static bool BGUIsFileExist_fullPath_IsValid;

	private static int BGUIsFileExist_fullPath_Offset;

	private static FFieldAddress BGUIsFileExist_fullPath_PropertyAddress;

	private static bool BGUIsFileExist_ReturnValue_IsValid;

	private static int BGUIsFileExist_ReturnValue_Offset;

	private static FFieldAddress BGUIsFileExist_ReturnValue_PropertyAddress;

	private static bool CheckBuffRemove_IsValid;

	private static IntPtr CheckBuffRemove_FunctionAddress;

	private static int CheckBuffRemove_ParamsSize;

	private static bool ScanCBGTemplate_IsValid;

	private static IntPtr ScanCBGTemplate_FunctionAddress;

	private static int ScanCBGTemplate_ParamsSize;

	private static bool BGUCopyABPSetting_IsValid;

	private static IntPtr BGUCopyABPSetting_FunctionAddress;

	private static int BGUCopyABPSetting_ParamsSize;

	private static bool BGUCopyABPSetting_Src_IsValid;

	private static int BGUCopyABPSetting_Src_Offset;

	private static bool BGUCopyABPSetting_Dest_IsValid;

	private static int BGUCopyABPSetting_Dest_Offset;

	private static bool GetResIDFromAsset_IsValid;

	private static IntPtr GetResIDFromAsset_FunctionAddress;

	private static int GetResIDFromAsset_ParamsSize;

	private static bool GetResIDFromAsset_Assets_IsValid;

	private static int GetResIDFromAsset_Assets_Offset;

	private static bool GetResIDFromAsset_ReturnValue_IsValid;

	private static int GetResIDFromAsset_ReturnValue_Offset;

	private static FFieldAddress GetResIDFromAsset_ReturnValue_PropertyAddress;

	private static bool ProjectileSpawnTest_IsValid;

	private static IntPtr ProjectileSpawnTest_FunctionAddress;

	private static int ProjectileSpawnTest_ParamsSize;

	private static bool ProjectileSpawnTest_Spawnner_IsValid;

	private static int ProjectileSpawnTest_Spawnner_Offset;

	private static bool ProjectileSpawnTest_Target_IsValid;

	private static int ProjectileSpawnTest_Target_Offset;

	private static bool ProjectileSpawnTest_ProjectileSpawnConfig_IsValid;

	private static int ProjectileSpawnTest_ProjectileSpawnConfig_Offset;

	private static bool CheckHitMoveCapsules_IsValid;

	private static IntPtr CheckHitMoveCapsules_FunctionAddress;

	private static int CheckHitMoveCapsules_ParamsSize;

	private static bool CheckHitMoveCapsules_WorldContext_IsValid;

	private static int CheckHitMoveCapsules_WorldContext_Offset;

	private static bool CheckHitMoveCapsules_ReturnValue_IsValid;

	private static int CheckHitMoveCapsules_ReturnValue_Offset;

	private static FFieldAddress CheckHitMoveCapsules_ReturnValue_PropertyAddress;

	private static bool GetResIDFromUnitAsset_IsValid;

	private static IntPtr GetResIDFromUnitAsset_FunctionAddress;

	private static int GetResIDFromUnitAsset_ParamsSize;

	private static bool GetResIDFromUnitAsset_Assets_IsValid;

	private static int GetResIDFromUnitAsset_Assets_Offset;

	private static bool GetResIDFromUnitAsset_ReturnValue_IsValid;

	private static int GetResIDFromUnitAsset_ReturnValue_Offset;

	private static bool BindDeathDispAMInUDDC_IsValid;

	private static IntPtr BindDeathDispAMInUDDC_FunctionAddress;

	private static int BindDeathDispAMInUDDC_ParamsSize;

	private static bool BindDeathDispAMInUDDC_UDDC_IsValid;

	private static int BindDeathDispAMInUDDC_UDDC_Offset;

	private static bool GetAllProjectileBPPath_IsValid;

	private static IntPtr GetAllProjectileBPPath_FunctionAddress;

	private static int GetAllProjectileBPPath_ParamsSize;

	private static bool GetAllProjectileBPPath_PathList_Exist_IsValid;

	private static int GetAllProjectileBPPath_PathList_Exist_Offset;

	private static FFieldAddress GetAllProjectileBPPath_PathList_Exist_PropertyAddress;

	private static bool SetActorCompEditorOnly_IsValid;

	private static IntPtr SetActorCompEditorOnly_FunctionAddress;

	private static int SetActorCompEditorOnly_ParamsSize;

	private static bool SetActorCompEditorOnly_ActorComp_IsValid;

	private static int SetActorCompEditorOnly_ActorComp_Offset;

	private static bool SetActorCompEditorOnly_bIsEditorOnly_IsValid;

	private static int SetActorCompEditorOnly_bIsEditorOnly_Offset;

	private static FFieldAddress SetActorCompEditorOnly_bIsEditorOnly_PropertyAddress;

	private static bool BindNormalStiffAMInUBAC_IsValid;

	private static IntPtr BindNormalStiffAMInUBAC_FunctionAddress;

	private static int BindNormalStiffAMInUBAC_ParamsSize;

	private static bool BindNormalStiffAMInUBAC_UBAC_IsValid;

	private static int BindNormalStiffAMInUBAC_UBAC_Offset;

	private static bool BGUAutoAddFootLockCurve_IsValid;

	private static IntPtr BGUAutoAddFootLockCurve_FunctionAddress;

	private static int BGUAutoAddFootLockCurve_ParamsSize;

	private static bool BGUAutoAddFootLockCurve_AnimSequence_IsValid;

	private static int BGUAutoAddFootLockCurve_AnimSequence_Offset;

	private static bool BGUAutoAddFootLockCurve_LeftFootBoneName_IsValid;

	private static int BGUAutoAddFootLockCurve_LeftFootBoneName_Offset;

	private static bool BGUAutoAddFootLockCurve_RightFootBoneName_IsValid;

	private static int BGUAutoAddFootLockCurve_RightFootBoneName_Offset;

	private static bool BGUAutoAddFootLockCurve_FootLockHeight_IsValid;

	private static int BGUAutoAddFootLockCurve_FootLockHeight_Offset;

	private static bool BGUAutoAddFootLockCurve_FootUnlockHeight_IsValid;

	private static int BGUAutoAddFootLockCurve_FootUnlockHeight_Offset;

	private static bool BGUAutoAddFootLockCurve_FootLockSpeed_IsValid;

	private static int BGUAutoAddFootLockCurve_FootLockSpeed_Offset;

	private static bool BGUAutoAddFootLockCurve_FootUnlockSpeed_IsValid;

	private static int BGUAutoAddFootLockCurve_FootUnlockSpeed_Offset;

	private static bool GetOriFilePathByAssetPath_IsValid;

	private static IntPtr GetOriFilePathByAssetPath_FunctionAddress;

	private static int GetOriFilePathByAssetPath_ParamsSize;

	private static bool GetOriFilePathByAssetPath_AssetPathName_IsValid;

	private static int GetOriFilePathByAssetPath_AssetPathName_Offset;

	private static FFieldAddress GetOriFilePathByAssetPath_AssetPathName_PropertyAddress;

	private static bool GetOriFilePathByAssetPath_AssetName_IsValid;

	private static int GetOriFilePathByAssetPath_AssetName_Offset;

	private static FFieldAddress GetOriFilePathByAssetPath_AssetName_PropertyAddress;

	private static bool GetOriFilePathByAssetPath_ReturnValue_IsValid;

	private static int GetOriFilePathByAssetPath_ReturnValue_Offset;

	private static FFieldAddress GetOriFilePathByAssetPath_ReturnValue_PropertyAddress;

	private static bool UpdateHitAudioPreloadList_IsValid;

	private static IntPtr UpdateHitAudioPreloadList_FunctionAddress;

	private static int UpdateHitAudioPreloadList_ParamsSize;

	private static bool UpdateHitAudioPreloadList_PathList_Exist_IsValid;

	private static int UpdateHitAudioPreloadList_PathList_Exist_Offset;

	private static FFieldAddress UpdateHitAudioPreloadList_PathList_Exist_PropertyAddress;

	private static bool UpdateHitAudioPreloadList_ReturnValue_IsValid;

	private static int UpdateHitAudioPreloadList_ReturnValue_Offset;

	private static bool CheckBeAttacked2Resources_IsValid;

	private static IntPtr CheckBeAttacked2Resources_FunctionAddress;

	private static int CheckBeAttacked2Resources_ParamsSize;

	private static bool CheckBeAttacked2Resources_bCheckBasicRuleOnly_IsValid;

	private static int CheckBeAttacked2Resources_bCheckBasicRuleOnly_Offset;

	private static FFieldAddress CheckBeAttacked2Resources_bCheckBasicRuleOnly_PropertyAddress;

	private static bool CheckBeAttacked2Resources_ReturnValue_IsValid;

	private static int CheckBeAttacked2Resources_ReturnValue_Offset;

	private static FFieldAddress CheckBeAttacked2Resources_ReturnValue_PropertyAddress;

	private static bool GetAllSummonBPPathFromDesc_IsValid;

	private static IntPtr GetAllSummonBPPathFromDesc_FunctionAddress;

	private static int GetAllSummonBPPathFromDesc_ParamsSize;

	private static bool GetAllSummonBPPathFromDesc_CurrentUsedBPPath_IsValid;

	private static int GetAllSummonBPPathFromDesc_CurrentUsedBPPath_Offset;

	private static FFieldAddress GetAllSummonBPPathFromDesc_CurrentUsedBPPath_PropertyAddress;

	private static bool CheckUnitCapsuleCollisions_IsValid;

	private static IntPtr CheckUnitCapsuleCollisions_FunctionAddress;

	private static int CheckUnitCapsuleCollisions_ParamsSize;

	private static bool CheckUnitCapsuleCollisions_WorldContext_IsValid;

	private static int CheckUnitCapsuleCollisions_WorldContext_Offset;

	private static bool CheckUnitCapsuleCollisions_ReturnValue_IsValid;

	private static int CheckUnitCapsuleCollisions_ReturnValue_Offset;

	private static FFieldAddress CheckUnitCapsuleCollisions_ReturnValue_PropertyAddress;

	private static bool Analysis_BuffUseSimpleState_IsValid;

	private static IntPtr Analysis_BuffUseSimpleState_FunctionAddress;

	private static int Analysis_BuffUseSimpleState_ParamsSize;

	private static bool BGUSetUpDefaultFootstepAudio_IsValid;

	private static IntPtr BGUSetUpDefaultFootstepAudio_FunctionAddress;

	private static int BGUSetUpDefaultFootstepAudio_ParamsSize;

	private static bool BGUSetUpDefaultFootstepAudio_TamerActor_IsValid;

	private static int BGUSetUpDefaultFootstepAudio_TamerActor_Offset;

	private static bool BGUSetUpDefaultFootstepAudio_AudioPath_IsValid;

	private static int BGUSetUpDefaultFootstepAudio_AudioPath_Offset;

	private static FFieldAddress BGUSetUpDefaultFootstepAudio_AudioPath_PropertyAddress;

	private static bool BGUSetUpDefaultFootstepAudio_ReturnValue_IsValid;

	private static int BGUSetUpDefaultFootstepAudio_ReturnValue_Offset;

	private static FFieldAddress BGUSetUpDefaultFootstepAudio_ReturnValue_PropertyAddress;

	private static bool GetTemplateClassFromUnitAsset_IsValid;

	private static IntPtr GetTemplateClassFromUnitAsset_FunctionAddress;

	private static int GetTemplateClassFromUnitAsset_ParamsSize;

	private static bool GetTemplateClassFromUnitAsset_Assets_IsValid;

	private static int GetTemplateClassFromUnitAsset_Assets_Offset;

	private static bool GetTemplateClassFromUnitAsset_ReturnValue_IsValid;

	private static int GetTemplateClassFromUnitAsset_ReturnValue_Offset;

	private static bool BGUMigrateDataFromUnitCommDesc_IsValid;

	private static IntPtr BGUMigrateDataFromUnitCommDesc_FunctionAddress;

	private static int BGUMigrateDataFromUnitCommDesc_ParamsSize;

	private static bool BGUMigrateDataFromUnitCommDesc_BlameName_IsValid;

	private static int BGUMigrateDataFromUnitCommDesc_BlameName_Offset;

	private static FFieldAddress BGUMigrateDataFromUnitCommDesc_BlameName_PropertyAddress;

	private static bool BGUAddNofityStateByPelvisSpeed_IsValid;

	private static IntPtr BGUAddNofityStateByPelvisSpeed_FunctionAddress;

	private static int BGUAddNofityStateByPelvisSpeed_ParamsSize;

	private static bool BGUAddNofityStateByPelvisSpeed_AnimMontage_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_AnimMontage_Offset;

	private static bool BGUAddNofityStateByPelvisSpeed_SpeedThreshold_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_SpeedThreshold_Offset;

	private static bool BGUAddNofityStateByPelvisSpeed_BuffID_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_BuffID_Offset;

	private static bool BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_Offset;

	private static bool BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_Offset;

	private static FFieldAddress BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_PropertyAddress;

	private static bool BGUAddNofityStateByPelvisSpeed_SocketName_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_SocketName_Offset;

	private static FFieldAddress BGUAddNofityStateByPelvisSpeed_SocketName_PropertyAddress;

	private static bool BGUAddNofityStateByPelvisSpeed_TickTime_IsValid;

	private static int BGUAddNofityStateByPelvisSpeed_TickTime_Offset;

	private static bool BGUEditorRecordSubLevelsInWorld_IsValid;

	private static IntPtr BGUEditorRecordSubLevelsInWorld_FunctionAddress;

	private static int BGUEditorRecordSubLevelsInWorld_ParamsSize;

	private static bool BGUEditorRecordSubLevelsInWorld_WorldContext_IsValid;

	private static int BGUEditorRecordSubLevelsInWorld_WorldContext_Offset;

	private static bool BGUEditorRecordSubLevelsInWorld_RecordFilePath_IsValid;

	private static int BGUEditorRecordSubLevelsInWorld_RecordFilePath_Offset;

	private static FFieldAddress BGUEditorRecordSubLevelsInWorld_RecordFilePath_PropertyAddress;

	private static bool AddMagicallyChangeFadeOutNotify_IsValid;

	private static IntPtr AddMagicallyChangeFadeOutNotify_FunctionAddress;

	private static int AddMagicallyChangeFadeOutNotify_ParamsSize;

	private static bool AddMagicallyChangeFadeOutNotify_Montage_IsValid;

	private static int AddMagicallyChangeFadeOutNotify_Montage_Offset;

	private static bool Analysis_BuffUseSpecialHitPartID_IsValid;

	private static IntPtr Analysis_BuffUseSpecialHitPartID_FunctionAddress;

	private static int Analysis_BuffUseSpecialHitPartID_ParamsSize;

	private static bool BGUSerializeActorTransformsToJson_IsValid;

	private static IntPtr BGUSerializeActorTransformsToJson_FunctionAddress;

	private static int BGUSerializeActorTransformsToJson_ParamsSize;

	private static bool BGUSerializeActorTransformsToJson_JsonPath_IsValid;

	private static int BGUSerializeActorTransformsToJson_JsonPath_Offset;

	private static FFieldAddress BGUSerializeActorTransformsToJson_JsonPath_PropertyAddress;

	private static bool BGUSerializeActorTransformsToJson_Actors_IsValid;

	private static int BGUSerializeActorTransformsToJson_Actors_Offset;

	private static FFieldAddress BGUSerializeActorTransformsToJson_Actors_PropertyAddress;

	private static bool BGUMigrateDataFromSkillEffectDesc_IsValid;

	private static IntPtr BGUMigrateDataFromSkillEffectDesc_FunctionAddress;

	private static int BGUMigrateDataFromSkillEffectDesc_ParamsSize;

	private static bool BGUMigrateDataFromSkillEffectDesc_BlameName_IsValid;

	private static int BGUMigrateDataFromSkillEffectDesc_BlameName_Offset;

	private static FFieldAddress BGUMigrateDataFromSkillEffectDesc_BlameName_PropertyAddress;

	private static bool BGUGetLeftFootHeightByFootStepConfig_IsValid;

	private static IntPtr BGUGetLeftFootHeightByFootStepConfig_FunctionAddress;

	private static int BGUGetLeftFootHeightByFootStepConfig_ParamsSize;

	private static bool BGUGetLeftFootHeightByFootStepConfig_ResID_IsValid;

	private static int BGUGetLeftFootHeightByFootStepConfig_ResID_Offset;

	private static bool BGUGetLeftFootHeightByFootStepConfig_Mesh_IsValid;

	private static int BGUGetLeftFootHeightByFootStepConfig_Mesh_Offset;

	private static bool BGUGetLeftFootHeightByFootStepConfig_ReturnValue_IsValid;

	private static int BGUGetLeftFootHeightByFootStepConfig_ReturnValue_Offset;

	private static bool BGUDeserializeActorTransformsFromJson_IsValid;

	private static IntPtr BGUDeserializeActorTransformsFromJson_FunctionAddress;

	private static int BGUDeserializeActorTransformsFromJson_ParamsSize;

	private static bool BGUDeserializeActorTransformsFromJson_JsonPath_IsValid;

	private static int BGUDeserializeActorTransformsFromJson_JsonPath_Offset;

	private static FFieldAddress BGUDeserializeActorTransformsFromJson_JsonPath_PropertyAddress;

	private static bool BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_IsValid;

	private static int BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_Offset;

	private static FFieldAddress BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_PropertyAddress;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_IsValid;

	private static IntPtr BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_ParamsSize;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_IsValid;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_Offset;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_IsValid;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_Offset;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_IsValid;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_Offset;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_IsValid;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_Offset;

	private static bool BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_IsValid;

	private static int BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_Offset;

	private static FFieldAddress BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_PropertyAddress;

	private static bool BGUEditorRecordSubLevelsInLevelPackage_IsValid;

	private static IntPtr BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress;

	private static int BGUEditorRecordSubLevelsInLevelPackage_ParamsSize;

	private static bool BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_IsValid;

	private static int BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_Offset;

	private static FFieldAddress BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_PropertyAddress;

	private static bool BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_IsValid;

	private static int BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_Offset;

	private static FFieldAddress BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_PropertyAddress;

	private static bool BGUMigrateDataFromUnitCommDesc_OverrideData_IsValid;

	private static IntPtr BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress;

	private static int BGUMigrateDataFromUnitCommDesc_OverrideData_ParamsSize;

	private static bool BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_IsValid;

	private static int BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_Offset;

	private static FFieldAddress BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_PropertyAddress;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:AddMagicallyChangeFadeOutNotify")]
	public static void AddMagicallyChangeFadeOutNotify(UAnimMontage Montage)
	{
		if (Montage == null)
		{
			return;
		}
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(Montage, out var NotifyEvents);
		foreach (FAnimNotifyEventSimple item in NotifyEvents)
		{
			if (item.Notify is b1.BAN_GSMagicallyChangeFadeOut)
			{
				UGSE_AnimFuncLib.RemoveAnimationNotify(Montage, item.Notify, null);
			}
			if (item.Notify is b1.BAN_GSMagicallyChangeRecover)
			{
				UGSE_AnimFuncLib.GetAnimationTrackNameByIndex(Montage, item.TrackIndex, out var TrackName);
				UGSE_AnimFuncLib.AddAnimationNotifyEvent(Montage, TrackName, item.StartTime - 0.5f, UClass.GetClass<b1.BAN_GSMagicallyChangeFadeOut>());
			}
		}
		Montage.MarkPackageDirty();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllSummonBPPathFromDesc")]
	public static void GetAllSummonBPPathFromDesc(out List<string> CurrentUsedBPPath)
	{
		LoadProtobufData<FUStSummonCommDesc>();
		Dictionary<int, FUStSummonCommDesc> allSummonCommDesc = BGW_GameDB.GetAllSummonCommDesc();
		CurrentUsedBPPath = new List<string>();
		foreach (KeyValuePair<int, FUStSummonCommDesc> item in allSummonCommDesc)
		{
			string summonTamerTemplatePath = item.Value.SummonTamerTemplatePath;
			if (!string.IsNullOrEmpty(summonTamerTemplatePath) && !CurrentUsedBPPath.Contains(summonTamerTemplatePath))
			{
				CurrentUsedBPPath.Add(summonTamerTemplatePath);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:SetActorCompEditorOnly")]
	public static void SetActorCompEditorOnly(UActorComponent ActorComp, bool bIsEditorOnly)
	{
		if (ActorComp != null)
		{
			ActorComp.IsEditorOnly = bIsEditorOnly;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBuffRemove")]
	public static void CheckBuffRemove()
	{
		LoadProtobufData<FUStSkillEffectDesc>();
		LoadProtobufData<FUStBuffDesc>();
		LoadProtobufData<FUStBuffRuleDesc>();
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, FUStSkillEffectDesc> item in BGW_GameDB.GetAllSkillEffectDesc())
		{
			if (item.Value.EffectType != EBuffAndSkillEffectType.RemoveBuff)
			{
				continue;
			}
			foreach (int item2 in item.Value.EffectParamsInt)
			{
				if (item2 < 0)
				{
					list.Add(-item2);
				}
			}
		}
		foreach (KeyValuePair<int, FUStBuffDesc> item3 in BGW_GameDB.GetAllBuffDesc())
		{
			foreach (FUStBuffEffectAttr buffEffect in item3.Value.BuffEffects)
			{
				if (buffEffect.EffectType != EBuffAndSkillEffectType.RemoveBuff)
				{
					continue;
				}
				foreach (int effectParam in buffEffect.EffectParams)
				{
					if (effectParam < 0)
					{
						list.Add(-effectParam);
					}
				}
			}
		}
		foreach (KeyValuePair<int, FUStBuffRuleDesc> item4 in BGW_GameDB.GetAllBuffRuleDesc())
		{
			if (item4.Value.BuffRuleType == EBuffRuleType.BrReplace && item4.Value.WithTriggerRemmoveEffect == EGSYesNo.No)
			{
				List<int> collection = AnalyzeBuffIDInRule(item4.Value.BuffIDList);
				list.AddRange(collection);
			}
			else if (item4.Value.BuffRuleType == EBuffRuleType.BrCompose && item4.Value.WithTriggerRemmoveEffect == EGSYesNo.No)
			{
				List<int> collection2 = AnalyzeBuffIDInRule(item4.Value.BuffIDList);
				list.AddRange(collection2);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSimpleState")]
	public static void Analysis_BuffUseSimpleState()
	{
		List<int> list = new List<int>();
		List<EBGUSimpleState> list2 = new List<EBGUSimpleState>();
		LoadProtobufData<FUStBuffDesc>();
		List<int> list3 = new List<int>();
		foreach (KeyValuePair<int, FUStBuffDesc> item in BGW_GameDB.GetAllBuffDesc())
		{
			foreach (FUStBuffEffectAttr buffEffect in item.Value.BuffEffects)
			{
				if (buffEffect.EffectType != EBuffAndSkillEffectType.SetSimpleState)
				{
					continue;
				}
				foreach (int effectParam in buffEffect.EffectParams)
				{
					if (effectParam == 82)
					{
						list3.Add(item.Key);
					}
					if (!list.Contains(effectParam))
					{
						list.Add(effectParam);
						list2.Add((EBGUSimpleState)effectParam);
					}
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSpecialHitPartID")]
	public static void Analysis_BuffUseSpecialHitPartID()
	{
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		new List<EBGUSimpleState>();
		LoadProtobufData<FUStBuffDesc>();
		foreach (KeyValuePair<int, FUStBuffDesc> item in BGW_GameDB.GetAllBuffDesc())
		{
			foreach (FUStBuffEffectAttr buffEffect in item.Value.BuffEffects)
			{
				if (buffEffect.EffectType == EBuffAndSkillEffectType.SkillDamage && buffEffect.EffectParamsString.Count > 2 && !dictionary.ContainsKey(item.Key))
				{
					dictionary.Add(item.Key, buffEffect.EffectParamsString[2]);
				}
			}
		}
	}

	public static List<int> AnalyzeBuffIDInRule(RepeatedField<int> BuffIDList)
	{
		List<int> list = new List<int>();
		if (BuffIDList == null)
		{
			return null;
		}
		for (int i = 0; i < BuffIDList.Count; i++)
		{
			if (BuffIDList[i] < 0)
			{
				FUStBuffGroupDesc buffGroupDesc = BGW_GameDB.GetBuffGroupDesc(-BuffIDList[i]);
				if (buffGroupDesc == null)
				{
					continue;
				}
				foreach (int buffID in buffGroupDesc.BuffIDList)
				{
					list.Add(buffID);
				}
			}
			else
			{
				list.Add(BuffIDList[i]);
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:ScanCBGTemplate")]
	public static void ScanCBGTemplate()
	{
		Dictionary<int, string> CBGList = new Dictionary<int, string>();
		string txtPath = $"{USystemLibrary.GetProjectSavedDirectory()}/CBGScan.csv";
		ScanCBGTemplateInAssets(txtPath, ref CBGList);
		ScanCBGTemplateInItemLevels(txtPath, ref CBGList);
	}

	private static void ScanCBGTemplateInAssets(string TxtPath, ref Dictionary<int, string> CBGList)
	{
		foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName("/Game/00Main/Design/Units"), bRecursive: true).AssetDataArr)
		{
			if (!(item.GetClass() != UClass.GetClass<UBlueprint>()))
			{
				FName objectPath = item.ObjectPath;
				UBlueprint Blueprint;
				AActor aActor = UGSE_EditorFuncLib.AssetPath_GetCDO(null, objectPath.ToString(), out Blueprint) as AActor;
				if (!(aActor == null))
				{
					ScanCBGTemplateInternal(aActor, TxtPath, ref CBGList, "");
				}
			}
		}
	}

	private static void ScanCBGTemplateInItemLevels(string TxtPath, ref Dictionary<int, string> CBGList)
	{
		UGSEditorLevelLibrary.GetGSWCItemLevels("/Game/00Main/Maps/BSD01", out var OutItemLevelAssets);
		foreach (FAssetData item in OutItemLevelAssets)
		{
			FName objectPath = item.ObjectPath;
			UGSE_EditorFuncLib.LoadLevel(objectPath.ToString());
			foreach (AActor allLevelActor in UGSE_EditorFuncLib.GetAllLevelActors())
			{
				objectPath = item.ObjectPath;
				ScanCBGTemplateInternal(allLevelActor, TxtPath, ref CBGList, objectPath.ToString());
			}
		}
	}

	private static void ScanCBGTemplateInternal(AActor Actor, string TxtPath, ref Dictionary<int, string> CBGList, string LevelName)
	{
		if ((!Actor.GetClass().IsChildOf<BGUCharacterCS>() || !Actor.GetClass().IsChildOf<BUTamerActor>()) && !(Actor.GetComponentByClass<BUS_ExtendConfigComp>() == null))
		{
			_ = Actor.GetComponentByClass<BUS_ConfigInfoComp>() == null;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:ProjectileSpawnTest")]
	public static void ProjectileSpawnTest(AActor Spawnner, AActor Target, BGWDataAsset_ProjectileSpawnConfig ProjectileSpawnConfig)
	{
		if (Spawnner == null || ProjectileSpawnConfig == null)
		{
			return;
		}
		FEffectInstReq effectInstReq = default(FEffectInstReq);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Spawnner);
		if (bUS_GSEventCollection != null)
		{
			FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
			ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
			ProjectileSpawnNSInfo.BuffIDList = ProjectileSpawnConfig.BuffIDList.ToList();
			ProjectileSpawnNSInfo.ProjectileID = ProjectileSpawnConfig.ProjectileID;
			ProjectileSpawnNSInfo.SpawnWave = ProjectileSpawnConfig.ProjectileWave;
			ProjectileSpawnNSInfo.SpawnNumPerWave = ProjectileSpawnConfig.ProjectileNumInOneWave;
			ProjectileSpawnNSInfo.SpawnBase = ProjectileSpawnConfig.SpawnBase;
			ProjectileSpawnNSInfo.SpawnBase.BaseActor = new TStrongObjectPtr<AActor>();
			ProjectileSpawnNSInfo.SpawnBase.BaseActor.Set(Spawnner);
			if (ProjectileSpawnConfig.SpawnBase.BaseType == ProjectileBaseType.UseEffectPosition)
			{
				ProjectileSpawnNSInfo.SpawnBase.EffectInstReq = effectInstReq;
			}
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo = ProjectileSpawnConfig.SpawnPosOffsetInfo;
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo.BaseActor = new TStrongObjectPtr<AActor>();
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo.BaseActor.Set(Spawnner);
			ProjectileSpawnNSInfo.AttachToSpawnBase = ProjectileSpawnConfig.AttachToSpawnBase;
			ProjectileSpawnNSInfo.AttachRule_Rot = ProjectileSpawnConfig.AttachRule_Rot;
			ProjectileSpawnNSInfo.TargetBase = ProjectileSpawnConfig.TargetBase;
			ProjectileSpawnNSInfo.TargetBase.BaseActor = new TStrongObjectPtr<AActor>();
			ProjectileSpawnNSInfo.TargetBase.BaseActor.Set(Target);
			if (ProjectileSpawnConfig.TargetBase.BaseType == ProjectileBaseType.UseEffectPosition)
			{
				ProjectileSpawnNSInfo.TargetBase.EffectInstReq = effectInstReq;
			}
			ProjectileSpawnNSInfo.TargetPosOffsetInfo = ProjectileSpawnConfig.TargetPosOffsetInfo;
			ProjectileSpawnNSInfo.TargetPosOffsetInfo.BaseActor = new TStrongObjectPtr<AActor>();
			ProjectileSpawnNSInfo.TargetPosOffsetInfo.BaseActor.Set(Target);
			ProjectileSpawnNSInfo.BornDirBaseInfo = ProjectileSpawnConfig.BornDirBaseInfo;
			if (ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType == ProjectileBornDirType.UseEffectNormal)
			{
				ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = effectInstReq.HitPointNormalDir;
			}
			ProjectileSpawnNSInfo.BornDirOffset = ProjectileSpawnConfig.BornDirOffset;
			ProjectileSpawnNSInfo.ProjectileFlySpd = ProjectileSpawnConfig.BulletFlySpd;
			ProjectileSpawnNSInfo.ProjectileRotSpd = ProjectileSpawnConfig.BulletRotSpd;
			ProjectileSpawnNSInfo.MontageID = -1;
			ProjectileSpawnNSInfo.SpawnWaveDuration = 0f;
			ProjectileSpawnNSInfo.SpawnCounter = 0;
			ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
			ProjectileSpawnNSInfo.ANSTotalTime = 0f;
			ProjectileSpawnNSInfo.bEnableMultiTargetMode = ProjectileSpawnConfig.bEnableMultiTargetMode;
			ProjectileSpawnNSInfo.MutilTargetRule = ProjectileSpawnConfig.MutilTargetRule;
			bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllProjectileBPPath")]
	public static void GetAllProjectileBPPath(out List<string> PathList_Exist)
	{
		PathList_Exist = new List<string>();
		LoadProtobufData<FUStProjectileCommDesc>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in BGW_GameDB.GetAllProjectileCommDesc())
		{
			string projectileBPTemplatePath = item.Value.ProjectileBPTemplatePath;
			if (!string.IsNullOrEmpty(projectileBPTemplatePath))
			{
				projectileBPTemplatePath = projectileBPTemplatePath.Substring(0, projectileBPTemplatePath.Length - 2);
				if (!PathList_Exist.Contains(projectileBPTemplatePath))
				{
					PathList_Exist.Add(projectileBPTemplatePath);
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:UpdateHitAudioPreloadList")]
	public static int UpdateHitAudioPreloadList(out List<string> PathList_Exist)
	{
		PathList_Exist = new List<string>();
		LoadProtobufData<FUStAttackHitAudioInfoDesc>();
		foreach (KeyValuePair<int, FUStAttackHitAudioInfoDesc> item in BGW_GameDB.GetAllAttackHitAudioInfoDesc())
		{
			FUStAttackHitAudioInfoDesc value = item.Value;
			string audioFolderPath = value.AudioFolderPath;
			string preAkEventName = value.PreAkEventName;
			string text = "";
			foreach (string value2 in AttackHitAKNameMapping.HitPerformTypeNameMap.Values)
			{
				foreach (string value3 in AttackHitAKNameMapping.HitItemTypeNameMap.Values)
				{
					text = string.Format("{0}/{1}_{2}_{3}.{1}_{2}_{3}", audioFolderPath, preAkEventName, value2, value3);
					if (!PathList_Exist.Contains(text) && BGUIsFileExist(text, out var _))
					{
						PathList_Exist.Add(text);
					}
				}
				text = string.Format("{0}/{1}_{2}_all.{1}_{2}_all", audioFolderPath, preAkEventName, value2);
				if (!PathList_Exist.Contains(text) && BGUIsFileExist(text, out var _))
				{
					PathList_Exist.Add(text);
				}
			}
		}
		return PathList_Exist.Count;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetOriFilePathByAssetPath")]
	public static string GetOriFilePathByAssetPath(string AssetPathName, string AssetName)
	{
		EPlatform platform = FPlatformProperties.GetPlatform();
		string text = string.Empty;
		switch (platform)
		{
		case EPlatform.Windows:
			text = Path.GetDirectoryName(FPaths.ProjectDir);
			if (string.IsNullOrEmpty(AssetPathName) || string.IsNullOrEmpty(AssetName) || string.IsNullOrEmpty(text) || !Directory.Exists(text))
			{
				return null;
			}
			break;
		case EPlatform.PS5:
			text = "/app0/b1/";
			break;
		case EPlatform.XSX:
			text = "/b1/";
			break;
		}
		string path = AssetName + ".uasset";
		string path2 = FPaths.GetPath(AssetPathName).TrimStart('/').Replace('/', '\\');
		return Path.GetFullPath(Path.Combine(text, path2, path)).Replace("\\unreal_proj\\Game\\00Main\\", "\\unreal_proj\\Content\\00Main\\");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUIsFileExist")]
	public static bool BGUIsFileExist(string PathWithGameHead, out string fullPath)
	{
		string[] array = PathWithGameHead.Split('.');
		string text = FPaths.ProjectDir + array[0] + ".uasset";
		return UBGUFunctionLibrary.BGUIsExistFile(fullPath = text.Replace("/Game", "Content"));
	}

	public static void LoadProtobufData<T>() where T : IMessage, new()
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:SkillSVaild")]
	public static bool SkillSVaild(AActor Unit, int SkillID)
	{
		LoadProtobufData<FUStSkillSDesc>();
		bool result = false;
		if (BGW_GameDB.GetSkillSDesc(SkillID, Unit) != null)
		{
			result = true;
		}
		return result;
	}

	public static void LoadProtobufDataNoneRunTime_AiConversationContentDesc()
	{
		LoadProtobufData<FUStAiConversationContentDesc>();
	}

	public static void LoadProtobufDataNoneRunTime_SweepCheckDesc()
	{
		LoadProtobufData<FUStSweepCheckDesc>();
	}

	public static FUStAiConversationContentDesc GetDescDataNoneRunTime_AiConversationContentDesc(int DescID)
	{
		return BGW_GameDB.GetAiConversationContentDesc(DescID);
	}

	public static void QueryEQSReferenceInfoFromTables(ref string OutSkillEffectIDs, ref string OutBuffIDs)
	{
		LoadProtobufData<FUStSkillEffectDesc>();
		LoadProtobufData<FUStBuffDesc>();
		foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(B1GlobalFNames._Game_00Main_Design_AI_EQS).AssetDataArr)
		{
			if (!(item.GetClass() == UClass.GetClass<UEnvQuery>()))
			{
				continue;
			}
			FName assetName = item.AssetName;
			foreach (KeyValuePair<int, FUStSkillEffectDesc> item2 in BGW_GameDB.GetAllSkillEffectDesc())
			{
				foreach (string item3 in item2.Value.EffectParamsStr)
				{
					if (item3.Contains(assetName.ToString()))
					{
						OutSkillEffectIDs = OutSkillEffectIDs + item2.Key + "\n";
					}
				}
			}
			foreach (KeyValuePair<int, FUStBuffDesc> item4 in BGW_GameDB.GetAllBuffDesc())
			{
				foreach (FUStBuffEffectAttr buffEffect in item4.Value.BuffEffects)
				{
					foreach (string item5 in buffEffect.EffectParamsString)
					{
						if (item5.Contains(assetName.ToString()))
						{
							OutBuffIDs = OutBuffIDs + item4.Key + "\n";
						}
					}
				}
			}
		}
	}

	public static FUnitAIDesc BGUGetUnitAIDesc(BUTamerActor Tamer)
	{
		FUnitAIDesc result = default(FUnitAIDesc);
		int finalBattleInfoExtendID = Tamer.GetFinalBattleInfoExtendID();
		FUStUnitAIDesc unitAIDesc = BGW_GameDB.GetUnitAIDesc(finalBattleInfoExtendID);
		if (unitAIDesc == null)
		{
			LoadProtobufData<FUStUnitAIDesc>();
			unitAIDesc = BGW_GameDB.GetUnitAIDesc(finalBattleInfoExtendID);
		}
		if (unitAIDesc == null)
		{
			return result;
		}
		BUS_ConfigInfoComp configInfoComp = Tamer.ConfigInfoComp;
		result.HearRange = ((configInfoComp.UnitAIDesc.HearRange == -1f) ? unitAIDesc.HearRange : configInfoComp.UnitAIDesc.HearRange);
		result.SightRange = ((configInfoComp.UnitAIDesc.SightRange == -1f) ? unitAIDesc.SightRange : configInfoComp.UnitAIDesc.SightRange);
		result.VisionAngleDegrees = ((configInfoComp.UnitAIDesc.VisionAngleDegrees == -1f) ? unitAIDesc.VisionAngleDegrees : configInfoComp.UnitAIDesc.VisionAngleDegrees);
		return result;
	}

	public static List<int> BGUFindEffectInstInBuffDesc(EBuffAndSkillEffectType EffectType, out List<int> EffectIdx)
	{
		LoadProtobufData<FUStBuffDesc>();
		Dictionary<int, FUStBuffDesc> allBuffDesc = BGW_GameDB.GetAllBuffDesc();
		List<int> list = new List<int>();
		EffectIdx = new List<int>();
		foreach (KeyValuePair<int, FUStBuffDesc> item in allBuffDesc)
		{
			int count = item.Value.BuffEffects.Count;
			for (int i = 0; i < count; i++)
			{
				if (!list.Contains(item.Key) && item.Value.BuffEffects[i].EffectType == EffectType)
				{
					list.Add(item.Key);
					EffectIdx.Add(i);
				}
			}
		}
		return list;
	}

	public static List<int> BGUFindEffectInstInBuffDesc_IntParamList(int BuffID, int EffectIdx)
	{
		List<int> list = new List<int>();
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(BuffID);
		if (originalBuffDesc != null)
		{
			foreach (int effectParam in originalBuffDesc.BuffEffects[EffectIdx].EffectParams)
			{
				list.Add(effectParam);
			}
		}
		return list;
	}

	public static AActor BGUSpawnActorFromAssetPath(string Path, ref FTransform Trans, UWorld World = null, ULevel InLevel = null)
	{
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootSyncMarkerToAnimSequence")]
	public static bool BGUAutoAddFootSyncMarkerToAnimSequence(UAnimSequence AnimSequence, in FName LeftFootBoneName, in FName RightFootBoneName, float GroundFootLimitHeight)
	{
		return false;
	}

	[Category("BGU|NoneRuntime")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootLockCurve")]
	public static void BGUAutoAddFootLockCurve(UAnimSequence AnimSequence, in FName LeftFootBoneName, in FName RightFootBoneName, float FootLockHeight, float FootUnlockHeight, float FootLockSpeed, float FootUnlockSpeed)
	{
	}

	[Category("BGU|NoneRuntime")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAddNofityStateByPelvisSpeed")]
	public static void BGUAddNofityStateByPelvisSpeed(UAnimMontage AnimMontage, float SpeedThreshold, int BuffID, TSubclassOf<UAnimNotifyState> NewNotifyStateClass, bool FirstRemoveAddBuffID, string SocketName = "Pelvis", float TickTime = 0.2f)
	{
		if (BuffID == 0 || SpeedThreshold == 0f)
		{
			return;
		}
		float playLength = AnimMontage.GetPlayLength();
		float num = 0f;
		UGSE_AnimFuncLib.AnimMontageGetSocketLocationForScale(AnimMontage, out var OutEndPos, 0f, "Pelvis");
		FVector fVector = OutEndPos;
		FVector OutEndPos2 = OutEndPos;
		bool flag = false;
		float key = 0f;
		float num2 = 0f;
		Dictionary<float, float> dictionary = new Dictionary<float, float>();
		while (num < playLength)
		{
			num += TickTime;
			num = FMath.Min(num, playLength);
			UGSE_AnimFuncLib.AnimMontageGetSocketLocationForScale(AnimMontage, out OutEndPos2, num, "Pelvis");
			float num3 = (OutEndPos2 - fVector).Size() / TickTime;
			if (num3 >= SpeedThreshold && !flag)
			{
				flag = true;
				key = num - TickTime;
			}
			else if (num3 < SpeedThreshold && flag)
			{
				flag = false;
				num2 = num - TickTime;
				dictionary.Add(key, num2);
			}
			fVector = OutEndPos2;
		}
		if (flag)
		{
			dictionary.Add(key, playLength);
		}
		UGSE_AnimFuncLib.RemoveNotifyTrackByName(AnimMontage, B1GlobalFNames.Immoblizing);
		if (FirstRemoveAddBuffID)
		{
			UGSE_AnimFuncLib.GetAllNotifyEvent(AnimMontage, out var AnimNotifyEventList);
			for (int i = 0; i < AnimNotifyEventList.Count; i++)
			{
				if (AnimNotifyEventList[i].NotifyStateClass is BANS_GSAddBuffByID bANS_GSAddBuffByID && bANS_GSAddBuffByID.BuffID == BuffID)
				{
					UGSE_AnimFuncLib.RemoveNotifyEventByIndex(AnimMontage, i);
				}
			}
		}
		UObject uObject = UObject.NewObject<BANS_GSAddBuffByID>(AnimMontage, FName.None, EObjectFlags.Transactional, null, copyTransientsFromClassDefaults: false, (IntPtr)0);
		if (uObject is BANS_GSAddBuffByID bANS_GSAddBuffByID2)
		{
			bANS_GSAddBuffByID2.BuffID = BuffID;
		}
		UBGUFunctionLibrary.AddBuffNotifyStates(AnimMontage, uObject, BuffID, dictionary);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUCopyABPSetting")]
	public static void BGUCopyABPSetting(BGWDataAsset_AbpHumanoidSetting Src, BGWDataAsset_AbpHumanoidSetting Dest)
	{
		if (!(Src == null) && !(Dest == null))
		{
			Dest.CommonSetting = Src.CommonSetting;
			Dest.MotionMatchingSetting = Src.MotionMatchingSetting;
			Dest.Simple4DirSetting = Src.Simple4DirSetting;
			Dest.PlayerLocomotionSetting = Src.PlayerLocomotionSetting;
			Dest.FlyControlSetting = Src.FlyControlSetting;
			Dest.AimOffsetSetting = Src.AimOffsetSetting;
			Dest.FootIKSetting = Src.FootIKSetting;
			Dest.DingShenSetting = Src.DingShenSetting;
			Dest.JumpSetting = Src.JumpSetting;
			Dest.PatrolSetting = Src.PatrolSetting;
			Dest.GlideMoveSetting = Src.GlideMoveSetting;
			Dest.ParkourMoveSetting = Src.ParkourMoveSetting;
			Dest.WheelMoveSetting = Src.WheelMoveSetting;
			Dest.MarkPackageDirty();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromUnitAsset")]
	public static int GetResIDFromUnitAsset(UAssetDataArray Assets)
	{
		int result = -1;
		if (Assets != null && Assets.AssetDataArr.Count > 0)
		{
			BUTamerActor bUTamerActor = (Assets.AssetDataArr[0].GetAsset() as UBlueprint).GeneratedClass.ClassDefaultObject as BUTamerActor;
			if (bUTamerActor != null)
			{
				result = bUTamerActor.ConfigInfoComp.UnitCDesc.ResID;
			}
		}
		return result;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromAsset")]
	public static List<UShapeComponent> GetResIDFromAsset(UAssetDataArray Assets)
	{
		List<UShapeComponent> list = new List<UShapeComponent>();
		if (Assets != null && Assets.AssetDataArr.Count > 0)
		{
			AActor aActor = (Assets.AssetDataArr[0].GetAsset() as UBlueprint).GeneratedClass.ClassDefaultObject as AActor;
			if (aActor != null)
			{
				foreach (UActorComponent item in aActor.GetComponentsByClass(UClass.GetClass<UShapeComponent>()))
				{
					UShapeComponent uShapeComponent = item as UShapeComponent;
					if (uShapeComponent != null)
					{
						list.Add(uShapeComponent);
					}
				}
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetCDO")]
	public static UObject GetCDO(UAssetDataArray Assets)
	{
		if (Assets != null && Assets.AssetDataArr.Count > 0)
		{
			return (Assets.AssetDataArr[0].GetAsset() as UBlueprint).GeneratedClass.ClassDefaultObject;
		}
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:GetTemplateClassFromUnitAsset")]
	public static TSubclassOf<BGUCharacterCS> GetTemplateClassFromUnitAsset(UAssetDataArray Assets)
	{
		if (Assets != null && Assets.AssetDataArr.Count > 0)
		{
			return (Assets.AssetDataArr[0].GetAsset() as UBlueprint).GeneratedClass;
		}
		return null;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckUnitCapsuleCollisions")]
	public static string CheckUnitCapsuleCollisions(UObject WorldContext)
	{
		string text = "";
		LoadProtobufData<FUStUnitCommDesc>();
		foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName("/Game/00Main/Design/Units"), bRecursive: true).AssetDataArr)
		{
			FName assetName = item.AssetName;
			string text2 = assetName.ToString();
			if (!text2.Contains("Unit_") || text2.Contains("_Prefab"))
			{
				continue;
			}
			BGUCharacterCS bGUCharacterCS = (item.GetAsset() as UBlueprint).GeneratedClass.ClassDefaultObject as BGUCharacterCS;
			if (!(bGUCharacterCS != null))
			{
				continue;
			}
			BUS_ConfigInfoComp componentByClass = bGUCharacterCS.GetComponentByClass<BUS_ConfigInfoComp>();
			if (componentByClass != null && componentByClass.UnitCDesc.ResID > 0)
			{
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(componentByClass.UnitCDesc.ResID);
				if (unitCommDesc != null)
				{
					if (unitCommDesc.UnitBodyType == EUnitBodyType.Huge)
					{
						if (bGUCharacterCS.CapsuleComponent.GetCollisionProfileName() != B1GlobalFNames.WindWalk_Pawn)
						{
							text = text + text2 + " (" + componentByClass.UnitCDesc.ResID + "), 该Huge体型的单位的根RootComponent碰撞预设未正确设置为WindWalk_Pawn\n";
						}
					}
					else if (bGUCharacterCS.CapsuleComponent.GetCollisionProfileName() != B1GlobalFNames.Pawn)
					{
						text = text + text2 + " (" + componentByClass.UnitCDesc.ResID + "), 该非Huge体型的单位的根RootComponent碰撞预设未正确设置为Pawn\n";
					}
				}
			}
			foreach (UActorComponent cDONodeComponent in UGSFuncLibForEditor.GetCDONodeComponents(bGUCharacterCS))
			{
				if (cDONodeComponent.GetClass() == UClass.GetClass<UCapsuleComponent>())
				{
					UCapsuleComponent uCapsuleComponent = cDONodeComponent as UCapsuleComponent;
					if (!(uCapsuleComponent == null) && !(uCapsuleComponent == bGUCharacterCS.CapsuleComponent) && (uCapsuleComponent.GetCollisionProfileName() != B1GlobalFNames.CollisionHitMove || uCapsuleComponent.GetCollisionProfileName() != B1GlobalFNames.Pawn))
					{
						text = text + text2 + " (" + componentByClass.UnitCDesc.ResID + "), 该单位有CapsuleComponent碰撞预设未正确设置为Pawn或CollisionHitMove\n";
					}
				}
			}
		}
		if (text != "")
		{
			text = "单位碰撞预设扫描结果\n" + text;
		}
		return text;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckHitMoveCapsules")]
	public static string CheckHitMoveCapsules(UObject WorldContext)
	{
		string text = "";
		foreach (FAssetData item in UGSFuncLibForEditor.GetAssetsInFolder(new FName("/Game/00Main/Design/Units"), bRecursive: true).AssetDataArr)
		{
			FName assetName = item.AssetName;
			string text2 = assetName.ToString();
			if (!text2.Contains("Unit_") || text2.Contains("_Prefab"))
			{
				continue;
			}
			UBlueprint uBlueprint = item.GetAsset() as UBlueprint;
			if (uBlueprint == null)
			{
				continue;
			}
			BGUCharacterCS bGUCharacterCS = uBlueprint.GeneratedClass.ClassDefaultObject as BGUCharacterCS;
			if (!(bGUCharacterCS != null))
			{
				continue;
			}
			BUS_ConfigInfoComp componentByClass = bGUCharacterCS.GetComponentByClass<BUS_ConfigInfoComp>();
			if (!(componentByClass != null) || componentByClass.UnitCDesc.ResID <= 0)
			{
				continue;
			}
			bool flag = false;
			foreach (UActorComponent cDONodeComponent in UGSFuncLibForEditor.GetCDONodeComponents(bGUCharacterCS))
			{
				if (cDONodeComponent.GetClass() == UClass.GetClass<UCapsuleComponent>())
				{
					UCapsuleComponent uCapsuleComponent = cDONodeComponent as UCapsuleComponent;
					if (!(uCapsuleComponent == null) && uCapsuleComponent.GetCollisionProfileName() == B1GlobalFNames.CollisionHitMove)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				text = text + text2 + " (" + componentByClass.UnitCDesc.ResID + ")\n";
			}
		}
		if (text != "")
		{
			text = "以下单位未配置HitMove\n" + text;
		}
		return text;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBeAttacked2Resources")]
	public static string CheckBeAttacked2Resources(bool bCheckBasicRuleOnly)
	{
		string Output = "";
		LoadProtobufData<FUStBeAttackedInfoDesc>();
		foreach (KeyValuePair<int, FUStBeAttackedInfoDesc> item in BGW_GameDB.GetAllBeAttackedInfoDesc())
		{
			if (item.Value.UnitBeAttackedConfigPath == "")
			{
				continue;
			}
			int key = item.Key;
			int resID = key / 100;
			LoadProtobufData<FUStUnitCommDesc>();
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
			if (unitCommDesc == null)
			{
				continue;
			}
			BGWDataAsset_UnitBeAttackedConfig bGWDataAsset_UnitBeAttackedConfig = (BGWDataAsset_UnitBeAttackedConfig)UGSE_LoadingUtilFuncLib.SyncLoadObject(item.Value.UnitBeAttackedConfigPath);
			if (bGWDataAsset_UnitBeAttackedConfig != null)
			{
				UAssetDataArray assetsInFolder = UGSFuncLibForEditor.GetAssetsInFolder(new FName(bGWDataAsset_UnitBeAttackedConfig.NormalStiffAMPath));
				string text = "";
				int num = key % 100;
				text = ((num >= 10) ? num.ToString() : $"0{num.ToString()}");
				string unitResName = bGWDataAsset_UnitBeAttackedConfig.UnitResName;
				Output = Output + "\n==========开始校验" + unitResName + "的UBAC" + item.Value.UnitBeAttackedConfigPath + "==========\n";
				switch (unitCommDesc.UnitBodyType)
				{
				case EUnitBodyType.Small:
					ProcessBeAttacked2ResourcesForSmallOrMediumBody(bGWDataAsset_UnitBeAttackedConfig, ref Output, text, assetsInFolder, bCheckBasicRuleOnly);
					break;
				case EUnitBodyType.Medium:
					ProcessBeAttacked2ResourcesForSmallOrMediumBody(bGWDataAsset_UnitBeAttackedConfig, ref Output, text, assetsInFolder, bCheckBasicRuleOnly);
					break;
				case EUnitBodyType.MediumBig:
					ProcessBeAttacked2ResourcesForMediumBigBody(bGWDataAsset_UnitBeAttackedConfig, ref Output, text, assetsInFolder, bCheckBasicRuleOnly);
					break;
				case EUnitBodyType.Big:
					ProcessBeAttacked2ResourcesForBigBody(bGWDataAsset_UnitBeAttackedConfig, ref Output, text, assetsInFolder, bCheckBasicRuleOnly);
					break;
				case EUnitBodyType.Huge:
					ProcessBeAttacked2ResourcesForHugeBody(bGWDataAsset_UnitBeAttackedConfig, ref Output, text, assetsInFolder, bCheckBasicRuleOnly);
					break;
				}
			}
		}
		return Output;
	}

	private static void ProcessBeAttacked2ResourcesForSmallOrMediumBody(BGWDataAsset_UnitBeAttackedConfig Config, ref string Output, string BeAttackedInfoIDStr, UAssetDataArray Assets, bool bCheckBasicRuleOnly)
	{
		List<int> list = new List<int>();
		list.Add(1);
		list.Add(2);
		list.Add(5);
		string unitResName = Config.UnitResName;
		List<int> list2 = new List<int>();
		foreach (FNormalStiffInfo normalStiffInfo in Config.NormalStiffInfoList)
		{
			list2.Add(normalStiffInfo.StiffLevelID);
		}
		bool flag = false;
		foreach (int item in list)
		{
			if (!list2.Contains(item))
			{
				flag = true;
			}
		}
		if (flag)
		{
			Output += "档位ID配置不符合规范，至少应包含";
			foreach (int item2 in list)
			{
				Output = Output + item2 + ",";
			}
			Output += "档位（参见通用动画列表.xlsx）！\n";
		}
		foreach (FNormalStiffInfo normalStiffInfo2 in Config.NormalStiffInfoList)
		{
			int stiffLevelID = normalStiffInfo2.StiffLevelID;
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			switch (normalStiffInfo2.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				switch (stiffLevelID)
				{
				case 1:
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hr");
					break;
				case 2:
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_df_hf");
					break;
				case 5:
					list3.Add($"AM_{unitResName}_bh_dep01_sl5_df_hf");
					break;
				default:
					list4.Add("f");
					break;
				}
				break;
			case ENormalStiffSectorsType.ForwardAndBackward:
				list4.Add("f");
				list4.Add("b");
				break;
			case ENormalStiffSectorsType.FourDir:
				list4.Add("f");
				list4.Add("b");
				list4.Add("l");
				list4.Add("r");
				break;
			}
			if (list3.Count > 0)
			{
				foreach (string item3 in list3)
				{
					bool flag2 = false;
					foreach (FAssetData item4 in Assets.AssetDataArr)
					{
						if (!(item4.GetClass() != UClass.GetClass<UAnimMontage>()))
						{
							FName assetName = item4.AssetName;
							if (assetName.ToString() == item3)
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						Output = Output + "缺少动画" + item3 + "（不符合对应体型对应攻击者所在区域所约定的规范，参见通用动画列表.xlsx）!\n";
					}
				}
			}
			else
			{
				if (bCheckBasicRuleOnly)
				{
					continue;
				}
				string text = "";
				string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
				foreach (string item5 in list4)
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						text = $"AM_{unitResName}_bh_dep{BeAttackedInfoIDStr}_sl{stiffLevelID}_d{item5}_h{text2}";
						bool flag3 = false;
						foreach (FAssetData item6 in Assets.AssetDataArr)
						{
							if (!(item6.GetClass() != UClass.GetClass<UAnimMontage>()))
							{
								FName assetName2 = item6.AssetName;
								if (assetName2.ToString() == text)
								{
									flag3 = true;
								}
							}
						}
						if (!flag3)
						{
							Output = Output + "缺少动画" + text + "!\n";
						}
					}
				}
			}
		}
	}

	private static void ProcessBeAttacked2ResourcesForMediumBigBody(BGWDataAsset_UnitBeAttackedConfig Config, ref string Output, string BeAttackedInfoIDStr, UAssetDataArray Assets, bool bCheckBasicRuleOnly)
	{
		List<int> list = new List<int>();
		list.Add(1);
		list.Add(2);
		list.Add(5);
		string unitResName = Config.UnitResName;
		List<int> list2 = new List<int>();
		foreach (FNormalStiffInfo normalStiffInfo in Config.NormalStiffInfoList)
		{
			list2.Add(normalStiffInfo.StiffLevelID);
		}
		bool flag = false;
		foreach (int item in list)
		{
			if (!list2.Contains(item))
			{
				flag = true;
			}
		}
		if (flag)
		{
			Output += "档位ID配置不符合规范，至少应包含";
			foreach (int item2 in list)
			{
				Output = Output + item2 + ",";
			}
			Output += "档位（参见通用动画列表.xlsx）！\n";
		}
		foreach (FNormalStiffInfo normalStiffInfo2 in Config.NormalStiffInfoList)
		{
			int stiffLevelID = normalStiffInfo2.StiffLevelID;
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			switch (normalStiffInfo2.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				if (stiffLevelID == 5)
				{
					list3.Add($"AM_{unitResName}_bh_dep01_sl5_df_hf");
				}
				else
				{
					list4.Add("f");
				}
				break;
			case ENormalStiffSectorsType.ForwardAndBackward:
				switch (stiffLevelID)
				{
				case 1:
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_db_hb");
					break;
				case 2:
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_df_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_df_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_db_hb");
					break;
				default:
					list4.Add("f");
					list4.Add("b");
					break;
				}
				break;
			case ENormalStiffSectorsType.FourDir:
				list4.Add("f");
				list4.Add("b");
				list4.Add("l");
				list4.Add("r");
				break;
			}
			if (list3.Count > 0)
			{
				foreach (string item3 in list3)
				{
					bool flag2 = false;
					foreach (FAssetData item4 in Assets.AssetDataArr)
					{
						if (!(item4.GetClass() != UClass.GetClass<UAnimMontage>()))
						{
							FName assetName = item4.AssetName;
							if (assetName.ToString() == item3)
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						Output = Output + "缺少动画" + item3 + "（不符合对应体型对应攻击者所在区域所约定的规范，参见通用动画列表.xlsx）!\n";
					}
				}
			}
			else
			{
				if (bCheckBasicRuleOnly)
				{
					continue;
				}
				string text = "";
				string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
				foreach (string item5 in list4)
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						text = $"AM_{unitResName}_bh_dep{BeAttackedInfoIDStr}_sl{stiffLevelID}_d{item5}_h{text2}";
						bool flag3 = false;
						foreach (FAssetData item6 in Assets.AssetDataArr)
						{
							if (!(item6.GetClass() != UClass.GetClass<UAnimMontage>()))
							{
								FName assetName2 = item6.AssetName;
								if (assetName2.ToString() == text)
								{
									flag3 = true;
								}
							}
						}
						if (!flag3)
						{
							Output = Output + "缺少动画" + text + "!\n";
						}
					}
				}
			}
		}
	}

	private static void ProcessBeAttacked2ResourcesForBigBody(BGWDataAsset_UnitBeAttackedConfig Config, ref string Output, string BeAttackedInfoIDStr, UAssetDataArray Assets, bool bCheckBasicRuleOnly)
	{
		List<int> list = new List<int>();
		list.Add(1);
		list.Add(4);
		string unitResName = Config.UnitResName;
		List<int> list2 = new List<int>();
		foreach (FNormalStiffInfo normalStiffInfo in Config.NormalStiffInfoList)
		{
			list2.Add(normalStiffInfo.StiffLevelID);
		}
		bool flag = false;
		foreach (int item in list)
		{
			if (!list2.Contains(item))
			{
				flag = true;
			}
		}
		if (flag)
		{
			Output += "档位ID配置不符合规范，至少应包含";
			foreach (int item2 in list)
			{
				Output = Output + item2 + ",";
			}
			Output += "档位（参见通用动画列表.xlsx）！\n";
		}
		foreach (FNormalStiffInfo normalStiffInfo2 in Config.NormalStiffInfoList)
		{
			int stiffLevelID = normalStiffInfo2.StiffLevelID;
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			switch (normalStiffInfo2.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				list4.Add("f");
				break;
			case ENormalStiffSectorsType.ForwardAndBackward:
				if (stiffLevelID == 4)
				{
					list3.Add($"AM_{unitResName}_bh_dep01_sl4_df_hf");
					list3.Add($"AM_{unitResName}_bh_dep01_sl4_dl_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl4_dr_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl4_db_hb");
				}
				else
				{
					list4.Add("f");
					list4.Add("b");
				}
				break;
			case ENormalStiffSectorsType.FourDir:
				if (stiffLevelID == 1)
				{
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_dl_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_dr_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_db_hb_1");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_db_hb_2");
				}
				else
				{
					list4.Add("f");
					list4.Add("b");
					list4.Add("l");
					list4.Add("r");
				}
				break;
			}
			if (list3.Count > 0)
			{
				foreach (string item3 in list3)
				{
					bool flag2 = false;
					foreach (FAssetData item4 in Assets.AssetDataArr)
					{
						if (!(item4.GetClass() != UClass.GetClass<UAnimMontage>()))
						{
							FName assetName = item4.AssetName;
							if (assetName.ToString() == item3)
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						Output = Output + "缺少动画" + item3 + "（不符合对应体型对应攻击者所在区域所约定的规范，参见通用动画列表.xlsx）!\n";
					}
				}
			}
			else
			{
				if (bCheckBasicRuleOnly)
				{
					continue;
				}
				string text = "";
				string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
				foreach (string item5 in list4)
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						text = $"AM_{unitResName}_bh_dep{BeAttackedInfoIDStr}_sl{stiffLevelID}_d{item5}_h{text2}";
						bool flag3 = false;
						foreach (FAssetData item6 in Assets.AssetDataArr)
						{
							if (!(item6.GetClass() != UClass.GetClass<UAnimMontage>()))
							{
								FName assetName2 = item6.AssetName;
								if (assetName2.ToString() == text)
								{
									flag3 = true;
								}
							}
						}
						if (!flag3)
						{
							Output = Output + "缺少动画" + text + "!\n";
						}
					}
				}
			}
		}
	}

	private static void ProcessBeAttacked2ResourcesForHugeBody(BGWDataAsset_UnitBeAttackedConfig Config, ref string Output, string BeAttackedInfoIDStr, UAssetDataArray Assets, bool bCheckBasicRuleOnly)
	{
		List<int> list = new List<int>();
		list.Add(1);
		list.Add(2);
		string unitResName = Config.UnitResName;
		List<int> list2 = new List<int>();
		foreach (FNormalStiffInfo normalStiffInfo in Config.NormalStiffInfoList)
		{
			list2.Add(normalStiffInfo.StiffLevelID);
		}
		bool flag = false;
		foreach (int item in list)
		{
			if (!list2.Contains(item))
			{
				flag = true;
			}
		}
		if (flag)
		{
			Output += "档位ID配置不符合规范，至少应包含";
			foreach (int item2 in list)
			{
				Output = Output + item2 + ",";
			}
			Output += "档位（参见通用动画列表.xlsx）！\n";
		}
		foreach (FNormalStiffInfo normalStiffInfo2 in Config.NormalStiffInfoList)
		{
			int stiffLevelID = normalStiffInfo2.StiffLevelID;
			List<string> list3 = new List<string>();
			List<string> list4 = new List<string>();
			switch (normalStiffInfo2.SectorsType)
			{
			case ENormalStiffSectorsType.AllForward:
				list4.Add("f");
				break;
			case ENormalStiffSectorsType.ForwardAndBackward:
				list4.Add("f");
				list4.Add("b");
				break;
			case ENormalStiffSectorsType.FourDir:
				switch (stiffLevelID)
				{
				case 1:
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_df_hf");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_dl_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_dr_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl1_db_hb");
					break;
				case 2:
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_df_hf");
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_dl_hl");
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_dr_hr");
					list3.Add($"AM_{unitResName}_bh_dep01_sl2_db_hb");
					break;
				default:
					list4.Add("f");
					list4.Add("b");
					list4.Add("l");
					list4.Add("r");
					break;
				}
				break;
			}
			if (list3.Count > 0)
			{
				foreach (string item3 in list3)
				{
					bool flag2 = false;
					foreach (FAssetData item4 in Assets.AssetDataArr)
					{
						if (!(item4.GetClass() != UClass.GetClass<UAnimMontage>()))
						{
							FName assetName = item4.AssetName;
							if (assetName.ToString() == item3)
							{
								flag2 = true;
							}
						}
					}
					if (!flag2)
					{
						Output = Output + "缺少动画" + item3 + "（不符合对应体型对应攻击者所在区域所约定的规范，参见通用动画列表.xlsx）!\n";
					}
				}
			}
			else
			{
				if (bCheckBasicRuleOnly)
				{
					continue;
				}
				string text = "";
				string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
				foreach (string item5 in list4)
				{
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						text = $"AM_{unitResName}_bh_dep{BeAttackedInfoIDStr}_sl{stiffLevelID}_d{item5}_h{text2}";
						bool flag3 = false;
						foreach (FAssetData item6 in Assets.AssetDataArr)
						{
							if (!(item6.GetClass() != UClass.GetClass<UAnimMontage>()))
							{
								FName assetName2 = item6.AssetName;
								if (assetName2.ToString() == text)
								{
									flag3 = true;
								}
							}
						}
						if (!flag3)
						{
							Output = Output + "缺少动画" + text + "!\n";
						}
					}
				}
			}
		}
	}

	public static FVector BGW_VectorRotationByAngle2D(int Params, FVector ForwardVector)
	{
		float value = (float)Params * (float)Math.PI / 180f;
		return new FVector(ForwardVector.X * FMath.Cos(value) + ForwardVector.Y * FMath.Sin(value), (0f - ForwardVector.X) * FMath.Sin(value) + ForwardVector.Y * FMath.Cos(value), 0.0);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BindNormalStiffAMInUBAC")]
	public static void BindNormalStiffAMInUBAC(BGWDataAsset_UnitBeAttackedConfig UBAC)
	{
		if (UBAC == null)
		{
			return;
		}
		UAssetDataArray assetsInFolder = UGSE_AssetUtilFuncLib.GetAssetsInFolder(new FName(UBAC.NormalStiffAMPath), bRecursive: true);
		if (!(assetsInFolder != null))
		{
			return;
		}
		List<UObject> list = UGSE_AssetUtilFuncLib.LoadObjectsFromAssetData(assetsInFolder);
		List<UAnimMontage> list2 = new List<UAnimMontage>();
		bool flag = false;
		foreach (UObject item in list)
		{
			UAnimMontage uAnimMontage = item as UAnimMontage;
			if (uAnimMontage != null && uAnimMontage.GetPathName().Contains("_bh"))
			{
				list2.Add(uAnimMontage);
				flag = true;
			}
		}
		if (!flag || list2.Count <= 0)
		{
			return;
		}
		UBAC.NormalStiffAMList.Clear();
		foreach (UAnimMontage item2 in list2)
		{
			UBAC.NormalStiffAMList.Add(item2);
		}
		UBAC.MarkPackageDirty();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BindDeathDispAMInUDDC")]
	public static void BindDeathDispAMInUDDC(BGWDataAsset_UnitDeathDispConfig UDDC)
	{
		if (UDDC == null)
		{
			return;
		}
		UAssetDataArray assetsInFolder = UGSE_AssetUtilFuncLib.GetAssetsInFolder(new FName(UDDC.NormalDeadAMPath), bRecursive: true);
		if (!(assetsInFolder != null))
		{
			return;
		}
		List<UObject> list = UGSE_AssetUtilFuncLib.LoadObjectsFromAssetData(assetsInFolder);
		List<UAnimMontage> list2 = new List<UAnimMontage>();
		bool flag = false;
		foreach (UObject item in list)
		{
			UAnimMontage uAnimMontage = item as UAnimMontage;
			if (uAnimMontage != null && uAnimMontage.GetPathName().Contains("_die"))
			{
				list2.Add(uAnimMontage);
				flag = true;
			}
		}
		if (!flag || list2.Count <= 0)
		{
			return;
		}
		UDDC.NormalDeadAMList.Clear();
		foreach (UAnimMontage item2 in list2)
		{
			UDDC.NormalDeadAMList.Add(item2);
		}
		UDDC.MarkPackageDirty();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:TestCode")]
	public static string TestCode()
	{
		string text = "";
		UAssetDataArray assetsInFolder = UGSE_AssetUtilFuncLib.GetAssetsInFolder(new FName("/Game/00MainHZ/Characters"), bRecursive: true);
		List<string> list = new List<string>();
		if (assetsInFolder != null)
		{
			foreach (FAssetData item in assetsInFolder.AssetDataArr)
			{
				FName assetClass = item.AssetClass;
				if (assetClass.ToString() == "BGWDataAsset_AbpHumanoidSetting")
				{
					assetClass = item.ObjectPath;
					list.Add(assetClass.ToString());
				}
			}
			foreach (UObject item2 in UGSE_AssetUtilFuncLib.LoadObjectsFromAssetData(UGSE_AssetUtilFuncLib.GetAssetsByPath(list)))
			{
				BGWDataAsset_AbpHumanoidSetting bGWDataAsset_AbpHumanoidSetting = item2 as BGWDataAsset_AbpHumanoidSetting;
				if (bGWDataAsset_AbpHumanoidSetting != null)
				{
					text += bGWDataAsset_AbpHumanoidSetting.GetName();
					text += "\t";
					text += bGWDataAsset_AbpHumanoidSetting.CommonSetting.ABPMoveMode;
					text += "\n";
				}
			}
		}
		return text.ToString();
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUGetLeftFootHeightByFootStepConfig")]
	public static float BGUGetLeftFootHeightByFootStepConfig(int ResID, USkeletalMeshComponent Mesh)
	{
		if (Mesh == null)
		{
			return 0f;
		}
		LoadProtobufData<FUStUnitCommDesc>();
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(ResID);
		if (unitCommDesc == null)
		{
			return 0f;
		}
		return UGSE_SkeletalMeshFuncLib.GetRefPoseTransform(Mesh, Mesh.GetBoneIndex(new FName(unitCommDesc.LeftFootBone)), bIsLocal: false).Translation.Z;
	}

	[Category("BGU|NoneRuntime")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSetUpDefaultFootstepAudio")]
	public static bool BGUSetUpDefaultFootstepAudio(BUTamerActor TamerActor, ref FSoftObjectPath AudioPath)
	{
		if (TamerActor == null)
		{
			return false;
		}
		BUS_ExtendConfigComp componentByClass = TamerActor.GetComponentByClass<BUS_ExtendConfigComp>();
		if (componentByClass != null)
		{
			FSoftObjectPath stepAudioPath = componentByClass.StepAudioPath;
			if (stepAudioPath.IsValid && stepAudioPath.TryLoad() != null)
			{
				return false;
			}
			componentByClass.StepAudioPath = AudioPath;
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc")]
	public static void BGUMigrateDataFromUnitCommDesc(string BlameName)
	{
		Dictionary<int, FUStUnitCommDesc> allUnitCommDesc = BGW_GameDB.GetAllUnitCommDesc();
		Dictionary<int, FUStUnitBattleInfoExtendDesc> allUnitBattleInfoExtendDesc = BGW_GameDB.GetAllUnitBattleInfoExtendDesc();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item in allUnitBattleInfoExtendDesc)
		{
			_ = item;
		}
		Dictionary<int, FUStUnitBattleInfoExtendDesc> dictionary = new Dictionary<int, FUStUnitBattleInfoExtendDesc>();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item2 in allUnitBattleInfoExtendDesc)
		{
			string blameByID = BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetBlameByID(item2.Key);
			if (BlameName == blameByID)
			{
				dictionary.Add(item2.Key, item2.Value);
			}
		}
		Dictionary<int, CachedInfo> dictionary2 = new Dictionary<int, CachedInfo>();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item3 in dictionary)
		{
			int key = item3.Key / 100;
			if (allUnitCommDesc.ContainsKey(key))
			{
				dictionary2.Add(value: new CachedInfo
				{
					ID = item3.Key
				}, key: item3.Key);
			}
		}
		JsonMapper.ToJson(dictionary2.ToList());
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|NoneRuntime")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc_OverrideData")]
	public static void BGUMigrateDataFromUnitCommDesc_OverrideData(string BlameName)
	{
		Dictionary<int, FUStUnitCommDesc> allUnitCommDesc = BGW_GameDB.GetAllUnitCommDesc();
		Dictionary<int, FUStUnitBattleInfoExtendDesc> allUnitBattleInfoExtendDesc = BGW_GameDB.GetAllUnitBattleInfoExtendDesc();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item in allUnitBattleInfoExtendDesc)
		{
			_ = item;
		}
		Dictionary<int, FUStUnitBattleInfoExtendDesc> dictionary = new Dictionary<int, FUStUnitBattleInfoExtendDesc>();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item2 in allUnitBattleInfoExtendDesc)
		{
			string blameByID = BG_ProtobufDataAPI<FUStUnitBattleInfoExtendDesc>.Get().GetBlameByID(item2.Key);
			if (BlameName == blameByID)
			{
				dictionary.Add(item2.Key, item2.Value);
			}
		}
		Dictionary<int, OverrideCachedInfo> dictionary2 = new Dictionary<int, OverrideCachedInfo>();
		foreach (KeyValuePair<int, FUStUnitBattleInfoExtendDesc> item3 in dictionary)
		{
			int key = item3.Key / 100;
			if (allUnitCommDesc.ContainsKey(key))
			{
				dictionary2.Add(value: new OverrideCachedInfo
				{
					ID = item3.Key
				}, key: item3.Key);
			}
		}
		JsonMapper.ToJson(dictionary2.ToList());
	}

	[BlueprintCallable]
	[Category("BGU|NoneRuntime")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromSkillEffectDesc")]
	public static void BGUMigrateDataFromSkillEffectDesc(string BlameName)
	{
		Dictionary<int, FUStSkillEffectDesc> allSkillEffectDesc = BGW_GameDB.GetAllSkillEffectDesc();
		Dictionary<int, SkillEffectArmorHitConfig> dictionary = new Dictionary<int, SkillEffectArmorHitConfig>();
		foreach (KeyValuePair<int, string> allBlame in BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetAllBlames())
		{
			_ = allBlame;
		}
		new Dictionary<int, int>
		{
			{ 2001, 1 },
			{ 2002, 10 },
			{ 2003, 50 },
			{ 2004, 100 },
			{ 2005, 500 },
			{ 2006, 10000 }
		};
		new Dictionary<int, float>
		{
			{ 2051, 0.1f },
			{ 2052, 10f },
			{ 2053, 50f },
			{ 2054, 100f },
			{ 2055, 500f },
			{ 2026, 1000f }
		};
		foreach (KeyValuePair<int, FUStSkillEffectDesc> item in allSkillEffectDesc)
		{
			string blameByID = BG_ProtobufDataAPI<FUStSkillEffectDesc>.Get().GetBlameByID(item.Key);
			FUStSkillEffectDesc value = item.Value;
			if (blameByID == BlameName && value.EffectType == EBuffAndSkillEffectType.SkillDamage && (value.EffectParamsStr.Count == 0 || value.EffectParamsStr[0] == ""))
			{
				dictionary.Add(value: new SkillEffectArmorHitConfig
				{
					ID = item.Key,
					HitValue = value.EffectParamsFloat[0]
				}, key: item.Key);
			}
		}
	}

	public static int BGUEditorGetLevelIdByPath(string LevelName)
	{
		return -1;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInWorld")]
	public static void BGUEditorRecordSubLevelsInWorld(UObject WorldContext, string RecordFilePath)
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInLevelPackage")]
	public static void BGUEditorRecordSubLevelsInLevelPackage(string LevelAsset, string RecordFilePath)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSerializeActorTransformsToJson")]
	public static void BGUSerializeActorTransformsToJson(string JsonPath, List<AActor> Actors)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUDeserializeActorTransformsFromJson")]
	public static void BGUDeserializeActorTransformsFromJson(string JsonPath, in List<AActor> ActorsToDeserialize)
	{
	}

	static BGUFuncLibNonRuntime()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibNonRuntime)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibNonRuntime));
		FootPostAnimNotifyTrackName = B1GlobalFNames.FootPos;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetCDO")]
	private static void GetCDO__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAssetDataArray assets = UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(buffer, GetCDO_Assets_Offset));
		UObject cDO = GetCDO(assets);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetCDO_ReturnValue_Offset), cDO);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:TestCode")]
	private static void TestCode__Invoker(IntPtr buffer, IntPtr obj)
	{
		string value = TestCode();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, TestCode_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:SkillSVaild")]
	private static void SkillSVaild__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SkillSVaild_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SkillSVaild_SkillID_Offset));
		bool value = SkillSVaild(unit, skillID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SkillSVaild_ReturnValue_Offset), 0, SkillSVaild_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUIsFileExist")]
	private static void BGUIsFileExist__Invoker(IntPtr buffer, IntPtr obj)
	{
		string pathWithGameHead = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUIsFileExist_PathWithGameHead_Offset));
		string fullPath;
		bool value = BGUIsFileExist(pathWithGameHead, out fullPath);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUIsFileExist_ReturnValue_Offset), 0, BGUIsFileExist_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, BGUIsFileExist_fullPath_Offset), fullPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBuffRemove")]
	private static void CheckBuffRemove__Invoker(IntPtr buffer, IntPtr obj)
	{
		CheckBuffRemove();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:ScanCBGTemplate")]
	private static void ScanCBGTemplate__Invoker(IntPtr buffer, IntPtr obj)
	{
		ScanCBGTemplate();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUCopyABPSetting")]
	private static void BGUCopyABPSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_AbpHumanoidSetting src = UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(buffer, BGUCopyABPSetting_Src_Offset));
		BGWDataAsset_AbpHumanoidSetting dest = UObjectMarshaler<BGWDataAsset_AbpHumanoidSetting>.FromNative(IntPtr.Add(buffer, BGUCopyABPSetting_Dest_Offset));
		BGUCopyABPSetting(src, dest);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromAsset")]
	private static void GetResIDFromAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<UShapeComponent> tArrayCopyMarshaler = new TArrayCopyMarshaler<UShapeComponent>(1, GetResIDFromAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.FromNative, CachedMarshalingDelegates<UShapeComponent, UObjectMarshaler<UShapeComponent>>.ToNative);
		UAssetDataArray assets = UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(buffer, GetResIDFromAsset_Assets_Offset));
		List<UShapeComponent> resIDFromAsset = GetResIDFromAsset(assets);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetResIDFromAsset_ReturnValue_Offset), resIDFromAsset);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:ProjectileSpawnTest")]
	private static void ProjectileSpawnTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor spawnner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProjectileSpawnTest_Spawnner_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProjectileSpawnTest_Target_Offset));
		BGWDataAsset_ProjectileSpawnConfig projectileSpawnConfig = UObjectMarshaler<BGWDataAsset_ProjectileSpawnConfig>.FromNative(IntPtr.Add(buffer, ProjectileSpawnTest_ProjectileSpawnConfig_Offset));
		ProjectileSpawnTest(spawnner, target, projectileSpawnConfig);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckHitMoveCapsules")]
	private static void CheckHitMoveCapsules__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CheckHitMoveCapsules_WorldContext_Offset));
		string value = CheckHitMoveCapsules(worldContext);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CheckHitMoveCapsules_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromUnitAsset")]
	private static void GetResIDFromUnitAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAssetDataArray assets = UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(buffer, GetResIDFromUnitAsset_Assets_Offset));
		int resIDFromUnitAsset = GetResIDFromUnitAsset(assets);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetResIDFromUnitAsset_ReturnValue_Offset), resIDFromUnitAsset);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BindDeathDispAMInUDDC")]
	private static void BindDeathDispAMInUDDC__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_UnitDeathDispConfig uDDC = UObjectMarshaler<BGWDataAsset_UnitDeathDispConfig>.FromNative(IntPtr.Add(buffer, BindDeathDispAMInUDDC_UDDC_Offset));
		BindDeathDispAMInUDDC(uDDC);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllProjectileBPPath")]
	private static void GetAllProjectileBPPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, GetAllProjectileBPPath_PathList_Exist_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> PathList_Exist = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetAllProjectileBPPath_PathList_Exist_Offset));
		GetAllProjectileBPPath(out PathList_Exist);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllProjectileBPPath_PathList_Exist_Offset), PathList_Exist);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:SetActorCompEditorOnly")]
	private static void SetActorCompEditorOnly__Invoker(IntPtr buffer, IntPtr obj)
	{
		UActorComponent actorComp = UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(buffer, SetActorCompEditorOnly_ActorComp_Offset));
		bool bIsEditorOnly = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetActorCompEditorOnly_bIsEditorOnly_Offset), 0, SetActorCompEditorOnly_bIsEditorOnly_PropertyAddress.Address);
		SetActorCompEditorOnly(actorComp, bIsEditorOnly);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BindNormalStiffAMInUBAC")]
	private static void BindNormalStiffAMInUBAC__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_UnitBeAttackedConfig uBAC = UObjectMarshaler<BGWDataAsset_UnitBeAttackedConfig>.FromNative(IntPtr.Add(buffer, BindNormalStiffAMInUBAC_UBAC_Offset));
		BindNormalStiffAMInUBAC(uBAC);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootLockCurve")]
	private static void BGUAutoAddFootLockCurve__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimSequence animSequence = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_AnimSequence_Offset));
		FName LeftFootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_LeftFootBoneName_Offset));
		FName RightFootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_RightFootBoneName_Offset));
		float footLockHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_FootLockHeight_Offset));
		float footUnlockHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_FootUnlockHeight_Offset));
		float footLockSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_FootLockSpeed_Offset));
		float footUnlockSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_FootUnlockSpeed_Offset));
		BGUAutoAddFootLockCurve(animSequence, in LeftFootBoneName, in RightFootBoneName, footLockHeight, footUnlockHeight, footLockSpeed, footUnlockSpeed);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_LeftFootBoneName_Offset), LeftFootBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, BGUAutoAddFootLockCurve_RightFootBoneName_Offset), RightFootBoneName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetOriFilePathByAssetPath")]
	private static void GetOriFilePathByAssetPath__Invoker(IntPtr buffer, IntPtr obj)
	{
		string assetPathName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetOriFilePathByAssetPath_AssetPathName_Offset));
		string assetName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetOriFilePathByAssetPath_AssetName_Offset));
		string oriFilePathByAssetPath = GetOriFilePathByAssetPath(assetPathName, assetName);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetOriFilePathByAssetPath_ReturnValue_Offset), oriFilePathByAssetPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:UpdateHitAudioPreloadList")]
	private static void UpdateHitAudioPreloadList__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, UpdateHitAudioPreloadList_PathList_Exist_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> PathList_Exist = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, UpdateHitAudioPreloadList_PathList_Exist_Offset));
		int value = UpdateHitAudioPreloadList(out PathList_Exist);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, UpdateHitAudioPreloadList_ReturnValue_Offset), value);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, UpdateHitAudioPreloadList_PathList_Exist_Offset), PathList_Exist);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBeAttacked2Resources")]
	private static void CheckBeAttacked2Resources__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool bCheckBasicRuleOnly = BoolMarshaler.FromNative(IntPtr.Add(buffer, CheckBeAttacked2Resources_bCheckBasicRuleOnly_Offset), 0, CheckBeAttacked2Resources_bCheckBasicRuleOnly_PropertyAddress.Address);
		string value = CheckBeAttacked2Resources(bCheckBasicRuleOnly);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CheckBeAttacked2Resources_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllSummonBPPathFromDesc")]
	private static void GetAllSummonBPPathFromDesc__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, GetAllSummonBPPathFromDesc_CurrentUsedBPPath_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> CurrentUsedBPPath = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetAllSummonBPPathFromDesc_CurrentUsedBPPath_Offset));
		GetAllSummonBPPathFromDesc(out CurrentUsedBPPath);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllSummonBPPathFromDesc_CurrentUsedBPPath_Offset), CurrentUsedBPPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckUnitCapsuleCollisions")]
	private static void CheckUnitCapsuleCollisions__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CheckUnitCapsuleCollisions_WorldContext_Offset));
		string value = CheckUnitCapsuleCollisions(worldContext);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CheckUnitCapsuleCollisions_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSimpleState")]
	private static void Analysis_BuffUseSimpleState__Invoker(IntPtr buffer, IntPtr obj)
	{
		Analysis_BuffUseSimpleState();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSetUpDefaultFootstepAudio")]
	private static void BGUSetUpDefaultFootstepAudio__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tamerActor = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, BGUSetUpDefaultFootstepAudio_TamerActor_Offset));
		FSoftObjectPath AudioPath = FSoftObjectPath.FromNative(IntPtr.Add(buffer, BGUSetUpDefaultFootstepAudio_AudioPath_Offset));
		bool value = BGUSetUpDefaultFootstepAudio(tamerActor, ref AudioPath);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUSetUpDefaultFootstepAudio_ReturnValue_Offset), 0, BGUSetUpDefaultFootstepAudio_ReturnValue_PropertyAddress.Address, value);
		FSoftObjectPath.ToNative(IntPtr.Add(buffer, BGUSetUpDefaultFootstepAudio_AudioPath_Offset), AudioPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:GetTemplateClassFromUnitAsset")]
	private static void GetTemplateClassFromUnitAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAssetDataArray assets = UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(buffer, GetTemplateClassFromUnitAsset_Assets_Offset));
		TSubclassOf<BGUCharacterCS> templateClassFromUnitAsset = GetTemplateClassFromUnitAsset(assets);
		TSubclassOfMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(buffer, GetTemplateClassFromUnitAsset_ReturnValue_Offset), templateClassFromUnitAsset);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc")]
	private static void BGUMigrateDataFromUnitCommDesc__Invoker(IntPtr buffer, IntPtr obj)
	{
		string blameName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUMigrateDataFromUnitCommDesc_BlameName_Offset));
		BGUMigrateDataFromUnitCommDesc(blameName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAddNofityStateByPelvisSpeed")]
	private static void BGUAddNofityStateByPelvisSpeed__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_AnimMontage_Offset));
		float speedThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_SpeedThreshold_Offset));
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_BuffID_Offset));
		TSubclassOf<UAnimNotifyState> newNotifyStateClass = TSubclassOfMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_Offset));
		bool firstRemoveAddBuffID = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_Offset), 0, BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_PropertyAddress.Address);
		string socketName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_SocketName_Offset));
		float tickTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddNofityStateByPelvisSpeed_TickTime_Offset));
		BGUAddNofityStateByPelvisSpeed(animMontage, speedThreshold, buffID, newNotifyStateClass, firstRemoveAddBuffID, socketName, tickTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInWorld")]
	private static void BGUEditorRecordSubLevelsInWorld__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUEditorRecordSubLevelsInWorld_WorldContext_Offset));
		string recordFilePath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUEditorRecordSubLevelsInWorld_RecordFilePath_Offset));
		BGUEditorRecordSubLevelsInWorld(worldContext, recordFilePath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:AddMagicallyChangeFadeOutNotify")]
	private static void AddMagicallyChangeFadeOutNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimMontage montage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, AddMagicallyChangeFadeOutNotify_Montage_Offset));
		AddMagicallyChangeFadeOutNotify(montage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSpecialHitPartID")]
	private static void Analysis_BuffUseSpecialHitPartID__Invoker(IntPtr buffer, IntPtr obj)
	{
		Analysis_BuffUseSpecialHitPartID();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSerializeActorTransformsToJson")]
	private static void BGUSerializeActorTransformsToJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		string jsonPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSerializeActorTransformsToJson_JsonPath_Offset));
		List<AActor> actors = new TArrayCopyMarshaler<AActor>(1, BGUSerializeActorTransformsToJson_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(buffer, BGUSerializeActorTransformsToJson_Actors_Offset));
		BGUSerializeActorTransformsToJson(jsonPath, actors);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromSkillEffectDesc")]
	private static void BGUMigrateDataFromSkillEffectDesc__Invoker(IntPtr buffer, IntPtr obj)
	{
		string blameName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUMigrateDataFromSkillEffectDesc_BlameName_Offset));
		BGUMigrateDataFromSkillEffectDesc(blameName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUGetLeftFootHeightByFootStepConfig")]
	private static void BGUGetLeftFootHeightByFootStepConfig__Invoker(IntPtr buffer, IntPtr obj)
	{
		int resID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUGetLeftFootHeightByFootStepConfig_ResID_Offset));
		USkeletalMeshComponent mesh = UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(buffer, BGUGetLeftFootHeightByFootStepConfig_Mesh_Offset));
		float value = BGUGetLeftFootHeightByFootStepConfig(resID, mesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BGUGetLeftFootHeightByFootStepConfig_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUDeserializeActorTransformsFromJson")]
	private static void BGUDeserializeActorTransformsFromJson__Invoker(IntPtr buffer, IntPtr obj)
	{
		string jsonPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUDeserializeActorTransformsFromJson_JsonPath_Offset));
		TArrayCopyMarshaler<AActor> tArrayCopyMarshaler = new TArrayCopyMarshaler<AActor>(1, BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
		List<AActor> ActorsToDeserialize = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_Offset));
		BGUDeserializeActorTransformsFromJson(jsonPath, in ActorsToDeserialize);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_Offset), ActorsToDeserialize);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootSyncMarkerToAnimSequence")]
	private static void BGUAutoAddFootSyncMarkerToAnimSequence__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimSequence animSequence = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_Offset));
		FName LeftFootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_Offset));
		FName RightFootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_Offset));
		float groundFootLimitHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_Offset));
		bool value = BGUAutoAddFootSyncMarkerToAnimSequence(animSequence, in LeftFootBoneName, in RightFootBoneName, groundFootLimitHeight);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_Offset), 0, BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_PropertyAddress.Address, value);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_Offset), LeftFootBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(buffer, BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_Offset), RightFootBoneName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInLevelPackage")]
	private static void BGUEditorRecordSubLevelsInLevelPackage__Invoker(IntPtr buffer, IntPtr obj)
	{
		string levelAsset = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_Offset));
		string recordFilePath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_Offset));
		BGUEditorRecordSubLevelsInLevelPackage(levelAsset, recordFilePath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc_OverrideData")]
	private static void BGUMigrateDataFromUnitCommDesc_OverrideData__Invoker(IntPtr buffer, IntPtr obj)
	{
		string blameName = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_Offset));
		BGUMigrateDataFromUnitCommDesc_OverrideData(blameName);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibNonRuntime");
		GetCDO_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCDO");
		GetCDO_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCDO_FunctionAddress);
		GetCDO_Assets_Offset = NativeReflection.GetPropertyOffset(GetCDO_FunctionAddress, "Assets");
		GetCDO_Assets_IsValid = NativeReflection.ValidatePropertyClass(GetCDO_FunctionAddress, "Assets", Classes.FObjectProperty);
		GetCDO_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCDO_FunctionAddress, "ReturnValue");
		GetCDO_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCDO_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCDO_IsValid = GetCDO_FunctionAddress != IntPtr.Zero && GetCDO_Assets_IsValid && GetCDO_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetCDO", GetCDO_IsValid);
		TestCode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestCode");
		TestCode_ParamsSize = NativeReflection.GetFunctionParamsSize(TestCode_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TestCode_ReturnValue_PropertyAddress, TestCode_FunctionAddress, "ReturnValue");
		TestCode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TestCode_FunctionAddress, "ReturnValue");
		TestCode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TestCode_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		TestCode_IsValid = TestCode_FunctionAddress != IntPtr.Zero && TestCode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:TestCode", TestCode_IsValid);
		SkillSVaild_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SkillSVaild");
		SkillSVaild_ParamsSize = NativeReflection.GetFunctionParamsSize(SkillSVaild_FunctionAddress);
		SkillSVaild_Unit_Offset = NativeReflection.GetPropertyOffset(SkillSVaild_FunctionAddress, "Unit");
		SkillSVaild_Unit_IsValid = NativeReflection.ValidatePropertyClass(SkillSVaild_FunctionAddress, "Unit", Classes.FObjectProperty);
		SkillSVaild_SkillID_Offset = NativeReflection.GetPropertyOffset(SkillSVaild_FunctionAddress, "SkillID");
		SkillSVaild_SkillID_IsValid = NativeReflection.ValidatePropertyClass(SkillSVaild_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SkillSVaild_ReturnValue_PropertyAddress, SkillSVaild_FunctionAddress, "ReturnValue");
		SkillSVaild_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SkillSVaild_FunctionAddress, "ReturnValue");
		SkillSVaild_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SkillSVaild_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SkillSVaild_IsValid = SkillSVaild_FunctionAddress != IntPtr.Zero && SkillSVaild_Unit_IsValid && SkillSVaild_SkillID_IsValid && SkillSVaild_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:SkillSVaild", SkillSVaild_IsValid);
		BGUIsFileExist_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUIsFileExist");
		BGUIsFileExist_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsFileExist_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUIsFileExist_PathWithGameHead_PropertyAddress, BGUIsFileExist_FunctionAddress, "PathWithGameHead");
		BGUIsFileExist_PathWithGameHead_Offset = NativeReflection.GetPropertyOffset(BGUIsFileExist_FunctionAddress, "PathWithGameHead");
		BGUIsFileExist_PathWithGameHead_IsValid = NativeReflection.ValidatePropertyClass(BGUIsFileExist_FunctionAddress, "PathWithGameHead", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUIsFileExist_fullPath_PropertyAddress, BGUIsFileExist_FunctionAddress, "fullPath");
		BGUIsFileExist_fullPath_Offset = NativeReflection.GetPropertyOffset(BGUIsFileExist_FunctionAddress, "fullPath");
		BGUIsFileExist_fullPath_IsValid = NativeReflection.ValidatePropertyClass(BGUIsFileExist_FunctionAddress, "fullPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUIsFileExist_ReturnValue_PropertyAddress, BGUIsFileExist_FunctionAddress, "ReturnValue");
		BGUIsFileExist_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUIsFileExist_FunctionAddress, "ReturnValue");
		BGUIsFileExist_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUIsFileExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsFileExist_IsValid = BGUIsFileExist_FunctionAddress != IntPtr.Zero && BGUIsFileExist_PathWithGameHead_IsValid && BGUIsFileExist_fullPath_IsValid && BGUIsFileExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUIsFileExist", BGUIsFileExist_IsValid);
		CheckBuffRemove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckBuffRemove");
		CheckBuffRemove_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBuffRemove_FunctionAddress);
		CheckBuffRemove_IsValid = CheckBuffRemove_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBuffRemove", CheckBuffRemove_IsValid);
		ScanCBGTemplate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScanCBGTemplate");
		ScanCBGTemplate_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanCBGTemplate_FunctionAddress);
		ScanCBGTemplate_IsValid = ScanCBGTemplate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:ScanCBGTemplate", ScanCBGTemplate_IsValid);
		BGUCopyABPSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCopyABPSetting");
		BGUCopyABPSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCopyABPSetting_FunctionAddress);
		BGUCopyABPSetting_Src_Offset = NativeReflection.GetPropertyOffset(BGUCopyABPSetting_FunctionAddress, "Src");
		BGUCopyABPSetting_Src_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyABPSetting_FunctionAddress, "Src", Classes.FObjectProperty);
		BGUCopyABPSetting_Dest_Offset = NativeReflection.GetPropertyOffset(BGUCopyABPSetting_FunctionAddress, "Dest");
		BGUCopyABPSetting_Dest_IsValid = NativeReflection.ValidatePropertyClass(BGUCopyABPSetting_FunctionAddress, "Dest", Classes.FObjectProperty);
		BGUCopyABPSetting_IsValid = BGUCopyABPSetting_FunctionAddress != IntPtr.Zero && BGUCopyABPSetting_Src_IsValid && BGUCopyABPSetting_Dest_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUCopyABPSetting", BGUCopyABPSetting_IsValid);
		GetResIDFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetResIDFromAsset");
		GetResIDFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetResIDFromAsset_FunctionAddress);
		GetResIDFromAsset_Assets_Offset = NativeReflection.GetPropertyOffset(GetResIDFromAsset_FunctionAddress, "Assets");
		GetResIDFromAsset_Assets_IsValid = NativeReflection.ValidatePropertyClass(GetResIDFromAsset_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetResIDFromAsset_ReturnValue_PropertyAddress, GetResIDFromAsset_FunctionAddress, "ReturnValue");
		GetResIDFromAsset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetResIDFromAsset_FunctionAddress, "ReturnValue");
		GetResIDFromAsset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetResIDFromAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetResIDFromAsset_IsValid = GetResIDFromAsset_FunctionAddress != IntPtr.Zero && GetResIDFromAsset_Assets_IsValid && GetResIDFromAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromAsset", GetResIDFromAsset_IsValid);
		ProjectileSpawnTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectileSpawnTest");
		ProjectileSpawnTest_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileSpawnTest_FunctionAddress);
		ProjectileSpawnTest_Spawnner_Offset = NativeReflection.GetPropertyOffset(ProjectileSpawnTest_FunctionAddress, "Spawnner");
		ProjectileSpawnTest_Spawnner_IsValid = NativeReflection.ValidatePropertyClass(ProjectileSpawnTest_FunctionAddress, "Spawnner", Classes.FObjectProperty);
		ProjectileSpawnTest_Target_Offset = NativeReflection.GetPropertyOffset(ProjectileSpawnTest_FunctionAddress, "Target");
		ProjectileSpawnTest_Target_IsValid = NativeReflection.ValidatePropertyClass(ProjectileSpawnTest_FunctionAddress, "Target", Classes.FObjectProperty);
		ProjectileSpawnTest_ProjectileSpawnConfig_Offset = NativeReflection.GetPropertyOffset(ProjectileSpawnTest_FunctionAddress, "ProjectileSpawnConfig");
		ProjectileSpawnTest_ProjectileSpawnConfig_IsValid = NativeReflection.ValidatePropertyClass(ProjectileSpawnTest_FunctionAddress, "ProjectileSpawnConfig", Classes.FObjectProperty);
		ProjectileSpawnTest_IsValid = ProjectileSpawnTest_FunctionAddress != IntPtr.Zero && ProjectileSpawnTest_Spawnner_IsValid && ProjectileSpawnTest_Target_IsValid && ProjectileSpawnTest_ProjectileSpawnConfig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:ProjectileSpawnTest", ProjectileSpawnTest_IsValid);
		CheckHitMoveCapsules_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckHitMoveCapsules");
		CheckHitMoveCapsules_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckHitMoveCapsules_FunctionAddress);
		CheckHitMoveCapsules_WorldContext_Offset = NativeReflection.GetPropertyOffset(CheckHitMoveCapsules_FunctionAddress, "WorldContext");
		CheckHitMoveCapsules_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CheckHitMoveCapsules_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CheckHitMoveCapsules_ReturnValue_PropertyAddress, CheckHitMoveCapsules_FunctionAddress, "ReturnValue");
		CheckHitMoveCapsules_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckHitMoveCapsules_FunctionAddress, "ReturnValue");
		CheckHitMoveCapsules_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckHitMoveCapsules_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CheckHitMoveCapsules_IsValid = CheckHitMoveCapsules_FunctionAddress != IntPtr.Zero && CheckHitMoveCapsules_WorldContext_IsValid && CheckHitMoveCapsules_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckHitMoveCapsules", CheckHitMoveCapsules_IsValid);
		GetResIDFromUnitAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetResIDFromUnitAsset");
		GetResIDFromUnitAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetResIDFromUnitAsset_FunctionAddress);
		GetResIDFromUnitAsset_Assets_Offset = NativeReflection.GetPropertyOffset(GetResIDFromUnitAsset_FunctionAddress, "Assets");
		GetResIDFromUnitAsset_Assets_IsValid = NativeReflection.ValidatePropertyClass(GetResIDFromUnitAsset_FunctionAddress, "Assets", Classes.FObjectProperty);
		GetResIDFromUnitAsset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetResIDFromUnitAsset_FunctionAddress, "ReturnValue");
		GetResIDFromUnitAsset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetResIDFromUnitAsset_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetResIDFromUnitAsset_IsValid = GetResIDFromUnitAsset_FunctionAddress != IntPtr.Zero && GetResIDFromUnitAsset_Assets_IsValid && GetResIDFromUnitAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetResIDFromUnitAsset", GetResIDFromUnitAsset_IsValid);
		BindDeathDispAMInUDDC_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindDeathDispAMInUDDC");
		BindDeathDispAMInUDDC_ParamsSize = NativeReflection.GetFunctionParamsSize(BindDeathDispAMInUDDC_FunctionAddress);
		BindDeathDispAMInUDDC_UDDC_Offset = NativeReflection.GetPropertyOffset(BindDeathDispAMInUDDC_FunctionAddress, "UDDC");
		BindDeathDispAMInUDDC_UDDC_IsValid = NativeReflection.ValidatePropertyClass(BindDeathDispAMInUDDC_FunctionAddress, "UDDC", Classes.FObjectProperty);
		BindDeathDispAMInUDDC_IsValid = BindDeathDispAMInUDDC_FunctionAddress != IntPtr.Zero && BindDeathDispAMInUDDC_UDDC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BindDeathDispAMInUDDC", BindDeathDispAMInUDDC_IsValid);
		GetAllProjectileBPPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllProjectileBPPath");
		GetAllProjectileBPPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllProjectileBPPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllProjectileBPPath_PathList_Exist_PropertyAddress, GetAllProjectileBPPath_FunctionAddress, "PathList_Exist");
		GetAllProjectileBPPath_PathList_Exist_Offset = NativeReflection.GetPropertyOffset(GetAllProjectileBPPath_FunctionAddress, "PathList_Exist");
		GetAllProjectileBPPath_PathList_Exist_IsValid = NativeReflection.ValidatePropertyClass(GetAllProjectileBPPath_FunctionAddress, "PathList_Exist", Classes.FArrayProperty);
		GetAllProjectileBPPath_IsValid = GetAllProjectileBPPath_FunctionAddress != IntPtr.Zero && GetAllProjectileBPPath_PathList_Exist_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllProjectileBPPath", GetAllProjectileBPPath_IsValid);
		SetActorCompEditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetActorCompEditorOnly");
		SetActorCompEditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorCompEditorOnly_FunctionAddress);
		SetActorCompEditorOnly_ActorComp_Offset = NativeReflection.GetPropertyOffset(SetActorCompEditorOnly_FunctionAddress, "ActorComp");
		SetActorCompEditorOnly_ActorComp_IsValid = NativeReflection.ValidatePropertyClass(SetActorCompEditorOnly_FunctionAddress, "ActorComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetActorCompEditorOnly_bIsEditorOnly_PropertyAddress, SetActorCompEditorOnly_FunctionAddress, "bIsEditorOnly");
		SetActorCompEditorOnly_bIsEditorOnly_Offset = NativeReflection.GetPropertyOffset(SetActorCompEditorOnly_FunctionAddress, "bIsEditorOnly");
		SetActorCompEditorOnly_bIsEditorOnly_IsValid = NativeReflection.ValidatePropertyClass(SetActorCompEditorOnly_FunctionAddress, "bIsEditorOnly", Classes.FBoolProperty);
		SetActorCompEditorOnly_IsValid = SetActorCompEditorOnly_FunctionAddress != IntPtr.Zero && SetActorCompEditorOnly_ActorComp_IsValid && SetActorCompEditorOnly_bIsEditorOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:SetActorCompEditorOnly", SetActorCompEditorOnly_IsValid);
		BindNormalStiffAMInUBAC_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindNormalStiffAMInUBAC");
		BindNormalStiffAMInUBAC_ParamsSize = NativeReflection.GetFunctionParamsSize(BindNormalStiffAMInUBAC_FunctionAddress);
		BindNormalStiffAMInUBAC_UBAC_Offset = NativeReflection.GetPropertyOffset(BindNormalStiffAMInUBAC_FunctionAddress, "UBAC");
		BindNormalStiffAMInUBAC_UBAC_IsValid = NativeReflection.ValidatePropertyClass(BindNormalStiffAMInUBAC_FunctionAddress, "UBAC", Classes.FObjectProperty);
		BindNormalStiffAMInUBAC_IsValid = BindNormalStiffAMInUBAC_FunctionAddress != IntPtr.Zero && BindNormalStiffAMInUBAC_UBAC_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BindNormalStiffAMInUBAC", BindNormalStiffAMInUBAC_IsValid);
		BGUAutoAddFootLockCurve_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAutoAddFootLockCurve");
		BGUAutoAddFootLockCurve_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAutoAddFootLockCurve_FunctionAddress);
		BGUAutoAddFootLockCurve_AnimSequence_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "AnimSequence");
		BGUAutoAddFootLockCurve_AnimSequence_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		BGUAutoAddFootLockCurve_LeftFootBoneName_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "LeftFootBoneName");
		BGUAutoAddFootLockCurve_LeftFootBoneName_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "LeftFootBoneName", Classes.FNameProperty);
		BGUAutoAddFootLockCurve_RightFootBoneName_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "RightFootBoneName");
		BGUAutoAddFootLockCurve_RightFootBoneName_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "RightFootBoneName", Classes.FNameProperty);
		BGUAutoAddFootLockCurve_FootLockHeight_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "FootLockHeight");
		BGUAutoAddFootLockCurve_FootLockHeight_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "FootLockHeight", Classes.FFloatProperty);
		BGUAutoAddFootLockCurve_FootUnlockHeight_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "FootUnlockHeight");
		BGUAutoAddFootLockCurve_FootUnlockHeight_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "FootUnlockHeight", Classes.FFloatProperty);
		BGUAutoAddFootLockCurve_FootLockSpeed_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "FootLockSpeed");
		BGUAutoAddFootLockCurve_FootLockSpeed_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "FootLockSpeed", Classes.FFloatProperty);
		BGUAutoAddFootLockCurve_FootUnlockSpeed_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootLockCurve_FunctionAddress, "FootUnlockSpeed");
		BGUAutoAddFootLockCurve_FootUnlockSpeed_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootLockCurve_FunctionAddress, "FootUnlockSpeed", Classes.FFloatProperty);
		BGUAutoAddFootLockCurve_IsValid = BGUAutoAddFootLockCurve_FunctionAddress != IntPtr.Zero && BGUAutoAddFootLockCurve_AnimSequence_IsValid && BGUAutoAddFootLockCurve_LeftFootBoneName_IsValid && BGUAutoAddFootLockCurve_RightFootBoneName_IsValid && BGUAutoAddFootLockCurve_FootLockHeight_IsValid && BGUAutoAddFootLockCurve_FootUnlockHeight_IsValid && BGUAutoAddFootLockCurve_FootLockSpeed_IsValid && BGUAutoAddFootLockCurve_FootUnlockSpeed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootLockCurve", BGUAutoAddFootLockCurve_IsValid);
		GetOriFilePathByAssetPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetOriFilePathByAssetPath");
		GetOriFilePathByAssetPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOriFilePathByAssetPath_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetOriFilePathByAssetPath_AssetPathName_PropertyAddress, GetOriFilePathByAssetPath_FunctionAddress, "AssetPathName");
		GetOriFilePathByAssetPath_AssetPathName_Offset = NativeReflection.GetPropertyOffset(GetOriFilePathByAssetPath_FunctionAddress, "AssetPathName");
		GetOriFilePathByAssetPath_AssetPathName_IsValid = NativeReflection.ValidatePropertyClass(GetOriFilePathByAssetPath_FunctionAddress, "AssetPathName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetOriFilePathByAssetPath_AssetName_PropertyAddress, GetOriFilePathByAssetPath_FunctionAddress, "AssetName");
		GetOriFilePathByAssetPath_AssetName_Offset = NativeReflection.GetPropertyOffset(GetOriFilePathByAssetPath_FunctionAddress, "AssetName");
		GetOriFilePathByAssetPath_AssetName_IsValid = NativeReflection.ValidatePropertyClass(GetOriFilePathByAssetPath_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetOriFilePathByAssetPath_ReturnValue_PropertyAddress, GetOriFilePathByAssetPath_FunctionAddress, "ReturnValue");
		GetOriFilePathByAssetPath_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetOriFilePathByAssetPath_FunctionAddress, "ReturnValue");
		GetOriFilePathByAssetPath_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetOriFilePathByAssetPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOriFilePathByAssetPath_IsValid = GetOriFilePathByAssetPath_FunctionAddress != IntPtr.Zero && GetOriFilePathByAssetPath_AssetPathName_IsValid && GetOriFilePathByAssetPath_AssetName_IsValid && GetOriFilePathByAssetPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetOriFilePathByAssetPath", GetOriFilePathByAssetPath_IsValid);
		UpdateHitAudioPreloadList_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateHitAudioPreloadList");
		UpdateHitAudioPreloadList_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateHitAudioPreloadList_FunctionAddress);
		NativeReflection.GetPropertyRef(ref UpdateHitAudioPreloadList_PathList_Exist_PropertyAddress, UpdateHitAudioPreloadList_FunctionAddress, "PathList_Exist");
		UpdateHitAudioPreloadList_PathList_Exist_Offset = NativeReflection.GetPropertyOffset(UpdateHitAudioPreloadList_FunctionAddress, "PathList_Exist");
		UpdateHitAudioPreloadList_PathList_Exist_IsValid = NativeReflection.ValidatePropertyClass(UpdateHitAudioPreloadList_FunctionAddress, "PathList_Exist", Classes.FArrayProperty);
		UpdateHitAudioPreloadList_ReturnValue_Offset = NativeReflection.GetPropertyOffset(UpdateHitAudioPreloadList_FunctionAddress, "ReturnValue");
		UpdateHitAudioPreloadList_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(UpdateHitAudioPreloadList_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		UpdateHitAudioPreloadList_IsValid = UpdateHitAudioPreloadList_FunctionAddress != IntPtr.Zero && UpdateHitAudioPreloadList_PathList_Exist_IsValid && UpdateHitAudioPreloadList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:UpdateHitAudioPreloadList", UpdateHitAudioPreloadList_IsValid);
		CheckBeAttacked2Resources_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckBeAttacked2Resources");
		CheckBeAttacked2Resources_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBeAttacked2Resources_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBeAttacked2Resources_bCheckBasicRuleOnly_PropertyAddress, CheckBeAttacked2Resources_FunctionAddress, "bCheckBasicRuleOnly");
		CheckBeAttacked2Resources_bCheckBasicRuleOnly_Offset = NativeReflection.GetPropertyOffset(CheckBeAttacked2Resources_FunctionAddress, "bCheckBasicRuleOnly");
		CheckBeAttacked2Resources_bCheckBasicRuleOnly_IsValid = NativeReflection.ValidatePropertyClass(CheckBeAttacked2Resources_FunctionAddress, "bCheckBasicRuleOnly", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CheckBeAttacked2Resources_ReturnValue_PropertyAddress, CheckBeAttacked2Resources_FunctionAddress, "ReturnValue");
		CheckBeAttacked2Resources_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckBeAttacked2Resources_FunctionAddress, "ReturnValue");
		CheckBeAttacked2Resources_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckBeAttacked2Resources_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CheckBeAttacked2Resources_IsValid = CheckBeAttacked2Resources_FunctionAddress != IntPtr.Zero && CheckBeAttacked2Resources_bCheckBasicRuleOnly_IsValid && CheckBeAttacked2Resources_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckBeAttacked2Resources", CheckBeAttacked2Resources_IsValid);
		GetAllSummonBPPathFromDesc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllSummonBPPathFromDesc");
		GetAllSummonBPPathFromDesc_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSummonBPPathFromDesc_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllSummonBPPathFromDesc_CurrentUsedBPPath_PropertyAddress, GetAllSummonBPPathFromDesc_FunctionAddress, "CurrentUsedBPPath");
		GetAllSummonBPPathFromDesc_CurrentUsedBPPath_Offset = NativeReflection.GetPropertyOffset(GetAllSummonBPPathFromDesc_FunctionAddress, "CurrentUsedBPPath");
		GetAllSummonBPPathFromDesc_CurrentUsedBPPath_IsValid = NativeReflection.ValidatePropertyClass(GetAllSummonBPPathFromDesc_FunctionAddress, "CurrentUsedBPPath", Classes.FArrayProperty);
		GetAllSummonBPPathFromDesc_IsValid = GetAllSummonBPPathFromDesc_FunctionAddress != IntPtr.Zero && GetAllSummonBPPathFromDesc_CurrentUsedBPPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetAllSummonBPPathFromDesc", GetAllSummonBPPathFromDesc_IsValid);
		CheckUnitCapsuleCollisions_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckUnitCapsuleCollisions");
		CheckUnitCapsuleCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckUnitCapsuleCollisions_FunctionAddress);
		CheckUnitCapsuleCollisions_WorldContext_Offset = NativeReflection.GetPropertyOffset(CheckUnitCapsuleCollisions_FunctionAddress, "WorldContext");
		CheckUnitCapsuleCollisions_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CheckUnitCapsuleCollisions_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CheckUnitCapsuleCollisions_ReturnValue_PropertyAddress, CheckUnitCapsuleCollisions_FunctionAddress, "ReturnValue");
		CheckUnitCapsuleCollisions_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckUnitCapsuleCollisions_FunctionAddress, "ReturnValue");
		CheckUnitCapsuleCollisions_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckUnitCapsuleCollisions_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CheckUnitCapsuleCollisions_IsValid = CheckUnitCapsuleCollisions_FunctionAddress != IntPtr.Zero && CheckUnitCapsuleCollisions_WorldContext_IsValid && CheckUnitCapsuleCollisions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:CheckUnitCapsuleCollisions", CheckUnitCapsuleCollisions_IsValid);
		Analysis_BuffUseSimpleState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Analysis_BuffUseSimpleState");
		Analysis_BuffUseSimpleState_ParamsSize = NativeReflection.GetFunctionParamsSize(Analysis_BuffUseSimpleState_FunctionAddress);
		Analysis_BuffUseSimpleState_IsValid = Analysis_BuffUseSimpleState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSimpleState", Analysis_BuffUseSimpleState_IsValid);
		BGUSetUpDefaultFootstepAudio_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUpDefaultFootstepAudio");
		BGUSetUpDefaultFootstepAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUpDefaultFootstepAudio_FunctionAddress);
		BGUSetUpDefaultFootstepAudio_TamerActor_Offset = NativeReflection.GetPropertyOffset(BGUSetUpDefaultFootstepAudio_FunctionAddress, "TamerActor");
		BGUSetUpDefaultFootstepAudio_TamerActor_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUpDefaultFootstepAudio_FunctionAddress, "TamerActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUpDefaultFootstepAudio_AudioPath_PropertyAddress, BGUSetUpDefaultFootstepAudio_FunctionAddress, "AudioPath");
		BGUSetUpDefaultFootstepAudio_AudioPath_Offset = NativeReflection.GetPropertyOffset(BGUSetUpDefaultFootstepAudio_FunctionAddress, "AudioPath");
		BGUSetUpDefaultFootstepAudio_AudioPath_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUpDefaultFootstepAudio_FunctionAddress, "AudioPath", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUpDefaultFootstepAudio_ReturnValue_PropertyAddress, BGUSetUpDefaultFootstepAudio_FunctionAddress, "ReturnValue");
		BGUSetUpDefaultFootstepAudio_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUSetUpDefaultFootstepAudio_FunctionAddress, "ReturnValue");
		BGUSetUpDefaultFootstepAudio_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUpDefaultFootstepAudio_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUSetUpDefaultFootstepAudio_IsValid = BGUSetUpDefaultFootstepAudio_FunctionAddress != IntPtr.Zero && BGUSetUpDefaultFootstepAudio_TamerActor_IsValid && BGUSetUpDefaultFootstepAudio_AudioPath_IsValid && BGUSetUpDefaultFootstepAudio_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSetUpDefaultFootstepAudio", BGUSetUpDefaultFootstepAudio_IsValid);
		GetTemplateClassFromUnitAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTemplateClassFromUnitAsset");
		GetTemplateClassFromUnitAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTemplateClassFromUnitAsset_FunctionAddress);
		GetTemplateClassFromUnitAsset_Assets_Offset = NativeReflection.GetPropertyOffset(GetTemplateClassFromUnitAsset_FunctionAddress, "Assets");
		GetTemplateClassFromUnitAsset_Assets_IsValid = NativeReflection.ValidatePropertyClass(GetTemplateClassFromUnitAsset_FunctionAddress, "Assets", Classes.FObjectProperty);
		GetTemplateClassFromUnitAsset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetTemplateClassFromUnitAsset_FunctionAddress, "ReturnValue");
		GetTemplateClassFromUnitAsset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetTemplateClassFromUnitAsset_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetTemplateClassFromUnitAsset_IsValid = GetTemplateClassFromUnitAsset_FunctionAddress != IntPtr.Zero && GetTemplateClassFromUnitAsset_Assets_IsValid && GetTemplateClassFromUnitAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:GetTemplateClassFromUnitAsset", GetTemplateClassFromUnitAsset_IsValid);
		BGUMigrateDataFromUnitCommDesc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMigrateDataFromUnitCommDesc");
		BGUMigrateDataFromUnitCommDesc_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMigrateDataFromUnitCommDesc_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUMigrateDataFromUnitCommDesc_BlameName_PropertyAddress, BGUMigrateDataFromUnitCommDesc_FunctionAddress, "BlameName");
		BGUMigrateDataFromUnitCommDesc_BlameName_Offset = NativeReflection.GetPropertyOffset(BGUMigrateDataFromUnitCommDesc_FunctionAddress, "BlameName");
		BGUMigrateDataFromUnitCommDesc_BlameName_IsValid = NativeReflection.ValidatePropertyClass(BGUMigrateDataFromUnitCommDesc_FunctionAddress, "BlameName", Classes.FStrProperty);
		BGUMigrateDataFromUnitCommDesc_IsValid = BGUMigrateDataFromUnitCommDesc_FunctionAddress != IntPtr.Zero && BGUMigrateDataFromUnitCommDesc_BlameName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc", BGUMigrateDataFromUnitCommDesc_IsValid);
		BGUAddNofityStateByPelvisSpeed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAddNofityStateByPelvisSpeed");
		BGUAddNofityStateByPelvisSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAddNofityStateByPelvisSpeed_FunctionAddress);
		BGUAddNofityStateByPelvisSpeed_AnimMontage_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "AnimMontage");
		BGUAddNofityStateByPelvisSpeed_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		BGUAddNofityStateByPelvisSpeed_SpeedThreshold_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "SpeedThreshold");
		BGUAddNofityStateByPelvisSpeed_SpeedThreshold_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "SpeedThreshold", Classes.FFloatProperty);
		BGUAddNofityStateByPelvisSpeed_BuffID_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "BuffID");
		BGUAddNofityStateByPelvisSpeed_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "BuffID", Classes.FIntProperty);
		BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "NewNotifyStateClass");
		BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "NewNotifyStateClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_PropertyAddress, BGUAddNofityStateByPelvisSpeed_FunctionAddress, "FirstRemoveAddBuffID");
		BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "FirstRemoveAddBuffID");
		BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "FirstRemoveAddBuffID", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGUAddNofityStateByPelvisSpeed_SocketName_PropertyAddress, BGUAddNofityStateByPelvisSpeed_FunctionAddress, "SocketName");
		BGUAddNofityStateByPelvisSpeed_SocketName_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "SocketName");
		BGUAddNofityStateByPelvisSpeed_SocketName_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "SocketName", Classes.FStrProperty);
		BGUAddNofityStateByPelvisSpeed_TickTime_Offset = NativeReflection.GetPropertyOffset(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "TickTime");
		BGUAddNofityStateByPelvisSpeed_TickTime_IsValid = NativeReflection.ValidatePropertyClass(BGUAddNofityStateByPelvisSpeed_FunctionAddress, "TickTime", Classes.FFloatProperty);
		BGUAddNofityStateByPelvisSpeed_IsValid = BGUAddNofityStateByPelvisSpeed_FunctionAddress != IntPtr.Zero && BGUAddNofityStateByPelvisSpeed_AnimMontage_IsValid && BGUAddNofityStateByPelvisSpeed_SpeedThreshold_IsValid && BGUAddNofityStateByPelvisSpeed_BuffID_IsValid && BGUAddNofityStateByPelvisSpeed_NewNotifyStateClass_IsValid && BGUAddNofityStateByPelvisSpeed_FirstRemoveAddBuffID_IsValid && BGUAddNofityStateByPelvisSpeed_SocketName_IsValid && BGUAddNofityStateByPelvisSpeed_TickTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAddNofityStateByPelvisSpeed", BGUAddNofityStateByPelvisSpeed_IsValid);
		BGUEditorRecordSubLevelsInWorld_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUEditorRecordSubLevelsInWorld");
		BGUEditorRecordSubLevelsInWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUEditorRecordSubLevelsInWorld_FunctionAddress);
		BGUEditorRecordSubLevelsInWorld_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUEditorRecordSubLevelsInWorld_FunctionAddress, "WorldContext");
		BGUEditorRecordSubLevelsInWorld_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUEditorRecordSubLevelsInWorld_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUEditorRecordSubLevelsInWorld_RecordFilePath_PropertyAddress, BGUEditorRecordSubLevelsInWorld_FunctionAddress, "RecordFilePath");
		BGUEditorRecordSubLevelsInWorld_RecordFilePath_Offset = NativeReflection.GetPropertyOffset(BGUEditorRecordSubLevelsInWorld_FunctionAddress, "RecordFilePath");
		BGUEditorRecordSubLevelsInWorld_RecordFilePath_IsValid = NativeReflection.ValidatePropertyClass(BGUEditorRecordSubLevelsInWorld_FunctionAddress, "RecordFilePath", Classes.FStrProperty);
		BGUEditorRecordSubLevelsInWorld_IsValid = BGUEditorRecordSubLevelsInWorld_FunctionAddress != IntPtr.Zero && BGUEditorRecordSubLevelsInWorld_WorldContext_IsValid && BGUEditorRecordSubLevelsInWorld_RecordFilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInWorld", BGUEditorRecordSubLevelsInWorld_IsValid);
		AddMagicallyChangeFadeOutNotify_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AddMagicallyChangeFadeOutNotify");
		AddMagicallyChangeFadeOutNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMagicallyChangeFadeOutNotify_FunctionAddress);
		AddMagicallyChangeFadeOutNotify_Montage_Offset = NativeReflection.GetPropertyOffset(AddMagicallyChangeFadeOutNotify_FunctionAddress, "Montage");
		AddMagicallyChangeFadeOutNotify_Montage_IsValid = NativeReflection.ValidatePropertyClass(AddMagicallyChangeFadeOutNotify_FunctionAddress, "Montage", Classes.FObjectProperty);
		AddMagicallyChangeFadeOutNotify_IsValid = AddMagicallyChangeFadeOutNotify_FunctionAddress != IntPtr.Zero && AddMagicallyChangeFadeOutNotify_Montage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:AddMagicallyChangeFadeOutNotify", AddMagicallyChangeFadeOutNotify_IsValid);
		Analysis_BuffUseSpecialHitPartID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Analysis_BuffUseSpecialHitPartID");
		Analysis_BuffUseSpecialHitPartID_ParamsSize = NativeReflection.GetFunctionParamsSize(Analysis_BuffUseSpecialHitPartID_FunctionAddress);
		Analysis_BuffUseSpecialHitPartID_IsValid = Analysis_BuffUseSpecialHitPartID_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:Analysis_BuffUseSpecialHitPartID", Analysis_BuffUseSpecialHitPartID_IsValid);
		BGUSerializeActorTransformsToJson_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSerializeActorTransformsToJson");
		BGUSerializeActorTransformsToJson_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSerializeActorTransformsToJson_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUSerializeActorTransformsToJson_JsonPath_PropertyAddress, BGUSerializeActorTransformsToJson_FunctionAddress, "JsonPath");
		BGUSerializeActorTransformsToJson_JsonPath_Offset = NativeReflection.GetPropertyOffset(BGUSerializeActorTransformsToJson_FunctionAddress, "JsonPath");
		BGUSerializeActorTransformsToJson_JsonPath_IsValid = NativeReflection.ValidatePropertyClass(BGUSerializeActorTransformsToJson_FunctionAddress, "JsonPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUSerializeActorTransformsToJson_Actors_PropertyAddress, BGUSerializeActorTransformsToJson_FunctionAddress, "Actors");
		BGUSerializeActorTransformsToJson_Actors_Offset = NativeReflection.GetPropertyOffset(BGUSerializeActorTransformsToJson_FunctionAddress, "Actors");
		BGUSerializeActorTransformsToJson_Actors_IsValid = NativeReflection.ValidatePropertyClass(BGUSerializeActorTransformsToJson_FunctionAddress, "Actors", Classes.FArrayProperty);
		BGUSerializeActorTransformsToJson_IsValid = BGUSerializeActorTransformsToJson_FunctionAddress != IntPtr.Zero && BGUSerializeActorTransformsToJson_JsonPath_IsValid && BGUSerializeActorTransformsToJson_Actors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUSerializeActorTransformsToJson", BGUSerializeActorTransformsToJson_IsValid);
		BGUMigrateDataFromSkillEffectDesc_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMigrateDataFromSkillEffectDesc");
		BGUMigrateDataFromSkillEffectDesc_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMigrateDataFromSkillEffectDesc_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUMigrateDataFromSkillEffectDesc_BlameName_PropertyAddress, BGUMigrateDataFromSkillEffectDesc_FunctionAddress, "BlameName");
		BGUMigrateDataFromSkillEffectDesc_BlameName_Offset = NativeReflection.GetPropertyOffset(BGUMigrateDataFromSkillEffectDesc_FunctionAddress, "BlameName");
		BGUMigrateDataFromSkillEffectDesc_BlameName_IsValid = NativeReflection.ValidatePropertyClass(BGUMigrateDataFromSkillEffectDesc_FunctionAddress, "BlameName", Classes.FStrProperty);
		BGUMigrateDataFromSkillEffectDesc_IsValid = BGUMigrateDataFromSkillEffectDesc_FunctionAddress != IntPtr.Zero && BGUMigrateDataFromSkillEffectDesc_BlameName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromSkillEffectDesc", BGUMigrateDataFromSkillEffectDesc_IsValid);
		BGUGetLeftFootHeightByFootStepConfig_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetLeftFootHeightByFootStepConfig");
		BGUGetLeftFootHeightByFootStepConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress);
		BGUGetLeftFootHeightByFootStepConfig_ResID_Offset = NativeReflection.GetPropertyOffset(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "ResID");
		BGUGetLeftFootHeightByFootStepConfig_ResID_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "ResID", Classes.FIntProperty);
		BGUGetLeftFootHeightByFootStepConfig_Mesh_Offset = NativeReflection.GetPropertyOffset(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "Mesh");
		BGUGetLeftFootHeightByFootStepConfig_Mesh_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "Mesh", Classes.FObjectProperty);
		BGUGetLeftFootHeightByFootStepConfig_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "ReturnValue");
		BGUGetLeftFootHeightByFootStepConfig_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetLeftFootHeightByFootStepConfig_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetLeftFootHeightByFootStepConfig_IsValid = BGUGetLeftFootHeightByFootStepConfig_FunctionAddress != IntPtr.Zero && BGUGetLeftFootHeightByFootStepConfig_ResID_IsValid && BGUGetLeftFootHeightByFootStepConfig_Mesh_IsValid && BGUGetLeftFootHeightByFootStepConfig_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUGetLeftFootHeightByFootStepConfig", BGUGetLeftFootHeightByFootStepConfig_IsValid);
		BGUDeserializeActorTransformsFromJson_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUDeserializeActorTransformsFromJson");
		BGUDeserializeActorTransformsFromJson_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDeserializeActorTransformsFromJson_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUDeserializeActorTransformsFromJson_JsonPath_PropertyAddress, BGUDeserializeActorTransformsFromJson_FunctionAddress, "JsonPath");
		BGUDeserializeActorTransformsFromJson_JsonPath_Offset = NativeReflection.GetPropertyOffset(BGUDeserializeActorTransformsFromJson_FunctionAddress, "JsonPath");
		BGUDeserializeActorTransformsFromJson_JsonPath_IsValid = NativeReflection.ValidatePropertyClass(BGUDeserializeActorTransformsFromJson_FunctionAddress, "JsonPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_PropertyAddress, BGUDeserializeActorTransformsFromJson_FunctionAddress, "ActorsToDeserialize");
		BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_Offset = NativeReflection.GetPropertyOffset(BGUDeserializeActorTransformsFromJson_FunctionAddress, "ActorsToDeserialize");
		BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_IsValid = NativeReflection.ValidatePropertyClass(BGUDeserializeActorTransformsFromJson_FunctionAddress, "ActorsToDeserialize", Classes.FArrayProperty);
		BGUDeserializeActorTransformsFromJson_IsValid = BGUDeserializeActorTransformsFromJson_FunctionAddress != IntPtr.Zero && BGUDeserializeActorTransformsFromJson_JsonPath_IsValid && BGUDeserializeActorTransformsFromJson_ActorsToDeserialize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUDeserializeActorTransformsFromJson", BGUDeserializeActorTransformsFromJson_IsValid);
		BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAutoAddFootSyncMarkerToAnimSequence");
		BGUAutoAddFootSyncMarkerToAnimSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress);
		BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "AnimSequence");
		BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "LeftFootBoneName");
		BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "LeftFootBoneName", Classes.FNameProperty);
		BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "RightFootBoneName");
		BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "RightFootBoneName", Classes.FNameProperty);
		BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "GroundFootLimitHeight");
		BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "GroundFootLimitHeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_PropertyAddress, BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "ReturnValue");
		BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "ReturnValue");
		BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUAutoAddFootSyncMarkerToAnimSequence_IsValid = BGUAutoAddFootSyncMarkerToAnimSequence_FunctionAddress != IntPtr.Zero && BGUAutoAddFootSyncMarkerToAnimSequence_AnimSequence_IsValid && BGUAutoAddFootSyncMarkerToAnimSequence_LeftFootBoneName_IsValid && BGUAutoAddFootSyncMarkerToAnimSequence_RightFootBoneName_IsValid && BGUAutoAddFootSyncMarkerToAnimSequence_GroundFootLimitHeight_IsValid && BGUAutoAddFootSyncMarkerToAnimSequence_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUAutoAddFootSyncMarkerToAnimSequence", BGUAutoAddFootSyncMarkerToAnimSequence_IsValid);
		BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUEditorRecordSubLevelsInLevelPackage");
		BGUEditorRecordSubLevelsInLevelPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_PropertyAddress, BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "LevelAsset");
		BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_Offset = NativeReflection.GetPropertyOffset(BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "LevelAsset");
		BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_IsValid = NativeReflection.ValidatePropertyClass(BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "LevelAsset", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_PropertyAddress, BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "RecordFilePath");
		BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_Offset = NativeReflection.GetPropertyOffset(BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "RecordFilePath");
		BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_IsValid = NativeReflection.ValidatePropertyClass(BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress, "RecordFilePath", Classes.FStrProperty);
		BGUEditorRecordSubLevelsInLevelPackage_IsValid = BGUEditorRecordSubLevelsInLevelPackage_FunctionAddress != IntPtr.Zero && BGUEditorRecordSubLevelsInLevelPackage_LevelAsset_IsValid && BGUEditorRecordSubLevelsInLevelPackage_RecordFilePath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUEditorRecordSubLevelsInLevelPackage", BGUEditorRecordSubLevelsInLevelPackage_IsValid);
		BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUMigrateDataFromUnitCommDesc_OverrideData");
		BGUMigrateDataFromUnitCommDesc_OverrideData_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_PropertyAddress, BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress, "BlameName");
		BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_Offset = NativeReflection.GetPropertyOffset(BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress, "BlameName");
		BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_IsValid = NativeReflection.ValidatePropertyClass(BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress, "BlameName", Classes.FStrProperty);
		BGUMigrateDataFromUnitCommDesc_OverrideData_IsValid = BGUMigrateDataFromUnitCommDesc_OverrideData_FunctionAddress != IntPtr.Zero && BGUMigrateDataFromUnitCommDesc_OverrideData_BlameName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibNonRuntime:BGUMigrateDataFromUnitCommDesc_OverrideData", BGUMigrateDataFromUnitCommDesc_OverrideData_IsValid);
	}
}

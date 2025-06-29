using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using b1.AutoQA;
using b1.BGW;
using b1.FUnctionLibUtil;
using b1.Localization;
using b1.Plugins.AkAudio;
using b1.Plugins.AsyncLoadingScreen;
using b1.Protobuf.DataAPI;
using BtlB1;
using BtlShare;
using CommB1;
using Diana.Common;
using Google.Protobuf;
using Google.Protobuf.Collections;
using GurCalliopeState;
using ResB1;
using UnrealEngine.AIModule;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS")]
public class BGUFunctionLibraryCS : UBlueprintFunctionLibrary
{
	private static FMargin GSafeZonePaddingSize;

	private static bool GIsSafeZonePaddingSizeCached;

	private const float INV10000 = 0.0001f;

	private static bool BGUGMDead_IsValid;

	private static IntPtr BGUGMDead_FunctionAddress;

	private static int BGUGMDead_ParamsSize;

	private static bool BGUGMDead_Unit_IsValid;

	private static int BGUGMDead_Unit_Offset;

	private static bool GM_AddAttr_IsValid;

	private static IntPtr GM_AddAttr_FunctionAddress;

	private static int GM_AddAttr_ParamsSize;

	private static bool GM_AddAttr_Unit_IsValid;

	private static int GM_AddAttr_Unit_Offset;

	private static bool GM_AddAttr_AttrType_IsValid;

	private static int GM_AddAttr_AttrType_Offset;

	private static FFieldAddress GM_AddAttr_AttrType_PropertyAddress;

	private static bool GM_AddAttr_AddValue_IsValid;

	private static int GM_AddAttr_AddValue_Offset;

	private static bool BGUAddBuff_IsValid;

	private static IntPtr BGUAddBuff_FunctionAddress;

	private static int BGUAddBuff_ParamsSize;

	private static bool BGUAddBuff_Caster_IsValid;

	private static int BGUAddBuff_Caster_Offset;

	private static bool BGUAddBuff_Target_IsValid;

	private static int BGUAddBuff_Target_Offset;

	private static bool BGUAddBuff_BuffID_IsValid;

	private static int BGUAddBuff_BuffID_Offset;

	private static bool BGUAddBuff_BuffSourceType_IsValid;

	private static int BGUAddBuff_BuffSourceType_Offset;

	private static FFieldAddress BGUAddBuff_BuffSourceType_PropertyAddress;

	private static bool BGUAddBuff_BuffDurationTimer_IsValid;

	private static int BGUAddBuff_BuffDurationTimer_Offset;

	private static bool GetRTForFX_IsValid;

	private static IntPtr GetRTForFX_FunctionAddress;

	private static int GetRTForFX_ParamsSize;

	private static bool GetRTForFX_OwnerActor_IsValid;

	private static int GetRTForFX_OwnerActor_Offset;

	private static bool GetRTForFX_RTType_IsValid;

	private static int GetRTForFX_RTType_Offset;

	private static FFieldAddress GetRTForFX_RTType_PropertyAddress;

	private static bool GetRTForFX_ReturnValue_IsValid;

	private static int GetRTForFX_ReturnValue_Offset;

	private static bool BGUDBCTest_IsValid;

	private static IntPtr BGUDBCTest_FunctionAddress;

	private static int BGUDBCTest_ParamsSize;

	private static bool BGUDBCTest_Owner_IsValid;

	private static int BGUDBCTest_Owner_Offset;

	private static bool BGUDBCTest_DBCPath_IsValid;

	private static int BGUDBCTest_DBCPath_Offset;

	private static FFieldAddress BGUDBCTest_DBCPath_PropertyAddress;

	private static bool TestVector_IsValid;

	private static IntPtr TestVector_FunctionAddress;

	private static int TestVector_ParamsSize;

	private static bool TestVector_A_IsValid;

	private static int TestVector_A_Offset;

	private static FFieldAddress TestVector_A_PropertyAddress;

	private static bool BGUHasBuff_IsValid;

	private static IntPtr BGUHasBuff_FunctionAddress;

	private static int BGUHasBuff_ParamsSize;

	private static bool BGUHasBuff_Unit_IsValid;

	private static int BGUHasBuff_Unit_Offset;

	private static bool BGUHasBuff_BuffID_IsValid;

	private static int BGUHasBuff_BuffID_Offset;

	private static FFieldAddress BGUHasBuff_BuffID_PropertyAddress;

	private static bool BGUHasBuff_ReturnValue_IsValid;

	private static int BGUHasBuff_ReturnValue_Offset;

	private static FFieldAddress BGUHasBuff_ReturnValue_PropertyAddress;

	private static bool UnitSuicide_IsValid;

	private static IntPtr UnitSuicide_FunctionAddress;

	private static int UnitSuicide_ParamsSize;

	private static bool UnitSuicide_Unit_IsValid;

	private static int UnitSuicide_Unit_Offset;

	private static bool BGUGetResID_IsValid;

	private static IntPtr BGUGetResID_FunctionAddress;

	private static int BGUGetResID_ParamsSize;

	private static bool BGUGetResID_Unit_IsValid;

	private static int BGUGetResID_Unit_Offset;

	private static bool BGUGetResID_ReturnValue_IsValid;

	private static int BGUGetResID_ReturnValue_Offset;

	private static bool DicSortTest_IsValid;

	private static IntPtr DicSortTest_FunctionAddress;

	private static int DicSortTest_ParamsSize;

	private static bool DicSortTest_Unit_IsValid;

	private static int DicSortTest_Unit_Offset;

	private static bool ChangeEquip_IsValid;

	private static IntPtr ChangeEquip_FunctionAddress;

	private static int ChangeEquip_ParamsSize;

	private static bool ChangeEquip_Actor_IsValid;

	private static int ChangeEquip_Actor_Offset;

	private static bool ChangeEquip_ID_IsValid;

	private static int ChangeEquip_ID_Offset;

	private static bool BGUCostAttr_IsValid;

	private static IntPtr BGUCostAttr_FunctionAddress;

	private static int BGUCostAttr_ParamsSize;

	private static bool BGUCostAttr_Unit_IsValid;

	private static int BGUCostAttr_Unit_Offset;

	private static bool BGUCostAttr_AttrCostType_IsValid;

	private static int BGUCostAttr_AttrCostType_Offset;

	private static FFieldAddress BGUCostAttr_AttrCostType_PropertyAddress;

	private static bool BGUCostAttr_CostBase_IsValid;

	private static int BGUCostAttr_CostBase_Offset;

	private static bool BGUCostAttr_CostRatio_IsValid;

	private static int BGUCostAttr_CostRatio_Offset;

	private static bool PlayUISound_IsValid;

	private static IntPtr PlayUISound_FunctionAddress;

	private static int PlayUISound_ParamsSize;

	private static bool PlayUISound_InWorldContext_IsValid;

	private static int PlayUISound_InWorldContext_Offset;

	private static bool PlayUISound_InAudioEvent_IsValid;

	private static int PlayUISound_InAudioEvent_Offset;

	private static bool PlayUISound_ReturnValue_IsValid;

	private static int PlayUISound_ReturnValue_Offset;

	private static bool BGUTestEnum_IsValid;

	private static IntPtr BGUTestEnum_FunctionAddress;

	private static int BGUTestEnum_ParamsSize;

	private static bool BGUTestEnum_Unit_IsValid;

	private static int BGUTestEnum_Unit_Offset;

	private static bool BGUTestEnum_SimpleState_IsValid;

	private static int BGUTestEnum_SimpleState_Offset;

	private static FFieldAddress BGUTestEnum_SimpleState_PropertyAddress;

	private static bool CanShutDown_IsValid;

	private static IntPtr CanShutDown_FunctionAddress;

	private static int CanShutDown_ParamsSize;

	private static bool CanShutDown_WorldContext_IsValid;

	private static int CanShutDown_WorldContext_Offset;

	private static bool CanShutDown_ReturnValue_IsValid;

	private static int CanShutDown_ReturnValue_Offset;

	private static FFieldAddress CanShutDown_ReturnValue_PropertyAddress;

	private static bool GetCameraFOV_IsValid;

	private static IntPtr GetCameraFOV_FunctionAddress;

	private static int GetCameraFOV_ParamsSize;

	private static bool GetCameraFOV_CameraActor_IsValid;

	private static int GetCameraFOV_CameraActor_Offset;

	private static bool GetCameraFOV_ReturnValue_IsValid;

	private static int GetCameraFOV_ReturnValue_Offset;

	private static bool BGUGetTarget_IsValid;

	private static IntPtr BGUGetTarget_FunctionAddress;

	private static int BGUGetTarget_ParamsSize;

	private static bool BGUGetTarget_Unit_IsValid;

	private static int BGUGetTarget_Unit_Offset;

	private static bool BGUGetTarget_ReturnValue_IsValid;

	private static int BGUGetTarget_ReturnValue_Offset;

	private static bool SetCameraFOV_IsValid;

	private static IntPtr SetCameraFOV_FunctionAddress;

	private static int SetCameraFOV_ParamsSize;

	private static bool SetCameraFOV_CameraActor_IsValid;

	private static int SetCameraFOV_CameraActor_Offset;

	private static bool SetCameraFOV_NewFOV_IsValid;

	private static int SetCameraFOV_NewFOV_Offset;

	private static bool GetAttrValue_IsValid;

	private static IntPtr GetAttrValue_FunctionAddress;

	private static int GetAttrValue_ParamsSize;

	private static bool GetAttrValue_Unit_IsValid;

	private static int GetAttrValue_Unit_Offset;

	private static bool GetAttrValue_AttrID_IsValid;

	private static int GetAttrValue_AttrID_Offset;

	private static FFieldAddress GetAttrValue_AttrID_PropertyAddress;

	private static bool GetAttrValue_ReturnValue_IsValid;

	private static int GetAttrValue_ReturnValue_Offset;

	private static bool BGUShowFPSUI_IsValid;

	private static IntPtr BGUShowFPSUI_FunctionAddress;

	private static int BGUShowFPSUI_ParamsSize;

	private static bool BGUShowFPSUI_Unit_IsValid;

	private static int BGUShowFPSUI_Unit_Offset;

	private static bool RunGMCommand_IsValid;

	private static IntPtr RunGMCommand_FunctionAddress;

	private static int RunGMCommand_ParamsSize;

	private static bool RunGMCommand_Actor_IsValid;

	private static int RunGMCommand_Actor_Offset;

	private static bool RunGMCommand_cmd_IsValid;

	private static int RunGMCommand_cmd_Offset;

	private static FFieldAddress RunGMCommand_cmd_PropertyAddress;

	private static bool RunGMCommand_JustRunInBin_IsValid;

	private static int RunGMCommand_JustRunInBin_Offset;

	private static FFieldAddress RunGMCommand_JustRunInBin_PropertyAddress;

	private static bool GetAllEquipId_IsValid;

	private static IntPtr GetAllEquipId_FunctionAddress;

	private static int GetAllEquipId_ParamsSize;

	private static bool GetAllEquipId_ReturnValue_IsValid;

	private static int GetAllEquipId_ReturnValue_Offset;

	private static FFieldAddress GetAllEquipId_ReturnValue_PropertyAddress;

	private static bool RefreshGameDB_IsValid;

	private static IntPtr RefreshGameDB_FunctionAddress;

	private static int RefreshGameDB_ParamsSize;

	private static bool StopFetchTick_IsValid;

	private static IntPtr StopFetchTick_FunctionAddress;

	private static int StopFetchTick_ParamsSize;

	private static bool StopFetchTick_WorldContext_IsValid;

	private static int StopFetchTick_WorldContext_Offset;

	private static bool BGUIsUnitDead_IsValid;

	private static IntPtr BGUIsUnitDead_FunctionAddress;

	private static int BGUIsUnitDead_ParamsSize;

	private static bool BGUIsUnitDead_Unit_IsValid;

	private static int BGUIsUnitDead_Unit_Offset;

	private static bool BGUIsUnitDead_ReturnValue_IsValid;

	private static int BGUIsUnitDead_ReturnValue_Offset;

	private static FFieldAddress BGUIsUnitDead_ReturnValue_PropertyAddress;

	private static bool BGURemoveBuff_IsValid;

	private static IntPtr BGURemoveBuff_FunctionAddress;

	private static int BGURemoveBuff_ParamsSize;

	private static bool BGURemoveBuff_Unit_IsValid;

	private static int BGURemoveBuff_Unit_Offset;

	private static bool BGURemoveBuff_BuffID_IsValid;

	private static int BGURemoveBuff_BuffID_Offset;

	private static bool BGURemoveBuff_EffectTriggerType_IsValid;

	private static int BGURemoveBuff_EffectTriggerType_Offset;

	private static FFieldAddress BGURemoveBuff_EffectTriggerType_PropertyAddress;

	private static bool BGURemoveBuff_Layer_IsValid;

	private static int BGURemoveBuff_Layer_Offset;

	private static bool BGUSpawnActor_IsValid;

	private static IntPtr BGUSpawnActor_FunctionAddress;

	private static int BGUSpawnActor_ParamsSize;

	private static bool BGUSpawnActor__World_IsValid;

	private static int BGUSpawnActor__World_Offset;

	private static bool BGUSpawnActor_ActorClass_IsValid;

	private static int BGUSpawnActor_ActorClass_Offset;

	private static bool BGUSpawnActor_Location_IsValid;

	private static int BGUSpawnActor_Location_Offset;

	private static FFieldAddress BGUSpawnActor_Location_PropertyAddress;

	private static bool BGUSpawnActor_Rotation_IsValid;

	private static int BGUSpawnActor_Rotation_Offset;

	private static FFieldAddress BGUSpawnActor_Rotation_PropertyAddress;

	private static bool BGUSpawnActor_ReturnValue_IsValid;

	private static int BGUSpawnActor_ReturnValue_Offset;

	private static bool TriggerEffect_IsValid;

	private static IntPtr TriggerEffect_FunctionAddress;

	private static int TriggerEffect_ParamsSize;

	private static bool TriggerEffect_Unit_IsValid;

	private static int TriggerEffect_Unit_Offset;

	private static bool TriggerEffect_EffectID_IsValid;

	private static int TriggerEffect_EffectID_Offset;

	private static bool SeqChangeEquip_IsValid;

	private static IntPtr SeqChangeEquip_FunctionAddress;

	private static int SeqChangeEquip_ParamsSize;

	private static bool SeqChangeEquip_SeqActor_IsValid;

	private static int SeqChangeEquip_SeqActor_Offset;

	private static bool SeqChangeEquip_EquipID_IsValid;

	private static int SeqChangeEquip_EquipID_Offset;

	private static bool BGUIsEnemyTeam_IsValid;

	private static IntPtr BGUIsEnemyTeam_FunctionAddress;

	private static int BGUIsEnemyTeam_ParamsSize;

	private static bool BGUIsEnemyTeam_SelfUnit_IsValid;

	private static int BGUIsEnemyTeam_SelfUnit_Offset;

	private static bool BGUIsEnemyTeam_OtherUnit_IsValid;

	private static int BGUIsEnemyTeam_OtherUnit_Offset;

	private static bool BGUIsEnemyTeam_ReturnValue_IsValid;

	private static int BGUIsEnemyTeam_ReturnValue_Offset;

	private static FFieldAddress BGUIsEnemyTeam_ReturnValue_PropertyAddress;

	private static bool BGUHasBuffByID_IsValid;

	private static IntPtr BGUHasBuffByID_FunctionAddress;

	private static int BGUHasBuffByID_ParamsSize;

	private static bool BGUHasBuffByID_Unit_IsValid;

	private static int BGUHasBuffByID_Unit_Offset;

	private static bool BGUHasBuffByID_BuffID_IsValid;

	private static int BGUHasBuffByID_BuffID_Offset;

	private static bool BGUHasBuffByID_ReturnValue_IsValid;

	private static int BGUHasBuffByID_ReturnValue_Offset;

	private static FFieldAddress BGUHasBuffByID_ReturnValue_PropertyAddress;

	private static bool PlayPigsyStory_IsValid;

	private static IntPtr PlayPigsyStory_FunctionAddress;

	private static int PlayPigsyStory_ParamsSize;

	private static bool PlayPigsyStory_Unit_IsValid;

	private static int PlayPigsyStory_Unit_Offset;

	private static bool RunEQSForDebug_IsValid;

	private static IntPtr RunEQSForDebug_FunctionAddress;

	private static int RunEQSForDebug_ParamsSize;

	private static bool RunEQSForDebug_Querier_IsValid;

	private static int RunEQSForDebug_Querier_Offset;

	private static bool RunEQSForDebug_Env_IsValid;

	private static int RunEQSForDebug_Env_Offset;

	private static bool TestInputEvent_IsValid;

	private static IntPtr TestInputEvent_FunctionAddress;

	private static int TestInputEvent_ParamsSize;

	private static bool TestInputEvent_A_IsValid;

	private static int TestInputEvent_A_Offset;

	private static FFieldAddress TestInputEvent_A_PropertyAddress;

	private static bool SetPhysSetting_IsValid;

	private static IntPtr SetPhysSetting_FunctionAddress;

	private static int SetPhysSetting_ParamsSize;

	private static bool SetPhysSetting_Actor_IsValid;

	private static int SetPhysSetting_Actor_Offset;

	private static bool SetPhysSetting_Type_IsValid;

	private static int SetPhysSetting_Type_Offset;

	private static FFieldAddress SetPhysSetting_Type_PropertyAddress;

	private static bool BGUClearWeapon_IsValid;

	private static IntPtr BGUClearWeapon_FunctionAddress;

	private static int BGUClearWeapon_ParamsSize;

	private static bool BGUClearWeapon_Owner_IsValid;

	private static int BGUClearWeapon_Owner_Offset;

	private static bool BreakCloudMove_IsValid;

	private static IntPtr BreakCloudMove_FunctionAddress;

	private static int BreakCloudMove_ParamsSize;

	private static bool BreakCloudMove_Unit_IsValid;

	private static int BreakCloudMove_Unit_Offset;

	private static bool BreakCloudMove_BreakAnimId_IsValid;

	private static int BreakCloudMove_BreakAnimId_Offset;

	private static bool BGUHideLevelUI_IsValid;

	private static IntPtr BGUHideLevelUI_FunctionAddress;

	private static int BGUHideLevelUI_ParamsSize;

	private static bool BGUHideLevelUI_Unit_IsValid;

	private static int BGUHideLevelUI_Unit_Offset;

	private static bool IsCheatGMLevel_IsValid;

	private static IntPtr IsCheatGMLevel_FunctionAddress;

	private static int IsCheatGMLevel_ParamsSize;

	private static bool IsCheatGMLevel_ReturnValue_IsValid;

	private static int IsCheatGMLevel_ReturnValue_Offset;

	private static FFieldAddress IsCheatGMLevel_ReturnValue_PropertyAddress;

	private static bool IsDebugGMLevel_IsValid;

	private static IntPtr IsDebugGMLevel_FunctionAddress;

	private static int IsDebugGMLevel_ParamsSize;

	private static bool IsDebugGMLevel_ReturnValue_IsValid;

	private static int IsDebugGMLevel_ReturnValue_Offset;

	private static FFieldAddress IsDebugGMLevel_ReturnValue_PropertyAddress;

	private static bool BGUHasUnitState_IsValid;

	private static IntPtr BGUHasUnitState_FunctionAddress;

	private static int BGUHasUnitState_ParamsSize;

	private static bool BGUHasUnitState_Unit_IsValid;

	private static int BGUHasUnitState_Unit_Offset;

	private static bool BGUHasUnitState_UnitState_IsValid;

	private static int BGUHasUnitState_UnitState_Offset;

	private static FFieldAddress BGUHasUnitState_UnitState_PropertyAddress;

	private static bool BGUHasUnitState_ReturnValue_IsValid;

	private static int BGUHasUnitState_ReturnValue_Offset;

	private static FFieldAddress BGUHasUnitState_ReturnValue_PropertyAddress;

	private static bool SeqChangeEquip2_IsValid;

	private static IntPtr SeqChangeEquip2_FunctionAddress;

	private static int SeqChangeEquip2_ParamsSize;

	private static bool SeqChangeEquip2_SeqActor_IsValid;

	private static int SeqChangeEquip2_SeqActor_Offset;

	private static bool GlobalEventTest_IsValid;

	private static IntPtr GlobalEventTest_FunctionAddress;

	private static int GlobalEventTest_ParamsSize;

	private static bool GlobalEventTest_Unit_IsValid;

	private static int GlobalEventTest_Unit_Offset;

	private static bool GlobalEventTest_Times_IsValid;

	private static int GlobalEventTest_Times_Offset;

	private static bool GenerateGrayBox_IsValid;

	private static IntPtr GenerateGrayBox_FunctionAddress;

	private static int GenerateGrayBox_ParamsSize;

	private static bool GenerateGrayBox_TempleteActor_IsValid;

	private static int GenerateGrayBox_TempleteActor_Offset;

	private static bool BGUGetFloatAttr_IsValid;

	private static IntPtr BGUGetFloatAttr_FunctionAddress;

	private static int BGUGetFloatAttr_ParamsSize;

	private static bool BGUGetFloatAttr_Unit_IsValid;

	private static int BGUGetFloatAttr_Unit_Offset;

	private static bool BGUGetFloatAttr_AttrID_IsValid;

	private static int BGUGetFloatAttr_AttrID_Offset;

	private static FFieldAddress BGUGetFloatAttr_AttrID_PropertyAddress;

	private static bool BGUGetFloatAttr_ReturnValue_IsValid;

	private static int BGUGetFloatAttr_ReturnValue_Offset;

	private static bool SummonEventTest_IsValid;

	private static IntPtr SummonEventTest_FunctionAddress;

	private static int SummonEventTest_ParamsSize;

	private static bool SummonEventTest_Unit_IsValid;

	private static int SummonEventTest_Unit_Offset;

	private static bool SetSolverCenter_IsValid;

	private static IntPtr SetSolverCenter_FunctionAddress;

	private static int SetSolverCenter_ParamsSize;

	private static bool SetSolverCenter_Unit_IsValid;

	private static int SetSolverCenter_Unit_Offset;

	private static bool BGUGetWeaponNum_IsValid;

	private static IntPtr BGUGetWeaponNum_FunctionAddress;

	private static int BGUGetWeaponNum_ParamsSize;

	private static bool BGUGetWeaponNum_Unit_IsValid;

	private static int BGUGetWeaponNum_Unit_Offset;

	private static bool BGUGetWeaponNum_ReturnValue_IsValid;

	private static int BGUGetWeaponNum_ReturnValue_Offset;

	private static bool BGUSetAttrValue_IsValid;

	private static IntPtr BGUSetAttrValue_FunctionAddress;

	private static int BGUSetAttrValue_ParamsSize;

	private static bool BGUSetAttrValue_Unit_IsValid;

	private static int BGUSetAttrValue_Unit_Offset;

	private static bool BGUSetAttrValue_AttrID_IsValid;

	private static int BGUSetAttrValue_AttrID_Offset;

	private static FFieldAddress BGUSetAttrValue_AttrID_PropertyAddress;

	private static bool BGUSetAttrValue_TargetValue_IsValid;

	private static int BGUSetAttrValue_TargetValue_Offset;

	private static bool BGUTryCastSpell_IsValid;

	private static IntPtr BGUTryCastSpell_FunctionAddress;

	private static int BGUTryCastSpell_ParamsSize;

	private static bool BGUTryCastSpell_Unit_IsValid;

	private static int BGUTryCastSpell_Unit_Offset;

	private static bool BGUTryCastSpell_SkillID_IsValid;

	private static int BGUTryCastSpell_SkillID_Offset;

	private static bool BGUTryCastSpell_SourceType_IsValid;

	private static int BGUTryCastSpell_SourceType_Offset;

	private static FFieldAddress BGUTryCastSpell_SourceType_PropertyAddress;

	private static bool BGUTryCastSpell_IsUseComboingSection_IsValid;

	private static int BGUTryCastSpell_IsUseComboingSection_Offset;

	private static FFieldAddress BGUTryCastSpell_IsUseComboingSection_PropertyAddress;

	private static bool BGUTryCastSpell_ReturnValue_IsValid;

	private static int BGUTryCastSpell_ReturnValue_Offset;

	private static bool ToggleCloudMove_IsValid;

	private static IntPtr ToggleCloudMove_FunctionAddress;

	private static int ToggleCloudMove_ParamsSize;

	private static bool ToggleCloudMove_Unit_IsValid;

	private static int ToggleCloudMove_Unit_Offset;

	private static bool BGUSetImmobility_IsValid;

	private static IntPtr BGUSetImmobility_FunctionAddress;

	private static int BGUSetImmobility_ParamsSize;

	private static bool BGUSetImmobility_Unit_IsValid;

	private static int BGUSetImmobility_Unit_Offset;

	private static bool BGUSetImmobility_Timer_IsValid;

	private static int BGUSetImmobility_Timer_Offset;

	private static bool BGUStartSceneQTE_IsValid;

	private static IntPtr BGUStartSceneQTE_FunctionAddress;

	private static int BGUStartSceneQTE_ParamsSize;

	private static bool BGUStartSceneQTE_Unit_IsValid;

	private static int BGUStartSceneQTE_Unit_Offset;

	private static bool BGUStartSceneQTE_QTEID_IsValid;

	private static int BGUStartSceneQTE_QTEID_Offset;

	private static bool BGUStartSceneQTE_TargetCharacter_IsValid;

	private static int BGUStartSceneQTE_TargetCharacter_Offset;

	private static bool BGURemoveAllBuff_IsValid;

	private static IntPtr BGURemoveAllBuff_FunctionAddress;

	private static int BGURemoveAllBuff_ParamsSize;

	private static bool BGURemoveAllBuff_Unit_IsValid;

	private static int BGURemoveAllBuff_Unit_Offset;

	private static bool BGURemoveAllBuff_EffectTriggerType_IsValid;

	private static int BGURemoveAllBuff_EffectTriggerType_Offset;

	private static FFieldAddress BGURemoveAllBuff_EffectTriggerType_PropertyAddress;

	private static bool IsUEDebugGMLevel_IsValid;

	private static IntPtr IsUEDebugGMLevel_FunctionAddress;

	private static int IsUEDebugGMLevel_ParamsSize;

	private static bool IsUEDebugGMLevel_ReturnValue_IsValid;

	private static int IsUEDebugGMLevel_ReturnValue_Offset;

	private static FFieldAddress IsUEDebugGMLevel_ReturnValue_PropertyAddress;

	private static bool ResetPhysSetting_IsValid;

	private static IntPtr ResetPhysSetting_FunctionAddress;

	private static int ResetPhysSetting_ParamsSize;

	private static bool ResetPhysSetting_Actor_IsValid;

	private static int ResetPhysSetting_Actor_Offset;

	private static bool BGUShowDialogueUI_IsValid;

	private static IntPtr BGUShowDialogueUI_FunctionAddress;

	private static int BGUShowDialogueUI_ParamsSize;

	private static bool BGUShowDialogueUI_Unit_IsValid;

	private static int BGUShowDialogueUI_Unit_Offset;

	private static bool BGUShowDialogueUI_DialogContent_IsValid;

	private static int BGUShowDialogueUI_DialogContent_Offset;

	private static FFieldAddress BGUShowDialogueUI_DialogContent_PropertyAddress;

	private static bool BGUShowDialogueUI_Duration_IsValid;

	private static int BGUShowDialogueUI_Duration_Offset;

	private static bool SetTrainDummyInfo_IsValid;

	private static IntPtr SetTrainDummyInfo_FunctionAddress;

	private static int SetTrainDummyInfo_ParamsSize;

	private static bool SetTrainDummyInfo_WorldContext_IsValid;

	private static int SetTrainDummyInfo_WorldContext_Offset;

	private static bool SetTrainDummyInfo_TrainDummyClassPath_IsValid;

	private static int SetTrainDummyInfo_TrainDummyClassPath_Offset;

	private static FFieldAddress SetTrainDummyInfo_TrainDummyClassPath_PropertyAddress;

	private static bool SetTrainDummyInfo_PlayerRoleDataConfigID_IsValid;

	private static int SetTrainDummyInfo_PlayerRoleDataConfigID_Offset;

	private static bool SetTrainDummyInfo_TrainDummyConfigPath_IsValid;

	private static int SetTrainDummyInfo_TrainDummyConfigPath_Offset;

	private static FFieldAddress SetTrainDummyInfo_TrainDummyConfigPath_PropertyAddress;

	private static bool SetTrainDummyInfo_CqgPath_IsValid;

	private static int SetTrainDummyInfo_CqgPath_Offset;

	private static FFieldAddress SetTrainDummyInfo_CqgPath_PropertyAddress;

	private static bool SetTrainDummyInfo_DPSCalTime_IsValid;

	private static int SetTrainDummyInfo_DPSCalTime_Offset;

	private static bool SetTrainDummyInfo_ReturnValue_IsValid;

	private static int SetTrainDummyInfo_ReturnValue_Offset;

	private static FFieldAddress SetTrainDummyInfo_ReturnValue_PropertyAddress;

	private static bool BGUUnitEquipFaBao_IsValid;

	private static IntPtr BGUUnitEquipFaBao_FunctionAddress;

	private static int BGUUnitEquipFaBao_ParamsSize;

	private static bool BGUUnitEquipFaBao_Unit_IsValid;

	private static int BGUUnitEquipFaBao_Unit_Offset;

	private static bool BGUUnitEquipFaBao_FaBaoID_IsValid;

	private static int BGUUnitEquipFaBao_FaBaoID_Offset;

	private static bool SwitchCameraGroup_IsValid;

	private static IntPtr SwitchCameraGroup_FunctionAddress;

	private static int SwitchCameraGroup_ParamsSize;

	private static bool SwitchCameraGroup_WorldContext_IsValid;

	private static int SwitchCameraGroup_WorldContext_Offset;

	private static bool SwitchCameraGroup_CameraGroupID_IsValid;

	private static int SwitchCameraGroup_CameraGroupID_Offset;

	private static bool BGUPlayLockTarget_IsValid;

	private static IntPtr BGUPlayLockTarget_FunctionAddress;

	private static int BGUPlayLockTarget_ParamsSize;

	private static bool BGUPlayLockTarget_Owner_IsValid;

	private static int BGUPlayLockTarget_Owner_Offset;

	private static bool BGUPlayLockTarget_TargetChr_IsValid;

	private static int BGUPlayLockTarget_TargetChr_Offset;

	private static bool BGUAISetSpeedRate_IsValid;

	private static IntPtr BGUAISetSpeedRate_FunctionAddress;

	private static int BGUAISetSpeedRate_ParamsSize;

	private static bool BGUAISetSpeedRate_Unit_IsValid;

	private static int BGUAISetSpeedRate_Unit_Offset;

	private static bool BGUAISetSpeedRate_SpeedRate_IsValid;

	private static int BGUAISetSpeedRate_SpeedRate_Offset;

	private static bool TimeLineNoiseTest_IsValid;

	private static IntPtr TimeLineNoiseTest_FunctionAddress;

	private static int TimeLineNoiseTest_ParamsSize;

	private static bool TimeLineNoiseTest_TotalTime_IsValid;

	private static int TimeLineNoiseTest_TotalTime_Offset;

	private static bool TimeLineNoiseTest_TimePointNum_IsValid;

	private static int TimeLineNoiseTest_TimePointNum_Offset;

	private static bool TimeLineNoiseTest_NoiseInterregional_IsValid;

	private static int TimeLineNoiseTest_NoiseInterregional_Offset;

	private static bool TimeLineNoiseTest_CurveFloat_IsValid;

	private static int TimeLineNoiseTest_CurveFloat_Offset;

	private static bool TimeLineNoiseTest_InterpMode_IsValid;

	private static int TimeLineNoiseTest_InterpMode_Offset;

	private static FFieldAddress TimeLineNoiseTest_InterpMode_PropertyAddress;

	private static bool BGUFullTransEnergy_IsValid;

	private static IntPtr BGUFullTransEnergy_FunctionAddress;

	private static int BGUFullTransEnergy_ParamsSize;

	private static bool BGUFullTransEnergy_WorldContext_IsValid;

	private static int BGUFullTransEnergy_WorldContext_Offset;

	private static bool InteruptPigsyStory_IsValid;

	private static IntPtr InteruptPigsyStory_FunctionAddress;

	private static int InteruptPigsyStory_ParamsSize;

	private static bool InteruptPigsyStory_Unit_IsValid;

	private static int InteruptPigsyStory_Unit_Offset;

	private static bool PlayFacialAnimTest_IsValid;

	private static IntPtr PlayFacialAnimTest_FunctionAddress;

	private static int PlayFacialAnimTest_ParamsSize;

	private static bool PlayFacialAnimTest_bPlay_IsValid;

	private static int PlayFacialAnimTest_bPlay_Offset;

	private static FFieldAddress PlayFacialAnimTest_bPlay_PropertyAddress;

	private static bool PlayFacialAnimTest_Unit_IsValid;

	private static int PlayFacialAnimTest_Unit_Offset;

	private static bool PlayFacialAnimTest_FacialAnim_IsValid;

	private static int PlayFacialAnimTest_FacialAnim_Offset;

	private static bool PlayFacialAnimTest_TimeOffset_IsValid;

	private static int PlayFacialAnimTest_TimeOffset_Offset;

	private static bool PlayFacialAnimTest_AutoBlendOutTime_IsValid;

	private static int PlayFacialAnimTest_AutoBlendOutTime_Offset;

	private static bool KJLSpawnProjectile_IsValid;

	private static IntPtr KJLSpawnProjectile_FunctionAddress;

	private static int KJLSpawnProjectile_ParamsSize;

	private static bool KJLSpawnProjectile_BulletSpawner_IsValid;

	private static int KJLSpawnProjectile_BulletSpawner_Offset;

	private static bool KJLSpawnProjectile_Target_IsValid;

	private static int KJLSpawnProjectile_Target_Offset;

	private static bool KJLSpawnProjectile_PointGeneratorTag_IsValid;

	private static int KJLSpawnProjectile_PointGeneratorTag_Offset;

	private static FFieldAddress KJLSpawnProjectile_PointGeneratorTag_PropertyAddress;

	private static bool KJLSpawnProjectile_BulletID_IsValid;

	private static int KJLSpawnProjectile_BulletID_Offset;

	private static bool KJLSpawnProjectile_LimitDistance_ToPlayer_IsValid;

	private static int KJLSpawnProjectile_LimitDistance_ToPlayer_Offset;

	private static bool KJLSpawnProjectile_LightningBeam_IsValid;

	private static int KJLSpawnProjectile_LightningBeam_Offset;

	private static bool KJLSpawnProjectile_LightningEndParamName_IsValid;

	private static int KJLSpawnProjectile_LightningEndParamName_Offset;

	private static FFieldAddress KJLSpawnProjectile_LightningEndParamName_PropertyAddress;

	private static bool KJLSpawnProjectile_SocketList_IsValid;

	private static int KJLSpawnProjectile_SocketList_Offset;

	private static FFieldAddress KJLSpawnProjectile_SocketList_PropertyAddress;

	private static bool KJLSpawnProjectile_DummyBulletNum_IsValid;

	private static int KJLSpawnProjectile_DummyBulletNum_Offset;

	private static bool KJLSpawnProjectile_EndPos_Noise_IsValid;

	private static int KJLSpawnProjectile_EndPos_Noise_Offset;

	private static FFieldAddress KJLSpawnProjectile_EndPos_Noise_PropertyAddress;

	private static bool KJLSpawnProjectile_DummyNiagara_IsValid;

	private static int KJLSpawnProjectile_DummyNiagara_Offset;

	private static bool KJLSpawnProjectile_DummyActiveDistance_IsValid;

	private static int KJLSpawnProjectile_DummyActiveDistance_Offset;

	private static bool KJLSpawnProjectile_RandomInterval_IsValid;

	private static int KJLSpawnProjectile_RandomInterval_Offset;

	private static FFieldAddress KJLSpawnProjectile_RandomInterval_PropertyAddress;

	private static bool BGUSetBehaviorTree_IsValid;

	private static IntPtr BGUSetBehaviorTree_FunctionAddress;

	private static int BGUSetBehaviorTree_ParamsSize;

	private static bool BGUSetBehaviorTree_Unit_IsValid;

	private static int BGUSetBehaviorTree_Unit_Offset;

	private static bool BGUSetBehaviorTree_BT_IsValid;

	private static int BGUSetBehaviorTree_BT_Offset;

	private static bool BGUSpawnGhostActor_IsValid;

	private static IntPtr BGUSpawnGhostActor_FunctionAddress;

	private static int BGUSpawnGhostActor_ParamsSize;

	private static bool BGUSpawnGhostActor_Target_IsValid;

	private static int BGUSpawnGhostActor_Target_Offset;

	private static bool BGUSpawnGhostActor_DAPath_IsValid;

	private static int BGUSpawnGhostActor_DAPath_Offset;

	private static FFieldAddress BGUSpawnGhostActor_DAPath_PropertyAddress;

	private static bool SwitchLanguageEnZh_IsValid;

	private static IntPtr SwitchLanguageEnZh_FunctionAddress;

	private static int SwitchLanguageEnZh_ParamsSize;

	private static bool BGUToggleGlobalURO_IsValid;

	private static IntPtr BGUToggleGlobalURO_FunctionAddress;

	private static int BGUToggleGlobalURO_ParamsSize;

	private static bool BGUToggleGlobalURO_UObj_IsValid;

	private static int BGUToggleGlobalURO_UObj_Offset;

	private static bool BGUToggleGlobalURO_bEnable_IsValid;

	private static int BGUToggleGlobalURO_bEnable_Offset;

	private static FFieldAddress BGUToggleGlobalURO_bEnable_PropertyAddress;

	private static bool BGURemoveImmobility_IsValid;

	private static IntPtr BGURemoveImmobility_FunctionAddress;

	private static int BGURemoveImmobility_ParamsSize;

	private static bool BGURemoveImmobility_Unit_IsValid;

	private static int BGURemoveImmobility_Unit_Offset;

	private static bool BGUTriggerUnitState_IsValid;

	private static IntPtr BGUTriggerUnitState_FunctionAddress;

	private static int BGUTriggerUnitState_ParamsSize;

	private static bool BGUTriggerUnitState_Actor_IsValid;

	private static int BGUTriggerUnitState_Actor_Offset;

	private static bool BGUTriggerUnitState_StateTrigger_IsValid;

	private static int BGUTriggerUnitState_StateTrigger_Offset;

	private static FFieldAddress BGUTriggerUnitState_StateTrigger_PropertyAddress;

	private static bool BGUTriggerUnitState_Time_IsValid;

	private static int BGUTriggerUnitState_Time_Offset;

	private static bool DisablePhysicalMove_IsValid;

	private static IntPtr DisablePhysicalMove_FunctionAddress;

	private static int DisablePhysicalMove_ParamsSize;

	private static bool DisablePhysicalMove_Unit_IsValid;

	private static int DisablePhysicalMove_Unit_Offset;

	private static bool DisablePhysicalMove_bDisable_IsValid;

	private static int DisablePhysicalMove_bDisable_Offset;

	private static FFieldAddress DisablePhysicalMove_bDisable_PropertyAddress;

	private static bool BGUUnitUnequipFaBao_IsValid;

	private static IntPtr BGUUnitUnequipFaBao_FunctionAddress;

	private static int BGUUnitUnequipFaBao_ParamsSize;

	private static bool BGUUnitUnequipFaBao_Unit_IsValid;

	private static int BGUUnitUnequipFaBao_Unit_Offset;

	private static bool FindTraceStatResult_IsValid;

	private static IntPtr FindTraceStatResult_FunctionAddress;

	private static int FindTraceStatResult_ParamsSize;

	private static bool FindTraceStatResult_WorldContext_IsValid;

	private static int FindTraceStatResult_WorldContext_Offset;

	private static bool FindTraceStatResult_Name_IsValid;

	private static int FindTraceStatResult_Name_Offset;

	private static FFieldAddress FindTraceStatResult_Name_PropertyAddress;

	private static bool FindTraceStatResult_ReturnValue_IsValid;

	private static int FindTraceStatResult_ReturnValue_Offset;

	private static bool BGUGetWeaponByIndex_IsValid;

	private static IntPtr BGUGetWeaponByIndex_FunctionAddress;

	private static int BGUGetWeaponByIndex_ParamsSize;

	private static bool BGUGetWeaponByIndex_Owner_IsValid;

	private static int BGUGetWeaponByIndex_Owner_Offset;

	private static bool BGUGetWeaponByIndex_index_IsValid;

	private static int BGUGetWeaponByIndex_index_Offset;

	private static bool BGUGetWeaponByIndex_ReturnValue_IsValid;

	private static int BGUGetWeaponByIndex_ReturnValue_Offset;

	private static bool BGUSetSecondFogData_IsValid;

	private static IntPtr BGUSetSecondFogData_FunctionAddress;

	private static int BGUSetSecondFogData_ParamsSize;

	private static bool BGUSetSecondFogData_ehfcomp_IsValid;

	private static int BGUSetSecondFogData_ehfcomp_Offset;

	private static bool BGUSetSecondFogData_SecondFogData_IsValid;

	private static int BGUSetSecondFogData_SecondFogData_Offset;

	private static FFieldAddress BGUSetSecondFogData_SecondFogData_PropertyAddress;

	private static bool SkipCurrentSequence_IsValid;

	private static IntPtr SkipCurrentSequence_FunctionAddress;

	private static int SkipCurrentSequence_ParamsSize;

	private static bool SkipCurrentSequence_WorldContext_IsValid;

	private static int SkipCurrentSequence_WorldContext_Offset;

	private static bool ClearPhysAnimSetting_IsValid;

	private static IntPtr ClearPhysAnimSetting_FunctionAddress;

	private static int ClearPhysAnimSetting_ParamsSize;

	private static bool ClearPhysAnimSetting_Unit_IsValid;

	private static int ClearPhysAnimSetting_Unit_Offset;

	private static bool ClearPhysAnimSetting_ReturnValue_IsValid;

	private static int ClearPhysAnimSetting_ReturnValue_Offset;

	private static bool BGUPlatformPatroMove_IsValid;

	private static IntPtr BGUPlatformPatroMove_FunctionAddress;

	private static int BGUPlatformPatroMove_ParamsSize;

	private static bool BGUPlatformPatroMove_Unit_IsValid;

	private static int BGUPlatformPatroMove_Unit_Offset;

	private static bool BGUPlatformPatroMove_BeginPos_IsValid;

	private static int BGUPlatformPatroMove_BeginPos_Offset;

	private static FFieldAddress BGUPlatformPatroMove_BeginPos_PropertyAddress;

	private static bool BGUPlatformPatroMove_EndPos_IsValid;

	private static int BGUPlatformPatroMove_EndPos_Offset;

	private static FFieldAddress BGUPlatformPatroMove_EndPos_PropertyAddress;

	private static bool BGUPlatformPatroMove_Speed_IsValid;

	private static int BGUPlatformPatroMove_Speed_Offset;

	private static bool BGUPlatformPatroRota_IsValid;

	private static IntPtr BGUPlatformPatroRota_FunctionAddress;

	private static int BGUPlatformPatroRota_ParamsSize;

	private static bool BGUPlatformPatroRota_Unit_IsValid;

	private static int BGUPlatformPatroRota_Unit_Offset;

	private static bool BGUPlatformPatroRota_MaxRate_IsValid;

	private static int BGUPlatformPatroRota_MaxRate_Offset;

	private static bool BGUPlatformPatroRota_Speed_IsValid;

	private static int BGUPlatformPatroRota_Speed_Offset;

	private static bool ExitWeakPerformState_IsValid;

	private static IntPtr ExitWeakPerformState_FunctionAddress;

	private static int ExitWeakPerformState_ParamsSize;

	private static bool ExitWeakPerformState_InWorldContext_IsValid;

	private static int ExitWeakPerformState_InWorldContext_Offset;

	private static bool BGUGetCachedPointSet_IsValid;

	private static IntPtr BGUGetCachedPointSet_FunctionAddress;

	private static int BGUGetCachedPointSet_ParamsSize;

	private static bool BGUGetCachedPointSet_OwnerCharacter_IsValid;

	private static int BGUGetCachedPointSet_OwnerCharacter_Offset;

	private static bool BGUGetCachedPointSet_RequestID_IsValid;

	private static int BGUGetCachedPointSet_RequestID_Offset;

	private static bool BGUGetCachedPointSet_ReturnValue_IsValid;

	private static int BGUGetCachedPointSet_ReturnValue_Offset;

	private static FFieldAddress BGUGetCachedPointSet_ReturnValue_PropertyAddress;

	private static bool DestroyAllProjectile_IsValid;

	private static IntPtr DestroyAllProjectile_FunctionAddress;

	private static int DestroyAllProjectile_ParamsSize;

	private static bool DestroyAllProjectile_Unit_IsValid;

	private static int DestroyAllProjectile_Unit_Offset;

	private static bool SwitchFreeCameraMode_IsValid;

	private static IntPtr SwitchFreeCameraMode_FunctionAddress;

	private static int SwitchFreeCameraMode_ParamsSize;

	private static bool SwitchFreeCameraMode_InWorldContext_IsValid;

	private static int SwitchFreeCameraMode_InWorldContext_Offset;

	private static bool TriggerSwitchPhysics_IsValid;

	private static IntPtr TriggerSwitchPhysics_FunctionAddress;

	private static int TriggerSwitchPhysics_ParamsSize;

	private static bool TriggerSwitchPhysics_Unit_IsValid;

	private static int TriggerSwitchPhysics_Unit_Offset;

	private static bool TriggerSwitchPhysics_ReturnValue_IsValid;

	private static int TriggerSwitchPhysics_ReturnValue_Offset;

	private static bool BGUGetActiveGameMode_IsValid;

	private static IntPtr BGUGetActiveGameMode_FunctionAddress;

	private static int BGUGetActiveGameMode_ParamsSize;

	private static bool BGUGetActiveGameMode_ReturnValue_IsValid;

	private static int BGUGetActiveGameMode_ReturnValue_Offset;

	private static bool GetProjectBranchName_IsValid;

	private static IntPtr GetProjectBranchName_FunctionAddress;

	private static int GetProjectBranchName_ParamsSize;

	private static bool GetProjectBranchName_ReturnValue_IsValid;

	private static int GetProjectBranchName_ReturnValue_Offset;

	private static FFieldAddress GetProjectBranchName_ReturnValue_PropertyAddress;

	private static bool SetTamerStrategyArea_IsValid;

	private static IntPtr SetTamerStrategyArea_FunctionAddress;

	private static int SetTamerStrategyArea_ParamsSize;

	private static bool SetTamerStrategyArea_InWorldContext_IsValid;

	private static int SetTamerStrategyArea_InWorldContext_Offset;

	private static bool SetTamerStrategyArea_InArea_IsValid;

	private static int SetTamerStrategyArea_InArea_Offset;

	private static FFieldAddress SetTamerStrategyArea_InArea_PropertyAddress;

	private static bool HandleAiConversation_IsValid;

	private static IntPtr HandleAiConversation_FunctionAddress;

	private static int HandleAiConversation_ParamsSize;

	private static bool HandleAiConversation_Caster_IsValid;

	private static int HandleAiConversation_Caster_Offset;

	private static bool HandleAiConversation_ConversationContentID_IsValid;

	private static int HandleAiConversation_ConversationContentID_Offset;

	private static bool EnterWeakPerformState_IsValid;

	private static IntPtr EnterWeakPerformState_FunctionAddress;

	private static int EnterWeakPerformState_ParamsSize;

	private static bool EnterWeakPerformState_InWorldContext_IsValid;

	private static int EnterWeakPerformState_InWorldContext_Offset;

	private static bool EnterWeakPerformState_ConfigID_IsValid;

	private static int EnterWeakPerformState_ConfigID_Offset;

	private static bool ExitPlayerSkillCamera_IsValid;

	private static IntPtr ExitPlayerSkillCamera_FunctionAddress;

	private static int ExitPlayerSkillCamera_ParamsSize;

	private static bool ExitPlayerSkillCamera_WorldContext_IsValid;

	private static int ExitPlayerSkillCamera_WorldContext_Offset;

	private static bool BGUHasUnitSimpleState_IsValid;

	private static IntPtr BGUHasUnitSimpleState_FunctionAddress;

	private static int BGUHasUnitSimpleState_ParamsSize;

	private static bool BGUHasUnitSimpleState_Unit_IsValid;

	private static int BGUHasUnitSimpleState_Unit_Offset;

	private static bool BGUHasUnitSimpleState_SimpleState_IsValid;

	private static int BGUHasUnitSimpleState_SimpleState_Offset;

	private static FFieldAddress BGUHasUnitSimpleState_SimpleState_PropertyAddress;

	private static bool BGUHasUnitSimpleState_ReturnValue_IsValid;

	private static int BGUHasUnitSimpleState_ReturnValue_Offset;

	private static FFieldAddress BGUHasUnitSimpleState_ReturnValue_PropertyAddress;

	private static bool CheckCurCeilingHeight_IsValid;

	private static IntPtr CheckCurCeilingHeight_FunctionAddress;

	private static int CheckCurCeilingHeight_ParamsSize;

	private static bool CheckCurCeilingHeight_Character_IsValid;

	private static int CheckCurCeilingHeight_Character_Offset;

	private static bool CheckCurCeilingHeight_LineTraceLength_IsValid;

	private static int CheckCurCeilingHeight_LineTraceLength_Offset;

	private static bool CheckCurCeilingHeight_ReturnValue_IsValid;

	private static int CheckCurCeilingHeight_ReturnValue_Offset;

	private static bool TriggerEffectToTarget_IsValid;

	private static IntPtr TriggerEffectToTarget_FunctionAddress;

	private static int TriggerEffectToTarget_ParamsSize;

	private static bool TriggerEffectToTarget_Unit_IsValid;

	private static int TriggerEffectToTarget_Unit_Offset;

	private static bool TriggerEffectToTarget_EffectID_IsValid;

	private static int TriggerEffectToTarget_EffectID_Offset;

	private static bool TriggerEffectToTarget_Target_IsValid;

	private static int TriggerEffectToTarget_Target_Offset;

	private static bool BGUUnitCastFaBaoSkill_IsValid;

	private static IntPtr BGUUnitCastFaBaoSkill_FunctionAddress;

	private static int BGUUnitCastFaBaoSkill_ParamsSize;

	private static bool BGUUnitCastFaBaoSkill_Unit_IsValid;

	private static int BGUUnitCastFaBaoSkill_Unit_Offset;

	private static bool BGUSetUnitSimpleState_IsValid;

	private static IntPtr BGUSetUnitSimpleState_FunctionAddress;

	private static int BGUSetUnitSimpleState_ParamsSize;

	private static bool BGUSetUnitSimpleState_Unit_IsValid;

	private static int BGUSetUnitSimpleState_Unit_Offset;

	private static bool BGUSetUnitSimpleState_SimpleState_IsValid;

	private static int BGUSetUnitSimpleState_SimpleState_Offset;

	private static FFieldAddress BGUSetUnitSimpleState_SimpleState_PropertyAddress;

	private static bool BGUSetUnitSimpleState_IsRemove_IsValid;

	private static int BGUSetUnitSimpleState_IsRemove_Offset;

	private static FFieldAddress BGUSetUnitSimpleState_IsRemove_PropertyAddress;

	private static bool BGUSetSkillSuperArmor_IsValid;

	private static IntPtr BGUSetSkillSuperArmor_FunctionAddress;

	private static int BGUSetSkillSuperArmor_ParamsSize;

	private static bool BGUSetSkillSuperArmor_Unit_IsValid;

	private static int BGUSetSkillSuperArmor_Unit_Offset;

	private static bool BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_IsValid;

	private static int BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_Offset;

	private static bool BGUSetSkillSuperArmor_SkillSuperArmorValue_IsValid;

	private static int BGUSetSkillSuperArmor_SkillSuperArmorValue_Offset;

	private static bool BGUCallPointsRegister_IsValid;

	private static IntPtr BGUCallPointsRegister_FunctionAddress;

	private static int BGUCallPointsRegister_ParamsSize;

	private static bool BGUCallPointsRegister_OwnerCharacter_IsValid;

	private static int BGUCallPointsRegister_OwnerCharacter_Offset;

	private static bool BGUCallPointsRegister_RequestID_IsValid;

	private static int BGUCallPointsRegister_RequestID_Offset;

	private static bool BGUCallPointsRegister_GenType_IsValid;

	private static int BGUCallPointsRegister_GenType_Offset;

	private static FFieldAddress BGUCallPointsRegister_GenType_PropertyAddress;

	private static bool BGUCallPointsRegister_ExtParam_IsValid;

	private static int BGUCallPointsRegister_ExtParam_Offset;

	private static FFieldAddress BGUCallPointsRegister_ExtParam_PropertyAddress;

	private static bool BGUGetCurrentUserType_IsValid;

	private static IntPtr BGUGetCurrentUserType_FunctionAddress;

	private static int BGUGetCurrentUserType_ParamsSize;

	private static bool BGUGetCurrentUserType_ReturnValue_IsValid;

	private static int BGUGetCurrentUserType_ReturnValue_Offset;

	private static bool TryGetComponentByFName_IsValid;

	private static IntPtr TryGetComponentByFName_FunctionAddress;

	private static int TryGetComponentByFName_ParamsSize;

	private static bool TryGetComponentByFName_Actor_IsValid;

	private static int TryGetComponentByFName_Actor_Offset;

	private static bool TryGetComponentByFName_Name_IsValid;

	private static int TryGetComponentByFName_Name_Offset;

	private static bool TryGetComponentByFName_ReturnValue_IsValid;

	private static int TryGetComponentByFName_ReturnValue_Offset;

	private static bool BGUHandleAbnormalState_IsValid;

	private static IntPtr BGUHandleAbnormalState_FunctionAddress;

	private static int BGUHandleAbnormalState_ParamsSize;

	private static bool BGUHandleAbnormalState_Attacker_IsValid;

	private static int BGUHandleAbnormalState_Attacker_Offset;

	private static bool BGUHandleAbnormalState_Victim_IsValid;

	private static int BGUHandleAbnormalState_Victim_Offset;

	private static bool BGUHandleAbnormalState_config_IsValid;

	private static int BGUHandleAbnormalState_config_Offset;

	private static FFieldAddress BGUHandleAbnormalState_config_PropertyAddress;

	private static bool BGUHandleAbnormalState_AddValue_IsValid;

	private static int BGUHandleAbnormalState_AddValue_Offset;

	private static bool BGUSetUnitCritRateBase_IsValid;

	private static IntPtr BGUSetUnitCritRateBase_FunctionAddress;

	private static int BGUSetUnitCritRateBase_ParamsSize;

	private static bool BGUSetUnitCritRateBase_Unit_IsValid;

	private static int BGUSetUnitCritRateBase_Unit_Offset;

	private static bool BGUSetUnitCritRateBase_CritRate_IsValid;

	private static int BGUSetUnitCritRateBase_CritRate_Offset;

	private static bool EnterPlayerSkillCamera_IsValid;

	private static IntPtr EnterPlayerSkillCamera_FunctionAddress;

	private static int EnterPlayerSkillCamera_ParamsSize;

	private static bool EnterPlayerSkillCamera_WorldContext_IsValid;

	private static int EnterPlayerSkillCamera_WorldContext_Offset;

	private static bool EnterPlayerSkillCamera_CameraID_IsValid;

	private static int EnterPlayerSkillCamera_CameraID_Offset;

	private static bool SetCameraFocusDistance_IsValid;

	private static IntPtr SetCameraFocusDistance_FunctionAddress;

	private static int SetCameraFocusDistance_ParamsSize;

	private static bool SetCameraFocusDistance_CameraActor_IsValid;

	private static int SetCameraFocusDistance_CameraActor_Offset;

	private static bool SetCameraFocusDistance_NewFocusDistance_IsValid;

	private static int SetCameraFocusDistance_NewFocusDistance_Offset;

	private static bool GetCameraFocusDistance_IsValid;

	private static IntPtr GetCameraFocusDistance_FunctionAddress;

	private static int GetCameraFocusDistance_ParamsSize;

	private static bool GetCameraFocusDistance_CameraActor_IsValid;

	private static int GetCameraFocusDistance_CameraActor_Offset;

	private static bool GetCameraFocusDistance_ReturnValue_IsValid;

	private static int GetCameraFocusDistance_ReturnValue_Offset;

	private static bool ExitMonsterSkillCamera_IsValid;

	private static IntPtr ExitMonsterSkillCamera_FunctionAddress;

	private static int ExitMonsterSkillCamera_ParamsSize;

	private static bool ExitMonsterSkillCamera_Monster_IsValid;

	private static int ExitMonsterSkillCamera_Monster_Offset;

	private static bool GetUnitLockTargetActor_IsValid;

	private static IntPtr GetUnitLockTargetActor_FunctionAddress;

	private static int GetUnitLockTargetActor_ParamsSize;

	private static bool GetUnitLockTargetActor_Unit_IsValid;

	private static int GetUnitLockTargetActor_Unit_Offset;

	private static bool GetUnitLockTargetActor_ReturnValue_IsValid;

	private static int GetUnitLockTargetActor_ReturnValue_Offset;

	private static bool BGUSetCanTriggerGroupAI_IsValid;

	private static IntPtr BGUSetCanTriggerGroupAI_FunctionAddress;

	private static int BGUSetCanTriggerGroupAI_ParamsSize;

	private static bool BGUSetCanTriggerGroupAI_WorldContext_IsValid;

	private static int BGUSetCanTriggerGroupAI_WorldContext_Offset;

	private static bool BGUSetCanTriggerGroupAI_CanTrigger_IsValid;

	private static int BGUSetCanTriggerGroupAI_CanTrigger_Offset;

	private static FFieldAddress BGUSetCanTriggerGroupAI_CanTrigger_PropertyAddress;

	private static bool EnterMonsterSkillCamera_IsValid;

	private static IntPtr EnterMonsterSkillCamera_FunctionAddress;

	private static int EnterMonsterSkillCamera_ParamsSize;

	private static bool EnterMonsterSkillCamera_Monster_IsValid;

	private static int EnterMonsterSkillCamera_Monster_Offset;

	private static bool EnterMonsterSkillCamera_CameraID_IsValid;

	private static int EnterMonsterSkillCamera_CameraID_Offset;

	private static bool BGUSpawnActorNoBeginPlay_IsValid;

	private static IntPtr BGUSpawnActorNoBeginPlay_FunctionAddress;

	private static int BGUSpawnActorNoBeginPlay_ParamsSize;

	private static bool BGUSpawnActorNoBeginPlay__World_IsValid;

	private static int BGUSpawnActorNoBeginPlay__World_Offset;

	private static bool BGUSpawnActorNoBeginPlay_ActorClass_IsValid;

	private static int BGUSpawnActorNoBeginPlay_ActorClass_Offset;

	private static bool BGUSpawnActorNoBeginPlay_ReturnValue_IsValid;

	private static int BGUSpawnActorNoBeginPlay_ReturnValue_Offset;

	private static bool PrepareForSkillRecording_IsValid;

	private static IntPtr PrepareForSkillRecording_FunctionAddress;

	private static int PrepareForSkillRecording_ParamsSize;

	private static bool PrepareForSkillRecording_World_IsValid;

	private static int PrepareForSkillRecording_World_Offset;

	private static bool PrepareForSkillRecording_UnitClass_IsValid;

	private static int PrepareForSkillRecording_UnitClass_Offset;

	private static bool PrepareForSkillRecording_ResID_IsValid;

	private static int PrepareForSkillRecording_ResID_Offset;

	private static bool PrepareForSkillRecording_SkillID_IsValid;

	private static int PrepareForSkillRecording_SkillID_Offset;

	private static bool PrepareForSkillRecording_bNeedsSpawnNewUnit_IsValid;

	private static int PrepareForSkillRecording_bNeedsSpawnNewUnit_Offset;

	private static FFieldAddress PrepareForSkillRecording_bNeedsSpawnNewUnit_PropertyAddress;

	private static bool PrepareForSkillRecording_SpawnedUnit_IsValid;

	private static int PrepareForSkillRecording_SpawnedUnit_Offset;

	private static bool PrepareForSkillRecording_PlayedMontage_IsValid;

	private static int PrepareForSkillRecording_PlayedMontage_Offset;

	private static bool BGURemoveSkillSuperArmor_IsValid;

	private static IntPtr BGURemoveSkillSuperArmor_FunctionAddress;

	private static int BGURemoveSkillSuperArmor_ParamsSize;

	private static bool BGURemoveSkillSuperArmor_Unit_IsValid;

	private static int BGURemoveSkillSuperArmor_Unit_Offset;

	private static bool ClampAndAlignToLandScape_IsValid;

	private static IntPtr ClampAndAlignToLandScape_FunctionAddress;

	private static int ClampAndAlignToLandScape_ParamsSize;

	private static bool ClampAndAlignToLandScape_Unit_IsValid;

	private static int ClampAndAlignToLandScape_Unit_Offset;

	private static bool ClampAndAlignToLandScape_ClampToLand_IsValid;

	private static int ClampAndAlignToLandScape_ClampToLand_Offset;

	private static FFieldAddress ClampAndAlignToLandScape_ClampToLand_PropertyAddress;

	private static bool ClampAndAlignToLandScape_AlignToLand_IsValid;

	private static int ClampAndAlignToLandScape_AlignToLand_Offset;

	private static FFieldAddress ClampAndAlignToLandScape_AlignToLand_PropertyAddress;

	private static bool ClampAndAlignToLandScape_DeltaTime_IsValid;

	private static int ClampAndAlignToLandScape_DeltaTime_Offset;

	private static bool ClampAndAlignToLandScape_InterpSpd_IsValid;

	private static int ClampAndAlignToLandScape_InterpSpd_Offset;

	private static bool BGURemoveBuffImmediately_IsValid;

	private static IntPtr BGURemoveBuffImmediately_FunctionAddress;

	private static int BGURemoveBuffImmediately_ParamsSize;

	private static bool BGURemoveBuffImmediately_Unit_IsValid;

	private static int BGURemoveBuffImmediately_Unit_Offset;

	private static bool BGURemoveBuffImmediately_BuffID_IsValid;

	private static int BGURemoveBuffImmediately_BuffID_Offset;

	private static bool BGURemoveBuffImmediately_EffectTriggerType_IsValid;

	private static int BGURemoveBuffImmediately_EffectTriggerType_Offset;

	private static FFieldAddress BGURemoveBuffImmediately_EffectTriggerType_PropertyAddress;

	private static bool BGUOneHitBreakImmobility_IsValid;

	private static IntPtr BGUOneHitBreakImmobility_FunctionAddress;

	private static int BGUOneHitBreakImmobility_ParamsSize;

	private static bool BGUOneHitBreakImmobility_Unit_IsValid;

	private static int BGUOneHitBreakImmobility_Unit_Offset;

	private static bool CastMagicallyChangeSkill_IsValid;

	private static IntPtr CastMagicallyChangeSkill_FunctionAddress;

	private static int CastMagicallyChangeSkill_ParamsSize;

	private static bool CastMagicallyChangeSkill_Unit_IsValid;

	private static int CastMagicallyChangeSkill_Unit_Offset;

	private static bool CastMagicallyChangeSkill_Config_IsValid;

	private static int CastMagicallyChangeSkill_Config_Offset;

	private static bool CastMagicallyChangeSkill_SkillID_IsValid;

	private static int CastMagicallyChangeSkill_SkillID_Offset;

	private static bool CastMagicallyChangeSkill_RecoverSkillID_IsValid;

	private static int CastMagicallyChangeSkill_RecoverSkillID_Offset;

	private static bool CanActivateConsoleCommad_IsValid;

	private static IntPtr CanActivateConsoleCommad_FunctionAddress;

	private static int CanActivateConsoleCommad_ParamsSize;

	private static bool CanActivateConsoleCommad_ReturnValue_IsValid;

	private static int CanActivateConsoleCommad_ReturnValue_Offset;

	private static FFieldAddress CanActivateConsoleCommad_ReturnValue_PropertyAddress;

	private static bool GetCineCameraFocalLength_IsValid;

	private static IntPtr GetCineCameraFocalLength_FunctionAddress;

	private static int GetCineCameraFocalLength_ParamsSize;

	private static bool GetCineCameraFocalLength_CineCameraActor_IsValid;

	private static int GetCineCameraFocalLength_CineCameraActor_Offset;

	private static bool GetCineCameraFocalLength_ReturnValue_IsValid;

	private static int GetCineCameraFocalLength_ReturnValue_Offset;

	private static bool SetCineCameraFocalLength_IsValid;

	private static IntPtr SetCineCameraFocalLength_FunctionAddress;

	private static int SetCineCameraFocalLength_ParamsSize;

	private static bool SetCineCameraFocalLength_CineCameraActor_IsValid;

	private static int SetCineCameraFocalLength_CineCameraActor_Offset;

	private static bool SetCineCameraFocalLength_NewFocalLength_IsValid;

	private static int SetCineCameraFocalLength_NewFocalLength_Offset;

	private static bool TestProfileSimpleOverlap_IsValid;

	private static IntPtr TestProfileSimpleOverlap_FunctionAddress;

	private static int TestProfileSimpleOverlap_ParamsSize;

	private static bool TestProfileSimpleOverlap_WorldContext_IsValid;

	private static int TestProfileSimpleOverlap_WorldContext_Offset;

	private static bool BGUPlayerCameraLockTarget_IsValid;

	private static IntPtr BGUPlayerCameraLockTarget_FunctionAddress;

	private static int BGUPlayerCameraLockTarget_ParamsSize;

	private static bool BGUPlayerCameraLockTarget_Player_IsValid;

	private static int BGUPlayerCameraLockTarget_Player_Offset;

	private static bool BGUPlayerCameraLockTarget_Target_IsValid;

	private static int BGUPlayerCameraLockTarget_Target_Offset;

	private static bool BGUClosestPerceivedTarget_IsValid;

	private static IntPtr BGUClosestPerceivedTarget_FunctionAddress;

	private static int BGUClosestPerceivedTarget_ParamsSize;

	private static bool BGUClosestPerceivedTarget_Unit_IsValid;

	private static int BGUClosestPerceivedTarget_Unit_Offset;

	private static bool BGUClosestPerceivedTarget_ReturnValue_IsValid;

	private static int BGUClosestPerceivedTarget_ReturnValue_Offset;

	private static bool ExportAllTamerToDataAsset_IsValid;

	private static IntPtr ExportAllTamerToDataAsset_FunctionAddress;

	private static int ExportAllTamerToDataAsset_ParamsSize;

	private static bool BGUTryDestroyDestructible_IsValid;

	private static IntPtr BGUTryDestroyDestructible_FunctionAddress;

	private static int BGUTryDestroyDestructible_ParamsSize;

	private static bool BGUTryDestroyDestructible_DestructibleActor_IsValid;

	private static int BGUTryDestroyDestructible_DestructibleActor_Offset;

	private static bool BGUCalcCharacterRotOnSlope_IsValid;

	private static IntPtr BGUCalcCharacterRotOnSlope_FunctionAddress;

	private static int BGUCalcCharacterRotOnSlope_ParamsSize;

	private static bool BGUCalcCharacterRotOnSlope_OwnerChr_IsValid;

	private static int BGUCalcCharacterRotOnSlope_OwnerChr_Offset;

	private static bool BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_IsValid;

	private static int BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_Offset;

	private static FFieldAddress BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_PropertyAddress;

	private static bool BGUCalcCharacterRotOnSlope_ReturnValue_IsValid;

	private static int BGUCalcCharacterRotOnSlope_ReturnValue_Offset;

	private static FFieldAddress BGUCalcCharacterRotOnSlope_ReturnValue_PropertyAddress;

	private static bool BGUPlatformPatroMoveSingle_IsValid;

	private static IntPtr BGUPlatformPatroMoveSingle_FunctionAddress;

	private static int BGUPlatformPatroMoveSingle_ParamsSize;

	private static bool BGUPlatformPatroMoveSingle_Unit_IsValid;

	private static int BGUPlatformPatroMoveSingle_Unit_Offset;

	private static bool BGUPlatformPatroMoveSingle_BeginPos_IsValid;

	private static int BGUPlatformPatroMoveSingle_BeginPos_Offset;

	private static FFieldAddress BGUPlatformPatroMoveSingle_BeginPos_PropertyAddress;

	private static bool BGUPlatformPatroMoveSingle_EndPos_IsValid;

	private static int BGUPlatformPatroMoveSingle_EndPos_Offset;

	private static FFieldAddress BGUPlatformPatroMoveSingle_EndPos_PropertyAddress;

	private static bool BGUPlatformPatroMoveSingle_Speed_IsValid;

	private static int BGUPlatformPatroMoveSingle_Speed_Offset;

	private static bool BGUPlatformPatroMoveSingle_PlayerCount_IsValid;

	private static int BGUPlatformPatroMoveSingle_PlayerCount_Offset;

	private static bool BGUPlatformPatroMoveSingle_Range_IsValid;

	private static int BGUPlatformPatroMoveSingle_Range_Offset;

	private static bool BGUGetMultiPointCurrentUnit_IsValid;

	private static IntPtr BGUGetMultiPointCurrentUnit_FunctionAddress;

	private static int BGUGetMultiPointCurrentUnit_ParamsSize;

	private static bool BGUGetMultiPointCurrentUnit_Actor_IsValid;

	private static int BGUGetMultiPointCurrentUnit_Actor_Offset;

	private static bool BGUGetMultiPointCurrentUnit_ReturnValue_IsValid;

	private static int BGUGetMultiPointCurrentUnit_ReturnValue_Offset;

	private static bool BGUEnablePlayerGuiBeiCamera_IsValid;

	private static IntPtr BGUEnablePlayerGuiBeiCamera_FunctionAddress;

	private static int BGUEnablePlayerGuiBeiCamera_ParamsSize;

	private static bool BGUEnablePlayerGuiBeiCamera_WorldContext_IsValid;

	private static int BGUEnablePlayerGuiBeiCamera_WorldContext_Offset;

	private static bool BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_IsValid;

	private static int BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_Offset;

	private static FFieldAddress BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_PropertyAddress;

	private static bool GenerateNavMeshBoundsVolumes_IsValid;

	private static IntPtr GenerateNavMeshBoundsVolumes_FunctionAddress;

	private static int GenerateNavMeshBoundsVolumes_ParamsSize;

	private static bool GenerateNavMeshBoundsVolumes_TempleteActor_IsValid;

	private static int GenerateNavMeshBoundsVolumes_TempleteActor_Offset;

	private static bool BGUDisablePlayerGuiBeiCamera_IsValid;

	private static IntPtr BGUDisablePlayerGuiBeiCamera_FunctionAddress;

	private static int BGUDisablePlayerGuiBeiCamera_ParamsSize;

	private static bool BGUDisablePlayerGuiBeiCamera_WorldContext_IsValid;

	private static int BGUDisablePlayerGuiBeiCamera_WorldContext_Offset;

	private static bool BGUSpawnActorAndECSBeginPlay_IsValid;

	private static IntPtr BGUSpawnActorAndECSBeginPlay_FunctionAddress;

	private static int BGUSpawnActorAndECSBeginPlay_ParamsSize;

	private static bool BGUSpawnActorAndECSBeginPlay__World_IsValid;

	private static int BGUSpawnActorAndECSBeginPlay__World_Offset;

	private static bool BGUSpawnActorAndECSBeginPlay_ActorClass_IsValid;

	private static int BGUSpawnActorAndECSBeginPlay_ActorClass_Offset;

	private static bool BGUSpawnActorAndECSBeginPlay_ReturnValue_IsValid;

	private static int BGUSpawnActorAndECSBeginPlay_ReturnValue_Offset;

	private static bool ExportBulletSkillToDataAsset_IsValid;

	private static IntPtr ExportBulletSkillToDataAsset_FunctionAddress;

	private static int ExportBulletSkillToDataAsset_ParamsSize;

	private static bool ExportBulletSkillToDataAsset_TM_IsValid;

	private static int ExportBulletSkillToDataAsset_TM_Offset;

	private static bool ExportTamerListToNewDAByBlame_IsValid;

	private static IntPtr ExportTamerListToNewDAByBlame_FunctionAddress;

	private static int ExportTamerListToNewDAByBlame_ParamsSize;

	private static bool ExportTamerListToNewDAByBlame_Actor_IsValid;

	private static int ExportTamerListToNewDAByBlame_Actor_Offset;

	private static bool ExportTamerListToNewDAByBlame_OldTamer_IsValid;

	private static int ExportTamerListToNewDAByBlame_OldTamer_Offset;

	private static FFieldAddress ExportTamerListToNewDAByBlame_OldTamer_PropertyAddress;

	private static bool ExportTamerListToNewDAByBlame_NewTimer_IsValid;

	private static int ExportTamerListToNewDAByBlame_NewTimer_Offset;

	private static FFieldAddress ExportTamerListToNewDAByBlame_NewTimer_PropertyAddress;

	private static bool ExportTamerListToNewDAByBlame_BlameName_IsValid;

	private static int ExportTamerListToNewDAByBlame_BlameName_Offset;

	private static FFieldAddress ExportTamerListToNewDAByBlame_BlameName_PropertyAddress;

	private static bool ExportTamerListToNewDAByBlame_ReturnValue_IsValid;

	private static int ExportTamerListToNewDAByBlame_ReturnValue_Offset;

	private static FFieldAddress ExportTamerListToNewDAByBlame_ReturnValue_PropertyAddress;

	private static bool PlayCamShakeWithControlByClass_IsValid;

	private static IntPtr PlayCamShakeWithControlByClass_FunctionAddress;

	private static int PlayCamShakeWithControlByClass_ParamsSize;

	private static bool PlayCamShakeWithControlByClass_CameraShakeCls_IsValid;

	private static int PlayCamShakeWithControlByClass_CameraShakeCls_Offset;

	private static bool PlayCamShakeWithControlByClass_Target_IsValid;

	private static int PlayCamShakeWithControlByClass_Target_Offset;

	private static bool PauseCamShakeWithControlByActor_IsValid;

	private static IntPtr PauseCamShakeWithControlByActor_FunctionAddress;

	private static int PauseCamShakeWithControlByActor_ParamsSize;

	private static bool PauseCamShakeWithControlByActor_Target_IsValid;

	private static int PauseCamShakeWithControlByActor_Target_Offset;

	private static bool PauseCamShakeWithControlByActor_bPause_IsValid;

	private static int PauseCamShakeWithControlByActor_bPause_Offset;

	private static FFieldAddress PauseCamShakeWithControlByActor_bPause_PropertyAddress;

	private static bool BGUSetDispInteractActorAttachTo_IsValid;

	private static IntPtr BGUSetDispInteractActorAttachTo_FunctionAddress;

	private static int BGUSetDispInteractActorAttachTo_ParamsSize;

	private static bool BGUSetDispInteractActorAttachTo_AttachTo_IsValid;

	private static int BGUSetDispInteractActorAttachTo_AttachTo_Offset;

	private static bool BGUTryCastSpellWithStartSection_IsValid;

	private static IntPtr BGUTryCastSpellWithStartSection_FunctionAddress;

	private static int BGUTryCastSpellWithStartSection_ParamsSize;

	private static bool BGUTryCastSpellWithStartSection_Unit_IsValid;

	private static int BGUTryCastSpellWithStartSection_Unit_Offset;

	private static bool BGUTryCastSpellWithStartSection_SkillID_IsValid;

	private static int BGUTryCastSpellWithStartSection_SkillID_Offset;

	private static bool BGUTryCastSpellWithStartSection_MontageStartSectionName_IsValid;

	private static int BGUTryCastSpellWithStartSection_MontageStartSectionName_Offset;

	private static bool BGUTryCastSpellWithStartSection_ReturnValue_IsValid;

	private static int BGUTryCastSpellWithStartSection_ReturnValue_Offset;

	private static bool BGUSetPlayerInSequenceTransition_IsValid;

	private static IntPtr BGUSetPlayerInSequenceTransition_FunctionAddress;

	private static int BGUSetPlayerInSequenceTransition_ParamsSize;

	private static bool BGUSetPlayerInSequenceTransition_Owner_IsValid;

	private static int BGUSetPlayerInSequenceTransition_Owner_Offset;

	private static bool BGUSetPlayerInSequenceTransition_bValue_IsValid;

	private static int BGUSetPlayerInSequenceTransition_bValue_Offset;

	private static FFieldAddress BGUSetPlayerInSequenceTransition_bValue_PropertyAddress;

	private static bool BGUCheckSpecialConsumeItemUseAble_IsValid;

	private static IntPtr BGUCheckSpecialConsumeItemUseAble_FunctionAddress;

	private static int BGUCheckSpecialConsumeItemUseAble_ParamsSize;

	private static bool BGUCheckSpecialConsumeItemUseAble_WorldContext_IsValid;

	private static int BGUCheckSpecialConsumeItemUseAble_WorldContext_Offset;

	private static bool BGUCheckSpecialConsumeItemUseAble_ItemID_IsValid;

	private static int BGUCheckSpecialConsumeItemUseAble_ItemID_Offset;

	private static bool BGUCheckSpecialConsumeItemUseAble_bShowTips_IsValid;

	private static int BGUCheckSpecialConsumeItemUseAble_bShowTips_Offset;

	private static FFieldAddress BGUCheckSpecialConsumeItemUseAble_bShowTips_PropertyAddress;

	private static bool BGUCheckSpecialConsumeItemUseAble_ReturnValue_IsValid;

	private static int BGUCheckSpecialConsumeItemUseAble_ReturnValue_Offset;

	private static FFieldAddress BGUCheckSpecialConsumeItemUseAble_ReturnValue_PropertyAddress;

	private static bool GetGuibeiBoneTransformFromLastTick_IsValid;

	private static IntPtr GetGuibeiBoneTransformFromLastTick_FunctionAddress;

	private static int GetGuibeiBoneTransformFromLastTick_ParamsSize;

	private static bool GetGuibeiBoneTransformFromLastTick_AnimSeq_IsValid;

	private static int GetGuibeiBoneTransformFromLastTick_AnimSeq_Offset;

	private static bool GetGuibeiBoneTransformFromLastTick_CurTime_IsValid;

	private static int GetGuibeiBoneTransformFromLastTick_CurTime_Offset;

	private static bool GetGuibeiBoneTransformFromLastTick_LastTime_IsValid;

	private static int GetGuibeiBoneTransformFromLastTick_LastTime_Offset;

	private static bool GetGuibeiBoneTransformFromLastTick_BoneName_IsValid;

	private static int GetGuibeiBoneTransformFromLastTick_BoneName_Offset;

	private static bool GetGuibeiBoneTransformFromLastTick_ReturnValue_IsValid;

	private static int GetGuibeiBoneTransformFromLastTick_ReturnValue_Offset;

	private static FFieldAddress GetGuibeiBoneTransformFromLastTick_ReturnValue_PropertyAddress;

	private static bool ExportTamerListToNewDAByWeaponInfo_IsValid;

	private static IntPtr ExportTamerListToNewDAByWeaponInfo_FunctionAddress;

	private static int ExportTamerListToNewDAByWeaponInfo_ParamsSize;

	private static bool ExportTamerListToNewDAByWeaponInfo_Actor_IsValid;

	private static int ExportTamerListToNewDAByWeaponInfo_Actor_Offset;

	private static bool ExportTamerListToNewDAByWeaponInfo_OldTamer_IsValid;

	private static int ExportTamerListToNewDAByWeaponInfo_OldTamer_Offset;

	private static FFieldAddress ExportTamerListToNewDAByWeaponInfo_OldTamer_PropertyAddress;

	private static bool ExportTamerListToNewDAByWeaponInfo_NewTimer_IsValid;

	private static int ExportTamerListToNewDAByWeaponInfo_NewTimer_Offset;

	private static FFieldAddress ExportTamerListToNewDAByWeaponInfo_NewTimer_PropertyAddress;

	private static bool ExportTamerListToNewDAByWeaponInfo_BlameName_IsValid;

	private static int ExportTamerListToNewDAByWeaponInfo_BlameName_Offset;

	private static FFieldAddress ExportTamerListToNewDAByWeaponInfo_BlameName_PropertyAddress;

	private static bool ExportTamerListToNewDAByWeaponInfo_ReturnValue_IsValid;

	private static int ExportTamerListToNewDAByWeaponInfo_ReturnValue_Offset;

	private static FFieldAddress ExportTamerListToNewDAByWeaponInfo_ReturnValue_PropertyAddress;

	private static bool RotateLevelRelativeToParentTransform_IsValid;

	private static IntPtr RotateLevelRelativeToParentTransform_FunctionAddress;

	private static int RotateLevelRelativeToParentTransform_ParamsSize;

	private static bool RotateLevelRelativeToParentTransform_WorldContextObject_IsValid;

	private static int RotateLevelRelativeToParentTransform_WorldContextObject_Offset;

	private static bool RotateLevelRelativeToParentTransform_LevelName_IsValid;

	private static int RotateLevelRelativeToParentTransform_LevelName_Offset;

	private static bool RotateLevelRelativeToParentTransform_ParentTransform_IsValid;

	private static int RotateLevelRelativeToParentTransform_ParentTransform_Offset;

	private static FFieldAddress RotateLevelRelativeToParentTransform_ParentTransform_PropertyAddress;

	private static bool RotateLevelRelativeToParentTransform_ParentTransformOffset_IsValid;

	private static int RotateLevelRelativeToParentTransform_ParentTransformOffset_Offset;

	private static FFieldAddress RotateLevelRelativeToParentTransform_ParentTransformOffset_PropertyAddress;

	private static bool CalTransformRelativeToParentTransformOffset_IsValid;

	private static IntPtr CalTransformRelativeToParentTransformOffset_FunctionAddress;

	private static int CalTransformRelativeToParentTransformOffset_ParamsSize;

	private static bool CalTransformRelativeToParentTransformOffset_SelfTransform_IsValid;

	private static int CalTransformRelativeToParentTransformOffset_SelfTransform_Offset;

	private static FFieldAddress CalTransformRelativeToParentTransformOffset_SelfTransform_PropertyAddress;

	private static bool CalTransformRelativeToParentTransformOffset_ParentTransform_IsValid;

	private static int CalTransformRelativeToParentTransformOffset_ParentTransform_Offset;

	private static FFieldAddress CalTransformRelativeToParentTransformOffset_ParentTransform_PropertyAddress;

	private static bool CalTransformRelativeToParentTransformOffset_ParentTransformOffset_IsValid;

	private static int CalTransformRelativeToParentTransformOffset_ParentTransformOffset_Offset;

	private static FFieldAddress CalTransformRelativeToParentTransformOffset_ParentTransformOffset_PropertyAddress;

	private static bool CalTransformRelativeToParentTransformOffset_ReturnValue_IsValid;

	private static int CalTransformRelativeToParentTransformOffset_ReturnValue_Offset;

	private static FFieldAddress CalTransformRelativeToParentTransformOffset_ReturnValue_PropertyAddress;

	private static bool ProjectWorldLocationToWidgetPositionWithSZInS_IsValid;

	private static IntPtr ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress;

	private static int ProjectWorldLocationToWidgetPositionWithSZInS_ParamsSize;

	private static bool ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_IsValid;

	private static int ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_Offset;

	private static bool ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_IsValid;

	private static int ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_Offset;

	private static FFieldAddress ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_PropertyAddress;

	private static bool ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_IsValid;

	private static int ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_Offset;

	private static FFieldAddress ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_PropertyAddress;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:DestroyAllProjectile")]
	public static void DestroyAllProjectile(AActor Unit)
	{
		BUS_EventCollectionCS.Get(Unit)?.Evt_DestroyAllCtrableBullet.Invoke();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PlayPigsyStory")]
	public static void PlayPigsyStory(AActor Unit)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:InteruptPigsyStory")]
	public static void InteruptPigsyStory(AActor Unit)
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PlayFacialAnimTest")]
	public static void PlayFacialAnimTest(bool bPlay, AActor Unit, UAnimSequence FacialAnim, float TimeOffset, float AutoBlendOutTime)
	{
	}

	public static int CheckConditions(AActor Owner, EDetectedUnitType UnitType, List<FDetectCondition> Conditions, EConditionalRelation ConditionalRelation, bool IsReverseCondition, AActor HitTarget = null)
	{
		int num = 1;
		int num2 = -1;
		if (IsReverseCondition)
		{
			num = -1;
			num2 = 1;
		}
		List<CalliopeCustom_DetectCondition> list = new List<CalliopeCustom_DetectCondition>();
		foreach (FDetectCondition Condition in Conditions)
		{
			list.Add(Condition.GetSerializableObject());
		}
		AActor actor = null;
		switch (UnitType)
		{
		case EDetectedUnitType.Self:
			actor = Owner;
			break;
		case EDetectedUnitType.Target:
			actor = HitTarget;
			break;
		case EDetectedUnitType.Master:
			actor = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner).GetMasterActor();
			break;
		case EDetectedUnitType.Player:
			actor = UGameplayStatics.GetPlayerPawn(Owner, 0);
			break;
		}
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(actor);
		if (readOnlyData == null)
		{
			return 0;
		}
		foreach (CalliopeCustom_DetectCondition item in list)
		{
			bool flag = readOnlyData.CheckDetectCondition(item);
			if (ConditionalRelation == EConditionalRelation.And && !flag)
			{
				return num2;
			}
			if (ConditionalRelation == EConditionalRelation.Or && flag)
			{
				return num;
			}
		}
		return ConditionalRelation switch
		{
			EConditionalRelation.And => num, 
			EConditionalRelation.Or => num2, 
			_ => 0, 
		};
	}

	public static bool IsClonedWukong(AActor Actor)
	{
		if (Actor is BGU_CharacterAI bGU_CharacterAI)
		{
			return bGU_CharacterAI.ConfigInfoComp.FlagConfig.UnitTemplateType == EUnitTagType.ClonedWukong;
		}
		return false;
	}

	public static int[] RandomSample(int[] arr, int n)
	{
		Random random = new Random();
		for (int num = arr.Length - 1; num > 0; num--)
		{
			int num2 = random.Next(num + 1);
			int num3 = arr[num];
			arr[num] = arr[num2];
			arr[num2] = num3;
		}
		return arr.Take(n).ToArray();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GM_AddAttr")]
	public static void GM_AddAttr(AActor Unit, EBGUAttrFloat AttrType, float AddValue)
	{
		BUS_EventCollectionCS.Get(Unit)?.Evt_FTB_IncreaseAttrFloat.Invoke(AttrType, AddValue);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetSolverCenter")]
	public static void SetSolverCenter(AActor Unit)
	{
		if (!(Unit == null))
		{
			BGW_DynamicSDFMgr.Get(Unit).SetSolverCenter(Unit);
		}
	}

	public static List<EBGUSimpleState> GetProgramOnlySimpleStateList()
	{
		List<EBGUSimpleState> list = new List<EBGUSimpleState>();
		foreach (EBGUSimpleState value in Enum.GetValues(typeof(EBGUSimpleState)))
		{
			if (EnumHasAttribute<UseInProgramOnly>(value))
			{
				list.Add(value);
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TestProfileSimpleOverlap")]
	public static void TestProfileSimpleOverlap(UObject WorldContext)
	{
		List<BGUCharacterCS> list = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext).ToList();
		List<FVector> list2 = new List<FVector>();
		foreach (BGUCharacterCS item in list)
		{
			list2.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item));
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
		BGC_SimpleOverlapMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_SimpleOverlapMgrData>(firstLocalPlayerController.PlayerState);
		if (gameStateReadonlyData != null)
		{
			foreach (FVector item2 in list2)
			{
				gameStateReadonlyData.GetSimpleOverlapActorsByMask(controlledPawn, item2, 1, 600f, 0f, 0f, default(FVector2D), IsSphere: true, out var _);
			}
		}
		foreach (FVector item3 in list2)
		{
			List<AActor> OutList2 = new List<AActor>();
			GetSimpleOverlapActors_AllClass(controlledPawn, item3, 1, 600f, 0f, 0f, default(FVector2D), IsSphere: true, ref OutList2);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:RunEQSForDebug")]
	public static void RunEQSForDebug(AActor Querier, UEnvQuery Env)
	{
		BGS_EventCollectionCS.Get(Querier).Evt_BGS_EQSObjRunInstant.Invoke(Env, Querier, out var _, out var _);
		BGU_UnrealWorldUtil.DestroyActor(Querier);
		UBGUFunctionLibraryForCS.RemoveAllQueriesByQuerier(Querier);
	}

	public static void GetSimpleOverlapActors_AllClass(AActor Owner, FVector InOriginalLocation, int Mask, float SphereRadius, float RectWidth, float RectLength, FVector2D RectRotation, bool IsSphere, ref List<AActor> OutList, bool UseEntRadiusCheck = true)
	{
		List<BGUCharacterCS> list = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(Owner).ToList();
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		List<float> list2 = new List<float>();
		foreach (BGUCharacterCS item in list)
		{
			float num = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(item), v);
			if (num < SphereRadius + 400f)
			{
				list2.Add(num);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:CastMagicallyChangeSkill")]
	public static void CastMagicallyChangeSkill(AActor Unit, BGWDataAsset_MagicallyChangeConfig Config, int SkillID, int RecoverSkillID)
	{
		BUS_EventCollectionCS.Get(Unit).Evt_OnCastMagicallyChangeSkill.Invoke(Config, SkillID, RecoverSkillID);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetProjectBranchName")]
	public static string GetProjectBranchName()
	{
		return File.ReadAllText(USystemLibrary.GetProjectDirectory() + "Config_Proj/B1/ProjBranch.txt");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GlobalEventTest")]
	public static void GlobalEventTest(AActor Unit, int Times)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		Times = (int)MathLib.Clamp(Times, 0f, Times);
		while (Times > 0)
		{
			Times--;
			BGW_EventCollection.Get(Unit).Evt_GlobalEventTest(1);
		}
		stopwatch.Stop();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SummonEventTest")]
	public static void SummonEventTest(AActor Unit)
	{
		BGW_EventCollection.Get(Unit).Evt_BGW_OnAllSummonBeKilled(Unit, 0);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:UnitSuicide")]
	public static void UnitSuicide(AActor Unit)
	{
		BUS_EventCollectionCS.Get(Unit).Evt_UnitDead.Invoke(Unit, EDeadReason.Suicide);
	}

	public static void TriggerGuideNodeFinishEvent(UObject WorldContext, EGuideNodeFinishType FinishType)
	{
		BGS_GSEventCollection.Get(WorldContext).Evt_TriggerGuideNodeFinishEvent.Invoke(FinishType);
	}

	public static void TriggerGuideNodeFinishEvent_WithIntParam(UObject WorldContext, EGuideNodeFinishType FinishType, int IntParam)
	{
		BGS_GSEventCollection.Get(WorldContext).Evt_TriggerGuideNodeFinishEvent_WithIntParam.Invoke(FinishType, IntParam);
	}

	public static APlayerController GetCharacterAuthorityPlayerController(BGUCharacterCS Character)
	{
		if (BGU_DataUtil.GetGameModeReadonlyData<BGC_ServerTamerAuthData>(Character).ActiveTamerAuthInfoNetGuidMap.TryGetValue(UGSE_OnlineFuncLib.GetObjNetGuid(Character), out var value))
		{
			return value.AuthPlayer;
		}
		return null;
	}

	public static bool TamerInLocalStratergy(UObject WorldCtx, FTamerRef TamerRef)
	{
		foreach (KeyValuePair<ETamerType, TamerStrategyBase> item in BGU_DataUtil.GetGameStateReadonlyData<BGC_TamerData>(WorldCtx).TamerStrategyMap)
		{
			if (item.Value.ContainsTamer(TamerRef))
			{
				return true;
			}
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetResID")]
	public static int BGUGetResID(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			bGUCharacterCS.GetResID();
		}
		return 0;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ClampAndAlignToLandScape")]
	public static void ClampAndAlignToLandScape(AActor Unit, bool ClampToLand, bool AlignToLand, float DeltaTime, float InterpSpd)
	{
		if (Unit == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
		FVector lineTraceStart = fVector + FVector.UpVector * 50.0;
		FVector lineTraceEnd = fVector - FVector.UpVector * 1000.0;
		if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(Unit.World, lineTraceStart, lineTraceEnd, out var hitResultSimple))
		{
			FRotator newRotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Unit);
			if (AlignToLand)
			{
				float pitch = MathLib.MakeRotFromYZ(Unit.GetActorRightVector(), hitResultSimple.HitImpactNormal).Pitch;
				newRotation.Pitch = FMath.FInterpTo(newRotation.Pitch, pitch, DeltaTime, InterpSpd);
				float roll = MathLib.MakeRotFromXZ(Unit.GetActorForwardVector(), hitResultSimple.HitImpactNormal).Roll;
				newRotation.Roll = FMath.FInterpTo(newRotation.Roll, roll, DeltaTime, InterpSpd);
			}
			FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
			if (ClampToLand)
			{
				newLocation.Z = hitResultSimple.HitLocation.Z;
			}
			BGUFuncLibActorTransformCS.BGUSetActorLocation(Unit, newLocation, bSweep: true, bTeleport: true);
			BGUFuncLibActorTransformCS.BGUSetActorRotation(Unit, newRotation, bTeleportPhysics: true);
		}
	}

	public static bool CheckNeedCastTurnSkill(AActor Owner, GSTurnSkillConfig TurnSkillConfig, FVector TargetLocation)
	{
		FVector actorForwardVector = Owner.GetActorForwardVector();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FVector2D a = new FVector2D(actorForwardVector);
		FVector2D a2 = new FVector2D(TargetLocation - fVector);
		FVector2D fVector2D = a.NormalSafe2D();
		a2 = a2.NormalSafe2D();
		int num = ((fVector2D.CrossProduct2D(a2) > 0.0) ? 1 : (-1));
		float num2 = MathLib.DegAcos(MathLib.DotProduct2D(fVector2D, a2));
		int turnSkillIDByDegree = TurnSkillConfig.GetTurnSkillIDByDegree(num2 * (float)num);
		if (turnSkillIDByDegree != 0 && !BGUHasUnitState(Owner, EBGUUnitState.Attacking))
		{
			BGUTryCastSpell(Owner, turnSkillIDByDegree, ECastSkillSourceType.TurnSkill);
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:HandleAiConversation")]
	public static void HandleAiConversation(AActor Caster, int ConversationContentID)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Caster);
		if (bUS_GSEventCollection != null)
		{
			List<int> list = new List<int>();
			list.Add(ConversationContentID);
			bUS_GSEventCollection.Evt_HandleConversationByContentIDList.Invoke("蓝图接口::HandleAiConversation", list);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TestVector")]
	public static void TestVector(FVector A)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TestInputEvent")]
	public static void TestInputEvent(FKeyEvent A)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:DicSortTest")]
	public static void DicSortTest(AActor Unit)
	{
		Dictionary<int, float> dictionary = new Dictionary<int, float>();
		dictionary.Add(1, 1.5f);
		dictionary.Add(2, 1f);
		dictionary.Add(3, 0.1f);
		dictionary.Add(4, 5f);
		IOrderedEnumerable<KeyValuePair<int, float>> orderedEnumerable = dictionary.OrderBy(delegate(KeyValuePair<int, float> pair)
		{
			KeyValuePair<int, float> keyValuePair = pair;
			return keyValuePair.Value;
		});
		dictionary.Clear();
		foreach (KeyValuePair<int, float> item in orderedEnumerable)
		{
			dictionary.Add(item.Key, item.Value);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TimeLineNoiseTest")]
	public static void TimeLineNoiseTest(float TotalTime, int TimePointNum, float NoiseInterregional, UCurveFloat CurveFloat, ERichCurveInterpMode InterpMode)
	{
		List<float> list = TimeLineMakingNoise(TotalTime, TimePointNum, NoiseInterregional);
		float num = 0f;
		foreach (float item in list)
		{
			num += item;
			UBGUFunctionLibrary.BGUSetValueToCurveFloat(CurveFloat, num, 0f, InterpMode);
		}
	}

	public static List<float> TimeLineMakingNoise(float TotalTime, int TimePointNum, float NoiseInterregional)
	{
		List<float> list = new List<float>();
		if (TotalTime <= 0f || TimePointNum <= 1)
		{
			return list;
		}
		float num = TotalTime / (float)(TimePointNum - 1);
		NoiseInterregional = FMath.Abs(NoiseInterregional);
		NoiseInterregional = FMath.Min(NoiseInterregional, num);
		List<float> list2 = new List<float>();
		for (int i = 0; i < TimePointNum; i++)
		{
			if (i == 0)
			{
				list2.Add(0f);
			}
			else if (i == TimePointNum - 1)
			{
				list2.Add(TotalTime);
			}
			else
			{
				list2.Add((float)i * num + FMath.RandRange(0f - NoiseInterregional, NoiseInterregional));
			}
		}
		for (int j = 1; j < list2.Count; j++)
		{
			list.Add(list2[j] - list2[j - 1]);
		}
		return list;
	}

	public static void SetTargetTransformByRefObj(UWorld World, FName TargetActorTag, string TargetGUID, string RefObjGUID, FVector RefLocalOffset)
	{
		if (World.IsNullOrDestroyed())
		{
			return;
		}
		AActor aActor = null;
		if (TargetActorTag != FName.None)
		{
			World.GetAllActorsOfClassWithTag(UClass.GetClass<AActor>(), TargetActorTag, out var OutActors);
			aActor = ((OutActors.Count > 0) ? OutActors[0] : null);
		}
		else if (!string.IsNullOrEmpty(TargetGUID))
		{
			aActor = BGU_DataUtil.GetActorByGuid(World, TargetGUID);
		}
		if (!aActor.IsNullOrDestroyed())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(World, TargetGUID);
			if (!actorByGuid.IsNullOrDestroyed())
			{
				FVector newLocation = actorByGuid.GetActorTransform().TransformLocation(RefLocalOffset);
				aActor.SetActorLocationAndRotation(newLocation, actorByGuid.GetActorRotation(), bSweep: false, out var _, bTeleport: false);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:CheckCurCeilingHeight")]
	public static float CheckCurCeilingHeight(ACharacter Character, float LineTraceLength = 2000f)
	{
		if (Character.IsNullOrDestroyed())
		{
			return -1f;
		}
		FVector fVector = Character.GetActorLocation() - Character.GetActorUpVector() * Character.CapsuleComponent.GetScaledCapsuleHalfHeight();
		FVector end = fVector + Character.GetActorUpVector() * LineTraceLength;
		List<AActor> list = new List<AActor>();
		list.Add(Character);
		if (USystemLibrary.LineTraceSingleByProfile(Character, fVector, end, B1GlobalFNames.Pawn, bTraceComplex: true, list, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Green, 2f))
		{
			return FVector.Dist(BGUGetVectorFromNetQuantizeVector(in OutHit.ImpactPoint), fVector);
		}
		return LineTraceLength;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:KJLSpawnProjectile")]
	public static void KJLSpawnProjectile(AActor BulletSpawner, AActor Target, string PointGeneratorTag, int BulletID, float LimitDistance_ToPlayer, UNiagaraSystem LightningBeam, string LightningEndParamName, List<string> SocketList, int DummyBulletNum, FVector EndPos_Noise, UNiagaraComponent DummyNiagara, float DummyActiveDistance, FVector2D RandomInterval)
	{
		if (BulletSpawner == null || Target == null)
		{
			return;
		}
		FVector actorLocation = BulletSpawner.GetActorLocation();
		FVector actorLocation2 = Target.GetActorLocation();
		if (FVector.Distance(actorLocation, actorLocation2) > DummyActiveDistance)
		{
			if (DummyNiagara != null && !DummyNiagara.IsVisible())
			{
				DummyNiagara.Visible = true;
			}
			return;
		}
		if (DummyNiagara != null && DummyNiagara.IsVisible())
		{
			DummyNiagara.Visible = false;
		}
		Target.World.GetAllActorsOfClassWithTag(UClass.GetClass<BGU_EQSPointRecorderActor>(), new FName(PointGeneratorTag), out var OutActors);
		if (OutActors.Count < 1)
		{
			return;
		}
		BGU_EQSPointRecorderActor bGU_EQSPointRecorderActor = OutActors[0] as BGU_EQSPointRecorderActor;
		if (bGU_EQSPointRecorderActor == null)
		{
			return;
		}
		List<FVector> list = new List<FVector>();
		foreach (FVector eQSPoint in bGU_EQSPointRecorderActor.EQSPoints)
		{
			list.Add(eQSPoint);
		}
		foreach (FVector customPoint in bGU_EQSPointRecorderActor.CustomPoints)
		{
			list.Add(customPoint);
		}
		if (list.Count < 1)
		{
			return;
		}
		List<FVector> list2 = new List<FVector>();
		LimitDistance_ToPlayer = FMath.Max(100f, LimitDistance_ToPlayer);
		FVector fVector = Target.GetActorLocation();
		if (bGU_EQSPointRecorderActor.InLocalMode())
		{
			FTransform actorTransform = bGU_EQSPointRecorderActor.RelativeTarget.GetActorTransform();
			actorTransform.Scale3D = FVector.OneVector;
			fVector = actorTransform.InverseTransformLocation(fVector);
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (FVector.Distance(list[i], fVector) < LimitDistance_ToPlayer)
			{
				list2.Add(list[i]);
			}
		}
		if (list2.Count < 1)
		{
			return;
		}
		List<FVector> list3 = new List<FVector>();
		list3.Add(FVector.ZeroVector);
		for (int j = 0; j < DummyBulletNum; j++)
		{
			if (list2.Count < 1)
			{
				break;
			}
			int index = FMath.RandRange(0, list2.Count - 1);
			if (bGU_EQSPointRecorderActor.InLocalMode())
			{
				FTransform actorTransform2 = bGU_EQSPointRecorderActor.RelativeTarget.GetActorTransform();
				actorTransform2.Scale3D = FVector.OneVector;
				list3.Add(actorTransform2.TransformLocation(list2[index]));
			}
			else
			{
				list3.Add(list2[index]);
			}
			list2.RemoveAt(index);
		}
		float num = 0f;
		int num2 = list3.Count;
		while (num2 > 0)
		{
			num2--;
			if (list3.Count < 1)
			{
				break;
			}
			string lightningStartSocketName = "root";
			if (SocketList.Count > 0)
			{
				int index2 = FMath.RandRange(0, SocketList.Count - 1);
				lightningStartSocketName = SocketList[index2];
				SocketList.RemoveAt(index2);
			}
			int index3 = FMath.RandRange(0, list3.Count - 1);
			FVector fVector2 = list3[index3];
			list3.RemoveAt(index3);
			FTimerManager fTimerManager = FTimerManager.PIEWorld ?? FTimerManager.GameInstance;
			if (fTimerManager != null)
			{
				PCSEW_KJLRandomLightning pCSEW_KJLRandomLightning = UObject.NewObject<PCSEW_KJLRandomLightning>(BulletSpawner);
				pCSEW_KJLRandomLightning.Init(BulletSpawner);
				pCSEW_KJLRandomLightning.InitData(BulletID, fVector2, EndPos_Noise, lightningStartSocketName, LightningBeam, LightningEndParamName, fVector2 != FVector.ZeroVector, Target);
				if (num <= 0f)
				{
					pCSEW_KJLRandomLightning.MainThread();
				}
				else
				{
					fTimerManager.SetTimer(pCSEW_KJLRandomLightning, "MainThread", num);
				}
				num += FMath.FRandRange(RandomInterval.X, RandomInterval.Y);
			}
		}
	}

	public static FVector GetOffsetNoise(float Noise_X, float Noise_Y, float Noise_Z)
	{
		float num = FMath.RandRange(0f - Noise_X, Noise_X);
		float num2 = FMath.RandRange(0f - Noise_Y, Noise_Y);
		float num3 = FMath.RandRange(0f - Noise_Z, Noise_Z);
		return new FVector(num, num2, num3);
	}

	public static List<ABGUCharacter> GetAllTargetCharacterList(ABGUCharacter Unit)
	{
		if (Unit == null)
		{
			return null;
		}
		List<ABGUCharacter> allActorsOfClassList = Unit.World.GetAllActorsOfClassList<ABGUCharacter>();
		List<ABGUCharacter> list = new List<ABGUCharacter>();
		foreach (ABGUCharacter item in allActorsOfClassList)
		{
			if (BGUIsEnemyTeam(Unit, item))
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static bool IsRemoteControlPawn(AActor Actor)
	{
		if (Actor as APawn == null || Actor.GetRemoteRole() != ENetRole.ROLE_AutonomousProxy)
		{
			return false;
		}
		return !((APawn)Actor).IsLocallyControlled();
	}

	public static bool IsLocalControlPawn(AActor Actor)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Actor);
		if (firstLocalPlayerController == null)
		{
			return false;
		}
		return firstLocalPlayerController.GetControlledPawn() == Actor;
	}

	public static BGUCharacterCS GetClosestPlayer(UObject WorldContextObject, FTransform Tran)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(WorldContextObject)))
		{
			return UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContextObject).GetControlledPawn() as BGUCharacterCS;
		}
		List<BGUCharacterCS> list = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContextObject).ToList();
		float num = float.MaxValue;
		BGUCharacterCS result = null;
		foreach (BGUCharacterCS item in list)
		{
			if (item.IsPlayerControlled())
			{
				float num2 = FVector.Dist(BGUFuncLibActorTransformCS.BGUGetActorLocation(item), Tran.GetLocation());
				if (num2 < num)
				{
					num = num2;
					result = item;
				}
			}
		}
		return result;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHandleAbnormalState")]
	public static void BGUHandleAbnormalState(AActor Attacker, AActor Victim, AbnormalStateAccConfig config, float AddValue)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Victim);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_HandleAbnormal.Invoke(config.AbnormalStateType, Attacker, config.AccType, AddValue, config.Level);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetDispInteractActorAttachTo")]
	public static void BGUSetDispInteractActorAttachTo(AActor AttachTo)
	{
		if (AttachTo == null)
		{
			return;
		}
		BGW_DispInteractMgr bGW_DispInteractMgr = BGW_DispInteractMgr.Get(AttachTo);
		if (!(bGW_DispInteractMgr == null))
		{
			BGUDispInteractActor dispInteractOwner = bGW_DispInteractMgr.DispInteractOwner;
			if (!(dispInteractOwner == null))
			{
				dispInteractOwner.AttachTo = AttachTo;
			}
		}
	}

	public static void BGUYukangTest(AActor Owner, EMatPainterType MatPainterType, float HitRangeMin, float HitRangeMax, float ExpandTime)
	{
		if (!(Owner == null))
		{
			BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		}
	}

	public static BGUDispInteractActor BGUGetDispInteractOwner(AActor Owner)
	{
		if (Owner == null)
		{
			return null;
		}
		BGUDispInteractActor bGUDispInteractActor = BGW_DispInteractMgr.Get(Owner)?.GetDispInteractOwner();
		if (bGUDispInteractActor != null)
		{
			return bGUDispInteractActor;
		}
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowFPSUI")]
	public static void BGUShowFPSUI(AActor Unit)
	{
		if (!(Unit == null))
		{
			Msg_ShowScriptWidget Msg = default(Msg_ShowScriptWidget);
			Msg.UIName = new FixedString256("BP_UI_TPS_Reticle");
			BGWGameInstanceCS.GetObject<CSApiBattle>(Unit).EnqueueMessage(ref Msg);
		}
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCheckSpecialConsumeItemUseAble")]
	public static bool BGUCheckSpecialConsumeItemUseAble(UObject WorldContext, int ItemID, bool bShowTips = true)
	{
		BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		IBUC_BattleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(bGUCharacterCS);
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(bGUCharacterCS);
		IBGC_GlobalBattleStateData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_GlobalBattleStateData, BGC_GlobalBattleStateData>(bGUCharacterCS);
		if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.FoxTransQuestItemID, out var ConfigInfo))
		{
			int intValue = ConfigInfo.IntValue;
			if (ItemID == intValue)
			{
				if (B1Global.GIsBossRushMode)
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_BossRushItemTips();
					}
					return false;
				}
				if (readOnlyData == null || readOnlyData.IsUnitInBattle())
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowShortItemTips();
					}
					return false;
				}
				if (gameStateReadonlyData == null || gameStateReadonlyData.IsInBossRoom())
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowShortItemTips();
					}
					return false;
				}
				IBIC_LevelData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_LevelData, BIC_LevelData>(bGUCharacterCS);
				if (gameInstanceReadonlyData == null || gameInstanceReadonlyData.CurrentLevelID != 30)
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowItemAreaTips();
					}
					return false;
				}
				IBUC_PlayerTransData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PlayerTransData, BUC_PlayerTransData>(bGUCharacterCS);
				if (readOnlyData2 == null || readOnlyData2.TransBackDurationTime > 0f)
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowShortItemTips();
					}
					return false;
				}
				IBUC_MagicallyChangeData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>(bGUCharacterCS);
				if (unPersistentReadOnlyData == null || (unPersistentReadOnlyData.IsDurMagicallyChange() && unPersistentReadOnlyData.VigorSkillReEnterWaitTime > 0f))
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowShortItemTips();
					}
					return false;
				}
				IBGC_LevelActorData gameStateReadonlyData2 = BGU_DataUtil.GetGameStateReadonlyData<IBGC_LevelActorData, BGC_LevelActorData>(bGUCharacterCS);
				if (gameStateReadonlyData2 == null || !gameStateReadonlyData2.CheckIsInSpecialItemArea(ItemID, bGUCharacterCS))
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowItemAreaTips();
					}
					return false;
				}
				IBUC_EnvironmentInteractionMgrData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(bGUCharacterCS);
				if (unPersistentReadOnlyData2 == null || unPersistentReadOnlyData2.ResultSurfaceType == ESceneItemSurfaceType.WaterSurface)
				{
					if (bShowTips)
					{
						bGW_UIEventCollection?.Evt_ShowShortItemTips();
					}
					return false;
				}
				return true;
			}
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetAttrValue")]
	public static void BGUSetAttrValue(AActor Unit, EBGUAttrFloat AttrID, float TargetValue)
	{
		if (!(Unit == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(AttrID, TargetValue);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCostAttr")]
	public static void BGUCostAttr(AActor Unit, EAttrCostType AttrCostType, float CostBase, float CostRatio)
	{
		if (!(Unit == null))
		{
			IBUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Unit);
			BGW_EffectTemplateList.Get(Unit).GetAttrCostTemplate(AttrCostType)?.DoCostAttrValue(Unit, readOnlyData, CostBase, CostRatio);
		}
	}

	public static void BGUIncreaseChargeLevel(AActor Unit, int IncreaseValue)
	{
		if (!(Unit == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnIncreaseChargeLevel.Invoke(IncreaseValue);
			}
		}
	}

	public static int BGUGetCurPELevel(AActor Unit)
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_PotentialEnergyData, BUC_PotentialEnergyData>(Unit).GetCurPELevel(Unit);
	}

	public static int BGUGetUniqueID(UObject Obj)
	{
		if (Obj != null)
		{
			return (int)Obj.GetUniqueID();
		}
		return -1;
	}

	public static int BGUGetPointsByEQS(UObject Obj)
	{
		if (Obj != null)
		{
			return (int)Obj.GetUniqueID();
		}
		return -1;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SkipCurrentSequence")]
	public static void SkipCurrentSequence(UObject WorldContext)
	{
		BGS_EventCollectionCS.Get(WorldContext)?.Evt_SkipCurrentMovie.Invoke();
	}

	public static void PauseCurrentSequence(UObject WorldContext)
	{
		BGS_EventCollectionCS.Get(WorldContext)?.Evt_PauseCurrentMovie.Invoke();
	}

	public static void ResumeCurrentSequence(UObject WorldContext)
	{
		BGS_EventCollectionCS.Get(WorldContext)?.Evt_ResumeCurrentMovie.Invoke();
	}

	public static void SkipCurrentInteractAction(UObject WorldContext)
	{
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext);
		if (firstLocalPlayerController != null)
		{
			BPS_EventCollectionCS.Get(firstLocalPlayerController)?.Evt_BPS_SkipInteract.Invoke();
		}
	}

	public static void TeleportToLevelPositionAndPreviewSeqWithCallBack(UObject WorldContext, int SeqId, Action OnSeqFinish)
	{
		if (BGUFuncLibSequenceCS.GetPreviewSeqInfo(WorldContext, SeqId, out var LevelId, out var PreviewPosition, out var PreviewRotation, out var OnleportFinish, OnSeqFinish))
		{
			TeleportToLevelPosition(WorldContext, LevelId, PreviewPosition, PreviewRotation, TravelUseDefaultPlayerStart: false, OnleportFinish);
		}
	}

	public static void TeleportToLevelPosition(UObject WorldContext, int levelId, FVector Position, FRotator Rotation, bool TravelUseDefaultPlayerStart, Action OnFinish = null)
	{
		LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(levelId);
		if (levelDesc == null && levelId != -1)
		{
			return;
		}
		FTransform fTransform = new FTransform(Rotation, Position);
		if (BGW_GameLifeTimeMgr.Get(WorldContext).GlobalFSMInstanceCurState == SGI_Global.InBattleStandAlone)
		{
			BGUCharacterCS bGUCharacterCS = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BPS_EventCollectionCS.Get(bGUCharacterCS.PlayerState).Evt_BPS_TeleportTo.Invoke(ETeleportTypeV2.SimpleLevelIdAndTransform, new TeleportParam_SimpleLevelIdAndTransform
				{
					LevelId = levelId,
					LevelTravelUseDefaultPlayerStart = TravelUseDefaultPlayerStart,
					TeleportTransform = fTransform,
					TeleportFinishCallback = OnFinish
				}, EPlayerTeleportReason.Test);
			}
		}
		else
		{
			FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.OverrideUnKnowLevelTravelPlayerStart = fTransform;
			FSMState_GI_Global_SubG_GI_Loading_UnKnowLevelTravel.UnKnowLevelTravelUseDefaultPlayerStart = TravelUseDefaultPlayerStart;
			if (levelDesc != null)
			{
				UGameplayStatics.OpenLevel(WorldContext, new FName(levelDesc.Path));
			}
		}
	}

	public static bool BGUGetIsBuildShipping()
	{
		return true;
	}

	public static void MarkCurrentLoopSequenceCanFinish(UObject WorldContext)
	{
		BGS_EventCollectionCS.Get(WorldContext)?.Evt_MarkCanFinishLoopMovie.Invoke();
	}

	[Tooltip("暴击率数值为万分比，如填10000则是 暴击率为万分之一万")]
	[DisplayName("设置目标基础暴击率")]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitCritRateBase")]
	public static void BGUSetUnitCritRateBase(AActor Unit, float CritRate)
	{
		if (!(Unit == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.CritRateBase, CritRate);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[DisplayName("一击打破定身")]
	[Tooltip("实际改的攻击者的攻击力，定身设定：定身内承受基于最大生命值的指定百分比时，定身就会被打破，该百分比在UnitComm表中填写")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUOneHitBreakImmobility")]
	public static void BGUOneHitBreakImmobility(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			bGUCharacterCS.GetResID();
			FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
			if (unitBattleInfoExtendDesc != null)
			{
				float newValue = BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(bGUCharacterCS).GetFloatValue(EBGUAttrFloat.HpMaxBase) * unitBattleInfoExtendDesc.ImmobilityHPRadio * 0.0001f;
				BUS_EventCollectionCS.Get(Unit.World.GetPlayerCharacter(0)).Evt_SetAttrFloat.Invoke(EBGUAttrFloat.AtkBase, newValue);
			}
		}
	}

	[Tooltip("定身时间单位：秒")]
	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[DisplayName("设置定身状态")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetImmobility")]
	public static void BGUSetImmobility(AActor Unit, float Timer)
	{
		if (!(Unit == null))
		{
			ACharacter playerCharacter = Unit.World.GetPlayerCharacter(0);
			if (!(playerCharacter == null))
			{
				BGUAddBuff(playerCharacter, Unit, 204, EBuffSourceType.Default, Timer * 1000f);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[DisplayName("解除定身状态")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveImmobility")]
	public static void BGURemoveImmobility(AActor Unit)
	{
		if (!(Unit == null) && !(Unit.World.GetPlayerCharacter(0) == null))
		{
			BGURemoveBuff(Unit, 204, EBuffEffectTriggerType.None, 999);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Util")]
	[DisplayName("移除技能霸体护甲")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveSkillSuperArmor")]
	public static void BGURemoveSkillSuperArmor(AActor Unit)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_RemoveSkillSuperArmor.Invoke(-1);
		}
	}

	[DisplayName("设置技能霸体护甲")]
	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSkillSuperArmor")]
	public static void BGUSetSkillSuperArmor(AActor Unit, UAnimMontage BreakSkillSupperArmorAM, float SkillSuperArmorValue)
	{
		if (!(Unit != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(Unit));
		if (unitCommDesc != null)
		{
			float setArmorValue = unitCommDesc.MaxSkillSuperArmorValue;
			if (SkillSuperArmorValue >= 0f)
			{
				setArmorValue = SkillSuperArmorValue;
			}
			bUS_GSEventCollection.Evt_TriggerSkillSuperArmor.Invoke(BreakSkillSupperArmorAM, setArmorValue, -1);
		}
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGMDead")]
	public static void BGUGMDead(AActor Unit)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_UnitDead.Invoke(Unit, EDeadReason.DeadZone);
		}
	}

	public static void OpenBattleInfoTool(bool IsOpen)
	{
		DebugConfig.IsOpenBattleInfoTool = IsOpen;
		BUS_BattleInfoComp.sBattleInfoLogList.Clear();
	}

	public static void RefreshBattleInfoTool()
	{
		BUS_BattleInfoComp.sBattleInfoLogList.Clear();
	}

	public static void SetAllUnitTargetIsFirstPlayer(UObject WorldContext)
	{
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			BUS_EventCollectionCS.Get(allActorsOfClass[i])?.Evt_AICatchTarget.Invoke(UGameplayStatics.GetPlayerCharacter(WorldContext, 0), ETargetSourceType.Target_AutoTest, SkipWakeUp: true);
		}
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMove")]
	public static void BGUPlatformPatroMove(AActor Unit, FVector BeginPos, FVector EndPos, float Speed)
	{
		FVector fVector = FVector.ZeroVector;
		USplineComponent componentByClass = Unit.GetComponentByClass<USplineComponent>();
		if (componentByClass == null)
		{
			return;
		}
		UProjectileMovementComponent componentByClass2 = Unit.GetComponentByClass<UProjectileMovementComponent>();
		if (!(componentByClass2 == null))
		{
			FVector actorLocation = Unit.GetActorLocation();
			componentByClass.GetNumberOfSplinePoints();
			BeginPos -= (BeginPos - EndPos) * 0.0010000000474974513;
			FVector a = actorLocation - EndPos;
			FVector a2 = actorLocation - BeginPos;
			FVector fVector2 = BeginPos - EndPos;
			if (FVector.DotProduct(a, fVector2) < 0f)
			{
				fVector = fVector2;
			}
			if (FVector.DotProduct(a2, fVector2) > 0f)
			{
				fVector = -fVector2;
			}
			if (fVector != FVector.ZeroVector)
			{
				componentByClass2.Velocity = fVector * Speed;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMoveSingle")]
	public static void BGUPlatformPatroMoveSingle(AActor Unit, FVector BeginPos, FVector EndPos, float Speed, int PlayerCount, float Range)
	{
		FVector fVector = FVector.ZeroVector;
		UProjectileMovementComponent componentByClass = Unit.GetComponentByClass<UProjectileMovementComponent>();
		if (componentByClass == null)
		{
			return;
		}
		bool flag = true;
		if (PlayerCount > 0)
		{
			List<ABGUCharacter> allActorsOfClassList = Unit.World.GetAllActorsOfClassList<ABGUCharacter>();
			int num = 0;
			foreach (ABGUCharacter item in allActorsOfClassList)
			{
				if (item.IsPlayerControlled() && FVector.Distance(item.GetActorLocation(), Unit.GetActorLocation()) < Range)
				{
					num++;
				}
			}
			if (PlayerCount < num && componentByClass.Velocity == fVector)
			{
				flag = false;
			}
		}
		FVector a = Unit.GetActorLocation() - EndPos;
		FVector fVector2 = BeginPos - EndPos;
		if (FVector.DotProduct(a, fVector2) > 0f && flag)
		{
			fVector = -fVector2;
		}
		componentByClass.Velocity = fVector * Speed;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroRota")]
	public static void BGUPlatformPatroRota(AActor Unit, int MaxRate, float Speed)
	{
		_ = FVector.ZeroVector;
		URotatingMovementComponent componentByClass = Unit.GetComponentByClass<URotatingMovementComponent>();
		if (!(componentByClass == null))
		{
			if (componentByClass.RotationRate.Pitch == 0f)
			{
				componentByClass.RotationRate = new FRotator(Speed, 0.0, 0.0);
			}
			if (Unit.GetActorRotation().Pitch < (float)(-MaxRate))
			{
				componentByClass.RotationRate = new FRotator(Speed, 0.0, 0.0);
			}
			if (Unit.GetActorRotation().Pitch > (float)MaxRate)
			{
				componentByClass.RotationRate = new FRotator(0f - Speed, 0.0, 0.0);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDBCTest")]
	public static void BGUDBCTest(AActor Owner, string DBCPath)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		if (!(bUS_GSEventCollection == null))
		{
			bUS_GSEventCollection.Evt_RequestSpawnFXByDispConfig.Invoke(DBCPath, out var RequestID, null, NeedSetSpawnTransform: true, BGUFuncLibActorTransformCS.BGUGetActorTransform(Owner));
			bUS_GSEventCollection.Evt_NotifyBulletMarkDBCReqID.Invoke(RequestID);
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayLockTarget")]
	public static void BGUPlayLockTarget(AActor Owner, BGUCharacterCS TargetChr)
	{
		BUS_EventCollectionCS.Get(Owner).Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(TargetChr, ETargetSourceType.None));
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:RunGMCommand")]
	public static void RunGMCommand(AActor Actor, string cmd, bool JustRunInBin)
	{
		if (!JustRunInBin || UBGUFunctionLibraryForCS.BGUGetIsBuildShipping())
		{
			USystemLibrary.ExecuteConsoleCommand(Actor, cmd, null);
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetPhysSetting")]
	public static void SetPhysSetting(AActor Actor, EPhysAnimType Type)
	{
		BUS_EventCollectionCS.Get(Actor).Evt_SetPhysAnimSetting.Invoke(Type);
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ResetPhysSetting")]
	public static void ResetPhysSetting(AActor Actor)
	{
		BUS_EventCollectionCS.Get(Actor).Evt_ResetPhysicalAnim.Invoke();
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnGhostActor")]
	public static void BGUSpawnGhostActor(AActor Target, string DAPath)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SpawnGhostActor.Invoke(DAPath);
		}
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetBehaviorTree")]
	public static void BGUSetBehaviorTree(AActor Unit, UBehaviorTree BT)
	{
		if (!Unit.IsNullOrDestroyed())
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_SetBT.Invoke(BT);
		}
	}

	[Category("BGU|Util")]
	[Tooltip("Caster应该为RootCaster, BuffDurationTimer 单位为毫秒")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAddBuff")]
	public static void BGUAddBuff(AActor Caster, AActor Target, int BuffID, EBuffSourceType BuffSourceType = EBuffSourceType.Default, float BuffDurationTimer = 0f)
	{
		if (!(Caster != null) || !(Target != null))
		{
			return;
		}
		if (Caster is BUTamerActor bUTamerActor)
		{
			Caster = bUTamerActor.GetMonster();
			if (Caster == null)
			{
				return;
			}
		}
		BUS_EventCollectionCS.Get(Target).Evt_BuffAdd.Invoke(BuffID, Caster, Caster, BuffDurationTimer, BuffSourceType);
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveAllBuff")]
	public static void BGURemoveAllBuff(AActor Unit, EBuffEffectTriggerType EffectTriggerType)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_BuffAllRemove.Invoke(EffectTriggerType);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuff")]
	public static void BGURemoveBuff(AActor Unit, int BuffID, EBuffEffectTriggerType EffectTriggerType, int Layer)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_BuffRemove.Invoke(BuffID, EffectTriggerType, Layer);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuffImmediately")]
	public static void BGURemoveBuffImmediately(AActor Unit, int BuffID, EBuffEffectTriggerType EffectTriggerType)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_BuffRemoveImmediately.Invoke(BuffID, EffectTriggerType);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowDialogueUI")]
	public static void BGUShowDialogueUI(AActor Unit, string DialogContent, float Duration)
	{
		if (Unit != null)
		{
			BGW_UIMgr.Get(Unit).PlaySubtitle("", DialogContent, Duration);
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHideLevelUI")]
	public static void BGUHideLevelUI(AActor Unit)
	{
		if (Unit != null)
		{
			BGS_GSEventCollection bGS_GSEventCollection = (UGameplayStatics.GetGameState(Unit.World) as BGGGameStateCS)?.GameEventCollection;
			if (bGS_GSEventCollection != null)
			{
				bGS_GSEventCollection.Evt_BGS_HideLevelUI.Invoke();
			}
		}
	}

	public static void BGUActiveNoSeqUI(UObject WorldContextObject, bool IsActive)
	{
		BGW_UIEventCollection bGW_UIEventCollection = BGW_UIEventCollection.Get(WorldContextObject);
		if (bGW_UIEventCollection != null)
		{
			bGW_UIEventCollection.Evt_UI_ActiveNoSeqUI(IsActive);
		}
	}

	public static void BGUTriggerSeqDisplayShow(AActor Unit, bool IsReMove)
	{
		BGU_DataUtil.OnDisPlayerShowTime(Unit, IsReMove);
	}

	public static void BGUTriggerSeqHiddenPlayer(AActor Unit, bool IsReMove)
	{
		BGU_DataUtil.OnTriggerSeqHiddenPlayer(Unit, IsReMove);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffect")]
	public static void TriggerEffect(AActor Unit, int EffectID)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		if (bUS_GSEventCollection != null)
		{
			FEffectInstReq fEffectInstReq = new FEffectInstReq(Unit);
			fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
			fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Unit);
			fEffectInstReq.HitActionDir = EHitActionDir.Default;
			FEffectInstReq effectInstReq = fEffectInstReq;
			bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffectToTarget")]
	public static void TriggerEffectToTarget(AActor Unit, int EffectID, AActor Target)
	{
		if (!(Target == null) && Unit.World != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				FEffectInstReq fEffectInstReq = new FEffectInstReq(Unit);
				fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
				fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(Unit);
				fEffectInstReq.HitActionDir = EHitActionDir.Default;
				FEffectInstReq effectInstReq = fEffectInstReq;
				bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, Target);
			}
		}
	}

	public static void BGUInputMoveForward(AActor Unit, float Val)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_InputMoveForward.Invoke(Val);
		}
	}

	public static void BGUInputMoveSideways(AActor Unit, float Val)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_InputMoveRight.Invoke(Val);
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpell")]
	public static int BGUTryCastSpell(AActor Unit, int SkillID, ECastSkillSourceType SourceType, bool IsUseComboingSection = false)
	{
		if (Unit == null)
		{
			return -1;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		ECastSkillResult eCastSkillResult = ECastSkillResult.CSR_OK;
		FCastSkillInfo cSI = new FCastSkillInfo(SkillID, SourceType);
		cSI.MontageStartSectionName = (IsUseComboingSection ? B1GlobalFNames.ing : FName.None);
		BUS_EventCollectionCS.Get(Unit).Evt_UnitCastSkillTry.Invoke(cSI);
		BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(Unit);
		if (readOnlyData != null)
		{
			eCastSkillResult = readOnlyData.GetLastSkillCastResult();
		}
		if (eCastSkillResult == ECastSkillResult.CSR_OK)
		{
			return 0;
		}
		return -1;
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpellWithStartSection")]
	public static int BGUTryCastSpellWithStartSection(AActor Unit, int SkillID, FName MontageStartSectionName)
	{
		if (Unit == null)
		{
			return -1;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		ECastSkillResult eCastSkillResult = ECastSkillResult.CSR_OK;
		FCastSkillInfo cSI = new FCastSkillInfo(SkillID, ECastSkillSourceType.Blueprint);
		cSI.MontageStartSectionName = MontageStartSectionName;
		cSI.NeedCheckSkillCanCast = false;
		BUS_EventCollectionCS.Get(Unit).Evt_UnitCastSkillTry.Invoke(cSI);
		BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(Unit);
		if (readOnlyData != null)
		{
			eCastSkillResult = readOnlyData.GetLastSkillCastResult();
		}
		if (eCastSkillResult == ECastSkillResult.CSR_OK)
		{
			return 0;
		}
		return -1;
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetCanTriggerGroupAI")]
	public static void BGUSetCanTriggerGroupAI(UObject WorldContext, bool CanTrigger)
	{
		BGS_EventCollectionCS.Get(WorldContext)?.Evt_BGS_SetCanTriggerGroupAI.Invoke(CanTrigger);
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetMultiPointCurrentUnit")]
	public static int BGUGetMultiPointCurrentUnit(AActor Actor)
	{
		BGUSpawnMultiPointActor bGUSpawnMultiPointActor = Actor as BGUSpawnMultiPointActor;
		if (bGUSpawnMultiPointActor != null)
		{
			b1.IBUC_SpawnMultiPointData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_SpawnMultiPointData, BUC_SpawnMultiPointData>(bGUSpawnMultiPointActor);
			if (readOnlyData != null)
			{
				return readOnlyData.CurrentUnitNum;
			}
		}
		return -1;
	}

	public static int BGUTrySmartCastSpell(AActor Unit, int SkillID, List<int> MappingRuleIDList, EMontageBindReason Reason = EMontageBindReason.Default)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit.IsNullOrDestroyed())
			{
				return 0;
			}
		}
		ECastSkillResult eCastSkillResult = ECastSkillResult.CSR_OK;
		BUS_EventCollectionCS.Get(Unit).Evt_RequestSmartCastSkill.Invoke(SkillID, MappingRuleIDList, Reason);
		BUC_SkillInstsData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SkillInstsData>(Unit);
		if (readOnlyData != null)
		{
			eCastSkillResult = readOnlyData.GetLastSkillCastResult();
		}
		bool flag = false;
		b1.IBUC_SmartCastSkillData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_SmartCastSkillData, b1.BUC_SmartCastSkillData>(Unit);
		if (unPersistentReadOnlyData != null)
		{
			flag = unPersistentReadOnlyData.LastAutoActionType == ECtrlActionType.CatAttack || unPersistentReadOnlyData.LastAutoActionType == ECtrlActionType.CatRunTrace;
		}
		if (flag && eCastSkillResult == ECastSkillResult.CSR_OK)
		{
			return 0;
		}
		return (int)eCastSkillResult;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitSimpleState")]
	public static void BGUSetUnitSimpleState(AActor Unit, EBGUSimpleState SimpleState, bool IsRemove)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_UnitSetSimpleState.Invoke(SimpleState, IsRemove);
		}
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUStartSceneQTE")]
	public static void BGUStartSceneQTE(AActor Unit, int QTEID, AActor TargetCharacter)
	{
		if (Unit != null)
		{
			BUS_EventCollectionCS.Get(Unit).Evt_StartSceneQTE.Invoke(QTEID, TargetCharacter);
		}
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSecondFogData")]
	public static void BGUSetSecondFogData(UExponentialHeightFogComponent ehfcomp, FExponentialHeightFogData SecondFogData)
	{
		if (!ehfcomp.IsNullOrDestroyed())
		{
			ehfcomp.SecondFogData = SecondFogData;
		}
	}

	public static AActor BGUAttachWeapon(AActor Unit, AActor Weapon, int WeaponIndex, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepRelative)
	{
		ABGUCharacter aBGUCharacter = Unit as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			return null;
		}
		FName socketName = BGUGetWeaponSocketNameByIndex(Unit, WeaponIndex);
		if (Weapon != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AttachWeapon.Invoke(Weapon, WeaponIndex, socketName, LocationRule, RotationRule, ScaleRule);
			}
		}
		return Weapon;
	}

	public static AActor BGUAttachWeaponBySocketName(AActor Unit, AActor Weapon, FName SocketName, int WeaponIndex, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepRelative)
	{
		ABGUCharacter aBGUCharacter = Unit as ABGUCharacter;
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			return null;
		}
		if (Weapon != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aBGUCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AttachWeapon.Invoke(Weapon, WeaponIndex, SocketName, LocationRule, RotationRule, ScaleRule);
			}
		}
		return Weapon;
	}

	public static FName BGUGetWeaponSocketNameByIndex(AActor Owner, int index)
	{
		if (Owner.IsNullOrDestroyed())
		{
			return FName.None;
		}
		BUC_ConfigInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ConfigInfoData>(Owner);
		if (readOnlyData == null)
		{
			return FName.None;
		}
		if (readOnlyData.Weapons.Count <= index || index < 0)
		{
			return FName.None;
		}
		return readOnlyData.Weapons[index].SocketName;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponByIndex")]
	public static AActor BGUGetWeaponByIndex(AActor Owner, int index)
	{
		if (Owner.IsNullOrDestroyed())
		{
			return null;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(Owner)?.FindWeaponByIndex(index);
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponNum")]
	public static int BGUGetWeaponNum(AActor Unit)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return 0;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(Unit)?.GetWeaponNum() ?? 0;
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUFullTransEnergy")]
	public static void BGUFullTransEnergy(UObject WorldContext)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(WorldContext, 0));
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_GMSetFullEnergy.Invoke(1f);
		}
	}

	public static bool IsInBattling(AActor OwnerActor)
	{
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(OwnerActor);
		if (readOnlyData == null)
		{
			return false;
		}
		if (readOnlyData.GetTargetInfo().LockTargetActor != null || readOnlyData.GetTargetedCount() > 0)
		{
			return true;
		}
		return false;
	}

	public static bool IsBeingTargeted(AActor OwnerActor)
	{
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(OwnerActor);
		if (readOnlyData == null)
		{
			return false;
		}
		readOnlyData.GetTargetInfo();
		if (readOnlyData.GetTargetedCount() > 0)
		{
			return true;
		}
		return false;
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClearWeapon")]
	public static void BGUClearWeapon(AActor Owner)
	{
	}

	public static bool BGUCanPlayerCtrlCamera(AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
		BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Unit);
		if (readOnlyData == null || readOnlyData2 == null)
		{
			return false;
		}
		if (!Unit.IsActorTickEnabled())
		{
			return false;
		}
		return true;
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitState")]
	public static bool BGUHasUnitState(AActor Unit, EBGUUnitState UnitState)
	{
		if (Unit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>(Unit)?.HasState(UnitState) ?? false;
	}

	public static bool BGUIsUnitInBattle(AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_BattleStateData, BUC_BattleStateData>(Unit)?.IsUnitInBattle() ?? false;
	}

	[Category("BGU|Util")]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsUnitDead")]
	public static bool BGUIsUnitDead(AActor Unit)
	{
		if (Unit == null)
		{
			return true;
		}
		return BGUHasUnitState(Unit, EBGUUnitState.Dead);
	}

	public static bool BGUCanUnitRunAITree(AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
		BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Unit);
		BUC_BuffData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Unit);
		if (readOnlyData == null || readOnlyData3 == null || readOnlyData2 == null)
		{
			return false;
		}
		if (readOnlyData.HasState(EBGUUnitState.Dead) || readOnlyData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || readOnlyData2.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return false;
		}
		return true;
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitSimpleState")]
	public static bool BGUHasUnitSimpleState(AActor Unit, EBGUSimpleState SimpleState)
	{
		if (Unit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Unit)?.HasSimpleState(SimpleState) ?? false;
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTestEnum")]
	public static void BGUTestEnum(AActor Unit, EBGUSimpleState SimpleState)
	{
	}

	public static void DisplayGMInfoForPassiveSkills(Dictionary<int, Dictionary<string, float>> CachedBuffModifyData, ref string Str)
	{
		foreach (KeyValuePair<int, Dictionary<string, float>> CachedBuffModifyDatum in CachedBuffModifyData)
		{
			int key = CachedBuffModifyDatum.Key;
			Dictionary<string, float> value = CachedBuffModifyDatum.Value;
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(key, value);
			if (buffDescRuntime == null)
			{
				continue;
			}
			FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(key);
			FieldInfo[] fields = typeof(FUStBuffDesc).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
			for (int i = 0; i < fields.Length; i++)
			{
				if (fields[i].GetValue(originalBuffDesc) is RepeatedField<FUStBuffEffectAttr> repeatedField)
				{
					for (int j = 0; j < repeatedField.Count; j++)
					{
						for (int k = 0; k < repeatedField[j].EffectParamsFloat.Count; k++)
						{
							float floatEffectParam = buffDescRuntime.GetFloatEffectParam(j, k);
							float num = repeatedField[j].EffectParamsFloat[k];
							if (floatEffectParam != num)
							{
								Str = Str + "Buff.Effects[" + j + "].ParamsFloat[" + k + "]: " + floatEffectParam + "(" + num + ")\n";
							}
						}
						for (int l = 0; l < repeatedField[j].EffectParams.Count; l++)
						{
							float num2 = buffDescRuntime.GetIntEffectParam(j, l);
							float num3 = repeatedField[j].EffectParams[l];
							if (num2 != num3)
							{
								Str = Str + "Buff.Effects[" + j + "].ParamsInt[" + l + "]: " + num2 + "(" + num3 + ")\n";
							}
						}
					}
				}
				else if (fields[i].Name != "_unknownFields")
				{
					string text = "";
					string text2 = fields[i].GetValue(originalBuffDesc).ToString();
					if (fields[i].Name == "Duration")
					{
						text = buffDescRuntime.GetDuration().ToString();
					}
					else if (fields[i].Name == "Interval")
					{
						text = buffDescRuntime.GetInterval().ToString();
					}
					else if (fields[i].Name == "MaxLayer")
					{
						text = buffDescRuntime.GetMaxLayer().ToString();
					}
					else if (fields[i].Name == "TargetCount")
					{
						text = buffDescRuntime.GetTargetCount().ToString();
					}
					else if (fields[i].Name == "Range")
					{
						text = buffDescRuntime.GetRangeParam(0).ToString();
						text2 = originalBuffDesc.Range.RangeParam[0].ToString();
					}
					if (text != "" && text != text2)
					{
						Str = Str + "Buff." + fields[i].Name + ": " + text + "(" + text2 + ")\n";
					}
				}
			}
		}
	}

	public static bool BGUCheckBuffEffectActiveCondition(int ID, bool bIsBuff, AActor Owner, EGSBuffAndSkillEffectActiveCondition ConditionType, string[] SplittedConditionParams, AActor CheckTarget = null)
	{
		switch (ConditionType)
		{
		case EGSBuffAndSkillEffectActiveCondition.Always:
			return true;
		case EGSBuffAndSkillEffectActiveCondition.ByProbability:
		{
			if (SplittedConditionParams.Length < 1)
			{
				return false;
			}
			if (int.TryParse(SplittedConditionParams[0], out var result22))
			{
				return UB1Util.GetRandomNumberFloat(0f, 1f) * 10000f <= (float)result22;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.HasTalent:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result29))
				{
					if (!BGUHasTalentByID(Owner, result29))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.HasAnyTalent:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result6))
				{
					if (BGUHasTalentByID(Owner, result6))
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.MasterHasTalent:
		{
			IBUC_MasterData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner);
			if (readOnlyData3 == null)
			{
				return false;
			}
			AActor masterActor = readOnlyData3.GetMasterActor();
			if (masterActor == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result11))
				{
					if (!BGUHasTalentByID(masterActor, result11))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.NotHasTalent:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result8))
				{
					if (BGUHasTalentByID(Owner, result8))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.HasBuff:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result30))
				{
					if (!BGUHasBuffByID(Owner, result30))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetHasBuff:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result5))
				{
					if (!BGUHasBuffByID(CheckTarget, result5))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetHasSimpleState:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result28))
				{
					if (!BGUHasUnitSimpleState(CheckTarget, (EBGUSimpleState)result28))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetHasAnySimpleState:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result2))
				{
					if (BGUHasUnitSimpleState(CheckTarget, (EBGUSimpleState)result2))
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetHasAbnormalState:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			IBUC_AbnormalStateHandlers unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AbnormalStateHandlers, BUC_AbnormalStateHandlers>(CheckTarget);
			if (unPersistentReadOnlyData == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result14))
				{
					if (!unPersistentReadOnlyData.IsInFinalState((EAbnormalStateType)result14))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.NotHasBuff:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result9))
				{
					if (BGUHasBuffByID(Owner, result9))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.HasAnyBuff:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result31))
				{
					if (BGUHasBuffByID(Owner, result31))
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetHasAnyBuff:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result3))
				{
					if (BGUHasBuffByID(CheckTarget, result3))
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetNotHasBuff:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result15))
				{
					if (BGUHasBuffByID(CheckTarget, result15))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.ByAttr:
		{
			if (SplittedConditionParams.Length != 5)
			{
				return false;
			}
			if (!int.TryParse(SplittedConditionParams[0], out var _) || !int.TryParse(SplittedConditionParams[1], out var result18) || !int.TryParse(SplittedConditionParams[2], out var result19) || !int.TryParse(SplittedConditionParams[3], out var result20) || !int.TryParse(SplittedConditionParams[4], out var result21))
			{
				return false;
			}
			float valueFromAttrID = GetValueFromAttrID(Owner, result18);
			float valueFromAttrID2 = GetValueFromAttrID(Owner, result19);
			bool flag = result20 > 0;
			bool flag2 = valueFromAttrID / valueFromAttrID2 * 10000f > (float)result21;
			if (!(flag && flag2))
			{
				if (!flag)
				{
					return !flag2;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.TargetByAttr:
		{
			if (CheckTarget == null)
			{
				return false;
			}
			if (SplittedConditionParams.Length != 5)
			{
				return false;
			}
			if (!int.TryParse(SplittedConditionParams[0], out var _) || !int.TryParse(SplittedConditionParams[1], out var result24) || !int.TryParse(SplittedConditionParams[2], out var result25) || !int.TryParse(SplittedConditionParams[3], out var result26) || !int.TryParse(SplittedConditionParams[4], out var result27))
			{
				return false;
			}
			float valueFromAttrID3 = GetValueFromAttrID(CheckTarget, result24);
			float valueFromAttrID4 = GetValueFromAttrID(CheckTarget, result25);
			bool flag3 = result26 > 0;
			bool flag4 = valueFromAttrID3 / valueFromAttrID4 * 10000f > (float)result27;
			if (!(flag3 && flag4))
			{
				if (!flag3)
				{
					return !flag4;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.CheckPhysMat:
		{
			List<int> list = new List<int>();
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result12))
				{
					list.Add(result12);
					continue;
				}
				return false;
			}
			IBUC_EnvironmentInteractionMgrData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(Owner);
			if (readOnlyData4 != null && list.Contains((int)readOnlyData4.ResultSurfaceType))
			{
				return true;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.IsSprinting:
		{
			BUC_MovementData readOnlyData6 = BGU_DataUtil.GetReadOnlyData<BUC_MovementData>(Owner);
			IBUC_ABPBasicData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPBasicData, BUC_ABPBasicData>(Owner);
			if (readOnlyData6 != null && unPersistentReadOnlyData2 != null)
			{
				string[] array = SplittedConditionParams;
				int i = 0;
				if (i < array.Length)
				{
					if (StringParseHelper.SafeTryFloatParse(array[i], out var Ret, IsNeedCatch: false))
					{
						if ((readOnlyData6.GetMoveType() == EBGUMoveMode.Normal || readOnlyData6.GetMoveType() == EBGUMoveMode.SideWalk) && unPersistentReadOnlyData2.Speed > Ret)
						{
							return true;
						}
						return false;
					}
					return false;
				}
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.CheckNotOnPhysMat:
		{
			List<int> list2 = new List<int>();
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result16))
				{
					list2.Add(result16);
					continue;
				}
				return false;
			}
			IBUC_EnvironmentInteractionMgrData readOnlyData5 = BGU_DataUtil.GetReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>(Owner);
			if (readOnlyData5 != null && list2.Contains((int)readOnlyData5.ResultSurfaceType))
			{
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.CheckResId:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result13))
				{
					if (BGU_DataUtil.GetActorResID(Owner) == result13)
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.MasterNotHasBuff:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result10))
				{
					IBUC_MasterData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner);
					if (readOnlyData2 == null)
					{
						return false;
					}
					if (BGUHasBuffByID(readOnlyData2.GetMasterActor(), result10))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.MasterHasAnyBuff:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result7))
				{
					IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner);
					if (readOnlyData == null)
					{
						return false;
					}
					if (BGUHasBuffByID(readOnlyData.GetMasterActor(), result7))
					{
						return true;
					}
					continue;
				}
				return false;
			}
			return false;
		}
		case EGSBuffAndSkillEffectActiveCondition.HasSimpleState:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result4))
				{
					if (!BGUHasUnitSimpleState(Owner, (EBGUSimpleState)result4))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		case EGSBuffAndSkillEffectActiveCondition.NotHasSimpleState:
		{
			string[] array = SplittedConditionParams;
			for (int i = 0; i < array.Length; i++)
			{
				if (int.TryParse(array[i], out var result))
				{
					if (BGUHasUnitSimpleState(Owner, (EBGUSimpleState)result))
					{
						return false;
					}
					continue;
				}
				return false;
			}
			return true;
		}
		default:
			return true;
		}
	}

	public static float GetValueFromAttrID(AActor Target, int AttrID)
	{
		return BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Target).GetFloatValue((EBGUAttrFloat)AttrID);
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuff")]
	public static bool BGUHasBuff(AActor Unit, EBPBuffID BuffID)
	{
		if (Unit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Unit)?.HasBuff((int)BuffID) ?? false;
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuffByID")]
	public static bool BGUHasBuffByID(AActor Unit, int BuffID)
	{
		if (Unit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Unit)?.HasBuff(BuffID) ?? false;
	}

	public static bool BGUHasTalentByID(AActor Unit, int TalentID)
	{
		if (Unit.IsNullOrDestroyed())
		{
			return false;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TalentData, BUC_TalentData>(Unit)?.HasTalent(TalentID) ?? false;
	}

	public static bool BGUIsMoveActive(AActor Unit, int MoveRequestIdx)
	{
		if (!Unit.IsNullOrDestroyed() && MoveRequestIdx > 0)
		{
			BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
			if (unPersistentReadOnlyData != null)
			{
				return unPersistentReadOnlyData.GetLastMoveIdx() == MoveRequestIdx;
			}
		}
		return false;
	}

	public static bool BGUIsMoving(AActor Unit)
	{
		if (!Unit.IsNullOrDestroyed())
		{
			BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
			if (unPersistentReadOnlyData != null)
			{
				return unPersistentReadOnlyData.GetLastMoveIdx() > 0;
			}
		}
		return false;
	}

	private static bool HasSimpleStateAndLog(BUC_SimpleStateData UnitSimpleStates, EBGUSimpleState SimpleState, int LogLvl)
	{
		if (UnitSimpleStates == null)
		{
			return false;
		}
		if (UnitSimpleStates.HasSimpleState(SimpleState))
		{
			_ = 0;
			return true;
		}
		return false;
	}

	private static bool HasStateAndLog(BUC_UnitStateData UnitStates, EBGUUnitState UnitState, int LogLvl)
	{
		if (UnitStates.HasState(UnitState))
		{
			_ = 0;
			return true;
		}
		return false;
	}

	private static bool CheckCanMoveImpl(bool bEnableAttackRotate, AActor Unit)
	{
		if (Unit == null)
		{
			return false;
		}
		int logLvl = 0;
		BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Unit);
		if (readOnlyData != null && (HasSimpleStateAndLog(readOnlyData, EBGUSimpleState.CantMove, logLvl) || HasSimpleStateAndLog(readOnlyData, EBGUSimpleState.Immobilizing, logLvl) || HasSimpleStateAndLog(readOnlyData, EBGUSimpleState.Frozen, logLvl) || HasSimpleStateAndLog(readOnlyData, EBGUSimpleState.PendingDeathInAnimationSyncing, logLvl)))
		{
			return false;
		}
		BUC_UnitStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
		if (readOnlyData2 != null)
		{
			if (HasStateAndLog(readOnlyData2, EBGUUnitState.Dead, logLvl))
			{
				return false;
			}
			if (HasStateAndLog(readOnlyData2, EBGUUnitState.LifeSavingHair_FakeDead, logLvl))
			{
				return false;
			}
			if (!readOnlyData2.HasState(EBGUUnitState.InMoveWindow))
			{
				if (HasStateAndLog(readOnlyData2, EBGUUnitState.Beatback, logLvl))
				{
					return false;
				}
				if (bEnableAttackRotate)
				{
					if (HasStateAndLog(readOnlyData2, EBGUUnitState.Attacking, logLvl))
					{
						return false;
					}
				}
				else if (HasStateAndLog(readOnlyData2, EBGUUnitState.Attacking, logLvl) && !readOnlyData2.HasState(EBGUUnitState.AttackMoving))
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	public static bool BGUCanMoveRun(AActor Unit)
	{
		return CheckCanMoveImpl(bEnableAttackRotate: false, Unit);
	}

	public static bool BGUCanMoveRotate(AActor Unit)
	{
		return CheckCanMoveImpl(bEnableAttackRotate: true, Unit);
	}

	public static AActor BGUGetAOTarget(AActor Unit)
	{
		if (Unit == null)
		{
			return null;
		}
		AActor result = null;
		if (Unit as BGUCharacterCS != null)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
			if (readOnlyData == null)
			{
				return null;
			}
			result = readOnlyData.GetAOTarget().LockTargetActor;
		}
		return result;
	}

	[Category("BGU|Util")]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetTarget")]
	public static AActor BGUGetTarget(AActor Unit)
	{
		if (Unit == null)
		{
			return null;
		}
		AActor result = null;
		if (Unit as BGUCharacterCS != null)
		{
			IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
			if (readOnlyData == null)
			{
				return null;
			}
			result = readOnlyData.GetTargetInfo().LockTargetActor;
		}
		else
		{
			BGUProjectileBaseActor bGUProjectileBaseActor = Unit as BGUProjectileBaseActor;
			if (bGUProjectileBaseActor != null)
			{
				BUC_ObjActorMovementData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_ObjActorMovementData>(bGUProjectileBaseActor);
				if (readOnlyData2 != null)
				{
					result = readOnlyData2.TargetActor;
				}
			}
		}
		return result;
	}

	[BlueprintPure]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClosestPerceivedTarget")]
	public static AActor BGUClosestPerceivedTarget(AActor Unit)
	{
		UBUC_AIComponent unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<UBUC_AIComponent>(Unit);
		if (unPersistentReadOnlyData == null)
		{
			return null;
		}
		List<AActor> list = UBGUFuncLibSelectTargets.BGUGetSightPerceivedActors(unPersistentReadOnlyData.PerceptionComp);
		if (list == null)
		{
			return null;
		}
		AActor aActor = null;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
		float num = float.MaxValue;
		foreach (AActor item in list)
		{
			if (aActor == null || num > (BGUFuncLibActorTransformCS.BGUGetActorLocation(item) - fVector).Size())
			{
				aActor = item;
			}
		}
		return aActor;
	}

	public static UnitLockTargetInfo BGUGetTargetInfo(AActor Unit)
	{
		if (Unit == null)
		{
			return new UnitLockTargetInfo();
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
		if (readOnlyData == null)
		{
			return new UnitLockTargetInfo();
		}
		return readOnlyData.GetTargetInfo();
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetUnitLockTargetActor")]
	public static AActor GetUnitLockTargetActor(AActor Unit)
	{
		return BGUGetTargetInfo(Unit).LockTargetActor;
	}

	public static UnitLockTargetInfo BGUGetSkillBaseTargetInfo(AActor Unit)
	{
		UnitLockTargetInfo result = new UnitLockTargetInfo();
		if (Unit == null)
		{
			return result;
		}
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Unit);
		if (readOnlyData == null)
		{
			return result;
		}
		return readOnlyData.GetSkillBaseTarget();
	}

	[UFunction]
	[BlueprintPure]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetFloatAttr")]
	public static float BGUGetFloatAttr(AActor Unit, EBGUAttrFloat AttrID)
	{
		if (Unit == null)
		{
			return 0f;
		}
		return BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Unit)?.GetFloatValue(AttrID) ?? 0f;
	}

	public static bool BGUIsSkillReady(AActor Unit, int SkillID)
	{
		if (Unit == null)
		{
			return false;
		}
		return !BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit).HasState(EBGUUnitState.Beatback);
	}

	public static bool BGUIsSkillActive(AActor Unit, int SkillRequestIdx)
	{
		if (!Unit.IsNullOrDestroyed())
		{
			BUC_ActionRequestData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ActionRequestData>(Unit);
			BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
			if (unPersistentReadOnlyData != null && readOnlyData != null)
			{
				if (unPersistentReadOnlyData.GetLastSkillIdx() == SkillRequestIdx)
				{
					return readOnlyData.HasState(EBGUUnitState.Attacking);
				}
				return false;
			}
		}
		return false;
	}

	public static bool BGUIsValidSkillTarget(AActor Unit, int SkillID)
	{
		BUC_UnitStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitStateData>(Unit);
		if (readOnlyData != null)
		{
			if (readOnlyData.HasState(EBGUUnitState.Dead) || BGUHasUnitSimpleState(Unit, EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				return false;
			}
			_ = 0;
			return true;
		}
		return false;
	}

	public static void BGUSetAISenseConfig(AActor Owner, UAIPerceptionComponent PerceptionComp, int ResID, out bool IsHearingSet, out bool IsSightSet)
	{
		IsHearingSet = false;
		IsSightSet = false;
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(Owner);
		if (unPersistentReadOnlyData != null && PerceptionComp.GetOwner() as AIController != null)
		{
			AIFuncLib.SetAISenseConfig(PerceptionComp.Address, unPersistentReadOnlyData.HearRange, unPersistentReadOnlyData.SightRange, -1f, unPersistentReadOnlyData.VisionAngleDegrees, 500f, IsSightDominantSense: true, out IsHearingSet, out IsSightSet);
		}
	}

	public static FVector BGUCalcImpulseP2P(AActor OwnerActor, FVector TargetPos, float SpeedHor)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor);
		float num = 980f;
		FVector safeNormal2D = (TargetPos - fVector).GetSafeNormal2D();
		FVector upVector = FVector.UpVector;
		float num2 = FVector2D.Distance(new FVector2D(TargetPos), new FVector2D(fVector)) / SpeedHor;
		float num3 = (TargetPos.Z - fVector.Z + num / 2f * num2 * num2) / num2;
		FVector fVector2 = OwnerActor.GetVelocity() * -1.0;
		FVector fVector3 = safeNormal2D * SpeedHor;
		FVector fVector4 = upVector * num3;
		return fVector2 + fVector3 + fVector4;
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCalcCharacterRotOnSlope")]
	public static FRotator BGUCalcCharacterRotOnSlope(ACharacter OwnerChr, out FVector SurfaceNormal_Normalized)
	{
		SurfaceNormal_Normalized = new FVector(0.0, 0.0, 0.0);
		UCapsuleComponent uCapsuleComponent = OwnerChr?.CapsuleComponent;
		if (uCapsuleComponent != null)
		{
			float scaledCapsuleHalfHeight = uCapsuleComponent.GetScaledCapsuleHalfHeight();
			float scaledCapsuleRadius = uCapsuleComponent.GetScaledCapsuleRadius();
			FVector worldLocation = uCapsuleComponent.GetWorldLocation();
			FVector forwardVector = uCapsuleComponent.GetForwardVector();
			FVector rightVector = uCapsuleComponent.GetRightVector();
			new List<AActor>().Add(OwnerChr);
			for (int i = 0; i < 3; i++)
			{
				FVector fVector = forwardVector * scaledCapsuleRadius;
				switch (i)
				{
				case 0:
					fVector = forwardVector * (0f - scaledCapsuleRadius) + rightVector * scaledCapsuleRadius;
					break;
				case 1:
					fVector = forwardVector * (0f - scaledCapsuleRadius) - rightVector * scaledCapsuleRadius;
					break;
				}
				if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(OwnerChr, worldLocation - new FVector(0.0, 0.0, scaledCapsuleHalfHeight * 0.5f) + fVector, worldLocation - new FVector(0.0, 0.0, scaledCapsuleHalfHeight * 2f) + fVector, out var hitResultSimple))
				{
					SurfaceNormal_Normalized += new FVector(hitResultSimple.HitImpactNormal.X, hitResultSimple.HitImpactNormal.Y, hitResultSimple.HitImpactNormal.Z) * 0.33000001311302185;
				}
				else
				{
					SurfaceNormal_Normalized += new FVector(0.0, 0.0, 0.33000001311302185);
				}
			}
			FRotator worldRotation = uCapsuleComponent.GetWorldRotation();
			worldRotation.Pitch = MathLib.MakeRotFromYZ(rightVector, SurfaceNormal_Normalized).Pitch;
			worldRotation.Roll = MathLib.MakeRotFromXZ(forwardVector, SurfaceNormal_Normalized).Roll;
			SurfaceNormal_Normalized.Normalize();
			return worldRotation;
		}
		return default(FRotator);
	}

	public static FRotator BGUCalcSlopeSurfaceRot(AActor OwnerActor, List<AActor> Ignores, FVector LineTraceStart, FVector LineTraceEnd, float SamplingRadius)
	{
		FVector actorForwardVector = OwnerActor.GetActorForwardVector();
		FVector actorRightVector = OwnerActor.GetActorRightVector();
		FVector z = new FVector(0.0, 0.0, 0.0);
		for (int i = 0; i < 5; i++)
		{
			FVector fVector = actorForwardVector * SamplingRadius;
			switch (i)
			{
			case 0:
				fVector = actorForwardVector * (0f - SamplingRadius) + actorRightVector * SamplingRadius;
				break;
			case 1:
				fVector = actorForwardVector * (0f - SamplingRadius) - actorRightVector * SamplingRadius;
				break;
			case 2:
				fVector = actorRightVector * SamplingRadius;
				break;
			case 3:
				fVector = -actorRightVector * SamplingRadius;
				break;
			}
			if (USystemLibrary.LineTraceSingle(OwnerActor.World, LineTraceStart + fVector, LineTraceEnd + fVector, ETraceTypeQuery.TraceTypeQuery1, bTraceComplex: true, Ignores, EDrawDebugTrace.None, out var OutHit, bIgnoreSelf: true, FLinearColor.Red, FLinearColor.Red, 5f))
			{
				z += new FVector(OutHit.ImpactNormal.X, OutHit.ImpactNormal.Y, OutHit.ImpactNormal.Z) * 0.20000000298023224;
			}
			else
			{
				z += new FVector(0.0, 0.0, 0.20000000298023224);
			}
		}
		FRotator result = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerActor);
		result.Pitch = MathLib.MakeRotFromYZ(actorRightVector, z).Pitch;
		result.Roll = MathLib.MakeRotFromXZ(actorForwardVector, z).Roll;
		return result;
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ProjectWorldLocationToWidgetPositionWithSZInS")]
	public static void ProjectWorldLocationToWidgetPositionWithSZInS(APlayerController PlayerController, FVector WorldPos, out FVector2D ScreenPos)
	{
		if (!GIsSafeZonePaddingSizeCached)
		{
			GSafeZonePaddingSize = UGSE_UMGFuncLib.GetSafeZonePaddingSize(PlayerController);
			GIsSafeZonePaddingSizeCached = true;
		}
		UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(PlayerController, WorldPos, out ScreenPos, bPlayerViewportRelative: false);
		ScreenPos.X -= GSafeZonePaddingSize.Left;
		ScreenPos.Y -= GSafeZonePaddingSize.Top;
	}

	public static FVector2D BGUCalcWorldPositionProjectToScreenVec(APlayerController PlayerController, FVector StartVec, FVector EndVec)
	{
		if (PlayerController == null)
		{
			return default(FVector2D);
		}
		ProjectWorldLocationToWidgetPositionWithSZInS(PlayerController, StartVec, out var ScreenPos);
		ProjectWorldLocationToWidgetPositionWithSZInS(PlayerController, EndVec, out var ScreenPos2);
		return ScreenPos2 - ScreenPos;
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTriggerUnitState")]
	public static void BGUTriggerUnitState(AActor Actor, EBUStateTrigger StateTrigger, float Time)
	{
		if (!(Actor == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitStateTrigger.Invoke(StateTrigger, Time);
			}
		}
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayerCameraLockTarget")]
	public static void BGUPlayerCameraLockTarget(AActor Player, AActor Target)
	{
		if (!(Player == null))
		{
			BUS_EventCollectionCS.Get(Player).Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(Target, ETargetSourceType.None));
		}
	}

	public static void BGUClearPlayerCameraLock(AActor Player)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Player);
		bUS_GSEventCollection.Evt_ClearTargetInfo.Invoke();
		bUS_GSEventCollection.Evt_Camera_ClearCamLock.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUEnablePlayerGuiBeiCamera")]
	public static void BGUEnablePlayerGuiBeiCamera(UObject WorldContext, FRotator CurInverseAnimRotation)
	{
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(WorldContext, 0)).Evt_Camera_EnableGuiBeiCamera.Invoke(CurInverseAnimRotation);
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDisablePlayerGuiBeiCamera")]
	public static void BGUDisablePlayerGuiBeiCamera(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(WorldContext, 0)).Evt_Camera_DisableGuiBeiCamera.Invoke();
	}

	public static void BGUStartTortoiseFakeMove(UObject WorldContextObject, UAnimSequence InverseAnim, bool bIsLoop)
	{
		BGS_EventCollectionCS.Get(WorldContextObject).Evt_BGS_StartTortoiseFakeMove.Invoke(InverseAnim, bIsLoop);
	}

	public static void BGUStopTortoiseFakeMove(UObject WorldContextObject)
	{
		BGS_EventCollectionCS.Get(WorldContextObject).Evt_BGS_StopTortoiseFakeMove.Invoke();
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetGuibeiBoneTransformFromLastTick")]
	public static FTransform GetGuibeiBoneTransformFromLastTick(UAnimSequence AnimSeq, float CurTime, float LastTime, FName BoneName)
	{
		FTransform fTransform = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq, CurTime, BoneName);
		FTransform other = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq, LastTime, BoneName);
		return fTransform.GetRelativeTransform(other);
	}

	public static FTransform GetAnimBoneTransformFromLastTick(UAnimSequence AnimSeq, float CurTime, float LastTime, FName BoneName, UCurveVector LocationCurve = null, UCurveVector MultiplierCurveL = null, UCurveVector RotationCurve = null, UCurveVector MultiplierCurveR = null)
	{
		FTransform fTransform = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq, CurTime, BoneName);
		FTransform other = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq, LastTime, BoneName);
		if (LocationCurve != null && MultiplierCurveL != null)
		{
			fTransform.SetLocation(fTransform.GetLocation() + LocationCurve.GetVectorValue(CurTime) * MultiplierCurveL.GetVectorValue(CurTime));
			other.SetLocation(other.GetLocation() + LocationCurve.GetVectorValue(LastTime) * MultiplierCurveL.GetVectorValue(LastTime));
		}
		if (RotationCurve != null && MultiplierCurveR != null)
		{
			FVector fVector = RotationCurve.GetVectorValue(CurTime) * MultiplierCurveR.GetVectorValue(CurTime);
			FRotator fRotator = fTransform.Rotator();
			fTransform.SetRotation(new FRotator(fRotator.Pitch + fVector.X, fRotator.Yaw + fVector.Y, fRotator.Roll + fVector.Z).Quaternion());
			FVector fVector2 = RotationCurve.GetVectorValue(LastTime) * MultiplierCurveR.GetVectorValue(LastTime);
			FRotator fRotator2 = other.Rotator();
			other.SetRotation(new FRotator(fRotator2.Pitch + fVector2.X, fRotator2.Yaw + fVector2.Y, fRotator2.Roll + fVector2.Z).Quaternion());
		}
		return fTransform.GetRelativeTransform(other);
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:RotateLevelRelativeToParentTransform")]
	public static void RotateLevelRelativeToParentTransform(UObject WorldContextObject, FName LevelName, FTransform ParentTransform, FTransform ParentTransformOffset)
	{
		FTransform levelTransform = CalTransformRelativeToParentTransformOffset(UBGUFunctionLibrary.GetLevelStreamingLevelTransformByName(WorldContextObject, LevelName), ParentTransform, ParentTransformOffset);
		UBGUFunctionLibrary.ApplyLevelTransform(WorldContextObject, LevelName, levelTransform);
	}

	public static FTransform AddTransform(FTransform Transform, FTransform TransformOffset)
	{
		return new FTransform(Transform.Rotation * TransformOffset.Rotation, Transform.Translation + TransformOffset.Translation, new FVector(Transform.Scale3D.X * TransformOffset.Scale3D.X, Transform.Scale3D.Y * TransformOffset.Scale3D.Y, Transform.Scale3D.Z * TransformOffset.Scale3D.Z));
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:CalTransformRelativeToParentTransformOffset")]
	public static FTransform CalTransformRelativeToParentTransformOffset(FTransform SelfTransform, FTransform ParentTransform, FTransform ParentTransformOffset)
	{
		FTransform relativeTransform = SelfTransform.GetRelativeTransform(ParentTransform);
		ParentTransform = AddTransform(ParentTransform, ParentTransformOffset);
		return AddTransform(ParentTransform, relativeTransform);
	}

	public static FRotator GetMoveYawDirection(AController Ctrl, APlayerCameraManager PlayerCameraManager = null)
	{
		AActor aActor = null;
		ABGPPlayerController aBGPPlayerController = Ctrl as ABGPPlayerController;
		if (aBGPPlayerController != null)
		{
			aActor = aBGPPlayerController.GetViewTarget();
		}
		if (aActor != null)
		{
			if (aActor as ABGUCharacter != null)
			{
				return Ctrl.GetControlRotation();
			}
			if (PlayerCameraManager != null)
			{
				return PlayerCameraManager.GetCameraRotation();
			}
			return BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
		}
		return new FRotator(0.0, 0.0, 0.0);
	}

	public static FRotator CalcDirWithInput(FRotator MoveYawDir, float ForwardVal, float RightVal)
	{
		MoveYawDir.Pitch = 0f;
		MoveYawDir.Roll = 0f;
		FMatrix fMatrix = FMatrix.CreateRotation(MoveYawDir);
		FVector fVector = fMatrix.GetUnitAxis(EAxis.X) * ForwardVal;
		FVector fVector2 = fMatrix.GetUnitAxis(EAxis.Y) * RightVal;
		FVector x = fVector + fVector2;
		return MathLib.MakeRotFromX(x);
	}

	public static int BGUGetTotalBuffLayersFromBuffGroup(AActor OwnerActor, int BuffGroupID, ref int ActiveBuffCount)
	{
		FUStBuffGroupDesc buffGroupDesc = BGW_GameDB.GetBuffGroupDesc(BuffGroupID);
		if (buffGroupDesc == null)
		{
			return 0;
		}
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(OwnerActor);
		if (readOnlyData == null)
		{
			return 0;
		}
		int num = 0;
		foreach (int buffID in buffGroupDesc.BuffIDList)
		{
			int buffLayer = readOnlyData.GetBuffLayer(buffID);
			num += buffLayer;
			if (buffLayer > 0)
			{
				ActiveBuffCount++;
			}
		}
		return num;
	}

	public static bool BGUGetIsPatrolling(AActor TargetActor)
	{
		return BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PatrolData>(TargetActor)?.bIsPatroling ?? false;
	}

	public static List<BGUCharacterCS> BGUGetAllChrByTeamID(UObject WorldContext, int TeamID)
	{
		List<BGUCharacterCS> list = new List<BGUCharacterCS>();
		BGUCharacterCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUCharacterCS>(WorldContext);
		foreach (BGUCharacterCS bGUCharacterCS in allActorsOfClass)
		{
			if (BGU_DataUtil.GetActorTeamID(bGUCharacterCS) == TeamID)
			{
				list.Add(bGUCharacterCS);
			}
		}
		return list;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActor")]
	public static AActor BGUSpawnActor(UWorld _World, TSubclassOf<AActor> ActorClass, FVector Location, FRotator Rotation)
	{
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		return _World.SpawnActor(ActorClass.Value, ref Location, ref Rotation, ref parameters);
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorNoBeginPlay")]
	public static AActor BGUSpawnActorNoBeginPlay(UWorld _World, TSubclassOf<AActor> ActorClass)
	{
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		FVector location = FVector.ZeroVector;
		FRotator rotation = FRotator.ZeroRotator;
		return _World.SpawnActor(ActorClass.Value, ref location, ref rotation, ref parameters);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorAndECSBeginPlay")]
	public static AActor BGUSpawnActorAndECSBeginPlay(UWorld _World, TSubclassOf<AActor> ActorClass)
	{
		FActorSpawnParameters parameters = new FActorSpawnParameters
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AlwaysSpawn
		};
		FVector Location = FVector.ZeroVector;
		FRotator Rotation = FRotator.ZeroRotator;
		return BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(_World, ActorClass.Value, ref Location, ref Rotation, ref parameters);
	}

	public static void BGUTriggerLeaveStealthMode(AActor PlayerActor)
	{
	}

	public static bool BGUIsTargetInView(FVector OriPosition, FRotator OriRotation, FVector TargetPostion, float AngleOneSide)
	{
		float num = BGUFuncLibAICS.BGUCalAngleWith2PointAndDir(OriPosition, OriRotation, TargetPostion);
		if ((num >= 0f && num <= AngleOneSide) || (num <= 0f && num >= 0f - AngleOneSide))
		{
			return true;
		}
		return false;
	}

	public static bool BGUSeletUnitsFilter(BGUCharacterCS WakeUpTarget, List<int> ResIDList, bool bActiveUnitHasTarget, bool bActivePassiveUnit)
	{
		if (ResIDList == null || WakeUpTarget == null)
		{
			return false;
		}
		int resID = WakeUpTarget.GetResID();
		if (ResIDList.Count > 0 && !ResIDList.Contains(resID))
		{
			return false;
		}
		if (!bActiveUnitHasTarget && BGUGetTarget(WakeUpTarget) != null)
		{
			return false;
		}
		if (!bActivePassiveUnit)
		{
			BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(WakeUpTarget);
			if (unPersistentReadOnlyData == null)
			{
				return false;
			}
			if (unPersistentReadOnlyData.UnitAIAttackType == EUnitAIAttackType.PassiveAttack)
			{
				return false;
			}
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAISetSpeedRate")]
	public static void BGUAISetSpeedRate(AActor Unit, float SpeedRate)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_AISetSpeedRate.Invoke(SpeedRate);
		}
	}

	public static void BGUAIChangeToTargetSpeedRate(AActor Owner, EAIMoveSpeedType SpeedRateType)
	{
		float unitSpeedRateByMoveSpeedType = AIFuncLibForCS.GetUnitSpeedRateByMoveSpeedType(Owner, SpeedRateType);
		unitSpeedRateByMoveSpeedType = ((unitSpeedRateByMoveSpeedType > 0f) ? unitSpeedRateByMoveSpeedType : 1f);
		BGUAIChangeToTargetSpeedRate(Owner, unitSpeedRateByMoveSpeedType);
	}

	public static void BGUAIChangeToTargetSpeedRate(AActor Owner, float SpeedRate)
	{
		if (!Owner.IsNullOrDestroyed())
		{
			IBUC_SpeedCtrlData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_SpeedCtrlData, BUC_SpeedCtrlData>(Owner);
			if (unPersistentReadOnlyData != null)
			{
				float moveSpeedSlow = unPersistentReadOnlyData.GetMoveSpeedSlow();
				float moveSpeedNormal = unPersistentReadOnlyData.GetMoveSpeedNormal();
				float moveSpeedFast = unPersistentReadOnlyData.GetMoveSpeedFast();
				float num = SpeedRate * moveSpeedFast;
				EBUStateTrigger triggerID = ((num < (moveSpeedSlow + moveSpeedNormal) / 2f) ? EBUStateTrigger.AIInputWalk : ((!(num < (moveSpeedNormal + moveSpeedFast) / 2f)) ? EBUStateTrigger.AIInputSprint : EBUStateTrigger.AIInputRun));
				BUS_EventCollectionCS.Get(Owner).Evt_AISetSpeedRate.Invoke(SpeedRate, EBGUSpeedCtrlID.MoveSpeedRate);
				BUS_EventCollectionCS.Get(Owner).Evt_UnitStateTrigger.Invoke(triggerID, 0f);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCachedPointSet")]
	public static List<FVector> BGUGetCachedPointSet(AActor OwnerCharacter, int RequestID)
	{
		List<FVector> result = new List<FVector>();
		if (OwnerCharacter.IsNullOrDestroyed())
		{
			return result;
		}
		BUC_PointSetsData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PointSetsData>(OwnerCharacter);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.PointQueneMap.ContainsKey(RequestID))
		{
			result = unPersistentReadOnlyData.PointQueneMap[RequestID];
		}
		return result;
	}

	public static List<FRotator> BGUGetCachedPointSet_Rot(AActor OwnerCharacter, int RequestID)
	{
		List<FRotator> result = new List<FRotator>();
		if (OwnerCharacter.IsNullOrDestroyed())
		{
			return result;
		}
		BUC_PointSetsData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_PointSetsData>(OwnerCharacter);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.PointQueneMap_Rot.ContainsKey(RequestID))
		{
			result = unPersistentReadOnlyData.PointQueneMap_Rot[RequestID];
		}
		return result;
	}

	public static void BGUCachePointsAdded(AActor OwnerCharacter, int RequestID, List<FVector> Points, bool bClearTheQuene)
	{
		if (!OwnerCharacter.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AddPointsToQuene.Invoke(RequestID, Points, bClearTheQuene);
			}
		}
	}

	[UFunction]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCallPointsRegister")]
	public static void BGUCallPointsRegister(AActor OwnerCharacter, int RequestID, PointsGenType GenType, PointsGenExtParam ExtParam)
	{
		if (!OwnerCharacter.IsNullOrDestroyed())
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(OwnerCharacter);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_CallPointsRegister.Invoke(RequestID, GenType, ExtParam);
			}
		}
	}

	[BlueprintPure]
	[UFunction]
	[Tooltip("0: B1, 1: X2, 2: U3")]
	[Category("BGU|Util")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetActiveGameMode")]
	public static int BGUGetActiveGameMode()
	{
		return 0;
	}

	[BlueprintCallable]
	[Category("BGU|Util")]
	[BlueprintPure]
	[Tooltip("0: Programmer, 1: Non-Programmer")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCurrentUserType")]
	public static int BGUGetCurrentUserType()
	{
		FileInfo[] files = new DirectoryInfo(USystemLibrary.GetProjectDirectory()).GetFiles("*.*");
		for (int i = 0; i < files.Length; i++)
		{
			if (files[i].Name == "GenVSProject.bat")
			{
				return 0;
			}
		}
		return 1;
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintPure]
	[Category("BGU|Camera")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFOV")]
	public static float GetCameraFOV(ACameraActor CameraActor)
	{
		if (CameraActor == null)
		{
			return 0f;
		}
		return CameraActor.CameraComponent.FieldOfView;
	}

	[Category("BGU|Camera")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFOV")]
	public static void SetCameraFOV(ACameraActor CameraActor, float NewFOV)
	{
		if (!(CameraActor == null))
		{
			CameraActor.CameraComponent.FieldOfView = NewFOV;
		}
	}

	[Category("BGU|Camera")]
	[BlueprintCallable]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetCineCameraFocalLength")]
	public static float GetCineCameraFocalLength(ACineCameraActor CineCameraActor)
	{
		if (CineCameraActor == null)
		{
			return 0f;
		}
		return (CineCameraActor.CameraComponent as UCineCameraComponent).CurrentFocalLength;
	}

	[BlueprintCallable]
	[Category("BGU|Camera")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetCineCameraFocalLength")]
	public static void SetCineCameraFocalLength(ACineCameraActor CineCameraActor, float NewFocalLength)
	{
		if (!(CineCameraActor == null))
		{
			(CineCameraActor.CameraComponent as UCineCameraComponent).CurrentFocalLength = NewFocalLength;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintPure]
	[Category("BGU|Camera")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFocusDistance")]
	public static float GetCameraFocusDistance(ACameraActor CameraActor)
	{
		if (CameraActor == null)
		{
			return 0f;
		}
		UCameraComponent cameraComponent = CameraActor.CameraComponent;
		UCineCameraComponent uCineCameraComponent = cameraComponent as UCineCameraComponent;
		if (!(uCineCameraComponent != null))
		{
			return cameraComponent.PostProcessSettings.DepthOfFieldFocalDistance;
		}
		return uCineCameraComponent.FocusSettings.ManualFocusDistance;
	}

	[UFunction]
	[Category("BGU|Camera")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFocusDistance")]
	public static void SetCameraFocusDistance(ACameraActor CameraActor, float NewFocusDistance)
	{
		if (!(CameraActor == null))
		{
			UCameraComponent cameraComponent = CameraActor.CameraComponent;
			UCineCameraComponent uCineCameraComponent = cameraComponent as UCineCameraComponent;
			if (uCineCameraComponent != null)
			{
				FCameraFocusSettings focusSettings = uCineCameraComponent.FocusSettings;
				focusSettings.ManualFocusDistance = NewFocusDistance;
				uCineCameraComponent.FocusSettings = focusSettings;
			}
			else
			{
				FPostProcessSettings postProcessSettings = cameraComponent.PostProcessSettings;
				postProcessSettings.DepthOfFieldFocalDistance = NewFocusDistance;
				cameraComponent.PostProcessSettings = postProcessSettings;
			}
		}
	}

	[Category("BGU|FX")]
	[BlueprintCallable]
	[BlueprintPure]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetRTForFX")]
	public static UTextureRenderTarget2D GetRTForFX(AActor OwnerActor, RenderTargetType RTType)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return null;
		}
		return BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_RenderTargetMgrData>(OwnerActor)?.GetTextureRenderTarget(RTType);
	}

	public static FVector BGUGetVectorFromNetQuantizeVector(in FVector_NetQuantize InVec)
	{
		return new FVector(InVec.X, InVec.Y, InVec.Z);
	}

	public static FVector BGUGetVectorFromNetQuantizeVector(in FVector_NetQuantizeNormal InVec)
	{
		return new FVector(InVec.X, InVec.Y, InVec.Z);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PrepareForSkillRecording")]
	public static void PrepareForSkillRecording(UWorld World, TSubclassOf<BGUCharacterCS> UnitClass, int ResID, int SkillID, bool bNeedsSpawnNewUnit, ref BGUCharacterCS SpawnedUnit, out UAnimMontage PlayedMontage)
	{
		PlayedMontage = null;
		if (World == null)
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(ResID);
		if (unitCommDesc == null)
		{
			return;
		}
		string name = "";
		switch (unitCommDesc.UnitBodyType)
		{
		case EUnitBodyType.Small:
			name = "Small";
			break;
		case EUnitBodyType.Medium:
			name = "Medium";
			break;
		case EUnitBodyType.MediumBig:
			name = "MediumBig";
			break;
		case EUnitBodyType.Big:
			name = "Big";
			break;
		case EUnitBodyType.Huge:
			name = "Huge";
			break;
		}
		UGameplayStatics.GetAllActorsOfClassWithTag(World, UClass.GetClass<BGUSceneItemBase>(), new FName(name), out var OutActors);
		FVector Location = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[0]);
		FRotator Rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(OutActors[0]);
		if (bNeedsSpawnNewUnit)
		{
			if (SpawnedUnit != null)
			{
				BGU_UnrealWorldUtil.DestroyActor(SpawnedUnit);
			}
			FActorSpawnParameters parameters = new FActorSpawnParameters
			{
				SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
			};
			SpawnedUnit = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(World, UnitClass.Value, ref Location, ref Rotation, ref parameters) as BGUCharacterCS;
			BGUSetUnitSimpleState(SpawnedUnit, EBGUSimpleState.CancelSkillCD, IsRemove: false);
			if (SpawnedUnit == null)
			{
				return;
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(SpawnedUnit)?.Evt_SetActorLocationAndRotation.Invoke(Location, Rotation, bSweep: false, bTeleport: false);
		}
		FUStSkillAIDesc skillAIDesc = BGW_GameDB.GetSkillAIDesc(SkillID);
		if (skillAIDesc == null)
		{
			return;
		}
		int num = 0;
		int num2 = skillAIDesc.AngleScoreSector0To45;
		if (skillAIDesc.AngleScoreSector45To90 > num2)
		{
			num2 = skillAIDesc.AngleScoreSector45To90;
			num = 1;
		}
		if (skillAIDesc.AngleScoreSector90To135 > num2)
		{
			num2 = skillAIDesc.AngleScoreSector90To135;
			num = 2;
		}
		if (skillAIDesc.AngleScoreSector135To180 > num2)
		{
			num2 = skillAIDesc.AngleScoreSector135To180;
			num = 3;
		}
		if (skillAIDesc.AngleScoreSector180ToNeg135 > num2)
		{
			num2 = skillAIDesc.AngleScoreSector180ToNeg135;
			num = 4;
		}
		if (skillAIDesc.AngleScoreSectorNeg135ToNeg90 > num2)
		{
			num2 = skillAIDesc.AngleScoreSectorNeg135ToNeg90;
			num = 5;
		}
		if (skillAIDesc.AngleScoreSectorNeg90ToNeg45 > num2)
		{
			num2 = skillAIDesc.AngleScoreSectorNeg90ToNeg45;
			num = 6;
		}
		if (skillAIDesc.AngleScoreSectorNeg45To0 > num2)
		{
			num2 = skillAIDesc.AngleScoreSectorNeg45To0;
			num = 7;
		}
		float num3 = 0f;
		switch (num)
		{
		case 0:
			num3 = FMath.RandRange(0f, 45f);
			break;
		case 1:
			num3 = FMath.RandRange(45f, 90f);
			break;
		case 2:
			num3 = FMath.RandRange(90f, 135f);
			break;
		case 3:
			num3 = FMath.RandRange(135f, 180f);
			break;
		case 4:
			num3 = FMath.RandRange(-180f, -135f);
			break;
		case 5:
			num3 = FMath.RandRange(135f, -90f);
			break;
		case 6:
			num3 = FMath.RandRange(-90f, -45f);
			break;
		case 7:
			num3 = FMath.RandRange(-45f, 0f);
			break;
		}
		float num4 = FMath.RandRange((skillAIDesc.PreferRangeMin + skillAIDesc.PreferRangeMax) / 2f, skillAIDesc.PreferRangeMax);
		FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(SpawnedUnit) + SpawnedUnit.GetActorForwardVector().RotateAngleAxis(num3, FVector.UpVector).GetSafeNormal() * num4;
		APawn playerPawn = UGameplayStatics.GetPlayerPawn(World, 0);
		BGUFuncLibActorTransformCS.BGUSetActorLocation(playerPawn, newLocation, bSweep: false, bTeleport: false);
		BGUSetUnitSimpleState(playerPawn, EBGUSimpleState.ImmueDamage, IsRemove: false);
		UGameplayStatics.GetAllActorsOfClassWithTag(World, UClass.GetClass<ACameraActor>(), new FName(name), out var OutActors2);
		UGSE_EngineFuncLib.GetFirstLocalPlayerController(World).SetViewTargetWithBlend(OutActors2[0]);
		FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(SkillID, SpawnedUnit);
		if (skillSDesc != null)
		{
			PlayedMontage = BGW_PreloadAssetMgr.Get(World).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
			if (!(PlayedMontage == null))
			{
				BUS_EventCollectionCS.Get(SpawnedUnit).Evt_AIPauseBT.Invoke(P1: true);
			}
		}
	}

	public static void BGUSetSplineFlyControlInfo(AActor Owner, BGUSplineActor SplineActor, FGSSplineFlyMoveInfo SplineFlyMoveInfo)
	{
		if (!(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_SetSplineFlyControlInfo.Invoke(SplineActor, SplineFlyMoveInfo);
		}
	}

	public static void BGUSetTraceVelocityCameraInfo(AActor Owner, bool bUseTraceVelocityCamera, float TraceSpeedRate)
	{
		if (!(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_SetTraceVelocityCameraInfo.Invoke(bUseTraceVelocityCamera, TraceSpeedRate);
		}
	}

	public static void BGUSetAMScaleMaxRate(AActor Owner, float AMScaleMaxRate)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner) && !(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner)?.Evt_SetAMScaleMaxRate.Invoke(AMScaleMaxRate);
		}
	}

	public static FName BGUGetPlayerChanTag()
	{
		return B1GlobalFNames.PlayerChanTag;
	}

	public static void LogBattleInfo(AActor ContextActor, EBattleInfoType BattleInfoType, string BattleInfoLog, int BattleInfoLogOptions = 0, EBGULogVerbosity BGULogVerbosity = EBGULogVerbosity.Log)
	{
		if (!DebugConfig.IsOpenBattleInfoTool)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(ContextActor);
		if (ContextActor is BUTamerActor)
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(ContextActor);
			if (firstLocalPlayerController != null)
			{
				bUS_GSEventCollection = BUS_EventCollectionCS.Get(firstLocalPlayerController.GetControlledPawn());
			}
		}
		bUS_GSEventCollection?.Evt_AddBattleInfoLog.Invoke(BattleInfoType, BattleInfoLog, BattleInfoLogOptions, BGULogVerbosity);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitEquipFaBao")]
	public static void BGUUnitEquipFaBao(AActor Unit, int FaBaoID)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitEquipFaBao.Invoke(FaBaoID);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitUnequipFaBao")]
	public static void BGUUnitUnequipFaBao(AActor Unit)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitUnequipFaBao.Invoke();
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitCastFaBaoSkill")]
	public static void BGUUnitCastFaBaoSkill(AActor Unit)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Unit);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitCastFaBaoSkill.Invoke();
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:CanActivateConsoleCommad")]
	public static bool CanActivateConsoleCommad()
	{
		if (BGWConsoleCommands.NoAnyGM)
		{
			return false;
		}
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:IsCheatGMLevel")]
	public static bool IsCheatGMLevel()
	{
		return BGWConsoleCommands.HasGMFlag(2);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:IsDebugGMLevel")]
	public static bool IsDebugGMLevel()
	{
		return BGWConsoleCommands.HasGMFlag(4);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:IsUEDebugGMLevel")]
	public static bool IsUEDebugGMLevel()
	{
		return BGWConsoleCommands.HasGMFlag(8);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUToggleGlobalURO")]
	public static void BGUToggleGlobalURO(UObject UObj, bool bEnable)
	{
		if (UGSE_EngineFuncLib.IsStandAlone(UGSE_EngineFuncLib.GetWorldFromObj(UObj)))
		{
			DebugConfig.CanOptimizeTick = bEnable;
		}
	}

	[BlueprintCallable]
	[UFunction]
	[BlueprintPure]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetAttrValue")]
	public static float GetAttrValue(AActor Unit, EBGUAttrFloat AttrID)
	{
		return BGU_DataUtil.GetReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>(Unit)?.GetFloatValue(AttrID) ?? (-1f);
	}

	public static Dictionary<EBGMStopCondition, BGMStopEventInfo> GetConditionStopEvents(BGWStopEventConditionConfigInfo StopEventConditionConfig)
	{
		Dictionary<EBGMStopCondition, BGMStopEventInfo> dictionary = null;
		if (StopEventConditionConfig.LeaveBattleEventStop != null)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<EBGMStopCondition, BGMStopEventInfo>();
			}
			dictionary.Add(EBGMStopCondition.LeaveBattle, new BGMStopEventInfo(StopEventConditionConfig.LeaveBattleEventStop));
		}
		if (StopEventConditionConfig.PlayerDeadEventStop != null)
		{
			if (dictionary == null)
			{
				dictionary = new Dictionary<EBGMStopCondition, BGMStopEventInfo>();
			}
			dictionary.Add(EBGMStopCondition.PlayerDead, new BGMStopEventInfo(StopEventConditionConfig.PlayerDeadEventStop));
		}
		return dictionary;
	}

	public static Dictionary<EBGMStopCondition, BGMStopEventInfo> GetConditionStopEvents(FStopEventConditionConfig StopEventConditionConfig)
	{
		return GetConditionStopEvents(new BGWStopEventConditionConfigInfo(StopEventConditionConfig));
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchCameraGroup")]
	public static void SwitchCameraGroup(UObject WorldContext, int CameraGroupID)
	{
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:EnterPlayerSkillCamera")]
	public static void EnterPlayerSkillCamera(UObject WorldContext, int CameraID)
	{
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(WorldContext, 0))?.Evt_EnterPlayerSkillCamera.Invoke(CameraID);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExitPlayerSkillCamera")]
	public static void ExitPlayerSkillCamera(UObject WorldContext)
	{
		BUS_EventCollectionCS.Get(UGameplayStatics.GetPlayerCharacter(WorldContext, 0))?.Evt_ExitPlayerSkillCamera.Invoke();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:EnterMonsterSkillCamera")]
	public static void EnterMonsterSkillCamera(AActor Monster, int CameraID)
	{
		BPS_EventCollectionCS.GetLocal(Monster).Evt_EnterSkillCam.Invoke(Monster, CameraID);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExitMonsterSkillCamera")]
	public static void ExitMonsterSkillCamera(AActor Monster)
	{
		BPS_EventCollectionCS.GetLocal(Monster).Evt_ExitSkillCam.Invoke(Monster);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchLanguageEnZh")]
	public static void SwitchLanguageEnZh()
	{
		string currentCulture = GSLocalization.GetCurrentCulture();
		if (currentCulture.Contains("en"))
		{
			GSLocalization.SetCurrentCulture(GSLocalization.Culture_zh_Hans);
		}
		else if (currentCulture.Contains("zh"))
		{
			GSLocalization.SetCurrentCulture(GSLocalization.Culture_en);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:RefreshGameDB")]
	public static void RefreshGameDB()
	{
		BGW_GameDB.Init("B1");
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsEnemyTeam")]
	public static bool BGUIsEnemyTeam(AActor SelfUnit, AActor OtherUnit)
	{
		if (SelfUnit == null || OtherUnit == null)
		{
			return false;
		}
		return BGU_DataUtil.GetGameStateReadonlyData<IBGC_TeamRelationData, BGC_TeamRelationData>(SelfUnit).IsEnemyTeam(SelfUnit, OtherUnit);
	}

	public static bool BGUGetSuperArmorValueByLevel(string SuperArmorLevelName, string BlameInfo, string ToBlame, out float SuperArmorValue, AActor Caster)
	{
		SuperArmorValue = 0f;
		foreach (KeyValuePair<int, FUStSuperArmorLevelDesc> item in BGW_GameDB.GetAllSuperArmorLevelDesc())
		{
			if (SuperArmorLevelName == item.Value.SuperArmorLevelName)
			{
				SuperArmorValue = BGW_GameDB.GetSuperArmorLevelDescFinalvalueByID(item.Value.ID, Caster);
				return true;
			}
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchFreeCameraMode")]
	public static void SwitchFreeCameraMode(UObject InWorldContext)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(InWorldContext))
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext);
		if (firstLocalPlayerController != null)
		{
			APawn controlledPawn = firstLocalPlayerController.GetControlledPawn();
			if (controlledPawn != null)
			{
				BUS_EventCollectionCS.Get(controlledPawn)?.Evt_SwitchFreeCameraMode.Invoke(EPlayerFreeCameraType.None);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:EnterWeakPerformState")]
	public static void EnterWeakPerformState(UObject InWorldContext, int ConfigID)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(InWorldContext))
		{
			return;
		}
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext);
		if (firstLocalPlayerController != null)
		{
			BPS_GSEventCollection bPS_GSEventCollection = BPS_EventCollectionCS.Get(firstLocalPlayerController);
			if (bPS_GSEventCollection != null && bPS_GSEventCollection.HasBeginPlay)
			{
				bPS_GSEventCollection.Evt_EnterWeakPerformState.Invoke(ConfigID);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExitWeakPerformState")]
	public static void ExitWeakPerformState(UObject InWorldContext)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(InWorldContext))
		{
			APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(InWorldContext);
			if (firstLocalPlayerController != null)
			{
				BPS_EventCollectionCS.Get(firstLocalPlayerController)?.Evt_ExitWeakPerformState.Invoke();
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PlayUISound")]
	public static int PlayUISound(UObject InWorldContext, UAkAudioEvent InAudioEvent)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(InWorldContext))
		{
			return -1;
		}
		AActor actorOfClass = UGameplayStatics.GetActorOfClass(InWorldContext, UClass.GetClass<APlayerCameraManager>());
		return UAkGameplayStatics.PostEvent(InAudioEvent, actorOfClass, 0, null);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryDestroyDestructible")]
	public static void BGUTryDestroyDestructible(AActor DestructibleActor)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(DestructibleActor))
		{
			BUS_EventCollectionCS.Get(DestructibleActor)?.Evt_DestroyDestructible.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(DestructibleActor), FVector.OneVector, 1000f);
		}
	}

	public static void BGUDestroyDestructible(AActor DestructibleActor, FVector HitLocation, FVector ImpulseDir, float ImpulseStrength = -1f)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(DestructibleActor))
		{
			if (ImpulseStrength < 0f)
			{
				ImpulseStrength = GetDestructibleImpulse(DestructibleActor);
			}
			BUS_EventCollectionCS.Get(DestructibleActor)?.Evt_DestroyDestructible.Invoke(HitLocation, ImpulseDir, ImpulseStrength);
		}
	}

	public static void BGUSetTargetInfo(bool IsOnline, AActor Owner, UnitLockTargetInfo TargetInfo)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			if (IsOnline)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_SetTargetInfoServer.Invoke(BGUFuncLibReplication.GetLockTargetInfoForRPC(TargetInfo));
			}
			else
			{
				BUS_EventCollectionCS.Get(Owner).Evt_SetTargetInfo.Invoke(TargetInfo);
			}
		}
	}

	public static void BGUSetTargetInfoWithCameraLocking(bool IsOnline, AActor Owner, UnitLockTargetInfo TargetInfo)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			if (IsOnline)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_SetTargetInfoWithCameraLockingServer.Invoke(BGUFuncLibReplication.GetLockTargetInfoForRPC(TargetInfo));
			}
			else
			{
				BUS_EventCollectionCS.Get(Owner).Evt_SetTargetInfoWithCameraLocking.Invoke(TargetInfo);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateNavMeshBoundsVolumes")]
	public static void GenerateNavMeshBoundsVolumes(AActor TempleteActor)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(TempleteActor))
		{
			return;
		}
		UWorld world = TempleteActor.World;
		world.GetAllActorsWithTag(B1GlobalFNames.GeneratedNavBound, out var OutActors);
		UGSE_EditorFuncLib.DeleteActors(OutActors, world);
		List<(AActor, FVector)> list = new List<(AActor, FVector)>();
		BUTamerActor[] allActorsOfClass = world.GetAllActorsOfClass<BUTamerActor>();
		foreach (BUTamerActor bUTamerActor in allActorsOfClass)
		{
			int finalBattleInfoExtendID = bUTamerActor.GetFinalBattleInfoExtendID();
			int num = 10000;
			FUStUnitAIDesc unitAIDesc = BGW_GameDB.GetUnitAIDesc(finalBattleInfoExtendID);
			if (unitAIDesc != null)
			{
				num = (int)(unitAIDesc.PursuitRange * 2f);
			}
			if (num > 20000)
			{
				num = 20000;
			}
			list.Add((bUTamerActor, new FVector(num, num, 3000.0)));
		}
		BGUInteractiveActorBase[] allActorsOfClass2 = world.GetAllActorsOfClass<BGUInteractiveActorBase>();
		foreach (BGUInteractiveActorBase bGUInteractiveActorBase in allActorsOfClass2)
		{
			BUS_InteractComp componentByClass = bGUInteractiveActorBase.GetComponentByClass<BUS_InteractComp>();
			int interactiveUnitID = componentByClass.InteractiveUnitID;
			int num2 = 10000;
			FUStInteractiveUnitCommDesc interactiveUnitCommDesc = BGW_GameDB.GetInteractiveUnitCommDesc(interactiveUnitID);
			if (interactiveUnitCommDesc != null)
			{
				num2 = (int)(UBGWFunctionLibraryCS.GetLeaveActivableDistance((componentByClass.ActivableDistance <= 0f) ? interactiveUnitCommDesc.ActivableDistance : componentByClass.ActivableDistance) * 2f);
			}
			list.Add((bGUInteractiveActorBase, new FVector(num2, num2, 3000.0)));
		}
		BGU_QuestActor[] allActorsOfClass3 = world.GetAllActorsOfClass<BGU_QuestActor>();
		foreach (BGU_QuestActor item in allActorsOfClass3)
		{
			list.Add((item, new FVector(15000.0, 15000.0, 3000.0)));
		}
		foreach (var item4 in list)
		{
			AActor item2 = item4.Item1;
			FVector item3 = item4.Item2;
			float x = item3.X;
			item3 = item4.Item2;
			float y = item3.Y;
			item3 = item4.Item2;
			UGSE_EditorFuncLib.GenerateNaviMeshBounds(item2, x, y, item3.Z, TempleteActor);
		}
	}

	[Category("BGU|Util")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateGrayBox")]
	public static void GenerateGrayBox(AActor TempleteActor)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(TempleteActor))
		{
			return;
		}
		UWorld world = TempleteActor.World;
		List<AActor> allActorsOfClassList = world.GetAllActorsOfClassList<AActor>();
		List<AActor> list = new List<AActor>();
		List<AActor> list2 = new List<AActor>();
		List<AActor> list3 = new List<AActor>();
		foreach (AActor item in allActorsOfClassList)
		{
			if (item.GetName().IndexOf("tree", 0, StringComparison.OrdinalIgnoreCase) != -1)
			{
				list.Add(item);
			}
			else if (item.GetName().IndexOf("interactivewater", 0, StringComparison.OrdinalIgnoreCase) != -1)
			{
				list2.Add(item);
			}
			else if (item.GetName().IndexOf("Fog", 0, StringComparison.OrdinalIgnoreCase) != -1)
			{
				list3.Add(item);
			}
		}
		UGSE_EditorFuncLib.DeleteActors(list, world);
		list.Clear();
		UGSE_EditorFuncLib.DeleteActors(list2, world);
		list2.Clear();
		UGSE_EditorFuncLib.DeleteActors(list3, world);
		list3.Clear();
		foreach (AStaticMeshActor allActorsOfClass in world.GetAllActorsOfClassList<AStaticMeshActor>())
		{
			if (allActorsOfClass.GetName().IndexOf("tree", 0, StringComparison.OrdinalIgnoreCase) != -1)
			{
				list.Add(allActorsOfClass);
			}
			else
			{
				allActorsOfClass.GetComponentByClass<UStaticMeshComponent>().GetMaterials().Clear();
			}
		}
		UGSE_EditorFuncLib.DeleteActors(list, world);
		list.Clear();
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetPlayerInSequenceTransition")]
	public static void BGUSetPlayerInSequenceTransition(AActor Owner, bool bValue)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner) && !(Owner == null))
		{
			BUS_EventCollectionCS.Get(Owner).Evt_SetPlayerLocomotionInSequenceTransition.Invoke(bValue);
		}
	}

	public static List<AActor> FetchChildActorByMatchInfo(AActor Owner, FTamerFamilyMatchChildInfo MatchInfo)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return new List<AActor>();
		}
		return (from Guid in FetchChildActorGuidByMatchInfo(Owner, MatchInfo)
			select BGU_DataUtil.GetActorByGuid(Owner, Guid) into Actor
			where !Actor.IsNullOrDestroyed()
			select Actor).ToList();
	}

	public static List<string> FetchChildActorGuidByMatchInfo(AActor Owner, FTamerFamilyMatchChildInfo MatchInfo)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return null;
		}
		IBGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(Owner));
		List<string> Guids = new List<string>();
		if (readOnlyData == null)
		{
			return Guids;
		}
		switch (MatchInfo.Filter)
		{
		case EChildActorFilterType.All:
			readOnlyData.TravelCircus(Owner, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			});
			break;
		case EChildActorFilterType.Socket:
			readOnlyData.TravelCircus(Owner, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, MatchInfo.MatchSocketType, MatchInfo.SocketName);
			break;
		case EChildActorFilterType.ResId:
			readOnlyData.TravelCircus(Owner, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, (CircusMember TreeNode) => TreeNode.ResId == MatchInfo.ResId);
			break;
		case EChildActorFilterType.NickName:
			readOnlyData.TravelCircus(Owner, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, (CircusMember TreeNode) => TreeNode.NickName.Contains(MatchInfo.NickName.TagName.ToString()));
			break;
		case EChildActorFilterType.Buff:
			readOnlyData.TravelCircus(Owner, delegate(CircusMember TreeNode)
			{
				Guids.Add(TreeNode.ActorGuid);
			}, delegate(CircusMember TreeNode)
			{
				BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(Owner, TreeNode.ActorGuid) as BGUCharacterCS;
				return (bGUCharacterCS != null && BGUHasBuffByID(bGUCharacterCS, MatchInfo.BuffId)) ? true : false;
			});
			break;
		}
		return Guids;
	}

	public static AActor GetDetectUnitActor(AActor Owner, EDetectedUnitType UnitType, string UnitGuid = null)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return null;
		}
		AActor result = null;
		switch (UnitType)
		{
		case EDetectedUnitType.Self:
			result = Owner;
			break;
		case EDetectedUnitType.Target:
			result = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Owner)?.GetTargetInfo()?.LockTargetActor;
			break;
		case EDetectedUnitType.Master:
			result = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner)?.GetMasterActor();
			break;
		case EDetectedUnitType.Player:
			result = UGameplayStatics.GetPlayerPawn(Owner, 0);
			break;
		case EDetectedUnitType.UseSmartUnit:
			result = BGU_DataUtil.GetActorByGuid(Owner, UnitGuid);
			break;
		}
		return result;
	}

	public static string GetDetectUnitActorFlagId(AActor Owner, EDetectedUnitType UnitType, string UnitGuid = null)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return "";
		}
		if (UnitType == EDetectedUnitType.UseSmartUnit)
		{
			AActor detectUnitActor = GetDetectUnitActor(Owner, UnitType, UnitGuid);
			if (detectUnitActor == null)
			{
				return UnitGuid;
			}
			return GetUnitFlagId(detectUnitActor);
		}
		return GetUnitFlagId(GetDetectUnitActor(Owner, UnitType, UnitGuid));
	}

	public static string GetUnitFlagId(AActor Unit)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return "";
		}
		if (BGU_DataUtil.GetActorType(Unit) != BGU_ActorType.CharacterPlayer)
		{
			return BGU_DataUtil.GetActorGuid(Unit);
		}
		return "Player";
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip")]
	public static void SeqChangeEquip(ABGUPerformerActor SeqActor, int EquipID)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(SeqActor);
		EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(EquipID);
		if (equipDesc != null)
		{
			bUS_GSEventCollection.Evt_ChangePreviewEquip.Invoke(equipDesc.EquipPosition, equipDesc.Id);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip2")]
	public static void SeqChangeEquip2(ABGUPerformerActor SeqActor)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(SeqActor);
		EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(11503);
		bUS_GSEventCollection.Evt_ChangePreviewEquip.Invoke(equipDesc.EquipPosition, equipDesc.Id);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:GetAllEquipId")]
	public static List<int> GetAllEquipId()
	{
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, EquipDesc> item in GameDBRuntime.GetAllEquipDesc())
		{
			if (item.Value.EquipPosition != EquipPosition.Fabao)
			{
				list.Add(item.Key);
			}
		}
		return list;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ChangeEquip")]
	public static void ChangeEquip(APawn Actor, int ID)
	{
		if (Actor != null)
		{
			EquipDesc equipDesc = GameDBRuntime.GetEquipDesc(ID);
			BUS_EventCollectionCS.Get(Actor).Evt_BattleLogicChangeEquip.Invoke(equipDesc.EquipPosition, equipDesc.Id);
		}
	}

	public static void GetBuffTickRuleBySimpleStateIDList(AActor Chr, ref List<int> BuffTickRuleBySimpleStateIDList)
	{
		if (BuffTickRuleBySimpleStateIDList == null)
		{
			return;
		}
		BuffTickRuleBySimpleStateIDList.Clear();
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Chr))
		{
			IBUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Chr);
			bool flag = readOnlyData?.HasSimpleState(EBGUSimpleState.Immobilizing) ?? false;
			bool num = readOnlyData?.HasSimpleState(EBGUSimpleState.Frozen) ?? false;
			if (flag)
			{
				BuffTickRuleBySimpleStateIDList.Add(9);
			}
			if (num)
			{
				BuffTickRuleBySimpleStateIDList.Add(82);
			}
		}
	}

	public static bool IsNeedPauseBuffTick(int BuffID, List<int> BuffTickRuleBySimpleStateIDList)
	{
		bool result = false;
		foreach (int BuffTickRuleBySimpleStateID in BuffTickRuleBySimpleStateIDList)
		{
			EBuffTickRuleBySSType RuleType;
			List<int> buffTickRuleBySimpleStateDesc = BGW_GameDB.GetBuffTickRuleBySimpleStateDesc(BuffTickRuleBySimpleStateID, out RuleType);
			if (buffTickRuleBySimpleStateDesc == null)
			{
				continue;
			}
			switch (RuleType)
			{
			case EBuffTickRuleBySSType.WhiteList:
				if (buffTickRuleBySimpleStateDesc.Contains(BuffID))
				{
					break;
				}
				result = true;
				goto end_IL_0042;
			case EBuffTickRuleBySSType.BlackList:
				if (!buffTickRuleBySimpleStateDesc.Contains(BuffID))
				{
					break;
				}
				result = true;
				goto end_IL_0042;
			}
			continue;
			end_IL_0042:
			break;
		}
		return result;
	}

	public static FTransform GetFrontLocationByHitPoint(AActor Unit, FVector HitLocation, FRotator HitPointNormalDir, ETraceTypeQuery TraceType, bool bDebug)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			return FTransform.Default;
		}
		if (bDebug)
		{
			USystemLibrary.DrawDebugSphere(Unit, HitLocation, 10f, 10, FLinearColor.Blue, 5f, 1f);
			USystemLibrary.DrawDebugLine(Unit, HitLocation, HitLocation + HitPointNormalDir.Conv_RotatorToVector() * 200.0, FLinearColor.Blue, 5f, 1f);
		}
		FVector startTrace = (BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit) - HitLocation).GetSafeNormal() + HitLocation;
		FVector endTrace = HitLocation;
		if (UBGUSelectUtil.LineTraceSimple(Unit, startTrace, endTrace, TraceType, bDebug, out var HitResult, null) > 0)
		{
			HitLocation = HitResult.HitLocation;
			HitPointNormalDir = HitResult.HitImpactNormal.Conv_VectorToRotator();
			if (bDebug)
			{
				USystemLibrary.DrawDebugSphere(Unit, HitLocation, 10f, 10, FLinearColor.Green, 5f, 1f);
				USystemLibrary.DrawDebugLine(Unit, HitLocation, HitLocation + HitPointNormalDir.Conv_RotatorToVector() * 200.0, FLinearColor.Green, 5f, 1f);
			}
		}
		return new FTransform(HitPointNormalDir, HitLocation);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetTamerStrategyArea")]
	public static void SetTamerStrategyArea(UObject InWorldContext, ETamerStrategyArea InArea)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(InWorldContext))
		{
			BGS_EventCollectionCS.Get(InWorldContext)?.Evt_SetTamerStrategyArea.Invoke(InArea);
		}
	}

	public static float GetDestructibleImpulse(UObject InWorldContext)
	{
		BGWDataAsset_DestructibleImpulseConfig destructibleImpulseConfig = BGW_PreloadAssetMgr.Get(InWorldContext).DestructibleImpulseConfig;
		if (destructibleImpulseConfig == null)
		{
			return 1000f;
		}
		return destructibleImpulseConfig.GetDestructibleImpulse();
	}

	public static float GetDestructibleImpulse(UObject InWorldContext, EGSHitDestructibleStrengthLevel StrengthLevel)
	{
		BGWDataAsset_DestructibleImpulseConfig destructibleImpulseConfig = BGW_PreloadAssetMgr.Get(InWorldContext).DestructibleImpulseConfig;
		if (destructibleImpulseConfig == null)
		{
			return 1000f;
		}
		return destructibleImpulseConfig.GetDestructibleImpulse(StrengthLevel);
	}

	public static bool FindWeaponDefualInActicedByActor(AActor FindWeapon, AActor Character)
	{
		IBUC_ConfigInfoData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>(Character);
		IBUC_WeaponManagerData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_WeaponManagerData, BUC_WeaponManagerData>(Character);
		if (unPersistentReadOnlyData2 == null || unPersistentReadOnlyData == null)
		{
			return false;
		}
		int num = unPersistentReadOnlyData2.FindWeaponIndex(FindWeapon);
		if (num != -1 && unPersistentReadOnlyData.Weapons.Count > num)
		{
			return unPersistentReadOnlyData.Weapons[num].bDefaultInactive;
		}
		return false;
	}

	public static string GetEnumNote<T>(string TypeName, string Name, string MetaFieldName) where T : Enum
	{
		UEnum uEnum = UObject.FindObject<UEnum>(UObject.AnyPackage, TypeName);
		int indexByName = uEnum.GetIndexByName(new FName(Name));
		if (indexByName != -1)
		{
			return uEnum.GetMetaData(MetaFieldName, indexByName);
		}
		return "";
	}

	public static bool EnumHasAttribute<TAttribute>(object _Enum) where TAttribute : Attribute
	{
		return _Enum.GetType().GetField(_Enum.ToString()).IsDefined(typeof(TAttribute));
	}

	public static bool GetEffectTemplateTips(Type type, out string[] Tips, out int CanUseInMutil, out int CanUseByBullet)
	{
		Tips = Array.Empty<string>();
		CanUseInMutil = 0;
		CanUseByBullet = 0;
		if (type == null)
		{
			return false;
		}
		if (type.GetCustomAttributes<EffectTemplateTipsAttribute>().Count() > 0)
		{
			EffectTemplateTipsAttribute effectTemplateTipsAttribute = type.GetCustomAttributes<EffectTemplateTipsAttribute>().First();
			Tips = effectTemplateTipsAttribute.GetParamterInfo();
			CanUseInMutil = ((type.GetCustomAttributes<CantUseInMultiEffect>().Count() > 0) ? (-1) : 0);
			CanUseByBullet = ((type.GetCustomAttributes<CanUseByBulletEffect>().Count() > 0) ? (-1) : 0);
			return true;
		}
		return false;
	}

	public static bool TypeHasAttribute<T>(Type InType) where T : Attribute
	{
		return InType.GetCustomAttribute<T>() != null;
	}

	public static bool MethodHasAttribute<T>(MethodInfo InMethod) where T : Attribute
	{
		return InMethod.GetCustomAttribute<T>() != null;
	}

	public static bool GetFunctionNoteAttribute(MethodInfo Info, out string Note, out Dictionary<int, string> IntParameterInfo, out Dictionary<int, string> FloatParameterInfo, out Dictionary<int, string> StringParameterInfo)
	{
		Note = "";
		IntParameterInfo = new Dictionary<int, string>();
		FloatParameterInfo = new Dictionary<int, string>();
		StringParameterInfo = new Dictionary<int, string>();
		if (Info == null)
		{
			return false;
		}
		bool flag = Info.GetCustomAttributes<TemplateFunNoteAttribute>().Count() > 0;
		if (flag)
		{
			TemplateFunNoteAttribute templateFunNoteAttribute = Info.GetCustomAttributes<TemplateFunNoteAttribute>().First();
			Note = templateFunNoteAttribute.GetNote();
		}
		foreach (ParamInfoI customAttribute in Info.GetCustomAttributes<ParamInfoI>())
		{
			IntParameterInfo[customAttribute.Index] = customAttribute.Description;
		}
		foreach (ParamInfoF customAttribute2 in Info.GetCustomAttributes<ParamInfoF>())
		{
			FloatParameterInfo[customAttribute2.Index] = customAttribute2.Description;
		}
		foreach (ParamInfoS customAttribute3 in Info.GetCustomAttributes<ParamInfoS>())
		{
			StringParameterInfo[customAttribute3.Index] = customAttribute3.Description;
		}
		return flag;
	}

	public static bool GetFunctionTipsAttribute(MethodInfo Info, out List<string> TipsList)
	{
		TipsList = new List<string>();
		if (Info == null)
		{
			return false;
		}
		foreach (TemplateFuncTipsAttribute customAttribute in Info.GetCustomAttributes<TemplateFuncTipsAttribute>())
		{
			TipsList.Add(customAttribute.GetTips());
		}
		return TipsList.Count > 0;
	}

	public static int GetEnumIndexFromAttrStr(string AttrStr)
	{
		if (AttrStr == "")
		{
			return -1;
		}
		_ = (EBGUAttrFloat)Enum.Parse(typeof(EBGUAttrFloat), AttrStr);
		return UObject.FindObject<UEnum>(UObject.AnyPackage, "EBGUAttrFloat").GetIndexByName(new FName(AttrStr));
	}

	public static int GetEnumIndexFromEffectTypeStr(string AttrStr)
	{
		string path = Path.Combine(FPaths.ProjectDir, "Managed/GSE.ProtobufDB/Protobuf/BG_ProtobufDB/BtlShare.cs");
		bool flag = false;
		bool flag2 = false;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path);
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (text.Contains("public enum EBGUAttrFloat  : byte"))
				{
					flag = true;
				}
				if (flag && text.Contains("}"))
				{
					break;
				}
				if (flag && text.Contains("cn"))
				{
					list.Add(text);
				}
			}
			array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.Contains("public enum EBuffAndSkillEffectType  : byte {"))
				{
					flag2 = true;
				}
				if (flag2 && text2.Contains("}"))
				{
					break;
				}
				if (flag2 && text2.Contains("cn"))
				{
					list2.Add(text2);
				}
			}
		}
		if (AttrStr == "")
		{
			return -1;
		}
		for (int j = 0; j < Enum.GetValues(typeof(EBuffAndSkillEffectType)).Length; j++)
		{
			string value = Enum.GetValues(typeof(EBuffAndSkillEffectType)).GetValue(j).ToString();
			if (AttrStr.Equals(value))
			{
				return j;
			}
		}
		return -1;
	}

	public static int GetEnumValueFromAttrStr(string AttrStr)
	{
		if (AttrStr == "")
		{
			return -1;
		}
		_ = (EBGUAttrFloat)Enum.Parse(typeof(EBGUAttrFloat), AttrStr);
		return UObject.FindObject<UEnum>(UObject.AnyPackage, "EBGUAttrFloat").GetValueByName(new FName(AttrStr));
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:StopFetchTick")]
	public static void StopFetchTick(UObject WorldContext)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:CanShutDown")]
	public static bool CanShutDown(UObject WorldContext)
	{
		return false;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ToggleCloudMove")]
	public static void ToggleCloudMove(AActor Unit)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_ToggleCloudMove.Invoke();
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:BreakCloudMove")]
	public static void BreakCloudMove(AActor Unit, int BreakAnimId)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_BreakCloudMove.Invoke(BreakAnimId);
		}
	}

	public static void BlockTillLevelStreamingCompleted(UObject WorldContextObject)
	{
		UGSE_EngineFuncLib.SetLevelRequestSuspend(ShouldSuspend: true);
		BGW_EventCollection.Get(WorldContextObject)?.Evt_ForceDispatchUpdateLevelStateRequest();
		UGSE_EngineFuncLib.PrepareLevelsNeedToBeUnloaded(WorldContextObject);
		UGSE_EngineFuncLib.SetLevelRequestSuspend(ShouldSuspend: false);
		CalBlockTillLevelStreamingCompleted(WorldContextObject);
		UGSE_EngineFuncLib.BlockTillSuspendedLevelsCompleted(WorldContextObject);
	}

	public static void CalBlockTillLevelStreamingCompleted(UObject WorldContextObject)
	{
		BGWGameInstanceCS bGWGameInstanceCS = BGWGameInstanceCS.Get(WorldContextObject);
		if (bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			bGWGameInstanceCS.SwitchLoadingScreenThread(UseSlateThread: true);
		}
		UGSE_EngineFuncLib.BlockTillLevelStreamingCompleted(WorldContextObject);
		if (bGWGameInstanceCS.GetCurLoadingScreenState() != EGSLoadingScreenState.Idle)
		{
			bGWGameInstanceCS.SwitchLoadingScreenThread(UseSlateThread: false);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:DisablePhysicalMove")]
	public static void DisablePhysicalMove(AActor Unit, bool bDisable)
	{
		if (!b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Unit))
		{
			BUS_EventCollectionCS.Get(Unit)?.Evt_DisablePhysicalMove.Invoke(bDisable);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExportAllTamerToDataAsset")]
	public static void ExportAllTamerToDataAsset()
	{
		foreach (string tamer in (UEditorAssetLibrary.LoadAsset("BGWDataAsset_TamerListConfig'/Game/3rd/QATest/DA_QATamerList.DA_QATamerList'") as AutoTestHelperLib.BGWDataAsset_TamerListConfig).TamerList)
		{
			if (UGSE_EditorFuncLib.AssetPath_GetCDO(null, tamer, out var _) is BUTamerActor tM)
			{
				ExportBulletSkillToDataAsset(tM);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExportBulletSkillToDataAsset")]
	public static void ExportBulletSkillToDataAsset(BUTamerActor TM)
	{
		BGWDataAsset_TamerAndBulletSkillIDConfig bGWDataAsset_TamerAndBulletSkillIDConfig = UEditorAssetLibrary.LoadAsset("BGWDataAsset_TamerAndBulletSkillIDConfig'/Game/3rd/QATest/DA_TamerAndBulletSkillIDConfig.DA_TamerAndBulletSkillIDConfig'") as BGWDataAsset_TamerAndBulletSkillIDConfig;
		UBehaviorTree unitBehaviorTree = TM.ConfigInfoComp.UnitBehaviorTree;
		FBehaviorTreeNodeData NodeData = new FBehaviorTreeNodeData
		{
			TaskNodeList = new List<UBTTaskNode>()
		};
		UGSE_BehaviorTreeFuncLib.GetBTTaskNodes(unitBehaviorTree, out NodeData);
		List<UBTTaskNode> taskNodeList = NodeData.TaskNodeList;
		List<int> list = new List<int>();
		foreach (UBTTaskNode item2 in taskNodeList)
		{
			BAIT_Combo bAIT_Combo = item2 as BAIT_Combo;
			if (bAIT_Combo != null)
			{
				foreach (FComboSkill item3 in bAIT_Combo.SkillArray)
				{
					foreach (int item4 in item3.SkillID)
					{
						if (!list.Contains(item4) && FilterSkillIDByNotif(item4))
						{
							list.Add(item4);
						}
					}
				}
			}
			BAIT_UseSkillWithID bAIT_UseSkillWithID = item2 as BAIT_UseSkillWithID;
			if (bAIT_UseSkillWithID != null && !list.Contains(bAIT_UseSkillWithID.SkillID) && FilterSkillIDByNotif(bAIT_UseSkillWithID.SkillID))
			{
				list.Add(bAIT_UseSkillWithID.SkillID);
			}
		}
		list.Sort();
		int behaviorGraphTemplateID = TM.ExtendConfigComp.BehaviorGraphTemplateID;
		if (behaviorGraphTemplateID != 0)
		{
			FUStCBGTemplateDesc cBGTemplateDesc = BGW_GameDB.GetCBGTemplateDesc(behaviorGraphTemplateID);
			object obj;
			if (cBGTemplateDesc == null)
			{
				obj = null;
			}
			else
			{
				string path = cBGTemplateDesc.Path;
				obj = ((path != null) ? GameplayTagExtension.LoadGraph(path) : null);
			}
			FCalliopeGraph fCalliopeGraph = (FCalliopeGraph)obj;
			if (fCalliopeGraph != null)
			{
				foreach (FCalliopeNode node in fCalliopeGraph.Nodes)
				{
					if (node.NodeClass == B1CalliopeDef.BehaviorNode.CastSkill)
					{
						BehaviorCustom_CastSkill behaviorCustom_CastSkill = new BehaviorCustom_CastSkill();
						behaviorCustom_CastSkill.MergeFrom(node.NodeData);
						if (!list.Contains(behaviorCustom_CastSkill.SkillId) && FilterSkillIDByNotif(behaviorCustom_CastSkill.SkillId))
						{
							list.Add(behaviorCustom_CastSkill.SkillId);
						}
					}
				}
			}
		}
		if (!(bGWDataAsset_TamerAndBulletSkillIDConfig != null))
		{
			return;
		}
		bool flag = false;
		foreach (BulletSkillTestInfo bulletSkillTestInfo in bGWDataAsset_TamerAndBulletSkillIDConfig.BulletSkillTestInfos)
		{
			if (bulletSkillTestInfo.TamerActor == TM)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			if (list.Count > 0)
			{
				BulletSkillTestInfo item = new BulletSkillTestInfo(TM, list);
				bGWDataAsset_TamerAndBulletSkillIDConfig.BulletSkillTestInfos.Add(item);
			}
			UGSE_AnimFuncLib.MarkDirty(bGWDataAsset_TamerAndBulletSkillIDConfig);
		}
	}

	public static bool FilterSkillIDByNotif(int SkillID)
	{
		UAnimMontage uAnimMontage = UEditorAssetLibrary.LoadAsset(BGUFunclibEditorUtility.GetAMPathBySkillID(SkillID)) as UAnimMontage;
		if (GameDBRuntime.GetFUStSkillSDesc(SkillID) == null)
		{
			return false;
		}
		_ = GameDBRuntime.GetFUStSkillSDesc(SkillID).SkillType;
		if (uAnimMontage == null)
		{
			return false;
		}
		UGSE_AnimFuncLib.GetAllNotifyEvent(uAnimMontage, out var AnimNotifyEventList);
		foreach (FAnimNotifyEvent item in AnimNotifyEventList)
		{
			if (item.NotifyStateClass as BANS_GSSpawnBullets != null)
			{
				return true;
			}
		}
		return false;
	}

	public static void PlayCamShakeWithControl(string CamShakeDAPath, AActor Target)
	{
		BGWDataAsset_CameraShakeWithControl bGWDataAsset_CameraShakeWithControl = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<BGWDataAsset_CameraShakeWithControl>(CamShakeDAPath, ELoadResourceType.AsyncLoadAndCache);
		if (bGWDataAsset_CameraShakeWithControl == null)
		{
			return;
		}
		UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(Target, bGWDataAsset_CameraShakeWithControl.CameraShake.Value);
		if (!(uMatineeCameraShake == null) && bGWDataAsset_CameraShakeWithControl.WithControl)
		{
			FVector epicenterLoc = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
			ACharacter aCharacter = Target as ACharacter;
			if (aCharacter != null)
			{
				epicenterLoc = aCharacter.Mesh.GetSocketLocation(bGWDataAsset_CameraShakeWithControl.SocketName);
			}
			BGS_EventCollectionCS.Get(Target).Evt_BGS_AddCameraShakeWithControl.Invoke(uMatineeCameraShake, bGWDataAsset_CameraShakeWithControl.CamShakeScaleByDistCurve, epicenterLoc, -1f, bGWDataAsset_CameraShakeWithControl.EpicenterIsAttach, bGWDataAsset_CameraShakeWithControl.SocketName, Target);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PlayCamShakeWithControlByClass")]
	public static void PlayCamShakeWithControlByClass(TSubclassOf<UMatineeCameraShake> CameraShakeCls, AActor Target)
	{
		ACharacter aCharacter = Target as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(aCharacter);
		if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			UMatineeCameraShake uMatineeCameraShake = UBUS_UtilComm.PlayCameraShakeByClass(aCharacter, CameraShakeCls.Value);
			if (!(uMatineeCameraShake == null))
			{
				FVector socketLocation = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.None);
				BGS_EventCollectionCS.Get(aCharacter).Evt_BGS_AddCameraShakeWithControl.Invoke(uMatineeCameraShake, null, socketLocation, -1f, EpicenterIsAttach: false, B1GlobalFNames.None, aCharacter);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:PauseCamShakeWithControlByActor")]
	public static void PauseCamShakeWithControlByActor(AActor Target, bool bPause)
	{
		ACharacter aCharacter = Target as ACharacter;
		if (!(aCharacter == null))
		{
			UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(aCharacter);
			if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
			{
				BGS_EventCollectionCS.Get(aCharacter).Evt_BGS_OnPauseCameraShakeByActor.Invoke(aCharacter, bPause);
			}
		}
	}

	public static void GamePlayTraceStartWithTaskName(UObject WorldContext, string TraceTaskName)
	{
	}

	public static void GamePlayTraceEnd(UObject WorldContext)
	{
	}

	public static bool IsUnitVigourDropperDispEnabled(AActor Unit)
	{
		BGUCharacterCS bGUCharacterCS = Unit as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(bGUCharacterCS.GetFinalBattleInfoExtendID());
		if (unitBattleInfoExtendDesc == null || unitBattleInfoExtendDesc.VigourDropId == 0)
		{
			return false;
		}
		BPC_PlayerRoleData readOnlyData = BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(UGSE_EngineFuncLib.GetFirstLocalPlayerController(Unit));
		if (readOnlyData == null)
		{
			return false;
		}
		SoulSkillDropDesc soulSkillDropDesc = GameDBRuntime.GetSoulSkillDropDesc(unitBattleInfoExtendDesc.VigourDropId);
		if (soulSkillDropDesc == null || RoleDataHelper.HasItem(readOnlyData, soulSkillDropDesc.SoulSkillId))
		{
			return false;
		}
		BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.EnableVigourUnitDispItem, out var ConfigInfo);
		if (ConfigInfo == null || !RoleDataHelper.HasItem(readOnlyData, ConfigInfo.IntValue))
		{
			return false;
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:FindTraceStatResult")]
	public static float FindTraceStatResult(UObject WorldContext, string Name)
	{
		return 0f;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:SetTrainDummyInfo")]
	public static bool SetTrainDummyInfo(UObject WorldContext, string TrainDummyClassPath, int PlayerRoleDataConfigID, string TrainDummyConfigPath, string CqgPath, float DPSCalTime = -1f)
	{
		AActor actorOfClass = UGameplayStatics.GetActorOfClass(WorldContext, UClass.GetClass<b1.BGUTrainDummyMgrActor>());
		if (actorOfClass == null)
		{
			return false;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorOfClass);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(WorldContext);
		if (bUS_GSEventCollection == null || bGS_GSEventCollection == null)
		{
			return false;
		}
		bUS_GSEventCollection.Evt_SetTrainDummyInfo.Invoke(TrainDummyClassPath, PlayerRoleDataConfigID, TrainDummyConfigPath, DPSCalTime);
		bGS_GSEventCollection.Evt_BGS_SwitchRootQuestGraph.Invoke(CqgPath);
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TryGetComponentByFName")]
	public static UActorComponent TryGetComponentByFName(AActor Actor, FName Name)
	{
		BGUCharacterCS bGUCharacterCS = Actor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			return bGUCharacterCS.TryGetComponentByName(Name);
		}
		foreach (UActorComponent item in Actor.GetComponentsByClass(UClass.GetClass<USceneComponent>()))
		{
			if (item.GetFName() == Name)
			{
				return item;
			}
		}
		return null;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByBlame")]
	public static bool ExportTamerListToNewDAByBlame(AActor Actor, string OldTamer, string NewTimer, string BlameName)
	{
		AutoTestHelperLib.BGWDataAsset_TamerListConfig bGWDataAsset_TamerListConfig = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(OldTamer, ELoadResourceType.SyncLoadAndCache);
		AutoTestHelperLib.BGWDataAsset_TamerListConfig bGWDataAsset_TamerListConfig2 = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(NewTimer, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_TamerListConfig != null && bGWDataAsset_TamerListConfig2 != null)
		{
			foreach (string tamer in bGWDataAsset_TamerListConfig.TamerList)
			{
				TStrongObjectPtr<UClass> tStrongObjectPtr = new TStrongObjectPtr<UClass>();
				UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<UBlueprint>(tamer, ELoadResourceType.SyncLoadAndCache);
				if (uBlueprint != null)
				{
					tStrongObjectPtr.Set(uBlueprint.GeneratedClass);
				}
				else
				{
					UClass newValue = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<UClass>(tamer, ELoadResourceType.SyncLoadAndCache);
					tStrongObjectPtr.Set(newValue);
				}
				BUTamerActor bUTamerActor = null;
				if (!tStrongObjectPtr.Get().IsNullOrDestroyed())
				{
					bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(Actor.World, tStrongObjectPtr.Get(), FTransform.Default, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
				}
				if (bUTamerActor != null)
				{
					UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, FTransform.Default);
					int resID = bUTamerActor.GetResID();
					string blameByID = BG_ProtobufDataAPI<FUStUnitCommDesc>.Get().GetBlameByID(in resID);
					_ = 3060;
					if (blameByID == BlameName)
					{
						bGWDataAsset_TamerListConfig2.TamerList.Add(tamer);
					}
					bUTamerActor.DestroyActor();
				}
			}
			bGWDataAsset_TamerListConfig2.MarkPackageDirty();
			return true;
		}
		return false;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByWeaponInfo")]
	public static bool ExportTamerListToNewDAByWeaponInfo(AActor Actor, string OldTamer, string NewTimer, string BlameName)
	{
		AutoTestHelperLib.BGWDataAsset_TamerListConfig bGWDataAsset_TamerListConfig = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(OldTamer, ELoadResourceType.SyncLoadAndCache);
		AutoTestHelperLib.BGWDataAsset_TamerListConfig bGWDataAsset_TamerListConfig2 = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<AutoTestHelperLib.BGWDataAsset_TamerListConfig>(NewTimer, ELoadResourceType.SyncLoadAndCache);
		if (bGWDataAsset_TamerListConfig != null && bGWDataAsset_TamerListConfig2 != null)
		{
			foreach (string tamer in bGWDataAsset_TamerListConfig.TamerList)
			{
				TStrongObjectPtr<UClass> tStrongObjectPtr = new TStrongObjectPtr<UClass>();
				UBlueprint uBlueprint = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<UBlueprint>(tamer, ELoadResourceType.SyncLoadAndCache);
				if (uBlueprint != null)
				{
					tStrongObjectPtr.Set(uBlueprint.GeneratedClass);
				}
				else
				{
					UClass newValue = BGW_PreloadAssetMgr.Get(Actor).TryGetCachedResourceObj<UClass>(tamer, ELoadResourceType.SyncLoadAndCache);
					tStrongObjectPtr.Set(newValue);
				}
				BUTamerActor bUTamerActor = null;
				if (!tStrongObjectPtr.Get().IsNullOrDestroyed())
				{
					bUTamerActor = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(Actor.World, tStrongObjectPtr.Get(), FTransform.Default, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, null) as BUTamerActor;
				}
				if (bUTamerActor != null)
				{
					UBGUFunctionLibrary.BGUFinishSpawningActor(bUTamerActor, FTransform.Default);
					if (bUTamerActor.ConfigInfoComp.UnitCDesc.Weapons.Count != 0)
					{
						bGWDataAsset_TamerListConfig2.TamerList.Add(tamer);
					}
					bUTamerActor.DestroyActor();
				}
			}
			bGWDataAsset_TamerListConfig2.MarkPackageDirty();
			return true;
		}
		return false;
	}

	[Category("BGU|Util")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerSwitchPhysics")]
	public static int TriggerSwitchPhysics(AActor Unit)
	{
		if (Unit == null)
		{
			return -1;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		FPhysicBlendInfoForDeath fPhysicBlendInfoForDeath = default(FPhysicBlendInfoForDeath);
		fPhysicBlendInfoForDeath.BoneName = B1GlobalFNames.pelvis;
		fPhysicBlendInfoForDeath.PhysicBlendInType = EPhysicBlendInType.Immediately;
		fPhysicBlendInfoForDeath.BlendFinalValue = 1f;
		BUS_EventCollectionCS.Get(Unit)?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
		return 1;
	}

	[BlueprintCallable]
	[UFunction]
	[Category("BGU|Util")]
	[USharpPath("/Script/b1-Managed.BGUFunctionLibraryCS:ClearPhysAnimSetting")]
	public static int ClearPhysAnimSetting(AActor Unit)
	{
		if (Unit == null)
		{
			return -1;
		}
		if (Unit is BUTamerActor bUTamerActor)
		{
			Unit = bUTamerActor.GetMonster();
			if (Unit == null)
			{
				return -1;
			}
		}
		BUS_EventCollectionCS.Get(Unit)?.Evt_ResetPhysicalAnim.Invoke();
		return 1;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGMDead")]
	private static void BGUGMDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGMDead_Unit_Offset));
		BGUGMDead(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GM_AddAttr")]
	private static void GM_AddAttr__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GM_AddAttr_Unit_Offset));
		EBGUAttrFloat attrType = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(buffer, GM_AddAttr_AttrType_Offset), 0, GM_AddAttr_AttrType_PropertyAddress.Address);
		float addValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GM_AddAttr_AddValue_Offset));
		GM_AddAttr(unit, attrType, addValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAddBuff")]
	private static void BGUAddBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor caster = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAddBuff_Caster_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAddBuff_Target_Offset));
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUAddBuff_BuffID_Offset));
		EBuffSourceType buffSourceType = EnumMarshaler<EBuffSourceType>.FromNative(IntPtr.Add(buffer, BGUAddBuff_BuffSourceType_Offset), 0, BGUAddBuff_BuffSourceType_PropertyAddress.Address);
		float buffDurationTimer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAddBuff_BuffDurationTimer_Offset));
		BGUAddBuff(caster, target, buffID, buffSourceType, buffDurationTimer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetRTForFX")]
	private static void GetRTForFX__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor ownerActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetRTForFX_OwnerActor_Offset));
		RenderTargetType rTType = EnumMarshaler<RenderTargetType>.FromNative(IntPtr.Add(buffer, GetRTForFX_RTType_Offset), 0, GetRTForFX_RTType_PropertyAddress.Address);
		UTextureRenderTarget2D rTForFX = GetRTForFX(ownerActor, rTType);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(buffer, GetRTForFX_ReturnValue_Offset), rTForFX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDBCTest")]
	private static void BGUDBCTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUDBCTest_Owner_Offset));
		string dBCPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUDBCTest_DBCPath_Offset));
		BGUDBCTest(owner, dBCPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TestVector")]
	private static void TestVector__Invoker(IntPtr buffer, IntPtr obj)
	{
		FVector a = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, TestVector_A_Offset));
		TestVector(a);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuff")]
	private static void BGUHasBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHasBuff_Unit_Offset));
		EBPBuffID buffID = EnumMarshaler<EBPBuffID>.FromNative(IntPtr.Add(buffer, BGUHasBuff_BuffID_Offset), 0, BGUHasBuff_BuffID_PropertyAddress.Address);
		bool value = BGUHasBuff(unit, buffID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUHasBuff_ReturnValue_Offset), 0, BGUHasBuff_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:UnitSuicide")]
	private static void UnitSuicide__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, UnitSuicide_Unit_Offset));
		UnitSuicide(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetResID")]
	private static void BGUGetResID__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetResID_Unit_Offset));
		int value = BGUGetResID(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetResID_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:DicSortTest")]
	private static void DicSortTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DicSortTest_Unit_Offset));
		DicSortTest(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ChangeEquip")]
	private static void ChangeEquip__Invoker(IntPtr buffer, IntPtr obj)
	{
		APawn actor = UObjectMarshaler<APawn>.FromNative(IntPtr.Add(buffer, ChangeEquip_Actor_Offset));
		int iD = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ChangeEquip_ID_Offset));
		ChangeEquip(actor, iD);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCostAttr")]
	private static void BGUCostAttr__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUCostAttr_Unit_Offset));
		EAttrCostType attrCostType = EnumMarshaler<EAttrCostType>.FromNative(IntPtr.Add(buffer, BGUCostAttr_AttrCostType_Offset), 0, BGUCostAttr_AttrCostType_PropertyAddress.Address);
		float costBase = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCostAttr_CostBase_Offset));
		float costRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUCostAttr_CostRatio_Offset));
		BGUCostAttr(unit, attrCostType, costBase, costRatio);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PlayUISound")]
	private static void PlayUISound__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject inWorldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, PlayUISound_InWorldContext_Offset));
		UAkAudioEvent inAudioEvent = UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(buffer, PlayUISound_InAudioEvent_Offset));
		int value = PlayUISound(inWorldContext, inAudioEvent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, PlayUISound_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTestEnum")]
	private static void BGUTestEnum__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUTestEnum_Unit_Offset));
		EBGUSimpleState simpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(buffer, BGUTestEnum_SimpleState_Offset), 0, BGUTestEnum_SimpleState_PropertyAddress.Address);
		BGUTestEnum(unit, simpleState);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:CanShutDown")]
	private static void CanShutDown__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, CanShutDown_WorldContext_Offset));
		bool value = CanShutDown(worldContext);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanShutDown_ReturnValue_Offset), 0, CanShutDown_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFOV")]
	private static void GetCameraFOV__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACameraActor cameraActor = UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(buffer, GetCameraFOV_CameraActor_Offset));
		float cameraFOV = GetCameraFOV(cameraActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetCameraFOV_ReturnValue_Offset), cameraFOV);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetTarget")]
	private static void BGUGetTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetTarget_Unit_Offset));
		AActor value = BGUGetTarget(unit);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUGetTarget_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFOV")]
	private static void SetCameraFOV__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACameraActor cameraActor = UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(buffer, SetCameraFOV_CameraActor_Offset));
		float newFOV = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetCameraFOV_NewFOV_Offset));
		SetCameraFOV(cameraActor, newFOV);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetAttrValue")]
	private static void GetAttrValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetAttrValue_Unit_Offset));
		EBGUAttrFloat attrID = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(buffer, GetAttrValue_AttrID_Offset), 0, GetAttrValue_AttrID_PropertyAddress.Address);
		float attrValue = GetAttrValue(unit, attrID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetAttrValue_ReturnValue_Offset), attrValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowFPSUI")]
	private static void BGUShowFPSUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUShowFPSUI_Unit_Offset));
		BGUShowFPSUI(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:RunGMCommand")]
	private static void RunGMCommand__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RunGMCommand_Actor_Offset));
		string cmd = FStringMarshaler.FromNative(IntPtr.Add(buffer, RunGMCommand_cmd_Offset));
		bool justRunInBin = BoolMarshaler.FromNative(IntPtr.Add(buffer, RunGMCommand_JustRunInBin_Offset), 0, RunGMCommand_JustRunInBin_PropertyAddress.Address);
		RunGMCommand(actor, cmd, justRunInBin);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetAllEquipId")]
	private static void GetAllEquipId__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, GetAllEquipId_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		List<int> allEquipId = GetAllEquipId();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllEquipId_ReturnValue_Offset), allEquipId);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:RefreshGameDB")]
	private static void RefreshGameDB__Invoker(IntPtr buffer, IntPtr obj)
	{
		RefreshGameDB();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:StopFetchTick")]
	private static void StopFetchTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, StopFetchTick_WorldContext_Offset));
		StopFetchTick(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsUnitDead")]
	private static void BGUIsUnitDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUIsUnitDead_Unit_Offset));
		bool value = BGUIsUnitDead(unit);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUIsUnitDead_ReturnValue_Offset), 0, BGUIsUnitDead_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuff")]
	private static void BGURemoveBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURemoveBuff_Unit_Offset));
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGURemoveBuff_BuffID_Offset));
		EBuffEffectTriggerType effectTriggerType = EnumMarshaler<EBuffEffectTriggerType>.FromNative(IntPtr.Add(buffer, BGURemoveBuff_EffectTriggerType_Offset), 0, BGURemoveBuff_EffectTriggerType_PropertyAddress.Address);
		int layer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGURemoveBuff_Layer_Offset));
		BGURemoveBuff(unit, buffID, effectTriggerType, layer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActor")]
	private static void BGUSpawnActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, BGUSpawnActor__World_Offset));
		TSubclassOf<AActor> actorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSpawnActor_ActorClass_Offset));
		FVector location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUSpawnActor_Location_Offset));
		FRotator rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(buffer, BGUSpawnActor_Rotation_Offset));
		AActor value = BGUSpawnActor(world, actorClass, location, rotation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUSpawnActor_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffect")]
	private static void TriggerEffect__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, TriggerEffect_Unit_Offset));
		int effectID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TriggerEffect_EffectID_Offset));
		TriggerEffect(unit, effectID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip")]
	private static void SeqChangeEquip__Invoker(IntPtr buffer, IntPtr obj)
	{
		ABGUPerformerActor seqActor = UObjectMarshaler<ABGUPerformerActor>.FromNative(IntPtr.Add(buffer, SeqChangeEquip_SeqActor_Offset));
		int equipID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SeqChangeEquip_EquipID_Offset));
		SeqChangeEquip(seqActor, equipID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsEnemyTeam")]
	private static void BGUIsEnemyTeam__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor selfUnit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUIsEnemyTeam_SelfUnit_Offset));
		AActor otherUnit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUIsEnemyTeam_OtherUnit_Offset));
		bool value = BGUIsEnemyTeam(selfUnit, otherUnit);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUIsEnemyTeam_ReturnValue_Offset), 0, BGUIsEnemyTeam_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuffByID")]
	private static void BGUHasBuffByID__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHasBuffByID_Unit_Offset));
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUHasBuffByID_BuffID_Offset));
		bool value = BGUHasBuffByID(unit, buffID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUHasBuffByID_ReturnValue_Offset), 0, BGUHasBuffByID_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PlayPigsyStory")]
	private static void PlayPigsyStory__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, PlayPigsyStory_Unit_Offset));
		PlayPigsyStory(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:RunEQSForDebug")]
	private static void RunEQSForDebug__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, RunEQSForDebug_Querier_Offset));
		UEnvQuery env = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(buffer, RunEQSForDebug_Env_Offset));
		RunEQSForDebug(querier, env);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TestInputEvent")]
	private static void TestInputEvent__Invoker(IntPtr buffer, IntPtr obj)
	{
		FKeyEvent a = StructAsClassMarshaler<FKeyEvent>.FromNative(IntPtr.Add(buffer, TestInputEvent_A_Offset));
		TestInputEvent(a);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetPhysSetting")]
	private static void SetPhysSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetPhysSetting_Actor_Offset));
		EPhysAnimType type = EnumMarshaler<EPhysAnimType>.FromNative(IntPtr.Add(buffer, SetPhysSetting_Type_Offset), 0, SetPhysSetting_Type_PropertyAddress.Address);
		SetPhysSetting(actor, type);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClearWeapon")]
	private static void BGUClearWeapon__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUClearWeapon_Owner_Offset));
		BGUClearWeapon(owner);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BreakCloudMove")]
	private static void BreakCloudMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BreakCloudMove_Unit_Offset));
		int breakAnimId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BreakCloudMove_BreakAnimId_Offset));
		BreakCloudMove(unit, breakAnimId);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHideLevelUI")]
	private static void BGUHideLevelUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHideLevelUI_Unit_Offset));
		BGUHideLevelUI(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:IsCheatGMLevel")]
	private static void IsCheatGMLevel__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = IsCheatGMLevel();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsCheatGMLevel_ReturnValue_Offset), 0, IsCheatGMLevel_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:IsDebugGMLevel")]
	private static void IsDebugGMLevel__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = IsDebugGMLevel();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsDebugGMLevel_ReturnValue_Offset), 0, IsDebugGMLevel_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitState")]
	private static void BGUHasUnitState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHasUnitState_Unit_Offset));
		EBGUUnitState unitState = EnumMarshaler<EBGUUnitState>.FromNative(IntPtr.Add(buffer, BGUHasUnitState_UnitState_Offset), 0, BGUHasUnitState_UnitState_PropertyAddress.Address);
		bool value = BGUHasUnitState(unit, unitState);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUHasUnitState_ReturnValue_Offset), 0, BGUHasUnitState_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip2")]
	private static void SeqChangeEquip2__Invoker(IntPtr buffer, IntPtr obj)
	{
		ABGUPerformerActor seqActor = UObjectMarshaler<ABGUPerformerActor>.FromNative(IntPtr.Add(buffer, SeqChangeEquip2_SeqActor_Offset));
		SeqChangeEquip2(seqActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GlobalEventTest")]
	private static void GlobalEventTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GlobalEventTest_Unit_Offset));
		int times = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GlobalEventTest_Times_Offset));
		GlobalEventTest(unit, times);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateGrayBox")]
	private static void GenerateGrayBox__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor templeteActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GenerateGrayBox_TempleteActor_Offset));
		GenerateGrayBox(templeteActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetFloatAttr")]
	private static void BGUGetFloatAttr__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetFloatAttr_Unit_Offset));
		EBGUAttrFloat attrID = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(buffer, BGUGetFloatAttr_AttrID_Offset), 0, BGUGetFloatAttr_AttrID_PropertyAddress.Address);
		float value = BGUGetFloatAttr(unit, attrID);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, BGUGetFloatAttr_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SummonEventTest")]
	private static void SummonEventTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SummonEventTest_Unit_Offset));
		SummonEventTest(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetSolverCenter")]
	private static void SetSolverCenter__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor solverCenter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SetSolverCenter_Unit_Offset));
		SetSolverCenter(solverCenter);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponNum")]
	private static void BGUGetWeaponNum__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetWeaponNum_Unit_Offset));
		int value = BGUGetWeaponNum(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetWeaponNum_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetAttrValue")]
	private static void BGUSetAttrValue__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetAttrValue_Unit_Offset));
		EBGUAttrFloat attrID = EnumMarshaler<EBGUAttrFloat>.FromNative(IntPtr.Add(buffer, BGUSetAttrValue_AttrID_Offset), 0, BGUSetAttrValue_AttrID_PropertyAddress.Address);
		float targetValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUSetAttrValue_TargetValue_Offset));
		BGUSetAttrValue(unit, attrID, targetValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpell")]
	private static void BGUTryCastSpell__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUTryCastSpell_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUTryCastSpell_SkillID_Offset));
		ECastSkillSourceType sourceType = EnumMarshaler<ECastSkillSourceType>.FromNative(IntPtr.Add(buffer, BGUTryCastSpell_SourceType_Offset), 0, BGUTryCastSpell_SourceType_PropertyAddress.Address);
		bool isUseComboingSection = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUTryCastSpell_IsUseComboingSection_Offset), 0, BGUTryCastSpell_IsUseComboingSection_PropertyAddress.Address);
		int value = BGUTryCastSpell(unit, skillID, sourceType, isUseComboingSection);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUTryCastSpell_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ToggleCloudMove")]
	private static void ToggleCloudMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ToggleCloudMove_Unit_Offset));
		ToggleCloudMove(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetImmobility")]
	private static void BGUSetImmobility__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetImmobility_Unit_Offset));
		float timer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUSetImmobility_Timer_Offset));
		BGUSetImmobility(unit, timer);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUStartSceneQTE")]
	private static void BGUStartSceneQTE__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUStartSceneQTE_Unit_Offset));
		int qTEID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUStartSceneQTE_QTEID_Offset));
		AActor targetCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUStartSceneQTE_TargetCharacter_Offset));
		BGUStartSceneQTE(unit, qTEID, targetCharacter);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveAllBuff")]
	private static void BGURemoveAllBuff__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURemoveAllBuff_Unit_Offset));
		EBuffEffectTriggerType effectTriggerType = EnumMarshaler<EBuffEffectTriggerType>.FromNative(IntPtr.Add(buffer, BGURemoveAllBuff_EffectTriggerType_Offset), 0, BGURemoveAllBuff_EffectTriggerType_PropertyAddress.Address);
		BGURemoveAllBuff(unit, effectTriggerType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:IsUEDebugGMLevel")]
	private static void IsUEDebugGMLevel__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = IsUEDebugGMLevel();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsUEDebugGMLevel_ReturnValue_Offset), 0, IsUEDebugGMLevel_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ResetPhysSetting")]
	private static void ResetPhysSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ResetPhysSetting_Actor_Offset));
		ResetPhysSetting(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowDialogueUI")]
	private static void BGUShowDialogueUI__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUShowDialogueUI_Unit_Offset));
		string dialogContent = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUShowDialogueUI_DialogContent_Offset));
		float duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUShowDialogueUI_Duration_Offset));
		BGUShowDialogueUI(unit, dialogContent, duration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetTrainDummyInfo")]
	private static void SetTrainDummyInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_WorldContext_Offset));
		string trainDummyClassPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_TrainDummyClassPath_Offset));
		int playerRoleDataConfigID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_PlayerRoleDataConfigID_Offset));
		string trainDummyConfigPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_TrainDummyConfigPath_Offset));
		string cqgPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_CqgPath_Offset));
		float dPSCalTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetTrainDummyInfo_DPSCalTime_Offset));
		bool value = SetTrainDummyInfo(worldContext, trainDummyClassPath, playerRoleDataConfigID, trainDummyConfigPath, cqgPath, dPSCalTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, SetTrainDummyInfo_ReturnValue_Offset), 0, SetTrainDummyInfo_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitEquipFaBao")]
	private static void BGUUnitEquipFaBao__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUUnitEquipFaBao_Unit_Offset));
		int faBaoID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUUnitEquipFaBao_FaBaoID_Offset));
		BGUUnitEquipFaBao(unit, faBaoID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchCameraGroup")]
	private static void SwitchCameraGroup__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SwitchCameraGroup_WorldContext_Offset));
		int cameraGroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, SwitchCameraGroup_CameraGroupID_Offset));
		SwitchCameraGroup(worldContext, cameraGroupID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayLockTarget")]
	private static void BGUPlayLockTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayLockTarget_Owner_Offset));
		BGUCharacterCS targetChr = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, BGUPlayLockTarget_TargetChr_Offset));
		BGUPlayLockTarget(owner, targetChr);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAISetSpeedRate")]
	private static void BGUAISetSpeedRate__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUAISetSpeedRate_Unit_Offset));
		float speedRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUAISetSpeedRate_SpeedRate_Offset));
		BGUAISetSpeedRate(unit, speedRate);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TimeLineNoiseTest")]
	private static void TimeLineNoiseTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		float totalTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TimeLineNoiseTest_TotalTime_Offset));
		int timePointNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TimeLineNoiseTest_TimePointNum_Offset));
		float noiseInterregional = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TimeLineNoiseTest_NoiseInterregional_Offset));
		UCurveFloat curveFloat = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(buffer, TimeLineNoiseTest_CurveFloat_Offset));
		ERichCurveInterpMode interpMode = EnumMarshaler<ERichCurveInterpMode>.FromNative(IntPtr.Add(buffer, TimeLineNoiseTest_InterpMode_Offset), 0, TimeLineNoiseTest_InterpMode_PropertyAddress.Address);
		TimeLineNoiseTest(totalTime, timePointNum, noiseInterregional, curveFloat, interpMode);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUFullTransEnergy")]
	private static void BGUFullTransEnergy__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUFullTransEnergy_WorldContext_Offset));
		BGUFullTransEnergy(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:InteruptPigsyStory")]
	private static void InteruptPigsyStory__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, InteruptPigsyStory_Unit_Offset));
		InteruptPigsyStory(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PlayFacialAnimTest")]
	private static void PlayFacialAnimTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool bPlay = BoolMarshaler.FromNative(IntPtr.Add(buffer, PlayFacialAnimTest_bPlay_Offset), 0, PlayFacialAnimTest_bPlay_PropertyAddress.Address);
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, PlayFacialAnimTest_Unit_Offset));
		UAnimSequence facialAnim = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(buffer, PlayFacialAnimTest_FacialAnim_Offset));
		float timeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PlayFacialAnimTest_TimeOffset_Offset));
		float autoBlendOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, PlayFacialAnimTest_AutoBlendOutTime_Offset));
		PlayFacialAnimTest(bPlay, unit, facialAnim, timeOffset, autoBlendOutTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:KJLSpawnProjectile")]
	private static void KJLSpawnProjectile__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor bulletSpawner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_BulletSpawner_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_Target_Offset));
		string pointGeneratorTag = FStringMarshaler.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_PointGeneratorTag_Offset));
		int bulletID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_BulletID_Offset));
		float limitDistance_ToPlayer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_LimitDistance_ToPlayer_Offset));
		UNiagaraSystem lightningBeam = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_LightningBeam_Offset));
		string lightningEndParamName = FStringMarshaler.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_LightningEndParamName_Offset));
		List<string> socketList = new TArrayCopyMarshaler<string>(1, KJLSpawnProjectile_SocketList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_SocketList_Offset));
		int dummyBulletNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_DummyBulletNum_Offset));
		FVector endPos_Noise = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_EndPos_Noise_Offset));
		UNiagaraComponent dummyNiagara = UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_DummyNiagara_Offset));
		float dummyActiveDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_DummyActiveDistance_Offset));
		FVector2D randomInterval = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, KJLSpawnProjectile_RandomInterval_Offset));
		KJLSpawnProjectile(bulletSpawner, target, pointGeneratorTag, bulletID, limitDistance_ToPlayer, lightningBeam, lightningEndParamName, socketList, dummyBulletNum, endPos_Noise, dummyNiagara, dummyActiveDistance, randomInterval);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetBehaviorTree")]
	private static void BGUSetBehaviorTree__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetBehaviorTree_Unit_Offset));
		UBehaviorTree bT = UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(buffer, BGUSetBehaviorTree_BT_Offset));
		BGUSetBehaviorTree(unit, bT);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnGhostActor")]
	private static void BGUSpawnGhostActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSpawnGhostActor_Target_Offset));
		string dAPath = FStringMarshaler.FromNative(IntPtr.Add(buffer, BGUSpawnGhostActor_DAPath_Offset));
		BGUSpawnGhostActor(target, dAPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchLanguageEnZh")]
	private static void SwitchLanguageEnZh__Invoker(IntPtr buffer, IntPtr obj)
	{
		SwitchLanguageEnZh();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUToggleGlobalURO")]
	private static void BGUToggleGlobalURO__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject uObj = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUToggleGlobalURO_UObj_Offset));
		bool bEnable = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUToggleGlobalURO_bEnable_Offset), 0, BGUToggleGlobalURO_bEnable_PropertyAddress.Address);
		BGUToggleGlobalURO(uObj, bEnable);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveImmobility")]
	private static void BGURemoveImmobility__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURemoveImmobility_Unit_Offset));
		BGURemoveImmobility(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTriggerUnitState")]
	private static void BGUTriggerUnitState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUTriggerUnitState_Actor_Offset));
		EBUStateTrigger stateTrigger = EnumMarshaler<EBUStateTrigger>.FromNative(IntPtr.Add(buffer, BGUTriggerUnitState_StateTrigger_Offset), 0, BGUTriggerUnitState_StateTrigger_PropertyAddress.Address);
		float time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUTriggerUnitState_Time_Offset));
		BGUTriggerUnitState(actor, stateTrigger, time);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:DisablePhysicalMove")]
	private static void DisablePhysicalMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DisablePhysicalMove_Unit_Offset));
		bool bDisable = BoolMarshaler.FromNative(IntPtr.Add(buffer, DisablePhysicalMove_bDisable_Offset), 0, DisablePhysicalMove_bDisable_PropertyAddress.Address);
		DisablePhysicalMove(unit, bDisable);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitUnequipFaBao")]
	private static void BGUUnitUnequipFaBao__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUUnitUnequipFaBao_Unit_Offset));
		BGUUnitUnequipFaBao(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:FindTraceStatResult")]
	private static void FindTraceStatResult__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, FindTraceStatResult_WorldContext_Offset));
		string name = FStringMarshaler.FromNative(IntPtr.Add(buffer, FindTraceStatResult_Name_Offset));
		float value = FindTraceStatResult(worldContext, name);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, FindTraceStatResult_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponByIndex")]
	private static void BGUGetWeaponByIndex__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetWeaponByIndex_Owner_Offset));
		int index = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUGetWeaponByIndex_index_Offset));
		AActor value = BGUGetWeaponByIndex(owner, index);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUGetWeaponByIndex_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSecondFogData")]
	private static void BGUSetSecondFogData__Invoker(IntPtr buffer, IntPtr obj)
	{
		UExponentialHeightFogComponent ehfcomp = UObjectMarshaler<UExponentialHeightFogComponent>.FromNative(IntPtr.Add(buffer, BGUSetSecondFogData_ehfcomp_Offset));
		FExponentialHeightFogData secondFogData = FExponentialHeightFogData.FromNative(IntPtr.Add(buffer, BGUSetSecondFogData_SecondFogData_Offset));
		BGUSetSecondFogData(ehfcomp, secondFogData);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SkipCurrentSequence")]
	private static void SkipCurrentSequence__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SkipCurrentSequence_WorldContext_Offset));
		SkipCurrentSequence(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ClearPhysAnimSetting")]
	private static void ClearPhysAnimSetting__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ClearPhysAnimSetting_Unit_Offset));
		int value = ClearPhysAnimSetting(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, ClearPhysAnimSetting_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMove")]
	private static void BGUPlatformPatroMove__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMove_Unit_Offset));
		FVector beginPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMove_BeginPos_Offset));
		FVector endPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMove_EndPos_Offset));
		float speed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMove_Speed_Offset));
		BGUPlatformPatroMove(unit, beginPos, endPos, speed);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroRota")]
	private static void BGUPlatformPatroRota__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroRota_Unit_Offset));
		int maxRate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroRota_MaxRate_Offset));
		float speed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroRota_Speed_Offset));
		BGUPlatformPatroRota(unit, maxRate, speed);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExitWeakPerformState")]
	private static void ExitWeakPerformState__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject inWorldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ExitWeakPerformState_InWorldContext_Offset));
		ExitWeakPerformState(inWorldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCachedPointSet")]
	private static void BGUGetCachedPointSet__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<FVector> tArrayCopyMarshaler = new TArrayCopyMarshaler<FVector>(1, BGUGetCachedPointSet_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
		AActor ownerCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetCachedPointSet_OwnerCharacter_Offset));
		int requestID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUGetCachedPointSet_RequestID_Offset));
		List<FVector> value = BGUGetCachedPointSet(ownerCharacter, requestID);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, BGUGetCachedPointSet_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:DestroyAllProjectile")]
	private static void DestroyAllProjectile__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DestroyAllProjectile_Unit_Offset));
		DestroyAllProjectile(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchFreeCameraMode")]
	private static void SwitchFreeCameraMode__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject inWorldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SwitchFreeCameraMode_InWorldContext_Offset));
		SwitchFreeCameraMode(inWorldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerSwitchPhysics")]
	private static void TriggerSwitchPhysics__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, TriggerSwitchPhysics_Unit_Offset));
		int value = TriggerSwitchPhysics(unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, TriggerSwitchPhysics_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetActiveGameMode")]
	private static void BGUGetActiveGameMode__Invoker(IntPtr buffer, IntPtr obj)
	{
		int value = BGUGetActiveGameMode();
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetActiveGameMode_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetProjectBranchName")]
	private static void GetProjectBranchName__Invoker(IntPtr buffer, IntPtr obj)
	{
		string projectBranchName = GetProjectBranchName();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetProjectBranchName_ReturnValue_Offset), projectBranchName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetTamerStrategyArea")]
	private static void SetTamerStrategyArea__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject inWorldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, SetTamerStrategyArea_InWorldContext_Offset));
		ETamerStrategyArea inArea = EnumMarshaler<ETamerStrategyArea>.FromNative(IntPtr.Add(buffer, SetTamerStrategyArea_InArea_Offset), 0, SetTamerStrategyArea_InArea_PropertyAddress.Address);
		SetTamerStrategyArea(inWorldContext, inArea);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:HandleAiConversation")]
	private static void HandleAiConversation__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor caster = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, HandleAiConversation_Caster_Offset));
		int conversationContentID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, HandleAiConversation_ConversationContentID_Offset));
		HandleAiConversation(caster, conversationContentID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:EnterWeakPerformState")]
	private static void EnterWeakPerformState__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject inWorldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, EnterWeakPerformState_InWorldContext_Offset));
		int configID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EnterWeakPerformState_ConfigID_Offset));
		EnterWeakPerformState(inWorldContext, configID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExitPlayerSkillCamera")]
	private static void ExitPlayerSkillCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, ExitPlayerSkillCamera_WorldContext_Offset));
		ExitPlayerSkillCamera(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitSimpleState")]
	private static void BGUHasUnitSimpleState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHasUnitSimpleState_Unit_Offset));
		EBGUSimpleState simpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(buffer, BGUHasUnitSimpleState_SimpleState_Offset), 0, BGUHasUnitSimpleState_SimpleState_PropertyAddress.Address);
		bool value = BGUHasUnitSimpleState(unit, simpleState);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUHasUnitSimpleState_ReturnValue_Offset), 0, BGUHasUnitSimpleState_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:CheckCurCeilingHeight")]
	private static void CheckCurCeilingHeight__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACharacter character = UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(buffer, CheckCurCeilingHeight_Character_Offset));
		float lineTraceLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CheckCurCeilingHeight_LineTraceLength_Offset));
		float value = CheckCurCeilingHeight(character, lineTraceLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, CheckCurCeilingHeight_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffectToTarget")]
	private static void TriggerEffectToTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, TriggerEffectToTarget_Unit_Offset));
		int effectID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, TriggerEffectToTarget_EffectID_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, TriggerEffectToTarget_Target_Offset));
		TriggerEffectToTarget(unit, effectID, target);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitCastFaBaoSkill")]
	private static void BGUUnitCastFaBaoSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUUnitCastFaBaoSkill_Unit_Offset));
		BGUUnitCastFaBaoSkill(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitSimpleState")]
	private static void BGUSetUnitSimpleState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetUnitSimpleState_Unit_Offset));
		EBGUSimpleState simpleState = EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(buffer, BGUSetUnitSimpleState_SimpleState_Offset), 0, BGUSetUnitSimpleState_SimpleState_PropertyAddress.Address);
		bool isRemove = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetUnitSimpleState_IsRemove_Offset), 0, BGUSetUnitSimpleState_IsRemove_PropertyAddress.Address);
		BGUSetUnitSimpleState(unit, simpleState, isRemove);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSkillSuperArmor")]
	private static void BGUSetSkillSuperArmor__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetSkillSuperArmor_Unit_Offset));
		UAnimMontage breakSkillSupperArmorAM = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_Offset));
		float skillSuperArmorValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUSetSkillSuperArmor_SkillSuperArmorValue_Offset));
		BGUSetSkillSuperArmor(unit, breakSkillSupperArmorAM, skillSuperArmorValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCallPointsRegister")]
	private static void BGUCallPointsRegister__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor ownerCharacter = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUCallPointsRegister_OwnerCharacter_Offset));
		int requestID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCallPointsRegister_RequestID_Offset));
		PointsGenType genType = EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(buffer, BGUCallPointsRegister_GenType_Offset), 0, BGUCallPointsRegister_GenType_PropertyAddress.Address);
		PointsGenExtParam extParam = PointsGenExtParam.FromNative(IntPtr.Add(buffer, BGUCallPointsRegister_ExtParam_Offset));
		BGUCallPointsRegister(ownerCharacter, requestID, genType, extParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCurrentUserType")]
	private static void BGUGetCurrentUserType__Invoker(IntPtr buffer, IntPtr obj)
	{
		int value = BGUGetCurrentUserType();
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetCurrentUserType_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TryGetComponentByFName")]
	private static void TryGetComponentByFName__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, TryGetComponentByFName_Actor_Offset));
		FName name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, TryGetComponentByFName_Name_Offset));
		UActorComponent value = TryGetComponentByFName(actor, name);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(buffer, TryGetComponentByFName_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHandleAbnormalState")]
	private static void BGUHandleAbnormalState__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor attacker = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHandleAbnormalState_Attacker_Offset));
		AActor victim = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUHandleAbnormalState_Victim_Offset));
		AbnormalStateAccConfig config = AbnormalStateAccConfig.FromNative(IntPtr.Add(buffer, BGUHandleAbnormalState_config_Offset));
		float addValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUHandleAbnormalState_AddValue_Offset));
		BGUHandleAbnormalState(attacker, victim, config, addValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitCritRateBase")]
	private static void BGUSetUnitCritRateBase__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetUnitCritRateBase_Unit_Offset));
		float critRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUSetUnitCritRateBase_CritRate_Offset));
		BGUSetUnitCritRateBase(unit, critRate);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:EnterPlayerSkillCamera")]
	private static void EnterPlayerSkillCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, EnterPlayerSkillCamera_WorldContext_Offset));
		int cameraID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EnterPlayerSkillCamera_CameraID_Offset));
		EnterPlayerSkillCamera(worldContext, cameraID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFocusDistance")]
	private static void SetCameraFocusDistance__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACameraActor cameraActor = UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(buffer, SetCameraFocusDistance_CameraActor_Offset));
		float newFocusDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetCameraFocusDistance_NewFocusDistance_Offset));
		SetCameraFocusDistance(cameraActor, newFocusDistance);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFocusDistance")]
	private static void GetCameraFocusDistance__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACameraActor cameraActor = UObjectMarshaler<ACameraActor>.FromNative(IntPtr.Add(buffer, GetCameraFocusDistance_CameraActor_Offset));
		float cameraFocusDistance = GetCameraFocusDistance(cameraActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetCameraFocusDistance_ReturnValue_Offset), cameraFocusDistance);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExitMonsterSkillCamera")]
	private static void ExitMonsterSkillCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor monster = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ExitMonsterSkillCamera_Monster_Offset));
		ExitMonsterSkillCamera(monster);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetUnitLockTargetActor")]
	private static void GetUnitLockTargetActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GetUnitLockTargetActor_Unit_Offset));
		AActor unitLockTargetActor = GetUnitLockTargetActor(unit);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, GetUnitLockTargetActor_ReturnValue_Offset), unitLockTargetActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetCanTriggerGroupAI")]
	private static void BGUSetCanTriggerGroupAI__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUSetCanTriggerGroupAI_WorldContext_Offset));
		bool canTrigger = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetCanTriggerGroupAI_CanTrigger_Offset), 0, BGUSetCanTriggerGroupAI_CanTrigger_PropertyAddress.Address);
		BGUSetCanTriggerGroupAI(worldContext, canTrigger);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:EnterMonsterSkillCamera")]
	private static void EnterMonsterSkillCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor monster = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, EnterMonsterSkillCamera_Monster_Offset));
		int cameraID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, EnterMonsterSkillCamera_CameraID_Offset));
		EnterMonsterSkillCamera(monster, cameraID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorNoBeginPlay")]
	private static void BGUSpawnActorNoBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, BGUSpawnActorNoBeginPlay__World_Offset));
		TSubclassOf<AActor> actorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSpawnActorNoBeginPlay_ActorClass_Offset));
		AActor value = BGUSpawnActorNoBeginPlay(world, actorClass);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUSpawnActorNoBeginPlay_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PrepareForSkillRecording")]
	private static void PrepareForSkillRecording__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_World_Offset));
		TSubclassOf<BGUCharacterCS> unitClass = TSubclassOfMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_UnitClass_Offset));
		int resID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_ResID_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_SkillID_Offset));
		bool bNeedsSpawnNewUnit = BoolMarshaler.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_bNeedsSpawnNewUnit_Offset), 0, PrepareForSkillRecording_bNeedsSpawnNewUnit_PropertyAddress.Address);
		BGUCharacterCS SpawnedUnit = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, PrepareForSkillRecording_SpawnedUnit_Offset));
		PrepareForSkillRecording(world, unitClass, resID, skillID, bNeedsSpawnNewUnit, ref SpawnedUnit, out var PlayedMontage);
		UObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(buffer, PrepareForSkillRecording_SpawnedUnit_Offset), SpawnedUnit);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(buffer, PrepareForSkillRecording_PlayedMontage_Offset), PlayedMontage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveSkillSuperArmor")]
	private static void BGURemoveSkillSuperArmor__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURemoveSkillSuperArmor_Unit_Offset));
		BGURemoveSkillSuperArmor(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ClampAndAlignToLandScape")]
	private static void ClampAndAlignToLandScape__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ClampAndAlignToLandScape_Unit_Offset));
		bool clampToLand = BoolMarshaler.FromNative(IntPtr.Add(buffer, ClampAndAlignToLandScape_ClampToLand_Offset), 0, ClampAndAlignToLandScape_ClampToLand_PropertyAddress.Address);
		bool alignToLand = BoolMarshaler.FromNative(IntPtr.Add(buffer, ClampAndAlignToLandScape_AlignToLand_Offset), 0, ClampAndAlignToLandScape_AlignToLand_PropertyAddress.Address);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ClampAndAlignToLandScape_DeltaTime_Offset));
		float interpSpd = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ClampAndAlignToLandScape_InterpSpd_Offset));
		ClampAndAlignToLandScape(unit, clampToLand, alignToLand, deltaTime, interpSpd);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuffImmediately")]
	private static void BGURemoveBuffImmediately__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGURemoveBuffImmediately_Unit_Offset));
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGURemoveBuffImmediately_BuffID_Offset));
		EBuffEffectTriggerType effectTriggerType = EnumMarshaler<EBuffEffectTriggerType>.FromNative(IntPtr.Add(buffer, BGURemoveBuffImmediately_EffectTriggerType_Offset), 0, BGURemoveBuffImmediately_EffectTriggerType_PropertyAddress.Address);
		BGURemoveBuffImmediately(unit, buffID, effectTriggerType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUOneHitBreakImmobility")]
	private static void BGUOneHitBreakImmobility__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUOneHitBreakImmobility_Unit_Offset));
		BGUOneHitBreakImmobility(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:CastMagicallyChangeSkill")]
	private static void CastMagicallyChangeSkill__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, CastMagicallyChangeSkill_Unit_Offset));
		BGWDataAsset_MagicallyChangeConfig config = UObjectMarshaler<BGWDataAsset_MagicallyChangeConfig>.FromNative(IntPtr.Add(buffer, CastMagicallyChangeSkill_Config_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, CastMagicallyChangeSkill_SkillID_Offset));
		int recoverSkillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, CastMagicallyChangeSkill_RecoverSkillID_Offset));
		CastMagicallyChangeSkill(unit, config, skillID, recoverSkillID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:CanActivateConsoleCommad")]
	private static void CanActivateConsoleCommad__Invoker(IntPtr buffer, IntPtr obj)
	{
		bool value = CanActivateConsoleCommad();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanActivateConsoleCommad_ReturnValue_Offset), 0, CanActivateConsoleCommad_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetCineCameraFocalLength")]
	private static void GetCineCameraFocalLength__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACineCameraActor cineCameraActor = UObjectMarshaler<ACineCameraActor>.FromNative(IntPtr.Add(buffer, GetCineCameraFocalLength_CineCameraActor_Offset));
		float cineCameraFocalLength = GetCineCameraFocalLength(cineCameraActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetCineCameraFocalLength_ReturnValue_Offset), cineCameraFocalLength);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:SetCineCameraFocalLength")]
	private static void SetCineCameraFocalLength__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACineCameraActor cineCameraActor = UObjectMarshaler<ACineCameraActor>.FromNative(IntPtr.Add(buffer, SetCineCameraFocalLength_CineCameraActor_Offset));
		float newFocalLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetCineCameraFocalLength_NewFocalLength_Offset));
		SetCineCameraFocalLength(cineCameraActor, newFocalLength);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:TestProfileSimpleOverlap")]
	private static void TestProfileSimpleOverlap__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, TestProfileSimpleOverlap_WorldContext_Offset));
		TestProfileSimpleOverlap(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayerCameraLockTarget")]
	private static void BGUPlayerCameraLockTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor player = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayerCameraLockTarget_Player_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlayerCameraLockTarget_Target_Offset));
		BGUPlayerCameraLockTarget(player, target);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClosestPerceivedTarget")]
	private static void BGUClosestPerceivedTarget__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUClosestPerceivedTarget_Unit_Offset));
		AActor value = BGUClosestPerceivedTarget(unit);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUClosestPerceivedTarget_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExportAllTamerToDataAsset")]
	private static void ExportAllTamerToDataAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		ExportAllTamerToDataAsset();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryDestroyDestructible")]
	private static void BGUTryDestroyDestructible__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor destructibleActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUTryDestroyDestructible_DestructibleActor_Offset));
		BGUTryDestroyDestructible(destructibleActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCalcCharacterRotOnSlope")]
	private static void BGUCalcCharacterRotOnSlope__Invoker(IntPtr buffer, IntPtr obj)
	{
		ACharacter ownerChr = UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(buffer, BGUCalcCharacterRotOnSlope_OwnerChr_Offset));
		FVector SurfaceNormal_Normalized;
		FRotator value = BGUCalcCharacterRotOnSlope(ownerChr, out SurfaceNormal_Normalized);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(buffer, BGUCalcCharacterRotOnSlope_ReturnValue_Offset), value);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(buffer, BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_Offset), SurfaceNormal_Normalized);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMoveSingle")]
	private static void BGUPlatformPatroMoveSingle__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_Unit_Offset));
		FVector beginPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_BeginPos_Offset));
		FVector endPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_EndPos_Offset));
		float speed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_Speed_Offset));
		int playerCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_PlayerCount_Offset));
		float range = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BGUPlatformPatroMoveSingle_Range_Offset));
		BGUPlatformPatroMoveSingle(unit, beginPos, endPos, speed, playerCount, range);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetMultiPointCurrentUnit")]
	private static void BGUGetMultiPointCurrentUnit__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUGetMultiPointCurrentUnit_Actor_Offset));
		int value = BGUGetMultiPointCurrentUnit(actor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUGetMultiPointCurrentUnit_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUEnablePlayerGuiBeiCamera")]
	private static void BGUEnablePlayerGuiBeiCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUEnablePlayerGuiBeiCamera_WorldContext_Offset));
		FRotator curInverseAnimRotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(buffer, BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_Offset));
		BGUEnablePlayerGuiBeiCamera(worldContext, curInverseAnimRotation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateNavMeshBoundsVolumes")]
	private static void GenerateNavMeshBoundsVolumes__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor templeteActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GenerateNavMeshBoundsVolumes_TempleteActor_Offset));
		GenerateNavMeshBoundsVolumes(templeteActor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDisablePlayerGuiBeiCamera")]
	private static void BGUDisablePlayerGuiBeiCamera__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUDisablePlayerGuiBeiCamera_WorldContext_Offset));
		BGUDisablePlayerGuiBeiCamera(worldContext);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorAndECSBeginPlay")]
	private static void BGUSpawnActorAndECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, BGUSpawnActorAndECSBeginPlay__World_Offset));
		TSubclassOf<AActor> actorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSpawnActorAndECSBeginPlay_ActorClass_Offset));
		AActor value = BGUSpawnActorAndECSBeginPlay(world, actorClass);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, BGUSpawnActorAndECSBeginPlay_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExportBulletSkillToDataAsset")]
	private static void ExportBulletSkillToDataAsset__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUTamerActor tM = UObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(buffer, ExportBulletSkillToDataAsset_TM_Offset));
		ExportBulletSkillToDataAsset(tM);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByBlame")]
	private static void ExportTamerListToNewDAByBlame__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByBlame_Actor_Offset));
		string oldTamer = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByBlame_OldTamer_Offset));
		string newTimer = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByBlame_NewTimer_Offset));
		string blameName = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByBlame_BlameName_Offset));
		bool value = ExportTamerListToNewDAByBlame(actor, oldTamer, newTimer, blameName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ExportTamerListToNewDAByBlame_ReturnValue_Offset), 0, ExportTamerListToNewDAByBlame_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PlayCamShakeWithControlByClass")]
	private static void PlayCamShakeWithControlByClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		TSubclassOf<UMatineeCameraShake> cameraShakeCls = TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(buffer, PlayCamShakeWithControlByClass_CameraShakeCls_Offset));
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, PlayCamShakeWithControlByClass_Target_Offset));
		PlayCamShakeWithControlByClass(cameraShakeCls, target);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:PauseCamShakeWithControlByActor")]
	private static void PauseCamShakeWithControlByActor__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, PauseCamShakeWithControlByActor_Target_Offset));
		bool bPause = BoolMarshaler.FromNative(IntPtr.Add(buffer, PauseCamShakeWithControlByActor_bPause_Offset), 0, PauseCamShakeWithControlByActor_bPause_PropertyAddress.Address);
		PauseCamShakeWithControlByActor(target, bPause);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetDispInteractActorAttachTo")]
	private static void BGUSetDispInteractActorAttachTo__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor attachTo = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetDispInteractActorAttachTo_AttachTo_Offset));
		BGUSetDispInteractActorAttachTo(attachTo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpellWithStartSection")]
	private static void BGUTryCastSpellWithStartSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUTryCastSpellWithStartSection_Unit_Offset));
		int skillID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUTryCastSpellWithStartSection_SkillID_Offset));
		FName montageStartSectionName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, BGUTryCastSpellWithStartSection_MontageStartSectionName_Offset));
		int value = BGUTryCastSpellWithStartSection(unit, skillID, montageStartSectionName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, BGUTryCastSpellWithStartSection_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetPlayerInSequenceTransition")]
	private static void BGUSetPlayerInSequenceTransition__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor owner = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, BGUSetPlayerInSequenceTransition_Owner_Offset));
		bool bValue = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUSetPlayerInSequenceTransition_bValue_Offset), 0, BGUSetPlayerInSequenceTransition_bValue_PropertyAddress.Address);
		BGUSetPlayerInSequenceTransition(owner, bValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCheckSpecialConsumeItemUseAble")]
	private static void BGUCheckSpecialConsumeItemUseAble__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContext = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, BGUCheckSpecialConsumeItemUseAble_WorldContext_Offset));
		int itemID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, BGUCheckSpecialConsumeItemUseAble_ItemID_Offset));
		bool bShowTips = BoolMarshaler.FromNative(IntPtr.Add(buffer, BGUCheckSpecialConsumeItemUseAble_bShowTips_Offset), 0, BGUCheckSpecialConsumeItemUseAble_bShowTips_PropertyAddress.Address);
		bool value = BGUCheckSpecialConsumeItemUseAble(worldContext, itemID, bShowTips);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, BGUCheckSpecialConsumeItemUseAble_ReturnValue_Offset), 0, BGUCheckSpecialConsumeItemUseAble_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:GetGuibeiBoneTransformFromLastTick")]
	private static void GetGuibeiBoneTransformFromLastTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		UAnimSequence animSeq = UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(buffer, GetGuibeiBoneTransformFromLastTick_AnimSeq_Offset));
		float curTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GetGuibeiBoneTransformFromLastTick_CurTime_Offset));
		float lastTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GetGuibeiBoneTransformFromLastTick_LastTime_Offset));
		FName boneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, GetGuibeiBoneTransformFromLastTick_BoneName_Offset));
		FTransform guibeiBoneTransformFromLastTick = GetGuibeiBoneTransformFromLastTick(animSeq, curTime, lastTime, boneName);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(buffer, GetGuibeiBoneTransformFromLastTick_ReturnValue_Offset), guibeiBoneTransformFromLastTick);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByWeaponInfo")]
	private static void ExportTamerListToNewDAByWeaponInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByWeaponInfo_Actor_Offset));
		string oldTamer = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByWeaponInfo_OldTamer_Offset));
		string newTimer = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByWeaponInfo_NewTimer_Offset));
		string blameName = FStringMarshaler.FromNative(IntPtr.Add(buffer, ExportTamerListToNewDAByWeaponInfo_BlameName_Offset));
		bool value = ExportTamerListToNewDAByWeaponInfo(actor, oldTamer, newTimer, blameName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ExportTamerListToNewDAByWeaponInfo_ReturnValue_Offset), 0, ExportTamerListToNewDAByWeaponInfo_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:RotateLevelRelativeToParentTransform")]
	private static void RotateLevelRelativeToParentTransform__Invoker(IntPtr buffer, IntPtr obj)
	{
		UObject worldContextObject = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(buffer, RotateLevelRelativeToParentTransform_WorldContextObject_Offset));
		FName levelName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, RotateLevelRelativeToParentTransform_LevelName_Offset));
		FTransform parentTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, RotateLevelRelativeToParentTransform_ParentTransform_Offset));
		FTransform parentTransformOffset = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, RotateLevelRelativeToParentTransform_ParentTransformOffset_Offset));
		RotateLevelRelativeToParentTransform(worldContextObject, levelName, parentTransform, parentTransformOffset);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:CalTransformRelativeToParentTransformOffset")]
	private static void CalTransformRelativeToParentTransformOffset__Invoker(IntPtr buffer, IntPtr obj)
	{
		FTransform selfTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, CalTransformRelativeToParentTransformOffset_SelfTransform_Offset));
		FTransform parentTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, CalTransformRelativeToParentTransformOffset_ParentTransform_Offset));
		FTransform parentTransformOffset = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, CalTransformRelativeToParentTransformOffset_ParentTransformOffset_Offset));
		FTransform value = CalTransformRelativeToParentTransformOffset(selfTransform, parentTransform, parentTransformOffset);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(buffer, CalTransformRelativeToParentTransformOffset_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFunctionLibraryCS:ProjectWorldLocationToWidgetPositionWithSZInS")]
	private static void ProjectWorldLocationToWidgetPositionWithSZInS__Invoker(IntPtr buffer, IntPtr obj)
	{
		APlayerController playerController = UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(buffer, ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_Offset));
		FVector worldPos = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_Offset));
		ProjectWorldLocationToWidgetPositionWithSZInS(playerController, worldPos, out var ScreenPos);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(buffer, ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_Offset), ScreenPos);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFunctionLibraryCS");
		BGUGMDead_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGMDead");
		BGUGMDead_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGMDead_FunctionAddress);
		BGUGMDead_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGMDead_FunctionAddress, "Unit");
		BGUGMDead_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGMDead_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGMDead_IsValid = BGUGMDead_FunctionAddress != IntPtr.Zero && BGUGMDead_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGMDead", BGUGMDead_IsValid);
		GM_AddAttr_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GM_AddAttr");
		GM_AddAttr_ParamsSize = NativeReflection.GetFunctionParamsSize(GM_AddAttr_FunctionAddress);
		GM_AddAttr_Unit_Offset = NativeReflection.GetPropertyOffset(GM_AddAttr_FunctionAddress, "Unit");
		GM_AddAttr_Unit_IsValid = NativeReflection.ValidatePropertyClass(GM_AddAttr_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GM_AddAttr_AttrType_PropertyAddress, GM_AddAttr_FunctionAddress, "AttrType");
		GM_AddAttr_AttrType_Offset = NativeReflection.GetPropertyOffset(GM_AddAttr_FunctionAddress, "AttrType");
		GM_AddAttr_AttrType_IsValid = NativeReflection.ValidatePropertyClass(GM_AddAttr_FunctionAddress, "AttrType", Classes.FEnumProperty);
		GM_AddAttr_AddValue_Offset = NativeReflection.GetPropertyOffset(GM_AddAttr_FunctionAddress, "AddValue");
		GM_AddAttr_AddValue_IsValid = NativeReflection.ValidatePropertyClass(GM_AddAttr_FunctionAddress, "AddValue", Classes.FFloatProperty);
		GM_AddAttr_IsValid = GM_AddAttr_FunctionAddress != IntPtr.Zero && GM_AddAttr_Unit_IsValid && GM_AddAttr_AttrType_IsValid && GM_AddAttr_AddValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GM_AddAttr", GM_AddAttr_IsValid);
		BGUAddBuff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAddBuff");
		BGUAddBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAddBuff_FunctionAddress);
		BGUAddBuff_Caster_Offset = NativeReflection.GetPropertyOffset(BGUAddBuff_FunctionAddress, "Caster");
		BGUAddBuff_Caster_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBuff_FunctionAddress, "Caster", Classes.FObjectProperty);
		BGUAddBuff_Target_Offset = NativeReflection.GetPropertyOffset(BGUAddBuff_FunctionAddress, "Target");
		BGUAddBuff_Target_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBuff_FunctionAddress, "Target", Classes.FObjectProperty);
		BGUAddBuff_BuffID_Offset = NativeReflection.GetPropertyOffset(BGUAddBuff_FunctionAddress, "BuffID");
		BGUAddBuff_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBuff_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUAddBuff_BuffSourceType_PropertyAddress, BGUAddBuff_FunctionAddress, "BuffSourceType");
		BGUAddBuff_BuffSourceType_Offset = NativeReflection.GetPropertyOffset(BGUAddBuff_FunctionAddress, "BuffSourceType");
		BGUAddBuff_BuffSourceType_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBuff_FunctionAddress, "BuffSourceType", Classes.FEnumProperty);
		BGUAddBuff_BuffDurationTimer_Offset = NativeReflection.GetPropertyOffset(BGUAddBuff_FunctionAddress, "BuffDurationTimer");
		BGUAddBuff_BuffDurationTimer_IsValid = NativeReflection.ValidatePropertyClass(BGUAddBuff_FunctionAddress, "BuffDurationTimer", Classes.FFloatProperty);
		BGUAddBuff_IsValid = BGUAddBuff_FunctionAddress != IntPtr.Zero && BGUAddBuff_Caster_IsValid && BGUAddBuff_Target_IsValid && BGUAddBuff_BuffID_IsValid && BGUAddBuff_BuffSourceType_IsValid && BGUAddBuff_BuffDurationTimer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAddBuff", BGUAddBuff_IsValid);
		GetRTForFX_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRTForFX");
		GetRTForFX_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRTForFX_FunctionAddress);
		GetRTForFX_OwnerActor_Offset = NativeReflection.GetPropertyOffset(GetRTForFX_FunctionAddress, "OwnerActor");
		GetRTForFX_OwnerActor_IsValid = NativeReflection.ValidatePropertyClass(GetRTForFX_FunctionAddress, "OwnerActor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetRTForFX_RTType_PropertyAddress, GetRTForFX_FunctionAddress, "RTType");
		GetRTForFX_RTType_Offset = NativeReflection.GetPropertyOffset(GetRTForFX_FunctionAddress, "RTType");
		GetRTForFX_RTType_IsValid = NativeReflection.ValidatePropertyClass(GetRTForFX_FunctionAddress, "RTType", Classes.FEnumProperty);
		GetRTForFX_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRTForFX_FunctionAddress, "ReturnValue");
		GetRTForFX_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRTForFX_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetRTForFX_IsValid = GetRTForFX_FunctionAddress != IntPtr.Zero && GetRTForFX_OwnerActor_IsValid && GetRTForFX_RTType_IsValid && GetRTForFX_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetRTForFX", GetRTForFX_IsValid);
		BGUDBCTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUDBCTest");
		BGUDBCTest_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDBCTest_FunctionAddress);
		BGUDBCTest_Owner_Offset = NativeReflection.GetPropertyOffset(BGUDBCTest_FunctionAddress, "Owner");
		BGUDBCTest_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUDBCTest_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUDBCTest_DBCPath_PropertyAddress, BGUDBCTest_FunctionAddress, "DBCPath");
		BGUDBCTest_DBCPath_Offset = NativeReflection.GetPropertyOffset(BGUDBCTest_FunctionAddress, "DBCPath");
		BGUDBCTest_DBCPath_IsValid = NativeReflection.ValidatePropertyClass(BGUDBCTest_FunctionAddress, "DBCPath", Classes.FStrProperty);
		BGUDBCTest_IsValid = BGUDBCTest_FunctionAddress != IntPtr.Zero && BGUDBCTest_Owner_IsValid && BGUDBCTest_DBCPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDBCTest", BGUDBCTest_IsValid);
		TestVector_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestVector");
		TestVector_ParamsSize = NativeReflection.GetFunctionParamsSize(TestVector_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TestVector_A_PropertyAddress, TestVector_FunctionAddress, "A");
		TestVector_A_Offset = NativeReflection.GetPropertyOffset(TestVector_FunctionAddress, "A");
		TestVector_A_IsValid = NativeReflection.ValidatePropertyClass(TestVector_FunctionAddress, "A", Classes.FStructProperty);
		TestVector_IsValid = TestVector_FunctionAddress != IntPtr.Zero && TestVector_A_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TestVector", TestVector_IsValid);
		BGUHasBuff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHasBuff");
		BGUHasBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHasBuff_FunctionAddress);
		BGUHasBuff_Unit_Offset = NativeReflection.GetPropertyOffset(BGUHasBuff_FunctionAddress, "Unit");
		BGUHasBuff_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuff_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUHasBuff_BuffID_PropertyAddress, BGUHasBuff_FunctionAddress, "BuffID");
		BGUHasBuff_BuffID_Offset = NativeReflection.GetPropertyOffset(BGUHasBuff_FunctionAddress, "BuffID");
		BGUHasBuff_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuff_FunctionAddress, "BuffID", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUHasBuff_ReturnValue_PropertyAddress, BGUHasBuff_FunctionAddress, "ReturnValue");
		BGUHasBuff_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUHasBuff_FunctionAddress, "ReturnValue");
		BGUHasBuff_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuff_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUHasBuff_IsValid = BGUHasBuff_FunctionAddress != IntPtr.Zero && BGUHasBuff_Unit_IsValid && BGUHasBuff_BuffID_IsValid && BGUHasBuff_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuff", BGUHasBuff_IsValid);
		UnitSuicide_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UnitSuicide");
		UnitSuicide_ParamsSize = NativeReflection.GetFunctionParamsSize(UnitSuicide_FunctionAddress);
		UnitSuicide_Unit_Offset = NativeReflection.GetPropertyOffset(UnitSuicide_FunctionAddress, "Unit");
		UnitSuicide_Unit_IsValid = NativeReflection.ValidatePropertyClass(UnitSuicide_FunctionAddress, "Unit", Classes.FObjectProperty);
		UnitSuicide_IsValid = UnitSuicide_FunctionAddress != IntPtr.Zero && UnitSuicide_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:UnitSuicide", UnitSuicide_IsValid);
		BGUGetResID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetResID");
		BGUGetResID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetResID_FunctionAddress);
		BGUGetResID_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetResID_FunctionAddress, "Unit");
		BGUGetResID_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetResID_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetResID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetResID_FunctionAddress, "ReturnValue");
		BGUGetResID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetResID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetResID_IsValid = BGUGetResID_FunctionAddress != IntPtr.Zero && BGUGetResID_Unit_IsValid && BGUGetResID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetResID", BGUGetResID_IsValid);
		DicSortTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DicSortTest");
		DicSortTest_ParamsSize = NativeReflection.GetFunctionParamsSize(DicSortTest_FunctionAddress);
		DicSortTest_Unit_Offset = NativeReflection.GetPropertyOffset(DicSortTest_FunctionAddress, "Unit");
		DicSortTest_Unit_IsValid = NativeReflection.ValidatePropertyClass(DicSortTest_FunctionAddress, "Unit", Classes.FObjectProperty);
		DicSortTest_IsValid = DicSortTest_FunctionAddress != IntPtr.Zero && DicSortTest_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:DicSortTest", DicSortTest_IsValid);
		ChangeEquip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ChangeEquip");
		ChangeEquip_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeEquip_FunctionAddress);
		ChangeEquip_Actor_Offset = NativeReflection.GetPropertyOffset(ChangeEquip_FunctionAddress, "Actor");
		ChangeEquip_Actor_IsValid = NativeReflection.ValidatePropertyClass(ChangeEquip_FunctionAddress, "Actor", Classes.FObjectProperty);
		ChangeEquip_ID_Offset = NativeReflection.GetPropertyOffset(ChangeEquip_FunctionAddress, "ID");
		ChangeEquip_ID_IsValid = NativeReflection.ValidatePropertyClass(ChangeEquip_FunctionAddress, "ID", Classes.FIntProperty);
		ChangeEquip_IsValid = ChangeEquip_FunctionAddress != IntPtr.Zero && ChangeEquip_Actor_IsValid && ChangeEquip_ID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ChangeEquip", ChangeEquip_IsValid);
		BGUCostAttr_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCostAttr");
		BGUCostAttr_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCostAttr_FunctionAddress);
		BGUCostAttr_Unit_Offset = NativeReflection.GetPropertyOffset(BGUCostAttr_FunctionAddress, "Unit");
		BGUCostAttr_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUCostAttr_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUCostAttr_AttrCostType_PropertyAddress, BGUCostAttr_FunctionAddress, "AttrCostType");
		BGUCostAttr_AttrCostType_Offset = NativeReflection.GetPropertyOffset(BGUCostAttr_FunctionAddress, "AttrCostType");
		BGUCostAttr_AttrCostType_IsValid = NativeReflection.ValidatePropertyClass(BGUCostAttr_FunctionAddress, "AttrCostType", Classes.FEnumProperty);
		BGUCostAttr_CostBase_Offset = NativeReflection.GetPropertyOffset(BGUCostAttr_FunctionAddress, "CostBase");
		BGUCostAttr_CostBase_IsValid = NativeReflection.ValidatePropertyClass(BGUCostAttr_FunctionAddress, "CostBase", Classes.FFloatProperty);
		BGUCostAttr_CostRatio_Offset = NativeReflection.GetPropertyOffset(BGUCostAttr_FunctionAddress, "CostRatio");
		BGUCostAttr_CostRatio_IsValid = NativeReflection.ValidatePropertyClass(BGUCostAttr_FunctionAddress, "CostRatio", Classes.FFloatProperty);
		BGUCostAttr_IsValid = BGUCostAttr_FunctionAddress != IntPtr.Zero && BGUCostAttr_Unit_IsValid && BGUCostAttr_AttrCostType_IsValid && BGUCostAttr_CostBase_IsValid && BGUCostAttr_CostRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCostAttr", BGUCostAttr_IsValid);
		PlayUISound_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayUISound");
		PlayUISound_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayUISound_FunctionAddress);
		PlayUISound_InWorldContext_Offset = NativeReflection.GetPropertyOffset(PlayUISound_FunctionAddress, "InWorldContext");
		PlayUISound_InWorldContext_IsValid = NativeReflection.ValidatePropertyClass(PlayUISound_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		PlayUISound_InAudioEvent_Offset = NativeReflection.GetPropertyOffset(PlayUISound_FunctionAddress, "InAudioEvent");
		PlayUISound_InAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(PlayUISound_FunctionAddress, "InAudioEvent", Classes.FObjectProperty);
		PlayUISound_ReturnValue_Offset = NativeReflection.GetPropertyOffset(PlayUISound_FunctionAddress, "ReturnValue");
		PlayUISound_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(PlayUISound_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		PlayUISound_IsValid = PlayUISound_FunctionAddress != IntPtr.Zero && PlayUISound_InWorldContext_IsValid && PlayUISound_InAudioEvent_IsValid && PlayUISound_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PlayUISound", PlayUISound_IsValid);
		BGUTestEnum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTestEnum");
		BGUTestEnum_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTestEnum_FunctionAddress);
		BGUTestEnum_Unit_Offset = NativeReflection.GetPropertyOffset(BGUTestEnum_FunctionAddress, "Unit");
		BGUTestEnum_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUTestEnum_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUTestEnum_SimpleState_PropertyAddress, BGUTestEnum_FunctionAddress, "SimpleState");
		BGUTestEnum_SimpleState_Offset = NativeReflection.GetPropertyOffset(BGUTestEnum_FunctionAddress, "SimpleState");
		BGUTestEnum_SimpleState_IsValid = NativeReflection.ValidatePropertyClass(BGUTestEnum_FunctionAddress, "SimpleState", Classes.FEnumProperty);
		BGUTestEnum_IsValid = BGUTestEnum_FunctionAddress != IntPtr.Zero && BGUTestEnum_Unit_IsValid && BGUTestEnum_SimpleState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTestEnum", BGUTestEnum_IsValid);
		CanShutDown_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanShutDown");
		CanShutDown_ParamsSize = NativeReflection.GetFunctionParamsSize(CanShutDown_FunctionAddress);
		CanShutDown_WorldContext_Offset = NativeReflection.GetPropertyOffset(CanShutDown_FunctionAddress, "WorldContext");
		CanShutDown_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(CanShutDown_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CanShutDown_ReturnValue_PropertyAddress, CanShutDown_FunctionAddress, "ReturnValue");
		CanShutDown_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanShutDown_FunctionAddress, "ReturnValue");
		CanShutDown_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanShutDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanShutDown_IsValid = CanShutDown_FunctionAddress != IntPtr.Zero && CanShutDown_WorldContext_IsValid && CanShutDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:CanShutDown", CanShutDown_IsValid);
		GetCameraFOV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCameraFOV");
		GetCameraFOV_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraFOV_FunctionAddress);
		GetCameraFOV_CameraActor_Offset = NativeReflection.GetPropertyOffset(GetCameraFOV_FunctionAddress, "CameraActor");
		GetCameraFOV_CameraActor_IsValid = NativeReflection.ValidatePropertyClass(GetCameraFOV_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		GetCameraFOV_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCameraFOV_FunctionAddress, "ReturnValue");
		GetCameraFOV_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCameraFOV_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCameraFOV_IsValid = GetCameraFOV_FunctionAddress != IntPtr.Zero && GetCameraFOV_CameraActor_IsValid && GetCameraFOV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFOV", GetCameraFOV_IsValid);
		BGUGetTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetTarget");
		BGUGetTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTarget_FunctionAddress);
		BGUGetTarget_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetTarget_FunctionAddress, "Unit");
		BGUGetTarget_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetTarget_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetTarget_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetTarget_FunctionAddress, "ReturnValue");
		BGUGetTarget_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetTarget_IsValid = BGUGetTarget_FunctionAddress != IntPtr.Zero && BGUGetTarget_Unit_IsValid && BGUGetTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetTarget", BGUGetTarget_IsValid);
		SetCameraFOV_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCameraFOV");
		SetCameraFOV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraFOV_FunctionAddress);
		SetCameraFOV_CameraActor_Offset = NativeReflection.GetPropertyOffset(SetCameraFOV_FunctionAddress, "CameraActor");
		SetCameraFOV_CameraActor_IsValid = NativeReflection.ValidatePropertyClass(SetCameraFOV_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		SetCameraFOV_NewFOV_Offset = NativeReflection.GetPropertyOffset(SetCameraFOV_FunctionAddress, "NewFOV");
		SetCameraFOV_NewFOV_IsValid = NativeReflection.ValidatePropertyClass(SetCameraFOV_FunctionAddress, "NewFOV", Classes.FFloatProperty);
		SetCameraFOV_IsValid = SetCameraFOV_FunctionAddress != IntPtr.Zero && SetCameraFOV_CameraActor_IsValid && SetCameraFOV_NewFOV_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFOV", SetCameraFOV_IsValid);
		GetAttrValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAttrValue");
		GetAttrValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAttrValue_FunctionAddress);
		GetAttrValue_Unit_Offset = NativeReflection.GetPropertyOffset(GetAttrValue_FunctionAddress, "Unit");
		GetAttrValue_Unit_IsValid = NativeReflection.ValidatePropertyClass(GetAttrValue_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GetAttrValue_AttrID_PropertyAddress, GetAttrValue_FunctionAddress, "AttrID");
		GetAttrValue_AttrID_Offset = NativeReflection.GetPropertyOffset(GetAttrValue_FunctionAddress, "AttrID");
		GetAttrValue_AttrID_IsValid = NativeReflection.ValidatePropertyClass(GetAttrValue_FunctionAddress, "AttrID", Classes.FEnumProperty);
		GetAttrValue_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAttrValue_FunctionAddress, "ReturnValue");
		GetAttrValue_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAttrValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetAttrValue_IsValid = GetAttrValue_FunctionAddress != IntPtr.Zero && GetAttrValue_Unit_IsValid && GetAttrValue_AttrID_IsValid && GetAttrValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetAttrValue", GetAttrValue_IsValid);
		BGUShowFPSUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUShowFPSUI");
		BGUShowFPSUI_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUShowFPSUI_FunctionAddress);
		BGUShowFPSUI_Unit_Offset = NativeReflection.GetPropertyOffset(BGUShowFPSUI_FunctionAddress, "Unit");
		BGUShowFPSUI_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUShowFPSUI_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUShowFPSUI_IsValid = BGUShowFPSUI_FunctionAddress != IntPtr.Zero && BGUShowFPSUI_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowFPSUI", BGUShowFPSUI_IsValid);
		RunGMCommand_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunGMCommand");
		RunGMCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(RunGMCommand_FunctionAddress);
		RunGMCommand_Actor_Offset = NativeReflection.GetPropertyOffset(RunGMCommand_FunctionAddress, "Actor");
		RunGMCommand_Actor_IsValid = NativeReflection.ValidatePropertyClass(RunGMCommand_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref RunGMCommand_cmd_PropertyAddress, RunGMCommand_FunctionAddress, "cmd");
		RunGMCommand_cmd_Offset = NativeReflection.GetPropertyOffset(RunGMCommand_FunctionAddress, "cmd");
		RunGMCommand_cmd_IsValid = NativeReflection.ValidatePropertyClass(RunGMCommand_FunctionAddress, "cmd", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref RunGMCommand_JustRunInBin_PropertyAddress, RunGMCommand_FunctionAddress, "JustRunInBin");
		RunGMCommand_JustRunInBin_Offset = NativeReflection.GetPropertyOffset(RunGMCommand_FunctionAddress, "JustRunInBin");
		RunGMCommand_JustRunInBin_IsValid = NativeReflection.ValidatePropertyClass(RunGMCommand_FunctionAddress, "JustRunInBin", Classes.FBoolProperty);
		RunGMCommand_IsValid = RunGMCommand_FunctionAddress != IntPtr.Zero && RunGMCommand_Actor_IsValid && RunGMCommand_cmd_IsValid && RunGMCommand_JustRunInBin_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:RunGMCommand", RunGMCommand_IsValid);
		GetAllEquipId_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllEquipId");
		GetAllEquipId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllEquipId_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllEquipId_ReturnValue_PropertyAddress, GetAllEquipId_FunctionAddress, "ReturnValue");
		GetAllEquipId_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAllEquipId_FunctionAddress, "ReturnValue");
		GetAllEquipId_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAllEquipId_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllEquipId_IsValid = GetAllEquipId_FunctionAddress != IntPtr.Zero && GetAllEquipId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetAllEquipId", GetAllEquipId_IsValid);
		RefreshGameDB_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RefreshGameDB");
		RefreshGameDB_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshGameDB_FunctionAddress);
		RefreshGameDB_IsValid = RefreshGameDB_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:RefreshGameDB", RefreshGameDB_IsValid);
		StopFetchTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopFetchTick");
		StopFetchTick_ParamsSize = NativeReflection.GetFunctionParamsSize(StopFetchTick_FunctionAddress);
		StopFetchTick_WorldContext_Offset = NativeReflection.GetPropertyOffset(StopFetchTick_FunctionAddress, "WorldContext");
		StopFetchTick_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(StopFetchTick_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		StopFetchTick_IsValid = StopFetchTick_FunctionAddress != IntPtr.Zero && StopFetchTick_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:StopFetchTick", StopFetchTick_IsValid);
		BGUIsUnitDead_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUIsUnitDead");
		BGUIsUnitDead_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsUnitDead_FunctionAddress);
		BGUIsUnitDead_Unit_Offset = NativeReflection.GetPropertyOffset(BGUIsUnitDead_FunctionAddress, "Unit");
		BGUIsUnitDead_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUIsUnitDead_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUIsUnitDead_ReturnValue_PropertyAddress, BGUIsUnitDead_FunctionAddress, "ReturnValue");
		BGUIsUnitDead_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUIsUnitDead_FunctionAddress, "ReturnValue");
		BGUIsUnitDead_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUIsUnitDead_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsUnitDead_IsValid = BGUIsUnitDead_FunctionAddress != IntPtr.Zero && BGUIsUnitDead_Unit_IsValid && BGUIsUnitDead_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsUnitDead", BGUIsUnitDead_IsValid);
		BGURemoveBuff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURemoveBuff");
		BGURemoveBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURemoveBuff_FunctionAddress);
		BGURemoveBuff_Unit_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuff_FunctionAddress, "Unit");
		BGURemoveBuff_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuff_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURemoveBuff_BuffID_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuff_FunctionAddress, "BuffID");
		BGURemoveBuff_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuff_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGURemoveBuff_EffectTriggerType_PropertyAddress, BGURemoveBuff_FunctionAddress, "EffectTriggerType");
		BGURemoveBuff_EffectTriggerType_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuff_FunctionAddress, "EffectTriggerType");
		BGURemoveBuff_EffectTriggerType_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuff_FunctionAddress, "EffectTriggerType", Classes.FEnumProperty);
		BGURemoveBuff_Layer_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuff_FunctionAddress, "Layer");
		BGURemoveBuff_Layer_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuff_FunctionAddress, "Layer", Classes.FIntProperty);
		BGURemoveBuff_IsValid = BGURemoveBuff_FunctionAddress != IntPtr.Zero && BGURemoveBuff_Unit_IsValid && BGURemoveBuff_BuffID_IsValid && BGURemoveBuff_EffectTriggerType_IsValid && BGURemoveBuff_Layer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuff", BGURemoveBuff_IsValid);
		BGUSpawnActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSpawnActor");
		BGUSpawnActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSpawnActor_FunctionAddress);
		BGUSpawnActor__World_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActor_FunctionAddress, "_World");
		BGUSpawnActor__World_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActor_FunctionAddress, "_World", Classes.FObjectProperty);
		BGUSpawnActor_ActorClass_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActor_FunctionAddress, "ActorClass");
		BGUSpawnActor_ActorClass_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActor_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref BGUSpawnActor_Location_PropertyAddress, BGUSpawnActor_FunctionAddress, "Location");
		BGUSpawnActor_Location_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActor_FunctionAddress, "Location");
		BGUSpawnActor_Location_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActor_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUSpawnActor_Rotation_PropertyAddress, BGUSpawnActor_FunctionAddress, "Rotation");
		BGUSpawnActor_Rotation_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActor_FunctionAddress, "Rotation");
		BGUSpawnActor_Rotation_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActor_FunctionAddress, "Rotation", Classes.FStructProperty);
		BGUSpawnActor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActor_FunctionAddress, "ReturnValue");
		BGUSpawnActor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUSpawnActor_IsValid = BGUSpawnActor_FunctionAddress != IntPtr.Zero && BGUSpawnActor__World_IsValid && BGUSpawnActor_ActorClass_IsValid && BGUSpawnActor_Location_IsValid && BGUSpawnActor_Rotation_IsValid && BGUSpawnActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActor", BGUSpawnActor_IsValid);
		TriggerEffect_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TriggerEffect");
		TriggerEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerEffect_FunctionAddress);
		TriggerEffect_Unit_Offset = NativeReflection.GetPropertyOffset(TriggerEffect_FunctionAddress, "Unit");
		TriggerEffect_Unit_IsValid = NativeReflection.ValidatePropertyClass(TriggerEffect_FunctionAddress, "Unit", Classes.FObjectProperty);
		TriggerEffect_EffectID_Offset = NativeReflection.GetPropertyOffset(TriggerEffect_FunctionAddress, "EffectID");
		TriggerEffect_EffectID_IsValid = NativeReflection.ValidatePropertyClass(TriggerEffect_FunctionAddress, "EffectID", Classes.FIntProperty);
		TriggerEffect_IsValid = TriggerEffect_FunctionAddress != IntPtr.Zero && TriggerEffect_Unit_IsValid && TriggerEffect_EffectID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffect", TriggerEffect_IsValid);
		SeqChangeEquip_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SeqChangeEquip");
		SeqChangeEquip_ParamsSize = NativeReflection.GetFunctionParamsSize(SeqChangeEquip_FunctionAddress);
		SeqChangeEquip_SeqActor_Offset = NativeReflection.GetPropertyOffset(SeqChangeEquip_FunctionAddress, "SeqActor");
		SeqChangeEquip_SeqActor_IsValid = NativeReflection.ValidatePropertyClass(SeqChangeEquip_FunctionAddress, "SeqActor", Classes.FObjectProperty);
		SeqChangeEquip_EquipID_Offset = NativeReflection.GetPropertyOffset(SeqChangeEquip_FunctionAddress, "EquipID");
		SeqChangeEquip_EquipID_IsValid = NativeReflection.ValidatePropertyClass(SeqChangeEquip_FunctionAddress, "EquipID", Classes.FIntProperty);
		SeqChangeEquip_IsValid = SeqChangeEquip_FunctionAddress != IntPtr.Zero && SeqChangeEquip_SeqActor_IsValid && SeqChangeEquip_EquipID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip", SeqChangeEquip_IsValid);
		BGUIsEnemyTeam_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUIsEnemyTeam");
		BGUIsEnemyTeam_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsEnemyTeam_FunctionAddress);
		BGUIsEnemyTeam_SelfUnit_Offset = NativeReflection.GetPropertyOffset(BGUIsEnemyTeam_FunctionAddress, "SelfUnit");
		BGUIsEnemyTeam_SelfUnit_IsValid = NativeReflection.ValidatePropertyClass(BGUIsEnemyTeam_FunctionAddress, "SelfUnit", Classes.FObjectProperty);
		BGUIsEnemyTeam_OtherUnit_Offset = NativeReflection.GetPropertyOffset(BGUIsEnemyTeam_FunctionAddress, "OtherUnit");
		BGUIsEnemyTeam_OtherUnit_IsValid = NativeReflection.ValidatePropertyClass(BGUIsEnemyTeam_FunctionAddress, "OtherUnit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUIsEnemyTeam_ReturnValue_PropertyAddress, BGUIsEnemyTeam_FunctionAddress, "ReturnValue");
		BGUIsEnemyTeam_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUIsEnemyTeam_FunctionAddress, "ReturnValue");
		BGUIsEnemyTeam_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUIsEnemyTeam_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsEnemyTeam_IsValid = BGUIsEnemyTeam_FunctionAddress != IntPtr.Zero && BGUIsEnemyTeam_SelfUnit_IsValid && BGUIsEnemyTeam_OtherUnit_IsValid && BGUIsEnemyTeam_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUIsEnemyTeam", BGUIsEnemyTeam_IsValid);
		BGUHasBuffByID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHasBuffByID");
		BGUHasBuffByID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHasBuffByID_FunctionAddress);
		BGUHasBuffByID_Unit_Offset = NativeReflection.GetPropertyOffset(BGUHasBuffByID_FunctionAddress, "Unit");
		BGUHasBuffByID_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuffByID_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUHasBuffByID_BuffID_Offset = NativeReflection.GetPropertyOffset(BGUHasBuffByID_FunctionAddress, "BuffID");
		BGUHasBuffByID_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuffByID_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUHasBuffByID_ReturnValue_PropertyAddress, BGUHasBuffByID_FunctionAddress, "ReturnValue");
		BGUHasBuffByID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUHasBuffByID_FunctionAddress, "ReturnValue");
		BGUHasBuffByID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUHasBuffByID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUHasBuffByID_IsValid = BGUHasBuffByID_FunctionAddress != IntPtr.Zero && BGUHasBuffByID_Unit_IsValid && BGUHasBuffByID_BuffID_IsValid && BGUHasBuffByID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasBuffByID", BGUHasBuffByID_IsValid);
		PlayPigsyStory_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayPigsyStory");
		PlayPigsyStory_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayPigsyStory_FunctionAddress);
		PlayPigsyStory_Unit_Offset = NativeReflection.GetPropertyOffset(PlayPigsyStory_FunctionAddress, "Unit");
		PlayPigsyStory_Unit_IsValid = NativeReflection.ValidatePropertyClass(PlayPigsyStory_FunctionAddress, "Unit", Classes.FObjectProperty);
		PlayPigsyStory_IsValid = PlayPigsyStory_FunctionAddress != IntPtr.Zero && PlayPigsyStory_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PlayPigsyStory", PlayPigsyStory_IsValid);
		RunEQSForDebug_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunEQSForDebug");
		RunEQSForDebug_ParamsSize = NativeReflection.GetFunctionParamsSize(RunEQSForDebug_FunctionAddress);
		RunEQSForDebug_Querier_Offset = NativeReflection.GetPropertyOffset(RunEQSForDebug_FunctionAddress, "Querier");
		RunEQSForDebug_Querier_IsValid = NativeReflection.ValidatePropertyClass(RunEQSForDebug_FunctionAddress, "Querier", Classes.FObjectProperty);
		RunEQSForDebug_Env_Offset = NativeReflection.GetPropertyOffset(RunEQSForDebug_FunctionAddress, "Env");
		RunEQSForDebug_Env_IsValid = NativeReflection.ValidatePropertyClass(RunEQSForDebug_FunctionAddress, "Env", Classes.FObjectProperty);
		RunEQSForDebug_IsValid = RunEQSForDebug_FunctionAddress != IntPtr.Zero && RunEQSForDebug_Querier_IsValid && RunEQSForDebug_Env_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:RunEQSForDebug", RunEQSForDebug_IsValid);
		TestInputEvent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestInputEvent");
		TestInputEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(TestInputEvent_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TestInputEvent_A_PropertyAddress, TestInputEvent_FunctionAddress, "A");
		TestInputEvent_A_Offset = NativeReflection.GetPropertyOffset(TestInputEvent_FunctionAddress, "A");
		TestInputEvent_A_IsValid = NativeReflection.ValidatePropertyClass(TestInputEvent_FunctionAddress, "A", Classes.FStructProperty);
		TestInputEvent_IsValid = TestInputEvent_FunctionAddress != IntPtr.Zero && TestInputEvent_A_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TestInputEvent", TestInputEvent_IsValid);
		SetPhysSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPhysSetting");
		SetPhysSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPhysSetting_FunctionAddress);
		SetPhysSetting_Actor_Offset = NativeReflection.GetPropertyOffset(SetPhysSetting_FunctionAddress, "Actor");
		SetPhysSetting_Actor_IsValid = NativeReflection.ValidatePropertyClass(SetPhysSetting_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetPhysSetting_Type_PropertyAddress, SetPhysSetting_FunctionAddress, "Type");
		SetPhysSetting_Type_Offset = NativeReflection.GetPropertyOffset(SetPhysSetting_FunctionAddress, "Type");
		SetPhysSetting_Type_IsValid = NativeReflection.ValidatePropertyClass(SetPhysSetting_FunctionAddress, "Type", Classes.FEnumProperty);
		SetPhysSetting_IsValid = SetPhysSetting_FunctionAddress != IntPtr.Zero && SetPhysSetting_Actor_IsValid && SetPhysSetting_Type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetPhysSetting", SetPhysSetting_IsValid);
		BGUClearWeapon_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUClearWeapon");
		BGUClearWeapon_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUClearWeapon_FunctionAddress);
		BGUClearWeapon_Owner_Offset = NativeReflection.GetPropertyOffset(BGUClearWeapon_FunctionAddress, "Owner");
		BGUClearWeapon_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUClearWeapon_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUClearWeapon_IsValid = BGUClearWeapon_FunctionAddress != IntPtr.Zero && BGUClearWeapon_Owner_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClearWeapon", BGUClearWeapon_IsValid);
		BreakCloudMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BreakCloudMove");
		BreakCloudMove_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakCloudMove_FunctionAddress);
		BreakCloudMove_Unit_Offset = NativeReflection.GetPropertyOffset(BreakCloudMove_FunctionAddress, "Unit");
		BreakCloudMove_Unit_IsValid = NativeReflection.ValidatePropertyClass(BreakCloudMove_FunctionAddress, "Unit", Classes.FObjectProperty);
		BreakCloudMove_BreakAnimId_Offset = NativeReflection.GetPropertyOffset(BreakCloudMove_FunctionAddress, "BreakAnimId");
		BreakCloudMove_BreakAnimId_IsValid = NativeReflection.ValidatePropertyClass(BreakCloudMove_FunctionAddress, "BreakAnimId", Classes.FIntProperty);
		BreakCloudMove_IsValid = BreakCloudMove_FunctionAddress != IntPtr.Zero && BreakCloudMove_Unit_IsValid && BreakCloudMove_BreakAnimId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BreakCloudMove", BreakCloudMove_IsValid);
		BGUHideLevelUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHideLevelUI");
		BGUHideLevelUI_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHideLevelUI_FunctionAddress);
		BGUHideLevelUI_Unit_Offset = NativeReflection.GetPropertyOffset(BGUHideLevelUI_FunctionAddress, "Unit");
		BGUHideLevelUI_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUHideLevelUI_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUHideLevelUI_IsValid = BGUHideLevelUI_FunctionAddress != IntPtr.Zero && BGUHideLevelUI_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHideLevelUI", BGUHideLevelUI_IsValid);
		IsCheatGMLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCheatGMLevel");
		IsCheatGMLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCheatGMLevel_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsCheatGMLevel_ReturnValue_PropertyAddress, IsCheatGMLevel_FunctionAddress, "ReturnValue");
		IsCheatGMLevel_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsCheatGMLevel_FunctionAddress, "ReturnValue");
		IsCheatGMLevel_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsCheatGMLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCheatGMLevel_IsValid = IsCheatGMLevel_FunctionAddress != IntPtr.Zero && IsCheatGMLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:IsCheatGMLevel", IsCheatGMLevel_IsValid);
		IsDebugGMLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsDebugGMLevel");
		IsDebugGMLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDebugGMLevel_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsDebugGMLevel_ReturnValue_PropertyAddress, IsDebugGMLevel_FunctionAddress, "ReturnValue");
		IsDebugGMLevel_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsDebugGMLevel_FunctionAddress, "ReturnValue");
		IsDebugGMLevel_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsDebugGMLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDebugGMLevel_IsValid = IsDebugGMLevel_FunctionAddress != IntPtr.Zero && IsDebugGMLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:IsDebugGMLevel", IsDebugGMLevel_IsValid);
		BGUHasUnitState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHasUnitState");
		BGUHasUnitState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHasUnitState_FunctionAddress);
		BGUHasUnitState_Unit_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitState_FunctionAddress, "Unit");
		BGUHasUnitState_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitState_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUHasUnitState_UnitState_PropertyAddress, BGUHasUnitState_FunctionAddress, "UnitState");
		BGUHasUnitState_UnitState_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitState_FunctionAddress, "UnitState");
		BGUHasUnitState_UnitState_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitState_FunctionAddress, "UnitState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUHasUnitState_ReturnValue_PropertyAddress, BGUHasUnitState_FunctionAddress, "ReturnValue");
		BGUHasUnitState_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitState_FunctionAddress, "ReturnValue");
		BGUHasUnitState_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUHasUnitState_IsValid = BGUHasUnitState_FunctionAddress != IntPtr.Zero && BGUHasUnitState_Unit_IsValid && BGUHasUnitState_UnitState_IsValid && BGUHasUnitState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitState", BGUHasUnitState_IsValid);
		SeqChangeEquip2_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SeqChangeEquip2");
		SeqChangeEquip2_ParamsSize = NativeReflection.GetFunctionParamsSize(SeqChangeEquip2_FunctionAddress);
		SeqChangeEquip2_SeqActor_Offset = NativeReflection.GetPropertyOffset(SeqChangeEquip2_FunctionAddress, "SeqActor");
		SeqChangeEquip2_SeqActor_IsValid = NativeReflection.ValidatePropertyClass(SeqChangeEquip2_FunctionAddress, "SeqActor", Classes.FObjectProperty);
		SeqChangeEquip2_IsValid = SeqChangeEquip2_FunctionAddress != IntPtr.Zero && SeqChangeEquip2_SeqActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SeqChangeEquip2", SeqChangeEquip2_IsValid);
		GlobalEventTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GlobalEventTest");
		GlobalEventTest_ParamsSize = NativeReflection.GetFunctionParamsSize(GlobalEventTest_FunctionAddress);
		GlobalEventTest_Unit_Offset = NativeReflection.GetPropertyOffset(GlobalEventTest_FunctionAddress, "Unit");
		GlobalEventTest_Unit_IsValid = NativeReflection.ValidatePropertyClass(GlobalEventTest_FunctionAddress, "Unit", Classes.FObjectProperty);
		GlobalEventTest_Times_Offset = NativeReflection.GetPropertyOffset(GlobalEventTest_FunctionAddress, "Times");
		GlobalEventTest_Times_IsValid = NativeReflection.ValidatePropertyClass(GlobalEventTest_FunctionAddress, "Times", Classes.FIntProperty);
		GlobalEventTest_IsValid = GlobalEventTest_FunctionAddress != IntPtr.Zero && GlobalEventTest_Unit_IsValid && GlobalEventTest_Times_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GlobalEventTest", GlobalEventTest_IsValid);
		GenerateGrayBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateGrayBox");
		GenerateGrayBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateGrayBox_FunctionAddress);
		GenerateGrayBox_TempleteActor_Offset = NativeReflection.GetPropertyOffset(GenerateGrayBox_FunctionAddress, "TempleteActor");
		GenerateGrayBox_TempleteActor_IsValid = NativeReflection.ValidatePropertyClass(GenerateGrayBox_FunctionAddress, "TempleteActor", Classes.FObjectProperty);
		GenerateGrayBox_IsValid = GenerateGrayBox_FunctionAddress != IntPtr.Zero && GenerateGrayBox_TempleteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateGrayBox", GenerateGrayBox_IsValid);
		BGUGetFloatAttr_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetFloatAttr");
		BGUGetFloatAttr_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetFloatAttr_FunctionAddress);
		BGUGetFloatAttr_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetFloatAttr_FunctionAddress, "Unit");
		BGUGetFloatAttr_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetFloatAttr_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUGetFloatAttr_AttrID_PropertyAddress, BGUGetFloatAttr_FunctionAddress, "AttrID");
		BGUGetFloatAttr_AttrID_Offset = NativeReflection.GetPropertyOffset(BGUGetFloatAttr_FunctionAddress, "AttrID");
		BGUGetFloatAttr_AttrID_IsValid = NativeReflection.ValidatePropertyClass(BGUGetFloatAttr_FunctionAddress, "AttrID", Classes.FEnumProperty);
		BGUGetFloatAttr_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetFloatAttr_FunctionAddress, "ReturnValue");
		BGUGetFloatAttr_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetFloatAttr_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetFloatAttr_IsValid = BGUGetFloatAttr_FunctionAddress != IntPtr.Zero && BGUGetFloatAttr_Unit_IsValid && BGUGetFloatAttr_AttrID_IsValid && BGUGetFloatAttr_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetFloatAttr", BGUGetFloatAttr_IsValid);
		SummonEventTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SummonEventTest");
		SummonEventTest_ParamsSize = NativeReflection.GetFunctionParamsSize(SummonEventTest_FunctionAddress);
		SummonEventTest_Unit_Offset = NativeReflection.GetPropertyOffset(SummonEventTest_FunctionAddress, "Unit");
		SummonEventTest_Unit_IsValid = NativeReflection.ValidatePropertyClass(SummonEventTest_FunctionAddress, "Unit", Classes.FObjectProperty);
		SummonEventTest_IsValid = SummonEventTest_FunctionAddress != IntPtr.Zero && SummonEventTest_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SummonEventTest", SummonEventTest_IsValid);
		SetSolverCenter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSolverCenter");
		SetSolverCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSolverCenter_FunctionAddress);
		SetSolverCenter_Unit_Offset = NativeReflection.GetPropertyOffset(SetSolverCenter_FunctionAddress, "Unit");
		SetSolverCenter_Unit_IsValid = NativeReflection.ValidatePropertyClass(SetSolverCenter_FunctionAddress, "Unit", Classes.FObjectProperty);
		SetSolverCenter_IsValid = SetSolverCenter_FunctionAddress != IntPtr.Zero && SetSolverCenter_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetSolverCenter", SetSolverCenter_IsValid);
		BGUGetWeaponNum_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetWeaponNum");
		BGUGetWeaponNum_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetWeaponNum_FunctionAddress);
		BGUGetWeaponNum_Unit_Offset = NativeReflection.GetPropertyOffset(BGUGetWeaponNum_FunctionAddress, "Unit");
		BGUGetWeaponNum_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUGetWeaponNum_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUGetWeaponNum_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetWeaponNum_FunctionAddress, "ReturnValue");
		BGUGetWeaponNum_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetWeaponNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetWeaponNum_IsValid = BGUGetWeaponNum_FunctionAddress != IntPtr.Zero && BGUGetWeaponNum_Unit_IsValid && BGUGetWeaponNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponNum", BGUGetWeaponNum_IsValid);
		BGUSetAttrValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetAttrValue");
		BGUSetAttrValue_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetAttrValue_FunctionAddress);
		BGUSetAttrValue_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetAttrValue_FunctionAddress, "Unit");
		BGUSetAttrValue_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetAttrValue_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetAttrValue_AttrID_PropertyAddress, BGUSetAttrValue_FunctionAddress, "AttrID");
		BGUSetAttrValue_AttrID_Offset = NativeReflection.GetPropertyOffset(BGUSetAttrValue_FunctionAddress, "AttrID");
		BGUSetAttrValue_AttrID_IsValid = NativeReflection.ValidatePropertyClass(BGUSetAttrValue_FunctionAddress, "AttrID", Classes.FEnumProperty);
		BGUSetAttrValue_TargetValue_Offset = NativeReflection.GetPropertyOffset(BGUSetAttrValue_FunctionAddress, "TargetValue");
		BGUSetAttrValue_TargetValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSetAttrValue_FunctionAddress, "TargetValue", Classes.FFloatProperty);
		BGUSetAttrValue_IsValid = BGUSetAttrValue_FunctionAddress != IntPtr.Zero && BGUSetAttrValue_Unit_IsValid && BGUSetAttrValue_AttrID_IsValid && BGUSetAttrValue_TargetValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetAttrValue", BGUSetAttrValue_IsValid);
		BGUTryCastSpell_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTryCastSpell");
		BGUTryCastSpell_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTryCastSpell_FunctionAddress);
		BGUTryCastSpell_Unit_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpell_FunctionAddress, "Unit");
		BGUTryCastSpell_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpell_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUTryCastSpell_SkillID_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpell_FunctionAddress, "SkillID");
		BGUTryCastSpell_SkillID_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpell_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUTryCastSpell_SourceType_PropertyAddress, BGUTryCastSpell_FunctionAddress, "SourceType");
		BGUTryCastSpell_SourceType_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpell_FunctionAddress, "SourceType");
		BGUTryCastSpell_SourceType_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpell_FunctionAddress, "SourceType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUTryCastSpell_IsUseComboingSection_PropertyAddress, BGUTryCastSpell_FunctionAddress, "IsUseComboingSection");
		BGUTryCastSpell_IsUseComboingSection_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpell_FunctionAddress, "IsUseComboingSection");
		BGUTryCastSpell_IsUseComboingSection_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpell_FunctionAddress, "IsUseComboingSection", Classes.FBoolProperty);
		BGUTryCastSpell_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpell_FunctionAddress, "ReturnValue");
		BGUTryCastSpell_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpell_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUTryCastSpell_IsValid = BGUTryCastSpell_FunctionAddress != IntPtr.Zero && BGUTryCastSpell_Unit_IsValid && BGUTryCastSpell_SkillID_IsValid && BGUTryCastSpell_SourceType_IsValid && BGUTryCastSpell_IsUseComboingSection_IsValid && BGUTryCastSpell_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpell", BGUTryCastSpell_IsValid);
		ToggleCloudMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ToggleCloudMove");
		ToggleCloudMove_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleCloudMove_FunctionAddress);
		ToggleCloudMove_Unit_Offset = NativeReflection.GetPropertyOffset(ToggleCloudMove_FunctionAddress, "Unit");
		ToggleCloudMove_Unit_IsValid = NativeReflection.ValidatePropertyClass(ToggleCloudMove_FunctionAddress, "Unit", Classes.FObjectProperty);
		ToggleCloudMove_IsValid = ToggleCloudMove_FunctionAddress != IntPtr.Zero && ToggleCloudMove_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ToggleCloudMove", ToggleCloudMove_IsValid);
		BGUSetImmobility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetImmobility");
		BGUSetImmobility_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetImmobility_FunctionAddress);
		BGUSetImmobility_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetImmobility_FunctionAddress, "Unit");
		BGUSetImmobility_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetImmobility_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUSetImmobility_Timer_Offset = NativeReflection.GetPropertyOffset(BGUSetImmobility_FunctionAddress, "Timer");
		BGUSetImmobility_Timer_IsValid = NativeReflection.ValidatePropertyClass(BGUSetImmobility_FunctionAddress, "Timer", Classes.FFloatProperty);
		BGUSetImmobility_IsValid = BGUSetImmobility_FunctionAddress != IntPtr.Zero && BGUSetImmobility_Unit_IsValid && BGUSetImmobility_Timer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetImmobility", BGUSetImmobility_IsValid);
		BGUStartSceneQTE_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUStartSceneQTE");
		BGUStartSceneQTE_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUStartSceneQTE_FunctionAddress);
		BGUStartSceneQTE_Unit_Offset = NativeReflection.GetPropertyOffset(BGUStartSceneQTE_FunctionAddress, "Unit");
		BGUStartSceneQTE_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUStartSceneQTE_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUStartSceneQTE_QTEID_Offset = NativeReflection.GetPropertyOffset(BGUStartSceneQTE_FunctionAddress, "QTEID");
		BGUStartSceneQTE_QTEID_IsValid = NativeReflection.ValidatePropertyClass(BGUStartSceneQTE_FunctionAddress, "QTEID", Classes.FIntProperty);
		BGUStartSceneQTE_TargetCharacter_Offset = NativeReflection.GetPropertyOffset(BGUStartSceneQTE_FunctionAddress, "TargetCharacter");
		BGUStartSceneQTE_TargetCharacter_IsValid = NativeReflection.ValidatePropertyClass(BGUStartSceneQTE_FunctionAddress, "TargetCharacter", Classes.FObjectProperty);
		BGUStartSceneQTE_IsValid = BGUStartSceneQTE_FunctionAddress != IntPtr.Zero && BGUStartSceneQTE_Unit_IsValid && BGUStartSceneQTE_QTEID_IsValid && BGUStartSceneQTE_TargetCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUStartSceneQTE", BGUStartSceneQTE_IsValid);
		BGURemoveAllBuff_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURemoveAllBuff");
		BGURemoveAllBuff_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURemoveAllBuff_FunctionAddress);
		BGURemoveAllBuff_Unit_Offset = NativeReflection.GetPropertyOffset(BGURemoveAllBuff_FunctionAddress, "Unit");
		BGURemoveAllBuff_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveAllBuff_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGURemoveAllBuff_EffectTriggerType_PropertyAddress, BGURemoveAllBuff_FunctionAddress, "EffectTriggerType");
		BGURemoveAllBuff_EffectTriggerType_Offset = NativeReflection.GetPropertyOffset(BGURemoveAllBuff_FunctionAddress, "EffectTriggerType");
		BGURemoveAllBuff_EffectTriggerType_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveAllBuff_FunctionAddress, "EffectTriggerType", Classes.FEnumProperty);
		BGURemoveAllBuff_IsValid = BGURemoveAllBuff_FunctionAddress != IntPtr.Zero && BGURemoveAllBuff_Unit_IsValid && BGURemoveAllBuff_EffectTriggerType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveAllBuff", BGURemoveAllBuff_IsValid);
		IsUEDebugGMLevel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsUEDebugGMLevel");
		IsUEDebugGMLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUEDebugGMLevel_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsUEDebugGMLevel_ReturnValue_PropertyAddress, IsUEDebugGMLevel_FunctionAddress, "ReturnValue");
		IsUEDebugGMLevel_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsUEDebugGMLevel_FunctionAddress, "ReturnValue");
		IsUEDebugGMLevel_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsUEDebugGMLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUEDebugGMLevel_IsValid = IsUEDebugGMLevel_FunctionAddress != IntPtr.Zero && IsUEDebugGMLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:IsUEDebugGMLevel", IsUEDebugGMLevel_IsValid);
		ResetPhysSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ResetPhysSetting");
		ResetPhysSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetPhysSetting_FunctionAddress);
		ResetPhysSetting_Actor_Offset = NativeReflection.GetPropertyOffset(ResetPhysSetting_FunctionAddress, "Actor");
		ResetPhysSetting_Actor_IsValid = NativeReflection.ValidatePropertyClass(ResetPhysSetting_FunctionAddress, "Actor", Classes.FObjectProperty);
		ResetPhysSetting_IsValid = ResetPhysSetting_FunctionAddress != IntPtr.Zero && ResetPhysSetting_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ResetPhysSetting", ResetPhysSetting_IsValid);
		BGUShowDialogueUI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUShowDialogueUI");
		BGUShowDialogueUI_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUShowDialogueUI_FunctionAddress);
		BGUShowDialogueUI_Unit_Offset = NativeReflection.GetPropertyOffset(BGUShowDialogueUI_FunctionAddress, "Unit");
		BGUShowDialogueUI_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUShowDialogueUI_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUShowDialogueUI_DialogContent_PropertyAddress, BGUShowDialogueUI_FunctionAddress, "DialogContent");
		BGUShowDialogueUI_DialogContent_Offset = NativeReflection.GetPropertyOffset(BGUShowDialogueUI_FunctionAddress, "DialogContent");
		BGUShowDialogueUI_DialogContent_IsValid = NativeReflection.ValidatePropertyClass(BGUShowDialogueUI_FunctionAddress, "DialogContent", Classes.FStrProperty);
		BGUShowDialogueUI_Duration_Offset = NativeReflection.GetPropertyOffset(BGUShowDialogueUI_FunctionAddress, "Duration");
		BGUShowDialogueUI_Duration_IsValid = NativeReflection.ValidatePropertyClass(BGUShowDialogueUI_FunctionAddress, "Duration", Classes.FFloatProperty);
		BGUShowDialogueUI_IsValid = BGUShowDialogueUI_FunctionAddress != IntPtr.Zero && BGUShowDialogueUI_Unit_IsValid && BGUShowDialogueUI_DialogContent_IsValid && BGUShowDialogueUI_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUShowDialogueUI", BGUShowDialogueUI_IsValid);
		SetTrainDummyInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTrainDummyInfo");
		SetTrainDummyInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrainDummyInfo_FunctionAddress);
		SetTrainDummyInfo_WorldContext_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "WorldContext");
		SetTrainDummyInfo_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetTrainDummyInfo_TrainDummyClassPath_PropertyAddress, SetTrainDummyInfo_FunctionAddress, "TrainDummyClassPath");
		SetTrainDummyInfo_TrainDummyClassPath_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "TrainDummyClassPath");
		SetTrainDummyInfo_TrainDummyClassPath_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "TrainDummyClassPath", Classes.FStrProperty);
		SetTrainDummyInfo_PlayerRoleDataConfigID_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "PlayerRoleDataConfigID");
		SetTrainDummyInfo_PlayerRoleDataConfigID_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "PlayerRoleDataConfigID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SetTrainDummyInfo_TrainDummyConfigPath_PropertyAddress, SetTrainDummyInfo_FunctionAddress, "TrainDummyConfigPath");
		SetTrainDummyInfo_TrainDummyConfigPath_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "TrainDummyConfigPath");
		SetTrainDummyInfo_TrainDummyConfigPath_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "TrainDummyConfigPath", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref SetTrainDummyInfo_CqgPath_PropertyAddress, SetTrainDummyInfo_FunctionAddress, "CqgPath");
		SetTrainDummyInfo_CqgPath_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "CqgPath");
		SetTrainDummyInfo_CqgPath_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "CqgPath", Classes.FStrProperty);
		SetTrainDummyInfo_DPSCalTime_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "DPSCalTime");
		SetTrainDummyInfo_DPSCalTime_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "DPSCalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SetTrainDummyInfo_ReturnValue_PropertyAddress, SetTrainDummyInfo_FunctionAddress, "ReturnValue");
		SetTrainDummyInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SetTrainDummyInfo_FunctionAddress, "ReturnValue");
		SetTrainDummyInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SetTrainDummyInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetTrainDummyInfo_IsValid = SetTrainDummyInfo_FunctionAddress != IntPtr.Zero && SetTrainDummyInfo_WorldContext_IsValid && SetTrainDummyInfo_TrainDummyClassPath_IsValid && SetTrainDummyInfo_PlayerRoleDataConfigID_IsValid && SetTrainDummyInfo_TrainDummyConfigPath_IsValid && SetTrainDummyInfo_CqgPath_IsValid && SetTrainDummyInfo_DPSCalTime_IsValid && SetTrainDummyInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetTrainDummyInfo", SetTrainDummyInfo_IsValid);
		BGUUnitEquipFaBao_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUUnitEquipFaBao");
		BGUUnitEquipFaBao_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnitEquipFaBao_FunctionAddress);
		BGUUnitEquipFaBao_Unit_Offset = NativeReflection.GetPropertyOffset(BGUUnitEquipFaBao_FunctionAddress, "Unit");
		BGUUnitEquipFaBao_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUUnitEquipFaBao_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUUnitEquipFaBao_FaBaoID_Offset = NativeReflection.GetPropertyOffset(BGUUnitEquipFaBao_FunctionAddress, "FaBaoID");
		BGUUnitEquipFaBao_FaBaoID_IsValid = NativeReflection.ValidatePropertyClass(BGUUnitEquipFaBao_FunctionAddress, "FaBaoID", Classes.FIntProperty);
		BGUUnitEquipFaBao_IsValid = BGUUnitEquipFaBao_FunctionAddress != IntPtr.Zero && BGUUnitEquipFaBao_Unit_IsValid && BGUUnitEquipFaBao_FaBaoID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitEquipFaBao", BGUUnitEquipFaBao_IsValid);
		SwitchCameraGroup_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchCameraGroup");
		SwitchCameraGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchCameraGroup_FunctionAddress);
		SwitchCameraGroup_WorldContext_Offset = NativeReflection.GetPropertyOffset(SwitchCameraGroup_FunctionAddress, "WorldContext");
		SwitchCameraGroup_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(SwitchCameraGroup_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		SwitchCameraGroup_CameraGroupID_Offset = NativeReflection.GetPropertyOffset(SwitchCameraGroup_FunctionAddress, "CameraGroupID");
		SwitchCameraGroup_CameraGroupID_IsValid = NativeReflection.ValidatePropertyClass(SwitchCameraGroup_FunctionAddress, "CameraGroupID", Classes.FIntProperty);
		SwitchCameraGroup_IsValid = SwitchCameraGroup_FunctionAddress != IntPtr.Zero && SwitchCameraGroup_WorldContext_IsValid && SwitchCameraGroup_CameraGroupID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchCameraGroup", SwitchCameraGroup_IsValid);
		BGUPlayLockTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlayLockTarget");
		BGUPlayLockTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayLockTarget_FunctionAddress);
		BGUPlayLockTarget_Owner_Offset = NativeReflection.GetPropertyOffset(BGUPlayLockTarget_FunctionAddress, "Owner");
		BGUPlayLockTarget_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayLockTarget_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUPlayLockTarget_TargetChr_Offset = NativeReflection.GetPropertyOffset(BGUPlayLockTarget_FunctionAddress, "TargetChr");
		BGUPlayLockTarget_TargetChr_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayLockTarget_FunctionAddress, "TargetChr", Classes.FObjectProperty);
		BGUPlayLockTarget_IsValid = BGUPlayLockTarget_FunctionAddress != IntPtr.Zero && BGUPlayLockTarget_Owner_IsValid && BGUPlayLockTarget_TargetChr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayLockTarget", BGUPlayLockTarget_IsValid);
		BGUAISetSpeedRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUAISetSpeedRate");
		BGUAISetSpeedRate_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUAISetSpeedRate_FunctionAddress);
		BGUAISetSpeedRate_Unit_Offset = NativeReflection.GetPropertyOffset(BGUAISetSpeedRate_FunctionAddress, "Unit");
		BGUAISetSpeedRate_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetSpeedRate_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUAISetSpeedRate_SpeedRate_Offset = NativeReflection.GetPropertyOffset(BGUAISetSpeedRate_FunctionAddress, "SpeedRate");
		BGUAISetSpeedRate_SpeedRate_IsValid = NativeReflection.ValidatePropertyClass(BGUAISetSpeedRate_FunctionAddress, "SpeedRate", Classes.FFloatProperty);
		BGUAISetSpeedRate_IsValid = BGUAISetSpeedRate_FunctionAddress != IntPtr.Zero && BGUAISetSpeedRate_Unit_IsValid && BGUAISetSpeedRate_SpeedRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUAISetSpeedRate", BGUAISetSpeedRate_IsValid);
		TimeLineNoiseTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TimeLineNoiseTest");
		TimeLineNoiseTest_ParamsSize = NativeReflection.GetFunctionParamsSize(TimeLineNoiseTest_FunctionAddress);
		TimeLineNoiseTest_TotalTime_Offset = NativeReflection.GetPropertyOffset(TimeLineNoiseTest_FunctionAddress, "TotalTime");
		TimeLineNoiseTest_TotalTime_IsValid = NativeReflection.ValidatePropertyClass(TimeLineNoiseTest_FunctionAddress, "TotalTime", Classes.FFloatProperty);
		TimeLineNoiseTest_TimePointNum_Offset = NativeReflection.GetPropertyOffset(TimeLineNoiseTest_FunctionAddress, "TimePointNum");
		TimeLineNoiseTest_TimePointNum_IsValid = NativeReflection.ValidatePropertyClass(TimeLineNoiseTest_FunctionAddress, "TimePointNum", Classes.FIntProperty);
		TimeLineNoiseTest_NoiseInterregional_Offset = NativeReflection.GetPropertyOffset(TimeLineNoiseTest_FunctionAddress, "NoiseInterregional");
		TimeLineNoiseTest_NoiseInterregional_IsValid = NativeReflection.ValidatePropertyClass(TimeLineNoiseTest_FunctionAddress, "NoiseInterregional", Classes.FFloatProperty);
		TimeLineNoiseTest_CurveFloat_Offset = NativeReflection.GetPropertyOffset(TimeLineNoiseTest_FunctionAddress, "CurveFloat");
		TimeLineNoiseTest_CurveFloat_IsValid = NativeReflection.ValidatePropertyClass(TimeLineNoiseTest_FunctionAddress, "CurveFloat", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TimeLineNoiseTest_InterpMode_PropertyAddress, TimeLineNoiseTest_FunctionAddress, "InterpMode");
		TimeLineNoiseTest_InterpMode_Offset = NativeReflection.GetPropertyOffset(TimeLineNoiseTest_FunctionAddress, "InterpMode");
		TimeLineNoiseTest_InterpMode_IsValid = NativeReflection.ValidatePropertyClass(TimeLineNoiseTest_FunctionAddress, "InterpMode", Classes.FEnumProperty);
		TimeLineNoiseTest_IsValid = TimeLineNoiseTest_FunctionAddress != IntPtr.Zero && TimeLineNoiseTest_TotalTime_IsValid && TimeLineNoiseTest_TimePointNum_IsValid && TimeLineNoiseTest_NoiseInterregional_IsValid && TimeLineNoiseTest_CurveFloat_IsValid && TimeLineNoiseTest_InterpMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TimeLineNoiseTest", TimeLineNoiseTest_IsValid);
		BGUFullTransEnergy_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUFullTransEnergy");
		BGUFullTransEnergy_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUFullTransEnergy_FunctionAddress);
		BGUFullTransEnergy_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUFullTransEnergy_FunctionAddress, "WorldContext");
		BGUFullTransEnergy_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUFullTransEnergy_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BGUFullTransEnergy_IsValid = BGUFullTransEnergy_FunctionAddress != IntPtr.Zero && BGUFullTransEnergy_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUFullTransEnergy", BGUFullTransEnergy_IsValid);
		InteruptPigsyStory_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InteruptPigsyStory");
		InteruptPigsyStory_ParamsSize = NativeReflection.GetFunctionParamsSize(InteruptPigsyStory_FunctionAddress);
		InteruptPigsyStory_Unit_Offset = NativeReflection.GetPropertyOffset(InteruptPigsyStory_FunctionAddress, "Unit");
		InteruptPigsyStory_Unit_IsValid = NativeReflection.ValidatePropertyClass(InteruptPigsyStory_FunctionAddress, "Unit", Classes.FObjectProperty);
		InteruptPigsyStory_IsValid = InteruptPigsyStory_FunctionAddress != IntPtr.Zero && InteruptPigsyStory_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:InteruptPigsyStory", InteruptPigsyStory_IsValid);
		PlayFacialAnimTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayFacialAnimTest");
		PlayFacialAnimTest_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayFacialAnimTest_FunctionAddress);
		NativeReflection.GetPropertyRef(ref PlayFacialAnimTest_bPlay_PropertyAddress, PlayFacialAnimTest_FunctionAddress, "bPlay");
		PlayFacialAnimTest_bPlay_Offset = NativeReflection.GetPropertyOffset(PlayFacialAnimTest_FunctionAddress, "bPlay");
		PlayFacialAnimTest_bPlay_IsValid = NativeReflection.ValidatePropertyClass(PlayFacialAnimTest_FunctionAddress, "bPlay", Classes.FBoolProperty);
		PlayFacialAnimTest_Unit_Offset = NativeReflection.GetPropertyOffset(PlayFacialAnimTest_FunctionAddress, "Unit");
		PlayFacialAnimTest_Unit_IsValid = NativeReflection.ValidatePropertyClass(PlayFacialAnimTest_FunctionAddress, "Unit", Classes.FObjectProperty);
		PlayFacialAnimTest_FacialAnim_Offset = NativeReflection.GetPropertyOffset(PlayFacialAnimTest_FunctionAddress, "FacialAnim");
		PlayFacialAnimTest_FacialAnim_IsValid = NativeReflection.ValidatePropertyClass(PlayFacialAnimTest_FunctionAddress, "FacialAnim", Classes.FObjectProperty);
		PlayFacialAnimTest_TimeOffset_Offset = NativeReflection.GetPropertyOffset(PlayFacialAnimTest_FunctionAddress, "TimeOffset");
		PlayFacialAnimTest_TimeOffset_IsValid = NativeReflection.ValidatePropertyClass(PlayFacialAnimTest_FunctionAddress, "TimeOffset", Classes.FFloatProperty);
		PlayFacialAnimTest_AutoBlendOutTime_Offset = NativeReflection.GetPropertyOffset(PlayFacialAnimTest_FunctionAddress, "AutoBlendOutTime");
		PlayFacialAnimTest_AutoBlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(PlayFacialAnimTest_FunctionAddress, "AutoBlendOutTime", Classes.FFloatProperty);
		PlayFacialAnimTest_IsValid = PlayFacialAnimTest_FunctionAddress != IntPtr.Zero && PlayFacialAnimTest_bPlay_IsValid && PlayFacialAnimTest_Unit_IsValid && PlayFacialAnimTest_FacialAnim_IsValid && PlayFacialAnimTest_TimeOffset_IsValid && PlayFacialAnimTest_AutoBlendOutTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PlayFacialAnimTest", PlayFacialAnimTest_IsValid);
		KJLSpawnProjectile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "KJLSpawnProjectile");
		KJLSpawnProjectile_ParamsSize = NativeReflection.GetFunctionParamsSize(KJLSpawnProjectile_FunctionAddress);
		KJLSpawnProjectile_BulletSpawner_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "BulletSpawner");
		KJLSpawnProjectile_BulletSpawner_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "BulletSpawner", Classes.FObjectProperty);
		KJLSpawnProjectile_Target_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "Target");
		KJLSpawnProjectile_Target_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref KJLSpawnProjectile_PointGeneratorTag_PropertyAddress, KJLSpawnProjectile_FunctionAddress, "PointGeneratorTag");
		KJLSpawnProjectile_PointGeneratorTag_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "PointGeneratorTag");
		KJLSpawnProjectile_PointGeneratorTag_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "PointGeneratorTag", Classes.FStrProperty);
		KJLSpawnProjectile_BulletID_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "BulletID");
		KJLSpawnProjectile_BulletID_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "BulletID", Classes.FIntProperty);
		KJLSpawnProjectile_LimitDistance_ToPlayer_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "LimitDistance_ToPlayer");
		KJLSpawnProjectile_LimitDistance_ToPlayer_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "LimitDistance_ToPlayer", Classes.FFloatProperty);
		KJLSpawnProjectile_LightningBeam_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "LightningBeam");
		KJLSpawnProjectile_LightningBeam_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "LightningBeam", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref KJLSpawnProjectile_LightningEndParamName_PropertyAddress, KJLSpawnProjectile_FunctionAddress, "LightningEndParamName");
		KJLSpawnProjectile_LightningEndParamName_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "LightningEndParamName");
		KJLSpawnProjectile_LightningEndParamName_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "LightningEndParamName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref KJLSpawnProjectile_SocketList_PropertyAddress, KJLSpawnProjectile_FunctionAddress, "SocketList");
		KJLSpawnProjectile_SocketList_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "SocketList");
		KJLSpawnProjectile_SocketList_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "SocketList", Classes.FArrayProperty);
		KJLSpawnProjectile_DummyBulletNum_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "DummyBulletNum");
		KJLSpawnProjectile_DummyBulletNum_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "DummyBulletNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref KJLSpawnProjectile_EndPos_Noise_PropertyAddress, KJLSpawnProjectile_FunctionAddress, "EndPos_Noise");
		KJLSpawnProjectile_EndPos_Noise_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "EndPos_Noise");
		KJLSpawnProjectile_EndPos_Noise_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "EndPos_Noise", Classes.FStructProperty);
		KJLSpawnProjectile_DummyNiagara_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "DummyNiagara");
		KJLSpawnProjectile_DummyNiagara_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "DummyNiagara", Classes.FObjectProperty);
		KJLSpawnProjectile_DummyActiveDistance_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "DummyActiveDistance");
		KJLSpawnProjectile_DummyActiveDistance_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "DummyActiveDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref KJLSpawnProjectile_RandomInterval_PropertyAddress, KJLSpawnProjectile_FunctionAddress, "RandomInterval");
		KJLSpawnProjectile_RandomInterval_Offset = NativeReflection.GetPropertyOffset(KJLSpawnProjectile_FunctionAddress, "RandomInterval");
		KJLSpawnProjectile_RandomInterval_IsValid = NativeReflection.ValidatePropertyClass(KJLSpawnProjectile_FunctionAddress, "RandomInterval", Classes.FStructProperty);
		KJLSpawnProjectile_IsValid = KJLSpawnProjectile_FunctionAddress != IntPtr.Zero && KJLSpawnProjectile_BulletSpawner_IsValid && KJLSpawnProjectile_Target_IsValid && KJLSpawnProjectile_PointGeneratorTag_IsValid && KJLSpawnProjectile_BulletID_IsValid && KJLSpawnProjectile_LimitDistance_ToPlayer_IsValid && KJLSpawnProjectile_LightningBeam_IsValid && KJLSpawnProjectile_LightningEndParamName_IsValid && KJLSpawnProjectile_SocketList_IsValid && KJLSpawnProjectile_DummyBulletNum_IsValid && KJLSpawnProjectile_EndPos_Noise_IsValid && KJLSpawnProjectile_DummyNiagara_IsValid && KJLSpawnProjectile_DummyActiveDistance_IsValid && KJLSpawnProjectile_RandomInterval_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:KJLSpawnProjectile", KJLSpawnProjectile_IsValid);
		BGUSetBehaviorTree_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetBehaviorTree");
		BGUSetBehaviorTree_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetBehaviorTree_FunctionAddress);
		BGUSetBehaviorTree_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetBehaviorTree_FunctionAddress, "Unit");
		BGUSetBehaviorTree_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetBehaviorTree_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUSetBehaviorTree_BT_Offset = NativeReflection.GetPropertyOffset(BGUSetBehaviorTree_FunctionAddress, "BT");
		BGUSetBehaviorTree_BT_IsValid = NativeReflection.ValidatePropertyClass(BGUSetBehaviorTree_FunctionAddress, "BT", Classes.FObjectProperty);
		BGUSetBehaviorTree_IsValid = BGUSetBehaviorTree_FunctionAddress != IntPtr.Zero && BGUSetBehaviorTree_Unit_IsValid && BGUSetBehaviorTree_BT_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetBehaviorTree", BGUSetBehaviorTree_IsValid);
		BGUSpawnGhostActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSpawnGhostActor");
		BGUSpawnGhostActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSpawnGhostActor_FunctionAddress);
		BGUSpawnGhostActor_Target_Offset = NativeReflection.GetPropertyOffset(BGUSpawnGhostActor_FunctionAddress, "Target");
		BGUSpawnGhostActor_Target_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnGhostActor_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSpawnGhostActor_DAPath_PropertyAddress, BGUSpawnGhostActor_FunctionAddress, "DAPath");
		BGUSpawnGhostActor_DAPath_Offset = NativeReflection.GetPropertyOffset(BGUSpawnGhostActor_FunctionAddress, "DAPath");
		BGUSpawnGhostActor_DAPath_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnGhostActor_FunctionAddress, "DAPath", Classes.FStrProperty);
		BGUSpawnGhostActor_IsValid = BGUSpawnGhostActor_FunctionAddress != IntPtr.Zero && BGUSpawnGhostActor_Target_IsValid && BGUSpawnGhostActor_DAPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnGhostActor", BGUSpawnGhostActor_IsValid);
		SwitchLanguageEnZh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchLanguageEnZh");
		SwitchLanguageEnZh_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchLanguageEnZh_FunctionAddress);
		SwitchLanguageEnZh_IsValid = SwitchLanguageEnZh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchLanguageEnZh", SwitchLanguageEnZh_IsValid);
		BGUToggleGlobalURO_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUToggleGlobalURO");
		BGUToggleGlobalURO_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUToggleGlobalURO_FunctionAddress);
		BGUToggleGlobalURO_UObj_Offset = NativeReflection.GetPropertyOffset(BGUToggleGlobalURO_FunctionAddress, "UObj");
		BGUToggleGlobalURO_UObj_IsValid = NativeReflection.ValidatePropertyClass(BGUToggleGlobalURO_FunctionAddress, "UObj", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUToggleGlobalURO_bEnable_PropertyAddress, BGUToggleGlobalURO_FunctionAddress, "bEnable");
		BGUToggleGlobalURO_bEnable_Offset = NativeReflection.GetPropertyOffset(BGUToggleGlobalURO_FunctionAddress, "bEnable");
		BGUToggleGlobalURO_bEnable_IsValid = NativeReflection.ValidatePropertyClass(BGUToggleGlobalURO_FunctionAddress, "bEnable", Classes.FBoolProperty);
		BGUToggleGlobalURO_IsValid = BGUToggleGlobalURO_FunctionAddress != IntPtr.Zero && BGUToggleGlobalURO_UObj_IsValid && BGUToggleGlobalURO_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUToggleGlobalURO", BGUToggleGlobalURO_IsValid);
		BGURemoveImmobility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURemoveImmobility");
		BGURemoveImmobility_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURemoveImmobility_FunctionAddress);
		BGURemoveImmobility_Unit_Offset = NativeReflection.GetPropertyOffset(BGURemoveImmobility_FunctionAddress, "Unit");
		BGURemoveImmobility_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveImmobility_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURemoveImmobility_IsValid = BGURemoveImmobility_FunctionAddress != IntPtr.Zero && BGURemoveImmobility_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveImmobility", BGURemoveImmobility_IsValid);
		BGUTriggerUnitState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTriggerUnitState");
		BGUTriggerUnitState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTriggerUnitState_FunctionAddress);
		BGUTriggerUnitState_Actor_Offset = NativeReflection.GetPropertyOffset(BGUTriggerUnitState_FunctionAddress, "Actor");
		BGUTriggerUnitState_Actor_IsValid = NativeReflection.ValidatePropertyClass(BGUTriggerUnitState_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUTriggerUnitState_StateTrigger_PropertyAddress, BGUTriggerUnitState_FunctionAddress, "StateTrigger");
		BGUTriggerUnitState_StateTrigger_Offset = NativeReflection.GetPropertyOffset(BGUTriggerUnitState_FunctionAddress, "StateTrigger");
		BGUTriggerUnitState_StateTrigger_IsValid = NativeReflection.ValidatePropertyClass(BGUTriggerUnitState_FunctionAddress, "StateTrigger", Classes.FEnumProperty);
		BGUTriggerUnitState_Time_Offset = NativeReflection.GetPropertyOffset(BGUTriggerUnitState_FunctionAddress, "Time");
		BGUTriggerUnitState_Time_IsValid = NativeReflection.ValidatePropertyClass(BGUTriggerUnitState_FunctionAddress, "Time", Classes.FFloatProperty);
		BGUTriggerUnitState_IsValid = BGUTriggerUnitState_FunctionAddress != IntPtr.Zero && BGUTriggerUnitState_Actor_IsValid && BGUTriggerUnitState_StateTrigger_IsValid && BGUTriggerUnitState_Time_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTriggerUnitState", BGUTriggerUnitState_IsValid);
		DisablePhysicalMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DisablePhysicalMove");
		DisablePhysicalMove_ParamsSize = NativeReflection.GetFunctionParamsSize(DisablePhysicalMove_FunctionAddress);
		DisablePhysicalMove_Unit_Offset = NativeReflection.GetPropertyOffset(DisablePhysicalMove_FunctionAddress, "Unit");
		DisablePhysicalMove_Unit_IsValid = NativeReflection.ValidatePropertyClass(DisablePhysicalMove_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DisablePhysicalMove_bDisable_PropertyAddress, DisablePhysicalMove_FunctionAddress, "bDisable");
		DisablePhysicalMove_bDisable_Offset = NativeReflection.GetPropertyOffset(DisablePhysicalMove_FunctionAddress, "bDisable");
		DisablePhysicalMove_bDisable_IsValid = NativeReflection.ValidatePropertyClass(DisablePhysicalMove_FunctionAddress, "bDisable", Classes.FBoolProperty);
		DisablePhysicalMove_IsValid = DisablePhysicalMove_FunctionAddress != IntPtr.Zero && DisablePhysicalMove_Unit_IsValid && DisablePhysicalMove_bDisable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:DisablePhysicalMove", DisablePhysicalMove_IsValid);
		BGUUnitUnequipFaBao_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUUnitUnequipFaBao");
		BGUUnitUnequipFaBao_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnitUnequipFaBao_FunctionAddress);
		BGUUnitUnequipFaBao_Unit_Offset = NativeReflection.GetPropertyOffset(BGUUnitUnequipFaBao_FunctionAddress, "Unit");
		BGUUnitUnequipFaBao_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUUnitUnequipFaBao_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUUnitUnequipFaBao_IsValid = BGUUnitUnequipFaBao_FunctionAddress != IntPtr.Zero && BGUUnitUnequipFaBao_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitUnequipFaBao", BGUUnitUnequipFaBao_IsValid);
		FindTraceStatResult_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindTraceStatResult");
		FindTraceStatResult_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTraceStatResult_FunctionAddress);
		FindTraceStatResult_WorldContext_Offset = NativeReflection.GetPropertyOffset(FindTraceStatResult_FunctionAddress, "WorldContext");
		FindTraceStatResult_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(FindTraceStatResult_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref FindTraceStatResult_Name_PropertyAddress, FindTraceStatResult_FunctionAddress, "Name");
		FindTraceStatResult_Name_Offset = NativeReflection.GetPropertyOffset(FindTraceStatResult_FunctionAddress, "Name");
		FindTraceStatResult_Name_IsValid = NativeReflection.ValidatePropertyClass(FindTraceStatResult_FunctionAddress, "Name", Classes.FStrProperty);
		FindTraceStatResult_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindTraceStatResult_FunctionAddress, "ReturnValue");
		FindTraceStatResult_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindTraceStatResult_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		FindTraceStatResult_IsValid = FindTraceStatResult_FunctionAddress != IntPtr.Zero && FindTraceStatResult_WorldContext_IsValid && FindTraceStatResult_Name_IsValid && FindTraceStatResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:FindTraceStatResult", FindTraceStatResult_IsValid);
		BGUGetWeaponByIndex_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetWeaponByIndex");
		BGUGetWeaponByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetWeaponByIndex_FunctionAddress);
		BGUGetWeaponByIndex_Owner_Offset = NativeReflection.GetPropertyOffset(BGUGetWeaponByIndex_FunctionAddress, "Owner");
		BGUGetWeaponByIndex_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUGetWeaponByIndex_FunctionAddress, "Owner", Classes.FObjectProperty);
		BGUGetWeaponByIndex_index_Offset = NativeReflection.GetPropertyOffset(BGUGetWeaponByIndex_FunctionAddress, "index");
		BGUGetWeaponByIndex_index_IsValid = NativeReflection.ValidatePropertyClass(BGUGetWeaponByIndex_FunctionAddress, "index", Classes.FIntProperty);
		BGUGetWeaponByIndex_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetWeaponByIndex_FunctionAddress, "ReturnValue");
		BGUGetWeaponByIndex_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetWeaponByIndex_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetWeaponByIndex_IsValid = BGUGetWeaponByIndex_FunctionAddress != IntPtr.Zero && BGUGetWeaponByIndex_Owner_IsValid && BGUGetWeaponByIndex_index_IsValid && BGUGetWeaponByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetWeaponByIndex", BGUGetWeaponByIndex_IsValid);
		BGUSetSecondFogData_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetSecondFogData");
		BGUSetSecondFogData_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetSecondFogData_FunctionAddress);
		BGUSetSecondFogData_ehfcomp_Offset = NativeReflection.GetPropertyOffset(BGUSetSecondFogData_FunctionAddress, "ehfcomp");
		BGUSetSecondFogData_ehfcomp_IsValid = NativeReflection.ValidatePropertyClass(BGUSetSecondFogData_FunctionAddress, "ehfcomp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetSecondFogData_SecondFogData_PropertyAddress, BGUSetSecondFogData_FunctionAddress, "SecondFogData");
		BGUSetSecondFogData_SecondFogData_Offset = NativeReflection.GetPropertyOffset(BGUSetSecondFogData_FunctionAddress, "SecondFogData");
		BGUSetSecondFogData_SecondFogData_IsValid = NativeReflection.ValidatePropertyClass(BGUSetSecondFogData_FunctionAddress, "SecondFogData", Classes.FStructProperty);
		BGUSetSecondFogData_IsValid = BGUSetSecondFogData_FunctionAddress != IntPtr.Zero && BGUSetSecondFogData_ehfcomp_IsValid && BGUSetSecondFogData_SecondFogData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSecondFogData", BGUSetSecondFogData_IsValid);
		SkipCurrentSequence_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SkipCurrentSequence");
		SkipCurrentSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SkipCurrentSequence_FunctionAddress);
		SkipCurrentSequence_WorldContext_Offset = NativeReflection.GetPropertyOffset(SkipCurrentSequence_FunctionAddress, "WorldContext");
		SkipCurrentSequence_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(SkipCurrentSequence_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		SkipCurrentSequence_IsValid = SkipCurrentSequence_FunctionAddress != IntPtr.Zero && SkipCurrentSequence_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SkipCurrentSequence", SkipCurrentSequence_IsValid);
		ClearPhysAnimSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClearPhysAnimSetting");
		ClearPhysAnimSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearPhysAnimSetting_FunctionAddress);
		ClearPhysAnimSetting_Unit_Offset = NativeReflection.GetPropertyOffset(ClearPhysAnimSetting_FunctionAddress, "Unit");
		ClearPhysAnimSetting_Unit_IsValid = NativeReflection.ValidatePropertyClass(ClearPhysAnimSetting_FunctionAddress, "Unit", Classes.FObjectProperty);
		ClearPhysAnimSetting_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ClearPhysAnimSetting_FunctionAddress, "ReturnValue");
		ClearPhysAnimSetting_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ClearPhysAnimSetting_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ClearPhysAnimSetting_IsValid = ClearPhysAnimSetting_FunctionAddress != IntPtr.Zero && ClearPhysAnimSetting_Unit_IsValid && ClearPhysAnimSetting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ClearPhysAnimSetting", ClearPhysAnimSetting_IsValid);
		BGUPlatformPatroMove_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlatformPatroMove");
		BGUPlatformPatroMove_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlatformPatroMove_FunctionAddress);
		BGUPlatformPatroMove_Unit_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMove_FunctionAddress, "Unit");
		BGUPlatformPatroMove_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMove_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUPlatformPatroMove_BeginPos_PropertyAddress, BGUPlatformPatroMove_FunctionAddress, "BeginPos");
		BGUPlatformPatroMove_BeginPos_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMove_FunctionAddress, "BeginPos");
		BGUPlatformPatroMove_BeginPos_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMove_FunctionAddress, "BeginPos", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUPlatformPatroMove_EndPos_PropertyAddress, BGUPlatformPatroMove_FunctionAddress, "EndPos");
		BGUPlatformPatroMove_EndPos_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMove_FunctionAddress, "EndPos");
		BGUPlatformPatroMove_EndPos_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMove_FunctionAddress, "EndPos", Classes.FStructProperty);
		BGUPlatformPatroMove_Speed_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMove_FunctionAddress, "Speed");
		BGUPlatformPatroMove_Speed_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMove_FunctionAddress, "Speed", Classes.FFloatProperty);
		BGUPlatformPatroMove_IsValid = BGUPlatformPatroMove_FunctionAddress != IntPtr.Zero && BGUPlatformPatroMove_Unit_IsValid && BGUPlatformPatroMove_BeginPos_IsValid && BGUPlatformPatroMove_EndPos_IsValid && BGUPlatformPatroMove_Speed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMove", BGUPlatformPatroMove_IsValid);
		BGUPlatformPatroRota_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlatformPatroRota");
		BGUPlatformPatroRota_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlatformPatroRota_FunctionAddress);
		BGUPlatformPatroRota_Unit_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroRota_FunctionAddress, "Unit");
		BGUPlatformPatroRota_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroRota_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUPlatformPatroRota_MaxRate_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroRota_FunctionAddress, "MaxRate");
		BGUPlatformPatroRota_MaxRate_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroRota_FunctionAddress, "MaxRate", Classes.FIntProperty);
		BGUPlatformPatroRota_Speed_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroRota_FunctionAddress, "Speed");
		BGUPlatformPatroRota_Speed_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroRota_FunctionAddress, "Speed", Classes.FFloatProperty);
		BGUPlatformPatroRota_IsValid = BGUPlatformPatroRota_FunctionAddress != IntPtr.Zero && BGUPlatformPatroRota_Unit_IsValid && BGUPlatformPatroRota_MaxRate_IsValid && BGUPlatformPatroRota_Speed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroRota", BGUPlatformPatroRota_IsValid);
		ExitWeakPerformState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExitWeakPerformState");
		ExitWeakPerformState_ParamsSize = NativeReflection.GetFunctionParamsSize(ExitWeakPerformState_FunctionAddress);
		ExitWeakPerformState_InWorldContext_Offset = NativeReflection.GetPropertyOffset(ExitWeakPerformState_FunctionAddress, "InWorldContext");
		ExitWeakPerformState_InWorldContext_IsValid = NativeReflection.ValidatePropertyClass(ExitWeakPerformState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		ExitWeakPerformState_IsValid = ExitWeakPerformState_FunctionAddress != IntPtr.Zero && ExitWeakPerformState_InWorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExitWeakPerformState", ExitWeakPerformState_IsValid);
		BGUGetCachedPointSet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetCachedPointSet");
		BGUGetCachedPointSet_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCachedPointSet_FunctionAddress);
		BGUGetCachedPointSet_OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(BGUGetCachedPointSet_FunctionAddress, "OwnerCharacter");
		BGUGetCachedPointSet_OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCachedPointSet_FunctionAddress, "OwnerCharacter", Classes.FObjectProperty);
		BGUGetCachedPointSet_RequestID_Offset = NativeReflection.GetPropertyOffset(BGUGetCachedPointSet_FunctionAddress, "RequestID");
		BGUGetCachedPointSet_RequestID_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCachedPointSet_FunctionAddress, "RequestID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUGetCachedPointSet_ReturnValue_PropertyAddress, BGUGetCachedPointSet_FunctionAddress, "ReturnValue");
		BGUGetCachedPointSet_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetCachedPointSet_FunctionAddress, "ReturnValue");
		BGUGetCachedPointSet_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCachedPointSet_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BGUGetCachedPointSet_IsValid = BGUGetCachedPointSet_FunctionAddress != IntPtr.Zero && BGUGetCachedPointSet_OwnerCharacter_IsValid && BGUGetCachedPointSet_RequestID_IsValid && BGUGetCachedPointSet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCachedPointSet", BGUGetCachedPointSet_IsValid);
		DestroyAllProjectile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DestroyAllProjectile");
		DestroyAllProjectile_ParamsSize = NativeReflection.GetFunctionParamsSize(DestroyAllProjectile_FunctionAddress);
		DestroyAllProjectile_Unit_Offset = NativeReflection.GetPropertyOffset(DestroyAllProjectile_FunctionAddress, "Unit");
		DestroyAllProjectile_Unit_IsValid = NativeReflection.ValidatePropertyClass(DestroyAllProjectile_FunctionAddress, "Unit", Classes.FObjectProperty);
		DestroyAllProjectile_IsValid = DestroyAllProjectile_FunctionAddress != IntPtr.Zero && DestroyAllProjectile_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:DestroyAllProjectile", DestroyAllProjectile_IsValid);
		SwitchFreeCameraMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SwitchFreeCameraMode");
		SwitchFreeCameraMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SwitchFreeCameraMode_FunctionAddress);
		SwitchFreeCameraMode_InWorldContext_Offset = NativeReflection.GetPropertyOffset(SwitchFreeCameraMode_FunctionAddress, "InWorldContext");
		SwitchFreeCameraMode_InWorldContext_IsValid = NativeReflection.ValidatePropertyClass(SwitchFreeCameraMode_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		SwitchFreeCameraMode_IsValid = SwitchFreeCameraMode_FunctionAddress != IntPtr.Zero && SwitchFreeCameraMode_InWorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SwitchFreeCameraMode", SwitchFreeCameraMode_IsValid);
		TriggerSwitchPhysics_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TriggerSwitchPhysics");
		TriggerSwitchPhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerSwitchPhysics_FunctionAddress);
		TriggerSwitchPhysics_Unit_Offset = NativeReflection.GetPropertyOffset(TriggerSwitchPhysics_FunctionAddress, "Unit");
		TriggerSwitchPhysics_Unit_IsValid = NativeReflection.ValidatePropertyClass(TriggerSwitchPhysics_FunctionAddress, "Unit", Classes.FObjectProperty);
		TriggerSwitchPhysics_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TriggerSwitchPhysics_FunctionAddress, "ReturnValue");
		TriggerSwitchPhysics_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TriggerSwitchPhysics_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TriggerSwitchPhysics_IsValid = TriggerSwitchPhysics_FunctionAddress != IntPtr.Zero && TriggerSwitchPhysics_Unit_IsValid && TriggerSwitchPhysics_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerSwitchPhysics", TriggerSwitchPhysics_IsValid);
		BGUGetActiveGameMode_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetActiveGameMode");
		BGUGetActiveGameMode_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetActiveGameMode_FunctionAddress);
		BGUGetActiveGameMode_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetActiveGameMode_FunctionAddress, "ReturnValue");
		BGUGetActiveGameMode_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetActiveGameMode_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetActiveGameMode_IsValid = BGUGetActiveGameMode_FunctionAddress != IntPtr.Zero && BGUGetActiveGameMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetActiveGameMode", BGUGetActiveGameMode_IsValid);
		GetProjectBranchName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetProjectBranchName");
		GetProjectBranchName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectBranchName_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetProjectBranchName_ReturnValue_PropertyAddress, GetProjectBranchName_FunctionAddress, "ReturnValue");
		GetProjectBranchName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetProjectBranchName_FunctionAddress, "ReturnValue");
		GetProjectBranchName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetProjectBranchName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetProjectBranchName_IsValid = GetProjectBranchName_FunctionAddress != IntPtr.Zero && GetProjectBranchName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetProjectBranchName", GetProjectBranchName_IsValid);
		SetTamerStrategyArea_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetTamerStrategyArea");
		SetTamerStrategyArea_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTamerStrategyArea_FunctionAddress);
		SetTamerStrategyArea_InWorldContext_Offset = NativeReflection.GetPropertyOffset(SetTamerStrategyArea_FunctionAddress, "InWorldContext");
		SetTamerStrategyArea_InWorldContext_IsValid = NativeReflection.ValidatePropertyClass(SetTamerStrategyArea_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SetTamerStrategyArea_InArea_PropertyAddress, SetTamerStrategyArea_FunctionAddress, "InArea");
		SetTamerStrategyArea_InArea_Offset = NativeReflection.GetPropertyOffset(SetTamerStrategyArea_FunctionAddress, "InArea");
		SetTamerStrategyArea_InArea_IsValid = NativeReflection.ValidatePropertyClass(SetTamerStrategyArea_FunctionAddress, "InArea", Classes.FEnumProperty);
		SetTamerStrategyArea_IsValid = SetTamerStrategyArea_FunctionAddress != IntPtr.Zero && SetTamerStrategyArea_InWorldContext_IsValid && SetTamerStrategyArea_InArea_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetTamerStrategyArea", SetTamerStrategyArea_IsValid);
		HandleAiConversation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HandleAiConversation");
		HandleAiConversation_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleAiConversation_FunctionAddress);
		HandleAiConversation_Caster_Offset = NativeReflection.GetPropertyOffset(HandleAiConversation_FunctionAddress, "Caster");
		HandleAiConversation_Caster_IsValid = NativeReflection.ValidatePropertyClass(HandleAiConversation_FunctionAddress, "Caster", Classes.FObjectProperty);
		HandleAiConversation_ConversationContentID_Offset = NativeReflection.GetPropertyOffset(HandleAiConversation_FunctionAddress, "ConversationContentID");
		HandleAiConversation_ConversationContentID_IsValid = NativeReflection.ValidatePropertyClass(HandleAiConversation_FunctionAddress, "ConversationContentID", Classes.FIntProperty);
		HandleAiConversation_IsValid = HandleAiConversation_FunctionAddress != IntPtr.Zero && HandleAiConversation_Caster_IsValid && HandleAiConversation_ConversationContentID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:HandleAiConversation", HandleAiConversation_IsValid);
		EnterWeakPerformState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnterWeakPerformState");
		EnterWeakPerformState_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterWeakPerformState_FunctionAddress);
		EnterWeakPerformState_InWorldContext_Offset = NativeReflection.GetPropertyOffset(EnterWeakPerformState_FunctionAddress, "InWorldContext");
		EnterWeakPerformState_InWorldContext_IsValid = NativeReflection.ValidatePropertyClass(EnterWeakPerformState_FunctionAddress, "InWorldContext", Classes.FObjectProperty);
		EnterWeakPerformState_ConfigID_Offset = NativeReflection.GetPropertyOffset(EnterWeakPerformState_FunctionAddress, "ConfigID");
		EnterWeakPerformState_ConfigID_IsValid = NativeReflection.ValidatePropertyClass(EnterWeakPerformState_FunctionAddress, "ConfigID", Classes.FIntProperty);
		EnterWeakPerformState_IsValid = EnterWeakPerformState_FunctionAddress != IntPtr.Zero && EnterWeakPerformState_InWorldContext_IsValid && EnterWeakPerformState_ConfigID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:EnterWeakPerformState", EnterWeakPerformState_IsValid);
		ExitPlayerSkillCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExitPlayerSkillCamera");
		ExitPlayerSkillCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(ExitPlayerSkillCamera_FunctionAddress);
		ExitPlayerSkillCamera_WorldContext_Offset = NativeReflection.GetPropertyOffset(ExitPlayerSkillCamera_FunctionAddress, "WorldContext");
		ExitPlayerSkillCamera_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(ExitPlayerSkillCamera_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		ExitPlayerSkillCamera_IsValid = ExitPlayerSkillCamera_FunctionAddress != IntPtr.Zero && ExitPlayerSkillCamera_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExitPlayerSkillCamera", ExitPlayerSkillCamera_IsValid);
		BGUHasUnitSimpleState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHasUnitSimpleState");
		BGUHasUnitSimpleState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHasUnitSimpleState_FunctionAddress);
		BGUHasUnitSimpleState_Unit_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitSimpleState_FunctionAddress, "Unit");
		BGUHasUnitSimpleState_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitSimpleState_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUHasUnitSimpleState_SimpleState_PropertyAddress, BGUHasUnitSimpleState_FunctionAddress, "SimpleState");
		BGUHasUnitSimpleState_SimpleState_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitSimpleState_FunctionAddress, "SimpleState");
		BGUHasUnitSimpleState_SimpleState_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitSimpleState_FunctionAddress, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUHasUnitSimpleState_ReturnValue_PropertyAddress, BGUHasUnitSimpleState_FunctionAddress, "ReturnValue");
		BGUHasUnitSimpleState_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUHasUnitSimpleState_FunctionAddress, "ReturnValue");
		BGUHasUnitSimpleState_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUHasUnitSimpleState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUHasUnitSimpleState_IsValid = BGUHasUnitSimpleState_FunctionAddress != IntPtr.Zero && BGUHasUnitSimpleState_Unit_IsValid && BGUHasUnitSimpleState_SimpleState_IsValid && BGUHasUnitSimpleState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHasUnitSimpleState", BGUHasUnitSimpleState_IsValid);
		CheckCurCeilingHeight_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckCurCeilingHeight");
		CheckCurCeilingHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckCurCeilingHeight_FunctionAddress);
		CheckCurCeilingHeight_Character_Offset = NativeReflection.GetPropertyOffset(CheckCurCeilingHeight_FunctionAddress, "Character");
		CheckCurCeilingHeight_Character_IsValid = NativeReflection.ValidatePropertyClass(CheckCurCeilingHeight_FunctionAddress, "Character", Classes.FObjectProperty);
		CheckCurCeilingHeight_LineTraceLength_Offset = NativeReflection.GetPropertyOffset(CheckCurCeilingHeight_FunctionAddress, "LineTraceLength");
		CheckCurCeilingHeight_LineTraceLength_IsValid = NativeReflection.ValidatePropertyClass(CheckCurCeilingHeight_FunctionAddress, "LineTraceLength", Classes.FFloatProperty);
		CheckCurCeilingHeight_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckCurCeilingHeight_FunctionAddress, "ReturnValue");
		CheckCurCeilingHeight_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckCurCeilingHeight_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		CheckCurCeilingHeight_IsValid = CheckCurCeilingHeight_FunctionAddress != IntPtr.Zero && CheckCurCeilingHeight_Character_IsValid && CheckCurCeilingHeight_LineTraceLength_IsValid && CheckCurCeilingHeight_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:CheckCurCeilingHeight", CheckCurCeilingHeight_IsValid);
		TriggerEffectToTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TriggerEffectToTarget");
		TriggerEffectToTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerEffectToTarget_FunctionAddress);
		TriggerEffectToTarget_Unit_Offset = NativeReflection.GetPropertyOffset(TriggerEffectToTarget_FunctionAddress, "Unit");
		TriggerEffectToTarget_Unit_IsValid = NativeReflection.ValidatePropertyClass(TriggerEffectToTarget_FunctionAddress, "Unit", Classes.FObjectProperty);
		TriggerEffectToTarget_EffectID_Offset = NativeReflection.GetPropertyOffset(TriggerEffectToTarget_FunctionAddress, "EffectID");
		TriggerEffectToTarget_EffectID_IsValid = NativeReflection.ValidatePropertyClass(TriggerEffectToTarget_FunctionAddress, "EffectID", Classes.FIntProperty);
		TriggerEffectToTarget_Target_Offset = NativeReflection.GetPropertyOffset(TriggerEffectToTarget_FunctionAddress, "Target");
		TriggerEffectToTarget_Target_IsValid = NativeReflection.ValidatePropertyClass(TriggerEffectToTarget_FunctionAddress, "Target", Classes.FObjectProperty);
		TriggerEffectToTarget_IsValid = TriggerEffectToTarget_FunctionAddress != IntPtr.Zero && TriggerEffectToTarget_Unit_IsValid && TriggerEffectToTarget_EffectID_IsValid && TriggerEffectToTarget_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TriggerEffectToTarget", TriggerEffectToTarget_IsValid);
		BGUUnitCastFaBaoSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUUnitCastFaBaoSkill");
		BGUUnitCastFaBaoSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnitCastFaBaoSkill_FunctionAddress);
		BGUUnitCastFaBaoSkill_Unit_Offset = NativeReflection.GetPropertyOffset(BGUUnitCastFaBaoSkill_FunctionAddress, "Unit");
		BGUUnitCastFaBaoSkill_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUUnitCastFaBaoSkill_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUUnitCastFaBaoSkill_IsValid = BGUUnitCastFaBaoSkill_FunctionAddress != IntPtr.Zero && BGUUnitCastFaBaoSkill_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUUnitCastFaBaoSkill", BGUUnitCastFaBaoSkill_IsValid);
		BGUSetUnitSimpleState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUnitSimpleState");
		BGUSetUnitSimpleState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUnitSimpleState_FunctionAddress);
		BGUSetUnitSimpleState_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitSimpleState_FunctionAddress, "Unit");
		BGUSetUnitSimpleState_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitSimpleState_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitSimpleState_SimpleState_PropertyAddress, BGUSetUnitSimpleState_FunctionAddress, "SimpleState");
		BGUSetUnitSimpleState_SimpleState_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitSimpleState_FunctionAddress, "SimpleState");
		BGUSetUnitSimpleState_SimpleState_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitSimpleState_FunctionAddress, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUSetUnitSimpleState_IsRemove_PropertyAddress, BGUSetUnitSimpleState_FunctionAddress, "IsRemove");
		BGUSetUnitSimpleState_IsRemove_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitSimpleState_FunctionAddress, "IsRemove");
		BGUSetUnitSimpleState_IsRemove_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitSimpleState_FunctionAddress, "IsRemove", Classes.FBoolProperty);
		BGUSetUnitSimpleState_IsValid = BGUSetUnitSimpleState_FunctionAddress != IntPtr.Zero && BGUSetUnitSimpleState_Unit_IsValid && BGUSetUnitSimpleState_SimpleState_IsValid && BGUSetUnitSimpleState_IsRemove_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitSimpleState", BGUSetUnitSimpleState_IsValid);
		BGUSetSkillSuperArmor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetSkillSuperArmor");
		BGUSetSkillSuperArmor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetSkillSuperArmor_FunctionAddress);
		BGUSetSkillSuperArmor_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetSkillSuperArmor_FunctionAddress, "Unit");
		BGUSetSkillSuperArmor_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetSkillSuperArmor_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_Offset = NativeReflection.GetPropertyOffset(BGUSetSkillSuperArmor_FunctionAddress, "BreakSkillSupperArmorAM");
		BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_IsValid = NativeReflection.ValidatePropertyClass(BGUSetSkillSuperArmor_FunctionAddress, "BreakSkillSupperArmorAM", Classes.FObjectProperty);
		BGUSetSkillSuperArmor_SkillSuperArmorValue_Offset = NativeReflection.GetPropertyOffset(BGUSetSkillSuperArmor_FunctionAddress, "SkillSuperArmorValue");
		BGUSetSkillSuperArmor_SkillSuperArmorValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSetSkillSuperArmor_FunctionAddress, "SkillSuperArmorValue", Classes.FFloatProperty);
		BGUSetSkillSuperArmor_IsValid = BGUSetSkillSuperArmor_FunctionAddress != IntPtr.Zero && BGUSetSkillSuperArmor_Unit_IsValid && BGUSetSkillSuperArmor_BreakSkillSupperArmorAM_IsValid && BGUSetSkillSuperArmor_SkillSuperArmorValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetSkillSuperArmor", BGUSetSkillSuperArmor_IsValid);
		BGUCallPointsRegister_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCallPointsRegister");
		BGUCallPointsRegister_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCallPointsRegister_FunctionAddress);
		BGUCallPointsRegister_OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(BGUCallPointsRegister_FunctionAddress, "OwnerCharacter");
		BGUCallPointsRegister_OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(BGUCallPointsRegister_FunctionAddress, "OwnerCharacter", Classes.FObjectProperty);
		BGUCallPointsRegister_RequestID_Offset = NativeReflection.GetPropertyOffset(BGUCallPointsRegister_FunctionAddress, "RequestID");
		BGUCallPointsRegister_RequestID_IsValid = NativeReflection.ValidatePropertyClass(BGUCallPointsRegister_FunctionAddress, "RequestID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUCallPointsRegister_GenType_PropertyAddress, BGUCallPointsRegister_FunctionAddress, "GenType");
		BGUCallPointsRegister_GenType_Offset = NativeReflection.GetPropertyOffset(BGUCallPointsRegister_FunctionAddress, "GenType");
		BGUCallPointsRegister_GenType_IsValid = NativeReflection.ValidatePropertyClass(BGUCallPointsRegister_FunctionAddress, "GenType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BGUCallPointsRegister_ExtParam_PropertyAddress, BGUCallPointsRegister_FunctionAddress, "ExtParam");
		BGUCallPointsRegister_ExtParam_Offset = NativeReflection.GetPropertyOffset(BGUCallPointsRegister_FunctionAddress, "ExtParam");
		BGUCallPointsRegister_ExtParam_IsValid = NativeReflection.ValidatePropertyClass(BGUCallPointsRegister_FunctionAddress, "ExtParam", Classes.FStructProperty);
		BGUCallPointsRegister_IsValid = BGUCallPointsRegister_FunctionAddress != IntPtr.Zero && BGUCallPointsRegister_OwnerCharacter_IsValid && BGUCallPointsRegister_RequestID_IsValid && BGUCallPointsRegister_GenType_IsValid && BGUCallPointsRegister_ExtParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCallPointsRegister", BGUCallPointsRegister_IsValid);
		BGUGetCurrentUserType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetCurrentUserType");
		BGUGetCurrentUserType_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetCurrentUserType_FunctionAddress);
		BGUGetCurrentUserType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetCurrentUserType_FunctionAddress, "ReturnValue");
		BGUGetCurrentUserType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetCurrentUserType_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetCurrentUserType_IsValid = BGUGetCurrentUserType_FunctionAddress != IntPtr.Zero && BGUGetCurrentUserType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetCurrentUserType", BGUGetCurrentUserType_IsValid);
		TryGetComponentByFName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TryGetComponentByFName");
		TryGetComponentByFName_ParamsSize = NativeReflection.GetFunctionParamsSize(TryGetComponentByFName_FunctionAddress);
		TryGetComponentByFName_Actor_Offset = NativeReflection.GetPropertyOffset(TryGetComponentByFName_FunctionAddress, "Actor");
		TryGetComponentByFName_Actor_IsValid = NativeReflection.ValidatePropertyClass(TryGetComponentByFName_FunctionAddress, "Actor", Classes.FObjectProperty);
		TryGetComponentByFName_Name_Offset = NativeReflection.GetPropertyOffset(TryGetComponentByFName_FunctionAddress, "Name");
		TryGetComponentByFName_Name_IsValid = NativeReflection.ValidatePropertyClass(TryGetComponentByFName_FunctionAddress, "Name", Classes.FNameProperty);
		TryGetComponentByFName_ReturnValue_Offset = NativeReflection.GetPropertyOffset(TryGetComponentByFName_FunctionAddress, "ReturnValue");
		TryGetComponentByFName_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(TryGetComponentByFName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		TryGetComponentByFName_IsValid = TryGetComponentByFName_FunctionAddress != IntPtr.Zero && TryGetComponentByFName_Actor_IsValid && TryGetComponentByFName_Name_IsValid && TryGetComponentByFName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TryGetComponentByFName", TryGetComponentByFName_IsValid);
		BGUHandleAbnormalState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUHandleAbnormalState");
		BGUHandleAbnormalState_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHandleAbnormalState_FunctionAddress);
		BGUHandleAbnormalState_Attacker_Offset = NativeReflection.GetPropertyOffset(BGUHandleAbnormalState_FunctionAddress, "Attacker");
		BGUHandleAbnormalState_Attacker_IsValid = NativeReflection.ValidatePropertyClass(BGUHandleAbnormalState_FunctionAddress, "Attacker", Classes.FObjectProperty);
		BGUHandleAbnormalState_Victim_Offset = NativeReflection.GetPropertyOffset(BGUHandleAbnormalState_FunctionAddress, "Victim");
		BGUHandleAbnormalState_Victim_IsValid = NativeReflection.ValidatePropertyClass(BGUHandleAbnormalState_FunctionAddress, "Victim", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUHandleAbnormalState_config_PropertyAddress, BGUHandleAbnormalState_FunctionAddress, "config");
		BGUHandleAbnormalState_config_Offset = NativeReflection.GetPropertyOffset(BGUHandleAbnormalState_FunctionAddress, "config");
		BGUHandleAbnormalState_config_IsValid = NativeReflection.ValidatePropertyClass(BGUHandleAbnormalState_FunctionAddress, "config", Classes.FStructProperty);
		BGUHandleAbnormalState_AddValue_Offset = NativeReflection.GetPropertyOffset(BGUHandleAbnormalState_FunctionAddress, "AddValue");
		BGUHandleAbnormalState_AddValue_IsValid = NativeReflection.ValidatePropertyClass(BGUHandleAbnormalState_FunctionAddress, "AddValue", Classes.FFloatProperty);
		BGUHandleAbnormalState_IsValid = BGUHandleAbnormalState_FunctionAddress != IntPtr.Zero && BGUHandleAbnormalState_Attacker_IsValid && BGUHandleAbnormalState_Victim_IsValid && BGUHandleAbnormalState_config_IsValid && BGUHandleAbnormalState_AddValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUHandleAbnormalState", BGUHandleAbnormalState_IsValid);
		BGUSetUnitCritRateBase_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetUnitCritRateBase");
		BGUSetUnitCritRateBase_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetUnitCritRateBase_FunctionAddress);
		BGUSetUnitCritRateBase_Unit_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitCritRateBase_FunctionAddress, "Unit");
		BGUSetUnitCritRateBase_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitCritRateBase_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUSetUnitCritRateBase_CritRate_Offset = NativeReflection.GetPropertyOffset(BGUSetUnitCritRateBase_FunctionAddress, "CritRate");
		BGUSetUnitCritRateBase_CritRate_IsValid = NativeReflection.ValidatePropertyClass(BGUSetUnitCritRateBase_FunctionAddress, "CritRate", Classes.FFloatProperty);
		BGUSetUnitCritRateBase_IsValid = BGUSetUnitCritRateBase_FunctionAddress != IntPtr.Zero && BGUSetUnitCritRateBase_Unit_IsValid && BGUSetUnitCritRateBase_CritRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetUnitCritRateBase", BGUSetUnitCritRateBase_IsValid);
		EnterPlayerSkillCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnterPlayerSkillCamera");
		EnterPlayerSkillCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterPlayerSkillCamera_FunctionAddress);
		EnterPlayerSkillCamera_WorldContext_Offset = NativeReflection.GetPropertyOffset(EnterPlayerSkillCamera_FunctionAddress, "WorldContext");
		EnterPlayerSkillCamera_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(EnterPlayerSkillCamera_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		EnterPlayerSkillCamera_CameraID_Offset = NativeReflection.GetPropertyOffset(EnterPlayerSkillCamera_FunctionAddress, "CameraID");
		EnterPlayerSkillCamera_CameraID_IsValid = NativeReflection.ValidatePropertyClass(EnterPlayerSkillCamera_FunctionAddress, "CameraID", Classes.FIntProperty);
		EnterPlayerSkillCamera_IsValid = EnterPlayerSkillCamera_FunctionAddress != IntPtr.Zero && EnterPlayerSkillCamera_WorldContext_IsValid && EnterPlayerSkillCamera_CameraID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:EnterPlayerSkillCamera", EnterPlayerSkillCamera_IsValid);
		SetCameraFocusDistance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCameraFocusDistance");
		SetCameraFocusDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraFocusDistance_FunctionAddress);
		SetCameraFocusDistance_CameraActor_Offset = NativeReflection.GetPropertyOffset(SetCameraFocusDistance_FunctionAddress, "CameraActor");
		SetCameraFocusDistance_CameraActor_IsValid = NativeReflection.ValidatePropertyClass(SetCameraFocusDistance_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		SetCameraFocusDistance_NewFocusDistance_Offset = NativeReflection.GetPropertyOffset(SetCameraFocusDistance_FunctionAddress, "NewFocusDistance");
		SetCameraFocusDistance_NewFocusDistance_IsValid = NativeReflection.ValidatePropertyClass(SetCameraFocusDistance_FunctionAddress, "NewFocusDistance", Classes.FFloatProperty);
		SetCameraFocusDistance_IsValid = SetCameraFocusDistance_FunctionAddress != IntPtr.Zero && SetCameraFocusDistance_CameraActor_IsValid && SetCameraFocusDistance_NewFocusDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetCameraFocusDistance", SetCameraFocusDistance_IsValid);
		GetCameraFocusDistance_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCameraFocusDistance");
		GetCameraFocusDistance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraFocusDistance_FunctionAddress);
		GetCameraFocusDistance_CameraActor_Offset = NativeReflection.GetPropertyOffset(GetCameraFocusDistance_FunctionAddress, "CameraActor");
		GetCameraFocusDistance_CameraActor_IsValid = NativeReflection.ValidatePropertyClass(GetCameraFocusDistance_FunctionAddress, "CameraActor", Classes.FObjectProperty);
		GetCameraFocusDistance_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCameraFocusDistance_FunctionAddress, "ReturnValue");
		GetCameraFocusDistance_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCameraFocusDistance_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCameraFocusDistance_IsValid = GetCameraFocusDistance_FunctionAddress != IntPtr.Zero && GetCameraFocusDistance_CameraActor_IsValid && GetCameraFocusDistance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetCameraFocusDistance", GetCameraFocusDistance_IsValid);
		ExitMonsterSkillCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExitMonsterSkillCamera");
		ExitMonsterSkillCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(ExitMonsterSkillCamera_FunctionAddress);
		ExitMonsterSkillCamera_Monster_Offset = NativeReflection.GetPropertyOffset(ExitMonsterSkillCamera_FunctionAddress, "Monster");
		ExitMonsterSkillCamera_Monster_IsValid = NativeReflection.ValidatePropertyClass(ExitMonsterSkillCamera_FunctionAddress, "Monster", Classes.FObjectProperty);
		ExitMonsterSkillCamera_IsValid = ExitMonsterSkillCamera_FunctionAddress != IntPtr.Zero && ExitMonsterSkillCamera_Monster_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExitMonsterSkillCamera", ExitMonsterSkillCamera_IsValid);
		GetUnitLockTargetActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUnitLockTargetActor");
		GetUnitLockTargetActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnitLockTargetActor_FunctionAddress);
		GetUnitLockTargetActor_Unit_Offset = NativeReflection.GetPropertyOffset(GetUnitLockTargetActor_FunctionAddress, "Unit");
		GetUnitLockTargetActor_Unit_IsValid = NativeReflection.ValidatePropertyClass(GetUnitLockTargetActor_FunctionAddress, "Unit", Classes.FObjectProperty);
		GetUnitLockTargetActor_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetUnitLockTargetActor_FunctionAddress, "ReturnValue");
		GetUnitLockTargetActor_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetUnitLockTargetActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetUnitLockTargetActor_IsValid = GetUnitLockTargetActor_FunctionAddress != IntPtr.Zero && GetUnitLockTargetActor_Unit_IsValid && GetUnitLockTargetActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetUnitLockTargetActor", GetUnitLockTargetActor_IsValid);
		BGUSetCanTriggerGroupAI_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetCanTriggerGroupAI");
		BGUSetCanTriggerGroupAI_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetCanTriggerGroupAI_FunctionAddress);
		BGUSetCanTriggerGroupAI_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUSetCanTriggerGroupAI_FunctionAddress, "WorldContext");
		BGUSetCanTriggerGroupAI_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUSetCanTriggerGroupAI_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetCanTriggerGroupAI_CanTrigger_PropertyAddress, BGUSetCanTriggerGroupAI_FunctionAddress, "CanTrigger");
		BGUSetCanTriggerGroupAI_CanTrigger_Offset = NativeReflection.GetPropertyOffset(BGUSetCanTriggerGroupAI_FunctionAddress, "CanTrigger");
		BGUSetCanTriggerGroupAI_CanTrigger_IsValid = NativeReflection.ValidatePropertyClass(BGUSetCanTriggerGroupAI_FunctionAddress, "CanTrigger", Classes.FBoolProperty);
		BGUSetCanTriggerGroupAI_IsValid = BGUSetCanTriggerGroupAI_FunctionAddress != IntPtr.Zero && BGUSetCanTriggerGroupAI_WorldContext_IsValid && BGUSetCanTriggerGroupAI_CanTrigger_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetCanTriggerGroupAI", BGUSetCanTriggerGroupAI_IsValid);
		EnterMonsterSkillCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EnterMonsterSkillCamera");
		EnterMonsterSkillCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(EnterMonsterSkillCamera_FunctionAddress);
		EnterMonsterSkillCamera_Monster_Offset = NativeReflection.GetPropertyOffset(EnterMonsterSkillCamera_FunctionAddress, "Monster");
		EnterMonsterSkillCamera_Monster_IsValid = NativeReflection.ValidatePropertyClass(EnterMonsterSkillCamera_FunctionAddress, "Monster", Classes.FObjectProperty);
		EnterMonsterSkillCamera_CameraID_Offset = NativeReflection.GetPropertyOffset(EnterMonsterSkillCamera_FunctionAddress, "CameraID");
		EnterMonsterSkillCamera_CameraID_IsValid = NativeReflection.ValidatePropertyClass(EnterMonsterSkillCamera_FunctionAddress, "CameraID", Classes.FIntProperty);
		EnterMonsterSkillCamera_IsValid = EnterMonsterSkillCamera_FunctionAddress != IntPtr.Zero && EnterMonsterSkillCamera_Monster_IsValid && EnterMonsterSkillCamera_CameraID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:EnterMonsterSkillCamera", EnterMonsterSkillCamera_IsValid);
		BGUSpawnActorNoBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSpawnActorNoBeginPlay");
		BGUSpawnActorNoBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSpawnActorNoBeginPlay_FunctionAddress);
		BGUSpawnActorNoBeginPlay__World_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorNoBeginPlay_FunctionAddress, "_World");
		BGUSpawnActorNoBeginPlay__World_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorNoBeginPlay_FunctionAddress, "_World", Classes.FObjectProperty);
		BGUSpawnActorNoBeginPlay_ActorClass_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorNoBeginPlay_FunctionAddress, "ActorClass");
		BGUSpawnActorNoBeginPlay_ActorClass_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorNoBeginPlay_FunctionAddress, "ActorClass", Classes.FClassProperty);
		BGUSpawnActorNoBeginPlay_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorNoBeginPlay_FunctionAddress, "ReturnValue");
		BGUSpawnActorNoBeginPlay_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorNoBeginPlay_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUSpawnActorNoBeginPlay_IsValid = BGUSpawnActorNoBeginPlay_FunctionAddress != IntPtr.Zero && BGUSpawnActorNoBeginPlay__World_IsValid && BGUSpawnActorNoBeginPlay_ActorClass_IsValid && BGUSpawnActorNoBeginPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorNoBeginPlay", BGUSpawnActorNoBeginPlay_IsValid);
		PrepareForSkillRecording_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrepareForSkillRecording");
		PrepareForSkillRecording_ParamsSize = NativeReflection.GetFunctionParamsSize(PrepareForSkillRecording_FunctionAddress);
		PrepareForSkillRecording_World_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "World");
		PrepareForSkillRecording_World_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "World", Classes.FObjectProperty);
		PrepareForSkillRecording_UnitClass_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "UnitClass");
		PrepareForSkillRecording_UnitClass_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "UnitClass", Classes.FClassProperty);
		PrepareForSkillRecording_ResID_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "ResID");
		PrepareForSkillRecording_ResID_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "ResID", Classes.FIntProperty);
		PrepareForSkillRecording_SkillID_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "SkillID");
		PrepareForSkillRecording_SkillID_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "SkillID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PrepareForSkillRecording_bNeedsSpawnNewUnit_PropertyAddress, PrepareForSkillRecording_FunctionAddress, "bNeedsSpawnNewUnit");
		PrepareForSkillRecording_bNeedsSpawnNewUnit_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "bNeedsSpawnNewUnit");
		PrepareForSkillRecording_bNeedsSpawnNewUnit_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "bNeedsSpawnNewUnit", Classes.FBoolProperty);
		PrepareForSkillRecording_SpawnedUnit_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "SpawnedUnit");
		PrepareForSkillRecording_SpawnedUnit_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "SpawnedUnit", Classes.FObjectProperty);
		PrepareForSkillRecording_PlayedMontage_Offset = NativeReflection.GetPropertyOffset(PrepareForSkillRecording_FunctionAddress, "PlayedMontage");
		PrepareForSkillRecording_PlayedMontage_IsValid = NativeReflection.ValidatePropertyClass(PrepareForSkillRecording_FunctionAddress, "PlayedMontage", Classes.FObjectProperty);
		PrepareForSkillRecording_IsValid = PrepareForSkillRecording_FunctionAddress != IntPtr.Zero && PrepareForSkillRecording_World_IsValid && PrepareForSkillRecording_UnitClass_IsValid && PrepareForSkillRecording_ResID_IsValid && PrepareForSkillRecording_SkillID_IsValid && PrepareForSkillRecording_bNeedsSpawnNewUnit_IsValid && PrepareForSkillRecording_SpawnedUnit_IsValid && PrepareForSkillRecording_PlayedMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PrepareForSkillRecording", PrepareForSkillRecording_IsValid);
		BGURemoveSkillSuperArmor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURemoveSkillSuperArmor");
		BGURemoveSkillSuperArmor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURemoveSkillSuperArmor_FunctionAddress);
		BGURemoveSkillSuperArmor_Unit_Offset = NativeReflection.GetPropertyOffset(BGURemoveSkillSuperArmor_FunctionAddress, "Unit");
		BGURemoveSkillSuperArmor_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveSkillSuperArmor_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURemoveSkillSuperArmor_IsValid = BGURemoveSkillSuperArmor_FunctionAddress != IntPtr.Zero && BGURemoveSkillSuperArmor_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveSkillSuperArmor", BGURemoveSkillSuperArmor_IsValid);
		ClampAndAlignToLandScape_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ClampAndAlignToLandScape");
		ClampAndAlignToLandScape_ParamsSize = NativeReflection.GetFunctionParamsSize(ClampAndAlignToLandScape_FunctionAddress);
		ClampAndAlignToLandScape_Unit_Offset = NativeReflection.GetPropertyOffset(ClampAndAlignToLandScape_FunctionAddress, "Unit");
		ClampAndAlignToLandScape_Unit_IsValid = NativeReflection.ValidatePropertyClass(ClampAndAlignToLandScape_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ClampAndAlignToLandScape_ClampToLand_PropertyAddress, ClampAndAlignToLandScape_FunctionAddress, "ClampToLand");
		ClampAndAlignToLandScape_ClampToLand_Offset = NativeReflection.GetPropertyOffset(ClampAndAlignToLandScape_FunctionAddress, "ClampToLand");
		ClampAndAlignToLandScape_ClampToLand_IsValid = NativeReflection.ValidatePropertyClass(ClampAndAlignToLandScape_FunctionAddress, "ClampToLand", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ClampAndAlignToLandScape_AlignToLand_PropertyAddress, ClampAndAlignToLandScape_FunctionAddress, "AlignToLand");
		ClampAndAlignToLandScape_AlignToLand_Offset = NativeReflection.GetPropertyOffset(ClampAndAlignToLandScape_FunctionAddress, "AlignToLand");
		ClampAndAlignToLandScape_AlignToLand_IsValid = NativeReflection.ValidatePropertyClass(ClampAndAlignToLandScape_FunctionAddress, "AlignToLand", Classes.FBoolProperty);
		ClampAndAlignToLandScape_DeltaTime_Offset = NativeReflection.GetPropertyOffset(ClampAndAlignToLandScape_FunctionAddress, "DeltaTime");
		ClampAndAlignToLandScape_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(ClampAndAlignToLandScape_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		ClampAndAlignToLandScape_InterpSpd_Offset = NativeReflection.GetPropertyOffset(ClampAndAlignToLandScape_FunctionAddress, "InterpSpd");
		ClampAndAlignToLandScape_InterpSpd_IsValid = NativeReflection.ValidatePropertyClass(ClampAndAlignToLandScape_FunctionAddress, "InterpSpd", Classes.FFloatProperty);
		ClampAndAlignToLandScape_IsValid = ClampAndAlignToLandScape_FunctionAddress != IntPtr.Zero && ClampAndAlignToLandScape_Unit_IsValid && ClampAndAlignToLandScape_ClampToLand_IsValid && ClampAndAlignToLandScape_AlignToLand_IsValid && ClampAndAlignToLandScape_DeltaTime_IsValid && ClampAndAlignToLandScape_InterpSpd_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ClampAndAlignToLandScape", ClampAndAlignToLandScape_IsValid);
		BGURemoveBuffImmediately_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGURemoveBuffImmediately");
		BGURemoveBuffImmediately_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURemoveBuffImmediately_FunctionAddress);
		BGURemoveBuffImmediately_Unit_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuffImmediately_FunctionAddress, "Unit");
		BGURemoveBuffImmediately_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuffImmediately_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGURemoveBuffImmediately_BuffID_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuffImmediately_FunctionAddress, "BuffID");
		BGURemoveBuffImmediately_BuffID_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuffImmediately_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGURemoveBuffImmediately_EffectTriggerType_PropertyAddress, BGURemoveBuffImmediately_FunctionAddress, "EffectTriggerType");
		BGURemoveBuffImmediately_EffectTriggerType_Offset = NativeReflection.GetPropertyOffset(BGURemoveBuffImmediately_FunctionAddress, "EffectTriggerType");
		BGURemoveBuffImmediately_EffectTriggerType_IsValid = NativeReflection.ValidatePropertyClass(BGURemoveBuffImmediately_FunctionAddress, "EffectTriggerType", Classes.FEnumProperty);
		BGURemoveBuffImmediately_IsValid = BGURemoveBuffImmediately_FunctionAddress != IntPtr.Zero && BGURemoveBuffImmediately_Unit_IsValid && BGURemoveBuffImmediately_BuffID_IsValid && BGURemoveBuffImmediately_EffectTriggerType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGURemoveBuffImmediately", BGURemoveBuffImmediately_IsValid);
		BGUOneHitBreakImmobility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUOneHitBreakImmobility");
		BGUOneHitBreakImmobility_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUOneHitBreakImmobility_FunctionAddress);
		BGUOneHitBreakImmobility_Unit_Offset = NativeReflection.GetPropertyOffset(BGUOneHitBreakImmobility_FunctionAddress, "Unit");
		BGUOneHitBreakImmobility_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUOneHitBreakImmobility_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUOneHitBreakImmobility_IsValid = BGUOneHitBreakImmobility_FunctionAddress != IntPtr.Zero && BGUOneHitBreakImmobility_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUOneHitBreakImmobility", BGUOneHitBreakImmobility_IsValid);
		CastMagicallyChangeSkill_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CastMagicallyChangeSkill");
		CastMagicallyChangeSkill_ParamsSize = NativeReflection.GetFunctionParamsSize(CastMagicallyChangeSkill_FunctionAddress);
		CastMagicallyChangeSkill_Unit_Offset = NativeReflection.GetPropertyOffset(CastMagicallyChangeSkill_FunctionAddress, "Unit");
		CastMagicallyChangeSkill_Unit_IsValid = NativeReflection.ValidatePropertyClass(CastMagicallyChangeSkill_FunctionAddress, "Unit", Classes.FObjectProperty);
		CastMagicallyChangeSkill_Config_Offset = NativeReflection.GetPropertyOffset(CastMagicallyChangeSkill_FunctionAddress, "Config");
		CastMagicallyChangeSkill_Config_IsValid = NativeReflection.ValidatePropertyClass(CastMagicallyChangeSkill_FunctionAddress, "Config", Classes.FObjectProperty);
		CastMagicallyChangeSkill_SkillID_Offset = NativeReflection.GetPropertyOffset(CastMagicallyChangeSkill_FunctionAddress, "SkillID");
		CastMagicallyChangeSkill_SkillID_IsValid = NativeReflection.ValidatePropertyClass(CastMagicallyChangeSkill_FunctionAddress, "SkillID", Classes.FIntProperty);
		CastMagicallyChangeSkill_RecoverSkillID_Offset = NativeReflection.GetPropertyOffset(CastMagicallyChangeSkill_FunctionAddress, "RecoverSkillID");
		CastMagicallyChangeSkill_RecoverSkillID_IsValid = NativeReflection.ValidatePropertyClass(CastMagicallyChangeSkill_FunctionAddress, "RecoverSkillID", Classes.FIntProperty);
		CastMagicallyChangeSkill_IsValid = CastMagicallyChangeSkill_FunctionAddress != IntPtr.Zero && CastMagicallyChangeSkill_Unit_IsValid && CastMagicallyChangeSkill_Config_IsValid && CastMagicallyChangeSkill_SkillID_IsValid && CastMagicallyChangeSkill_RecoverSkillID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:CastMagicallyChangeSkill", CastMagicallyChangeSkill_IsValid);
		CanActivateConsoleCommad_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CanActivateConsoleCommad");
		CanActivateConsoleCommad_ParamsSize = NativeReflection.GetFunctionParamsSize(CanActivateConsoleCommad_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanActivateConsoleCommad_ReturnValue_PropertyAddress, CanActivateConsoleCommad_FunctionAddress, "ReturnValue");
		CanActivateConsoleCommad_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanActivateConsoleCommad_FunctionAddress, "ReturnValue");
		CanActivateConsoleCommad_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanActivateConsoleCommad_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanActivateConsoleCommad_IsValid = CanActivateConsoleCommad_FunctionAddress != IntPtr.Zero && CanActivateConsoleCommad_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:CanActivateConsoleCommad", CanActivateConsoleCommad_IsValid);
		GetCineCameraFocalLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCineCameraFocalLength");
		GetCineCameraFocalLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCineCameraFocalLength_FunctionAddress);
		GetCineCameraFocalLength_CineCameraActor_Offset = NativeReflection.GetPropertyOffset(GetCineCameraFocalLength_FunctionAddress, "CineCameraActor");
		GetCineCameraFocalLength_CineCameraActor_IsValid = NativeReflection.ValidatePropertyClass(GetCineCameraFocalLength_FunctionAddress, "CineCameraActor", Classes.FObjectProperty);
		GetCineCameraFocalLength_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCineCameraFocalLength_FunctionAddress, "ReturnValue");
		GetCineCameraFocalLength_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCineCameraFocalLength_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetCineCameraFocalLength_IsValid = GetCineCameraFocalLength_FunctionAddress != IntPtr.Zero && GetCineCameraFocalLength_CineCameraActor_IsValid && GetCineCameraFocalLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetCineCameraFocalLength", GetCineCameraFocalLength_IsValid);
		SetCineCameraFocalLength_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetCineCameraFocalLength");
		SetCineCameraFocalLength_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCineCameraFocalLength_FunctionAddress);
		SetCineCameraFocalLength_CineCameraActor_Offset = NativeReflection.GetPropertyOffset(SetCineCameraFocalLength_FunctionAddress, "CineCameraActor");
		SetCineCameraFocalLength_CineCameraActor_IsValid = NativeReflection.ValidatePropertyClass(SetCineCameraFocalLength_FunctionAddress, "CineCameraActor", Classes.FObjectProperty);
		SetCineCameraFocalLength_NewFocalLength_Offset = NativeReflection.GetPropertyOffset(SetCineCameraFocalLength_FunctionAddress, "NewFocalLength");
		SetCineCameraFocalLength_NewFocalLength_IsValid = NativeReflection.ValidatePropertyClass(SetCineCameraFocalLength_FunctionAddress, "NewFocalLength", Classes.FFloatProperty);
		SetCineCameraFocalLength_IsValid = SetCineCameraFocalLength_FunctionAddress != IntPtr.Zero && SetCineCameraFocalLength_CineCameraActor_IsValid && SetCineCameraFocalLength_NewFocalLength_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:SetCineCameraFocalLength", SetCineCameraFocalLength_IsValid);
		TestProfileSimpleOverlap_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TestProfileSimpleOverlap");
		TestProfileSimpleOverlap_ParamsSize = NativeReflection.GetFunctionParamsSize(TestProfileSimpleOverlap_FunctionAddress);
		TestProfileSimpleOverlap_WorldContext_Offset = NativeReflection.GetPropertyOffset(TestProfileSimpleOverlap_FunctionAddress, "WorldContext");
		TestProfileSimpleOverlap_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(TestProfileSimpleOverlap_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		TestProfileSimpleOverlap_IsValid = TestProfileSimpleOverlap_FunctionAddress != IntPtr.Zero && TestProfileSimpleOverlap_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:TestProfileSimpleOverlap", TestProfileSimpleOverlap_IsValid);
		BGUPlayerCameraLockTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlayerCameraLockTarget");
		BGUPlayerCameraLockTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayerCameraLockTarget_FunctionAddress);
		BGUPlayerCameraLockTarget_Player_Offset = NativeReflection.GetPropertyOffset(BGUPlayerCameraLockTarget_FunctionAddress, "Player");
		BGUPlayerCameraLockTarget_Player_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerCameraLockTarget_FunctionAddress, "Player", Classes.FObjectProperty);
		BGUPlayerCameraLockTarget_Target_Offset = NativeReflection.GetPropertyOffset(BGUPlayerCameraLockTarget_FunctionAddress, "Target");
		BGUPlayerCameraLockTarget_Target_IsValid = NativeReflection.ValidatePropertyClass(BGUPlayerCameraLockTarget_FunctionAddress, "Target", Classes.FObjectProperty);
		BGUPlayerCameraLockTarget_IsValid = BGUPlayerCameraLockTarget_FunctionAddress != IntPtr.Zero && BGUPlayerCameraLockTarget_Player_IsValid && BGUPlayerCameraLockTarget_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlayerCameraLockTarget", BGUPlayerCameraLockTarget_IsValid);
		BGUClosestPerceivedTarget_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUClosestPerceivedTarget");
		BGUClosestPerceivedTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUClosestPerceivedTarget_FunctionAddress);
		BGUClosestPerceivedTarget_Unit_Offset = NativeReflection.GetPropertyOffset(BGUClosestPerceivedTarget_FunctionAddress, "Unit");
		BGUClosestPerceivedTarget_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUClosestPerceivedTarget_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUClosestPerceivedTarget_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUClosestPerceivedTarget_FunctionAddress, "ReturnValue");
		BGUClosestPerceivedTarget_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUClosestPerceivedTarget_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUClosestPerceivedTarget_IsValid = BGUClosestPerceivedTarget_FunctionAddress != IntPtr.Zero && BGUClosestPerceivedTarget_Unit_IsValid && BGUClosestPerceivedTarget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUClosestPerceivedTarget", BGUClosestPerceivedTarget_IsValid);
		ExportAllTamerToDataAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportAllTamerToDataAsset");
		ExportAllTamerToDataAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportAllTamerToDataAsset_FunctionAddress);
		ExportAllTamerToDataAsset_IsValid = ExportAllTamerToDataAsset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExportAllTamerToDataAsset", ExportAllTamerToDataAsset_IsValid);
		BGUTryDestroyDestructible_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTryDestroyDestructible");
		BGUTryDestroyDestructible_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTryDestroyDestructible_FunctionAddress);
		BGUTryDestroyDestructible_DestructibleActor_Offset = NativeReflection.GetPropertyOffset(BGUTryDestroyDestructible_FunctionAddress, "DestructibleActor");
		BGUTryDestroyDestructible_DestructibleActor_IsValid = NativeReflection.ValidatePropertyClass(BGUTryDestroyDestructible_FunctionAddress, "DestructibleActor", Classes.FObjectProperty);
		BGUTryDestroyDestructible_IsValid = BGUTryDestroyDestructible_FunctionAddress != IntPtr.Zero && BGUTryDestroyDestructible_DestructibleActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryDestroyDestructible", BGUTryDestroyDestructible_IsValid);
		BGUCalcCharacterRotOnSlope_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCalcCharacterRotOnSlope");
		BGUCalcCharacterRotOnSlope_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcCharacterRotOnSlope_FunctionAddress);
		BGUCalcCharacterRotOnSlope_OwnerChr_Offset = NativeReflection.GetPropertyOffset(BGUCalcCharacterRotOnSlope_FunctionAddress, "OwnerChr");
		BGUCalcCharacterRotOnSlope_OwnerChr_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcCharacterRotOnSlope_FunctionAddress, "OwnerChr", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_PropertyAddress, BGUCalcCharacterRotOnSlope_FunctionAddress, "SurfaceNormal_Normalized");
		BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_Offset = NativeReflection.GetPropertyOffset(BGUCalcCharacterRotOnSlope_FunctionAddress, "SurfaceNormal_Normalized");
		BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcCharacterRotOnSlope_FunctionAddress, "SurfaceNormal_Normalized", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUCalcCharacterRotOnSlope_ReturnValue_PropertyAddress, BGUCalcCharacterRotOnSlope_FunctionAddress, "ReturnValue");
		BGUCalcCharacterRotOnSlope_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUCalcCharacterRotOnSlope_FunctionAddress, "ReturnValue");
		BGUCalcCharacterRotOnSlope_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUCalcCharacterRotOnSlope_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BGUCalcCharacterRotOnSlope_IsValid = BGUCalcCharacterRotOnSlope_FunctionAddress != IntPtr.Zero && BGUCalcCharacterRotOnSlope_OwnerChr_IsValid && BGUCalcCharacterRotOnSlope_SurfaceNormal_Normalized_IsValid && BGUCalcCharacterRotOnSlope_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCalcCharacterRotOnSlope", BGUCalcCharacterRotOnSlope_IsValid);
		BGUPlatformPatroMoveSingle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUPlatformPatroMoveSingle");
		BGUPlatformPatroMoveSingle_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlatformPatroMoveSingle_FunctionAddress);
		BGUPlatformPatroMoveSingle_Unit_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "Unit");
		BGUPlatformPatroMoveSingle_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUPlatformPatroMoveSingle_BeginPos_PropertyAddress, BGUPlatformPatroMoveSingle_FunctionAddress, "BeginPos");
		BGUPlatformPatroMoveSingle_BeginPos_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "BeginPos");
		BGUPlatformPatroMoveSingle_BeginPos_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "BeginPos", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BGUPlatformPatroMoveSingle_EndPos_PropertyAddress, BGUPlatformPatroMoveSingle_FunctionAddress, "EndPos");
		BGUPlatformPatroMoveSingle_EndPos_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "EndPos");
		BGUPlatformPatroMoveSingle_EndPos_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "EndPos", Classes.FStructProperty);
		BGUPlatformPatroMoveSingle_Speed_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "Speed");
		BGUPlatformPatroMoveSingle_Speed_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "Speed", Classes.FFloatProperty);
		BGUPlatformPatroMoveSingle_PlayerCount_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "PlayerCount");
		BGUPlatformPatroMoveSingle_PlayerCount_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "PlayerCount", Classes.FIntProperty);
		BGUPlatformPatroMoveSingle_Range_Offset = NativeReflection.GetPropertyOffset(BGUPlatformPatroMoveSingle_FunctionAddress, "Range");
		BGUPlatformPatroMoveSingle_Range_IsValid = NativeReflection.ValidatePropertyClass(BGUPlatformPatroMoveSingle_FunctionAddress, "Range", Classes.FFloatProperty);
		BGUPlatformPatroMoveSingle_IsValid = BGUPlatformPatroMoveSingle_FunctionAddress != IntPtr.Zero && BGUPlatformPatroMoveSingle_Unit_IsValid && BGUPlatformPatroMoveSingle_BeginPos_IsValid && BGUPlatformPatroMoveSingle_EndPos_IsValid && BGUPlatformPatroMoveSingle_Speed_IsValid && BGUPlatformPatroMoveSingle_PlayerCount_IsValid && BGUPlatformPatroMoveSingle_Range_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUPlatformPatroMoveSingle", BGUPlatformPatroMoveSingle_IsValid);
		BGUGetMultiPointCurrentUnit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUGetMultiPointCurrentUnit");
		BGUGetMultiPointCurrentUnit_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMultiPointCurrentUnit_FunctionAddress);
		BGUGetMultiPointCurrentUnit_Actor_Offset = NativeReflection.GetPropertyOffset(BGUGetMultiPointCurrentUnit_FunctionAddress, "Actor");
		BGUGetMultiPointCurrentUnit_Actor_IsValid = NativeReflection.ValidatePropertyClass(BGUGetMultiPointCurrentUnit_FunctionAddress, "Actor", Classes.FObjectProperty);
		BGUGetMultiPointCurrentUnit_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUGetMultiPointCurrentUnit_FunctionAddress, "ReturnValue");
		BGUGetMultiPointCurrentUnit_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUGetMultiPointCurrentUnit_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetMultiPointCurrentUnit_IsValid = BGUGetMultiPointCurrentUnit_FunctionAddress != IntPtr.Zero && BGUGetMultiPointCurrentUnit_Actor_IsValid && BGUGetMultiPointCurrentUnit_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUGetMultiPointCurrentUnit", BGUGetMultiPointCurrentUnit_IsValid);
		BGUEnablePlayerGuiBeiCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUEnablePlayerGuiBeiCamera");
		BGUEnablePlayerGuiBeiCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUEnablePlayerGuiBeiCamera_FunctionAddress);
		BGUEnablePlayerGuiBeiCamera_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUEnablePlayerGuiBeiCamera_FunctionAddress, "WorldContext");
		BGUEnablePlayerGuiBeiCamera_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUEnablePlayerGuiBeiCamera_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_PropertyAddress, BGUEnablePlayerGuiBeiCamera_FunctionAddress, "CurInverseAnimRotation");
		BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_Offset = NativeReflection.GetPropertyOffset(BGUEnablePlayerGuiBeiCamera_FunctionAddress, "CurInverseAnimRotation");
		BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_IsValid = NativeReflection.ValidatePropertyClass(BGUEnablePlayerGuiBeiCamera_FunctionAddress, "CurInverseAnimRotation", Classes.FStructProperty);
		BGUEnablePlayerGuiBeiCamera_IsValid = BGUEnablePlayerGuiBeiCamera_FunctionAddress != IntPtr.Zero && BGUEnablePlayerGuiBeiCamera_WorldContext_IsValid && BGUEnablePlayerGuiBeiCamera_CurInverseAnimRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUEnablePlayerGuiBeiCamera", BGUEnablePlayerGuiBeiCamera_IsValid);
		GenerateNavMeshBoundsVolumes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateNavMeshBoundsVolumes");
		GenerateNavMeshBoundsVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateNavMeshBoundsVolumes_FunctionAddress);
		GenerateNavMeshBoundsVolumes_TempleteActor_Offset = NativeReflection.GetPropertyOffset(GenerateNavMeshBoundsVolumes_FunctionAddress, "TempleteActor");
		GenerateNavMeshBoundsVolumes_TempleteActor_IsValid = NativeReflection.ValidatePropertyClass(GenerateNavMeshBoundsVolumes_FunctionAddress, "TempleteActor", Classes.FObjectProperty);
		GenerateNavMeshBoundsVolumes_IsValid = GenerateNavMeshBoundsVolumes_FunctionAddress != IntPtr.Zero && GenerateNavMeshBoundsVolumes_TempleteActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GenerateNavMeshBoundsVolumes", GenerateNavMeshBoundsVolumes_IsValid);
		BGUDisablePlayerGuiBeiCamera_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUDisablePlayerGuiBeiCamera");
		BGUDisablePlayerGuiBeiCamera_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUDisablePlayerGuiBeiCamera_FunctionAddress);
		BGUDisablePlayerGuiBeiCamera_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUDisablePlayerGuiBeiCamera_FunctionAddress, "WorldContext");
		BGUDisablePlayerGuiBeiCamera_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUDisablePlayerGuiBeiCamera_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BGUDisablePlayerGuiBeiCamera_IsValid = BGUDisablePlayerGuiBeiCamera_FunctionAddress != IntPtr.Zero && BGUDisablePlayerGuiBeiCamera_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUDisablePlayerGuiBeiCamera", BGUDisablePlayerGuiBeiCamera_IsValid);
		BGUSpawnActorAndECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSpawnActorAndECSBeginPlay");
		BGUSpawnActorAndECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSpawnActorAndECSBeginPlay_FunctionAddress);
		BGUSpawnActorAndECSBeginPlay__World_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "_World");
		BGUSpawnActorAndECSBeginPlay__World_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "_World", Classes.FObjectProperty);
		BGUSpawnActorAndECSBeginPlay_ActorClass_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "ActorClass");
		BGUSpawnActorAndECSBeginPlay_ActorClass_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "ActorClass", Classes.FClassProperty);
		BGUSpawnActorAndECSBeginPlay_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "ReturnValue");
		BGUSpawnActorAndECSBeginPlay_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSpawnActorAndECSBeginPlay_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUSpawnActorAndECSBeginPlay_IsValid = BGUSpawnActorAndECSBeginPlay_FunctionAddress != IntPtr.Zero && BGUSpawnActorAndECSBeginPlay__World_IsValid && BGUSpawnActorAndECSBeginPlay_ActorClass_IsValid && BGUSpawnActorAndECSBeginPlay_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSpawnActorAndECSBeginPlay", BGUSpawnActorAndECSBeginPlay_IsValid);
		ExportBulletSkillToDataAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportBulletSkillToDataAsset");
		ExportBulletSkillToDataAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportBulletSkillToDataAsset_FunctionAddress);
		ExportBulletSkillToDataAsset_TM_Offset = NativeReflection.GetPropertyOffset(ExportBulletSkillToDataAsset_FunctionAddress, "TM");
		ExportBulletSkillToDataAsset_TM_IsValid = NativeReflection.ValidatePropertyClass(ExportBulletSkillToDataAsset_FunctionAddress, "TM", Classes.FObjectProperty);
		ExportBulletSkillToDataAsset_IsValid = ExportBulletSkillToDataAsset_FunctionAddress != IntPtr.Zero && ExportBulletSkillToDataAsset_TM_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExportBulletSkillToDataAsset", ExportBulletSkillToDataAsset_IsValid);
		ExportTamerListToNewDAByBlame_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportTamerListToNewDAByBlame");
		ExportTamerListToNewDAByBlame_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportTamerListToNewDAByBlame_FunctionAddress);
		ExportTamerListToNewDAByBlame_Actor_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByBlame_FunctionAddress, "Actor");
		ExportTamerListToNewDAByBlame_Actor_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByBlame_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByBlame_OldTamer_PropertyAddress, ExportTamerListToNewDAByBlame_FunctionAddress, "OldTamer");
		ExportTamerListToNewDAByBlame_OldTamer_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByBlame_FunctionAddress, "OldTamer");
		ExportTamerListToNewDAByBlame_OldTamer_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByBlame_FunctionAddress, "OldTamer", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByBlame_NewTimer_PropertyAddress, ExportTamerListToNewDAByBlame_FunctionAddress, "NewTimer");
		ExportTamerListToNewDAByBlame_NewTimer_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByBlame_FunctionAddress, "NewTimer");
		ExportTamerListToNewDAByBlame_NewTimer_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByBlame_FunctionAddress, "NewTimer", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByBlame_BlameName_PropertyAddress, ExportTamerListToNewDAByBlame_FunctionAddress, "BlameName");
		ExportTamerListToNewDAByBlame_BlameName_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByBlame_FunctionAddress, "BlameName");
		ExportTamerListToNewDAByBlame_BlameName_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByBlame_FunctionAddress, "BlameName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByBlame_ReturnValue_PropertyAddress, ExportTamerListToNewDAByBlame_FunctionAddress, "ReturnValue");
		ExportTamerListToNewDAByBlame_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByBlame_FunctionAddress, "ReturnValue");
		ExportTamerListToNewDAByBlame_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByBlame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportTamerListToNewDAByBlame_IsValid = ExportTamerListToNewDAByBlame_FunctionAddress != IntPtr.Zero && ExportTamerListToNewDAByBlame_Actor_IsValid && ExportTamerListToNewDAByBlame_OldTamer_IsValid && ExportTamerListToNewDAByBlame_NewTimer_IsValid && ExportTamerListToNewDAByBlame_BlameName_IsValid && ExportTamerListToNewDAByBlame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByBlame", ExportTamerListToNewDAByBlame_IsValid);
		PlayCamShakeWithControlByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PlayCamShakeWithControlByClass");
		PlayCamShakeWithControlByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayCamShakeWithControlByClass_FunctionAddress);
		PlayCamShakeWithControlByClass_CameraShakeCls_Offset = NativeReflection.GetPropertyOffset(PlayCamShakeWithControlByClass_FunctionAddress, "CameraShakeCls");
		PlayCamShakeWithControlByClass_CameraShakeCls_IsValid = NativeReflection.ValidatePropertyClass(PlayCamShakeWithControlByClass_FunctionAddress, "CameraShakeCls", Classes.FClassProperty);
		PlayCamShakeWithControlByClass_Target_Offset = NativeReflection.GetPropertyOffset(PlayCamShakeWithControlByClass_FunctionAddress, "Target");
		PlayCamShakeWithControlByClass_Target_IsValid = NativeReflection.ValidatePropertyClass(PlayCamShakeWithControlByClass_FunctionAddress, "Target", Classes.FObjectProperty);
		PlayCamShakeWithControlByClass_IsValid = PlayCamShakeWithControlByClass_FunctionAddress != IntPtr.Zero && PlayCamShakeWithControlByClass_CameraShakeCls_IsValid && PlayCamShakeWithControlByClass_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PlayCamShakeWithControlByClass", PlayCamShakeWithControlByClass_IsValid);
		PauseCamShakeWithControlByActor_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PauseCamShakeWithControlByActor");
		PauseCamShakeWithControlByActor_ParamsSize = NativeReflection.GetFunctionParamsSize(PauseCamShakeWithControlByActor_FunctionAddress);
		PauseCamShakeWithControlByActor_Target_Offset = NativeReflection.GetPropertyOffset(PauseCamShakeWithControlByActor_FunctionAddress, "Target");
		PauseCamShakeWithControlByActor_Target_IsValid = NativeReflection.ValidatePropertyClass(PauseCamShakeWithControlByActor_FunctionAddress, "Target", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref PauseCamShakeWithControlByActor_bPause_PropertyAddress, PauseCamShakeWithControlByActor_FunctionAddress, "bPause");
		PauseCamShakeWithControlByActor_bPause_Offset = NativeReflection.GetPropertyOffset(PauseCamShakeWithControlByActor_FunctionAddress, "bPause");
		PauseCamShakeWithControlByActor_bPause_IsValid = NativeReflection.ValidatePropertyClass(PauseCamShakeWithControlByActor_FunctionAddress, "bPause", Classes.FBoolProperty);
		PauseCamShakeWithControlByActor_IsValid = PauseCamShakeWithControlByActor_FunctionAddress != IntPtr.Zero && PauseCamShakeWithControlByActor_Target_IsValid && PauseCamShakeWithControlByActor_bPause_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:PauseCamShakeWithControlByActor", PauseCamShakeWithControlByActor_IsValid);
		BGUSetDispInteractActorAttachTo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetDispInteractActorAttachTo");
		BGUSetDispInteractActorAttachTo_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetDispInteractActorAttachTo_FunctionAddress);
		BGUSetDispInteractActorAttachTo_AttachTo_Offset = NativeReflection.GetPropertyOffset(BGUSetDispInteractActorAttachTo_FunctionAddress, "AttachTo");
		BGUSetDispInteractActorAttachTo_AttachTo_IsValid = NativeReflection.ValidatePropertyClass(BGUSetDispInteractActorAttachTo_FunctionAddress, "AttachTo", Classes.FObjectProperty);
		BGUSetDispInteractActorAttachTo_IsValid = BGUSetDispInteractActorAttachTo_FunctionAddress != IntPtr.Zero && BGUSetDispInteractActorAttachTo_AttachTo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetDispInteractActorAttachTo", BGUSetDispInteractActorAttachTo_IsValid);
		BGUTryCastSpellWithStartSection_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUTryCastSpellWithStartSection");
		BGUTryCastSpellWithStartSection_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUTryCastSpellWithStartSection_FunctionAddress);
		BGUTryCastSpellWithStartSection_Unit_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpellWithStartSection_FunctionAddress, "Unit");
		BGUTryCastSpellWithStartSection_Unit_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpellWithStartSection_FunctionAddress, "Unit", Classes.FObjectProperty);
		BGUTryCastSpellWithStartSection_SkillID_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpellWithStartSection_FunctionAddress, "SkillID");
		BGUTryCastSpellWithStartSection_SkillID_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpellWithStartSection_FunctionAddress, "SkillID", Classes.FIntProperty);
		BGUTryCastSpellWithStartSection_MontageStartSectionName_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpellWithStartSection_FunctionAddress, "MontageStartSectionName");
		BGUTryCastSpellWithStartSection_MontageStartSectionName_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpellWithStartSection_FunctionAddress, "MontageStartSectionName", Classes.FNameProperty);
		BGUTryCastSpellWithStartSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUTryCastSpellWithStartSection_FunctionAddress, "ReturnValue");
		BGUTryCastSpellWithStartSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUTryCastSpellWithStartSection_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUTryCastSpellWithStartSection_IsValid = BGUTryCastSpellWithStartSection_FunctionAddress != IntPtr.Zero && BGUTryCastSpellWithStartSection_Unit_IsValid && BGUTryCastSpellWithStartSection_SkillID_IsValid && BGUTryCastSpellWithStartSection_MontageStartSectionName_IsValid && BGUTryCastSpellWithStartSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUTryCastSpellWithStartSection", BGUTryCastSpellWithStartSection_IsValid);
		BGUSetPlayerInSequenceTransition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUSetPlayerInSequenceTransition");
		BGUSetPlayerInSequenceTransition_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetPlayerInSequenceTransition_FunctionAddress);
		BGUSetPlayerInSequenceTransition_Owner_Offset = NativeReflection.GetPropertyOffset(BGUSetPlayerInSequenceTransition_FunctionAddress, "Owner");
		BGUSetPlayerInSequenceTransition_Owner_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPlayerInSequenceTransition_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref BGUSetPlayerInSequenceTransition_bValue_PropertyAddress, BGUSetPlayerInSequenceTransition_FunctionAddress, "bValue");
		BGUSetPlayerInSequenceTransition_bValue_Offset = NativeReflection.GetPropertyOffset(BGUSetPlayerInSequenceTransition_FunctionAddress, "bValue");
		BGUSetPlayerInSequenceTransition_bValue_IsValid = NativeReflection.ValidatePropertyClass(BGUSetPlayerInSequenceTransition_FunctionAddress, "bValue", Classes.FBoolProperty);
		BGUSetPlayerInSequenceTransition_IsValid = BGUSetPlayerInSequenceTransition_FunctionAddress != IntPtr.Zero && BGUSetPlayerInSequenceTransition_Owner_IsValid && BGUSetPlayerInSequenceTransition_bValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUSetPlayerInSequenceTransition", BGUSetPlayerInSequenceTransition_IsValid);
		BGUCheckSpecialConsumeItemUseAble_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGUCheckSpecialConsumeItemUseAble");
		BGUCheckSpecialConsumeItemUseAble_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCheckSpecialConsumeItemUseAble_FunctionAddress);
		BGUCheckSpecialConsumeItemUseAble_WorldContext_Offset = NativeReflection.GetPropertyOffset(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "WorldContext");
		BGUCheckSpecialConsumeItemUseAble_WorldContext_IsValid = NativeReflection.ValidatePropertyClass(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		BGUCheckSpecialConsumeItemUseAble_ItemID_Offset = NativeReflection.GetPropertyOffset(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "ItemID");
		BGUCheckSpecialConsumeItemUseAble_ItemID_IsValid = NativeReflection.ValidatePropertyClass(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "ItemID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BGUCheckSpecialConsumeItemUseAble_bShowTips_PropertyAddress, BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "bShowTips");
		BGUCheckSpecialConsumeItemUseAble_bShowTips_Offset = NativeReflection.GetPropertyOffset(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "bShowTips");
		BGUCheckSpecialConsumeItemUseAble_bShowTips_IsValid = NativeReflection.ValidatePropertyClass(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "bShowTips", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BGUCheckSpecialConsumeItemUseAble_ReturnValue_PropertyAddress, BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "ReturnValue");
		BGUCheckSpecialConsumeItemUseAble_ReturnValue_Offset = NativeReflection.GetPropertyOffset(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "ReturnValue");
		BGUCheckSpecialConsumeItemUseAble_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(BGUCheckSpecialConsumeItemUseAble_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUCheckSpecialConsumeItemUseAble_IsValid = BGUCheckSpecialConsumeItemUseAble_FunctionAddress != IntPtr.Zero && BGUCheckSpecialConsumeItemUseAble_WorldContext_IsValid && BGUCheckSpecialConsumeItemUseAble_ItemID_IsValid && BGUCheckSpecialConsumeItemUseAble_bShowTips_IsValid && BGUCheckSpecialConsumeItemUseAble_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:BGUCheckSpecialConsumeItemUseAble", BGUCheckSpecialConsumeItemUseAble_IsValid);
		GetGuibeiBoneTransformFromLastTick_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetGuibeiBoneTransformFromLastTick");
		GetGuibeiBoneTransformFromLastTick_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGuibeiBoneTransformFromLastTick_FunctionAddress);
		GetGuibeiBoneTransformFromLastTick_AnimSeq_Offset = NativeReflection.GetPropertyOffset(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "AnimSeq");
		GetGuibeiBoneTransformFromLastTick_AnimSeq_IsValid = NativeReflection.ValidatePropertyClass(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "AnimSeq", Classes.FObjectProperty);
		GetGuibeiBoneTransformFromLastTick_CurTime_Offset = NativeReflection.GetPropertyOffset(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "CurTime");
		GetGuibeiBoneTransformFromLastTick_CurTime_IsValid = NativeReflection.ValidatePropertyClass(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "CurTime", Classes.FFloatProperty);
		GetGuibeiBoneTransformFromLastTick_LastTime_Offset = NativeReflection.GetPropertyOffset(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "LastTime");
		GetGuibeiBoneTransformFromLastTick_LastTime_IsValid = NativeReflection.ValidatePropertyClass(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "LastTime", Classes.FFloatProperty);
		GetGuibeiBoneTransformFromLastTick_BoneName_Offset = NativeReflection.GetPropertyOffset(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "BoneName");
		GetGuibeiBoneTransformFromLastTick_BoneName_IsValid = NativeReflection.ValidatePropertyClass(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref GetGuibeiBoneTransformFromLastTick_ReturnValue_PropertyAddress, GetGuibeiBoneTransformFromLastTick_FunctionAddress, "ReturnValue");
		GetGuibeiBoneTransformFromLastTick_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "ReturnValue");
		GetGuibeiBoneTransformFromLastTick_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetGuibeiBoneTransformFromLastTick_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGuibeiBoneTransformFromLastTick_IsValid = GetGuibeiBoneTransformFromLastTick_FunctionAddress != IntPtr.Zero && GetGuibeiBoneTransformFromLastTick_AnimSeq_IsValid && GetGuibeiBoneTransformFromLastTick_CurTime_IsValid && GetGuibeiBoneTransformFromLastTick_LastTime_IsValid && GetGuibeiBoneTransformFromLastTick_BoneName_IsValid && GetGuibeiBoneTransformFromLastTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:GetGuibeiBoneTransformFromLastTick", GetGuibeiBoneTransformFromLastTick_IsValid);
		ExportTamerListToNewDAByWeaponInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportTamerListToNewDAByWeaponInfo");
		ExportTamerListToNewDAByWeaponInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportTamerListToNewDAByWeaponInfo_FunctionAddress);
		ExportTamerListToNewDAByWeaponInfo_Actor_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "Actor");
		ExportTamerListToNewDAByWeaponInfo_Actor_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByWeaponInfo_OldTamer_PropertyAddress, ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "OldTamer");
		ExportTamerListToNewDAByWeaponInfo_OldTamer_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "OldTamer");
		ExportTamerListToNewDAByWeaponInfo_OldTamer_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "OldTamer", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByWeaponInfo_NewTimer_PropertyAddress, ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "NewTimer");
		ExportTamerListToNewDAByWeaponInfo_NewTimer_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "NewTimer");
		ExportTamerListToNewDAByWeaponInfo_NewTimer_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "NewTimer", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByWeaponInfo_BlameName_PropertyAddress, ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "BlameName");
		ExportTamerListToNewDAByWeaponInfo_BlameName_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "BlameName");
		ExportTamerListToNewDAByWeaponInfo_BlameName_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "BlameName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ExportTamerListToNewDAByWeaponInfo_ReturnValue_PropertyAddress, ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "ReturnValue");
		ExportTamerListToNewDAByWeaponInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "ReturnValue");
		ExportTamerListToNewDAByWeaponInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ExportTamerListToNewDAByWeaponInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExportTamerListToNewDAByWeaponInfo_IsValid = ExportTamerListToNewDAByWeaponInfo_FunctionAddress != IntPtr.Zero && ExportTamerListToNewDAByWeaponInfo_Actor_IsValid && ExportTamerListToNewDAByWeaponInfo_OldTamer_IsValid && ExportTamerListToNewDAByWeaponInfo_NewTimer_IsValid && ExportTamerListToNewDAByWeaponInfo_BlameName_IsValid && ExportTamerListToNewDAByWeaponInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ExportTamerListToNewDAByWeaponInfo", ExportTamerListToNewDAByWeaponInfo_IsValid);
		RotateLevelRelativeToParentTransform_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RotateLevelRelativeToParentTransform");
		RotateLevelRelativeToParentTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(RotateLevelRelativeToParentTransform_FunctionAddress);
		RotateLevelRelativeToParentTransform_WorldContextObject_Offset = NativeReflection.GetPropertyOffset(RotateLevelRelativeToParentTransform_FunctionAddress, "WorldContextObject");
		RotateLevelRelativeToParentTransform_WorldContextObject_IsValid = NativeReflection.ValidatePropertyClass(RotateLevelRelativeToParentTransform_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		RotateLevelRelativeToParentTransform_LevelName_Offset = NativeReflection.GetPropertyOffset(RotateLevelRelativeToParentTransform_FunctionAddress, "LevelName");
		RotateLevelRelativeToParentTransform_LevelName_IsValid = NativeReflection.ValidatePropertyClass(RotateLevelRelativeToParentTransform_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref RotateLevelRelativeToParentTransform_ParentTransform_PropertyAddress, RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransform");
		RotateLevelRelativeToParentTransform_ParentTransform_Offset = NativeReflection.GetPropertyOffset(RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransform");
		RotateLevelRelativeToParentTransform_ParentTransform_IsValid = NativeReflection.ValidatePropertyClass(RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref RotateLevelRelativeToParentTransform_ParentTransformOffset_PropertyAddress, RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransformOffset");
		RotateLevelRelativeToParentTransform_ParentTransformOffset_Offset = NativeReflection.GetPropertyOffset(RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransformOffset");
		RotateLevelRelativeToParentTransform_ParentTransformOffset_IsValid = NativeReflection.ValidatePropertyClass(RotateLevelRelativeToParentTransform_FunctionAddress, "ParentTransformOffset", Classes.FStructProperty);
		RotateLevelRelativeToParentTransform_IsValid = RotateLevelRelativeToParentTransform_FunctionAddress != IntPtr.Zero && RotateLevelRelativeToParentTransform_WorldContextObject_IsValid && RotateLevelRelativeToParentTransform_LevelName_IsValid && RotateLevelRelativeToParentTransform_ParentTransform_IsValid && RotateLevelRelativeToParentTransform_ParentTransformOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:RotateLevelRelativeToParentTransform", RotateLevelRelativeToParentTransform_IsValid);
		CalTransformRelativeToParentTransformOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CalTransformRelativeToParentTransformOffset");
		CalTransformRelativeToParentTransformOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(CalTransformRelativeToParentTransformOffset_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CalTransformRelativeToParentTransformOffset_SelfTransform_PropertyAddress, CalTransformRelativeToParentTransformOffset_FunctionAddress, "SelfTransform");
		CalTransformRelativeToParentTransformOffset_SelfTransform_Offset = NativeReflection.GetPropertyOffset(CalTransformRelativeToParentTransformOffset_FunctionAddress, "SelfTransform");
		CalTransformRelativeToParentTransformOffset_SelfTransform_IsValid = NativeReflection.ValidatePropertyClass(CalTransformRelativeToParentTransformOffset_FunctionAddress, "SelfTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalTransformRelativeToParentTransformOffset_ParentTransform_PropertyAddress, CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransform");
		CalTransformRelativeToParentTransformOffset_ParentTransform_Offset = NativeReflection.GetPropertyOffset(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransform");
		CalTransformRelativeToParentTransformOffset_ParentTransform_IsValid = NativeReflection.ValidatePropertyClass(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransform", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalTransformRelativeToParentTransformOffset_ParentTransformOffset_PropertyAddress, CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransformOffset");
		CalTransformRelativeToParentTransformOffset_ParentTransformOffset_Offset = NativeReflection.GetPropertyOffset(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransformOffset");
		CalTransformRelativeToParentTransformOffset_ParentTransformOffset_IsValid = NativeReflection.ValidatePropertyClass(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ParentTransformOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CalTransformRelativeToParentTransformOffset_ReturnValue_PropertyAddress, CalTransformRelativeToParentTransformOffset_FunctionAddress, "ReturnValue");
		CalTransformRelativeToParentTransformOffset_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ReturnValue");
		CalTransformRelativeToParentTransformOffset_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CalTransformRelativeToParentTransformOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CalTransformRelativeToParentTransformOffset_IsValid = CalTransformRelativeToParentTransformOffset_FunctionAddress != IntPtr.Zero && CalTransformRelativeToParentTransformOffset_SelfTransform_IsValid && CalTransformRelativeToParentTransformOffset_ParentTransform_IsValid && CalTransformRelativeToParentTransformOffset_ParentTransformOffset_IsValid && CalTransformRelativeToParentTransformOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:CalTransformRelativeToParentTransformOffset", CalTransformRelativeToParentTransformOffset_IsValid);
		ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectWorldLocationToWidgetPositionWithSZInS");
		ProjectWorldLocationToWidgetPositionWithSZInS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress);
		ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_Offset = NativeReflection.GetPropertyOffset(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "PlayerController");
		ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_IsValid = NativeReflection.ValidatePropertyClass(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_PropertyAddress, ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "WorldPos");
		ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_Offset = NativeReflection.GetPropertyOffset(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "WorldPos");
		ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_IsValid = NativeReflection.ValidatePropertyClass(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "WorldPos", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_PropertyAddress, ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "ScreenPos");
		ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_Offset = NativeReflection.GetPropertyOffset(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "ScreenPos");
		ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_IsValid = NativeReflection.ValidatePropertyClass(ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress, "ScreenPos", Classes.FStructProperty);
		ProjectWorldLocationToWidgetPositionWithSZInS_IsValid = ProjectWorldLocationToWidgetPositionWithSZInS_FunctionAddress != IntPtr.Zero && ProjectWorldLocationToWidgetPositionWithSZInS_PlayerController_IsValid && ProjectWorldLocationToWidgetPositionWithSZInS_WorldPos_IsValid && ProjectWorldLocationToWidgetPositionWithSZInS_ScreenPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFunctionLibraryCS:ProjectWorldLocationToWidgetPositionWithSZInS", ProjectWorldLocationToWidgetPositionWithSZInS_IsValid);
	}

	static BGUFunctionLibraryCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFunctionLibraryCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFunctionLibraryCS));
	}
}

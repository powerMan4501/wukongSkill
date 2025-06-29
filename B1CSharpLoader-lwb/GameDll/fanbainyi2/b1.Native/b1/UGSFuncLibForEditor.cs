using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptEditor;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Runtime;
using UnrealEngine.StaticMeshEditor;
using UnrealEngine.SubobjectDataInterface;
using UnrealEngine.UnrealEd;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSFuncLibForEditor : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateFindInAssetsData_IsValid;

	private static IntPtr UpdateFindInAssetsData_FunctionAddress;

	private static int UpdateFindInAssetsData_ParamsSize;

	private static bool ShowNotifyText_IsValid;

	private static IntPtr ShowNotifyText_FunctionAddress;

	private static int ShowNotifyText_ParamsSize;

	private static bool ShowNotifyText_InNotifyText_IsValid;

	private static FFieldAddress ShowNotifyText_InNotifyText_PropertyAddress;

	private static int ShowNotifyText_InNotifyText_Offset;

	private static bool ShowMassageDialog_IsValid;

	private static IntPtr ShowMassageDialog_FunctionAddress;

	private static int ShowMassageDialog_ParamsSize;

	private static bool ShowMassageDialog_Message_IsValid;

	private static FFieldAddress ShowMassageDialog_Message_PropertyAddress;

	private static int ShowMassageDialog_Message_Offset;

	private static bool SetViewportType_IsValid;

	private static IntPtr SetViewportType_FunctionAddress;

	private static int SetViewportType_ParamsSize;

	private static bool SetViewportType_InViewportType_IsValid;

	private static FFieldAddress SetViewportType_InViewportType_PropertyAddress;

	private static int SetViewportType_InViewportType_Offset;

	private static bool SetViewMode_IsValid;

	private static IntPtr SetViewMode_FunctionAddress;

	private static int SetViewMode_ParamsSize;

	private static bool SetViewMode_InViewModeIndex_IsValid;

	private static FFieldAddress SetViewMode_InViewModeIndex_PropertyAddress;

	private static int SetViewMode_InViewModeIndex_Offset;

	private static bool SetStatic_IsValid;

	private static IntPtr SetStatic_FunctionAddress;

	private static int SetStatic_ParamsSize;

	private static bool SetStatic_InObj_IsValid;

	private static FFieldAddress SetStatic_InObj_PropertyAddress;

	private static int SetStatic_InObj_Offset;

	private static bool SetSplineCompIsEdited_IsValid;

	private static IntPtr SetSplineCompIsEdited_FunctionAddress;

	private static int SetSplineCompIsEdited_ParamsSize;

	private static bool SetSplineCompIsEdited_SplineComp_IsValid;

	private static FFieldAddress SetSplineCompIsEdited_SplineComp_PropertyAddress;

	private static int SetSplineCompIsEdited_SplineComp_Offset;

	private static bool SetSplineCompIsEdited_IsEdited_IsValid;

	private static FFieldAddress SetSplineCompIsEdited_IsEdited_PropertyAddress;

	private static int SetSplineCompIsEdited_IsEdited_Offset;

	private static bool SetPreloadLevel_IsValid;

	private static IntPtr SetPreloadLevel_FunctionAddress;

	private static int SetPreloadLevel_ParamsSize;

	private static bool SetPreloadLevel_PreloadLevel_IsValid;

	private static FFieldAddress SetPreloadLevel_PreloadLevel_PropertyAddress;

	private static int SetPreloadLevel_PreloadLevel_Offset;

	private static bool SetNiagaraDisable_IsValid;

	private static IntPtr SetNiagaraDisable_FunctionAddress;

	private static int SetNiagaraDisable_ParamsSize;

	private static bool SetNiagaraDisable_Disable_IsValid;

	private static FFieldAddress SetNiagaraDisable_Disable_PropertyAddress;

	private static int SetNiagaraDisable_Disable_Offset;

	private static bool SetClothingAssetSelfCollision_IsValid;

	private static IntPtr SetClothingAssetSelfCollision_FunctionAddress;

	private static int SetClothingAssetSelfCollision_ParamsSize;

	private static bool SetClothingAssetSelfCollision_InSkeletalMesh_IsValid;

	private static FFieldAddress SetClothingAssetSelfCollision_InSkeletalMesh_PropertyAddress;

	private static int SetClothingAssetSelfCollision_InSkeletalMesh_Offset;

	private static bool SetClothingAssetSelfCollision_NewSelfCollision_IsValid;

	private static FFieldAddress SetClothingAssetSelfCollision_NewSelfCollision_PropertyAddress;

	private static int SetClothingAssetSelfCollision_NewSelfCollision_Offset;

	private static bool SetCinematicActorLock_IsValid;

	private static IntPtr SetCinematicActorLock_FunctionAddress;

	private static int SetCinematicActorLock_ParamsSize;

	private static bool SetCinematicActorLock_Actor_IsValid;

	private static FFieldAddress SetCinematicActorLock_Actor_PropertyAddress;

	private static int SetCinematicActorLock_Actor_Offset;

	private static bool SetActorSelectionState_IsValid;

	private static IntPtr SetActorSelectionState_FunctionAddress;

	private static int SetActorSelectionState_ParamsSize;

	private static bool SetActorSelectionState_Actor_IsValid;

	private static FFieldAddress SetActorSelectionState_Actor_PropertyAddress;

	private static int SetActorSelectionState_Actor_Offset;

	private static bool SetActorSelectionState_bShouldBeSelected_IsValid;

	private static FFieldAddress SetActorSelectionState_bShouldBeSelected_PropertyAddress;

	private static int SetActorSelectionState_bShouldBeSelected_Offset;

	private static bool SetActorLock_IsValid;

	private static IntPtr SetActorLock_FunctionAddress;

	private static int SetActorLock_ParamsSize;

	private static bool SetActorLock_Actor_IsValid;

	private static FFieldAddress SetActorLock_Actor_PropertyAddress;

	private static int SetActorLock_Actor_Offset;

	private static bool SetActorLabel_IsValid;

	private static IntPtr SetActorLabel_FunctionAddress;

	private static int SetActorLabel_ParamsSize;

	private static bool SetActorLabel_InActor_IsValid;

	private static FFieldAddress SetActorLabel_InActor_PropertyAddress;

	private static int SetActorLabel_InActor_Offset;

	private static bool SetActorLabel_InLabel_IsValid;

	private static FFieldAddress SetActorLabel_InLabel_PropertyAddress;

	private static int SetActorLabel_InLabel_Offset;

	private static bool ResetClothingAssetConfig_IsValid;

	private static IntPtr ResetClothingAssetConfig_FunctionAddress;

	private static int ResetClothingAssetConfig_ParamsSize;

	private static bool ResetClothingAssetConfig_InSkeletalMesh_IsValid;

	private static FFieldAddress ResetClothingAssetConfig_InSkeletalMesh_PropertyAddress;

	private static int ResetClothingAssetConfig_InSkeletalMesh_Offset;

	private static bool ReplaceHISMByFoliageType_IsValid;

	private static IntPtr ReplaceHISMByFoliageType_FunctionAddress;

	private static int ReplaceHISMByFoliageType_ParamsSize;

	private static bool ReplaceHISMByFoliageType_WorldContext_IsValid;

	private static FFieldAddress ReplaceHISMByFoliageType_WorldContext_PropertyAddress;

	private static int ReplaceHISMByFoliageType_WorldContext_Offset;

	private static bool ReplaceHISMByFoliageType_oldFoliageType_IsValid;

	private static FFieldAddress ReplaceHISMByFoliageType_oldFoliageType_PropertyAddress;

	private static int ReplaceHISMByFoliageType_oldFoliageType_Offset;

	private static bool ReplaceHISMByFoliageType_newFoliageType_IsValid;

	private static FFieldAddress ReplaceHISMByFoliageType_newFoliageType_PropertyAddress;

	private static int ReplaceHISMByFoliageType_newFoliageType_Offset;

	private static bool ReimportAssets_IsValid;

	private static IntPtr ReimportAssets_FunctionAddress;

	private static int ReimportAssets_ParamsSize;

	private static bool ReimportAssets_ReimportAssets_IsValid;

	private static FFieldAddress ReimportAssets_ReimportAssets_PropertyAddress;

	private static int ReimportAssets_ReimportAssets_Offset;

	private static bool ReimportAssets_bShowNotification_IsValid;

	private static FFieldAddress ReimportAssets_bShowNotification_PropertyAddress;

	private static int ReimportAssets_bShowNotification_Offset;

	private static bool ReimportAssets_SourceFileIndex_IsValid;

	private static FFieldAddress ReimportAssets_SourceFileIndex_PropertyAddress;

	private static int ReimportAssets_SourceFileIndex_Offset;

	private static bool ReimportAssets_bForceNewFile_IsValid;

	private static FFieldAddress ReimportAssets_bForceNewFile_PropertyAddress;

	private static int ReimportAssets_bForceNewFile_Offset;

	private static bool ReimportAssets_bAutomated_IsValid;

	private static FFieldAddress ReimportAssets_bAutomated_PropertyAddress;

	private static int ReimportAssets_bAutomated_Offset;

	private static bool RegisterPropertyTypeCustomizationDetails_IsValid;

	private static IntPtr RegisterPropertyTypeCustomizationDetails_FunctionAddress;

	private static int RegisterPropertyTypeCustomizationDetails_ParamsSize;

	private static bool RegisterPropertyTypeCustomizationDetails_StructName_IsValid;

	private static FFieldAddress RegisterPropertyTypeCustomizationDetails_StructName_PropertyAddress;

	private static int RegisterPropertyTypeCustomizationDetails_StructName_Offset;

	private static bool RegisterPropertyTypeCustomizationDetails_EnumType_IsValid;

	private static FFieldAddress RegisterPropertyTypeCustomizationDetails_EnumType_PropertyAddress;

	private static int RegisterPropertyTypeCustomizationDetails_EnumType_Offset;

	private static bool RegisterPropertyTypeCustomizationDetails_Properties_IsValid;

	private static FFieldAddress RegisterPropertyTypeCustomizationDetails_Properties_PropertyAddress;

	private static int RegisterPropertyTypeCustomizationDetails_Properties_Offset;

	private static bool PIEStart_IsValid;

	private static IntPtr PIEStart_FunctionAddress;

	private static int PIEStart_ParamsSize;

	private static bool PasteSubobjects_IsValid;

	private static IntPtr PasteSubobjects_FunctionAddress;

	private static int PasteSubobjects_ParamsSize;

	private static bool PasteSubobjects_PasteToContext_IsValid;

	private static FFieldAddress PasteSubobjects_PasteToContext_PropertyAddress;

	private static int PasteSubobjects_PasteToContext_Offset;

	private static bool PasteSubobjects_NewParentHandles_IsValid;

	private static FFieldAddress PasteSubobjects_NewParentHandles_PropertyAddress;

	private static int PasteSubobjects_NewParentHandles_Offset;

	private static bool PasteSubobjects_BpContext_IsValid;

	private static FFieldAddress PasteSubobjects_BpContext_PropertyAddress;

	private static int PasteSubobjects_BpContext_Offset;

	private static bool PasteSubobjects_OutPastedHandles_IsValid;

	private static FFieldAddress PasteSubobjects_OutPastedHandles_PropertyAddress;

	private static int PasteSubobjects_OutPastedHandles_Offset;

	private static bool OnActorUnlock_IsValid;

	private static IntPtr OnActorUnlock_FunctionAddress;

	private static int OnActorUnlock_ParamsSize;

	private static bool OnActorLockToggleFromMenu_IsValid;

	private static IntPtr OnActorLockToggleFromMenu_FunctionAddress;

	private static int OnActorLockToggleFromMenu_ParamsSize;

	private static bool OnActorLockToggleFromMenu_Actor_IsValid;

	private static FFieldAddress OnActorLockToggleFromMenu_Actor_PropertyAddress;

	private static int OnActorLockToggleFromMenu_Actor_Offset;

	private static bool ModifyStaticMeshActorGenerateLightMap_IsValid;

	private static IntPtr ModifyStaticMeshActorGenerateLightMap_FunctionAddress;

	private static int ModifyStaticMeshActorGenerateLightMap_ParamsSize;

	private static bool ModifyStaticMeshActorGenerateLightMap_enable_IsValid;

	private static FFieldAddress ModifyStaticMeshActorGenerateLightMap_enable_PropertyAddress;

	private static int ModifyStaticMeshActorGenerateLightMap_enable_Offset;

	private static bool MergeShaderCodeFiles_IsValid;

	private static IntPtr MergeShaderCodeFiles_FunctionAddress;

	private static int MergeShaderCodeFiles_ParamsSize;

	private static bool MergeShaderCodeFiles_OldDir_IsValid;

	private static FFieldAddress MergeShaderCodeFiles_OldDir_PropertyAddress;

	private static int MergeShaderCodeFiles_OldDir_Offset;

	private static bool MergeShaderCodeFiles_NewDir_IsValid;

	private static FFieldAddress MergeShaderCodeFiles_NewDir_PropertyAddress;

	private static int MergeShaderCodeFiles_NewDir_Offset;

	private static bool MergeShaderCodeFiles_OutputDir_IsValid;

	private static FFieldAddress MergeShaderCodeFiles_OutputDir_PropertyAddress;

	private static int MergeShaderCodeFiles_OutputDir_Offset;

	private static bool MergeShaderCodeFiles_ReturnValue_IsValid;

	private static FFieldAddress MergeShaderCodeFiles_ReturnValue_PropertyAddress;

	private static int MergeShaderCodeFiles_ReturnValue_Offset;

	private static bool LoadObjectsFromAssetData_IsValid;

	private static IntPtr LoadObjectsFromAssetData_FunctionAddress;

	private static int LoadObjectsFromAssetData_ParamsSize;

	private static bool LoadObjectsFromAssetData_Assets_IsValid;

	private static FFieldAddress LoadObjectsFromAssetData_Assets_PropertyAddress;

	private static int LoadObjectsFromAssetData_Assets_Offset;

	private static bool LoadObjectsFromAssetData_ReturnValue_IsValid;

	private static FFieldAddress LoadObjectsFromAssetData_ReturnValue_PropertyAddress;

	private static int LoadObjectsFromAssetData_ReturnValue_Offset;

	private static bool IsPlayInPreview_IsValid;

	private static IntPtr IsPlayInPreview_FunctionAddress;

	private static int IsPlayInPreview_ParamsSize;

	private static bool IsPlayInPreview_World_IsValid;

	private static FFieldAddress IsPlayInPreview_World_PropertyAddress;

	private static int IsPlayInPreview_World_Offset;

	private static bool IsPlayInPreview_ReturnValue_IsValid;

	private static FFieldAddress IsPlayInPreview_ReturnValue_PropertyAddress;

	private static int IsPlayInPreview_ReturnValue_Offset;

	private static bool IsPlayInEditor_IsValid;

	private static IntPtr IsPlayInEditor_FunctionAddress;

	private static int IsPlayInEditor_ParamsSize;

	private static bool IsPlayInEditor_World_IsValid;

	private static FFieldAddress IsPlayInEditor_World_PropertyAddress;

	private static int IsPlayInEditor_World_Offset;

	private static bool IsPlayInEditor_ReturnValue_IsValid;

	private static FFieldAddress IsPlayInEditor_ReturnValue_PropertyAddress;

	private static int IsPlayInEditor_ReturnValue_Offset;

	private static bool IsPackageExist_IsValid;

	private static IntPtr IsPackageExist_FunctionAddress;

	private static int IsPackageExist_ParamsSize;

	private static bool IsPackageExist_PathName_IsValid;

	private static FFieldAddress IsPackageExist_PathName_PropertyAddress;

	private static int IsPackageExist_PathName_Offset;

	private static bool IsPackageExist_ReturnValue_IsValid;

	private static FFieldAddress IsPackageExist_ReturnValue_PropertyAddress;

	private static int IsPackageExist_ReturnValue_Offset;

	private static bool IsGameWorld_IsValid;

	private static IntPtr IsGameWorld_FunctionAddress;

	private static int IsGameWorld_ParamsSize;

	private static bool IsGameWorld_World_IsValid;

	private static FFieldAddress IsGameWorld_World_PropertyAddress;

	private static int IsGameWorld_World_Offset;

	private static bool IsGameWorld_ReturnValue_IsValid;

	private static FFieldAddress IsGameWorld_ReturnValue_PropertyAddress;

	private static int IsGameWorld_ReturnValue_Offset;

	private static bool IsEditorWorld_IsValid;

	private static IntPtr IsEditorWorld_FunctionAddress;

	private static int IsEditorWorld_ParamsSize;

	private static bool IsEditorWorld_World_IsValid;

	private static FFieldAddress IsEditorWorld_World_PropertyAddress;

	private static int IsEditorWorld_World_Offset;

	private static bool IsEditorWorld_ReturnValue_IsValid;

	private static FFieldAddress IsEditorWorld_ReturnValue_PropertyAddress;

	private static int IsEditorWorld_ReturnValue_Offset;

	private static bool ImportAssets_IsValid;

	private static IntPtr ImportAssets_FunctionAddress;

	private static int ImportAssets_ParamsSize;

	private static bool ImportAssets_FilePaths_IsValid;

	private static FFieldAddress ImportAssets_FilePaths_PropertyAddress;

	private static int ImportAssets_FilePaths_Offset;

	private static bool ImportAssets_DestinationPath_IsValid;

	private static FFieldAddress ImportAssets_DestinationPath_PropertyAddress;

	private static int ImportAssets_DestinationPath_Offset;

	private static bool ImportAssets_ReturnValue_IsValid;

	private static FFieldAddress ImportAssets_ReturnValue_PropertyAddress;

	private static int ImportAssets_ReturnValue_Offset;

	private static bool GSToggleFixMapPIEMode_IsValid;

	private static IntPtr GSToggleFixMapPIEMode_FunctionAddress;

	private static int GSToggleFixMapPIEMode_ParamsSize;

	private static bool GSToggleEditorMode_IsValid;

	private static IntPtr GSToggleEditorMode_FunctionAddress;

	private static int GSToggleEditorMode_ParamsSize;

	private static bool GSToggleEditorMode_InEdName_IsValid;

	private static FFieldAddress GSToggleEditorMode_InEdName_PropertyAddress;

	private static int GSToggleEditorMode_InEdName_Offset;

	private static bool GSGenerateLODLevels_IsValid;

	private static IntPtr GSGenerateLODLevels_FunctionAddress;

	private static int GSGenerateLODLevels_ParamsSize;

	private static bool GSGenerateLODLevels_LevelName_IsValid;

	private static FFieldAddress GSGenerateLODLevels_LevelName_PropertyAddress;

	private static int GSGenerateLODLevels_LevelName_Offset;

	private static bool GSGenerateLODLevel_IsValid;

	private static IntPtr GSGenerateLODLevel_FunctionAddress;

	private static int GSGenerateLODLevel_ParamsSize;

	private static bool GSGenerateLODLevel_LevelName_IsValid;

	private static FFieldAddress GSGenerateLODLevel_LevelName_PropertyAddress;

	private static int GSGenerateLODLevel_LevelName_Offset;

	private static bool GSGenerateLODLevel_TargetLODIndex_IsValid;

	private static FFieldAddress GSGenerateLODLevel_TargetLODIndex_PropertyAddress;

	private static int GSGenerateLODLevel_TargetLODIndex_Offset;

	private static bool GetTagNameBySocketName_IsValid;

	private static IntPtr GetTagNameBySocketName_FunctionAddress;

	private static int GetTagNameBySocketName_ParamsSize;

	private static bool GetTagNameBySocketName_StaticMesh_IsValid;

	private static FFieldAddress GetTagNameBySocketName_StaticMesh_PropertyAddress;

	private static int GetTagNameBySocketName_StaticMesh_Offset;

	private static bool GetTagNameBySocketName_SocketName_IsValid;

	private static FFieldAddress GetTagNameBySocketName_SocketName_PropertyAddress;

	private static int GetTagNameBySocketName_SocketName_Offset;

	private static bool GetTagNameBySocketName_ReturnValue_IsValid;

	private static FFieldAddress GetTagNameBySocketName_ReturnValue_PropertyAddress;

	private static int GetTagNameBySocketName_ReturnValue_Offset;

	private static bool GetStaticMeshEditorSubsystem_IsValid;

	private static IntPtr GetStaticMeshEditorSubsystem_FunctionAddress;

	private static int GetStaticMeshEditorSubsystem_ParamsSize;

	private static bool GetStaticMeshEditorSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetStaticMeshEditorSubsystem_ReturnValue_PropertyAddress;

	private static int GetStaticMeshEditorSubsystem_ReturnValue_Offset;

	private static bool GetSelectedFolders_IsValid;

	private static IntPtr GetSelectedFolders_FunctionAddress;

	private static int GetSelectedFolders_ParamsSize;

	private static bool GetSelectedFolders_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedFolders_ReturnValue_PropertyAddress;

	private static int GetSelectedFolders_ReturnValue_Offset;

	private static bool GetSelectedAssets_IsValid;

	private static IntPtr GetSelectedAssets_FunctionAddress;

	private static int GetSelectedAssets_ParamsSize;

	private static bool GetSelectedAssets_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedAssets_ReturnValue_PropertyAddress;

	private static int GetSelectedAssets_ReturnValue_Offset;

	private static bool GetReferenceAssetsFromObjects_IsValid;

	private static IntPtr GetReferenceAssetsFromObjects_FunctionAddress;

	private static int GetReferenceAssetsFromObjects_ParamsSize;

	private static bool GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid;

	private static FFieldAddress GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress;

	private static int GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset;

	private static bool GetReferenceAssetsFromObjects_ReturnValue_IsValid;

	private static FFieldAddress GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress;

	private static int GetReferenceAssetsFromObjects_ReturnValue_Offset;

	private static bool GetReferenceAssetsFromAssets_IsValid;

	private static IntPtr GetReferenceAssetsFromAssets_FunctionAddress;

	private static int GetReferenceAssetsFromAssets_ParamsSize;

	private static bool GetReferenceAssetsFromAssets_Assets_IsValid;

	private static FFieldAddress GetReferenceAssetsFromAssets_Assets_PropertyAddress;

	private static int GetReferenceAssetsFromAssets_Assets_Offset;

	private static bool GetReferenceAssetsFromAssets_ReturnValue_IsValid;

	private static FFieldAddress GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress;

	private static int GetReferenceAssetsFromAssets_ReturnValue_Offset;

	private static bool GetPreviewStaticMeshBySocketName_IsValid;

	private static IntPtr GetPreviewStaticMeshBySocketName_FunctionAddress;

	private static int GetPreviewStaticMeshBySocketName_ParamsSize;

	private static bool GetPreviewStaticMeshBySocketName_StaticMesh_IsValid;

	private static FFieldAddress GetPreviewStaticMeshBySocketName_StaticMesh_PropertyAddress;

	private static int GetPreviewStaticMeshBySocketName_StaticMesh_Offset;

	private static bool GetPreviewStaticMeshBySocketName_SocketName_IsValid;

	private static FFieldAddress GetPreviewStaticMeshBySocketName_SocketName_PropertyAddress;

	private static int GetPreviewStaticMeshBySocketName_SocketName_Offset;

	private static bool GetPreviewStaticMeshBySocketName_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewStaticMeshBySocketName_ReturnValue_PropertyAddress;

	private static int GetPreviewStaticMeshBySocketName_ReturnValue_Offset;

	private static bool GetLevelFoliageInstanceBounds_IsValid;

	private static IntPtr GetLevelFoliageInstanceBounds_FunctionAddress;

	private static int GetLevelFoliageInstanceBounds_ParamsSize;

	private static bool GetLevelFoliageInstanceBounds_Level_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceBounds_Level_PropertyAddress;

	private static int GetLevelFoliageInstanceBounds_Level_Offset;

	private static bool GetLevelFoliageInstanceBounds_ReturnValue_IsValid;

	private static FFieldAddress GetLevelFoliageInstanceBounds_ReturnValue_PropertyAddress;

	private static int GetLevelFoliageInstanceBounds_ReturnValue_Offset;

	private static bool GetFactoryForAssetObject_IsValid;

	private static IntPtr GetFactoryForAssetObject_FunctionAddress;

	private static int GetFactoryForAssetObject_ParamsSize;

	private static bool GetFactoryForAssetObject_AssetObject_IsValid;

	private static FFieldAddress GetFactoryForAssetObject_AssetObject_PropertyAddress;

	private static int GetFactoryForAssetObject_AssetObject_Offset;

	private static bool GetFactoryForAssetObject_ReturnValue_IsValid;

	private static FFieldAddress GetFactoryForAssetObject_ReturnValue_PropertyAddress;

	private static int GetFactoryForAssetObject_ReturnValue_Offset;

	private static bool GetEditorWorld_IsValid;

	private static IntPtr GetEditorWorld_FunctionAddress;

	private static int GetEditorWorld_ParamsSize;

	private static bool GetEditorWorld_ReturnValue_IsValid;

	private static FFieldAddress GetEditorWorld_ReturnValue_PropertyAddress;

	private static int GetEditorWorld_ReturnValue_Offset;

	private static bool GetEditorActorSubsystem_IsValid;

	private static IntPtr GetEditorActorSubsystem_FunctionAddress;

	private static int GetEditorActorSubsystem_ParamsSize;

	private static bool GetEditorActorSubsystem_ReturnValue_IsValid;

	private static FFieldAddress GetEditorActorSubsystem_ReturnValue_PropertyAddress;

	private static int GetEditorActorSubsystem_ReturnValue_Offset;

	private static bool GetCDONodeComponents_IsValid;

	private static IntPtr GetCDONodeComponents_FunctionAddress;

	private static int GetCDONodeComponents_ParamsSize;

	private static bool GetCDONodeComponents_CDO_IsValid;

	private static FFieldAddress GetCDONodeComponents_CDO_PropertyAddress;

	private static int GetCDONodeComponents_CDO_Offset;

	private static bool GetCDONodeComponents_ReturnValue_IsValid;

	private static FFieldAddress GetCDONodeComponents_ReturnValue_PropertyAddress;

	private static int GetCDONodeComponents_ReturnValue_Offset;

	private static bool GetCDOComponentByName_IsValid;

	private static IntPtr GetCDOComponentByName_FunctionAddress;

	private static int GetCDOComponentByName_ParamsSize;

	private static bool GetCDOComponentByName_BP_IsValid;

	private static FFieldAddress GetCDOComponentByName_BP_PropertyAddress;

	private static int GetCDOComponentByName_BP_Offset;

	private static bool GetCDOComponentByName_CompName_IsValid;

	private static FFieldAddress GetCDOComponentByName_CompName_PropertyAddress;

	private static int GetCDOComponentByName_CompName_Offset;

	private static bool GetCDOComponentByName_bCreateInheritable_IsValid;

	private static FFieldAddress GetCDOComponentByName_bCreateInheritable_PropertyAddress;

	private static int GetCDOComponentByName_bCreateInheritable_Offset;

	private static bool GetCDOComponentByName_ReturnValue_IsValid;

	private static FFieldAddress GetCDOComponentByName_ReturnValue_PropertyAddress;

	private static int GetCDOComponentByName_ReturnValue_Offset;

	private static bool GetBlueprintCDOComponentByName_IsValid;

	private static IntPtr GetBlueprintCDOComponentByName_FunctionAddress;

	private static int GetBlueprintCDOComponentByName_ParamsSize;

	private static bool GetBlueprintCDOComponentByName_BP_IsValid;

	private static FFieldAddress GetBlueprintCDOComponentByName_BP_PropertyAddress;

	private static int GetBlueprintCDOComponentByName_BP_Offset;

	private static bool GetBlueprintCDOComponentByName_CompName_IsValid;

	private static FFieldAddress GetBlueprintCDOComponentByName_CompName_PropertyAddress;

	private static int GetBlueprintCDOComponentByName_CompName_Offset;

	private static bool GetBlueprintCDOComponentByName_ReturnValue_IsValid;

	private static FFieldAddress GetBlueprintCDOComponentByName_ReturnValue_PropertyAddress;

	private static int GetBlueprintCDOComponentByName_ReturnValue_Offset;

	private static bool GetAssetsInFolder_IsValid;

	private static IntPtr GetAssetsInFolder_FunctionAddress;

	private static int GetAssetsInFolder_ParamsSize;

	private static bool GetAssetsInFolder_FolderPath_IsValid;

	private static FFieldAddress GetAssetsInFolder_FolderPath_PropertyAddress;

	private static int GetAssetsInFolder_FolderPath_Offset;

	private static bool GetAssetsInFolder_bRecursive_IsValid;

	private static FFieldAddress GetAssetsInFolder_bRecursive_PropertyAddress;

	private static int GetAssetsInFolder_bRecursive_Offset;

	private static bool GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetsInFolder_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsInFolder_ReturnValue_PropertyAddress;

	private static int GetAssetsInFolder_ReturnValue_Offset;

	private static bool GetAssetDataFromPackageObj_IsValid;

	private static IntPtr GetAssetDataFromPackageObj_FunctionAddress;

	private static int GetAssetDataFromPackageObj_ParamsSize;

	private static bool GetAssetDataFromPackageObj_PackageObjects_IsValid;

	private static FFieldAddress GetAssetDataFromPackageObj_PackageObjects_PropertyAddress;

	private static int GetAssetDataFromPackageObj_PackageObjects_Offset;

	private static bool GetAssetDataFromPackageObj_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataFromPackageObj_ReturnValue_PropertyAddress;

	private static int GetAssetDataFromPackageObj_ReturnValue_Offset;

	private static bool GetAllComponentTemplateInBlueprint_IsValid;

	private static IntPtr GetAllComponentTemplateInBlueprint_FunctionAddress;

	private static int GetAllComponentTemplateInBlueprint_ParamsSize;

	private static bool GetAllComponentTemplateInBlueprint_Blueprint_IsValid;

	private static FFieldAddress GetAllComponentTemplateInBlueprint_Blueprint_PropertyAddress;

	private static int GetAllComponentTemplateInBlueprint_Blueprint_Offset;

	private static bool GetAllComponentTemplateInBlueprint_ReturnValue_IsValid;

	private static FFieldAddress GetAllComponentTemplateInBlueprint_ReturnValue_PropertyAddress;

	private static int GetAllComponentTemplateInBlueprint_ReturnValue_Offset;

	private static bool GetActorPlacementLocationOnCursor_IsValid;

	private static IntPtr GetActorPlacementLocationOnCursor_FunctionAddress;

	private static int GetActorPlacementLocationOnCursor_ParamsSize;

	private static bool GetActorPlacementLocationOnCursor_Actor_IsValid;

	private static FFieldAddress GetActorPlacementLocationOnCursor_Actor_PropertyAddress;

	private static int GetActorPlacementLocationOnCursor_Actor_Offset;

	private static bool GetActorPlacementLocationOnCursor_ReturnValue_IsValid;

	private static FFieldAddress GetActorPlacementLocationOnCursor_ReturnValue_PropertyAddress;

	private static int GetActorPlacementLocationOnCursor_ReturnValue_Offset;

	private static bool GEditor_ValidateSceneRootNodes_IsValid;

	private static IntPtr GEditor_ValidateSceneRootNodes_FunctionAddress;

	private static int GEditor_ValidateSceneRootNodes_ParamsSize;

	private static bool GEditor_ValidateSceneRootNodes_BlueprintObj_IsValid;

	private static FFieldAddress GEditor_ValidateSceneRootNodes_BlueprintObj_PropertyAddress;

	private static int GEditor_ValidateSceneRootNodes_BlueprintObj_Offset;

	private static bool GEditor_UseActorFactory_IsValid;

	private static IntPtr GEditor_UseActorFactory_FunctionAddress;

	private static int GEditor_UseActorFactory_ParamsSize;

	private static bool GEditor_UseActorFactory_ActorFactory_IsValid;

	private static FFieldAddress GEditor_UseActorFactory_ActorFactory_PropertyAddress;

	private static int GEditor_UseActorFactory_ActorFactory_Offset;

	private static bool GEditor_UseActorFactory_AssetData_IsValid;

	private static FFieldAddress GEditor_UseActorFactory_AssetData_PropertyAddress;

	private static int GEditor_UseActorFactory_AssetData_Offset;

	private static bool GEditor_UseActorFactory_Transform_IsValid;

	private static FFieldAddress GEditor_UseActorFactory_Transform_PropertyAddress;

	private static int GEditor_UseActorFactory_Transform_Offset;

	private static bool GEditor_UseActorFactory_ReturnValue_IsValid;

	private static FFieldAddress GEditor_UseActorFactory_ReturnValue_PropertyAddress;

	private static int GEditor_UseActorFactory_ReturnValue_Offset;

	private static bool GEditor_StaticMeshUnregisterComponent_IsValid;

	private static IntPtr GEditor_StaticMeshUnregisterComponent_FunctionAddress;

	private static int GEditor_StaticMeshUnregisterComponent_ParamsSize;

	private static bool GEditor_StaticMeshUnregisterComponent_StaticMesh_IsValid;

	private static FFieldAddress GEditor_StaticMeshUnregisterComponent_StaticMesh_PropertyAddress;

	private static int GEditor_StaticMeshUnregisterComponent_StaticMesh_Offset;

	private static bool GEditor_StaticMeshRegisterComponentWithWorld_IsValid;

	private static IntPtr GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress;

	private static int GEditor_StaticMeshRegisterComponentWithWorld_ParamsSize;

	private static bool GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_IsValid;

	private static FFieldAddress GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_PropertyAddress;

	private static int GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_Offset;

	private static bool GEditor_StaticMeshRegisterComponentWithWorld_InWorld_IsValid;

	private static FFieldAddress GEditor_StaticMeshRegisterComponentWithWorld_InWorld_PropertyAddress;

	private static int GEditor_StaticMeshRegisterComponentWithWorld_InWorld_Offset;

	private static bool GEditor_SpawnActorAbsolute_IsValid;

	private static IntPtr GEditor_SpawnActorAbsolute_FunctionAddress;

	private static int GEditor_SpawnActorAbsolute_ParamsSize;

	private static bool GEditor_SpawnActorAbsolute_EditotWorld_IsValid;

	private static FFieldAddress GEditor_SpawnActorAbsolute_EditotWorld_PropertyAddress;

	private static int GEditor_SpawnActorAbsolute_EditotWorld_Offset;

	private static bool GEditor_SpawnActorAbsolute_Class_IsValid;

	private static FFieldAddress GEditor_SpawnActorAbsolute_Class_PropertyAddress;

	private static int GEditor_SpawnActorAbsolute_Class_Offset;

	private static bool GEditor_SpawnActorAbsolute_Transform_IsValid;

	private static FFieldAddress GEditor_SpawnActorAbsolute_Transform_PropertyAddress;

	private static int GEditor_SpawnActorAbsolute_Transform_Offset;

	private static bool GEditor_SpawnActorAbsolute_ReturnValue_IsValid;

	private static FFieldAddress GEditor_SpawnActorAbsolute_ReturnValue_PropertyAddress;

	private static int GEditor_SpawnActorAbsolute_ReturnValue_Offset;

	private static bool GEditor_SnapRotatorToGrid_IsValid;

	private static IntPtr GEditor_SnapRotatorToGrid_FunctionAddress;

	private static int GEditor_SnapRotatorToGrid_ParamsSize;

	private static bool GEditor_SnapRotatorToGrid_RotationToSnapped_IsValid;

	private static FFieldAddress GEditor_SnapRotatorToGrid_RotationToSnapped_PropertyAddress;

	private static int GEditor_SnapRotatorToGrid_RotationToSnapped_Offset;

	private static bool GEditor_SnapRotatorToGrid_ReturnValue_IsValid;

	private static FFieldAddress GEditor_SnapRotatorToGrid_ReturnValue_PropertyAddress;

	private static int GEditor_SnapRotatorToGrid_ReturnValue_Offset;

	private static bool GEditor_SetGAllowActorScriptExecutionInEditor_IsValid;

	private static IntPtr GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress;

	private static int GEditor_SetGAllowActorScriptExecutionInEditor_ParamsSize;

	private static bool GEditor_SetGAllowActorScriptExecutionInEditor_bVal_IsValid;

	private static FFieldAddress GEditor_SetGAllowActorScriptExecutionInEditor_bVal_PropertyAddress;

	private static int GEditor_SetGAllowActorScriptExecutionInEditor_bVal_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_IsValid;

	private static IntPtr GEditor_RecalculateMouseRayHitTransform_FunctionAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_ParamsSize;

	private static bool GEditor_RecalculateMouseRayHitTransform_JSViewport_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_JSViewport_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_JSViewport_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_UseUpRot_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_UseUpRot_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_UseUpRot_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_EnableSnapX_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_EnableSnapX_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_EnableSnapX_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_EnableSnapY_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_EnableSnapY_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_EnableSnapY_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_IgnoreActors_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_IgnoreActors_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_IgnoreActors_Offset;

	private static bool GEditor_RecalculateMouseRayHitTransform_ReturnValue_IsValid;

	private static FFieldAddress GEditor_RecalculateMouseRayHitTransform_ReturnValue_PropertyAddress;

	private static int GEditor_RecalculateMouseRayHitTransform_ReturnValue_Offset;

	private static bool GEditor_IsStaticMeshRegistered_IsValid;

	private static IntPtr GEditor_IsStaticMeshRegistered_FunctionAddress;

	private static int GEditor_IsStaticMeshRegistered_ParamsSize;

	private static bool GEditor_IsStaticMeshRegistered_StaticMesh_IsValid;

	private static FFieldAddress GEditor_IsStaticMeshRegistered_StaticMesh_PropertyAddress;

	private static int GEditor_IsStaticMeshRegistered_StaticMesh_Offset;

	private static bool GEditor_IsStaticMeshRegistered_ReturnValue_IsValid;

	private static FFieldAddress GEditor_IsStaticMeshRegistered_ReturnValue_PropertyAddress;

	private static int GEditor_IsStaticMeshRegistered_ReturnValue_Offset;

	private static bool GEditor_IsRunningCommandlet_IsValid;

	private static IntPtr GEditor_IsRunningCommandlet_FunctionAddress;

	private static int GEditor_IsRunningCommandlet_ParamsSize;

	private static bool GEditor_IsRunningCommandlet_ReturnValue_IsValid;

	private static FFieldAddress GEditor_IsRunningCommandlet_ReturnValue_PropertyAddress;

	private static int GEditor_IsRunningCommandlet_ReturnValue_Offset;

	private static bool GEditor_GetSelectedInstancesFoliageType_IsValid;

	private static IntPtr GEditor_GetSelectedInstancesFoliageType_FunctionAddress;

	private static int GEditor_GetSelectedInstancesFoliageType_ParamsSize;

	private static bool GEditor_GetSelectedInstancesFoliageType_ReturnValue_IsValid;

	private static FFieldAddress GEditor_GetSelectedInstancesFoliageType_ReturnValue_PropertyAddress;

	private static int GEditor_GetSelectedInstancesFoliageType_ReturnValue_Offset;

	private static bool GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_IsValid;

	private static IntPtr GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress;

	private static int GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_ParamsSize;

	private static bool GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_IsValid;

	private static FFieldAddress GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_PropertyAddress;

	private static int GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_Offset;

	private static bool GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_IsValid;

	private static FFieldAddress GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_PropertyAddress;

	private static int GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_Offset;

	private static bool GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_IsValid;

	private static FFieldAddress GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_PropertyAddress;

	private static int GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_Offset;

	private static bool GEditor_GetGAllowActorScriptExecutionInEditor_IsValid;

	private static IntPtr GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress;

	private static int GEditor_GetGAllowActorScriptExecutionInEditor_ParamsSize;

	private static bool GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_IsValid;

	private static FFieldAddress GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_PropertyAddress;

	private static int GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_Offset;

	private static bool GEditor_GetFoliageType_Actor_ActorClassAssetPathName_IsValid;

	private static IntPtr GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress;

	private static int GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ParamsSize;

	private static bool GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_IsValid;

	private static FFieldAddress GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_PropertyAddress;

	private static int GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_Offset;

	private static bool GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_IsValid;

	private static FFieldAddress GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_PropertyAddress;

	private static int GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_Offset;

	private static bool GEditor_GetBlueprintParentClass_IsValid;

	private static IntPtr GEditor_GetBlueprintParentClass_FunctionAddress;

	private static int GEditor_GetBlueprintParentClass_ParamsSize;

	private static bool GEditor_GetBlueprintParentClass_Blueprint_IsValid;

	private static FFieldAddress GEditor_GetBlueprintParentClass_Blueprint_PropertyAddress;

	private static int GEditor_GetBlueprintParentClass_Blueprint_Offset;

	private static bool GEditor_GetBlueprintParentClass_ReturnValue_IsValid;

	private static FFieldAddress GEditor_GetBlueprintParentClass_ReturnValue_PropertyAddress;

	private static int GEditor_GetBlueprintParentClass_ReturnValue_Offset;

	private static bool GEditor_GetBlueprintAsset_IsValid;

	private static IntPtr GEditor_GetBlueprintAsset_FunctionAddress;

	private static int GEditor_GetBlueprintAsset_ParamsSize;

	private static bool GEditor_GetBlueprintAsset_Object_IsValid;

	private static FFieldAddress GEditor_GetBlueprintAsset_Object_PropertyAddress;

	private static int GEditor_GetBlueprintAsset_Object_Offset;

	private static bool GEditor_GetBlueprintAsset_ReturnValue_IsValid;

	private static FFieldAddress GEditor_GetBlueprintAsset_ReturnValue_PropertyAddress;

	private static int GEditor_GetBlueprintAsset_ReturnValue_Offset;

	private static bool GEditor_FoliageType_Actor_ActorClass_IsValid;

	private static IntPtr GEditor_FoliageType_Actor_ActorClass_FunctionAddress;

	private static int GEditor_FoliageType_Actor_ActorClass_ParamsSize;

	private static bool GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_IsValid;

	private static FFieldAddress GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_PropertyAddress;

	private static int GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_Offset;

	private static bool GEditor_FoliageType_Actor_ActorClass_ReturnValue_IsValid;

	private static FFieldAddress GEditor_FoliageType_Actor_ActorClass_ReturnValue_PropertyAddress;

	private static int GEditor_FoliageType_Actor_ActorClass_ReturnValue_Offset;

	private static bool GEditor_DestroyActorTest_IsValid;

	private static IntPtr GEditor_DestroyActorTest_FunctionAddress;

	private static int GEditor_DestroyActorTest_ParamsSize;

	private static bool GEditor_DestroyActorTest_NeedDestroyAcotr_IsValid;

	private static FFieldAddress GEditor_DestroyActorTest_NeedDestroyAcotr_PropertyAddress;

	private static int GEditor_DestroyActorTest_NeedDestroyAcotr_Offset;

	private static bool GEditor_CreateMID_IsValid;

	private static IntPtr GEditor_CreateMID_FunctionAddress;

	private static int GEditor_CreateMID_ParamsSize;

	private static bool GEditor_CreateMID_ParentMaterial_IsValid;

	private static FFieldAddress GEditor_CreateMID_ParentMaterial_PropertyAddress;

	private static int GEditor_CreateMID_ParentMaterial_Offset;

	private static bool GEditor_CreateMID_InOuter_IsValid;

	private static FFieldAddress GEditor_CreateMID_InOuter_PropertyAddress;

	private static int GEditor_CreateMID_InOuter_Offset;

	private static bool GEditor_CreateMID_ReturnValue_IsValid;

	private static FFieldAddress GEditor_CreateMID_ReturnValue_PropertyAddress;

	private static int GEditor_CreateMID_ReturnValue_Offset;

	private static bool GEditor_CalculateComponentsBoundingBoxInLocalSpace_IsValid;

	private static IntPtr GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress;

	private static int GEditor_CalculateComponentsBoundingBoxInLocalSpace_ParamsSize;

	private static bool GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_IsValid;

	private static FFieldAddress GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_PropertyAddress;

	private static int GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_Offset;

	private static bool GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_IsValid;

	private static FFieldAddress GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_PropertyAddress;

	private static int GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_Offset;

	private static bool GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_IsValid;

	private static FFieldAddress GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_PropertyAddress;

	private static int GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_Offset;

	private static bool GEditor_AddCompToActor_IsValid;

	private static IntPtr GEditor_AddCompToActor_FunctionAddress;

	private static int GEditor_AddCompToActor_ParamsSize;

	private static bool GEditor_AddCompToActor_EditotWorld_IsValid;

	private static FFieldAddress GEditor_AddCompToActor_EditotWorld_PropertyAddress;

	private static int GEditor_AddCompToActor_EditotWorld_Offset;

	private static bool GEditor_AddCompToActor_Class_IsValid;

	private static FFieldAddress GEditor_AddCompToActor_Class_PropertyAddress;

	private static int GEditor_AddCompToActor_Class_Offset;

	private static bool GEditor_AddCompToActor_Actor_IsValid;

	private static FFieldAddress GEditor_AddCompToActor_Actor_PropertyAddress;

	private static int GEditor_AddCompToActor_Actor_Offset;

	private static bool GEditor_AddCompToActor_ReturnValue_IsValid;

	private static FFieldAddress GEditor_AddCompToActor_ReturnValue_PropertyAddress;

	private static int GEditor_AddCompToActor_ReturnValue_Offset;

	private static bool ForceGCInEditor_IsValid;

	private static IntPtr ForceGCInEditor_FunctionAddress;

	private static int ForceGCInEditor_ParamsSize;

	private static bool ForceGCInEditor_flag_IsValid;

	private static FFieldAddress ForceGCInEditor_flag_PropertyAddress;

	private static int ForceGCInEditor_flag_Offset;

	private static bool ExportStaticMeshInternal_IsValid;

	private static IntPtr ExportStaticMeshInternal_FunctionAddress;

	private static int ExportStaticMeshInternal_ParamsSize;

	private static bool ExportStaticMeshInternal_ObjectsToExport_IsValid;

	private static FFieldAddress ExportStaticMeshInternal_ObjectsToExport_PropertyAddress;

	private static int ExportStaticMeshInternal_ObjectsToExport_Offset;

	private static bool ExportStaticMeshInternal_ExportPath_IsValid;

	private static FFieldAddress ExportStaticMeshInternal_ExportPath_PropertyAddress;

	private static int ExportStaticMeshInternal_ExportPath_Offset;

	private static bool EnableAllPlantsImposter_IsValid;

	private static IntPtr EnableAllPlantsImposter_FunctionAddress;

	private static int EnableAllPlantsImposter_ParamsSize;

	private static bool EnableAllPlantsImposter_MapName_IsValid;

	private static FFieldAddress EnableAllPlantsImposter_MapName_PropertyAddress;

	private static int EnableAllPlantsImposter_MapName_Offset;

	private static bool EnableAllPlantsImposter_PlantsKeyWords_IsValid;

	private static FFieldAddress EnableAllPlantsImposter_PlantsKeyWords_PropertyAddress;

	private static int EnableAllPlantsImposter_PlantsKeyWords_Offset;

	private static bool EnableAllPlantsImposter_RuleOutKeyWords_IsValid;

	private static FFieldAddress EnableAllPlantsImposter_RuleOutKeyWords_PropertyAddress;

	private static int EnableAllPlantsImposter_RuleOutKeyWords_Offset;

	private static bool DuplicateSubobjects_IsValid;

	private static IntPtr DuplicateSubobjects_FunctionAddress;

	private static int DuplicateSubobjects_ParamsSize;

	private static bool DuplicateSubobjects_Context_IsValid;

	private static FFieldAddress DuplicateSubobjects_Context_PropertyAddress;

	private static int DuplicateSubobjects_Context_Offset;

	private static bool DuplicateSubobjects_SubobjectsToDup_IsValid;

	private static FFieldAddress DuplicateSubobjects_SubobjectsToDup_PropertyAddress;

	private static int DuplicateSubobjects_SubobjectsToDup_Offset;

	private static bool DuplicateSubobjects_BpContext_IsValid;

	private static FFieldAddress DuplicateSubobjects_BpContext_PropertyAddress;

	private static int DuplicateSubobjects_BpContext_Offset;

	private static bool DuplicateSubobjects_OutNewSubobjects_IsValid;

	private static FFieldAddress DuplicateSubobjects_OutNewSubobjects_PropertyAddress;

	private static int DuplicateSubobjects_OutNewSubobjects_Offset;

	private static bool CreateBlueprintWithClass_IsValid;

	private static IntPtr CreateBlueprintWithClass_FunctionAddress;

	private static int CreateBlueprintWithClass_ParamsSize;

	private static bool CreateBlueprintWithClass_ParentClass_IsValid;

	private static FFieldAddress CreateBlueprintWithClass_ParentClass_PropertyAddress;

	private static int CreateBlueprintWithClass_ParentClass_Offset;

	private static bool CreateBlueprintWithClass_AssetName_IsValid;

	private static FFieldAddress CreateBlueprintWithClass_AssetName_PropertyAddress;

	private static int CreateBlueprintWithClass_AssetName_Offset;

	private static bool CreateBlueprintWithClass_PackagePath_IsValid;

	private static FFieldAddress CreateBlueprintWithClass_PackagePath_PropertyAddress;

	private static int CreateBlueprintWithClass_PackagePath_Offset;

	private static bool CreateBlueprintWithClass_ReturnValue_IsValid;

	private static FFieldAddress CreateBlueprintWithClass_ReturnValue_PropertyAddress;

	private static int CreateBlueprintWithClass_ReturnValue_Offset;

	private static bool CopyThumbnailBetweenBlueprint_IsValid;

	private static IntPtr CopyThumbnailBetweenBlueprint_FunctionAddress;

	private static int CopyThumbnailBetweenBlueprint_ParamsSize;

	private static bool CopyThumbnailBetweenBlueprint_Origin_IsValid;

	private static FFieldAddress CopyThumbnailBetweenBlueprint_Origin_PropertyAddress;

	private static int CopyThumbnailBetweenBlueprint_Origin_Offset;

	private static bool CopyThumbnailBetweenBlueprint_Target_IsValid;

	private static FFieldAddress CopyThumbnailBetweenBlueprint_Target_PropertyAddress;

	private static int CopyThumbnailBetweenBlueprint_Target_Offset;

	private static bool ConvertHISMToStaticMeshActor_IsValid;

	private static IntPtr ConvertHISMToStaticMeshActor_FunctionAddress;

	private static int ConvertHISMToStaticMeshActor_ParamsSize;

	private static bool ConvertHISMToStaticMeshActor_WorldContext_IsValid;

	private static FFieldAddress ConvertHISMToStaticMeshActor_WorldContext_PropertyAddress;

	private static int ConvertHISMToStaticMeshActor_WorldContext_Offset;

	private static bool ContainRuntimeVirtualTexture_IsValid;

	private static IntPtr ContainRuntimeVirtualTexture_FunctionAddress;

	private static int ContainRuntimeVirtualTexture_ParamsSize;

	private static bool ContainRuntimeVirtualTexture_PrimComponent_IsValid;

	private static FFieldAddress ContainRuntimeVirtualTexture_PrimComponent_PropertyAddress;

	private static int ContainRuntimeVirtualTexture_PrimComponent_Offset;

	private static bool ContainRuntimeVirtualTexture_RVT_IsValid;

	private static FFieldAddress ContainRuntimeVirtualTexture_RVT_PropertyAddress;

	private static int ContainRuntimeVirtualTexture_RVT_Offset;

	private static bool ContainRuntimeVirtualTexture_ReturnValue_IsValid;

	private static FFieldAddress ContainRuntimeVirtualTexture_ReturnValue_PropertyAddress;

	private static int ContainRuntimeVirtualTexture_ReturnValue_Offset;

	private static bool ClearRuntimeVirtualTexture_IsValid;

	private static IntPtr ClearRuntimeVirtualTexture_FunctionAddress;

	private static int ClearRuntimeVirtualTexture_ParamsSize;

	private static bool ClearRuntimeVirtualTexture_PrimComponent_IsValid;

	private static FFieldAddress ClearRuntimeVirtualTexture_PrimComponent_PropertyAddress;

	private static int ClearRuntimeVirtualTexture_PrimComponent_Offset;

	private static bool CleanOverlapFoliages_IsValid;

	private static IntPtr CleanOverlapFoliages_FunctionAddress;

	private static int CleanOverlapFoliages_ParamsSize;

	private static bool CleanOverlapActors_IsValid;

	private static IntPtr CleanOverlapActors_FunctionAddress;

	private static int CleanOverlapActors_ParamsSize;

	private static bool CheckoutAndSavePackage_IsValid;

	private static IntPtr CheckoutAndSavePackage_FunctionAddress;

	private static int CheckoutAndSavePackage_ParamsSize;

	private static bool CheckoutAndSavePackage_PackagesToSave_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_PackagesToSave_PropertyAddress;

	private static int CheckoutAndSavePackage_PackagesToSave_Offset;

	private static bool CheckoutAndSavePackage_bCheckDirty_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_bCheckDirty_PropertyAddress;

	private static int CheckoutAndSavePackage_bCheckDirty_Offset;

	private static bool CheckoutAndSavePackage_bPromptToSave_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_bPromptToSave_PropertyAddress;

	private static int CheckoutAndSavePackage_bPromptToSave_Offset;

	private static bool CheckoutAndSavePackage_OutFailedPackages_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_OutFailedPackages_PropertyAddress;

	private static int CheckoutAndSavePackage_OutFailedPackages_Offset;

	private static bool CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress;

	private static int CheckoutAndSavePackage_bAlreadyCheckedOut_Offset;

	private static bool CheckoutAndSavePackage_bCanBeDeclined_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress;

	private static int CheckoutAndSavePackage_bCanBeDeclined_Offset;

	private static bool CheckoutAndSavePackage_ReturnValue_IsValid;

	private static FFieldAddress CheckoutAndSavePackage_ReturnValue_PropertyAddress;

	private static int CheckoutAndSavePackage_ReturnValue_Offset;

	private static bool ChangeBufferVisualizationMode_IsValid;

	private static IntPtr ChangeBufferVisualizationMode_FunctionAddress;

	private static int ChangeBufferVisualizationMode_ParamsSize;

	private static bool ChangeBufferVisualizationMode_InName_IsValid;

	private static FFieldAddress ChangeBufferVisualizationMode_InName_PropertyAddress;

	private static int ChangeBufferVisualizationMode_InName_Offset;

	private static bool BGUSplitSplineActor_IsValid;

	private static IntPtr BGUSplitSplineActor_FunctionAddress;

	private static int BGUSplitSplineActor_ParamsSize;

	private static bool BGUSplitSplineActor_InSplineActor_IsValid;

	private static FFieldAddress BGUSplitSplineActor_InSplineActor_PropertyAddress;

	private static int BGUSplitSplineActor_InSplineActor_Offset;

	private static bool BGURecalculateSpawnTransform_IsValid;

	private static IntPtr BGURecalculateSpawnTransform_FunctionAddress;

	private static int BGURecalculateSpawnTransform_ParamsSize;

	private static bool BGURecalculateSpawnTransform_JSViewport_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_JSViewport_PropertyAddress;

	private static int BGURecalculateSpawnTransform_JSViewport_Offset;

	private static bool BGURecalculateSpawnTransform_UseUpRot_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_UseUpRot_PropertyAddress;

	private static int BGURecalculateSpawnTransform_UseUpRot_Offset;

	private static bool BGURecalculateSpawnTransform_SpawnWorldTransform_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_SpawnWorldTransform_PropertyAddress;

	private static int BGURecalculateSpawnTransform_SpawnWorldTransform_Offset;

	private static bool BGURecalculateSpawnTransform_EnableSnapX_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_EnableSnapX_PropertyAddress;

	private static int BGURecalculateSpawnTransform_EnableSnapX_Offset;

	private static bool BGURecalculateSpawnTransform_EnableSnapY_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_EnableSnapY_PropertyAddress;

	private static int BGURecalculateSpawnTransform_EnableSnapY_Offset;

	private static bool BGURecalculateSpawnTransform_EnableSnapZ_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_EnableSnapZ_PropertyAddress;

	private static int BGURecalculateSpawnTransform_EnableSnapZ_Offset;

	private static bool BGURecalculateSpawnTransform_ReturnValue_IsValid;

	private static FFieldAddress BGURecalculateSpawnTransform_ReturnValue_PropertyAddress;

	private static int BGURecalculateSpawnTransform_ReturnValue_Offset;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_IsValid;

	private static IntPtr BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_ParamsSize;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_IsValid;

	private static FFieldAddress BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_PropertyAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_Offset;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_IsValid;

	private static FFieldAddress BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_PropertyAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_Offset;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_IsValid;

	private static FFieldAddress BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_PropertyAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_Offset;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_IsValid;

	private static FFieldAddress BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_PropertyAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_Offset;

	private static bool BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_IsValid;

	private static FFieldAddress BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_PropertyAddress;

	private static int BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_Offset;

	private static bool BGUGenSplineAirWall_IsValid;

	private static IntPtr BGUGenSplineAirWall_FunctionAddress;

	private static int BGUGenSplineAirWall_ParamsSize;

	private static bool BGUGenSplineAirWall_WorldContextObject_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_WorldContextObject_PropertyAddress;

	private static int BGUGenSplineAirWall_WorldContextObject_Offset;

	private static bool BGUGenSplineAirWall_BaseVertices_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_BaseVertices_PropertyAddress;

	private static int BGUGenSplineAirWall_BaseVertices_Offset;

	private static bool BGUGenSplineAirWall_AirWallHeight_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_AirWallHeight_PropertyAddress;

	private static int BGUGenSplineAirWall_AirWallHeight_Offset;

	private static bool BGUGenSplineAirWall_bMakeInvisible_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_bMakeInvisible_PropertyAddress;

	private static int BGUGenSplineAirWall_bMakeInvisible_Offset;

	private static bool BGUGenSplineAirWall_AirWallType_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_AirWallType_PropertyAddress;

	private static int BGUGenSplineAirWall_AirWallType_Offset;

	private static bool BGUGenSplineAirWall_UpDirection_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_UpDirection_PropertyAddress;

	private static int BGUGenSplineAirWall_UpDirection_Offset;

	private static bool BGUGenSplineAirWall_bNavModify_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_bNavModify_PropertyAddress;

	private static int BGUGenSplineAirWall_bNavModify_Offset;

	private static bool BGUGenSplineAirWall_ReturnValue_IsValid;

	private static FFieldAddress BGUGenSplineAirWall_ReturnValue_PropertyAddress;

	private static int BGUGenSplineAirWall_ReturnValue_Offset;

	private static bool BGUGenManualSplineMoveOverlapVolume_IsValid;

	private static IntPtr BGUGenManualSplineMoveOverlapVolume_FunctionAddress;

	private static int BGUGenManualSplineMoveOverlapVolume_ParamsSize;

	private static bool BGUGenManualSplineMoveOverlapVolume_WorldContext_IsValid;

	private static FFieldAddress BGUGenManualSplineMoveOverlapVolume_WorldContext_PropertyAddress;

	private static int BGUGenManualSplineMoveOverlapVolume_WorldContext_Offset;

	private static bool BGUGenManualSplineMoveOverlapVolume_BaseVertices_IsValid;

	private static FFieldAddress BGUGenManualSplineMoveOverlapVolume_BaseVertices_PropertyAddress;

	private static int BGUGenManualSplineMoveOverlapVolume_BaseVertices_Offset;

	private static bool BGUGenManualSplineMoveOverlapVolume_ReturnValue_IsValid;

	private static FFieldAddress BGUGenManualSplineMoveOverlapVolume_ReturnValue_PropertyAddress;

	private static int BGUGenManualSplineMoveOverlapVolume_ReturnValue_Offset;

	private static bool BGUGenAirWall_IsValid;

	private static IntPtr BGUGenAirWall_FunctionAddress;

	private static int BGUGenAirWall_ParamsSize;

	private static bool BGUGenAirWall_WorldContextObject_IsValid;

	private static FFieldAddress BGUGenAirWall_WorldContextObject_PropertyAddress;

	private static int BGUGenAirWall_WorldContextObject_Offset;

	private static bool BGUGenAirWall_ShapeVertices_IsValid;

	private static FFieldAddress BGUGenAirWall_ShapeVertices_PropertyAddress;

	private static int BGUGenAirWall_ShapeVertices_Offset;

	private static bool BGUGenAirWall_bAutoExtrude_IsValid;

	private static FFieldAddress BGUGenAirWall_bAutoExtrude_PropertyAddress;

	private static int BGUGenAirWall_bAutoExtrude_Offset;

	private static bool BGUGenAirWall_ExtrudeDepth_IsValid;

	private static FFieldAddress BGUGenAirWall_ExtrudeDepth_PropertyAddress;

	private static int BGUGenAirWall_ExtrudeDepth_Offset;

	private static bool BGUGenAirWall_AirWallHeight_IsValid;

	private static FFieldAddress BGUGenAirWall_AirWallHeight_PropertyAddress;

	private static int BGUGenAirWall_AirWallHeight_Offset;

	private static bool BGUFixSplineAirWallCenterPoint_IsValid;

	private static IntPtr BGUFixSplineAirWallCenterPoint_FunctionAddress;

	private static int BGUFixSplineAirWallCenterPoint_ParamsSize;

	private static bool AddRuntimeVirtualTexture_IsValid;

	private static IntPtr AddRuntimeVirtualTexture_FunctionAddress;

	private static int AddRuntimeVirtualTexture_ParamsSize;

	private static bool AddRuntimeVirtualTexture_PrimComponent_IsValid;

	private static FFieldAddress AddRuntimeVirtualTexture_PrimComponent_PropertyAddress;

	private static int AddRuntimeVirtualTexture_PrimComponent_Offset;

	private static bool AddRuntimeVirtualTexture_RVT_IsValid;

	private static FFieldAddress AddRuntimeVirtualTexture_RVT_PropertyAddress;

	private static int AddRuntimeVirtualTexture_RVT_Offset;

	private static bool AddRuntimeVirtualTexture_ReturnValue_IsValid;

	private static FFieldAddress AddRuntimeVirtualTexture_ReturnValue_PropertyAddress;

	private static int AddRuntimeVirtualTexture_ReturnValue_Offset;

	private static bool AddNewCompToBPAsset_IsValid;

	private static IntPtr AddNewCompToBPAsset_FunctionAddress;

	private static int AddNewCompToBPAsset_ParamsSize;

	private static bool AddNewCompToBPAsset_InBlueprint_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_InBlueprint_PropertyAddress;

	private static int AddNewCompToBPAsset_InBlueprint_Offset;

	private static bool AddNewCompToBPAsset_InComponentVariableName_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_InComponentVariableName_PropertyAddress;

	private static int AddNewCompToBPAsset_InComponentVariableName_Offset;

	private static bool AddNewCompToBPAsset_InComponentClass_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_InComponentClass_PropertyAddress;

	private static int AddNewCompToBPAsset_InComponentClass_Offset;

	private static bool AddNewCompToBPAsset_outCompVariableName_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_outCompVariableName_PropertyAddress;

	private static int AddNewCompToBPAsset_outCompVariableName_Offset;

	private static bool AddNewCompToBPAsset_ParentVariableName_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_ParentVariableName_PropertyAddress;

	private static int AddNewCompToBPAsset_ParentVariableName_Offset;

	private static bool AddNewCompToBPAsset_SocketOrBoneName_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_SocketOrBoneName_PropertyAddress;

	private static int AddNewCompToBPAsset_SocketOrBoneName_Offset;

	private static bool AddNewCompToBPAsset_ReturnValue_IsValid;

	private static FFieldAddress AddNewCompToBPAsset_ReturnValue_PropertyAddress;

	private static int AddNewCompToBPAsset_ReturnValue_Offset;

	private static bool AddNewCompToActor_IsValid;

	private static IntPtr AddNewCompToActor_FunctionAddress;

	private static int AddNewCompToActor_ParamsSize;

	private static bool AddNewCompToActor_Actor_IsValid;

	private static FFieldAddress AddNewCompToActor_Actor_PropertyAddress;

	private static int AddNewCompToActor_Actor_Offset;

	private static bool AddNewCompToActor_InComponentClass_IsValid;

	private static FFieldAddress AddNewCompToActor_InComponentClass_PropertyAddress;

	private static int AddNewCompToActor_InComponentClass_Offset;

	private static bool AddNewCompToActor_ReturnValue_IsValid;

	private static FFieldAddress AddNewCompToActor_ReturnValue_PropertyAddress;

	private static int AddNewCompToActor_ReturnValue_Offset;

	private static bool AddCompToBPAsset_IsValid;

	private static IntPtr AddCompToBPAsset_FunctionAddress;

	private static int AddCompToBPAsset_ParamsSize;

	private static bool AddCompToBPAsset_BP_IsValid;

	private static FFieldAddress AddCompToBPAsset_BP_PropertyAddress;

	private static int AddCompToBPAsset_BP_Offset;

	private static bool AddCompToBPAsset_NewComponentVariableName_IsValid;

	private static FFieldAddress AddCompToBPAsset_NewComponentVariableName_PropertyAddress;

	private static int AddCompToBPAsset_NewComponentVariableName_Offset;

	private static bool AddCompToBPAsset_NewComponentClass_IsValid;

	private static FFieldAddress AddCompToBPAsset_NewComponentClass_PropertyAddress;

	private static int AddCompToBPAsset_NewComponentClass_Offset;

	private static bool AddCompToBPAsset_outNewVariableName_IsValid;

	private static FFieldAddress AddCompToBPAsset_outNewVariableName_PropertyAddress;

	private static int AddCompToBPAsset_outNewVariableName_Offset;

	private static bool AddCompToBPAsset_ParentComponentOrVariableName_IsValid;

	private static FFieldAddress AddCompToBPAsset_ParentComponentOrVariableName_PropertyAddress;

	private static int AddCompToBPAsset_ParentComponentOrVariableName_Offset;

	private static bool AddCompToBPAsset_SocketOrBoneName_IsValid;

	private static FFieldAddress AddCompToBPAsset_SocketOrBoneName_PropertyAddress;

	private static int AddCompToBPAsset_SocketOrBoneName_Offset;

	private static bool AddCompToBPAsset_ReturnValue_IsValid;

	private static FFieldAddress AddCompToBPAsset_ReturnValue_PropertyAddress;

	private static int AddCompToBPAsset_ReturnValue_Offset;

	private static bool AddComponentsToBlueprint_IsValid;

	private static IntPtr AddComponentsToBlueprint_FunctionAddress;

	private static int AddComponentsToBlueprint_ParamsSize;

	private static bool AddComponentsToBlueprint_Blueprint_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_Blueprint_PropertyAddress;

	private static int AddComponentsToBlueprint_Blueprint_Offset;

	private static bool AddComponentsToBlueprint_Components_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_Components_PropertyAddress;

	private static int AddComponentsToBlueprint_Components_Offset;

	private static bool AddComponentsToBlueprint_bHarvesting_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_bHarvesting_PropertyAddress;

	private static int AddComponentsToBlueprint_bHarvesting_Offset;

	private static bool AddComponentsToBlueprint_OptionalNewRootComponentTag_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_OptionalNewRootComponentTag_PropertyAddress;

	private static int AddComponentsToBlueprint_OptionalNewRootComponentTag_Offset;

	private static bool AddComponentsToBlueprint_bKeepMobility_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_bKeepMobility_PropertyAddress;

	private static int AddComponentsToBlueprint_bKeepMobility_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:UpdateFindInAssetsData")]
	public unsafe static void UpdateFindInAssetsData()
	{
		if (!UpdateFindInAssetsData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:UpdateFindInAssetsData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateFindInAssetsData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateFindInAssetsData_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: UpdateFindInAssetsData_FunctionAddress, argsSize: UpdateFindInAssetsData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ShowNotifyText")]
	public unsafe static void ShowNotifyText(string InNotifyText)
	{
		if (!ShowNotifyText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ShowNotifyText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowNotifyText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowNotifyText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowNotifyText_InNotifyText_Offset), 0, ShowNotifyText_InNotifyText_PropertyAddress.Address, InNotifyText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowNotifyText_FunctionAddress, intPtr, ShowNotifyText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowNotifyText_InNotifyText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ShowMassageDialog")]
	public unsafe static void ShowMassageDialog(string Message)
	{
		if (!ShowMassageDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ShowMassageDialog");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowMassageDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowMassageDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowMassageDialog_Message_Offset), 0, ShowMassageDialog_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowMassageDialog_FunctionAddress, intPtr, ShowMassageDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowMassageDialog_Message_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewportType")]
	public unsafe static void SetViewportType(ELevelViewportType InViewportType)
	{
		if (!SetViewportType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewportType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewportType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewportType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELevelViewportType>.ToNative(IntPtr.Add(intPtr, SetViewportType_InViewportType_Offset), 0, SetViewportType_InViewportType_PropertyAddress.Address, InViewportType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewportType_FunctionAddress, intPtr, SetViewportType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewMode")]
	public unsafe static void SetViewMode(EViewModeIndex InViewModeIndex)
	{
		if (!SetViewMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EViewModeIndex>.ToNative(IntPtr.Add(intPtr, SetViewMode_InViewModeIndex_Offset), 0, SetViewMode_InViewModeIndex_PropertyAddress.Address, InViewModeIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewMode_FunctionAddress, intPtr, SetViewMode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetStatic")]
	public unsafe static void SetStatic(UObject InObj)
	{
		if (!SetStatic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetStatic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStatic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStatic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetStatic_InObj_Offset), 0, SetStatic_InObj_PropertyAddress.Address, InObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStatic_FunctionAddress, intPtr, SetStatic_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetSplineCompIsEdited")]
	public unsafe static void SetSplineCompIsEdited(USplineComponent SplineComp, bool IsEdited)
	{
		if (!SetSplineCompIsEdited_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetSplineCompIsEdited");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineCompIsEdited_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineCompIsEdited_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(intPtr, SetSplineCompIsEdited_SplineComp_Offset), 0, SetSplineCompIsEdited_SplineComp_PropertyAddress.Address, SplineComp);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSplineCompIsEdited_IsEdited_Offset), 0, SetSplineCompIsEdited_IsEdited_PropertyAddress.Address, IsEdited);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSplineCompIsEdited_FunctionAddress, intPtr, SetSplineCompIsEdited_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetPreloadLevel")]
	public unsafe static void SetPreloadLevel(int PreloadLevel)
	{
		if (!SetPreloadLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetPreloadLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPreloadLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPreloadLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPreloadLevel_PreloadLevel_Offset), 0, SetPreloadLevel_PreloadLevel_PropertyAddress.Address, PreloadLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPreloadLevel_FunctionAddress, intPtr, SetPreloadLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetNiagaraDisable")]
	public unsafe static void SetNiagaraDisable(bool Disable)
	{
		if (!SetNiagaraDisable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetNiagaraDisable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNiagaraDisable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNiagaraDisable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNiagaraDisable_Disable_Offset), 0, SetNiagaraDisable_Disable_PropertyAddress.Address, Disable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNiagaraDisable_FunctionAddress, intPtr, SetNiagaraDisable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetClothingAssetSelfCollision")]
	public unsafe static void SetClothingAssetSelfCollision(USkeletalMesh InSkeletalMesh, bool NewSelfCollision)
	{
		if (!SetClothingAssetSelfCollision_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetClothingAssetSelfCollision");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClothingAssetSelfCollision_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClothingAssetSelfCollision_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, SetClothingAssetSelfCollision_InSkeletalMesh_Offset), 0, SetClothingAssetSelfCollision_InSkeletalMesh_PropertyAddress.Address, InSkeletalMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetClothingAssetSelfCollision_NewSelfCollision_Offset), 0, SetClothingAssetSelfCollision_NewSelfCollision_PropertyAddress.Address, NewSelfCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetClothingAssetSelfCollision_FunctionAddress, intPtr, SetClothingAssetSelfCollision_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetCinematicActorLock")]
	public unsafe static void SetCinematicActorLock(AActor Actor)
	{
		if (!SetCinematicActorLock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetCinematicActorLock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCinematicActorLock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCinematicActorLock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetCinematicActorLock_Actor_Offset), 0, SetCinematicActorLock_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCinematicActorLock_FunctionAddress, intPtr, SetCinematicActorLock_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorSelectionState")]
	public unsafe static void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
	{
		if (!SetActorSelectionState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorSelectionState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorSelectionState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorSelectionState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorSelectionState_Actor_Offset), 0, SetActorSelectionState_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorSelectionState_bShouldBeSelected_Offset), 0, SetActorSelectionState_bShouldBeSelected_PropertyAddress.Address, bShouldBeSelected);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorSelectionState_FunctionAddress, intPtr, SetActorSelectionState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLock")]
	public unsafe static void SetActorLock(AActor Actor)
	{
		if (!SetActorLock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLock_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLock_Actor_Offset), 0, SetActorLock_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLock_FunctionAddress, intPtr, SetActorLock_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLabel")]
	public unsafe static void SetActorLabel(AActor InActor, string InLabel)
	{
		if (!SetActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLabel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLabel_InActor_Offset), 0, SetActorLabel_InActor_PropertyAddress.Address, InActor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabel_InLabel_Offset), 0, SetActorLabel_InLabel_PropertyAddress.Address, InLabel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLabel_FunctionAddress, intPtr, SetActorLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActorLabel_InLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ResetClothingAssetConfig")]
	public unsafe static void ResetClothingAssetConfig(USkeletalMesh InSkeletalMesh)
	{
		if (!ResetClothingAssetConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ResetClothingAssetConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetClothingAssetConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetClothingAssetConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, ResetClothingAssetConfig_InSkeletalMesh_Offset), 0, ResetClothingAssetConfig_InSkeletalMesh_PropertyAddress.Address, InSkeletalMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetClothingAssetConfig_FunctionAddress, intPtr, ResetClothingAssetConfig_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ReplaceHISMByFoliageType")]
	public unsafe static void ReplaceHISMByFoliageType(UObject WorldContext, UFoliageType oldFoliageType, UFoliageType newFoliageType)
	{
		if (!ReplaceHISMByFoliageType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ReplaceHISMByFoliageType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceHISMByFoliageType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceHISMByFoliageType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReplaceHISMByFoliageType_WorldContext_Offset), 0, ReplaceHISMByFoliageType_WorldContext_PropertyAddress.Address, WorldContext);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceHISMByFoliageType_oldFoliageType_Offset), 0, ReplaceHISMByFoliageType_oldFoliageType_PropertyAddress.Address, oldFoliageType);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceHISMByFoliageType_newFoliageType_Offset), 0, ReplaceHISMByFoliageType_newFoliageType_PropertyAddress.Address, newFoliageType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceHISMByFoliageType_FunctionAddress, intPtr, ReplaceHISMByFoliageType_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ReimportAssets")]
	public unsafe static void ReimportAssets(List<UObject> ReimportAssets, bool bShowNotification, int SourceFileIndex, bool bForceNewFile, bool bAutomated)
	{
		if (!ReimportAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ReimportAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReimportAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReimportAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ReimportAssets_ReimportAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ReimportAssets_ReimportAssets_Offset), ReimportAssets);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReimportAssets_bShowNotification_Offset), 0, ReimportAssets_bShowNotification_PropertyAddress.Address, bShowNotification);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReimportAssets_SourceFileIndex_Offset), 0, ReimportAssets_SourceFileIndex_PropertyAddress.Address, SourceFileIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReimportAssets_bForceNewFile_Offset), 0, ReimportAssets_bForceNewFile_PropertyAddress.Address, bForceNewFile);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReimportAssets_bAutomated_Offset), 0, ReimportAssets_bAutomated_PropertyAddress.Address, bAutomated);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReimportAssets_FunctionAddress, intPtr, ReimportAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReimportAssets_ReimportAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:RegisterPropertyTypeCustomizationDetails")]
	public unsafe static void RegisterPropertyTypeCustomizationDetails(string StructName, int EnumType, List<FName> Properties)
	{
		if (!RegisterPropertyTypeCustomizationDetails_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:RegisterPropertyTypeCustomizationDetails");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RegisterPropertyTypeCustomizationDetails_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RegisterPropertyTypeCustomizationDetails_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RegisterPropertyTypeCustomizationDetails_StructName_Offset), 0, RegisterPropertyTypeCustomizationDetails_StructName_PropertyAddress.Address, StructName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RegisterPropertyTypeCustomizationDetails_EnumType_Offset), 0, RegisterPropertyTypeCustomizationDetails_EnumType_PropertyAddress.Address, EnumType);
		new TArrayCopyMarshaler<FName>(1, RegisterPropertyTypeCustomizationDetails_Properties_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, RegisterPropertyTypeCustomizationDetails_Properties_Offset), Properties);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RegisterPropertyTypeCustomizationDetails_FunctionAddress, intPtr, RegisterPropertyTypeCustomizationDetails_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RegisterPropertyTypeCustomizationDetails_StructName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RegisterPropertyTypeCustomizationDetails_Properties_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:PIEStart")]
	public unsafe static void PIEStart()
	{
		if (!PIEStart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:PIEStart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PIEStart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PIEStart_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PIEStart_FunctionAddress, argsSize: PIEStart_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:PasteSubobjects")]
	public unsafe static void PasteSubobjects(FSubobjectDataHandle PasteToContext, List<FSubobjectDataHandle> NewParentHandles, UBlueprint BpContext, out List<FSubobjectDataHandle> OutPastedHandles)
	{
		if (!PasteSubobjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:PasteSubobjects");
			OutPastedHandles = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PasteSubobjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PasteSubobjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(PasteSubobjects_PasteToContext_PropertyAddress.Address, intPtr);
		FSubobjectDataHandle.ToNative(IntPtr.Add(intPtr, PasteSubobjects_PasteToContext_Offset), 0, PasteSubobjects_PasteToContext_PropertyAddress.Address, PasteToContext);
		new TArrayCopyMarshaler<FSubobjectDataHandle>(1, PasteSubobjects_NewParentHandles_PropertyAddress, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.FromNative, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.ToNative).ToNative(IntPtr.Add(intPtr, PasteSubobjects_NewParentHandles_Offset), NewParentHandles);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, PasteSubobjects_BpContext_Offset), 0, PasteSubobjects_BpContext_PropertyAddress.Address, BpContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PasteSubobjects_FunctionAddress, intPtr, PasteSubobjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PasteSubobjects_PasteToContext_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PasteSubobjects_NewParentHandles_PropertyAddress.Address, intPtr);
		OutPastedHandles = new TArrayCopyMarshaler<FSubobjectDataHandle>(1, PasteSubobjects_OutPastedHandles_PropertyAddress, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.FromNative, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.ToNative).FromNative(IntPtr.Add(intPtr, PasteSubobjects_OutPastedHandles_Offset));
		NativeReflection.DestroyValue_InContainer(PasteSubobjects_OutPastedHandles_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorUnlock")]
	public unsafe static void OnActorUnlock()
	{
		if (!OnActorUnlock_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorUnlock");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnActorUnlock_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnActorUnlock_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: OnActorUnlock_FunctionAddress, argsSize: OnActorUnlock_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorLockToggleFromMenu")]
	public unsafe static void OnActorLockToggleFromMenu(AActor Actor)
	{
		if (!OnActorLockToggleFromMenu_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorLockToggleFromMenu");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnActorLockToggleFromMenu_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnActorLockToggleFromMenu_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, OnActorLockToggleFromMenu_Actor_Offset), 0, OnActorLockToggleFromMenu_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OnActorLockToggleFromMenu_FunctionAddress, intPtr, OnActorLockToggleFromMenu_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ModifyStaticMeshActorGenerateLightMap")]
	public unsafe static void ModifyStaticMeshActorGenerateLightMap(bool enable)
	{
		if (!ModifyStaticMeshActorGenerateLightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ModifyStaticMeshActorGenerateLightMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyStaticMeshActorGenerateLightMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyStaticMeshActorGenerateLightMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyStaticMeshActorGenerateLightMap_enable_Offset), 0, ModifyStaticMeshActorGenerateLightMap_enable_PropertyAddress.Address, enable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyStaticMeshActorGenerateLightMap_FunctionAddress, intPtr, ModifyStaticMeshActorGenerateLightMap_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:MergeShaderCodeFiles")]
	public unsafe static bool MergeShaderCodeFiles(string OldDir, string NewDir, string OutputDir)
	{
		if (!MergeShaderCodeFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:MergeShaderCodeFiles");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MergeShaderCodeFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MergeShaderCodeFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeShaderCodeFiles_OldDir_Offset), 0, MergeShaderCodeFiles_OldDir_PropertyAddress.Address, OldDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeShaderCodeFiles_NewDir_Offset), 0, MergeShaderCodeFiles_NewDir_PropertyAddress.Address, NewDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MergeShaderCodeFiles_OutputDir_Offset), 0, MergeShaderCodeFiles_OutputDir_PropertyAddress.Address, OutputDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MergeShaderCodeFiles_FunctionAddress, intPtr, MergeShaderCodeFiles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MergeShaderCodeFiles_OldDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeShaderCodeFiles_NewDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MergeShaderCodeFiles_OutputDir_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MergeShaderCodeFiles_ReturnValue_Offset), 0, MergeShaderCodeFiles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:LoadObjectsFromAssetData")]
	public unsafe static List<UObject> LoadObjectsFromAssetData(UAssetDataArray Assets)
	{
		if (!LoadObjectsFromAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:LoadObjectsFromAssetData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadObjectsFromAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadObjectsFromAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, LoadObjectsFromAssetData_Assets_Offset), 0, LoadObjectsFromAssetData_Assets_PropertyAddress.Address, Assets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadObjectsFromAssetData_FunctionAddress, intPtr, LoadObjectsFromAssetData_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, LoadObjectsFromAssetData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadObjectsFromAssetData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(LoadObjectsFromAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInPreview")]
	public unsafe static bool IsPlayInPreview(UWorld World)
	{
		if (!IsPlayInPreview_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInPreview");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayInPreview_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayInPreview_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsPlayInPreview_World_Offset), 0, IsPlayInPreview_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPlayInPreview_FunctionAddress, intPtr, IsPlayInPreview_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayInPreview_ReturnValue_Offset), 0, IsPlayInPreview_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInEditor")]
	public unsafe static bool IsPlayInEditor(UWorld World)
	{
		if (!IsPlayInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPlayInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPlayInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsPlayInEditor_World_Offset), 0, IsPlayInEditor_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPlayInEditor_FunctionAddress, intPtr, IsPlayInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPlayInEditor_ReturnValue_Offset), 0, IsPlayInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:IsPackageExist")]
	public unsafe static bool IsPackageExist(string PathName)
	{
		if (!IsPackageExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:IsPackageExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPackageExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPackageExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsPackageExist_PathName_Offset), 0, IsPackageExist_PathName_PropertyAddress.Address, PathName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPackageExist_FunctionAddress, intPtr, IsPackageExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsPackageExist_PathName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPackageExist_ReturnValue_Offset), 0, IsPackageExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:IsGameWorld")]
	public unsafe static bool IsGameWorld(UWorld World)
	{
		if (!IsGameWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:IsGameWorld");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGameWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGameWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsGameWorld_World_Offset), 0, IsGameWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsGameWorld_FunctionAddress, intPtr, IsGameWorld_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGameWorld_ReturnValue_Offset), 0, IsGameWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:IsEditorWorld")]
	public unsafe static bool IsEditorWorld(UWorld World)
	{
		if (!IsEditorWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:IsEditorWorld");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsEditorWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsEditorWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, IsEditorWorld_World_Offset), 0, IsEditorWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsEditorWorld_FunctionAddress, intPtr, IsEditorWorld_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsEditorWorld_ReturnValue_Offset), 0, IsEditorWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ImportAssets")]
	public unsafe static List<UObject> ImportAssets(List<string> FilePaths, string DestinationPath)
	{
		if (!ImportAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ImportAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ImportAssets_FilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ImportAssets_FilePaths_Offset), FilePaths);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportAssets_DestinationPath_Offset), 0, ImportAssets_DestinationPath_PropertyAddress.Address, DestinationPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportAssets_FunctionAddress, intPtr, ImportAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportAssets_FilePaths_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ImportAssets_DestinationPath_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, ImportAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, ImportAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleFixMapPIEMode")]
	public unsafe static void GSToggleFixMapPIEMode()
	{
		if (!GSToggleFixMapPIEMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleFixMapPIEMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSToggleFixMapPIEMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSToggleFixMapPIEMode_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: GSToggleFixMapPIEMode_FunctionAddress, argsSize: GSToggleFixMapPIEMode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleEditorMode")]
	public unsafe static void GSToggleEditorMode(FName InEdName)
	{
		if (!GSToggleEditorMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleEditorMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSToggleEditorMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSToggleEditorMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GSToggleEditorMode_InEdName_Offset), 0, GSToggleEditorMode_InEdName_PropertyAddress.Address, InEdName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSToggleEditorMode_FunctionAddress, intPtr, GSToggleEditorMode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevels")]
	public unsafe static void GSGenerateLODLevels(string LevelName)
	{
		if (!GSGenerateLODLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSGenerateLODLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSGenerateLODLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSGenerateLODLevels_LevelName_Offset), 0, GSGenerateLODLevels_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSGenerateLODLevels_FunctionAddress, intPtr, GSGenerateLODLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSGenerateLODLevels_LevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevel")]
	public unsafe static void GSGenerateLODLevel(string LevelName, int TargetLODIndex)
	{
		if (!GSGenerateLODLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSGenerateLODLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSGenerateLODLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSGenerateLODLevel_LevelName_Offset), 0, GSGenerateLODLevel_LevelName_PropertyAddress.Address, LevelName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GSGenerateLODLevel_TargetLODIndex_Offset), 0, GSGenerateLODLevel_TargetLODIndex_PropertyAddress.Address, TargetLODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSGenerateLODLevel_FunctionAddress, intPtr, GSGenerateLODLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSGenerateLODLevel_LevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetTagNameBySocketName")]
	public unsafe static string GetTagNameBySocketName(UStaticMeshComponent StaticMesh, FName SocketName)
	{
		if (!GetTagNameBySocketName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetTagNameBySocketName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagNameBySocketName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagNameBySocketName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GetTagNameBySocketName_StaticMesh_Offset), 0, GetTagNameBySocketName_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTagNameBySocketName_SocketName_Offset), 0, GetTagNameBySocketName_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTagNameBySocketName_FunctionAddress, intPtr, GetTagNameBySocketName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTagNameBySocketName_ReturnValue_Offset), 0, GetTagNameBySocketName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTagNameBySocketName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetStaticMeshEditorSubsystem")]
	public unsafe static UStaticMeshEditorSubsystem GetStaticMeshEditorSubsystem()
	{
		if (!GetStaticMeshEditorSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetStaticMeshEditorSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStaticMeshEditorSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStaticMeshEditorSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStaticMeshEditorSubsystem_FunctionAddress, intPtr, GetStaticMeshEditorSubsystem_ParamsSize);
		return UObjectMarshaler<UStaticMeshEditorSubsystem>.FromNative(IntPtr.Add(intPtr, GetStaticMeshEditorSubsystem_ReturnValue_Offset), 0, GetStaticMeshEditorSubsystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedFolders")]
	public unsafe static List<string> GetSelectedFolders()
	{
		if (!GetSelectedFolders_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedFolders");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedFolders_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedFolders_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedFolders_FunctionAddress, intPtr, GetSelectedFolders_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetSelectedFolders_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedFolders_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedFolders_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedAssets")]
	public unsafe static UAssetDataArray GetSelectedAssets()
	{
		if (!GetSelectedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedAssets_FunctionAddress, intPtr, GetSelectedAssets_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetSelectedAssets_ReturnValue_Offset), 0, GetSelectedAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromObjects")]
	public unsafe static UAssetDataArray GetReferenceAssetsFromObjects(List<UObject> LoadedSourceAssets)
	{
		if (!GetReferenceAssetsFromObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferenceAssetsFromObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferenceAssetsFromObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset), LoadedSourceAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReferenceAssetsFromObjects_FunctionAddress, intPtr, GetReferenceAssetsFromObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetReferenceAssetsFromObjects_ReturnValue_Offset), 0, GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromAssets")]
	public unsafe static UAssetDataArray GetReferenceAssetsFromAssets(UAssetDataArray Assets)
	{
		if (!GetReferenceAssetsFromAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferenceAssetsFromAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferenceAssetsFromAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetReferenceAssetsFromAssets_Assets_Offset), 0, GetReferenceAssetsFromAssets_Assets_PropertyAddress.Address, Assets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReferenceAssetsFromAssets_FunctionAddress, intPtr, GetReferenceAssetsFromAssets_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetReferenceAssetsFromAssets_ReturnValue_Offset), 0, GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetPreviewStaticMeshBySocketName")]
	public unsafe static UStaticMesh GetPreviewStaticMeshBySocketName(UStaticMeshComponent StaticMesh, FName SocketName)
	{
		if (!GetPreviewStaticMeshBySocketName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetPreviewStaticMeshBySocketName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewStaticMeshBySocketName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewStaticMeshBySocketName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GetPreviewStaticMeshBySocketName_StaticMesh_Offset), 0, GetPreviewStaticMeshBySocketName_StaticMesh_PropertyAddress.Address, StaticMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetPreviewStaticMeshBySocketName_SocketName_Offset), 0, GetPreviewStaticMeshBySocketName_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPreviewStaticMeshBySocketName_FunctionAddress, intPtr, GetPreviewStaticMeshBySocketName_ParamsSize);
		return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(intPtr, GetPreviewStaticMeshBySocketName_ReturnValue_Offset), 0, GetPreviewStaticMeshBySocketName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetLevelFoliageInstanceBounds")]
	public unsafe static Dictionary<string, FFoliageBounds> GetLevelFoliageInstanceBounds(string Level)
	{
		if (!GetLevelFoliageInstanceBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetLevelFoliageInstanceBounds");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelFoliageInstanceBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelFoliageInstanceBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceBounds_Level_Offset), 0, GetLevelFoliageInstanceBounds_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelFoliageInstanceBounds_FunctionAddress, intPtr, GetLevelFoliageInstanceBounds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelFoliageInstanceBounds_Level_PropertyAddress.Address, intPtr);
		Dictionary<string, FFoliageBounds> result = new TMapCopyMarshaler<string, FFoliageBounds>(1, GetLevelFoliageInstanceBounds_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FFoliageBounds, FFoliageBounds>.FromNative, CachedMarshalingDelegates<FFoliageBounds, FFoliageBounds>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelFoliageInstanceBounds_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelFoliageInstanceBounds_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetFactoryForAssetObject")]
	public unsafe static UActorFactory GetFactoryForAssetObject(UObject AssetObject)
	{
		if (!GetFactoryForAssetObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetFactoryForAssetObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFactoryForAssetObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFactoryForAssetObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetFactoryForAssetObject_AssetObject_Offset), 0, GetFactoryForAssetObject_AssetObject_PropertyAddress.Address, AssetObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFactoryForAssetObject_FunctionAddress, intPtr, GetFactoryForAssetObject_ParamsSize);
		return UObjectMarshaler<UActorFactory>.FromNative(IntPtr.Add(intPtr, GetFactoryForAssetObject_ReturnValue_Offset), 0, GetFactoryForAssetObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorWorld")]
	public unsafe static UWorld GetEditorWorld()
	{
		if (!GetEditorWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditorWorld_FunctionAddress, intPtr, GetEditorWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetEditorWorld_ReturnValue_Offset), 0, GetEditorWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorActorSubsystem")]
	public unsafe static UEditorActorSubsystem GetEditorActorSubsystem()
	{
		if (!GetEditorActorSubsystem_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorActorSubsystem");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorActorSubsystem_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorActorSubsystem_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditorActorSubsystem_FunctionAddress, intPtr, GetEditorActorSubsystem_ParamsSize);
		return UObjectMarshaler<UEditorActorSubsystem>.FromNative(IntPtr.Add(intPtr, GetEditorActorSubsystem_ReturnValue_Offset), 0, GetEditorActorSubsystem_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDONodeComponents")]
	public unsafe static List<UActorComponent> GetCDONodeComponents(AActor CDO)
	{
		if (!GetCDONodeComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDONodeComponents");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCDONodeComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCDONodeComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetCDONodeComponents_CDO_Offset), 0, GetCDONodeComponents_CDO_PropertyAddress.Address, CDO);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCDONodeComponents_FunctionAddress, intPtr, GetCDONodeComponents_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetCDONodeComponents_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetCDONodeComponents_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetCDONodeComponents_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDOComponentByName")]
	public unsafe static UActorComponent GetCDOComponentByName(UBlueprint BP, FName CompName, bool bCreateInheritable = false)
	{
		if (!GetCDOComponentByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDOComponentByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCDOComponentByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCDOComponentByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetCDOComponentByName_BP_Offset), 0, GetCDOComponentByName_BP_PropertyAddress.Address, BP);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetCDOComponentByName_CompName_Offset), 0, GetCDOComponentByName_CompName_PropertyAddress.Address, CompName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetCDOComponentByName_bCreateInheritable_Offset), 0, GetCDOComponentByName_bCreateInheritable_PropertyAddress.Address, bCreateInheritable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCDOComponentByName_FunctionAddress, intPtr, GetCDOComponentByName_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, GetCDOComponentByName_ReturnValue_Offset), 0, GetCDOComponentByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetBlueprintCDOComponentByName")]
	public unsafe static UActorComponent GetBlueprintCDOComponentByName(UBlueprint BP, FName CompName)
	{
		if (!GetBlueprintCDOComponentByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetBlueprintCDOComponentByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprintCDOComponentByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprintCDOComponentByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetBlueprintCDOComponentByName_BP_Offset), 0, GetBlueprintCDOComponentByName_BP_PropertyAddress.Address, BP);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetBlueprintCDOComponentByName_CompName_Offset), 0, GetBlueprintCDOComponentByName_CompName_PropertyAddress.Address, CompName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlueprintCDOComponentByName_FunctionAddress, intPtr, GetBlueprintCDOComponentByName_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, GetBlueprintCDOComponentByName_ReturnValue_Offset), 0, GetBlueprintCDOComponentByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetsInFolder")]
	public unsafe static UAssetDataArray GetAssetsInFolder(FName FolderPath, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
	{
		if (!GetAssetsInFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetsInFolder");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsInFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsInFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_FolderPath_Offset), 0, GetAssetsInFolder_FolderPath_PropertyAddress.Address, FolderPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_bRecursive_Offset), 0, GetAssetsInFolder_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsInFolder_FunctionAddress, intPtr, GetAssetsInFolder_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetsInFolder_ReturnValue_Offset), 0, GetAssetsInFolder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetDataFromPackageObj")]
	public unsafe static UAssetDataArray GetAssetDataFromPackageObj(List<UObject> PackageObjects)
	{
		if (!GetAssetDataFromPackageObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetDataFromPackageObj");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataFromPackageObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataFromPackageObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, GetAssetDataFromPackageObj_PackageObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetDataFromPackageObj_PackageObjects_Offset), PackageObjects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataFromPackageObj_FunctionAddress, intPtr, GetAssetDataFromPackageObj_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetDataFromPackageObj_PackageObjects_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetDataFromPackageObj_ReturnValue_Offset), 0, GetAssetDataFromPackageObj_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetAllComponentTemplateInBlueprint")]
	public unsafe static List<UActorComponent> GetAllComponentTemplateInBlueprint(UBlueprint Blueprint)
	{
		if (!GetAllComponentTemplateInBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetAllComponentTemplateInBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllComponentTemplateInBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllComponentTemplateInBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetAllComponentTemplateInBlueprint_Blueprint_Offset), 0, GetAllComponentTemplateInBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllComponentTemplateInBlueprint_FunctionAddress, intPtr, GetAllComponentTemplateInBlueprint_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GetAllComponentTemplateInBlueprint_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllComponentTemplateInBlueprint_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllComponentTemplateInBlueprint_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GetActorPlacementLocationOnCursor")]
	public unsafe static FVector GetActorPlacementLocationOnCursor(AActor Actor)
	{
		if (!GetActorPlacementLocationOnCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GetActorPlacementLocationOnCursor");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorPlacementLocationOnCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorPlacementLocationOnCursor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorPlacementLocationOnCursor_Actor_Offset), 0, GetActorPlacementLocationOnCursor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorPlacementLocationOnCursor_FunctionAddress, intPtr, GetActorPlacementLocationOnCursor_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorPlacementLocationOnCursor_ReturnValue_Offset), 0, GetActorPlacementLocationOnCursor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_ValidateSceneRootNodes")]
	public unsafe static void GEditor_ValidateSceneRootNodes(UBlueprint BlueprintObj)
	{
		if (!GEditor_ValidateSceneRootNodes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_ValidateSceneRootNodes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_ValidateSceneRootNodes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_ValidateSceneRootNodes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GEditor_ValidateSceneRootNodes_BlueprintObj_Offset), 0, GEditor_ValidateSceneRootNodes_BlueprintObj_PropertyAddress.Address, BlueprintObj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_ValidateSceneRootNodes_FunctionAddress, intPtr, GEditor_ValidateSceneRootNodes_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_UseActorFactory")]
	public unsafe static AActor GEditor_UseActorFactory(UActorFactory ActorFactory, UAssetDataArray AssetData, FTransform Transform)
	{
		if (!GEditor_UseActorFactory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_UseActorFactory");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_UseActorFactory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_UseActorFactory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorFactory>.ToNative(IntPtr.Add(intPtr, GEditor_UseActorFactory_ActorFactory_Offset), 0, GEditor_UseActorFactory_ActorFactory_PropertyAddress.Address, ActorFactory);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GEditor_UseActorFactory_AssetData_Offset), 0, GEditor_UseActorFactory_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InitializeValue_InContainer(GEditor_UseActorFactory_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, GEditor_UseActorFactory_Transform_Offset), 0, GEditor_UseActorFactory_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_UseActorFactory_FunctionAddress, intPtr, GEditor_UseActorFactory_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GEditor_UseActorFactory_ReturnValue_Offset), 0, GEditor_UseActorFactory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshUnregisterComponent")]
	public unsafe static void GEditor_StaticMeshUnregisterComponent(UStaticMeshComponent StaticMesh)
	{
		if (!GEditor_StaticMeshUnregisterComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshUnregisterComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_StaticMeshUnregisterComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_StaticMeshUnregisterComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GEditor_StaticMeshUnregisterComponent_StaticMesh_Offset), 0, GEditor_StaticMeshUnregisterComponent_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_StaticMeshUnregisterComponent_FunctionAddress, intPtr, GEditor_StaticMeshUnregisterComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshRegisterComponentWithWorld")]
	public unsafe static void GEditor_StaticMeshRegisterComponentWithWorld(UStaticMeshComponent StaticMesh, UWorld InWorld)
	{
		if (!GEditor_StaticMeshRegisterComponentWithWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshRegisterComponentWithWorld");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_StaticMeshRegisterComponentWithWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_StaticMeshRegisterComponentWithWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_Offset), 0, GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_PropertyAddress.Address, StaticMesh);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GEditor_StaticMeshRegisterComponentWithWorld_InWorld_Offset), 0, GEditor_StaticMeshRegisterComponentWithWorld_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, intPtr, GEditor_StaticMeshRegisterComponentWithWorld_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SpawnActorAbsolute")]
	public unsafe static AActor GEditor_SpawnActorAbsolute(UWorld EditotWorld, TSubclassOf<AActor> Class, FTransform Transform)
	{
		if (!GEditor_SpawnActorAbsolute_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SpawnActorAbsolute");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_SpawnActorAbsolute_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_SpawnActorAbsolute_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GEditor_SpawnActorAbsolute_EditotWorld_Offset), 0, GEditor_SpawnActorAbsolute_EditotWorld_PropertyAddress.Address, EditotWorld);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GEditor_SpawnActorAbsolute_Class_Offset), 0, GEditor_SpawnActorAbsolute_Class_PropertyAddress.Address, Class);
		NativeReflection.InitializeValue_InContainer(GEditor_SpawnActorAbsolute_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, GEditor_SpawnActorAbsolute_Transform_Offset), 0, GEditor_SpawnActorAbsolute_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_SpawnActorAbsolute_FunctionAddress, intPtr, GEditor_SpawnActorAbsolute_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GEditor_SpawnActorAbsolute_ReturnValue_Offset), 0, GEditor_SpawnActorAbsolute_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SnapRotatorToGrid")]
	public unsafe static FRotator GEditor_SnapRotatorToGrid(FRotator RotationToSnapped)
	{
		if (!GEditor_SnapRotatorToGrid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SnapRotatorToGrid");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_SnapRotatorToGrid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_SnapRotatorToGrid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, GEditor_SnapRotatorToGrid_RotationToSnapped_Offset), 0, GEditor_SnapRotatorToGrid_RotationToSnapped_PropertyAddress.Address, RotationToSnapped);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_SnapRotatorToGrid_FunctionAddress, intPtr, GEditor_SnapRotatorToGrid_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GEditor_SnapRotatorToGrid_ReturnValue_Offset), 0, GEditor_SnapRotatorToGrid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SetGAllowActorScriptExecutionInEditor")]
	public unsafe static void GEditor_SetGAllowActorScriptExecutionInEditor(bool bVal)
	{
		if (!GEditor_SetGAllowActorScriptExecutionInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SetGAllowActorScriptExecutionInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_SetGAllowActorScriptExecutionInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_SetGAllowActorScriptExecutionInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_SetGAllowActorScriptExecutionInEditor_bVal_Offset), 0, GEditor_SetGAllowActorScriptExecutionInEditor_bVal_PropertyAddress.Address, bVal);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress, intPtr, GEditor_SetGAllowActorScriptExecutionInEditor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_RecalculateMouseRayHitTransform")]
	public unsafe static bool GEditor_RecalculateMouseRayHitTransform(FJavascriptEdViewport JSViewport, bool UseUpRot, out FTransform SpawnWorldTransform, bool EnableSnapX, bool EnableSnapY, bool EnableSnapZ, List<AActor> IgnoreActors)
	{
		if (!GEditor_RecalculateMouseRayHitTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_RecalculateMouseRayHitTransform");
			SpawnWorldTransform = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_RecalculateMouseRayHitTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_RecalculateMouseRayHitTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_JSViewport_Offset), 0, GEditor_RecalculateMouseRayHitTransform_JSViewport_PropertyAddress.Address, JSViewport);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_UseUpRot_Offset), 0, GEditor_RecalculateMouseRayHitTransform_UseUpRot_PropertyAddress.Address, UseUpRot);
		NativeReflection.InitializeValue_InContainer(GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_EnableSnapX_Offset), 0, GEditor_RecalculateMouseRayHitTransform_EnableSnapX_PropertyAddress.Address, EnableSnapX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_EnableSnapY_Offset), 0, GEditor_RecalculateMouseRayHitTransform_EnableSnapY_PropertyAddress.Address, EnableSnapY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_Offset), 0, GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_PropertyAddress.Address, EnableSnapZ);
		new TArrayCopyMarshaler<AActor>(1, GEditor_RecalculateMouseRayHitTransform_IgnoreActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_IgnoreActors_Offset), IgnoreActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, intPtr, GEditor_RecalculateMouseRayHitTransform_ParamsSize);
		SpawnWorldTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_Offset), 0, GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GEditor_RecalculateMouseRayHitTransform_IgnoreActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GEditor_RecalculateMouseRayHitTransform_ReturnValue_Offset), 0, GEditor_RecalculateMouseRayHitTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsStaticMeshRegistered")]
	public unsafe static bool GEditor_IsStaticMeshRegistered(UStaticMeshComponent StaticMesh)
	{
		if (!GEditor_IsStaticMeshRegistered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsStaticMeshRegistered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_IsStaticMeshRegistered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_IsStaticMeshRegistered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(intPtr, GEditor_IsStaticMeshRegistered_StaticMesh_Offset), 0, GEditor_IsStaticMeshRegistered_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_IsStaticMeshRegistered_FunctionAddress, intPtr, GEditor_IsStaticMeshRegistered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GEditor_IsStaticMeshRegistered_ReturnValue_Offset), 0, GEditor_IsStaticMeshRegistered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsRunningCommandlet")]
	public unsafe static bool GEditor_IsRunningCommandlet()
	{
		if (!GEditor_IsRunningCommandlet_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsRunningCommandlet");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_IsRunningCommandlet_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_IsRunningCommandlet_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_IsRunningCommandlet_FunctionAddress, intPtr, GEditor_IsRunningCommandlet_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GEditor_IsRunningCommandlet_ReturnValue_Offset), 0, GEditor_IsRunningCommandlet_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetSelectedInstancesFoliageType")]
	public unsafe static UFoliageType GEditor_GetSelectedInstancesFoliageType()
	{
		if (!GEditor_GetSelectedInstancesFoliageType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetSelectedInstancesFoliageType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetSelectedInstancesFoliageType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetSelectedInstancesFoliageType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetSelectedInstancesFoliageType_FunctionAddress, intPtr, GEditor_GetSelectedInstancesFoliageType_ParamsSize);
		return UObjectMarshaler<UFoliageType>.FromNative(IntPtr.Add(intPtr, GEditor_GetSelectedInstancesFoliageType_ReturnValue_Offset), 0, GEditor_GetSelectedInstancesFoliageType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetHierarchicalInstancedStaticMeshAssetPath2")]
	public unsafe static void GEditor_GetHierarchicalInstancedStaticMeshAssetPath2(UWorld InWorld, FVector location, float radius)
	{
		if (!GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetHierarchicalInstancedStaticMeshAssetPath2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_Offset), 0, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_PropertyAddress.Address, InWorld);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_Offset), 0, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_PropertyAddress.Address, location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_Offset), 0, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_PropertyAddress.Address, radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, intPtr, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_ParamsSize);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetGAllowActorScriptExecutionInEditor")]
	public unsafe static bool GEditor_GetGAllowActorScriptExecutionInEditor()
	{
		if (!GEditor_GetGAllowActorScriptExecutionInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetGAllowActorScriptExecutionInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetGAllowActorScriptExecutionInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetGAllowActorScriptExecutionInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress, intPtr, GEditor_GetGAllowActorScriptExecutionInEditor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_Offset), 0, GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetFoliageType_Actor_ActorClassAssetPathName")]
	public unsafe static FName GEditor_GetFoliageType_Actor_ActorClassAssetPathName(UFoliageType_Actor FoliageType_Actor)
	{
		if (!GEditor_GetFoliageType_Actor_ActorClassAssetPathName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetFoliageType_Actor_ActorClassAssetPathName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_Actor>.ToNative(IntPtr.Add(intPtr, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_Offset), 0, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_PropertyAddress.Address, FoliageType_Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, intPtr, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_Offset), 0, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintParentClass")]
	public unsafe static TSubclassOf<UObject> GEditor_GetBlueprintParentClass(UBlueprint Blueprint)
	{
		if (!GEditor_GetBlueprintParentClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintParentClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetBlueprintParentClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetBlueprintParentClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GEditor_GetBlueprintParentClass_Blueprint_Offset), 0, GEditor_GetBlueprintParentClass_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetBlueprintParentClass_FunctionAddress, intPtr, GEditor_GetBlueprintParentClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GEditor_GetBlueprintParentClass_ReturnValue_Offset), 0, GEditor_GetBlueprintParentClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintAsset")]
	public unsafe static UBlueprint GEditor_GetBlueprintAsset(UObject Object)
	{
		if (!GEditor_GetBlueprintAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_GetBlueprintAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_GetBlueprintAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GEditor_GetBlueprintAsset_Object_Offset), 0, GEditor_GetBlueprintAsset_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_GetBlueprintAsset_FunctionAddress, intPtr, GEditor_GetBlueprintAsset_ParamsSize);
		return UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(intPtr, GEditor_GetBlueprintAsset_ReturnValue_Offset), 0, GEditor_GetBlueprintAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_FoliageType_Actor_ActorClass")]
	public unsafe static List<UActorComponent> GEditor_FoliageType_Actor_ActorClass(UFoliageType_Actor FoliageType_Actor)
	{
		if (!GEditor_FoliageType_Actor_ActorClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_FoliageType_Actor_ActorClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_FoliageType_Actor_ActorClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_FoliageType_Actor_ActorClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFoliageType_Actor>.ToNative(IntPtr.Add(intPtr, GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_Offset), 0, GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_PropertyAddress.Address, FoliageType_Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_FoliageType_Actor_ActorClass_FunctionAddress, intPtr, GEditor_FoliageType_Actor_ActorClass_ParamsSize);
		List<UActorComponent> result = new TArrayCopyMarshaler<UActorComponent>(1, GEditor_FoliageType_Actor_ActorClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, GEditor_FoliageType_Actor_ActorClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GEditor_FoliageType_Actor_ActorClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_DestroyActorTest")]
	public unsafe static void GEditor_DestroyActorTest(AActor NeedDestroyAcotr)
	{
		if (!GEditor_DestroyActorTest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_DestroyActorTest");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_DestroyActorTest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_DestroyActorTest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GEditor_DestroyActorTest_NeedDestroyAcotr_Offset), 0, GEditor_DestroyActorTest_NeedDestroyAcotr_PropertyAddress.Address, NeedDestroyAcotr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_DestroyActorTest_FunctionAddress, intPtr, GEditor_DestroyActorTest_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CreateMID")]
	public unsafe static UMaterialInstanceDynamic GEditor_CreateMID(UMaterialInterface ParentMaterial, UObject InOuter)
	{
		if (!GEditor_CreateMID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CreateMID");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_CreateMID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_CreateMID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, GEditor_CreateMID_ParentMaterial_Offset), 0, GEditor_CreateMID_ParentMaterial_PropertyAddress.Address, ParentMaterial);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GEditor_CreateMID_InOuter_Offset), 0, GEditor_CreateMID_InOuter_PropertyAddress.Address, InOuter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_CreateMID_FunctionAddress, intPtr, GEditor_CreateMID_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(intPtr, GEditor_CreateMID_ReturnValue_Offset), 0, GEditor_CreateMID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CalculateComponentsBoundingBoxInLocalSpace")]
	public unsafe static FVector GEditor_CalculateComponentsBoundingBoxInLocalSpace(AActor Unit, bool bNonColliding)
	{
		if (!GEditor_CalculateComponentsBoundingBoxInLocalSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CalculateComponentsBoundingBoxInLocalSpace");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_CalculateComponentsBoundingBoxInLocalSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_CalculateComponentsBoundingBoxInLocalSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_Offset), 0, GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_PropertyAddress.Address, Unit);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_Offset), 0, GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_PropertyAddress.Address, bNonColliding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, intPtr, GEditor_CalculateComponentsBoundingBoxInLocalSpace_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_Offset), 0, GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_AddCompToActor")]
	public unsafe static USceneComponent GEditor_AddCompToActor(UWorld EditotWorld, TSubclassOf<USceneComponent> Class, AActor Actor)
	{
		if (!GEditor_AddCompToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_AddCompToActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GEditor_AddCompToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GEditor_AddCompToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GEditor_AddCompToActor_EditotWorld_Offset), 0, GEditor_AddCompToActor_EditotWorld_PropertyAddress.Address, EditotWorld);
		TSubclassOfMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, GEditor_AddCompToActor_Class_Offset), 0, GEditor_AddCompToActor_Class_PropertyAddress.Address, Class);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GEditor_AddCompToActor_Actor_Offset), 0, GEditor_AddCompToActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GEditor_AddCompToActor_FunctionAddress, intPtr, GEditor_AddCompToActor_ParamsSize);
		return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(intPtr, GEditor_AddCompToActor_ReturnValue_Offset), 0, GEditor_AddCompToActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ForceGCInEditor")]
	public unsafe static void ForceGCInEditor(int flag)
	{
		if (!ForceGCInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ForceGCInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceGCInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceGCInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ForceGCInEditor_flag_Offset), 0, ForceGCInEditor_flag_PropertyAddress.Address, flag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceGCInEditor_FunctionAddress, intPtr, ForceGCInEditor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ExportStaticMeshInternal")]
	public unsafe static void ExportStaticMeshInternal(List<UObject> ObjectsToExport, string ExportPath)
	{
		if (!ExportStaticMeshInternal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ExportStaticMeshInternal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportStaticMeshInternal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportStaticMeshInternal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ExportStaticMeshInternal_ObjectsToExport_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ExportStaticMeshInternal_ObjectsToExport_Offset), ObjectsToExport);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportStaticMeshInternal_ExportPath_Offset), 0, ExportStaticMeshInternal_ExportPath_PropertyAddress.Address, ExportPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportStaticMeshInternal_FunctionAddress, intPtr, ExportStaticMeshInternal_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportStaticMeshInternal_ObjectsToExport_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportStaticMeshInternal_ExportPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:EnableAllPlantsImposter")]
	public unsafe static void EnableAllPlantsImposter(string MapName, List<string> PlantsKeyWords, List<string> RuleOutKeyWords)
	{
		if (!EnableAllPlantsImposter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:EnableAllPlantsImposter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableAllPlantsImposter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableAllPlantsImposter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EnableAllPlantsImposter_MapName_Offset), 0, EnableAllPlantsImposter_MapName_PropertyAddress.Address, MapName);
		new TArrayCopyMarshaler<string>(1, EnableAllPlantsImposter_PlantsKeyWords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, EnableAllPlantsImposter_PlantsKeyWords_Offset), PlantsKeyWords);
		new TArrayCopyMarshaler<string>(1, EnableAllPlantsImposter_RuleOutKeyWords_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, EnableAllPlantsImposter_RuleOutKeyWords_Offset), RuleOutKeyWords);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableAllPlantsImposter_FunctionAddress, intPtr, EnableAllPlantsImposter_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EnableAllPlantsImposter_MapName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EnableAllPlantsImposter_PlantsKeyWords_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EnableAllPlantsImposter_RuleOutKeyWords_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:DuplicateSubobjects")]
	public unsafe static void DuplicateSubobjects(FSubobjectDataHandle Context, List<FSubobjectDataHandle> SubobjectsToDup, UBlueprint BpContext, out List<FSubobjectDataHandle> OutNewSubobjects)
	{
		if (!DuplicateSubobjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:DuplicateSubobjects");
			OutNewSubobjects = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateSubobjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateSubobjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DuplicateSubobjects_Context_PropertyAddress.Address, intPtr);
		FSubobjectDataHandle.ToNative(IntPtr.Add(intPtr, DuplicateSubobjects_Context_Offset), 0, DuplicateSubobjects_Context_PropertyAddress.Address, Context);
		new TArrayCopyMarshaler<FSubobjectDataHandle>(1, DuplicateSubobjects_SubobjectsToDup_PropertyAddress, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.FromNative, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.ToNative).ToNative(IntPtr.Add(intPtr, DuplicateSubobjects_SubobjectsToDup_Offset), SubobjectsToDup);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, DuplicateSubobjects_BpContext_Offset), 0, DuplicateSubobjects_BpContext_PropertyAddress.Address, BpContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateSubobjects_FunctionAddress, intPtr, DuplicateSubobjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateSubobjects_Context_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateSubobjects_SubobjectsToDup_PropertyAddress.Address, intPtr);
		OutNewSubobjects = new TArrayCopyMarshaler<FSubobjectDataHandle>(1, DuplicateSubobjects_OutNewSubobjects_PropertyAddress, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.FromNative, CachedMarshalingDelegates<FSubobjectDataHandle, FSubobjectDataHandle>.ToNative).FromNative(IntPtr.Add(intPtr, DuplicateSubobjects_OutNewSubobjects_Offset));
		NativeReflection.DestroyValue_InContainer(DuplicateSubobjects_OutNewSubobjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:CreateBlueprintWithClass")]
	public unsafe static UObject CreateBlueprintWithClass(TSubclassOf<UObject> ParentClass, string AssetName, string PackagePath)
	{
		if (!CreateBlueprintWithClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:CreateBlueprintWithClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBlueprintWithClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBlueprintWithClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateBlueprintWithClass_ParentClass_Offset), 0, CreateBlueprintWithClass_ParentClass_PropertyAddress.Address, ParentClass);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlueprintWithClass_AssetName_Offset), 0, CreateBlueprintWithClass_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBlueprintWithClass_PackagePath_Offset), 0, CreateBlueprintWithClass_PackagePath_PropertyAddress.Address, PackagePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateBlueprintWithClass_FunctionAddress, intPtr, CreateBlueprintWithClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateBlueprintWithClass_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateBlueprintWithClass_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CreateBlueprintWithClass_ReturnValue_Offset), 0, CreateBlueprintWithClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:CopyThumbnailBetweenBlueprint")]
	public unsafe static void CopyThumbnailBetweenBlueprint(UBlueprint Origin, UBlueprint Target)
	{
		if (!CopyThumbnailBetweenBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:CopyThumbnailBetweenBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyThumbnailBetweenBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyThumbnailBetweenBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, CopyThumbnailBetweenBlueprint_Origin_Offset), 0, CopyThumbnailBetweenBlueprint_Origin_PropertyAddress.Address, Origin);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, CopyThumbnailBetweenBlueprint_Target_Offset), 0, CopyThumbnailBetweenBlueprint_Target_PropertyAddress.Address, Target);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyThumbnailBetweenBlueprint_FunctionAddress, intPtr, CopyThumbnailBetweenBlueprint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ConvertHISMToStaticMeshActor")]
	public unsafe static void ConvertHISMToStaticMeshActor(UObject WorldContext)
	{
		if (!ConvertHISMToStaticMeshActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ConvertHISMToStaticMeshActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertHISMToStaticMeshActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertHISMToStaticMeshActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ConvertHISMToStaticMeshActor_WorldContext_Offset), 0, ConvertHISMToStaticMeshActor_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertHISMToStaticMeshActor_FunctionAddress, intPtr, ConvertHISMToStaticMeshActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ContainRuntimeVirtualTexture")]
	public unsafe static bool ContainRuntimeVirtualTexture(UPrimitiveComponent PrimComponent, URuntimeVirtualTexture RVT)
	{
		if (!ContainRuntimeVirtualTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ContainRuntimeVirtualTexture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ContainRuntimeVirtualTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ContainRuntimeVirtualTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ContainRuntimeVirtualTexture_PrimComponent_Offset), 0, ContainRuntimeVirtualTexture_PrimComponent_PropertyAddress.Address, PrimComponent);
		UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(intPtr, ContainRuntimeVirtualTexture_RVT_Offset), 0, ContainRuntimeVirtualTexture_RVT_PropertyAddress.Address, RVT);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ContainRuntimeVirtualTexture_FunctionAddress, intPtr, ContainRuntimeVirtualTexture_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ContainRuntimeVirtualTexture_ReturnValue_Offset), 0, ContainRuntimeVirtualTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ClearRuntimeVirtualTexture")]
	public unsafe static void ClearRuntimeVirtualTexture(UPrimitiveComponent PrimComponent)
	{
		if (!ClearRuntimeVirtualTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ClearRuntimeVirtualTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearRuntimeVirtualTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearRuntimeVirtualTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ClearRuntimeVirtualTexture_PrimComponent_Offset), 0, ClearRuntimeVirtualTexture_PrimComponent_PropertyAddress.Address, PrimComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearRuntimeVirtualTexture_FunctionAddress, intPtr, ClearRuntimeVirtualTexture_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapFoliages")]
	public unsafe static void CleanOverlapFoliages()
	{
		if (!CleanOverlapFoliages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapFoliages");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanOverlapFoliages_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanOverlapFoliages_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CleanOverlapFoliages_FunctionAddress, argsSize: CleanOverlapFoliages_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapActors")]
	public unsafe static void CleanOverlapActors()
	{
		if (!CleanOverlapActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanOverlapActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanOverlapActors_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CleanOverlapActors_FunctionAddress, argsSize: CleanOverlapActors_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:CheckoutAndSavePackage")]
	public unsafe static bool CheckoutAndSavePackage(List<UPackage> PackagesToSave, bool bCheckDirty, bool bPromptToSave, out List<UPackage> OutFailedPackages, bool bAlreadyCheckedOut = false, bool bCanBeDeclined = true)
	{
		if (!CheckoutAndSavePackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:CheckoutAndSavePackage");
			OutFailedPackages = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutAndSavePackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutAndSavePackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UPackage>(1, CheckoutAndSavePackage_PackagesToSave_PropertyAddress, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.FromNative, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.ToNative).ToNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_PackagesToSave_Offset), PackagesToSave);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_bCheckDirty_Offset), 0, CheckoutAndSavePackage_bCheckDirty_PropertyAddress.Address, bCheckDirty);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_bPromptToSave_Offset), 0, CheckoutAndSavePackage_bPromptToSave_PropertyAddress.Address, bPromptToSave);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_bAlreadyCheckedOut_Offset), 0, CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress.Address, bAlreadyCheckedOut);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_bCanBeDeclined_Offset), 0, CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress.Address, bCanBeDeclined);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutAndSavePackage_FunctionAddress, intPtr, CheckoutAndSavePackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckoutAndSavePackage_PackagesToSave_PropertyAddress.Address, intPtr);
		OutFailedPackages = new TArrayCopyMarshaler<UPackage>(1, CheckoutAndSavePackage_OutFailedPackages_PropertyAddress, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.FromNative, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.ToNative).FromNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_OutFailedPackages_Offset));
		NativeReflection.DestroyValue_InContainer(CheckoutAndSavePackage_OutFailedPackages_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckoutAndSavePackage_ReturnValue_Offset), 0, CheckoutAndSavePackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:ChangeBufferVisualizationMode")]
	public unsafe static void ChangeBufferVisualizationMode(FName InName)
	{
		if (!ChangeBufferVisualizationMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:ChangeBufferVisualizationMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ChangeBufferVisualizationMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ChangeBufferVisualizationMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ChangeBufferVisualizationMode_InName_Offset), 0, ChangeBufferVisualizationMode_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ChangeBufferVisualizationMode_FunctionAddress, intPtr, ChangeBufferVisualizationMode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGUSplitSplineActor")]
	public unsafe static void BGUSplitSplineActor(AActor InSplineActor)
	{
		if (!BGUSplitSplineActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGUSplitSplineActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSplitSplineActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSplitSplineActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUSplitSplineActor_InSplineActor_Offset), 0, BGUSplitSplineActor_InSplineActor_PropertyAddress.Address, InSplineActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSplitSplineActor_FunctionAddress, intPtr, BGUSplitSplineActor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateSpawnTransform")]
	public unsafe static bool BGURecalculateSpawnTransform(FJavascriptEdViewport JSViewport, bool UseUpRot, out FTransform SpawnWorldTransform, bool EnableSnapX, bool EnableSnapY, bool EnableSnapZ)
	{
		if (!BGURecalculateSpawnTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateSpawnTransform");
			SpawnWorldTransform = default(FTransform);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURecalculateSpawnTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURecalculateSpawnTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_JSViewport_Offset), 0, BGURecalculateSpawnTransform_JSViewport_PropertyAddress.Address, JSViewport);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_UseUpRot_Offset), 0, BGURecalculateSpawnTransform_UseUpRot_PropertyAddress.Address, UseUpRot);
		NativeReflection.InitializeValue_InContainer(BGURecalculateSpawnTransform_SpawnWorldTransform_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_EnableSnapX_Offset), 0, BGURecalculateSpawnTransform_EnableSnapX_PropertyAddress.Address, EnableSnapX);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_EnableSnapY_Offset), 0, BGURecalculateSpawnTransform_EnableSnapY_PropertyAddress.Address, EnableSnapY);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_EnableSnapZ_Offset), 0, BGURecalculateSpawnTransform_EnableSnapZ_PropertyAddress.Address, EnableSnapZ);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURecalculateSpawnTransform_FunctionAddress, intPtr, BGURecalculateSpawnTransform_ParamsSize);
		SpawnWorldTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_SpawnWorldTransform_Offset), 0, BGURecalculateSpawnTransform_SpawnWorldTransform_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGURecalculateSpawnTransform_ReturnValue_Offset), 0, BGURecalculateSpawnTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateMousePlaneIntersectionWorldLocation")]
	public unsafe static bool BGURecalculateMousePlaneIntersectionWorldLocation(FJavascriptEdViewport JSViewport, FTransform SpawnWorldTransform, out FPlane SpawnTracePlane, out FVector CursorPlaneIntersectionWorldLocation)
	{
		if (!BGURecalculateMousePlaneIntersectionWorldLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateMousePlaneIntersectionWorldLocation");
			SpawnTracePlane = default(FPlane);
			CursorPlaneIntersectionWorldLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURecalculateMousePlaneIntersectionWorldLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURecalculateMousePlaneIntersectionWorldLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptEdViewport>.ToNative(IntPtr.Add(intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_Offset), 0, BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_PropertyAddress.Address, JSViewport);
		NativeReflection.InitializeValue_InContainer(BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_Offset), 0, BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_PropertyAddress.Address, SpawnWorldTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_ParamsSize);
		SpawnTracePlane = BlittableTypeMarshaler<FPlane>.FromNative(IntPtr.Add(intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_Offset), 0, BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_PropertyAddress.Address);
		CursorPlaneIntersectionWorldLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_Offset), 0, BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_Offset), 0, BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenSplineAirWall")]
	public unsafe static ABGWBlockingVolume BGUGenSplineAirWall(UObject WorldContextObject, List<FVector> BaseVertices, float AirWallHeight, bool bMakeInvisible, EAirWallType AirWallType, FVector UpDirection, bool bNavModify)
	{
		if (!BGUGenSplineAirWall_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenSplineAirWall");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenSplineAirWall_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenSplineAirWall_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_WorldContextObject_Offset), 0, BGUGenSplineAirWall_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<FVector>(1, BGUGenSplineAirWall_BaseVertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_BaseVertices_Offset), BaseVertices);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_AirWallHeight_Offset), 0, BGUGenSplineAirWall_AirWallHeight_PropertyAddress.Address, AirWallHeight);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_bMakeInvisible_Offset), 0, BGUGenSplineAirWall_bMakeInvisible_PropertyAddress.Address, bMakeInvisible);
		EnumMarshaler<EAirWallType>.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_AirWallType_Offset), 0, BGUGenSplineAirWall_AirWallType_PropertyAddress.Address, AirWallType);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_UpDirection_Offset), 0, BGUGenSplineAirWall_UpDirection_PropertyAddress.Address, UpDirection);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_bNavModify_Offset), 0, BGUGenSplineAirWall_bNavModify_PropertyAddress.Address, bNavModify);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenSplineAirWall_FunctionAddress, intPtr, BGUGenSplineAirWall_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUGenSplineAirWall_BaseVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ABGWBlockingVolume>.FromNative(IntPtr.Add(intPtr, BGUGenSplineAirWall_ReturnValue_Offset), 0, BGUGenSplineAirWall_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenManualSplineMoveOverlapVolume")]
	public unsafe static ABGWBlockingVolume BGUGenManualSplineMoveOverlapVolume(UObject WorldContext, List<FVector> BaseVertices)
	{
		if (!BGUGenManualSplineMoveOverlapVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenManualSplineMoveOverlapVolume");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenManualSplineMoveOverlapVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenManualSplineMoveOverlapVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGenManualSplineMoveOverlapVolume_WorldContext_Offset), 0, BGUGenManualSplineMoveOverlapVolume_WorldContext_PropertyAddress.Address, WorldContext);
		new TArrayCopyMarshaler<FVector>(1, BGUGenManualSplineMoveOverlapVolume_BaseVertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUGenManualSplineMoveOverlapVolume_BaseVertices_Offset), BaseVertices);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenManualSplineMoveOverlapVolume_FunctionAddress, intPtr, BGUGenManualSplineMoveOverlapVolume_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUGenManualSplineMoveOverlapVolume_BaseVertices_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ABGWBlockingVolume>.FromNative(IntPtr.Add(intPtr, BGUGenManualSplineMoveOverlapVolume_ReturnValue_Offset), 0, BGUGenManualSplineMoveOverlapVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenAirWall")]
	public unsafe static void BGUGenAirWall(UObject WorldContextObject, List<FVector> ShapeVertices, bool bAutoExtrude, int ExtrudeDepth, float AirWallHeight)
	{
		if (!BGUGenAirWall_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenAirWall");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenAirWall_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenAirWall_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGenAirWall_WorldContextObject_Offset), 0, BGUGenAirWall_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		new TArrayCopyMarshaler<FVector>(1, BGUGenAirWall_ShapeVertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUGenAirWall_ShapeVertices_Offset), ShapeVertices);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGenAirWall_bAutoExtrude_Offset), 0, BGUGenAirWall_bAutoExtrude_PropertyAddress.Address, bAutoExtrude);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUGenAirWall_ExtrudeDepth_Offset), 0, BGUGenAirWall_ExtrudeDepth_PropertyAddress.Address, ExtrudeDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUGenAirWall_AirWallHeight_Offset), 0, BGUGenAirWall_AirWallHeight_PropertyAddress.Address, AirWallHeight);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenAirWall_FunctionAddress, intPtr, BGUGenAirWall_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUGenAirWall_ShapeVertices_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:BGUFixSplineAirWallCenterPoint")]
	public unsafe static void BGUFixSplineAirWallCenterPoint()
	{
		if (!BGUFixSplineAirWallCenterPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:BGUFixSplineAirWallCenterPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUFixSplineAirWallCenterPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUFixSplineAirWallCenterPoint_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: BGUFixSplineAirWallCenterPoint_FunctionAddress, argsSize: BGUFixSplineAirWallCenterPoint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:AddRuntimeVirtualTexture")]
	public unsafe static bool AddRuntimeVirtualTexture(UPrimitiveComponent PrimComponent, URuntimeVirtualTexture RVT)
	{
		if (!AddRuntimeVirtualTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:AddRuntimeVirtualTexture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddRuntimeVirtualTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddRuntimeVirtualTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, AddRuntimeVirtualTexture_PrimComponent_Offset), 0, AddRuntimeVirtualTexture_PrimComponent_PropertyAddress.Address, PrimComponent);
		UObjectMarshaler<URuntimeVirtualTexture>.ToNative(IntPtr.Add(intPtr, AddRuntimeVirtualTexture_RVT_Offset), 0, AddRuntimeVirtualTexture_RVT_PropertyAddress.Address, RVT);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddRuntimeVirtualTexture_FunctionAddress, intPtr, AddRuntimeVirtualTexture_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddRuntimeVirtualTexture_ReturnValue_Offset), 0, AddRuntimeVirtualTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToBPAsset")]
	public unsafe static UActorComponent AddNewCompToBPAsset(UBlueprint InBlueprint, FName InComponentVariableName, TSubclassOf<UObject> InComponentClass, out FName outCompVariableName, FName ParentVariableName, FName SocketOrBoneName)
	{
		if (!AddNewCompToBPAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToBPAsset");
			outCompVariableName = default(FName);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewCompToBPAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewCompToBPAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_InBlueprint_Offset), 0, AddNewCompToBPAsset_InBlueprint_PropertyAddress.Address, InBlueprint);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_InComponentVariableName_Offset), 0, AddNewCompToBPAsset_InComponentVariableName_PropertyAddress.Address, InComponentVariableName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_InComponentClass_Offset), 0, AddNewCompToBPAsset_InComponentClass_PropertyAddress.Address, InComponentClass);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_ParentVariableName_Offset), 0, AddNewCompToBPAsset_ParentVariableName_PropertyAddress.Address, ParentVariableName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_SocketOrBoneName_Offset), 0, AddNewCompToBPAsset_SocketOrBoneName_PropertyAddress.Address, SocketOrBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNewCompToBPAsset_FunctionAddress, intPtr, AddNewCompToBPAsset_ParamsSize);
		outCompVariableName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_outCompVariableName_Offset), 0, AddNewCompToBPAsset_outCompVariableName_PropertyAddress.Address);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, AddNewCompToBPAsset_ReturnValue_Offset), 0, AddNewCompToBPAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToActor")]
	public unsafe static UActorComponent AddNewCompToActor(AActor Actor, TSubclassOf<UObject> InComponentClass)
	{
		if (!AddNewCompToActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewCompToActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewCompToActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddNewCompToActor_Actor_Offset), 0, AddNewCompToActor_Actor_PropertyAddress.Address, Actor);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNewCompToActor_InComponentClass_Offset), 0, AddNewCompToActor_InComponentClass_PropertyAddress.Address, InComponentClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNewCompToActor_FunctionAddress, intPtr, AddNewCompToActor_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, AddNewCompToActor_ReturnValue_Offset), 0, AddNewCompToActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:AddCompToBPAsset")]
	public unsafe static UActorComponent AddCompToBPAsset(UBlueprint BP, FName NewComponentVariableName, TSubclassOf<UObject> NewComponentClass, out FName outNewVariableName, FName ParentComponentOrVariableName, FName SocketOrBoneName)
	{
		if (!AddCompToBPAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:AddCompToBPAsset");
			outNewVariableName = default(FName);
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCompToBPAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCompToBPAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, AddCompToBPAsset_BP_Offset), 0, AddCompToBPAsset_BP_PropertyAddress.Address, BP);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCompToBPAsset_NewComponentVariableName_Offset), 0, AddCompToBPAsset_NewComponentVariableName_PropertyAddress.Address, NewComponentVariableName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddCompToBPAsset_NewComponentClass_Offset), 0, AddCompToBPAsset_NewComponentClass_PropertyAddress.Address, NewComponentClass);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCompToBPAsset_ParentComponentOrVariableName_Offset), 0, AddCompToBPAsset_ParentComponentOrVariableName_PropertyAddress.Address, ParentComponentOrVariableName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddCompToBPAsset_SocketOrBoneName_Offset), 0, AddCompToBPAsset_SocketOrBoneName_PropertyAddress.Address, SocketOrBoneName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddCompToBPAsset_FunctionAddress, intPtr, AddCompToBPAsset_ParamsSize);
		outNewVariableName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddCompToBPAsset_outNewVariableName_Offset), 0, AddCompToBPAsset_outNewVariableName_PropertyAddress.Address);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, AddCompToBPAsset_ReturnValue_Offset), 0, AddCompToBPAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSFuncLibForEditor:AddComponentsToBlueprint")]
	public unsafe static void AddComponentsToBlueprint(UBlueprint Blueprint, List<UActorComponent> Components, bool bHarvesting, FName OptionalNewRootComponentTag, bool bKeepMobility)
	{
		if (!AddComponentsToBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSFuncLibForEditor:AddComponentsToBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddComponentsToBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddComponentsToBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_Blueprint_Offset), 0, AddComponentsToBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		new TArrayCopyMarshaler<UActorComponent>(1, AddComponentsToBlueprint_Components_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_Components_Offset), Components);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_bHarvesting_Offset), 0, AddComponentsToBlueprint_bHarvesting_PropertyAddress.Address, bHarvesting);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_OptionalNewRootComponentTag_Offset), 0, AddComponentsToBlueprint_OptionalNewRootComponentTag_PropertyAddress.Address, OptionalNewRootComponentTag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_bKeepMobility_Offset), 0, AddComponentsToBlueprint_bKeepMobility_PropertyAddress.Address, bKeepMobility);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddComponentsToBlueprint_FunctionAddress, intPtr, AddComponentsToBlueprint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddComponentsToBlueprint_Components_PropertyAddress.Address, intPtr);
	}

	static UGSFuncLibForEditor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSFuncLibForEditor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSFuncLibForEditor));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSFuncLibForEditor");
		UpdateFindInAssetsData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateFindInAssetsData");
		UpdateFindInAssetsData_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateFindInAssetsData_FunctionAddress);
		UpdateFindInAssetsData_IsValid = UpdateFindInAssetsData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:UpdateFindInAssetsData", UpdateFindInAssetsData_IsValid);
		ShowNotifyText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowNotifyText");
		ShowNotifyText_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowNotifyText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowNotifyText_InNotifyText_PropertyAddress, ShowNotifyText_FunctionAddress, "InNotifyText");
		ShowNotifyText_InNotifyText_Offset = NativeReflectionCached.GetPropertyOffset(ShowNotifyText_FunctionAddress, "InNotifyText");
		ShowNotifyText_InNotifyText_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowNotifyText_FunctionAddress, "InNotifyText", Classes.FStrProperty);
		ShowNotifyText_IsValid = ShowNotifyText_FunctionAddress != IntPtr.Zero && ShowNotifyText_InNotifyText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ShowNotifyText", ShowNotifyText_IsValid);
		ShowMassageDialog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowMassageDialog");
		ShowMassageDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowMassageDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowMassageDialog_Message_PropertyAddress, ShowMassageDialog_FunctionAddress, "Message");
		ShowMassageDialog_Message_Offset = NativeReflectionCached.GetPropertyOffset(ShowMassageDialog_FunctionAddress, "Message");
		ShowMassageDialog_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMassageDialog_FunctionAddress, "Message", Classes.FStrProperty);
		ShowMassageDialog_IsValid = ShowMassageDialog_FunctionAddress != IntPtr.Zero && ShowMassageDialog_Message_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ShowMassageDialog", ShowMassageDialog_IsValid);
		SetViewportType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewportType");
		SetViewportType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewportType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewportType_InViewportType_PropertyAddress, SetViewportType_FunctionAddress, "InViewportType");
		SetViewportType_InViewportType_Offset = NativeReflectionCached.GetPropertyOffset(SetViewportType_FunctionAddress, "InViewportType");
		SetViewportType_InViewportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewportType_FunctionAddress, "InViewportType", Classes.FByteProperty);
		SetViewportType_IsValid = SetViewportType_FunctionAddress != IntPtr.Zero && SetViewportType_InViewportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewportType", SetViewportType_IsValid);
		SetViewMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewMode");
		SetViewMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewMode_InViewModeIndex_PropertyAddress, SetViewMode_FunctionAddress, "InViewModeIndex");
		SetViewMode_InViewModeIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetViewMode_FunctionAddress, "InViewModeIndex");
		SetViewMode_InViewModeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewMode_FunctionAddress, "InViewModeIndex", Classes.FByteProperty);
		SetViewMode_IsValid = SetViewMode_FunctionAddress != IntPtr.Zero && SetViewMode_InViewModeIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetViewMode", SetViewMode_IsValid);
		SetStatic_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStatic");
		SetStatic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStatic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStatic_InObj_PropertyAddress, SetStatic_FunctionAddress, "InObj");
		SetStatic_InObj_Offset = NativeReflectionCached.GetPropertyOffset(SetStatic_FunctionAddress, "InObj");
		SetStatic_InObj_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStatic_FunctionAddress, "InObj", Classes.FObjectProperty);
		SetStatic_IsValid = SetStatic_FunctionAddress != IntPtr.Zero && SetStatic_InObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetStatic", SetStatic_IsValid);
		SetSplineCompIsEdited_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSplineCompIsEdited");
		SetSplineCompIsEdited_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineCompIsEdited_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineCompIsEdited_SplineComp_PropertyAddress, SetSplineCompIsEdited_FunctionAddress, "SplineComp");
		SetSplineCompIsEdited_SplineComp_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineCompIsEdited_FunctionAddress, "SplineComp");
		SetSplineCompIsEdited_SplineComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineCompIsEdited_FunctionAddress, "SplineComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplineCompIsEdited_IsEdited_PropertyAddress, SetSplineCompIsEdited_FunctionAddress, "IsEdited");
		SetSplineCompIsEdited_IsEdited_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineCompIsEdited_FunctionAddress, "IsEdited");
		SetSplineCompIsEdited_IsEdited_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineCompIsEdited_FunctionAddress, "IsEdited", Classes.FBoolProperty);
		SetSplineCompIsEdited_IsValid = SetSplineCompIsEdited_FunctionAddress != IntPtr.Zero && SetSplineCompIsEdited_SplineComp_IsValid && SetSplineCompIsEdited_IsEdited_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetSplineCompIsEdited", SetSplineCompIsEdited_IsValid);
		SetPreloadLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPreloadLevel");
		SetPreloadLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPreloadLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPreloadLevel_PreloadLevel_PropertyAddress, SetPreloadLevel_FunctionAddress, "PreloadLevel");
		SetPreloadLevel_PreloadLevel_Offset = NativeReflectionCached.GetPropertyOffset(SetPreloadLevel_FunctionAddress, "PreloadLevel");
		SetPreloadLevel_PreloadLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPreloadLevel_FunctionAddress, "PreloadLevel", Classes.FIntProperty);
		SetPreloadLevel_IsValid = SetPreloadLevel_FunctionAddress != IntPtr.Zero && SetPreloadLevel_PreloadLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetPreloadLevel", SetPreloadLevel_IsValid);
		SetNiagaraDisable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNiagaraDisable");
		SetNiagaraDisable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNiagaraDisable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNiagaraDisable_Disable_PropertyAddress, SetNiagaraDisable_FunctionAddress, "Disable");
		SetNiagaraDisable_Disable_Offset = NativeReflectionCached.GetPropertyOffset(SetNiagaraDisable_FunctionAddress, "Disable");
		SetNiagaraDisable_Disable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNiagaraDisable_FunctionAddress, "Disable", Classes.FBoolProperty);
		SetNiagaraDisable_IsValid = SetNiagaraDisable_FunctionAddress != IntPtr.Zero && SetNiagaraDisable_Disable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetNiagaraDisable", SetNiagaraDisable_IsValid);
		SetClothingAssetSelfCollision_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetClothingAssetSelfCollision");
		SetClothingAssetSelfCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClothingAssetSelfCollision_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClothingAssetSelfCollision_InSkeletalMesh_PropertyAddress, SetClothingAssetSelfCollision_FunctionAddress, "InSkeletalMesh");
		SetClothingAssetSelfCollision_InSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetClothingAssetSelfCollision_FunctionAddress, "InSkeletalMesh");
		SetClothingAssetSelfCollision_InSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClothingAssetSelfCollision_FunctionAddress, "InSkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetClothingAssetSelfCollision_NewSelfCollision_PropertyAddress, SetClothingAssetSelfCollision_FunctionAddress, "NewSelfCollision");
		SetClothingAssetSelfCollision_NewSelfCollision_Offset = NativeReflectionCached.GetPropertyOffset(SetClothingAssetSelfCollision_FunctionAddress, "NewSelfCollision");
		SetClothingAssetSelfCollision_NewSelfCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClothingAssetSelfCollision_FunctionAddress, "NewSelfCollision", Classes.FBoolProperty);
		SetClothingAssetSelfCollision_IsValid = SetClothingAssetSelfCollision_FunctionAddress != IntPtr.Zero && SetClothingAssetSelfCollision_InSkeletalMesh_IsValid && SetClothingAssetSelfCollision_NewSelfCollision_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetClothingAssetSelfCollision", SetClothingAssetSelfCollision_IsValid);
		SetCinematicActorLock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCinematicActorLock");
		SetCinematicActorLock_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCinematicActorLock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCinematicActorLock_Actor_PropertyAddress, SetCinematicActorLock_FunctionAddress, "Actor");
		SetCinematicActorLock_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetCinematicActorLock_FunctionAddress, "Actor");
		SetCinematicActorLock_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCinematicActorLock_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetCinematicActorLock_IsValid = SetCinematicActorLock_FunctionAddress != IntPtr.Zero && SetCinematicActorLock_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetCinematicActorLock", SetCinematicActorLock_IsValid);
		SetActorSelectionState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorSelectionState");
		SetActorSelectionState_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorSelectionState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_Actor_PropertyAddress, SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "Actor");
		SetActorSelectionState_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorSelectionState_bShouldBeSelected_PropertyAddress, SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_Offset = NativeReflectionCached.GetPropertyOffset(SetActorSelectionState_FunctionAddress, "bShouldBeSelected");
		SetActorSelectionState_bShouldBeSelected_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorSelectionState_FunctionAddress, "bShouldBeSelected", Classes.FBoolProperty);
		SetActorSelectionState_IsValid = SetActorSelectionState_FunctionAddress != IntPtr.Zero && SetActorSelectionState_Actor_IsValid && SetActorSelectionState_bShouldBeSelected_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorSelectionState", SetActorSelectionState_IsValid);
		SetActorLock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLock");
		SetActorLock_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLock_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLock_Actor_PropertyAddress, SetActorLock_FunctionAddress, "Actor");
		SetActorLock_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLock_FunctionAddress, "Actor");
		SetActorLock_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLock_FunctionAddress, "Actor", Classes.FObjectProperty);
		SetActorLock_IsValid = SetActorLock_FunctionAddress != IntPtr.Zero && SetActorLock_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLock", SetActorLock_IsValid);
		SetActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLabel");
		SetActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_InActor_PropertyAddress, SetActorLabel_FunctionAddress, "InActor");
		SetActorLabel_InActor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "InActor");
		SetActorLabel_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_InLabel_PropertyAddress, SetActorLabel_FunctionAddress, "InLabel");
		SetActorLabel_InLabel_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "InLabel");
		SetActorLabel_InLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "InLabel", Classes.FStrProperty);
		SetActorLabel_IsValid = SetActorLabel_FunctionAddress != IntPtr.Zero && SetActorLabel_InActor_IsValid && SetActorLabel_InLabel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:SetActorLabel", SetActorLabel_IsValid);
		ResetClothingAssetConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetClothingAssetConfig");
		ResetClothingAssetConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetClothingAssetConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetClothingAssetConfig_InSkeletalMesh_PropertyAddress, ResetClothingAssetConfig_FunctionAddress, "InSkeletalMesh");
		ResetClothingAssetConfig_InSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(ResetClothingAssetConfig_FunctionAddress, "InSkeletalMesh");
		ResetClothingAssetConfig_InSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetClothingAssetConfig_FunctionAddress, "InSkeletalMesh", Classes.FObjectProperty);
		ResetClothingAssetConfig_IsValid = ResetClothingAssetConfig_FunctionAddress != IntPtr.Zero && ResetClothingAssetConfig_InSkeletalMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ResetClothingAssetConfig", ResetClothingAssetConfig_IsValid);
		ReplaceHISMByFoliageType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceHISMByFoliageType");
		ReplaceHISMByFoliageType_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceHISMByFoliageType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceHISMByFoliageType_WorldContext_PropertyAddress, ReplaceHISMByFoliageType_FunctionAddress, "WorldContext");
		ReplaceHISMByFoliageType_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceHISMByFoliageType_FunctionAddress, "WorldContext");
		ReplaceHISMByFoliageType_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceHISMByFoliageType_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceHISMByFoliageType_oldFoliageType_PropertyAddress, ReplaceHISMByFoliageType_FunctionAddress, "oldFoliageType");
		ReplaceHISMByFoliageType_oldFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceHISMByFoliageType_FunctionAddress, "oldFoliageType");
		ReplaceHISMByFoliageType_oldFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceHISMByFoliageType_FunctionAddress, "oldFoliageType", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceHISMByFoliageType_newFoliageType_PropertyAddress, ReplaceHISMByFoliageType_FunctionAddress, "newFoliageType");
		ReplaceHISMByFoliageType_newFoliageType_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceHISMByFoliageType_FunctionAddress, "newFoliageType");
		ReplaceHISMByFoliageType_newFoliageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceHISMByFoliageType_FunctionAddress, "newFoliageType", Classes.FObjectProperty);
		ReplaceHISMByFoliageType_IsValid = ReplaceHISMByFoliageType_FunctionAddress != IntPtr.Zero && ReplaceHISMByFoliageType_WorldContext_IsValid && ReplaceHISMByFoliageType_oldFoliageType_IsValid && ReplaceHISMByFoliageType_newFoliageType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ReplaceHISMByFoliageType", ReplaceHISMByFoliageType_IsValid);
		ReimportAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReimportAssets");
		ReimportAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ReimportAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReimportAssets_ReimportAssets_PropertyAddress, ReimportAssets_FunctionAddress, "ReimportAssets");
		ReimportAssets_ReimportAssets_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAssets_FunctionAddress, "ReimportAssets");
		ReimportAssets_ReimportAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAssets_FunctionAddress, "ReimportAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAssets_bShowNotification_PropertyAddress, ReimportAssets_FunctionAddress, "bShowNotification");
		ReimportAssets_bShowNotification_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAssets_FunctionAddress, "bShowNotification");
		ReimportAssets_bShowNotification_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAssets_FunctionAddress, "bShowNotification", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAssets_SourceFileIndex_PropertyAddress, ReimportAssets_FunctionAddress, "SourceFileIndex");
		ReimportAssets_SourceFileIndex_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAssets_FunctionAddress, "SourceFileIndex");
		ReimportAssets_SourceFileIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAssets_FunctionAddress, "SourceFileIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAssets_bForceNewFile_PropertyAddress, ReimportAssets_FunctionAddress, "bForceNewFile");
		ReimportAssets_bForceNewFile_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAssets_FunctionAddress, "bForceNewFile");
		ReimportAssets_bForceNewFile_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAssets_FunctionAddress, "bForceNewFile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReimportAssets_bAutomated_PropertyAddress, ReimportAssets_FunctionAddress, "bAutomated");
		ReimportAssets_bAutomated_Offset = NativeReflectionCached.GetPropertyOffset(ReimportAssets_FunctionAddress, "bAutomated");
		ReimportAssets_bAutomated_IsValid = NativeReflectionCached.ValidatePropertyClass(ReimportAssets_FunctionAddress, "bAutomated", Classes.FBoolProperty);
		ReimportAssets_IsValid = ReimportAssets_FunctionAddress != IntPtr.Zero && ReimportAssets_ReimportAssets_IsValid && ReimportAssets_bShowNotification_IsValid && ReimportAssets_SourceFileIndex_IsValid && ReimportAssets_bForceNewFile_IsValid && ReimportAssets_bAutomated_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ReimportAssets", ReimportAssets_IsValid);
		RegisterPropertyTypeCustomizationDetails_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RegisterPropertyTypeCustomizationDetails");
		RegisterPropertyTypeCustomizationDetails_ParamsSize = NativeReflection.GetFunctionParamsSize(RegisterPropertyTypeCustomizationDetails_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RegisterPropertyTypeCustomizationDetails_StructName_PropertyAddress, RegisterPropertyTypeCustomizationDetails_FunctionAddress, "StructName");
		RegisterPropertyTypeCustomizationDetails_StructName_Offset = NativeReflectionCached.GetPropertyOffset(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "StructName");
		RegisterPropertyTypeCustomizationDetails_StructName_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "StructName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterPropertyTypeCustomizationDetails_EnumType_PropertyAddress, RegisterPropertyTypeCustomizationDetails_FunctionAddress, "EnumType");
		RegisterPropertyTypeCustomizationDetails_EnumType_Offset = NativeReflectionCached.GetPropertyOffset(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "EnumType");
		RegisterPropertyTypeCustomizationDetails_EnumType_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "EnumType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RegisterPropertyTypeCustomizationDetails_Properties_PropertyAddress, RegisterPropertyTypeCustomizationDetails_FunctionAddress, "Properties");
		RegisterPropertyTypeCustomizationDetails_Properties_Offset = NativeReflectionCached.GetPropertyOffset(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "Properties");
		RegisterPropertyTypeCustomizationDetails_Properties_IsValid = NativeReflectionCached.ValidatePropertyClass(RegisterPropertyTypeCustomizationDetails_FunctionAddress, "Properties", Classes.FArrayProperty);
		RegisterPropertyTypeCustomizationDetails_IsValid = RegisterPropertyTypeCustomizationDetails_FunctionAddress != IntPtr.Zero && RegisterPropertyTypeCustomizationDetails_StructName_IsValid && RegisterPropertyTypeCustomizationDetails_EnumType_IsValid && RegisterPropertyTypeCustomizationDetails_Properties_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:RegisterPropertyTypeCustomizationDetails", RegisterPropertyTypeCustomizationDetails_IsValid);
		PIEStart_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PIEStart");
		PIEStart_ParamsSize = NativeReflection.GetFunctionParamsSize(PIEStart_FunctionAddress);
		PIEStart_IsValid = PIEStart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:PIEStart", PIEStart_IsValid);
		PasteSubobjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PasteSubobjects");
		PasteSubobjects_ParamsSize = NativeReflection.GetFunctionParamsSize(PasteSubobjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PasteSubobjects_PasteToContext_PropertyAddress, PasteSubobjects_FunctionAddress, "PasteToContext");
		PasteSubobjects_PasteToContext_Offset = NativeReflectionCached.GetPropertyOffset(PasteSubobjects_FunctionAddress, "PasteToContext");
		PasteSubobjects_PasteToContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteSubobjects_FunctionAddress, "PasteToContext", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PasteSubobjects_NewParentHandles_PropertyAddress, PasteSubobjects_FunctionAddress, "NewParentHandles");
		PasteSubobjects_NewParentHandles_Offset = NativeReflectionCached.GetPropertyOffset(PasteSubobjects_FunctionAddress, "NewParentHandles");
		PasteSubobjects_NewParentHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteSubobjects_FunctionAddress, "NewParentHandles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PasteSubobjects_BpContext_PropertyAddress, PasteSubobjects_FunctionAddress, "BpContext");
		PasteSubobjects_BpContext_Offset = NativeReflectionCached.GetPropertyOffset(PasteSubobjects_FunctionAddress, "BpContext");
		PasteSubobjects_BpContext_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteSubobjects_FunctionAddress, "BpContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PasteSubobjects_OutPastedHandles_PropertyAddress, PasteSubobjects_FunctionAddress, "OutPastedHandles");
		PasteSubobjects_OutPastedHandles_Offset = NativeReflectionCached.GetPropertyOffset(PasteSubobjects_FunctionAddress, "OutPastedHandles");
		PasteSubobjects_OutPastedHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteSubobjects_FunctionAddress, "OutPastedHandles", Classes.FArrayProperty);
		PasteSubobjects_IsValid = PasteSubobjects_FunctionAddress != IntPtr.Zero && PasteSubobjects_PasteToContext_IsValid && PasteSubobjects_NewParentHandles_IsValid && PasteSubobjects_BpContext_IsValid && PasteSubobjects_OutPastedHandles_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:PasteSubobjects", PasteSubobjects_IsValid);
		OnActorUnlock_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnActorUnlock");
		OnActorUnlock_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorUnlock_FunctionAddress);
		OnActorUnlock_IsValid = OnActorUnlock_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorUnlock", OnActorUnlock_IsValid);
		OnActorLockToggleFromMenu_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OnActorLockToggleFromMenu");
		OnActorLockToggleFromMenu_ParamsSize = NativeReflection.GetFunctionParamsSize(OnActorLockToggleFromMenu_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnActorLockToggleFromMenu_Actor_PropertyAddress, OnActorLockToggleFromMenu_FunctionAddress, "Actor");
		OnActorLockToggleFromMenu_Actor_Offset = NativeReflectionCached.GetPropertyOffset(OnActorLockToggleFromMenu_FunctionAddress, "Actor");
		OnActorLockToggleFromMenu_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(OnActorLockToggleFromMenu_FunctionAddress, "Actor", Classes.FObjectProperty);
		OnActorLockToggleFromMenu_IsValid = OnActorLockToggleFromMenu_FunctionAddress != IntPtr.Zero && OnActorLockToggleFromMenu_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:OnActorLockToggleFromMenu", OnActorLockToggleFromMenu_IsValid);
		ModifyStaticMeshActorGenerateLightMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyStaticMeshActorGenerateLightMap");
		ModifyStaticMeshActorGenerateLightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyStaticMeshActorGenerateLightMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyStaticMeshActorGenerateLightMap_enable_PropertyAddress, ModifyStaticMeshActorGenerateLightMap_FunctionAddress, "enable");
		ModifyStaticMeshActorGenerateLightMap_enable_Offset = NativeReflectionCached.GetPropertyOffset(ModifyStaticMeshActorGenerateLightMap_FunctionAddress, "enable");
		ModifyStaticMeshActorGenerateLightMap_enable_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyStaticMeshActorGenerateLightMap_FunctionAddress, "enable", Classes.FBoolProperty);
		ModifyStaticMeshActorGenerateLightMap_IsValid = ModifyStaticMeshActorGenerateLightMap_FunctionAddress != IntPtr.Zero && ModifyStaticMeshActorGenerateLightMap_enable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ModifyStaticMeshActorGenerateLightMap", ModifyStaticMeshActorGenerateLightMap_IsValid);
		MergeShaderCodeFiles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MergeShaderCodeFiles");
		MergeShaderCodeFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(MergeShaderCodeFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MergeShaderCodeFiles_OldDir_PropertyAddress, MergeShaderCodeFiles_FunctionAddress, "OldDir");
		MergeShaderCodeFiles_OldDir_Offset = NativeReflectionCached.GetPropertyOffset(MergeShaderCodeFiles_FunctionAddress, "OldDir");
		MergeShaderCodeFiles_OldDir_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeShaderCodeFiles_FunctionAddress, "OldDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeShaderCodeFiles_NewDir_PropertyAddress, MergeShaderCodeFiles_FunctionAddress, "NewDir");
		MergeShaderCodeFiles_NewDir_Offset = NativeReflectionCached.GetPropertyOffset(MergeShaderCodeFiles_FunctionAddress, "NewDir");
		MergeShaderCodeFiles_NewDir_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeShaderCodeFiles_FunctionAddress, "NewDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeShaderCodeFiles_OutputDir_PropertyAddress, MergeShaderCodeFiles_FunctionAddress, "OutputDir");
		MergeShaderCodeFiles_OutputDir_Offset = NativeReflectionCached.GetPropertyOffset(MergeShaderCodeFiles_FunctionAddress, "OutputDir");
		MergeShaderCodeFiles_OutputDir_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeShaderCodeFiles_FunctionAddress, "OutputDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MergeShaderCodeFiles_ReturnValue_PropertyAddress, MergeShaderCodeFiles_FunctionAddress, "ReturnValue");
		MergeShaderCodeFiles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MergeShaderCodeFiles_FunctionAddress, "ReturnValue");
		MergeShaderCodeFiles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MergeShaderCodeFiles_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MergeShaderCodeFiles_IsValid = MergeShaderCodeFiles_FunctionAddress != IntPtr.Zero && MergeShaderCodeFiles_OldDir_IsValid && MergeShaderCodeFiles_NewDir_IsValid && MergeShaderCodeFiles_OutputDir_IsValid && MergeShaderCodeFiles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:MergeShaderCodeFiles", MergeShaderCodeFiles_IsValid);
		LoadObjectsFromAssetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadObjectsFromAssetData");
		LoadObjectsFromAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadObjectsFromAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadObjectsFromAssetData_Assets_PropertyAddress, LoadObjectsFromAssetData_FunctionAddress, "Assets");
		LoadObjectsFromAssetData_Assets_Offset = NativeReflectionCached.GetPropertyOffset(LoadObjectsFromAssetData_FunctionAddress, "Assets");
		LoadObjectsFromAssetData_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadObjectsFromAssetData_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadObjectsFromAssetData_ReturnValue_PropertyAddress, LoadObjectsFromAssetData_FunctionAddress, "ReturnValue");
		LoadObjectsFromAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadObjectsFromAssetData_FunctionAddress, "ReturnValue");
		LoadObjectsFromAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadObjectsFromAssetData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		LoadObjectsFromAssetData_IsValid = LoadObjectsFromAssetData_FunctionAddress != IntPtr.Zero && LoadObjectsFromAssetData_Assets_IsValid && LoadObjectsFromAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:LoadObjectsFromAssetData", LoadObjectsFromAssetData_IsValid);
		IsPlayInPreview_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlayInPreview");
		IsPlayInPreview_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayInPreview_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayInPreview_World_PropertyAddress, IsPlayInPreview_FunctionAddress, "World");
		IsPlayInPreview_World_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayInPreview_FunctionAddress, "World");
		IsPlayInPreview_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayInPreview_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlayInPreview_ReturnValue_PropertyAddress, IsPlayInPreview_FunctionAddress, "ReturnValue");
		IsPlayInPreview_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayInPreview_FunctionAddress, "ReturnValue");
		IsPlayInPreview_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayInPreview_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayInPreview_IsValid = IsPlayInPreview_FunctionAddress != IntPtr.Zero && IsPlayInPreview_World_IsValid && IsPlayInPreview_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInPreview", IsPlayInPreview_IsValid);
		IsPlayInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPlayInEditor");
		IsPlayInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPlayInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPlayInEditor_World_PropertyAddress, IsPlayInEditor_FunctionAddress, "World");
		IsPlayInEditor_World_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayInEditor_FunctionAddress, "World");
		IsPlayInEditor_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayInEditor_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPlayInEditor_ReturnValue_PropertyAddress, IsPlayInEditor_FunctionAddress, "ReturnValue");
		IsPlayInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPlayInEditor_FunctionAddress, "ReturnValue");
		IsPlayInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPlayInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPlayInEditor_IsValid = IsPlayInEditor_FunctionAddress != IntPtr.Zero && IsPlayInEditor_World_IsValid && IsPlayInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:IsPlayInEditor", IsPlayInEditor_IsValid);
		IsPackageExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPackageExist");
		IsPackageExist_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPackageExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPackageExist_PathName_PropertyAddress, IsPackageExist_FunctionAddress, "PathName");
		IsPackageExist_PathName_Offset = NativeReflectionCached.GetPropertyOffset(IsPackageExist_FunctionAddress, "PathName");
		IsPackageExist_PathName_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPackageExist_FunctionAddress, "PathName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsPackageExist_ReturnValue_PropertyAddress, IsPackageExist_FunctionAddress, "ReturnValue");
		IsPackageExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPackageExist_FunctionAddress, "ReturnValue");
		IsPackageExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPackageExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPackageExist_IsValid = IsPackageExist_FunctionAddress != IntPtr.Zero && IsPackageExist_PathName_IsValid && IsPackageExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:IsPackageExist", IsPackageExist_IsValid);
		IsGameWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsGameWorld");
		IsGameWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGameWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGameWorld_World_PropertyAddress, IsGameWorld_FunctionAddress, "World");
		IsGameWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(IsGameWorld_FunctionAddress, "World");
		IsGameWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGameWorld_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsGameWorld_ReturnValue_PropertyAddress, IsGameWorld_FunctionAddress, "ReturnValue");
		IsGameWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGameWorld_FunctionAddress, "ReturnValue");
		IsGameWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGameWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGameWorld_IsValid = IsGameWorld_FunctionAddress != IntPtr.Zero && IsGameWorld_World_IsValid && IsGameWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:IsGameWorld", IsGameWorld_IsValid);
		IsEditorWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsEditorWorld");
		IsEditorWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditorWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsEditorWorld_World_PropertyAddress, IsEditorWorld_FunctionAddress, "World");
		IsEditorWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(IsEditorWorld_FunctionAddress, "World");
		IsEditorWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditorWorld_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEditorWorld_ReturnValue_PropertyAddress, IsEditorWorld_FunctionAddress, "ReturnValue");
		IsEditorWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsEditorWorld_FunctionAddress, "ReturnValue");
		IsEditorWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsEditorWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditorWorld_IsValid = IsEditorWorld_FunctionAddress != IntPtr.Zero && IsEditorWorld_World_IsValid && IsEditorWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:IsEditorWorld", IsEditorWorld_IsValid);
		ImportAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportAssets");
		ImportAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportAssets_FilePaths_PropertyAddress, ImportAssets_FunctionAddress, "FilePaths");
		ImportAssets_FilePaths_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssets_FunctionAddress, "FilePaths");
		ImportAssets_FilePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssets_FunctionAddress, "FilePaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAssets_DestinationPath_PropertyAddress, ImportAssets_FunctionAddress, "DestinationPath");
		ImportAssets_DestinationPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssets_FunctionAddress, "DestinationPath");
		ImportAssets_DestinationPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssets_FunctionAddress, "DestinationPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAssets_ReturnValue_PropertyAddress, ImportAssets_FunctionAddress, "ReturnValue");
		ImportAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssets_FunctionAddress, "ReturnValue");
		ImportAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportAssets_IsValid = ImportAssets_FunctionAddress != IntPtr.Zero && ImportAssets_FilePaths_IsValid && ImportAssets_DestinationPath_IsValid && ImportAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ImportAssets", ImportAssets_IsValid);
		GSToggleFixMapPIEMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSToggleFixMapPIEMode");
		GSToggleFixMapPIEMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GSToggleFixMapPIEMode_FunctionAddress);
		GSToggleFixMapPIEMode_IsValid = GSToggleFixMapPIEMode_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleFixMapPIEMode", GSToggleFixMapPIEMode_IsValid);
		GSToggleEditorMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSToggleEditorMode");
		GSToggleEditorMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GSToggleEditorMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSToggleEditorMode_InEdName_PropertyAddress, GSToggleEditorMode_FunctionAddress, "InEdName");
		GSToggleEditorMode_InEdName_Offset = NativeReflectionCached.GetPropertyOffset(GSToggleEditorMode_FunctionAddress, "InEdName");
		GSToggleEditorMode_InEdName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSToggleEditorMode_FunctionAddress, "InEdName", Classes.FNameProperty);
		GSToggleEditorMode_IsValid = GSToggleEditorMode_FunctionAddress != IntPtr.Zero && GSToggleEditorMode_InEdName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GSToggleEditorMode", GSToggleEditorMode_IsValid);
		GSGenerateLODLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSGenerateLODLevels");
		GSGenerateLODLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GSGenerateLODLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSGenerateLODLevels_LevelName_PropertyAddress, GSGenerateLODLevels_FunctionAddress, "LevelName");
		GSGenerateLODLevels_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GSGenerateLODLevels_FunctionAddress, "LevelName");
		GSGenerateLODLevels_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSGenerateLODLevels_FunctionAddress, "LevelName", Classes.FStrProperty);
		GSGenerateLODLevels_IsValid = GSGenerateLODLevels_FunctionAddress != IntPtr.Zero && GSGenerateLODLevels_LevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevels", GSGenerateLODLevels_IsValid);
		GSGenerateLODLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSGenerateLODLevel");
		GSGenerateLODLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GSGenerateLODLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSGenerateLODLevel_LevelName_PropertyAddress, GSGenerateLODLevel_FunctionAddress, "LevelName");
		GSGenerateLODLevel_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GSGenerateLODLevel_FunctionAddress, "LevelName");
		GSGenerateLODLevel_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GSGenerateLODLevel_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSGenerateLODLevel_TargetLODIndex_PropertyAddress, GSGenerateLODLevel_FunctionAddress, "TargetLODIndex");
		GSGenerateLODLevel_TargetLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(GSGenerateLODLevel_FunctionAddress, "TargetLODIndex");
		GSGenerateLODLevel_TargetLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GSGenerateLODLevel_FunctionAddress, "TargetLODIndex", Classes.FIntProperty);
		GSGenerateLODLevel_IsValid = GSGenerateLODLevel_FunctionAddress != IntPtr.Zero && GSGenerateLODLevel_LevelName_IsValid && GSGenerateLODLevel_TargetLODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GSGenerateLODLevel", GSGenerateLODLevel_IsValid);
		GetTagNameBySocketName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTagNameBySocketName");
		GetTagNameBySocketName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagNameBySocketName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagNameBySocketName_StaticMesh_PropertyAddress, GetTagNameBySocketName_FunctionAddress, "StaticMesh");
		GetTagNameBySocketName_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetTagNameBySocketName_FunctionAddress, "StaticMesh");
		GetTagNameBySocketName_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagNameBySocketName_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagNameBySocketName_SocketName_PropertyAddress, GetTagNameBySocketName_FunctionAddress, "SocketName");
		GetTagNameBySocketName_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetTagNameBySocketName_FunctionAddress, "SocketName");
		GetTagNameBySocketName_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagNameBySocketName_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagNameBySocketName_ReturnValue_PropertyAddress, GetTagNameBySocketName_FunctionAddress, "ReturnValue");
		GetTagNameBySocketName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagNameBySocketName_FunctionAddress, "ReturnValue");
		GetTagNameBySocketName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagNameBySocketName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetTagNameBySocketName_IsValid = GetTagNameBySocketName_FunctionAddress != IntPtr.Zero && GetTagNameBySocketName_StaticMesh_IsValid && GetTagNameBySocketName_SocketName_IsValid && GetTagNameBySocketName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetTagNameBySocketName", GetTagNameBySocketName_IsValid);
		GetStaticMeshEditorSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStaticMeshEditorSubsystem");
		GetStaticMeshEditorSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStaticMeshEditorSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStaticMeshEditorSubsystem_ReturnValue_PropertyAddress, GetStaticMeshEditorSubsystem_FunctionAddress, "ReturnValue");
		GetStaticMeshEditorSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStaticMeshEditorSubsystem_FunctionAddress, "ReturnValue");
		GetStaticMeshEditorSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStaticMeshEditorSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetStaticMeshEditorSubsystem_IsValid = GetStaticMeshEditorSubsystem_FunctionAddress != IntPtr.Zero && GetStaticMeshEditorSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetStaticMeshEditorSubsystem", GetStaticMeshEditorSubsystem_IsValid);
		GetSelectedFolders_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedFolders");
		GetSelectedFolders_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedFolders_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedFolders_ReturnValue_PropertyAddress, GetSelectedFolders_FunctionAddress, "ReturnValue");
		GetSelectedFolders_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedFolders_FunctionAddress, "ReturnValue");
		GetSelectedFolders_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedFolders_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedFolders_IsValid = GetSelectedFolders_FunctionAddress != IntPtr.Zero && GetSelectedFolders_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedFolders", GetSelectedFolders_IsValid);
		GetSelectedAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedAssets");
		GetSelectedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedAssets_ReturnValue_PropertyAddress, GetSelectedAssets_FunctionAddress, "ReturnValue");
		GetSelectedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedAssets_FunctionAddress, "ReturnValue");
		GetSelectedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedAssets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSelectedAssets_IsValid = GetSelectedAssets_FunctionAddress != IntPtr.Zero && GetSelectedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetSelectedAssets", GetSelectedAssets_IsValid);
		GetReferenceAssetsFromObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferenceAssetsFromObjects");
		GetReferenceAssetsFromObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferenceAssetsFromObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress, GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets");
		GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets");
		GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress, GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReferenceAssetsFromObjects_IsValid = GetReferenceAssetsFromObjects_FunctionAddress != IntPtr.Zero && GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid && GetReferenceAssetsFromObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromObjects", GetReferenceAssetsFromObjects_IsValid);
		GetReferenceAssetsFromAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferenceAssetsFromAssets");
		GetReferenceAssetsFromAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferenceAssetsFromAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromAssets_Assets_PropertyAddress, GetReferenceAssetsFromAssets_FunctionAddress, "Assets");
		GetReferenceAssetsFromAssets_Assets_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromAssets_FunctionAddress, "Assets");
		GetReferenceAssetsFromAssets_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromAssets_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress, GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReferenceAssetsFromAssets_IsValid = GetReferenceAssetsFromAssets_FunctionAddress != IntPtr.Zero && GetReferenceAssetsFromAssets_Assets_IsValid && GetReferenceAssetsFromAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetReferenceAssetsFromAssets", GetReferenceAssetsFromAssets_IsValid);
		GetPreviewStaticMeshBySocketName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviewStaticMeshBySocketName");
		GetPreviewStaticMeshBySocketName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewStaticMeshBySocketName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewStaticMeshBySocketName_StaticMesh_PropertyAddress, GetPreviewStaticMeshBySocketName_FunctionAddress, "StaticMesh");
		GetPreviewStaticMeshBySocketName_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewStaticMeshBySocketName_FunctionAddress, "StaticMesh");
		GetPreviewStaticMeshBySocketName_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewStaticMeshBySocketName_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewStaticMeshBySocketName_SocketName_PropertyAddress, GetPreviewStaticMeshBySocketName_FunctionAddress, "SocketName");
		GetPreviewStaticMeshBySocketName_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewStaticMeshBySocketName_FunctionAddress, "SocketName");
		GetPreviewStaticMeshBySocketName_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewStaticMeshBySocketName_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewStaticMeshBySocketName_ReturnValue_PropertyAddress, GetPreviewStaticMeshBySocketName_FunctionAddress, "ReturnValue");
		GetPreviewStaticMeshBySocketName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewStaticMeshBySocketName_FunctionAddress, "ReturnValue");
		GetPreviewStaticMeshBySocketName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewStaticMeshBySocketName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewStaticMeshBySocketName_IsValid = GetPreviewStaticMeshBySocketName_FunctionAddress != IntPtr.Zero && GetPreviewStaticMeshBySocketName_StaticMesh_IsValid && GetPreviewStaticMeshBySocketName_SocketName_IsValid && GetPreviewStaticMeshBySocketName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetPreviewStaticMeshBySocketName", GetPreviewStaticMeshBySocketName_IsValid);
		GetLevelFoliageInstanceBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelFoliageInstanceBounds");
		GetLevelFoliageInstanceBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelFoliageInstanceBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceBounds_Level_PropertyAddress, GetLevelFoliageInstanceBounds_FunctionAddress, "Level");
		GetLevelFoliageInstanceBounds_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceBounds_FunctionAddress, "Level");
		GetLevelFoliageInstanceBounds_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceBounds_FunctionAddress, "Level", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelFoliageInstanceBounds_ReturnValue_PropertyAddress, GetLevelFoliageInstanceBounds_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelFoliageInstanceBounds_FunctionAddress, "ReturnValue");
		GetLevelFoliageInstanceBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelFoliageInstanceBounds_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetLevelFoliageInstanceBounds_IsValid = GetLevelFoliageInstanceBounds_FunctionAddress != IntPtr.Zero && GetLevelFoliageInstanceBounds_Level_IsValid && GetLevelFoliageInstanceBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetLevelFoliageInstanceBounds", GetLevelFoliageInstanceBounds_IsValid);
		GetFactoryForAssetObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFactoryForAssetObject");
		GetFactoryForAssetObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFactoryForAssetObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryForAssetObject_AssetObject_PropertyAddress, GetFactoryForAssetObject_FunctionAddress, "AssetObject");
		GetFactoryForAssetObject_AssetObject_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryForAssetObject_FunctionAddress, "AssetObject");
		GetFactoryForAssetObject_AssetObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryForAssetObject_FunctionAddress, "AssetObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFactoryForAssetObject_ReturnValue_PropertyAddress, GetFactoryForAssetObject_FunctionAddress, "ReturnValue");
		GetFactoryForAssetObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFactoryForAssetObject_FunctionAddress, "ReturnValue");
		GetFactoryForAssetObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFactoryForAssetObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFactoryForAssetObject_IsValid = GetFactoryForAssetObject_FunctionAddress != IntPtr.Zero && GetFactoryForAssetObject_AssetObject_IsValid && GetFactoryForAssetObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetFactoryForAssetObject", GetFactoryForAssetObject_IsValid);
		GetEditorWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorWorld");
		GetEditorWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorWorld_ReturnValue_PropertyAddress, GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEditorWorld_IsValid = GetEditorWorld_FunctionAddress != IntPtr.Zero && GetEditorWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorWorld", GetEditorWorld_IsValid);
		GetEditorActorSubsystem_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorActorSubsystem");
		GetEditorActorSubsystem_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorActorSubsystem_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorActorSubsystem_ReturnValue_PropertyAddress, GetEditorActorSubsystem_FunctionAddress, "ReturnValue");
		GetEditorActorSubsystem_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorActorSubsystem_FunctionAddress, "ReturnValue");
		GetEditorActorSubsystem_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorActorSubsystem_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEditorActorSubsystem_IsValid = GetEditorActorSubsystem_FunctionAddress != IntPtr.Zero && GetEditorActorSubsystem_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetEditorActorSubsystem", GetEditorActorSubsystem_IsValid);
		GetCDONodeComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCDONodeComponents");
		GetCDONodeComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCDONodeComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCDONodeComponents_CDO_PropertyAddress, GetCDONodeComponents_FunctionAddress, "CDO");
		GetCDONodeComponents_CDO_Offset = NativeReflectionCached.GetPropertyOffset(GetCDONodeComponents_FunctionAddress, "CDO");
		GetCDONodeComponents_CDO_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDONodeComponents_FunctionAddress, "CDO", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDONodeComponents_ReturnValue_PropertyAddress, GetCDONodeComponents_FunctionAddress, "ReturnValue");
		GetCDONodeComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCDONodeComponents_FunctionAddress, "ReturnValue");
		GetCDONodeComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDONodeComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCDONodeComponents_IsValid = GetCDONodeComponents_FunctionAddress != IntPtr.Zero && GetCDONodeComponents_CDO_IsValid && GetCDONodeComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDONodeComponents", GetCDONodeComponents_IsValid);
		GetCDOComponentByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCDOComponentByName");
		GetCDOComponentByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCDOComponentByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCDOComponentByName_BP_PropertyAddress, GetCDOComponentByName_FunctionAddress, "BP");
		GetCDOComponentByName_BP_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOComponentByName_FunctionAddress, "BP");
		GetCDOComponentByName_BP_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOComponentByName_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDOComponentByName_CompName_PropertyAddress, GetCDOComponentByName_FunctionAddress, "CompName");
		GetCDOComponentByName_CompName_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOComponentByName_FunctionAddress, "CompName");
		GetCDOComponentByName_CompName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOComponentByName_FunctionAddress, "CompName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDOComponentByName_bCreateInheritable_PropertyAddress, GetCDOComponentByName_FunctionAddress, "bCreateInheritable");
		GetCDOComponentByName_bCreateInheritable_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOComponentByName_FunctionAddress, "bCreateInheritable");
		GetCDOComponentByName_bCreateInheritable_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOComponentByName_FunctionAddress, "bCreateInheritable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDOComponentByName_ReturnValue_PropertyAddress, GetCDOComponentByName_FunctionAddress, "ReturnValue");
		GetCDOComponentByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCDOComponentByName_FunctionAddress, "ReturnValue");
		GetCDOComponentByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDOComponentByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCDOComponentByName_IsValid = GetCDOComponentByName_FunctionAddress != IntPtr.Zero && GetCDOComponentByName_BP_IsValid && GetCDOComponentByName_CompName_IsValid && GetCDOComponentByName_bCreateInheritable_IsValid && GetCDOComponentByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetCDOComponentByName", GetCDOComponentByName_IsValid);
		GetBlueprintCDOComponentByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlueprintCDOComponentByName");
		GetBlueprintCDOComponentByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlueprintCDOComponentByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintCDOComponentByName_BP_PropertyAddress, GetBlueprintCDOComponentByName_FunctionAddress, "BP");
		GetBlueprintCDOComponentByName_BP_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintCDOComponentByName_FunctionAddress, "BP");
		GetBlueprintCDOComponentByName_BP_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintCDOComponentByName_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintCDOComponentByName_CompName_PropertyAddress, GetBlueprintCDOComponentByName_FunctionAddress, "CompName");
		GetBlueprintCDOComponentByName_CompName_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintCDOComponentByName_FunctionAddress, "CompName");
		GetBlueprintCDOComponentByName_CompName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintCDOComponentByName_FunctionAddress, "CompName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintCDOComponentByName_ReturnValue_PropertyAddress, GetBlueprintCDOComponentByName_FunctionAddress, "ReturnValue");
		GetBlueprintCDOComponentByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintCDOComponentByName_FunctionAddress, "ReturnValue");
		GetBlueprintCDOComponentByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintCDOComponentByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetBlueprintCDOComponentByName_IsValid = GetBlueprintCDOComponentByName_FunctionAddress != IntPtr.Zero && GetBlueprintCDOComponentByName_BP_IsValid && GetBlueprintCDOComponentByName_CompName_IsValid && GetBlueprintCDOComponentByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetBlueprintCDOComponentByName", GetBlueprintCDOComponentByName_IsValid);
		GetAssetsInFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsInFolder");
		GetAssetsInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsInFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_FolderPath_PropertyAddress, GetAssetsInFolder_FunctionAddress, "FolderPath");
		GetAssetsInFolder_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "FolderPath");
		GetAssetsInFolder_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "FolderPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_bRecursive_PropertyAddress, GetAssetsInFolder_FunctionAddress, "bRecursive");
		GetAssetsInFolder_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "bRecursive");
		GetAssetsInFolder_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_ReturnValue_PropertyAddress, GetAssetsInFolder_FunctionAddress, "ReturnValue");
		GetAssetsInFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "ReturnValue");
		GetAssetsInFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetsInFolder_IsValid = GetAssetsInFolder_FunctionAddress != IntPtr.Zero && GetAssetsInFolder_FolderPath_IsValid && GetAssetsInFolder_bRecursive_IsValid && GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid && GetAssetsInFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetsInFolder", GetAssetsInFolder_IsValid);
		GetAssetDataFromPackageObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataFromPackageObj");
		GetAssetDataFromPackageObj_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataFromPackageObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackageObj_PackageObjects_PropertyAddress, GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects");
		GetAssetDataFromPackageObj_PackageObjects_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects");
		GetAssetDataFromPackageObj_PackageObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackageObj_ReturnValue_PropertyAddress, GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackageObj_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackageObj_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetDataFromPackageObj_IsValid = GetAssetDataFromPackageObj_FunctionAddress != IntPtr.Zero && GetAssetDataFromPackageObj_PackageObjects_IsValid && GetAssetDataFromPackageObj_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetAssetDataFromPackageObj", GetAssetDataFromPackageObj_IsValid);
		GetAllComponentTemplateInBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllComponentTemplateInBlueprint");
		GetAllComponentTemplateInBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllComponentTemplateInBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllComponentTemplateInBlueprint_Blueprint_PropertyAddress, GetAllComponentTemplateInBlueprint_FunctionAddress, "Blueprint");
		GetAllComponentTemplateInBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetAllComponentTemplateInBlueprint_FunctionAddress, "Blueprint");
		GetAllComponentTemplateInBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllComponentTemplateInBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllComponentTemplateInBlueprint_ReturnValue_PropertyAddress, GetAllComponentTemplateInBlueprint_FunctionAddress, "ReturnValue");
		GetAllComponentTemplateInBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllComponentTemplateInBlueprint_FunctionAddress, "ReturnValue");
		GetAllComponentTemplateInBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllComponentTemplateInBlueprint_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllComponentTemplateInBlueprint_IsValid = GetAllComponentTemplateInBlueprint_FunctionAddress != IntPtr.Zero && GetAllComponentTemplateInBlueprint_Blueprint_IsValid && GetAllComponentTemplateInBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetAllComponentTemplateInBlueprint", GetAllComponentTemplateInBlueprint_IsValid);
		GetActorPlacementLocationOnCursor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorPlacementLocationOnCursor");
		GetActorPlacementLocationOnCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorPlacementLocationOnCursor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorPlacementLocationOnCursor_Actor_PropertyAddress, GetActorPlacementLocationOnCursor_FunctionAddress, "Actor");
		GetActorPlacementLocationOnCursor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorPlacementLocationOnCursor_FunctionAddress, "Actor");
		GetActorPlacementLocationOnCursor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorPlacementLocationOnCursor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorPlacementLocationOnCursor_ReturnValue_PropertyAddress, GetActorPlacementLocationOnCursor_FunctionAddress, "ReturnValue");
		GetActorPlacementLocationOnCursor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorPlacementLocationOnCursor_FunctionAddress, "ReturnValue");
		GetActorPlacementLocationOnCursor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorPlacementLocationOnCursor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorPlacementLocationOnCursor_IsValid = GetActorPlacementLocationOnCursor_FunctionAddress != IntPtr.Zero && GetActorPlacementLocationOnCursor_Actor_IsValid && GetActorPlacementLocationOnCursor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GetActorPlacementLocationOnCursor", GetActorPlacementLocationOnCursor_IsValid);
		GEditor_ValidateSceneRootNodes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_ValidateSceneRootNodes");
		GEditor_ValidateSceneRootNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_ValidateSceneRootNodes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_ValidateSceneRootNodes_BlueprintObj_PropertyAddress, GEditor_ValidateSceneRootNodes_FunctionAddress, "BlueprintObj");
		GEditor_ValidateSceneRootNodes_BlueprintObj_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_ValidateSceneRootNodes_FunctionAddress, "BlueprintObj");
		GEditor_ValidateSceneRootNodes_BlueprintObj_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_ValidateSceneRootNodes_FunctionAddress, "BlueprintObj", Classes.FObjectProperty);
		GEditor_ValidateSceneRootNodes_IsValid = GEditor_ValidateSceneRootNodes_FunctionAddress != IntPtr.Zero && GEditor_ValidateSceneRootNodes_BlueprintObj_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_ValidateSceneRootNodes", GEditor_ValidateSceneRootNodes_IsValid);
		GEditor_UseActorFactory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_UseActorFactory");
		GEditor_UseActorFactory_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_UseActorFactory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_UseActorFactory_ActorFactory_PropertyAddress, GEditor_UseActorFactory_FunctionAddress, "ActorFactory");
		GEditor_UseActorFactory_ActorFactory_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_UseActorFactory_FunctionAddress, "ActorFactory");
		GEditor_UseActorFactory_ActorFactory_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_UseActorFactory_FunctionAddress, "ActorFactory", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_UseActorFactory_AssetData_PropertyAddress, GEditor_UseActorFactory_FunctionAddress, "AssetData");
		GEditor_UseActorFactory_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_UseActorFactory_FunctionAddress, "AssetData");
		GEditor_UseActorFactory_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_UseActorFactory_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_UseActorFactory_Transform_PropertyAddress, GEditor_UseActorFactory_FunctionAddress, "Transform");
		GEditor_UseActorFactory_Transform_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_UseActorFactory_FunctionAddress, "Transform");
		GEditor_UseActorFactory_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_UseActorFactory_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_UseActorFactory_ReturnValue_PropertyAddress, GEditor_UseActorFactory_FunctionAddress, "ReturnValue");
		GEditor_UseActorFactory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_UseActorFactory_FunctionAddress, "ReturnValue");
		GEditor_UseActorFactory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_UseActorFactory_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_UseActorFactory_IsValid = GEditor_UseActorFactory_FunctionAddress != IntPtr.Zero && GEditor_UseActorFactory_ActorFactory_IsValid && GEditor_UseActorFactory_AssetData_IsValid && GEditor_UseActorFactory_Transform_IsValid && GEditor_UseActorFactory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_UseActorFactory", GEditor_UseActorFactory_IsValid);
		GEditor_StaticMeshUnregisterComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_StaticMeshUnregisterComponent");
		GEditor_StaticMeshUnregisterComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_StaticMeshUnregisterComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_StaticMeshUnregisterComponent_StaticMesh_PropertyAddress, GEditor_StaticMeshUnregisterComponent_FunctionAddress, "StaticMesh");
		GEditor_StaticMeshUnregisterComponent_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_StaticMeshUnregisterComponent_FunctionAddress, "StaticMesh");
		GEditor_StaticMeshUnregisterComponent_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_StaticMeshUnregisterComponent_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		GEditor_StaticMeshUnregisterComponent_IsValid = GEditor_StaticMeshUnregisterComponent_FunctionAddress != IntPtr.Zero && GEditor_StaticMeshUnregisterComponent_StaticMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshUnregisterComponent", GEditor_StaticMeshUnregisterComponent_IsValid);
		GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_StaticMeshRegisterComponentWithWorld");
		GEditor_StaticMeshRegisterComponentWithWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_PropertyAddress, GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "StaticMesh");
		GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "StaticMesh");
		GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_StaticMeshRegisterComponentWithWorld_InWorld_PropertyAddress, GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "InWorld");
		GEditor_StaticMeshRegisterComponentWithWorld_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "InWorld");
		GEditor_StaticMeshRegisterComponentWithWorld_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress, "InWorld", Classes.FObjectProperty);
		GEditor_StaticMeshRegisterComponentWithWorld_IsValid = GEditor_StaticMeshRegisterComponentWithWorld_FunctionAddress != IntPtr.Zero && GEditor_StaticMeshRegisterComponentWithWorld_StaticMesh_IsValid && GEditor_StaticMeshRegisterComponentWithWorld_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_StaticMeshRegisterComponentWithWorld", GEditor_StaticMeshRegisterComponentWithWorld_IsValid);
		GEditor_SpawnActorAbsolute_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_SpawnActorAbsolute");
		GEditor_SpawnActorAbsolute_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_SpawnActorAbsolute_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SpawnActorAbsolute_EditotWorld_PropertyAddress, GEditor_SpawnActorAbsolute_FunctionAddress, "EditotWorld");
		GEditor_SpawnActorAbsolute_EditotWorld_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SpawnActorAbsolute_FunctionAddress, "EditotWorld");
		GEditor_SpawnActorAbsolute_EditotWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SpawnActorAbsolute_FunctionAddress, "EditotWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SpawnActorAbsolute_Class_PropertyAddress, GEditor_SpawnActorAbsolute_FunctionAddress, "Class");
		GEditor_SpawnActorAbsolute_Class_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SpawnActorAbsolute_FunctionAddress, "Class");
		GEditor_SpawnActorAbsolute_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SpawnActorAbsolute_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SpawnActorAbsolute_Transform_PropertyAddress, GEditor_SpawnActorAbsolute_FunctionAddress, "Transform");
		GEditor_SpawnActorAbsolute_Transform_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SpawnActorAbsolute_FunctionAddress, "Transform");
		GEditor_SpawnActorAbsolute_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SpawnActorAbsolute_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SpawnActorAbsolute_ReturnValue_PropertyAddress, GEditor_SpawnActorAbsolute_FunctionAddress, "ReturnValue");
		GEditor_SpawnActorAbsolute_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SpawnActorAbsolute_FunctionAddress, "ReturnValue");
		GEditor_SpawnActorAbsolute_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SpawnActorAbsolute_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_SpawnActorAbsolute_IsValid = GEditor_SpawnActorAbsolute_FunctionAddress != IntPtr.Zero && GEditor_SpawnActorAbsolute_EditotWorld_IsValid && GEditor_SpawnActorAbsolute_Class_IsValid && GEditor_SpawnActorAbsolute_Transform_IsValid && GEditor_SpawnActorAbsolute_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SpawnActorAbsolute", GEditor_SpawnActorAbsolute_IsValid);
		GEditor_SnapRotatorToGrid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_SnapRotatorToGrid");
		GEditor_SnapRotatorToGrid_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_SnapRotatorToGrid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SnapRotatorToGrid_RotationToSnapped_PropertyAddress, GEditor_SnapRotatorToGrid_FunctionAddress, "RotationToSnapped");
		GEditor_SnapRotatorToGrid_RotationToSnapped_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SnapRotatorToGrid_FunctionAddress, "RotationToSnapped");
		GEditor_SnapRotatorToGrid_RotationToSnapped_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SnapRotatorToGrid_FunctionAddress, "RotationToSnapped", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SnapRotatorToGrid_ReturnValue_PropertyAddress, GEditor_SnapRotatorToGrid_FunctionAddress, "ReturnValue");
		GEditor_SnapRotatorToGrid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SnapRotatorToGrid_FunctionAddress, "ReturnValue");
		GEditor_SnapRotatorToGrid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SnapRotatorToGrid_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GEditor_SnapRotatorToGrid_IsValid = GEditor_SnapRotatorToGrid_FunctionAddress != IntPtr.Zero && GEditor_SnapRotatorToGrid_RotationToSnapped_IsValid && GEditor_SnapRotatorToGrid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SnapRotatorToGrid", GEditor_SnapRotatorToGrid_IsValid);
		GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_SetGAllowActorScriptExecutionInEditor");
		GEditor_SetGAllowActorScriptExecutionInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_SetGAllowActorScriptExecutionInEditor_bVal_PropertyAddress, GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress, "bVal");
		GEditor_SetGAllowActorScriptExecutionInEditor_bVal_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress, "bVal");
		GEditor_SetGAllowActorScriptExecutionInEditor_bVal_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress, "bVal", Classes.FBoolProperty);
		GEditor_SetGAllowActorScriptExecutionInEditor_IsValid = GEditor_SetGAllowActorScriptExecutionInEditor_FunctionAddress != IntPtr.Zero && GEditor_SetGAllowActorScriptExecutionInEditor_bVal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_SetGAllowActorScriptExecutionInEditor", GEditor_SetGAllowActorScriptExecutionInEditor_IsValid);
		GEditor_RecalculateMouseRayHitTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_RecalculateMouseRayHitTransform");
		GEditor_RecalculateMouseRayHitTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_RecalculateMouseRayHitTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_JSViewport_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "JSViewport");
		GEditor_RecalculateMouseRayHitTransform_JSViewport_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "JSViewport");
		GEditor_RecalculateMouseRayHitTransform_JSViewport_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "JSViewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_UseUpRot_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "UseUpRot");
		GEditor_RecalculateMouseRayHitTransform_UseUpRot_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "UseUpRot");
		GEditor_RecalculateMouseRayHitTransform_UseUpRot_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "UseUpRot", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "SpawnWorldTransform");
		GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "SpawnWorldTransform");
		GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "SpawnWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_EnableSnapX_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapX");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapX_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapX");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapX_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_EnableSnapY_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapY");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapY_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapY");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapY_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapZ");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapZ");
		GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "EnableSnapZ", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_IgnoreActors_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "IgnoreActors");
		GEditor_RecalculateMouseRayHitTransform_IgnoreActors_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "IgnoreActors");
		GEditor_RecalculateMouseRayHitTransform_IgnoreActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "IgnoreActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_RecalculateMouseRayHitTransform_ReturnValue_PropertyAddress, GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "ReturnValue");
		GEditor_RecalculateMouseRayHitTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "ReturnValue");
		GEditor_RecalculateMouseRayHitTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_RecalculateMouseRayHitTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GEditor_RecalculateMouseRayHitTransform_IsValid = GEditor_RecalculateMouseRayHitTransform_FunctionAddress != IntPtr.Zero && GEditor_RecalculateMouseRayHitTransform_JSViewport_IsValid && GEditor_RecalculateMouseRayHitTransform_UseUpRot_IsValid && GEditor_RecalculateMouseRayHitTransform_SpawnWorldTransform_IsValid && GEditor_RecalculateMouseRayHitTransform_EnableSnapX_IsValid && GEditor_RecalculateMouseRayHitTransform_EnableSnapY_IsValid && GEditor_RecalculateMouseRayHitTransform_EnableSnapZ_IsValid && GEditor_RecalculateMouseRayHitTransform_IgnoreActors_IsValid && GEditor_RecalculateMouseRayHitTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_RecalculateMouseRayHitTransform", GEditor_RecalculateMouseRayHitTransform_IsValid);
		GEditor_IsStaticMeshRegistered_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_IsStaticMeshRegistered");
		GEditor_IsStaticMeshRegistered_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_IsStaticMeshRegistered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_IsStaticMeshRegistered_StaticMesh_PropertyAddress, GEditor_IsStaticMeshRegistered_FunctionAddress, "StaticMesh");
		GEditor_IsStaticMeshRegistered_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_IsStaticMeshRegistered_FunctionAddress, "StaticMesh");
		GEditor_IsStaticMeshRegistered_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_IsStaticMeshRegistered_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_IsStaticMeshRegistered_ReturnValue_PropertyAddress, GEditor_IsStaticMeshRegistered_FunctionAddress, "ReturnValue");
		GEditor_IsStaticMeshRegistered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_IsStaticMeshRegistered_FunctionAddress, "ReturnValue");
		GEditor_IsStaticMeshRegistered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_IsStaticMeshRegistered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GEditor_IsStaticMeshRegistered_IsValid = GEditor_IsStaticMeshRegistered_FunctionAddress != IntPtr.Zero && GEditor_IsStaticMeshRegistered_StaticMesh_IsValid && GEditor_IsStaticMeshRegistered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsStaticMeshRegistered", GEditor_IsStaticMeshRegistered_IsValid);
		GEditor_IsRunningCommandlet_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_IsRunningCommandlet");
		GEditor_IsRunningCommandlet_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_IsRunningCommandlet_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_IsRunningCommandlet_ReturnValue_PropertyAddress, GEditor_IsRunningCommandlet_FunctionAddress, "ReturnValue");
		GEditor_IsRunningCommandlet_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_IsRunningCommandlet_FunctionAddress, "ReturnValue");
		GEditor_IsRunningCommandlet_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_IsRunningCommandlet_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GEditor_IsRunningCommandlet_IsValid = GEditor_IsRunningCommandlet_FunctionAddress != IntPtr.Zero && GEditor_IsRunningCommandlet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_IsRunningCommandlet", GEditor_IsRunningCommandlet_IsValid);
		GEditor_GetSelectedInstancesFoliageType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetSelectedInstancesFoliageType");
		GEditor_GetSelectedInstancesFoliageType_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetSelectedInstancesFoliageType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetSelectedInstancesFoliageType_ReturnValue_PropertyAddress, GEditor_GetSelectedInstancesFoliageType_FunctionAddress, "ReturnValue");
		GEditor_GetSelectedInstancesFoliageType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetSelectedInstancesFoliageType_FunctionAddress, "ReturnValue");
		GEditor_GetSelectedInstancesFoliageType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetSelectedInstancesFoliageType_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_GetSelectedInstancesFoliageType_IsValid = GEditor_GetSelectedInstancesFoliageType_FunctionAddress != IntPtr.Zero && GEditor_GetSelectedInstancesFoliageType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetSelectedInstancesFoliageType", GEditor_GetSelectedInstancesFoliageType_IsValid);
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetHierarchicalInstancedStaticMeshAssetPath2");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_PropertyAddress, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "InWorld");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "InWorld");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_PropertyAddress, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "location");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "location");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_PropertyAddress, GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "radius");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "radius");
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress, "radius", Classes.FFloatProperty);
		GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_IsValid = GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_FunctionAddress != IntPtr.Zero && GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_InWorld_IsValid && GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_location_IsValid && GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_radius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetHierarchicalInstancedStaticMeshAssetPath2", GEditor_GetHierarchicalInstancedStaticMeshAssetPath2_IsValid);
		GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetGAllowActorScriptExecutionInEditor");
		GEditor_GetGAllowActorScriptExecutionInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_PropertyAddress, GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress, "ReturnValue");
		GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress, "ReturnValue");
		GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GEditor_GetGAllowActorScriptExecutionInEditor_IsValid = GEditor_GetGAllowActorScriptExecutionInEditor_FunctionAddress != IntPtr.Zero && GEditor_GetGAllowActorScriptExecutionInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetGAllowActorScriptExecutionInEditor", GEditor_GetGAllowActorScriptExecutionInEditor_IsValid);
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetFoliageType_Actor_ActorClassAssetPathName");
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_PropertyAddress, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "FoliageType_Actor");
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "FoliageType_Actor");
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "FoliageType_Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_PropertyAddress, GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "ReturnValue");
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "ReturnValue");
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GEditor_GetFoliageType_Actor_ActorClassAssetPathName_IsValid = GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FunctionAddress != IntPtr.Zero && GEditor_GetFoliageType_Actor_ActorClassAssetPathName_FoliageType_Actor_IsValid && GEditor_GetFoliageType_Actor_ActorClassAssetPathName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetFoliageType_Actor_ActorClassAssetPathName", GEditor_GetFoliageType_Actor_ActorClassAssetPathName_IsValid);
		GEditor_GetBlueprintParentClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetBlueprintParentClass");
		GEditor_GetBlueprintParentClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetBlueprintParentClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetBlueprintParentClass_Blueprint_PropertyAddress, GEditor_GetBlueprintParentClass_FunctionAddress, "Blueprint");
		GEditor_GetBlueprintParentClass_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetBlueprintParentClass_FunctionAddress, "Blueprint");
		GEditor_GetBlueprintParentClass_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetBlueprintParentClass_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetBlueprintParentClass_ReturnValue_PropertyAddress, GEditor_GetBlueprintParentClass_FunctionAddress, "ReturnValue");
		GEditor_GetBlueprintParentClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetBlueprintParentClass_FunctionAddress, "ReturnValue");
		GEditor_GetBlueprintParentClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetBlueprintParentClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GEditor_GetBlueprintParentClass_IsValid = GEditor_GetBlueprintParentClass_FunctionAddress != IntPtr.Zero && GEditor_GetBlueprintParentClass_Blueprint_IsValid && GEditor_GetBlueprintParentClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintParentClass", GEditor_GetBlueprintParentClass_IsValid);
		GEditor_GetBlueprintAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_GetBlueprintAsset");
		GEditor_GetBlueprintAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_GetBlueprintAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetBlueprintAsset_Object_PropertyAddress, GEditor_GetBlueprintAsset_FunctionAddress, "Object");
		GEditor_GetBlueprintAsset_Object_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetBlueprintAsset_FunctionAddress, "Object");
		GEditor_GetBlueprintAsset_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetBlueprintAsset_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_GetBlueprintAsset_ReturnValue_PropertyAddress, GEditor_GetBlueprintAsset_FunctionAddress, "ReturnValue");
		GEditor_GetBlueprintAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_GetBlueprintAsset_FunctionAddress, "ReturnValue");
		GEditor_GetBlueprintAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_GetBlueprintAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_GetBlueprintAsset_IsValid = GEditor_GetBlueprintAsset_FunctionAddress != IntPtr.Zero && GEditor_GetBlueprintAsset_Object_IsValid && GEditor_GetBlueprintAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_GetBlueprintAsset", GEditor_GetBlueprintAsset_IsValid);
		GEditor_FoliageType_Actor_ActorClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_FoliageType_Actor_ActorClass");
		GEditor_FoliageType_Actor_ActorClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_FoliageType_Actor_ActorClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_PropertyAddress, GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "FoliageType_Actor");
		GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "FoliageType_Actor");
		GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "FoliageType_Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_FoliageType_Actor_ActorClass_ReturnValue_PropertyAddress, GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "ReturnValue");
		GEditor_FoliageType_Actor_ActorClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "ReturnValue");
		GEditor_FoliageType_Actor_ActorClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_FoliageType_Actor_ActorClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GEditor_FoliageType_Actor_ActorClass_IsValid = GEditor_FoliageType_Actor_ActorClass_FunctionAddress != IntPtr.Zero && GEditor_FoliageType_Actor_ActorClass_FoliageType_Actor_IsValid && GEditor_FoliageType_Actor_ActorClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_FoliageType_Actor_ActorClass", GEditor_FoliageType_Actor_ActorClass_IsValid);
		GEditor_DestroyActorTest_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_DestroyActorTest");
		GEditor_DestroyActorTest_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_DestroyActorTest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_DestroyActorTest_NeedDestroyAcotr_PropertyAddress, GEditor_DestroyActorTest_FunctionAddress, "NeedDestroyAcotr");
		GEditor_DestroyActorTest_NeedDestroyAcotr_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_DestroyActorTest_FunctionAddress, "NeedDestroyAcotr");
		GEditor_DestroyActorTest_NeedDestroyAcotr_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_DestroyActorTest_FunctionAddress, "NeedDestroyAcotr", Classes.FObjectProperty);
		GEditor_DestroyActorTest_IsValid = GEditor_DestroyActorTest_FunctionAddress != IntPtr.Zero && GEditor_DestroyActorTest_NeedDestroyAcotr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_DestroyActorTest", GEditor_DestroyActorTest_IsValid);
		GEditor_CreateMID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_CreateMID");
		GEditor_CreateMID_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_CreateMID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CreateMID_ParentMaterial_PropertyAddress, GEditor_CreateMID_FunctionAddress, "ParentMaterial");
		GEditor_CreateMID_ParentMaterial_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CreateMID_FunctionAddress, "ParentMaterial");
		GEditor_CreateMID_ParentMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CreateMID_FunctionAddress, "ParentMaterial", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CreateMID_InOuter_PropertyAddress, GEditor_CreateMID_FunctionAddress, "InOuter");
		GEditor_CreateMID_InOuter_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CreateMID_FunctionAddress, "InOuter");
		GEditor_CreateMID_InOuter_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CreateMID_FunctionAddress, "InOuter", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CreateMID_ReturnValue_PropertyAddress, GEditor_CreateMID_FunctionAddress, "ReturnValue");
		GEditor_CreateMID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CreateMID_FunctionAddress, "ReturnValue");
		GEditor_CreateMID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CreateMID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_CreateMID_IsValid = GEditor_CreateMID_FunctionAddress != IntPtr.Zero && GEditor_CreateMID_ParentMaterial_IsValid && GEditor_CreateMID_InOuter_IsValid && GEditor_CreateMID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CreateMID", GEditor_CreateMID_IsValid);
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_CalculateComponentsBoundingBoxInLocalSpace");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_PropertyAddress, GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "Unit");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "Unit");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_PropertyAddress, GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "bNonColliding");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "bNonColliding");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "bNonColliding", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_PropertyAddress, GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "ReturnValue");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "ReturnValue");
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GEditor_CalculateComponentsBoundingBoxInLocalSpace_IsValid = GEditor_CalculateComponentsBoundingBoxInLocalSpace_FunctionAddress != IntPtr.Zero && GEditor_CalculateComponentsBoundingBoxInLocalSpace_Unit_IsValid && GEditor_CalculateComponentsBoundingBoxInLocalSpace_bNonColliding_IsValid && GEditor_CalculateComponentsBoundingBoxInLocalSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_CalculateComponentsBoundingBoxInLocalSpace", GEditor_CalculateComponentsBoundingBoxInLocalSpace_IsValid);
		GEditor_AddCompToActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GEditor_AddCompToActor");
		GEditor_AddCompToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GEditor_AddCompToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GEditor_AddCompToActor_EditotWorld_PropertyAddress, GEditor_AddCompToActor_FunctionAddress, "EditotWorld");
		GEditor_AddCompToActor_EditotWorld_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_AddCompToActor_FunctionAddress, "EditotWorld");
		GEditor_AddCompToActor_EditotWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_AddCompToActor_FunctionAddress, "EditotWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_AddCompToActor_Class_PropertyAddress, GEditor_AddCompToActor_FunctionAddress, "Class");
		GEditor_AddCompToActor_Class_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_AddCompToActor_FunctionAddress, "Class");
		GEditor_AddCompToActor_Class_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_AddCompToActor_FunctionAddress, "Class", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_AddCompToActor_Actor_PropertyAddress, GEditor_AddCompToActor_FunctionAddress, "Actor");
		GEditor_AddCompToActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_AddCompToActor_FunctionAddress, "Actor");
		GEditor_AddCompToActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_AddCompToActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GEditor_AddCompToActor_ReturnValue_PropertyAddress, GEditor_AddCompToActor_FunctionAddress, "ReturnValue");
		GEditor_AddCompToActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GEditor_AddCompToActor_FunctionAddress, "ReturnValue");
		GEditor_AddCompToActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GEditor_AddCompToActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GEditor_AddCompToActor_IsValid = GEditor_AddCompToActor_FunctionAddress != IntPtr.Zero && GEditor_AddCompToActor_EditotWorld_IsValid && GEditor_AddCompToActor_Class_IsValid && GEditor_AddCompToActor_Actor_IsValid && GEditor_AddCompToActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:GEditor_AddCompToActor", GEditor_AddCompToActor_IsValid);
		ForceGCInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceGCInEditor");
		ForceGCInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceGCInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceGCInEditor_flag_PropertyAddress, ForceGCInEditor_FunctionAddress, "flag");
		ForceGCInEditor_flag_Offset = NativeReflectionCached.GetPropertyOffset(ForceGCInEditor_FunctionAddress, "flag");
		ForceGCInEditor_flag_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceGCInEditor_FunctionAddress, "flag", Classes.FIntProperty);
		ForceGCInEditor_IsValid = ForceGCInEditor_FunctionAddress != IntPtr.Zero && ForceGCInEditor_flag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ForceGCInEditor", ForceGCInEditor_IsValid);
		ExportStaticMeshInternal_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportStaticMeshInternal");
		ExportStaticMeshInternal_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportStaticMeshInternal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportStaticMeshInternal_ObjectsToExport_PropertyAddress, ExportStaticMeshInternal_FunctionAddress, "ObjectsToExport");
		ExportStaticMeshInternal_ObjectsToExport_Offset = NativeReflectionCached.GetPropertyOffset(ExportStaticMeshInternal_FunctionAddress, "ObjectsToExport");
		ExportStaticMeshInternal_ObjectsToExport_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStaticMeshInternal_FunctionAddress, "ObjectsToExport", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportStaticMeshInternal_ExportPath_PropertyAddress, ExportStaticMeshInternal_FunctionAddress, "ExportPath");
		ExportStaticMeshInternal_ExportPath_Offset = NativeReflectionCached.GetPropertyOffset(ExportStaticMeshInternal_FunctionAddress, "ExportPath");
		ExportStaticMeshInternal_ExportPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportStaticMeshInternal_FunctionAddress, "ExportPath", Classes.FStrProperty);
		ExportStaticMeshInternal_IsValid = ExportStaticMeshInternal_FunctionAddress != IntPtr.Zero && ExportStaticMeshInternal_ObjectsToExport_IsValid && ExportStaticMeshInternal_ExportPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ExportStaticMeshInternal", ExportStaticMeshInternal_IsValid);
		EnableAllPlantsImposter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableAllPlantsImposter");
		EnableAllPlantsImposter_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableAllPlantsImposter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableAllPlantsImposter_MapName_PropertyAddress, EnableAllPlantsImposter_FunctionAddress, "MapName");
		EnableAllPlantsImposter_MapName_Offset = NativeReflectionCached.GetPropertyOffset(EnableAllPlantsImposter_FunctionAddress, "MapName");
		EnableAllPlantsImposter_MapName_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableAllPlantsImposter_FunctionAddress, "MapName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAllPlantsImposter_PlantsKeyWords_PropertyAddress, EnableAllPlantsImposter_FunctionAddress, "PlantsKeyWords");
		EnableAllPlantsImposter_PlantsKeyWords_Offset = NativeReflectionCached.GetPropertyOffset(EnableAllPlantsImposter_FunctionAddress, "PlantsKeyWords");
		EnableAllPlantsImposter_PlantsKeyWords_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableAllPlantsImposter_FunctionAddress, "PlantsKeyWords", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableAllPlantsImposter_RuleOutKeyWords_PropertyAddress, EnableAllPlantsImposter_FunctionAddress, "RuleOutKeyWords");
		EnableAllPlantsImposter_RuleOutKeyWords_Offset = NativeReflectionCached.GetPropertyOffset(EnableAllPlantsImposter_FunctionAddress, "RuleOutKeyWords");
		EnableAllPlantsImposter_RuleOutKeyWords_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableAllPlantsImposter_FunctionAddress, "RuleOutKeyWords", Classes.FArrayProperty);
		EnableAllPlantsImposter_IsValid = EnableAllPlantsImposter_FunctionAddress != IntPtr.Zero && EnableAllPlantsImposter_MapName_IsValid && EnableAllPlantsImposter_PlantsKeyWords_IsValid && EnableAllPlantsImposter_RuleOutKeyWords_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:EnableAllPlantsImposter", EnableAllPlantsImposter_IsValid);
		DuplicateSubobjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateSubobjects");
		DuplicateSubobjects_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateSubobjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSubobjects_Context_PropertyAddress, DuplicateSubobjects_FunctionAddress, "Context");
		DuplicateSubobjects_Context_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSubobjects_FunctionAddress, "Context");
		DuplicateSubobjects_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSubobjects_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSubobjects_SubobjectsToDup_PropertyAddress, DuplicateSubobjects_FunctionAddress, "SubobjectsToDup");
		DuplicateSubobjects_SubobjectsToDup_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSubobjects_FunctionAddress, "SubobjectsToDup");
		DuplicateSubobjects_SubobjectsToDup_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSubobjects_FunctionAddress, "SubobjectsToDup", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSubobjects_BpContext_PropertyAddress, DuplicateSubobjects_FunctionAddress, "BpContext");
		DuplicateSubobjects_BpContext_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSubobjects_FunctionAddress, "BpContext");
		DuplicateSubobjects_BpContext_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSubobjects_FunctionAddress, "BpContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSubobjects_OutNewSubobjects_PropertyAddress, DuplicateSubobjects_FunctionAddress, "OutNewSubobjects");
		DuplicateSubobjects_OutNewSubobjects_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSubobjects_FunctionAddress, "OutNewSubobjects");
		DuplicateSubobjects_OutNewSubobjects_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSubobjects_FunctionAddress, "OutNewSubobjects", Classes.FArrayProperty);
		DuplicateSubobjects_IsValid = DuplicateSubobjects_FunctionAddress != IntPtr.Zero && DuplicateSubobjects_Context_IsValid && DuplicateSubobjects_SubobjectsToDup_IsValid && DuplicateSubobjects_BpContext_IsValid && DuplicateSubobjects_OutNewSubobjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:DuplicateSubobjects", DuplicateSubobjects_IsValid);
		CreateBlueprintWithClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateBlueprintWithClass");
		CreateBlueprintWithClass_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBlueprintWithClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBlueprintWithClass_ParentClass_PropertyAddress, CreateBlueprintWithClass_FunctionAddress, "ParentClass");
		CreateBlueprintWithClass_ParentClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlueprintWithClass_FunctionAddress, "ParentClass");
		CreateBlueprintWithClass_ParentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlueprintWithClass_FunctionAddress, "ParentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlueprintWithClass_AssetName_PropertyAddress, CreateBlueprintWithClass_FunctionAddress, "AssetName");
		CreateBlueprintWithClass_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlueprintWithClass_FunctionAddress, "AssetName");
		CreateBlueprintWithClass_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlueprintWithClass_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlueprintWithClass_PackagePath_PropertyAddress, CreateBlueprintWithClass_FunctionAddress, "PackagePath");
		CreateBlueprintWithClass_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlueprintWithClass_FunctionAddress, "PackagePath");
		CreateBlueprintWithClass_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlueprintWithClass_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBlueprintWithClass_ReturnValue_PropertyAddress, CreateBlueprintWithClass_FunctionAddress, "ReturnValue");
		CreateBlueprintWithClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateBlueprintWithClass_FunctionAddress, "ReturnValue");
		CreateBlueprintWithClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBlueprintWithClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateBlueprintWithClass_IsValid = CreateBlueprintWithClass_FunctionAddress != IntPtr.Zero && CreateBlueprintWithClass_ParentClass_IsValid && CreateBlueprintWithClass_AssetName_IsValid && CreateBlueprintWithClass_PackagePath_IsValid && CreateBlueprintWithClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:CreateBlueprintWithClass", CreateBlueprintWithClass_IsValid);
		CopyThumbnailBetweenBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyThumbnailBetweenBlueprint");
		CopyThumbnailBetweenBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyThumbnailBetweenBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyThumbnailBetweenBlueprint_Origin_PropertyAddress, CopyThumbnailBetweenBlueprint_FunctionAddress, "Origin");
		CopyThumbnailBetweenBlueprint_Origin_Offset = NativeReflectionCached.GetPropertyOffset(CopyThumbnailBetweenBlueprint_FunctionAddress, "Origin");
		CopyThumbnailBetweenBlueprint_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyThumbnailBetweenBlueprint_FunctionAddress, "Origin", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyThumbnailBetweenBlueprint_Target_PropertyAddress, CopyThumbnailBetweenBlueprint_FunctionAddress, "Target");
		CopyThumbnailBetweenBlueprint_Target_Offset = NativeReflectionCached.GetPropertyOffset(CopyThumbnailBetweenBlueprint_FunctionAddress, "Target");
		CopyThumbnailBetweenBlueprint_Target_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyThumbnailBetweenBlueprint_FunctionAddress, "Target", Classes.FObjectProperty);
		CopyThumbnailBetweenBlueprint_IsValid = CopyThumbnailBetweenBlueprint_FunctionAddress != IntPtr.Zero && CopyThumbnailBetweenBlueprint_Origin_IsValid && CopyThumbnailBetweenBlueprint_Target_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:CopyThumbnailBetweenBlueprint", CopyThumbnailBetweenBlueprint_IsValid);
		ConvertHISMToStaticMeshActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertHISMToStaticMeshActor");
		ConvertHISMToStaticMeshActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertHISMToStaticMeshActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertHISMToStaticMeshActor_WorldContext_PropertyAddress, ConvertHISMToStaticMeshActor_FunctionAddress, "WorldContext");
		ConvertHISMToStaticMeshActor_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(ConvertHISMToStaticMeshActor_FunctionAddress, "WorldContext");
		ConvertHISMToStaticMeshActor_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertHISMToStaticMeshActor_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		ConvertHISMToStaticMeshActor_IsValid = ConvertHISMToStaticMeshActor_FunctionAddress != IntPtr.Zero && ConvertHISMToStaticMeshActor_WorldContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ConvertHISMToStaticMeshActor", ConvertHISMToStaticMeshActor_IsValid);
		ContainRuntimeVirtualTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ContainRuntimeVirtualTexture");
		ContainRuntimeVirtualTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(ContainRuntimeVirtualTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ContainRuntimeVirtualTexture_PrimComponent_PropertyAddress, ContainRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		ContainRuntimeVirtualTexture_PrimComponent_Offset = NativeReflectionCached.GetPropertyOffset(ContainRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		ContainRuntimeVirtualTexture_PrimComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainRuntimeVirtualTexture_FunctionAddress, "PrimComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ContainRuntimeVirtualTexture_RVT_PropertyAddress, ContainRuntimeVirtualTexture_FunctionAddress, "RVT");
		ContainRuntimeVirtualTexture_RVT_Offset = NativeReflectionCached.GetPropertyOffset(ContainRuntimeVirtualTexture_FunctionAddress, "RVT");
		ContainRuntimeVirtualTexture_RVT_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainRuntimeVirtualTexture_FunctionAddress, "RVT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ContainRuntimeVirtualTexture_ReturnValue_PropertyAddress, ContainRuntimeVirtualTexture_FunctionAddress, "ReturnValue");
		ContainRuntimeVirtualTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ContainRuntimeVirtualTexture_FunctionAddress, "ReturnValue");
		ContainRuntimeVirtualTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ContainRuntimeVirtualTexture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ContainRuntimeVirtualTexture_IsValid = ContainRuntimeVirtualTexture_FunctionAddress != IntPtr.Zero && ContainRuntimeVirtualTexture_PrimComponent_IsValid && ContainRuntimeVirtualTexture_RVT_IsValid && ContainRuntimeVirtualTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ContainRuntimeVirtualTexture", ContainRuntimeVirtualTexture_IsValid);
		ClearRuntimeVirtualTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearRuntimeVirtualTexture");
		ClearRuntimeVirtualTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearRuntimeVirtualTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearRuntimeVirtualTexture_PrimComponent_PropertyAddress, ClearRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		ClearRuntimeVirtualTexture_PrimComponent_Offset = NativeReflectionCached.GetPropertyOffset(ClearRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		ClearRuntimeVirtualTexture_PrimComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearRuntimeVirtualTexture_FunctionAddress, "PrimComponent", Classes.FObjectProperty);
		ClearRuntimeVirtualTexture_IsValid = ClearRuntimeVirtualTexture_FunctionAddress != IntPtr.Zero && ClearRuntimeVirtualTexture_PrimComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ClearRuntimeVirtualTexture", ClearRuntimeVirtualTexture_IsValid);
		CleanOverlapFoliages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanOverlapFoliages");
		CleanOverlapFoliages_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanOverlapFoliages_FunctionAddress);
		CleanOverlapFoliages_IsValid = CleanOverlapFoliages_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapFoliages", CleanOverlapFoliages_IsValid);
		CleanOverlapActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanOverlapActors");
		CleanOverlapActors_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanOverlapActors_FunctionAddress);
		CleanOverlapActors_IsValid = CleanOverlapActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:CleanOverlapActors", CleanOverlapActors_IsValid);
		CheckoutAndSavePackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutAndSavePackage");
		CheckoutAndSavePackage_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutAndSavePackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_PackagesToSave_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "PackagesToSave");
		CheckoutAndSavePackage_PackagesToSave_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "PackagesToSave");
		CheckoutAndSavePackage_PackagesToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "PackagesToSave", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_bCheckDirty_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bCheckDirty");
		CheckoutAndSavePackage_bCheckDirty_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bCheckDirty");
		CheckoutAndSavePackage_bCheckDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bCheckDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_bPromptToSave_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bPromptToSave");
		CheckoutAndSavePackage_bPromptToSave_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bPromptToSave");
		CheckoutAndSavePackage_bPromptToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bPromptToSave", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_OutFailedPackages_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "OutFailedPackages");
		CheckoutAndSavePackage_OutFailedPackages_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "OutFailedPackages");
		CheckoutAndSavePackage_OutFailedPackages_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "OutFailedPackages", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_bAlreadyCheckedOut_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut");
		CheckoutAndSavePackage_bAlreadyCheckedOut_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut");
		CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bAlreadyCheckedOut", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_bCanBeDeclined_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined");
		CheckoutAndSavePackage_bCanBeDeclined_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined");
		CheckoutAndSavePackage_bCanBeDeclined_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "bCanBeDeclined", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAndSavePackage_ReturnValue_PropertyAddress, CheckoutAndSavePackage_FunctionAddress, "ReturnValue");
		CheckoutAndSavePackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAndSavePackage_FunctionAddress, "ReturnValue");
		CheckoutAndSavePackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAndSavePackage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutAndSavePackage_IsValid = CheckoutAndSavePackage_FunctionAddress != IntPtr.Zero && CheckoutAndSavePackage_PackagesToSave_IsValid && CheckoutAndSavePackage_bCheckDirty_IsValid && CheckoutAndSavePackage_bPromptToSave_IsValid && CheckoutAndSavePackage_OutFailedPackages_IsValid && CheckoutAndSavePackage_bAlreadyCheckedOut_IsValid && CheckoutAndSavePackage_bCanBeDeclined_IsValid && CheckoutAndSavePackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:CheckoutAndSavePackage", CheckoutAndSavePackage_IsValid);
		ChangeBufferVisualizationMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ChangeBufferVisualizationMode");
		ChangeBufferVisualizationMode_ParamsSize = NativeReflection.GetFunctionParamsSize(ChangeBufferVisualizationMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ChangeBufferVisualizationMode_InName_PropertyAddress, ChangeBufferVisualizationMode_FunctionAddress, "InName");
		ChangeBufferVisualizationMode_InName_Offset = NativeReflectionCached.GetPropertyOffset(ChangeBufferVisualizationMode_FunctionAddress, "InName");
		ChangeBufferVisualizationMode_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(ChangeBufferVisualizationMode_FunctionAddress, "InName", Classes.FNameProperty);
		ChangeBufferVisualizationMode_IsValid = ChangeBufferVisualizationMode_FunctionAddress != IntPtr.Zero && ChangeBufferVisualizationMode_InName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:ChangeBufferVisualizationMode", ChangeBufferVisualizationMode_IsValid);
		BGUSplitSplineActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSplitSplineActor");
		BGUSplitSplineActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSplitSplineActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSplitSplineActor_InSplineActor_PropertyAddress, BGUSplitSplineActor_FunctionAddress, "InSplineActor");
		BGUSplitSplineActor_InSplineActor_Offset = NativeReflectionCached.GetPropertyOffset(BGUSplitSplineActor_FunctionAddress, "InSplineActor");
		BGUSplitSplineActor_InSplineActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSplitSplineActor_FunctionAddress, "InSplineActor", Classes.FObjectProperty);
		BGUSplitSplineActor_IsValid = BGUSplitSplineActor_FunctionAddress != IntPtr.Zero && BGUSplitSplineActor_InSplineActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGUSplitSplineActor", BGUSplitSplineActor_IsValid);
		BGURecalculateSpawnTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURecalculateSpawnTransform");
		BGURecalculateSpawnTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURecalculateSpawnTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_JSViewport_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "JSViewport");
		BGURecalculateSpawnTransform_JSViewport_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "JSViewport");
		BGURecalculateSpawnTransform_JSViewport_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "JSViewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_UseUpRot_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "UseUpRot");
		BGURecalculateSpawnTransform_UseUpRot_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "UseUpRot");
		BGURecalculateSpawnTransform_UseUpRot_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "UseUpRot", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_SpawnWorldTransform_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "SpawnWorldTransform");
		BGURecalculateSpawnTransform_SpawnWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "SpawnWorldTransform");
		BGURecalculateSpawnTransform_SpawnWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "SpawnWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_EnableSnapX_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapX");
		BGURecalculateSpawnTransform_EnableSnapX_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapX");
		BGURecalculateSpawnTransform_EnableSnapX_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapX", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_EnableSnapY_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapY");
		BGURecalculateSpawnTransform_EnableSnapY_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapY");
		BGURecalculateSpawnTransform_EnableSnapY_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapY", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_EnableSnapZ_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapZ");
		BGURecalculateSpawnTransform_EnableSnapZ_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapZ");
		BGURecalculateSpawnTransform_EnableSnapZ_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "EnableSnapZ", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateSpawnTransform_ReturnValue_PropertyAddress, BGURecalculateSpawnTransform_FunctionAddress, "ReturnValue");
		BGURecalculateSpawnTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateSpawnTransform_FunctionAddress, "ReturnValue");
		BGURecalculateSpawnTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateSpawnTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGURecalculateSpawnTransform_IsValid = BGURecalculateSpawnTransform_FunctionAddress != IntPtr.Zero && BGURecalculateSpawnTransform_JSViewport_IsValid && BGURecalculateSpawnTransform_UseUpRot_IsValid && BGURecalculateSpawnTransform_SpawnWorldTransform_IsValid && BGURecalculateSpawnTransform_EnableSnapX_IsValid && BGURecalculateSpawnTransform_EnableSnapY_IsValid && BGURecalculateSpawnTransform_EnableSnapZ_IsValid && BGURecalculateSpawnTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateSpawnTransform", BGURecalculateSpawnTransform_IsValid);
		BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURecalculateMousePlaneIntersectionWorldLocation");
		BGURecalculateMousePlaneIntersectionWorldLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_PropertyAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "JSViewport");
		BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "JSViewport");
		BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "JSViewport", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_PropertyAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnWorldTransform");
		BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnWorldTransform");
		BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnWorldTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_PropertyAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnTracePlane");
		BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnTracePlane");
		BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "SpawnTracePlane", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_PropertyAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "CursorPlaneIntersectionWorldLocation");
		BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "CursorPlaneIntersectionWorldLocation");
		BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "CursorPlaneIntersectionWorldLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_PropertyAddress, BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "ReturnValue");
		BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "ReturnValue");
		BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGURecalculateMousePlaneIntersectionWorldLocation_IsValid = BGURecalculateMousePlaneIntersectionWorldLocation_FunctionAddress != IntPtr.Zero && BGURecalculateMousePlaneIntersectionWorldLocation_JSViewport_IsValid && BGURecalculateMousePlaneIntersectionWorldLocation_SpawnWorldTransform_IsValid && BGURecalculateMousePlaneIntersectionWorldLocation_SpawnTracePlane_IsValid && BGURecalculateMousePlaneIntersectionWorldLocation_CursorPlaneIntersectionWorldLocation_IsValid && BGURecalculateMousePlaneIntersectionWorldLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGURecalculateMousePlaneIntersectionWorldLocation", BGURecalculateMousePlaneIntersectionWorldLocation_IsValid);
		BGUGenSplineAirWall_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenSplineAirWall");
		BGUGenSplineAirWall_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenSplineAirWall_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_WorldContextObject_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "WorldContextObject");
		BGUGenSplineAirWall_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "WorldContextObject");
		BGUGenSplineAirWall_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_BaseVertices_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "BaseVertices");
		BGUGenSplineAirWall_BaseVertices_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "BaseVertices");
		BGUGenSplineAirWall_BaseVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "BaseVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_AirWallHeight_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "AirWallHeight");
		BGUGenSplineAirWall_AirWallHeight_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "AirWallHeight");
		BGUGenSplineAirWall_AirWallHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "AirWallHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_bMakeInvisible_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "bMakeInvisible");
		BGUGenSplineAirWall_bMakeInvisible_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "bMakeInvisible");
		BGUGenSplineAirWall_bMakeInvisible_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "bMakeInvisible", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_AirWallType_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "AirWallType");
		BGUGenSplineAirWall_AirWallType_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "AirWallType");
		BGUGenSplineAirWall_AirWallType_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "AirWallType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_UpDirection_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "UpDirection");
		BGUGenSplineAirWall_UpDirection_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "UpDirection");
		BGUGenSplineAirWall_UpDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "UpDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_bNavModify_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "bNavModify");
		BGUGenSplineAirWall_bNavModify_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "bNavModify");
		BGUGenSplineAirWall_bNavModify_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "bNavModify", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenSplineAirWall_ReturnValue_PropertyAddress, BGUGenSplineAirWall_FunctionAddress, "ReturnValue");
		BGUGenSplineAirWall_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenSplineAirWall_FunctionAddress, "ReturnValue");
		BGUGenSplineAirWall_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenSplineAirWall_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGenSplineAirWall_IsValid = BGUGenSplineAirWall_FunctionAddress != IntPtr.Zero && BGUGenSplineAirWall_WorldContextObject_IsValid && BGUGenSplineAirWall_BaseVertices_IsValid && BGUGenSplineAirWall_AirWallHeight_IsValid && BGUGenSplineAirWall_bMakeInvisible_IsValid && BGUGenSplineAirWall_AirWallType_IsValid && BGUGenSplineAirWall_UpDirection_IsValid && BGUGenSplineAirWall_bNavModify_IsValid && BGUGenSplineAirWall_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenSplineAirWall", BGUGenSplineAirWall_IsValid);
		BGUGenManualSplineMoveOverlapVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenManualSplineMoveOverlapVolume");
		BGUGenManualSplineMoveOverlapVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenManualSplineMoveOverlapVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenManualSplineMoveOverlapVolume_WorldContext_PropertyAddress, BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "WorldContext");
		BGUGenManualSplineMoveOverlapVolume_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "WorldContext");
		BGUGenManualSplineMoveOverlapVolume_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenManualSplineMoveOverlapVolume_BaseVertices_PropertyAddress, BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "BaseVertices");
		BGUGenManualSplineMoveOverlapVolume_BaseVertices_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "BaseVertices");
		BGUGenManualSplineMoveOverlapVolume_BaseVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "BaseVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenManualSplineMoveOverlapVolume_ReturnValue_PropertyAddress, BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "ReturnValue");
		BGUGenManualSplineMoveOverlapVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "ReturnValue");
		BGUGenManualSplineMoveOverlapVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenManualSplineMoveOverlapVolume_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGenManualSplineMoveOverlapVolume_IsValid = BGUGenManualSplineMoveOverlapVolume_FunctionAddress != IntPtr.Zero && BGUGenManualSplineMoveOverlapVolume_WorldContext_IsValid && BGUGenManualSplineMoveOverlapVolume_BaseVertices_IsValid && BGUGenManualSplineMoveOverlapVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenManualSplineMoveOverlapVolume", BGUGenManualSplineMoveOverlapVolume_IsValid);
		BGUGenAirWall_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenAirWall");
		BGUGenAirWall_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenAirWall_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenAirWall_WorldContextObject_PropertyAddress, BGUGenAirWall_FunctionAddress, "WorldContextObject");
		BGUGenAirWall_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenAirWall_FunctionAddress, "WorldContextObject");
		BGUGenAirWall_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenAirWall_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenAirWall_ShapeVertices_PropertyAddress, BGUGenAirWall_FunctionAddress, "ShapeVertices");
		BGUGenAirWall_ShapeVertices_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenAirWall_FunctionAddress, "ShapeVertices");
		BGUGenAirWall_ShapeVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenAirWall_FunctionAddress, "ShapeVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenAirWall_bAutoExtrude_PropertyAddress, BGUGenAirWall_FunctionAddress, "bAutoExtrude");
		BGUGenAirWall_bAutoExtrude_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenAirWall_FunctionAddress, "bAutoExtrude");
		BGUGenAirWall_bAutoExtrude_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenAirWall_FunctionAddress, "bAutoExtrude", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenAirWall_ExtrudeDepth_PropertyAddress, BGUGenAirWall_FunctionAddress, "ExtrudeDepth");
		BGUGenAirWall_ExtrudeDepth_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenAirWall_FunctionAddress, "ExtrudeDepth");
		BGUGenAirWall_ExtrudeDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenAirWall_FunctionAddress, "ExtrudeDepth", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenAirWall_AirWallHeight_PropertyAddress, BGUGenAirWall_FunctionAddress, "AirWallHeight");
		BGUGenAirWall_AirWallHeight_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenAirWall_FunctionAddress, "AirWallHeight");
		BGUGenAirWall_AirWallHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenAirWall_FunctionAddress, "AirWallHeight", Classes.FFloatProperty);
		BGUGenAirWall_IsValid = BGUGenAirWall_FunctionAddress != IntPtr.Zero && BGUGenAirWall_WorldContextObject_IsValid && BGUGenAirWall_ShapeVertices_IsValid && BGUGenAirWall_bAutoExtrude_IsValid && BGUGenAirWall_ExtrudeDepth_IsValid && BGUGenAirWall_AirWallHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGUGenAirWall", BGUGenAirWall_IsValid);
		BGUFixSplineAirWallCenterPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUFixSplineAirWallCenterPoint");
		BGUFixSplineAirWallCenterPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUFixSplineAirWallCenterPoint_FunctionAddress);
		BGUFixSplineAirWallCenterPoint_IsValid = BGUFixSplineAirWallCenterPoint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:BGUFixSplineAirWallCenterPoint", BGUFixSplineAirWallCenterPoint_IsValid);
		AddRuntimeVirtualTexture_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddRuntimeVirtualTexture");
		AddRuntimeVirtualTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(AddRuntimeVirtualTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddRuntimeVirtualTexture_PrimComponent_PropertyAddress, AddRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		AddRuntimeVirtualTexture_PrimComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddRuntimeVirtualTexture_FunctionAddress, "PrimComponent");
		AddRuntimeVirtualTexture_PrimComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRuntimeVirtualTexture_FunctionAddress, "PrimComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRuntimeVirtualTexture_RVT_PropertyAddress, AddRuntimeVirtualTexture_FunctionAddress, "RVT");
		AddRuntimeVirtualTexture_RVT_Offset = NativeReflectionCached.GetPropertyOffset(AddRuntimeVirtualTexture_FunctionAddress, "RVT");
		AddRuntimeVirtualTexture_RVT_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRuntimeVirtualTexture_FunctionAddress, "RVT", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddRuntimeVirtualTexture_ReturnValue_PropertyAddress, AddRuntimeVirtualTexture_FunctionAddress, "ReturnValue");
		AddRuntimeVirtualTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddRuntimeVirtualTexture_FunctionAddress, "ReturnValue");
		AddRuntimeVirtualTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddRuntimeVirtualTexture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddRuntimeVirtualTexture_IsValid = AddRuntimeVirtualTexture_FunctionAddress != IntPtr.Zero && AddRuntimeVirtualTexture_PrimComponent_IsValid && AddRuntimeVirtualTexture_RVT_IsValid && AddRuntimeVirtualTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:AddRuntimeVirtualTexture", AddRuntimeVirtualTexture_IsValid);
		AddNewCompToBPAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNewCompToBPAsset");
		AddNewCompToBPAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewCompToBPAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_InBlueprint_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "InBlueprint");
		AddNewCompToBPAsset_InBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "InBlueprint");
		AddNewCompToBPAsset_InBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "InBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_InComponentVariableName_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "InComponentVariableName");
		AddNewCompToBPAsset_InComponentVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "InComponentVariableName");
		AddNewCompToBPAsset_InComponentVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "InComponentVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_InComponentClass_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "InComponentClass");
		AddNewCompToBPAsset_InComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "InComponentClass");
		AddNewCompToBPAsset_InComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "InComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_outCompVariableName_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "outCompVariableName");
		AddNewCompToBPAsset_outCompVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "outCompVariableName");
		AddNewCompToBPAsset_outCompVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "outCompVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_ParentVariableName_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "ParentVariableName");
		AddNewCompToBPAsset_ParentVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "ParentVariableName");
		AddNewCompToBPAsset_ParentVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "ParentVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_SocketOrBoneName_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "SocketOrBoneName");
		AddNewCompToBPAsset_SocketOrBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "SocketOrBoneName");
		AddNewCompToBPAsset_SocketOrBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "SocketOrBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToBPAsset_ReturnValue_PropertyAddress, AddNewCompToBPAsset_FunctionAddress, "ReturnValue");
		AddNewCompToBPAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToBPAsset_FunctionAddress, "ReturnValue");
		AddNewCompToBPAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToBPAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNewCompToBPAsset_IsValid = AddNewCompToBPAsset_FunctionAddress != IntPtr.Zero && AddNewCompToBPAsset_InBlueprint_IsValid && AddNewCompToBPAsset_InComponentVariableName_IsValid && AddNewCompToBPAsset_InComponentClass_IsValid && AddNewCompToBPAsset_outCompVariableName_IsValid && AddNewCompToBPAsset_ParentVariableName_IsValid && AddNewCompToBPAsset_SocketOrBoneName_IsValid && AddNewCompToBPAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToBPAsset", AddNewCompToBPAsset_IsValid);
		AddNewCompToActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNewCompToActor");
		AddNewCompToActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewCompToActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToActor_Actor_PropertyAddress, AddNewCompToActor_FunctionAddress, "Actor");
		AddNewCompToActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToActor_FunctionAddress, "Actor");
		AddNewCompToActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToActor_InComponentClass_PropertyAddress, AddNewCompToActor_FunctionAddress, "InComponentClass");
		AddNewCompToActor_InComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToActor_FunctionAddress, "InComponentClass");
		AddNewCompToActor_InComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToActor_FunctionAddress, "InComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewCompToActor_ReturnValue_PropertyAddress, AddNewCompToActor_FunctionAddress, "ReturnValue");
		AddNewCompToActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewCompToActor_FunctionAddress, "ReturnValue");
		AddNewCompToActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewCompToActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNewCompToActor_IsValid = AddNewCompToActor_FunctionAddress != IntPtr.Zero && AddNewCompToActor_Actor_IsValid && AddNewCompToActor_InComponentClass_IsValid && AddNewCompToActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:AddNewCompToActor", AddNewCompToActor_IsValid);
		AddCompToBPAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddCompToBPAsset");
		AddCompToBPAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCompToBPAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_BP_PropertyAddress, AddCompToBPAsset_FunctionAddress, "BP");
		AddCompToBPAsset_BP_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "BP");
		AddCompToBPAsset_BP_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_NewComponentVariableName_PropertyAddress, AddCompToBPAsset_FunctionAddress, "NewComponentVariableName");
		AddCompToBPAsset_NewComponentVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "NewComponentVariableName");
		AddCompToBPAsset_NewComponentVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "NewComponentVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_NewComponentClass_PropertyAddress, AddCompToBPAsset_FunctionAddress, "NewComponentClass");
		AddCompToBPAsset_NewComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "NewComponentClass");
		AddCompToBPAsset_NewComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "NewComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_outNewVariableName_PropertyAddress, AddCompToBPAsset_FunctionAddress, "outNewVariableName");
		AddCompToBPAsset_outNewVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "outNewVariableName");
		AddCompToBPAsset_outNewVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "outNewVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_ParentComponentOrVariableName_PropertyAddress, AddCompToBPAsset_FunctionAddress, "ParentComponentOrVariableName");
		AddCompToBPAsset_ParentComponentOrVariableName_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "ParentComponentOrVariableName");
		AddCompToBPAsset_ParentComponentOrVariableName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "ParentComponentOrVariableName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_SocketOrBoneName_PropertyAddress, AddCompToBPAsset_FunctionAddress, "SocketOrBoneName");
		AddCompToBPAsset_SocketOrBoneName_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "SocketOrBoneName");
		AddCompToBPAsset_SocketOrBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "SocketOrBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCompToBPAsset_ReturnValue_PropertyAddress, AddCompToBPAsset_FunctionAddress, "ReturnValue");
		AddCompToBPAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCompToBPAsset_FunctionAddress, "ReturnValue");
		AddCompToBPAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCompToBPAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddCompToBPAsset_IsValid = AddCompToBPAsset_FunctionAddress != IntPtr.Zero && AddCompToBPAsset_BP_IsValid && AddCompToBPAsset_NewComponentVariableName_IsValid && AddCompToBPAsset_NewComponentClass_IsValid && AddCompToBPAsset_outNewVariableName_IsValid && AddCompToBPAsset_ParentComponentOrVariableName_IsValid && AddCompToBPAsset_SocketOrBoneName_IsValid && AddCompToBPAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:AddCompToBPAsset", AddCompToBPAsset_IsValid);
		AddComponentsToBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddComponentsToBlueprint");
		AddComponentsToBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddComponentsToBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_Blueprint_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "Blueprint");
		AddComponentsToBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "Blueprint");
		AddComponentsToBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_Components_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "Components");
		AddComponentsToBlueprint_Components_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "Components");
		AddComponentsToBlueprint_Components_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "Components", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_bHarvesting_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "bHarvesting");
		AddComponentsToBlueprint_bHarvesting_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "bHarvesting");
		AddComponentsToBlueprint_bHarvesting_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "bHarvesting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_OptionalNewRootComponentTag_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponentTag");
		AddComponentsToBlueprint_OptionalNewRootComponentTag_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponentTag");
		AddComponentsToBlueprint_OptionalNewRootComponentTag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponentTag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_bKeepMobility_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "bKeepMobility");
		AddComponentsToBlueprint_bKeepMobility_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "bKeepMobility");
		AddComponentsToBlueprint_bKeepMobility_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "bKeepMobility", Classes.FBoolProperty);
		AddComponentsToBlueprint_IsValid = AddComponentsToBlueprint_FunctionAddress != IntPtr.Zero && AddComponentsToBlueprint_Blueprint_IsValid && AddComponentsToBlueprint_Components_IsValid && AddComponentsToBlueprint_bHarvesting_IsValid && AddComponentsToBlueprint_OptionalNewRootComponentTag_IsValid && AddComponentsToBlueprint_bKeepMobility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSFuncLibForEditor:AddComponentsToBlueprint", AddComponentsToBlueprint_IsValid);
	}
}

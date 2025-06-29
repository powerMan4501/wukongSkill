using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;
using UnrealEngine.UnrealEd;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateModelComponents_IsValid;

	private static IntPtr UpdateModelComponents_FunctionAddress;

	private static int UpdateModelComponents_ParamsSize;

	private static bool UpdateModelComponents_Level_IsValid;

	private static FFieldAddress UpdateModelComponents_Level_PropertyAddress;

	private static int UpdateModelComponents_Level_Offset;

	private static bool ToggleSelect_IsValid;

	private static IntPtr ToggleSelect_FunctionAddress;

	private static int ToggleSelect_ParamsSize;

	private static bool ToggleSelect_Selection_IsValid;

	private static FFieldAddress ToggleSelect_Selection_PropertyAddress;

	private static int ToggleSelect_Selection_Offset;

	private static bool ToggleSelect_InObject_IsValid;

	private static FFieldAddress ToggleSelect_InObject_PropertyAddress;

	private static int ToggleSelect_InObject_Offset;

	private static bool ToggleIsExecuteTestModePIE_IsValid;

	private static IntPtr ToggleIsExecuteTestModePIE_FunctionAddress;

	private static int ToggleIsExecuteTestModePIE_ParamsSize;

	private static bool ToggleIsExecuteTestModePIE_ReturnValue_IsValid;

	private static FFieldAddress ToggleIsExecuteTestModePIE_ReturnValue_PropertyAddress;

	private static int ToggleIsExecuteTestModePIE_ReturnValue_Offset;

	private static bool SetIsTemporarilyHiddenInEditor_IsValid;

	private static IntPtr SetIsTemporarilyHiddenInEditor_FunctionAddress;

	private static int SetIsTemporarilyHiddenInEditor_ParamsSize;

	private static bool SetIsTemporarilyHiddenInEditor_Actor_IsValid;

	private static FFieldAddress SetIsTemporarilyHiddenInEditor_Actor_PropertyAddress;

	private static int SetIsTemporarilyHiddenInEditor_Actor_Offset;

	private static bool SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid;

	private static FFieldAddress SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress;

	private static int SetIsTemporarilyHiddenInEditor_bIsHidden_Offset;

	private static bool SetHitProxy_IsValid;

	private static IntPtr SetHitProxy_FunctionAddress;

	private static int SetHitProxy_ParamsSize;

	private static bool SetHitProxy_PDI_IsValid;

	private static FFieldAddress SetHitProxy_PDI_PropertyAddress;

	private static int SetHitProxy_PDI_Offset;

	private static bool SetHitProxy_Name_IsValid;

	private static FFieldAddress SetHitProxy_Name_PropertyAddress;

	private static int SetHitProxy_Name_Offset;

	private static bool SetHeightmapDataFromMemory_IsValid;

	private static IntPtr SetHeightmapDataFromMemory_FunctionAddress;

	private static int SetHeightmapDataFromMemory_ParamsSize;

	private static bool SetHeightmapDataFromMemory_LandscapeInfo_IsValid;

	private static FFieldAddress SetHeightmapDataFromMemory_LandscapeInfo_PropertyAddress;

	private static int SetHeightmapDataFromMemory_LandscapeInfo_Offset;

	private static bool SetHeightmapDataFromMemory_MinX_IsValid;

	private static FFieldAddress SetHeightmapDataFromMemory_MinX_PropertyAddress;

	private static int SetHeightmapDataFromMemory_MinX_Offset;

	private static bool SetHeightmapDataFromMemory_MinY_IsValid;

	private static FFieldAddress SetHeightmapDataFromMemory_MinY_PropertyAddress;

	private static int SetHeightmapDataFromMemory_MinY_Offset;

	private static bool SetHeightmapDataFromMemory_MaxX_IsValid;

	private static FFieldAddress SetHeightmapDataFromMemory_MaxX_PropertyAddress;

	private static int SetHeightmapDataFromMemory_MaxX_Offset;

	private static bool SetHeightmapDataFromMemory_MaxY_IsValid;

	private static FFieldAddress SetHeightmapDataFromMemory_MaxY_PropertyAddress;

	private static int SetHeightmapDataFromMemory_MaxY_Offset;

	private static bool SetFolderPath_Recursively_IsValid;

	private static IntPtr SetFolderPath_Recursively_FunctionAddress;

	private static int SetFolderPath_Recursively_ParamsSize;

	private static bool SetFolderPath_Recursively_Actor_IsValid;

	private static FFieldAddress SetFolderPath_Recursively_Actor_PropertyAddress;

	private static int SetFolderPath_Recursively_Actor_Offset;

	private static bool SetFolderPath_Recursively_NewFolderPath_IsValid;

	private static FFieldAddress SetFolderPath_Recursively_NewFolderPath_PropertyAddress;

	private static int SetFolderPath_Recursively_NewFolderPath_Offset;

	private static bool SetFolderPath_IsValid;

	private static IntPtr SetFolderPath_FunctionAddress;

	private static int SetFolderPath_ParamsSize;

	private static bool SetFolderPath_Actor_IsValid;

	private static FFieldAddress SetFolderPath_Actor_PropertyAddress;

	private static int SetFolderPath_Actor_Offset;

	private static bool SetFolderPath_NewFolderPath_IsValid;

	private static FFieldAddress SetFolderPath_NewFolderPath_PropertyAddress;

	private static int SetFolderPath_NewFolderPath_Offset;

	private static bool SetAlphamapDataFromMemory_IsValid;

	private static IntPtr SetAlphamapDataFromMemory_FunctionAddress;

	private static int SetAlphamapDataFromMemory_ParamsSize;

	private static bool SetAlphamapDataFromMemory_LandscapeInfo_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_LandscapeInfo_PropertyAddress;

	private static int SetAlphamapDataFromMemory_LandscapeInfo_Offset;

	private static bool SetAlphamapDataFromMemory_LayerInfo_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_LayerInfo_PropertyAddress;

	private static int SetAlphamapDataFromMemory_LayerInfo_Offset;

	private static bool SetAlphamapDataFromMemory_MinX_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_MinX_PropertyAddress;

	private static int SetAlphamapDataFromMemory_MinX_Offset;

	private static bool SetAlphamapDataFromMemory_MinY_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_MinY_PropertyAddress;

	private static int SetAlphamapDataFromMemory_MinY_Offset;

	private static bool SetAlphamapDataFromMemory_MaxX_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_MaxX_PropertyAddress;

	private static int SetAlphamapDataFromMemory_MaxX_Offset;

	private static bool SetAlphamapDataFromMemory_MaxY_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_MaxY_PropertyAddress;

	private static int SetAlphamapDataFromMemory_MaxY_Offset;

	private static bool SetAlphamapDataFromMemory_PaintingRestriction_IsValid;

	private static FFieldAddress SetAlphamapDataFromMemory_PaintingRestriction_PropertyAddress;

	private static int SetAlphamapDataFromMemory_PaintingRestriction_Offset;

	private static bool SetActorLocation_IsValid;

	private static IntPtr SetActorLocation_FunctionAddress;

	private static int SetActorLocation_ParamsSize;

	private static bool SetActorLocation_Actor_IsValid;

	private static FFieldAddress SetActorLocation_Actor_PropertyAddress;

	private static int SetActorLocation_Actor_Offset;

	private static bool SetActorLocation_NewLocation_IsValid;

	private static FFieldAddress SetActorLocation_NewLocation_PropertyAddress;

	private static int SetActorLocation_NewLocation_Offset;

	private static bool SetActorLocation_bSweep_IsValid;

	private static FFieldAddress SetActorLocation_bSweep_PropertyAddress;

	private static int SetActorLocation_bSweep_Offset;

	private static bool SetActorLocation_SweepHitResult_IsValid;

	private static FFieldAddress SetActorLocation_SweepHitResult_PropertyAddress;

	private static int SetActorLocation_SweepHitResult_Offset;

	private static bool SetActorLocation_bTeleport_IsValid;

	private static FFieldAddress SetActorLocation_bTeleport_PropertyAddress;

	private static int SetActorLocation_bTeleport_Offset;

	private static bool SetActorLocation_ReturnValue_IsValid;

	private static FFieldAddress SetActorLocation_ReturnValue_PropertyAddress;

	private static int SetActorLocation_ReturnValue_Offset;

	private static bool SetActorLabelUnique_IsValid;

	private static IntPtr SetActorLabelUnique_FunctionAddress;

	private static int SetActorLabelUnique_ParamsSize;

	private static bool SetActorLabelUnique_Actor_IsValid;

	private static FFieldAddress SetActorLabelUnique_Actor_PropertyAddress;

	private static int SetActorLabelUnique_Actor_Offset;

	private static bool SetActorLabelUnique_NewActorLabel_IsValid;

	private static FFieldAddress SetActorLabelUnique_NewActorLabel_PropertyAddress;

	private static int SetActorLabelUnique_NewActorLabel_Offset;

	private static bool SetActorLabelUnique_InExistingActorLabels_IsValid;

	private static FFieldAddress SetActorLabelUnique_InExistingActorLabels_PropertyAddress;

	private static int SetActorLabelUnique_InExistingActorLabels_Offset;

	private static bool SetActorLabel_IsValid;

	private static IntPtr SetActorLabel_FunctionAddress;

	private static int SetActorLabel_ParamsSize;

	private static bool SetActorLabel_Actor_IsValid;

	private static FFieldAddress SetActorLabel_Actor_PropertyAddress;

	private static int SetActorLabel_Actor_Offset;

	private static bool SetActorLabel_NewActorLabel_IsValid;

	private static FFieldAddress SetActorLabel_NewActorLabel_PropertyAddress;

	private static int SetActorLabel_NewActorLabel_Offset;

	private static bool SetActorLabel_bMarkDirty_IsValid;

	private static FFieldAddress SetActorLabel_bMarkDirty_PropertyAddress;

	private static int SetActorLabel_bMarkDirty_Offset;

	private static bool Select_IsValid;

	private static IntPtr Select_FunctionAddress;

	private static int Select_ParamsSize;

	private static bool Select_Selection_IsValid;

	private static FFieldAddress Select_Selection_PropertyAddress;

	private static int Select_Selection_Offset;

	private static bool Select_InObject_IsValid;

	private static FFieldAddress Select_InObject_PropertyAddress;

	private static int Select_InObject_Offset;

	private static bool SavePackage_IsValid;

	private static IntPtr SavePackage_FunctionAddress;

	private static int SavePackage_ParamsSize;

	private static bool SavePackage_Package_IsValid;

	private static FFieldAddress SavePackage_Package_PropertyAddress;

	private static int SavePackage_Package_Offset;

	private static bool SavePackage_FileName_IsValid;

	private static FFieldAddress SavePackage_FileName_PropertyAddress;

	private static int SavePackage_FileName_Offset;

	private static bool SavePackage_ReturnValue_IsValid;

	private static FFieldAddress SavePackage_ReturnValue_PropertyAddress;

	private static int SavePackage_ReturnValue_Offset;

	private static bool RequestEndPlayMapInPIE_IsValid;

	private static IntPtr RequestEndPlayMapInPIE_FunctionAddress;

	private static int RequestEndPlayMapInPIE_ParamsSize;

	private static bool ReplaceAnimNotifyClass_IsValid;

	private static IntPtr ReplaceAnimNotifyClass_FunctionAddress;

	private static int ReplaceAnimNotifyClass_ParamsSize;

	private static bool ReplaceAnimNotifyClass_Sequence_IsValid;

	private static FFieldAddress ReplaceAnimNotifyClass_Sequence_PropertyAddress;

	private static int ReplaceAnimNotifyClass_Sequence_Offset;

	private static bool ReplaceAnimNotifyClass_NotifyName_IsValid;

	private static FFieldAddress ReplaceAnimNotifyClass_NotifyName_PropertyAddress;

	private static int ReplaceAnimNotifyClass_NotifyName_Offset;

	private static bool ReplaceAnimNotifyClass_NewNotifyName_IsValid;

	private static FFieldAddress ReplaceAnimNotifyClass_NewNotifyName_PropertyAddress;

	private static int ReplaceAnimNotifyClass_NewNotifyName_Offset;

	private static bool ReplaceAnimNotifyClass_NewNotifyClass_IsValid;

	private static FFieldAddress ReplaceAnimNotifyClass_NewNotifyClass_PropertyAddress;

	private static int ReplaceAnimNotifyClass_NewNotifyClass_Offset;

	private static bool ReplaceAnimNotifyClass_ReturnValue_IsValid;

	private static FFieldAddress ReplaceAnimNotifyClass_ReturnValue_PropertyAddress;

	private static int ReplaceAnimNotifyClass_ReturnValue_Offset;

	private static bool RemoveLevelInstance_IsValid;

	private static IntPtr RemoveLevelInstance_FunctionAddress;

	private static int RemoveLevelInstance_ParamsSize;

	private static bool RemoveLevelInstance_World_IsValid;

	private static FFieldAddress RemoveLevelInstance_World_PropertyAddress;

	private static int RemoveLevelInstance_World_Offset;

	private static bool RemoveExtender_IsValid;

	private static IntPtr RemoveExtender_FunctionAddress;

	private static int RemoveExtender_ParamsSize;

	private static bool RemoveExtender_Manager_IsValid;

	private static FFieldAddress RemoveExtender_Manager_PropertyAddress;

	private static int RemoveExtender_Manager_Offset;

	private static bool RemoveExtender_Extender_IsValid;

	private static FFieldAddress RemoveExtender_Extender_PropertyAddress;

	private static int RemoveExtender_Extender_Offset;

	private static bool RemoveComponentFromBlueprint_IsValid;

	private static IntPtr RemoveComponentFromBlueprint_FunctionAddress;

	private static int RemoveComponentFromBlueprint_ParamsSize;

	private static bool RemoveComponentFromBlueprint_Blueprint_IsValid;

	private static FFieldAddress RemoveComponentFromBlueprint_Blueprint_PropertyAddress;

	private static int RemoveComponentFromBlueprint_Blueprint_Offset;

	private static bool RemoveComponentFromBlueprint_RemoveComponent_IsValid;

	private static FFieldAddress RemoveComponentFromBlueprint_RemoveComponent_PropertyAddress;

	private static int RemoveComponentFromBlueprint_RemoveComponent_Offset;

	private static bool RemoveComponentFromBlueprint_bPromoteChildren_IsValid;

	private static FFieldAddress RemoveComponentFromBlueprint_bPromoteChildren_PropertyAddress;

	private static int RemoveComponentFromBlueprint_bPromoteChildren_Offset;

	private static bool RemoveAllLazyExtender_IsValid;

	private static IntPtr RemoveAllLazyExtender_FunctionAddress;

	private static int RemoveAllLazyExtender_ParamsSize;

	private static bool RemoveAllLazyExtender_Manager_IsValid;

	private static FFieldAddress RemoveAllLazyExtender_Manager_PropertyAddress;

	private static int RemoveAllLazyExtender_Manager_Offset;

	private static bool PostEditChange_IsValid;

	private static IntPtr PostEditChange_FunctionAddress;

	private static int PostEditChange_ParamsSize;

	private static bool PostEditChange_InObject_IsValid;

	private static FFieldAddress PostEditChange_InObject_PropertyAddress;

	private static int PostEditChange_InObject_Offset;

	private static bool OpenPopupWindow_IsValid;

	private static IntPtr OpenPopupWindow_FunctionAddress;

	private static int OpenPopupWindow_ParamsSize;

	private static bool OpenPopupWindow_Widget_IsValid;

	private static FFieldAddress OpenPopupWindow_Widget_PropertyAddress;

	private static int OpenPopupWindow_Widget_Offset;

	private static bool OpenPopupWindow_PopupDesiredSize_IsValid;

	private static FFieldAddress OpenPopupWindow_PopupDesiredSize_PropertyAddress;

	private static int OpenPopupWindow_PopupDesiredSize_Offset;

	private static bool OpenPopupWindow_HeadingText_IsValid;

	private static FFieldAddress OpenPopupWindow_HeadingText_PropertyAddress;

	private static int OpenPopupWindow_HeadingText_Offset;

	private static bool OpenFileDialog_IsValid;

	private static IntPtr OpenFileDialog_FunctionAddress;

	private static int OpenFileDialog_ParamsSize;

	private static bool OpenFileDialog_WindowHandle_IsValid;

	private static FFieldAddress OpenFileDialog_WindowHandle_PropertyAddress;

	private static int OpenFileDialog_WindowHandle_Offset;

	private static bool OpenFileDialog_DialogTitle_IsValid;

	private static FFieldAddress OpenFileDialog_DialogTitle_PropertyAddress;

	private static int OpenFileDialog_DialogTitle_Offset;

	private static bool OpenFileDialog_DefaultPath_IsValid;

	private static FFieldAddress OpenFileDialog_DefaultPath_PropertyAddress;

	private static int OpenFileDialog_DefaultPath_Offset;

	private static bool OpenFileDialog_DefaultFile_IsValid;

	private static FFieldAddress OpenFileDialog_DefaultFile_PropertyAddress;

	private static int OpenFileDialog_DefaultFile_Offset;

	private static bool OpenFileDialog_FileTypes_IsValid;

	private static FFieldAddress OpenFileDialog_FileTypes_PropertyAddress;

	private static int OpenFileDialog_FileTypes_Offset;

	private static bool OpenFileDialog_Flags_IsValid;

	private static FFieldAddress OpenFileDialog_Flags_PropertyAddress;

	private static int OpenFileDialog_Flags_Offset;

	private static bool OpenFileDialog_OutFilenames_IsValid;

	private static FFieldAddress OpenFileDialog_OutFilenames_PropertyAddress;

	private static int OpenFileDialog_OutFilenames_Offset;

	private static bool OpenFileDialog_ReturnValue_IsValid;

	private static FFieldAddress OpenFileDialog_ReturnValue_PropertyAddress;

	private static int OpenFileDialog_ReturnValue_Offset;

	private static bool OpenEditorForAssetByPath_IsValid;

	private static IntPtr OpenEditorForAssetByPath_FunctionAddress;

	private static int OpenEditorForAssetByPath_ParamsSize;

	private static bool OpenEditorForAssetByPath_AssetPathName_IsValid;

	private static FFieldAddress OpenEditorForAssetByPath_AssetPathName_PropertyAddress;

	private static int OpenEditorForAssetByPath_AssetPathName_Offset;

	private static bool OpenEditorForAssetByPath_ObjectName_IsValid;

	private static FFieldAddress OpenEditorForAssetByPath_ObjectName_PropertyAddress;

	private static int OpenEditorForAssetByPath_ObjectName_Offset;

	private static bool OpenEditorForAsset_IsValid;

	private static IntPtr OpenEditorForAsset_FunctionAddress;

	private static int OpenEditorForAsset_ParamsSize;

	private static bool OpenEditorForAsset_Asset_IsValid;

	private static FFieldAddress OpenEditorForAsset_Asset_PropertyAddress;

	private static int OpenEditorForAsset_Asset_Offset;

	private static bool OpenEditorForAsset_ReturnValue_IsValid;

	private static FFieldAddress OpenEditorForAsset_ReturnValue_PropertyAddress;

	private static int OpenEditorForAsset_ReturnValue_Offset;

	private static bool OpenDirectoryDialog_IsValid;

	private static IntPtr OpenDirectoryDialog_FunctionAddress;

	private static int OpenDirectoryDialog_ParamsSize;

	private static bool OpenDirectoryDialog_WindowHandle_IsValid;

	private static FFieldAddress OpenDirectoryDialog_WindowHandle_PropertyAddress;

	private static int OpenDirectoryDialog_WindowHandle_Offset;

	private static bool OpenDirectoryDialog_DialogTitle_IsValid;

	private static FFieldAddress OpenDirectoryDialog_DialogTitle_PropertyAddress;

	private static int OpenDirectoryDialog_DialogTitle_Offset;

	private static bool OpenDirectoryDialog_DefaultPath_IsValid;

	private static FFieldAddress OpenDirectoryDialog_DefaultPath_PropertyAddress;

	private static int OpenDirectoryDialog_DefaultPath_Offset;

	private static bool OpenDirectoryDialog_OutFolderName_IsValid;

	private static FFieldAddress OpenDirectoryDialog_OutFolderName_PropertyAddress;

	private static int OpenDirectoryDialog_OutFolderName_Offset;

	private static bool OpenDirectoryDialog_ReturnValue_IsValid;

	private static FFieldAddress OpenDirectoryDialog_ReturnValue_PropertyAddress;

	private static int OpenDirectoryDialog_ReturnValue_Offset;

	private static bool ModifyObject_IsValid;

	private static IntPtr ModifyObject_FunctionAddress;

	private static int ModifyObject_ParamsSize;

	private static bool ModifyObject_Object_IsValid;

	private static FFieldAddress ModifyObject_Object_PropertyAddress;

	private static int ModifyObject_Object_Offset;

	private static bool ModifyObject_bAlwaysMarkDirty_IsValid;

	private static FFieldAddress ModifyObject_bAlwaysMarkDirty_PropertyAddress;

	private static int ModifyObject_bAlwaysMarkDirty_Offset;

	private static bool MarkPackageDirty_IsValid;

	private static IntPtr MarkPackageDirty_FunctionAddress;

	private static int MarkPackageDirty_ParamsSize;

	private static bool MarkPackageDirty_InObject_IsValid;

	private static FFieldAddress MarkPackageDirty_InObject_PropertyAddress;

	private static int MarkPackageDirty_InObject_Offset;

	private static bool MarkPackageDirty_ReturnValue_IsValid;

	private static FFieldAddress MarkPackageDirty_ReturnValue_PropertyAddress;

	private static int MarkPackageDirty_ReturnValue_Offset;

	private static bool LoadImageFromDiskAsync_IsValid;

	private static IntPtr LoadImageFromDiskAsync_FunctionAddress;

	private static int LoadImageFromDiskAsync_ParamsSize;

	private static bool LoadImageFromDiskAsync_ImagePath_IsValid;

	private static FFieldAddress LoadImageFromDiskAsync_ImagePath_PropertyAddress;

	private static int LoadImageFromDiskAsync_ImagePath_Offset;

	private static bool LoadImageFromDiskAsync_Callback_IsValid;

	private static FFieldAddress LoadImageFromDiskAsync_Callback_PropertyAddress;

	private static int LoadImageFromDiskAsync_Callback_Offset;

	private static bool LoadImageFromDiskAsync_ReturnValue_IsValid;

	private static FFieldAddress LoadImageFromDiskAsync_ReturnValue_PropertyAddress;

	private static int LoadImageFromDiskAsync_ReturnValue_Offset;

	private static bool LoadFileToString_IsValid;

	private static IntPtr LoadFileToString_FunctionAddress;

	private static int LoadFileToString_ParamsSize;

	private static bool LoadFileToString_Path_IsValid;

	private static FFieldAddress LoadFileToString_Path_PropertyAddress;

	private static int LoadFileToString_Path_Offset;

	private static bool LoadFileToString_Data_IsValid;

	private static FFieldAddress LoadFileToString_Data_PropertyAddress;

	private static int LoadFileToString_Data_Offset;

	private static bool LoadFileToString_ReturnValue_IsValid;

	private static FFieldAddress LoadFileToString_ReturnValue_PropertyAddress;

	private static int LoadFileToString_ReturnValue_Offset;

	private static bool LoadFileToIntArray_IsValid;

	private static IntPtr LoadFileToIntArray_FunctionAddress;

	private static int LoadFileToIntArray_ParamsSize;

	private static bool LoadFileToIntArray_Path_IsValid;

	private static FFieldAddress LoadFileToIntArray_Path_PropertyAddress;

	private static int LoadFileToIntArray_Path_Offset;

	private static bool LoadFileToIntArray_FileData_IsValid;

	private static FFieldAddress LoadFileToIntArray_FileData_PropertyAddress;

	private static int LoadFileToIntArray_FileData_Offset;

	private static bool LoadFileToIntArray_ReturnValue_IsValid;

	private static FFieldAddress LoadFileToIntArray_ReturnValue_PropertyAddress;

	private static int LoadFileToIntArray_ReturnValue_Offset;

	private static bool IsShiftDown_IsValid;

	private static IntPtr IsShiftDown_FunctionAddress;

	private static int IsShiftDown_ParamsSize;

	private static bool IsShiftDown_Click_IsValid;

	private static FFieldAddress IsShiftDown_Click_PropertyAddress;

	private static int IsShiftDown_Click_Offset;

	private static bool IsShiftDown_ReturnValue_IsValid;

	private static FFieldAddress IsShiftDown_ReturnValue_PropertyAddress;

	private static int IsShiftDown_ReturnValue_Offset;

	private static bool IsControlDown_IsValid;

	private static IntPtr IsControlDown_FunctionAddress;

	private static int IsControlDown_ParamsSize;

	private static bool IsControlDown_Click_IsValid;

	private static FFieldAddress IsControlDown_Click_PropertyAddress;

	private static int IsControlDown_Click_Offset;

	private static bool IsControlDown_ReturnValue_IsValid;

	private static FFieldAddress IsControlDown_ReturnValue_PropertyAddress;

	private static int IsControlDown_ReturnValue_Offset;

	private static bool IsAssetLoaded_IsValid;

	private static IntPtr IsAssetLoaded_FunctionAddress;

	private static int IsAssetLoaded_ParamsSize;

	private static bool IsAssetLoaded_AssetData_IsValid;

	private static FFieldAddress IsAssetLoaded_AssetData_PropertyAddress;

	private static int IsAssetLoaded_AssetData_Offset;

	private static bool IsAssetLoaded_ReturnValue_IsValid;

	private static FFieldAddress IsAssetLoaded_ReturnValue_PropertyAddress;

	private static int IsAssetLoaded_ReturnValue_Offset;

	private static bool IsAltDown_IsValid;

	private static IntPtr IsAltDown_FunctionAddress;

	private static int IsAltDown_ParamsSize;

	private static bool IsAltDown_Click_IsValid;

	private static FFieldAddress IsAltDown_Click_PropertyAddress;

	private static int IsAltDown_Click_Offset;

	private static bool IsAltDown_ReturnValue_IsValid;

	private static FFieldAddress IsAltDown_ReturnValue_PropertyAddress;

	private static int IsAltDown_ReturnValue_Offset;

	private static bool IsActorLabelEditable_IsValid;

	private static IntPtr IsActorLabelEditable_FunctionAddress;

	private static int IsActorLabelEditable_ParamsSize;

	private static bool IsActorLabelEditable_Actor_IsValid;

	private static FFieldAddress IsActorLabelEditable_Actor_PropertyAddress;

	private static int IsActorLabelEditable_Actor_Offset;

	private static bool IsActorLabelEditable_ReturnValue_IsValid;

	private static FFieldAddress IsActorLabelEditable_ReturnValue_PropertyAddress;

	private static int IsActorLabelEditable_ReturnValue_Offset;

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_Transactor_IsValid;

	private static FFieldAddress IsActive_Transactor_PropertyAddress;

	private static int IsActive_Transactor_Offset;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool InvalidateModelGeometry_IsValid;

	private static IntPtr InvalidateModelGeometry_FunctionAddress;

	private static int InvalidateModelGeometry_ParamsSize;

	private static bool InvalidateModelGeometry_World_IsValid;

	private static FFieldAddress InvalidateModelGeometry_World_PropertyAddress;

	private static int InvalidateModelGeometry_World_Offset;

	private static bool InvalidateModelGeometry_InLevel_IsValid;

	private static FFieldAddress InvalidateModelGeometry_InLevel_PropertyAddress;

	private static int InvalidateModelGeometry_InLevel_Offset;

	private static bool HasMetaData_IsValid;

	private static IntPtr HasMetaData_FunctionAddress;

	private static int HasMetaData_ParamsSize;

	private static bool HasMetaData_Field_IsValid;

	private static FFieldAddress HasMetaData_Field_PropertyAddress;

	private static int HasMetaData_Field_Offset;

	private static bool HasMetaData_Key_IsValid;

	private static FFieldAddress HasMetaData_Key_PropertyAddress;

	private static int HasMetaData_Key_Offset;

	private static bool HasMetaData_ReturnValue_IsValid;

	private static FFieldAddress HasMetaData_ReturnValue_PropertyAddress;

	private static int HasMetaData_ReturnValue_Offset;

	private static bool GetUniqueID_IsValid;

	private static IntPtr GetUniqueID_FunctionAddress;

	private static int GetUniqueID_ParamsSize;

	private static bool GetUniqueID_InObject_IsValid;

	private static FFieldAddress GetUniqueID_InObject_PropertyAddress;

	private static int GetUniqueID_InObject_Offset;

	private static bool GetUniqueID_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueID_ReturnValue_PropertyAddress;

	private static int GetUniqueID_ReturnValue_Offset;

	private static bool GetTransaction_IsValid;

	private static IntPtr GetTransaction_FunctionAddress;

	private static int GetTransaction_ParamsSize;

	private static bool GetTransaction_Transactor_IsValid;

	private static FFieldAddress GetTransaction_Transactor_PropertyAddress;

	private static int GetTransaction_Transactor_Offset;

	private static bool GetTransaction_QueueIndex_IsValid;

	private static FFieldAddress GetTransaction_QueueIndex_PropertyAddress;

	private static int GetTransaction_QueueIndex_Offset;

	private static bool GetTransaction_ReturnValue_IsValid;

	private static FFieldAddress GetTransaction_ReturnValue_PropertyAddress;

	private static int GetTransaction_ReturnValue_Offset;

	private static bool GetToolBarExtensibilityManager_IsValid;

	private static IntPtr GetToolBarExtensibilityManager_FunctionAddress;

	private static int GetToolBarExtensibilityManager_ParamsSize;

	private static bool GetToolBarExtensibilityManager_What_IsValid;

	private static FFieldAddress GetToolBarExtensibilityManager_What_PropertyAddress;

	private static int GetToolBarExtensibilityManager_What_Offset;

	private static bool GetToolBarExtensibilityManager_ReturnValue_IsValid;

	private static FFieldAddress GetToolBarExtensibilityManager_ReturnValue_PropertyAddress;

	private static int GetToolBarExtensibilityManager_ReturnValue_Offset;

	private static bool GetTitle_IsValid;

	private static IntPtr GetTitle_FunctionAddress;

	private static int GetTitle_ParamsSize;

	private static bool GetTitle_Transaction_IsValid;

	private static FFieldAddress GetTitle_Transaction_PropertyAddress;

	private static int GetTitle_Transaction_Offset;

	private static bool GetTitle_ReturnValue_IsValid;

	private static FFieldAddress GetTitle_ReturnValue_PropertyAddress;

	private static int GetTitle_ReturnValue_Offset;

	private static bool GetTagValue_IsValid;

	private static IntPtr GetTagValue_FunctionAddress;

	private static int GetTagValue_ParamsSize;

	private static bool GetTagValue_AssetData_IsValid;

	private static FFieldAddress GetTagValue_AssetData_PropertyAddress;

	private static int GetTagValue_AssetData_Offset;

	private static bool GetTagValue_Name_IsValid;

	private static FFieldAddress GetTagValue_Name_PropertyAddress;

	private static int GetTagValue_Name_Offset;

	private static bool GetTagValue_OutValue_IsValid;

	private static FFieldAddress GetTagValue_OutValue_PropertyAddress;

	private static int GetTagValue_OutValue_Offset;

	private static bool GetTagValue_ReturnValue_IsValid;

	private static FFieldAddress GetTagValue_ReturnValue_PropertyAddress;

	private static int GetTagValue_ReturnValue_Offset;

	private static bool GetSelectedObjects_IsValid;

	private static IntPtr GetSelectedObjects_FunctionAddress;

	private static int GetSelectedObjects_ParamsSize;

	private static bool GetSelectedObjects_Selection_IsValid;

	private static FFieldAddress GetSelectedObjects_Selection_PropertyAddress;

	private static int GetSelectedObjects_Selection_Offset;

	private static bool GetSelectedObjects_Out_IsValid;

	private static FFieldAddress GetSelectedObjects_Out_PropertyAddress;

	private static int GetSelectedObjects_Out_Offset;

	private static bool GetSelectedObjects_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedObjects_ReturnValue_PropertyAddress;

	private static int GetSelectedObjects_ReturnValue_Offset;

	private static bool GetRootWindow_IsValid;

	private static IntPtr GetRootWindow_FunctionAddress;

	private static int GetRootWindow_ParamsSize;

	private static bool GetRootWindow_ReturnValue_IsValid;

	private static FFieldAddress GetRootWindow_ReturnValue_PropertyAddress;

	private static int GetRootWindow_ReturnValue_Offset;

	private static bool GetQueueLength_IsValid;

	private static IntPtr GetQueueLength_FunctionAddress;

	private static int GetQueueLength_ParamsSize;

	private static bool GetQueueLength_Transactor_IsValid;

	private static FFieldAddress GetQueueLength_Transactor_PropertyAddress;

	private static int GetQueueLength_Transactor_Offset;

	private static bool GetQueueLength_ReturnValue_IsValid;

	private static FFieldAddress GetQueueLength_ReturnValue_PropertyAddress;

	private static int GetQueueLength_ReturnValue_Offset;

	private static bool GetPrimaryObject_IsValid;

	private static IntPtr GetPrimaryObject_FunctionAddress;

	private static int GetPrimaryObject_ParamsSize;

	private static bool GetPrimaryObject_Transaction_IsValid;

	private static FFieldAddress GetPrimaryObject_Transaction_PropertyAddress;

	private static int GetPrimaryObject_Transaction_Offset;

	private static bool GetPrimaryObject_ReturnValue_IsValid;

	private static FFieldAddress GetPrimaryObject_ReturnValue_PropertyAddress;

	private static int GetPrimaryObject_ReturnValue_Offset;

	private static bool GetParentClassOfBlueprint_IsValid;

	private static IntPtr GetParentClassOfBlueprint_FunctionAddress;

	private static int GetParentClassOfBlueprint_ParamsSize;

	private static bool GetParentClassOfBlueprint_Blueprint_IsValid;

	private static FFieldAddress GetParentClassOfBlueprint_Blueprint_PropertyAddress;

	private static int GetParentClassOfBlueprint_Blueprint_Offset;

	private static bool GetParentClassOfBlueprint_ReturnValue_IsValid;

	private static FFieldAddress GetParentClassOfBlueprint_ReturnValue_PropertyAddress;

	private static int GetParentClassOfBlueprint_ReturnValue_Offset;

	private static bool GetPackage_IsValid;

	private static IntPtr GetPackage_FunctionAddress;

	private static int GetPackage_ParamsSize;

	private static bool GetPackage_AssetData_IsValid;

	private static FFieldAddress GetPackage_AssetData_PropertyAddress;

	private static int GetPackage_AssetData_Offset;

	private static bool GetPackage_ReturnValue_IsValid;

	private static FFieldAddress GetPackage_ReturnValue_PropertyAddress;

	private static int GetPackage_ReturnValue_Offset;

	private static bool GetOrigin_IsValid;

	private static IntPtr GetOrigin_FunctionAddress;

	private static int GetOrigin_ParamsSize;

	private static bool GetOrigin_Click_IsValid;

	private static FFieldAddress GetOrigin_Click_PropertyAddress;

	private static int GetOrigin_Click_Offset;

	private static bool GetOrigin_ReturnValue_IsValid;

	private static FFieldAddress GetOrigin_ReturnValue_PropertyAddress;

	private static int GetOrigin_ReturnValue_Offset;

	private static bool GetName_IsValid;

	private static IntPtr GetName_FunctionAddress;

	private static int GetName_ParamsSize;

	private static bool GetName_Proxy_IsValid;

	private static FFieldAddress GetName_Proxy_PropertyAddress;

	private static int GetName_Proxy_Offset;

	private static bool GetName_ReturnValue_IsValid;

	private static FFieldAddress GetName_ReturnValue_PropertyAddress;

	private static int GetName_ReturnValue_Offset;

	private static bool GetMenuExtensibilityManager_IsValid;

	private static IntPtr GetMenuExtensibilityManager_FunctionAddress;

	private static int GetMenuExtensibilityManager_ParamsSize;

	private static bool GetMenuExtensibilityManager_What_IsValid;

	private static FFieldAddress GetMenuExtensibilityManager_What_PropertyAddress;

	private static int GetMenuExtensibilityManager_What_Offset;

	private static bool GetMenuExtensibilityManager_ReturnValue_IsValid;

	private static FFieldAddress GetMenuExtensibilityManager_ReturnValue_PropertyAddress;

	private static int GetMenuExtensibilityManager_ReturnValue_Offset;

	private static bool GetLevelEditorActions_IsValid;

	private static IntPtr GetLevelEditorActions_FunctionAddress;

	private static int GetLevelEditorActions_ParamsSize;

	private static bool GetLevelEditorActions_ReturnValue_IsValid;

	private static FFieldAddress GetLevelEditorActions_ReturnValue_PropertyAddress;

	private static int GetLevelEditorActions_ReturnValue_Offset;

	private static bool GetLayerInfoByName_IsValid;

	private static IntPtr GetLayerInfoByName_FunctionAddress;

	private static int GetLayerInfoByName_ParamsSize;

	private static bool GetLayerInfoByName_LandscapeInfo_IsValid;

	private static FFieldAddress GetLayerInfoByName_LandscapeInfo_PropertyAddress;

	private static int GetLayerInfoByName_LandscapeInfo_Offset;

	private static bool GetLayerInfoByName_LayerName_IsValid;

	private static FFieldAddress GetLayerInfoByName_LayerName_PropertyAddress;

	private static int GetLayerInfoByName_LayerName_Offset;

	private static bool GetLayerInfoByName_Owner_IsValid;

	private static FFieldAddress GetLayerInfoByName_Owner_PropertyAddress;

	private static int GetLayerInfoByName_Owner_Offset;

	private static bool GetLayerInfoByName_ReturnValue_IsValid;

	private static FFieldAddress GetLayerInfoByName_ReturnValue_PropertyAddress;

	private static int GetLayerInfoByName_ReturnValue_Offset;

	private static bool GetLandscapeInfo_IsValid;

	private static IntPtr GetLandscapeInfo_FunctionAddress;

	private static int GetLandscapeInfo_ParamsSize;

	private static bool GetLandscapeInfo_Landscape_IsValid;

	private static FFieldAddress GetLandscapeInfo_Landscape_PropertyAddress;

	private static int GetLandscapeInfo_Landscape_Offset;

	private static bool GetLandscapeInfo_bSpawnNewActor_IsValid;

	private static FFieldAddress GetLandscapeInfo_bSpawnNewActor_PropertyAddress;

	private static int GetLandscapeInfo_bSpawnNewActor_Offset;

	private static bool GetLandscapeInfo_ReturnValue_IsValid;

	private static FFieldAddress GetLandscapeInfo_ReturnValue_PropertyAddress;

	private static int GetLandscapeInfo_ReturnValue_Offset;

	private static bool GetLandscapeExtent_IsValid;

	private static IntPtr GetLandscapeExtent_FunctionAddress;

	private static int GetLandscapeExtent_ParamsSize;

	private static bool GetLandscapeExtent_LandscapeInfo_IsValid;

	private static FFieldAddress GetLandscapeExtent_LandscapeInfo_PropertyAddress;

	private static int GetLandscapeExtent_LandscapeInfo_Offset;

	private static bool GetLandscapeExtent_MinX_IsValid;

	private static FFieldAddress GetLandscapeExtent_MinX_PropertyAddress;

	private static int GetLandscapeExtent_MinX_Offset;

	private static bool GetLandscapeExtent_MinY_IsValid;

	private static FFieldAddress GetLandscapeExtent_MinY_PropertyAddress;

	private static int GetLandscapeExtent_MinY_Offset;

	private static bool GetLandscapeExtent_MaxX_IsValid;

	private static FFieldAddress GetLandscapeExtent_MaxX_PropertyAddress;

	private static int GetLandscapeExtent_MaxX_Offset;

	private static bool GetLandscapeExtent_MaxY_IsValid;

	private static FFieldAddress GetLandscapeExtent_MaxY_PropertyAddress;

	private static int GetLandscapeExtent_MaxY_Offset;

	private static bool GetLandscapeExtent_ReturnValue_IsValid;

	private static FFieldAddress GetLandscapeExtent_ReturnValue_PropertyAddress;

	private static int GetLandscapeExtent_ReturnValue_Offset;

	private static bool GetKeyNameByKeyEvent_IsValid;

	private static IntPtr GetKeyNameByKeyEvent_FunctionAddress;

	private static int GetKeyNameByKeyEvent_ParamsSize;

	private static bool GetKeyNameByKeyEvent_Event_IsValid;

	private static FFieldAddress GetKeyNameByKeyEvent_Event_PropertyAddress;

	private static int GetKeyNameByKeyEvent_Event_Offset;

	private static bool GetKeyNameByKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetKeyNameByKeyEvent_ReturnValue_PropertyAddress;

	private static int GetKeyNameByKeyEvent_ReturnValue_Offset;

	private static bool GetKey_IsValid;

	private static IntPtr GetKey_FunctionAddress;

	private static int GetKey_ParamsSize;

	private static bool GetKey_Click_IsValid;

	private static FFieldAddress GetKey_Click_PropertyAddress;

	private static int GetKey_Click_Offset;

	private static bool GetKey_ReturnValue_IsValid;

	private static FFieldAddress GetKey_ReturnValue_PropertyAddress;

	private static int GetKey_ReturnValue_Offset;

	private static bool GetIsShiftDownByKeyEvent_IsValid;

	private static IntPtr GetIsShiftDownByKeyEvent_FunctionAddress;

	private static int GetIsShiftDownByKeyEvent_ParamsSize;

	private static bool GetIsShiftDownByKeyEvent_Event_IsValid;

	private static FFieldAddress GetIsShiftDownByKeyEvent_Event_PropertyAddress;

	private static int GetIsShiftDownByKeyEvent_Event_Offset;

	private static bool GetIsShiftDownByKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetIsShiftDownByKeyEvent_ReturnValue_PropertyAddress;

	private static int GetIsShiftDownByKeyEvent_ReturnValue_Offset;

	private static bool GetIsExecuteTestModePIE_IsValid;

	private static IntPtr GetIsExecuteTestModePIE_FunctionAddress;

	private static int GetIsExecuteTestModePIE_ParamsSize;

	private static bool GetIsExecuteTestModePIE_ReturnValue_IsValid;

	private static FFieldAddress GetIsExecuteTestModePIE_ReturnValue_PropertyAddress;

	private static int GetIsExecuteTestModePIE_ReturnValue_Offset;

	private static bool GetIsControlDownByKeyEvent_IsValid;

	private static IntPtr GetIsControlDownByKeyEvent_FunctionAddress;

	private static int GetIsControlDownByKeyEvent_ParamsSize;

	private static bool GetIsControlDownByKeyEvent_Event_IsValid;

	private static FFieldAddress GetIsControlDownByKeyEvent_Event_PropertyAddress;

	private static int GetIsControlDownByKeyEvent_Event_Offset;

	private static bool GetIsControlDownByKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetIsControlDownByKeyEvent_ReturnValue_PropertyAddress;

	private static int GetIsControlDownByKeyEvent_ReturnValue_Offset;

	private static bool GetIsAltDownByKeyEvent_IsValid;

	private static IntPtr GetIsAltDownByKeyEvent_FunctionAddress;

	private static int GetIsAltDownByKeyEvent_ParamsSize;

	private static bool GetIsAltDownByKeyEvent_Event_IsValid;

	private static FFieldAddress GetIsAltDownByKeyEvent_Event_PropertyAddress;

	private static int GetIsAltDownByKeyEvent_Event_Offset;

	private static bool GetIsAltDownByKeyEvent_ReturnValue_IsValid;

	private static FFieldAddress GetIsAltDownByKeyEvent_ReturnValue_PropertyAddress;

	private static int GetIsAltDownByKeyEvent_ReturnValue_Offset;

	private static bool GetHeightmapDataToMemory_IsValid;

	private static IntPtr GetHeightmapDataToMemory_FunctionAddress;

	private static int GetHeightmapDataToMemory_ParamsSize;

	private static bool GetHeightmapDataToMemory_LandscapeInfo_IsValid;

	private static FFieldAddress GetHeightmapDataToMemory_LandscapeInfo_PropertyAddress;

	private static int GetHeightmapDataToMemory_LandscapeInfo_Offset;

	private static bool GetHeightmapDataToMemory_MinX_IsValid;

	private static FFieldAddress GetHeightmapDataToMemory_MinX_PropertyAddress;

	private static int GetHeightmapDataToMemory_MinX_Offset;

	private static bool GetHeightmapDataToMemory_MinY_IsValid;

	private static FFieldAddress GetHeightmapDataToMemory_MinY_PropertyAddress;

	private static int GetHeightmapDataToMemory_MinY_Offset;

	private static bool GetHeightmapDataToMemory_MaxX_IsValid;

	private static FFieldAddress GetHeightmapDataToMemory_MaxX_PropertyAddress;

	private static int GetHeightmapDataToMemory_MaxX_Offset;

	private static bool GetHeightmapDataToMemory_MaxY_IsValid;

	private static FFieldAddress GetHeightmapDataToMemory_MaxY_PropertyAddress;

	private static int GetHeightmapDataToMemory_MaxY_Offset;

	private static bool GetGroup_IsValid;

	private static IntPtr GetGroup_FunctionAddress;

	private static int GetGroup_ParamsSize;

	private static bool GetGroup_Name_IsValid;

	private static FFieldAddress GetGroup_Name_PropertyAddress;

	private static int GetGroup_Name_Offset;

	private static bool GetGroup_ReturnValue_IsValid;

	private static FFieldAddress GetGroup_ReturnValue_PropertyAddress;

	private static int GetGroup_ReturnValue_Offset;

	private static bool GetFolderPath_IsValid;

	private static IntPtr GetFolderPath_FunctionAddress;

	private static int GetFolderPath_ParamsSize;

	private static bool GetFolderPath_Actor_IsValid;

	private static FFieldAddress GetFolderPath_Actor_PropertyAddress;

	private static int GetFolderPath_Actor_Offset;

	private static bool GetFolderPath_ReturnValue_IsValid;

	private static FFieldAddress GetFolderPath_ReturnValue_PropertyAddress;

	private static int GetFolderPath_ReturnValue_Offset;

	private static bool GetEvent_IsValid;

	private static IntPtr GetEvent_FunctionAddress;

	private static int GetEvent_ParamsSize;

	private static bool GetEvent_Click_IsValid;

	private static FFieldAddress GetEvent_Click_PropertyAddress;

	private static int GetEvent_Click_Offset;

	private static bool GetEvent_ReturnValue_IsValid;

	private static FFieldAddress GetEvent_ReturnValue_PropertyAddress;

	private static int GetEvent_ReturnValue_Offset;

	private static bool GetEngine_IsValid;

	private static IntPtr GetEngine_FunctionAddress;

	private static int GetEngine_ParamsSize;

	private static bool GetEngine_ReturnValue_IsValid;

	private static FFieldAddress GetEngine_ReturnValue_PropertyAddress;

	private static int GetEngine_ReturnValue_Offset;

	private static bool GetEditorPlayWorld_IsValid;

	private static IntPtr GetEditorPlayWorld_FunctionAddress;

	private static int GetEditorPlayWorld_ParamsSize;

	private static bool GetEditorPlayWorld_ReturnValue_IsValid;

	private static FFieldAddress GetEditorPlayWorld_ReturnValue_PropertyAddress;

	private static int GetEditorPlayWorld_ReturnValue_Offset;

	private static bool GetDirection_IsValid;

	private static IntPtr GetDirection_FunctionAddress;

	private static int GetDirection_ParamsSize;

	private static bool GetDirection_Click_IsValid;

	private static FFieldAddress GetDirection_Click_PropertyAddress;

	private static int GetDirection_Click_Offset;

	private static bool GetDirection_ReturnValue_IsValid;

	private static FFieldAddress GetDirection_ReturnValue_PropertyAddress;

	private static int GetDirection_ReturnValue_Offset;

	private static bool GetDefaultBrush_IsValid;

	private static IntPtr GetDefaultBrush_FunctionAddress;

	private static int GetDefaultBrush_ParamsSize;

	private static bool GetDefaultBrush_World_IsValid;

	private static FFieldAddress GetDefaultBrush_World_PropertyAddress;

	private static int GetDefaultBrush_World_Offset;

	private static bool GetDefaultBrush_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultBrush_ReturnValue_PropertyAddress;

	private static int GetDefaultBrush_ReturnValue_Offset;

	private static bool GetDataTableAsJSON_IsValid;

	private static IntPtr GetDataTableAsJSON_FunctionAddress;

	private static int GetDataTableAsJSON_ParamsSize;

	private static bool GetDataTableAsJSON_InDataTable_IsValid;

	private static FFieldAddress GetDataTableAsJSON_InDataTable_PropertyAddress;

	private static int GetDataTableAsJSON_InDataTable_Offset;

	private static bool GetDataTableAsJSON_InDTExportFlags_IsValid;

	private static FFieldAddress GetDataTableAsJSON_InDTExportFlags_PropertyAddress;

	private static int GetDataTableAsJSON_InDTExportFlags_Offset;

	private static bool GetDataTableAsJSON_ReturnValue_IsValid;

	private static FFieldAddress GetDataTableAsJSON_ReturnValue_PropertyAddress;

	private static int GetDataTableAsJSON_ReturnValue_Offset;

	private static bool GetContext_IsValid;

	private static IntPtr GetContext_FunctionAddress;

	private static int GetContext_ParamsSize;

	private static bool GetContext_Transaction_IsValid;

	private static FFieldAddress GetContext_Transaction_PropertyAddress;

	private static int GetContext_Transaction_Offset;

	private static bool GetContext_ReturnValue_IsValid;

	private static FFieldAddress GetContext_ReturnValue_PropertyAddress;

	private static int GetContext_ReturnValue_Offset;

	private static bool GetClickPos_IsValid;

	private static IntPtr GetClickPos_FunctionAddress;

	private static int GetClickPos_ParamsSize;

	private static bool GetClickPos_Click_IsValid;

	private static FFieldAddress GetClickPos_Click_PropertyAddress;

	private static int GetClickPos_Click_Offset;

	private static bool GetClickPos_ReturnValue_IsValid;

	private static FFieldAddress GetClickPos_ReturnValue_PropertyAddress;

	private static int GetClickPos_ReturnValue_Offset;

	private static bool GetClass_IsValid;

	private static IntPtr GetClass_FunctionAddress;

	private static int GetClass_ParamsSize;

	private static bool GetClass_AssetData_IsValid;

	private static FFieldAddress GetClass_AssetData_PropertyAddress;

	private static int GetClass_AssetData_Offset;

	private static bool GetClass_ReturnValue_IsValid;

	private static FFieldAddress GetClass_ReturnValue_PropertyAddress;

	private static int GetClass_ReturnValue_Offset;

	private static bool GetAssetsByType_IsValid;

	private static IntPtr GetAssetsByType_FunctionAddress;

	private static int GetAssetsByType_ParamsSize;

	private static bool GetAssetsByType_Types_IsValid;

	private static FFieldAddress GetAssetsByType_Types_PropertyAddress;

	private static int GetAssetsByType_Types_Offset;

	private static bool GetAssetsByType_bRecursiveClasses_IsValid;

	private static FFieldAddress GetAssetsByType_bRecursiveClasses_PropertyAddress;

	private static int GetAssetsByType_bRecursiveClasses_Offset;

	private static bool GetAssetsByType_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByType_ReturnValue_PropertyAddress;

	private static int GetAssetsByType_ReturnValue_Offset;

	private static bool GetAsset_IsValid;

	private static IntPtr GetAsset_FunctionAddress;

	private static int GetAsset_ParamsSize;

	private static bool GetAsset_AssetData_IsValid;

	private static FFieldAddress GetAsset_AssetData_PropertyAddress;

	private static int GetAsset_AssetData_Offset;

	private static bool GetAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAsset_ReturnValue_PropertyAddress;

	private static int GetAsset_ReturnValue_Offset;

	private static bool GetAlphamapDataToMemory_IsValid;

	private static IntPtr GetAlphamapDataToMemory_FunctionAddress;

	private static int GetAlphamapDataToMemory_ParamsSize;

	private static bool GetAlphamapDataToMemory_LandscapeInfo_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_LandscapeInfo_PropertyAddress;

	private static int GetAlphamapDataToMemory_LandscapeInfo_Offset;

	private static bool GetAlphamapDataToMemory_LayerInfo_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_LayerInfo_PropertyAddress;

	private static int GetAlphamapDataToMemory_LayerInfo_Offset;

	private static bool GetAlphamapDataToMemory_MinX_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_MinX_PropertyAddress;

	private static int GetAlphamapDataToMemory_MinX_Offset;

	private static bool GetAlphamapDataToMemory_MinY_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_MinY_PropertyAddress;

	private static int GetAlphamapDataToMemory_MinY_Offset;

	private static bool GetAlphamapDataToMemory_MaxX_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_MaxX_PropertyAddress;

	private static int GetAlphamapDataToMemory_MaxX_Offset;

	private static bool GetAlphamapDataToMemory_MaxY_IsValid;

	private static FFieldAddress GetAlphamapDataToMemory_MaxY_PropertyAddress;

	private static int GetAlphamapDataToMemory_MaxY_Offset;

	private static bool GetAllTags_IsValid;

	private static IntPtr GetAllTags_FunctionAddress;

	private static int GetAllTags_ParamsSize;

	private static bool GetAllTags_AssetData_IsValid;

	private static FFieldAddress GetAllTags_AssetData_PropertyAddress;

	private static int GetAllTags_AssetData_Offset;

	private static bool GetAllTags_OutArray_IsValid;

	private static FFieldAddress GetAllTags_OutArray_PropertyAddress;

	private static int GetAllTags_OutArray_Offset;

	private static bool GetActorRotation_IsValid;

	private static IntPtr GetActorRotation_FunctionAddress;

	private static int GetActorRotation_ParamsSize;

	private static bool GetActorRotation_Actor_IsValid;

	private static FFieldAddress GetActorRotation_Actor_PropertyAddress;

	private static int GetActorRotation_Actor_Offset;

	private static bool GetActorRotation_ReturnValue_IsValid;

	private static FFieldAddress GetActorRotation_ReturnValue_PropertyAddress;

	private static int GetActorRotation_ReturnValue_Offset;

	private static bool GetActorLocation_IsValid;

	private static IntPtr GetActorLocation_FunctionAddress;

	private static int GetActorLocation_ParamsSize;

	private static bool GetActorLocation_Actor_IsValid;

	private static FFieldAddress GetActorLocation_Actor_PropertyAddress;

	private static int GetActorLocation_Actor_Offset;

	private static bool GetActorLocation_ReturnValue_IsValid;

	private static FFieldAddress GetActorLocation_ReturnValue_PropertyAddress;

	private static int GetActorLocation_ReturnValue_Offset;

	private static bool GetActorLabel_IsValid;

	private static IntPtr GetActorLabel_FunctionAddress;

	private static int GetActorLabel_ParamsSize;

	private static bool GetActorLabel_Actor_IsValid;

	private static FFieldAddress GetActorLabel_Actor_PropertyAddress;

	private static int GetActorLabel_Actor_Offset;

	private static bool GetActorLabel_ReturnValue_IsValid;

	private static FFieldAddress GetActorLabel_ReturnValue_PropertyAddress;

	private static int GetActorLabel_ReturnValue_Offset;

	private static bool GetActor_IsValid;

	private static IntPtr GetActor_FunctionAddress;

	private static int GetActor_ParamsSize;

	private static bool GetActor_Proxy_IsValid;

	private static FFieldAddress GetActor_Proxy_PropertyAddress;

	private static int GetActor_Proxy_Offset;

	private static bool GetActor_ReturnValue_IsValid;

	private static FFieldAddress GetActor_ReturnValue_PropertyAddress;

	private static int GetActor_ReturnValue_Offset;

	private static bool FindWorldInPackage_IsValid;

	private static IntPtr FindWorldInPackage_FunctionAddress;

	private static int FindWorldInPackage_ParamsSize;

	private static bool FindWorldInPackage_Package_IsValid;

	private static FFieldAddress FindWorldInPackage_Package_PropertyAddress;

	private static int FindWorldInPackage_Package_Offset;

	private static bool FindWorldInPackage_ReturnValue_IsValid;

	private static FFieldAddress FindWorldInPackage_ReturnValue_PropertyAddress;

	private static int FindWorldInPackage_ReturnValue_Offset;

	private static bool ExportNavigation_IsValid;

	private static IntPtr ExportNavigation_FunctionAddress;

	private static int ExportNavigation_ParamsSize;

	private static bool ExportNavigation_InWorld_IsValid;

	private static FFieldAddress ExportNavigation_InWorld_PropertyAddress;

	private static int ExportNavigation_InWorld_Offset;

	private static bool ExportNavigation_Path_IsValid;

	private static FFieldAddress ExportNavigation_Path_PropertyAddress;

	private static int ExportNavigation_Path_Offset;

	private static bool ExportNavigation_ReturnValue_IsValid;

	private static FFieldAddress ExportNavigation_ReturnValue_PropertyAddress;

	private static int ExportNavigation_ReturnValue_Offset;

	private static bool EditorDestroyActor_IsValid;

	private static IntPtr EditorDestroyActor_FunctionAddress;

	private static int EditorDestroyActor_ParamsSize;

	private static bool EditorDestroyActor_World_IsValid;

	private static FFieldAddress EditorDestroyActor_World_PropertyAddress;

	private static int EditorDestroyActor_World_Offset;

	private static bool EditorDestroyActor_Actor_IsValid;

	private static FFieldAddress EditorDestroyActor_Actor_PropertyAddress;

	private static int EditorDestroyActor_Actor_Offset;

	private static bool EditorDestroyActor_bShouldModifyLevel_IsValid;

	private static FFieldAddress EditorDestroyActor_bShouldModifyLevel_PropertyAddress;

	private static int EditorDestroyActor_bShouldModifyLevel_Offset;

	private static bool EditorDestroyActor_ReturnValue_IsValid;

	private static FFieldAddress EditorDestroyActor_ReturnValue_PropertyAddress;

	private static int EditorDestroyActor_ReturnValue_Offset;

	private static bool EditorAddModalWindow_IsValid;

	private static IntPtr EditorAddModalWindow_FunctionAddress;

	private static int EditorAddModalWindow_ParamsSize;

	private static bool EditorAddModalWindow_Widget_IsValid;

	private static FFieldAddress EditorAddModalWindow_Widget_PropertyAddress;

	private static int EditorAddModalWindow_Widget_Offset;

	private static bool DrawWireStar_IsValid;

	private static IntPtr DrawWireStar_FunctionAddress;

	private static int DrawWireStar_ParamsSize;

	private static bool DrawWireStar_PDI_IsValid;

	private static FFieldAddress DrawWireStar_PDI_PropertyAddress;

	private static int DrawWireStar_PDI_Offset;

	private static bool DrawWireStar_Position_IsValid;

	private static FFieldAddress DrawWireStar_Position_PropertyAddress;

	private static int DrawWireStar_Position_Offset;

	private static bool DrawWireStar_Size_IsValid;

	private static FFieldAddress DrawWireStar_Size_PropertyAddress;

	private static int DrawWireStar_Size_Offset;

	private static bool DrawWireStar_Color_IsValid;

	private static FFieldAddress DrawWireStar_Color_PropertyAddress;

	private static int DrawWireStar_Color_Offset;

	private static bool DrawWireStar_DepthPriority_IsValid;

	private static FFieldAddress DrawWireStar_DepthPriority_PropertyAddress;

	private static int DrawWireStar_DepthPriority_Offset;

	private static bool DrawWireSphereCappedCone_IsValid;

	private static IntPtr DrawWireSphereCappedCone_FunctionAddress;

	private static int DrawWireSphereCappedCone_ParamsSize;

	private static bool DrawWireSphereCappedCone_PDI_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_PDI_PropertyAddress;

	private static int DrawWireSphereCappedCone_PDI_Offset;

	private static bool DrawWireSphereCappedCone_Transform_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_Transform_PropertyAddress;

	private static int DrawWireSphereCappedCone_Transform_Offset;

	private static bool DrawWireSphereCappedCone_ConeRadius_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_ConeRadius_PropertyAddress;

	private static int DrawWireSphereCappedCone_ConeRadius_Offset;

	private static bool DrawWireSphereCappedCone_ConeAngle_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_ConeAngle_PropertyAddress;

	private static int DrawWireSphereCappedCone_ConeAngle_Offset;

	private static bool DrawWireSphereCappedCone_ConeSides_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_ConeSides_PropertyAddress;

	private static int DrawWireSphereCappedCone_ConeSides_Offset;

	private static bool DrawWireSphereCappedCone_ArcFrequency_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_ArcFrequency_PropertyAddress;

	private static int DrawWireSphereCappedCone_ArcFrequency_Offset;

	private static bool DrawWireSphereCappedCone_CapSegments_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_CapSegments_PropertyAddress;

	private static int DrawWireSphereCappedCone_CapSegments_Offset;

	private static bool DrawWireSphereCappedCone_Color_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_Color_PropertyAddress;

	private static int DrawWireSphereCappedCone_Color_Offset;

	private static bool DrawWireSphereCappedCone_DepthPriority_IsValid;

	private static FFieldAddress DrawWireSphereCappedCone_DepthPriority_PropertyAddress;

	private static int DrawWireSphereCappedCone_DepthPriority_Offset;

	private static bool DrawWireSphereAutoSides2_IsValid;

	private static IntPtr DrawWireSphereAutoSides2_FunctionAddress;

	private static int DrawWireSphereAutoSides2_ParamsSize;

	private static bool DrawWireSphereAutoSides2_PDI_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_PDI_PropertyAddress;

	private static int DrawWireSphereAutoSides2_PDI_Offset;

	private static bool DrawWireSphereAutoSides2_Transform_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_Transform_PropertyAddress;

	private static int DrawWireSphereAutoSides2_Transform_Offset;

	private static bool DrawWireSphereAutoSides2_Color_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_Color_PropertyAddress;

	private static int DrawWireSphereAutoSides2_Color_Offset;

	private static bool DrawWireSphereAutoSides2_Radius_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_Radius_PropertyAddress;

	private static int DrawWireSphereAutoSides2_Radius_Offset;

	private static bool DrawWireSphereAutoSides2_DepthPriority_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_DepthPriority_PropertyAddress;

	private static int DrawWireSphereAutoSides2_DepthPriority_Offset;

	private static bool DrawWireSphereAutoSides2_Thickness_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_Thickness_PropertyAddress;

	private static int DrawWireSphereAutoSides2_Thickness_Offset;

	private static bool DrawWireSphereAutoSides2_DepthBias_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_DepthBias_PropertyAddress;

	private static int DrawWireSphereAutoSides2_DepthBias_Offset;

	private static bool DrawWireSphereAutoSides2_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides2_bScreenSpace_PropertyAddress;

	private static int DrawWireSphereAutoSides2_bScreenSpace_Offset;

	private static bool DrawWireSphereAutoSides_IsValid;

	private static IntPtr DrawWireSphereAutoSides_FunctionAddress;

	private static int DrawWireSphereAutoSides_ParamsSize;

	private static bool DrawWireSphereAutoSides_PDI_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_PDI_PropertyAddress;

	private static int DrawWireSphereAutoSides_PDI_Offset;

	private static bool DrawWireSphereAutoSides_Base_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_Base_PropertyAddress;

	private static int DrawWireSphereAutoSides_Base_Offset;

	private static bool DrawWireSphereAutoSides_Color_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_Color_PropertyAddress;

	private static int DrawWireSphereAutoSides_Color_Offset;

	private static bool DrawWireSphereAutoSides_Radius_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_Radius_PropertyAddress;

	private static int DrawWireSphereAutoSides_Radius_Offset;

	private static bool DrawWireSphereAutoSides_DepthPriority_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_DepthPriority_PropertyAddress;

	private static int DrawWireSphereAutoSides_DepthPriority_Offset;

	private static bool DrawWireSphereAutoSides_Thickness_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_Thickness_PropertyAddress;

	private static int DrawWireSphereAutoSides_Thickness_Offset;

	private static bool DrawWireSphereAutoSides_DepthBias_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_DepthBias_PropertyAddress;

	private static int DrawWireSphereAutoSides_DepthBias_Offset;

	private static bool DrawWireSphereAutoSides_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireSphereAutoSides_bScreenSpace_PropertyAddress;

	private static int DrawWireSphereAutoSides_bScreenSpace_Offset;

	private static bool DrawWireSphere2_IsValid;

	private static IntPtr DrawWireSphere2_FunctionAddress;

	private static int DrawWireSphere2_ParamsSize;

	private static bool DrawWireSphere2_PDI_IsValid;

	private static FFieldAddress DrawWireSphere2_PDI_PropertyAddress;

	private static int DrawWireSphere2_PDI_Offset;

	private static bool DrawWireSphere2_Transform_IsValid;

	private static FFieldAddress DrawWireSphere2_Transform_PropertyAddress;

	private static int DrawWireSphere2_Transform_Offset;

	private static bool DrawWireSphere2_Color_IsValid;

	private static FFieldAddress DrawWireSphere2_Color_PropertyAddress;

	private static int DrawWireSphere2_Color_Offset;

	private static bool DrawWireSphere2_Radius_IsValid;

	private static FFieldAddress DrawWireSphere2_Radius_PropertyAddress;

	private static int DrawWireSphere2_Radius_Offset;

	private static bool DrawWireSphere2_NumSides_IsValid;

	private static FFieldAddress DrawWireSphere2_NumSides_PropertyAddress;

	private static int DrawWireSphere2_NumSides_Offset;

	private static bool DrawWireSphere2_DepthPriority_IsValid;

	private static FFieldAddress DrawWireSphere2_DepthPriority_PropertyAddress;

	private static int DrawWireSphere2_DepthPriority_Offset;

	private static bool DrawWireSphere2_Thickness_IsValid;

	private static FFieldAddress DrawWireSphere2_Thickness_PropertyAddress;

	private static int DrawWireSphere2_Thickness_Offset;

	private static bool DrawWireSphere2_DepthBias_IsValid;

	private static FFieldAddress DrawWireSphere2_DepthBias_PropertyAddress;

	private static int DrawWireSphere2_DepthBias_Offset;

	private static bool DrawWireSphere2_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireSphere2_bScreenSpace_PropertyAddress;

	private static int DrawWireSphere2_bScreenSpace_Offset;

	private static bool DrawWireSphere_IsValid;

	private static IntPtr DrawWireSphere_FunctionAddress;

	private static int DrawWireSphere_ParamsSize;

	private static bool DrawWireSphere_PDI_IsValid;

	private static FFieldAddress DrawWireSphere_PDI_PropertyAddress;

	private static int DrawWireSphere_PDI_Offset;

	private static bool DrawWireSphere_Base_IsValid;

	private static FFieldAddress DrawWireSphere_Base_PropertyAddress;

	private static int DrawWireSphere_Base_Offset;

	private static bool DrawWireSphere_Color_IsValid;

	private static FFieldAddress DrawWireSphere_Color_PropertyAddress;

	private static int DrawWireSphere_Color_Offset;

	private static bool DrawWireSphere_Radius_IsValid;

	private static FFieldAddress DrawWireSphere_Radius_PropertyAddress;

	private static int DrawWireSphere_Radius_Offset;

	private static bool DrawWireSphere_NumSides_IsValid;

	private static FFieldAddress DrawWireSphere_NumSides_PropertyAddress;

	private static int DrawWireSphere_NumSides_Offset;

	private static bool DrawWireSphere_DepthPriority_IsValid;

	private static FFieldAddress DrawWireSphere_DepthPriority_PropertyAddress;

	private static int DrawWireSphere_DepthPriority_Offset;

	private static bool DrawWireSphere_Thickness_IsValid;

	private static FFieldAddress DrawWireSphere_Thickness_PropertyAddress;

	private static int DrawWireSphere_Thickness_Offset;

	private static bool DrawWireSphere_DepthBias_IsValid;

	private static FFieldAddress DrawWireSphere_DepthBias_PropertyAddress;

	private static int DrawWireSphere_DepthBias_Offset;

	private static bool DrawWireSphere_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireSphere_bScreenSpace_PropertyAddress;

	private static int DrawWireSphere_bScreenSpace_Offset;

	private static bool DrawWireDiamond_IsValid;

	private static IntPtr DrawWireDiamond_FunctionAddress;

	private static int DrawWireDiamond_ParamsSize;

	private static bool DrawWireDiamond_PDI_IsValid;

	private static FFieldAddress DrawWireDiamond_PDI_PropertyAddress;

	private static int DrawWireDiamond_PDI_Offset;

	private static bool DrawWireDiamond_Transform_IsValid;

	private static FFieldAddress DrawWireDiamond_Transform_PropertyAddress;

	private static int DrawWireDiamond_Transform_Offset;

	private static bool DrawWireDiamond_Size_IsValid;

	private static FFieldAddress DrawWireDiamond_Size_PropertyAddress;

	private static int DrawWireDiamond_Size_Offset;

	private static bool DrawWireDiamond_InColor_IsValid;

	private static FFieldAddress DrawWireDiamond_InColor_PropertyAddress;

	private static int DrawWireDiamond_InColor_Offset;

	private static bool DrawWireDiamond_DepthPriority_IsValid;

	private static FFieldAddress DrawWireDiamond_DepthPriority_PropertyAddress;

	private static int DrawWireDiamond_DepthPriority_Offset;

	private static bool DrawWireCylinder_IsValid;

	private static IntPtr DrawWireCylinder_FunctionAddress;

	private static int DrawWireCylinder_ParamsSize;

	private static bool DrawWireCylinder_PDI_IsValid;

	private static FFieldAddress DrawWireCylinder_PDI_PropertyAddress;

	private static int DrawWireCylinder_PDI_Offset;

	private static bool DrawWireCylinder_Base_IsValid;

	private static FFieldAddress DrawWireCylinder_Base_PropertyAddress;

	private static int DrawWireCylinder_Base_Offset;

	private static bool DrawWireCylinder_X_IsValid;

	private static FFieldAddress DrawWireCylinder_X_PropertyAddress;

	private static int DrawWireCylinder_X_Offset;

	private static bool DrawWireCylinder_Y_IsValid;

	private static FFieldAddress DrawWireCylinder_Y_PropertyAddress;

	private static int DrawWireCylinder_Y_Offset;

	private static bool DrawWireCylinder_Z_IsValid;

	private static FFieldAddress DrawWireCylinder_Z_PropertyAddress;

	private static int DrawWireCylinder_Z_Offset;

	private static bool DrawWireCylinder_Color_IsValid;

	private static FFieldAddress DrawWireCylinder_Color_PropertyAddress;

	private static int DrawWireCylinder_Color_Offset;

	private static bool DrawWireCylinder_Radius_IsValid;

	private static FFieldAddress DrawWireCylinder_Radius_PropertyAddress;

	private static int DrawWireCylinder_Radius_Offset;

	private static bool DrawWireCylinder_HalfHeight_IsValid;

	private static FFieldAddress DrawWireCylinder_HalfHeight_PropertyAddress;

	private static int DrawWireCylinder_HalfHeight_Offset;

	private static bool DrawWireCylinder_NumSides_IsValid;

	private static FFieldAddress DrawWireCylinder_NumSides_PropertyAddress;

	private static int DrawWireCylinder_NumSides_Offset;

	private static bool DrawWireCylinder_DepthPriority_IsValid;

	private static FFieldAddress DrawWireCylinder_DepthPriority_PropertyAddress;

	private static int DrawWireCylinder_DepthPriority_Offset;

	private static bool DrawWireCylinder_Thickness_IsValid;

	private static FFieldAddress DrawWireCylinder_Thickness_PropertyAddress;

	private static int DrawWireCylinder_Thickness_Offset;

	private static bool DrawWireCylinder_DepthBias_IsValid;

	private static FFieldAddress DrawWireCylinder_DepthBias_PropertyAddress;

	private static int DrawWireCylinder_DepthBias_Offset;

	private static bool DrawWireCylinder_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireCylinder_bScreenSpace_PropertyAddress;

	private static int DrawWireCylinder_bScreenSpace_Offset;

	private static bool DrawWireCone_IsValid;

	private static IntPtr DrawWireCone_FunctionAddress;

	private static int DrawWireCone_ParamsSize;

	private static bool DrawWireCone_PDI_IsValid;

	private static FFieldAddress DrawWireCone_PDI_PropertyAddress;

	private static int DrawWireCone_PDI_Offset;

	private static bool DrawWireCone_Verts_IsValid;

	private static FFieldAddress DrawWireCone_Verts_PropertyAddress;

	private static int DrawWireCone_Verts_Offset;

	private static bool DrawWireCone_Transform_IsValid;

	private static FFieldAddress DrawWireCone_Transform_PropertyAddress;

	private static int DrawWireCone_Transform_Offset;

	private static bool DrawWireCone_ConeRadius_IsValid;

	private static FFieldAddress DrawWireCone_ConeRadius_PropertyAddress;

	private static int DrawWireCone_ConeRadius_Offset;

	private static bool DrawWireCone_ConeAngle_IsValid;

	private static FFieldAddress DrawWireCone_ConeAngle_PropertyAddress;

	private static int DrawWireCone_ConeAngle_Offset;

	private static bool DrawWireCone_ConeSides_IsValid;

	private static FFieldAddress DrawWireCone_ConeSides_PropertyAddress;

	private static int DrawWireCone_ConeSides_Offset;

	private static bool DrawWireCone_Color_IsValid;

	private static FFieldAddress DrawWireCone_Color_PropertyAddress;

	private static int DrawWireCone_Color_Offset;

	private static bool DrawWireCone_DepthPriority_IsValid;

	private static FFieldAddress DrawWireCone_DepthPriority_PropertyAddress;

	private static int DrawWireCone_DepthPriority_Offset;

	private static bool DrawWireCone_Thickness_IsValid;

	private static FFieldAddress DrawWireCone_Thickness_PropertyAddress;

	private static int DrawWireCone_Thickness_Offset;

	private static bool DrawWireCone_DepthBias_IsValid;

	private static FFieldAddress DrawWireCone_DepthBias_PropertyAddress;

	private static int DrawWireCone_DepthBias_Offset;

	private static bool DrawWireCone_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireCone_bScreenSpace_PropertyAddress;

	private static int DrawWireCone_bScreenSpace_Offset;

	private static bool DrawWireChoppedCone_IsValid;

	private static IntPtr DrawWireChoppedCone_FunctionAddress;

	private static int DrawWireChoppedCone_ParamsSize;

	private static bool DrawWireChoppedCone_PDI_IsValid;

	private static FFieldAddress DrawWireChoppedCone_PDI_PropertyAddress;

	private static int DrawWireChoppedCone_PDI_Offset;

	private static bool DrawWireChoppedCone_Base_IsValid;

	private static FFieldAddress DrawWireChoppedCone_Base_PropertyAddress;

	private static int DrawWireChoppedCone_Base_Offset;

	private static bool DrawWireChoppedCone_X_IsValid;

	private static FFieldAddress DrawWireChoppedCone_X_PropertyAddress;

	private static int DrawWireChoppedCone_X_Offset;

	private static bool DrawWireChoppedCone_Y_IsValid;

	private static FFieldAddress DrawWireChoppedCone_Y_PropertyAddress;

	private static int DrawWireChoppedCone_Y_Offset;

	private static bool DrawWireChoppedCone_Z_IsValid;

	private static FFieldAddress DrawWireChoppedCone_Z_PropertyAddress;

	private static int DrawWireChoppedCone_Z_Offset;

	private static bool DrawWireChoppedCone_Color_IsValid;

	private static FFieldAddress DrawWireChoppedCone_Color_PropertyAddress;

	private static int DrawWireChoppedCone_Color_Offset;

	private static bool DrawWireChoppedCone_Radius_IsValid;

	private static FFieldAddress DrawWireChoppedCone_Radius_PropertyAddress;

	private static int DrawWireChoppedCone_Radius_Offset;

	private static bool DrawWireChoppedCone_TopRadius_IsValid;

	private static FFieldAddress DrawWireChoppedCone_TopRadius_PropertyAddress;

	private static int DrawWireChoppedCone_TopRadius_Offset;

	private static bool DrawWireChoppedCone_HalfHeight_IsValid;

	private static FFieldAddress DrawWireChoppedCone_HalfHeight_PropertyAddress;

	private static int DrawWireChoppedCone_HalfHeight_Offset;

	private static bool DrawWireChoppedCone_NumSides_IsValid;

	private static FFieldAddress DrawWireChoppedCone_NumSides_PropertyAddress;

	private static int DrawWireChoppedCone_NumSides_Offset;

	private static bool DrawWireChoppedCone_DepthPriority_IsValid;

	private static FFieldAddress DrawWireChoppedCone_DepthPriority_PropertyAddress;

	private static int DrawWireChoppedCone_DepthPriority_Offset;

	private static bool DrawWireCapsule_IsValid;

	private static IntPtr DrawWireCapsule_FunctionAddress;

	private static int DrawWireCapsule_ParamsSize;

	private static bool DrawWireCapsule_PDI_IsValid;

	private static FFieldAddress DrawWireCapsule_PDI_PropertyAddress;

	private static int DrawWireCapsule_PDI_Offset;

	private static bool DrawWireCapsule_Base_IsValid;

	private static FFieldAddress DrawWireCapsule_Base_PropertyAddress;

	private static int DrawWireCapsule_Base_Offset;

	private static bool DrawWireCapsule_X_IsValid;

	private static FFieldAddress DrawWireCapsule_X_PropertyAddress;

	private static int DrawWireCapsule_X_Offset;

	private static bool DrawWireCapsule_Y_IsValid;

	private static FFieldAddress DrawWireCapsule_Y_PropertyAddress;

	private static int DrawWireCapsule_Y_Offset;

	private static bool DrawWireCapsule_Z_IsValid;

	private static FFieldAddress DrawWireCapsule_Z_PropertyAddress;

	private static int DrawWireCapsule_Z_Offset;

	private static bool DrawWireCapsule_Color_IsValid;

	private static FFieldAddress DrawWireCapsule_Color_PropertyAddress;

	private static int DrawWireCapsule_Color_Offset;

	private static bool DrawWireCapsule_Radius_IsValid;

	private static FFieldAddress DrawWireCapsule_Radius_PropertyAddress;

	private static int DrawWireCapsule_Radius_Offset;

	private static bool DrawWireCapsule_HalfHeight_IsValid;

	private static FFieldAddress DrawWireCapsule_HalfHeight_PropertyAddress;

	private static int DrawWireCapsule_HalfHeight_Offset;

	private static bool DrawWireCapsule_NumSides_IsValid;

	private static FFieldAddress DrawWireCapsule_NumSides_PropertyAddress;

	private static int DrawWireCapsule_NumSides_Offset;

	private static bool DrawWireCapsule_DepthPriority_IsValid;

	private static FFieldAddress DrawWireCapsule_DepthPriority_PropertyAddress;

	private static int DrawWireCapsule_DepthPriority_Offset;

	private static bool DrawWireCapsule_Thickness_IsValid;

	private static FFieldAddress DrawWireCapsule_Thickness_PropertyAddress;

	private static int DrawWireCapsule_Thickness_Offset;

	private static bool DrawWireCapsule_DepthBias_IsValid;

	private static FFieldAddress DrawWireCapsule_DepthBias_PropertyAddress;

	private static int DrawWireCapsule_DepthBias_Offset;

	private static bool DrawWireCapsule_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireCapsule_bScreenSpace_PropertyAddress;

	private static int DrawWireCapsule_bScreenSpace_Offset;

	private static bool DrawWireBox2_IsValid;

	private static IntPtr DrawWireBox2_FunctionAddress;

	private static int DrawWireBox2_ParamsSize;

	private static bool DrawWireBox2_PDI_IsValid;

	private static FFieldAddress DrawWireBox2_PDI_PropertyAddress;

	private static int DrawWireBox2_PDI_Offset;

	private static bool DrawWireBox2_Matrix_IsValid;

	private static FFieldAddress DrawWireBox2_Matrix_PropertyAddress;

	private static int DrawWireBox2_Matrix_Offset;

	private static bool DrawWireBox2_Box_IsValid;

	private static FFieldAddress DrawWireBox2_Box_PropertyAddress;

	private static int DrawWireBox2_Box_Offset;

	private static bool DrawWireBox2_Color_IsValid;

	private static FFieldAddress DrawWireBox2_Color_PropertyAddress;

	private static int DrawWireBox2_Color_Offset;

	private static bool DrawWireBox2_DepthPriority_IsValid;

	private static FFieldAddress DrawWireBox2_DepthPriority_PropertyAddress;

	private static int DrawWireBox2_DepthPriority_Offset;

	private static bool DrawWireBox2_Thickness_IsValid;

	private static FFieldAddress DrawWireBox2_Thickness_PropertyAddress;

	private static int DrawWireBox2_Thickness_Offset;

	private static bool DrawWireBox2_DepthBias_IsValid;

	private static FFieldAddress DrawWireBox2_DepthBias_PropertyAddress;

	private static int DrawWireBox2_DepthBias_Offset;

	private static bool DrawWireBox2_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireBox2_bScreenSpace_PropertyAddress;

	private static int DrawWireBox2_bScreenSpace_Offset;

	private static bool DrawWireBox_IsValid;

	private static IntPtr DrawWireBox_FunctionAddress;

	private static int DrawWireBox_ParamsSize;

	private static bool DrawWireBox_PDI_IsValid;

	private static FFieldAddress DrawWireBox_PDI_PropertyAddress;

	private static int DrawWireBox_PDI_Offset;

	private static bool DrawWireBox_Box_IsValid;

	private static FFieldAddress DrawWireBox_Box_PropertyAddress;

	private static int DrawWireBox_Box_Offset;

	private static bool DrawWireBox_Color_IsValid;

	private static FFieldAddress DrawWireBox_Color_PropertyAddress;

	private static int DrawWireBox_Color_Offset;

	private static bool DrawWireBox_DepthPriority_IsValid;

	private static FFieldAddress DrawWireBox_DepthPriority_PropertyAddress;

	private static int DrawWireBox_DepthPriority_Offset;

	private static bool DrawWireBox_Thickness_IsValid;

	private static FFieldAddress DrawWireBox_Thickness_PropertyAddress;

	private static int DrawWireBox_Thickness_Offset;

	private static bool DrawWireBox_DepthBias_IsValid;

	private static FFieldAddress DrawWireBox_DepthBias_PropertyAddress;

	private static int DrawWireBox_DepthBias_Offset;

	private static bool DrawWireBox_bScreenSpace_IsValid;

	private static FFieldAddress DrawWireBox_bScreenSpace_PropertyAddress;

	private static int DrawWireBox_bScreenSpace_Offset;

	private static bool DrawPolygon_IsValid;

	private static IntPtr DrawPolygon_FunctionAddress;

	private static int DrawPolygon_ParamsSize;

	private static bool DrawPolygon_PDI_IsValid;

	private static FFieldAddress DrawPolygon_PDI_PropertyAddress;

	private static int DrawPolygon_PDI_Offset;

	private static bool DrawPolygon_Verts_IsValid;

	private static FFieldAddress DrawPolygon_Verts_PropertyAddress;

	private static int DrawPolygon_Verts_Offset;

	private static bool DrawPolygon_InColor_IsValid;

	private static FFieldAddress DrawPolygon_InColor_PropertyAddress;

	private static int DrawPolygon_InColor_Offset;

	private static bool DrawPolygon_DepthPriority_IsValid;

	private static FFieldAddress DrawPolygon_DepthPriority_PropertyAddress;

	private static int DrawPolygon_DepthPriority_Offset;

	private static bool DrawPolygon_RHIFeatureLevel_IsValid;

	private static FFieldAddress DrawPolygon_RHIFeatureLevel_PropertyAddress;

	private static int DrawPolygon_RHIFeatureLevel_Offset;

	private static bool DrawOrientedWireBox_IsValid;

	private static IntPtr DrawOrientedWireBox_FunctionAddress;

	private static int DrawOrientedWireBox_ParamsSize;

	private static bool DrawOrientedWireBox_PDI_IsValid;

	private static FFieldAddress DrawOrientedWireBox_PDI_PropertyAddress;

	private static int DrawOrientedWireBox_PDI_Offset;

	private static bool DrawOrientedWireBox_Base_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Base_PropertyAddress;

	private static int DrawOrientedWireBox_Base_Offset;

	private static bool DrawOrientedWireBox_X_IsValid;

	private static FFieldAddress DrawOrientedWireBox_X_PropertyAddress;

	private static int DrawOrientedWireBox_X_Offset;

	private static bool DrawOrientedWireBox_Y_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Y_PropertyAddress;

	private static int DrawOrientedWireBox_Y_Offset;

	private static bool DrawOrientedWireBox_Z_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Z_PropertyAddress;

	private static int DrawOrientedWireBox_Z_Offset;

	private static bool DrawOrientedWireBox_Extent_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Extent_PropertyAddress;

	private static int DrawOrientedWireBox_Extent_Offset;

	private static bool DrawOrientedWireBox_Color_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Color_PropertyAddress;

	private static int DrawOrientedWireBox_Color_Offset;

	private static bool DrawOrientedWireBox_DepthPriority_IsValid;

	private static FFieldAddress DrawOrientedWireBox_DepthPriority_PropertyAddress;

	private static int DrawOrientedWireBox_DepthPriority_Offset;

	private static bool DrawOrientedWireBox_Thickness_IsValid;

	private static FFieldAddress DrawOrientedWireBox_Thickness_PropertyAddress;

	private static int DrawOrientedWireBox_Thickness_Offset;

	private static bool DrawOrientedWireBox_DepthBias_IsValid;

	private static FFieldAddress DrawOrientedWireBox_DepthBias_PropertyAddress;

	private static int DrawOrientedWireBox_DepthBias_Offset;

	private static bool DrawOrientedWireBox_bScreenSpace_IsValid;

	private static FFieldAddress DrawOrientedWireBox_bScreenSpace_PropertyAddress;

	private static int DrawOrientedWireBox_bScreenSpace_Offset;

	private static bool DrawDirectionalArrow_IsValid;

	private static IntPtr DrawDirectionalArrow_FunctionAddress;

	private static int DrawDirectionalArrow_ParamsSize;

	private static bool DrawDirectionalArrow_PDI_IsValid;

	private static FFieldAddress DrawDirectionalArrow_PDI_PropertyAddress;

	private static int DrawDirectionalArrow_PDI_Offset;

	private static bool DrawDirectionalArrow_ArrowToWorld_IsValid;

	private static FFieldAddress DrawDirectionalArrow_ArrowToWorld_PropertyAddress;

	private static int DrawDirectionalArrow_ArrowToWorld_Offset;

	private static bool DrawDirectionalArrow_InColor_IsValid;

	private static FFieldAddress DrawDirectionalArrow_InColor_PropertyAddress;

	private static int DrawDirectionalArrow_InColor_Offset;

	private static bool DrawDirectionalArrow_Length_IsValid;

	private static FFieldAddress DrawDirectionalArrow_Length_PropertyAddress;

	private static int DrawDirectionalArrow_Length_Offset;

	private static bool DrawDirectionalArrow_ArrowSize_IsValid;

	private static FFieldAddress DrawDirectionalArrow_ArrowSize_PropertyAddress;

	private static int DrawDirectionalArrow_ArrowSize_Offset;

	private static bool DrawDirectionalArrow_DepthPriority_IsValid;

	private static FFieldAddress DrawDirectionalArrow_DepthPriority_PropertyAddress;

	private static int DrawDirectionalArrow_DepthPriority_Offset;

	private static bool DrawDirectionalArrow_Thickness_IsValid;

	private static FFieldAddress DrawDirectionalArrow_Thickness_PropertyAddress;

	private static int DrawDirectionalArrow_Thickness_Offset;

	private static bool DrawDashedLine_IsValid;

	private static IntPtr DrawDashedLine_FunctionAddress;

	private static int DrawDashedLine_ParamsSize;

	private static bool DrawDashedLine_PDI_IsValid;

	private static FFieldAddress DrawDashedLine_PDI_PropertyAddress;

	private static int DrawDashedLine_PDI_Offset;

	private static bool DrawDashedLine_Start_IsValid;

	private static FFieldAddress DrawDashedLine_Start_PropertyAddress;

	private static int DrawDashedLine_Start_Offset;

	private static bool DrawDashedLine_End_IsValid;

	private static FFieldAddress DrawDashedLine_End_PropertyAddress;

	private static int DrawDashedLine_End_Offset;

	private static bool DrawDashedLine_Color_IsValid;

	private static FFieldAddress DrawDashedLine_Color_PropertyAddress;

	private static int DrawDashedLine_Color_Offset;

	private static bool DrawDashedLine_DashSize_IsValid;

	private static FFieldAddress DrawDashedLine_DashSize_PropertyAddress;

	private static int DrawDashedLine_DashSize_Offset;

	private static bool DrawDashedLine_DepthPriority_IsValid;

	private static FFieldAddress DrawDashedLine_DepthPriority_PropertyAddress;

	private static int DrawDashedLine_DepthPriority_Offset;

	private static bool DrawDashedLine_DepthBias_IsValid;

	private static FFieldAddress DrawDashedLine_DepthBias_PropertyAddress;

	private static int DrawDashedLine_DepthBias_Offset;

	private static bool DrawConnectedArrow_IsValid;

	private static IntPtr DrawConnectedArrow_FunctionAddress;

	private static int DrawConnectedArrow_ParamsSize;

	private static bool DrawConnectedArrow_PDI_IsValid;

	private static FFieldAddress DrawConnectedArrow_PDI_PropertyAddress;

	private static int DrawConnectedArrow_PDI_Offset;

	private static bool DrawConnectedArrow_ArrowToWorld_IsValid;

	private static FFieldAddress DrawConnectedArrow_ArrowToWorld_PropertyAddress;

	private static int DrawConnectedArrow_ArrowToWorld_Offset;

	private static bool DrawConnectedArrow_Color_IsValid;

	private static FFieldAddress DrawConnectedArrow_Color_PropertyAddress;

	private static int DrawConnectedArrow_Color_Offset;

	private static bool DrawConnectedArrow_ArrowHeight_IsValid;

	private static FFieldAddress DrawConnectedArrow_ArrowHeight_PropertyAddress;

	private static int DrawConnectedArrow_ArrowHeight_Offset;

	private static bool DrawConnectedArrow_ArrowWidth_IsValid;

	private static FFieldAddress DrawConnectedArrow_ArrowWidth_PropertyAddress;

	private static int DrawConnectedArrow_ArrowWidth_Offset;

	private static bool DrawConnectedArrow_DepthPriority_IsValid;

	private static FFieldAddress DrawConnectedArrow_DepthPriority_PropertyAddress;

	private static int DrawConnectedArrow_DepthPriority_Offset;

	private static bool DrawConnectedArrow_Thickness_IsValid;

	private static FFieldAddress DrawConnectedArrow_Thickness_PropertyAddress;

	private static int DrawConnectedArrow_Thickness_Offset;

	private static bool DrawConnectedArrow_NumSpokes_IsValid;

	private static FFieldAddress DrawConnectedArrow_NumSpokes_PropertyAddress;

	private static int DrawConnectedArrow_NumSpokes_Offset;

	private static bool DrawCircle_IsValid;

	private static IntPtr DrawCircle_FunctionAddress;

	private static int DrawCircle_ParamsSize;

	private static bool DrawCircle_PDI_IsValid;

	private static FFieldAddress DrawCircle_PDI_PropertyAddress;

	private static int DrawCircle_PDI_Offset;

	private static bool DrawCircle_Base_IsValid;

	private static FFieldAddress DrawCircle_Base_PropertyAddress;

	private static int DrawCircle_Base_Offset;

	private static bool DrawCircle_X_IsValid;

	private static FFieldAddress DrawCircle_X_PropertyAddress;

	private static int DrawCircle_X_Offset;

	private static bool DrawCircle_Y_IsValid;

	private static FFieldAddress DrawCircle_Y_PropertyAddress;

	private static int DrawCircle_Y_Offset;

	private static bool DrawCircle_Color_IsValid;

	private static FFieldAddress DrawCircle_Color_PropertyAddress;

	private static int DrawCircle_Color_Offset;

	private static bool DrawCircle_Radius_IsValid;

	private static FFieldAddress DrawCircle_Radius_PropertyAddress;

	private static int DrawCircle_Radius_Offset;

	private static bool DrawCircle_NumSides_IsValid;

	private static FFieldAddress DrawCircle_NumSides_PropertyAddress;

	private static int DrawCircle_NumSides_Offset;

	private static bool DrawCircle_DepthPriority_IsValid;

	private static FFieldAddress DrawCircle_DepthPriority_PropertyAddress;

	private static int DrawCircle_DepthPriority_Offset;

	private static bool DrawCircle_Thickness_IsValid;

	private static FFieldAddress DrawCircle_Thickness_PropertyAddress;

	private static int DrawCircle_Thickness_Offset;

	private static bool DrawCircle_DepthBias_IsValid;

	private static FFieldAddress DrawCircle_DepthBias_PropertyAddress;

	private static int DrawCircle_DepthBias_Offset;

	private static bool DrawCircle_bScreenSpace_IsValid;

	private static FFieldAddress DrawCircle_bScreenSpace_PropertyAddress;

	private static int DrawCircle_bScreenSpace_Offset;

	private static bool DrawArc_IsValid;

	private static IntPtr DrawArc_FunctionAddress;

	private static int DrawArc_ParamsSize;

	private static bool DrawArc_PDI_IsValid;

	private static FFieldAddress DrawArc_PDI_PropertyAddress;

	private static int DrawArc_PDI_Offset;

	private static bool DrawArc_Base_IsValid;

	private static FFieldAddress DrawArc_Base_PropertyAddress;

	private static int DrawArc_Base_Offset;

	private static bool DrawArc_X_IsValid;

	private static FFieldAddress DrawArc_X_PropertyAddress;

	private static int DrawArc_X_Offset;

	private static bool DrawArc_Y_IsValid;

	private static FFieldAddress DrawArc_Y_PropertyAddress;

	private static int DrawArc_Y_Offset;

	private static bool DrawArc_MinAngle_IsValid;

	private static FFieldAddress DrawArc_MinAngle_PropertyAddress;

	private static int DrawArc_MinAngle_Offset;

	private static bool DrawArc_MaxAngle_IsValid;

	private static FFieldAddress DrawArc_MaxAngle_PropertyAddress;

	private static int DrawArc_MaxAngle_Offset;

	private static bool DrawArc_Radius_IsValid;

	private static FFieldAddress DrawArc_Radius_PropertyAddress;

	private static int DrawArc_Radius_Offset;

	private static bool DrawArc_Sections_IsValid;

	private static FFieldAddress DrawArc_Sections_PropertyAddress;

	private static int DrawArc_Sections_Offset;

	private static bool DrawArc_Color_IsValid;

	private static FFieldAddress DrawArc_Color_PropertyAddress;

	private static int DrawArc_Color_Offset;

	private static bool DrawArc_DepthPriority_IsValid;

	private static FFieldAddress DrawArc_DepthPriority_PropertyAddress;

	private static int DrawArc_DepthPriority_Offset;

	private static bool DeselectAll_IsValid;

	private static IntPtr DeselectAll_FunctionAddress;

	private static int DeselectAll_ParamsSize;

	private static bool DeselectAll_Selection_IsValid;

	private static FFieldAddress DeselectAll_Selection_PropertyAddress;

	private static int DeselectAll_Selection_Offset;

	private static bool DeselectAll_InClass_IsValid;

	private static FFieldAddress DeselectAll_InClass_PropertyAddress;

	private static int DeselectAll_InClass_Offset;

	private static bool Deselect_IsValid;

	private static IntPtr Deselect_FunctionAddress;

	private static int Deselect_ParamsSize;

	private static bool Deselect_Selection_IsValid;

	private static FFieldAddress Deselect_Selection_PropertyAddress;

	private static int Deselect_Selection_Offset;

	private static bool Deselect_InObject_IsValid;

	private static FFieldAddress Deselect_InObject_PropertyAddress;

	private static int Deselect_InObject_Offset;

	private static bool DeletePackage_IsValid;

	private static IntPtr DeletePackage_FunctionAddress;

	private static int DeletePackage_ParamsSize;

	private static bool DeletePackage_Package_IsValid;

	private static FFieldAddress DeletePackage_Package_PropertyAddress;

	private static int DeletePackage_Package_Offset;

	private static bool DeletePackage_ReturnValue_IsValid;

	private static FFieldAddress DeletePackage_ReturnValue_PropertyAddress;

	private static int DeletePackage_ReturnValue_Offset;

	private static bool csgAdd_IsValid;

	private static IntPtr csgAdd_FunctionAddress;

	private static int csgAdd_ParamsSize;

	private static bool csgAdd_DefaultBrush_IsValid;

	private static FFieldAddress csgAdd_DefaultBrush_PropertyAddress;

	private static int csgAdd_DefaultBrush_Offset;

	private static bool csgAdd_PolyFlags_IsValid;

	private static FFieldAddress csgAdd_PolyFlags_PropertyAddress;

	private static int csgAdd_PolyFlags_Offset;

	private static bool csgAdd_BrushType_IsValid;

	private static FFieldAddress csgAdd_BrushType_PropertyAddress;

	private static int csgAdd_BrushType_Offset;

	private static bool csgAdd_ReturnValue_IsValid;

	private static FFieldAddress csgAdd_ReturnValue_PropertyAddress;

	private static int csgAdd_ReturnValue_Offset;

	private static bool CreatePropertyEditorToolkit_IsValid;

	private static IntPtr CreatePropertyEditorToolkit_FunctionAddress;

	private static int CreatePropertyEditorToolkit_ParamsSize;

	private static bool CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_IsValid;

	private static FFieldAddress CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_PropertyAddress;

	private static int CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_Offset;

	private static bool CreateLogListingWidget_IsValid;

	private static IntPtr CreateLogListingWidget_FunctionAddress;

	private static int CreateLogListingWidget_ParamsSize;

	private static bool CreateLogListingWidget_InLogName_IsValid;

	private static FFieldAddress CreateLogListingWidget_InLogName_PropertyAddress;

	private static int CreateLogListingWidget_InLogName_Offset;

	private static bool CreateLogListingWidget_ReturnValue_IsValid;

	private static FFieldAddress CreateLogListingWidget_ReturnValue_PropertyAddress;

	private static int CreateLogListingWidget_ReturnValue_Offset;

	private static bool CreateLogListing_IsValid;

	private static IntPtr CreateLogListing_FunctionAddress;

	private static int CreateLogListing_ParamsSize;

	private static bool CreateLogListing_InLogName_IsValid;

	private static FFieldAddress CreateLogListing_InLogName_PropertyAddress;

	private static int CreateLogListing_InLogName_Offset;

	private static bool CreateLogListing_InLabel_IsValid;

	private static FFieldAddress CreateLogListing_InLabel_PropertyAddress;

	private static int CreateLogListing_InLabel_Offset;

	private static bool CreateBrushForVolumeActor_IsValid;

	private static IntPtr CreateBrushForVolumeActor_FunctionAddress;

	private static int CreateBrushForVolumeActor_ParamsSize;

	private static bool CreateBrushForVolumeActor_NewActor_IsValid;

	private static FFieldAddress CreateBrushForVolumeActor_NewActor_PropertyAddress;

	private static int CreateBrushForVolumeActor_NewActor_Offset;

	private static bool CreateBrushForVolumeActor_BrushBuilder_IsValid;

	private static FFieldAddress CreateBrushForVolumeActor_BrushBuilder_PropertyAddress;

	private static int CreateBrushForVolumeActor_BrushBuilder_Offset;

	private static bool ConditionalBeginDestroybyUObject_IsValid;

	private static IntPtr ConditionalBeginDestroybyUObject_FunctionAddress;

	private static int ConditionalBeginDestroybyUObject_ParamsSize;

	private static bool ConditionalBeginDestroybyUObject_TargetObject_IsValid;

	private static FFieldAddress ConditionalBeginDestroybyUObject_TargetObject_PropertyAddress;

	private static int ConditionalBeginDestroybyUObject_TargetObject_Offset;

	private static bool ConditionalBeginDestroybyUObject_ReturnValue_IsValid;

	private static FFieldAddress ConditionalBeginDestroybyUObject_ReturnValue_PropertyAddress;

	private static int ConditionalBeginDestroybyUObject_ReturnValue_Offset;

	private static bool CompileBlueprint_IsValid;

	private static IntPtr CompileBlueprint_FunctionAddress;

	private static int CompileBlueprint_ParamsSize;

	private static bool CompileBlueprint_Blueprint_IsValid;

	private static FFieldAddress CompileBlueprint_Blueprint_PropertyAddress;

	private static int CompileBlueprint_Blueprint_Offset;

	private static bool ClearActorLabel_IsValid;

	private static IntPtr ClearActorLabel_FunctionAddress;

	private static int ClearActorLabel_ParamsSize;

	private static bool ClearActorLabel_Actor_IsValid;

	private static FFieldAddress ClearActorLabel_Actor_PropertyAddress;

	private static int ClearActorLabel_Actor_Offset;

	private static bool Build_IsValid;

	private static IntPtr Build_FunctionAddress;

	private static int Build_ParamsSize;

	private static bool Build_Builder_IsValid;

	private static FFieldAddress Build_Builder_PropertyAddress;

	private static int Build_Builder_Offset;

	private static bool Build_InWorld_IsValid;

	private static FFieldAddress Build_InWorld_PropertyAddress;

	private static int Build_InWorld_Offset;

	private static bool Build_InBrush_IsValid;

	private static FFieldAddress Build_InBrush_PropertyAddress;

	private static int Build_InBrush_Offset;

	private static bool Build_ReturnValue_IsValid;

	private static FFieldAddress Build_ReturnValue_PropertyAddress;

	private static int Build_ReturnValue_Offset;

	private static bool BroadcastHotReload_IsValid;

	private static IntPtr BroadcastHotReload_FunctionAddress;

	private static int BroadcastHotReload_ParamsSize;

	private static bool BroadcastAssetCreated_IsValid;

	private static IntPtr BroadcastAssetCreated_FunctionAddress;

	private static int BroadcastAssetCreated_ParamsSize;

	private static bool BroadcastAssetCreated_NewAsset_IsValid;

	private static FFieldAddress BroadcastAssetCreated_NewAsset_PropertyAddress;

	private static int BroadcastAssetCreated_NewAsset_Offset;

	private static bool AddWhitelistedObject_IsValid;

	private static IntPtr AddWhitelistedObject_FunctionAddress;

	private static int AddWhitelistedObject_ParamsSize;

	private static bool AddWhitelistedObject_InObject_IsValid;

	private static FFieldAddress AddWhitelistedObject_InObject_PropertyAddress;

	private static int AddWhitelistedObject_InObject_Offset;

	private static bool AddNewComponentToBlueprint_IsValid;

	private static IntPtr AddNewComponentToBlueprint_FunctionAddress;

	private static int AddNewComponentToBlueprint_ParamsSize;

	private static bool AddNewComponentToBlueprint_NewComponentClass_IsValid;

	private static FFieldAddress AddNewComponentToBlueprint_NewComponentClass_PropertyAddress;

	private static int AddNewComponentToBlueprint_NewComponentClass_Offset;

	private static bool AddNewComponentToBlueprint_Asset_IsValid;

	private static FFieldAddress AddNewComponentToBlueprint_Asset_PropertyAddress;

	private static int AddNewComponentToBlueprint_Asset_Offset;

	private static bool AddNewComponentToBlueprint_ReturnValue_IsValid;

	private static FFieldAddress AddNewComponentToBlueprint_ReturnValue_PropertyAddress;

	private static int AddNewComponentToBlueprint_ReturnValue_Offset;

	private static bool AddLogListingMessage_IsValid;

	private static IntPtr AddLogListingMessage_FunctionAddress;

	private static int AddLogListingMessage_ParamsSize;

	private static bool AddLogListingMessage_InLogName_IsValid;

	private static FFieldAddress AddLogListingMessage_InLogName_PropertyAddress;

	private static int AddLogListingMessage_InLogName_Offset;

	private static bool AddLogListingMessage_InSeverity_IsValid;

	private static FFieldAddress AddLogListingMessage_InSeverity_PropertyAddress;

	private static int AddLogListingMessage_InSeverity_Offset;

	private static bool AddLogListingMessage_LogText_IsValid;

	private static FFieldAddress AddLogListingMessage_LogText_PropertyAddress;

	private static int AddLogListingMessage_LogText_Offset;

	private static bool AddLazyExtender_IsValid;

	private static IntPtr AddLazyExtender_FunctionAddress;

	private static int AddLazyExtender_ParamsSize;

	private static bool AddLazyExtender_Manager_IsValid;

	private static FFieldAddress AddLazyExtender_Manager_PropertyAddress;

	private static int AddLazyExtender_Manager_Offset;

	private static bool AddLazyExtender_Delegates_IsValid;

	private static FFieldAddress AddLazyExtender_Delegates_PropertyAddress;

	private static int AddLazyExtender_Delegates_Offset;

	private static bool AddGroup_IsValid;

	private static IntPtr AddGroup_FunctionAddress;

	private static int AddGroup_ParamsSize;

	private static bool AddGroup_Parent_IsValid;

	private static FFieldAddress AddGroup_Parent_PropertyAddress;

	private static int AddGroup_Parent_Offset;

	private static bool AddGroup_DisplayName_IsValid;

	private static FFieldAddress AddGroup_DisplayName_PropertyAddress;

	private static int AddGroup_DisplayName_Offset;

	private static bool AddGroup_ReturnValue_IsValid;

	private static FFieldAddress AddGroup_ReturnValue_PropertyAddress;

	private static int AddGroup_ReturnValue_Offset;

	private static bool AddExtender_IsValid;

	private static IntPtr AddExtender_FunctionAddress;

	private static int AddExtender_ParamsSize;

	private static bool AddExtender_Manager_IsValid;

	private static FFieldAddress AddExtender_Manager_PropertyAddress;

	private static int AddExtender_Manager_Offset;

	private static bool AddExtender_Extender_IsValid;

	private static FFieldAddress AddExtender_Extender_PropertyAddress;

	private static int AddExtender_Extender_Offset;

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

	private static bool AddComponentsToBlueprint_OptionalNewRootComponent_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_OptionalNewRootComponent_PropertyAddress;

	private static int AddComponentsToBlueprint_OptionalNewRootComponent_Offset;

	private static bool AddComponentsToBlueprint_bKeepMobility_IsValid;

	private static FFieldAddress AddComponentsToBlueprint_bKeepMobility_PropertyAddress;

	private static int AddComponentsToBlueprint_bKeepMobility_Offset;

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:UpdateModelComponents")]
	public unsafe static void UpdateModelComponents(ULevel Level)
	{
		if (!UpdateModelComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:UpdateModelComponents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateModelComponents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateModelComponents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, UpdateModelComponents_Level_Offset), 0, UpdateModelComponents_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateModelComponents_FunctionAddress, intPtr, UpdateModelComponents_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleSelect")]
	public unsafe static void ToggleSelect(USelection Selection, UObject InObject)
	{
		if (!ToggleSelect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleSelect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleSelect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleSelect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USelection>.ToNative(IntPtr.Add(intPtr, ToggleSelect_Selection_Offset), 0, ToggleSelect_Selection_PropertyAddress.Address, Selection);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ToggleSelect_InObject_Offset), 0, ToggleSelect_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToggleSelect_FunctionAddress, intPtr, ToggleSelect_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleIsExecuteTestModePIE")]
	public unsafe static bool ToggleIsExecuteTestModePIE()
	{
		if (!ToggleIsExecuteTestModePIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleIsExecuteTestModePIE");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleIsExecuteTestModePIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleIsExecuteTestModePIE_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToggleIsExecuteTestModePIE_FunctionAddress, intPtr, ToggleIsExecuteTestModePIE_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ToggleIsExecuteTestModePIE_ReturnValue_Offset), 0, ToggleIsExecuteTestModePIE_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetIsTemporarilyHiddenInEditor")]
	public unsafe static void SetIsTemporarilyHiddenInEditor(AActor Actor, bool bIsHidden)
	{
		if (!SetIsTemporarilyHiddenInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetIsTemporarilyHiddenInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsTemporarilyHiddenInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsTemporarilyHiddenInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetIsTemporarilyHiddenInEditor_Actor_Offset), 0, SetIsTemporarilyHiddenInEditor_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsTemporarilyHiddenInEditor_bIsHidden_Offset), 0, SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress.Address, bIsHidden);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetIsTemporarilyHiddenInEditor_FunctionAddress, intPtr, SetIsTemporarilyHiddenInEditor_ParamsSize);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHitProxy")]
	public unsafe static void SetHitProxy(FJavascriptPDI PDI, FName Name)
	{
		if (!SetHitProxy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHitProxy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHitProxy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHitProxy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, SetHitProxy_PDI_Offset), 0, SetHitProxy_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetHitProxy_Name_Offset), 0, SetHitProxy_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetHitProxy_FunctionAddress, intPtr, SetHitProxy_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHeightmapDataFromMemory")]
	public unsafe static void SetHeightmapDataFromMemory(ULandscapeInfo LandscapeInfo, int MinX, int MinY, int MaxX, int MaxY)
	{
		if (!SetHeightmapDataFromMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHeightmapDataFromMemory");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHeightmapDataFromMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHeightmapDataFromMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, SetHeightmapDataFromMemory_LandscapeInfo_Offset), 0, SetHeightmapDataFromMemory_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetHeightmapDataFromMemory_MinX_Offset), 0, SetHeightmapDataFromMemory_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetHeightmapDataFromMemory_MinY_Offset), 0, SetHeightmapDataFromMemory_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetHeightmapDataFromMemory_MaxX_Offset), 0, SetHeightmapDataFromMemory_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetHeightmapDataFromMemory_MaxY_Offset), 0, SetHeightmapDataFromMemory_MaxY_PropertyAddress.Address, MaxY);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetHeightmapDataFromMemory_FunctionAddress, intPtr, SetHeightmapDataFromMemory_ParamsSize);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath_Recursively")]
	public unsafe static void SetFolderPath_Recursively(AActor Actor, FName NewFolderPath)
	{
		if (!SetFolderPath_Recursively_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath_Recursively");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFolderPath_Recursively_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFolderPath_Recursively_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetFolderPath_Recursively_Actor_Offset), 0, SetFolderPath_Recursively_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFolderPath_Recursively_NewFolderPath_Offset), 0, SetFolderPath_Recursively_NewFolderPath_PropertyAddress.Address, NewFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFolderPath_Recursively_FunctionAddress, intPtr, SetFolderPath_Recursively_ParamsSize);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath")]
	public unsafe static void SetFolderPath(AActor Actor, FName NewFolderPath)
	{
		if (!SetFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetFolderPath_Actor_Offset), 0, SetFolderPath_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFolderPath_NewFolderPath_Offset), 0, SetFolderPath_NewFolderPath_PropertyAddress.Address, NewFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFolderPath_FunctionAddress, intPtr, SetFolderPath_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetAlphamapDataFromMemory")]
	public unsafe static void SetAlphamapDataFromMemory(ULandscapeInfo LandscapeInfo, ULandscapeLayerInfoObject LayerInfo, int MinX, int MinY, int MaxX, int MaxY, ELandscapeLayerPaintingRestriction PaintingRestriction = ELandscapeLayerPaintingRestriction.None)
	{
		if (!SetAlphamapDataFromMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetAlphamapDataFromMemory");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAlphamapDataFromMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAlphamapDataFromMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_LandscapeInfo_Offset), 0, SetAlphamapDataFromMemory_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		UObjectMarshaler<ULandscapeLayerInfoObject>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_LayerInfo_Offset), 0, SetAlphamapDataFromMemory_LayerInfo_PropertyAddress.Address, LayerInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_MinX_Offset), 0, SetAlphamapDataFromMemory_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_MinY_Offset), 0, SetAlphamapDataFromMemory_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_MaxX_Offset), 0, SetAlphamapDataFromMemory_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_MaxY_Offset), 0, SetAlphamapDataFromMemory_MaxY_PropertyAddress.Address, MaxY);
		EnumMarshaler<ELandscapeLayerPaintingRestriction>.ToNative(IntPtr.Add(intPtr, SetAlphamapDataFromMemory_PaintingRestriction_Offset), 0, SetAlphamapDataFromMemory_PaintingRestriction_PropertyAddress.Address, PaintingRestriction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAlphamapDataFromMemory_FunctionAddress, intPtr, SetAlphamapDataFromMemory_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLocation")]
	public unsafe static bool SetActorLocation(AActor Actor, FVector NewLocation, bool bSweep, out FHitResult SweepHitResult, bool bTeleport)
	{
		if (!SetActorLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLocation");
			SweepHitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLocation_Actor_Offset), 0, SetActorLocation_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetActorLocation_NewLocation_Offset), 0, SetActorLocation_NewLocation_PropertyAddress.Address, NewLocation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocation_bSweep_Offset), 0, SetActorLocation_bSweep_PropertyAddress.Address, bSweep);
		NativeReflection.InitializeValue_InContainer(SetActorLocation_SweepHitResult_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLocation_bTeleport_Offset), 0, SetActorLocation_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLocation_FunctionAddress, intPtr, SetActorLocation_ParamsSize);
		SweepHitResult = FHitResult.FromNative(IntPtr.Add(intPtr, SetActorLocation_SweepHitResult_Offset), 0, SetActorLocation_SweepHitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetActorLocation_ReturnValue_Offset), 0, SetActorLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabelUnique")]
	public unsafe static void SetActorLabelUnique(AActor Actor, string NewActorLabel, List<string> InExistingActorLabels)
	{
		if (!SetActorLabelUnique_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabelUnique");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLabelUnique_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLabelUnique_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLabelUnique_Actor_Offset), 0, SetActorLabelUnique_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabelUnique_NewActorLabel_Offset), 0, SetActorLabelUnique_NewActorLabel_PropertyAddress.Address, NewActorLabel);
		new TArrayCopyMarshaler<string>(1, SetActorLabelUnique_InExistingActorLabels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetActorLabelUnique_InExistingActorLabels_Offset), InExistingActorLabels);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLabelUnique_FunctionAddress, intPtr, SetActorLabelUnique_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActorLabelUnique_NewActorLabel_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetActorLabelUnique_InExistingActorLabels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabel")]
	public unsafe static void SetActorLabel(AActor Actor, string NewActorLabel, bool bMarkDirty)
	{
		if (!SetActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLabel_Actor_Offset), 0, SetActorLabel_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabel_NewActorLabel_Offset), 0, SetActorLabel_NewActorLabel_PropertyAddress.Address, NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLabel_bMarkDirty_Offset), 0, SetActorLabel_bMarkDirty_PropertyAddress.Address, bMarkDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLabel_FunctionAddress, intPtr, SetActorLabel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetActorLabel_NewActorLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:Select")]
	public unsafe static void Select(USelection Selection, UObject InObject)
	{
		if (!Select_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:Select");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Select_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Select_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USelection>.ToNative(IntPtr.Add(intPtr, Select_Selection_Offset), 0, Select_Selection_PropertyAddress.Address, Selection);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Select_InObject_Offset), 0, Select_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Select_FunctionAddress, intPtr, Select_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:SavePackage")]
	public unsafe static bool SavePackage(UPackage Package, string FileName)
	{
		if (!SavePackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:SavePackage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SavePackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SavePackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, SavePackage_Package_Offset), 0, SavePackage_Package_PropertyAddress.Address, Package);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SavePackage_FileName_Offset), 0, SavePackage_FileName_PropertyAddress.Address, FileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SavePackage_FunctionAddress, intPtr, SavePackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SavePackage_FileName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SavePackage_ReturnValue_Offset), 0, SavePackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:RequestEndPlayMapInPIE")]
	public unsafe static void RequestEndPlayMapInPIE()
	{
		if (!RequestEndPlayMapInPIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:RequestEndPlayMapInPIE");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestEndPlayMapInPIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestEndPlayMapInPIE_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RequestEndPlayMapInPIE_FunctionAddress, argsSize: RequestEndPlayMapInPIE_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ReplaceAnimNotifyClass")]
	public unsafe static int ReplaceAnimNotifyClass(UAnimSequenceBase Sequence, string NotifyName, string NewNotifyName, UObject NewNotifyClass)
	{
		if (!ReplaceAnimNotifyClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ReplaceAnimNotifyClass");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAnimNotifyClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAnimNotifyClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyClass_Sequence_Offset), 0, ReplaceAnimNotifyClass_Sequence_PropertyAddress.Address, Sequence);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyClass_NotifyName_Offset), 0, ReplaceAnimNotifyClass_NotifyName_PropertyAddress.Address, NotifyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyClass_NewNotifyName_Offset), 0, ReplaceAnimNotifyClass_NewNotifyName_PropertyAddress.Address, NewNotifyName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ReplaceAnimNotifyClass_NewNotifyClass_Offset), 0, ReplaceAnimNotifyClass_NewNotifyClass_PropertyAddress.Address, NewNotifyClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceAnimNotifyClass_FunctionAddress, intPtr, ReplaceAnimNotifyClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceAnimNotifyClass_NotifyName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ReplaceAnimNotifyClass_NewNotifyName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ReplaceAnimNotifyClass_ReturnValue_Offset), 0, ReplaceAnimNotifyClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveLevelInstance")]
	public unsafe static void RemoveLevelInstance(UWorld World)
	{
		if (!RemoveLevelInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveLevelInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLevelInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLevelInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, RemoveLevelInstance_World_Offset), 0, RemoveLevelInstance_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveLevelInstance_FunctionAddress, intPtr, RemoveLevelInstance_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveExtender")]
	public unsafe static void RemoveExtender(FJavascriptExtensibilityManager Manager, FJavascriptExtender Extender)
	{
		if (!RemoveExtender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveExtender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveExtender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveExtender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveExtender_Manager_PropertyAddress.Address, intPtr);
		FJavascriptExtensibilityManager.ToNative(IntPtr.Add(intPtr, RemoveExtender_Manager_Offset), 0, RemoveExtender_Manager_PropertyAddress.Address, Manager);
		NativeReflection.InitializeValue_InContainer(RemoveExtender_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, RemoveExtender_Extender_Offset), 0, RemoveExtender_Extender_PropertyAddress.Address, Extender);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveExtender_FunctionAddress, intPtr, RemoveExtender_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveExtender_Manager_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RemoveExtender_Extender_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveComponentFromBlueprint")]
	public unsafe static void RemoveComponentFromBlueprint(UBlueprint Blueprint, UActorComponent RemoveComponent, bool bPromoteChildren = false)
	{
		if (!RemoveComponentFromBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveComponentFromBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveComponentFromBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveComponentFromBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, RemoveComponentFromBlueprint_Blueprint_Offset), 0, RemoveComponentFromBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RemoveComponentFromBlueprint_RemoveComponent_Offset), 0, RemoveComponentFromBlueprint_RemoveComponent_PropertyAddress.Address, RemoveComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RemoveComponentFromBlueprint_bPromoteChildren_Offset), 0, RemoveComponentFromBlueprint_bPromoteChildren_PropertyAddress.Address, bPromoteChildren);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveComponentFromBlueprint_FunctionAddress, intPtr, RemoveComponentFromBlueprint_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveAllLazyExtender")]
	public unsafe static void RemoveAllLazyExtender(FJavascriptExtensibilityManager Manager)
	{
		if (!RemoveAllLazyExtender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveAllLazyExtender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAllLazyExtender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAllLazyExtender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveAllLazyExtender_Manager_PropertyAddress.Address, intPtr);
		FJavascriptExtensibilityManager.ToNative(IntPtr.Add(intPtr, RemoveAllLazyExtender_Manager_Offset), 0, RemoveAllLazyExtender_Manager_PropertyAddress.Address, Manager);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAllLazyExtender_FunctionAddress, intPtr, RemoveAllLazyExtender_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveAllLazyExtender_Manager_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:PostEditChange")]
	public unsafe static void PostEditChange(UObject InObject)
	{
		if (!PostEditChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:PostEditChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostEditChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostEditChange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PostEditChange_InObject_Offset), 0, PostEditChange_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostEditChange_FunctionAddress, intPtr, PostEditChange_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenPopupWindow")]
	public unsafe static void OpenPopupWindow(UWidget Widget, FVector2D PopupDesiredSize, FText HeadingText)
	{
		if (!OpenPopupWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenPopupWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenPopupWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenPopupWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, OpenPopupWindow_Widget_Offset), 0, OpenPopupWindow_Widget_PropertyAddress.Address, Widget);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, OpenPopupWindow_PopupDesiredSize_Offset), 0, OpenPopupWindow_PopupDesiredSize_PropertyAddress.Address, PopupDesiredSize);
		NativeReflection.InitializeValue_InContainer(OpenPopupWindow_HeadingText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, OpenPopupWindow_HeadingText_Offset), 0, OpenPopupWindow_HeadingText_PropertyAddress.Address, HeadingText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenPopupWindow_FunctionAddress, intPtr, OpenPopupWindow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenPopupWindow_HeadingText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenFileDialog")]
	public unsafe static bool OpenFileDialog(UJavascriptWindow WindowHandle, string DialogTitle, string DefaultPath, string DefaultFile, string FileTypes, int Flags, out List<string> OutFilenames)
	{
		if (!OpenFileDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenFileDialog");
			OutFilenames = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenFileDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenFileDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptWindow>.ToNative(IntPtr.Add(intPtr, OpenFileDialog_WindowHandle_Offset), 0, OpenFileDialog_WindowHandle_PropertyAddress.Address, WindowHandle);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFileDialog_DialogTitle_Offset), 0, OpenFileDialog_DialogTitle_PropertyAddress.Address, DialogTitle);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFileDialog_DefaultPath_Offset), 0, OpenFileDialog_DefaultPath_PropertyAddress.Address, DefaultPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFileDialog_DefaultFile_Offset), 0, OpenFileDialog_DefaultFile_PropertyAddress.Address, DefaultFile);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFileDialog_FileTypes_Offset), 0, OpenFileDialog_FileTypes_PropertyAddress.Address, FileTypes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OpenFileDialog_Flags_Offset), 0, OpenFileDialog_Flags_PropertyAddress.Address, Flags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenFileDialog_FunctionAddress, intPtr, OpenFileDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenFileDialog_DialogTitle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OpenFileDialog_DefaultPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OpenFileDialog_DefaultFile_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OpenFileDialog_FileTypes_PropertyAddress.Address, intPtr);
		OutFilenames = new TArrayCopyMarshaler<string>(1, OpenFileDialog_OutFilenames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OpenFileDialog_OutFilenames_Offset));
		NativeReflection.DestroyValue_InContainer(OpenFileDialog_OutFilenames_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenFileDialog_ReturnValue_Offset), 0, OpenFileDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAssetByPath")]
	public unsafe static void OpenEditorForAssetByPath(string AssetPathName, string ObjectName)
	{
		if (!OpenEditorForAssetByPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAssetByPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenEditorForAssetByPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenEditorForAssetByPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenEditorForAssetByPath_AssetPathName_Offset), 0, OpenEditorForAssetByPath_AssetPathName_PropertyAddress.Address, AssetPathName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenEditorForAssetByPath_ObjectName_Offset), 0, OpenEditorForAssetByPath_ObjectName_PropertyAddress.Address, ObjectName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenEditorForAssetByPath_FunctionAddress, intPtr, OpenEditorForAssetByPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenEditorForAssetByPath_AssetPathName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OpenEditorForAssetByPath_ObjectName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAsset")]
	public unsafe static bool OpenEditorForAsset(UObject Asset)
	{
		if (!OpenEditorForAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenEditorForAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenEditorForAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OpenEditorForAsset_Asset_Offset), 0, OpenEditorForAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenEditorForAsset_FunctionAddress, intPtr, OpenEditorForAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenEditorForAsset_ReturnValue_Offset), 0, OpenEditorForAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenDirectoryDialog")]
	public unsafe static bool OpenDirectoryDialog(UJavascriptWindow WindowHandle, string DialogTitle, string DefaultPath, out string OutFolderName)
	{
		if (!OpenDirectoryDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenDirectoryDialog");
			OutFolderName = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenDirectoryDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenDirectoryDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UJavascriptWindow>.ToNative(IntPtr.Add(intPtr, OpenDirectoryDialog_WindowHandle_Offset), 0, OpenDirectoryDialog_WindowHandle_PropertyAddress.Address, WindowHandle);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenDirectoryDialog_DialogTitle_Offset), 0, OpenDirectoryDialog_DialogTitle_PropertyAddress.Address, DialogTitle);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenDirectoryDialog_DefaultPath_Offset), 0, OpenDirectoryDialog_DefaultPath_PropertyAddress.Address, DefaultPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenDirectoryDialog_FunctionAddress, intPtr, OpenDirectoryDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenDirectoryDialog_DialogTitle_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OpenDirectoryDialog_DefaultPath_PropertyAddress.Address, intPtr);
		OutFolderName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, OpenDirectoryDialog_OutFolderName_Offset), 0, OpenDirectoryDialog_OutFolderName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OpenDirectoryDialog_OutFolderName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenDirectoryDialog_ReturnValue_Offset), 0, OpenDirectoryDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ModifyObject")]
	public unsafe static void ModifyObject(UObject Object, bool bAlwaysMarkDirty = false)
	{
		if (!ModifyObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ModifyObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ModifyObject_Object_Offset), 0, ModifyObject_Object_PropertyAddress.Address, Object);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyObject_bAlwaysMarkDirty_Offset), 0, ModifyObject_bAlwaysMarkDirty_PropertyAddress.Address, bAlwaysMarkDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyObject_FunctionAddress, intPtr, ModifyObject_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:MarkPackageDirty")]
	public unsafe static bool MarkPackageDirty(UObject InObject)
	{
		if (!MarkPackageDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:MarkPackageDirty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkPackageDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkPackageDirty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MarkPackageDirty_InObject_Offset), 0, MarkPackageDirty_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkPackageDirty_FunctionAddress, intPtr, MarkPackageDirty_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MarkPackageDirty_ReturnValue_Offset), 0, MarkPackageDirty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadImageFromDiskAsync")]
	public unsafe static bool LoadImageFromDiskAsync(string ImagePath, UAsyncTaskDownloadImage Callback)
	{
		if (!LoadImageFromDiskAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadImageFromDiskAsync");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadImageFromDiskAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadImageFromDiskAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadImageFromDiskAsync_ImagePath_Offset), 0, LoadImageFromDiskAsync_ImagePath_PropertyAddress.Address, ImagePath);
		UObjectMarshaler<UAsyncTaskDownloadImage>.ToNative(IntPtr.Add(intPtr, LoadImageFromDiskAsync_Callback_Offset), 0, LoadImageFromDiskAsync_Callback_PropertyAddress.Address, Callback);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadImageFromDiskAsync_FunctionAddress, intPtr, LoadImageFromDiskAsync_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadImageFromDiskAsync_ImagePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadImageFromDiskAsync_ReturnValue_Offset), 0, LoadImageFromDiskAsync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToString")]
	public unsafe static bool LoadFileToString(string Path, out string Data)
	{
		if (!LoadFileToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToString");
			Data = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadFileToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadFileToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadFileToString_Path_Offset), 0, LoadFileToString_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadFileToString_FunctionAddress, intPtr, LoadFileToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadFileToString_Path_PropertyAddress.Address, intPtr);
		Data = FStringMarshaler.FromNative(IntPtr.Add(intPtr, LoadFileToString_Data_Offset), 0, LoadFileToString_Data_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(LoadFileToString_Data_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadFileToString_ReturnValue_Offset), 0, LoadFileToString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToIntArray")]
	public unsafe static bool LoadFileToIntArray(string Path, out List<byte> FileData)
	{
		if (!LoadFileToIntArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToIntArray");
			FileData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadFileToIntArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadFileToIntArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadFileToIntArray_Path_Offset), 0, LoadFileToIntArray_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadFileToIntArray_FunctionAddress, intPtr, LoadFileToIntArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadFileToIntArray_Path_PropertyAddress.Address, intPtr);
		FileData = new TArrayCopyMarshaler<byte>(1, LoadFileToIntArray_FileData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadFileToIntArray_FileData_Offset));
		NativeReflection.DestroyValue_InContainer(LoadFileToIntArray_FileData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadFileToIntArray_ReturnValue_Offset), 0, LoadFileToIntArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsShiftDown")]
	public unsafe static bool IsShiftDown(FJavascriptViewportClick Click)
	{
		if (!IsShiftDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsShiftDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsShiftDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsShiftDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, IsShiftDown_Click_Offset), 0, IsShiftDown_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsShiftDown_FunctionAddress, intPtr, IsShiftDown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsShiftDown_ReturnValue_Offset), 0, IsShiftDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsControlDown")]
	public unsafe static bool IsControlDown(FJavascriptViewportClick Click)
	{
		if (!IsControlDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsControlDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsControlDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsControlDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, IsControlDown_Click_Offset), 0, IsControlDown_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsControlDown_FunctionAddress, intPtr, IsControlDown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsControlDown_ReturnValue_Offset), 0, IsControlDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAssetLoaded")]
	public unsafe static bool IsAssetLoaded(FJavascriptAssetData AssetData)
	{
		if (!IsAssetLoaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAssetLoaded");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAssetLoaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAssetLoaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsAssetLoaded_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, IsAssetLoaded_AssetData_Offset), 0, IsAssetLoaded_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAssetLoaded_FunctionAddress, intPtr, IsAssetLoaded_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsAssetLoaded_AssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAssetLoaded_ReturnValue_Offset), 0, IsAssetLoaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAltDown")]
	public unsafe static bool IsAltDown(FJavascriptViewportClick Click)
	{
		if (!IsAltDown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAltDown");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsAltDown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsAltDown_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, IsAltDown_Click_Offset), 0, IsAltDown_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsAltDown_FunctionAddress, intPtr, IsAltDown_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsAltDown_ReturnValue_Offset), 0, IsAltDown_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActorLabelEditable")]
	public unsafe static bool IsActorLabelEditable(AActor Actor)
	{
		if (!IsActorLabelEditable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActorLabelEditable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActorLabelEditable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActorLabelEditable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, IsActorLabelEditable_Actor_Offset), 0, IsActorLabelEditable_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActorLabelEditable_FunctionAddress, intPtr, IsActorLabelEditable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActorLabelEditable_ReturnValue_Offset), 0, IsActorLabelEditable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActive")]
	public unsafe static bool IsActive(UTransactor Transactor)
	{
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTransactor>.ToNative(IntPtr.Add(intPtr, IsActive_Transactor_Offset), 0, IsActive_Transactor_PropertyAddress.Address, Transactor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:InvalidateModelGeometry")]
	public unsafe static void InvalidateModelGeometry(UWorld World, ULevel InLevel)
	{
		if (!InvalidateModelGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:InvalidateModelGeometry");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvalidateModelGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvalidateModelGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, InvalidateModelGeometry_World_Offset), 0, InvalidateModelGeometry_World_PropertyAddress.Address, World);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, InvalidateModelGeometry_InLevel_Offset), 0, InvalidateModelGeometry_InLevel_PropertyAddress.Address, InLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, InvalidateModelGeometry_FunctionAddress, intPtr, InvalidateModelGeometry_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:HasMetaData")]
	public unsafe static bool HasMetaData(UField Field, string Key)
	{
		if (!HasMetaData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:HasMetaData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMetaData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMetaData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UField>.ToNative(IntPtr.Add(intPtr, HasMetaData_Field_Offset), 0, HasMetaData_Field_PropertyAddress.Address, Field);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HasMetaData_Key_Offset), 0, HasMetaData_Key_PropertyAddress.Address, Key);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasMetaData_FunctionAddress, intPtr, HasMetaData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasMetaData_Key_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMetaData_ReturnValue_Offset), 0, HasMetaData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetUniqueID")]
	public unsafe static int GetUniqueID(UObject InObject)
	{
		if (!GetUniqueID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetUniqueID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetUniqueID_InObject_Offset), 0, GetUniqueID_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueID_FunctionAddress, intPtr, GetUniqueID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUniqueID_ReturnValue_Offset), 0, GetUniqueID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTransaction")]
	public unsafe static FJavascriptTransaction GetTransaction(UTransactor Transactor, int QueueIndex)
	{
		if (!GetTransaction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTransaction");
			return default(FJavascriptTransaction);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransaction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransaction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTransactor>.ToNative(IntPtr.Add(intPtr, GetTransaction_Transactor_Offset), 0, GetTransaction_Transactor_PropertyAddress.Address, Transactor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTransaction_QueueIndex_Offset), 0, GetTransaction_QueueIndex_PropertyAddress.Address, QueueIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransaction_FunctionAddress, intPtr, GetTransaction_ParamsSize);
		return BlittableTypeMarshaler<FJavascriptTransaction>.FromNative(IntPtr.Add(intPtr, GetTransaction_ReturnValue_Offset), 0, GetTransaction_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetToolBarExtensibilityManager")]
	public unsafe static FJavascriptExtensibilityManager GetToolBarExtensibilityManager(FName What)
	{
		if (!GetToolBarExtensibilityManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetToolBarExtensibilityManager");
			return default(FJavascriptExtensibilityManager);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetToolBarExtensibilityManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetToolBarExtensibilityManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetToolBarExtensibilityManager_What_Offset), 0, GetToolBarExtensibilityManager_What_PropertyAddress.Address, What);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetToolBarExtensibilityManager_FunctionAddress, intPtr, GetToolBarExtensibilityManager_ParamsSize);
		FJavascriptExtensibilityManager result = FJavascriptExtensibilityManager.FromNative(IntPtr.Add(intPtr, GetToolBarExtensibilityManager_ReturnValue_Offset), 0, GetToolBarExtensibilityManager_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetToolBarExtensibilityManager_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTitle")]
	public unsafe static string GetTitle(FJavascriptTransaction Transaction)
	{
		if (!GetTitle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTitle");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTitle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTitle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptTransaction>.ToNative(IntPtr.Add(intPtr, GetTitle_Transaction_Offset), 0, GetTitle_Transaction_PropertyAddress.Address, Transaction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTitle_FunctionAddress, intPtr, GetTitle_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTitle_ReturnValue_Offset), 0, GetTitle_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTitle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTagValue")]
	public unsafe static bool GetTagValue(FJavascriptAssetData AssetData, FName Name, out string OutValue)
	{
		if (!GetTagValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTagValue");
			OutValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTagValue_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, GetTagValue_AssetData_Offset), 0, GetTagValue_AssetData_PropertyAddress.Address, AssetData);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetTagValue_Name_Offset), 0, GetTagValue_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTagValue_FunctionAddress, intPtr, GetTagValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTagValue_AssetData_PropertyAddress.Address, intPtr);
		OutValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetTagValue_OutValue_Offset), 0, GetTagValue_OutValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTagValue_OutValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetTagValue_ReturnValue_Offset), 0, GetTagValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetSelectedObjects")]
	public unsafe static int GetSelectedObjects(USelection Selection, out List<UObject> Out)
	{
		if (!GetSelectedObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetSelectedObjects");
			Out = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USelection>.ToNative(IntPtr.Add(intPtr, GetSelectedObjects_Selection_Offset), 0, GetSelectedObjects_Selection_PropertyAddress.Address, Selection);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedObjects_FunctionAddress, intPtr, GetSelectedObjects_ParamsSize);
		Out = new TArrayCopyMarshaler<UObject>(1, GetSelectedObjects_Out_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedObjects_Out_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedObjects_Out_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSelectedObjects_ReturnValue_Offset), 0, GetSelectedObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetRootWindow")]
	public unsafe static FJavascriptSlateWidget GetRootWindow()
	{
		if (!GetRootWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetRootWindow");
			return default(FJavascriptSlateWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRootWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRootWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRootWindow_FunctionAddress, intPtr, GetRootWindow_ParamsSize);
		FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, GetRootWindow_ReturnValue_Offset), 0, GetRootWindow_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetRootWindow_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetQueueLength")]
	public unsafe static int GetQueueLength(UTransactor Transactor)
	{
		if (!GetQueueLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetQueueLength");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQueueLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQueueLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTransactor>.ToNative(IntPtr.Add(intPtr, GetQueueLength_Transactor_Offset), 0, GetQueueLength_Transactor_PropertyAddress.Address, Transactor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetQueueLength_FunctionAddress, intPtr, GetQueueLength_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetQueueLength_ReturnValue_Offset), 0, GetQueueLength_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPrimaryObject")]
	public unsafe static UObject GetPrimaryObject(FJavascriptTransaction Transaction)
	{
		if (!GetPrimaryObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPrimaryObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrimaryObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrimaryObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptTransaction>.ToNative(IntPtr.Add(intPtr, GetPrimaryObject_Transaction_Offset), 0, GetPrimaryObject_Transaction_PropertyAddress.Address, Transaction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPrimaryObject_FunctionAddress, intPtr, GetPrimaryObject_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetPrimaryObject_ReturnValue_Offset), 0, GetPrimaryObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetParentClassOfBlueprint")]
	public unsafe static TSubclassOf<UObject> GetParentClassOfBlueprint(UBlueprint Blueprint)
	{
		if (!GetParentClassOfBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetParentClassOfBlueprint");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParentClassOfBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParentClassOfBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetParentClassOfBlueprint_Blueprint_Offset), 0, GetParentClassOfBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParentClassOfBlueprint_FunctionAddress, intPtr, GetParentClassOfBlueprint_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetParentClassOfBlueprint_ReturnValue_Offset), 0, GetParentClassOfBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPackage")]
	public unsafe static UPackage GetPackage(FJavascriptAssetData AssetData)
	{
		if (!GetPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPackage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPackage_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, GetPackage_AssetData_Offset), 0, GetPackage_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPackage_FunctionAddress, intPtr, GetPackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPackage_AssetData_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPackage>.FromNative(IntPtr.Add(intPtr, GetPackage_ReturnValue_Offset), 0, GetPackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetOrigin")]
	public unsafe static FVector GetOrigin(FJavascriptViewportClick Click)
	{
		if (!GetOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetOrigin");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, GetOrigin_Click_Offset), 0, GetOrigin_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOrigin_FunctionAddress, intPtr, GetOrigin_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetOrigin_ReturnValue_Offset), 0, GetOrigin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetName")]
	public unsafe static FName GetName(FJavascriptHitProxy Proxy)
	{
		if (!GetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptHitProxy>.ToNative(IntPtr.Add(intPtr, GetName_Proxy_Offset), 0, GetName_Proxy_PropertyAddress.Address, Proxy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetName_FunctionAddress, intPtr, GetName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetName_ReturnValue_Offset), 0, GetName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetMenuExtensibilityManager")]
	public unsafe static FJavascriptExtensibilityManager GetMenuExtensibilityManager(FName What)
	{
		if (!GetMenuExtensibilityManager_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetMenuExtensibilityManager");
			return default(FJavascriptExtensibilityManager);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMenuExtensibilityManager_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMenuExtensibilityManager_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMenuExtensibilityManager_What_Offset), 0, GetMenuExtensibilityManager_What_PropertyAddress.Address, What);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMenuExtensibilityManager_FunctionAddress, intPtr, GetMenuExtensibilityManager_ParamsSize);
		FJavascriptExtensibilityManager result = FJavascriptExtensibilityManager.FromNative(IntPtr.Add(intPtr, GetMenuExtensibilityManager_ReturnValue_Offset), 0, GetMenuExtensibilityManager_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMenuExtensibilityManager_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLevelEditorActions")]
	public unsafe static FJavascriptUICommandList GetLevelEditorActions()
	{
		if (!GetLevelEditorActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLevelEditorActions");
			return default(FJavascriptUICommandList);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelEditorActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelEditorActions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelEditorActions_FunctionAddress, intPtr, GetLevelEditorActions_ParamsSize);
		FJavascriptUICommandList result = FJavascriptUICommandList.FromNative(IntPtr.Add(intPtr, GetLevelEditorActions_ReturnValue_Offset), 0, GetLevelEditorActions_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLevelEditorActions_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLayerInfoByName")]
	public unsafe static ULandscapeLayerInfoObject GetLayerInfoByName(ULandscapeInfo LandscapeInfo, FName LayerName, ALandscapeProxy Owner)
	{
		if (!GetLayerInfoByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLayerInfoByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLayerInfoByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLayerInfoByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, GetLayerInfoByName_LandscapeInfo_Offset), 0, GetLayerInfoByName_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLayerInfoByName_LayerName_Offset), 0, GetLayerInfoByName_LayerName_PropertyAddress.Address, LayerName);
		UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(intPtr, GetLayerInfoByName_Owner_Offset), 0, GetLayerInfoByName_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLayerInfoByName_FunctionAddress, intPtr, GetLayerInfoByName_ParamsSize);
		return UObjectMarshaler<ULandscapeLayerInfoObject>.FromNative(IntPtr.Add(intPtr, GetLayerInfoByName_ReturnValue_Offset), 0, GetLayerInfoByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeInfo")]
	public unsafe static ULandscapeInfo GetLandscapeInfo(ALandscape Landscape, bool bSpawnNewActor)
	{
		if (!GetLandscapeInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeInfo");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLandscapeInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLandscapeInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscape>.ToNative(IntPtr.Add(intPtr, GetLandscapeInfo_Landscape_Offset), 0, GetLandscapeInfo_Landscape_PropertyAddress.Address, Landscape);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLandscapeInfo_bSpawnNewActor_Offset), 0, GetLandscapeInfo_bSpawnNewActor_PropertyAddress.Address, bSpawnNewActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLandscapeInfo_FunctionAddress, intPtr, GetLandscapeInfo_ParamsSize);
		return UObjectMarshaler<ULandscapeInfo>.FromNative(IntPtr.Add(intPtr, GetLandscapeInfo_ReturnValue_Offset), 0, GetLandscapeInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeExtent")]
	public unsafe static bool GetLandscapeExtent(ULandscapeInfo LandscapeInfo, out int MinX, out int MinY, out int MaxX, out int MaxY)
	{
		if (!GetLandscapeExtent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeExtent");
			MinX = 0;
			MinY = 0;
			MaxX = 0;
			MaxY = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLandscapeExtent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLandscapeExtent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, GetLandscapeExtent_LandscapeInfo_Offset), 0, GetLandscapeExtent_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLandscapeExtent_FunctionAddress, intPtr, GetLandscapeExtent_ParamsSize);
		MinX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLandscapeExtent_MinX_Offset), 0, GetLandscapeExtent_MinX_PropertyAddress.Address);
		MinY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLandscapeExtent_MinY_Offset), 0, GetLandscapeExtent_MinY_PropertyAddress.Address);
		MaxX = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLandscapeExtent_MaxX_Offset), 0, GetLandscapeExtent_MaxX_PropertyAddress.Address);
		MaxY = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLandscapeExtent_MaxY_Offset), 0, GetLandscapeExtent_MaxY_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLandscapeExtent_ReturnValue_Offset), 0, GetLandscapeExtent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKeyNameByKeyEvent")]
	public unsafe static string GetKeyNameByKeyEvent(FKeyEvent Event)
	{
		if (!GetKeyNameByKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKeyNameByKeyEvent");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKeyNameByKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKeyNameByKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetKeyNameByKeyEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetKeyNameByKeyEvent_Event_Offset), 0, GetKeyNameByKeyEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKeyNameByKeyEvent_FunctionAddress, intPtr, GetKeyNameByKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetKeyNameByKeyEvent_Event_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetKeyNameByKeyEvent_ReturnValue_Offset), 0, GetKeyNameByKeyEvent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKeyNameByKeyEvent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKey")]
	public unsafe static FKey GetKey(FJavascriptViewportClick Click)
	{
		if (!GetKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKey");
			return default(FKey);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, GetKey_Click_Offset), 0, GetKey_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetKey_FunctionAddress, intPtr, GetKey_ParamsSize);
		FKey result = FKey.FromNative(IntPtr.Add(intPtr, GetKey_ReturnValue_Offset), 0, GetKey_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetKey_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsShiftDownByKeyEvent")]
	public unsafe static bool GetIsShiftDownByKeyEvent(FKeyEvent Event)
	{
		if (!GetIsShiftDownByKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsShiftDownByKeyEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsShiftDownByKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsShiftDownByKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIsShiftDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetIsShiftDownByKeyEvent_Event_Offset), 0, GetIsShiftDownByKeyEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsShiftDownByKeyEvent_FunctionAddress, intPtr, GetIsShiftDownByKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIsShiftDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsShiftDownByKeyEvent_ReturnValue_Offset), 0, GetIsShiftDownByKeyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 872686593u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsExecuteTestModePIE")]
	public unsafe static bool GetIsExecuteTestModePIE()
	{
		if (!GetIsExecuteTestModePIE_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsExecuteTestModePIE");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsExecuteTestModePIE_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsExecuteTestModePIE_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsExecuteTestModePIE_FunctionAddress, intPtr, GetIsExecuteTestModePIE_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsExecuteTestModePIE_ReturnValue_Offset), 0, GetIsExecuteTestModePIE_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsControlDownByKeyEvent")]
	public unsafe static bool GetIsControlDownByKeyEvent(FKeyEvent Event)
	{
		if (!GetIsControlDownByKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsControlDownByKeyEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsControlDownByKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsControlDownByKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIsControlDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetIsControlDownByKeyEvent_Event_Offset), 0, GetIsControlDownByKeyEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsControlDownByKeyEvent_FunctionAddress, intPtr, GetIsControlDownByKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIsControlDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsControlDownByKeyEvent_ReturnValue_Offset), 0, GetIsControlDownByKeyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsAltDownByKeyEvent")]
	public unsafe static bool GetIsAltDownByKeyEvent(FKeyEvent Event)
	{
		if (!GetIsAltDownByKeyEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsAltDownByKeyEvent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsAltDownByKeyEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsAltDownByKeyEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetIsAltDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		StructAsClassMarshaler<FKeyEvent>.ToNative(IntPtr.Add(intPtr, GetIsAltDownByKeyEvent_Event_Offset), 0, GetIsAltDownByKeyEvent_Event_PropertyAddress.Address, Event);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIsAltDownByKeyEvent_FunctionAddress, intPtr, GetIsAltDownByKeyEvent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetIsAltDownByKeyEvent_Event_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsAltDownByKeyEvent_ReturnValue_Offset), 0, GetIsAltDownByKeyEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetHeightmapDataToMemory")]
	public unsafe static void GetHeightmapDataToMemory(ULandscapeInfo LandscapeInfo, int MinX, int MinY, int MaxX, int MaxY)
	{
		if (!GetHeightmapDataToMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetHeightmapDataToMemory");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetHeightmapDataToMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetHeightmapDataToMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, GetHeightmapDataToMemory_LandscapeInfo_Offset), 0, GetHeightmapDataToMemory_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightmapDataToMemory_MinX_Offset), 0, GetHeightmapDataToMemory_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightmapDataToMemory_MinY_Offset), 0, GetHeightmapDataToMemory_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightmapDataToMemory_MaxX_Offset), 0, GetHeightmapDataToMemory_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetHeightmapDataToMemory_MaxY_Offset), 0, GetHeightmapDataToMemory_MaxY_PropertyAddress.Address, MaxY);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetHeightmapDataToMemory_FunctionAddress, intPtr, GetHeightmapDataToMemory_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetGroup")]
	public unsafe static FJavascriptWorkspaceItem GetGroup(string Name)
	{
		if (!GetGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetGroup");
			return default(FJavascriptWorkspaceItem);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetGroup_Name_Offset), 0, GetGroup_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGroup_FunctionAddress, intPtr, GetGroup_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetGroup_Name_PropertyAddress.Address, intPtr);
		FJavascriptWorkspaceItem result = FJavascriptWorkspaceItem.FromNative(IntPtr.Add(intPtr, GetGroup_ReturnValue_Offset), 0, GetGroup_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetGroup_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetFolderPath")]
	public unsafe static FName GetFolderPath(AActor Actor)
	{
		if (!GetFolderPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetFolderPath");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFolderPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFolderPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetFolderPath_Actor_Offset), 0, GetFolderPath_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFolderPath_FunctionAddress, intPtr, GetFolderPath_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetFolderPath_ReturnValue_Offset), 0, GetFolderPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEvent")]
	public unsafe static EInputEventType GetEvent(FJavascriptViewportClick Click)
	{
		if (!GetEvent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEvent");
			return EInputEventType.IE_Pressed;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEvent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEvent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, GetEvent_Click_Offset), 0, GetEvent_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEvent_FunctionAddress, intPtr, GetEvent_ParamsSize);
		return EnumMarshaler<EInputEventType>.FromNative(IntPtr.Add(intPtr, GetEvent_ReturnValue_Offset), 0, GetEvent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEngine")]
	public unsafe static UEditorEngine GetEngine()
	{
		if (!GetEngine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEngine");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEngine_FunctionAddress, intPtr, GetEngine_ParamsSize);
		return UObjectMarshaler<UEditorEngine>.FromNative(IntPtr.Add(intPtr, GetEngine_ReturnValue_Offset), 0, GetEngine_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEditorPlayWorld")]
	public unsafe static UWorld GetEditorPlayWorld()
	{
		if (!GetEditorPlayWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEditorPlayWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEditorPlayWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEditorPlayWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEditorPlayWorld_FunctionAddress, intPtr, GetEditorPlayWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetEditorPlayWorld_ReturnValue_Offset), 0, GetEditorPlayWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDirection")]
	public unsafe static FVector GetDirection(FJavascriptViewportClick Click)
	{
		if (!GetDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDirection");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, GetDirection_Click_Offset), 0, GetDirection_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDirection_FunctionAddress, intPtr, GetDirection_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetDirection_ReturnValue_Offset), 0, GetDirection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDefaultBrush")]
	public unsafe static ABrush GetDefaultBrush(UWorld World)
	{
		if (!GetDefaultBrush_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDefaultBrush");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultBrush_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultBrush_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetDefaultBrush_World_Offset), 0, GetDefaultBrush_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDefaultBrush_FunctionAddress, intPtr, GetDefaultBrush_ParamsSize);
		return UObjectMarshaler<ABrush>.FromNative(IntPtr.Add(intPtr, GetDefaultBrush_ReturnValue_Offset), 0, GetDefaultBrush_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDataTableAsJSON")]
	public unsafe static string GetDataTableAsJSON(UDataTable InDataTable, byte InDTExportFlags = 0)
	{
		if (!GetDataTableAsJSON_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDataTableAsJSON");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDataTableAsJSON_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDataTableAsJSON_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UDataTable>.ToNative(IntPtr.Add(intPtr, GetDataTableAsJSON_InDataTable_Offset), 0, GetDataTableAsJSON_InDataTable_PropertyAddress.Address, InDataTable);
		BlittableTypeMarshaler<byte>.ToNative(IntPtr.Add(intPtr, GetDataTableAsJSON_InDTExportFlags_Offset), 0, GetDataTableAsJSON_InDTExportFlags_PropertyAddress.Address, InDTExportFlags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDataTableAsJSON_FunctionAddress, intPtr, GetDataTableAsJSON_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDataTableAsJSON_ReturnValue_Offset), 0, GetDataTableAsJSON_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDataTableAsJSON_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetContext")]
	public unsafe static string GetContext(FJavascriptTransaction Transaction)
	{
		if (!GetContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetContext");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptTransaction>.ToNative(IntPtr.Add(intPtr, GetContext_Transaction_Offset), 0, GetContext_Transaction_PropertyAddress.Address, Transaction);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetContext_FunctionAddress, intPtr, GetContext_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetContext_ReturnValue_Offset), 0, GetContext_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetContext_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClickPos")]
	public unsafe static FIntPoint GetClickPos(FJavascriptViewportClick Click)
	{
		if (!GetClickPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClickPos");
			return default(FIntPoint);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClickPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClickPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, GetClickPos_Click_Offset), 0, GetClickPos_Click_PropertyAddress.Address, Click);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetClickPos_FunctionAddress, intPtr, GetClickPos_ParamsSize);
		return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(intPtr, GetClickPos_ReturnValue_Offset), 0, GetClickPos_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClass")]
	public unsafe static TSubclassOf<UObject> GetClass(FJavascriptAssetData AssetData)
	{
		if (!GetClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetClass_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, GetClass_AssetData_Offset), 0, GetClass_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetClass_FunctionAddress, intPtr, GetClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetClass_AssetData_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetClass_ReturnValue_Offset), 0, GetClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAssetsByType")]
	public unsafe static List<FAssetData> GetAssetsByType(List<string> Types, bool bRecursiveClasses = true)
	{
		if (!GetAssetsByType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAssetsByType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetAssetsByType_Types_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetsByType_Types_Offset), Types);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByType_bRecursiveClasses_Offset), 0, GetAssetsByType_bRecursiveClasses_PropertyAddress.Address, bRecursiveClasses);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsByType_FunctionAddress, intPtr, GetAssetsByType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetsByType_Types_PropertyAddress.Address, intPtr);
		List<FAssetData> result = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAsset")]
	public unsafe static UObject GetAsset(FJavascriptAssetData AssetData)
	{
		if (!GetAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAsset_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, GetAsset_AssetData_Offset), 0, GetAsset_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAsset_FunctionAddress, intPtr, GetAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAsset_AssetData_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAsset_ReturnValue_Offset), 0, GetAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAlphamapDataToMemory")]
	public unsafe static void GetAlphamapDataToMemory(ULandscapeInfo LandscapeInfo, ULandscapeLayerInfoObject LayerInfo, int MinX, int MinY, int MaxX, int MaxY)
	{
		if (!GetAlphamapDataToMemory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAlphamapDataToMemory");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAlphamapDataToMemory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAlphamapDataToMemory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULandscapeInfo>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_LandscapeInfo_Offset), 0, GetAlphamapDataToMemory_LandscapeInfo_PropertyAddress.Address, LandscapeInfo);
		UObjectMarshaler<ULandscapeLayerInfoObject>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_LayerInfo_Offset), 0, GetAlphamapDataToMemory_LayerInfo_PropertyAddress.Address, LayerInfo);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_MinX_Offset), 0, GetAlphamapDataToMemory_MinX_PropertyAddress.Address, MinX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_MinY_Offset), 0, GetAlphamapDataToMemory_MinY_PropertyAddress.Address, MinY);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_MaxX_Offset), 0, GetAlphamapDataToMemory_MaxX_PropertyAddress.Address, MaxX);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAlphamapDataToMemory_MaxY_Offset), 0, GetAlphamapDataToMemory_MaxY_PropertyAddress.Address, MaxY);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAlphamapDataToMemory_FunctionAddress, intPtr, GetAlphamapDataToMemory_ParamsSize);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAllTags")]
	public unsafe static void GetAllTags(FJavascriptAssetData AssetData, out List<FName> OutArray)
	{
		if (!GetAllTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAllTags");
			OutArray = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllTags_AssetData_PropertyAddress.Address, intPtr);
		FJavascriptAssetData.ToNative(IntPtr.Add(intPtr, GetAllTags_AssetData_Offset), 0, GetAllTags_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllTags_FunctionAddress, intPtr, GetAllTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllTags_AssetData_PropertyAddress.Address, intPtr);
		OutArray = new TArrayCopyMarshaler<FName>(1, GetAllTags_OutArray_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllTags_OutArray_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllTags_OutArray_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 612639745u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorRotation")]
	public unsafe static FRotator GetActorRotation(AActor Actor)
	{
		if (!GetActorRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorRotation_Actor_Offset), 0, GetActorRotation_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorRotation_FunctionAddress, intPtr, GetActorRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetActorRotation_ReturnValue_Offset), 0, GetActorRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 612639745u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLocation")]
	public unsafe static FVector GetActorLocation(AActor Actor)
	{
		if (!GetActorLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorLocation_Actor_Offset), 0, GetActorLocation_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorLocation_FunctionAddress, intPtr, GetActorLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetActorLocation_ReturnValue_Offset), 0, GetActorLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLabel")]
	public unsafe static string GetActorLabel(AActor Actor)
	{
		if (!GetActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLabel");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorLabel_Actor_Offset), 0, GetActorLabel_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorLabel_FunctionAddress, intPtr, GetActorLabel_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActorLabel_ReturnValue_Offset), 0, GetActorLabel_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorLabel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActor")]
	public unsafe static AActor GetActor(FJavascriptHitProxy Proxy)
	{
		if (!GetActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptHitProxy>.ToNative(IntPtr.Add(intPtr, GetActor_Proxy_Offset), 0, GetActor_Proxy_PropertyAddress.Address, Proxy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActor_FunctionAddress, intPtr, GetActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetActor_ReturnValue_Offset), 0, GetActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:FindWorldInPackage")]
	public unsafe static UWorld FindWorldInPackage(UPackage Package)
	{
		if (!FindWorldInPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:FindWorldInPackage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindWorldInPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindWorldInPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, FindWorldInPackage_Package_Offset), 0, FindWorldInPackage_Package_PropertyAddress.Address, Package);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindWorldInPackage_FunctionAddress, intPtr, FindWorldInPackage_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, FindWorldInPackage_ReturnValue_Offset), 0, FindWorldInPackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ExportNavigation")]
	public unsafe static string ExportNavigation(UWorld InWorld, string Path)
	{
		if (!ExportNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ExportNavigation");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ExportNavigation_InWorld_Offset), 0, ExportNavigation_InWorld_PropertyAddress.Address, InWorld);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportNavigation_Path_Offset), 0, ExportNavigation_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportNavigation_FunctionAddress, intPtr, ExportNavigation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportNavigation_Path_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ExportNavigation_ReturnValue_Offset), 0, ExportNavigation_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ExportNavigation_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorDestroyActor")]
	public unsafe static bool EditorDestroyActor(UWorld World, AActor Actor, bool bShouldModifyLevel)
	{
		if (!EditorDestroyActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorDestroyActor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorDestroyActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorDestroyActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, EditorDestroyActor_World_Offset), 0, EditorDestroyActor_World_PropertyAddress.Address, World);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, EditorDestroyActor_Actor_Offset), 0, EditorDestroyActor_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EditorDestroyActor_bShouldModifyLevel_Offset), 0, EditorDestroyActor_bShouldModifyLevel_PropertyAddress.Address, bShouldModifyLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EditorDestroyActor_FunctionAddress, intPtr, EditorDestroyActor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EditorDestroyActor_ReturnValue_Offset), 0, EditorDestroyActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorAddModalWindow")]
	public unsafe static void EditorAddModalWindow(FJavascriptSlateWidget Widget)
	{
		if (!EditorAddModalWindow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorAddModalWindow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditorAddModalWindow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditorAddModalWindow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EditorAddModalWindow_Widget_PropertyAddress.Address, intPtr);
		FJavascriptSlateWidget.ToNative(IntPtr.Add(intPtr, EditorAddModalWindow_Widget_Offset), 0, EditorAddModalWindow_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EditorAddModalWindow_FunctionAddress, intPtr, EditorAddModalWindow_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EditorAddModalWindow_Widget_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireStar")]
	public unsafe static void DrawWireStar(FJavascriptPDI PDI, FVector Position, float Size, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority)
	{
		if (!DrawWireStar_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireStar");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireStar_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireStar_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireStar_PDI_Offset), 0, DrawWireStar_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireStar_Position_Offset), 0, DrawWireStar_Position_PropertyAddress.Address, Position);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireStar_Size_Offset), 0, DrawWireStar_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireStar_Color_Offset), 0, DrawWireStar_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireStar_DepthPriority_Offset), 0, DrawWireStar_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireStar_FunctionAddress, intPtr, DrawWireStar_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereCappedCone")]
	public unsafe static void DrawWireSphereCappedCone(FJavascriptPDI PDI, FTransform Transform, float ConeRadius, float ConeAngle, int ConeSides, int ArcFrequency, int CapSegments, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority)
	{
		if (!DrawWireSphereCappedCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereCappedCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireSphereCappedCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireSphereCappedCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_PDI_Offset), 0, DrawWireSphereCappedCone_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireSphereCappedCone_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_Transform_Offset), 0, DrawWireSphereCappedCone_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_ConeRadius_Offset), 0, DrawWireSphereCappedCone_ConeRadius_PropertyAddress.Address, ConeRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_ConeAngle_Offset), 0, DrawWireSphereCappedCone_ConeAngle_PropertyAddress.Address, ConeAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_ConeSides_Offset), 0, DrawWireSphereCappedCone_ConeSides_PropertyAddress.Address, ConeSides);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_ArcFrequency_Offset), 0, DrawWireSphereCappedCone_ArcFrequency_PropertyAddress.Address, ArcFrequency);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_CapSegments_Offset), 0, DrawWireSphereCappedCone_CapSegments_PropertyAddress.Address, CapSegments);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_Color_Offset), 0, DrawWireSphereCappedCone_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireSphereCappedCone_DepthPriority_Offset), 0, DrawWireSphereCappedCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireSphereCappedCone_FunctionAddress, intPtr, DrawWireSphereCappedCone_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides2")]
	public unsafe static void DrawWireSphereAutoSides2(FJavascriptPDI PDI, FTransform Transform, FLinearColor Color, float Radius, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireSphereAutoSides2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireSphereAutoSides2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireSphereAutoSides2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_PDI_Offset), 0, DrawWireSphereAutoSides2_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireSphereAutoSides2_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_Transform_Offset), 0, DrawWireSphereAutoSides2_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_Color_Offset), 0, DrawWireSphereAutoSides2_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_Radius_Offset), 0, DrawWireSphereAutoSides2_Radius_PropertyAddress.Address, Radius);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_DepthPriority_Offset), 0, DrawWireSphereAutoSides2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_Thickness_Offset), 0, DrawWireSphereAutoSides2_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_DepthBias_Offset), 0, DrawWireSphereAutoSides2_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides2_bScreenSpace_Offset), 0, DrawWireSphereAutoSides2_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireSphereAutoSides2_FunctionAddress, intPtr, DrawWireSphereAutoSides2_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides")]
	public unsafe static void DrawWireSphereAutoSides(FJavascriptPDI PDI, FVector Base, FLinearColor Color, float Radius, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireSphereAutoSides_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireSphereAutoSides_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireSphereAutoSides_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_PDI_Offset), 0, DrawWireSphereAutoSides_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_Base_Offset), 0, DrawWireSphereAutoSides_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_Color_Offset), 0, DrawWireSphereAutoSides_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_Radius_Offset), 0, DrawWireSphereAutoSides_Radius_PropertyAddress.Address, Radius);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_DepthPriority_Offset), 0, DrawWireSphereAutoSides_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_Thickness_Offset), 0, DrawWireSphereAutoSides_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_DepthBias_Offset), 0, DrawWireSphereAutoSides_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireSphereAutoSides_bScreenSpace_Offset), 0, DrawWireSphereAutoSides_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireSphereAutoSides_FunctionAddress, intPtr, DrawWireSphereAutoSides_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere2")]
	public unsafe static void DrawWireSphere2(FJavascriptPDI PDI, FTransform Transform, FLinearColor Color, float Radius, int NumSides, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireSphere2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireSphere2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireSphere2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_PDI_Offset), 0, DrawWireSphere2_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireSphere2_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_Transform_Offset), 0, DrawWireSphere2_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_Color_Offset), 0, DrawWireSphere2_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_Radius_Offset), 0, DrawWireSphere2_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_NumSides_Offset), 0, DrawWireSphere2_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_DepthPriority_Offset), 0, DrawWireSphere2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_Thickness_Offset), 0, DrawWireSphere2_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_DepthBias_Offset), 0, DrawWireSphere2_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireSphere2_bScreenSpace_Offset), 0, DrawWireSphere2_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireSphere2_FunctionAddress, intPtr, DrawWireSphere2_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere")]
	public unsafe static void DrawWireSphere(FJavascriptPDI PDI, FVector Base, FLinearColor Color, float Radius, int NumSides, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireSphere_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireSphere_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireSphere_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_PDI_Offset), 0, DrawWireSphere_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_Base_Offset), 0, DrawWireSphere_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_Color_Offset), 0, DrawWireSphere_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_Radius_Offset), 0, DrawWireSphere_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_NumSides_Offset), 0, DrawWireSphere_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_DepthPriority_Offset), 0, DrawWireSphere_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_Thickness_Offset), 0, DrawWireSphere_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireSphere_DepthBias_Offset), 0, DrawWireSphere_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireSphere_bScreenSpace_Offset), 0, DrawWireSphere_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireSphere_FunctionAddress, intPtr, DrawWireSphere_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireDiamond")]
	public unsafe static void DrawWireDiamond(FJavascriptPDI PDI, FTransform Transform, float Size, FLinearColor InColor, ESceneDepthPriorityGroup DepthPriority)
	{
		if (!DrawWireDiamond_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireDiamond");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireDiamond_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireDiamond_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireDiamond_PDI_Offset), 0, DrawWireDiamond_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireDiamond_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireDiamond_Transform_Offset), 0, DrawWireDiamond_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireDiamond_Size_Offset), 0, DrawWireDiamond_Size_PropertyAddress.Address, Size);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireDiamond_InColor_Offset), 0, DrawWireDiamond_InColor_PropertyAddress.Address, InColor);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireDiamond_DepthPriority_Offset), 0, DrawWireDiamond_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireDiamond_FunctionAddress, intPtr, DrawWireDiamond_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCylinder")]
	public unsafe static void DrawWireCylinder(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, FVector Z, FLinearColor Color, float Radius, float HalfHeight, int NumSides, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireCylinder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCylinder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireCylinder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireCylinder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_PDI_Offset), 0, DrawWireCylinder_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Base_Offset), 0, DrawWireCylinder_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_X_Offset), 0, DrawWireCylinder_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Y_Offset), 0, DrawWireCylinder_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Z_Offset), 0, DrawWireCylinder_Z_PropertyAddress.Address, Z);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Color_Offset), 0, DrawWireCylinder_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Radius_Offset), 0, DrawWireCylinder_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_HalfHeight_Offset), 0, DrawWireCylinder_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_NumSides_Offset), 0, DrawWireCylinder_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_DepthPriority_Offset), 0, DrawWireCylinder_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_Thickness_Offset), 0, DrawWireCylinder_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_DepthBias_Offset), 0, DrawWireCylinder_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireCylinder_bScreenSpace_Offset), 0, DrawWireCylinder_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireCylinder_FunctionAddress, intPtr, DrawWireCylinder_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCone")]
	public unsafe static void DrawWireCone(FJavascriptPDI PDI, out List<FVector> Verts, FTransform Transform, float ConeRadius, float ConeAngle, int ConeSides, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCone");
			Verts = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireCone_PDI_Offset), 0, DrawWireCone_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireCone_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireCone_Transform_Offset), 0, DrawWireCone_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCone_ConeRadius_Offset), 0, DrawWireCone_ConeRadius_PropertyAddress.Address, ConeRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCone_ConeAngle_Offset), 0, DrawWireCone_ConeAngle_PropertyAddress.Address, ConeAngle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireCone_ConeSides_Offset), 0, DrawWireCone_ConeSides_PropertyAddress.Address, ConeSides);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireCone_Color_Offset), 0, DrawWireCone_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireCone_DepthPriority_Offset), 0, DrawWireCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCone_Thickness_Offset), 0, DrawWireCone_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCone_DepthBias_Offset), 0, DrawWireCone_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireCone_bScreenSpace_Offset), 0, DrawWireCone_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireCone_FunctionAddress, intPtr, DrawWireCone_ParamsSize);
		Verts = new TArrayCopyMarshaler<FVector>(1, DrawWireCone_Verts_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, DrawWireCone_Verts_Offset));
		NativeReflection.DestroyValue_InContainer(DrawWireCone_Verts_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireChoppedCone")]
	public unsafe static void DrawWireChoppedCone(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, FVector Z, FLinearColor Color, float Radius, float TopRadius, float HalfHeight, int NumSides, ESceneDepthPriorityGroup DepthPriority)
	{
		if (!DrawWireChoppedCone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireChoppedCone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireChoppedCone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireChoppedCone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_PDI_Offset), 0, DrawWireChoppedCone_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_Base_Offset), 0, DrawWireChoppedCone_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_X_Offset), 0, DrawWireChoppedCone_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_Y_Offset), 0, DrawWireChoppedCone_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_Z_Offset), 0, DrawWireChoppedCone_Z_PropertyAddress.Address, Z);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_Color_Offset), 0, DrawWireChoppedCone_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_Radius_Offset), 0, DrawWireChoppedCone_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_TopRadius_Offset), 0, DrawWireChoppedCone_TopRadius_PropertyAddress.Address, TopRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_HalfHeight_Offset), 0, DrawWireChoppedCone_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_NumSides_Offset), 0, DrawWireChoppedCone_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireChoppedCone_DepthPriority_Offset), 0, DrawWireChoppedCone_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireChoppedCone_FunctionAddress, intPtr, DrawWireChoppedCone_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCapsule")]
	public unsafe static void DrawWireCapsule(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, FVector Z, FLinearColor Color, float Radius, float HalfHeight, int NumSides, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireCapsule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCapsule");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireCapsule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireCapsule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_PDI_Offset), 0, DrawWireCapsule_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Base_Offset), 0, DrawWireCapsule_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_X_Offset), 0, DrawWireCapsule_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Y_Offset), 0, DrawWireCapsule_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Z_Offset), 0, DrawWireCapsule_Z_PropertyAddress.Address, Z);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Color_Offset), 0, DrawWireCapsule_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Radius_Offset), 0, DrawWireCapsule_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_HalfHeight_Offset), 0, DrawWireCapsule_HalfHeight_PropertyAddress.Address, HalfHeight);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_NumSides_Offset), 0, DrawWireCapsule_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_DepthPriority_Offset), 0, DrawWireCapsule_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_Thickness_Offset), 0, DrawWireCapsule_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_DepthBias_Offset), 0, DrawWireCapsule_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireCapsule_bScreenSpace_Offset), 0, DrawWireCapsule_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireCapsule_FunctionAddress, intPtr, DrawWireCapsule_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox2")]
	public unsafe static void DrawWireBox2(FJavascriptPDI PDI, FTransform Matrix, FBox Box, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireBox2_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox2");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireBox2_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireBox2_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_PDI_Offset), 0, DrawWireBox2_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawWireBox2_Matrix_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_Matrix_Offset), 0, DrawWireBox2_Matrix_PropertyAddress.Address, Matrix);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_Box_Offset), 0, DrawWireBox2_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_Color_Offset), 0, DrawWireBox2_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_DepthPriority_Offset), 0, DrawWireBox2_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_Thickness_Offset), 0, DrawWireBox2_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireBox2_DepthBias_Offset), 0, DrawWireBox2_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireBox2_bScreenSpace_Offset), 0, DrawWireBox2_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireBox2_FunctionAddress, intPtr, DrawWireBox2_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox")]
	public unsafe static void DrawWireBox(FJavascriptPDI PDI, FBox Box, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawWireBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawWireBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawWireBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawWireBox_PDI_Offset), 0, DrawWireBox_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, DrawWireBox_Box_Offset), 0, DrawWireBox_Box_PropertyAddress.Address, Box);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawWireBox_Color_Offset), 0, DrawWireBox_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawWireBox_DepthPriority_Offset), 0, DrawWireBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireBox_Thickness_Offset), 0, DrawWireBox_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawWireBox_DepthBias_Offset), 0, DrawWireBox_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawWireBox_bScreenSpace_Offset), 0, DrawWireBox_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawWireBox_FunctionAddress, intPtr, DrawWireBox_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawPolygon")]
	public unsafe static void DrawPolygon(FJavascriptPDI PDI, List<FVector> Verts, FLinearColor InColor, ESceneDepthPriorityGroup DepthPriority, EJavascriptRHIFeatureLevel RHIFeatureLevel)
	{
		if (!DrawPolygon_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawPolygon");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawPolygon_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawPolygon_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawPolygon_PDI_Offset), 0, DrawPolygon_PDI_PropertyAddress.Address, PDI);
		new TArrayCopyMarshaler<FVector>(1, DrawPolygon_Verts_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DrawPolygon_Verts_Offset), Verts);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawPolygon_InColor_Offset), 0, DrawPolygon_InColor_PropertyAddress.Address, InColor);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawPolygon_DepthPriority_Offset), 0, DrawPolygon_DepthPriority_PropertyAddress.Address, DepthPriority);
		EnumMarshaler<EJavascriptRHIFeatureLevel>.ToNative(IntPtr.Add(intPtr, DrawPolygon_RHIFeatureLevel_Offset), 0, DrawPolygon_RHIFeatureLevel_PropertyAddress.Address, RHIFeatureLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawPolygon_FunctionAddress, intPtr, DrawPolygon_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawPolygon_Verts_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawOrientedWireBox")]
	public unsafe static void DrawOrientedWireBox(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, FVector Z, FVector Extent, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawOrientedWireBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawOrientedWireBox");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawOrientedWireBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawOrientedWireBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_PDI_Offset), 0, DrawOrientedWireBox_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Base_Offset), 0, DrawOrientedWireBox_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_X_Offset), 0, DrawOrientedWireBox_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Y_Offset), 0, DrawOrientedWireBox_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Z_Offset), 0, DrawOrientedWireBox_Z_PropertyAddress.Address, Z);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Extent_Offset), 0, DrawOrientedWireBox_Extent_PropertyAddress.Address, Extent);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Color_Offset), 0, DrawOrientedWireBox_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_DepthPriority_Offset), 0, DrawOrientedWireBox_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_Thickness_Offset), 0, DrawOrientedWireBox_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_DepthBias_Offset), 0, DrawOrientedWireBox_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawOrientedWireBox_bScreenSpace_Offset), 0, DrawOrientedWireBox_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawOrientedWireBox_FunctionAddress, intPtr, DrawOrientedWireBox_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDirectionalArrow")]
	public unsafe static void DrawDirectionalArrow(FJavascriptPDI PDI, FTransform ArrowToWorld, FLinearColor InColor, float Length, float ArrowSize, ESceneDepthPriorityGroup DepthPriority, float Thickness)
	{
		if (!DrawDirectionalArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDirectionalArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawDirectionalArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawDirectionalArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_PDI_Offset), 0, DrawDirectionalArrow_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawDirectionalArrow_ArrowToWorld_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_ArrowToWorld_Offset), 0, DrawDirectionalArrow_ArrowToWorld_PropertyAddress.Address, ArrowToWorld);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_InColor_Offset), 0, DrawDirectionalArrow_InColor_PropertyAddress.Address, InColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_Length_Offset), 0, DrawDirectionalArrow_Length_PropertyAddress.Address, Length);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_ArrowSize_Offset), 0, DrawDirectionalArrow_ArrowSize_PropertyAddress.Address, ArrowSize);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_DepthPriority_Offset), 0, DrawDirectionalArrow_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDirectionalArrow_Thickness_Offset), 0, DrawDirectionalArrow_Thickness_PropertyAddress.Address, Thickness);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawDirectionalArrow_FunctionAddress, intPtr, DrawDirectionalArrow_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDashedLine")]
	public unsafe static void DrawDashedLine(FJavascriptPDI PDI, FVector Start, FVector End, FLinearColor Color, float DashSize, ESceneDepthPriorityGroup DepthPriority, float DepthBias)
	{
		if (!DrawDashedLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDashedLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawDashedLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawDashedLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_PDI_Offset), 0, DrawDashedLine_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_Start_Offset), 0, DrawDashedLine_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_End_Offset), 0, DrawDashedLine_End_PropertyAddress.Address, End);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_Color_Offset), 0, DrawDashedLine_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_DashSize_Offset), 0, DrawDashedLine_DashSize_PropertyAddress.Address, DashSize);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_DepthPriority_Offset), 0, DrawDashedLine_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDashedLine_DepthBias_Offset), 0, DrawDashedLine_DepthBias_PropertyAddress.Address, DepthBias);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawDashedLine_FunctionAddress, intPtr, DrawDashedLine_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawConnectedArrow")]
	public unsafe static void DrawConnectedArrow(FJavascriptPDI PDI, FTransform ArrowToWorld, FLinearColor Color, float ArrowHeight, float ArrowWidth, ESceneDepthPriorityGroup DepthPriority, float Thickness, int NumSpokes)
	{
		if (!DrawConnectedArrow_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawConnectedArrow");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawConnectedArrow_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawConnectedArrow_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_PDI_Offset), 0, DrawConnectedArrow_PDI_PropertyAddress.Address, PDI);
		NativeReflection.InitializeValue_InContainer(DrawConnectedArrow_ArrowToWorld_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_ArrowToWorld_Offset), 0, DrawConnectedArrow_ArrowToWorld_PropertyAddress.Address, ArrowToWorld);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_Color_Offset), 0, DrawConnectedArrow_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_ArrowHeight_Offset), 0, DrawConnectedArrow_ArrowHeight_PropertyAddress.Address, ArrowHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_ArrowWidth_Offset), 0, DrawConnectedArrow_ArrowWidth_PropertyAddress.Address, ArrowWidth);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_DepthPriority_Offset), 0, DrawConnectedArrow_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_Thickness_Offset), 0, DrawConnectedArrow_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawConnectedArrow_NumSpokes_Offset), 0, DrawConnectedArrow_NumSpokes_PropertyAddress.Address, NumSpokes);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawConnectedArrow_FunctionAddress, intPtr, DrawConnectedArrow_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawCircle")]
	public unsafe static void DrawCircle(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, FLinearColor Color, float Radius, int NumSides, ESceneDepthPriorityGroup DepthPriority, float Thickness, float DepthBias, bool bScreenSpace)
	{
		if (!DrawCircle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawCircle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawCircle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawCircle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawCircle_PDI_Offset), 0, DrawCircle_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawCircle_Base_Offset), 0, DrawCircle_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawCircle_X_Offset), 0, DrawCircle_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawCircle_Y_Offset), 0, DrawCircle_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawCircle_Color_Offset), 0, DrawCircle_Color_PropertyAddress.Address, Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawCircle_Radius_Offset), 0, DrawCircle_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawCircle_NumSides_Offset), 0, DrawCircle_NumSides_PropertyAddress.Address, NumSides);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawCircle_DepthPriority_Offset), 0, DrawCircle_DepthPriority_PropertyAddress.Address, DepthPriority);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawCircle_Thickness_Offset), 0, DrawCircle_Thickness_PropertyAddress.Address, Thickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawCircle_DepthBias_Offset), 0, DrawCircle_DepthBias_PropertyAddress.Address, DepthBias);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DrawCircle_bScreenSpace_Offset), 0, DrawCircle_bScreenSpace_PropertyAddress.Address, bScreenSpace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawCircle_FunctionAddress, intPtr, DrawCircle_ParamsSize);
	}

	[UFunction(Flags = 616834049u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawArc")]
	public unsafe static void DrawArc(FJavascriptPDI PDI, FVector Base, FVector X, FVector Y, float MinAngle, float MaxAngle, float Radius, int Sections, FLinearColor Color, ESceneDepthPriorityGroup DepthPriority)
	{
		if (!DrawArc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawArc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawArc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawArc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, DrawArc_PDI_Offset), 0, DrawArc_PDI_PropertyAddress.Address, PDI);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawArc_Base_Offset), 0, DrawArc_Base_PropertyAddress.Address, Base);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawArc_X_Offset), 0, DrawArc_X_PropertyAddress.Address, X);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawArc_Y_Offset), 0, DrawArc_Y_PropertyAddress.Address, Y);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawArc_MinAngle_Offset), 0, DrawArc_MinAngle_PropertyAddress.Address, MinAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawArc_MaxAngle_Offset), 0, DrawArc_MaxAngle_PropertyAddress.Address, MaxAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawArc_Radius_Offset), 0, DrawArc_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, DrawArc_Sections_Offset), 0, DrawArc_Sections_PropertyAddress.Address, Sections);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawArc_Color_Offset), 0, DrawArc_Color_PropertyAddress.Address, Color);
		EnumMarshaler<ESceneDepthPriorityGroup>.ToNative(IntPtr.Add(intPtr, DrawArc_DepthPriority_Offset), 0, DrawArc_DepthPriority_PropertyAddress.Address, DepthPriority);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawArc_FunctionAddress, intPtr, DrawArc_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DeselectAll")]
	public unsafe static void DeselectAll(USelection Selection, TSubclassOf<UObject> InClass)
	{
		if (!DeselectAll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DeselectAll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeselectAll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeselectAll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USelection>.ToNative(IntPtr.Add(intPtr, DeselectAll_Selection_Offset), 0, DeselectAll_Selection_PropertyAddress.Address, Selection);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DeselectAll_InClass_Offset), 0, DeselectAll_InClass_PropertyAddress.Address, InClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeselectAll_FunctionAddress, intPtr, DeselectAll_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:Deselect")]
	public unsafe static void Deselect(USelection Selection, UObject InObject)
	{
		if (!Deselect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:Deselect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Deselect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Deselect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USelection>.ToNative(IntPtr.Add(intPtr, Deselect_Selection_Offset), 0, Deselect_Selection_PropertyAddress.Address, Selection);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Deselect_InObject_Offset), 0, Deselect_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Deselect_FunctionAddress, intPtr, Deselect_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:DeletePackage")]
	public unsafe static bool DeletePackage(UPackage Package)
	{
		if (!DeletePackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:DeletePackage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeletePackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeletePackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, DeletePackage_Package_Offset), 0, DeletePackage_Package_PropertyAddress.Address, Package);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeletePackage_FunctionAddress, intPtr, DeletePackage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeletePackage_ReturnValue_Offset), 0, DeletePackage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:csgAdd")]
	public unsafe static ABrush csgAdd(ABrush DefaultBrush, int PolyFlags, EBrushType BrushType)
	{
		if (!csgAdd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:csgAdd");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(csgAdd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)csgAdd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABrush>.ToNative(IntPtr.Add(intPtr, csgAdd_DefaultBrush_Offset), 0, csgAdd_DefaultBrush_PropertyAddress.Address, DefaultBrush);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, csgAdd_PolyFlags_Offset), 0, csgAdd_PolyFlags_PropertyAddress.Address, PolyFlags);
		EnumMarshaler<EBrushType>.ToNative(IntPtr.Add(intPtr, csgAdd_BrushType_Offset), 0, csgAdd_BrushType_PropertyAddress.Address, BrushType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, csgAdd_FunctionAddress, intPtr, csgAdd_ParamsSize);
		return UObjectMarshaler<ABrush>.FromNative(IntPtr.Add(intPtr, csgAdd_ReturnValue_Offset), 0, csgAdd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:CreatePropertyEditorToolkit")]
	public unsafe static void CreatePropertyEditorToolkit(List<UObject> ObjectsForPropertiesMenu)
	{
		if (!CreatePropertyEditorToolkit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:CreatePropertyEditorToolkit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePropertyEditorToolkit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePropertyEditorToolkit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_Offset), ObjectsForPropertiesMenu);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreatePropertyEditorToolkit_FunctionAddress, intPtr, CreatePropertyEditorToolkit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListingWidget")]
	public unsafe static FJavascriptSlateWidget CreateLogListingWidget(FName InLogName)
	{
		if (!CreateLogListingWidget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListingWidget");
			return default(FJavascriptSlateWidget);
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLogListingWidget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLogListingWidget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateLogListingWidget_InLogName_Offset), 0, CreateLogListingWidget_InLogName_PropertyAddress.Address, InLogName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLogListingWidget_FunctionAddress, intPtr, CreateLogListingWidget_ParamsSize);
		FJavascriptSlateWidget result = FJavascriptSlateWidget.FromNative(IntPtr.Add(intPtr, CreateLogListingWidget_ReturnValue_Offset), 0, CreateLogListingWidget_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateLogListingWidget_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListing")]
	public unsafe static void CreateLogListing(FName InLogName, FText InLabel)
	{
		if (!CreateLogListing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLogListing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLogListing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateLogListing_InLogName_Offset), 0, CreateLogListing_InLogName_PropertyAddress.Address, InLogName);
		NativeReflection.InitializeValue_InContainer(CreateLogListing_InLabel_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, CreateLogListing_InLabel_Offset), 0, CreateLogListing_InLabel_PropertyAddress.Address, InLabel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLogListing_FunctionAddress, intPtr, CreateLogListing_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateLogListing_InLabel_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateBrushForVolumeActor")]
	public unsafe static void CreateBrushForVolumeActor(AVolume NewActor, UBrushBuilder BrushBuilder)
	{
		if (!CreateBrushForVolumeActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateBrushForVolumeActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBrushForVolumeActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBrushForVolumeActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AVolume>.ToNative(IntPtr.Add(intPtr, CreateBrushForVolumeActor_NewActor_Offset), 0, CreateBrushForVolumeActor_NewActor_PropertyAddress.Address, NewActor);
		UObjectMarshaler<UBrushBuilder>.ToNative(IntPtr.Add(intPtr, CreateBrushForVolumeActor_BrushBuilder_Offset), 0, CreateBrushForVolumeActor_BrushBuilder_PropertyAddress.Address, BrushBuilder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateBrushForVolumeActor_FunctionAddress, intPtr, CreateBrushForVolumeActor_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ConditionalBeginDestroybyUObject")]
	public unsafe static bool ConditionalBeginDestroybyUObject(UObject TargetObject)
	{
		if (!ConditionalBeginDestroybyUObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ConditionalBeginDestroybyUObject");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConditionalBeginDestroybyUObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConditionalBeginDestroybyUObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ConditionalBeginDestroybyUObject_TargetObject_Offset), 0, ConditionalBeginDestroybyUObject_TargetObject_PropertyAddress.Address, TargetObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConditionalBeginDestroybyUObject_FunctionAddress, intPtr, ConditionalBeginDestroybyUObject_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConditionalBeginDestroybyUObject_ReturnValue_Offset), 0, ConditionalBeginDestroybyUObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:CompileBlueprint")]
	public unsafe static void CompileBlueprint(UBlueprint Blueprint)
	{
		if (!CompileBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:CompileBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompileBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompileBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, CompileBlueprint_Blueprint_Offset), 0, CompileBlueprint_Blueprint_PropertyAddress.Address, Blueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CompileBlueprint_FunctionAddress, intPtr, CompileBlueprint_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:ClearActorLabel")]
	public unsafe static void ClearActorLabel(AActor Actor)
	{
		if (!ClearActorLabel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:ClearActorLabel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearActorLabel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearActorLabel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ClearActorLabel_Actor_Offset), 0, ClearActorLabel_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearActorLabel_FunctionAddress, intPtr, ClearActorLabel_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:Build")]
	public unsafe static bool Build(UBrushBuilder Builder, UWorld InWorld, ABrush InBrush)
	{
		if (!Build_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:Build");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Build_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Build_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBrushBuilder>.ToNative(IntPtr.Add(intPtr, Build_Builder_Offset), 0, Build_Builder_PropertyAddress.Address, Builder);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, Build_InWorld_Offset), 0, Build_InWorld_PropertyAddress.Address, InWorld);
		UObjectMarshaler<ABrush>.ToNative(IntPtr.Add(intPtr, Build_InBrush_Offset), 0, Build_InBrush_PropertyAddress.Address, InBrush);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Build_FunctionAddress, intPtr, Build_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Build_ReturnValue_Offset), 0, Build_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastHotReload")]
	public unsafe static void BroadcastHotReload()
	{
		if (!BroadcastHotReload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastHotReload");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BroadcastHotReload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BroadcastHotReload_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: BroadcastHotReload_FunctionAddress, argsSize: BroadcastHotReload_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastAssetCreated")]
	public unsafe static void BroadcastAssetCreated(UObject NewAsset)
	{
		if (!BroadcastAssetCreated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastAssetCreated");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BroadcastAssetCreated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BroadcastAssetCreated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BroadcastAssetCreated_NewAsset_Offset), 0, BroadcastAssetCreated_NewAsset_PropertyAddress.Address, NewAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BroadcastAssetCreated_FunctionAddress, intPtr, BroadcastAssetCreated_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddWhitelistedObject")]
	public unsafe static void AddWhitelistedObject(UObject InObject)
	{
		if (!AddWhitelistedObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddWhitelistedObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddWhitelistedObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddWhitelistedObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddWhitelistedObject_InObject_Offset), 0, AddWhitelistedObject_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddWhitelistedObject_FunctionAddress, intPtr, AddWhitelistedObject_ParamsSize);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddNewComponentToBlueprint")]
	public unsafe static UActorComponent AddNewComponentToBlueprint(TSubclassOf<UObject> NewComponentClass, UObject Asset)
	{
		if (!AddNewComponentToBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddNewComponentToBlueprint");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddNewComponentToBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddNewComponentToBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNewComponentToBlueprint_NewComponentClass_Offset), 0, AddNewComponentToBlueprint_NewComponentClass_PropertyAddress.Address, NewComponentClass);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddNewComponentToBlueprint_Asset_Offset), 0, AddNewComponentToBlueprint_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddNewComponentToBlueprint_FunctionAddress, intPtr, AddNewComponentToBlueprint_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, AddNewComponentToBlueprint_ReturnValue_Offset), 0, AddNewComponentToBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLogListingMessage")]
	public unsafe static void AddLogListingMessage(FName InLogName, EJavascriptMessageSeverity InSeverity, string LogText)
	{
		if (!AddLogListingMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLogListingMessage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLogListingMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLogListingMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddLogListingMessage_InLogName_Offset), 0, AddLogListingMessage_InLogName_PropertyAddress.Address, InLogName);
		EnumMarshaler<EJavascriptMessageSeverity>.ToNative(IntPtr.Add(intPtr, AddLogListingMessage_InSeverity_Offset), 0, AddLogListingMessage_InSeverity_PropertyAddress.Address, InSeverity);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddLogListingMessage_LogText_Offset), 0, AddLogListingMessage_LogText_PropertyAddress.Address, LogText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLogListingMessage_FunctionAddress, intPtr, AddLogListingMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLogListingMessage_LogText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLazyExtender")]
	public unsafe static void AddLazyExtender(FJavascriptExtensibilityManager Manager, UJavascriptLazyExtenderDelegates Delegates)
	{
		if (!AddLazyExtender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLazyExtender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLazyExtender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLazyExtender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddLazyExtender_Manager_PropertyAddress.Address, intPtr);
		FJavascriptExtensibilityManager.ToNative(IntPtr.Add(intPtr, AddLazyExtender_Manager_Offset), 0, AddLazyExtender_Manager_PropertyAddress.Address, Manager);
		UObjectMarshaler<UJavascriptLazyExtenderDelegates>.ToNative(IntPtr.Add(intPtr, AddLazyExtender_Delegates_Offset), 0, AddLazyExtender_Delegates_PropertyAddress.Address, Delegates);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLazyExtender_FunctionAddress, intPtr, AddLazyExtender_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddLazyExtender_Manager_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddGroup")]
	public unsafe static FJavascriptWorkspaceItem AddGroup(FJavascriptWorkspaceItem Parent, FText DisplayName)
	{
		if (!AddGroup_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddGroup");
			return default(FJavascriptWorkspaceItem);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGroup_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGroup_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddGroup_Parent_PropertyAddress.Address, intPtr);
		FJavascriptWorkspaceItem.ToNative(IntPtr.Add(intPtr, AddGroup_Parent_Offset), 0, AddGroup_Parent_PropertyAddress.Address, Parent);
		NativeReflection.InitializeValue_InContainer(AddGroup_DisplayName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, AddGroup_DisplayName_Offset), 0, AddGroup_DisplayName_PropertyAddress.Address, DisplayName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddGroup_FunctionAddress, intPtr, AddGroup_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddGroup_Parent_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddGroup_DisplayName_PropertyAddress.Address, intPtr);
		FJavascriptWorkspaceItem result = FJavascriptWorkspaceItem.FromNative(IntPtr.Add(intPtr, AddGroup_ReturnValue_Offset), 0, AddGroup_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddGroup_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604251137u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddExtender")]
	public unsafe static void AddExtender(FJavascriptExtensibilityManager Manager, FJavascriptExtender Extender)
	{
		if (!AddExtender_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddExtender");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddExtender_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddExtender_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddExtender_Manager_PropertyAddress.Address, intPtr);
		FJavascriptExtensibilityManager.ToNative(IntPtr.Add(intPtr, AddExtender_Manager_Offset), 0, AddExtender_Manager_PropertyAddress.Address, Manager);
		NativeReflection.InitializeValue_InContainer(AddExtender_Extender_PropertyAddress.Address, intPtr);
		FJavascriptExtender.ToNative(IntPtr.Add(intPtr, AddExtender_Extender_Offset), 0, AddExtender_Extender_PropertyAddress.Address, Extender);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddExtender_FunctionAddress, intPtr, AddExtender_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddExtender_Manager_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddExtender_Extender_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608445441u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorLibrary:AddComponentsToBlueprint")]
	public unsafe static void AddComponentsToBlueprint(UBlueprint Blueprint, List<UActorComponent> Components, bool bHarvesting, UActorComponent OptionalNewRootComponent, bool bKeepMobility)
	{
		if (!AddComponentsToBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorLibrary:AddComponentsToBlueprint");
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
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_OptionalNewRootComponent_Offset), 0, AddComponentsToBlueprint_OptionalNewRootComponent_PropertyAddress.Address, OptionalNewRootComponent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddComponentsToBlueprint_bKeepMobility_Offset), 0, AddComponentsToBlueprint_bKeepMobility_PropertyAddress.Address, bKeepMobility);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddComponentsToBlueprint_FunctionAddress, intPtr, AddComponentsToBlueprint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddComponentsToBlueprint_Components_PropertyAddress.Address, intPtr);
	}

	static UJavascriptEditorLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorLibrary");
		UpdateModelComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateModelComponents");
		UpdateModelComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateModelComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateModelComponents_Level_PropertyAddress, UpdateModelComponents_FunctionAddress, "Level");
		UpdateModelComponents_Level_Offset = NativeReflectionCached.GetPropertyOffset(UpdateModelComponents_FunctionAddress, "Level");
		UpdateModelComponents_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateModelComponents_FunctionAddress, "Level", Classes.FObjectProperty);
		UpdateModelComponents_IsValid = UpdateModelComponents_FunctionAddress != IntPtr.Zero && UpdateModelComponents_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:UpdateModelComponents", UpdateModelComponents_IsValid);
		ToggleSelect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleSelect");
		ToggleSelect_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleSelect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleSelect_Selection_PropertyAddress, ToggleSelect_FunctionAddress, "Selection");
		ToggleSelect_Selection_Offset = NativeReflectionCached.GetPropertyOffset(ToggleSelect_FunctionAddress, "Selection");
		ToggleSelect_Selection_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleSelect_FunctionAddress, "Selection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ToggleSelect_InObject_PropertyAddress, ToggleSelect_FunctionAddress, "InObject");
		ToggleSelect_InObject_Offset = NativeReflectionCached.GetPropertyOffset(ToggleSelect_FunctionAddress, "InObject");
		ToggleSelect_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleSelect_FunctionAddress, "InObject", Classes.FObjectProperty);
		ToggleSelect_IsValid = ToggleSelect_FunctionAddress != IntPtr.Zero && ToggleSelect_Selection_IsValid && ToggleSelect_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleSelect", ToggleSelect_IsValid);
		ToggleIsExecuteTestModePIE_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleIsExecuteTestModePIE");
		ToggleIsExecuteTestModePIE_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleIsExecuteTestModePIE_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleIsExecuteTestModePIE_ReturnValue_PropertyAddress, ToggleIsExecuteTestModePIE_FunctionAddress, "ReturnValue");
		ToggleIsExecuteTestModePIE_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToggleIsExecuteTestModePIE_FunctionAddress, "ReturnValue");
		ToggleIsExecuteTestModePIE_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleIsExecuteTestModePIE_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ToggleIsExecuteTestModePIE_IsValid = ToggleIsExecuteTestModePIE_FunctionAddress != IntPtr.Zero && ToggleIsExecuteTestModePIE_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ToggleIsExecuteTestModePIE", ToggleIsExecuteTestModePIE_IsValid);
		SetIsTemporarilyHiddenInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIsTemporarilyHiddenInEditor");
		SetIsTemporarilyHiddenInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsTemporarilyHiddenInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsTemporarilyHiddenInEditor_Actor_PropertyAddress, SetIsTemporarilyHiddenInEditor_FunctionAddress, "Actor");
		SetIsTemporarilyHiddenInEditor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetIsTemporarilyHiddenInEditor_FunctionAddress, "Actor");
		SetIsTemporarilyHiddenInEditor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsTemporarilyHiddenInEditor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIsTemporarilyHiddenInEditor_bIsHidden_PropertyAddress, SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden");
		SetIsTemporarilyHiddenInEditor_bIsHidden_Offset = NativeReflectionCached.GetPropertyOffset(SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden");
		SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsTemporarilyHiddenInEditor_FunctionAddress, "bIsHidden", Classes.FBoolProperty);
		SetIsTemporarilyHiddenInEditor_IsValid = SetIsTemporarilyHiddenInEditor_FunctionAddress != IntPtr.Zero && SetIsTemporarilyHiddenInEditor_Actor_IsValid && SetIsTemporarilyHiddenInEditor_bIsHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetIsTemporarilyHiddenInEditor", SetIsTemporarilyHiddenInEditor_IsValid);
		SetHitProxy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetHitProxy");
		SetHitProxy_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHitProxy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHitProxy_PDI_PropertyAddress, SetHitProxy_FunctionAddress, "PDI");
		SetHitProxy_PDI_Offset = NativeReflectionCached.GetPropertyOffset(SetHitProxy_FunctionAddress, "PDI");
		SetHitProxy_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitProxy_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHitProxy_Name_PropertyAddress, SetHitProxy_FunctionAddress, "Name");
		SetHitProxy_Name_Offset = NativeReflectionCached.GetPropertyOffset(SetHitProxy_FunctionAddress, "Name");
		SetHitProxy_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHitProxy_FunctionAddress, "Name", Classes.FNameProperty);
		SetHitProxy_IsValid = SetHitProxy_FunctionAddress != IntPtr.Zero && SetHitProxy_PDI_IsValid && SetHitProxy_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHitProxy", SetHitProxy_IsValid);
		SetHeightmapDataFromMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetHeightmapDataFromMemory");
		SetHeightmapDataFromMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHeightmapDataFromMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHeightmapDataFromMemory_LandscapeInfo_PropertyAddress, SetHeightmapDataFromMemory_FunctionAddress, "LandscapeInfo");
		SetHeightmapDataFromMemory_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightmapDataFromMemory_FunctionAddress, "LandscapeInfo");
		SetHeightmapDataFromMemory_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightmapDataFromMemory_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHeightmapDataFromMemory_MinX_PropertyAddress, SetHeightmapDataFromMemory_FunctionAddress, "MinX");
		SetHeightmapDataFromMemory_MinX_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightmapDataFromMemory_FunctionAddress, "MinX");
		SetHeightmapDataFromMemory_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightmapDataFromMemory_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHeightmapDataFromMemory_MinY_PropertyAddress, SetHeightmapDataFromMemory_FunctionAddress, "MinY");
		SetHeightmapDataFromMemory_MinY_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightmapDataFromMemory_FunctionAddress, "MinY");
		SetHeightmapDataFromMemory_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightmapDataFromMemory_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHeightmapDataFromMemory_MaxX_PropertyAddress, SetHeightmapDataFromMemory_FunctionAddress, "MaxX");
		SetHeightmapDataFromMemory_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightmapDataFromMemory_FunctionAddress, "MaxX");
		SetHeightmapDataFromMemory_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightmapDataFromMemory_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetHeightmapDataFromMemory_MaxY_PropertyAddress, SetHeightmapDataFromMemory_FunctionAddress, "MaxY");
		SetHeightmapDataFromMemory_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightmapDataFromMemory_FunctionAddress, "MaxY");
		SetHeightmapDataFromMemory_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightmapDataFromMemory_FunctionAddress, "MaxY", Classes.FIntProperty);
		SetHeightmapDataFromMemory_IsValid = SetHeightmapDataFromMemory_FunctionAddress != IntPtr.Zero && SetHeightmapDataFromMemory_LandscapeInfo_IsValid && SetHeightmapDataFromMemory_MinX_IsValid && SetHeightmapDataFromMemory_MinY_IsValid && SetHeightmapDataFromMemory_MaxX_IsValid && SetHeightmapDataFromMemory_MaxY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetHeightmapDataFromMemory", SetHeightmapDataFromMemory_IsValid);
		SetFolderPath_Recursively_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFolderPath_Recursively");
		SetFolderPath_Recursively_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFolderPath_Recursively_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFolderPath_Recursively_Actor_PropertyAddress, SetFolderPath_Recursively_FunctionAddress, "Actor");
		SetFolderPath_Recursively_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderPath_Recursively_FunctionAddress, "Actor");
		SetFolderPath_Recursively_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderPath_Recursively_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderPath_Recursively_NewFolderPath_PropertyAddress, SetFolderPath_Recursively_FunctionAddress, "NewFolderPath");
		SetFolderPath_Recursively_NewFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderPath_Recursively_FunctionAddress, "NewFolderPath");
		SetFolderPath_Recursively_NewFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderPath_Recursively_FunctionAddress, "NewFolderPath", Classes.FNameProperty);
		SetFolderPath_Recursively_IsValid = SetFolderPath_Recursively_FunctionAddress != IntPtr.Zero && SetFolderPath_Recursively_Actor_IsValid && SetFolderPath_Recursively_NewFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath_Recursively", SetFolderPath_Recursively_IsValid);
		SetFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFolderPath");
		SetFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFolderPath_Actor_PropertyAddress, SetFolderPath_FunctionAddress, "Actor");
		SetFolderPath_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderPath_FunctionAddress, "Actor");
		SetFolderPath_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderPath_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderPath_NewFolderPath_PropertyAddress, SetFolderPath_FunctionAddress, "NewFolderPath");
		SetFolderPath_NewFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderPath_FunctionAddress, "NewFolderPath");
		SetFolderPath_NewFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderPath_FunctionAddress, "NewFolderPath", Classes.FNameProperty);
		SetFolderPath_IsValid = SetFolderPath_FunctionAddress != IntPtr.Zero && SetFolderPath_Actor_IsValid && SetFolderPath_NewFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetFolderPath", SetFolderPath_IsValid);
		SetAlphamapDataFromMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAlphamapDataFromMemory");
		SetAlphamapDataFromMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAlphamapDataFromMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_LandscapeInfo_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "LandscapeInfo");
		SetAlphamapDataFromMemory_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "LandscapeInfo");
		SetAlphamapDataFromMemory_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_LayerInfo_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "LayerInfo");
		SetAlphamapDataFromMemory_LayerInfo_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "LayerInfo");
		SetAlphamapDataFromMemory_LayerInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "LayerInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_MinX_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "MinX");
		SetAlphamapDataFromMemory_MinX_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "MinX");
		SetAlphamapDataFromMemory_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_MinY_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "MinY");
		SetAlphamapDataFromMemory_MinY_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "MinY");
		SetAlphamapDataFromMemory_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_MaxX_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "MaxX");
		SetAlphamapDataFromMemory_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "MaxX");
		SetAlphamapDataFromMemory_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_MaxY_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "MaxY");
		SetAlphamapDataFromMemory_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "MaxY");
		SetAlphamapDataFromMemory_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "MaxY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAlphamapDataFromMemory_PaintingRestriction_PropertyAddress, SetAlphamapDataFromMemory_FunctionAddress, "PaintingRestriction");
		SetAlphamapDataFromMemory_PaintingRestriction_Offset = NativeReflectionCached.GetPropertyOffset(SetAlphamapDataFromMemory_FunctionAddress, "PaintingRestriction");
		SetAlphamapDataFromMemory_PaintingRestriction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAlphamapDataFromMemory_FunctionAddress, "PaintingRestriction", Classes.FEnumProperty);
		SetAlphamapDataFromMemory_IsValid = SetAlphamapDataFromMemory_FunctionAddress != IntPtr.Zero && SetAlphamapDataFromMemory_LandscapeInfo_IsValid && SetAlphamapDataFromMemory_LayerInfo_IsValid && SetAlphamapDataFromMemory_MinX_IsValid && SetAlphamapDataFromMemory_MinY_IsValid && SetAlphamapDataFromMemory_MaxX_IsValid && SetAlphamapDataFromMemory_MaxY_IsValid && SetAlphamapDataFromMemory_PaintingRestriction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetAlphamapDataFromMemory", SetAlphamapDataFromMemory_IsValid);
		SetActorLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLocation");
		SetActorLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_Actor_PropertyAddress, SetActorLocation_FunctionAddress, "Actor");
		SetActorLocation_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "Actor");
		SetActorLocation_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_NewLocation_PropertyAddress, SetActorLocation_FunctionAddress, "NewLocation");
		SetActorLocation_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "NewLocation");
		SetActorLocation_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_bSweep_PropertyAddress, SetActorLocation_FunctionAddress, "bSweep");
		SetActorLocation_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "bSweep");
		SetActorLocation_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_SweepHitResult_PropertyAddress, SetActorLocation_FunctionAddress, "SweepHitResult");
		SetActorLocation_SweepHitResult_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "SweepHitResult");
		SetActorLocation_SweepHitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "SweepHitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_bTeleport_PropertyAddress, SetActorLocation_FunctionAddress, "bTeleport");
		SetActorLocation_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "bTeleport");
		SetActorLocation_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLocation_ReturnValue_PropertyAddress, SetActorLocation_FunctionAddress, "ReturnValue");
		SetActorLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLocation_FunctionAddress, "ReturnValue");
		SetActorLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLocation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetActorLocation_IsValid = SetActorLocation_FunctionAddress != IntPtr.Zero && SetActorLocation_Actor_IsValid && SetActorLocation_NewLocation_IsValid && SetActorLocation_bSweep_IsValid && SetActorLocation_SweepHitResult_IsValid && SetActorLocation_bTeleport_IsValid && SetActorLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLocation", SetActorLocation_IsValid);
		SetActorLabelUnique_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLabelUnique");
		SetActorLabelUnique_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLabelUnique_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabelUnique_Actor_PropertyAddress, SetActorLabelUnique_FunctionAddress, "Actor");
		SetActorLabelUnique_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabelUnique_FunctionAddress, "Actor");
		SetActorLabelUnique_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabelUnique_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabelUnique_NewActorLabel_PropertyAddress, SetActorLabelUnique_FunctionAddress, "NewActorLabel");
		SetActorLabelUnique_NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabelUnique_FunctionAddress, "NewActorLabel");
		SetActorLabelUnique_NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabelUnique_FunctionAddress, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabelUnique_InExistingActorLabels_PropertyAddress, SetActorLabelUnique_FunctionAddress, "InExistingActorLabels");
		SetActorLabelUnique_InExistingActorLabels_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabelUnique_FunctionAddress, "InExistingActorLabels");
		SetActorLabelUnique_InExistingActorLabels_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabelUnique_FunctionAddress, "InExistingActorLabels", Classes.FArrayProperty);
		SetActorLabelUnique_IsValid = SetActorLabelUnique_FunctionAddress != IntPtr.Zero && SetActorLabelUnique_Actor_IsValid && SetActorLabelUnique_NewActorLabel_IsValid && SetActorLabelUnique_InExistingActorLabels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabelUnique", SetActorLabelUnique_IsValid);
		SetActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLabel");
		SetActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_Actor_PropertyAddress, SetActorLabel_FunctionAddress, "Actor");
		SetActorLabel_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "Actor");
		SetActorLabel_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_NewActorLabel_PropertyAddress, SetActorLabel_FunctionAddress, "NewActorLabel");
		SetActorLabel_NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "NewActorLabel");
		SetActorLabel_NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLabel_bMarkDirty_PropertyAddress, SetActorLabel_FunctionAddress, "bMarkDirty");
		SetActorLabel_bMarkDirty_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLabel_FunctionAddress, "bMarkDirty");
		SetActorLabel_bMarkDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLabel_FunctionAddress, "bMarkDirty", Classes.FBoolProperty);
		SetActorLabel_IsValid = SetActorLabel_FunctionAddress != IntPtr.Zero && SetActorLabel_Actor_IsValid && SetActorLabel_NewActorLabel_IsValid && SetActorLabel_bMarkDirty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SetActorLabel", SetActorLabel_IsValid);
		Select_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Select");
		Select_ParamsSize = NativeReflection.GetFunctionParamsSize(Select_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Select_Selection_PropertyAddress, Select_FunctionAddress, "Selection");
		Select_Selection_Offset = NativeReflectionCached.GetPropertyOffset(Select_FunctionAddress, "Selection");
		Select_Selection_IsValid = NativeReflectionCached.ValidatePropertyClass(Select_FunctionAddress, "Selection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Select_InObject_PropertyAddress, Select_FunctionAddress, "InObject");
		Select_InObject_Offset = NativeReflectionCached.GetPropertyOffset(Select_FunctionAddress, "InObject");
		Select_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(Select_FunctionAddress, "InObject", Classes.FObjectProperty);
		Select_IsValid = Select_FunctionAddress != IntPtr.Zero && Select_Selection_IsValid && Select_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:Select", Select_IsValid);
		SavePackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SavePackage");
		SavePackage_ParamsSize = NativeReflection.GetFunctionParamsSize(SavePackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SavePackage_Package_PropertyAddress, SavePackage_FunctionAddress, "Package");
		SavePackage_Package_Offset = NativeReflectionCached.GetPropertyOffset(SavePackage_FunctionAddress, "Package");
		SavePackage_Package_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePackage_FunctionAddress, "Package", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SavePackage_FileName_PropertyAddress, SavePackage_FunctionAddress, "FileName");
		SavePackage_FileName_Offset = NativeReflectionCached.GetPropertyOffset(SavePackage_FunctionAddress, "FileName");
		SavePackage_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePackage_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SavePackage_ReturnValue_PropertyAddress, SavePackage_FunctionAddress, "ReturnValue");
		SavePackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SavePackage_FunctionAddress, "ReturnValue");
		SavePackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePackage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SavePackage_IsValid = SavePackage_FunctionAddress != IntPtr.Zero && SavePackage_Package_IsValid && SavePackage_FileName_IsValid && SavePackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:SavePackage", SavePackage_IsValid);
		RequestEndPlayMapInPIE_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestEndPlayMapInPIE");
		RequestEndPlayMapInPIE_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestEndPlayMapInPIE_FunctionAddress);
		RequestEndPlayMapInPIE_IsValid = RequestEndPlayMapInPIE_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:RequestEndPlayMapInPIE", RequestEndPlayMapInPIE_IsValid);
		ReplaceAnimNotifyClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceAnimNotifyClass");
		ReplaceAnimNotifyClass_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAnimNotifyClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyClass_Sequence_PropertyAddress, ReplaceAnimNotifyClass_FunctionAddress, "Sequence");
		ReplaceAnimNotifyClass_Sequence_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyClass_FunctionAddress, "Sequence");
		ReplaceAnimNotifyClass_Sequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyClass_FunctionAddress, "Sequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyClass_NotifyName_PropertyAddress, ReplaceAnimNotifyClass_FunctionAddress, "NotifyName");
		ReplaceAnimNotifyClass_NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyClass_FunctionAddress, "NotifyName");
		ReplaceAnimNotifyClass_NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyClass_FunctionAddress, "NotifyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyClass_NewNotifyName_PropertyAddress, ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyName");
		ReplaceAnimNotifyClass_NewNotifyName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyName");
		ReplaceAnimNotifyClass_NewNotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyClass_NewNotifyClass_PropertyAddress, ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifyClass_NewNotifyClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyClass");
		ReplaceAnimNotifyClass_NewNotifyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyClass_FunctionAddress, "NewNotifyClass", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAnimNotifyClass_ReturnValue_PropertyAddress, ReplaceAnimNotifyClass_FunctionAddress, "ReturnValue");
		ReplaceAnimNotifyClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAnimNotifyClass_FunctionAddress, "ReturnValue");
		ReplaceAnimNotifyClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAnimNotifyClass_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ReplaceAnimNotifyClass_IsValid = ReplaceAnimNotifyClass_FunctionAddress != IntPtr.Zero && ReplaceAnimNotifyClass_Sequence_IsValid && ReplaceAnimNotifyClass_NotifyName_IsValid && ReplaceAnimNotifyClass_NewNotifyName_IsValid && ReplaceAnimNotifyClass_NewNotifyClass_IsValid && ReplaceAnimNotifyClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ReplaceAnimNotifyClass", ReplaceAnimNotifyClass_IsValid);
		RemoveLevelInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveLevelInstance");
		RemoveLevelInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLevelInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLevelInstance_World_PropertyAddress, RemoveLevelInstance_FunctionAddress, "World");
		RemoveLevelInstance_World_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLevelInstance_FunctionAddress, "World");
		RemoveLevelInstance_World_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLevelInstance_FunctionAddress, "World", Classes.FObjectProperty);
		RemoveLevelInstance_IsValid = RemoveLevelInstance_FunctionAddress != IntPtr.Zero && RemoveLevelInstance_World_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveLevelInstance", RemoveLevelInstance_IsValid);
		RemoveExtender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveExtender");
		RemoveExtender_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveExtender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveExtender_Manager_PropertyAddress, RemoveExtender_FunctionAddress, "Manager");
		RemoveExtender_Manager_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExtender_FunctionAddress, "Manager");
		RemoveExtender_Manager_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExtender_FunctionAddress, "Manager", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveExtender_Extender_PropertyAddress, RemoveExtender_FunctionAddress, "Extender");
		RemoveExtender_Extender_Offset = NativeReflectionCached.GetPropertyOffset(RemoveExtender_FunctionAddress, "Extender");
		RemoveExtender_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveExtender_FunctionAddress, "Extender", Classes.FStructProperty);
		RemoveExtender_IsValid = RemoveExtender_FunctionAddress != IntPtr.Zero && RemoveExtender_Manager_IsValid && RemoveExtender_Extender_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveExtender", RemoveExtender_IsValid);
		RemoveComponentFromBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveComponentFromBlueprint");
		RemoveComponentFromBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveComponentFromBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveComponentFromBlueprint_Blueprint_PropertyAddress, RemoveComponentFromBlueprint_FunctionAddress, "Blueprint");
		RemoveComponentFromBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(RemoveComponentFromBlueprint_FunctionAddress, "Blueprint");
		RemoveComponentFromBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveComponentFromBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveComponentFromBlueprint_RemoveComponent_PropertyAddress, RemoveComponentFromBlueprint_FunctionAddress, "RemoveComponent");
		RemoveComponentFromBlueprint_RemoveComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveComponentFromBlueprint_FunctionAddress, "RemoveComponent");
		RemoveComponentFromBlueprint_RemoveComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveComponentFromBlueprint_FunctionAddress, "RemoveComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveComponentFromBlueprint_bPromoteChildren_PropertyAddress, RemoveComponentFromBlueprint_FunctionAddress, "bPromoteChildren");
		RemoveComponentFromBlueprint_bPromoteChildren_Offset = NativeReflectionCached.GetPropertyOffset(RemoveComponentFromBlueprint_FunctionAddress, "bPromoteChildren");
		RemoveComponentFromBlueprint_bPromoteChildren_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveComponentFromBlueprint_FunctionAddress, "bPromoteChildren", Classes.FBoolProperty);
		RemoveComponentFromBlueprint_IsValid = RemoveComponentFromBlueprint_FunctionAddress != IntPtr.Zero && RemoveComponentFromBlueprint_Blueprint_IsValid && RemoveComponentFromBlueprint_RemoveComponent_IsValid && RemoveComponentFromBlueprint_bPromoteChildren_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveComponentFromBlueprint", RemoveComponentFromBlueprint_IsValid);
		RemoveAllLazyExtender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAllLazyExtender");
		RemoveAllLazyExtender_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAllLazyExtender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAllLazyExtender_Manager_PropertyAddress, RemoveAllLazyExtender_FunctionAddress, "Manager");
		RemoveAllLazyExtender_Manager_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAllLazyExtender_FunctionAddress, "Manager");
		RemoveAllLazyExtender_Manager_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAllLazyExtender_FunctionAddress, "Manager", Classes.FStructProperty);
		RemoveAllLazyExtender_IsValid = RemoveAllLazyExtender_FunctionAddress != IntPtr.Zero && RemoveAllLazyExtender_Manager_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:RemoveAllLazyExtender", RemoveAllLazyExtender_IsValid);
		PostEditChange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostEditChange");
		PostEditChange_ParamsSize = NativeReflection.GetFunctionParamsSize(PostEditChange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostEditChange_InObject_PropertyAddress, PostEditChange_FunctionAddress, "InObject");
		PostEditChange_InObject_Offset = NativeReflectionCached.GetPropertyOffset(PostEditChange_FunctionAddress, "InObject");
		PostEditChange_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(PostEditChange_FunctionAddress, "InObject", Classes.FObjectProperty);
		PostEditChange_IsValid = PostEditChange_FunctionAddress != IntPtr.Zero && PostEditChange_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:PostEditChange", PostEditChange_IsValid);
		OpenPopupWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenPopupWindow");
		OpenPopupWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenPopupWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenPopupWindow_Widget_PropertyAddress, OpenPopupWindow_FunctionAddress, "Widget");
		OpenPopupWindow_Widget_Offset = NativeReflectionCached.GetPropertyOffset(OpenPopupWindow_FunctionAddress, "Widget");
		OpenPopupWindow_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPopupWindow_FunctionAddress, "Widget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenPopupWindow_PopupDesiredSize_PropertyAddress, OpenPopupWindow_FunctionAddress, "PopupDesiredSize");
		OpenPopupWindow_PopupDesiredSize_Offset = NativeReflectionCached.GetPropertyOffset(OpenPopupWindow_FunctionAddress, "PopupDesiredSize");
		OpenPopupWindow_PopupDesiredSize_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPopupWindow_FunctionAddress, "PopupDesiredSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenPopupWindow_HeadingText_PropertyAddress, OpenPopupWindow_FunctionAddress, "HeadingText");
		OpenPopupWindow_HeadingText_Offset = NativeReflectionCached.GetPropertyOffset(OpenPopupWindow_FunctionAddress, "HeadingText");
		OpenPopupWindow_HeadingText_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenPopupWindow_FunctionAddress, "HeadingText", Classes.FTextProperty);
		OpenPopupWindow_IsValid = OpenPopupWindow_FunctionAddress != IntPtr.Zero && OpenPopupWindow_Widget_IsValid && OpenPopupWindow_PopupDesiredSize_IsValid && OpenPopupWindow_HeadingText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenPopupWindow", OpenPopupWindow_IsValid);
		OpenFileDialog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenFileDialog");
		OpenFileDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenFileDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_WindowHandle_PropertyAddress, OpenFileDialog_FunctionAddress, "WindowHandle");
		OpenFileDialog_WindowHandle_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "WindowHandle");
		OpenFileDialog_WindowHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "WindowHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_DialogTitle_PropertyAddress, OpenFileDialog_FunctionAddress, "DialogTitle");
		OpenFileDialog_DialogTitle_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "DialogTitle");
		OpenFileDialog_DialogTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "DialogTitle", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_DefaultPath_PropertyAddress, OpenFileDialog_FunctionAddress, "DefaultPath");
		OpenFileDialog_DefaultPath_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "DefaultPath");
		OpenFileDialog_DefaultPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "DefaultPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_DefaultFile_PropertyAddress, OpenFileDialog_FunctionAddress, "DefaultFile");
		OpenFileDialog_DefaultFile_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "DefaultFile");
		OpenFileDialog_DefaultFile_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "DefaultFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_FileTypes_PropertyAddress, OpenFileDialog_FunctionAddress, "FileTypes");
		OpenFileDialog_FileTypes_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "FileTypes");
		OpenFileDialog_FileTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "FileTypes", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_Flags_PropertyAddress, OpenFileDialog_FunctionAddress, "Flags");
		OpenFileDialog_Flags_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "Flags");
		OpenFileDialog_Flags_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "Flags", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_OutFilenames_PropertyAddress, OpenFileDialog_FunctionAddress, "OutFilenames");
		OpenFileDialog_OutFilenames_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "OutFilenames");
		OpenFileDialog_OutFilenames_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "OutFilenames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenFileDialog_ReturnValue_PropertyAddress, OpenFileDialog_FunctionAddress, "ReturnValue");
		OpenFileDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileDialog_FunctionAddress, "ReturnValue");
		OpenFileDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileDialog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenFileDialog_IsValid = OpenFileDialog_FunctionAddress != IntPtr.Zero && OpenFileDialog_WindowHandle_IsValid && OpenFileDialog_DialogTitle_IsValid && OpenFileDialog_DefaultPath_IsValid && OpenFileDialog_DefaultFile_IsValid && OpenFileDialog_FileTypes_IsValid && OpenFileDialog_Flags_IsValid && OpenFileDialog_OutFilenames_IsValid && OpenFileDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenFileDialog", OpenFileDialog_IsValid);
		OpenEditorForAssetByPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenEditorForAssetByPath");
		OpenEditorForAssetByPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenEditorForAssetByPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAssetByPath_AssetPathName_PropertyAddress, OpenEditorForAssetByPath_FunctionAddress, "AssetPathName");
		OpenEditorForAssetByPath_AssetPathName_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAssetByPath_FunctionAddress, "AssetPathName");
		OpenEditorForAssetByPath_AssetPathName_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAssetByPath_FunctionAddress, "AssetPathName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAssetByPath_ObjectName_PropertyAddress, OpenEditorForAssetByPath_FunctionAddress, "ObjectName");
		OpenEditorForAssetByPath_ObjectName_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAssetByPath_FunctionAddress, "ObjectName");
		OpenEditorForAssetByPath_ObjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAssetByPath_FunctionAddress, "ObjectName", Classes.FStrProperty);
		OpenEditorForAssetByPath_IsValid = OpenEditorForAssetByPath_FunctionAddress != IntPtr.Zero && OpenEditorForAssetByPath_AssetPathName_IsValid && OpenEditorForAssetByPath_ObjectName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAssetByPath", OpenEditorForAssetByPath_IsValid);
		OpenEditorForAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenEditorForAsset");
		OpenEditorForAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenEditorForAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAsset_Asset_PropertyAddress, OpenEditorForAsset_FunctionAddress, "Asset");
		OpenEditorForAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAsset_FunctionAddress, "Asset");
		OpenEditorForAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenEditorForAsset_ReturnValue_PropertyAddress, OpenEditorForAsset_FunctionAddress, "ReturnValue");
		OpenEditorForAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenEditorForAsset_FunctionAddress, "ReturnValue");
		OpenEditorForAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenEditorForAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenEditorForAsset_IsValid = OpenEditorForAsset_FunctionAddress != IntPtr.Zero && OpenEditorForAsset_Asset_IsValid && OpenEditorForAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenEditorForAsset", OpenEditorForAsset_IsValid);
		OpenDirectoryDialog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenDirectoryDialog");
		OpenDirectoryDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenDirectoryDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenDirectoryDialog_WindowHandle_PropertyAddress, OpenDirectoryDialog_FunctionAddress, "WindowHandle");
		OpenDirectoryDialog_WindowHandle_Offset = NativeReflectionCached.GetPropertyOffset(OpenDirectoryDialog_FunctionAddress, "WindowHandle");
		OpenDirectoryDialog_WindowHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenDirectoryDialog_FunctionAddress, "WindowHandle", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenDirectoryDialog_DialogTitle_PropertyAddress, OpenDirectoryDialog_FunctionAddress, "DialogTitle");
		OpenDirectoryDialog_DialogTitle_Offset = NativeReflectionCached.GetPropertyOffset(OpenDirectoryDialog_FunctionAddress, "DialogTitle");
		OpenDirectoryDialog_DialogTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenDirectoryDialog_FunctionAddress, "DialogTitle", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenDirectoryDialog_DefaultPath_PropertyAddress, OpenDirectoryDialog_FunctionAddress, "DefaultPath");
		OpenDirectoryDialog_DefaultPath_Offset = NativeReflectionCached.GetPropertyOffset(OpenDirectoryDialog_FunctionAddress, "DefaultPath");
		OpenDirectoryDialog_DefaultPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenDirectoryDialog_FunctionAddress, "DefaultPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenDirectoryDialog_OutFolderName_PropertyAddress, OpenDirectoryDialog_FunctionAddress, "OutFolderName");
		OpenDirectoryDialog_OutFolderName_Offset = NativeReflectionCached.GetPropertyOffset(OpenDirectoryDialog_FunctionAddress, "OutFolderName");
		OpenDirectoryDialog_OutFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenDirectoryDialog_FunctionAddress, "OutFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenDirectoryDialog_ReturnValue_PropertyAddress, OpenDirectoryDialog_FunctionAddress, "ReturnValue");
		OpenDirectoryDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenDirectoryDialog_FunctionAddress, "ReturnValue");
		OpenDirectoryDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenDirectoryDialog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenDirectoryDialog_IsValid = OpenDirectoryDialog_FunctionAddress != IntPtr.Zero && OpenDirectoryDialog_WindowHandle_IsValid && OpenDirectoryDialog_DialogTitle_IsValid && OpenDirectoryDialog_DefaultPath_IsValid && OpenDirectoryDialog_OutFolderName_IsValid && OpenDirectoryDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:OpenDirectoryDialog", OpenDirectoryDialog_IsValid);
		ModifyObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyObject");
		ModifyObject_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyObject_Object_PropertyAddress, ModifyObject_FunctionAddress, "Object");
		ModifyObject_Object_Offset = NativeReflectionCached.GetPropertyOffset(ModifyObject_FunctionAddress, "Object");
		ModifyObject_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyObject_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyObject_bAlwaysMarkDirty_PropertyAddress, ModifyObject_FunctionAddress, "bAlwaysMarkDirty");
		ModifyObject_bAlwaysMarkDirty_Offset = NativeReflectionCached.GetPropertyOffset(ModifyObject_FunctionAddress, "bAlwaysMarkDirty");
		ModifyObject_bAlwaysMarkDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyObject_FunctionAddress, "bAlwaysMarkDirty", Classes.FBoolProperty);
		ModifyObject_IsValid = ModifyObject_FunctionAddress != IntPtr.Zero && ModifyObject_Object_IsValid && ModifyObject_bAlwaysMarkDirty_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ModifyObject", ModifyObject_IsValid);
		MarkPackageDirty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkPackageDirty");
		MarkPackageDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkPackageDirty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkPackageDirty_InObject_PropertyAddress, MarkPackageDirty_FunctionAddress, "InObject");
		MarkPackageDirty_InObject_Offset = NativeReflectionCached.GetPropertyOffset(MarkPackageDirty_FunctionAddress, "InObject");
		MarkPackageDirty_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkPackageDirty_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MarkPackageDirty_ReturnValue_PropertyAddress, MarkPackageDirty_FunctionAddress, "ReturnValue");
		MarkPackageDirty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MarkPackageDirty_FunctionAddress, "ReturnValue");
		MarkPackageDirty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkPackageDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MarkPackageDirty_IsValid = MarkPackageDirty_FunctionAddress != IntPtr.Zero && MarkPackageDirty_InObject_IsValid && MarkPackageDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:MarkPackageDirty", MarkPackageDirty_IsValid);
		LoadImageFromDiskAsync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadImageFromDiskAsync");
		LoadImageFromDiskAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadImageFromDiskAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadImageFromDiskAsync_ImagePath_PropertyAddress, LoadImageFromDiskAsync_FunctionAddress, "ImagePath");
		LoadImageFromDiskAsync_ImagePath_Offset = NativeReflectionCached.GetPropertyOffset(LoadImageFromDiskAsync_FunctionAddress, "ImagePath");
		LoadImageFromDiskAsync_ImagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadImageFromDiskAsync_FunctionAddress, "ImagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadImageFromDiskAsync_Callback_PropertyAddress, LoadImageFromDiskAsync_FunctionAddress, "Callback");
		LoadImageFromDiskAsync_Callback_Offset = NativeReflectionCached.GetPropertyOffset(LoadImageFromDiskAsync_FunctionAddress, "Callback");
		LoadImageFromDiskAsync_Callback_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadImageFromDiskAsync_FunctionAddress, "Callback", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadImageFromDiskAsync_ReturnValue_PropertyAddress, LoadImageFromDiskAsync_FunctionAddress, "ReturnValue");
		LoadImageFromDiskAsync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadImageFromDiskAsync_FunctionAddress, "ReturnValue");
		LoadImageFromDiskAsync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadImageFromDiskAsync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadImageFromDiskAsync_IsValid = LoadImageFromDiskAsync_FunctionAddress != IntPtr.Zero && LoadImageFromDiskAsync_ImagePath_IsValid && LoadImageFromDiskAsync_Callback_IsValid && LoadImageFromDiskAsync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadImageFromDiskAsync", LoadImageFromDiskAsync_IsValid);
		LoadFileToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadFileToString");
		LoadFileToString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadFileToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToString_Path_PropertyAddress, LoadFileToString_FunctionAddress, "Path");
		LoadFileToString_Path_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToString_FunctionAddress, "Path");
		LoadFileToString_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToString_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToString_Data_PropertyAddress, LoadFileToString_FunctionAddress, "Data");
		LoadFileToString_Data_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToString_FunctionAddress, "Data");
		LoadFileToString_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToString_FunctionAddress, "Data", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToString_ReturnValue_PropertyAddress, LoadFileToString_FunctionAddress, "ReturnValue");
		LoadFileToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToString_FunctionAddress, "ReturnValue");
		LoadFileToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadFileToString_IsValid = LoadFileToString_FunctionAddress != IntPtr.Zero && LoadFileToString_Path_IsValid && LoadFileToString_Data_IsValid && LoadFileToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToString", LoadFileToString_IsValid);
		LoadFileToIntArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadFileToIntArray");
		LoadFileToIntArray_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadFileToIntArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToIntArray_Path_PropertyAddress, LoadFileToIntArray_FunctionAddress, "Path");
		LoadFileToIntArray_Path_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToIntArray_FunctionAddress, "Path");
		LoadFileToIntArray_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToIntArray_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToIntArray_FileData_PropertyAddress, LoadFileToIntArray_FunctionAddress, "FileData");
		LoadFileToIntArray_FileData_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToIntArray_FunctionAddress, "FileData");
		LoadFileToIntArray_FileData_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToIntArray_FunctionAddress, "FileData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToIntArray_ReturnValue_PropertyAddress, LoadFileToIntArray_FunctionAddress, "ReturnValue");
		LoadFileToIntArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToIntArray_FunctionAddress, "ReturnValue");
		LoadFileToIntArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToIntArray_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadFileToIntArray_IsValid = LoadFileToIntArray_FunctionAddress != IntPtr.Zero && LoadFileToIntArray_Path_IsValid && LoadFileToIntArray_FileData_IsValid && LoadFileToIntArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:LoadFileToIntArray", LoadFileToIntArray_IsValid);
		IsShiftDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsShiftDown");
		IsShiftDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsShiftDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsShiftDown_Click_PropertyAddress, IsShiftDown_FunctionAddress, "Click");
		IsShiftDown_Click_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftDown_FunctionAddress, "Click");
		IsShiftDown_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftDown_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsShiftDown_ReturnValue_PropertyAddress, IsShiftDown_FunctionAddress, "ReturnValue");
		IsShiftDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsShiftDown_FunctionAddress, "ReturnValue");
		IsShiftDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsShiftDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsShiftDown_IsValid = IsShiftDown_FunctionAddress != IntPtr.Zero && IsShiftDown_Click_IsValid && IsShiftDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsShiftDown", IsShiftDown_IsValid);
		IsControlDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsControlDown");
		IsControlDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsControlDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsControlDown_Click_PropertyAddress, IsControlDown_FunctionAddress, "Click");
		IsControlDown_Click_Offset = NativeReflectionCached.GetPropertyOffset(IsControlDown_FunctionAddress, "Click");
		IsControlDown_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControlDown_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsControlDown_ReturnValue_PropertyAddress, IsControlDown_FunctionAddress, "ReturnValue");
		IsControlDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsControlDown_FunctionAddress, "ReturnValue");
		IsControlDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsControlDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsControlDown_IsValid = IsControlDown_FunctionAddress != IntPtr.Zero && IsControlDown_Click_IsValid && IsControlDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsControlDown", IsControlDown_IsValid);
		IsAssetLoaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAssetLoaded");
		IsAssetLoaded_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAssetLoaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAssetLoaded_AssetData_PropertyAddress, IsAssetLoaded_FunctionAddress, "AssetData");
		IsAssetLoaded_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetLoaded_FunctionAddress, "AssetData");
		IsAssetLoaded_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetLoaded_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAssetLoaded_ReturnValue_PropertyAddress, IsAssetLoaded_FunctionAddress, "ReturnValue");
		IsAssetLoaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAssetLoaded_FunctionAddress, "ReturnValue");
		IsAssetLoaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAssetLoaded_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAssetLoaded_IsValid = IsAssetLoaded_FunctionAddress != IntPtr.Zero && IsAssetLoaded_AssetData_IsValid && IsAssetLoaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAssetLoaded", IsAssetLoaded_IsValid);
		IsAltDown_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsAltDown");
		IsAltDown_ParamsSize = NativeReflection.GetFunctionParamsSize(IsAltDown_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsAltDown_Click_PropertyAddress, IsAltDown_FunctionAddress, "Click");
		IsAltDown_Click_Offset = NativeReflectionCached.GetPropertyOffset(IsAltDown_FunctionAddress, "Click");
		IsAltDown_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltDown_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAltDown_ReturnValue_PropertyAddress, IsAltDown_FunctionAddress, "ReturnValue");
		IsAltDown_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsAltDown_FunctionAddress, "ReturnValue");
		IsAltDown_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsAltDown_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsAltDown_IsValid = IsAltDown_FunctionAddress != IntPtr.Zero && IsAltDown_Click_IsValid && IsAltDown_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsAltDown", IsAltDown_IsValid);
		IsActorLabelEditable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActorLabelEditable");
		IsActorLabelEditable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActorLabelEditable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActorLabelEditable_Actor_PropertyAddress, IsActorLabelEditable_FunctionAddress, "Actor");
		IsActorLabelEditable_Actor_Offset = NativeReflectionCached.GetPropertyOffset(IsActorLabelEditable_FunctionAddress, "Actor");
		IsActorLabelEditable_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorLabelEditable_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActorLabelEditable_ReturnValue_PropertyAddress, IsActorLabelEditable_FunctionAddress, "ReturnValue");
		IsActorLabelEditable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActorLabelEditable_FunctionAddress, "ReturnValue");
		IsActorLabelEditable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActorLabelEditable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActorLabelEditable_IsValid = IsActorLabelEditable_FunctionAddress != IntPtr.Zero && IsActorLabelEditable_Actor_IsValid && IsActorLabelEditable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActorLabelEditable", IsActorLabelEditable_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_Transactor_PropertyAddress, IsActive_FunctionAddress, "Transactor");
		IsActive_Transactor_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "Transactor");
		IsActive_Transactor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "Transactor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_Transactor_IsValid && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:IsActive", IsActive_IsValid);
		InvalidateModelGeometry_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "InvalidateModelGeometry");
		InvalidateModelGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(InvalidateModelGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InvalidateModelGeometry_World_PropertyAddress, InvalidateModelGeometry_FunctionAddress, "World");
		InvalidateModelGeometry_World_Offset = NativeReflectionCached.GetPropertyOffset(InvalidateModelGeometry_FunctionAddress, "World");
		InvalidateModelGeometry_World_IsValid = NativeReflectionCached.ValidatePropertyClass(InvalidateModelGeometry_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InvalidateModelGeometry_InLevel_PropertyAddress, InvalidateModelGeometry_FunctionAddress, "InLevel");
		InvalidateModelGeometry_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(InvalidateModelGeometry_FunctionAddress, "InLevel");
		InvalidateModelGeometry_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(InvalidateModelGeometry_FunctionAddress, "InLevel", Classes.FObjectProperty);
		InvalidateModelGeometry_IsValid = InvalidateModelGeometry_FunctionAddress != IntPtr.Zero && InvalidateModelGeometry_World_IsValid && InvalidateModelGeometry_InLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:InvalidateModelGeometry", InvalidateModelGeometry_IsValid);
		HasMetaData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasMetaData");
		HasMetaData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMetaData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMetaData_Field_PropertyAddress, HasMetaData_FunctionAddress, "Field");
		HasMetaData_Field_Offset = NativeReflectionCached.GetPropertyOffset(HasMetaData_FunctionAddress, "Field");
		HasMetaData_Field_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMetaData_FunctionAddress, "Field", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasMetaData_Key_PropertyAddress, HasMetaData_FunctionAddress, "Key");
		HasMetaData_Key_Offset = NativeReflectionCached.GetPropertyOffset(HasMetaData_FunctionAddress, "Key");
		HasMetaData_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMetaData_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HasMetaData_ReturnValue_PropertyAddress, HasMetaData_FunctionAddress, "ReturnValue");
		HasMetaData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMetaData_FunctionAddress, "ReturnValue");
		HasMetaData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMetaData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMetaData_IsValid = HasMetaData_FunctionAddress != IntPtr.Zero && HasMetaData_Field_IsValid && HasMetaData_Key_IsValid && HasMetaData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:HasMetaData", HasMetaData_IsValid);
		GetUniqueID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueID");
		GetUniqueID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueID_InObject_PropertyAddress, GetUniqueID_FunctionAddress, "InObject");
		GetUniqueID_InObject_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueID_FunctionAddress, "InObject");
		GetUniqueID_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueID_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueID_ReturnValue_PropertyAddress, GetUniqueID_FunctionAddress, "ReturnValue");
		GetUniqueID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueID_FunctionAddress, "ReturnValue");
		GetUniqueID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUniqueID_IsValid = GetUniqueID_FunctionAddress != IntPtr.Zero && GetUniqueID_InObject_IsValid && GetUniqueID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetUniqueID", GetUniqueID_IsValid);
		GetTransaction_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransaction");
		GetTransaction_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransaction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransaction_Transactor_PropertyAddress, GetTransaction_FunctionAddress, "Transactor");
		GetTransaction_Transactor_Offset = NativeReflectionCached.GetPropertyOffset(GetTransaction_FunctionAddress, "Transactor");
		GetTransaction_Transactor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransaction_FunctionAddress, "Transactor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransaction_QueueIndex_PropertyAddress, GetTransaction_FunctionAddress, "QueueIndex");
		GetTransaction_QueueIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTransaction_FunctionAddress, "QueueIndex");
		GetTransaction_QueueIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransaction_FunctionAddress, "QueueIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransaction_ReturnValue_PropertyAddress, GetTransaction_FunctionAddress, "ReturnValue");
		GetTransaction_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransaction_FunctionAddress, "ReturnValue");
		GetTransaction_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransaction_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransaction_IsValid = GetTransaction_FunctionAddress != IntPtr.Zero && GetTransaction_Transactor_IsValid && GetTransaction_QueueIndex_IsValid && GetTransaction_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTransaction", GetTransaction_IsValid);
		GetToolBarExtensibilityManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetToolBarExtensibilityManager");
		GetToolBarExtensibilityManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetToolBarExtensibilityManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetToolBarExtensibilityManager_What_PropertyAddress, GetToolBarExtensibilityManager_FunctionAddress, "What");
		GetToolBarExtensibilityManager_What_Offset = NativeReflectionCached.GetPropertyOffset(GetToolBarExtensibilityManager_FunctionAddress, "What");
		GetToolBarExtensibilityManager_What_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolBarExtensibilityManager_FunctionAddress, "What", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetToolBarExtensibilityManager_ReturnValue_PropertyAddress, GetToolBarExtensibilityManager_FunctionAddress, "ReturnValue");
		GetToolBarExtensibilityManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetToolBarExtensibilityManager_FunctionAddress, "ReturnValue");
		GetToolBarExtensibilityManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetToolBarExtensibilityManager_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetToolBarExtensibilityManager_IsValid = GetToolBarExtensibilityManager_FunctionAddress != IntPtr.Zero && GetToolBarExtensibilityManager_What_IsValid && GetToolBarExtensibilityManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetToolBarExtensibilityManager", GetToolBarExtensibilityManager_IsValid);
		GetTitle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTitle");
		GetTitle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTitle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTitle_Transaction_PropertyAddress, GetTitle_FunctionAddress, "Transaction");
		GetTitle_Transaction_Offset = NativeReflectionCached.GetPropertyOffset(GetTitle_FunctionAddress, "Transaction");
		GetTitle_Transaction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTitle_FunctionAddress, "Transaction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTitle_ReturnValue_PropertyAddress, GetTitle_FunctionAddress, "ReturnValue");
		GetTitle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTitle_FunctionAddress, "ReturnValue");
		GetTitle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTitle_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTitle_IsValid = GetTitle_FunctionAddress != IntPtr.Zero && GetTitle_Transaction_IsValid && GetTitle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTitle", GetTitle_IsValid);
		GetTagValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTagValue");
		GetTagValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_AssetData_PropertyAddress, GetTagValue_FunctionAddress, "AssetData");
		GetTagValue_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "AssetData");
		GetTagValue_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_Name_PropertyAddress, GetTagValue_FunctionAddress, "Name");
		GetTagValue_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "Name");
		GetTagValue_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_OutValue_PropertyAddress, GetTagValue_FunctionAddress, "OutValue");
		GetTagValue_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "OutValue");
		GetTagValue_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "OutValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValue_ReturnValue_PropertyAddress, GetTagValue_FunctionAddress, "ReturnValue");
		GetTagValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValue_FunctionAddress, "ReturnValue");
		GetTagValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetTagValue_IsValid = GetTagValue_FunctionAddress != IntPtr.Zero && GetTagValue_AssetData_IsValid && GetTagValue_Name_IsValid && GetTagValue_OutValue_IsValid && GetTagValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetTagValue", GetTagValue_IsValid);
		GetSelectedObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedObjects");
		GetSelectedObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_Selection_PropertyAddress, GetSelectedObjects_FunctionAddress, "Selection");
		GetSelectedObjects_Selection_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "Selection");
		GetSelectedObjects_Selection_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "Selection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_Out_PropertyAddress, GetSelectedObjects_FunctionAddress, "Out");
		GetSelectedObjects_Out_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "Out");
		GetSelectedObjects_Out_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "Out", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedObjects_ReturnValue_PropertyAddress, GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedObjects_FunctionAddress, "ReturnValue");
		GetSelectedObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedObjects_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSelectedObjects_IsValid = GetSelectedObjects_FunctionAddress != IntPtr.Zero && GetSelectedObjects_Selection_IsValid && GetSelectedObjects_Out_IsValid && GetSelectedObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetSelectedObjects", GetSelectedObjects_IsValid);
		GetRootWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRootWindow");
		GetRootWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRootWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRootWindow_ReturnValue_PropertyAddress, GetRootWindow_FunctionAddress, "ReturnValue");
		GetRootWindow_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRootWindow_FunctionAddress, "ReturnValue");
		GetRootWindow_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRootWindow_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRootWindow_IsValid = GetRootWindow_FunctionAddress != IntPtr.Zero && GetRootWindow_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetRootWindow", GetRootWindow_IsValid);
		GetQueueLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetQueueLength");
		GetQueueLength_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQueueLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQueueLength_Transactor_PropertyAddress, GetQueueLength_FunctionAddress, "Transactor");
		GetQueueLength_Transactor_Offset = NativeReflectionCached.GetPropertyOffset(GetQueueLength_FunctionAddress, "Transactor");
		GetQueueLength_Transactor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueueLength_FunctionAddress, "Transactor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetQueueLength_ReturnValue_PropertyAddress, GetQueueLength_FunctionAddress, "ReturnValue");
		GetQueueLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQueueLength_FunctionAddress, "ReturnValue");
		GetQueueLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQueueLength_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetQueueLength_IsValid = GetQueueLength_FunctionAddress != IntPtr.Zero && GetQueueLength_Transactor_IsValid && GetQueueLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetQueueLength", GetQueueLength_IsValid);
		GetPrimaryObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPrimaryObject");
		GetPrimaryObject_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrimaryObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrimaryObject_Transaction_PropertyAddress, GetPrimaryObject_FunctionAddress, "Transaction");
		GetPrimaryObject_Transaction_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimaryObject_FunctionAddress, "Transaction");
		GetPrimaryObject_Transaction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimaryObject_FunctionAddress, "Transaction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPrimaryObject_ReturnValue_PropertyAddress, GetPrimaryObject_FunctionAddress, "ReturnValue");
		GetPrimaryObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrimaryObject_FunctionAddress, "ReturnValue");
		GetPrimaryObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrimaryObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPrimaryObject_IsValid = GetPrimaryObject_FunctionAddress != IntPtr.Zero && GetPrimaryObject_Transaction_IsValid && GetPrimaryObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPrimaryObject", GetPrimaryObject_IsValid);
		GetParentClassOfBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParentClassOfBlueprint");
		GetParentClassOfBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParentClassOfBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParentClassOfBlueprint_Blueprint_PropertyAddress, GetParentClassOfBlueprint_FunctionAddress, "Blueprint");
		GetParentClassOfBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetParentClassOfBlueprint_FunctionAddress, "Blueprint");
		GetParentClassOfBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentClassOfBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParentClassOfBlueprint_ReturnValue_PropertyAddress, GetParentClassOfBlueprint_FunctionAddress, "ReturnValue");
		GetParentClassOfBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParentClassOfBlueprint_FunctionAddress, "ReturnValue");
		GetParentClassOfBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParentClassOfBlueprint_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetParentClassOfBlueprint_IsValid = GetParentClassOfBlueprint_FunctionAddress != IntPtr.Zero && GetParentClassOfBlueprint_Blueprint_IsValid && GetParentClassOfBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetParentClassOfBlueprint", GetParentClassOfBlueprint_IsValid);
		GetPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPackage");
		GetPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPackage_AssetData_PropertyAddress, GetPackage_FunctionAddress, "AssetData");
		GetPackage_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetPackage_FunctionAddress, "AssetData");
		GetPackage_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPackage_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPackage_ReturnValue_PropertyAddress, GetPackage_FunctionAddress, "ReturnValue");
		GetPackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPackage_FunctionAddress, "ReturnValue");
		GetPackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPackage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPackage_IsValid = GetPackage_FunctionAddress != IntPtr.Zero && GetPackage_AssetData_IsValid && GetPackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetPackage", GetPackage_IsValid);
		GetOrigin_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOrigin");
		GetOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrigin_Click_PropertyAddress, GetOrigin_FunctionAddress, "Click");
		GetOrigin_Click_Offset = NativeReflectionCached.GetPropertyOffset(GetOrigin_FunctionAddress, "Click");
		GetOrigin_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrigin_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOrigin_ReturnValue_PropertyAddress, GetOrigin_FunctionAddress, "ReturnValue");
		GetOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOrigin_FunctionAddress, "ReturnValue");
		GetOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrigin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetOrigin_IsValid = GetOrigin_FunctionAddress != IntPtr.Zero && GetOrigin_Click_IsValid && GetOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetOrigin", GetOrigin_IsValid);
		GetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetName");
		GetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetName_Proxy_PropertyAddress, GetName_FunctionAddress, "Proxy");
		GetName_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "Proxy");
		GetName_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "Proxy", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetName_ReturnValue_PropertyAddress, GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetName_IsValid = GetName_FunctionAddress != IntPtr.Zero && GetName_Proxy_IsValid && GetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetName", GetName_IsValid);
		GetMenuExtensibilityManager_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMenuExtensibilityManager");
		GetMenuExtensibilityManager_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMenuExtensibilityManager_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMenuExtensibilityManager_What_PropertyAddress, GetMenuExtensibilityManager_FunctionAddress, "What");
		GetMenuExtensibilityManager_What_Offset = NativeReflectionCached.GetPropertyOffset(GetMenuExtensibilityManager_FunctionAddress, "What");
		GetMenuExtensibilityManager_What_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMenuExtensibilityManager_FunctionAddress, "What", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMenuExtensibilityManager_ReturnValue_PropertyAddress, GetMenuExtensibilityManager_FunctionAddress, "ReturnValue");
		GetMenuExtensibilityManager_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMenuExtensibilityManager_FunctionAddress, "ReturnValue");
		GetMenuExtensibilityManager_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMenuExtensibilityManager_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMenuExtensibilityManager_IsValid = GetMenuExtensibilityManager_FunctionAddress != IntPtr.Zero && GetMenuExtensibilityManager_What_IsValid && GetMenuExtensibilityManager_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetMenuExtensibilityManager", GetMenuExtensibilityManager_IsValid);
		GetLevelEditorActions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelEditorActions");
		GetLevelEditorActions_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelEditorActions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelEditorActions_ReturnValue_PropertyAddress, GetLevelEditorActions_FunctionAddress, "ReturnValue");
		GetLevelEditorActions_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelEditorActions_FunctionAddress, "ReturnValue");
		GetLevelEditorActions_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelEditorActions_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelEditorActions_IsValid = GetLevelEditorActions_FunctionAddress != IntPtr.Zero && GetLevelEditorActions_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLevelEditorActions", GetLevelEditorActions_IsValid);
		GetLayerInfoByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLayerInfoByName");
		GetLayerInfoByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLayerInfoByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLayerInfoByName_LandscapeInfo_PropertyAddress, GetLayerInfoByName_FunctionAddress, "LandscapeInfo");
		GetLayerInfoByName_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerInfoByName_FunctionAddress, "LandscapeInfo");
		GetLayerInfoByName_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerInfoByName_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLayerInfoByName_LayerName_PropertyAddress, GetLayerInfoByName_FunctionAddress, "LayerName");
		GetLayerInfoByName_LayerName_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerInfoByName_FunctionAddress, "LayerName");
		GetLayerInfoByName_LayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerInfoByName_FunctionAddress, "LayerName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLayerInfoByName_Owner_PropertyAddress, GetLayerInfoByName_FunctionAddress, "Owner");
		GetLayerInfoByName_Owner_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerInfoByName_FunctionAddress, "Owner");
		GetLayerInfoByName_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerInfoByName_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLayerInfoByName_ReturnValue_PropertyAddress, GetLayerInfoByName_FunctionAddress, "ReturnValue");
		GetLayerInfoByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLayerInfoByName_FunctionAddress, "ReturnValue");
		GetLayerInfoByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLayerInfoByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLayerInfoByName_IsValid = GetLayerInfoByName_FunctionAddress != IntPtr.Zero && GetLayerInfoByName_LandscapeInfo_IsValid && GetLayerInfoByName_LayerName_IsValid && GetLayerInfoByName_Owner_IsValid && GetLayerInfoByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLayerInfoByName", GetLayerInfoByName_IsValid);
		GetLandscapeInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLandscapeInfo");
		GetLandscapeInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLandscapeInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeInfo_Landscape_PropertyAddress, GetLandscapeInfo_FunctionAddress, "Landscape");
		GetLandscapeInfo_Landscape_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeInfo_FunctionAddress, "Landscape");
		GetLandscapeInfo_Landscape_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeInfo_FunctionAddress, "Landscape", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeInfo_bSpawnNewActor_PropertyAddress, GetLandscapeInfo_FunctionAddress, "bSpawnNewActor");
		GetLandscapeInfo_bSpawnNewActor_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeInfo_FunctionAddress, "bSpawnNewActor");
		GetLandscapeInfo_bSpawnNewActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeInfo_FunctionAddress, "bSpawnNewActor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeInfo_ReturnValue_PropertyAddress, GetLandscapeInfo_FunctionAddress, "ReturnValue");
		GetLandscapeInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeInfo_FunctionAddress, "ReturnValue");
		GetLandscapeInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeInfo_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLandscapeInfo_IsValid = GetLandscapeInfo_FunctionAddress != IntPtr.Zero && GetLandscapeInfo_Landscape_IsValid && GetLandscapeInfo_bSpawnNewActor_IsValid && GetLandscapeInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeInfo", GetLandscapeInfo_IsValid);
		GetLandscapeExtent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLandscapeExtent");
		GetLandscapeExtent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLandscapeExtent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_LandscapeInfo_PropertyAddress, GetLandscapeExtent_FunctionAddress, "LandscapeInfo");
		GetLandscapeExtent_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "LandscapeInfo");
		GetLandscapeExtent_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_MinX_PropertyAddress, GetLandscapeExtent_FunctionAddress, "MinX");
		GetLandscapeExtent_MinX_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "MinX");
		GetLandscapeExtent_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_MinY_PropertyAddress, GetLandscapeExtent_FunctionAddress, "MinY");
		GetLandscapeExtent_MinY_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "MinY");
		GetLandscapeExtent_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_MaxX_PropertyAddress, GetLandscapeExtent_FunctionAddress, "MaxX");
		GetLandscapeExtent_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "MaxX");
		GetLandscapeExtent_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_MaxY_PropertyAddress, GetLandscapeExtent_FunctionAddress, "MaxY");
		GetLandscapeExtent_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "MaxY");
		GetLandscapeExtent_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "MaxY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLandscapeExtent_ReturnValue_PropertyAddress, GetLandscapeExtent_FunctionAddress, "ReturnValue");
		GetLandscapeExtent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLandscapeExtent_FunctionAddress, "ReturnValue");
		GetLandscapeExtent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLandscapeExtent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLandscapeExtent_IsValid = GetLandscapeExtent_FunctionAddress != IntPtr.Zero && GetLandscapeExtent_LandscapeInfo_IsValid && GetLandscapeExtent_MinX_IsValid && GetLandscapeExtent_MinY_IsValid && GetLandscapeExtent_MaxX_IsValid && GetLandscapeExtent_MaxY_IsValid && GetLandscapeExtent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetLandscapeExtent", GetLandscapeExtent_IsValid);
		GetKeyNameByKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKeyNameByKeyEvent");
		GetKeyNameByKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKeyNameByKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKeyNameByKeyEvent_Event_PropertyAddress, GetKeyNameByKeyEvent_FunctionAddress, "Event");
		GetKeyNameByKeyEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyNameByKeyEvent_FunctionAddress, "Event");
		GetKeyNameByKeyEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyNameByKeyEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKeyNameByKeyEvent_ReturnValue_PropertyAddress, GetKeyNameByKeyEvent_FunctionAddress, "ReturnValue");
		GetKeyNameByKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKeyNameByKeyEvent_FunctionAddress, "ReturnValue");
		GetKeyNameByKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKeyNameByKeyEvent_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetKeyNameByKeyEvent_IsValid = GetKeyNameByKeyEvent_FunctionAddress != IntPtr.Zero && GetKeyNameByKeyEvent_Event_IsValid && GetKeyNameByKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKeyNameByKeyEvent", GetKeyNameByKeyEvent_IsValid);
		GetKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetKey");
		GetKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetKey_Click_PropertyAddress, GetKey_FunctionAddress, "Click");
		GetKey_Click_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "Click");
		GetKey_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetKey_ReturnValue_PropertyAddress, GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetKey_FunctionAddress, "ReturnValue");
		GetKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetKey_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetKey_IsValid = GetKey_FunctionAddress != IntPtr.Zero && GetKey_Click_IsValid && GetKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetKey", GetKey_IsValid);
		GetIsShiftDownByKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsShiftDownByKeyEvent");
		GetIsShiftDownByKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsShiftDownByKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsShiftDownByKeyEvent_Event_PropertyAddress, GetIsShiftDownByKeyEvent_FunctionAddress, "Event");
		GetIsShiftDownByKeyEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetIsShiftDownByKeyEvent_FunctionAddress, "Event");
		GetIsShiftDownByKeyEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsShiftDownByKeyEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsShiftDownByKeyEvent_ReturnValue_PropertyAddress, GetIsShiftDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsShiftDownByKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsShiftDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsShiftDownByKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsShiftDownByKeyEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsShiftDownByKeyEvent_IsValid = GetIsShiftDownByKeyEvent_FunctionAddress != IntPtr.Zero && GetIsShiftDownByKeyEvent_Event_IsValid && GetIsShiftDownByKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsShiftDownByKeyEvent", GetIsShiftDownByKeyEvent_IsValid);
		GetIsExecuteTestModePIE_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsExecuteTestModePIE");
		GetIsExecuteTestModePIE_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsExecuteTestModePIE_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsExecuteTestModePIE_ReturnValue_PropertyAddress, GetIsExecuteTestModePIE_FunctionAddress, "ReturnValue");
		GetIsExecuteTestModePIE_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsExecuteTestModePIE_FunctionAddress, "ReturnValue");
		GetIsExecuteTestModePIE_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsExecuteTestModePIE_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsExecuteTestModePIE_IsValid = GetIsExecuteTestModePIE_FunctionAddress != IntPtr.Zero && GetIsExecuteTestModePIE_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsExecuteTestModePIE", GetIsExecuteTestModePIE_IsValid);
		GetIsControlDownByKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsControlDownByKeyEvent");
		GetIsControlDownByKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsControlDownByKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsControlDownByKeyEvent_Event_PropertyAddress, GetIsControlDownByKeyEvent_FunctionAddress, "Event");
		GetIsControlDownByKeyEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetIsControlDownByKeyEvent_FunctionAddress, "Event");
		GetIsControlDownByKeyEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsControlDownByKeyEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsControlDownByKeyEvent_ReturnValue_PropertyAddress, GetIsControlDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsControlDownByKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsControlDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsControlDownByKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsControlDownByKeyEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsControlDownByKeyEvent_IsValid = GetIsControlDownByKeyEvent_FunctionAddress != IntPtr.Zero && GetIsControlDownByKeyEvent_Event_IsValid && GetIsControlDownByKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsControlDownByKeyEvent", GetIsControlDownByKeyEvent_IsValid);
		GetIsAltDownByKeyEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIsAltDownByKeyEvent");
		GetIsAltDownByKeyEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsAltDownByKeyEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsAltDownByKeyEvent_Event_PropertyAddress, GetIsAltDownByKeyEvent_FunctionAddress, "Event");
		GetIsAltDownByKeyEvent_Event_Offset = NativeReflectionCached.GetPropertyOffset(GetIsAltDownByKeyEvent_FunctionAddress, "Event");
		GetIsAltDownByKeyEvent_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsAltDownByKeyEvent_FunctionAddress, "Event", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetIsAltDownByKeyEvent_ReturnValue_PropertyAddress, GetIsAltDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsAltDownByKeyEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsAltDownByKeyEvent_FunctionAddress, "ReturnValue");
		GetIsAltDownByKeyEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsAltDownByKeyEvent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsAltDownByKeyEvent_IsValid = GetIsAltDownByKeyEvent_FunctionAddress != IntPtr.Zero && GetIsAltDownByKeyEvent_Event_IsValid && GetIsAltDownByKeyEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetIsAltDownByKeyEvent", GetIsAltDownByKeyEvent_IsValid);
		GetHeightmapDataToMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetHeightmapDataToMemory");
		GetHeightmapDataToMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetHeightmapDataToMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetHeightmapDataToMemory_LandscapeInfo_PropertyAddress, GetHeightmapDataToMemory_FunctionAddress, "LandscapeInfo");
		GetHeightmapDataToMemory_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightmapDataToMemory_FunctionAddress, "LandscapeInfo");
		GetHeightmapDataToMemory_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightmapDataToMemory_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightmapDataToMemory_MinX_PropertyAddress, GetHeightmapDataToMemory_FunctionAddress, "MinX");
		GetHeightmapDataToMemory_MinX_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightmapDataToMemory_FunctionAddress, "MinX");
		GetHeightmapDataToMemory_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightmapDataToMemory_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightmapDataToMemory_MinY_PropertyAddress, GetHeightmapDataToMemory_FunctionAddress, "MinY");
		GetHeightmapDataToMemory_MinY_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightmapDataToMemory_FunctionAddress, "MinY");
		GetHeightmapDataToMemory_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightmapDataToMemory_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightmapDataToMemory_MaxX_PropertyAddress, GetHeightmapDataToMemory_FunctionAddress, "MaxX");
		GetHeightmapDataToMemory_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightmapDataToMemory_FunctionAddress, "MaxX");
		GetHeightmapDataToMemory_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightmapDataToMemory_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetHeightmapDataToMemory_MaxY_PropertyAddress, GetHeightmapDataToMemory_FunctionAddress, "MaxY");
		GetHeightmapDataToMemory_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(GetHeightmapDataToMemory_FunctionAddress, "MaxY");
		GetHeightmapDataToMemory_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetHeightmapDataToMemory_FunctionAddress, "MaxY", Classes.FIntProperty);
		GetHeightmapDataToMemory_IsValid = GetHeightmapDataToMemory_FunctionAddress != IntPtr.Zero && GetHeightmapDataToMemory_LandscapeInfo_IsValid && GetHeightmapDataToMemory_MinX_IsValid && GetHeightmapDataToMemory_MinY_IsValid && GetHeightmapDataToMemory_MaxX_IsValid && GetHeightmapDataToMemory_MaxY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetHeightmapDataToMemory", GetHeightmapDataToMemory_IsValid);
		GetGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGroup");
		GetGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGroup_Name_PropertyAddress, GetGroup_FunctionAddress, "Name");
		GetGroup_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetGroup_FunctionAddress, "Name");
		GetGroup_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGroup_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGroup_ReturnValue_PropertyAddress, GetGroup_FunctionAddress, "ReturnValue");
		GetGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGroup_FunctionAddress, "ReturnValue");
		GetGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGroup_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetGroup_IsValid = GetGroup_FunctionAddress != IntPtr.Zero && GetGroup_Name_IsValid && GetGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetGroup", GetGroup_IsValid);
		GetFolderPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFolderPath");
		GetFolderPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFolderPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFolderPath_Actor_PropertyAddress, GetFolderPath_FunctionAddress, "Actor");
		GetFolderPath_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderPath_FunctionAddress, "Actor");
		GetFolderPath_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderPath_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFolderPath_ReturnValue_PropertyAddress, GetFolderPath_FunctionAddress, "ReturnValue");
		GetFolderPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderPath_FunctionAddress, "ReturnValue");
		GetFolderPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderPath_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetFolderPath_IsValid = GetFolderPath_FunctionAddress != IntPtr.Zero && GetFolderPath_Actor_IsValid && GetFolderPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetFolderPath", GetFolderPath_IsValid);
		GetEvent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEvent");
		GetEvent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEvent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEvent_Click_PropertyAddress, GetEvent_FunctionAddress, "Click");
		GetEvent_Click_Offset = NativeReflectionCached.GetPropertyOffset(GetEvent_FunctionAddress, "Click");
		GetEvent_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEvent_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEvent_ReturnValue_PropertyAddress, GetEvent_FunctionAddress, "ReturnValue");
		GetEvent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEvent_FunctionAddress, "ReturnValue");
		GetEvent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEvent_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetEvent_IsValid = GetEvent_FunctionAddress != IntPtr.Zero && GetEvent_Click_IsValid && GetEvent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEvent", GetEvent_IsValid);
		GetEngine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEngine");
		GetEngine_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngine_ReturnValue_PropertyAddress, GetEngine_FunctionAddress, "ReturnValue");
		GetEngine_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngine_FunctionAddress, "ReturnValue");
		GetEngine_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngine_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEngine_IsValid = GetEngine_FunctionAddress != IntPtr.Zero && GetEngine_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEngine", GetEngine_IsValid);
		GetEditorPlayWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorPlayWorld");
		GetEditorPlayWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorPlayWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorPlayWorld_ReturnValue_PropertyAddress, GetEditorPlayWorld_FunctionAddress, "ReturnValue");
		GetEditorPlayWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorPlayWorld_FunctionAddress, "ReturnValue");
		GetEditorPlayWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorPlayWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEditorPlayWorld_IsValid = GetEditorPlayWorld_FunctionAddress != IntPtr.Zero && GetEditorPlayWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetEditorPlayWorld", GetEditorPlayWorld_IsValid);
		GetDirection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDirection");
		GetDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirection_Click_PropertyAddress, GetDirection_FunctionAddress, "Click");
		GetDirection_Click_Offset = NativeReflectionCached.GetPropertyOffset(GetDirection_FunctionAddress, "Click");
		GetDirection_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirection_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirection_ReturnValue_PropertyAddress, GetDirection_FunctionAddress, "ReturnValue");
		GetDirection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirection_FunctionAddress, "ReturnValue");
		GetDirection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirection_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDirection_IsValid = GetDirection_FunctionAddress != IntPtr.Zero && GetDirection_Click_IsValid && GetDirection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDirection", GetDirection_IsValid);
		GetDefaultBrush_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDefaultBrush");
		GetDefaultBrush_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultBrush_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultBrush_World_PropertyAddress, GetDefaultBrush_FunctionAddress, "World");
		GetDefaultBrush_World_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultBrush_FunctionAddress, "World");
		GetDefaultBrush_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultBrush_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultBrush_ReturnValue_PropertyAddress, GetDefaultBrush_FunctionAddress, "ReturnValue");
		GetDefaultBrush_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultBrush_FunctionAddress, "ReturnValue");
		GetDefaultBrush_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultBrush_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultBrush_IsValid = GetDefaultBrush_FunctionAddress != IntPtr.Zero && GetDefaultBrush_World_IsValid && GetDefaultBrush_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDefaultBrush", GetDefaultBrush_IsValid);
		GetDataTableAsJSON_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDataTableAsJSON");
		GetDataTableAsJSON_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDataTableAsJSON_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableAsJSON_InDataTable_PropertyAddress, GetDataTableAsJSON_FunctionAddress, "InDataTable");
		GetDataTableAsJSON_InDataTable_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableAsJSON_FunctionAddress, "InDataTable");
		GetDataTableAsJSON_InDataTable_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableAsJSON_FunctionAddress, "InDataTable", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableAsJSON_InDTExportFlags_PropertyAddress, GetDataTableAsJSON_FunctionAddress, "InDTExportFlags");
		GetDataTableAsJSON_InDTExportFlags_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableAsJSON_FunctionAddress, "InDTExportFlags");
		GetDataTableAsJSON_InDTExportFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableAsJSON_FunctionAddress, "InDTExportFlags", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDataTableAsJSON_ReturnValue_PropertyAddress, GetDataTableAsJSON_FunctionAddress, "ReturnValue");
		GetDataTableAsJSON_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDataTableAsJSON_FunctionAddress, "ReturnValue");
		GetDataTableAsJSON_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDataTableAsJSON_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDataTableAsJSON_IsValid = GetDataTableAsJSON_FunctionAddress != IntPtr.Zero && GetDataTableAsJSON_InDataTable_IsValid && GetDataTableAsJSON_InDTExportFlags_IsValid && GetDataTableAsJSON_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetDataTableAsJSON", GetDataTableAsJSON_IsValid);
		GetContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetContext");
		GetContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContext_Transaction_PropertyAddress, GetContext_FunctionAddress, "Transaction");
		GetContext_Transaction_Offset = NativeReflectionCached.GetPropertyOffset(GetContext_FunctionAddress, "Transaction");
		GetContext_Transaction_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContext_FunctionAddress, "Transaction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetContext_ReturnValue_PropertyAddress, GetContext_FunctionAddress, "ReturnValue");
		GetContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContext_FunctionAddress, "ReturnValue");
		GetContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContext_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetContext_IsValid = GetContext_FunctionAddress != IntPtr.Zero && GetContext_Transaction_IsValid && GetContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetContext", GetContext_IsValid);
		GetClickPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetClickPos");
		GetClickPos_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClickPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClickPos_Click_PropertyAddress, GetClickPos_FunctionAddress, "Click");
		GetClickPos_Click_Offset = NativeReflectionCached.GetPropertyOffset(GetClickPos_FunctionAddress, "Click");
		GetClickPos_Click_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClickPos_FunctionAddress, "Click", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClickPos_ReturnValue_PropertyAddress, GetClickPos_FunctionAddress, "ReturnValue");
		GetClickPos_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClickPos_FunctionAddress, "ReturnValue");
		GetClickPos_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClickPos_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetClickPos_IsValid = GetClickPos_FunctionAddress != IntPtr.Zero && GetClickPos_Click_IsValid && GetClickPos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClickPos", GetClickPos_IsValid);
		GetClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetClass");
		GetClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClass_AssetData_PropertyAddress, GetClass_FunctionAddress, "AssetData");
		GetClass_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetClass_FunctionAddress, "AssetData");
		GetClass_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClass_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClass_ReturnValue_PropertyAddress, GetClass_FunctionAddress, "ReturnValue");
		GetClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClass_FunctionAddress, "ReturnValue");
		GetClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetClass_IsValid = GetClass_FunctionAddress != IntPtr.Zero && GetClass_AssetData_IsValid && GetClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetClass", GetClass_IsValid);
		GetAssetsByType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsByType");
		GetAssetsByType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByType_Types_PropertyAddress, GetAssetsByType_FunctionAddress, "Types");
		GetAssetsByType_Types_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByType_FunctionAddress, "Types");
		GetAssetsByType_Types_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByType_FunctionAddress, "Types", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByType_bRecursiveClasses_PropertyAddress, GetAssetsByType_FunctionAddress, "bRecursiveClasses");
		GetAssetsByType_bRecursiveClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByType_FunctionAddress, "bRecursiveClasses");
		GetAssetsByType_bRecursiveClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByType_FunctionAddress, "bRecursiveClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByType_ReturnValue_PropertyAddress, GetAssetsByType_FunctionAddress, "ReturnValue");
		GetAssetsByType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByType_FunctionAddress, "ReturnValue");
		GetAssetsByType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAssetsByType_IsValid = GetAssetsByType_FunctionAddress != IntPtr.Zero && GetAssetsByType_Types_IsValid && GetAssetsByType_bRecursiveClasses_IsValid && GetAssetsByType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAssetsByType", GetAssetsByType_IsValid);
		GetAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAsset");
		GetAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAsset_AssetData_PropertyAddress, GetAsset_FunctionAddress, "AssetData");
		GetAsset_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAsset_FunctionAddress, "AssetData");
		GetAsset_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsset_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAsset_ReturnValue_PropertyAddress, GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAsset_FunctionAddress, "ReturnValue");
		GetAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAsset_IsValid = GetAsset_FunctionAddress != IntPtr.Zero && GetAsset_AssetData_IsValid && GetAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAsset", GetAsset_IsValid);
		GetAlphamapDataToMemory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAlphamapDataToMemory");
		GetAlphamapDataToMemory_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAlphamapDataToMemory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_LandscapeInfo_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "LandscapeInfo");
		GetAlphamapDataToMemory_LandscapeInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "LandscapeInfo");
		GetAlphamapDataToMemory_LandscapeInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "LandscapeInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_LayerInfo_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "LayerInfo");
		GetAlphamapDataToMemory_LayerInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "LayerInfo");
		GetAlphamapDataToMemory_LayerInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "LayerInfo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_MinX_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "MinX");
		GetAlphamapDataToMemory_MinX_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "MinX");
		GetAlphamapDataToMemory_MinX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "MinX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_MinY_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "MinY");
		GetAlphamapDataToMemory_MinY_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "MinY");
		GetAlphamapDataToMemory_MinY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "MinY", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_MaxX_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "MaxX");
		GetAlphamapDataToMemory_MaxX_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "MaxX");
		GetAlphamapDataToMemory_MaxX_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "MaxX", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAlphamapDataToMemory_MaxY_PropertyAddress, GetAlphamapDataToMemory_FunctionAddress, "MaxY");
		GetAlphamapDataToMemory_MaxY_Offset = NativeReflectionCached.GetPropertyOffset(GetAlphamapDataToMemory_FunctionAddress, "MaxY");
		GetAlphamapDataToMemory_MaxY_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAlphamapDataToMemory_FunctionAddress, "MaxY", Classes.FIntProperty);
		GetAlphamapDataToMemory_IsValid = GetAlphamapDataToMemory_FunctionAddress != IntPtr.Zero && GetAlphamapDataToMemory_LandscapeInfo_IsValid && GetAlphamapDataToMemory_LayerInfo_IsValid && GetAlphamapDataToMemory_MinX_IsValid && GetAlphamapDataToMemory_MinY_IsValid && GetAlphamapDataToMemory_MaxX_IsValid && GetAlphamapDataToMemory_MaxY_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAlphamapDataToMemory", GetAlphamapDataToMemory_IsValid);
		GetAllTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllTags");
		GetAllTags_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllTags_AssetData_PropertyAddress, GetAllTags_FunctionAddress, "AssetData");
		GetAllTags_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTags_FunctionAddress, "AssetData");
		GetAllTags_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTags_FunctionAddress, "AssetData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllTags_OutArray_PropertyAddress, GetAllTags_FunctionAddress, "OutArray");
		GetAllTags_OutArray_Offset = NativeReflectionCached.GetPropertyOffset(GetAllTags_FunctionAddress, "OutArray");
		GetAllTags_OutArray_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllTags_FunctionAddress, "OutArray", Classes.FArrayProperty);
		GetAllTags_IsValid = GetAllTags_FunctionAddress != IntPtr.Zero && GetAllTags_AssetData_IsValid && GetAllTags_OutArray_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetAllTags", GetAllTags_IsValid);
		GetActorRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorRotation");
		GetActorRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorRotation_Actor_PropertyAddress, GetActorRotation_FunctionAddress, "Actor");
		GetActorRotation_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRotation_FunctionAddress, "Actor");
		GetActorRotation_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRotation_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorRotation_ReturnValue_PropertyAddress, GetActorRotation_FunctionAddress, "ReturnValue");
		GetActorRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorRotation_FunctionAddress, "ReturnValue");
		GetActorRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorRotation_IsValid = GetActorRotation_FunctionAddress != IntPtr.Zero && GetActorRotation_Actor_IsValid && GetActorRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorRotation", GetActorRotation_IsValid);
		GetActorLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorLocation");
		GetActorLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocation_Actor_PropertyAddress, GetActorLocation_FunctionAddress, "Actor");
		GetActorLocation_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocation_FunctionAddress, "Actor");
		GetActorLocation_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocation_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocation_ReturnValue_PropertyAddress, GetActorLocation_FunctionAddress, "ReturnValue");
		GetActorLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocation_FunctionAddress, "ReturnValue");
		GetActorLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorLocation_IsValid = GetActorLocation_FunctionAddress != IntPtr.Zero && GetActorLocation_Actor_IsValid && GetActorLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLocation", GetActorLocation_IsValid);
		GetActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorLabel");
		GetActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLabel_Actor_PropertyAddress, GetActorLabel_FunctionAddress, "Actor");
		GetActorLabel_Actor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLabel_FunctionAddress, "Actor");
		GetActorLabel_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLabel_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLabel_ReturnValue_PropertyAddress, GetActorLabel_FunctionAddress, "ReturnValue");
		GetActorLabel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLabel_FunctionAddress, "ReturnValue");
		GetActorLabel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLabel_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetActorLabel_IsValid = GetActorLabel_FunctionAddress != IntPtr.Zero && GetActorLabel_Actor_IsValid && GetActorLabel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActorLabel", GetActorLabel_IsValid);
		GetActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActor");
		GetActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActor_Proxy_PropertyAddress, GetActor_FunctionAddress, "Proxy");
		GetActor_Proxy_Offset = NativeReflectionCached.GetPropertyOffset(GetActor_FunctionAddress, "Proxy");
		GetActor_Proxy_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActor_FunctionAddress, "Proxy", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActor_ReturnValue_PropertyAddress, GetActor_FunctionAddress, "ReturnValue");
		GetActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActor_FunctionAddress, "ReturnValue");
		GetActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActor_IsValid = GetActor_FunctionAddress != IntPtr.Zero && GetActor_Proxy_IsValid && GetActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:GetActor", GetActor_IsValid);
		FindWorldInPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindWorldInPackage");
		FindWorldInPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(FindWorldInPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindWorldInPackage_Package_PropertyAddress, FindWorldInPackage_FunctionAddress, "Package");
		FindWorldInPackage_Package_Offset = NativeReflectionCached.GetPropertyOffset(FindWorldInPackage_FunctionAddress, "Package");
		FindWorldInPackage_Package_IsValid = NativeReflectionCached.ValidatePropertyClass(FindWorldInPackage_FunctionAddress, "Package", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindWorldInPackage_ReturnValue_PropertyAddress, FindWorldInPackage_FunctionAddress, "ReturnValue");
		FindWorldInPackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindWorldInPackage_FunctionAddress, "ReturnValue");
		FindWorldInPackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindWorldInPackage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindWorldInPackage_IsValid = FindWorldInPackage_FunctionAddress != IntPtr.Zero && FindWorldInPackage_Package_IsValid && FindWorldInPackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:FindWorldInPackage", FindWorldInPackage_IsValid);
		ExportNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportNavigation");
		ExportNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportNavigation_InWorld_PropertyAddress, ExportNavigation_FunctionAddress, "InWorld");
		ExportNavigation_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(ExportNavigation_FunctionAddress, "InWorld");
		ExportNavigation_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportNavigation_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportNavigation_Path_PropertyAddress, ExportNavigation_FunctionAddress, "Path");
		ExportNavigation_Path_Offset = NativeReflectionCached.GetPropertyOffset(ExportNavigation_FunctionAddress, "Path");
		ExportNavigation_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportNavigation_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportNavigation_ReturnValue_PropertyAddress, ExportNavigation_FunctionAddress, "ReturnValue");
		ExportNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExportNavigation_FunctionAddress, "ReturnValue");
		ExportNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportNavigation_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ExportNavigation_IsValid = ExportNavigation_FunctionAddress != IntPtr.Zero && ExportNavigation_InWorld_IsValid && ExportNavigation_Path_IsValid && ExportNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ExportNavigation", ExportNavigation_IsValid);
		EditorDestroyActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EditorDestroyActor");
		EditorDestroyActor_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorDestroyActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorDestroyActor_World_PropertyAddress, EditorDestroyActor_FunctionAddress, "World");
		EditorDestroyActor_World_Offset = NativeReflectionCached.GetPropertyOffset(EditorDestroyActor_FunctionAddress, "World");
		EditorDestroyActor_World_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorDestroyActor_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorDestroyActor_Actor_PropertyAddress, EditorDestroyActor_FunctionAddress, "Actor");
		EditorDestroyActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(EditorDestroyActor_FunctionAddress, "Actor");
		EditorDestroyActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorDestroyActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorDestroyActor_bShouldModifyLevel_PropertyAddress, EditorDestroyActor_FunctionAddress, "bShouldModifyLevel");
		EditorDestroyActor_bShouldModifyLevel_Offset = NativeReflectionCached.GetPropertyOffset(EditorDestroyActor_FunctionAddress, "bShouldModifyLevel");
		EditorDestroyActor_bShouldModifyLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorDestroyActor_FunctionAddress, "bShouldModifyLevel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorDestroyActor_ReturnValue_PropertyAddress, EditorDestroyActor_FunctionAddress, "ReturnValue");
		EditorDestroyActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EditorDestroyActor_FunctionAddress, "ReturnValue");
		EditorDestroyActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorDestroyActor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EditorDestroyActor_IsValid = EditorDestroyActor_FunctionAddress != IntPtr.Zero && EditorDestroyActor_World_IsValid && EditorDestroyActor_Actor_IsValid && EditorDestroyActor_bShouldModifyLevel_IsValid && EditorDestroyActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorDestroyActor", EditorDestroyActor_IsValid);
		EditorAddModalWindow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EditorAddModalWindow");
		EditorAddModalWindow_ParamsSize = NativeReflection.GetFunctionParamsSize(EditorAddModalWindow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditorAddModalWindow_Widget_PropertyAddress, EditorAddModalWindow_FunctionAddress, "Widget");
		EditorAddModalWindow_Widget_Offset = NativeReflectionCached.GetPropertyOffset(EditorAddModalWindow_FunctionAddress, "Widget");
		EditorAddModalWindow_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(EditorAddModalWindow_FunctionAddress, "Widget", Classes.FStructProperty);
		EditorAddModalWindow_IsValid = EditorAddModalWindow_FunctionAddress != IntPtr.Zero && EditorAddModalWindow_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:EditorAddModalWindow", EditorAddModalWindow_IsValid);
		DrawWireStar_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireStar");
		DrawWireStar_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireStar_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireStar_PDI_PropertyAddress, DrawWireStar_FunctionAddress, "PDI");
		DrawWireStar_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireStar_FunctionAddress, "PDI");
		DrawWireStar_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireStar_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireStar_Position_PropertyAddress, DrawWireStar_FunctionAddress, "Position");
		DrawWireStar_Position_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireStar_FunctionAddress, "Position");
		DrawWireStar_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireStar_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireStar_Size_PropertyAddress, DrawWireStar_FunctionAddress, "Size");
		DrawWireStar_Size_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireStar_FunctionAddress, "Size");
		DrawWireStar_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireStar_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireStar_Color_PropertyAddress, DrawWireStar_FunctionAddress, "Color");
		DrawWireStar_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireStar_FunctionAddress, "Color");
		DrawWireStar_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireStar_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireStar_DepthPriority_PropertyAddress, DrawWireStar_FunctionAddress, "DepthPriority");
		DrawWireStar_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireStar_FunctionAddress, "DepthPriority");
		DrawWireStar_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireStar_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		DrawWireStar_IsValid = DrawWireStar_FunctionAddress != IntPtr.Zero && DrawWireStar_PDI_IsValid && DrawWireStar_Position_IsValid && DrawWireStar_Size_IsValid && DrawWireStar_Color_IsValid && DrawWireStar_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireStar", DrawWireStar_IsValid);
		DrawWireSphereCappedCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireSphereCappedCone");
		DrawWireSphereCappedCone_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireSphereCappedCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_PDI_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "PDI");
		DrawWireSphereCappedCone_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "PDI");
		DrawWireSphereCappedCone_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_Transform_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "Transform");
		DrawWireSphereCappedCone_Transform_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "Transform");
		DrawWireSphereCappedCone_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_ConeRadius_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "ConeRadius");
		DrawWireSphereCappedCone_ConeRadius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "ConeRadius");
		DrawWireSphereCappedCone_ConeRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "ConeRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_ConeAngle_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "ConeAngle");
		DrawWireSphereCappedCone_ConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "ConeAngle");
		DrawWireSphereCappedCone_ConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "ConeAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_ConeSides_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "ConeSides");
		DrawWireSphereCappedCone_ConeSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "ConeSides");
		DrawWireSphereCappedCone_ConeSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "ConeSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_ArcFrequency_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "ArcFrequency");
		DrawWireSphereCappedCone_ArcFrequency_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "ArcFrequency");
		DrawWireSphereCappedCone_ArcFrequency_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "ArcFrequency", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_CapSegments_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "CapSegments");
		DrawWireSphereCappedCone_CapSegments_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "CapSegments");
		DrawWireSphereCappedCone_CapSegments_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "CapSegments", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_Color_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "Color");
		DrawWireSphereCappedCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "Color");
		DrawWireSphereCappedCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereCappedCone_DepthPriority_PropertyAddress, DrawWireSphereCappedCone_FunctionAddress, "DepthPriority");
		DrawWireSphereCappedCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereCappedCone_FunctionAddress, "DepthPriority");
		DrawWireSphereCappedCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereCappedCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		DrawWireSphereCappedCone_IsValid = DrawWireSphereCappedCone_FunctionAddress != IntPtr.Zero && DrawWireSphereCappedCone_PDI_IsValid && DrawWireSphereCappedCone_Transform_IsValid && DrawWireSphereCappedCone_ConeRadius_IsValid && DrawWireSphereCappedCone_ConeAngle_IsValid && DrawWireSphereCappedCone_ConeSides_IsValid && DrawWireSphereCappedCone_ArcFrequency_IsValid && DrawWireSphereCappedCone_CapSegments_IsValid && DrawWireSphereCappedCone_Color_IsValid && DrawWireSphereCappedCone_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereCappedCone", DrawWireSphereCappedCone_IsValid);
		DrawWireSphereAutoSides2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireSphereAutoSides2");
		DrawWireSphereAutoSides2_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireSphereAutoSides2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_PDI_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "PDI");
		DrawWireSphereAutoSides2_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "PDI");
		DrawWireSphereAutoSides2_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_Transform_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "Transform");
		DrawWireSphereAutoSides2_Transform_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "Transform");
		DrawWireSphereAutoSides2_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_Color_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "Color");
		DrawWireSphereAutoSides2_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "Color");
		DrawWireSphereAutoSides2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_Radius_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "Radius");
		DrawWireSphereAutoSides2_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "Radius");
		DrawWireSphereAutoSides2_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_DepthPriority_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "DepthPriority");
		DrawWireSphereAutoSides2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "DepthPriority");
		DrawWireSphereAutoSides2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_Thickness_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "Thickness");
		DrawWireSphereAutoSides2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "Thickness");
		DrawWireSphereAutoSides2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_DepthBias_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "DepthBias");
		DrawWireSphereAutoSides2_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "DepthBias");
		DrawWireSphereAutoSides2_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides2_bScreenSpace_PropertyAddress, DrawWireSphereAutoSides2_FunctionAddress, "bScreenSpace");
		DrawWireSphereAutoSides2_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides2_FunctionAddress, "bScreenSpace");
		DrawWireSphereAutoSides2_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides2_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireSphereAutoSides2_IsValid = DrawWireSphereAutoSides2_FunctionAddress != IntPtr.Zero && DrawWireSphereAutoSides2_PDI_IsValid && DrawWireSphereAutoSides2_Transform_IsValid && DrawWireSphereAutoSides2_Color_IsValid && DrawWireSphereAutoSides2_Radius_IsValid && DrawWireSphereAutoSides2_DepthPriority_IsValid && DrawWireSphereAutoSides2_Thickness_IsValid && DrawWireSphereAutoSides2_DepthBias_IsValid && DrawWireSphereAutoSides2_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides2", DrawWireSphereAutoSides2_IsValid);
		DrawWireSphereAutoSides_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireSphereAutoSides");
		DrawWireSphereAutoSides_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireSphereAutoSides_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_PDI_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "PDI");
		DrawWireSphereAutoSides_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "PDI");
		DrawWireSphereAutoSides_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_Base_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "Base");
		DrawWireSphereAutoSides_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "Base");
		DrawWireSphereAutoSides_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_Color_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "Color");
		DrawWireSphereAutoSides_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "Color");
		DrawWireSphereAutoSides_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_Radius_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "Radius");
		DrawWireSphereAutoSides_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "Radius");
		DrawWireSphereAutoSides_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_DepthPriority_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "DepthPriority");
		DrawWireSphereAutoSides_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "DepthPriority");
		DrawWireSphereAutoSides_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_Thickness_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "Thickness");
		DrawWireSphereAutoSides_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "Thickness");
		DrawWireSphereAutoSides_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_DepthBias_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "DepthBias");
		DrawWireSphereAutoSides_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "DepthBias");
		DrawWireSphereAutoSides_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphereAutoSides_bScreenSpace_PropertyAddress, DrawWireSphereAutoSides_FunctionAddress, "bScreenSpace");
		DrawWireSphereAutoSides_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphereAutoSides_FunctionAddress, "bScreenSpace");
		DrawWireSphereAutoSides_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphereAutoSides_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireSphereAutoSides_IsValid = DrawWireSphereAutoSides_FunctionAddress != IntPtr.Zero && DrawWireSphereAutoSides_PDI_IsValid && DrawWireSphereAutoSides_Base_IsValid && DrawWireSphereAutoSides_Color_IsValid && DrawWireSphereAutoSides_Radius_IsValid && DrawWireSphereAutoSides_DepthPriority_IsValid && DrawWireSphereAutoSides_Thickness_IsValid && DrawWireSphereAutoSides_DepthBias_IsValid && DrawWireSphereAutoSides_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphereAutoSides", DrawWireSphereAutoSides_IsValid);
		DrawWireSphere2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireSphere2");
		DrawWireSphere2_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireSphere2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_PDI_PropertyAddress, DrawWireSphere2_FunctionAddress, "PDI");
		DrawWireSphere2_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "PDI");
		DrawWireSphere2_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_Transform_PropertyAddress, DrawWireSphere2_FunctionAddress, "Transform");
		DrawWireSphere2_Transform_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "Transform");
		DrawWireSphere2_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_Color_PropertyAddress, DrawWireSphere2_FunctionAddress, "Color");
		DrawWireSphere2_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "Color");
		DrawWireSphere2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_Radius_PropertyAddress, DrawWireSphere2_FunctionAddress, "Radius");
		DrawWireSphere2_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "Radius");
		DrawWireSphere2_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_NumSides_PropertyAddress, DrawWireSphere2_FunctionAddress, "NumSides");
		DrawWireSphere2_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "NumSides");
		DrawWireSphere2_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_DepthPriority_PropertyAddress, DrawWireSphere2_FunctionAddress, "DepthPriority");
		DrawWireSphere2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "DepthPriority");
		DrawWireSphere2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_Thickness_PropertyAddress, DrawWireSphere2_FunctionAddress, "Thickness");
		DrawWireSphere2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "Thickness");
		DrawWireSphere2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_DepthBias_PropertyAddress, DrawWireSphere2_FunctionAddress, "DepthBias");
		DrawWireSphere2_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "DepthBias");
		DrawWireSphere2_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere2_bScreenSpace_PropertyAddress, DrawWireSphere2_FunctionAddress, "bScreenSpace");
		DrawWireSphere2_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere2_FunctionAddress, "bScreenSpace");
		DrawWireSphere2_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere2_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireSphere2_IsValid = DrawWireSphere2_FunctionAddress != IntPtr.Zero && DrawWireSphere2_PDI_IsValid && DrawWireSphere2_Transform_IsValid && DrawWireSphere2_Color_IsValid && DrawWireSphere2_Radius_IsValid && DrawWireSphere2_NumSides_IsValid && DrawWireSphere2_DepthPriority_IsValid && DrawWireSphere2_Thickness_IsValid && DrawWireSphere2_DepthBias_IsValid && DrawWireSphere2_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere2", DrawWireSphere2_IsValid);
		DrawWireSphere_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireSphere");
		DrawWireSphere_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireSphere_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_PDI_PropertyAddress, DrawWireSphere_FunctionAddress, "PDI");
		DrawWireSphere_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "PDI");
		DrawWireSphere_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_Base_PropertyAddress, DrawWireSphere_FunctionAddress, "Base");
		DrawWireSphere_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "Base");
		DrawWireSphere_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_Color_PropertyAddress, DrawWireSphere_FunctionAddress, "Color");
		DrawWireSphere_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "Color");
		DrawWireSphere_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_Radius_PropertyAddress, DrawWireSphere_FunctionAddress, "Radius");
		DrawWireSphere_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "Radius");
		DrawWireSphere_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_NumSides_PropertyAddress, DrawWireSphere_FunctionAddress, "NumSides");
		DrawWireSphere_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "NumSides");
		DrawWireSphere_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_DepthPriority_PropertyAddress, DrawWireSphere_FunctionAddress, "DepthPriority");
		DrawWireSphere_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "DepthPriority");
		DrawWireSphere_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_Thickness_PropertyAddress, DrawWireSphere_FunctionAddress, "Thickness");
		DrawWireSphere_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "Thickness");
		DrawWireSphere_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_DepthBias_PropertyAddress, DrawWireSphere_FunctionAddress, "DepthBias");
		DrawWireSphere_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "DepthBias");
		DrawWireSphere_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireSphere_bScreenSpace_PropertyAddress, DrawWireSphere_FunctionAddress, "bScreenSpace");
		DrawWireSphere_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireSphere_FunctionAddress, "bScreenSpace");
		DrawWireSphere_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireSphere_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireSphere_IsValid = DrawWireSphere_FunctionAddress != IntPtr.Zero && DrawWireSphere_PDI_IsValid && DrawWireSphere_Base_IsValid && DrawWireSphere_Color_IsValid && DrawWireSphere_Radius_IsValid && DrawWireSphere_NumSides_IsValid && DrawWireSphere_DepthPriority_IsValid && DrawWireSphere_Thickness_IsValid && DrawWireSphere_DepthBias_IsValid && DrawWireSphere_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireSphere", DrawWireSphere_IsValid);
		DrawWireDiamond_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireDiamond");
		DrawWireDiamond_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireDiamond_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireDiamond_PDI_PropertyAddress, DrawWireDiamond_FunctionAddress, "PDI");
		DrawWireDiamond_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireDiamond_FunctionAddress, "PDI");
		DrawWireDiamond_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireDiamond_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireDiamond_Transform_PropertyAddress, DrawWireDiamond_FunctionAddress, "Transform");
		DrawWireDiamond_Transform_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireDiamond_FunctionAddress, "Transform");
		DrawWireDiamond_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireDiamond_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireDiamond_Size_PropertyAddress, DrawWireDiamond_FunctionAddress, "Size");
		DrawWireDiamond_Size_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireDiamond_FunctionAddress, "Size");
		DrawWireDiamond_Size_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireDiamond_FunctionAddress, "Size", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireDiamond_InColor_PropertyAddress, DrawWireDiamond_FunctionAddress, "InColor");
		DrawWireDiamond_InColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireDiamond_FunctionAddress, "InColor");
		DrawWireDiamond_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireDiamond_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireDiamond_DepthPriority_PropertyAddress, DrawWireDiamond_FunctionAddress, "DepthPriority");
		DrawWireDiamond_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireDiamond_FunctionAddress, "DepthPriority");
		DrawWireDiamond_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireDiamond_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		DrawWireDiamond_IsValid = DrawWireDiamond_FunctionAddress != IntPtr.Zero && DrawWireDiamond_PDI_IsValid && DrawWireDiamond_Transform_IsValid && DrawWireDiamond_Size_IsValid && DrawWireDiamond_InColor_IsValid && DrawWireDiamond_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireDiamond", DrawWireDiamond_IsValid);
		DrawWireCylinder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireCylinder");
		DrawWireCylinder_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireCylinder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_PDI_PropertyAddress, DrawWireCylinder_FunctionAddress, "PDI");
		DrawWireCylinder_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "PDI");
		DrawWireCylinder_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Base_PropertyAddress, DrawWireCylinder_FunctionAddress, "Base");
		DrawWireCylinder_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Base");
		DrawWireCylinder_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_X_PropertyAddress, DrawWireCylinder_FunctionAddress, "X");
		DrawWireCylinder_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "X");
		DrawWireCylinder_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Y_PropertyAddress, DrawWireCylinder_FunctionAddress, "Y");
		DrawWireCylinder_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Y");
		DrawWireCylinder_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Z_PropertyAddress, DrawWireCylinder_FunctionAddress, "Z");
		DrawWireCylinder_Z_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Z");
		DrawWireCylinder_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Z", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Color_PropertyAddress, DrawWireCylinder_FunctionAddress, "Color");
		DrawWireCylinder_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Color");
		DrawWireCylinder_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Radius_PropertyAddress, DrawWireCylinder_FunctionAddress, "Radius");
		DrawWireCylinder_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Radius");
		DrawWireCylinder_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_HalfHeight_PropertyAddress, DrawWireCylinder_FunctionAddress, "HalfHeight");
		DrawWireCylinder_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "HalfHeight");
		DrawWireCylinder_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_NumSides_PropertyAddress, DrawWireCylinder_FunctionAddress, "NumSides");
		DrawWireCylinder_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "NumSides");
		DrawWireCylinder_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_DepthPriority_PropertyAddress, DrawWireCylinder_FunctionAddress, "DepthPriority");
		DrawWireCylinder_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "DepthPriority");
		DrawWireCylinder_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_Thickness_PropertyAddress, DrawWireCylinder_FunctionAddress, "Thickness");
		DrawWireCylinder_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "Thickness");
		DrawWireCylinder_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_DepthBias_PropertyAddress, DrawWireCylinder_FunctionAddress, "DepthBias");
		DrawWireCylinder_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "DepthBias");
		DrawWireCylinder_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCylinder_bScreenSpace_PropertyAddress, DrawWireCylinder_FunctionAddress, "bScreenSpace");
		DrawWireCylinder_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCylinder_FunctionAddress, "bScreenSpace");
		DrawWireCylinder_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCylinder_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireCylinder_IsValid = DrawWireCylinder_FunctionAddress != IntPtr.Zero && DrawWireCylinder_PDI_IsValid && DrawWireCylinder_Base_IsValid && DrawWireCylinder_X_IsValid && DrawWireCylinder_Y_IsValid && DrawWireCylinder_Z_IsValid && DrawWireCylinder_Color_IsValid && DrawWireCylinder_Radius_IsValid && DrawWireCylinder_HalfHeight_IsValid && DrawWireCylinder_NumSides_IsValid && DrawWireCylinder_DepthPriority_IsValid && DrawWireCylinder_Thickness_IsValid && DrawWireCylinder_DepthBias_IsValid && DrawWireCylinder_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCylinder", DrawWireCylinder_IsValid);
		DrawWireCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireCone");
		DrawWireCone_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_PDI_PropertyAddress, DrawWireCone_FunctionAddress, "PDI");
		DrawWireCone_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "PDI");
		DrawWireCone_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_Verts_PropertyAddress, DrawWireCone_FunctionAddress, "Verts");
		DrawWireCone_Verts_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "Verts");
		DrawWireCone_Verts_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "Verts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_Transform_PropertyAddress, DrawWireCone_FunctionAddress, "Transform");
		DrawWireCone_Transform_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "Transform");
		DrawWireCone_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_ConeRadius_PropertyAddress, DrawWireCone_FunctionAddress, "ConeRadius");
		DrawWireCone_ConeRadius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "ConeRadius");
		DrawWireCone_ConeRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "ConeRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_ConeAngle_PropertyAddress, DrawWireCone_FunctionAddress, "ConeAngle");
		DrawWireCone_ConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "ConeAngle");
		DrawWireCone_ConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "ConeAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_ConeSides_PropertyAddress, DrawWireCone_FunctionAddress, "ConeSides");
		DrawWireCone_ConeSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "ConeSides");
		DrawWireCone_ConeSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "ConeSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_Color_PropertyAddress, DrawWireCone_FunctionAddress, "Color");
		DrawWireCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "Color");
		DrawWireCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_DepthPriority_PropertyAddress, DrawWireCone_FunctionAddress, "DepthPriority");
		DrawWireCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "DepthPriority");
		DrawWireCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_Thickness_PropertyAddress, DrawWireCone_FunctionAddress, "Thickness");
		DrawWireCone_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "Thickness");
		DrawWireCone_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_DepthBias_PropertyAddress, DrawWireCone_FunctionAddress, "DepthBias");
		DrawWireCone_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "DepthBias");
		DrawWireCone_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCone_bScreenSpace_PropertyAddress, DrawWireCone_FunctionAddress, "bScreenSpace");
		DrawWireCone_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCone_FunctionAddress, "bScreenSpace");
		DrawWireCone_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCone_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireCone_IsValid = DrawWireCone_FunctionAddress != IntPtr.Zero && DrawWireCone_PDI_IsValid && DrawWireCone_Verts_IsValid && DrawWireCone_Transform_IsValid && DrawWireCone_ConeRadius_IsValid && DrawWireCone_ConeAngle_IsValid && DrawWireCone_ConeSides_IsValid && DrawWireCone_Color_IsValid && DrawWireCone_DepthPriority_IsValid && DrawWireCone_Thickness_IsValid && DrawWireCone_DepthBias_IsValid && DrawWireCone_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCone", DrawWireCone_IsValid);
		DrawWireChoppedCone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireChoppedCone");
		DrawWireChoppedCone_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireChoppedCone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_PDI_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "PDI");
		DrawWireChoppedCone_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "PDI");
		DrawWireChoppedCone_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_Base_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "Base");
		DrawWireChoppedCone_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "Base");
		DrawWireChoppedCone_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_X_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "X");
		DrawWireChoppedCone_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "X");
		DrawWireChoppedCone_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_Y_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "Y");
		DrawWireChoppedCone_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "Y");
		DrawWireChoppedCone_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_Z_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "Z");
		DrawWireChoppedCone_Z_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "Z");
		DrawWireChoppedCone_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "Z", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_Color_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "Color");
		DrawWireChoppedCone_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "Color");
		DrawWireChoppedCone_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_Radius_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "Radius");
		DrawWireChoppedCone_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "Radius");
		DrawWireChoppedCone_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_TopRadius_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "TopRadius");
		DrawWireChoppedCone_TopRadius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "TopRadius");
		DrawWireChoppedCone_TopRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "TopRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_HalfHeight_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "HalfHeight");
		DrawWireChoppedCone_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "HalfHeight");
		DrawWireChoppedCone_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_NumSides_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "NumSides");
		DrawWireChoppedCone_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "NumSides");
		DrawWireChoppedCone_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireChoppedCone_DepthPriority_PropertyAddress, DrawWireChoppedCone_FunctionAddress, "DepthPriority");
		DrawWireChoppedCone_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireChoppedCone_FunctionAddress, "DepthPriority");
		DrawWireChoppedCone_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireChoppedCone_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		DrawWireChoppedCone_IsValid = DrawWireChoppedCone_FunctionAddress != IntPtr.Zero && DrawWireChoppedCone_PDI_IsValid && DrawWireChoppedCone_Base_IsValid && DrawWireChoppedCone_X_IsValid && DrawWireChoppedCone_Y_IsValid && DrawWireChoppedCone_Z_IsValid && DrawWireChoppedCone_Color_IsValid && DrawWireChoppedCone_Radius_IsValid && DrawWireChoppedCone_TopRadius_IsValid && DrawWireChoppedCone_HalfHeight_IsValid && DrawWireChoppedCone_NumSides_IsValid && DrawWireChoppedCone_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireChoppedCone", DrawWireChoppedCone_IsValid);
		DrawWireCapsule_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireCapsule");
		DrawWireCapsule_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireCapsule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_PDI_PropertyAddress, DrawWireCapsule_FunctionAddress, "PDI");
		DrawWireCapsule_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "PDI");
		DrawWireCapsule_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Base_PropertyAddress, DrawWireCapsule_FunctionAddress, "Base");
		DrawWireCapsule_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Base");
		DrawWireCapsule_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_X_PropertyAddress, DrawWireCapsule_FunctionAddress, "X");
		DrawWireCapsule_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "X");
		DrawWireCapsule_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Y_PropertyAddress, DrawWireCapsule_FunctionAddress, "Y");
		DrawWireCapsule_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Y");
		DrawWireCapsule_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Z_PropertyAddress, DrawWireCapsule_FunctionAddress, "Z");
		DrawWireCapsule_Z_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Z");
		DrawWireCapsule_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Z", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Color_PropertyAddress, DrawWireCapsule_FunctionAddress, "Color");
		DrawWireCapsule_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Color");
		DrawWireCapsule_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Radius_PropertyAddress, DrawWireCapsule_FunctionAddress, "Radius");
		DrawWireCapsule_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Radius");
		DrawWireCapsule_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_HalfHeight_PropertyAddress, DrawWireCapsule_FunctionAddress, "HalfHeight");
		DrawWireCapsule_HalfHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "HalfHeight");
		DrawWireCapsule_HalfHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "HalfHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_NumSides_PropertyAddress, DrawWireCapsule_FunctionAddress, "NumSides");
		DrawWireCapsule_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "NumSides");
		DrawWireCapsule_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_DepthPriority_PropertyAddress, DrawWireCapsule_FunctionAddress, "DepthPriority");
		DrawWireCapsule_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "DepthPriority");
		DrawWireCapsule_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_Thickness_PropertyAddress, DrawWireCapsule_FunctionAddress, "Thickness");
		DrawWireCapsule_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "Thickness");
		DrawWireCapsule_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_DepthBias_PropertyAddress, DrawWireCapsule_FunctionAddress, "DepthBias");
		DrawWireCapsule_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "DepthBias");
		DrawWireCapsule_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireCapsule_bScreenSpace_PropertyAddress, DrawWireCapsule_FunctionAddress, "bScreenSpace");
		DrawWireCapsule_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireCapsule_FunctionAddress, "bScreenSpace");
		DrawWireCapsule_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireCapsule_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireCapsule_IsValid = DrawWireCapsule_FunctionAddress != IntPtr.Zero && DrawWireCapsule_PDI_IsValid && DrawWireCapsule_Base_IsValid && DrawWireCapsule_X_IsValid && DrawWireCapsule_Y_IsValid && DrawWireCapsule_Z_IsValid && DrawWireCapsule_Color_IsValid && DrawWireCapsule_Radius_IsValid && DrawWireCapsule_HalfHeight_IsValid && DrawWireCapsule_NumSides_IsValid && DrawWireCapsule_DepthPriority_IsValid && DrawWireCapsule_Thickness_IsValid && DrawWireCapsule_DepthBias_IsValid && DrawWireCapsule_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireCapsule", DrawWireCapsule_IsValid);
		DrawWireBox2_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireBox2");
		DrawWireBox2_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireBox2_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_PDI_PropertyAddress, DrawWireBox2_FunctionAddress, "PDI");
		DrawWireBox2_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "PDI");
		DrawWireBox2_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_Matrix_PropertyAddress, DrawWireBox2_FunctionAddress, "Matrix");
		DrawWireBox2_Matrix_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "Matrix");
		DrawWireBox2_Matrix_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "Matrix", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_Box_PropertyAddress, DrawWireBox2_FunctionAddress, "Box");
		DrawWireBox2_Box_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "Box");
		DrawWireBox2_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_Color_PropertyAddress, DrawWireBox2_FunctionAddress, "Color");
		DrawWireBox2_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "Color");
		DrawWireBox2_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_DepthPriority_PropertyAddress, DrawWireBox2_FunctionAddress, "DepthPriority");
		DrawWireBox2_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "DepthPriority");
		DrawWireBox2_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_Thickness_PropertyAddress, DrawWireBox2_FunctionAddress, "Thickness");
		DrawWireBox2_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "Thickness");
		DrawWireBox2_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_DepthBias_PropertyAddress, DrawWireBox2_FunctionAddress, "DepthBias");
		DrawWireBox2_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "DepthBias");
		DrawWireBox2_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox2_bScreenSpace_PropertyAddress, DrawWireBox2_FunctionAddress, "bScreenSpace");
		DrawWireBox2_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox2_FunctionAddress, "bScreenSpace");
		DrawWireBox2_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox2_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireBox2_IsValid = DrawWireBox2_FunctionAddress != IntPtr.Zero && DrawWireBox2_PDI_IsValid && DrawWireBox2_Matrix_IsValid && DrawWireBox2_Box_IsValid && DrawWireBox2_Color_IsValid && DrawWireBox2_DepthPriority_IsValid && DrawWireBox2_Thickness_IsValid && DrawWireBox2_DepthBias_IsValid && DrawWireBox2_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox2", DrawWireBox2_IsValid);
		DrawWireBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawWireBox");
		DrawWireBox_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawWireBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_PDI_PropertyAddress, DrawWireBox_FunctionAddress, "PDI");
		DrawWireBox_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "PDI");
		DrawWireBox_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_Box_PropertyAddress, DrawWireBox_FunctionAddress, "Box");
		DrawWireBox_Box_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "Box");
		DrawWireBox_Box_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "Box", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_Color_PropertyAddress, DrawWireBox_FunctionAddress, "Color");
		DrawWireBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "Color");
		DrawWireBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_DepthPriority_PropertyAddress, DrawWireBox_FunctionAddress, "DepthPriority");
		DrawWireBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "DepthPriority");
		DrawWireBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_Thickness_PropertyAddress, DrawWireBox_FunctionAddress, "Thickness");
		DrawWireBox_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "Thickness");
		DrawWireBox_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_DepthBias_PropertyAddress, DrawWireBox_FunctionAddress, "DepthBias");
		DrawWireBox_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "DepthBias");
		DrawWireBox_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawWireBox_bScreenSpace_PropertyAddress, DrawWireBox_FunctionAddress, "bScreenSpace");
		DrawWireBox_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawWireBox_FunctionAddress, "bScreenSpace");
		DrawWireBox_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawWireBox_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawWireBox_IsValid = DrawWireBox_FunctionAddress != IntPtr.Zero && DrawWireBox_PDI_IsValid && DrawWireBox_Box_IsValid && DrawWireBox_Color_IsValid && DrawWireBox_DepthPriority_IsValid && DrawWireBox_Thickness_IsValid && DrawWireBox_DepthBias_IsValid && DrawWireBox_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawWireBox", DrawWireBox_IsValid);
		DrawPolygon_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawPolygon");
		DrawPolygon_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawPolygon_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_PDI_PropertyAddress, DrawPolygon_FunctionAddress, "PDI");
		DrawPolygon_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "PDI");
		DrawPolygon_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_Verts_PropertyAddress, DrawPolygon_FunctionAddress, "Verts");
		DrawPolygon_Verts_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "Verts");
		DrawPolygon_Verts_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "Verts", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_InColor_PropertyAddress, DrawPolygon_FunctionAddress, "InColor");
		DrawPolygon_InColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "InColor");
		DrawPolygon_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_DepthPriority_PropertyAddress, DrawPolygon_FunctionAddress, "DepthPriority");
		DrawPolygon_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "DepthPriority");
		DrawPolygon_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawPolygon_RHIFeatureLevel_PropertyAddress, DrawPolygon_FunctionAddress, "RHIFeatureLevel");
		DrawPolygon_RHIFeatureLevel_Offset = NativeReflectionCached.GetPropertyOffset(DrawPolygon_FunctionAddress, "RHIFeatureLevel");
		DrawPolygon_RHIFeatureLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawPolygon_FunctionAddress, "RHIFeatureLevel", Classes.FByteProperty);
		DrawPolygon_IsValid = DrawPolygon_FunctionAddress != IntPtr.Zero && DrawPolygon_PDI_IsValid && DrawPolygon_Verts_IsValid && DrawPolygon_InColor_IsValid && DrawPolygon_DepthPriority_IsValid && DrawPolygon_RHIFeatureLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawPolygon", DrawPolygon_IsValid);
		DrawOrientedWireBox_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawOrientedWireBox");
		DrawOrientedWireBox_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawOrientedWireBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_PDI_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "PDI");
		DrawOrientedWireBox_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "PDI");
		DrawOrientedWireBox_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Base_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Base");
		DrawOrientedWireBox_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Base");
		DrawOrientedWireBox_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_X_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "X");
		DrawOrientedWireBox_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "X");
		DrawOrientedWireBox_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Y_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Y");
		DrawOrientedWireBox_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Y");
		DrawOrientedWireBox_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Z_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Z");
		DrawOrientedWireBox_Z_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Z");
		DrawOrientedWireBox_Z_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Z", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Extent_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Extent");
		DrawOrientedWireBox_Extent_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Extent");
		DrawOrientedWireBox_Extent_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Extent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Color_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Color");
		DrawOrientedWireBox_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Color");
		DrawOrientedWireBox_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_DepthPriority_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "DepthPriority");
		DrawOrientedWireBox_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "DepthPriority");
		DrawOrientedWireBox_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_Thickness_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "Thickness");
		DrawOrientedWireBox_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "Thickness");
		DrawOrientedWireBox_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_DepthBias_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "DepthBias");
		DrawOrientedWireBox_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "DepthBias");
		DrawOrientedWireBox_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawOrientedWireBox_bScreenSpace_PropertyAddress, DrawOrientedWireBox_FunctionAddress, "bScreenSpace");
		DrawOrientedWireBox_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawOrientedWireBox_FunctionAddress, "bScreenSpace");
		DrawOrientedWireBox_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawOrientedWireBox_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawOrientedWireBox_IsValid = DrawOrientedWireBox_FunctionAddress != IntPtr.Zero && DrawOrientedWireBox_PDI_IsValid && DrawOrientedWireBox_Base_IsValid && DrawOrientedWireBox_X_IsValid && DrawOrientedWireBox_Y_IsValid && DrawOrientedWireBox_Z_IsValid && DrawOrientedWireBox_Extent_IsValid && DrawOrientedWireBox_Color_IsValid && DrawOrientedWireBox_DepthPriority_IsValid && DrawOrientedWireBox_Thickness_IsValid && DrawOrientedWireBox_DepthBias_IsValid && DrawOrientedWireBox_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawOrientedWireBox", DrawOrientedWireBox_IsValid);
		DrawDirectionalArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawDirectionalArrow");
		DrawDirectionalArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawDirectionalArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_PDI_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "PDI");
		DrawDirectionalArrow_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "PDI");
		DrawDirectionalArrow_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_ArrowToWorld_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "ArrowToWorld");
		DrawDirectionalArrow_ArrowToWorld_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "ArrowToWorld");
		DrawDirectionalArrow_ArrowToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "ArrowToWorld", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_InColor_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "InColor");
		DrawDirectionalArrow_InColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "InColor");
		DrawDirectionalArrow_InColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "InColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_Length_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "Length");
		DrawDirectionalArrow_Length_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "Length");
		DrawDirectionalArrow_Length_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "Length", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_ArrowSize_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "ArrowSize");
		DrawDirectionalArrow_ArrowSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "ArrowSize");
		DrawDirectionalArrow_ArrowSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "ArrowSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_DepthPriority_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "DepthPriority");
		DrawDirectionalArrow_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "DepthPriority");
		DrawDirectionalArrow_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDirectionalArrow_Thickness_PropertyAddress, DrawDirectionalArrow_FunctionAddress, "Thickness");
		DrawDirectionalArrow_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawDirectionalArrow_FunctionAddress, "Thickness");
		DrawDirectionalArrow_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDirectionalArrow_FunctionAddress, "Thickness", Classes.FFloatProperty);
		DrawDirectionalArrow_IsValid = DrawDirectionalArrow_FunctionAddress != IntPtr.Zero && DrawDirectionalArrow_PDI_IsValid && DrawDirectionalArrow_ArrowToWorld_IsValid && DrawDirectionalArrow_InColor_IsValid && DrawDirectionalArrow_Length_IsValid && DrawDirectionalArrow_ArrowSize_IsValid && DrawDirectionalArrow_DepthPriority_IsValid && DrawDirectionalArrow_Thickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDirectionalArrow", DrawDirectionalArrow_IsValid);
		DrawDashedLine_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawDashedLine");
		DrawDashedLine_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawDashedLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_PDI_PropertyAddress, DrawDashedLine_FunctionAddress, "PDI");
		DrawDashedLine_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "PDI");
		DrawDashedLine_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_Start_PropertyAddress, DrawDashedLine_FunctionAddress, "Start");
		DrawDashedLine_Start_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "Start");
		DrawDashedLine_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_End_PropertyAddress, DrawDashedLine_FunctionAddress, "End");
		DrawDashedLine_End_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "End");
		DrawDashedLine_End_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_Color_PropertyAddress, DrawDashedLine_FunctionAddress, "Color");
		DrawDashedLine_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "Color");
		DrawDashedLine_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_DashSize_PropertyAddress, DrawDashedLine_FunctionAddress, "DashSize");
		DrawDashedLine_DashSize_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "DashSize");
		DrawDashedLine_DashSize_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "DashSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_DepthPriority_PropertyAddress, DrawDashedLine_FunctionAddress, "DepthPriority");
		DrawDashedLine_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "DepthPriority");
		DrawDashedLine_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDashedLine_DepthBias_PropertyAddress, DrawDashedLine_FunctionAddress, "DepthBias");
		DrawDashedLine_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawDashedLine_FunctionAddress, "DepthBias");
		DrawDashedLine_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDashedLine_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		DrawDashedLine_IsValid = DrawDashedLine_FunctionAddress != IntPtr.Zero && DrawDashedLine_PDI_IsValid && DrawDashedLine_Start_IsValid && DrawDashedLine_End_IsValid && DrawDashedLine_Color_IsValid && DrawDashedLine_DashSize_IsValid && DrawDashedLine_DepthPriority_IsValid && DrawDashedLine_DepthBias_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawDashedLine", DrawDashedLine_IsValid);
		DrawConnectedArrow_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawConnectedArrow");
		DrawConnectedArrow_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawConnectedArrow_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_PDI_PropertyAddress, DrawConnectedArrow_FunctionAddress, "PDI");
		DrawConnectedArrow_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "PDI");
		DrawConnectedArrow_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_ArrowToWorld_PropertyAddress, DrawConnectedArrow_FunctionAddress, "ArrowToWorld");
		DrawConnectedArrow_ArrowToWorld_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "ArrowToWorld");
		DrawConnectedArrow_ArrowToWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "ArrowToWorld", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_Color_PropertyAddress, DrawConnectedArrow_FunctionAddress, "Color");
		DrawConnectedArrow_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "Color");
		DrawConnectedArrow_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_ArrowHeight_PropertyAddress, DrawConnectedArrow_FunctionAddress, "ArrowHeight");
		DrawConnectedArrow_ArrowHeight_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "ArrowHeight");
		DrawConnectedArrow_ArrowHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "ArrowHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_ArrowWidth_PropertyAddress, DrawConnectedArrow_FunctionAddress, "ArrowWidth");
		DrawConnectedArrow_ArrowWidth_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "ArrowWidth");
		DrawConnectedArrow_ArrowWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "ArrowWidth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_DepthPriority_PropertyAddress, DrawConnectedArrow_FunctionAddress, "DepthPriority");
		DrawConnectedArrow_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "DepthPriority");
		DrawConnectedArrow_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_Thickness_PropertyAddress, DrawConnectedArrow_FunctionAddress, "Thickness");
		DrawConnectedArrow_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "Thickness");
		DrawConnectedArrow_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawConnectedArrow_NumSpokes_PropertyAddress, DrawConnectedArrow_FunctionAddress, "NumSpokes");
		DrawConnectedArrow_NumSpokes_Offset = NativeReflectionCached.GetPropertyOffset(DrawConnectedArrow_FunctionAddress, "NumSpokes");
		DrawConnectedArrow_NumSpokes_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawConnectedArrow_FunctionAddress, "NumSpokes", Classes.FIntProperty);
		DrawConnectedArrow_IsValid = DrawConnectedArrow_FunctionAddress != IntPtr.Zero && DrawConnectedArrow_PDI_IsValid && DrawConnectedArrow_ArrowToWorld_IsValid && DrawConnectedArrow_Color_IsValid && DrawConnectedArrow_ArrowHeight_IsValid && DrawConnectedArrow_ArrowWidth_IsValid && DrawConnectedArrow_DepthPriority_IsValid && DrawConnectedArrow_Thickness_IsValid && DrawConnectedArrow_NumSpokes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawConnectedArrow", DrawConnectedArrow_IsValid);
		DrawCircle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawCircle");
		DrawCircle_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawCircle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_PDI_PropertyAddress, DrawCircle_FunctionAddress, "PDI");
		DrawCircle_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "PDI");
		DrawCircle_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_Base_PropertyAddress, DrawCircle_FunctionAddress, "Base");
		DrawCircle_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "Base");
		DrawCircle_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_X_PropertyAddress, DrawCircle_FunctionAddress, "X");
		DrawCircle_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "X");
		DrawCircle_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_Y_PropertyAddress, DrawCircle_FunctionAddress, "Y");
		DrawCircle_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "Y");
		DrawCircle_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_Color_PropertyAddress, DrawCircle_FunctionAddress, "Color");
		DrawCircle_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "Color");
		DrawCircle_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_Radius_PropertyAddress, DrawCircle_FunctionAddress, "Radius");
		DrawCircle_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "Radius");
		DrawCircle_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_NumSides_PropertyAddress, DrawCircle_FunctionAddress, "NumSides");
		DrawCircle_NumSides_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "NumSides");
		DrawCircle_NumSides_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "NumSides", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_DepthPriority_PropertyAddress, DrawCircle_FunctionAddress, "DepthPriority");
		DrawCircle_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "DepthPriority");
		DrawCircle_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_Thickness_PropertyAddress, DrawCircle_FunctionAddress, "Thickness");
		DrawCircle_Thickness_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "Thickness");
		DrawCircle_Thickness_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "Thickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_DepthBias_PropertyAddress, DrawCircle_FunctionAddress, "DepthBias");
		DrawCircle_DepthBias_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "DepthBias");
		DrawCircle_DepthBias_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "DepthBias", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawCircle_bScreenSpace_PropertyAddress, DrawCircle_FunctionAddress, "bScreenSpace");
		DrawCircle_bScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(DrawCircle_FunctionAddress, "bScreenSpace");
		DrawCircle_bScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawCircle_FunctionAddress, "bScreenSpace", Classes.FBoolProperty);
		DrawCircle_IsValid = DrawCircle_FunctionAddress != IntPtr.Zero && DrawCircle_PDI_IsValid && DrawCircle_Base_IsValid && DrawCircle_X_IsValid && DrawCircle_Y_IsValid && DrawCircle_Color_IsValid && DrawCircle_Radius_IsValid && DrawCircle_NumSides_IsValid && DrawCircle_DepthPriority_IsValid && DrawCircle_Thickness_IsValid && DrawCircle_DepthBias_IsValid && DrawCircle_bScreenSpace_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawCircle", DrawCircle_IsValid);
		DrawArc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawArc");
		DrawArc_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawArc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_PDI_PropertyAddress, DrawArc_FunctionAddress, "PDI");
		DrawArc_PDI_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "PDI");
		DrawArc_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "PDI", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_Base_PropertyAddress, DrawArc_FunctionAddress, "Base");
		DrawArc_Base_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "Base");
		DrawArc_Base_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "Base", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_X_PropertyAddress, DrawArc_FunctionAddress, "X");
		DrawArc_X_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "X");
		DrawArc_X_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "X", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_Y_PropertyAddress, DrawArc_FunctionAddress, "Y");
		DrawArc_Y_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "Y");
		DrawArc_Y_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "Y", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_MinAngle_PropertyAddress, DrawArc_FunctionAddress, "MinAngle");
		DrawArc_MinAngle_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "MinAngle");
		DrawArc_MinAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "MinAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_MaxAngle_PropertyAddress, DrawArc_FunctionAddress, "MaxAngle");
		DrawArc_MaxAngle_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "MaxAngle");
		DrawArc_MaxAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "MaxAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_Radius_PropertyAddress, DrawArc_FunctionAddress, "Radius");
		DrawArc_Radius_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "Radius");
		DrawArc_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_Sections_PropertyAddress, DrawArc_FunctionAddress, "Sections");
		DrawArc_Sections_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "Sections");
		DrawArc_Sections_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "Sections", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_Color_PropertyAddress, DrawArc_FunctionAddress, "Color");
		DrawArc_Color_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "Color");
		DrawArc_Color_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "Color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawArc_DepthPriority_PropertyAddress, DrawArc_FunctionAddress, "DepthPriority");
		DrawArc_DepthPriority_Offset = NativeReflectionCached.GetPropertyOffset(DrawArc_FunctionAddress, "DepthPriority");
		DrawArc_DepthPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawArc_FunctionAddress, "DepthPriority", Classes.FByteProperty);
		DrawArc_IsValid = DrawArc_FunctionAddress != IntPtr.Zero && DrawArc_PDI_IsValid && DrawArc_Base_IsValid && DrawArc_X_IsValid && DrawArc_Y_IsValid && DrawArc_MinAngle_IsValid && DrawArc_MaxAngle_IsValid && DrawArc_Radius_IsValid && DrawArc_Sections_IsValid && DrawArc_Color_IsValid && DrawArc_DepthPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DrawArc", DrawArc_IsValid);
		DeselectAll_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeselectAll");
		DeselectAll_ParamsSize = NativeReflection.GetFunctionParamsSize(DeselectAll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeselectAll_Selection_PropertyAddress, DeselectAll_FunctionAddress, "Selection");
		DeselectAll_Selection_Offset = NativeReflectionCached.GetPropertyOffset(DeselectAll_FunctionAddress, "Selection");
		DeselectAll_Selection_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectAll_FunctionAddress, "Selection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeselectAll_InClass_PropertyAddress, DeselectAll_FunctionAddress, "InClass");
		DeselectAll_InClass_Offset = NativeReflectionCached.GetPropertyOffset(DeselectAll_FunctionAddress, "InClass");
		DeselectAll_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(DeselectAll_FunctionAddress, "InClass", Classes.FClassProperty);
		DeselectAll_IsValid = DeselectAll_FunctionAddress != IntPtr.Zero && DeselectAll_Selection_IsValid && DeselectAll_InClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DeselectAll", DeselectAll_IsValid);
		Deselect_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Deselect");
		Deselect_ParamsSize = NativeReflection.GetFunctionParamsSize(Deselect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Deselect_Selection_PropertyAddress, Deselect_FunctionAddress, "Selection");
		Deselect_Selection_Offset = NativeReflectionCached.GetPropertyOffset(Deselect_FunctionAddress, "Selection");
		Deselect_Selection_IsValid = NativeReflectionCached.ValidatePropertyClass(Deselect_FunctionAddress, "Selection", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Deselect_InObject_PropertyAddress, Deselect_FunctionAddress, "InObject");
		Deselect_InObject_Offset = NativeReflectionCached.GetPropertyOffset(Deselect_FunctionAddress, "InObject");
		Deselect_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(Deselect_FunctionAddress, "InObject", Classes.FObjectProperty);
		Deselect_IsValid = Deselect_FunctionAddress != IntPtr.Zero && Deselect_Selection_IsValid && Deselect_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:Deselect", Deselect_IsValid);
		DeletePackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeletePackage");
		DeletePackage_ParamsSize = NativeReflection.GetFunctionParamsSize(DeletePackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeletePackage_Package_PropertyAddress, DeletePackage_FunctionAddress, "Package");
		DeletePackage_Package_Offset = NativeReflectionCached.GetPropertyOffset(DeletePackage_FunctionAddress, "Package");
		DeletePackage_Package_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePackage_FunctionAddress, "Package", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeletePackage_ReturnValue_PropertyAddress, DeletePackage_FunctionAddress, "ReturnValue");
		DeletePackage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeletePackage_FunctionAddress, "ReturnValue");
		DeletePackage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeletePackage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeletePackage_IsValid = DeletePackage_FunctionAddress != IntPtr.Zero && DeletePackage_Package_IsValid && DeletePackage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:DeletePackage", DeletePackage_IsValid);
		csgAdd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "csgAdd");
		csgAdd_ParamsSize = NativeReflection.GetFunctionParamsSize(csgAdd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref csgAdd_DefaultBrush_PropertyAddress, csgAdd_FunctionAddress, "DefaultBrush");
		csgAdd_DefaultBrush_Offset = NativeReflectionCached.GetPropertyOffset(csgAdd_FunctionAddress, "DefaultBrush");
		csgAdd_DefaultBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(csgAdd_FunctionAddress, "DefaultBrush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref csgAdd_PolyFlags_PropertyAddress, csgAdd_FunctionAddress, "PolyFlags");
		csgAdd_PolyFlags_Offset = NativeReflectionCached.GetPropertyOffset(csgAdd_FunctionAddress, "PolyFlags");
		csgAdd_PolyFlags_IsValid = NativeReflectionCached.ValidatePropertyClass(csgAdd_FunctionAddress, "PolyFlags", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref csgAdd_BrushType_PropertyAddress, csgAdd_FunctionAddress, "BrushType");
		csgAdd_BrushType_Offset = NativeReflectionCached.GetPropertyOffset(csgAdd_FunctionAddress, "BrushType");
		csgAdd_BrushType_IsValid = NativeReflectionCached.ValidatePropertyClass(csgAdd_FunctionAddress, "BrushType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref csgAdd_ReturnValue_PropertyAddress, csgAdd_FunctionAddress, "ReturnValue");
		csgAdd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(csgAdd_FunctionAddress, "ReturnValue");
		csgAdd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(csgAdd_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		csgAdd_IsValid = csgAdd_FunctionAddress != IntPtr.Zero && csgAdd_DefaultBrush_IsValid && csgAdd_PolyFlags_IsValid && csgAdd_BrushType_IsValid && csgAdd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:csgAdd", csgAdd_IsValid);
		CreatePropertyEditorToolkit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreatePropertyEditorToolkit");
		CreatePropertyEditorToolkit_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePropertyEditorToolkit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_PropertyAddress, CreatePropertyEditorToolkit_FunctionAddress, "ObjectsForPropertiesMenu");
		CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_Offset = NativeReflectionCached.GetPropertyOffset(CreatePropertyEditorToolkit_FunctionAddress, "ObjectsForPropertiesMenu");
		CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePropertyEditorToolkit_FunctionAddress, "ObjectsForPropertiesMenu", Classes.FArrayProperty);
		CreatePropertyEditorToolkit_IsValid = CreatePropertyEditorToolkit_FunctionAddress != IntPtr.Zero && CreatePropertyEditorToolkit_ObjectsForPropertiesMenu_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:CreatePropertyEditorToolkit", CreatePropertyEditorToolkit_IsValid);
		CreateLogListingWidget_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLogListingWidget");
		CreateLogListingWidget_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLogListingWidget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLogListingWidget_InLogName_PropertyAddress, CreateLogListingWidget_FunctionAddress, "InLogName");
		CreateLogListingWidget_InLogName_Offset = NativeReflectionCached.GetPropertyOffset(CreateLogListingWidget_FunctionAddress, "InLogName");
		CreateLogListingWidget_InLogName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLogListingWidget_FunctionAddress, "InLogName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLogListingWidget_ReturnValue_PropertyAddress, CreateLogListingWidget_FunctionAddress, "ReturnValue");
		CreateLogListingWidget_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateLogListingWidget_FunctionAddress, "ReturnValue");
		CreateLogListingWidget_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLogListingWidget_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		CreateLogListingWidget_IsValid = CreateLogListingWidget_FunctionAddress != IntPtr.Zero && CreateLogListingWidget_InLogName_IsValid && CreateLogListingWidget_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListingWidget", CreateLogListingWidget_IsValid);
		CreateLogListing_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLogListing");
		CreateLogListing_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLogListing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLogListing_InLogName_PropertyAddress, CreateLogListing_FunctionAddress, "InLogName");
		CreateLogListing_InLogName_Offset = NativeReflectionCached.GetPropertyOffset(CreateLogListing_FunctionAddress, "InLogName");
		CreateLogListing_InLogName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLogListing_FunctionAddress, "InLogName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLogListing_InLabel_PropertyAddress, CreateLogListing_FunctionAddress, "InLabel");
		CreateLogListing_InLabel_Offset = NativeReflectionCached.GetPropertyOffset(CreateLogListing_FunctionAddress, "InLabel");
		CreateLogListing_InLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLogListing_FunctionAddress, "InLabel", Classes.FTextProperty);
		CreateLogListing_IsValid = CreateLogListing_FunctionAddress != IntPtr.Zero && CreateLogListing_InLogName_IsValid && CreateLogListing_InLabel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateLogListing", CreateLogListing_IsValid);
		CreateBrushForVolumeActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateBrushForVolumeActor");
		CreateBrushForVolumeActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBrushForVolumeActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBrushForVolumeActor_NewActor_PropertyAddress, CreateBrushForVolumeActor_FunctionAddress, "NewActor");
		CreateBrushForVolumeActor_NewActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateBrushForVolumeActor_FunctionAddress, "NewActor");
		CreateBrushForVolumeActor_NewActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBrushForVolumeActor_FunctionAddress, "NewActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBrushForVolumeActor_BrushBuilder_PropertyAddress, CreateBrushForVolumeActor_FunctionAddress, "BrushBuilder");
		CreateBrushForVolumeActor_BrushBuilder_Offset = NativeReflectionCached.GetPropertyOffset(CreateBrushForVolumeActor_FunctionAddress, "BrushBuilder");
		CreateBrushForVolumeActor_BrushBuilder_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBrushForVolumeActor_FunctionAddress, "BrushBuilder", Classes.FObjectProperty);
		CreateBrushForVolumeActor_IsValid = CreateBrushForVolumeActor_FunctionAddress != IntPtr.Zero && CreateBrushForVolumeActor_NewActor_IsValid && CreateBrushForVolumeActor_BrushBuilder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:CreateBrushForVolumeActor", CreateBrushForVolumeActor_IsValid);
		ConditionalBeginDestroybyUObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConditionalBeginDestroybyUObject");
		ConditionalBeginDestroybyUObject_ParamsSize = NativeReflection.GetFunctionParamsSize(ConditionalBeginDestroybyUObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConditionalBeginDestroybyUObject_TargetObject_PropertyAddress, ConditionalBeginDestroybyUObject_FunctionAddress, "TargetObject");
		ConditionalBeginDestroybyUObject_TargetObject_Offset = NativeReflectionCached.GetPropertyOffset(ConditionalBeginDestroybyUObject_FunctionAddress, "TargetObject");
		ConditionalBeginDestroybyUObject_TargetObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ConditionalBeginDestroybyUObject_FunctionAddress, "TargetObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConditionalBeginDestroybyUObject_ReturnValue_PropertyAddress, ConditionalBeginDestroybyUObject_FunctionAddress, "ReturnValue");
		ConditionalBeginDestroybyUObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConditionalBeginDestroybyUObject_FunctionAddress, "ReturnValue");
		ConditionalBeginDestroybyUObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConditionalBeginDestroybyUObject_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ConditionalBeginDestroybyUObject_IsValid = ConditionalBeginDestroybyUObject_FunctionAddress != IntPtr.Zero && ConditionalBeginDestroybyUObject_TargetObject_IsValid && ConditionalBeginDestroybyUObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ConditionalBeginDestroybyUObject", ConditionalBeginDestroybyUObject_IsValid);
		CompileBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompileBlueprint");
		CompileBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(CompileBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CompileBlueprint_Blueprint_PropertyAddress, CompileBlueprint_FunctionAddress, "Blueprint");
		CompileBlueprint_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(CompileBlueprint_FunctionAddress, "Blueprint");
		CompileBlueprint_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(CompileBlueprint_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		CompileBlueprint_IsValid = CompileBlueprint_FunctionAddress != IntPtr.Zero && CompileBlueprint_Blueprint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:CompileBlueprint", CompileBlueprint_IsValid);
		ClearActorLabel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearActorLabel");
		ClearActorLabel_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearActorLabel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearActorLabel_Actor_PropertyAddress, ClearActorLabel_FunctionAddress, "Actor");
		ClearActorLabel_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ClearActorLabel_FunctionAddress, "Actor");
		ClearActorLabel_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearActorLabel_FunctionAddress, "Actor", Classes.FObjectProperty);
		ClearActorLabel_IsValid = ClearActorLabel_FunctionAddress != IntPtr.Zero && ClearActorLabel_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:ClearActorLabel", ClearActorLabel_IsValid);
		Build_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Build");
		Build_ParamsSize = NativeReflection.GetFunctionParamsSize(Build_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Build_Builder_PropertyAddress, Build_FunctionAddress, "Builder");
		Build_Builder_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "Builder");
		Build_Builder_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "Builder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Build_InWorld_PropertyAddress, Build_FunctionAddress, "InWorld");
		Build_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "InWorld");
		Build_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Build_InBrush_PropertyAddress, Build_FunctionAddress, "InBrush");
		Build_InBrush_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "InBrush");
		Build_InBrush_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "InBrush", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Build_ReturnValue_PropertyAddress, Build_FunctionAddress, "ReturnValue");
		Build_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Build_FunctionAddress, "ReturnValue");
		Build_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Build_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Build_IsValid = Build_FunctionAddress != IntPtr.Zero && Build_Builder_IsValid && Build_InWorld_IsValid && Build_InBrush_IsValid && Build_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:Build", Build_IsValid);
		BroadcastHotReload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BroadcastHotReload");
		BroadcastHotReload_ParamsSize = NativeReflection.GetFunctionParamsSize(BroadcastHotReload_FunctionAddress);
		BroadcastHotReload_IsValid = BroadcastHotReload_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastHotReload", BroadcastHotReload_IsValid);
		BroadcastAssetCreated_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BroadcastAssetCreated");
		BroadcastAssetCreated_ParamsSize = NativeReflection.GetFunctionParamsSize(BroadcastAssetCreated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BroadcastAssetCreated_NewAsset_PropertyAddress, BroadcastAssetCreated_FunctionAddress, "NewAsset");
		BroadcastAssetCreated_NewAsset_Offset = NativeReflectionCached.GetPropertyOffset(BroadcastAssetCreated_FunctionAddress, "NewAsset");
		BroadcastAssetCreated_NewAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(BroadcastAssetCreated_FunctionAddress, "NewAsset", Classes.FObjectProperty);
		BroadcastAssetCreated_IsValid = BroadcastAssetCreated_FunctionAddress != IntPtr.Zero && BroadcastAssetCreated_NewAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:BroadcastAssetCreated", BroadcastAssetCreated_IsValid);
		AddWhitelistedObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddWhitelistedObject");
		AddWhitelistedObject_ParamsSize = NativeReflection.GetFunctionParamsSize(AddWhitelistedObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddWhitelistedObject_InObject_PropertyAddress, AddWhitelistedObject_FunctionAddress, "InObject");
		AddWhitelistedObject_InObject_Offset = NativeReflectionCached.GetPropertyOffset(AddWhitelistedObject_FunctionAddress, "InObject");
		AddWhitelistedObject_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddWhitelistedObject_FunctionAddress, "InObject", Classes.FObjectProperty);
		AddWhitelistedObject_IsValid = AddWhitelistedObject_FunctionAddress != IntPtr.Zero && AddWhitelistedObject_InObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddWhitelistedObject", AddWhitelistedObject_IsValid);
		AddNewComponentToBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddNewComponentToBlueprint");
		AddNewComponentToBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(AddNewComponentToBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddNewComponentToBlueprint_NewComponentClass_PropertyAddress, AddNewComponentToBlueprint_FunctionAddress, "NewComponentClass");
		AddNewComponentToBlueprint_NewComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(AddNewComponentToBlueprint_FunctionAddress, "NewComponentClass");
		AddNewComponentToBlueprint_NewComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewComponentToBlueprint_FunctionAddress, "NewComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewComponentToBlueprint_Asset_PropertyAddress, AddNewComponentToBlueprint_FunctionAddress, "Asset");
		AddNewComponentToBlueprint_Asset_Offset = NativeReflectionCached.GetPropertyOffset(AddNewComponentToBlueprint_FunctionAddress, "Asset");
		AddNewComponentToBlueprint_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewComponentToBlueprint_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddNewComponentToBlueprint_ReturnValue_PropertyAddress, AddNewComponentToBlueprint_FunctionAddress, "ReturnValue");
		AddNewComponentToBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddNewComponentToBlueprint_FunctionAddress, "ReturnValue");
		AddNewComponentToBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddNewComponentToBlueprint_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddNewComponentToBlueprint_IsValid = AddNewComponentToBlueprint_FunctionAddress != IntPtr.Zero && AddNewComponentToBlueprint_NewComponentClass_IsValid && AddNewComponentToBlueprint_Asset_IsValid && AddNewComponentToBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddNewComponentToBlueprint", AddNewComponentToBlueprint_IsValid);
		AddLogListingMessage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLogListingMessage");
		AddLogListingMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLogListingMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLogListingMessage_InLogName_PropertyAddress, AddLogListingMessage_FunctionAddress, "InLogName");
		AddLogListingMessage_InLogName_Offset = NativeReflectionCached.GetPropertyOffset(AddLogListingMessage_FunctionAddress, "InLogName");
		AddLogListingMessage_InLogName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLogListingMessage_FunctionAddress, "InLogName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLogListingMessage_InSeverity_PropertyAddress, AddLogListingMessage_FunctionAddress, "InSeverity");
		AddLogListingMessage_InSeverity_Offset = NativeReflectionCached.GetPropertyOffset(AddLogListingMessage_FunctionAddress, "InSeverity");
		AddLogListingMessage_InSeverity_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLogListingMessage_FunctionAddress, "InSeverity", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLogListingMessage_LogText_PropertyAddress, AddLogListingMessage_FunctionAddress, "LogText");
		AddLogListingMessage_LogText_Offset = NativeReflectionCached.GetPropertyOffset(AddLogListingMessage_FunctionAddress, "LogText");
		AddLogListingMessage_LogText_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLogListingMessage_FunctionAddress, "LogText", Classes.FStrProperty);
		AddLogListingMessage_IsValid = AddLogListingMessage_FunctionAddress != IntPtr.Zero && AddLogListingMessage_InLogName_IsValid && AddLogListingMessage_InSeverity_IsValid && AddLogListingMessage_LogText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLogListingMessage", AddLogListingMessage_IsValid);
		AddLazyExtender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLazyExtender");
		AddLazyExtender_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLazyExtender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLazyExtender_Manager_PropertyAddress, AddLazyExtender_FunctionAddress, "Manager");
		AddLazyExtender_Manager_Offset = NativeReflectionCached.GetPropertyOffset(AddLazyExtender_FunctionAddress, "Manager");
		AddLazyExtender_Manager_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLazyExtender_FunctionAddress, "Manager", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLazyExtender_Delegates_PropertyAddress, AddLazyExtender_FunctionAddress, "Delegates");
		AddLazyExtender_Delegates_Offset = NativeReflectionCached.GetPropertyOffset(AddLazyExtender_FunctionAddress, "Delegates");
		AddLazyExtender_Delegates_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLazyExtender_FunctionAddress, "Delegates", Classes.FObjectProperty);
		AddLazyExtender_IsValid = AddLazyExtender_FunctionAddress != IntPtr.Zero && AddLazyExtender_Manager_IsValid && AddLazyExtender_Delegates_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddLazyExtender", AddLazyExtender_IsValid);
		AddGroup_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddGroup");
		AddGroup_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGroup_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGroup_Parent_PropertyAddress, AddGroup_FunctionAddress, "Parent");
		AddGroup_Parent_Offset = NativeReflectionCached.GetPropertyOffset(AddGroup_FunctionAddress, "Parent");
		AddGroup_Parent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGroup_FunctionAddress, "Parent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGroup_DisplayName_PropertyAddress, AddGroup_FunctionAddress, "DisplayName");
		AddGroup_DisplayName_Offset = NativeReflectionCached.GetPropertyOffset(AddGroup_FunctionAddress, "DisplayName");
		AddGroup_DisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGroup_FunctionAddress, "DisplayName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGroup_ReturnValue_PropertyAddress, AddGroup_FunctionAddress, "ReturnValue");
		AddGroup_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddGroup_FunctionAddress, "ReturnValue");
		AddGroup_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGroup_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddGroup_IsValid = AddGroup_FunctionAddress != IntPtr.Zero && AddGroup_Parent_IsValid && AddGroup_DisplayName_IsValid && AddGroup_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddGroup", AddGroup_IsValid);
		AddExtender_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddExtender");
		AddExtender_ParamsSize = NativeReflection.GetFunctionParamsSize(AddExtender_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddExtender_Manager_PropertyAddress, AddExtender_FunctionAddress, "Manager");
		AddExtender_Manager_Offset = NativeReflectionCached.GetPropertyOffset(AddExtender_FunctionAddress, "Manager");
		AddExtender_Manager_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExtender_FunctionAddress, "Manager", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddExtender_Extender_PropertyAddress, AddExtender_FunctionAddress, "Extender");
		AddExtender_Extender_Offset = NativeReflectionCached.GetPropertyOffset(AddExtender_FunctionAddress, "Extender");
		AddExtender_Extender_IsValid = NativeReflectionCached.ValidatePropertyClass(AddExtender_FunctionAddress, "Extender", Classes.FStructProperty);
		AddExtender_IsValid = AddExtender_FunctionAddress != IntPtr.Zero && AddExtender_Manager_IsValid && AddExtender_Extender_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddExtender", AddExtender_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_OptionalNewRootComponent_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponent");
		AddComponentsToBlueprint_OptionalNewRootComponent_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponent");
		AddComponentsToBlueprint_OptionalNewRootComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "OptionalNewRootComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddComponentsToBlueprint_bKeepMobility_PropertyAddress, AddComponentsToBlueprint_FunctionAddress, "bKeepMobility");
		AddComponentsToBlueprint_bKeepMobility_Offset = NativeReflectionCached.GetPropertyOffset(AddComponentsToBlueprint_FunctionAddress, "bKeepMobility");
		AddComponentsToBlueprint_bKeepMobility_IsValid = NativeReflectionCached.ValidatePropertyClass(AddComponentsToBlueprint_FunctionAddress, "bKeepMobility", Classes.FBoolProperty);
		AddComponentsToBlueprint_IsValid = AddComponentsToBlueprint_FunctionAddress != IntPtr.Zero && AddComponentsToBlueprint_Blueprint_IsValid && AddComponentsToBlueprint_Components_IsValid && AddComponentsToBlueprint_bHarvesting_IsValid && AddComponentsToBlueprint_OptionalNewRootComponent_IsValid && AddComponentsToBlueprint_bKeepMobility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorLibrary:AddComponentsToBlueprint", AddComponentsToBlueprint_IsValid);
	}
}

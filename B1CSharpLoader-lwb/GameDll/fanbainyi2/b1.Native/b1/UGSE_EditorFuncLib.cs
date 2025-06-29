using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_EditorFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SpawnActorFromFactory_IsValid;

	private static IntPtr SpawnActorFromFactory_FunctionAddress;

	private static int SpawnActorFromFactory_ParamsSize;

	private static bool SpawnActorFromFactory_AssetObject_IsValid;

	private static FFieldAddress SpawnActorFromFactory_AssetObject_PropertyAddress;

	private static int SpawnActorFromFactory_AssetObject_Offset;

	private static bool SpawnActorFromFactory_Transform_IsValid;

	private static FFieldAddress SpawnActorFromFactory_Transform_PropertyAddress;

	private static int SpawnActorFromFactory_Transform_Offset;

	private static bool SpawnActorFromFactory_ReturnValue_IsValid;

	private static FFieldAddress SpawnActorFromFactory_ReturnValue_PropertyAddress;

	private static int SpawnActorFromFactory_ReturnValue_Offset;

	private static bool ShowWidgetBlueprint_IsValid;

	private static IntPtr ShowWidgetBlueprint_FunctionAddress;

	private static int ShowWidgetBlueprint_ParamsSize;

	private static bool ShowWidgetBlueprint_Outer_IsValid;

	private static FFieldAddress ShowWidgetBlueprint_Outer_PropertyAddress;

	private static int ShowWidgetBlueprint_Outer_Offset;

	private static bool ShowWidgetBlueprint_Path_IsValid;

	private static FFieldAddress ShowWidgetBlueprint_Path_PropertyAddress;

	private static int ShowWidgetBlueprint_Path_Offset;

	private static bool SetViewTransitionToLocation_IsValid;

	private static IntPtr SetViewTransitionToLocation_FunctionAddress;

	private static int SetViewTransitionToLocation_ParamsSize;

	private static bool SetViewTransitionToLocation_LocationToLook_IsValid;

	private static FFieldAddress SetViewTransitionToLocation_LocationToLook_PropertyAddress;

	private static int SetViewTransitionToLocation_LocationToLook_Offset;

	private static bool SetViewRotation_IsValid;

	private static IntPtr SetViewRotation_FunctionAddress;

	private static int SetViewRotation_ParamsSize;

	private static bool SetViewRotation_InRotation_IsValid;

	private static FFieldAddress SetViewRotation_InRotation_PropertyAddress;

	private static int SetViewRotation_InRotation_Offset;

	private static bool SetViewportTransform_IsValid;

	private static IntPtr SetViewportTransform_FunctionAddress;

	private static int SetViewportTransform_ParamsSize;

	private static bool SetViewportTransform_InTransform_IsValid;

	private static FFieldAddress SetViewportTransform_InTransform_PropertyAddress;

	private static int SetViewportTransform_InTransform_Offset;

	private static bool SetViewLocation_IsValid;

	private static IntPtr SetViewLocation_FunctionAddress;

	private static int SetViewLocation_ParamsSize;

	private static bool SetViewLocation_InLocation_IsValid;

	private static FFieldAddress SetViewLocation_InLocation_PropertyAddress;

	private static int SetViewLocation_InLocation_Offset;

	private static bool SetStreamingLevelVolume_IsValid;

	private static IntPtr SetStreamingLevelVolume_FunctionAddress;

	private static int SetStreamingLevelVolume_ParamsSize;

	private static bool SetStreamingLevelVolume_LevelStreaming_IsValid;

	private static FFieldAddress SetStreamingLevelVolume_LevelStreaming_PropertyAddress;

	private static int SetStreamingLevelVolume_LevelStreaming_Offset;

	private static bool SetStreamingLevelVolume_Vol_IsValid;

	private static FFieldAddress SetStreamingLevelVolume_Vol_PropertyAddress;

	private static int SetStreamingLevelVolume_Vol_Offset;

	private static bool SetCurrentLevel_IsValid;

	private static IntPtr SetCurrentLevel_FunctionAddress;

	private static int SetCurrentLevel_ParamsSize;

	private static bool SetCurrentLevel_World_IsValid;

	private static FFieldAddress SetCurrentLevel_World_PropertyAddress;

	private static int SetCurrentLevel_World_Offset;

	private static bool SetCurrentLevel_Level_IsValid;

	private static FFieldAddress SetCurrentLevel_Level_PropertyAddress;

	private static int SetCurrentLevel_Level_Offset;

	private static bool SetBPDesc_IsValid;

	private static IntPtr SetBPDesc_FunctionAddress;

	private static int SetBPDesc_ParamsSize;

	private static bool SetBPDesc_BP_IsValid;

	private static FFieldAddress SetBPDesc_BP_PropertyAddress;

	private static int SetBPDesc_BP_Offset;

	private static bool SetBPDesc_Desc_IsValid;

	private static FFieldAddress SetBPDesc_Desc_PropertyAddress;

	private static int SetBPDesc_Desc_Offset;

	private static bool SetActorLevelBoundsRelevant_IsValid;

	private static IntPtr SetActorLevelBoundsRelevant_FunctionAddress;

	private static int SetActorLevelBoundsRelevant_ParamsSize;

	private static bool SetActorLevelBoundsRelevant_InActor_IsValid;

	private static FFieldAddress SetActorLevelBoundsRelevant_InActor_PropertyAddress;

	private static int SetActorLevelBoundsRelevant_InActor_Offset;

	private static bool SetActorLevelBoundsRelevant_bRelevant_IsValid;

	private static FFieldAddress SetActorLevelBoundsRelevant_bRelevant_PropertyAddress;

	private static int SetActorLevelBoundsRelevant_bRelevant_Offset;

	private static bool SetActorEditorOnly_IsValid;

	private static IntPtr SetActorEditorOnly_FunctionAddress;

	private static int SetActorEditorOnly_ParamsSize;

	private static bool SetActorEditorOnly_Actor_IsValid;

	private static FFieldAddress SetActorEditorOnly_Actor_PropertyAddress;

	private static int SetActorEditorOnly_Actor_Offset;

	private static bool SetActorEditorOnly_NewEnable_IsValid;

	private static FFieldAddress SetActorEditorOnly_NewEnable_PropertyAddress;

	private static int SetActorEditorOnly_NewEnable_Offset;

	private static bool ScanDuplicatedActorTracksInSequence_IsValid;

	private static IntPtr ScanDuplicatedActorTracksInSequence_FunctionAddress;

	private static int ScanDuplicatedActorTracksInSequence_ParamsSize;

	private static bool SavePackage_IsValid;

	private static IntPtr SavePackage_FunctionAddress;

	private static int SavePackage_ParamsSize;

	private static bool SavePackage_PackageToSave_IsValid;

	private static FFieldAddress SavePackage_PackageToSave_PropertyAddress;

	private static int SavePackage_PackageToSave_Offset;

	private static bool SaveObject_IsValid;

	private static IntPtr SaveObject_FunctionAddress;

	private static int SaveObject_ParamsSize;

	private static bool SaveObject_ObjectToSave_IsValid;

	private static FFieldAddress SaveObject_ObjectToSave_PropertyAddress;

	private static int SaveObject_ObjectToSave_Offset;

	private static bool SaveLevel_IsValid;

	private static IntPtr SaveLevel_FunctionAddress;

	private static int SaveLevel_ParamsSize;

	private static bool SaveLevel_LevelToSave_IsValid;

	private static FFieldAddress SaveLevel_LevelToSave_PropertyAddress;

	private static int SaveLevel_LevelToSave_Offset;

	private static bool RunDisableAllScreenMessageCommand_IsValid;

	private static IntPtr RunDisableAllScreenMessageCommand_FunctionAddress;

	private static int RunDisableAllScreenMessageCommand_ParamsSize;

	private static bool RemoveAnimFrames_IsValid;

	private static IntPtr RemoveAnimFrames_FunctionAddress;

	private static int RemoveAnimFrames_ParamsSize;

	private static bool RemoveAnimFrames_AnimSequence_IsValid;

	private static FFieldAddress RemoveAnimFrames_AnimSequence_PropertyAddress;

	private static int RemoveAnimFrames_AnimSequence_Offset;

	private static bool RemoveAnimFrames_StartTime_IsValid;

	private static FFieldAddress RemoveAnimFrames_StartTime_PropertyAddress;

	private static int RemoveAnimFrames_StartTime_Offset;

	private static bool RemoveAnimFrames_EndTime_IsValid;

	private static FFieldAddress RemoveAnimFrames_EndTime_PropertyAddress;

	private static int RemoveAnimFrames_EndTime_Offset;

	private static bool PopulateSelectedNAsToNiagaraMonitor_IsValid;

	private static IntPtr PopulateSelectedNAsToNiagaraMonitor_FunctionAddress;

	private static int PopulateSelectedNAsToNiagaraMonitor_ParamsSize;

	private static bool PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_IsValid;

	private static FFieldAddress PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_PropertyAddress;

	private static int PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_Offset;

	private static bool PlayMap_IsValid;

	private static IntPtr PlayMap_FunctionAddress;

	private static int PlayMap_ParamsSize;

	private static bool PasteComponentsFromClipBoard_IsValid;

	private static IntPtr PasteComponentsFromClipBoard_FunctionAddress;

	private static int PasteComponentsFromClipBoard_ParamsSize;

	private static bool PasteComponentsFromClipBoard_OutPastedComponents_IsValid;

	private static FFieldAddress PasteComponentsFromClipBoard_OutPastedComponents_PropertyAddress;

	private static int PasteComponentsFromClipBoard_OutPastedComponents_Offset;

	private static bool PasteComponentsFromClipBoard_TargetActor_IsValid;

	private static FFieldAddress PasteComponentsFromClipBoard_TargetActor_PropertyAddress;

	private static int PasteComponentsFromClipBoard_TargetActor_Offset;

	private static bool PasteComponentsFromClipBoard_bWarnIfHidden_IsValid;

	private static FFieldAddress PasteComponentsFromClipBoard_bWarnIfHidden_PropertyAddress;

	private static int PasteComponentsFromClipBoard_bWarnIfHidden_Offset;

	private static bool OpenSourceFile_IsValid;

	private static IntPtr OpenSourceFile_FunctionAddress;

	private static int OpenSourceFile_ParamsSize;

	private static bool OpenSourceFile_AbsoluteSourcePath_IsValid;

	private static FFieldAddress OpenSourceFile_AbsoluteSourcePath_PropertyAddress;

	private static int OpenSourceFile_AbsoluteSourcePath_Offset;

	private static bool OpenSourceFile_LineNumber_IsValid;

	private static FFieldAddress OpenSourceFile_LineNumber_PropertyAddress;

	private static int OpenSourceFile_LineNumber_Offset;

	private static bool OpenSourceFile_ColumnNumber_IsValid;

	private static FFieldAddress OpenSourceFile_ColumnNumber_PropertyAddress;

	private static int OpenSourceFile_ColumnNumber_Offset;

	private static bool OpenLevelInEditor_IsValid;

	private static IntPtr OpenLevelInEditor_FunctionAddress;

	private static int OpenLevelInEditor_ParamsSize;

	private static bool OpenLevelInEditor_PackageName_IsValid;

	private static FFieldAddress OpenLevelInEditor_PackageName_PropertyAddress;

	private static int OpenLevelInEditor_PackageName_Offset;

	private static bool OpenLevelInEditor_bOnlyPersistentLevel_IsValid;

	private static FFieldAddress OpenLevelInEditor_bOnlyPersistentLevel_PropertyAddress;

	private static int OpenLevelInEditor_bOnlyPersistentLevel_Offset;

	private static bool OpenLevelInEditor_ReturnValue_IsValid;

	private static FFieldAddress OpenLevelInEditor_ReturnValue_PropertyAddress;

	private static int OpenLevelInEditor_ReturnValue_Offset;

	private static bool OpenItemLevelInEditor_IsValid;

	private static IntPtr OpenItemLevelInEditor_FunctionAddress;

	private static int OpenItemLevelInEditor_ParamsSize;

	private static bool OpenItemLevelInEditor_PackageName_IsValid;

	private static FFieldAddress OpenItemLevelInEditor_PackageName_PropertyAddress;

	private static int OpenItemLevelInEditor_PackageName_Offset;

	private static bool OpenItemLevelInEditor_bOnlyPersistentLevel_IsValid;

	private static FFieldAddress OpenItemLevelInEditor_bOnlyPersistentLevel_PropertyAddress;

	private static int OpenItemLevelInEditor_bOnlyPersistentLevel_Offset;

	private static bool OpenItemLevelInEditor_ReturnValue_IsValid;

	private static FFieldAddress OpenItemLevelInEditor_ReturnValue_PropertyAddress;

	private static int OpenItemLevelInEditor_ReturnValue_Offset;

	private static bool MessageOpenDialogWithYesNoType_IsValid;

	private static IntPtr MessageOpenDialogWithYesNoType_FunctionAddress;

	private static int MessageOpenDialogWithYesNoType_ParamsSize;

	private static bool MessageOpenDialogWithYesNoType_Message_IsValid;

	private static FFieldAddress MessageOpenDialogWithYesNoType_Message_PropertyAddress;

	private static int MessageOpenDialogWithYesNoType_Message_Offset;

	private static bool MessageOpenDialogWithYesNoType_Title_IsValid;

	private static FFieldAddress MessageOpenDialogWithYesNoType_Title_PropertyAddress;

	private static int MessageOpenDialogWithYesNoType_Title_Offset;

	private static bool MessageOpenDialogWithYesNoType_ReturnValue_IsValid;

	private static FFieldAddress MessageOpenDialogWithYesNoType_ReturnValue_PropertyAddress;

	private static int MessageOpenDialogWithYesNoType_ReturnValue_Offset;

	private static bool LoadLevel_IsValid;

	private static IntPtr LoadLevel_FunctionAddress;

	private static int LoadLevel_ParamsSize;

	private static bool LoadLevel_Path_IsValid;

	private static FFieldAddress LoadLevel_Path_PropertyAddress;

	private static int LoadLevel_Path_Offset;

	private static bool IsUnderDirectory_IsValid;

	private static IntPtr IsUnderDirectory_FunctionAddress;

	private static int IsUnderDirectory_ParamsSize;

	private static bool IsUnderDirectory_InPath_IsValid;

	private static FFieldAddress IsUnderDirectory_InPath_PropertyAddress;

	private static int IsUnderDirectory_InPath_Offset;

	private static bool IsUnderDirectory_InDirectory_IsValid;

	private static FFieldAddress IsUnderDirectory_InDirectory_PropertyAddress;

	private static int IsUnderDirectory_InDirectory_Offset;

	private static bool IsUnderDirectory_ReturnValue_IsValid;

	private static FFieldAddress IsUnderDirectory_ReturnValue_PropertyAddress;

	private static int IsUnderDirectory_ReturnValue_Offset;

	private static bool IsInEditorWithMoviePipelineQueue_IsValid;

	private static IntPtr IsInEditorWithMoviePipelineQueue_FunctionAddress;

	private static int IsInEditorWithMoviePipelineQueue_ParamsSize;

	private static bool IsInEditorWithMoviePipelineQueue_ReturnValue_IsValid;

	private static FFieldAddress IsInEditorWithMoviePipelineQueue_ReturnValue_PropertyAddress;

	private static int IsInEditorWithMoviePipelineQueue_ReturnValue_Offset;

	private static bool IsCurrentPIEWorldContextInTick_IsValid;

	private static IntPtr IsCurrentPIEWorldContextInTick_FunctionAddress;

	private static int IsCurrentPIEWorldContextInTick_ParamsSize;

	private static bool IsCurrentPIEWorldContextInTick_WorldContext_IsValid;

	private static FFieldAddress IsCurrentPIEWorldContextInTick_WorldContext_PropertyAddress;

	private static int IsCurrentPIEWorldContextInTick_WorldContext_Offset;

	private static bool IsCurrentPIEWorldContextInTick_ReturnValue_IsValid;

	private static FFieldAddress IsCurrentPIEWorldContextInTick_ReturnValue_PropertyAddress;

	private static int IsCurrentPIEWorldContextInTick_ReturnValue_Offset;

	private static bool IsCurrentEditorWorldContext_IsValid;

	private static IntPtr IsCurrentEditorWorldContext_FunctionAddress;

	private static int IsCurrentEditorWorldContext_ParamsSize;

	private static bool IsCurrentEditorWorldContext_WorldContext_IsValid;

	private static FFieldAddress IsCurrentEditorWorldContext_WorldContext_PropertyAddress;

	private static int IsCurrentEditorWorldContext_WorldContext_Offset;

	private static bool IsCurrentEditorWorldContext_ReturnValue_IsValid;

	private static FFieldAddress IsCurrentEditorWorldContext_ReturnValue_PropertyAddress;

	private static int IsCurrentEditorWorldContext_ReturnValue_Offset;

	private static bool IsClassPlaceable_IsValid;

	private static IntPtr IsClassPlaceable_FunctionAddress;

	private static int IsClassPlaceable_ParamsSize;

	private static bool IsClassPlaceable_AssetClass_IsValid;

	private static FFieldAddress IsClassPlaceable_AssetClass_PropertyAddress;

	private static int IsClassPlaceable_AssetClass_Offset;

	private static bool IsClassPlaceable_ReturnValue_IsValid;

	private static FFieldAddress IsClassPlaceable_ReturnValue_PropertyAddress;

	private static int IsClassPlaceable_ReturnValue_Offset;

	private static bool ImportCSVToStringTable_IsValid;

	private static IntPtr ImportCSVToStringTable_FunctionAddress;

	private static int ImportCSVToStringTable_ParamsSize;

	private static bool ImportCSVToStringTable_TableID_IsValid;

	private static FFieldAddress ImportCSVToStringTable_TableID_PropertyAddress;

	private static int ImportCSVToStringTable_TableID_Offset;

	private static bool ImportCSVToStringTable_CSVPath_IsValid;

	private static FFieldAddress ImportCSVToStringTable_CSVPath_PropertyAddress;

	private static int ImportCSVToStringTable_CSVPath_Offset;

	private static bool HotReLoadCastMoudleChange_IsValid;

	private static IntPtr HotReLoadCastMoudleChange_FunctionAddress;

	private static int HotReLoadCastMoudleChange_ParamsSize;

	private static bool GetValidPostProcessVolumes_IsValid;

	private static IntPtr GetValidPostProcessVolumes_FunctionAddress;

	private static int GetValidPostProcessVolumes_ParamsSize;

	private static bool GetValidPostProcessVolumes_InWorld_IsValid;

	private static FFieldAddress GetValidPostProcessVolumes_InWorld_PropertyAddress;

	private static int GetValidPostProcessVolumes_InWorld_Offset;

	private static bool GetValidPostProcessVolumes_ReturnValue_IsValid;

	private static FFieldAddress GetValidPostProcessVolumes_ReturnValue_PropertyAddress;

	private static int GetValidPostProcessVolumes_ReturnValue_Offset;

	private static bool GetSelectedActors_IsValid;

	private static IntPtr GetSelectedActors_FunctionAddress;

	private static int GetSelectedActors_ParamsSize;

	private static bool GetSelectedActors_OutActors_IsValid;

	private static FFieldAddress GetSelectedActors_OutActors_PropertyAddress;

	private static int GetSelectedActors_OutActors_Offset;

	private static bool GetPersistentLevel_IsValid;

	private static IntPtr GetPersistentLevel_FunctionAddress;

	private static int GetPersistentLevel_ParamsSize;

	private static bool GetPersistentLevel_World_IsValid;

	private static FFieldAddress GetPersistentLevel_World_PropertyAddress;

	private static int GetPersistentLevel_World_Offset;

	private static bool GetPersistentLevel_ReturnValue_IsValid;

	private static FFieldAddress GetPersistentLevel_ReturnValue_PropertyAddress;

	private static int GetPersistentLevel_ReturnValue_Offset;

	private static bool GetPackagesByName_IsValid;

	private static IntPtr GetPackagesByName_FunctionAddress;

	private static int GetPackagesByName_ParamsSize;

	private static bool GetPackagesByName_Name_IsValid;

	private static FFieldAddress GetPackagesByName_Name_PropertyAddress;

	private static int GetPackagesByName_Name_Offset;

	private static bool GetPackagesByName_OutPackageNames_IsValid;

	private static FFieldAddress GetPackagesByName_OutPackageNames_PropertyAddress;

	private static int GetPackagesByName_OutPackageNames_Offset;

	private static bool GetEditorWorld_IsValid;

	private static IntPtr GetEditorWorld_FunctionAddress;

	private static int GetEditorWorld_ParamsSize;

	private static bool GetEditorWorld_ReturnValue_IsValid;

	private static FFieldAddress GetEditorWorld_ReturnValue_PropertyAddress;

	private static int GetEditorWorld_ReturnValue_Offset;

	private static bool GetDirectoriesToAlwaysCook_IsValid;

	private static IntPtr GetDirectoriesToAlwaysCook_FunctionAddress;

	private static int GetDirectoriesToAlwaysCook_ParamsSize;

	private static bool GetDirectoriesToAlwaysCook_bConvertToLocalPath_IsValid;

	private static FFieldAddress GetDirectoriesToAlwaysCook_bConvertToLocalPath_PropertyAddress;

	private static int GetDirectoriesToAlwaysCook_bConvertToLocalPath_Offset;

	private static bool GetDirectoriesToAlwaysCook_ReturnValue_IsValid;

	private static FFieldAddress GetDirectoriesToAlwaysCook_ReturnValue_PropertyAddress;

	private static int GetDirectoriesToAlwaysCook_ReturnValue_Offset;

	private static bool GetCurrentLevel_IsValid;

	private static IntPtr GetCurrentLevel_FunctionAddress;

	private static int GetCurrentLevel_ParamsSize;

	private static bool GetCurrentLevel_World_IsValid;

	private static FFieldAddress GetCurrentLevel_World_PropertyAddress;

	private static int GetCurrentLevel_World_Offset;

	private static bool GetCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentLevel_ReturnValue_PropertyAddress;

	private static int GetCurrentLevel_ReturnValue_Offset;

	private static bool GetCurrentGWorldType_IsValid;

	private static IntPtr GetCurrentGWorldType_FunctionAddress;

	private static int GetCurrentGWorldType_ParamsSize;

	private static bool GetCurrentGWorldType_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentGWorldType_ReturnValue_PropertyAddress;

	private static int GetCurrentGWorldType_ReturnValue_Offset;

	private static bool GetCurrentEditingWorld_IsValid;

	private static IntPtr GetCurrentEditingWorld_FunctionAddress;

	private static int GetCurrentEditingWorld_ParamsSize;

	private static bool GetCurrentEditingWorld_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentEditingWorld_ReturnValue_PropertyAddress;

	private static int GetCurrentEditingWorld_ReturnValue_Offset;

	private static bool GetContentBrowserSelections_IsValid;

	private static IntPtr GetContentBrowserSelections_FunctionAddress;

	private static int GetContentBrowserSelections_ParamsSize;

	private static bool GetContentBrowserSelections_ReturnValue_IsValid;

	private static FFieldAddress GetContentBrowserSelections_ReturnValue_PropertyAddress;

	private static int GetContentBrowserSelections_ReturnValue_Offset;

	private static bool GetCDONodeComponents_IsValid;

	private static IntPtr GetCDONodeComponents_FunctionAddress;

	private static int GetCDONodeComponents_ParamsSize;

	private static bool GetCDONodeComponents_CDO_IsValid;

	private static FFieldAddress GetCDONodeComponents_CDO_PropertyAddress;

	private static int GetCDONodeComponents_CDO_Offset;

	private static bool GetCDONodeComponents_ReturnValue_IsValid;

	private static FFieldAddress GetCDONodeComponents_ReturnValue_PropertyAddress;

	private static int GetCDONodeComponents_ReturnValue_Offset;

	private static bool GetBrushBounds_IsValid;

	private static IntPtr GetBrushBounds_FunctionAddress;

	private static int GetBrushBounds_ParamsSize;

	private static bool GetBrushBounds_BrushCom_IsValid;

	private static FFieldAddress GetBrushBounds_BrushCom_PropertyAddress;

	private static int GetBrushBounds_BrushCom_Offset;

	private static bool GetBrushBounds_ReturnValue_IsValid;

	private static FFieldAddress GetBrushBounds_ReturnValue_PropertyAddress;

	private static int GetBrushBounds_ReturnValue_Offset;

	private static bool GetAssetDependencies_IsValid;

	private static IntPtr GetAssetDependencies_FunctionAddress;

	private static int GetAssetDependencies_ParamsSize;

	private static bool GetAssetDependencies_PackageName_IsValid;

	private static FFieldAddress GetAssetDependencies_PackageName_PropertyAddress;

	private static int GetAssetDependencies_PackageName_Offset;

	private static bool GetAssetDependencies_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDependencies_ReturnValue_PropertyAddress;

	private static int GetAssetDependencies_ReturnValue_Offset;

	private static bool GetAllLevelActors_IsValid;

	private static IntPtr GetAllLevelActors_FunctionAddress;

	private static int GetAllLevelActors_ParamsSize;

	private static bool GetAllLevelActors_ReturnValue_IsValid;

	private static FFieldAddress GetAllLevelActors_ReturnValue_PropertyAddress;

	private static int GetAllLevelActors_ReturnValue_Offset;

	private static bool GenerateNaviMeshBounds_IsValid;

	private static IntPtr GenerateNaviMeshBounds_FunctionAddress;

	private static int GenerateNaviMeshBounds_ParamsSize;

	private static bool GenerateNaviMeshBounds_Anchor_IsValid;

	private static FFieldAddress GenerateNaviMeshBounds_Anchor_PropertyAddress;

	private static int GenerateNaviMeshBounds_Anchor_Offset;

	private static bool GenerateNaviMeshBounds_ScaleX_IsValid;

	private static FFieldAddress GenerateNaviMeshBounds_ScaleX_PropertyAddress;

	private static int GenerateNaviMeshBounds_ScaleX_Offset;

	private static bool GenerateNaviMeshBounds_ScaleY_IsValid;

	private static FFieldAddress GenerateNaviMeshBounds_ScaleY_PropertyAddress;

	private static int GenerateNaviMeshBounds_ScaleY_Offset;

	private static bool GenerateNaviMeshBounds_ScaleZ_IsValid;

	private static FFieldAddress GenerateNaviMeshBounds_ScaleZ_PropertyAddress;

	private static int GenerateNaviMeshBounds_ScaleZ_Offset;

	private static bool GenerateNaviMeshBounds_DuplicateBase_IsValid;

	private static FFieldAddress GenerateNaviMeshBounds_DuplicateBase_PropertyAddress;

	private static int GenerateNaviMeshBounds_DuplicateBase_Offset;

	private static bool GatherText_IsValid;

	private static IntPtr GatherText_FunctionAddress;

	private static int GatherText_ParamsSize;

	private static bool FAssetData_GetTagValue_IsValid;

	private static IntPtr FAssetData_GetTagValue_FunctionAddress;

	private static int FAssetData_GetTagValue_ParamsSize;

	private static bool FAssetData_GetTagValue_AssetData_IsValid;

	private static FFieldAddress FAssetData_GetTagValue_AssetData_PropertyAddress;

	private static int FAssetData_GetTagValue_AssetData_Offset;

	private static bool FAssetData_GetTagValue_TagName_IsValid;

	private static FFieldAddress FAssetData_GetTagValue_TagName_PropertyAddress;

	private static int FAssetData_GetTagValue_TagName_Offset;

	private static bool FAssetData_GetTagValue_ReturnValue_IsValid;

	private static FFieldAddress FAssetData_GetTagValue_ReturnValue_PropertyAddress;

	private static int FAssetData_GetTagValue_ReturnValue_Offset;

	private static bool FAssetData_GetClass_IsValid;

	private static IntPtr FAssetData_GetClass_FunctionAddress;

	private static int FAssetData_GetClass_ParamsSize;

	private static bool FAssetData_GetClass_AssetData_IsValid;

	private static FFieldAddress FAssetData_GetClass_AssetData_PropertyAddress;

	private static int FAssetData_GetClass_AssetData_Offset;

	private static bool FAssetData_GetClass_ReturnValue_IsValid;

	private static FFieldAddress FAssetData_GetClass_ReturnValue_PropertyAddress;

	private static int FAssetData_GetClass_ReturnValue_Offset;

	private static bool FAssetData_GetAsset_IsValid;

	private static IntPtr FAssetData_GetAsset_FunctionAddress;

	private static int FAssetData_GetAsset_ParamsSize;

	private static bool FAssetData_GetAsset_AssetData_IsValid;

	private static FFieldAddress FAssetData_GetAsset_AssetData_PropertyAddress;

	private static int FAssetData_GetAsset_AssetData_Offset;

	private static bool FAssetData_GetAsset_ReturnValue_IsValid;

	private static FFieldAddress FAssetData_GetAsset_ReturnValue_PropertyAddress;

	private static int FAssetData_GetAsset_ReturnValue_Offset;

	private static bool ExportToolSelectNone_IsValid;

	private static IntPtr ExportToolSelectNone_FunctionAddress;

	private static int ExportToolSelectNone_ParamsSize;

	private static bool ExportToolSelectNone_bNoteSelectionChange_IsValid;

	private static FFieldAddress ExportToolSelectNone_bNoteSelectionChange_PropertyAddress;

	private static int ExportToolSelectNone_bNoteSelectionChange_Offset;

	private static bool ExportToolSelectNone_bDeselectBSPSurfs_IsValid;

	private static FFieldAddress ExportToolSelectNone_bDeselectBSPSurfs_PropertyAddress;

	private static int ExportToolSelectNone_bDeselectBSPSurfs_Offset;

	private static bool ExportToolSelectActor_IsValid;

	private static IntPtr ExportToolSelectActor_FunctionAddress;

	private static int ExportToolSelectActor_ParamsSize;

	private static bool ExportToolSelectActor_TargetActor_IsValid;

	private static FFieldAddress ExportToolSelectActor_TargetActor_PropertyAddress;

	private static int ExportToolSelectActor_TargetActor_Offset;

	private static bool EditObjectByName_IsValid;

	private static IntPtr EditObjectByName_FunctionAddress;

	private static int EditObjectByName_ParamsSize;

	private static bool EditObjectByName_PackageName_IsValid;

	private static FFieldAddress EditObjectByName_PackageName_PropertyAddress;

	private static int EditObjectByName_PackageName_Offset;

	private static bool EditObject_IsValid;

	private static IntPtr EditObject_FunctionAddress;

	private static int EditObject_ParamsSize;

	private static bool EditObject_ObjectToEdit_IsValid;

	private static FFieldAddress EditObject_ObjectToEdit_PropertyAddress;

	private static int EditObject_ObjectToEdit_Offset;

	private static bool DuplicateWorld_IsValid;

	private static IntPtr DuplicateWorld_FunctionAddress;

	private static int DuplicateWorld_ParamsSize;

	private static bool DuplicateWorld_TempleteWorld_IsValid;

	private static FFieldAddress DuplicateWorld_TempleteWorld_PropertyAddress;

	private static int DuplicateWorld_TempleteWorld_Offset;

	private static bool DuplicateWorld_PackageName_IsValid;

	private static FFieldAddress DuplicateWorld_PackageName_PropertyAddress;

	private static int DuplicateWorld_PackageName_Offset;

	private static bool DuplicateWorld_ObjectName_IsValid;

	private static FFieldAddress DuplicateWorld_ObjectName_PropertyAddress;

	private static int DuplicateWorld_ObjectName_Offset;

	private static bool DuplicateWorld_ReturnValue_IsValid;

	private static FFieldAddress DuplicateWorld_ReturnValue_PropertyAddress;

	private static int DuplicateWorld_ReturnValue_Offset;

	private static bool DuplicateActor_IsValid;

	private static IntPtr DuplicateActor_FunctionAddress;

	private static int DuplicateActor_ParamsSize;

	private static bool DuplicateActor_ActorToDuplicate_IsValid;

	private static FFieldAddress DuplicateActor_ActorToDuplicate_PropertyAddress;

	private static int DuplicateActor_ActorToDuplicate_Offset;

	private static bool DuplicateActor_InLevel_IsValid;

	private static FFieldAddress DuplicateActor_InLevel_PropertyAddress;

	private static int DuplicateActor_InLevel_Offset;

	private static bool DuplicateActor_Offset_IsValid;

	private static FFieldAddress DuplicateActor_Offset_PropertyAddress;

	private static int DuplicateActor_Offset_Offset;

	private static bool DuplicateActor_ReturnValue_IsValid;

	private static FFieldAddress DuplicateActor_ReturnValue_PropertyAddress;

	private static int DuplicateActor_ReturnValue_Offset;

	private static bool DeleteObject_IsValid;

	private static IntPtr DeleteObject_FunctionAddress;

	private static int DeleteObject_ParamsSize;

	private static bool DeleteObject_ObjectToDelete_IsValid;

	private static FFieldAddress DeleteObject_ObjectToDelete_PropertyAddress;

	private static int DeleteObject_ObjectToDelete_Offset;

	private static bool DeleteObject_ShowConfirm_IsValid;

	private static FFieldAddress DeleteObject_ShowConfirm_PropertyAddress;

	private static int DeleteObject_ShowConfirm_Offset;

	private static bool DeleteActors_WithVerify_IsValid;

	private static IntPtr DeleteActors_WithVerify_FunctionAddress;

	private static int DeleteActors_WithVerify_ParamsSize;

	private static bool DeleteActors_WithVerify_InActorsToDelete_IsValid;

	private static FFieldAddress DeleteActors_WithVerify_InActorsToDelete_PropertyAddress;

	private static int DeleteActors_WithVerify_InActorsToDelete_Offset;

	private static bool DeleteActors_WithVerify_InWorld_IsValid;

	private static FFieldAddress DeleteActors_WithVerify_InWorld_PropertyAddress;

	private static int DeleteActors_WithVerify_InWorld_Offset;

	private static bool DeleteActors_WithVerify_bVerifyDeletionCanHappen_IsValid;

	private static FFieldAddress DeleteActors_WithVerify_bVerifyDeletionCanHappen_PropertyAddress;

	private static int DeleteActors_WithVerify_bVerifyDeletionCanHappen_Offset;

	private static bool DeleteActors_WithVerify_bWarnAboutReferences_IsValid;

	private static FFieldAddress DeleteActors_WithVerify_bWarnAboutReferences_PropertyAddress;

	private static int DeleteActors_WithVerify_bWarnAboutReferences_Offset;

	private static bool DeleteActors_WithVerify_bWarnAboutSoftReferences_IsValid;

	private static FFieldAddress DeleteActors_WithVerify_bWarnAboutSoftReferences_PropertyAddress;

	private static int DeleteActors_WithVerify_bWarnAboutSoftReferences_Offset;

	private static bool DeleteActors_IsValid;

	private static IntPtr DeleteActors_FunctionAddress;

	private static int DeleteActors_ParamsSize;

	private static bool DeleteActors_InActorsToDelete_IsValid;

	private static FFieldAddress DeleteActors_InActorsToDelete_PropertyAddress;

	private static int DeleteActors_InActorsToDelete_Offset;

	private static bool DeleteActors_InWorld_IsValid;

	private static FFieldAddress DeleteActors_InWorld_PropertyAddress;

	private static int DeleteActors_InWorld_Offset;

	private static bool DebugRoomCreateLevel_IsValid;

	private static IntPtr DebugRoomCreateLevel_FunctionAddress;

	private static int DebugRoomCreateLevel_ParamsSize;

	private static bool DebugRoomCreateLevel_MainWorld_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_MainWorld_PropertyAddress;

	private static int DebugRoomCreateLevel_MainWorld_Offset;

	private static bool DebugRoomCreateLevel_TempleteWorld_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_TempleteWorld_PropertyAddress;

	private static int DebugRoomCreateLevel_TempleteWorld_Offset;

	private static bool DebugRoomCreateLevel_PackageName_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_PackageName_PropertyAddress;

	private static int DebugRoomCreateLevel_PackageName_Offset;

	private static bool DebugRoomCreateLevel_ObjectName_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_ObjectName_PropertyAddress;

	private static int DebugRoomCreateLevel_ObjectName_Offset;

	private static bool DebugRoomCreateLevel_ChineseName_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_ChineseName_PropertyAddress;

	private static int DebugRoomCreateLevel_ChineseName_Offset;

	private static bool DebugRoomCreateLevel_NewWorldTrans_IsValid;

	private static FFieldAddress DebugRoomCreateLevel_NewWorldTrans_PropertyAddress;

	private static int DebugRoomCreateLevel_NewWorldTrans_Offset;

	private static bool CopyComponentsToClipBoard_IsValid;

	private static IntPtr CopyComponentsToClipBoard_FunctionAddress;

	private static int CopyComponentsToClipBoard_ParamsSize;

	private static bool CopyComponentsToClipBoard_ComponentsToCopy_IsValid;

	private static FFieldAddress CopyComponentsToClipBoard_ComponentsToCopy_PropertyAddress;

	private static int CopyComponentsToClipBoard_ComponentsToCopy_Offset;

	private static bool CompileText_IsValid;

	private static IntPtr CompileText_FunctionAddress;

	private static int CompileText_ParamsSize;

	private static bool CheckAssetHasScriptBlueprint_IsValid;

	private static IntPtr CheckAssetHasScriptBlueprint_FunctionAddress;

	private static int CheckAssetHasScriptBlueprint_ParamsSize;

	private static bool CheckAssetHasScriptBlueprint_Asset_IsValid;

	private static FFieldAddress CheckAssetHasScriptBlueprint_Asset_PropertyAddress;

	private static int CheckAssetHasScriptBlueprint_Asset_Offset;

	private static bool CheckAssetHasScriptBlueprint_ReturnValue_IsValid;

	private static FFieldAddress CheckAssetHasScriptBlueprint_ReturnValue_PropertyAddress;

	private static int CheckAssetHasScriptBlueprint_ReturnValue_Offset;

	private static bool CheckActorBoundsInfo_IsValid;

	private static IntPtr CheckActorBoundsInfo_FunctionAddress;

	private static int CheckActorBoundsInfo_ParamsSize;

	private static bool CheckActorBoundsInfo_InActor_IsValid;

	private static FFieldAddress CheckActorBoundsInfo_InActor_PropertyAddress;

	private static int CheckActorBoundsInfo_InActor_Offset;

	private static bool CheckActorBoundsInfo_bIncludeNonCollision_IsValid;

	private static FFieldAddress CheckActorBoundsInfo_bIncludeNonCollision_PropertyAddress;

	private static int CheckActorBoundsInfo_bIncludeNonCollision_Offset;

	private static bool CheckActorBoundsInfo_OutActorLevelBoundsRelevant_IsValid;

	private static FFieldAddress CheckActorBoundsInfo_OutActorLevelBoundsRelevant_PropertyAddress;

	private static int CheckActorBoundsInfo_OutActorLevelBoundsRelevant_Offset;

	private static bool CheckActorBoundsInfo_OutActorBounds_IsValid;

	private static FFieldAddress CheckActorBoundsInfo_OutActorBounds_PropertyAddress;

	private static int CheckActorBoundsInfo_OutActorBounds_Offset;

	private static bool BGULandscapeCameraCollsion_IsValid;

	private static IntPtr BGULandscapeCameraCollsion_FunctionAddress;

	private static int BGULandscapeCameraCollsion_ParamsSize;

	private static bool BGULandscapeCameraCollsion_WorldContextObject_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_WorldContextObject_PropertyAddress;

	private static int BGULandscapeCameraCollsion_WorldContextObject_Offset;

	private static bool BGULandscapeCameraCollsion_SurfaceType_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_SurfaceType_PropertyAddress;

	private static int BGULandscapeCameraCollsion_SurfaceType_Offset;

	private static bool BGULandscapeCameraCollsion_cellSize_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_cellSize_PropertyAddress;

	private static int BGULandscapeCameraCollsion_cellSize_Offset;

	private static bool BGULandscapeCameraCollsion_MaxHeightOffset_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_MaxHeightOffset_PropertyAddress;

	private static int BGULandscapeCameraCollsion_MaxHeightOffset_Offset;

	private static bool BGULandscapeCameraCollsion_MaxDisplacement_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_MaxDisplacement_PropertyAddress;

	private static int BGULandscapeCameraCollsion_MaxDisplacement_Offset;

	private static bool BGULandscapeCameraCollsion_CameraCollisionOffset_IsValid;

	private static FFieldAddress BGULandscapeCameraCollsion_CameraCollisionOffset_PropertyAddress;

	private static int BGULandscapeCameraCollsion_CameraCollisionOffset_Offset;

	private static bool BGUGetStaticMeshComp_IsValid;

	private static IntPtr BGUGetStaticMeshComp_FunctionAddress;

	private static int BGUGetStaticMeshComp_ParamsSize;

	private static bool BGUGetStaticMeshComp_Actor_IsValid;

	private static FFieldAddress BGUGetStaticMeshComp_Actor_PropertyAddress;

	private static int BGUGetStaticMeshComp_Actor_Offset;

	private static bool BGUGetStaticMeshComp_ReturnValue_IsValid;

	private static FFieldAddress BGUGetStaticMeshComp_ReturnValue_PropertyAddress;

	private static int BGUGetStaticMeshComp_ReturnValue_Offset;

	private static bool AssetPath_GetCDO_IsValid;

	private static IntPtr AssetPath_GetCDO_FunctionAddress;

	private static int AssetPath_GetCDO_ParamsSize;

	private static bool AssetPath_GetCDO_Outer_IsValid;

	private static FFieldAddress AssetPath_GetCDO_Outer_PropertyAddress;

	private static int AssetPath_GetCDO_Outer_Offset;

	private static bool AssetPath_GetCDO_Path_IsValid;

	private static FFieldAddress AssetPath_GetCDO_Path_PropertyAddress;

	private static int AssetPath_GetCDO_Path_Offset;

	private static bool AssetPath_GetCDO_Blueprint_IsValid;

	private static FFieldAddress AssetPath_GetCDO_Blueprint_PropertyAddress;

	private static int AssetPath_GetCDO_Blueprint_Offset;

	private static bool AssetPath_GetCDO_ReturnValue_IsValid;

	private static FFieldAddress AssetPath_GetCDO_ReturnValue_PropertyAddress;

	private static int AssetPath_GetCDO_ReturnValue_Offset;

	private static bool ActorRename_IsValid;

	private static IntPtr ActorRename_FunctionAddress;

	private static int ActorRename_ParamsSize;

	private static bool ActorRename_Actor_IsValid;

	private static FFieldAddress ActorRename_Actor_PropertyAddress;

	private static int ActorRename_Actor_Offset;

	private static bool ActorRename_NewName_IsValid;

	private static FFieldAddress ActorRename_NewName_PropertyAddress;

	private static int ActorRename_NewName_Offset;

	[UFunction(Flags = 616702977u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SpawnActorFromFactory")]
	public unsafe static AActor SpawnActorFromFactory(UObject AssetObject, FTransform Transform)
	{
		if (!SpawnActorFromFactory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SpawnActorFromFactory");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActorFromFactory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActorFromFactory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnActorFromFactory_AssetObject_Offset), 0, SpawnActorFromFactory_AssetObject_PropertyAddress.Address, AssetObject);
		NativeReflection.InitializeValue_InContainer(SpawnActorFromFactory_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnActorFromFactory_Transform_Offset), 0, SpawnActorFromFactory_Transform_PropertyAddress.Address, Transform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnActorFromFactory_FunctionAddress, intPtr, SpawnActorFromFactory_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActorFromFactory_ReturnValue_Offset), 0, SpawnActorFromFactory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ShowWidgetBlueprint")]
	public unsafe static void ShowWidgetBlueprint(UObject Outer, string Path)
	{
		if (!ShowWidgetBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ShowWidgetBlueprint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowWidgetBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowWidgetBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ShowWidgetBlueprint_Outer_Offset), 0, ShowWidgetBlueprint_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowWidgetBlueprint_Path_Offset), 0, ShowWidgetBlueprint_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowWidgetBlueprint_FunctionAddress, intPtr, ShowWidgetBlueprint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowWidgetBlueprint_Path_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewTransitionToLocation")]
	public unsafe static void SetViewTransitionToLocation(FVector LocationToLook)
	{
		if (!SetViewTransitionToLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewTransitionToLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewTransitionToLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewTransitionToLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetViewTransitionToLocation_LocationToLook_Offset), 0, SetViewTransitionToLocation_LocationToLook_PropertyAddress.Address, LocationToLook);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewTransitionToLocation_FunctionAddress, intPtr, SetViewTransitionToLocation_ParamsSize);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewRotation")]
	public unsafe static void SetViewRotation(FRotator InRotation)
	{
		if (!SetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetViewRotation_InRotation_Offset), 0, SetViewRotation_InRotation_PropertyAddress.Address, InRotation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewRotation_FunctionAddress, intPtr, SetViewRotation_ParamsSize);
	}

	[UFunction(Flags = 616702977u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewportTransform")]
	public unsafe static void SetViewportTransform(FTransform InTransform)
	{
		if (!SetViewportTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewportTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewportTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewportTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetViewportTransform_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SetViewportTransform_InTransform_Offset), 0, SetViewportTransform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewportTransform_FunctionAddress, intPtr, SetViewportTransform_ParamsSize);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewLocation")]
	public unsafe static void SetViewLocation(FVector InLocation)
	{
		if (!SetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetViewLocation_InLocation_Offset), 0, SetViewLocation_InLocation_PropertyAddress.Address, InLocation);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetViewLocation_FunctionAddress, intPtr, SetViewLocation_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetStreamingLevelVolume")]
	public unsafe static void SetStreamingLevelVolume(ULevel LevelStreaming, ALevelStreamingVolume Vol)
	{
		if (!SetStreamingLevelVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetStreamingLevelVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStreamingLevelVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStreamingLevelVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SetStreamingLevelVolume_LevelStreaming_Offset), 0, SetStreamingLevelVolume_LevelStreaming_PropertyAddress.Address, LevelStreaming);
		UObjectMarshaler<ALevelStreamingVolume>.ToNative(IntPtr.Add(intPtr, SetStreamingLevelVolume_Vol_Offset), 0, SetStreamingLevelVolume_Vol_PropertyAddress.Address, Vol);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStreamingLevelVolume_FunctionAddress, intPtr, SetStreamingLevelVolume_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetCurrentLevel")]
	public unsafe static void SetCurrentLevel(UWorld World, ULevel Level)
	{
		if (!SetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetCurrentLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, SetCurrentLevel_World_Offset), 0, SetCurrentLevel_World_PropertyAddress.Address, World);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SetCurrentLevel_Level_Offset), 0, SetCurrentLevel_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCurrentLevel_FunctionAddress, intPtr, SetCurrentLevel_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetBPDesc")]
	public unsafe static void SetBPDesc(UBlueprint BP, string Desc)
	{
		if (!SetBPDesc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetBPDesc");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBPDesc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBPDesc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, SetBPDesc_BP_Offset), 0, SetBPDesc_BP_PropertyAddress.Address, BP);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBPDesc_Desc_Offset), 0, SetBPDesc_Desc_PropertyAddress.Address, Desc);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBPDesc_FunctionAddress, intPtr, SetBPDesc_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBPDesc_Desc_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorLevelBoundsRelevant")]
	public unsafe static void SetActorLevelBoundsRelevant(AActor InActor, bool bRelevant)
	{
		if (!SetActorLevelBoundsRelevant_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorLevelBoundsRelevant");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorLevelBoundsRelevant_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorLevelBoundsRelevant_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorLevelBoundsRelevant_InActor_Offset), 0, SetActorLevelBoundsRelevant_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorLevelBoundsRelevant_bRelevant_Offset), 0, SetActorLevelBoundsRelevant_bRelevant_PropertyAddress.Address, bRelevant);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorLevelBoundsRelevant_FunctionAddress, intPtr, SetActorLevelBoundsRelevant_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorEditorOnly")]
	public unsafe static void SetActorEditorOnly(AActor Actor, bool NewEnable)
	{
		if (!SetActorEditorOnly_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorEditorOnly");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetActorEditorOnly_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetActorEditorOnly_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SetActorEditorOnly_Actor_Offset), 0, SetActorEditorOnly_Actor_PropertyAddress.Address, Actor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetActorEditorOnly_NewEnable_Offset), 0, SetActorEditorOnly_NewEnable_PropertyAddress.Address, NewEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetActorEditorOnly_FunctionAddress, intPtr, SetActorEditorOnly_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ScanDuplicatedActorTracksInSequence")]
	public unsafe static void ScanDuplicatedActorTracksInSequence()
	{
		if (!ScanDuplicatedActorTracksInSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ScanDuplicatedActorTracksInSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanDuplicatedActorTracksInSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanDuplicatedActorTracksInSequence_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ScanDuplicatedActorTracksInSequence_FunctionAddress, argsSize: ScanDuplicatedActorTracksInSequence_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SavePackage")]
	public unsafe static void SavePackage(UPackage PackageToSave)
	{
		if (!SavePackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SavePackage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SavePackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SavePackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPackage>.ToNative(IntPtr.Add(intPtr, SavePackage_PackageToSave_Offset), 0, SavePackage_PackageToSave_PropertyAddress.Address, PackageToSave);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SavePackage_FunctionAddress, intPtr, SavePackage_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SaveObject")]
	public unsafe static void SaveObject(UObject ObjectToSave)
	{
		if (!SaveObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SaveObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SaveObject_ObjectToSave_Offset), 0, SaveObject_ObjectToSave_PropertyAddress.Address, ObjectToSave);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveObject_FunctionAddress, intPtr, SaveObject_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:SaveLevel")]
	public unsafe static void SaveLevel(ULevel LevelToSave)
	{
		if (!SaveLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:SaveLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SaveLevel_LevelToSave_Offset), 0, SaveLevel_LevelToSave_PropertyAddress.Address, LevelToSave);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLevel_FunctionAddress, intPtr, SaveLevel_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:RunDisableAllScreenMessageCommand")]
	public unsafe static void RunDisableAllScreenMessageCommand()
	{
		if (!RunDisableAllScreenMessageCommand_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:RunDisableAllScreenMessageCommand");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunDisableAllScreenMessageCommand_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunDisableAllScreenMessageCommand_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RunDisableAllScreenMessageCommand_FunctionAddress, argsSize: RunDisableAllScreenMessageCommand_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:RemoveAnimFrames")]
	public unsafe static void RemoveAnimFrames(UAnimSequence AnimSequence, float StartTime, float EndTime)
	{
		if (!RemoveAnimFrames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:RemoveAnimFrames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveAnimFrames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveAnimFrames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(intPtr, RemoveAnimFrames_AnimSequence_Offset), 0, RemoveAnimFrames_AnimSequence_PropertyAddress.Address, AnimSequence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RemoveAnimFrames_StartTime_Offset), 0, RemoveAnimFrames_StartTime_PropertyAddress.Address, StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, RemoveAnimFrames_EndTime_Offset), 0, RemoveAnimFrames_EndTime_PropertyAddress.Address, EndTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveAnimFrames_FunctionAddress, intPtr, RemoveAnimFrames_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:PopulateSelectedNAsToNiagaraMonitor")]
	public unsafe static void PopulateSelectedNAsToNiagaraMonitor(List<UNiagaraSystem> SelectedNiagaraAssets)
	{
		if (!PopulateSelectedNAsToNiagaraMonitor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:PopulateSelectedNAsToNiagaraMonitor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PopulateSelectedNAsToNiagaraMonitor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PopulateSelectedNAsToNiagaraMonitor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UNiagaraSystem>(1, PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_PropertyAddress, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.FromNative, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.ToNative).ToNative(IntPtr.Add(intPtr, PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_Offset), SelectedNiagaraAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PopulateSelectedNAsToNiagaraMonitor_FunctionAddress, intPtr, PopulateSelectedNAsToNiagaraMonitor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:PlayMap")]
	public unsafe static void PlayMap()
	{
		if (!PlayMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:PlayMap");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayMap_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PlayMap_FunctionAddress, argsSize: PlayMap_ParamsSize);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:PasteComponentsFromClipBoard")]
	public unsafe static void PasteComponentsFromClipBoard(out List<UActorComponent> OutPastedComponents, AActor TargetActor, bool bWarnIfHidden = false)
	{
		if (!PasteComponentsFromClipBoard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:PasteComponentsFromClipBoard");
			OutPastedComponents = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PasteComponentsFromClipBoard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PasteComponentsFromClipBoard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PasteComponentsFromClipBoard_TargetActor_Offset), 0, PasteComponentsFromClipBoard_TargetActor_PropertyAddress.Address, TargetActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PasteComponentsFromClipBoard_bWarnIfHidden_Offset), 0, PasteComponentsFromClipBoard_bWarnIfHidden_PropertyAddress.Address, bWarnIfHidden);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PasteComponentsFromClipBoard_FunctionAddress, intPtr, PasteComponentsFromClipBoard_ParamsSize);
		OutPastedComponents = new TArrayCopyMarshaler<UActorComponent>(1, PasteComponentsFromClipBoard_OutPastedComponents_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).FromNative(IntPtr.Add(intPtr, PasteComponentsFromClipBoard_OutPastedComponents_Offset));
		NativeReflection.DestroyValue_InContainer(PasteComponentsFromClipBoard_OutPastedComponents_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:OpenSourceFile")]
	public unsafe static void OpenSourceFile(string AbsoluteSourcePath, int LineNumber, int ColumnNumber)
	{
		if (!OpenSourceFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:OpenSourceFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenSourceFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenSourceFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenSourceFile_AbsoluteSourcePath_Offset), 0, OpenSourceFile_AbsoluteSourcePath_PropertyAddress.Address, AbsoluteSourcePath);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OpenSourceFile_LineNumber_Offset), 0, OpenSourceFile_LineNumber_PropertyAddress.Address, LineNumber);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OpenSourceFile_ColumnNumber_Offset), 0, OpenSourceFile_ColumnNumber_PropertyAddress.Address, ColumnNumber);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenSourceFile_FunctionAddress, intPtr, OpenSourceFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenSourceFile_AbsoluteSourcePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:OpenLevelInEditor")]
	public unsafe static bool OpenLevelInEditor(string PackageName, bool bOnlyPersistentLevel = true)
	{
		if (!OpenLevelInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:OpenLevelInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenLevelInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenLevelInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenLevelInEditor_PackageName_Offset), 0, OpenLevelInEditor_PackageName_PropertyAddress.Address, PackageName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OpenLevelInEditor_bOnlyPersistentLevel_Offset), 0, OpenLevelInEditor_bOnlyPersistentLevel_PropertyAddress.Address, bOnlyPersistentLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenLevelInEditor_FunctionAddress, intPtr, OpenLevelInEditor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenLevelInEditor_PackageName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenLevelInEditor_ReturnValue_Offset), 0, OpenLevelInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:OpenItemLevelInEditor")]
	public unsafe static bool OpenItemLevelInEditor(string PackageName, bool bOnlyPersistentLevel = true)
	{
		if (!OpenItemLevelInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:OpenItemLevelInEditor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenItemLevelInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenItemLevelInEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenItemLevelInEditor_PackageName_Offset), 0, OpenItemLevelInEditor_PackageName_PropertyAddress.Address, PackageName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, OpenItemLevelInEditor_bOnlyPersistentLevel_Offset), 0, OpenItemLevelInEditor_bOnlyPersistentLevel_PropertyAddress.Address, bOnlyPersistentLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenItemLevelInEditor_FunctionAddress, intPtr, OpenItemLevelInEditor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenItemLevelInEditor_PackageName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OpenItemLevelInEditor_ReturnValue_Offset), 0, OpenItemLevelInEditor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:MessageOpenDialogWithYesNoType")]
	public unsafe static bool MessageOpenDialogWithYesNoType(FText Message, FText Title)
	{
		if (!MessageOpenDialogWithYesNoType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:MessageOpenDialogWithYesNoType");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MessageOpenDialogWithYesNoType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MessageOpenDialogWithYesNoType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MessageOpenDialogWithYesNoType_Message_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, MessageOpenDialogWithYesNoType_Message_Offset), 0, MessageOpenDialogWithYesNoType_Message_PropertyAddress.Address, Message);
		NativeReflection.InitializeValue_InContainer(MessageOpenDialogWithYesNoType_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, MessageOpenDialogWithYesNoType_Title_Offset), 0, MessageOpenDialogWithYesNoType_Title_PropertyAddress.Address, Title);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MessageOpenDialogWithYesNoType_FunctionAddress, intPtr, MessageOpenDialogWithYesNoType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MessageOpenDialogWithYesNoType_Message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MessageOpenDialogWithYesNoType_Title_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MessageOpenDialogWithYesNoType_ReturnValue_Offset), 0, MessageOpenDialogWithYesNoType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:LoadLevel")]
	public unsafe static void LoadLevel(string Path)
	{
		if (!LoadLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:LoadLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadLevel_Path_Offset), 0, LoadLevel_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadLevel_FunctionAddress, intPtr, LoadLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadLevel_Path_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:IsUnderDirectory")]
	public unsafe static bool IsUnderDirectory(string InPath, string InDirectory)
	{
		if (!IsUnderDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:IsUnderDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsUnderDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsUnderDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsUnderDirectory_InPath_Offset), 0, IsUnderDirectory_InPath_PropertyAddress.Address, InPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, IsUnderDirectory_InDirectory_Offset), 0, IsUnderDirectory_InDirectory_PropertyAddress.Address, InDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsUnderDirectory_FunctionAddress, intPtr, IsUnderDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsUnderDirectory_InPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(IsUnderDirectory_InDirectory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsUnderDirectory_ReturnValue_Offset), 0, IsUnderDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:IsInEditorWithMoviePipelineQueue")]
	public unsafe static bool IsInEditorWithMoviePipelineQueue()
	{
		if (!IsInEditorWithMoviePipelineQueue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:IsInEditorWithMoviePipelineQueue");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInEditorWithMoviePipelineQueue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInEditorWithMoviePipelineQueue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsInEditorWithMoviePipelineQueue_FunctionAddress, intPtr, IsInEditorWithMoviePipelineQueue_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInEditorWithMoviePipelineQueue_ReturnValue_Offset), 0, IsInEditorWithMoviePipelineQueue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentPIEWorldContextInTick")]
	public unsafe static bool IsCurrentPIEWorldContextInTick(UObject WorldContext)
	{
		if (!IsCurrentPIEWorldContextInTick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentPIEWorldContextInTick");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCurrentPIEWorldContextInTick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCurrentPIEWorldContextInTick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsCurrentPIEWorldContextInTick_WorldContext_Offset), 0, IsCurrentPIEWorldContextInTick_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCurrentPIEWorldContextInTick_FunctionAddress, intPtr, IsCurrentPIEWorldContextInTick_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCurrentPIEWorldContextInTick_ReturnValue_Offset), 0, IsCurrentPIEWorldContextInTick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentEditorWorldContext")]
	public unsafe static bool IsCurrentEditorWorldContext(UObject WorldContext)
	{
		if (!IsCurrentEditorWorldContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentEditorWorldContext");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCurrentEditorWorldContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCurrentEditorWorldContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsCurrentEditorWorldContext_WorldContext_Offset), 0, IsCurrentEditorWorldContext_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCurrentEditorWorldContext_FunctionAddress, intPtr, IsCurrentEditorWorldContext_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCurrentEditorWorldContext_ReturnValue_Offset), 0, IsCurrentEditorWorldContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:IsClassPlaceable")]
	public unsafe static bool IsClassPlaceable(TSubclassOf<UObject> AssetClass)
	{
		if (!IsClassPlaceable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:IsClassPlaceable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsClassPlaceable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsClassPlaceable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, IsClassPlaceable_AssetClass_Offset), 0, IsClassPlaceable_AssetClass_PropertyAddress.Address, AssetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsClassPlaceable_FunctionAddress, intPtr, IsClassPlaceable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsClassPlaceable_ReturnValue_Offset), 0, IsClassPlaceable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ImportCSVToStringTable")]
	public unsafe static void ImportCSVToStringTable(FName TableID, string CSVPath)
	{
		if (!ImportCSVToStringTable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ImportCSVToStringTable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportCSVToStringTable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportCSVToStringTable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ImportCSVToStringTable_TableID_Offset), 0, ImportCSVToStringTable_TableID_PropertyAddress.Address, TableID);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportCSVToStringTable_CSVPath_Offset), 0, ImportCSVToStringTable_CSVPath_PropertyAddress.Address, CSVPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ImportCSVToStringTable_FunctionAddress, intPtr, ImportCSVToStringTable_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportCSVToStringTable_CSVPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:HotReLoadCastMoudleChange")]
	public unsafe static void HotReLoadCastMoudleChange()
	{
		if (!HotReLoadCastMoudleChange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:HotReLoadCastMoudleChange");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HotReLoadCastMoudleChange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HotReLoadCastMoudleChange_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: HotReLoadCastMoudleChange_FunctionAddress, argsSize: HotReLoadCastMoudleChange_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetValidPostProcessVolumes")]
	public unsafe static List<APostProcessVolume> GetValidPostProcessVolumes(UWorld InWorld)
	{
		if (!GetValidPostProcessVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetValidPostProcessVolumes");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValidPostProcessVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValidPostProcessVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetValidPostProcessVolumes_InWorld_Offset), 0, GetValidPostProcessVolumes_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetValidPostProcessVolumes_FunctionAddress, intPtr, GetValidPostProcessVolumes_ParamsSize);
		List<APostProcessVolume> result = new TArrayCopyMarshaler<APostProcessVolume>(1, GetValidPostProcessVolumes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<APostProcessVolume, UObjectMarshaler<APostProcessVolume>>.FromNative, CachedMarshalingDelegates<APostProcessVolume, UObjectMarshaler<APostProcessVolume>>.ToNative).FromNative(IntPtr.Add(intPtr, GetValidPostProcessVolumes_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetValidPostProcessVolumes_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetSelectedActors")]
	public unsafe static void GetSelectedActors(out List<AActor> OutActors)
	{
		if (!GetSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetSelectedActors");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedActors_FunctionAddress, intPtr, GetSelectedActors_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetSelectedActors_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedActors_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedActors_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetPersistentLevel")]
	public unsafe static ULevel GetPersistentLevel(UWorld World)
	{
		if (!GetPersistentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetPersistentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPersistentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPersistentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetPersistentLevel_World_Offset), 0, GetPersistentLevel_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPersistentLevel_FunctionAddress, intPtr, GetPersistentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetPersistentLevel_ReturnValue_Offset), 0, GetPersistentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetPackagesByName")]
	public unsafe static void GetPackagesByName(string Name, out List<FName> OutPackageNames)
	{
		if (!GetPackagesByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetPackagesByName");
			OutPackageNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPackagesByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPackagesByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPackagesByName_Name_Offset), 0, GetPackagesByName_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPackagesByName_FunctionAddress, intPtr, GetPackagesByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPackagesByName_Name_PropertyAddress.Address, intPtr);
		OutPackageNames = new TArrayCopyMarshaler<FName>(1, GetPackagesByName_OutPackageNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetPackagesByName_OutPackageNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetPackagesByName_OutPackageNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetEditorWorld")]
	public unsafe static UWorld GetEditorWorld()
	{
		if (!GetEditorWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetEditorWorld");
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

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetDirectoriesToAlwaysCook")]
	public unsafe static List<string> GetDirectoriesToAlwaysCook(bool bConvertToLocalPath = false)
	{
		if (!GetDirectoriesToAlwaysCook_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetDirectoriesToAlwaysCook");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDirectoriesToAlwaysCook_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDirectoriesToAlwaysCook_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetDirectoriesToAlwaysCook_bConvertToLocalPath_Offset), 0, GetDirectoriesToAlwaysCook_bConvertToLocalPath_PropertyAddress.Address, bConvertToLocalPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDirectoriesToAlwaysCook_FunctionAddress, intPtr, GetDirectoriesToAlwaysCook_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetDirectoriesToAlwaysCook_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetDirectoriesToAlwaysCook_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetDirectoriesToAlwaysCook_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentLevel")]
	public unsafe static ULevel GetCurrentLevel(UWorld World)
	{
		if (!GetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetCurrentLevel_World_Offset), 0, GetCurrentLevel_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentLevel_FunctionAddress, intPtr, GetCurrentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetCurrentLevel_ReturnValue_Offset), 0, GetCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentGWorldType")]
	public unsafe static int GetCurrentGWorldType()
	{
		if (!GetCurrentGWorldType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentGWorldType");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentGWorldType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentGWorldType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentGWorldType_FunctionAddress, intPtr, GetCurrentGWorldType_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentGWorldType_ReturnValue_Offset), 0, GetCurrentGWorldType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentEditingWorld")]
	public unsafe static UWorld GetCurrentEditingWorld()
	{
		if (!GetCurrentEditingWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentEditingWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentEditingWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentEditingWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentEditingWorld_FunctionAddress, intPtr, GetCurrentEditingWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetCurrentEditingWorld_ReturnValue_Offset), 0, GetCurrentEditingWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetContentBrowserSelections")]
	public unsafe static UAssetDataArray GetContentBrowserSelections()
	{
		if (!GetContentBrowserSelections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetContentBrowserSelections");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContentBrowserSelections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContentBrowserSelections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetContentBrowserSelections_FunctionAddress, intPtr, GetContentBrowserSelections_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetContentBrowserSelections_ReturnValue_Offset), 0, GetContentBrowserSelections_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetCDONodeComponents")]
	public unsafe static List<UActorComponent> GetCDONodeComponents(AActor CDO)
	{
		if (!GetCDONodeComponents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetCDONodeComponents");
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

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetBrushBounds")]
	public unsafe static FBoxSphereBounds GetBrushBounds(UBrushComponent BrushCom)
	{
		if (!GetBrushBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetBrushBounds");
			return default(FBoxSphereBounds);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBrushBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBrushBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBrushComponent>.ToNative(IntPtr.Add(intPtr, GetBrushBounds_BrushCom_Offset), 0, GetBrushBounds_BrushCom_PropertyAddress.Address, BrushCom);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBrushBounds_FunctionAddress, intPtr, GetBrushBounds_ParamsSize);
		return BlittableTypeMarshaler<FBoxSphereBounds>.FromNative(IntPtr.Add(intPtr, GetBrushBounds_ReturnValue_Offset), 0, GetBrushBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetAssetDependencies")]
	public unsafe static List<FName> GetAssetDependencies(FName PackageName)
	{
		if (!GetAssetDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetAssetDependencies");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetDependencies_PackageName_Offset), 0, GetAssetDependencies_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDependencies_FunctionAddress, intPtr, GetAssetDependencies_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetAssetDependencies_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetDependencies_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetDependencies_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GetAllLevelActors")]
	public unsafe static List<AActor> GetAllLevelActors()
	{
		if (!GetAllLevelActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GetAllLevelActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllLevelActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllLevelActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllLevelActors_FunctionAddress, intPtr, GetAllLevelActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllLevelActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllLevelActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllLevelActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GenerateNaviMeshBounds")]
	public unsafe static void GenerateNaviMeshBounds(AActor Anchor, float ScaleX, float ScaleY, float ScaleZ, AActor DuplicateBase)
	{
		if (!GenerateNaviMeshBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GenerateNaviMeshBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateNaviMeshBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateNaviMeshBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GenerateNaviMeshBounds_Anchor_Offset), 0, GenerateNaviMeshBounds_Anchor_PropertyAddress.Address, Anchor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GenerateNaviMeshBounds_ScaleX_Offset), 0, GenerateNaviMeshBounds_ScaleX_PropertyAddress.Address, ScaleX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GenerateNaviMeshBounds_ScaleY_Offset), 0, GenerateNaviMeshBounds_ScaleY_PropertyAddress.Address, ScaleY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GenerateNaviMeshBounds_ScaleZ_Offset), 0, GenerateNaviMeshBounds_ScaleZ_PropertyAddress.Address, ScaleZ);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GenerateNaviMeshBounds_DuplicateBase_Offset), 0, GenerateNaviMeshBounds_DuplicateBase_PropertyAddress.Address, DuplicateBase);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateNaviMeshBounds_FunctionAddress, intPtr, GenerateNaviMeshBounds_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:GatherText")]
	public unsafe static void GatherText()
	{
		if (!GatherText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:GatherText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GatherText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GatherText_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: GatherText_FunctionAddress, argsSize: GatherText_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetTagValue")]
	public unsafe static string FAssetData_GetTagValue(UAssetDataArray AssetData, FName TagName)
	{
		if (!FAssetData_GetTagValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetTagValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FAssetData_GetTagValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FAssetData_GetTagValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, FAssetData_GetTagValue_AssetData_Offset), 0, FAssetData_GetTagValue_AssetData_PropertyAddress.Address, AssetData);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FAssetData_GetTagValue_TagName_Offset), 0, FAssetData_GetTagValue_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FAssetData_GetTagValue_FunctionAddress, intPtr, FAssetData_GetTagValue_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FAssetData_GetTagValue_ReturnValue_Offset), 0, FAssetData_GetTagValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FAssetData_GetTagValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetClass")]
	public unsafe static TSubclassOf<UObject> FAssetData_GetClass(UAssetDataArray AssetData)
	{
		if (!FAssetData_GetClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FAssetData_GetClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FAssetData_GetClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, FAssetData_GetClass_AssetData_Offset), 0, FAssetData_GetClass_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FAssetData_GetClass_FunctionAddress, intPtr, FAssetData_GetClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FAssetData_GetClass_ReturnValue_Offset), 0, FAssetData_GetClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetAsset")]
	public unsafe static UObject FAssetData_GetAsset(UAssetDataArray AssetData)
	{
		if (!FAssetData_GetAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FAssetData_GetAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FAssetData_GetAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, FAssetData_GetAsset_AssetData_Offset), 0, FAssetData_GetAsset_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FAssetData_GetAsset_FunctionAddress, intPtr, FAssetData_GetAsset_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FAssetData_GetAsset_ReturnValue_Offset), 0, FAssetData_GetAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectNone")]
	public unsafe static void ExportToolSelectNone(bool bNoteSelectionChange, bool bDeselectBSPSurfs)
	{
		if (!ExportToolSelectNone_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectNone");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToolSelectNone_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToolSelectNone_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportToolSelectNone_bNoteSelectionChange_Offset), 0, ExportToolSelectNone_bNoteSelectionChange_PropertyAddress.Address, bNoteSelectionChange);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportToolSelectNone_bDeselectBSPSurfs_Offset), 0, ExportToolSelectNone_bDeselectBSPSurfs_PropertyAddress.Address, bDeselectBSPSurfs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportToolSelectNone_FunctionAddress, intPtr, ExportToolSelectNone_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectActor")]
	public unsafe static void ExportToolSelectActor(AActor TargetActor)
	{
		if (!ExportToolSelectActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToolSelectActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToolSelectActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ExportToolSelectActor_TargetActor_Offset), 0, ExportToolSelectActor_TargetActor_PropertyAddress.Address, TargetActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportToolSelectActor_FunctionAddress, intPtr, ExportToolSelectActor_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:EditObjectByName")]
	public unsafe static void EditObjectByName(string PackageName)
	{
		if (!EditObjectByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:EditObjectByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditObjectByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditObjectByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, EditObjectByName_PackageName_Offset), 0, EditObjectByName_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EditObjectByName_FunctionAddress, intPtr, EditObjectByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EditObjectByName_PackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:EditObject")]
	public unsafe static void EditObject(UObject ObjectToEdit)
	{
		if (!EditObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:EditObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EditObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EditObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, EditObject_ObjectToEdit_Offset), 0, EditObject_ObjectToEdit_PropertyAddress.Address, ObjectToEdit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EditObject_FunctionAddress, intPtr, EditObject_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateWorld")]
	public unsafe static UWorld DuplicateWorld(string TempleteWorld, string PackageName, string ObjectName)
	{
		if (!DuplicateWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateWorld_TempleteWorld_Offset), 0, DuplicateWorld_TempleteWorld_PropertyAddress.Address, TempleteWorld);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateWorld_PackageName_Offset), 0, DuplicateWorld_PackageName_PropertyAddress.Address, PackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateWorld_ObjectName_Offset), 0, DuplicateWorld_ObjectName_PropertyAddress.Address, ObjectName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateWorld_FunctionAddress, intPtr, DuplicateWorld_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateWorld_TempleteWorld_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateWorld_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateWorld_ObjectName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, DuplicateWorld_ReturnValue_Offset), 0, DuplicateWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateActor")]
	public unsafe static AActor DuplicateActor(AActor ActorToDuplicate, ULevel InLevel, FVector Offset)
	{
		if (!DuplicateActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DuplicateActor_ActorToDuplicate_Offset), 0, DuplicateActor_ActorToDuplicate_PropertyAddress.Address, ActorToDuplicate);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, DuplicateActor_InLevel_Offset), 0, DuplicateActor_InLevel_PropertyAddress.Address, InLevel);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DuplicateActor_Offset_Offset), 0, DuplicateActor_Offset_PropertyAddress.Address, Offset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateActor_FunctionAddress, intPtr, DuplicateActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, DuplicateActor_ReturnValue_Offset), 0, DuplicateActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteObject")]
	public unsafe static void DeleteObject(UObject ObjectToDelete, bool ShowConfirm)
	{
		if (!DeleteObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteObject");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DeleteObject_ObjectToDelete_Offset), 0, DeleteObject_ObjectToDelete_PropertyAddress.Address, ObjectToDelete);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteObject_ShowConfirm_Offset), 0, DeleteObject_ShowConfirm_PropertyAddress.Address, ShowConfirm);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteObject_FunctionAddress, intPtr, DeleteObject_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors_WithVerify")]
	public unsafe static void DeleteActors_WithVerify(List<AActor> InActorsToDelete, UWorld InWorld, bool bVerifyDeletionCanHappen = true, bool bWarnAboutReferences = true, bool bWarnAboutSoftReferences = true)
	{
		if (!DeleteActors_WithVerify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors_WithVerify");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteActors_WithVerify_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteActors_WithVerify_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, DeleteActors_WithVerify_InActorsToDelete_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteActors_WithVerify_InActorsToDelete_Offset), InActorsToDelete);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DeleteActors_WithVerify_InWorld_Offset), 0, DeleteActors_WithVerify_InWorld_PropertyAddress.Address, InWorld);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteActors_WithVerify_bVerifyDeletionCanHappen_Offset), 0, DeleteActors_WithVerify_bVerifyDeletionCanHappen_PropertyAddress.Address, bVerifyDeletionCanHappen);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteActors_WithVerify_bWarnAboutReferences_Offset), 0, DeleteActors_WithVerify_bWarnAboutReferences_PropertyAddress.Address, bWarnAboutReferences);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DeleteActors_WithVerify_bWarnAboutSoftReferences_Offset), 0, DeleteActors_WithVerify_bWarnAboutSoftReferences_PropertyAddress.Address, bWarnAboutSoftReferences);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteActors_WithVerify_FunctionAddress, intPtr, DeleteActors_WithVerify_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteActors_WithVerify_InActorsToDelete_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors")]
	public unsafe static void DeleteActors(List<AActor> InActorsToDelete, UWorld InWorld)
	{
		if (!DeleteActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, DeleteActors_InActorsToDelete_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteActors_InActorsToDelete_Offset), InActorsToDelete);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DeleteActors_InWorld_Offset), 0, DeleteActors_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteActors_FunctionAddress, intPtr, DeleteActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteActors_InActorsToDelete_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 612508673u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:DebugRoomCreateLevel")]
	public unsafe static void DebugRoomCreateLevel(string MainWorld, string TempleteWorld, string PackageName, string ObjectName, string ChineseName, FTransform NewWorldTrans)
	{
		if (!DebugRoomCreateLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:DebugRoomCreateLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DebugRoomCreateLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DebugRoomCreateLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_MainWorld_Offset), 0, DebugRoomCreateLevel_MainWorld_PropertyAddress.Address, MainWorld);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_TempleteWorld_Offset), 0, DebugRoomCreateLevel_TempleteWorld_PropertyAddress.Address, TempleteWorld);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_PackageName_Offset), 0, DebugRoomCreateLevel_PackageName_PropertyAddress.Address, PackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_ObjectName_Offset), 0, DebugRoomCreateLevel_ObjectName_PropertyAddress.Address, ObjectName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_ChineseName_Offset), 0, DebugRoomCreateLevel_ChineseName_PropertyAddress.Address, ChineseName);
		NativeReflection.InitializeValue_InContainer(DebugRoomCreateLevel_NewWorldTrans_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, DebugRoomCreateLevel_NewWorldTrans_Offset), 0, DebugRoomCreateLevel_NewWorldTrans_PropertyAddress.Address, NewWorldTrans);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DebugRoomCreateLevel_FunctionAddress, intPtr, DebugRoomCreateLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DebugRoomCreateLevel_MainWorld_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DebugRoomCreateLevel_TempleteWorld_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DebugRoomCreateLevel_PackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DebugRoomCreateLevel_ObjectName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DebugRoomCreateLevel_ChineseName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:CopyComponentsToClipBoard")]
	public unsafe static void CopyComponentsToClipBoard(List<UActorComponent> ComponentsToCopy)
	{
		if (!CopyComponentsToClipBoard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:CopyComponentsToClipBoard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyComponentsToClipBoard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyComponentsToClipBoard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UActorComponent>(1, CopyComponentsToClipBoard_ComponentsToCopy_PropertyAddress, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.FromNative, CachedMarshalingDelegates<UActorComponent, UObjectMarshaler<UActorComponent>>.ToNative).ToNative(IntPtr.Add(intPtr, CopyComponentsToClipBoard_ComponentsToCopy_Offset), ComponentsToCopy);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyComponentsToClipBoard_FunctionAddress, intPtr, CopyComponentsToClipBoard_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyComponentsToClipBoard_ComponentsToCopy_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:CompileText")]
	public unsafe static void CompileText()
	{
		if (!CompileText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:CompileText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CompileText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CompileText_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CompileText_FunctionAddress, argsSize: CompileText_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:CheckAssetHasScriptBlueprint")]
	public unsafe static bool CheckAssetHasScriptBlueprint(UObject Asset)
	{
		if (!CheckAssetHasScriptBlueprint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:CheckAssetHasScriptBlueprint");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckAssetHasScriptBlueprint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckAssetHasScriptBlueprint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CheckAssetHasScriptBlueprint_Asset_Offset), 0, CheckAssetHasScriptBlueprint_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckAssetHasScriptBlueprint_FunctionAddress, intPtr, CheckAssetHasScriptBlueprint_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckAssetHasScriptBlueprint_ReturnValue_Offset), 0, CheckAssetHasScriptBlueprint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:CheckActorBoundsInfo")]
	public unsafe static void CheckActorBoundsInfo(AActor InActor, bool bIncludeNonCollision, out bool OutActorLevelBoundsRelevant, out FBox OutActorBounds)
	{
		if (!CheckActorBoundsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:CheckActorBoundsInfo");
			OutActorLevelBoundsRelevant = false;
			OutActorBounds = default(FBox);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckActorBoundsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckActorBoundsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CheckActorBoundsInfo_InActor_Offset), 0, CheckActorBoundsInfo_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckActorBoundsInfo_bIncludeNonCollision_Offset), 0, CheckActorBoundsInfo_bIncludeNonCollision_PropertyAddress.Address, bIncludeNonCollision);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckActorBoundsInfo_FunctionAddress, intPtr, CheckActorBoundsInfo_ParamsSize);
		OutActorLevelBoundsRelevant = BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckActorBoundsInfo_OutActorLevelBoundsRelevant_Offset), 0, CheckActorBoundsInfo_OutActorLevelBoundsRelevant_PropertyAddress.Address);
		OutActorBounds = BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, CheckActorBoundsInfo_OutActorBounds_Offset), 0, CheckActorBoundsInfo_OutActorBounds_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:BGULandscapeCameraCollsion")]
	public unsafe static void BGULandscapeCameraCollsion(UObject WorldContextObject, int SurfaceType, float cellSize, float MaxHeightOffset, float MaxDisplacement, float CameraCollisionOffset)
	{
		if (!BGULandscapeCameraCollsion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:BGULandscapeCameraCollsion");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGULandscapeCameraCollsion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGULandscapeCameraCollsion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_WorldContextObject_Offset), 0, BGULandscapeCameraCollsion_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_SurfaceType_Offset), 0, BGULandscapeCameraCollsion_SurfaceType_PropertyAddress.Address, SurfaceType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_cellSize_Offset), 0, BGULandscapeCameraCollsion_cellSize_PropertyAddress.Address, cellSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_MaxHeightOffset_Offset), 0, BGULandscapeCameraCollsion_MaxHeightOffset_PropertyAddress.Address, MaxHeightOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_MaxDisplacement_Offset), 0, BGULandscapeCameraCollsion_MaxDisplacement_PropertyAddress.Address, MaxDisplacement);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGULandscapeCameraCollsion_CameraCollisionOffset_Offset), 0, BGULandscapeCameraCollsion_CameraCollisionOffset_PropertyAddress.Address, CameraCollisionOffset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGULandscapeCameraCollsion_FunctionAddress, intPtr, BGULandscapeCameraCollsion_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:BGUGetStaticMeshComp")]
	public unsafe static UStaticMeshComponent BGUGetStaticMeshComp(AActor Actor)
	{
		if (!BGUGetStaticMeshComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:BGUGetStaticMeshComp");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetStaticMeshComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetStaticMeshComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetStaticMeshComp_Actor_Offset), 0, BGUGetStaticMeshComp_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetStaticMeshComp_FunctionAddress, intPtr, BGUGetStaticMeshComp_ParamsSize);
		return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(intPtr, BGUGetStaticMeshComp_ReturnValue_Offset), 0, BGUGetStaticMeshComp_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:AssetPath_GetCDO")]
	public unsafe static UObject AssetPath_GetCDO(UObject Outer, string Path, out UBlueprint Blueprint)
	{
		if (!AssetPath_GetCDO_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:AssetPath_GetCDO");
			Blueprint = null;
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssetPath_GetCDO_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssetPath_GetCDO_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AssetPath_GetCDO_Outer_Offset), 0, AssetPath_GetCDO_Outer_PropertyAddress.Address, Outer);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssetPath_GetCDO_Path_Offset), 0, AssetPath_GetCDO_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AssetPath_GetCDO_FunctionAddress, intPtr, AssetPath_GetCDO_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssetPath_GetCDO_Path_PropertyAddress.Address, intPtr);
		Blueprint = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(intPtr, AssetPath_GetCDO_Blueprint_Offset), 0, AssetPath_GetCDO_Blueprint_PropertyAddress.Address);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, AssetPath_GetCDO_ReturnValue_Offset), 0, AssetPath_GetCDO_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_EditorFuncLib:ActorRename")]
	public unsafe static void ActorRename(AActor Actor, string NewName)
	{
		if (!ActorRename_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_EditorFuncLib:ActorRename");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ActorRename_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ActorRename_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ActorRename_Actor_Offset), 0, ActorRename_Actor_PropertyAddress.Address, Actor);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ActorRename_NewName_Offset), 0, ActorRename_NewName_PropertyAddress.Address, NewName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ActorRename_FunctionAddress, intPtr, ActorRename_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ActorRename_NewName_PropertyAddress.Address, intPtr);
	}

	static UGSE_EditorFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_EditorFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_EditorFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_EditorFuncLib");
		SpawnActorFromFactory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnActorFromFactory");
		SpawnActorFromFactory_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorFromFactory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromFactory_AssetObject_PropertyAddress, SpawnActorFromFactory_FunctionAddress, "AssetObject");
		SpawnActorFromFactory_AssetObject_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromFactory_FunctionAddress, "AssetObject");
		SpawnActorFromFactory_AssetObject_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromFactory_FunctionAddress, "AssetObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromFactory_Transform_PropertyAddress, SpawnActorFromFactory_FunctionAddress, "Transform");
		SpawnActorFromFactory_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromFactory_FunctionAddress, "Transform");
		SpawnActorFromFactory_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromFactory_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActorFromFactory_ReturnValue_PropertyAddress, SpawnActorFromFactory_FunctionAddress, "ReturnValue");
		SpawnActorFromFactory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActorFromFactory_FunctionAddress, "ReturnValue");
		SpawnActorFromFactory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActorFromFactory_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorFromFactory_IsValid = SpawnActorFromFactory_FunctionAddress != IntPtr.Zero && SpawnActorFromFactory_AssetObject_IsValid && SpawnActorFromFactory_Transform_IsValid && SpawnActorFromFactory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SpawnActorFromFactory", SpawnActorFromFactory_IsValid);
		ShowWidgetBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowWidgetBlueprint");
		ShowWidgetBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowWidgetBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowWidgetBlueprint_Outer_PropertyAddress, ShowWidgetBlueprint_FunctionAddress, "Outer");
		ShowWidgetBlueprint_Outer_Offset = NativeReflectionCached.GetPropertyOffset(ShowWidgetBlueprint_FunctionAddress, "Outer");
		ShowWidgetBlueprint_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowWidgetBlueprint_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowWidgetBlueprint_Path_PropertyAddress, ShowWidgetBlueprint_FunctionAddress, "Path");
		ShowWidgetBlueprint_Path_Offset = NativeReflectionCached.GetPropertyOffset(ShowWidgetBlueprint_FunctionAddress, "Path");
		ShowWidgetBlueprint_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowWidgetBlueprint_FunctionAddress, "Path", Classes.FStrProperty);
		ShowWidgetBlueprint_IsValid = ShowWidgetBlueprint_FunctionAddress != IntPtr.Zero && ShowWidgetBlueprint_Outer_IsValid && ShowWidgetBlueprint_Path_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ShowWidgetBlueprint", ShowWidgetBlueprint_IsValid);
		SetViewTransitionToLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewTransitionToLocation");
		SetViewTransitionToLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewTransitionToLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewTransitionToLocation_LocationToLook_PropertyAddress, SetViewTransitionToLocation_FunctionAddress, "LocationToLook");
		SetViewTransitionToLocation_LocationToLook_Offset = NativeReflectionCached.GetPropertyOffset(SetViewTransitionToLocation_FunctionAddress, "LocationToLook");
		SetViewTransitionToLocation_LocationToLook_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewTransitionToLocation_FunctionAddress, "LocationToLook", Classes.FStructProperty);
		SetViewTransitionToLocation_IsValid = SetViewTransitionToLocation_FunctionAddress != IntPtr.Zero && SetViewTransitionToLocation_LocationToLook_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewTransitionToLocation", SetViewTransitionToLocation_IsValid);
		SetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewRotation");
		SetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_InRotation_PropertyAddress, SetViewRotation_FunctionAddress, "InRotation");
		SetViewRotation_InRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "InRotation");
		SetViewRotation_InRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "InRotation", Classes.FStructProperty);
		SetViewRotation_IsValid = SetViewRotation_FunctionAddress != IntPtr.Zero && SetViewRotation_InRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewRotation", SetViewRotation_IsValid);
		SetViewportTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewportTransform");
		SetViewportTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewportTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewportTransform_InTransform_PropertyAddress, SetViewportTransform_FunctionAddress, "InTransform");
		SetViewportTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetViewportTransform_FunctionAddress, "InTransform");
		SetViewportTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewportTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		SetViewportTransform_IsValid = SetViewportTransform_FunctionAddress != IntPtr.Zero && SetViewportTransform_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewportTransform", SetViewportTransform_IsValid);
		SetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetViewLocation");
		SetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewLocation_InLocation_PropertyAddress, SetViewLocation_FunctionAddress, "InLocation");
		SetViewLocation_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewLocation_FunctionAddress, "InLocation");
		SetViewLocation_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewLocation_FunctionAddress, "InLocation", Classes.FStructProperty);
		SetViewLocation_IsValid = SetViewLocation_FunctionAddress != IntPtr.Zero && SetViewLocation_InLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetViewLocation", SetViewLocation_IsValid);
		SetStreamingLevelVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStreamingLevelVolume");
		SetStreamingLevelVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStreamingLevelVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStreamingLevelVolume_LevelStreaming_PropertyAddress, SetStreamingLevelVolume_FunctionAddress, "LevelStreaming");
		SetStreamingLevelVolume_LevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(SetStreamingLevelVolume_FunctionAddress, "LevelStreaming");
		SetStreamingLevelVolume_LevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStreamingLevelVolume_FunctionAddress, "LevelStreaming", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStreamingLevelVolume_Vol_PropertyAddress, SetStreamingLevelVolume_FunctionAddress, "Vol");
		SetStreamingLevelVolume_Vol_Offset = NativeReflectionCached.GetPropertyOffset(SetStreamingLevelVolume_FunctionAddress, "Vol");
		SetStreamingLevelVolume_Vol_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStreamingLevelVolume_FunctionAddress, "Vol", Classes.FObjectProperty);
		SetStreamingLevelVolume_IsValid = SetStreamingLevelVolume_FunctionAddress != IntPtr.Zero && SetStreamingLevelVolume_LevelStreaming_IsValid && SetStreamingLevelVolume_Vol_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetStreamingLevelVolume", SetStreamingLevelVolume_IsValid);
		SetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCurrentLevel");
		SetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLevel_World_PropertyAddress, SetCurrentLevel_FunctionAddress, "World");
		SetCurrentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLevel_FunctionAddress, "World");
		SetCurrentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCurrentLevel_Level_PropertyAddress, SetCurrentLevel_FunctionAddress, "Level");
		SetCurrentLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(SetCurrentLevel_FunctionAddress, "Level");
		SetCurrentLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCurrentLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		SetCurrentLevel_IsValid = SetCurrentLevel_FunctionAddress != IntPtr.Zero && SetCurrentLevel_World_IsValid && SetCurrentLevel_Level_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetCurrentLevel", SetCurrentLevel_IsValid);
		SetBPDesc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBPDesc");
		SetBPDesc_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBPDesc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBPDesc_BP_PropertyAddress, SetBPDesc_FunctionAddress, "BP");
		SetBPDesc_BP_Offset = NativeReflectionCached.GetPropertyOffset(SetBPDesc_FunctionAddress, "BP");
		SetBPDesc_BP_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBPDesc_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBPDesc_Desc_PropertyAddress, SetBPDesc_FunctionAddress, "Desc");
		SetBPDesc_Desc_Offset = NativeReflectionCached.GetPropertyOffset(SetBPDesc_FunctionAddress, "Desc");
		SetBPDesc_Desc_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBPDesc_FunctionAddress, "Desc", Classes.FStrProperty);
		SetBPDesc_IsValid = SetBPDesc_FunctionAddress != IntPtr.Zero && SetBPDesc_BP_IsValid && SetBPDesc_Desc_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetBPDesc", SetBPDesc_IsValid);
		SetActorLevelBoundsRelevant_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorLevelBoundsRelevant");
		SetActorLevelBoundsRelevant_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorLevelBoundsRelevant_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorLevelBoundsRelevant_InActor_PropertyAddress, SetActorLevelBoundsRelevant_FunctionAddress, "InActor");
		SetActorLevelBoundsRelevant_InActor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLevelBoundsRelevant_FunctionAddress, "InActor");
		SetActorLevelBoundsRelevant_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLevelBoundsRelevant_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorLevelBoundsRelevant_bRelevant_PropertyAddress, SetActorLevelBoundsRelevant_FunctionAddress, "bRelevant");
		SetActorLevelBoundsRelevant_bRelevant_Offset = NativeReflectionCached.GetPropertyOffset(SetActorLevelBoundsRelevant_FunctionAddress, "bRelevant");
		SetActorLevelBoundsRelevant_bRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorLevelBoundsRelevant_FunctionAddress, "bRelevant", Classes.FBoolProperty);
		SetActorLevelBoundsRelevant_IsValid = SetActorLevelBoundsRelevant_FunctionAddress != IntPtr.Zero && SetActorLevelBoundsRelevant_InActor_IsValid && SetActorLevelBoundsRelevant_bRelevant_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorLevelBoundsRelevant", SetActorLevelBoundsRelevant_IsValid);
		SetActorEditorOnly_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetActorEditorOnly");
		SetActorEditorOnly_ParamsSize = NativeReflection.GetFunctionParamsSize(SetActorEditorOnly_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetActorEditorOnly_Actor_PropertyAddress, SetActorEditorOnly_FunctionAddress, "Actor");
		SetActorEditorOnly_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SetActorEditorOnly_FunctionAddress, "Actor");
		SetActorEditorOnly_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorEditorOnly_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetActorEditorOnly_NewEnable_PropertyAddress, SetActorEditorOnly_FunctionAddress, "NewEnable");
		SetActorEditorOnly_NewEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetActorEditorOnly_FunctionAddress, "NewEnable");
		SetActorEditorOnly_NewEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetActorEditorOnly_FunctionAddress, "NewEnable", Classes.FBoolProperty);
		SetActorEditorOnly_IsValid = SetActorEditorOnly_FunctionAddress != IntPtr.Zero && SetActorEditorOnly_Actor_IsValid && SetActorEditorOnly_NewEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SetActorEditorOnly", SetActorEditorOnly_IsValid);
		ScanDuplicatedActorTracksInSequence_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanDuplicatedActorTracksInSequence");
		ScanDuplicatedActorTracksInSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanDuplicatedActorTracksInSequence_FunctionAddress);
		ScanDuplicatedActorTracksInSequence_IsValid = ScanDuplicatedActorTracksInSequence_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ScanDuplicatedActorTracksInSequence", ScanDuplicatedActorTracksInSequence_IsValid);
		SavePackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SavePackage");
		SavePackage_ParamsSize = NativeReflection.GetFunctionParamsSize(SavePackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SavePackage_PackageToSave_PropertyAddress, SavePackage_FunctionAddress, "PackageToSave");
		SavePackage_PackageToSave_Offset = NativeReflectionCached.GetPropertyOffset(SavePackage_FunctionAddress, "PackageToSave");
		SavePackage_PackageToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePackage_FunctionAddress, "PackageToSave", Classes.FObjectProperty);
		SavePackage_IsValid = SavePackage_FunctionAddress != IntPtr.Zero && SavePackage_PackageToSave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SavePackage", SavePackage_IsValid);
		SaveObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveObject");
		SaveObject_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveObject_ObjectToSave_PropertyAddress, SaveObject_FunctionAddress, "ObjectToSave");
		SaveObject_ObjectToSave_Offset = NativeReflectionCached.GetPropertyOffset(SaveObject_FunctionAddress, "ObjectToSave");
		SaveObject_ObjectToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveObject_FunctionAddress, "ObjectToSave", Classes.FObjectProperty);
		SaveObject_IsValid = SaveObject_FunctionAddress != IntPtr.Zero && SaveObject_ObjectToSave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SaveObject", SaveObject_IsValid);
		SaveLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLevel");
		SaveLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLevel_LevelToSave_PropertyAddress, SaveLevel_FunctionAddress, "LevelToSave");
		SaveLevel_LevelToSave_Offset = NativeReflectionCached.GetPropertyOffset(SaveLevel_FunctionAddress, "LevelToSave");
		SaveLevel_LevelToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLevel_FunctionAddress, "LevelToSave", Classes.FObjectProperty);
		SaveLevel_IsValid = SaveLevel_FunctionAddress != IntPtr.Zero && SaveLevel_LevelToSave_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:SaveLevel", SaveLevel_IsValid);
		RunDisableAllScreenMessageCommand_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RunDisableAllScreenMessageCommand");
		RunDisableAllScreenMessageCommand_ParamsSize = NativeReflection.GetFunctionParamsSize(RunDisableAllScreenMessageCommand_FunctionAddress);
		RunDisableAllScreenMessageCommand_IsValid = RunDisableAllScreenMessageCommand_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:RunDisableAllScreenMessageCommand", RunDisableAllScreenMessageCommand_IsValid);
		RemoveAnimFrames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveAnimFrames");
		RemoveAnimFrames_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveAnimFrames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimFrames_AnimSequence_PropertyAddress, RemoveAnimFrames_FunctionAddress, "AnimSequence");
		RemoveAnimFrames_AnimSequence_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimFrames_FunctionAddress, "AnimSequence");
		RemoveAnimFrames_AnimSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimFrames_FunctionAddress, "AnimSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimFrames_StartTime_PropertyAddress, RemoveAnimFrames_FunctionAddress, "StartTime");
		RemoveAnimFrames_StartTime_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimFrames_FunctionAddress, "StartTime");
		RemoveAnimFrames_StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimFrames_FunctionAddress, "StartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveAnimFrames_EndTime_PropertyAddress, RemoveAnimFrames_FunctionAddress, "EndTime");
		RemoveAnimFrames_EndTime_Offset = NativeReflectionCached.GetPropertyOffset(RemoveAnimFrames_FunctionAddress, "EndTime");
		RemoveAnimFrames_EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveAnimFrames_FunctionAddress, "EndTime", Classes.FFloatProperty);
		RemoveAnimFrames_IsValid = RemoveAnimFrames_FunctionAddress != IntPtr.Zero && RemoveAnimFrames_AnimSequence_IsValid && RemoveAnimFrames_StartTime_IsValid && RemoveAnimFrames_EndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:RemoveAnimFrames", RemoveAnimFrames_IsValid);
		PopulateSelectedNAsToNiagaraMonitor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PopulateSelectedNAsToNiagaraMonitor");
		PopulateSelectedNAsToNiagaraMonitor_ParamsSize = NativeReflection.GetFunctionParamsSize(PopulateSelectedNAsToNiagaraMonitor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_PropertyAddress, PopulateSelectedNAsToNiagaraMonitor_FunctionAddress, "SelectedNiagaraAssets");
		PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_Offset = NativeReflectionCached.GetPropertyOffset(PopulateSelectedNAsToNiagaraMonitor_FunctionAddress, "SelectedNiagaraAssets");
		PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(PopulateSelectedNAsToNiagaraMonitor_FunctionAddress, "SelectedNiagaraAssets", Classes.FArrayProperty);
		PopulateSelectedNAsToNiagaraMonitor_IsValid = PopulateSelectedNAsToNiagaraMonitor_FunctionAddress != IntPtr.Zero && PopulateSelectedNAsToNiagaraMonitor_SelectedNiagaraAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:PopulateSelectedNAsToNiagaraMonitor", PopulateSelectedNAsToNiagaraMonitor_IsValid);
		PlayMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayMap");
		PlayMap_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayMap_FunctionAddress);
		PlayMap_IsValid = PlayMap_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:PlayMap", PlayMap_IsValid);
		PasteComponentsFromClipBoard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PasteComponentsFromClipBoard");
		PasteComponentsFromClipBoard_ParamsSize = NativeReflection.GetFunctionParamsSize(PasteComponentsFromClipBoard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PasteComponentsFromClipBoard_OutPastedComponents_PropertyAddress, PasteComponentsFromClipBoard_FunctionAddress, "OutPastedComponents");
		PasteComponentsFromClipBoard_OutPastedComponents_Offset = NativeReflectionCached.GetPropertyOffset(PasteComponentsFromClipBoard_FunctionAddress, "OutPastedComponents");
		PasteComponentsFromClipBoard_OutPastedComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteComponentsFromClipBoard_FunctionAddress, "OutPastedComponents", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PasteComponentsFromClipBoard_TargetActor_PropertyAddress, PasteComponentsFromClipBoard_FunctionAddress, "TargetActor");
		PasteComponentsFromClipBoard_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(PasteComponentsFromClipBoard_FunctionAddress, "TargetActor");
		PasteComponentsFromClipBoard_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteComponentsFromClipBoard_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PasteComponentsFromClipBoard_bWarnIfHidden_PropertyAddress, PasteComponentsFromClipBoard_FunctionAddress, "bWarnIfHidden");
		PasteComponentsFromClipBoard_bWarnIfHidden_Offset = NativeReflectionCached.GetPropertyOffset(PasteComponentsFromClipBoard_FunctionAddress, "bWarnIfHidden");
		PasteComponentsFromClipBoard_bWarnIfHidden_IsValid = NativeReflectionCached.ValidatePropertyClass(PasteComponentsFromClipBoard_FunctionAddress, "bWarnIfHidden", Classes.FBoolProperty);
		PasteComponentsFromClipBoard_IsValid = PasteComponentsFromClipBoard_FunctionAddress != IntPtr.Zero && PasteComponentsFromClipBoard_OutPastedComponents_IsValid && PasteComponentsFromClipBoard_TargetActor_IsValid && PasteComponentsFromClipBoard_bWarnIfHidden_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:PasteComponentsFromClipBoard", PasteComponentsFromClipBoard_IsValid);
		OpenSourceFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenSourceFile");
		OpenSourceFile_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenSourceFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceFile_AbsoluteSourcePath_PropertyAddress, OpenSourceFile_FunctionAddress, "AbsoluteSourcePath");
		OpenSourceFile_AbsoluteSourcePath_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceFile_FunctionAddress, "AbsoluteSourcePath");
		OpenSourceFile_AbsoluteSourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceFile_FunctionAddress, "AbsoluteSourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceFile_LineNumber_PropertyAddress, OpenSourceFile_FunctionAddress, "LineNumber");
		OpenSourceFile_LineNumber_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceFile_FunctionAddress, "LineNumber");
		OpenSourceFile_LineNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceFile_FunctionAddress, "LineNumber", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSourceFile_ColumnNumber_PropertyAddress, OpenSourceFile_FunctionAddress, "ColumnNumber");
		OpenSourceFile_ColumnNumber_Offset = NativeReflectionCached.GetPropertyOffset(OpenSourceFile_FunctionAddress, "ColumnNumber");
		OpenSourceFile_ColumnNumber_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenSourceFile_FunctionAddress, "ColumnNumber", Classes.FIntProperty);
		OpenSourceFile_IsValid = OpenSourceFile_FunctionAddress != IntPtr.Zero && OpenSourceFile_AbsoluteSourcePath_IsValid && OpenSourceFile_LineNumber_IsValid && OpenSourceFile_ColumnNumber_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:OpenSourceFile", OpenSourceFile_IsValid);
		OpenLevelInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenLevelInEditor");
		OpenLevelInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenLevelInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenLevelInEditor_PackageName_PropertyAddress, OpenLevelInEditor_FunctionAddress, "PackageName");
		OpenLevelInEditor_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(OpenLevelInEditor_FunctionAddress, "PackageName");
		OpenLevelInEditor_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLevelInEditor_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenLevelInEditor_bOnlyPersistentLevel_PropertyAddress, OpenLevelInEditor_FunctionAddress, "bOnlyPersistentLevel");
		OpenLevelInEditor_bOnlyPersistentLevel_Offset = NativeReflectionCached.GetPropertyOffset(OpenLevelInEditor_FunctionAddress, "bOnlyPersistentLevel");
		OpenLevelInEditor_bOnlyPersistentLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLevelInEditor_FunctionAddress, "bOnlyPersistentLevel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenLevelInEditor_ReturnValue_PropertyAddress, OpenLevelInEditor_FunctionAddress, "ReturnValue");
		OpenLevelInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenLevelInEditor_FunctionAddress, "ReturnValue");
		OpenLevelInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenLevelInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenLevelInEditor_IsValid = OpenLevelInEditor_FunctionAddress != IntPtr.Zero && OpenLevelInEditor_PackageName_IsValid && OpenLevelInEditor_bOnlyPersistentLevel_IsValid && OpenLevelInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:OpenLevelInEditor", OpenLevelInEditor_IsValid);
		OpenItemLevelInEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenItemLevelInEditor");
		OpenItemLevelInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenItemLevelInEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenItemLevelInEditor_PackageName_PropertyAddress, OpenItemLevelInEditor_FunctionAddress, "PackageName");
		OpenItemLevelInEditor_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(OpenItemLevelInEditor_FunctionAddress, "PackageName");
		OpenItemLevelInEditor_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenItemLevelInEditor_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenItemLevelInEditor_bOnlyPersistentLevel_PropertyAddress, OpenItemLevelInEditor_FunctionAddress, "bOnlyPersistentLevel");
		OpenItemLevelInEditor_bOnlyPersistentLevel_Offset = NativeReflectionCached.GetPropertyOffset(OpenItemLevelInEditor_FunctionAddress, "bOnlyPersistentLevel");
		OpenItemLevelInEditor_bOnlyPersistentLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenItemLevelInEditor_FunctionAddress, "bOnlyPersistentLevel", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenItemLevelInEditor_ReturnValue_PropertyAddress, OpenItemLevelInEditor_FunctionAddress, "ReturnValue");
		OpenItemLevelInEditor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OpenItemLevelInEditor_FunctionAddress, "ReturnValue");
		OpenItemLevelInEditor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenItemLevelInEditor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OpenItemLevelInEditor_IsValid = OpenItemLevelInEditor_FunctionAddress != IntPtr.Zero && OpenItemLevelInEditor_PackageName_IsValid && OpenItemLevelInEditor_bOnlyPersistentLevel_IsValid && OpenItemLevelInEditor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:OpenItemLevelInEditor", OpenItemLevelInEditor_IsValid);
		MessageOpenDialogWithYesNoType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MessageOpenDialogWithYesNoType");
		MessageOpenDialogWithYesNoType_ParamsSize = NativeReflection.GetFunctionParamsSize(MessageOpenDialogWithYesNoType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MessageOpenDialogWithYesNoType_Message_PropertyAddress, MessageOpenDialogWithYesNoType_FunctionAddress, "Message");
		MessageOpenDialogWithYesNoType_Message_Offset = NativeReflectionCached.GetPropertyOffset(MessageOpenDialogWithYesNoType_FunctionAddress, "Message");
		MessageOpenDialogWithYesNoType_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(MessageOpenDialogWithYesNoType_FunctionAddress, "Message", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref MessageOpenDialogWithYesNoType_Title_PropertyAddress, MessageOpenDialogWithYesNoType_FunctionAddress, "Title");
		MessageOpenDialogWithYesNoType_Title_Offset = NativeReflectionCached.GetPropertyOffset(MessageOpenDialogWithYesNoType_FunctionAddress, "Title");
		MessageOpenDialogWithYesNoType_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(MessageOpenDialogWithYesNoType_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref MessageOpenDialogWithYesNoType_ReturnValue_PropertyAddress, MessageOpenDialogWithYesNoType_FunctionAddress, "ReturnValue");
		MessageOpenDialogWithYesNoType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MessageOpenDialogWithYesNoType_FunctionAddress, "ReturnValue");
		MessageOpenDialogWithYesNoType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MessageOpenDialogWithYesNoType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MessageOpenDialogWithYesNoType_IsValid = MessageOpenDialogWithYesNoType_FunctionAddress != IntPtr.Zero && MessageOpenDialogWithYesNoType_Message_IsValid && MessageOpenDialogWithYesNoType_Title_IsValid && MessageOpenDialogWithYesNoType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:MessageOpenDialogWithYesNoType", MessageOpenDialogWithYesNoType_IsValid);
		LoadLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadLevel");
		LoadLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadLevel_Path_PropertyAddress, LoadLevel_FunctionAddress, "Path");
		LoadLevel_Path_Offset = NativeReflectionCached.GetPropertyOffset(LoadLevel_FunctionAddress, "Path");
		LoadLevel_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadLevel_FunctionAddress, "Path", Classes.FStrProperty);
		LoadLevel_IsValid = LoadLevel_FunctionAddress != IntPtr.Zero && LoadLevel_Path_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:LoadLevel", LoadLevel_IsValid);
		IsUnderDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsUnderDirectory");
		IsUnderDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(IsUnderDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsUnderDirectory_InPath_PropertyAddress, IsUnderDirectory_FunctionAddress, "InPath");
		IsUnderDirectory_InPath_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderDirectory_FunctionAddress, "InPath");
		IsUnderDirectory_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderDirectory_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUnderDirectory_InDirectory_PropertyAddress, IsUnderDirectory_FunctionAddress, "InDirectory");
		IsUnderDirectory_InDirectory_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderDirectory_FunctionAddress, "InDirectory");
		IsUnderDirectory_InDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderDirectory_FunctionAddress, "InDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref IsUnderDirectory_ReturnValue_PropertyAddress, IsUnderDirectory_FunctionAddress, "ReturnValue");
		IsUnderDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsUnderDirectory_FunctionAddress, "ReturnValue");
		IsUnderDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsUnderDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsUnderDirectory_IsValid = IsUnderDirectory_FunctionAddress != IntPtr.Zero && IsUnderDirectory_InPath_IsValid && IsUnderDirectory_InDirectory_IsValid && IsUnderDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:IsUnderDirectory", IsUnderDirectory_IsValid);
		IsInEditorWithMoviePipelineQueue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsInEditorWithMoviePipelineQueue");
		IsInEditorWithMoviePipelineQueue_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInEditorWithMoviePipelineQueue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInEditorWithMoviePipelineQueue_ReturnValue_PropertyAddress, IsInEditorWithMoviePipelineQueue_FunctionAddress, "ReturnValue");
		IsInEditorWithMoviePipelineQueue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInEditorWithMoviePipelineQueue_FunctionAddress, "ReturnValue");
		IsInEditorWithMoviePipelineQueue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInEditorWithMoviePipelineQueue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInEditorWithMoviePipelineQueue_IsValid = IsInEditorWithMoviePipelineQueue_FunctionAddress != IntPtr.Zero && IsInEditorWithMoviePipelineQueue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:IsInEditorWithMoviePipelineQueue", IsInEditorWithMoviePipelineQueue_IsValid);
		IsCurrentPIEWorldContextInTick_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCurrentPIEWorldContextInTick");
		IsCurrentPIEWorldContextInTick_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCurrentPIEWorldContextInTick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentPIEWorldContextInTick_WorldContext_PropertyAddress, IsCurrentPIEWorldContextInTick_FunctionAddress, "WorldContext");
		IsCurrentPIEWorldContextInTick_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentPIEWorldContextInTick_FunctionAddress, "WorldContext");
		IsCurrentPIEWorldContextInTick_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentPIEWorldContextInTick_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentPIEWorldContextInTick_ReturnValue_PropertyAddress, IsCurrentPIEWorldContextInTick_FunctionAddress, "ReturnValue");
		IsCurrentPIEWorldContextInTick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentPIEWorldContextInTick_FunctionAddress, "ReturnValue");
		IsCurrentPIEWorldContextInTick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentPIEWorldContextInTick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCurrentPIEWorldContextInTick_IsValid = IsCurrentPIEWorldContextInTick_FunctionAddress != IntPtr.Zero && IsCurrentPIEWorldContextInTick_WorldContext_IsValid && IsCurrentPIEWorldContextInTick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentPIEWorldContextInTick", IsCurrentPIEWorldContextInTick_IsValid);
		IsCurrentEditorWorldContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCurrentEditorWorldContext");
		IsCurrentEditorWorldContext_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCurrentEditorWorldContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentEditorWorldContext_WorldContext_PropertyAddress, IsCurrentEditorWorldContext_FunctionAddress, "WorldContext");
		IsCurrentEditorWorldContext_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentEditorWorldContext_FunctionAddress, "WorldContext");
		IsCurrentEditorWorldContext_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentEditorWorldContext_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsCurrentEditorWorldContext_ReturnValue_PropertyAddress, IsCurrentEditorWorldContext_FunctionAddress, "ReturnValue");
		IsCurrentEditorWorldContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCurrentEditorWorldContext_FunctionAddress, "ReturnValue");
		IsCurrentEditorWorldContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCurrentEditorWorldContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCurrentEditorWorldContext_IsValid = IsCurrentEditorWorldContext_FunctionAddress != IntPtr.Zero && IsCurrentEditorWorldContext_WorldContext_IsValid && IsCurrentEditorWorldContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:IsCurrentEditorWorldContext", IsCurrentEditorWorldContext_IsValid);
		IsClassPlaceable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsClassPlaceable");
		IsClassPlaceable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsClassPlaceable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsClassPlaceable_AssetClass_PropertyAddress, IsClassPlaceable_FunctionAddress, "AssetClass");
		IsClassPlaceable_AssetClass_Offset = NativeReflectionCached.GetPropertyOffset(IsClassPlaceable_FunctionAddress, "AssetClass");
		IsClassPlaceable_AssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClassPlaceable_FunctionAddress, "AssetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref IsClassPlaceable_ReturnValue_PropertyAddress, IsClassPlaceable_FunctionAddress, "ReturnValue");
		IsClassPlaceable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsClassPlaceable_FunctionAddress, "ReturnValue");
		IsClassPlaceable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsClassPlaceable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsClassPlaceable_IsValid = IsClassPlaceable_FunctionAddress != IntPtr.Zero && IsClassPlaceable_AssetClass_IsValid && IsClassPlaceable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:IsClassPlaceable", IsClassPlaceable_IsValid);
		ImportCSVToStringTable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ImportCSVToStringTable");
		ImportCSVToStringTable_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportCSVToStringTable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportCSVToStringTable_TableID_PropertyAddress, ImportCSVToStringTable_FunctionAddress, "TableID");
		ImportCSVToStringTable_TableID_Offset = NativeReflectionCached.GetPropertyOffset(ImportCSVToStringTable_FunctionAddress, "TableID");
		ImportCSVToStringTable_TableID_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCSVToStringTable_FunctionAddress, "TableID", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportCSVToStringTable_CSVPath_PropertyAddress, ImportCSVToStringTable_FunctionAddress, "CSVPath");
		ImportCSVToStringTable_CSVPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportCSVToStringTable_FunctionAddress, "CSVPath");
		ImportCSVToStringTable_CSVPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportCSVToStringTable_FunctionAddress, "CSVPath", Classes.FStrProperty);
		ImportCSVToStringTable_IsValid = ImportCSVToStringTable_FunctionAddress != IntPtr.Zero && ImportCSVToStringTable_TableID_IsValid && ImportCSVToStringTable_CSVPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ImportCSVToStringTable", ImportCSVToStringTable_IsValid);
		HotReLoadCastMoudleChange_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HotReLoadCastMoudleChange");
		HotReLoadCastMoudleChange_ParamsSize = NativeReflection.GetFunctionParamsSize(HotReLoadCastMoudleChange_FunctionAddress);
		HotReLoadCastMoudleChange_IsValid = HotReLoadCastMoudleChange_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:HotReLoadCastMoudleChange", HotReLoadCastMoudleChange_IsValid);
		GetValidPostProcessVolumes_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetValidPostProcessVolumes");
		GetValidPostProcessVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValidPostProcessVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValidPostProcessVolumes_InWorld_PropertyAddress, GetValidPostProcessVolumes_FunctionAddress, "InWorld");
		GetValidPostProcessVolumes_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(GetValidPostProcessVolumes_FunctionAddress, "InWorld");
		GetValidPostProcessVolumes_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidPostProcessVolumes_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValidPostProcessVolumes_ReturnValue_PropertyAddress, GetValidPostProcessVolumes_FunctionAddress, "ReturnValue");
		GetValidPostProcessVolumes_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValidPostProcessVolumes_FunctionAddress, "ReturnValue");
		GetValidPostProcessVolumes_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValidPostProcessVolumes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetValidPostProcessVolumes_IsValid = GetValidPostProcessVolumes_FunctionAddress != IntPtr.Zero && GetValidPostProcessVolumes_InWorld_IsValid && GetValidPostProcessVolumes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetValidPostProcessVolumes", GetValidPostProcessVolumes_IsValid);
		GetSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedActors");
		GetSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedActors_OutActors_PropertyAddress, GetSelectedActors_FunctionAddress, "OutActors");
		GetSelectedActors_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedActors_FunctionAddress, "OutActors");
		GetSelectedActors_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedActors_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetSelectedActors_IsValid = GetSelectedActors_FunctionAddress != IntPtr.Zero && GetSelectedActors_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetSelectedActors", GetSelectedActors_IsValid);
		GetPersistentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPersistentLevel");
		GetPersistentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPersistentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPersistentLevel_World_PropertyAddress, GetPersistentLevel_FunctionAddress, "World");
		GetPersistentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(GetPersistentLevel_FunctionAddress, "World");
		GetPersistentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPersistentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPersistentLevel_ReturnValue_PropertyAddress, GetPersistentLevel_FunctionAddress, "ReturnValue");
		GetPersistentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPersistentLevel_FunctionAddress, "ReturnValue");
		GetPersistentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPersistentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPersistentLevel_IsValid = GetPersistentLevel_FunctionAddress != IntPtr.Zero && GetPersistentLevel_World_IsValid && GetPersistentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetPersistentLevel", GetPersistentLevel_IsValid);
		GetPackagesByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPackagesByName");
		GetPackagesByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPackagesByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPackagesByName_Name_PropertyAddress, GetPackagesByName_FunctionAddress, "Name");
		GetPackagesByName_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetPackagesByName_FunctionAddress, "Name");
		GetPackagesByName_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPackagesByName_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPackagesByName_OutPackageNames_PropertyAddress, GetPackagesByName_FunctionAddress, "OutPackageNames");
		GetPackagesByName_OutPackageNames_Offset = NativeReflectionCached.GetPropertyOffset(GetPackagesByName_FunctionAddress, "OutPackageNames");
		GetPackagesByName_OutPackageNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPackagesByName_FunctionAddress, "OutPackageNames", Classes.FArrayProperty);
		GetPackagesByName_IsValid = GetPackagesByName_FunctionAddress != IntPtr.Zero && GetPackagesByName_Name_IsValid && GetPackagesByName_OutPackageNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetPackagesByName", GetPackagesByName_IsValid);
		GetEditorWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEditorWorld");
		GetEditorWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEditorWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEditorWorld_ReturnValue_PropertyAddress, GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEditorWorld_FunctionAddress, "ReturnValue");
		GetEditorWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEditorWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetEditorWorld_IsValid = GetEditorWorld_FunctionAddress != IntPtr.Zero && GetEditorWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetEditorWorld", GetEditorWorld_IsValid);
		GetDirectoriesToAlwaysCook_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDirectoriesToAlwaysCook");
		GetDirectoriesToAlwaysCook_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDirectoriesToAlwaysCook_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDirectoriesToAlwaysCook_bConvertToLocalPath_PropertyAddress, GetDirectoriesToAlwaysCook_FunctionAddress, "bConvertToLocalPath");
		GetDirectoriesToAlwaysCook_bConvertToLocalPath_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectoriesToAlwaysCook_FunctionAddress, "bConvertToLocalPath");
		GetDirectoriesToAlwaysCook_bConvertToLocalPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectoriesToAlwaysCook_FunctionAddress, "bConvertToLocalPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDirectoriesToAlwaysCook_ReturnValue_PropertyAddress, GetDirectoriesToAlwaysCook_FunctionAddress, "ReturnValue");
		GetDirectoriesToAlwaysCook_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDirectoriesToAlwaysCook_FunctionAddress, "ReturnValue");
		GetDirectoriesToAlwaysCook_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDirectoriesToAlwaysCook_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetDirectoriesToAlwaysCook_IsValid = GetDirectoriesToAlwaysCook_FunctionAddress != IntPtr.Zero && GetDirectoriesToAlwaysCook_bConvertToLocalPath_IsValid && GetDirectoriesToAlwaysCook_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetDirectoriesToAlwaysCook", GetDirectoriesToAlwaysCook_IsValid);
		GetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentLevel");
		GetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLevel_World_PropertyAddress, GetCurrentLevel_FunctionAddress, "World");
		GetCurrentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLevel_FunctionAddress, "World");
		GetCurrentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentLevel_ReturnValue_PropertyAddress, GetCurrentLevel_FunctionAddress, "ReturnValue");
		GetCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentLevel_FunctionAddress, "ReturnValue");
		GetCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentLevel_IsValid = GetCurrentLevel_FunctionAddress != IntPtr.Zero && GetCurrentLevel_World_IsValid && GetCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentLevel", GetCurrentLevel_IsValid);
		GetCurrentGWorldType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentGWorldType");
		GetCurrentGWorldType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentGWorldType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentGWorldType_ReturnValue_PropertyAddress, GetCurrentGWorldType_FunctionAddress, "ReturnValue");
		GetCurrentGWorldType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentGWorldType_FunctionAddress, "ReturnValue");
		GetCurrentGWorldType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentGWorldType_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentGWorldType_IsValid = GetCurrentGWorldType_FunctionAddress != IntPtr.Zero && GetCurrentGWorldType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentGWorldType", GetCurrentGWorldType_IsValid);
		GetCurrentEditingWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentEditingWorld");
		GetCurrentEditingWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentEditingWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentEditingWorld_ReturnValue_PropertyAddress, GetCurrentEditingWorld_FunctionAddress, "ReturnValue");
		GetCurrentEditingWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentEditingWorld_FunctionAddress, "ReturnValue");
		GetCurrentEditingWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentEditingWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentEditingWorld_IsValid = GetCurrentEditingWorld_FunctionAddress != IntPtr.Zero && GetCurrentEditingWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetCurrentEditingWorld", GetCurrentEditingWorld_IsValid);
		GetContentBrowserSelections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetContentBrowserSelections");
		GetContentBrowserSelections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContentBrowserSelections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContentBrowserSelections_ReturnValue_PropertyAddress, GetContentBrowserSelections_FunctionAddress, "ReturnValue");
		GetContentBrowserSelections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContentBrowserSelections_FunctionAddress, "ReturnValue");
		GetContentBrowserSelections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContentBrowserSelections_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetContentBrowserSelections_IsValid = GetContentBrowserSelections_FunctionAddress != IntPtr.Zero && GetContentBrowserSelections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetContentBrowserSelections", GetContentBrowserSelections_IsValid);
		GetCDONodeComponents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCDONodeComponents");
		GetCDONodeComponents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCDONodeComponents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCDONodeComponents_CDO_PropertyAddress, GetCDONodeComponents_FunctionAddress, "CDO");
		GetCDONodeComponents_CDO_Offset = NativeReflectionCached.GetPropertyOffset(GetCDONodeComponents_FunctionAddress, "CDO");
		GetCDONodeComponents_CDO_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDONodeComponents_FunctionAddress, "CDO", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCDONodeComponents_ReturnValue_PropertyAddress, GetCDONodeComponents_FunctionAddress, "ReturnValue");
		GetCDONodeComponents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCDONodeComponents_FunctionAddress, "ReturnValue");
		GetCDONodeComponents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCDONodeComponents_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetCDONodeComponents_IsValid = GetCDONodeComponents_FunctionAddress != IntPtr.Zero && GetCDONodeComponents_CDO_IsValid && GetCDONodeComponents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetCDONodeComponents", GetCDONodeComponents_IsValid);
		GetBrushBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBrushBounds");
		GetBrushBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBrushBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBrushBounds_BrushCom_PropertyAddress, GetBrushBounds_FunctionAddress, "BrushCom");
		GetBrushBounds_BrushCom_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushBounds_FunctionAddress, "BrushCom");
		GetBrushBounds_BrushCom_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushBounds_FunctionAddress, "BrushCom", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBrushBounds_ReturnValue_PropertyAddress, GetBrushBounds_FunctionAddress, "ReturnValue");
		GetBrushBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBrushBounds_FunctionAddress, "ReturnValue");
		GetBrushBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBrushBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBrushBounds_IsValid = GetBrushBounds_FunctionAddress != IntPtr.Zero && GetBrushBounds_BrushCom_IsValid && GetBrushBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetBrushBounds", GetBrushBounds_IsValid);
		GetAssetDependencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDependencies");
		GetAssetDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDependencies_PackageName_PropertyAddress, GetAssetDependencies_FunctionAddress, "PackageName");
		GetAssetDependencies_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDependencies_FunctionAddress, "PackageName");
		GetAssetDependencies_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDependencies_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDependencies_ReturnValue_PropertyAddress, GetAssetDependencies_FunctionAddress, "ReturnValue");
		GetAssetDependencies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDependencies_FunctionAddress, "ReturnValue");
		GetAssetDependencies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDependencies_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAssetDependencies_IsValid = GetAssetDependencies_FunctionAddress != IntPtr.Zero && GetAssetDependencies_PackageName_IsValid && GetAssetDependencies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetAssetDependencies", GetAssetDependencies_IsValid);
		GetAllLevelActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllLevelActors");
		GetAllLevelActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllLevelActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllLevelActors_ReturnValue_PropertyAddress, GetAllLevelActors_FunctionAddress, "ReturnValue");
		GetAllLevelActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllLevelActors_FunctionAddress, "ReturnValue");
		GetAllLevelActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllLevelActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllLevelActors_IsValid = GetAllLevelActors_FunctionAddress != IntPtr.Zero && GetAllLevelActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GetAllLevelActors", GetAllLevelActors_IsValid);
		GenerateNaviMeshBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateNaviMeshBounds");
		GenerateNaviMeshBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateNaviMeshBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaviMeshBounds_Anchor_PropertyAddress, GenerateNaviMeshBounds_FunctionAddress, "Anchor");
		GenerateNaviMeshBounds_Anchor_Offset = NativeReflectionCached.GetPropertyOffset(GenerateNaviMeshBounds_FunctionAddress, "Anchor");
		GenerateNaviMeshBounds_Anchor_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateNaviMeshBounds_FunctionAddress, "Anchor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaviMeshBounds_ScaleX_PropertyAddress, GenerateNaviMeshBounds_FunctionAddress, "ScaleX");
		GenerateNaviMeshBounds_ScaleX_Offset = NativeReflectionCached.GetPropertyOffset(GenerateNaviMeshBounds_FunctionAddress, "ScaleX");
		GenerateNaviMeshBounds_ScaleX_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateNaviMeshBounds_FunctionAddress, "ScaleX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaviMeshBounds_ScaleY_PropertyAddress, GenerateNaviMeshBounds_FunctionAddress, "ScaleY");
		GenerateNaviMeshBounds_ScaleY_Offset = NativeReflectionCached.GetPropertyOffset(GenerateNaviMeshBounds_FunctionAddress, "ScaleY");
		GenerateNaviMeshBounds_ScaleY_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateNaviMeshBounds_FunctionAddress, "ScaleY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaviMeshBounds_ScaleZ_PropertyAddress, GenerateNaviMeshBounds_FunctionAddress, "ScaleZ");
		GenerateNaviMeshBounds_ScaleZ_Offset = NativeReflectionCached.GetPropertyOffset(GenerateNaviMeshBounds_FunctionAddress, "ScaleZ");
		GenerateNaviMeshBounds_ScaleZ_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateNaviMeshBounds_FunctionAddress, "ScaleZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateNaviMeshBounds_DuplicateBase_PropertyAddress, GenerateNaviMeshBounds_FunctionAddress, "DuplicateBase");
		GenerateNaviMeshBounds_DuplicateBase_Offset = NativeReflectionCached.GetPropertyOffset(GenerateNaviMeshBounds_FunctionAddress, "DuplicateBase");
		GenerateNaviMeshBounds_DuplicateBase_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateNaviMeshBounds_FunctionAddress, "DuplicateBase", Classes.FObjectProperty);
		GenerateNaviMeshBounds_IsValid = GenerateNaviMeshBounds_FunctionAddress != IntPtr.Zero && GenerateNaviMeshBounds_Anchor_IsValid && GenerateNaviMeshBounds_ScaleX_IsValid && GenerateNaviMeshBounds_ScaleY_IsValid && GenerateNaviMeshBounds_ScaleZ_IsValid && GenerateNaviMeshBounds_DuplicateBase_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GenerateNaviMeshBounds", GenerateNaviMeshBounds_IsValid);
		GatherText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GatherText");
		GatherText_ParamsSize = NativeReflection.GetFunctionParamsSize(GatherText_FunctionAddress);
		GatherText_IsValid = GatherText_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:GatherText", GatherText_IsValid);
		FAssetData_GetTagValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FAssetData_GetTagValue");
		FAssetData_GetTagValue_ParamsSize = NativeReflection.GetFunctionParamsSize(FAssetData_GetTagValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetTagValue_AssetData_PropertyAddress, FAssetData_GetTagValue_FunctionAddress, "AssetData");
		FAssetData_GetTagValue_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetTagValue_FunctionAddress, "AssetData");
		FAssetData_GetTagValue_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetTagValue_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetTagValue_TagName_PropertyAddress, FAssetData_GetTagValue_FunctionAddress, "TagName");
		FAssetData_GetTagValue_TagName_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetTagValue_FunctionAddress, "TagName");
		FAssetData_GetTagValue_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetTagValue_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetTagValue_ReturnValue_PropertyAddress, FAssetData_GetTagValue_FunctionAddress, "ReturnValue");
		FAssetData_GetTagValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetTagValue_FunctionAddress, "ReturnValue");
		FAssetData_GetTagValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetTagValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FAssetData_GetTagValue_IsValid = FAssetData_GetTagValue_FunctionAddress != IntPtr.Zero && FAssetData_GetTagValue_AssetData_IsValid && FAssetData_GetTagValue_TagName_IsValid && FAssetData_GetTagValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetTagValue", FAssetData_GetTagValue_IsValid);
		FAssetData_GetClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FAssetData_GetClass");
		FAssetData_GetClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FAssetData_GetClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetClass_AssetData_PropertyAddress, FAssetData_GetClass_FunctionAddress, "AssetData");
		FAssetData_GetClass_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetClass_FunctionAddress, "AssetData");
		FAssetData_GetClass_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetClass_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetClass_ReturnValue_PropertyAddress, FAssetData_GetClass_FunctionAddress, "ReturnValue");
		FAssetData_GetClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetClass_FunctionAddress, "ReturnValue");
		FAssetData_GetClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		FAssetData_GetClass_IsValid = FAssetData_GetClass_FunctionAddress != IntPtr.Zero && FAssetData_GetClass_AssetData_IsValid && FAssetData_GetClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetClass", FAssetData_GetClass_IsValid);
		FAssetData_GetAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FAssetData_GetAsset");
		FAssetData_GetAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(FAssetData_GetAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetAsset_AssetData_PropertyAddress, FAssetData_GetAsset_FunctionAddress, "AssetData");
		FAssetData_GetAsset_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetAsset_FunctionAddress, "AssetData");
		FAssetData_GetAsset_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetAsset_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FAssetData_GetAsset_ReturnValue_PropertyAddress, FAssetData_GetAsset_FunctionAddress, "ReturnValue");
		FAssetData_GetAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FAssetData_GetAsset_FunctionAddress, "ReturnValue");
		FAssetData_GetAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FAssetData_GetAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FAssetData_GetAsset_IsValid = FAssetData_GetAsset_FunctionAddress != IntPtr.Zero && FAssetData_GetAsset_AssetData_IsValid && FAssetData_GetAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:FAssetData_GetAsset", FAssetData_GetAsset_IsValid);
		ExportToolSelectNone_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportToolSelectNone");
		ExportToolSelectNone_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToolSelectNone_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportToolSelectNone_bNoteSelectionChange_PropertyAddress, ExportToolSelectNone_FunctionAddress, "bNoteSelectionChange");
		ExportToolSelectNone_bNoteSelectionChange_Offset = NativeReflectionCached.GetPropertyOffset(ExportToolSelectNone_FunctionAddress, "bNoteSelectionChange");
		ExportToolSelectNone_bNoteSelectionChange_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToolSelectNone_FunctionAddress, "bNoteSelectionChange", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportToolSelectNone_bDeselectBSPSurfs_PropertyAddress, ExportToolSelectNone_FunctionAddress, "bDeselectBSPSurfs");
		ExportToolSelectNone_bDeselectBSPSurfs_Offset = NativeReflectionCached.GetPropertyOffset(ExportToolSelectNone_FunctionAddress, "bDeselectBSPSurfs");
		ExportToolSelectNone_bDeselectBSPSurfs_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToolSelectNone_FunctionAddress, "bDeselectBSPSurfs", Classes.FBoolProperty);
		ExportToolSelectNone_IsValid = ExportToolSelectNone_FunctionAddress != IntPtr.Zero && ExportToolSelectNone_bNoteSelectionChange_IsValid && ExportToolSelectNone_bDeselectBSPSurfs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectNone", ExportToolSelectNone_IsValid);
		ExportToolSelectActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportToolSelectActor");
		ExportToolSelectActor_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToolSelectActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportToolSelectActor_TargetActor_PropertyAddress, ExportToolSelectActor_FunctionAddress, "TargetActor");
		ExportToolSelectActor_TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(ExportToolSelectActor_FunctionAddress, "TargetActor");
		ExportToolSelectActor_TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToolSelectActor_FunctionAddress, "TargetActor", Classes.FObjectProperty);
		ExportToolSelectActor_IsValid = ExportToolSelectActor_FunctionAddress != IntPtr.Zero && ExportToolSelectActor_TargetActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ExportToolSelectActor", ExportToolSelectActor_IsValid);
		EditObjectByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EditObjectByName");
		EditObjectByName_ParamsSize = NativeReflection.GetFunctionParamsSize(EditObjectByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditObjectByName_PackageName_PropertyAddress, EditObjectByName_FunctionAddress, "PackageName");
		EditObjectByName_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(EditObjectByName_FunctionAddress, "PackageName");
		EditObjectByName_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(EditObjectByName_FunctionAddress, "PackageName", Classes.FStrProperty);
		EditObjectByName_IsValid = EditObjectByName_FunctionAddress != IntPtr.Zero && EditObjectByName_PackageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:EditObjectByName", EditObjectByName_IsValid);
		EditObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EditObject");
		EditObject_ParamsSize = NativeReflection.GetFunctionParamsSize(EditObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EditObject_ObjectToEdit_PropertyAddress, EditObject_FunctionAddress, "ObjectToEdit");
		EditObject_ObjectToEdit_Offset = NativeReflectionCached.GetPropertyOffset(EditObject_FunctionAddress, "ObjectToEdit");
		EditObject_ObjectToEdit_IsValid = NativeReflectionCached.ValidatePropertyClass(EditObject_FunctionAddress, "ObjectToEdit", Classes.FObjectProperty);
		EditObject_IsValid = EditObject_FunctionAddress != IntPtr.Zero && EditObject_ObjectToEdit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:EditObject", EditObject_IsValid);
		DuplicateWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateWorld");
		DuplicateWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateWorld_TempleteWorld_PropertyAddress, DuplicateWorld_FunctionAddress, "TempleteWorld");
		DuplicateWorld_TempleteWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateWorld_FunctionAddress, "TempleteWorld");
		DuplicateWorld_TempleteWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateWorld_FunctionAddress, "TempleteWorld", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateWorld_PackageName_PropertyAddress, DuplicateWorld_FunctionAddress, "PackageName");
		DuplicateWorld_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateWorld_FunctionAddress, "PackageName");
		DuplicateWorld_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateWorld_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateWorld_ObjectName_PropertyAddress, DuplicateWorld_FunctionAddress, "ObjectName");
		DuplicateWorld_ObjectName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateWorld_FunctionAddress, "ObjectName");
		DuplicateWorld_ObjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateWorld_FunctionAddress, "ObjectName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateWorld_ReturnValue_PropertyAddress, DuplicateWorld_FunctionAddress, "ReturnValue");
		DuplicateWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateWorld_FunctionAddress, "ReturnValue");
		DuplicateWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateWorld_IsValid = DuplicateWorld_FunctionAddress != IntPtr.Zero && DuplicateWorld_TempleteWorld_IsValid && DuplicateWorld_PackageName_IsValid && DuplicateWorld_ObjectName_IsValid && DuplicateWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateWorld", DuplicateWorld_IsValid);
		DuplicateActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateActor");
		DuplicateActor_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_ActorToDuplicate_PropertyAddress, DuplicateActor_FunctionAddress, "ActorToDuplicate");
		DuplicateActor_ActorToDuplicate_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "ActorToDuplicate");
		DuplicateActor_ActorToDuplicate_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "ActorToDuplicate", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_InLevel_PropertyAddress, DuplicateActor_FunctionAddress, "InLevel");
		DuplicateActor_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "InLevel");
		DuplicateActor_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "InLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_Offset_PropertyAddress, DuplicateActor_FunctionAddress, "Offset");
		DuplicateActor_Offset_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "Offset");
		DuplicateActor_Offset_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "Offset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateActor_ReturnValue_PropertyAddress, DuplicateActor_FunctionAddress, "ReturnValue");
		DuplicateActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateActor_FunctionAddress, "ReturnValue");
		DuplicateActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateActor_IsValid = DuplicateActor_FunctionAddress != IntPtr.Zero && DuplicateActor_ActorToDuplicate_IsValid && DuplicateActor_InLevel_IsValid && DuplicateActor_Offset_IsValid && DuplicateActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DuplicateActor", DuplicateActor_IsValid);
		DeleteObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteObject");
		DeleteObject_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteObject_ObjectToDelete_PropertyAddress, DeleteObject_FunctionAddress, "ObjectToDelete");
		DeleteObject_ObjectToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObject_FunctionAddress, "ObjectToDelete");
		DeleteObject_ObjectToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObject_FunctionAddress, "ObjectToDelete", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteObject_ShowConfirm_PropertyAddress, DeleteObject_FunctionAddress, "ShowConfirm");
		DeleteObject_ShowConfirm_Offset = NativeReflectionCached.GetPropertyOffset(DeleteObject_FunctionAddress, "ShowConfirm");
		DeleteObject_ShowConfirm_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteObject_FunctionAddress, "ShowConfirm", Classes.FBoolProperty);
		DeleteObject_IsValid = DeleteObject_FunctionAddress != IntPtr.Zero && DeleteObject_ObjectToDelete_IsValid && DeleteObject_ShowConfirm_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteObject", DeleteObject_IsValid);
		DeleteActors_WithVerify_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteActors_WithVerify");
		DeleteActors_WithVerify_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteActors_WithVerify_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_WithVerify_InActorsToDelete_PropertyAddress, DeleteActors_WithVerify_FunctionAddress, "InActorsToDelete");
		DeleteActors_WithVerify_InActorsToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_WithVerify_FunctionAddress, "InActorsToDelete");
		DeleteActors_WithVerify_InActorsToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_WithVerify_FunctionAddress, "InActorsToDelete", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_WithVerify_InWorld_PropertyAddress, DeleteActors_WithVerify_FunctionAddress, "InWorld");
		DeleteActors_WithVerify_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_WithVerify_FunctionAddress, "InWorld");
		DeleteActors_WithVerify_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_WithVerify_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_WithVerify_bVerifyDeletionCanHappen_PropertyAddress, DeleteActors_WithVerify_FunctionAddress, "bVerifyDeletionCanHappen");
		DeleteActors_WithVerify_bVerifyDeletionCanHappen_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_WithVerify_FunctionAddress, "bVerifyDeletionCanHappen");
		DeleteActors_WithVerify_bVerifyDeletionCanHappen_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_WithVerify_FunctionAddress, "bVerifyDeletionCanHappen", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_WithVerify_bWarnAboutReferences_PropertyAddress, DeleteActors_WithVerify_FunctionAddress, "bWarnAboutReferences");
		DeleteActors_WithVerify_bWarnAboutReferences_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_WithVerify_FunctionAddress, "bWarnAboutReferences");
		DeleteActors_WithVerify_bWarnAboutReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_WithVerify_FunctionAddress, "bWarnAboutReferences", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_WithVerify_bWarnAboutSoftReferences_PropertyAddress, DeleteActors_WithVerify_FunctionAddress, "bWarnAboutSoftReferences");
		DeleteActors_WithVerify_bWarnAboutSoftReferences_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_WithVerify_FunctionAddress, "bWarnAboutSoftReferences");
		DeleteActors_WithVerify_bWarnAboutSoftReferences_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_WithVerify_FunctionAddress, "bWarnAboutSoftReferences", Classes.FBoolProperty);
		DeleteActors_WithVerify_IsValid = DeleteActors_WithVerify_FunctionAddress != IntPtr.Zero && DeleteActors_WithVerify_InActorsToDelete_IsValid && DeleteActors_WithVerify_InWorld_IsValid && DeleteActors_WithVerify_bVerifyDeletionCanHappen_IsValid && DeleteActors_WithVerify_bWarnAboutReferences_IsValid && DeleteActors_WithVerify_bWarnAboutSoftReferences_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors_WithVerify", DeleteActors_WithVerify_IsValid);
		DeleteActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteActors");
		DeleteActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_InActorsToDelete_PropertyAddress, DeleteActors_FunctionAddress, "InActorsToDelete");
		DeleteActors_InActorsToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_FunctionAddress, "InActorsToDelete");
		DeleteActors_InActorsToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_FunctionAddress, "InActorsToDelete", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteActors_InWorld_PropertyAddress, DeleteActors_FunctionAddress, "InWorld");
		DeleteActors_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DeleteActors_FunctionAddress, "InWorld");
		DeleteActors_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteActors_FunctionAddress, "InWorld", Classes.FObjectProperty);
		DeleteActors_IsValid = DeleteActors_FunctionAddress != IntPtr.Zero && DeleteActors_InActorsToDelete_IsValid && DeleteActors_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DeleteActors", DeleteActors_IsValid);
		DebugRoomCreateLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DebugRoomCreateLevel");
		DebugRoomCreateLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(DebugRoomCreateLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_MainWorld_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "MainWorld");
		DebugRoomCreateLevel_MainWorld_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "MainWorld");
		DebugRoomCreateLevel_MainWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "MainWorld", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_TempleteWorld_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "TempleteWorld");
		DebugRoomCreateLevel_TempleteWorld_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "TempleteWorld");
		DebugRoomCreateLevel_TempleteWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "TempleteWorld", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_PackageName_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "PackageName");
		DebugRoomCreateLevel_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "PackageName");
		DebugRoomCreateLevel_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "PackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_ObjectName_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "ObjectName");
		DebugRoomCreateLevel_ObjectName_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "ObjectName");
		DebugRoomCreateLevel_ObjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "ObjectName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_ChineseName_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "ChineseName");
		DebugRoomCreateLevel_ChineseName_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "ChineseName");
		DebugRoomCreateLevel_ChineseName_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "ChineseName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DebugRoomCreateLevel_NewWorldTrans_PropertyAddress, DebugRoomCreateLevel_FunctionAddress, "NewWorldTrans");
		DebugRoomCreateLevel_NewWorldTrans_Offset = NativeReflectionCached.GetPropertyOffset(DebugRoomCreateLevel_FunctionAddress, "NewWorldTrans");
		DebugRoomCreateLevel_NewWorldTrans_IsValid = NativeReflectionCached.ValidatePropertyClass(DebugRoomCreateLevel_FunctionAddress, "NewWorldTrans", Classes.FStructProperty);
		DebugRoomCreateLevel_IsValid = DebugRoomCreateLevel_FunctionAddress != IntPtr.Zero && DebugRoomCreateLevel_MainWorld_IsValid && DebugRoomCreateLevel_TempleteWorld_IsValid && DebugRoomCreateLevel_PackageName_IsValid && DebugRoomCreateLevel_ObjectName_IsValid && DebugRoomCreateLevel_ChineseName_IsValid && DebugRoomCreateLevel_NewWorldTrans_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:DebugRoomCreateLevel", DebugRoomCreateLevel_IsValid);
		CopyComponentsToClipBoard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyComponentsToClipBoard");
		CopyComponentsToClipBoard_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyComponentsToClipBoard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyComponentsToClipBoard_ComponentsToCopy_PropertyAddress, CopyComponentsToClipBoard_FunctionAddress, "ComponentsToCopy");
		CopyComponentsToClipBoard_ComponentsToCopy_Offset = NativeReflectionCached.GetPropertyOffset(CopyComponentsToClipBoard_FunctionAddress, "ComponentsToCopy");
		CopyComponentsToClipBoard_ComponentsToCopy_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyComponentsToClipBoard_FunctionAddress, "ComponentsToCopy", Classes.FArrayProperty);
		CopyComponentsToClipBoard_IsValid = CopyComponentsToClipBoard_FunctionAddress != IntPtr.Zero && CopyComponentsToClipBoard_ComponentsToCopy_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:CopyComponentsToClipBoard", CopyComponentsToClipBoard_IsValid);
		CompileText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CompileText");
		CompileText_ParamsSize = NativeReflection.GetFunctionParamsSize(CompileText_FunctionAddress);
		CompileText_IsValid = CompileText_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:CompileText", CompileText_IsValid);
		CheckAssetHasScriptBlueprint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckAssetHasScriptBlueprint");
		CheckAssetHasScriptBlueprint_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckAssetHasScriptBlueprint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckAssetHasScriptBlueprint_Asset_PropertyAddress, CheckAssetHasScriptBlueprint_FunctionAddress, "Asset");
		CheckAssetHasScriptBlueprint_Asset_Offset = NativeReflectionCached.GetPropertyOffset(CheckAssetHasScriptBlueprint_FunctionAddress, "Asset");
		CheckAssetHasScriptBlueprint_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckAssetHasScriptBlueprint_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckAssetHasScriptBlueprint_ReturnValue_PropertyAddress, CheckAssetHasScriptBlueprint_FunctionAddress, "ReturnValue");
		CheckAssetHasScriptBlueprint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckAssetHasScriptBlueprint_FunctionAddress, "ReturnValue");
		CheckAssetHasScriptBlueprint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckAssetHasScriptBlueprint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckAssetHasScriptBlueprint_IsValid = CheckAssetHasScriptBlueprint_FunctionAddress != IntPtr.Zero && CheckAssetHasScriptBlueprint_Asset_IsValid && CheckAssetHasScriptBlueprint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:CheckAssetHasScriptBlueprint", CheckAssetHasScriptBlueprint_IsValid);
		CheckActorBoundsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckActorBoundsInfo");
		CheckActorBoundsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckActorBoundsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckActorBoundsInfo_InActor_PropertyAddress, CheckActorBoundsInfo_FunctionAddress, "InActor");
		CheckActorBoundsInfo_InActor_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorBoundsInfo_FunctionAddress, "InActor");
		CheckActorBoundsInfo_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorBoundsInfo_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorBoundsInfo_bIncludeNonCollision_PropertyAddress, CheckActorBoundsInfo_FunctionAddress, "bIncludeNonCollision");
		CheckActorBoundsInfo_bIncludeNonCollision_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorBoundsInfo_FunctionAddress, "bIncludeNonCollision");
		CheckActorBoundsInfo_bIncludeNonCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorBoundsInfo_FunctionAddress, "bIncludeNonCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorBoundsInfo_OutActorLevelBoundsRelevant_PropertyAddress, CheckActorBoundsInfo_FunctionAddress, "OutActorLevelBoundsRelevant");
		CheckActorBoundsInfo_OutActorLevelBoundsRelevant_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorBoundsInfo_FunctionAddress, "OutActorLevelBoundsRelevant");
		CheckActorBoundsInfo_OutActorLevelBoundsRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorBoundsInfo_FunctionAddress, "OutActorLevelBoundsRelevant", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorBoundsInfo_OutActorBounds_PropertyAddress, CheckActorBoundsInfo_FunctionAddress, "OutActorBounds");
		CheckActorBoundsInfo_OutActorBounds_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorBoundsInfo_FunctionAddress, "OutActorBounds");
		CheckActorBoundsInfo_OutActorBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorBoundsInfo_FunctionAddress, "OutActorBounds", Classes.FStructProperty);
		CheckActorBoundsInfo_IsValid = CheckActorBoundsInfo_FunctionAddress != IntPtr.Zero && CheckActorBoundsInfo_InActor_IsValid && CheckActorBoundsInfo_bIncludeNonCollision_IsValid && CheckActorBoundsInfo_OutActorLevelBoundsRelevant_IsValid && CheckActorBoundsInfo_OutActorBounds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:CheckActorBoundsInfo", CheckActorBoundsInfo_IsValid);
		BGULandscapeCameraCollsion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGULandscapeCameraCollsion");
		BGULandscapeCameraCollsion_ParamsSize = NativeReflection.GetFunctionParamsSize(BGULandscapeCameraCollsion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_WorldContextObject_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "WorldContextObject");
		BGULandscapeCameraCollsion_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "WorldContextObject");
		BGULandscapeCameraCollsion_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_SurfaceType_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "SurfaceType");
		BGULandscapeCameraCollsion_SurfaceType_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "SurfaceType");
		BGULandscapeCameraCollsion_SurfaceType_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "SurfaceType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_cellSize_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "cellSize");
		BGULandscapeCameraCollsion_cellSize_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "cellSize");
		BGULandscapeCameraCollsion_cellSize_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "cellSize", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_MaxHeightOffset_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "MaxHeightOffset");
		BGULandscapeCameraCollsion_MaxHeightOffset_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "MaxHeightOffset");
		BGULandscapeCameraCollsion_MaxHeightOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "MaxHeightOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_MaxDisplacement_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "MaxDisplacement");
		BGULandscapeCameraCollsion_MaxDisplacement_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "MaxDisplacement");
		BGULandscapeCameraCollsion_MaxDisplacement_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "MaxDisplacement", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULandscapeCameraCollsion_CameraCollisionOffset_PropertyAddress, BGULandscapeCameraCollsion_FunctionAddress, "CameraCollisionOffset");
		BGULandscapeCameraCollsion_CameraCollisionOffset_Offset = NativeReflectionCached.GetPropertyOffset(BGULandscapeCameraCollsion_FunctionAddress, "CameraCollisionOffset");
		BGULandscapeCameraCollsion_CameraCollisionOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULandscapeCameraCollsion_FunctionAddress, "CameraCollisionOffset", Classes.FFloatProperty);
		BGULandscapeCameraCollsion_IsValid = BGULandscapeCameraCollsion_FunctionAddress != IntPtr.Zero && BGULandscapeCameraCollsion_WorldContextObject_IsValid && BGULandscapeCameraCollsion_SurfaceType_IsValid && BGULandscapeCameraCollsion_cellSize_IsValid && BGULandscapeCameraCollsion_MaxHeightOffset_IsValid && BGULandscapeCameraCollsion_MaxDisplacement_IsValid && BGULandscapeCameraCollsion_CameraCollisionOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:BGULandscapeCameraCollsion", BGULandscapeCameraCollsion_IsValid);
		BGUGetStaticMeshComp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetStaticMeshComp");
		BGUGetStaticMeshComp_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetStaticMeshComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetStaticMeshComp_Actor_PropertyAddress, BGUGetStaticMeshComp_FunctionAddress, "Actor");
		BGUGetStaticMeshComp_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetStaticMeshComp_FunctionAddress, "Actor");
		BGUGetStaticMeshComp_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetStaticMeshComp_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetStaticMeshComp_ReturnValue_PropertyAddress, BGUGetStaticMeshComp_FunctionAddress, "ReturnValue");
		BGUGetStaticMeshComp_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetStaticMeshComp_FunctionAddress, "ReturnValue");
		BGUGetStaticMeshComp_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetStaticMeshComp_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetStaticMeshComp_IsValid = BGUGetStaticMeshComp_FunctionAddress != IntPtr.Zero && BGUGetStaticMeshComp_Actor_IsValid && BGUGetStaticMeshComp_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:BGUGetStaticMeshComp", BGUGetStaticMeshComp_IsValid);
		AssetPath_GetCDO_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AssetPath_GetCDO");
		AssetPath_GetCDO_ParamsSize = NativeReflection.GetFunctionParamsSize(AssetPath_GetCDO_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssetPath_GetCDO_Outer_PropertyAddress, AssetPath_GetCDO_FunctionAddress, "Outer");
		AssetPath_GetCDO_Outer_Offset = NativeReflectionCached.GetPropertyOffset(AssetPath_GetCDO_FunctionAddress, "Outer");
		AssetPath_GetCDO_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetPath_GetCDO_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetPath_GetCDO_Path_PropertyAddress, AssetPath_GetCDO_FunctionAddress, "Path");
		AssetPath_GetCDO_Path_Offset = NativeReflectionCached.GetPropertyOffset(AssetPath_GetCDO_FunctionAddress, "Path");
		AssetPath_GetCDO_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetPath_GetCDO_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetPath_GetCDO_Blueprint_PropertyAddress, AssetPath_GetCDO_FunctionAddress, "Blueprint");
		AssetPath_GetCDO_Blueprint_Offset = NativeReflectionCached.GetPropertyOffset(AssetPath_GetCDO_FunctionAddress, "Blueprint");
		AssetPath_GetCDO_Blueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetPath_GetCDO_FunctionAddress, "Blueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AssetPath_GetCDO_ReturnValue_PropertyAddress, AssetPath_GetCDO_FunctionAddress, "ReturnValue");
		AssetPath_GetCDO_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AssetPath_GetCDO_FunctionAddress, "ReturnValue");
		AssetPath_GetCDO_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AssetPath_GetCDO_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AssetPath_GetCDO_IsValid = AssetPath_GetCDO_FunctionAddress != IntPtr.Zero && AssetPath_GetCDO_Outer_IsValid && AssetPath_GetCDO_Path_IsValid && AssetPath_GetCDO_Blueprint_IsValid && AssetPath_GetCDO_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:AssetPath_GetCDO", AssetPath_GetCDO_IsValid);
		ActorRename_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ActorRename");
		ActorRename_ParamsSize = NativeReflection.GetFunctionParamsSize(ActorRename_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ActorRename_Actor_PropertyAddress, ActorRename_FunctionAddress, "Actor");
		ActorRename_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ActorRename_FunctionAddress, "Actor");
		ActorRename_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorRename_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorRename_NewName_PropertyAddress, ActorRename_FunctionAddress, "NewName");
		ActorRename_NewName_Offset = NativeReflectionCached.GetPropertyOffset(ActorRename_FunctionAddress, "NewName");
		ActorRename_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(ActorRename_FunctionAddress, "NewName", Classes.FStrProperty);
		ActorRename_IsValid = ActorRename_FunctionAddress != IntPtr.Zero && ActorRename_Actor_IsValid && ActorRename_NewName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_EditorFuncLib:ActorRename", ActorRename_IsValid);
	}
}

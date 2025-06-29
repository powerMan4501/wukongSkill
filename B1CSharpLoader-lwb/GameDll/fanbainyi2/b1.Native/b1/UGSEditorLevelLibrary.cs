using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Foliage;
using UnrealEngine.Landscape;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorLevelLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WorldGetCurrentLevel_IsValid;

	private static IntPtr WorldGetCurrentLevel_FunctionAddress;

	private static int WorldGetCurrentLevel_ParamsSize;

	private static bool WorldGetCurrentLevel_World_IsValid;

	private static FFieldAddress WorldGetCurrentLevel_World_PropertyAddress;

	private static int WorldGetCurrentLevel_World_Offset;

	private static bool WorldGetCurrentLevel_ReturnValue_IsValid;

	private static FFieldAddress WorldGetCurrentLevel_ReturnValue_PropertyAddress;

	private static int WorldGetCurrentLevel_ReturnValue_Offset;

	private static bool UpdateSubLevelBounds_IsValid;

	private static IntPtr UpdateSubLevelBounds_FunctionAddress;

	private static int UpdateSubLevelBounds_ParamsSize;

	private static bool UpdateSubLevelBounds_RootDirectory_IsValid;

	private static FFieldAddress UpdateSubLevelBounds_RootDirectory_PropertyAddress;

	private static int UpdateSubLevelBounds_RootDirectory_Offset;

	private static bool UpdateLevelBound_IsValid;

	private static IntPtr UpdateLevelBound_FunctionAddress;

	private static int UpdateLevelBound_ParamsSize;

	private static bool UpdateLevelBound_InLevelBound_IsValid;

	private static FFieldAddress UpdateLevelBound_InLevelBound_PropertyAddress;

	private static int UpdateLevelBound_InLevelBound_Offset;

	private static bool UpdateAllLevelBounds_IsValid;

	private static IntPtr UpdateAllLevelBounds_FunctionAddress;

	private static int UpdateAllLevelBounds_ParamsSize;

	private static bool UpdateAllLevelBounds_RootDirectory_IsValid;

	private static FFieldAddress UpdateAllLevelBounds_RootDirectory_PropertyAddress;

	private static int UpdateAllLevelBounds_RootDirectory_Offset;

	private static bool UpdateAllLevelBounds_SettingPtr_IsValid;

	private static FFieldAddress UpdateAllLevelBounds_SettingPtr_PropertyAddress;

	private static int UpdateAllLevelBounds_SettingPtr_Offset;

	private static bool UnLoadStreamingLevelsIntoCurrentPersistent_IsValid;

	private static IntPtr UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress;

	private static int UnLoadStreamingLevelsIntoCurrentPersistent_ParamsSize;

	private static bool UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;

	private static FFieldAddress UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress;

	private static int UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset;

	private static bool TranslateAllLevelActor_IsValid;

	private static IntPtr TranslateAllLevelActor_FunctionAddress;

	private static int TranslateAllLevelActor_ParamsSize;

	private static bool TranslateAllLevelActor_LevelName_IsValid;

	private static FFieldAddress TranslateAllLevelActor_LevelName_PropertyAddress;

	private static int TranslateAllLevelActor_LevelName_Offset;

	private static bool TranslateAllLevelActor_WorldTranslate_IsValid;

	private static FFieldAddress TranslateAllLevelActor_WorldTranslate_PropertyAddress;

	private static int TranslateAllLevelActor_WorldTranslate_Offset;

	private static bool TranslateAllLevelActor_ExceptActorClasses_IsValid;

	private static FFieldAddress TranslateAllLevelActor_ExceptActorClasses_PropertyAddress;

	private static int TranslateAllLevelActor_ExceptActorClasses_Offset;

	private static bool TranslateAllLevelActor_ReturnValue_IsValid;

	private static FFieldAddress TranslateAllLevelActor_ReturnValue_PropertyAddress;

	private static int TranslateAllLevelActor_ReturnValue_Offset;

	private static bool ToggleAllNoLandMeshVisibility_IsValid;

	private static IntPtr ToggleAllNoLandMeshVisibility_FunctionAddress;

	private static int ToggleAllNoLandMeshVisibility_ParamsSize;

	private static bool ToggleAllIKMeshVisibility_IsValid;

	private static IntPtr ToggleAllIKMeshVisibility_FunctionAddress;

	private static int ToggleAllIKMeshVisibility_ParamsSize;

	private static bool ToggleActorVisibilityInSceneOutliner_IsValid;

	private static IntPtr ToggleActorVisibilityInSceneOutliner_FunctionAddress;

	private static int ToggleActorVisibilityInSceneOutliner_ParamsSize;

	private static bool ToggleActorVisibilityInSceneOutliner_Actors_IsValid;

	private static FFieldAddress ToggleActorVisibilityInSceneOutliner_Actors_PropertyAddress;

	private static int ToggleActorVisibilityInSceneOutliner_Actors_Offset;

	private static bool TilesContainBlueprintClass_IsValid;

	private static IntPtr TilesContainBlueprintClass_FunctionAddress;

	private static int TilesContainBlueprintClass_ParamsSize;

	private static bool TilesContainBlueprintClass_SourceRootDirectory_IsValid;

	private static FFieldAddress TilesContainBlueprintClass_SourceRootDirectory_PropertyAddress;

	private static int TilesContainBlueprintClass_SourceRootDirectory_Offset;

	private static bool TilesContainBlueprintClass_OutResults_IsValid;

	private static FFieldAddress TilesContainBlueprintClass_OutResults_PropertyAddress;

	private static int TilesContainBlueprintClass_OutResults_Offset;

	private static bool TilesContainBlueprintClass_ReturnValue_IsValid;

	private static FFieldAddress TilesContainBlueprintClass_ReturnValue_PropertyAddress;

	private static int TilesContainBlueprintClass_ReturnValue_Offset;

	private static bool SpawnActor2SubLevel_IsValid;

	private static IntPtr SpawnActor2SubLevel_FunctionAddress;

	private static int SpawnActor2SubLevel_ParamsSize;

	private static bool SpawnActor2SubLevel_InSubLevel_IsValid;

	private static FFieldAddress SpawnActor2SubLevel_InSubLevel_PropertyAddress;

	private static int SpawnActor2SubLevel_InSubLevel_Offset;

	private static bool SpawnActor2SubLevel_InActorClass_IsValid;

	private static FFieldAddress SpawnActor2SubLevel_InActorClass_PropertyAddress;

	private static int SpawnActor2SubLevel_InActorClass_Offset;

	private static bool SpawnActor2SubLevel_InTransform_IsValid;

	private static FFieldAddress SpawnActor2SubLevel_InTransform_PropertyAddress;

	private static int SpawnActor2SubLevel_InTransform_Offset;

	private static bool SpawnActor2SubLevel_InName_IsValid;

	private static FFieldAddress SpawnActor2SubLevel_InName_PropertyAddress;

	private static int SpawnActor2SubLevel_InName_Offset;

	private static bool SpawnActor2SubLevel_ReturnValue_IsValid;

	private static FFieldAddress SpawnActor2SubLevel_ReturnValue_PropertyAddress;

	private static int SpawnActor2SubLevel_ReturnValue_Offset;

	private static bool ShowStreamingLevelsIntoCurrentPersistent_IsValid;

	private static IntPtr ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress;

	private static int ShowStreamingLevelsIntoCurrentPersistent_ParamsSize;

	private static bool ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;

	private static FFieldAddress ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress;

	private static int ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset;

	private static bool SetBossRushLevelLayer_IsValid;

	private static IntPtr SetBossRushLevelLayer_FunctionAddress;

	private static int SetBossRushLevelLayer_ParamsSize;

	private static bool SetBossRushLevelLayer_InSubLevelWorld_IsValid;

	private static FFieldAddress SetBossRushLevelLayer_InSubLevelWorld_PropertyAddress;

	private static int SetBossRushLevelLayer_InSubLevelWorld_Offset;

	private static bool SetAllBossRushLevelLayer_IsValid;

	private static IntPtr SetAllBossRushLevelLayer_FunctionAddress;

	private static int SetAllBossRushLevelLayer_ParamsSize;

	private static bool SetAllBossRushLevelLayer_InLevelNameList_IsValid;

	private static FFieldAddress SetAllBossRushLevelLayer_InLevelNameList_PropertyAddress;

	private static int SetAllBossRushLevelLayer_InLevelNameList_Offset;

	private static bool SelectActorsByTag_IsValid;

	private static IntPtr SelectActorsByTag_FunctionAddress;

	private static int SelectActorsByTag_ParamsSize;

	private static bool SelectActorsByTag_Tag_IsValid;

	private static FFieldAddress SelectActorsByTag_Tag_PropertyAddress;

	private static int SelectActorsByTag_Tag_Offset;

	private static bool ScanSpecifiedLevel_IsValid;

	private static IntPtr ScanSpecifiedLevel_FunctionAddress;

	private static int ScanSpecifiedLevel_ParamsSize;

	private static bool ScanSpecifiedLevel_SourceRootDirectory_IsValid;

	private static FFieldAddress ScanSpecifiedLevel_SourceRootDirectory_PropertyAddress;

	private static int ScanSpecifiedLevel_SourceRootDirectory_Offset;

	private static bool ScanSpecifiedLevel_InLevelName_IsValid;

	private static FFieldAddress ScanSpecifiedLevel_InLevelName_PropertyAddress;

	private static int ScanSpecifiedLevel_InLevelName_Offset;

	private static bool ScanLevelsExceedThreshold_IsValid;

	private static IntPtr ScanLevelsExceedThreshold_FunctionAddress;

	private static int ScanLevelsExceedThreshold_ParamsSize;

	private static bool ScanLevelsExceedThreshold_InRootDirectory_IsValid;

	private static FFieldAddress ScanLevelsExceedThreshold_InRootDirectory_PropertyAddress;

	private static int ScanLevelsExceedThreshold_InRootDirectory_Offset;

	private static bool ScanLevelsExceedThreshold_InThresholdNum_IsValid;

	private static FFieldAddress ScanLevelsExceedThreshold_InThresholdNum_PropertyAddress;

	private static int ScanLevelsExceedThreshold_InThresholdNum_Offset;

	private static bool ScanAllTileLevels_IsValid;

	private static IntPtr ScanAllTileLevels_FunctionAddress;

	private static int ScanAllTileLevels_ParamsSize;

	private static bool ScanAllTileLevels_SourceRootDirectory_IsValid;

	private static FFieldAddress ScanAllTileLevels_SourceRootDirectory_PropertyAddress;

	private static int ScanAllTileLevels_SourceRootDirectory_Offset;

	private static bool ScanAllTileLevels_InScanMode_IsValid;

	private static FFieldAddress ScanAllTileLevels_InScanMode_PropertyAddress;

	private static int ScanAllTileLevels_InScanMode_Offset;

	private static bool ScanAllStaticMeshesDistanceFieldInfo_IsValid;

	private static IntPtr ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress;

	private static int ScanAllStaticMeshesDistanceFieldInfo_ParamsSize;

	private static bool ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_IsValid;

	private static FFieldAddress ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_PropertyAddress;

	private static int ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_Offset;

	private static bool ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_IsValid;

	private static FFieldAddress ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_PropertyAddress;

	private static int ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_Offset;

	private static bool SaveLevel_IsValid;

	private static IntPtr SaveLevel_FunctionAddress;

	private static int SaveLevel_ParamsSize;

	private static bool SaveLevel_InLevel_IsValid;

	private static FFieldAddress SaveLevel_InLevel_PropertyAddress;

	private static int SaveLevel_InLevel_Offset;

	private static bool SaveLevel_bAutoCheckOut_IsValid;

	private static FFieldAddress SaveLevel_bAutoCheckOut_PropertyAddress;

	private static int SaveLevel_bAutoCheckOut_Offset;

	private static bool ResetActorToBlueprintDefaults_IsValid;

	private static IntPtr ResetActorToBlueprintDefaults_FunctionAddress;

	private static int ResetActorToBlueprintDefaults_ParamsSize;

	private static bool ResetActorToBlueprintDefaults_Actor_IsValid;

	private static FFieldAddress ResetActorToBlueprintDefaults_Actor_PropertyAddress;

	private static int ResetActorToBlueprintDefaults_Actor_Offset;

	private static bool ResetActorToBlueprintDefaults_ReturnValue_IsValid;

	private static FFieldAddress ResetActorToBlueprintDefaults_ReturnValue_PropertyAddress;

	private static int ResetActorToBlueprintDefaults_ReturnValue_Offset;

	private static bool ReplaceFoliageByFoliageByLevelName_IsValid;

	private static IntPtr ReplaceFoliageByFoliageByLevelName_FunctionAddress;

	private static int ReplaceFoliageByFoliageByLevelName_ParamsSize;

	private static bool ReplaceFoliageByFoliageByLevelName_LevelName_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliageByLevelName_LevelName_PropertyAddress;

	private static int ReplaceFoliageByFoliageByLevelName_LevelName_Offset;

	private static bool ReplaceFoliageByFoliageByLevelName_sourceFoliage_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliageByLevelName_sourceFoliage_PropertyAddress;

	private static int ReplaceFoliageByFoliageByLevelName_sourceFoliage_Offset;

	private static bool ReplaceFoliageByFoliageByLevelName_targetFoliage_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliageByLevelName_targetFoliage_PropertyAddress;

	private static int ReplaceFoliageByFoliageByLevelName_targetFoliage_Offset;

	private static bool ReplaceFoliageByFoliage_IsValid;

	private static IntPtr ReplaceFoliageByFoliage_FunctionAddress;

	private static int ReplaceFoliageByFoliage_ParamsSize;

	private static bool ReplaceFoliageByFoliage_Level_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliage_Level_PropertyAddress;

	private static int ReplaceFoliageByFoliage_Level_Offset;

	private static bool ReplaceFoliageByFoliage_sourceFoliage_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliage_sourceFoliage_PropertyAddress;

	private static int ReplaceFoliageByFoliage_sourceFoliage_Offset;

	private static bool ReplaceFoliageByFoliage_targetFoliage_IsValid;

	private static FFieldAddress ReplaceFoliageByFoliage_targetFoliage_PropertyAddress;

	private static int ReplaceFoliageByFoliage_targetFoliage_Offset;

	private static bool RemoveFoliageTypeFromLevelByLevelName_IsValid;

	private static IntPtr RemoveFoliageTypeFromLevelByLevelName_FunctionAddress;

	private static int RemoveFoliageTypeFromLevelByLevelName_ParamsSize;

	private static bool RemoveFoliageTypeFromLevelByLevelName_LevelName_IsValid;

	private static FFieldAddress RemoveFoliageTypeFromLevelByLevelName_LevelName_PropertyAddress;

	private static int RemoveFoliageTypeFromLevelByLevelName_LevelName_Offset;

	private static bool RemoveFoliageTypeFromLevelByLevelName_type_IsValid;

	private static FFieldAddress RemoveFoliageTypeFromLevelByLevelName_type_PropertyAddress;

	private static int RemoveFoliageTypeFromLevelByLevelName_type_Offset;

	private static bool RemoveFoliageTypeFromLevel_IsValid;

	private static IntPtr RemoveFoliageTypeFromLevel_FunctionAddress;

	private static int RemoveFoliageTypeFromLevel_ParamsSize;

	private static bool RemoveFoliageTypeFromLevel_Level_IsValid;

	private static FFieldAddress RemoveFoliageTypeFromLevel_Level_PropertyAddress;

	private static int RemoveFoliageTypeFromLevel_Level_Offset;

	private static bool RemoveFoliageTypeFromLevel_type_IsValid;

	private static FFieldAddress RemoveFoliageTypeFromLevel_type_PropertyAddress;

	private static int RemoveFoliageTypeFromLevel_type_Offset;

	private static bool RemoveEmptyStaticMeshActor_IsValid;

	private static IntPtr RemoveEmptyStaticMeshActor_FunctionAddress;

	private static int RemoveEmptyStaticMeshActor_ParamsSize;

	private static bool RemoveEmptyInstancedFoliageActor_IsValid;

	private static IntPtr RemoveEmptyInstancedFoliageActor_FunctionAddress;

	private static int RemoveEmptyInstancedFoliageActor_ParamsSize;

	private static bool RemoveEmptyFoliageInfo_IsValid;

	private static IntPtr RemoveEmptyFoliageInfo_FunctionAddress;

	private static int RemoveEmptyFoliageInfo_ParamsSize;

	private static bool RemoveEmptyFoliageInfo_ReturnValue_IsValid;

	private static FFieldAddress RemoveEmptyFoliageInfo_ReturnValue_PropertyAddress;

	private static int RemoveEmptyFoliageInfo_ReturnValue_Offset;

	private static bool RemapFoliageTypeAndCompsInLevels_IsValid;

	private static IntPtr RemapFoliageTypeAndCompsInLevels_FunctionAddress;

	private static int RemapFoliageTypeAndCompsInLevels_ParamsSize;

	private static bool RemapFoliageTypeAndCompsInLevels_SrcFolderPath_IsValid;

	private static FFieldAddress RemapFoliageTypeAndCompsInLevels_SrcFolderPath_PropertyAddress;

	private static int RemapFoliageTypeAndCompsInLevels_SrcFolderPath_Offset;

	private static bool RemapFoliageTypeAndCompsInLevel_IsValid;

	private static IntPtr RemapFoliageTypeAndCompsInLevel_FunctionAddress;

	private static int RemapFoliageTypeAndCompsInLevel_ParamsSize;

	private static bool RemapFoliageTypeAndCompsInLevel_TargetLevel_IsValid;

	private static FFieldAddress RemapFoliageTypeAndCompsInLevel_TargetLevel_PropertyAddress;

	private static int RemapFoliageTypeAndCompsInLevel_TargetLevel_Offset;

	private static bool RemapFoliageTypeAndComps_IsValid;

	private static IntPtr RemapFoliageTypeAndComps_FunctionAddress;

	private static int RemapFoliageTypeAndComps_ParamsSize;

	private static bool RemapFoliageTypeAndComps_InAsset_IsValid;

	private static FFieldAddress RemapFoliageTypeAndComps_InAsset_PropertyAddress;

	private static int RemapFoliageTypeAndComps_InAsset_Offset;

	private static bool RefreshViewportLocation_IsValid;

	private static IntPtr RefreshViewportLocation_FunctionAddress;

	private static int RefreshViewportLocation_ParamsSize;

	private static bool RefreshViewportLocation_CamPos_IsValid;

	private static FFieldAddress RefreshViewportLocation_CamPos_PropertyAddress;

	private static int RefreshViewportLocation_CamPos_Offset;

	private static bool RefreshTileLevelsHierarchy_IsValid;

	private static IntPtr RefreshTileLevelsHierarchy_FunctionAddress;

	private static int RefreshTileLevelsHierarchy_ParamsSize;

	private static bool RefreshTileLevelsHierarchy_InPersistentLevelPath_IsValid;

	private static FFieldAddress RefreshTileLevelsHierarchy_InPersistentLevelPath_PropertyAddress;

	private static int RefreshTileLevelsHierarchy_InPersistentLevelPath_Offset;

	private static bool ProcessPerActorLODSettings_IsValid;

	private static IntPtr ProcessPerActorLODSettings_FunctionAddress;

	private static int ProcessPerActorLODSettings_ParamsSize;

	private static bool ProcessPerActorLODSettings_SrcFolderPath_IsValid;

	private static FFieldAddress ProcessPerActorLODSettings_SrcFolderPath_PropertyAddress;

	private static int ProcessPerActorLODSettings_SrcFolderPath_Offset;

	private static bool ProcessPerActorLODSettings_SettingPtr_IsValid;

	private static FFieldAddress ProcessPerActorLODSettings_SettingPtr_PropertyAddress;

	private static int ProcessPerActorLODSettings_SettingPtr_Offset;

	private static bool PrintTilesStatsInfo_IsValid;

	private static IntPtr PrintTilesStatsInfo_FunctionAddress;

	private static int PrintTilesStatsInfo_ParamsSize;

	private static bool PrintTilesStatsInfo_RootDirectory_IsValid;

	private static FFieldAddress PrintTilesStatsInfo_RootDirectory_PropertyAddress;

	private static int PrintTilesStatsInfo_RootDirectory_Offset;

	private static bool PrintTilesSkippability_IsValid;

	private static IntPtr PrintTilesSkippability_FunctionAddress;

	private static int PrintTilesSkippability_ParamsSize;

	private static bool PrintTilesSkippability_RootDirectory_IsValid;

	private static FFieldAddress PrintTilesSkippability_RootDirectory_PropertyAddress;

	private static int PrintTilesSkippability_RootDirectory_Offset;

	private static bool PostProcessTileData_IsValid;

	private static IntPtr PostProcessTileData_FunctionAddress;

	private static int PostProcessTileData_ParamsSize;

	private static bool PostProcessTileData_SourceRootDirectory_IsValid;

	private static FFieldAddress PostProcessTileData_SourceRootDirectory_PropertyAddress;

	private static int PostProcessTileData_SourceRootDirectory_Offset;

	private static bool PostProcessTileData_SettingPtr_IsValid;

	private static FFieldAddress PostProcessTileData_SettingPtr_PropertyAddress;

	private static int PostProcessTileData_SettingPtr_Offset;

	private static bool MoveAllFoliageInstancesToTargetWorld_IsValid;

	private static IntPtr MoveAllFoliageInstancesToTargetWorld_FunctionAddress;

	private static int MoveAllFoliageInstancesToTargetWorld_ParamsSize;

	private static bool MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_IsValid;

	private static FFieldAddress MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_PropertyAddress;

	private static int MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_Offset;

	private static bool MoveActorsBackToDominantLevel_IsValid;

	private static IntPtr MoveActorsBackToDominantLevel_FunctionAddress;

	private static int MoveActorsBackToDominantLevel_ParamsSize;

	private static bool MoveActorsBackToDominantLevel_SourceRootDirectory_IsValid;

	private static FFieldAddress MoveActorsBackToDominantLevel_SourceRootDirectory_PropertyAddress;

	private static int MoveActorsBackToDominantLevel_SourceRootDirectory_Offset;

	private static bool MoveActorsBackToDominantLevel_SettingPtr_IsValid;

	private static FFieldAddress MoveActorsBackToDominantLevel_SettingPtr_PropertyAddress;

	private static int MoveActorsBackToDominantLevel_SettingPtr_Offset;

	private static bool MoveActorsBackToDominantLevel_ReturnValue_IsValid;

	private static FFieldAddress MoveActorsBackToDominantLevel_ReturnValue_PropertyAddress;

	private static int MoveActorsBackToDominantLevel_ReturnValue_Offset;

	private static bool MoveActorsBackAndCacheActorsInfo_IsValid;

	private static IntPtr MoveActorsBackAndCacheActorsInfo_FunctionAddress;

	private static int MoveActorsBackAndCacheActorsInfo_ParamsSize;

	private static bool MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_IsValid;

	private static FFieldAddress MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_PropertyAddress;

	private static int MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_Offset;

	private static bool MoveActorsBackAndCacheActorsInfo_SettingPtr_IsValid;

	private static FFieldAddress MoveActorsBackAndCacheActorsInfo_SettingPtr_PropertyAddress;

	private static int MoveActorsBackAndCacheActorsInfo_SettingPtr_Offset;

	private static bool MoveActorsBackAndCacheActorsInfo_ReturnValue_IsValid;

	private static FFieldAddress MoveActorsBackAndCacheActorsInfo_ReturnValue_PropertyAddress;

	private static int MoveActorsBackAndCacheActorsInfo_ReturnValue_Offset;

	private static bool ModifyNameForActors_IsValid;

	private static IntPtr ModifyNameForActors_FunctionAddress;

	private static int ModifyNameForActors_ParamsSize;

	private static bool ModifyNameForActors_Actors_IsValid;

	private static FFieldAddress ModifyNameForActors_Actors_PropertyAddress;

	private static int ModifyNameForActors_Actors_Offset;

	private static bool ModifyNameForActors_replaceStr_IsValid;

	private static FFieldAddress ModifyNameForActors_replaceStr_PropertyAddress;

	private static int ModifyNameForActors_replaceStr_Offset;

	private static bool ModifyNameForActors_NewStr_IsValid;

	private static FFieldAddress ModifyNameForActors_NewStr_PropertyAddress;

	private static int ModifyNameForActors_NewStr_Offset;

	private static bool ModifyNameForActors_NotFitGoAppend_IsValid;

	private static FFieldAddress ModifyNameForActors_NotFitGoAppend_PropertyAddress;

	private static int ModifyNameForActors_NotFitGoAppend_Offset;

	private static bool MakeLevelNameDecorateLevelActor_IsValid;

	private static IntPtr MakeLevelNameDecorateLevelActor_FunctionAddress;

	private static int MakeLevelNameDecorateLevelActor_ParamsSize;

	private static bool LoadWCTileMapSettings_IsValid;

	private static IntPtr LoadWCTileMapSettings_FunctionAddress;

	private static int LoadWCTileMapSettings_ParamsSize;

	private static bool LoadWCTileMapSettings_MapFolder_IsValid;

	private static FFieldAddress LoadWCTileMapSettings_MapFolder_PropertyAddress;

	private static int LoadWCTileMapSettings_MapFolder_Offset;

	private static bool LoadWCTileMapSettings_bDebugLog_IsValid;

	private static FFieldAddress LoadWCTileMapSettings_bDebugLog_PropertyAddress;

	private static int LoadWCTileMapSettings_bDebugLog_Offset;

	private static bool LoadWCTileMapSettings_ReturnValue_IsValid;

	private static FFieldAddress LoadWCTileMapSettings_ReturnValue_PropertyAddress;

	private static int LoadWCTileMapSettings_ReturnValue_Offset;

	private static bool LoadStreamingLevelsIntoCurrentPersistent_IsValid;

	private static IntPtr LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress;

	private static int LoadStreamingLevelsIntoCurrentPersistent_ParamsSize;

	private static bool LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;

	private static FFieldAddress LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress;

	private static int LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset;

	private static bool LoadAllWCLevels_IsValid;

	private static IntPtr LoadAllWCLevels_FunctionAddress;

	private static int LoadAllWCLevels_ParamsSize;

	private static bool LoadAllWCLevels_InWorld_IsValid;

	private static FFieldAddress LoadAllWCLevels_InWorld_PropertyAddress;

	private static int LoadAllWCLevels_InWorld_Offset;

	private static bool HideStreamingLevelsIntoCurrentPersistent_IsValid;

	private static IntPtr HideStreamingLevelsIntoCurrentPersistent_FunctionAddress;

	private static int HideStreamingLevelsIntoCurrentPersistent_ParamsSize;

	private static bool HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;

	private static FFieldAddress HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress;

	private static int HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset;

	private static bool HideAllWCLevels_IsValid;

	private static IntPtr HideAllWCLevels_FunctionAddress;

	private static int HideAllWCLevels_ParamsSize;

	private static bool HideAllWCLevels_InWorld_IsValid;

	private static FFieldAddress HideAllWCLevels_InWorld_PropertyAddress;

	private static int HideAllWCLevels_InWorld_Offset;

	private static bool GSWCReorganizeActorsSimple_IsValid;

	private static IntPtr GSWCReorganizeActorsSimple_FunctionAddress;

	private static int GSWCReorganizeActorsSimple_ParamsSize;

	private static bool GSWCReorganizeActorsSimple_SourceRootDirectory_IsValid;

	private static FFieldAddress GSWCReorganizeActorsSimple_SourceRootDirectory_PropertyAddress;

	private static int GSWCReorganizeActorsSimple_SourceRootDirectory_Offset;

	private static bool GSWCReorganizeActorsSimple_SettingPtr_IsValid;

	private static FFieldAddress GSWCReorganizeActorsSimple_SettingPtr_PropertyAddress;

	private static int GSWCReorganizeActorsSimple_SettingPtr_Offset;

	private static bool GSWCReorganizeActors_IsValid;

	private static IntPtr GSWCReorganizeActors_FunctionAddress;

	private static int GSWCReorganizeActors_ParamsSize;

	private static bool GSWCReorganizeActors_SourceRootDirectory_IsValid;

	private static FFieldAddress GSWCReorganizeActors_SourceRootDirectory_PropertyAddress;

	private static int GSWCReorganizeActors_SourceRootDirectory_Offset;

	private static bool GSWCReorganizeActors_SettingPtr_IsValid;

	private static FFieldAddress GSWCReorganizeActors_SettingPtr_PropertyAddress;

	private static int GSWCReorganizeActors_SettingPtr_Offset;

	private static bool GetWorldContext_IsValid;

	private static IntPtr GetWorldContext_FunctionAddress;

	private static int GetWorldContext_ParamsSize;

	private static bool GetWorldContext_ReturnValue_IsValid;

	private static FFieldAddress GetWorldContext_ReturnValue_PropertyAddress;

	private static int GetWorldContext_ReturnValue_Offset;

	private static bool GetViewportXY_IsValid;

	private static IntPtr GetViewportXY_FunctionAddress;

	private static int GetViewportXY_ParamsSize;

	private static bool GetViewportXY_ReturnValue_IsValid;

	private static FFieldAddress GetViewportXY_ReturnValue_PropertyAddress;

	private static int GetViewportXY_ReturnValue_Offset;

	private static bool GetViewportLocation_IsValid;

	private static IntPtr GetViewportLocation_FunctionAddress;

	private static int GetViewportLocation_ParamsSize;

	private static bool GetViewportLocation_ReturnValue_IsValid;

	private static FFieldAddress GetViewportLocation_ReturnValue_PropertyAddress;

	private static int GetViewportLocation_ReturnValue_Offset;

	private static bool GetSelectedActors_IsValid;

	private static IntPtr GetSelectedActors_FunctionAddress;

	private static int GetSelectedActors_ParamsSize;

	private static bool GetSelectedActors_ReturnValue_IsValid;

	private static FFieldAddress GetSelectedActors_ReturnValue_PropertyAddress;

	private static int GetSelectedActors_ReturnValue_Offset;

	private static bool GetOrthoUnitsPerPixel_IsValid;

	private static IntPtr GetOrthoUnitsPerPixel_FunctionAddress;

	private static int GetOrthoUnitsPerPixel_ParamsSize;

	private static bool GetOrthoUnitsPerPixel_ReturnValue_IsValid;

	private static FFieldAddress GetOrthoUnitsPerPixel_ReturnValue_PropertyAddress;

	private static int GetOrthoUnitsPerPixel_ReturnValue_Offset;

	private static bool GetLevelsInWorld_IsValid;

	private static IntPtr GetLevelsInWorld_FunctionAddress;

	private static int GetLevelsInWorld_ParamsSize;

	private static bool GetLevelsInWorld_CurWorld_IsValid;

	private static FFieldAddress GetLevelsInWorld_CurWorld_PropertyAddress;

	private static int GetLevelsInWorld_CurWorld_Offset;

	private static bool GetLevelsInWorld_OutSubLevels_IsValid;

	private static FFieldAddress GetLevelsInWorld_OutSubLevels_PropertyAddress;

	private static int GetLevelsInWorld_OutSubLevels_Offset;

	private static bool GetLevels_IsValid;

	private static IntPtr GetLevels_FunctionAddress;

	private static int GetLevels_ParamsSize;

	private static bool GetLevels_World_IsValid;

	private static FFieldAddress GetLevels_World_PropertyAddress;

	private static int GetLevels_World_Offset;

	private static bool GetLevels_ReturnValue_IsValid;

	private static FFieldAddress GetLevels_ReturnValue_PropertyAddress;

	private static int GetLevels_ReturnValue_Offset;

	private static bool GetLevelByName_IsValid;

	private static IntPtr GetLevelByName_FunctionAddress;

	private static int GetLevelByName_ParamsSize;

	private static bool GetLevelByName_LevelName_IsValid;

	private static FFieldAddress GetLevelByName_LevelName_PropertyAddress;

	private static int GetLevelByName_LevelName_Offset;

	private static bool GetLevelByName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelByName_ReturnValue_PropertyAddress;

	private static int GetLevelByName_ReturnValue_Offset;

	private static bool GetLevelBoundsFromAsset_IsValid;

	private static IntPtr GetLevelBoundsFromAsset_FunctionAddress;

	private static int GetLevelBoundsFromAsset_ParamsSize;

	private static bool GetLevelBoundsFromAsset_Asset_IsValid;

	private static FFieldAddress GetLevelBoundsFromAsset_Asset_PropertyAddress;

	private static int GetLevelBoundsFromAsset_Asset_Offset;

	private static bool GetLevelBoundsFromAsset_ReturnValue_IsValid;

	private static FFieldAddress GetLevelBoundsFromAsset_ReturnValue_PropertyAddress;

	private static int GetLevelBoundsFromAsset_ReturnValue_Offset;

	private static bool GetLevelAllActors_IsValid;

	private static IntPtr GetLevelAllActors_FunctionAddress;

	private static int GetLevelAllActors_ParamsSize;

	private static bool GetLevelAllActors_Level_IsValid;

	private static FFieldAddress GetLevelAllActors_Level_PropertyAddress;

	private static int GetLevelAllActors_Level_Offset;

	private static bool GetLevelAllActors_ReturnValue_IsValid;

	private static FFieldAddress GetLevelAllActors_ReturnValue_PropertyAddress;

	private static int GetLevelAllActors_ReturnValue_Offset;

	private static bool GetGSWCItemLevels_IsValid;

	private static IntPtr GetGSWCItemLevels_FunctionAddress;

	private static int GetGSWCItemLevels_ParamsSize;

	private static bool GetGSWCItemLevels_SrcFolderPath_IsValid;

	private static FFieldAddress GetGSWCItemLevels_SrcFolderPath_PropertyAddress;

	private static int GetGSWCItemLevels_SrcFolderPath_Offset;

	private static bool GetGSWCItemLevels_OutItemLevelAssets_IsValid;

	private static FFieldAddress GetGSWCItemLevels_OutItemLevelAssets_PropertyAddress;

	private static int GetGSWCItemLevels_OutItemLevelAssets_Offset;

	private static bool GetGSWCItemLevels_ReturnValue_IsValid;

	private static FFieldAddress GetGSWCItemLevels_ReturnValue_PropertyAddress;

	private static int GetGSWCItemLevels_ReturnValue_Offset;

	private static bool GetFoliageInstanceDataFromLevelByLevelName_IsValid;

	private static IntPtr GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress;

	private static int GetFoliageInstanceDataFromLevelByLevelName_ParamsSize;

	private static bool GetFoliageInstanceDataFromLevelByLevelName_LevelName_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevelByLevelName_LevelName_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevelByLevelName_LevelName_Offset;

	private static bool GetFoliageInstanceDataFromLevelByLevelName_type_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevelByLevelName_type_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevelByLevelName_type_Offset;

	private static bool GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_Offset;

	private static bool GetFoliageInstanceDataFromLevel_IsValid;

	private static IntPtr GetFoliageInstanceDataFromLevel_FunctionAddress;

	private static int GetFoliageInstanceDataFromLevel_ParamsSize;

	private static bool GetFoliageInstanceDataFromLevel_Level_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevel_Level_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevel_Level_Offset;

	private static bool GetFoliageInstanceDataFromLevel_type_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevel_type_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevel_type_Offset;

	private static bool GetFoliageInstanceDataFromLevel_ReturnValue_IsValid;

	private static FFieldAddress GetFoliageInstanceDataFromLevel_ReturnValue_PropertyAddress;

	private static int GetFoliageInstanceDataFromLevel_ReturnValue_Offset;

	private static bool GetCurrentPersistentLevelWorld_IsValid;

	private static IntPtr GetCurrentPersistentLevelWorld_FunctionAddress;

	private static int GetCurrentPersistentLevelWorld_ParamsSize;

	private static bool GetCurrentPersistentLevelWorld_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPersistentLevelWorld_ReturnValue_PropertyAddress;

	private static int GetCurrentPersistentLevelWorld_ReturnValue_Offset;

	private static bool GetCurrentPersistentLevelName_IsValid;

	private static IntPtr GetCurrentPersistentLevelName_FunctionAddress;

	private static int GetCurrentPersistentLevelName_ParamsSize;

	private static bool GetCurrentPersistentLevelName_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentPersistentLevelName_ReturnValue_PropertyAddress;

	private static int GetCurrentPersistentLevelName_ReturnValue_Offset;

	private static bool GetCurrentAllWCLevelsName_IsValid;

	private static IntPtr GetCurrentAllWCLevelsName_FunctionAddress;

	private static int GetCurrentAllWCLevelsName_ParamsSize;

	private static bool GetCurrentAllWCLevelsName_OutLevelsName_IsValid;

	private static FFieldAddress GetCurrentAllWCLevelsName_OutLevelsName_PropertyAddress;

	private static int GetCurrentAllWCLevelsName_OutLevelsName_Offset;

	private static bool GetCurrentAllWCLevelsName_bIgnoreWCTile_IsValid;

	private static FFieldAddress GetCurrentAllWCLevelsName_bIgnoreWCTile_PropertyAddress;

	private static int GetCurrentAllWCLevelsName_bIgnoreWCTile_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_IsValid;

	private static IntPtr GetAllActorsInsideInBoxInAllWorlds_FunctionAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_ParamsSize;

	private static bool GetAllActorsInsideInBoxInAllWorlds_encloseBox_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_encloseBox_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_encloseBox_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_allWorld_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_allWorld_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_allWorld_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_Offset;

	private static bool GetAllActorsInsideInBoxInAllWorlds_ReturnValue_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllWorlds_ReturnValue_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllWorlds_ReturnValue_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_IsValid;

	private static IntPtr GetAllActorsInsideInBoxInAllLevels_FunctionAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_ParamsSize;

	private static bool GetAllActorsInsideInBoxInAllLevels_encloseBox_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_encloseBox_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_encloseBox_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_allLevel_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_allLevel_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_allLevel_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_filterSizePercent_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_filterSizePercent_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_filterSizePercent_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_Offset;

	private static bool GetAllActorsInsideInBoxInAllLevels_ReturnValue_IsValid;

	private static FFieldAddress GetAllActorsInsideInBoxInAllLevels_ReturnValue_PropertyAddress;

	private static int GetAllActorsInsideInBoxInAllLevels_ReturnValue_Offset;

	private static bool GetActorListByDistanceSignificance_IsValid;

	private static IntPtr GetActorListByDistanceSignificance_FunctionAddress;

	private static int GetActorListByDistanceSignificance_ParamsSize;

	private static bool GetActorListByDistanceSignificance_OriginalActor_IsValid;

	private static FFieldAddress GetActorListByDistanceSignificance_OriginalActor_PropertyAddress;

	private static int GetActorListByDistanceSignificance_OriginalActor_Offset;

	private static bool GetActorListByDistanceSignificance_traceRadius_IsValid;

	private static FFieldAddress GetActorListByDistanceSignificance_traceRadius_PropertyAddress;

	private static int GetActorListByDistanceSignificance_traceRadius_Offset;

	private static bool GetActorListByDistanceSignificance_ReturnValue_IsValid;

	private static FFieldAddress GetActorListByDistanceSignificance_ReturnValue_PropertyAddress;

	private static int GetActorListByDistanceSignificance_ReturnValue_Offset;

	private static bool GenerateWCTileConfig_IsValid;

	private static IntPtr GenerateWCTileConfig_FunctionAddress;

	private static int GenerateWCTileConfig_ParamsSize;

	private static bool GenerateWCTileConfig_SrcFolderPath_IsValid;

	private static FFieldAddress GenerateWCTileConfig_SrcFolderPath_PropertyAddress;

	private static int GenerateWCTileConfig_SrcFolderPath_Offset;

	private static bool GenerateWCTileConfig_InSerializeMode_IsValid;

	private static FFieldAddress GenerateWCTileConfig_InSerializeMode_PropertyAddress;

	private static int GenerateWCTileConfig_InSerializeMode_Offset;

	private static bool GenerateMapTileLODs_IsValid;

	private static IntPtr GenerateMapTileLODs_FunctionAddress;

	private static int GenerateMapTileLODs_ParamsSize;

	private static bool GenerateMapTileLODs_SrcFolderPath_IsValid;

	private static FFieldAddress GenerateMapTileLODs_SrcFolderPath_PropertyAddress;

	private static int GenerateMapTileLODs_SrcFolderPath_Offset;

	private static bool GenerateMapTileLODs_InMapFilterNames_IsValid;

	private static FFieldAddress GenerateMapTileLODs_InMapFilterNames_PropertyAddress;

	private static int GenerateMapTileLODs_InMapFilterNames_Offset;

	private static bool GenerateMapTileLODs_SettingsPtr_IsValid;

	private static FFieldAddress GenerateMapTileLODs_SettingsPtr_PropertyAddress;

	private static int GenerateMapTileLODs_SettingsPtr_Offset;

	private static bool GenerateMapTileLODs_PersistentLevelName_IsValid;

	private static FFieldAddress GenerateMapTileLODs_PersistentLevelName_PropertyAddress;

	private static int GenerateMapTileLODs_PersistentLevelName_Offset;

	private static bool GenerateMapTileLODs_bRequiredPreLevelGC_IsValid;

	private static FFieldAddress GenerateMapTileLODs_bRequiredPreLevelGC_PropertyAddress;

	private static int GenerateMapTileLODs_bRequiredPreLevelGC_Offset;

	private static bool GenerateMapTileLODs_ReturnValue_IsValid;

	private static FFieldAddress GenerateMapTileLODs_ReturnValue_PropertyAddress;

	private static int GenerateMapTileLODs_ReturnValue_Offset;

	private static bool ForceAllLevelGC_IsValid;

	private static IntPtr ForceAllLevelGC_FunctionAddress;

	private static int ForceAllLevelGC_ParamsSize;

	private static bool FixNormalTilesTreeIssues_IsValid;

	private static IntPtr FixNormalTilesTreeIssues_FunctionAddress;

	private static int FixNormalTilesTreeIssues_ParamsSize;

	private static bool FixNormalTilesTreeIssues_RootDirectory_IsValid;

	private static FFieldAddress FixNormalTilesTreeIssues_RootDirectory_PropertyAddress;

	private static int FixNormalTilesTreeIssues_RootDirectory_Offset;

	private static bool FixLevelActorAffectNavData_IsValid;

	private static IntPtr FixLevelActorAffectNavData_FunctionAddress;

	private static int FixLevelActorAffectNavData_ParamsSize;

	private static bool FixLevelActorAffectNavData_PointsFilePath_IsValid;

	private static FFieldAddress FixLevelActorAffectNavData_PointsFilePath_PropertyAddress;

	private static int FixLevelActorAffectNavData_PointsFilePath_Offset;

	private static bool FixLevelActorAffectNavData_ToleranceDistance_IsValid;

	private static FFieldAddress FixLevelActorAffectNavData_ToleranceDistance_PropertyAddress;

	private static int FixLevelActorAffectNavData_ToleranceDistance_Offset;

	private static bool ExportLevel_IsValid;

	private static IntPtr ExportLevel_FunctionAddress;

	private static int ExportLevel_ParamsSize;

	private static bool ExportLevel_bExportSelectedActorsOnly_IsValid;

	private static FFieldAddress ExportLevel_bExportSelectedActorsOnly_PropertyAddress;

	private static int ExportLevel_bExportSelectedActorsOnly_Offset;

	private static bool EmptySelectedActorsOverrideMaterials_IsValid;

	private static IntPtr EmptySelectedActorsOverrideMaterials_FunctionAddress;

	private static int EmptySelectedActorsOverrideMaterials_ParamsSize;

	private static bool DuplicateSelectedActors_IsValid;

	private static IntPtr DuplicateSelectedActors_FunctionAddress;

	private static int DuplicateSelectedActors_ParamsSize;

	private static bool DuplicateSelectedActors_InWorld_IsValid;

	private static FFieldAddress DuplicateSelectedActors_InWorld_PropertyAddress;

	private static int DuplicateSelectedActors_InWorld_Offset;

	private static bool DuplicateAllLevels_IsValid;

	private static IntPtr DuplicateAllLevels_FunctionAddress;

	private static int DuplicateAllLevels_ParamsSize;

	private static bool DuplicateAllLevels_SourceRootDirectory_IsValid;

	private static FFieldAddress DuplicateAllLevels_SourceRootDirectory_PropertyAddress;

	private static int DuplicateAllLevels_SourceRootDirectory_Offset;

	private static bool DuplicateAllLevels_DestRootDirectory_IsValid;

	private static FFieldAddress DuplicateAllLevels_DestRootDirectory_PropertyAddress;

	private static int DuplicateAllLevels_DestRootDirectory_Offset;

	private static bool DuplicateAllLevels_newPrefix_IsValid;

	private static FFieldAddress DuplicateAllLevels_newPrefix_PropertyAddress;

	private static int DuplicateAllLevels_newPrefix_Offset;

	private static bool DuplicateAllLevels_LevelStreamingNameRetargetSrc_IsValid;

	private static FFieldAddress DuplicateAllLevels_LevelStreamingNameRetargetSrc_PropertyAddress;

	private static int DuplicateAllLevels_LevelStreamingNameRetargetSrc_Offset;

	private static bool DuplicateAllLevels_LevelStreamingNameRetargetDest_IsValid;

	private static FFieldAddress DuplicateAllLevels_LevelStreamingNameRetargetDest_PropertyAddress;

	private static int DuplicateAllLevels_LevelStreamingNameRetargetDest_Offset;

	private static bool DuplicateAllLevels_needRescan_IsValid;

	private static FFieldAddress DuplicateAllLevels_needRescan_PropertyAddress;

	private static int DuplicateAllLevels_needRescan_Offset;

	private static bool DuplicateAllLevels_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAllLevels_ReturnValue_PropertyAddress;

	private static int DuplicateAllLevels_ReturnValue_Offset;

	private static bool DumpSelectedActorBoundsInfo_IsValid;

	private static IntPtr DumpSelectedActorBoundsInfo_FunctionAddress;

	private static int DumpSelectedActorBoundsInfo_ParamsSize;

	private static bool DumpLandscapeHeightMapAndWeightMap_IsValid;

	private static IntPtr DumpLandscapeHeightMapAndWeightMap_FunctionAddress;

	private static int DumpLandscapeHeightMapAndWeightMap_ParamsSize;

	private static bool DumpLandscapeHeightMapAndWeightMap_ProxyActor_IsValid;

	private static FFieldAddress DumpLandscapeHeightMapAndWeightMap_ProxyActor_PropertyAddress;

	private static int DumpLandscapeHeightMapAndWeightMap_ProxyActor_Offset;

	private static bool DumpLandscapeHeightMapAndWeightMap_ReturnValue_IsValid;

	private static FFieldAddress DumpLandscapeHeightMapAndWeightMap_ReturnValue_PropertyAddress;

	private static int DumpLandscapeHeightMapAndWeightMap_ReturnValue_Offset;

	private static bool DiscardNavigationDataChunks_IsValid;

	private static IntPtr DiscardNavigationDataChunks_FunctionAddress;

	private static int DiscardNavigationDataChunks_ParamsSize;

	private static bool DiscardNavigationDataChunks_world_IsValid;

	private static FFieldAddress DiscardNavigationDataChunks_world_PropertyAddress;

	private static int DiscardNavigationDataChunks_world_Offset;

	private static bool DisableLodMeshCollisions_IsValid;

	private static IntPtr DisableLodMeshCollisions_FunctionAddress;

	private static int DisableLodMeshCollisions_ParamsSize;

	private static bool DisableLodMeshCollisions_PyFilePathBasedOnContentDir_IsValid;

	private static FFieldAddress DisableLodMeshCollisions_PyFilePathBasedOnContentDir_PropertyAddress;

	private static int DisableLodMeshCollisions_PyFilePathBasedOnContentDir_Offset;

	private static bool DisableLodMeshCollisions_TargetFolder_IsValid;

	private static FFieldAddress DisableLodMeshCollisions_TargetFolder_PropertyAddress;

	private static int DisableLodMeshCollisions_TargetFolder_Offset;

	private static bool CreateShapeActorFromeStaticMeshActor_IsValid;

	private static IntPtr CreateShapeActorFromeStaticMeshActor_FunctionAddress;

	private static int CreateShapeActorFromeStaticMeshActor_ParamsSize;

	private static bool CreateShapeActorFromeStaticMeshActor_AppendMeshActors_IsValid;

	private static FFieldAddress CreateShapeActorFromeStaticMeshActor_AppendMeshActors_PropertyAddress;

	private static int CreateShapeActorFromeStaticMeshActor_AppendMeshActors_Offset;

	private static bool CreateLevelFromSelectionActors_IsValid;

	private static IntPtr CreateLevelFromSelectionActors_FunctionAddress;

	private static int CreateLevelFromSelectionActors_ParamsSize;

	private static bool CreateLevelFromSelectionActors_needReplaceActor_IsValid;

	private static FFieldAddress CreateLevelFromSelectionActors_needReplaceActor_PropertyAddress;

	private static int CreateLevelFromSelectionActors_needReplaceActor_Offset;

	private static bool ConvertWorld2LevelObject_IsValid;

	private static IntPtr ConvertWorld2LevelObject_FunctionAddress;

	private static int ConvertWorld2LevelObject_ParamsSize;

	private static bool ConvertWorld2LevelObject_InWorld_IsValid;

	private static FFieldAddress ConvertWorld2LevelObject_InWorld_PropertyAddress;

	private static int ConvertWorld2LevelObject_InWorld_Offset;

	private static bool ConvertWorld2LevelObject_ReturnValue_IsValid;

	private static FFieldAddress ConvertWorld2LevelObject_ReturnValue_PropertyAddress;

	private static int ConvertWorld2LevelObject_ReturnValue_Offset;

	private static bool ConvertStaticMeshActorToInstance_IsValid;

	private static IntPtr ConvertStaticMeshActorToInstance_FunctionAddress;

	private static int ConvertStaticMeshActorToInstance_ParamsSize;

	private static bool ConvertStaticMeshActorToInstance_MeshActors_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToInstance_MeshActors_PropertyAddress;

	private static int ConvertStaticMeshActorToInstance_MeshActors_Offset;

	private static bool ConvertStaticMeshActorToInstance_UseHISM_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToInstance_UseHISM_PropertyAddress;

	private static int ConvertStaticMeshActorToInstance_UseHISM_Offset;

	private static bool ConvertStaticMeshActorToInstance_MinInstancesCount_IsValid;

	private static FFieldAddress ConvertStaticMeshActorToInstance_MinInstancesCount_PropertyAddress;

	private static int ConvertStaticMeshActorToInstance_MinInstancesCount_Offset;

	private static bool ConvertMatchedBlockingVolumeInLevelToGroundChannel_IsValid;

	private static IntPtr ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress;

	private static int ConvertMatchedBlockingVolumeInLevelToGroundChannel_ParamsSize;

	private static bool ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_IsValid;

	private static FFieldAddress ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_PropertyAddress;

	private static int ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_Offset;

	private static bool ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_IsValid;

	private static FFieldAddress ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_PropertyAddress;

	private static int ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_Offset;

	private static bool ConvertLevelStaticMeshToInstance_IsValid;

	private static IntPtr ConvertLevelStaticMeshToInstance_FunctionAddress;

	private static int ConvertLevelStaticMeshToInstance_ParamsSize;

	private static bool ConvertLevelStaticMeshToInstance_CellX_IsValid;

	private static FFieldAddress ConvertLevelStaticMeshToInstance_CellX_PropertyAddress;

	private static int ConvertLevelStaticMeshToInstance_CellX_Offset;

	private static bool ConvertLevelStaticMeshToInstance_CellY_IsValid;

	private static FFieldAddress ConvertLevelStaticMeshToInstance_CellY_PropertyAddress;

	private static int ConvertLevelStaticMeshToInstance_CellY_Offset;

	private static bool ConvertLevelStaticMeshToInstance_CellZ_IsValid;

	private static FFieldAddress ConvertLevelStaticMeshToInstance_CellZ_PropertyAddress;

	private static int ConvertLevelStaticMeshToInstance_CellZ_Offset;

	private static bool ConvertLevelStaticMeshToInstance_MinInstancesCount_IsValid;

	private static FFieldAddress ConvertLevelStaticMeshToInstance_MinInstancesCount_PropertyAddress;

	private static int ConvertLevelStaticMeshToInstance_MinInstancesCount_Offset;

	private static bool ConvertCubeInLevelToBlockingVolume_IsValid;

	private static IntPtr ConvertCubeInLevelToBlockingVolume_FunctionAddress;

	private static int ConvertCubeInLevelToBlockingVolume_ParamsSize;

	private static bool ConvertCubeInLevelToBlockingVolume_InAssets_IsValid;

	private static FFieldAddress ConvertCubeInLevelToBlockingVolume_InAssets_PropertyAddress;

	private static int ConvertCubeInLevelToBlockingVolume_InAssets_Offset;

	private static bool ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_IsValid;

	private static FFieldAddress ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_PropertyAddress;

	private static int ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_Offset;

	private static bool ClearSelectedActorsCustomPrimitiveData_IsValid;

	private static IntPtr ClearSelectedActorsCustomPrimitiveData_FunctionAddress;

	private static int ClearSelectedActorsCustomPrimitiveData_ParamsSize;

	private static bool CleanObsoleteAssets_IsValid;

	private static IntPtr CleanObsoleteAssets_FunctionAddress;

	private static int CleanObsoleteAssets_ParamsSize;

	private static bool CleanObsoleteAssets_SourceRootDirectory_IsValid;

	private static FFieldAddress CleanObsoleteAssets_SourceRootDirectory_PropertyAddress;

	private static int CleanObsoleteAssets_SourceRootDirectory_Offset;

	private static bool CleanLevelNameDecorateLevelActor_IsValid;

	private static IntPtr CleanLevelNameDecorateLevelActor_FunctionAddress;

	private static int CleanLevelNameDecorateLevelActor_ParamsSize;

	private static bool CleanIllegalNoSMLandTags_IsValid;

	private static IntPtr CleanIllegalNoSMLandTags_FunctionAddress;

	private static int CleanIllegalNoSMLandTags_ParamsSize;

	private static bool CleanAllOldIKMeshTags_IsValid;

	private static IntPtr CleanAllOldIKMeshTags_FunctionAddress;

	private static int CleanAllOldIKMeshTags_ParamsSize;

	private static bool CheckSkylightCubemapResolution_IsValid;

	private static IntPtr CheckSkylightCubemapResolution_FunctionAddress;

	private static int CheckSkylightCubemapResolution_ParamsSize;

	private static bool CheckSkylightCubemapResolution_SrcFolderPath_IsValid;

	private static FFieldAddress CheckSkylightCubemapResolution_SrcFolderPath_PropertyAddress;

	private static int CheckSkylightCubemapResolution_SrcFolderPath_Offset;

	private static bool CheckForUmappedFoliageCompsInLevels_IsValid;

	private static IntPtr CheckForUmappedFoliageCompsInLevels_FunctionAddress;

	private static int CheckForUmappedFoliageCompsInLevels_ParamsSize;

	private static bool CheckForUmappedFoliageCompsInLevels_SrcFolderPath_IsValid;

	private static FFieldAddress CheckForUmappedFoliageCompsInLevels_SrcFolderPath_PropertyAddress;

	private static int CheckForUmappedFoliageCompsInLevels_SrcFolderPath_Offset;

	private static bool CheckForUmappedFoliageComps_IsValid;

	private static IntPtr CheckForUmappedFoliageComps_FunctionAddress;

	private static int CheckForUmappedFoliageComps_ParamsSize;

	private static bool CheckForUmappedFoliageComps_InAsset_IsValid;

	private static FFieldAddress CheckForUmappedFoliageComps_InAsset_PropertyAddress;

	private static int CheckForUmappedFoliageComps_InAsset_Offset;

	private static bool CheckDuplicatedActorsForRemoval_IsValid;

	private static IntPtr CheckDuplicatedActorsForRemoval_FunctionAddress;

	private static int CheckDuplicatedActorsForRemoval_ParamsSize;

	private static bool CheckDuplicatedActorsForRemoval_SrcFolderPath_IsValid;

	private static FFieldAddress CheckDuplicatedActorsForRemoval_SrcFolderPath_PropertyAddress;

	private static int CheckDuplicatedActorsForRemoval_SrcFolderPath_Offset;

	private static bool CheckDuplicatedActorsForRemoval_SettingPtr_IsValid;

	private static FFieldAddress CheckDuplicatedActorsForRemoval_SettingPtr_PropertyAddress;

	private static int CheckDuplicatedActorsForRemoval_SettingPtr_Offset;

	private static bool CheckDuplicatedActorsForRemoval_bScanOnly_IsValid;

	private static FFieldAddress CheckDuplicatedActorsForRemoval_bScanOnly_PropertyAddress;

	private static int CheckDuplicatedActorsForRemoval_bScanOnly_Offset;

	private static bool CheckActorsNumAfterSplit_IsValid;

	private static IntPtr CheckActorsNumAfterSplit_FunctionAddress;

	private static int CheckActorsNumAfterSplit_ParamsSize;

	private static bool CheckActorsNumAfterSplit_SourceRootDirectory_IsValid;

	private static FFieldAddress CheckActorsNumAfterSplit_SourceRootDirectory_PropertyAddress;

	private static int CheckActorsNumAfterSplit_SourceRootDirectory_Offset;

	private static bool CheckActorsNumAfterSplit_bDebug_IsValid;

	private static FFieldAddress CheckActorsNumAfterSplit_bDebug_PropertyAddress;

	private static int CheckActorsNumAfterSplit_bDebug_Offset;

	private static bool CalculateLevelBounds_IsValid;

	private static IntPtr CalculateLevelBounds_FunctionAddress;

	private static int CalculateLevelBounds_ParamsSize;

	private static bool CalculateLevelBounds_InLevel_IsValid;

	private static FFieldAddress CalculateLevelBounds_InLevel_PropertyAddress;

	private static int CalculateLevelBounds_InLevel_Offset;

	private static bool CalculateLevelBounds_Origin_IsValid;

	private static FFieldAddress CalculateLevelBounds_Origin_PropertyAddress;

	private static int CalculateLevelBounds_Origin_Offset;

	private static bool CalculateLevelBounds_BoxExtent_IsValid;

	private static FFieldAddress CalculateLevelBounds_BoxExtent_PropertyAddress;

	private static int CalculateLevelBounds_BoxExtent_Offset;

	private static bool CalculateActorClassAndCount_IsValid;

	private static IntPtr CalculateActorClassAndCount_FunctionAddress;

	private static int CalculateActorClassAndCount_ParamsSize;

	private static bool CalculateActorClassAndCount_SourceRootDirectory_IsValid;

	private static FFieldAddress CalculateActorClassAndCount_SourceRootDirectory_PropertyAddress;

	private static int CalculateActorClassAndCount_SourceRootDirectory_Offset;

	private static bool CacheConsoleHistoryBuffer_IsValid;

	private static IntPtr CacheConsoleHistoryBuffer_FunctionAddress;

	private static int CacheConsoleHistoryBuffer_ParamsSize;

	private static bool CacheConsoleHistoryBuffer_ReturnValue_IsValid;

	private static FFieldAddress CacheConsoleHistoryBuffer_ReturnValue_PropertyAddress;

	private static int CacheConsoleHistoryBuffer_ReturnValue_Offset;

	private static bool BuildNavDataNoWC_IsValid;

	private static IntPtr BuildNavDataNoWC_FunctionAddress;

	private static int BuildNavDataNoWC_ParamsSize;

	private static bool BuildNavDataNoWC_MapName_IsValid;

	private static FFieldAddress BuildNavDataNoWC_MapName_PropertyAddress;

	private static int BuildNavDataNoWC_MapName_Offset;

	private static bool BuildNavDataNoWC_bNeedCheckout_IsValid;

	private static FFieldAddress BuildNavDataNoWC_bNeedCheckout_PropertyAddress;

	private static int BuildNavDataNoWC_bNeedCheckout_Offset;

	private static bool BuildNavDataNoWC_ReturnValue_IsValid;

	private static FFieldAddress BuildNavDataNoWC_ReturnValue_PropertyAddress;

	private static int BuildNavDataNoWC_ReturnValue_Offset;

	private static bool BuildNavData_IsValid;

	private static IntPtr BuildNavData_FunctionAddress;

	private static int BuildNavData_ParamsSize;

	private static bool BuildNavData_MapName_IsValid;

	private static FFieldAddress BuildNavData_MapName_PropertyAddress;

	private static int BuildNavData_MapName_Offset;

	private static bool BuildNavData_bNeedCheckout_IsValid;

	private static FFieldAddress BuildNavData_bNeedCheckout_PropertyAddress;

	private static int BuildNavData_bNeedCheckout_Offset;

	private static bool BuildNavData_ReturnValue_IsValid;

	private static FFieldAddress BuildNavData_ReturnValue_PropertyAddress;

	private static int BuildNavData_ReturnValue_Offset;

	private static bool AssembleTilesNamesForParallelTasks_IsValid;

	private static IntPtr AssembleTilesNamesForParallelTasks_FunctionAddress;

	private static int AssembleTilesNamesForParallelTasks_ParamsSize;

	private static bool AssembleTilesNamesForParallelTasks_RootDirectory_IsValid;

	private static FFieldAddress AssembleTilesNamesForParallelTasks_RootDirectory_PropertyAddress;

	private static int AssembleTilesNamesForParallelTasks_RootDirectory_Offset;

	private static bool AssembleTilesNamesForParallelTasks_InMapFilterNames_IsValid;

	private static FFieldAddress AssembleTilesNamesForParallelTasks_InMapFilterNames_PropertyAddress;

	private static int AssembleTilesNamesForParallelTasks_InMapFilterNames_Offset;

	private static bool AddFoliageTypeToLevelByLevelName_IsValid;

	private static IntPtr AddFoliageTypeToLevelByLevelName_FunctionAddress;

	private static int AddFoliageTypeToLevelByLevelName_ParamsSize;

	private static bool AddFoliageTypeToLevelByLevelName_LevelName_IsValid;

	private static FFieldAddress AddFoliageTypeToLevelByLevelName_LevelName_PropertyAddress;

	private static int AddFoliageTypeToLevelByLevelName_LevelName_Offset;

	private static bool AddFoliageTypeToLevelByLevelName_type_IsValid;

	private static FFieldAddress AddFoliageTypeToLevelByLevelName_type_PropertyAddress;

	private static int AddFoliageTypeToLevelByLevelName_type_Offset;

	private static bool AddFoliageTypeToLevelByLevelName_ReturnValue_IsValid;

	private static FFieldAddress AddFoliageTypeToLevelByLevelName_ReturnValue_PropertyAddress;

	private static int AddFoliageTypeToLevelByLevelName_ReturnValue_Offset;

	private static bool AddFoliageTypeToLevel_IsValid;

	private static IntPtr AddFoliageTypeToLevel_FunctionAddress;

	private static int AddFoliageTypeToLevel_ParamsSize;

	private static bool AddFoliageTypeToLevel_Level_IsValid;

	private static FFieldAddress AddFoliageTypeToLevel_Level_PropertyAddress;

	private static int AddFoliageTypeToLevel_Level_Offset;

	private static bool AddFoliageTypeToLevel_type_IsValid;

	private static FFieldAddress AddFoliageTypeToLevel_type_PropertyAddress;

	private static int AddFoliageTypeToLevel_type_Offset;

	private static bool AddFoliageTypeToLevel_ReturnValue_IsValid;

	private static FFieldAddress AddFoliageTypeToLevel_ReturnValue_PropertyAddress;

	private static int AddFoliageTypeToLevel_ReturnValue_Offset;

	private static bool AddFoliageInstanceDataToLevelByLevelName_IsValid;

	private static IntPtr AddFoliageInstanceDataToLevelByLevelName_FunctionAddress;

	private static int AddFoliageInstanceDataToLevelByLevelName_ParamsSize;

	private static bool AddFoliageInstanceDataToLevelByLevelName_LevelName_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevelByLevelName_LevelName_PropertyAddress;

	private static int AddFoliageInstanceDataToLevelByLevelName_LevelName_Offset;

	private static bool AddFoliageInstanceDataToLevelByLevelName_type_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevelByLevelName_type_PropertyAddress;

	private static int AddFoliageInstanceDataToLevelByLevelName_type_Offset;

	private static bool AddFoliageInstanceDataToLevelByLevelName_InstanceData_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevelByLevelName_InstanceData_PropertyAddress;

	private static int AddFoliageInstanceDataToLevelByLevelName_InstanceData_Offset;

	private static bool AddFoliageInstanceDataToLevel_IsValid;

	private static IntPtr AddFoliageInstanceDataToLevel_FunctionAddress;

	private static int AddFoliageInstanceDataToLevel_ParamsSize;

	private static bool AddFoliageInstanceDataToLevel_Level_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevel_Level_PropertyAddress;

	private static int AddFoliageInstanceDataToLevel_Level_Offset;

	private static bool AddFoliageInstanceDataToLevel_type_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevel_type_PropertyAddress;

	private static int AddFoliageInstanceDataToLevel_type_Offset;

	private static bool AddFoliageInstanceDataToLevel_InstanceData_IsValid;

	private static FFieldAddress AddFoliageInstanceDataToLevel_InstanceData_PropertyAddress;

	private static int AddFoliageInstanceDataToLevel_InstanceData_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:WorldGetCurrentLevel")]
	public unsafe static ULevel WorldGetCurrentLevel(UWorld World)
	{
		if (!WorldGetCurrentLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:WorldGetCurrentLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WorldGetCurrentLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WorldGetCurrentLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, WorldGetCurrentLevel_World_Offset), 0, WorldGetCurrentLevel_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WorldGetCurrentLevel_FunctionAddress, intPtr, WorldGetCurrentLevel_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, WorldGetCurrentLevel_ReturnValue_Offset), 0, WorldGetCurrentLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateSubLevelBounds")]
	public unsafe static void UpdateSubLevelBounds(string RootDirectory)
	{
		if (!UpdateSubLevelBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateSubLevelBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateSubLevelBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateSubLevelBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateSubLevelBounds_RootDirectory_Offset), 0, UpdateSubLevelBounds_RootDirectory_PropertyAddress.Address, RootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateSubLevelBounds_FunctionAddress, intPtr, UpdateSubLevelBounds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateSubLevelBounds_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateLevelBound")]
	public unsafe static void UpdateLevelBound(ALevelBounds InLevelBound)
	{
		if (!UpdateLevelBound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateLevelBound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateLevelBound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateLevelBound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelBounds>.ToNative(IntPtr.Add(intPtr, UpdateLevelBound_InLevelBound_Offset), 0, UpdateLevelBound_InLevelBound_PropertyAddress.Address, InLevelBound);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateLevelBound_FunctionAddress, intPtr, UpdateLevelBound_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateAllLevelBounds")]
	public unsafe static void UpdateAllLevelBounds(string RootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!UpdateAllLevelBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateAllLevelBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateAllLevelBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateAllLevelBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateAllLevelBounds_RootDirectory_Offset), 0, UpdateAllLevelBounds_RootDirectory_PropertyAddress.Address, RootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, UpdateAllLevelBounds_SettingPtr_Offset), 0, UpdateAllLevelBounds_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateAllLevelBounds_FunctionAddress, intPtr, UpdateAllLevelBounds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateAllLevelBounds_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:UnLoadStreamingLevelsIntoCurrentPersistent")]
	public unsafe static void UnLoadStreamingLevelsIntoCurrentPersistent(List<string> InSubLevelNames)
	{
		if (!UnLoadStreamingLevelsIntoCurrentPersistent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:UnLoadStreamingLevelsIntoCurrentPersistent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnLoadStreamingLevelsIntoCurrentPersistent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnLoadStreamingLevelsIntoCurrentPersistent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset), InSubLevelNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, intPtr, UnLoadStreamingLevelsIntoCurrentPersistent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:TranslateAllLevelActor")]
	public unsafe static int TranslateAllLevelActor(string LevelName, FVector WorldTranslate, List<TSubclassOf<UObject>> ExceptActorClasses)
	{
		if (!TranslateAllLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:TranslateAllLevelActor");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TranslateAllLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TranslateAllLevelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TranslateAllLevelActor_LevelName_Offset), 0, TranslateAllLevelActor_LevelName_PropertyAddress.Address, LevelName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, TranslateAllLevelActor_WorldTranslate_Offset), 0, TranslateAllLevelActor_WorldTranslate_PropertyAddress.Address, WorldTranslate);
		new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, TranslateAllLevelActor_ExceptActorClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, TranslateAllLevelActor_ExceptActorClasses_Offset), ExceptActorClasses);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TranslateAllLevelActor_FunctionAddress, intPtr, TranslateAllLevelActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TranslateAllLevelActor_LevelName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TranslateAllLevelActor_ExceptActorClasses_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, TranslateAllLevelActor_ReturnValue_Offset), 0, TranslateAllLevelActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllNoLandMeshVisibility")]
	public unsafe static void ToggleAllNoLandMeshVisibility()
	{
		if (!ToggleAllNoLandMeshVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllNoLandMeshVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleAllNoLandMeshVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleAllNoLandMeshVisibility_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ToggleAllNoLandMeshVisibility_FunctionAddress, argsSize: ToggleAllNoLandMeshVisibility_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllIKMeshVisibility")]
	public unsafe static void ToggleAllIKMeshVisibility()
	{
		if (!ToggleAllIKMeshVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllIKMeshVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleAllIKMeshVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleAllIKMeshVisibility_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ToggleAllIKMeshVisibility_FunctionAddress, argsSize: ToggleAllIKMeshVisibility_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleActorVisibilityInSceneOutliner")]
	public unsafe static void ToggleActorVisibilityInSceneOutliner(List<AActor> Actors)
	{
		if (!ToggleActorVisibilityInSceneOutliner_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleActorVisibilityInSceneOutliner");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToggleActorVisibilityInSceneOutliner_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToggleActorVisibilityInSceneOutliner_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ToggleActorVisibilityInSceneOutliner_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ToggleActorVisibilityInSceneOutliner_Actors_Offset), Actors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ToggleActorVisibilityInSceneOutliner_FunctionAddress, intPtr, ToggleActorVisibilityInSceneOutliner_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ToggleActorVisibilityInSceneOutliner_Actors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:TilesContainBlueprintClass")]
	public unsafe static bool TilesContainBlueprintClass(string SourceRootDirectory, out List<string> OutResults)
	{
		if (!TilesContainBlueprintClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:TilesContainBlueprintClass");
			OutResults = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TilesContainBlueprintClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TilesContainBlueprintClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TilesContainBlueprintClass_SourceRootDirectory_Offset), 0, TilesContainBlueprintClass_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TilesContainBlueprintClass_FunctionAddress, intPtr, TilesContainBlueprintClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TilesContainBlueprintClass_SourceRootDirectory_PropertyAddress.Address, intPtr);
		OutResults = new TArrayCopyMarshaler<string>(1, TilesContainBlueprintClass_OutResults_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, TilesContainBlueprintClass_OutResults_Offset));
		NativeReflection.DestroyValue_InContainer(TilesContainBlueprintClass_OutResults_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TilesContainBlueprintClass_ReturnValue_Offset), 0, TilesContainBlueprintClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:SpawnActor2SubLevel")]
	public unsafe static AActor SpawnActor2SubLevel(ULevel InSubLevel, TSubclassOf<UObject> InActorClass, FTransform InTransform, FName InName)
	{
		if (!SpawnActor2SubLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:SpawnActor2SubLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SpawnActor2SubLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SpawnActor2SubLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SpawnActor2SubLevel_InSubLevel_Offset), 0, SpawnActor2SubLevel_InSubLevel_PropertyAddress.Address, InSubLevel);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SpawnActor2SubLevel_InActorClass_Offset), 0, SpawnActor2SubLevel_InActorClass_PropertyAddress.Address, InActorClass);
		NativeReflection.InitializeValue_InContainer(SpawnActor2SubLevel_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SpawnActor2SubLevel_InTransform_Offset), 0, SpawnActor2SubLevel_InTransform_PropertyAddress.Address, InTransform);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SpawnActor2SubLevel_InName_Offset), 0, SpawnActor2SubLevel_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SpawnActor2SubLevel_FunctionAddress, intPtr, SpawnActor2SubLevel_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, SpawnActor2SubLevel_ReturnValue_Offset), 0, SpawnActor2SubLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ShowStreamingLevelsIntoCurrentPersistent")]
	public unsafe static void ShowStreamingLevelsIntoCurrentPersistent(List<string> InSubLevelNames)
	{
		if (!ShowStreamingLevelsIntoCurrentPersistent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ShowStreamingLevelsIntoCurrentPersistent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowStreamingLevelsIntoCurrentPersistent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowStreamingLevelsIntoCurrentPersistent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset), InSubLevelNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress, intPtr, ShowStreamingLevelsIntoCurrentPersistent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:SetBossRushLevelLayer")]
	public unsafe static void SetBossRushLevelLayer(UWorld InSubLevelWorld)
	{
		if (!SetBossRushLevelLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:SetBossRushLevelLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBossRushLevelLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBossRushLevelLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, SetBossRushLevelLayer_InSubLevelWorld_Offset), 0, SetBossRushLevelLayer_InSubLevelWorld_PropertyAddress.Address, InSubLevelWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBossRushLevelLayer_FunctionAddress, intPtr, SetBossRushLevelLayer_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:SetAllBossRushLevelLayer")]
	public unsafe static void SetAllBossRushLevelLayer(List<string> InLevelNameList)
	{
		if (!SetAllBossRushLevelLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:SetAllBossRushLevelLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllBossRushLevelLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllBossRushLevelLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, SetAllBossRushLevelLayer_InLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetAllBossRushLevelLayer_InLevelNameList_Offset), InLevelNameList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllBossRushLevelLayer_FunctionAddress, intPtr, SetAllBossRushLevelLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAllBossRushLevelLayer_InLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:SelectActorsByTag")]
	public unsafe static void SelectActorsByTag(FName Tag)
	{
		if (!SelectActorsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:SelectActorsByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectActorsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectActorsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SelectActorsByTag_Tag_Offset), 0, SelectActorsByTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectActorsByTag_FunctionAddress, intPtr, SelectActorsByTag_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanSpecifiedLevel")]
	public unsafe static void ScanSpecifiedLevel(string SourceRootDirectory, string InLevelName)
	{
		if (!ScanSpecifiedLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanSpecifiedLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanSpecifiedLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanSpecifiedLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanSpecifiedLevel_SourceRootDirectory_Offset), 0, ScanSpecifiedLevel_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanSpecifiedLevel_InLevelName_Offset), 0, ScanSpecifiedLevel_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanSpecifiedLevel_FunctionAddress, intPtr, ScanSpecifiedLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanSpecifiedLevel_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ScanSpecifiedLevel_InLevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanLevelsExceedThreshold")]
	public unsafe static void ScanLevelsExceedThreshold(string InRootDirectory, int InThresholdNum)
	{
		if (!ScanLevelsExceedThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanLevelsExceedThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanLevelsExceedThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanLevelsExceedThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanLevelsExceedThreshold_InRootDirectory_Offset), 0, ScanLevelsExceedThreshold_InRootDirectory_PropertyAddress.Address, InRootDirectory);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScanLevelsExceedThreshold_InThresholdNum_Offset), 0, ScanLevelsExceedThreshold_InThresholdNum_PropertyAddress.Address, InThresholdNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanLevelsExceedThreshold_FunctionAddress, intPtr, ScanLevelsExceedThreshold_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanLevelsExceedThreshold_InRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllTileLevels")]
	public unsafe static void ScanAllTileLevels(string SourceRootDirectory, int InScanMode)
	{
		if (!ScanAllTileLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllTileLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanAllTileLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanAllTileLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanAllTileLevels_SourceRootDirectory_Offset), 0, ScanAllTileLevels_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ScanAllTileLevels_InScanMode_Offset), 0, ScanAllTileLevels_InScanMode_PropertyAddress.Address, InScanMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanAllTileLevels_FunctionAddress, intPtr, ScanAllTileLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanAllTileLevels_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllStaticMeshesDistanceFieldInfo")]
	public unsafe static void ScanAllStaticMeshesDistanceFieldInfo(string RootDirectory, float DFSizeThreshold = 1f)
	{
		if (!ScanAllStaticMeshesDistanceFieldInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllStaticMeshesDistanceFieldInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanAllStaticMeshesDistanceFieldInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanAllStaticMeshesDistanceFieldInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_Offset), 0, ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_PropertyAddress.Address, RootDirectory);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_Offset), 0, ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_PropertyAddress.Address, DFSizeThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, intPtr, ScanAllStaticMeshesDistanceFieldInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:SaveLevel")]
	public unsafe static void SaveLevel(ULevel InLevel, bool bAutoCheckOut = true)
	{
		if (!SaveLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:SaveLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SaveLevel_InLevel_Offset), 0, SaveLevel_InLevel_PropertyAddress.Address, InLevel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveLevel_bAutoCheckOut_Offset), 0, SaveLevel_bAutoCheckOut_PropertyAddress.Address, bAutoCheckOut);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLevel_FunctionAddress, intPtr, SaveLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ResetActorToBlueprintDefaults")]
	public unsafe static int ResetActorToBlueprintDefaults(AActor Actor)
	{
		if (!ResetActorToBlueprintDefaults_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ResetActorToBlueprintDefaults");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetActorToBlueprintDefaults_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetActorToBlueprintDefaults_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ResetActorToBlueprintDefaults_Actor_Offset), 0, ResetActorToBlueprintDefaults_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ResetActorToBlueprintDefaults_FunctionAddress, intPtr, ResetActorToBlueprintDefaults_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ResetActorToBlueprintDefaults_ReturnValue_Offset), 0, ResetActorToBlueprintDefaults_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliageByLevelName")]
	public unsafe static void ReplaceFoliageByFoliageByLevelName(string LevelName, UFoliageType sourceFoliage, UFoliageType targetFoliage)
	{
		if (!ReplaceFoliageByFoliageByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliageByLevelName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceFoliageByFoliageByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceFoliageByFoliageByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliageByLevelName_LevelName_Offset), 0, ReplaceFoliageByFoliageByLevelName_LevelName_PropertyAddress.Address, LevelName);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliageByLevelName_sourceFoliage_Offset), 0, ReplaceFoliageByFoliageByLevelName_sourceFoliage_PropertyAddress.Address, sourceFoliage);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliageByLevelName_targetFoliage_Offset), 0, ReplaceFoliageByFoliageByLevelName_targetFoliage_PropertyAddress.Address, targetFoliage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceFoliageByFoliageByLevelName_FunctionAddress, intPtr, ReplaceFoliageByFoliageByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceFoliageByFoliageByLevelName_LevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliage")]
	public unsafe static void ReplaceFoliageByFoliage(ULevel Level, UFoliageType sourceFoliage, UFoliageType targetFoliage)
	{
		if (!ReplaceFoliageByFoliage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceFoliageByFoliage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceFoliageByFoliage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliage_Level_Offset), 0, ReplaceFoliageByFoliage_Level_PropertyAddress.Address, Level);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliage_sourceFoliage_Offset), 0, ReplaceFoliageByFoliage_sourceFoliage_PropertyAddress.Address, sourceFoliage);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, ReplaceFoliageByFoliage_targetFoliage_Offset), 0, ReplaceFoliageByFoliage_targetFoliage_PropertyAddress.Address, targetFoliage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceFoliageByFoliage_FunctionAddress, intPtr, ReplaceFoliageByFoliage_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevelByLevelName")]
	public unsafe static void RemoveFoliageTypeFromLevelByLevelName(string LevelName, UFoliageType type)
	{
		if (!RemoveFoliageTypeFromLevelByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevelByLevelName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFoliageTypeFromLevelByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFoliageTypeFromLevelByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveFoliageTypeFromLevelByLevelName_LevelName_Offset), 0, RemoveFoliageTypeFromLevelByLevelName_LevelName_PropertyAddress.Address, LevelName);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, RemoveFoliageTypeFromLevelByLevelName_type_Offset), 0, RemoveFoliageTypeFromLevelByLevelName_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, intPtr, RemoveFoliageTypeFromLevelByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveFoliageTypeFromLevelByLevelName_LevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevel")]
	public unsafe static void RemoveFoliageTypeFromLevel(ULevel Level, UFoliageType type)
	{
		if (!RemoveFoliageTypeFromLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFoliageTypeFromLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFoliageTypeFromLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, RemoveFoliageTypeFromLevel_Level_Offset), 0, RemoveFoliageTypeFromLevel_Level_PropertyAddress.Address, Level);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, RemoveFoliageTypeFromLevel_type_Offset), 0, RemoveFoliageTypeFromLevel_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveFoliageTypeFromLevel_FunctionAddress, intPtr, RemoveFoliageTypeFromLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyStaticMeshActor")]
	public unsafe static void RemoveEmptyStaticMeshActor()
	{
		if (!RemoveEmptyStaticMeshActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyStaticMeshActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEmptyStaticMeshActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEmptyStaticMeshActor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RemoveEmptyStaticMeshActor_FunctionAddress, argsSize: RemoveEmptyStaticMeshActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyInstancedFoliageActor")]
	public unsafe static void RemoveEmptyInstancedFoliageActor()
	{
		if (!RemoveEmptyInstancedFoliageActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyInstancedFoliageActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEmptyInstancedFoliageActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEmptyInstancedFoliageActor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: RemoveEmptyInstancedFoliageActor_FunctionAddress, argsSize: RemoveEmptyInstancedFoliageActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyFoliageInfo")]
	public unsafe static bool RemoveEmptyFoliageInfo()
	{
		if (!RemoveEmptyFoliageInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyFoliageInfo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveEmptyFoliageInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveEmptyFoliageInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveEmptyFoliageInfo_FunctionAddress, intPtr, RemoveEmptyFoliageInfo_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveEmptyFoliageInfo_ReturnValue_Offset), 0, RemoveEmptyFoliageInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevels")]
	public unsafe static void RemapFoliageTypeAndCompsInLevels(string SrcFolderPath)
	{
		if (!RemapFoliageTypeAndCompsInLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemapFoliageTypeAndCompsInLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemapFoliageTypeAndCompsInLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemapFoliageTypeAndCompsInLevels_SrcFolderPath_Offset), 0, RemapFoliageTypeAndCompsInLevels_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemapFoliageTypeAndCompsInLevels_FunctionAddress, intPtr, RemapFoliageTypeAndCompsInLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemapFoliageTypeAndCompsInLevels_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevel")]
	public unsafe static void RemapFoliageTypeAndCompsInLevel(ULevel TargetLevel)
	{
		if (!RemapFoliageTypeAndCompsInLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemapFoliageTypeAndCompsInLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemapFoliageTypeAndCompsInLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, RemapFoliageTypeAndCompsInLevel_TargetLevel_Offset), 0, RemapFoliageTypeAndCompsInLevel_TargetLevel_PropertyAddress.Address, TargetLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemapFoliageTypeAndCompsInLevel_FunctionAddress, intPtr, RemapFoliageTypeAndCompsInLevel_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndComps")]
	public unsafe static void RemapFoliageTypeAndComps(FAssetData InAsset)
	{
		if (!RemapFoliageTypeAndComps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndComps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemapFoliageTypeAndComps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemapFoliageTypeAndComps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemapFoliageTypeAndComps_InAsset_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, RemapFoliageTypeAndComps_InAsset_Offset), 0, RemapFoliageTypeAndComps_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemapFoliageTypeAndComps_FunctionAddress, intPtr, RemapFoliageTypeAndComps_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemapFoliageTypeAndComps_InAsset_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshViewportLocation")]
	public unsafe static void RefreshViewportLocation(FVector CamPos)
	{
		if (!RefreshViewportLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshViewportLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshViewportLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshViewportLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RefreshViewportLocation_CamPos_Offset), 0, RefreshViewportLocation_CamPos_PropertyAddress.Address, CamPos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RefreshViewportLocation_FunctionAddress, intPtr, RefreshViewportLocation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshTileLevelsHierarchy")]
	public unsafe static void RefreshTileLevelsHierarchy(string InPersistentLevelPath)
	{
		if (!RefreshTileLevelsHierarchy_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshTileLevelsHierarchy");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshTileLevelsHierarchy_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshTileLevelsHierarchy_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RefreshTileLevelsHierarchy_InPersistentLevelPath_Offset), 0, RefreshTileLevelsHierarchy_InPersistentLevelPath_PropertyAddress.Address, InPersistentLevelPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RefreshTileLevelsHierarchy_FunctionAddress, intPtr, RefreshTileLevelsHierarchy_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RefreshTileLevelsHierarchy_InPersistentLevelPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ProcessPerActorLODSettings")]
	public unsafe static void ProcessPerActorLODSettings(string SrcFolderPath, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!ProcessPerActorLODSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ProcessPerActorLODSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessPerActorLODSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessPerActorLODSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ProcessPerActorLODSettings_SrcFolderPath_Offset), 0, ProcessPerActorLODSettings_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, ProcessPerActorLODSettings_SettingPtr_Offset), 0, ProcessPerActorLODSettings_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ProcessPerActorLODSettings_FunctionAddress, intPtr, ProcessPerActorLODSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessPerActorLODSettings_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesStatsInfo")]
	public unsafe static void PrintTilesStatsInfo(string RootDirectory)
	{
		if (!PrintTilesStatsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesStatsInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintTilesStatsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintTilesStatsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrintTilesStatsInfo_RootDirectory_Offset), 0, PrintTilesStatsInfo_RootDirectory_PropertyAddress.Address, RootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrintTilesStatsInfo_FunctionAddress, intPtr, PrintTilesStatsInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrintTilesStatsInfo_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesSkippability")]
	public unsafe static void PrintTilesSkippability(string RootDirectory)
	{
		if (!PrintTilesSkippability_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesSkippability");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintTilesSkippability_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintTilesSkippability_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrintTilesSkippability_RootDirectory_Offset), 0, PrintTilesSkippability_RootDirectory_PropertyAddress.Address, RootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PrintTilesSkippability_FunctionAddress, intPtr, PrintTilesSkippability_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrintTilesSkippability_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:PostProcessTileData")]
	public unsafe static void PostProcessTileData(string SourceRootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!PostProcessTileData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:PostProcessTileData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostProcessTileData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostProcessTileData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostProcessTileData_SourceRootDirectory_Offset), 0, PostProcessTileData_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, PostProcessTileData_SettingPtr_Offset), 0, PostProcessTileData_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostProcessTileData_FunctionAddress, intPtr, PostProcessTileData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostProcessTileData_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveAllFoliageInstancesToTargetWorld")]
	public unsafe static void MoveAllFoliageInstancesToTargetWorld(string TargetMapPackageName)
	{
		if (!MoveAllFoliageInstancesToTargetWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveAllFoliageInstancesToTargetWorld");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveAllFoliageInstancesToTargetWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveAllFoliageInstancesToTargetWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_Offset), 0, MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_PropertyAddress.Address, TargetMapPackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveAllFoliageInstancesToTargetWorld_FunctionAddress, intPtr, MoveAllFoliageInstancesToTargetWorld_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackToDominantLevel")]
	public unsafe static bool MoveActorsBackToDominantLevel(string SourceRootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!MoveActorsBackToDominantLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackToDominantLevel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveActorsBackToDominantLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveActorsBackToDominantLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoveActorsBackToDominantLevel_SourceRootDirectory_Offset), 0, MoveActorsBackToDominantLevel_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, MoveActorsBackToDominantLevel_SettingPtr_Offset), 0, MoveActorsBackToDominantLevel_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveActorsBackToDominantLevel_FunctionAddress, intPtr, MoveActorsBackToDominantLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MoveActorsBackToDominantLevel_SourceRootDirectory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MoveActorsBackToDominantLevel_ReturnValue_Offset), 0, MoveActorsBackToDominantLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackAndCacheActorsInfo")]
	public unsafe static bool MoveActorsBackAndCacheActorsInfo(string SourceRootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!MoveActorsBackAndCacheActorsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackAndCacheActorsInfo");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveActorsBackAndCacheActorsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveActorsBackAndCacheActorsInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_Offset), 0, MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, MoveActorsBackAndCacheActorsInfo_SettingPtr_Offset), 0, MoveActorsBackAndCacheActorsInfo_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveActorsBackAndCacheActorsInfo_FunctionAddress, intPtr, MoveActorsBackAndCacheActorsInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MoveActorsBackAndCacheActorsInfo_ReturnValue_Offset), 0, MoveActorsBackAndCacheActorsInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ModifyNameForActors")]
	public unsafe static void ModifyNameForActors(List<AActor> Actors, string replaceStr, string NewStr, bool NotFitGoAppend)
	{
		if (!ModifyNameForActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ModifyNameForActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ModifyNameForActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ModifyNameForActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, ModifyNameForActors_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ModifyNameForActors_Actors_Offset), Actors);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyNameForActors_replaceStr_Offset), 0, ModifyNameForActors_replaceStr_PropertyAddress.Address, replaceStr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ModifyNameForActors_NewStr_Offset), 0, ModifyNameForActors_NewStr_PropertyAddress.Address, NewStr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ModifyNameForActors_NotFitGoAppend_Offset), 0, ModifyNameForActors_NotFitGoAppend_PropertyAddress.Address, NotFitGoAppend);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ModifyNameForActors_FunctionAddress, intPtr, ModifyNameForActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ModifyNameForActors_Actors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyNameForActors_replaceStr_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ModifyNameForActors_NewStr_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:MakeLevelNameDecorateLevelActor")]
	public unsafe static void MakeLevelNameDecorateLevelActor()
	{
		if (!MakeLevelNameDecorateLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:MakeLevelNameDecorateLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeLevelNameDecorateLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeLevelNameDecorateLevelActor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: MakeLevelNameDecorateLevelActor_FunctionAddress, argsSize: MakeLevelNameDecorateLevelActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadWCTileMapSettings")]
	public unsafe static UGSWCSettingsDataAsset LoadWCTileMapSettings(string MapFolder, bool bDebugLog = false)
	{
		if (!LoadWCTileMapSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadWCTileMapSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadWCTileMapSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadWCTileMapSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadWCTileMapSettings_MapFolder_Offset), 0, LoadWCTileMapSettings_MapFolder_PropertyAddress.Address, MapFolder);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, LoadWCTileMapSettings_bDebugLog_Offset), 0, LoadWCTileMapSettings_bDebugLog_PropertyAddress.Address, bDebugLog);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadWCTileMapSettings_FunctionAddress, intPtr, LoadWCTileMapSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadWCTileMapSettings_MapFolder_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UGSWCSettingsDataAsset>.FromNative(IntPtr.Add(intPtr, LoadWCTileMapSettings_ReturnValue_Offset), 0, LoadWCTileMapSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadStreamingLevelsIntoCurrentPersistent")]
	public unsafe static void LoadStreamingLevelsIntoCurrentPersistent(List<string> InSubLevelNames)
	{
		if (!LoadStreamingLevelsIntoCurrentPersistent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadStreamingLevelsIntoCurrentPersistent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadStreamingLevelsIntoCurrentPersistent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadStreamingLevelsIntoCurrentPersistent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset), InSubLevelNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, intPtr, LoadStreamingLevelsIntoCurrentPersistent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadAllWCLevels")]
	public unsafe static void LoadAllWCLevels(UWorld InWorld)
	{
		if (!LoadAllWCLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadAllWCLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAllWCLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAllWCLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, LoadAllWCLevels_InWorld_Offset), 0, LoadAllWCLevels_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadAllWCLevels_FunctionAddress, intPtr, LoadAllWCLevels_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:HideStreamingLevelsIntoCurrentPersistent")]
	public unsafe static void HideStreamingLevelsIntoCurrentPersistent(List<string> InSubLevelNames)
	{
		if (!HideStreamingLevelsIntoCurrentPersistent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:HideStreamingLevelsIntoCurrentPersistent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideStreamingLevelsIntoCurrentPersistent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideStreamingLevelsIntoCurrentPersistent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset), InSubLevelNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HideStreamingLevelsIntoCurrentPersistent_FunctionAddress, intPtr, HideStreamingLevelsIntoCurrentPersistent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:HideAllWCLevels")]
	public unsafe static void HideAllWCLevels(UWorld InWorld)
	{
		if (!HideAllWCLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:HideAllWCLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HideAllWCLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HideAllWCLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, HideAllWCLevels_InWorld_Offset), 0, HideAllWCLevels_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HideAllWCLevels_FunctionAddress, intPtr, HideAllWCLevels_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActorsSimple")]
	public unsafe static void GSWCReorganizeActorsSimple(string SourceRootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!GSWCReorganizeActorsSimple_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActorsSimple");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSWCReorganizeActorsSimple_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSWCReorganizeActorsSimple_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSWCReorganizeActorsSimple_SourceRootDirectory_Offset), 0, GSWCReorganizeActorsSimple_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, GSWCReorganizeActorsSimple_SettingPtr_Offset), 0, GSWCReorganizeActorsSimple_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSWCReorganizeActorsSimple_FunctionAddress, intPtr, GSWCReorganizeActorsSimple_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSWCReorganizeActorsSimple_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActors")]
	public unsafe static void GSWCReorganizeActors(string SourceRootDirectory, UGSWCSettingsDataAsset SettingPtr)
	{
		if (!GSWCReorganizeActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GSWCReorganizeActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GSWCReorganizeActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GSWCReorganizeActors_SourceRootDirectory_Offset), 0, GSWCReorganizeActors_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, GSWCReorganizeActors_SettingPtr_Offset), 0, GSWCReorganizeActors_SettingPtr_PropertyAddress.Address, SettingPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GSWCReorganizeActors_FunctionAddress, intPtr, GSWCReorganizeActors_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GSWCReorganizeActors_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetWorldContext")]
	public unsafe static UObject GetWorldContext()
	{
		if (!GetWorldContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetWorldContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetWorldContext_FunctionAddress, intPtr, GetWorldContext_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetWorldContext_ReturnValue_Offset), 0, GetWorldContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportXY")]
	public unsafe static FVector2D GetViewportXY()
	{
		if (!GetViewportXY_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportXY");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportXY_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportXY_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportXY_FunctionAddress, intPtr, GetViewportXY_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewportXY_ReturnValue_Offset), 0, GetViewportXY_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportLocation")]
	public unsafe static FVector GetViewportLocation()
	{
		if (!GetViewportLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetViewportLocation_FunctionAddress, intPtr, GetViewportLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetViewportLocation_ReturnValue_Offset), 0, GetViewportLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetSelectedActors")]
	public unsafe static List<AActor> GetSelectedActors()
	{
		if (!GetSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetSelectedActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSelectedActors_FunctionAddress, intPtr, GetSelectedActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetSelectedActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSelectedActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSelectedActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetOrthoUnitsPerPixel")]
	public unsafe static float GetOrthoUnitsPerPixel()
	{
		if (!GetOrthoUnitsPerPixel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetOrthoUnitsPerPixel");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOrthoUnitsPerPixel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOrthoUnitsPerPixel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOrthoUnitsPerPixel_FunctionAddress, intPtr, GetOrthoUnitsPerPixel_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetOrthoUnitsPerPixel_ReturnValue_Offset), 0, GetOrthoUnitsPerPixel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelsInWorld")]
	public unsafe static void GetLevelsInWorld(UWorld CurWorld, out List<string> OutSubLevels)
	{
		if (!GetLevelsInWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelsInWorld");
			OutSubLevels = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelsInWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelsInWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetLevelsInWorld_CurWorld_Offset), 0, GetLevelsInWorld_CurWorld_PropertyAddress.Address, CurWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelsInWorld_FunctionAddress, intPtr, GetLevelsInWorld_ParamsSize);
		OutSubLevels = new TArrayCopyMarshaler<string>(1, GetLevelsInWorld_OutSubLevels_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelsInWorld_OutSubLevels_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelsInWorld_OutSubLevels_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevels")]
	public unsafe static List<ULevel> GetLevels(UWorld World)
	{
		if (!GetLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetLevels_World_Offset), 0, GetLevels_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevels_FunctionAddress, intPtr, GetLevels_ParamsSize);
		List<ULevel> result = new TArrayCopyMarshaler<ULevel>(1, GetLevels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.FromNative, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelByName")]
	public unsafe static ULevel GetLevelByName(string LevelName)
	{
		if (!GetLevelByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetLevelByName_LevelName_Offset), 0, GetLevelByName_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelByName_FunctionAddress, intPtr, GetLevelByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelByName_LevelName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, GetLevelByName_ReturnValue_Offset), 0, GetLevelByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelBoundsFromAsset")]
	public unsafe static FBox GetLevelBoundsFromAsset(FAssetData Asset)
	{
		if (!GetLevelBoundsFromAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelBoundsFromAsset");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelBoundsFromAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelBoundsFromAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLevelBoundsFromAsset_Asset_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, GetLevelBoundsFromAsset_Asset_Offset), 0, GetLevelBoundsFromAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelBoundsFromAsset_FunctionAddress, intPtr, GetLevelBoundsFromAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetLevelBoundsFromAsset_Asset_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetLevelBoundsFromAsset_ReturnValue_Offset), 0, GetLevelBoundsFromAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelAllActors")]
	public unsafe static List<AActor> GetLevelAllActors(ULevel Level)
	{
		if (!GetLevelAllActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelAllActors");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelAllActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelAllActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GetLevelAllActors_Level_Offset), 0, GetLevelAllActors_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelAllActors_FunctionAddress, intPtr, GetLevelAllActors_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetLevelAllActors_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelAllActors_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelAllActors_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetGSWCItemLevels")]
	public unsafe static bool GetGSWCItemLevels(string SrcFolderPath, out List<FAssetData> OutItemLevelAssets)
	{
		if (!GetGSWCItemLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetGSWCItemLevels");
			OutItemLevelAssets = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGSWCItemLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGSWCItemLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetGSWCItemLevels_SrcFolderPath_Offset), 0, GetGSWCItemLevels_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGSWCItemLevels_FunctionAddress, intPtr, GetGSWCItemLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetGSWCItemLevels_SrcFolderPath_PropertyAddress.Address, intPtr);
		OutItemLevelAssets = new TArrayCopyMarshaler<FAssetData>(1, GetGSWCItemLevels_OutItemLevelAssets_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetGSWCItemLevels_OutItemLevelAssets_Offset));
		NativeReflection.DestroyValue_InContainer(GetGSWCItemLevels_OutItemLevelAssets_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetGSWCItemLevels_ReturnValue_Offset), 0, GetGSWCItemLevels_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevelByLevelName")]
	public unsafe static List<FFoliageInstanceData> GetFoliageInstanceDataFromLevelByLevelName(string LevelName, UFoliageType type)
	{
		if (!GetFoliageInstanceDataFromLevelByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevelByLevelName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFoliageInstanceDataFromLevelByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFoliageInstanceDataFromLevelByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevelByLevelName_LevelName_Offset), 0, GetFoliageInstanceDataFromLevelByLevelName_LevelName_PropertyAddress.Address, LevelName);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevelByLevelName_type_Offset), 0, GetFoliageInstanceDataFromLevelByLevelName_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, intPtr, GetFoliageInstanceDataFromLevelByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFoliageInstanceDataFromLevelByLevelName_LevelName_PropertyAddress.Address, intPtr);
		List<FFoliageInstanceData> result = new TArrayCopyMarshaler<FFoliageInstanceData>(1, GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).FromNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevel")]
	public unsafe static List<FFoliageInstanceData> GetFoliageInstanceDataFromLevel(ULevel Level, UFoliageType type)
	{
		if (!GetFoliageInstanceDataFromLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFoliageInstanceDataFromLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFoliageInstanceDataFromLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevel_Level_Offset), 0, GetFoliageInstanceDataFromLevel_Level_PropertyAddress.Address, Level);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevel_type_Offset), 0, GetFoliageInstanceDataFromLevel_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFoliageInstanceDataFromLevel_FunctionAddress, intPtr, GetFoliageInstanceDataFromLevel_ParamsSize);
		List<FFoliageInstanceData> result = new TArrayCopyMarshaler<FFoliageInstanceData>(1, GetFoliageInstanceDataFromLevel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).FromNative(IntPtr.Add(intPtr, GetFoliageInstanceDataFromLevel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetFoliageInstanceDataFromLevel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelWorld")]
	public unsafe static UWorld GetCurrentPersistentLevelWorld()
	{
		if (!GetCurrentPersistentLevelWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPersistentLevelWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPersistentLevelWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentPersistentLevelWorld_FunctionAddress, intPtr, GetCurrentPersistentLevelWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetCurrentPersistentLevelWorld_ReturnValue_Offset), 0, GetCurrentPersistentLevelWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelName")]
	public unsafe static string GetCurrentPersistentLevelName()
	{
		if (!GetCurrentPersistentLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPersistentLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPersistentLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentPersistentLevelName_FunctionAddress, intPtr, GetCurrentPersistentLevelName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCurrentPersistentLevelName_ReturnValue_Offset), 0, GetCurrentPersistentLevelName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentPersistentLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentAllWCLevelsName")]
	public unsafe static void GetCurrentAllWCLevelsName(out List<string> OutLevelsName, bool bIgnoreWCTile = true)
	{
		if (!GetCurrentAllWCLevelsName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentAllWCLevelsName");
			OutLevelsName = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentAllWCLevelsName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentAllWCLevelsName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetCurrentAllWCLevelsName_bIgnoreWCTile_Offset), 0, GetCurrentAllWCLevelsName_bIgnoreWCTile_PropertyAddress.Address, bIgnoreWCTile);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentAllWCLevelsName_FunctionAddress, intPtr, GetCurrentAllWCLevelsName_ParamsSize);
		OutLevelsName = new TArrayCopyMarshaler<string>(1, GetCurrentAllWCLevelsName_OutLevelsName_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetCurrentAllWCLevelsName_OutLevelsName_Offset));
		NativeReflection.DestroyValue_InContainer(GetCurrentAllWCLevelsName_OutLevelsName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllWorlds")]
	public unsafe static List<AActor> GetAllActorsInsideInBoxInAllWorlds(FBox encloseBox, List<UWorld> allWorld, float LimitComponentNum, float filterSizePercent, bool bMustLevelBoundsRelevant)
	{
		if (!GetAllActorsInsideInBoxInAllWorlds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllWorlds");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsInsideInBoxInAllWorlds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsInsideInBoxInAllWorlds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_encloseBox_Offset), 0, GetAllActorsInsideInBoxInAllWorlds_encloseBox_PropertyAddress.Address, encloseBox);
		new TArrayCopyMarshaler<UWorld>(1, GetAllActorsInsideInBoxInAllWorlds_allWorld_PropertyAddress, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.FromNative, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_allWorld_Offset), allWorld);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_Offset), 0, GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_PropertyAddress.Address, LimitComponentNum);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_Offset), 0, GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_PropertyAddress.Address, filterSizePercent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_Offset), 0, GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_PropertyAddress.Address, bMustLevelBoundsRelevant);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, intPtr, GetAllActorsInsideInBoxInAllWorlds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllActorsInsideInBoxInAllWorlds_allWorld_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllActorsInsideInBoxInAllWorlds_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllWorlds_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsInsideInBoxInAllWorlds_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllLevels")]
	public unsafe static List<AActor> GetAllActorsInsideInBoxInAllLevels(FBox encloseBox, List<ULevel> allLevel, float LimitComponentNum, float filterSizePercent, bool bMustLevelBoundsRelevant)
	{
		if (!GetAllActorsInsideInBoxInAllLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllLevels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsInsideInBoxInAllLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsInsideInBoxInAllLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_encloseBox_Offset), 0, GetAllActorsInsideInBoxInAllLevels_encloseBox_PropertyAddress.Address, encloseBox);
		new TArrayCopyMarshaler<ULevel>(1, GetAllActorsInsideInBoxInAllLevels_allLevel_PropertyAddress, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.FromNative, CachedMarshalingDelegates<ULevel, UObjectMarshaler<ULevel>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_allLevel_Offset), allLevel);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_Offset), 0, GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_PropertyAddress.Address, LimitComponentNum);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_filterSizePercent_Offset), 0, GetAllActorsInsideInBoxInAllLevels_filterSizePercent_PropertyAddress.Address, filterSizePercent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_Offset), 0, GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_PropertyAddress.Address, bMustLevelBoundsRelevant);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, intPtr, GetAllActorsInsideInBoxInAllLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllActorsInsideInBoxInAllLevels_allLevel_PropertyAddress.Address, intPtr);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllActorsInsideInBoxInAllLevels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsInsideInBoxInAllLevels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsInsideInBoxInAllLevels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GetActorListByDistanceSignificance")]
	public unsafe static List<AActor> GetActorListByDistanceSignificance(AActor OriginalActor, float traceRadius = 10000f)
	{
		if (!GetActorListByDistanceSignificance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GetActorListByDistanceSignificance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorListByDistanceSignificance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorListByDistanceSignificance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorListByDistanceSignificance_OriginalActor_Offset), 0, GetActorListByDistanceSignificance_OriginalActor_PropertyAddress.Address, OriginalActor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetActorListByDistanceSignificance_traceRadius_Offset), 0, GetActorListByDistanceSignificance_traceRadius_PropertyAddress.Address, traceRadius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorListByDistanceSignificance_FunctionAddress, intPtr, GetActorListByDistanceSignificance_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetActorListByDistanceSignificance_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetActorListByDistanceSignificance_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetActorListByDistanceSignificance_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateWCTileConfig")]
	public unsafe static void GenerateWCTileConfig(string SrcFolderPath, EWCSerializeMode InSerializeMode = EWCSerializeMode.All)
	{
		if (!GenerateWCTileConfig_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateWCTileConfig");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateWCTileConfig_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateWCTileConfig_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateWCTileConfig_SrcFolderPath_Offset), 0, GenerateWCTileConfig_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		EnumMarshaler<EWCSerializeMode>.ToNative(IntPtr.Add(intPtr, GenerateWCTileConfig_InSerializeMode_Offset), 0, GenerateWCTileConfig_InSerializeMode_PropertyAddress.Address, InSerializeMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateWCTileConfig_FunctionAddress, intPtr, GenerateWCTileConfig_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateWCTileConfig_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateMapTileLODs")]
	public unsafe static bool GenerateMapTileLODs(string SrcFolderPath, List<string> InMapFilterNames, UGSWCSettingsDataAsset SettingsPtr, string PersistentLevelName, bool bRequiredPreLevelGC = true)
	{
		if (!GenerateMapTileLODs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateMapTileLODs");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateMapTileLODs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateMapTileLODs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateMapTileLODs_SrcFolderPath_Offset), 0, GenerateMapTileLODs_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		new TArrayCopyMarshaler<string>(1, GenerateMapTileLODs_InMapFilterNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GenerateMapTileLODs_InMapFilterNames_Offset), InMapFilterNames);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, GenerateMapTileLODs_SettingsPtr_Offset), 0, GenerateMapTileLODs_SettingsPtr_PropertyAddress.Address, SettingsPtr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateMapTileLODs_PersistentLevelName_Offset), 0, GenerateMapTileLODs_PersistentLevelName_PropertyAddress.Address, PersistentLevelName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GenerateMapTileLODs_bRequiredPreLevelGC_Offset), 0, GenerateMapTileLODs_bRequiredPreLevelGC_PropertyAddress.Address, bRequiredPreLevelGC);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenerateMapTileLODs_FunctionAddress, intPtr, GenerateMapTileLODs_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenerateMapTileLODs_SrcFolderPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GenerateMapTileLODs_InMapFilterNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GenerateMapTileLODs_PersistentLevelName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GenerateMapTileLODs_ReturnValue_Offset), 0, GenerateMapTileLODs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ForceAllLevelGC")]
	public unsafe static void ForceAllLevelGC()
	{
		if (!ForceAllLevelGC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ForceAllLevelGC");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceAllLevelGC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceAllLevelGC_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ForceAllLevelGC_FunctionAddress, argsSize: ForceAllLevelGC_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:FixNormalTilesTreeIssues")]
	public unsafe static void FixNormalTilesTreeIssues(string RootDirectory)
	{
		if (!FixNormalTilesTreeIssues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:FixNormalTilesTreeIssues");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixNormalTilesTreeIssues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixNormalTilesTreeIssues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FixNormalTilesTreeIssues_RootDirectory_Offset), 0, FixNormalTilesTreeIssues_RootDirectory_PropertyAddress.Address, RootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixNormalTilesTreeIssues_FunctionAddress, intPtr, FixNormalTilesTreeIssues_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FixNormalTilesTreeIssues_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:FixLevelActorAffectNavData")]
	public unsafe static void FixLevelActorAffectNavData(string PointsFilePath, float ToleranceDistance = 3000f)
	{
		if (!FixLevelActorAffectNavData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:FixLevelActorAffectNavData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixLevelActorAffectNavData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixLevelActorAffectNavData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FixLevelActorAffectNavData_PointsFilePath_Offset), 0, FixLevelActorAffectNavData_PointsFilePath_PropertyAddress.Address, PointsFilePath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FixLevelActorAffectNavData_ToleranceDistance_Offset), 0, FixLevelActorAffectNavData_ToleranceDistance_PropertyAddress.Address, ToleranceDistance);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixLevelActorAffectNavData_FunctionAddress, intPtr, FixLevelActorAffectNavData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FixLevelActorAffectNavData_PointsFilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ExportLevel")]
	public unsafe static void ExportLevel(bool bExportSelectedActorsOnly)
	{
		if (!ExportLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ExportLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportLevel_bExportSelectedActorsOnly_Offset), 0, ExportLevel_bExportSelectedActorsOnly_PropertyAddress.Address, bExportSelectedActorsOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportLevel_FunctionAddress, intPtr, ExportLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:EmptySelectedActorsOverrideMaterials")]
	public unsafe static void EmptySelectedActorsOverrideMaterials()
	{
		if (!EmptySelectedActorsOverrideMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:EmptySelectedActorsOverrideMaterials");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EmptySelectedActorsOverrideMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EmptySelectedActorsOverrideMaterials_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: EmptySelectedActorsOverrideMaterials_FunctionAddress, argsSize: EmptySelectedActorsOverrideMaterials_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateSelectedActors")]
	public unsafe static void DuplicateSelectedActors(UWorld InWorld)
	{
		if (!DuplicateSelectedActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateSelectedActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateSelectedActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateSelectedActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DuplicateSelectedActors_InWorld_Offset), 0, DuplicateSelectedActors_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateSelectedActors_FunctionAddress, intPtr, DuplicateSelectedActors_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateAllLevels")]
	public unsafe static List<UWorld> DuplicateAllLevels(string SourceRootDirectory, string DestRootDirectory, string newPrefix, string LevelStreamingNameRetargetSrc, string LevelStreamingNameRetargetDest, bool needRescan)
	{
		if (!DuplicateAllLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateAllLevels");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAllLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAllLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_SourceRootDirectory_Offset), 0, DuplicateAllLevels_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_DestRootDirectory_Offset), 0, DuplicateAllLevels_DestRootDirectory_PropertyAddress.Address, DestRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_newPrefix_Offset), 0, DuplicateAllLevels_newPrefix_PropertyAddress.Address, newPrefix);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_LevelStreamingNameRetargetSrc_Offset), 0, DuplicateAllLevels_LevelStreamingNameRetargetSrc_PropertyAddress.Address, LevelStreamingNameRetargetSrc);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_LevelStreamingNameRetargetDest_Offset), 0, DuplicateAllLevels_LevelStreamingNameRetargetDest_PropertyAddress.Address, LevelStreamingNameRetargetDest);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAllLevels_needRescan_Offset), 0, DuplicateAllLevels_needRescan_PropertyAddress.Address, needRescan);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateAllLevels_FunctionAddress, intPtr, DuplicateAllLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_DestRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_newPrefix_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_LevelStreamingNameRetargetSrc_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_LevelStreamingNameRetargetDest_PropertyAddress.Address, intPtr);
		List<UWorld> result = new TArrayCopyMarshaler<UWorld>(1, DuplicateAllLevels_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.FromNative, CachedMarshalingDelegates<UWorld, UObjectMarshaler<UWorld>>.ToNative).FromNative(IntPtr.Add(intPtr, DuplicateAllLevels_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(DuplicateAllLevels_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpSelectedActorBoundsInfo")]
	public unsafe static void DumpSelectedActorBoundsInfo()
	{
		if (!DumpSelectedActorBoundsInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpSelectedActorBoundsInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DumpSelectedActorBoundsInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DumpSelectedActorBoundsInfo_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: DumpSelectedActorBoundsInfo_FunctionAddress, argsSize: DumpSelectedActorBoundsInfo_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpLandscapeHeightMapAndWeightMap")]
	public unsafe static bool DumpLandscapeHeightMapAndWeightMap(ALandscapeProxy ProxyActor)
	{
		if (!DumpLandscapeHeightMapAndWeightMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpLandscapeHeightMapAndWeightMap");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DumpLandscapeHeightMapAndWeightMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DumpLandscapeHeightMapAndWeightMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALandscapeProxy>.ToNative(IntPtr.Add(intPtr, DumpLandscapeHeightMapAndWeightMap_ProxyActor_Offset), 0, DumpLandscapeHeightMapAndWeightMap_ProxyActor_PropertyAddress.Address, ProxyActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DumpLandscapeHeightMapAndWeightMap_FunctionAddress, intPtr, DumpLandscapeHeightMapAndWeightMap_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DumpLandscapeHeightMapAndWeightMap_ReturnValue_Offset), 0, DumpLandscapeHeightMapAndWeightMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DiscardNavigationDataChunks")]
	public unsafe static void DiscardNavigationDataChunks(UWorld world)
	{
		if (!DiscardNavigationDataChunks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DiscardNavigationDataChunks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DiscardNavigationDataChunks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DiscardNavigationDataChunks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, DiscardNavigationDataChunks_world_Offset), 0, DiscardNavigationDataChunks_world_PropertyAddress.Address, world);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DiscardNavigationDataChunks_FunctionAddress, intPtr, DiscardNavigationDataChunks_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:DisableLodMeshCollisions")]
	public unsafe static void DisableLodMeshCollisions(string PyFilePathBasedOnContentDir, string TargetFolder)
	{
		if (!DisableLodMeshCollisions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:DisableLodMeshCollisions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableLodMeshCollisions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableLodMeshCollisions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DisableLodMeshCollisions_PyFilePathBasedOnContentDir_Offset), 0, DisableLodMeshCollisions_PyFilePathBasedOnContentDir_PropertyAddress.Address, PyFilePathBasedOnContentDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DisableLodMeshCollisions_TargetFolder_Offset), 0, DisableLodMeshCollisions_TargetFolder_PropertyAddress.Address, TargetFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DisableLodMeshCollisions_FunctionAddress, intPtr, DisableLodMeshCollisions_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DisableLodMeshCollisions_PyFilePathBasedOnContentDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DisableLodMeshCollisions_TargetFolder_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateShapeActorFromeStaticMeshActor")]
	public unsafe static void CreateShapeActorFromeStaticMeshActor(List<AActor> AppendMeshActors)
	{
		if (!CreateShapeActorFromeStaticMeshActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateShapeActorFromeStaticMeshActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateShapeActorFromeStaticMeshActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateShapeActorFromeStaticMeshActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, CreateShapeActorFromeStaticMeshActor_AppendMeshActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, CreateShapeActorFromeStaticMeshActor_AppendMeshActors_Offset), AppendMeshActors);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateShapeActorFromeStaticMeshActor_FunctionAddress, intPtr, CreateShapeActorFromeStaticMeshActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateShapeActorFromeStaticMeshActor_AppendMeshActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateLevelFromSelectionActors")]
	public unsafe static void CreateLevelFromSelectionActors(bool needReplaceActor = false)
	{
		if (!CreateLevelFromSelectionActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateLevelFromSelectionActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLevelFromSelectionActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLevelFromSelectionActors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateLevelFromSelectionActors_needReplaceActor_Offset), 0, CreateLevelFromSelectionActors_needReplaceActor_PropertyAddress.Address, needReplaceActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLevelFromSelectionActors_FunctionAddress, intPtr, CreateLevelFromSelectionActors_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertWorld2LevelObject")]
	public unsafe static ULevel ConvertWorld2LevelObject(UWorld InWorld)
	{
		if (!ConvertWorld2LevelObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertWorld2LevelObject");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertWorld2LevelObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertWorld2LevelObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ConvertWorld2LevelObject_InWorld_Offset), 0, ConvertWorld2LevelObject_InWorld_PropertyAddress.Address, InWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertWorld2LevelObject_FunctionAddress, intPtr, ConvertWorld2LevelObject_ParamsSize);
		return UObjectMarshaler<ULevel>.FromNative(IntPtr.Add(intPtr, ConvertWorld2LevelObject_ReturnValue_Offset), 0, ConvertWorld2LevelObject_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertStaticMeshActorToInstance")]
	public unsafe static void ConvertStaticMeshActorToInstance(List<AStaticMeshActor> MeshActors, bool UseHISM, int MinInstancesCount)
	{
		if (!ConvertStaticMeshActorToInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertStaticMeshActorToInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertStaticMeshActorToInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertStaticMeshActorToInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AStaticMeshActor>(1, ConvertStaticMeshActorToInstance_MeshActors_PropertyAddress, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.FromNative, CachedMarshalingDelegates<AStaticMeshActor, UObjectMarshaler<AStaticMeshActor>>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToInstance_MeshActors_Offset), MeshActors);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToInstance_UseHISM_Offset), 0, ConvertStaticMeshActorToInstance_UseHISM_PropertyAddress.Address, UseHISM);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertStaticMeshActorToInstance_MinInstancesCount_Offset), 0, ConvertStaticMeshActorToInstance_MinInstancesCount_PropertyAddress.Address, MinInstancesCount);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertStaticMeshActorToInstance_FunctionAddress, intPtr, ConvertStaticMeshActorToInstance_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertStaticMeshActorToInstance_MeshActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertMatchedBlockingVolumeInLevelToGroundChannel")]
	public unsafe static void ConvertMatchedBlockingVolumeInLevelToGroundChannel(List<FAssetData> InAssets, float InHeightThreshold = 200f)
	{
		if (!ConvertMatchedBlockingVolumeInLevelToGroundChannel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertMatchedBlockingVolumeInLevelToGroundChannel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertMatchedBlockingVolumeInLevelToGroundChannel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertMatchedBlockingVolumeInLevelToGroundChannel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetData>(1, ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_Offset), InAssets);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_Offset), 0, ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_PropertyAddress.Address, InHeightThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, intPtr, ConvertMatchedBlockingVolumeInLevelToGroundChannel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertLevelStaticMeshToInstance")]
	public unsafe static void ConvertLevelStaticMeshToInstance(float CellX, float CellY, float CellZ, int MinInstancesCount)
	{
		if (!ConvertLevelStaticMeshToInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertLevelStaticMeshToInstance");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertLevelStaticMeshToInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertLevelStaticMeshToInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertLevelStaticMeshToInstance_CellX_Offset), 0, ConvertLevelStaticMeshToInstance_CellX_PropertyAddress.Address, CellX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertLevelStaticMeshToInstance_CellY_Offset), 0, ConvertLevelStaticMeshToInstance_CellY_PropertyAddress.Address, CellY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ConvertLevelStaticMeshToInstance_CellZ_Offset), 0, ConvertLevelStaticMeshToInstance_CellZ_PropertyAddress.Address, CellZ);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ConvertLevelStaticMeshToInstance_MinInstancesCount_Offset), 0, ConvertLevelStaticMeshToInstance_MinInstancesCount_PropertyAddress.Address, MinInstancesCount);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertLevelStaticMeshToInstance_FunctionAddress, intPtr, ConvertLevelStaticMeshToInstance_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertCubeInLevelToBlockingVolume")]
	public unsafe static void ConvertCubeInLevelToBlockingVolume(List<FAssetData> InAssets, bool bKeepOriginalActor)
	{
		if (!ConvertCubeInLevelToBlockingVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertCubeInLevelToBlockingVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertCubeInLevelToBlockingVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertCubeInLevelToBlockingVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetData>(1, ConvertCubeInLevelToBlockingVolume_InAssets_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).ToNative(IntPtr.Add(intPtr, ConvertCubeInLevelToBlockingVolume_InAssets_Offset), InAssets);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_Offset), 0, ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_PropertyAddress.Address, bKeepOriginalActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertCubeInLevelToBlockingVolume_FunctionAddress, intPtr, ConvertCubeInLevelToBlockingVolume_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertCubeInLevelToBlockingVolume_InAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:ClearSelectedActorsCustomPrimitiveData")]
	public unsafe static void ClearSelectedActorsCustomPrimitiveData()
	{
		if (!ClearSelectedActorsCustomPrimitiveData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:ClearSelectedActorsCustomPrimitiveData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearSelectedActorsCustomPrimitiveData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearSelectedActorsCustomPrimitiveData_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ClearSelectedActorsCustomPrimitiveData_FunctionAddress, argsSize: ClearSelectedActorsCustomPrimitiveData_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanObsoleteAssets")]
	public unsafe static void CleanObsoleteAssets(string SourceRootDirectory)
	{
		if (!CleanObsoleteAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanObsoleteAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanObsoleteAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanObsoleteAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CleanObsoleteAssets_SourceRootDirectory_Offset), 0, CleanObsoleteAssets_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CleanObsoleteAssets_FunctionAddress, intPtr, CleanObsoleteAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CleanObsoleteAssets_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanLevelNameDecorateLevelActor")]
	public unsafe static void CleanLevelNameDecorateLevelActor()
	{
		if (!CleanLevelNameDecorateLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanLevelNameDecorateLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanLevelNameDecorateLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanLevelNameDecorateLevelActor_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CleanLevelNameDecorateLevelActor_FunctionAddress, argsSize: CleanLevelNameDecorateLevelActor_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanIllegalNoSMLandTags")]
	public unsafe static void CleanIllegalNoSMLandTags()
	{
		if (!CleanIllegalNoSMLandTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanIllegalNoSMLandTags");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanIllegalNoSMLandTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanIllegalNoSMLandTags_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CleanIllegalNoSMLandTags_FunctionAddress, argsSize: CleanIllegalNoSMLandTags_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanAllOldIKMeshTags")]
	public unsafe static void CleanAllOldIKMeshTags()
	{
		if (!CleanAllOldIKMeshTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanAllOldIKMeshTags");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CleanAllOldIKMeshTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CleanAllOldIKMeshTags_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: CleanAllOldIKMeshTags_FunctionAddress, argsSize: CleanAllOldIKMeshTags_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckSkylightCubemapResolution")]
	public unsafe static void CheckSkylightCubemapResolution(string SrcFolderPath)
	{
		if (!CheckSkylightCubemapResolution_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckSkylightCubemapResolution");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckSkylightCubemapResolution_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckSkylightCubemapResolution_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckSkylightCubemapResolution_SrcFolderPath_Offset), 0, CheckSkylightCubemapResolution_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckSkylightCubemapResolution_FunctionAddress, intPtr, CheckSkylightCubemapResolution_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckSkylightCubemapResolution_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageCompsInLevels")]
	public unsafe static void CheckForUmappedFoliageCompsInLevels(string SrcFolderPath)
	{
		if (!CheckForUmappedFoliageCompsInLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageCompsInLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckForUmappedFoliageCompsInLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckForUmappedFoliageCompsInLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckForUmappedFoliageCompsInLevels_SrcFolderPath_Offset), 0, CheckForUmappedFoliageCompsInLevels_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckForUmappedFoliageCompsInLevels_FunctionAddress, intPtr, CheckForUmappedFoliageCompsInLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckForUmappedFoliageCompsInLevels_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageComps")]
	public unsafe static void CheckForUmappedFoliageComps(FAssetData InAsset)
	{
		if (!CheckForUmappedFoliageComps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageComps");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckForUmappedFoliageComps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckForUmappedFoliageComps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CheckForUmappedFoliageComps_InAsset_PropertyAddress.Address, intPtr);
		FAssetData.ToNative(IntPtr.Add(intPtr, CheckForUmappedFoliageComps_InAsset_Offset), 0, CheckForUmappedFoliageComps_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckForUmappedFoliageComps_FunctionAddress, intPtr, CheckForUmappedFoliageComps_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckForUmappedFoliageComps_InAsset_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckDuplicatedActorsForRemoval")]
	public unsafe static void CheckDuplicatedActorsForRemoval(string SrcFolderPath, UGSWCSettingsDataAsset SettingPtr, bool bScanOnly)
	{
		if (!CheckDuplicatedActorsForRemoval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckDuplicatedActorsForRemoval");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckDuplicatedActorsForRemoval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckDuplicatedActorsForRemoval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckDuplicatedActorsForRemoval_SrcFolderPath_Offset), 0, CheckDuplicatedActorsForRemoval_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		UObjectMarshaler<UGSWCSettingsDataAsset>.ToNative(IntPtr.Add(intPtr, CheckDuplicatedActorsForRemoval_SettingPtr_Offset), 0, CheckDuplicatedActorsForRemoval_SettingPtr_PropertyAddress.Address, SettingPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckDuplicatedActorsForRemoval_bScanOnly_Offset), 0, CheckDuplicatedActorsForRemoval_bScanOnly_PropertyAddress.Address, bScanOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckDuplicatedActorsForRemoval_FunctionAddress, intPtr, CheckDuplicatedActorsForRemoval_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckDuplicatedActorsForRemoval_SrcFolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckActorsNumAfterSplit")]
	public unsafe static void CheckActorsNumAfterSplit(string SourceRootDirectory, bool bDebug = false)
	{
		if (!CheckActorsNumAfterSplit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckActorsNumAfterSplit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckActorsNumAfterSplit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckActorsNumAfterSplit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckActorsNumAfterSplit_SourceRootDirectory_Offset), 0, CheckActorsNumAfterSplit_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckActorsNumAfterSplit_bDebug_Offset), 0, CheckActorsNumAfterSplit_bDebug_PropertyAddress.Address, bDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckActorsNumAfterSplit_FunctionAddress, intPtr, CheckActorsNumAfterSplit_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckActorsNumAfterSplit_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateLevelBounds")]
	public unsafe static void CalculateLevelBounds(ULevel InLevel, out FVector Origin, out FVector BoxExtent)
	{
		if (!CalculateLevelBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateLevelBounds");
			Origin = default(FVector);
			BoxExtent = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateLevelBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateLevelBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, CalculateLevelBounds_InLevel_Offset), 0, CalculateLevelBounds_InLevel_PropertyAddress.Address, InLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateLevelBounds_FunctionAddress, intPtr, CalculateLevelBounds_ParamsSize);
		Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, CalculateLevelBounds_Origin_Offset), 0, CalculateLevelBounds_Origin_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, CalculateLevelBounds_BoxExtent_Offset), 0, CalculateLevelBounds_BoxExtent_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateActorClassAndCount")]
	public unsafe static void CalculateActorClassAndCount(string SourceRootDirectory)
	{
		if (!CalculateActorClassAndCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateActorClassAndCount");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateActorClassAndCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateActorClassAndCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CalculateActorClassAndCount_SourceRootDirectory_Offset), 0, CalculateActorClassAndCount_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateActorClassAndCount_FunctionAddress, intPtr, CalculateActorClassAndCount_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CalculateActorClassAndCount_SourceRootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:CacheConsoleHistoryBuffer")]
	public unsafe static List<string> CacheConsoleHistoryBuffer()
	{
		if (!CacheConsoleHistoryBuffer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:CacheConsoleHistoryBuffer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CacheConsoleHistoryBuffer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CacheConsoleHistoryBuffer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CacheConsoleHistoryBuffer_FunctionAddress, intPtr, CacheConsoleHistoryBuffer_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, CacheConsoleHistoryBuffer_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, CacheConsoleHistoryBuffer_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(CacheConsoleHistoryBuffer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavDataNoWC")]
	public unsafe static int BuildNavDataNoWC(string MapName, bool bNeedCheckout)
	{
		if (!BuildNavDataNoWC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavDataNoWC");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildNavDataNoWC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildNavDataNoWC_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildNavDataNoWC_MapName_Offset), 0, BuildNavDataNoWC_MapName_PropertyAddress.Address, MapName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BuildNavDataNoWC_bNeedCheckout_Offset), 0, BuildNavDataNoWC_bNeedCheckout_PropertyAddress.Address, bNeedCheckout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildNavDataNoWC_FunctionAddress, intPtr, BuildNavDataNoWC_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildNavDataNoWC_MapName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BuildNavDataNoWC_ReturnValue_Offset), 0, BuildNavDataNoWC_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavData")]
	public unsafe static int BuildNavData(string MapName, bool bNeedCheckout)
	{
		if (!BuildNavData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavData");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildNavData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildNavData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildNavData_MapName_Offset), 0, BuildNavData_MapName_PropertyAddress.Address, MapName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BuildNavData_bNeedCheckout_Offset), 0, BuildNavData_bNeedCheckout_PropertyAddress.Address, bNeedCheckout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildNavData_FunctionAddress, intPtr, BuildNavData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildNavData_MapName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BuildNavData_ReturnValue_Offset), 0, BuildNavData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:AssembleTilesNamesForParallelTasks")]
	public unsafe static void AssembleTilesNamesForParallelTasks(string RootDirectory, List<string> InMapFilterNames)
	{
		if (!AssembleTilesNamesForParallelTasks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:AssembleTilesNamesForParallelTasks");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AssembleTilesNamesForParallelTasks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AssembleTilesNamesForParallelTasks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AssembleTilesNamesForParallelTasks_RootDirectory_Offset), 0, AssembleTilesNamesForParallelTasks_RootDirectory_PropertyAddress.Address, RootDirectory);
		new TArrayCopyMarshaler<string>(1, AssembleTilesNamesForParallelTasks_InMapFilterNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, AssembleTilesNamesForParallelTasks_InMapFilterNames_Offset), InMapFilterNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AssembleTilesNamesForParallelTasks_FunctionAddress, intPtr, AssembleTilesNamesForParallelTasks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AssembleTilesNamesForParallelTasks_RootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AssembleTilesNamesForParallelTasks_InMapFilterNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevelByLevelName")]
	public unsafe static UFoliageType AddFoliageTypeToLevelByLevelName(string LevelName, UFoliageType type)
	{
		if (!AddFoliageTypeToLevelByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevelByLevelName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFoliageTypeToLevelByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFoliageTypeToLevelByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFoliageTypeToLevelByLevelName_LevelName_Offset), 0, AddFoliageTypeToLevelByLevelName_LevelName_PropertyAddress.Address, LevelName);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, AddFoliageTypeToLevelByLevelName_type_Offset), 0, AddFoliageTypeToLevelByLevelName_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFoliageTypeToLevelByLevelName_FunctionAddress, intPtr, AddFoliageTypeToLevelByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFoliageTypeToLevelByLevelName_LevelName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UFoliageType>.FromNative(IntPtr.Add(intPtr, AddFoliageTypeToLevelByLevelName_ReturnValue_Offset), 0, AddFoliageTypeToLevelByLevelName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevel")]
	public unsafe static UFoliageType AddFoliageTypeToLevel(ULevel Level, UFoliageType type)
	{
		if (!AddFoliageTypeToLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFoliageTypeToLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFoliageTypeToLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, AddFoliageTypeToLevel_Level_Offset), 0, AddFoliageTypeToLevel_Level_PropertyAddress.Address, Level);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, AddFoliageTypeToLevel_type_Offset), 0, AddFoliageTypeToLevel_type_PropertyAddress.Address, type);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFoliageTypeToLevel_FunctionAddress, intPtr, AddFoliageTypeToLevel_ParamsSize);
		return UObjectMarshaler<UFoliageType>.FromNative(IntPtr.Add(intPtr, AddFoliageTypeToLevel_ReturnValue_Offset), 0, AddFoliageTypeToLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevelByLevelName")]
	public unsafe static void AddFoliageInstanceDataToLevelByLevelName(string LevelName, UFoliageType type, List<FFoliageInstanceData> InstanceData)
	{
		if (!AddFoliageInstanceDataToLevelByLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevelByLevelName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFoliageInstanceDataToLevelByLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFoliageInstanceDataToLevelByLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevelByLevelName_LevelName_Offset), 0, AddFoliageInstanceDataToLevelByLevelName_LevelName_PropertyAddress.Address, LevelName);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevelByLevelName_type_Offset), 0, AddFoliageInstanceDataToLevelByLevelName_type_PropertyAddress.Address, type);
		new TArrayCopyMarshaler<FFoliageInstanceData>(1, AddFoliageInstanceDataToLevelByLevelName_InstanceData_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevelByLevelName_InstanceData_Offset), InstanceData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, intPtr, AddFoliageInstanceDataToLevelByLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFoliageInstanceDataToLevelByLevelName_LevelName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddFoliageInstanceDataToLevelByLevelName_InstanceData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevel")]
	public unsafe static void AddFoliageInstanceDataToLevel(ULevel Level, UFoliageType type, List<FFoliageInstanceData> InstanceData)
	{
		if (!AddFoliageInstanceDataToLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFoliageInstanceDataToLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFoliageInstanceDataToLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevel_Level_Offset), 0, AddFoliageInstanceDataToLevel_Level_PropertyAddress.Address, Level);
		UObjectMarshaler<UFoliageType>.ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevel_type_Offset), 0, AddFoliageInstanceDataToLevel_type_PropertyAddress.Address, type);
		new TArrayCopyMarshaler<FFoliageInstanceData>(1, AddFoliageInstanceDataToLevel_InstanceData_PropertyAddress, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.FromNative, CachedMarshalingDelegates<FFoliageInstanceData, FFoliageInstanceData>.ToNative).ToNative(IntPtr.Add(intPtr, AddFoliageInstanceDataToLevel_InstanceData_Offset), InstanceData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFoliageInstanceDataToLevel_FunctionAddress, intPtr, AddFoliageInstanceDataToLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddFoliageInstanceDataToLevel_InstanceData_PropertyAddress.Address, intPtr);
	}

	static UGSEditorLevelLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorLevelLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorLevelLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorLevelLibrary");
		WorldGetCurrentLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WorldGetCurrentLevel");
		WorldGetCurrentLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(WorldGetCurrentLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WorldGetCurrentLevel_World_PropertyAddress, WorldGetCurrentLevel_FunctionAddress, "World");
		WorldGetCurrentLevel_World_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetCurrentLevel_FunctionAddress, "World");
		WorldGetCurrentLevel_World_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetCurrentLevel_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref WorldGetCurrentLevel_ReturnValue_PropertyAddress, WorldGetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldGetCurrentLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WorldGetCurrentLevel_FunctionAddress, "ReturnValue");
		WorldGetCurrentLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WorldGetCurrentLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		WorldGetCurrentLevel_IsValid = WorldGetCurrentLevel_FunctionAddress != IntPtr.Zero && WorldGetCurrentLevel_World_IsValid && WorldGetCurrentLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:WorldGetCurrentLevel", WorldGetCurrentLevel_IsValid);
		UpdateSubLevelBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateSubLevelBounds");
		UpdateSubLevelBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateSubLevelBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateSubLevelBounds_RootDirectory_PropertyAddress, UpdateSubLevelBounds_FunctionAddress, "RootDirectory");
		UpdateSubLevelBounds_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(UpdateSubLevelBounds_FunctionAddress, "RootDirectory");
		UpdateSubLevelBounds_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateSubLevelBounds_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		UpdateSubLevelBounds_IsValid = UpdateSubLevelBounds_FunctionAddress != IntPtr.Zero && UpdateSubLevelBounds_RootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateSubLevelBounds", UpdateSubLevelBounds_IsValid);
		UpdateLevelBound_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateLevelBound");
		UpdateLevelBound_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateLevelBound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateLevelBound_InLevelBound_PropertyAddress, UpdateLevelBound_FunctionAddress, "InLevelBound");
		UpdateLevelBound_InLevelBound_Offset = NativeReflectionCached.GetPropertyOffset(UpdateLevelBound_FunctionAddress, "InLevelBound");
		UpdateLevelBound_InLevelBound_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateLevelBound_FunctionAddress, "InLevelBound", Classes.FObjectProperty);
		UpdateLevelBound_IsValid = UpdateLevelBound_FunctionAddress != IntPtr.Zero && UpdateLevelBound_InLevelBound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateLevelBound", UpdateLevelBound_IsValid);
		UpdateAllLevelBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateAllLevelBounds");
		UpdateAllLevelBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateAllLevelBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateAllLevelBounds_RootDirectory_PropertyAddress, UpdateAllLevelBounds_FunctionAddress, "RootDirectory");
		UpdateAllLevelBounds_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAllLevelBounds_FunctionAddress, "RootDirectory");
		UpdateAllLevelBounds_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAllLevelBounds_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateAllLevelBounds_SettingPtr_PropertyAddress, UpdateAllLevelBounds_FunctionAddress, "SettingPtr");
		UpdateAllLevelBounds_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(UpdateAllLevelBounds_FunctionAddress, "SettingPtr");
		UpdateAllLevelBounds_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateAllLevelBounds_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		UpdateAllLevelBounds_IsValid = UpdateAllLevelBounds_FunctionAddress != IntPtr.Zero && UpdateAllLevelBounds_RootDirectory_IsValid && UpdateAllLevelBounds_SettingPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:UpdateAllLevelBounds", UpdateAllLevelBounds_IsValid);
		UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnLoadStreamingLevelsIntoCurrentPersistent");
		UnLoadStreamingLevelsIntoCurrentPersistent_ParamsSize = NativeReflection.GetFunctionParamsSize(UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames", Classes.FArrayProperty);
		UnLoadStreamingLevelsIntoCurrentPersistent_IsValid = UnLoadStreamingLevelsIntoCurrentPersistent_FunctionAddress != IntPtr.Zero && UnLoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:UnLoadStreamingLevelsIntoCurrentPersistent", UnLoadStreamingLevelsIntoCurrentPersistent_IsValid);
		TranslateAllLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TranslateAllLevelActor");
		TranslateAllLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(TranslateAllLevelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TranslateAllLevelActor_LevelName_PropertyAddress, TranslateAllLevelActor_FunctionAddress, "LevelName");
		TranslateAllLevelActor_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(TranslateAllLevelActor_FunctionAddress, "LevelName");
		TranslateAllLevelActor_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateAllLevelActor_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateAllLevelActor_WorldTranslate_PropertyAddress, TranslateAllLevelActor_FunctionAddress, "WorldTranslate");
		TranslateAllLevelActor_WorldTranslate_Offset = NativeReflectionCached.GetPropertyOffset(TranslateAllLevelActor_FunctionAddress, "WorldTranslate");
		TranslateAllLevelActor_WorldTranslate_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateAllLevelActor_FunctionAddress, "WorldTranslate", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateAllLevelActor_ExceptActorClasses_PropertyAddress, TranslateAllLevelActor_FunctionAddress, "ExceptActorClasses");
		TranslateAllLevelActor_ExceptActorClasses_Offset = NativeReflectionCached.GetPropertyOffset(TranslateAllLevelActor_FunctionAddress, "ExceptActorClasses");
		TranslateAllLevelActor_ExceptActorClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateAllLevelActor_FunctionAddress, "ExceptActorClasses", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TranslateAllLevelActor_ReturnValue_PropertyAddress, TranslateAllLevelActor_FunctionAddress, "ReturnValue");
		TranslateAllLevelActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TranslateAllLevelActor_FunctionAddress, "ReturnValue");
		TranslateAllLevelActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TranslateAllLevelActor_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		TranslateAllLevelActor_IsValid = TranslateAllLevelActor_FunctionAddress != IntPtr.Zero && TranslateAllLevelActor_LevelName_IsValid && TranslateAllLevelActor_WorldTranslate_IsValid && TranslateAllLevelActor_ExceptActorClasses_IsValid && TranslateAllLevelActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:TranslateAllLevelActor", TranslateAllLevelActor_IsValid);
		ToggleAllNoLandMeshVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleAllNoLandMeshVisibility");
		ToggleAllNoLandMeshVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleAllNoLandMeshVisibility_FunctionAddress);
		ToggleAllNoLandMeshVisibility_IsValid = ToggleAllNoLandMeshVisibility_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllNoLandMeshVisibility", ToggleAllNoLandMeshVisibility_IsValid);
		ToggleAllIKMeshVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleAllIKMeshVisibility");
		ToggleAllIKMeshVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleAllIKMeshVisibility_FunctionAddress);
		ToggleAllIKMeshVisibility_IsValid = ToggleAllIKMeshVisibility_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleAllIKMeshVisibility", ToggleAllIKMeshVisibility_IsValid);
		ToggleActorVisibilityInSceneOutliner_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ToggleActorVisibilityInSceneOutliner");
		ToggleActorVisibilityInSceneOutliner_ParamsSize = NativeReflection.GetFunctionParamsSize(ToggleActorVisibilityInSceneOutliner_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToggleActorVisibilityInSceneOutliner_Actors_PropertyAddress, ToggleActorVisibilityInSceneOutliner_FunctionAddress, "Actors");
		ToggleActorVisibilityInSceneOutliner_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ToggleActorVisibilityInSceneOutliner_FunctionAddress, "Actors");
		ToggleActorVisibilityInSceneOutliner_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ToggleActorVisibilityInSceneOutliner_FunctionAddress, "Actors", Classes.FArrayProperty);
		ToggleActorVisibilityInSceneOutliner_IsValid = ToggleActorVisibilityInSceneOutliner_FunctionAddress != IntPtr.Zero && ToggleActorVisibilityInSceneOutliner_Actors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ToggleActorVisibilityInSceneOutliner", ToggleActorVisibilityInSceneOutliner_IsValid);
		TilesContainBlueprintClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TilesContainBlueprintClass");
		TilesContainBlueprintClass_ParamsSize = NativeReflection.GetFunctionParamsSize(TilesContainBlueprintClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TilesContainBlueprintClass_SourceRootDirectory_PropertyAddress, TilesContainBlueprintClass_FunctionAddress, "SourceRootDirectory");
		TilesContainBlueprintClass_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(TilesContainBlueprintClass_FunctionAddress, "SourceRootDirectory");
		TilesContainBlueprintClass_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(TilesContainBlueprintClass_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TilesContainBlueprintClass_OutResults_PropertyAddress, TilesContainBlueprintClass_FunctionAddress, "OutResults");
		TilesContainBlueprintClass_OutResults_Offset = NativeReflectionCached.GetPropertyOffset(TilesContainBlueprintClass_FunctionAddress, "OutResults");
		TilesContainBlueprintClass_OutResults_IsValid = NativeReflectionCached.ValidatePropertyClass(TilesContainBlueprintClass_FunctionAddress, "OutResults", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TilesContainBlueprintClass_ReturnValue_PropertyAddress, TilesContainBlueprintClass_FunctionAddress, "ReturnValue");
		TilesContainBlueprintClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TilesContainBlueprintClass_FunctionAddress, "ReturnValue");
		TilesContainBlueprintClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TilesContainBlueprintClass_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TilesContainBlueprintClass_IsValid = TilesContainBlueprintClass_FunctionAddress != IntPtr.Zero && TilesContainBlueprintClass_SourceRootDirectory_IsValid && TilesContainBlueprintClass_OutResults_IsValid && TilesContainBlueprintClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:TilesContainBlueprintClass", TilesContainBlueprintClass_IsValid);
		SpawnActor2SubLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SpawnActor2SubLevel");
		SpawnActor2SubLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActor2SubLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SpawnActor2SubLevel_InSubLevel_PropertyAddress, SpawnActor2SubLevel_FunctionAddress, "InSubLevel");
		SpawnActor2SubLevel_InSubLevel_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActor2SubLevel_FunctionAddress, "InSubLevel");
		SpawnActor2SubLevel_InSubLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActor2SubLevel_FunctionAddress, "InSubLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActor2SubLevel_InActorClass_PropertyAddress, SpawnActor2SubLevel_FunctionAddress, "InActorClass");
		SpawnActor2SubLevel_InActorClass_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActor2SubLevel_FunctionAddress, "InActorClass");
		SpawnActor2SubLevel_InActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActor2SubLevel_FunctionAddress, "InActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActor2SubLevel_InTransform_PropertyAddress, SpawnActor2SubLevel_FunctionAddress, "InTransform");
		SpawnActor2SubLevel_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActor2SubLevel_FunctionAddress, "InTransform");
		SpawnActor2SubLevel_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActor2SubLevel_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActor2SubLevel_InName_PropertyAddress, SpawnActor2SubLevel_FunctionAddress, "InName");
		SpawnActor2SubLevel_InName_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActor2SubLevel_FunctionAddress, "InName");
		SpawnActor2SubLevel_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActor2SubLevel_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnActor2SubLevel_ReturnValue_PropertyAddress, SpawnActor2SubLevel_FunctionAddress, "ReturnValue");
		SpawnActor2SubLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SpawnActor2SubLevel_FunctionAddress, "ReturnValue");
		SpawnActor2SubLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SpawnActor2SubLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActor2SubLevel_IsValid = SpawnActor2SubLevel_FunctionAddress != IntPtr.Zero && SpawnActor2SubLevel_InSubLevel_IsValid && SpawnActor2SubLevel_InActorClass_IsValid && SpawnActor2SubLevel_InTransform_IsValid && SpawnActor2SubLevel_InName_IsValid && SpawnActor2SubLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:SpawnActor2SubLevel", SpawnActor2SubLevel_IsValid);
		ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowStreamingLevelsIntoCurrentPersistent");
		ShowStreamingLevelsIntoCurrentPersistent_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames", Classes.FArrayProperty);
		ShowStreamingLevelsIntoCurrentPersistent_IsValid = ShowStreamingLevelsIntoCurrentPersistent_FunctionAddress != IntPtr.Zero && ShowStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ShowStreamingLevelsIntoCurrentPersistent", ShowStreamingLevelsIntoCurrentPersistent_IsValid);
		SetBossRushLevelLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBossRushLevelLayer");
		SetBossRushLevelLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBossRushLevelLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBossRushLevelLayer_InSubLevelWorld_PropertyAddress, SetBossRushLevelLayer_FunctionAddress, "InSubLevelWorld");
		SetBossRushLevelLayer_InSubLevelWorld_Offset = NativeReflectionCached.GetPropertyOffset(SetBossRushLevelLayer_FunctionAddress, "InSubLevelWorld");
		SetBossRushLevelLayer_InSubLevelWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBossRushLevelLayer_FunctionAddress, "InSubLevelWorld", Classes.FObjectProperty);
		SetBossRushLevelLayer_IsValid = SetBossRushLevelLayer_FunctionAddress != IntPtr.Zero && SetBossRushLevelLayer_InSubLevelWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:SetBossRushLevelLayer", SetBossRushLevelLayer_IsValid);
		SetAllBossRushLevelLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllBossRushLevelLayer");
		SetAllBossRushLevelLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllBossRushLevelLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllBossRushLevelLayer_InLevelNameList_PropertyAddress, SetAllBossRushLevelLayer_FunctionAddress, "InLevelNameList");
		SetAllBossRushLevelLayer_InLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBossRushLevelLayer_FunctionAddress, "InLevelNameList");
		SetAllBossRushLevelLayer_InLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBossRushLevelLayer_FunctionAddress, "InLevelNameList", Classes.FArrayProperty);
		SetAllBossRushLevelLayer_IsValid = SetAllBossRushLevelLayer_FunctionAddress != IntPtr.Zero && SetAllBossRushLevelLayer_InLevelNameList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:SetAllBossRushLevelLayer", SetAllBossRushLevelLayer_IsValid);
		SelectActorsByTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectActorsByTag");
		SelectActorsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectActorsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectActorsByTag_Tag_PropertyAddress, SelectActorsByTag_FunctionAddress, "Tag");
		SelectActorsByTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(SelectActorsByTag_FunctionAddress, "Tag");
		SelectActorsByTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectActorsByTag_FunctionAddress, "Tag", Classes.FNameProperty);
		SelectActorsByTag_IsValid = SelectActorsByTag_FunctionAddress != IntPtr.Zero && SelectActorsByTag_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:SelectActorsByTag", SelectActorsByTag_IsValid);
		ScanSpecifiedLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanSpecifiedLevel");
		ScanSpecifiedLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanSpecifiedLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanSpecifiedLevel_SourceRootDirectory_PropertyAddress, ScanSpecifiedLevel_FunctionAddress, "SourceRootDirectory");
		ScanSpecifiedLevel_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanSpecifiedLevel_FunctionAddress, "SourceRootDirectory");
		ScanSpecifiedLevel_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanSpecifiedLevel_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanSpecifiedLevel_InLevelName_PropertyAddress, ScanSpecifiedLevel_FunctionAddress, "InLevelName");
		ScanSpecifiedLevel_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(ScanSpecifiedLevel_FunctionAddress, "InLevelName");
		ScanSpecifiedLevel_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanSpecifiedLevel_FunctionAddress, "InLevelName", Classes.FStrProperty);
		ScanSpecifiedLevel_IsValid = ScanSpecifiedLevel_FunctionAddress != IntPtr.Zero && ScanSpecifiedLevel_SourceRootDirectory_IsValid && ScanSpecifiedLevel_InLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanSpecifiedLevel", ScanSpecifiedLevel_IsValid);
		ScanLevelsExceedThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanLevelsExceedThreshold");
		ScanLevelsExceedThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanLevelsExceedThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanLevelsExceedThreshold_InRootDirectory_PropertyAddress, ScanLevelsExceedThreshold_FunctionAddress, "InRootDirectory");
		ScanLevelsExceedThreshold_InRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanLevelsExceedThreshold_FunctionAddress, "InRootDirectory");
		ScanLevelsExceedThreshold_InRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanLevelsExceedThreshold_FunctionAddress, "InRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanLevelsExceedThreshold_InThresholdNum_PropertyAddress, ScanLevelsExceedThreshold_FunctionAddress, "InThresholdNum");
		ScanLevelsExceedThreshold_InThresholdNum_Offset = NativeReflectionCached.GetPropertyOffset(ScanLevelsExceedThreshold_FunctionAddress, "InThresholdNum");
		ScanLevelsExceedThreshold_InThresholdNum_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanLevelsExceedThreshold_FunctionAddress, "InThresholdNum", Classes.FIntProperty);
		ScanLevelsExceedThreshold_IsValid = ScanLevelsExceedThreshold_FunctionAddress != IntPtr.Zero && ScanLevelsExceedThreshold_InRootDirectory_IsValid && ScanLevelsExceedThreshold_InThresholdNum_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanLevelsExceedThreshold", ScanLevelsExceedThreshold_IsValid);
		ScanAllTileLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanAllTileLevels");
		ScanAllTileLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanAllTileLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanAllTileLevels_SourceRootDirectory_PropertyAddress, ScanAllTileLevels_FunctionAddress, "SourceRootDirectory");
		ScanAllTileLevels_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllTileLevels_FunctionAddress, "SourceRootDirectory");
		ScanAllTileLevels_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllTileLevels_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanAllTileLevels_InScanMode_PropertyAddress, ScanAllTileLevels_FunctionAddress, "InScanMode");
		ScanAllTileLevels_InScanMode_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllTileLevels_FunctionAddress, "InScanMode");
		ScanAllTileLevels_InScanMode_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllTileLevels_FunctionAddress, "InScanMode", Classes.FIntProperty);
		ScanAllTileLevels_IsValid = ScanAllTileLevels_FunctionAddress != IntPtr.Zero && ScanAllTileLevels_SourceRootDirectory_IsValid && ScanAllTileLevels_InScanMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllTileLevels", ScanAllTileLevels_IsValid);
		ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ScanAllStaticMeshesDistanceFieldInfo");
		ScanAllStaticMeshesDistanceFieldInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_PropertyAddress, ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "RootDirectory");
		ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "RootDirectory");
		ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_PropertyAddress, ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "DFSizeThreshold");
		ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "DFSizeThreshold");
		ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress, "DFSizeThreshold", Classes.FFloatProperty);
		ScanAllStaticMeshesDistanceFieldInfo_IsValid = ScanAllStaticMeshesDistanceFieldInfo_FunctionAddress != IntPtr.Zero && ScanAllStaticMeshesDistanceFieldInfo_RootDirectory_IsValid && ScanAllStaticMeshesDistanceFieldInfo_DFSizeThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ScanAllStaticMeshesDistanceFieldInfo", ScanAllStaticMeshesDistanceFieldInfo_IsValid);
		SaveLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLevel");
		SaveLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLevel_InLevel_PropertyAddress, SaveLevel_FunctionAddress, "InLevel");
		SaveLevel_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(SaveLevel_FunctionAddress, "InLevel");
		SaveLevel_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLevel_FunctionAddress, "InLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLevel_bAutoCheckOut_PropertyAddress, SaveLevel_FunctionAddress, "bAutoCheckOut");
		SaveLevel_bAutoCheckOut_Offset = NativeReflectionCached.GetPropertyOffset(SaveLevel_FunctionAddress, "bAutoCheckOut");
		SaveLevel_bAutoCheckOut_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLevel_FunctionAddress, "bAutoCheckOut", Classes.FBoolProperty);
		SaveLevel_IsValid = SaveLevel_FunctionAddress != IntPtr.Zero && SaveLevel_InLevel_IsValid && SaveLevel_bAutoCheckOut_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:SaveLevel", SaveLevel_IsValid);
		ResetActorToBlueprintDefaults_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ResetActorToBlueprintDefaults");
		ResetActorToBlueprintDefaults_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetActorToBlueprintDefaults_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResetActorToBlueprintDefaults_Actor_PropertyAddress, ResetActorToBlueprintDefaults_FunctionAddress, "Actor");
		ResetActorToBlueprintDefaults_Actor_Offset = NativeReflectionCached.GetPropertyOffset(ResetActorToBlueprintDefaults_FunctionAddress, "Actor");
		ResetActorToBlueprintDefaults_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetActorToBlueprintDefaults_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ResetActorToBlueprintDefaults_ReturnValue_PropertyAddress, ResetActorToBlueprintDefaults_FunctionAddress, "ReturnValue");
		ResetActorToBlueprintDefaults_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResetActorToBlueprintDefaults_FunctionAddress, "ReturnValue");
		ResetActorToBlueprintDefaults_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResetActorToBlueprintDefaults_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ResetActorToBlueprintDefaults_IsValid = ResetActorToBlueprintDefaults_FunctionAddress != IntPtr.Zero && ResetActorToBlueprintDefaults_Actor_IsValid && ResetActorToBlueprintDefaults_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ResetActorToBlueprintDefaults", ResetActorToBlueprintDefaults_IsValid);
		ReplaceFoliageByFoliageByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceFoliageByFoliageByLevelName");
		ReplaceFoliageByFoliageByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceFoliageByFoliageByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliageByLevelName_LevelName_PropertyAddress, ReplaceFoliageByFoliageByLevelName_FunctionAddress, "LevelName");
		ReplaceFoliageByFoliageByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "LevelName");
		ReplaceFoliageByFoliageByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliageByLevelName_sourceFoliage_PropertyAddress, ReplaceFoliageByFoliageByLevelName_FunctionAddress, "sourceFoliage");
		ReplaceFoliageByFoliageByLevelName_sourceFoliage_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "sourceFoliage");
		ReplaceFoliageByFoliageByLevelName_sourceFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "sourceFoliage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliageByLevelName_targetFoliage_PropertyAddress, ReplaceFoliageByFoliageByLevelName_FunctionAddress, "targetFoliage");
		ReplaceFoliageByFoliageByLevelName_targetFoliage_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "targetFoliage");
		ReplaceFoliageByFoliageByLevelName_targetFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliageByLevelName_FunctionAddress, "targetFoliage", Classes.FObjectProperty);
		ReplaceFoliageByFoliageByLevelName_IsValid = ReplaceFoliageByFoliageByLevelName_FunctionAddress != IntPtr.Zero && ReplaceFoliageByFoliageByLevelName_LevelName_IsValid && ReplaceFoliageByFoliageByLevelName_sourceFoliage_IsValid && ReplaceFoliageByFoliageByLevelName_targetFoliage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliageByLevelName", ReplaceFoliageByFoliageByLevelName_IsValid);
		ReplaceFoliageByFoliage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceFoliageByFoliage");
		ReplaceFoliageByFoliage_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceFoliageByFoliage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliage_Level_PropertyAddress, ReplaceFoliageByFoliage_FunctionAddress, "Level");
		ReplaceFoliageByFoliage_Level_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliage_FunctionAddress, "Level");
		ReplaceFoliageByFoliage_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliage_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliage_sourceFoliage_PropertyAddress, ReplaceFoliageByFoliage_FunctionAddress, "sourceFoliage");
		ReplaceFoliageByFoliage_sourceFoliage_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliage_FunctionAddress, "sourceFoliage");
		ReplaceFoliageByFoliage_sourceFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliage_FunctionAddress, "sourceFoliage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceFoliageByFoliage_targetFoliage_PropertyAddress, ReplaceFoliageByFoliage_FunctionAddress, "targetFoliage");
		ReplaceFoliageByFoliage_targetFoliage_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceFoliageByFoliage_FunctionAddress, "targetFoliage");
		ReplaceFoliageByFoliage_targetFoliage_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceFoliageByFoliage_FunctionAddress, "targetFoliage", Classes.FObjectProperty);
		ReplaceFoliageByFoliage_IsValid = ReplaceFoliageByFoliage_FunctionAddress != IntPtr.Zero && ReplaceFoliageByFoliage_Level_IsValid && ReplaceFoliageByFoliage_sourceFoliage_IsValid && ReplaceFoliageByFoliage_targetFoliage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ReplaceFoliageByFoliage", ReplaceFoliageByFoliage_IsValid);
		RemoveFoliageTypeFromLevelByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveFoliageTypeFromLevelByLevelName");
		RemoveFoliageTypeFromLevelByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFoliageTypeFromLevelByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageTypeFromLevelByLevelName_LevelName_PropertyAddress, RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "LevelName");
		RemoveFoliageTypeFromLevelByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "LevelName");
		RemoveFoliageTypeFromLevelByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageTypeFromLevelByLevelName_type_PropertyAddress, RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "type");
		RemoveFoliageTypeFromLevelByLevelName_type_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "type");
		RemoveFoliageTypeFromLevelByLevelName_type_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageTypeFromLevelByLevelName_FunctionAddress, "type", Classes.FObjectProperty);
		RemoveFoliageTypeFromLevelByLevelName_IsValid = RemoveFoliageTypeFromLevelByLevelName_FunctionAddress != IntPtr.Zero && RemoveFoliageTypeFromLevelByLevelName_LevelName_IsValid && RemoveFoliageTypeFromLevelByLevelName_type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevelByLevelName", RemoveFoliageTypeFromLevelByLevelName_IsValid);
		RemoveFoliageTypeFromLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveFoliageTypeFromLevel");
		RemoveFoliageTypeFromLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFoliageTypeFromLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageTypeFromLevel_Level_PropertyAddress, RemoveFoliageTypeFromLevel_FunctionAddress, "Level");
		RemoveFoliageTypeFromLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageTypeFromLevel_FunctionAddress, "Level");
		RemoveFoliageTypeFromLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageTypeFromLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveFoliageTypeFromLevel_type_PropertyAddress, RemoveFoliageTypeFromLevel_FunctionAddress, "type");
		RemoveFoliageTypeFromLevel_type_Offset = NativeReflectionCached.GetPropertyOffset(RemoveFoliageTypeFromLevel_FunctionAddress, "type");
		RemoveFoliageTypeFromLevel_type_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveFoliageTypeFromLevel_FunctionAddress, "type", Classes.FObjectProperty);
		RemoveFoliageTypeFromLevel_IsValid = RemoveFoliageTypeFromLevel_FunctionAddress != IntPtr.Zero && RemoveFoliageTypeFromLevel_Level_IsValid && RemoveFoliageTypeFromLevel_type_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveFoliageTypeFromLevel", RemoveFoliageTypeFromLevel_IsValid);
		RemoveEmptyStaticMeshActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveEmptyStaticMeshActor");
		RemoveEmptyStaticMeshActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEmptyStaticMeshActor_FunctionAddress);
		RemoveEmptyStaticMeshActor_IsValid = RemoveEmptyStaticMeshActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyStaticMeshActor", RemoveEmptyStaticMeshActor_IsValid);
		RemoveEmptyInstancedFoliageActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveEmptyInstancedFoliageActor");
		RemoveEmptyInstancedFoliageActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEmptyInstancedFoliageActor_FunctionAddress);
		RemoveEmptyInstancedFoliageActor_IsValid = RemoveEmptyInstancedFoliageActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyInstancedFoliageActor", RemoveEmptyInstancedFoliageActor_IsValid);
		RemoveEmptyFoliageInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveEmptyFoliageInfo");
		RemoveEmptyFoliageInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveEmptyFoliageInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveEmptyFoliageInfo_ReturnValue_PropertyAddress, RemoveEmptyFoliageInfo_FunctionAddress, "ReturnValue");
		RemoveEmptyFoliageInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveEmptyFoliageInfo_FunctionAddress, "ReturnValue");
		RemoveEmptyFoliageInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveEmptyFoliageInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveEmptyFoliageInfo_IsValid = RemoveEmptyFoliageInfo_FunctionAddress != IntPtr.Zero && RemoveEmptyFoliageInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemoveEmptyFoliageInfo", RemoveEmptyFoliageInfo_IsValid);
		RemapFoliageTypeAndCompsInLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemapFoliageTypeAndCompsInLevels");
		RemapFoliageTypeAndCompsInLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(RemapFoliageTypeAndCompsInLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemapFoliageTypeAndCompsInLevels_SrcFolderPath_PropertyAddress, RemapFoliageTypeAndCompsInLevels_FunctionAddress, "SrcFolderPath");
		RemapFoliageTypeAndCompsInLevels_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(RemapFoliageTypeAndCompsInLevels_FunctionAddress, "SrcFolderPath");
		RemapFoliageTypeAndCompsInLevels_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapFoliageTypeAndCompsInLevels_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		RemapFoliageTypeAndCompsInLevels_IsValid = RemapFoliageTypeAndCompsInLevels_FunctionAddress != IntPtr.Zero && RemapFoliageTypeAndCompsInLevels_SrcFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevels", RemapFoliageTypeAndCompsInLevels_IsValid);
		RemapFoliageTypeAndCompsInLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemapFoliageTypeAndCompsInLevel");
		RemapFoliageTypeAndCompsInLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(RemapFoliageTypeAndCompsInLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemapFoliageTypeAndCompsInLevel_TargetLevel_PropertyAddress, RemapFoliageTypeAndCompsInLevel_FunctionAddress, "TargetLevel");
		RemapFoliageTypeAndCompsInLevel_TargetLevel_Offset = NativeReflectionCached.GetPropertyOffset(RemapFoliageTypeAndCompsInLevel_FunctionAddress, "TargetLevel");
		RemapFoliageTypeAndCompsInLevel_TargetLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapFoliageTypeAndCompsInLevel_FunctionAddress, "TargetLevel", Classes.FObjectProperty);
		RemapFoliageTypeAndCompsInLevel_IsValid = RemapFoliageTypeAndCompsInLevel_FunctionAddress != IntPtr.Zero && RemapFoliageTypeAndCompsInLevel_TargetLevel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndCompsInLevel", RemapFoliageTypeAndCompsInLevel_IsValid);
		RemapFoliageTypeAndComps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemapFoliageTypeAndComps");
		RemapFoliageTypeAndComps_ParamsSize = NativeReflection.GetFunctionParamsSize(RemapFoliageTypeAndComps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemapFoliageTypeAndComps_InAsset_PropertyAddress, RemapFoliageTypeAndComps_FunctionAddress, "InAsset");
		RemapFoliageTypeAndComps_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(RemapFoliageTypeAndComps_FunctionAddress, "InAsset");
		RemapFoliageTypeAndComps_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RemapFoliageTypeAndComps_FunctionAddress, "InAsset", Classes.FStructProperty);
		RemapFoliageTypeAndComps_IsValid = RemapFoliageTypeAndComps_FunctionAddress != IntPtr.Zero && RemapFoliageTypeAndComps_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RemapFoliageTypeAndComps", RemapFoliageTypeAndComps_IsValid);
		RefreshViewportLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshViewportLocation");
		RefreshViewportLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshViewportLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshViewportLocation_CamPos_PropertyAddress, RefreshViewportLocation_FunctionAddress, "CamPos");
		RefreshViewportLocation_CamPos_Offset = NativeReflectionCached.GetPropertyOffset(RefreshViewportLocation_FunctionAddress, "CamPos");
		RefreshViewportLocation_CamPos_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshViewportLocation_FunctionAddress, "CamPos", Classes.FStructProperty);
		RefreshViewportLocation_IsValid = RefreshViewportLocation_FunctionAddress != IntPtr.Zero && RefreshViewportLocation_CamPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshViewportLocation", RefreshViewportLocation_IsValid);
		RefreshTileLevelsHierarchy_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RefreshTileLevelsHierarchy");
		RefreshTileLevelsHierarchy_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshTileLevelsHierarchy_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RefreshTileLevelsHierarchy_InPersistentLevelPath_PropertyAddress, RefreshTileLevelsHierarchy_FunctionAddress, "InPersistentLevelPath");
		RefreshTileLevelsHierarchy_InPersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(RefreshTileLevelsHierarchy_FunctionAddress, "InPersistentLevelPath");
		RefreshTileLevelsHierarchy_InPersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RefreshTileLevelsHierarchy_FunctionAddress, "InPersistentLevelPath", Classes.FStrProperty);
		RefreshTileLevelsHierarchy_IsValid = RefreshTileLevelsHierarchy_FunctionAddress != IntPtr.Zero && RefreshTileLevelsHierarchy_InPersistentLevelPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:RefreshTileLevelsHierarchy", RefreshTileLevelsHierarchy_IsValid);
		ProcessPerActorLODSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ProcessPerActorLODSettings");
		ProcessPerActorLODSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessPerActorLODSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessPerActorLODSettings_SrcFolderPath_PropertyAddress, ProcessPerActorLODSettings_FunctionAddress, "SrcFolderPath");
		ProcessPerActorLODSettings_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(ProcessPerActorLODSettings_FunctionAddress, "SrcFolderPath");
		ProcessPerActorLODSettings_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessPerActorLODSettings_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessPerActorLODSettings_SettingPtr_PropertyAddress, ProcessPerActorLODSettings_FunctionAddress, "SettingPtr");
		ProcessPerActorLODSettings_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(ProcessPerActorLODSettings_FunctionAddress, "SettingPtr");
		ProcessPerActorLODSettings_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessPerActorLODSettings_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		ProcessPerActorLODSettings_IsValid = ProcessPerActorLODSettings_FunctionAddress != IntPtr.Zero && ProcessPerActorLODSettings_SrcFolderPath_IsValid && ProcessPerActorLODSettings_SettingPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ProcessPerActorLODSettings", ProcessPerActorLODSettings_IsValid);
		PrintTilesStatsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintTilesStatsInfo");
		PrintTilesStatsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintTilesStatsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrintTilesStatsInfo_RootDirectory_PropertyAddress, PrintTilesStatsInfo_FunctionAddress, "RootDirectory");
		PrintTilesStatsInfo_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(PrintTilesStatsInfo_FunctionAddress, "RootDirectory");
		PrintTilesStatsInfo_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(PrintTilesStatsInfo_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		PrintTilesStatsInfo_IsValid = PrintTilesStatsInfo_FunctionAddress != IntPtr.Zero && PrintTilesStatsInfo_RootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesStatsInfo", PrintTilesStatsInfo_IsValid);
		PrintTilesSkippability_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintTilesSkippability");
		PrintTilesSkippability_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintTilesSkippability_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrintTilesSkippability_RootDirectory_PropertyAddress, PrintTilesSkippability_FunctionAddress, "RootDirectory");
		PrintTilesSkippability_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(PrintTilesSkippability_FunctionAddress, "RootDirectory");
		PrintTilesSkippability_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(PrintTilesSkippability_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		PrintTilesSkippability_IsValid = PrintTilesSkippability_FunctionAddress != IntPtr.Zero && PrintTilesSkippability_RootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:PrintTilesSkippability", PrintTilesSkippability_IsValid);
		PostProcessTileData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostProcessTileData");
		PostProcessTileData_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessTileData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostProcessTileData_SourceRootDirectory_PropertyAddress, PostProcessTileData_FunctionAddress, "SourceRootDirectory");
		PostProcessTileData_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(PostProcessTileData_FunctionAddress, "SourceRootDirectory");
		PostProcessTileData_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(PostProcessTileData_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostProcessTileData_SettingPtr_PropertyAddress, PostProcessTileData_FunctionAddress, "SettingPtr");
		PostProcessTileData_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(PostProcessTileData_FunctionAddress, "SettingPtr");
		PostProcessTileData_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(PostProcessTileData_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		PostProcessTileData_IsValid = PostProcessTileData_FunctionAddress != IntPtr.Zero && PostProcessTileData_SourceRootDirectory_IsValid && PostProcessTileData_SettingPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:PostProcessTileData", PostProcessTileData_IsValid);
		MoveAllFoliageInstancesToTargetWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveAllFoliageInstancesToTargetWorld");
		MoveAllFoliageInstancesToTargetWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveAllFoliageInstancesToTargetWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_PropertyAddress, MoveAllFoliageInstancesToTargetWorld_FunctionAddress, "TargetMapPackageName");
		MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_Offset = NativeReflectionCached.GetPropertyOffset(MoveAllFoliageInstancesToTargetWorld_FunctionAddress, "TargetMapPackageName");
		MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveAllFoliageInstancesToTargetWorld_FunctionAddress, "TargetMapPackageName", Classes.FStrProperty);
		MoveAllFoliageInstancesToTargetWorld_IsValid = MoveAllFoliageInstancesToTargetWorld_FunctionAddress != IntPtr.Zero && MoveAllFoliageInstancesToTargetWorld_TargetMapPackageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveAllFoliageInstancesToTargetWorld", MoveAllFoliageInstancesToTargetWorld_IsValid);
		MoveActorsBackToDominantLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveActorsBackToDominantLevel");
		MoveActorsBackToDominantLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveActorsBackToDominantLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackToDominantLevel_SourceRootDirectory_PropertyAddress, MoveActorsBackToDominantLevel_FunctionAddress, "SourceRootDirectory");
		MoveActorsBackToDominantLevel_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackToDominantLevel_FunctionAddress, "SourceRootDirectory");
		MoveActorsBackToDominantLevel_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackToDominantLevel_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackToDominantLevel_SettingPtr_PropertyAddress, MoveActorsBackToDominantLevel_FunctionAddress, "SettingPtr");
		MoveActorsBackToDominantLevel_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackToDominantLevel_FunctionAddress, "SettingPtr");
		MoveActorsBackToDominantLevel_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackToDominantLevel_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackToDominantLevel_ReturnValue_PropertyAddress, MoveActorsBackToDominantLevel_FunctionAddress, "ReturnValue");
		MoveActorsBackToDominantLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackToDominantLevel_FunctionAddress, "ReturnValue");
		MoveActorsBackToDominantLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackToDominantLevel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MoveActorsBackToDominantLevel_IsValid = MoveActorsBackToDominantLevel_FunctionAddress != IntPtr.Zero && MoveActorsBackToDominantLevel_SourceRootDirectory_IsValid && MoveActorsBackToDominantLevel_SettingPtr_IsValid && MoveActorsBackToDominantLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackToDominantLevel", MoveActorsBackToDominantLevel_IsValid);
		MoveActorsBackAndCacheActorsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveActorsBackAndCacheActorsInfo");
		MoveActorsBackAndCacheActorsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveActorsBackAndCacheActorsInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_PropertyAddress, MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SourceRootDirectory");
		MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SourceRootDirectory");
		MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackAndCacheActorsInfo_SettingPtr_PropertyAddress, MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SettingPtr");
		MoveActorsBackAndCacheActorsInfo_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SettingPtr");
		MoveActorsBackAndCacheActorsInfo_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveActorsBackAndCacheActorsInfo_ReturnValue_PropertyAddress, MoveActorsBackAndCacheActorsInfo_FunctionAddress, "ReturnValue");
		MoveActorsBackAndCacheActorsInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "ReturnValue");
		MoveActorsBackAndCacheActorsInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveActorsBackAndCacheActorsInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MoveActorsBackAndCacheActorsInfo_IsValid = MoveActorsBackAndCacheActorsInfo_FunctionAddress != IntPtr.Zero && MoveActorsBackAndCacheActorsInfo_SourceRootDirectory_IsValid && MoveActorsBackAndCacheActorsInfo_SettingPtr_IsValid && MoveActorsBackAndCacheActorsInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:MoveActorsBackAndCacheActorsInfo", MoveActorsBackAndCacheActorsInfo_IsValid);
		ModifyNameForActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ModifyNameForActors");
		ModifyNameForActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyNameForActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ModifyNameForActors_Actors_PropertyAddress, ModifyNameForActors_FunctionAddress, "Actors");
		ModifyNameForActors_Actors_Offset = NativeReflectionCached.GetPropertyOffset(ModifyNameForActors_FunctionAddress, "Actors");
		ModifyNameForActors_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyNameForActors_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyNameForActors_replaceStr_PropertyAddress, ModifyNameForActors_FunctionAddress, "replaceStr");
		ModifyNameForActors_replaceStr_Offset = NativeReflectionCached.GetPropertyOffset(ModifyNameForActors_FunctionAddress, "replaceStr");
		ModifyNameForActors_replaceStr_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyNameForActors_FunctionAddress, "replaceStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyNameForActors_NewStr_PropertyAddress, ModifyNameForActors_FunctionAddress, "NewStr");
		ModifyNameForActors_NewStr_Offset = NativeReflectionCached.GetPropertyOffset(ModifyNameForActors_FunctionAddress, "NewStr");
		ModifyNameForActors_NewStr_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyNameForActors_FunctionAddress, "NewStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyNameForActors_NotFitGoAppend_PropertyAddress, ModifyNameForActors_FunctionAddress, "NotFitGoAppend");
		ModifyNameForActors_NotFitGoAppend_Offset = NativeReflectionCached.GetPropertyOffset(ModifyNameForActors_FunctionAddress, "NotFitGoAppend");
		ModifyNameForActors_NotFitGoAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(ModifyNameForActors_FunctionAddress, "NotFitGoAppend", Classes.FBoolProperty);
		ModifyNameForActors_IsValid = ModifyNameForActors_FunctionAddress != IntPtr.Zero && ModifyNameForActors_Actors_IsValid && ModifyNameForActors_replaceStr_IsValid && ModifyNameForActors_NewStr_IsValid && ModifyNameForActors_NotFitGoAppend_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ModifyNameForActors", ModifyNameForActors_IsValid);
		MakeLevelNameDecorateLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeLevelNameDecorateLevelActor");
		MakeLevelNameDecorateLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeLevelNameDecorateLevelActor_FunctionAddress);
		MakeLevelNameDecorateLevelActor_IsValid = MakeLevelNameDecorateLevelActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:MakeLevelNameDecorateLevelActor", MakeLevelNameDecorateLevelActor_IsValid);
		LoadWCTileMapSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadWCTileMapSettings");
		LoadWCTileMapSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadWCTileMapSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadWCTileMapSettings_MapFolder_PropertyAddress, LoadWCTileMapSettings_FunctionAddress, "MapFolder");
		LoadWCTileMapSettings_MapFolder_Offset = NativeReflectionCached.GetPropertyOffset(LoadWCTileMapSettings_FunctionAddress, "MapFolder");
		LoadWCTileMapSettings_MapFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadWCTileMapSettings_FunctionAddress, "MapFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadWCTileMapSettings_bDebugLog_PropertyAddress, LoadWCTileMapSettings_FunctionAddress, "bDebugLog");
		LoadWCTileMapSettings_bDebugLog_Offset = NativeReflectionCached.GetPropertyOffset(LoadWCTileMapSettings_FunctionAddress, "bDebugLog");
		LoadWCTileMapSettings_bDebugLog_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadWCTileMapSettings_FunctionAddress, "bDebugLog", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadWCTileMapSettings_ReturnValue_PropertyAddress, LoadWCTileMapSettings_FunctionAddress, "ReturnValue");
		LoadWCTileMapSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadWCTileMapSettings_FunctionAddress, "ReturnValue");
		LoadWCTileMapSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadWCTileMapSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadWCTileMapSettings_IsValid = LoadWCTileMapSettings_FunctionAddress != IntPtr.Zero && LoadWCTileMapSettings_MapFolder_IsValid && LoadWCTileMapSettings_bDebugLog_IsValid && LoadWCTileMapSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadWCTileMapSettings", LoadWCTileMapSettings_IsValid);
		LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadStreamingLevelsIntoCurrentPersistent");
		LoadStreamingLevelsIntoCurrentPersistent_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames", Classes.FArrayProperty);
		LoadStreamingLevelsIntoCurrentPersistent_IsValid = LoadStreamingLevelsIntoCurrentPersistent_FunctionAddress != IntPtr.Zero && LoadStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadStreamingLevelsIntoCurrentPersistent", LoadStreamingLevelsIntoCurrentPersistent_IsValid);
		LoadAllWCLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadAllWCLevels");
		LoadAllWCLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAllWCLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadAllWCLevels_InWorld_PropertyAddress, LoadAllWCLevels_FunctionAddress, "InWorld");
		LoadAllWCLevels_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(LoadAllWCLevels_FunctionAddress, "InWorld");
		LoadAllWCLevels_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAllWCLevels_FunctionAddress, "InWorld", Classes.FObjectProperty);
		LoadAllWCLevels_IsValid = LoadAllWCLevels_FunctionAddress != IntPtr.Zero && LoadAllWCLevels_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:LoadAllWCLevels", LoadAllWCLevels_IsValid);
		HideStreamingLevelsIntoCurrentPersistent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HideStreamingLevelsIntoCurrentPersistent");
		HideStreamingLevelsIntoCurrentPersistent_ParamsSize = NativeReflection.GetFunctionParamsSize(HideStreamingLevelsIntoCurrentPersistent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_PropertyAddress, HideStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(HideStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames");
		HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(HideStreamingLevelsIntoCurrentPersistent_FunctionAddress, "InSubLevelNames", Classes.FArrayProperty);
		HideStreamingLevelsIntoCurrentPersistent_IsValid = HideStreamingLevelsIntoCurrentPersistent_FunctionAddress != IntPtr.Zero && HideStreamingLevelsIntoCurrentPersistent_InSubLevelNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:HideStreamingLevelsIntoCurrentPersistent", HideStreamingLevelsIntoCurrentPersistent_IsValid);
		HideAllWCLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HideAllWCLevels");
		HideAllWCLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(HideAllWCLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HideAllWCLevels_InWorld_PropertyAddress, HideAllWCLevels_FunctionAddress, "InWorld");
		HideAllWCLevels_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(HideAllWCLevels_FunctionAddress, "InWorld");
		HideAllWCLevels_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(HideAllWCLevels_FunctionAddress, "InWorld", Classes.FObjectProperty);
		HideAllWCLevels_IsValid = HideAllWCLevels_FunctionAddress != IntPtr.Zero && HideAllWCLevels_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:HideAllWCLevels", HideAllWCLevels_IsValid);
		GSWCReorganizeActorsSimple_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSWCReorganizeActorsSimple");
		GSWCReorganizeActorsSimple_ParamsSize = NativeReflection.GetFunctionParamsSize(GSWCReorganizeActorsSimple_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSWCReorganizeActorsSimple_SourceRootDirectory_PropertyAddress, GSWCReorganizeActorsSimple_FunctionAddress, "SourceRootDirectory");
		GSWCReorganizeActorsSimple_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GSWCReorganizeActorsSimple_FunctionAddress, "SourceRootDirectory");
		GSWCReorganizeActorsSimple_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GSWCReorganizeActorsSimple_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSWCReorganizeActorsSimple_SettingPtr_PropertyAddress, GSWCReorganizeActorsSimple_FunctionAddress, "SettingPtr");
		GSWCReorganizeActorsSimple_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(GSWCReorganizeActorsSimple_FunctionAddress, "SettingPtr");
		GSWCReorganizeActorsSimple_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(GSWCReorganizeActorsSimple_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		GSWCReorganizeActorsSimple_IsValid = GSWCReorganizeActorsSimple_FunctionAddress != IntPtr.Zero && GSWCReorganizeActorsSimple_SourceRootDirectory_IsValid && GSWCReorganizeActorsSimple_SettingPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActorsSimple", GSWCReorganizeActorsSimple_IsValid);
		GSWCReorganizeActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GSWCReorganizeActors");
		GSWCReorganizeActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GSWCReorganizeActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GSWCReorganizeActors_SourceRootDirectory_PropertyAddress, GSWCReorganizeActors_FunctionAddress, "SourceRootDirectory");
		GSWCReorganizeActors_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GSWCReorganizeActors_FunctionAddress, "SourceRootDirectory");
		GSWCReorganizeActors_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GSWCReorganizeActors_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GSWCReorganizeActors_SettingPtr_PropertyAddress, GSWCReorganizeActors_FunctionAddress, "SettingPtr");
		GSWCReorganizeActors_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(GSWCReorganizeActors_FunctionAddress, "SettingPtr");
		GSWCReorganizeActors_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(GSWCReorganizeActors_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		GSWCReorganizeActors_IsValid = GSWCReorganizeActors_FunctionAddress != IntPtr.Zero && GSWCReorganizeActors_SourceRootDirectory_IsValid && GSWCReorganizeActors_SettingPtr_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GSWCReorganizeActors", GSWCReorganizeActors_IsValid);
		GetWorldContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetWorldContext");
		GetWorldContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldContext_ReturnValue_PropertyAddress, GetWorldContext_FunctionAddress, "ReturnValue");
		GetWorldContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldContext_FunctionAddress, "ReturnValue");
		GetWorldContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldContext_IsValid = GetWorldContext_FunctionAddress != IntPtr.Zero && GetWorldContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetWorldContext", GetWorldContext_IsValid);
		GetViewportXY_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportXY");
		GetViewportXY_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportXY_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportXY_ReturnValue_PropertyAddress, GetViewportXY_FunctionAddress, "ReturnValue");
		GetViewportXY_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportXY_FunctionAddress, "ReturnValue");
		GetViewportXY_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportXY_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportXY_IsValid = GetViewportXY_FunctionAddress != IntPtr.Zero && GetViewportXY_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportXY", GetViewportXY_IsValid);
		GetViewportLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetViewportLocation");
		GetViewportLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportLocation_ReturnValue_PropertyAddress, GetViewportLocation_FunctionAddress, "ReturnValue");
		GetViewportLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportLocation_FunctionAddress, "ReturnValue");
		GetViewportLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewportLocation_IsValid = GetViewportLocation_FunctionAddress != IntPtr.Zero && GetViewportLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetViewportLocation", GetViewportLocation_IsValid);
		GetSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSelectedActors");
		GetSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSelectedActors_ReturnValue_PropertyAddress, GetSelectedActors_FunctionAddress, "ReturnValue");
		GetSelectedActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSelectedActors_FunctionAddress, "ReturnValue");
		GetSelectedActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSelectedActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSelectedActors_IsValid = GetSelectedActors_FunctionAddress != IntPtr.Zero && GetSelectedActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetSelectedActors", GetSelectedActors_IsValid);
		GetOrthoUnitsPerPixel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOrthoUnitsPerPixel");
		GetOrthoUnitsPerPixel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOrthoUnitsPerPixel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOrthoUnitsPerPixel_ReturnValue_PropertyAddress, GetOrthoUnitsPerPixel_FunctionAddress, "ReturnValue");
		GetOrthoUnitsPerPixel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOrthoUnitsPerPixel_FunctionAddress, "ReturnValue");
		GetOrthoUnitsPerPixel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOrthoUnitsPerPixel_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetOrthoUnitsPerPixel_IsValid = GetOrthoUnitsPerPixel_FunctionAddress != IntPtr.Zero && GetOrthoUnitsPerPixel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetOrthoUnitsPerPixel", GetOrthoUnitsPerPixel_IsValid);
		GetLevelsInWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelsInWorld");
		GetLevelsInWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelsInWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelsInWorld_CurWorld_PropertyAddress, GetLevelsInWorld_FunctionAddress, "CurWorld");
		GetLevelsInWorld_CurWorld_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelsInWorld_FunctionAddress, "CurWorld");
		GetLevelsInWorld_CurWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelsInWorld_FunctionAddress, "CurWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelsInWorld_OutSubLevels_PropertyAddress, GetLevelsInWorld_FunctionAddress, "OutSubLevels");
		GetLevelsInWorld_OutSubLevels_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelsInWorld_FunctionAddress, "OutSubLevels");
		GetLevelsInWorld_OutSubLevels_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelsInWorld_FunctionAddress, "OutSubLevels", Classes.FArrayProperty);
		GetLevelsInWorld_IsValid = GetLevelsInWorld_FunctionAddress != IntPtr.Zero && GetLevelsInWorld_CurWorld_IsValid && GetLevelsInWorld_OutSubLevels_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelsInWorld", GetLevelsInWorld_IsValid);
		GetLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevels");
		GetLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevels_World_PropertyAddress, GetLevels_FunctionAddress, "World");
		GetLevels_World_Offset = NativeReflectionCached.GetPropertyOffset(GetLevels_FunctionAddress, "World");
		GetLevels_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevels_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevels_ReturnValue_PropertyAddress, GetLevels_FunctionAddress, "ReturnValue");
		GetLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevels_FunctionAddress, "ReturnValue");
		GetLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevels_IsValid = GetLevels_FunctionAddress != IntPtr.Zero && GetLevels_World_IsValid && GetLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevels", GetLevels_IsValid);
		GetLevelByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelByName");
		GetLevelByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelByName_LevelName_PropertyAddress, GetLevelByName_FunctionAddress, "LevelName");
		GetLevelByName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelByName_FunctionAddress, "LevelName");
		GetLevelByName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelByName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelByName_ReturnValue_PropertyAddress, GetLevelByName_FunctionAddress, "ReturnValue");
		GetLevelByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelByName_FunctionAddress, "ReturnValue");
		GetLevelByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLevelByName_IsValid = GetLevelByName_FunctionAddress != IntPtr.Zero && GetLevelByName_LevelName_IsValid && GetLevelByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelByName", GetLevelByName_IsValid);
		GetLevelBoundsFromAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelBoundsFromAsset");
		GetLevelBoundsFromAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelBoundsFromAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelBoundsFromAsset_Asset_PropertyAddress, GetLevelBoundsFromAsset_FunctionAddress, "Asset");
		GetLevelBoundsFromAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelBoundsFromAsset_FunctionAddress, "Asset");
		GetLevelBoundsFromAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelBoundsFromAsset_FunctionAddress, "Asset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelBoundsFromAsset_ReturnValue_PropertyAddress, GetLevelBoundsFromAsset_FunctionAddress, "ReturnValue");
		GetLevelBoundsFromAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelBoundsFromAsset_FunctionAddress, "ReturnValue");
		GetLevelBoundsFromAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelBoundsFromAsset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelBoundsFromAsset_IsValid = GetLevelBoundsFromAsset_FunctionAddress != IntPtr.Zero && GetLevelBoundsFromAsset_Asset_IsValid && GetLevelBoundsFromAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelBoundsFromAsset", GetLevelBoundsFromAsset_IsValid);
		GetLevelAllActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelAllActors");
		GetLevelAllActors_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelAllActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelAllActors_Level_PropertyAddress, GetLevelAllActors_FunctionAddress, "Level");
		GetLevelAllActors_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelAllActors_FunctionAddress, "Level");
		GetLevelAllActors_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelAllActors_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelAllActors_ReturnValue_PropertyAddress, GetLevelAllActors_FunctionAddress, "ReturnValue");
		GetLevelAllActors_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelAllActors_FunctionAddress, "ReturnValue");
		GetLevelAllActors_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelAllActors_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevelAllActors_IsValid = GetLevelAllActors_FunctionAddress != IntPtr.Zero && GetLevelAllActors_Level_IsValid && GetLevelAllActors_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetLevelAllActors", GetLevelAllActors_IsValid);
		GetGSWCItemLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGSWCItemLevels");
		GetGSWCItemLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGSWCItemLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGSWCItemLevels_SrcFolderPath_PropertyAddress, GetGSWCItemLevels_FunctionAddress, "SrcFolderPath");
		GetGSWCItemLevels_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GetGSWCItemLevels_FunctionAddress, "SrcFolderPath");
		GetGSWCItemLevels_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSWCItemLevels_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGSWCItemLevels_OutItemLevelAssets_PropertyAddress, GetGSWCItemLevels_FunctionAddress, "OutItemLevelAssets");
		GetGSWCItemLevels_OutItemLevelAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetGSWCItemLevels_FunctionAddress, "OutItemLevelAssets");
		GetGSWCItemLevels_OutItemLevelAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSWCItemLevels_FunctionAddress, "OutItemLevelAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGSWCItemLevels_ReturnValue_PropertyAddress, GetGSWCItemLevels_FunctionAddress, "ReturnValue");
		GetGSWCItemLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGSWCItemLevels_FunctionAddress, "ReturnValue");
		GetGSWCItemLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGSWCItemLevels_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetGSWCItemLevels_IsValid = GetGSWCItemLevels_FunctionAddress != IntPtr.Zero && GetGSWCItemLevels_SrcFolderPath_IsValid && GetGSWCItemLevels_OutItemLevelAssets_IsValid && GetGSWCItemLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetGSWCItemLevels", GetGSWCItemLevels_IsValid);
		GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFoliageInstanceDataFromLevelByLevelName");
		GetFoliageInstanceDataFromLevelByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevelByLevelName_LevelName_PropertyAddress, GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "LevelName");
		GetFoliageInstanceDataFromLevelByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "LevelName");
		GetFoliageInstanceDataFromLevelByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevelByLevelName_type_PropertyAddress, GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "type");
		GetFoliageInstanceDataFromLevelByLevelName_type_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "type");
		GetFoliageInstanceDataFromLevelByLevelName_type_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_PropertyAddress, GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "ReturnValue");
		GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "ReturnValue");
		GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetFoliageInstanceDataFromLevelByLevelName_IsValid = GetFoliageInstanceDataFromLevelByLevelName_FunctionAddress != IntPtr.Zero && GetFoliageInstanceDataFromLevelByLevelName_LevelName_IsValid && GetFoliageInstanceDataFromLevelByLevelName_type_IsValid && GetFoliageInstanceDataFromLevelByLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevelByLevelName", GetFoliageInstanceDataFromLevelByLevelName_IsValid);
		GetFoliageInstanceDataFromLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFoliageInstanceDataFromLevel");
		GetFoliageInstanceDataFromLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFoliageInstanceDataFromLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevel_Level_PropertyAddress, GetFoliageInstanceDataFromLevel_FunctionAddress, "Level");
		GetFoliageInstanceDataFromLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevel_FunctionAddress, "Level");
		GetFoliageInstanceDataFromLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevel_type_PropertyAddress, GetFoliageInstanceDataFromLevel_FunctionAddress, "type");
		GetFoliageInstanceDataFromLevel_type_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevel_FunctionAddress, "type");
		GetFoliageInstanceDataFromLevel_type_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevel_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFoliageInstanceDataFromLevel_ReturnValue_PropertyAddress, GetFoliageInstanceDataFromLevel_FunctionAddress, "ReturnValue");
		GetFoliageInstanceDataFromLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFoliageInstanceDataFromLevel_FunctionAddress, "ReturnValue");
		GetFoliageInstanceDataFromLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFoliageInstanceDataFromLevel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetFoliageInstanceDataFromLevel_IsValid = GetFoliageInstanceDataFromLevel_FunctionAddress != IntPtr.Zero && GetFoliageInstanceDataFromLevel_Level_IsValid && GetFoliageInstanceDataFromLevel_type_IsValid && GetFoliageInstanceDataFromLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetFoliageInstanceDataFromLevel", GetFoliageInstanceDataFromLevel_IsValid);
		GetCurrentPersistentLevelWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentPersistentLevelWorld");
		GetCurrentPersistentLevelWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPersistentLevelWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPersistentLevelWorld_ReturnValue_PropertyAddress, GetCurrentPersistentLevelWorld_FunctionAddress, "ReturnValue");
		GetCurrentPersistentLevelWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPersistentLevelWorld_FunctionAddress, "ReturnValue");
		GetCurrentPersistentLevelWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPersistentLevelWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentPersistentLevelWorld_IsValid = GetCurrentPersistentLevelWorld_FunctionAddress != IntPtr.Zero && GetCurrentPersistentLevelWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelWorld", GetCurrentPersistentLevelWorld_IsValid);
		GetCurrentPersistentLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentPersistentLevelName");
		GetCurrentPersistentLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPersistentLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPersistentLevelName_ReturnValue_PropertyAddress, GetCurrentPersistentLevelName_FunctionAddress, "ReturnValue");
		GetCurrentPersistentLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPersistentLevelName_FunctionAddress, "ReturnValue");
		GetCurrentPersistentLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPersistentLevelName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCurrentPersistentLevelName_IsValid = GetCurrentPersistentLevelName_FunctionAddress != IntPtr.Zero && GetCurrentPersistentLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentPersistentLevelName", GetCurrentPersistentLevelName_IsValid);
		GetCurrentAllWCLevelsName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentAllWCLevelsName");
		GetCurrentAllWCLevelsName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentAllWCLevelsName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAllWCLevelsName_OutLevelsName_PropertyAddress, GetCurrentAllWCLevelsName_FunctionAddress, "OutLevelsName");
		GetCurrentAllWCLevelsName_OutLevelsName_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAllWCLevelsName_FunctionAddress, "OutLevelsName");
		GetCurrentAllWCLevelsName_OutLevelsName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAllWCLevelsName_FunctionAddress, "OutLevelsName", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentAllWCLevelsName_bIgnoreWCTile_PropertyAddress, GetCurrentAllWCLevelsName_FunctionAddress, "bIgnoreWCTile");
		GetCurrentAllWCLevelsName_bIgnoreWCTile_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentAllWCLevelsName_FunctionAddress, "bIgnoreWCTile");
		GetCurrentAllWCLevelsName_bIgnoreWCTile_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentAllWCLevelsName_FunctionAddress, "bIgnoreWCTile", Classes.FBoolProperty);
		GetCurrentAllWCLevelsName_IsValid = GetCurrentAllWCLevelsName_FunctionAddress != IntPtr.Zero && GetCurrentAllWCLevelsName_OutLevelsName_IsValid && GetCurrentAllWCLevelsName_bIgnoreWCTile_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetCurrentAllWCLevelsName", GetCurrentAllWCLevelsName_IsValid);
		GetAllActorsInsideInBoxInAllWorlds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsInsideInBoxInAllWorlds");
		GetAllActorsInsideInBoxInAllWorlds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_encloseBox_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "encloseBox");
		GetAllActorsInsideInBoxInAllWorlds_encloseBox_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "encloseBox");
		GetAllActorsInsideInBoxInAllWorlds_encloseBox_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "encloseBox", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_allWorld_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "allWorld");
		GetAllActorsInsideInBoxInAllWorlds_allWorld_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "allWorld");
		GetAllActorsInsideInBoxInAllWorlds_allWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "allWorld", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "LimitComponentNum");
		GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "LimitComponentNum");
		GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "LimitComponentNum", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "filterSizePercent");
		GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "filterSizePercent");
		GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "filterSizePercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "bMustLevelBoundsRelevant");
		GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "bMustLevelBoundsRelevant");
		GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "bMustLevelBoundsRelevant", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllWorlds_ReturnValue_PropertyAddress, GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "ReturnValue");
		GetAllActorsInsideInBoxInAllWorlds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "ReturnValue");
		GetAllActorsInsideInBoxInAllWorlds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllWorlds_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllActorsInsideInBoxInAllWorlds_IsValid = GetAllActorsInsideInBoxInAllWorlds_FunctionAddress != IntPtr.Zero && GetAllActorsInsideInBoxInAllWorlds_encloseBox_IsValid && GetAllActorsInsideInBoxInAllWorlds_allWorld_IsValid && GetAllActorsInsideInBoxInAllWorlds_LimitComponentNum_IsValid && GetAllActorsInsideInBoxInAllWorlds_filterSizePercent_IsValid && GetAllActorsInsideInBoxInAllWorlds_bMustLevelBoundsRelevant_IsValid && GetAllActorsInsideInBoxInAllWorlds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllWorlds", GetAllActorsInsideInBoxInAllWorlds_IsValid);
		GetAllActorsInsideInBoxInAllLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsInsideInBoxInAllLevels");
		GetAllActorsInsideInBoxInAllLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsInsideInBoxInAllLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_encloseBox_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "encloseBox");
		GetAllActorsInsideInBoxInAllLevels_encloseBox_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "encloseBox");
		GetAllActorsInsideInBoxInAllLevels_encloseBox_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "encloseBox", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_allLevel_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "allLevel");
		GetAllActorsInsideInBoxInAllLevels_allLevel_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "allLevel");
		GetAllActorsInsideInBoxInAllLevels_allLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "allLevel", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "LimitComponentNum");
		GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "LimitComponentNum");
		GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "LimitComponentNum", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_filterSizePercent_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "filterSizePercent");
		GetAllActorsInsideInBoxInAllLevels_filterSizePercent_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "filterSizePercent");
		GetAllActorsInsideInBoxInAllLevels_filterSizePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "filterSizePercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "bMustLevelBoundsRelevant");
		GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "bMustLevelBoundsRelevant");
		GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "bMustLevelBoundsRelevant", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInsideInBoxInAllLevels_ReturnValue_PropertyAddress, GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "ReturnValue");
		GetAllActorsInsideInBoxInAllLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "ReturnValue");
		GetAllActorsInsideInBoxInAllLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInsideInBoxInAllLevels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllActorsInsideInBoxInAllLevels_IsValid = GetAllActorsInsideInBoxInAllLevels_FunctionAddress != IntPtr.Zero && GetAllActorsInsideInBoxInAllLevels_encloseBox_IsValid && GetAllActorsInsideInBoxInAllLevels_allLevel_IsValid && GetAllActorsInsideInBoxInAllLevels_LimitComponentNum_IsValid && GetAllActorsInsideInBoxInAllLevels_filterSizePercent_IsValid && GetAllActorsInsideInBoxInAllLevels_bMustLevelBoundsRelevant_IsValid && GetAllActorsInsideInBoxInAllLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetAllActorsInsideInBoxInAllLevels", GetAllActorsInsideInBoxInAllLevels_IsValid);
		GetActorListByDistanceSignificance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorListByDistanceSignificance");
		GetActorListByDistanceSignificance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorListByDistanceSignificance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorListByDistanceSignificance_OriginalActor_PropertyAddress, GetActorListByDistanceSignificance_FunctionAddress, "OriginalActor");
		GetActorListByDistanceSignificance_OriginalActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorListByDistanceSignificance_FunctionAddress, "OriginalActor");
		GetActorListByDistanceSignificance_OriginalActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorListByDistanceSignificance_FunctionAddress, "OriginalActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorListByDistanceSignificance_traceRadius_PropertyAddress, GetActorListByDistanceSignificance_FunctionAddress, "traceRadius");
		GetActorListByDistanceSignificance_traceRadius_Offset = NativeReflectionCached.GetPropertyOffset(GetActorListByDistanceSignificance_FunctionAddress, "traceRadius");
		GetActorListByDistanceSignificance_traceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorListByDistanceSignificance_FunctionAddress, "traceRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorListByDistanceSignificance_ReturnValue_PropertyAddress, GetActorListByDistanceSignificance_FunctionAddress, "ReturnValue");
		GetActorListByDistanceSignificance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorListByDistanceSignificance_FunctionAddress, "ReturnValue");
		GetActorListByDistanceSignificance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorListByDistanceSignificance_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetActorListByDistanceSignificance_IsValid = GetActorListByDistanceSignificance_FunctionAddress != IntPtr.Zero && GetActorListByDistanceSignificance_OriginalActor_IsValid && GetActorListByDistanceSignificance_traceRadius_IsValid && GetActorListByDistanceSignificance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GetActorListByDistanceSignificance", GetActorListByDistanceSignificance_IsValid);
		GenerateWCTileConfig_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateWCTileConfig");
		GenerateWCTileConfig_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateWCTileConfig_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateWCTileConfig_SrcFolderPath_PropertyAddress, GenerateWCTileConfig_FunctionAddress, "SrcFolderPath");
		GenerateWCTileConfig_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWCTileConfig_FunctionAddress, "SrcFolderPath");
		GenerateWCTileConfig_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWCTileConfig_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateWCTileConfig_InSerializeMode_PropertyAddress, GenerateWCTileConfig_FunctionAddress, "InSerializeMode");
		GenerateWCTileConfig_InSerializeMode_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWCTileConfig_FunctionAddress, "InSerializeMode");
		GenerateWCTileConfig_InSerializeMode_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWCTileConfig_FunctionAddress, "InSerializeMode", Classes.FEnumProperty);
		GenerateWCTileConfig_IsValid = GenerateWCTileConfig_FunctionAddress != IntPtr.Zero && GenerateWCTileConfig_SrcFolderPath_IsValid && GenerateWCTileConfig_InSerializeMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateWCTileConfig", GenerateWCTileConfig_IsValid);
		GenerateMapTileLODs_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenerateMapTileLODs");
		GenerateMapTileLODs_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateMapTileLODs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_SrcFolderPath_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "SrcFolderPath");
		GenerateMapTileLODs_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "SrcFolderPath");
		GenerateMapTileLODs_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_InMapFilterNames_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "InMapFilterNames");
		GenerateMapTileLODs_InMapFilterNames_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "InMapFilterNames");
		GenerateMapTileLODs_InMapFilterNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "InMapFilterNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_SettingsPtr_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "SettingsPtr");
		GenerateMapTileLODs_SettingsPtr_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "SettingsPtr");
		GenerateMapTileLODs_SettingsPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "SettingsPtr", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_PersistentLevelName_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "PersistentLevelName");
		GenerateMapTileLODs_PersistentLevelName_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "PersistentLevelName");
		GenerateMapTileLODs_PersistentLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "PersistentLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_bRequiredPreLevelGC_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "bRequiredPreLevelGC");
		GenerateMapTileLODs_bRequiredPreLevelGC_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "bRequiredPreLevelGC");
		GenerateMapTileLODs_bRequiredPreLevelGC_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "bRequiredPreLevelGC", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateMapTileLODs_ReturnValue_PropertyAddress, GenerateMapTileLODs_FunctionAddress, "ReturnValue");
		GenerateMapTileLODs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateMapTileLODs_FunctionAddress, "ReturnValue");
		GenerateMapTileLODs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateMapTileLODs_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GenerateMapTileLODs_IsValid = GenerateMapTileLODs_FunctionAddress != IntPtr.Zero && GenerateMapTileLODs_SrcFolderPath_IsValid && GenerateMapTileLODs_InMapFilterNames_IsValid && GenerateMapTileLODs_SettingsPtr_IsValid && GenerateMapTileLODs_PersistentLevelName_IsValid && GenerateMapTileLODs_bRequiredPreLevelGC_IsValid && GenerateMapTileLODs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:GenerateMapTileLODs", GenerateMapTileLODs_IsValid);
		ForceAllLevelGC_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceAllLevelGC");
		ForceAllLevelGC_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceAllLevelGC_FunctionAddress);
		ForceAllLevelGC_IsValid = ForceAllLevelGC_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ForceAllLevelGC", ForceAllLevelGC_IsValid);
		FixNormalTilesTreeIssues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixNormalTilesTreeIssues");
		FixNormalTilesTreeIssues_ParamsSize = NativeReflection.GetFunctionParamsSize(FixNormalTilesTreeIssues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixNormalTilesTreeIssues_RootDirectory_PropertyAddress, FixNormalTilesTreeIssues_FunctionAddress, "RootDirectory");
		FixNormalTilesTreeIssues_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(FixNormalTilesTreeIssues_FunctionAddress, "RootDirectory");
		FixNormalTilesTreeIssues_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(FixNormalTilesTreeIssues_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		FixNormalTilesTreeIssues_IsValid = FixNormalTilesTreeIssues_FunctionAddress != IntPtr.Zero && FixNormalTilesTreeIssues_RootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:FixNormalTilesTreeIssues", FixNormalTilesTreeIssues_IsValid);
		FixLevelActorAffectNavData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixLevelActorAffectNavData");
		FixLevelActorAffectNavData_ParamsSize = NativeReflection.GetFunctionParamsSize(FixLevelActorAffectNavData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixLevelActorAffectNavData_PointsFilePath_PropertyAddress, FixLevelActorAffectNavData_FunctionAddress, "PointsFilePath");
		FixLevelActorAffectNavData_PointsFilePath_Offset = NativeReflectionCached.GetPropertyOffset(FixLevelActorAffectNavData_FunctionAddress, "PointsFilePath");
		FixLevelActorAffectNavData_PointsFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(FixLevelActorAffectNavData_FunctionAddress, "PointsFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FixLevelActorAffectNavData_ToleranceDistance_PropertyAddress, FixLevelActorAffectNavData_FunctionAddress, "ToleranceDistance");
		FixLevelActorAffectNavData_ToleranceDistance_Offset = NativeReflectionCached.GetPropertyOffset(FixLevelActorAffectNavData_FunctionAddress, "ToleranceDistance");
		FixLevelActorAffectNavData_ToleranceDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(FixLevelActorAffectNavData_FunctionAddress, "ToleranceDistance", Classes.FFloatProperty);
		FixLevelActorAffectNavData_IsValid = FixLevelActorAffectNavData_FunctionAddress != IntPtr.Zero && FixLevelActorAffectNavData_PointsFilePath_IsValid && FixLevelActorAffectNavData_ToleranceDistance_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:FixLevelActorAffectNavData", FixLevelActorAffectNavData_IsValid);
		ExportLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportLevel");
		ExportLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportLevel_bExportSelectedActorsOnly_PropertyAddress, ExportLevel_FunctionAddress, "bExportSelectedActorsOnly");
		ExportLevel_bExportSelectedActorsOnly_Offset = NativeReflectionCached.GetPropertyOffset(ExportLevel_FunctionAddress, "bExportSelectedActorsOnly");
		ExportLevel_bExportSelectedActorsOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportLevel_FunctionAddress, "bExportSelectedActorsOnly", Classes.FBoolProperty);
		ExportLevel_IsValid = ExportLevel_FunctionAddress != IntPtr.Zero && ExportLevel_bExportSelectedActorsOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ExportLevel", ExportLevel_IsValid);
		EmptySelectedActorsOverrideMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EmptySelectedActorsOverrideMaterials");
		EmptySelectedActorsOverrideMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(EmptySelectedActorsOverrideMaterials_FunctionAddress);
		EmptySelectedActorsOverrideMaterials_IsValid = EmptySelectedActorsOverrideMaterials_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:EmptySelectedActorsOverrideMaterials", EmptySelectedActorsOverrideMaterials_IsValid);
		DuplicateSelectedActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateSelectedActors");
		DuplicateSelectedActors_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateSelectedActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateSelectedActors_InWorld_PropertyAddress, DuplicateSelectedActors_FunctionAddress, "InWorld");
		DuplicateSelectedActors_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateSelectedActors_FunctionAddress, "InWorld");
		DuplicateSelectedActors_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateSelectedActors_FunctionAddress, "InWorld", Classes.FObjectProperty);
		DuplicateSelectedActors_IsValid = DuplicateSelectedActors_FunctionAddress != IntPtr.Zero && DuplicateSelectedActors_InWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateSelectedActors", DuplicateSelectedActors_IsValid);
		DuplicateAllLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateAllLevels");
		DuplicateAllLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAllLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_SourceRootDirectory_PropertyAddress, DuplicateAllLevels_FunctionAddress, "SourceRootDirectory");
		DuplicateAllLevels_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "SourceRootDirectory");
		DuplicateAllLevels_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_DestRootDirectory_PropertyAddress, DuplicateAllLevels_FunctionAddress, "DestRootDirectory");
		DuplicateAllLevels_DestRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "DestRootDirectory");
		DuplicateAllLevels_DestRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "DestRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_newPrefix_PropertyAddress, DuplicateAllLevels_FunctionAddress, "newPrefix");
		DuplicateAllLevels_newPrefix_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "newPrefix");
		DuplicateAllLevels_newPrefix_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "newPrefix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_LevelStreamingNameRetargetSrc_PropertyAddress, DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetSrc");
		DuplicateAllLevels_LevelStreamingNameRetargetSrc_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetSrc");
		DuplicateAllLevels_LevelStreamingNameRetargetSrc_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetSrc", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_LevelStreamingNameRetargetDest_PropertyAddress, DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetDest");
		DuplicateAllLevels_LevelStreamingNameRetargetDest_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetDest");
		DuplicateAllLevels_LevelStreamingNameRetargetDest_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "LevelStreamingNameRetargetDest", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_needRescan_PropertyAddress, DuplicateAllLevels_FunctionAddress, "needRescan");
		DuplicateAllLevels_needRescan_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "needRescan");
		DuplicateAllLevels_needRescan_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "needRescan", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAllLevels_ReturnValue_PropertyAddress, DuplicateAllLevels_FunctionAddress, "ReturnValue");
		DuplicateAllLevels_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAllLevels_FunctionAddress, "ReturnValue");
		DuplicateAllLevels_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAllLevels_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		DuplicateAllLevels_IsValid = DuplicateAllLevels_FunctionAddress != IntPtr.Zero && DuplicateAllLevels_SourceRootDirectory_IsValid && DuplicateAllLevels_DestRootDirectory_IsValid && DuplicateAllLevels_newPrefix_IsValid && DuplicateAllLevels_LevelStreamingNameRetargetSrc_IsValid && DuplicateAllLevels_LevelStreamingNameRetargetDest_IsValid && DuplicateAllLevels_needRescan_IsValid && DuplicateAllLevels_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DuplicateAllLevels", DuplicateAllLevels_IsValid);
		DumpSelectedActorBoundsInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DumpSelectedActorBoundsInfo");
		DumpSelectedActorBoundsInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(DumpSelectedActorBoundsInfo_FunctionAddress);
		DumpSelectedActorBoundsInfo_IsValid = DumpSelectedActorBoundsInfo_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpSelectedActorBoundsInfo", DumpSelectedActorBoundsInfo_IsValid);
		DumpLandscapeHeightMapAndWeightMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DumpLandscapeHeightMapAndWeightMap");
		DumpLandscapeHeightMapAndWeightMap_ParamsSize = NativeReflection.GetFunctionParamsSize(DumpLandscapeHeightMapAndWeightMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DumpLandscapeHeightMapAndWeightMap_ProxyActor_PropertyAddress, DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ProxyActor");
		DumpLandscapeHeightMapAndWeightMap_ProxyActor_Offset = NativeReflectionCached.GetPropertyOffset(DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ProxyActor");
		DumpLandscapeHeightMapAndWeightMap_ProxyActor_IsValid = NativeReflectionCached.ValidatePropertyClass(DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ProxyActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DumpLandscapeHeightMapAndWeightMap_ReturnValue_PropertyAddress, DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ReturnValue");
		DumpLandscapeHeightMapAndWeightMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ReturnValue");
		DumpLandscapeHeightMapAndWeightMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DumpLandscapeHeightMapAndWeightMap_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DumpLandscapeHeightMapAndWeightMap_IsValid = DumpLandscapeHeightMapAndWeightMap_FunctionAddress != IntPtr.Zero && DumpLandscapeHeightMapAndWeightMap_ProxyActor_IsValid && DumpLandscapeHeightMapAndWeightMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DumpLandscapeHeightMapAndWeightMap", DumpLandscapeHeightMapAndWeightMap_IsValid);
		DiscardNavigationDataChunks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DiscardNavigationDataChunks");
		DiscardNavigationDataChunks_ParamsSize = NativeReflection.GetFunctionParamsSize(DiscardNavigationDataChunks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DiscardNavigationDataChunks_world_PropertyAddress, DiscardNavigationDataChunks_FunctionAddress, "world");
		DiscardNavigationDataChunks_world_Offset = NativeReflectionCached.GetPropertyOffset(DiscardNavigationDataChunks_FunctionAddress, "world");
		DiscardNavigationDataChunks_world_IsValid = NativeReflectionCached.ValidatePropertyClass(DiscardNavigationDataChunks_FunctionAddress, "world", Classes.FObjectProperty);
		DiscardNavigationDataChunks_IsValid = DiscardNavigationDataChunks_FunctionAddress != IntPtr.Zero && DiscardNavigationDataChunks_world_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DiscardNavigationDataChunks", DiscardNavigationDataChunks_IsValid);
		DisableLodMeshCollisions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableLodMeshCollisions");
		DisableLodMeshCollisions_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableLodMeshCollisions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DisableLodMeshCollisions_PyFilePathBasedOnContentDir_PropertyAddress, DisableLodMeshCollisions_FunctionAddress, "PyFilePathBasedOnContentDir");
		DisableLodMeshCollisions_PyFilePathBasedOnContentDir_Offset = NativeReflectionCached.GetPropertyOffset(DisableLodMeshCollisions_FunctionAddress, "PyFilePathBasedOnContentDir");
		DisableLodMeshCollisions_PyFilePathBasedOnContentDir_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableLodMeshCollisions_FunctionAddress, "PyFilePathBasedOnContentDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableLodMeshCollisions_TargetFolder_PropertyAddress, DisableLodMeshCollisions_FunctionAddress, "TargetFolder");
		DisableLodMeshCollisions_TargetFolder_Offset = NativeReflectionCached.GetPropertyOffset(DisableLodMeshCollisions_FunctionAddress, "TargetFolder");
		DisableLodMeshCollisions_TargetFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(DisableLodMeshCollisions_FunctionAddress, "TargetFolder", Classes.FStrProperty);
		DisableLodMeshCollisions_IsValid = DisableLodMeshCollisions_FunctionAddress != IntPtr.Zero && DisableLodMeshCollisions_PyFilePathBasedOnContentDir_IsValid && DisableLodMeshCollisions_TargetFolder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:DisableLodMeshCollisions", DisableLodMeshCollisions_IsValid);
		CreateShapeActorFromeStaticMeshActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateShapeActorFromeStaticMeshActor");
		CreateShapeActorFromeStaticMeshActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateShapeActorFromeStaticMeshActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateShapeActorFromeStaticMeshActor_AppendMeshActors_PropertyAddress, CreateShapeActorFromeStaticMeshActor_FunctionAddress, "AppendMeshActors");
		CreateShapeActorFromeStaticMeshActor_AppendMeshActors_Offset = NativeReflectionCached.GetPropertyOffset(CreateShapeActorFromeStaticMeshActor_FunctionAddress, "AppendMeshActors");
		CreateShapeActorFromeStaticMeshActor_AppendMeshActors_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateShapeActorFromeStaticMeshActor_FunctionAddress, "AppendMeshActors", Classes.FArrayProperty);
		CreateShapeActorFromeStaticMeshActor_IsValid = CreateShapeActorFromeStaticMeshActor_FunctionAddress != IntPtr.Zero && CreateShapeActorFromeStaticMeshActor_AppendMeshActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateShapeActorFromeStaticMeshActor", CreateShapeActorFromeStaticMeshActor_IsValid);
		CreateLevelFromSelectionActors_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLevelFromSelectionActors");
		CreateLevelFromSelectionActors_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLevelFromSelectionActors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLevelFromSelectionActors_needReplaceActor_PropertyAddress, CreateLevelFromSelectionActors_FunctionAddress, "needReplaceActor");
		CreateLevelFromSelectionActors_needReplaceActor_Offset = NativeReflectionCached.GetPropertyOffset(CreateLevelFromSelectionActors_FunctionAddress, "needReplaceActor");
		CreateLevelFromSelectionActors_needReplaceActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLevelFromSelectionActors_FunctionAddress, "needReplaceActor", Classes.FBoolProperty);
		CreateLevelFromSelectionActors_IsValid = CreateLevelFromSelectionActors_FunctionAddress != IntPtr.Zero && CreateLevelFromSelectionActors_needReplaceActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CreateLevelFromSelectionActors", CreateLevelFromSelectionActors_IsValid);
		ConvertWorld2LevelObject_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertWorld2LevelObject");
		ConvertWorld2LevelObject_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertWorld2LevelObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertWorld2LevelObject_InWorld_PropertyAddress, ConvertWorld2LevelObject_FunctionAddress, "InWorld");
		ConvertWorld2LevelObject_InWorld_Offset = NativeReflectionCached.GetPropertyOffset(ConvertWorld2LevelObject_FunctionAddress, "InWorld");
		ConvertWorld2LevelObject_InWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertWorld2LevelObject_FunctionAddress, "InWorld", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertWorld2LevelObject_ReturnValue_PropertyAddress, ConvertWorld2LevelObject_FunctionAddress, "ReturnValue");
		ConvertWorld2LevelObject_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertWorld2LevelObject_FunctionAddress, "ReturnValue");
		ConvertWorld2LevelObject_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertWorld2LevelObject_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConvertWorld2LevelObject_IsValid = ConvertWorld2LevelObject_FunctionAddress != IntPtr.Zero && ConvertWorld2LevelObject_InWorld_IsValid && ConvertWorld2LevelObject_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertWorld2LevelObject", ConvertWorld2LevelObject_IsValid);
		ConvertStaticMeshActorToInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertStaticMeshActorToInstance");
		ConvertStaticMeshActorToInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertStaticMeshActorToInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToInstance_MeshActors_PropertyAddress, ConvertStaticMeshActorToInstance_FunctionAddress, "MeshActors");
		ConvertStaticMeshActorToInstance_MeshActors_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToInstance_FunctionAddress, "MeshActors");
		ConvertStaticMeshActorToInstance_MeshActors_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToInstance_FunctionAddress, "MeshActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToInstance_UseHISM_PropertyAddress, ConvertStaticMeshActorToInstance_FunctionAddress, "UseHISM");
		ConvertStaticMeshActorToInstance_UseHISM_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToInstance_FunctionAddress, "UseHISM");
		ConvertStaticMeshActorToInstance_UseHISM_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToInstance_FunctionAddress, "UseHISM", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertStaticMeshActorToInstance_MinInstancesCount_PropertyAddress, ConvertStaticMeshActorToInstance_FunctionAddress, "MinInstancesCount");
		ConvertStaticMeshActorToInstance_MinInstancesCount_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStaticMeshActorToInstance_FunctionAddress, "MinInstancesCount");
		ConvertStaticMeshActorToInstance_MinInstancesCount_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStaticMeshActorToInstance_FunctionAddress, "MinInstancesCount", Classes.FIntProperty);
		ConvertStaticMeshActorToInstance_IsValid = ConvertStaticMeshActorToInstance_FunctionAddress != IntPtr.Zero && ConvertStaticMeshActorToInstance_MeshActors_IsValid && ConvertStaticMeshActorToInstance_UseHISM_IsValid && ConvertStaticMeshActorToInstance_MinInstancesCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertStaticMeshActorToInstance", ConvertStaticMeshActorToInstance_IsValid);
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertMatchedBlockingVolumeInLevelToGroundChannel");
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_PropertyAddress, ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InAssets");
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_Offset = NativeReflectionCached.GetPropertyOffset(ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InAssets");
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_PropertyAddress, ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InHeightThreshold");
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_Offset = NativeReflectionCached.GetPropertyOffset(ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InHeightThreshold");
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress, "InHeightThreshold", Classes.FFloatProperty);
		ConvertMatchedBlockingVolumeInLevelToGroundChannel_IsValid = ConvertMatchedBlockingVolumeInLevelToGroundChannel_FunctionAddress != IntPtr.Zero && ConvertMatchedBlockingVolumeInLevelToGroundChannel_InAssets_IsValid && ConvertMatchedBlockingVolumeInLevelToGroundChannel_InHeightThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertMatchedBlockingVolumeInLevelToGroundChannel", ConvertMatchedBlockingVolumeInLevelToGroundChannel_IsValid);
		ConvertLevelStaticMeshToInstance_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertLevelStaticMeshToInstance");
		ConvertLevelStaticMeshToInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertLevelStaticMeshToInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertLevelStaticMeshToInstance_CellX_PropertyAddress, ConvertLevelStaticMeshToInstance_FunctionAddress, "CellX");
		ConvertLevelStaticMeshToInstance_CellX_Offset = NativeReflectionCached.GetPropertyOffset(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellX");
		ConvertLevelStaticMeshToInstance_CellX_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellX", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertLevelStaticMeshToInstance_CellY_PropertyAddress, ConvertLevelStaticMeshToInstance_FunctionAddress, "CellY");
		ConvertLevelStaticMeshToInstance_CellY_Offset = NativeReflectionCached.GetPropertyOffset(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellY");
		ConvertLevelStaticMeshToInstance_CellY_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellY", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertLevelStaticMeshToInstance_CellZ_PropertyAddress, ConvertLevelStaticMeshToInstance_FunctionAddress, "CellZ");
		ConvertLevelStaticMeshToInstance_CellZ_Offset = NativeReflectionCached.GetPropertyOffset(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellZ");
		ConvertLevelStaticMeshToInstance_CellZ_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertLevelStaticMeshToInstance_FunctionAddress, "CellZ", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertLevelStaticMeshToInstance_MinInstancesCount_PropertyAddress, ConvertLevelStaticMeshToInstance_FunctionAddress, "MinInstancesCount");
		ConvertLevelStaticMeshToInstance_MinInstancesCount_Offset = NativeReflectionCached.GetPropertyOffset(ConvertLevelStaticMeshToInstance_FunctionAddress, "MinInstancesCount");
		ConvertLevelStaticMeshToInstance_MinInstancesCount_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertLevelStaticMeshToInstance_FunctionAddress, "MinInstancesCount", Classes.FIntProperty);
		ConvertLevelStaticMeshToInstance_IsValid = ConvertLevelStaticMeshToInstance_FunctionAddress != IntPtr.Zero && ConvertLevelStaticMeshToInstance_CellX_IsValid && ConvertLevelStaticMeshToInstance_CellY_IsValid && ConvertLevelStaticMeshToInstance_CellZ_IsValid && ConvertLevelStaticMeshToInstance_MinInstancesCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertLevelStaticMeshToInstance", ConvertLevelStaticMeshToInstance_IsValid);
		ConvertCubeInLevelToBlockingVolume_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertCubeInLevelToBlockingVolume");
		ConvertCubeInLevelToBlockingVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertCubeInLevelToBlockingVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertCubeInLevelToBlockingVolume_InAssets_PropertyAddress, ConvertCubeInLevelToBlockingVolume_FunctionAddress, "InAssets");
		ConvertCubeInLevelToBlockingVolume_InAssets_Offset = NativeReflectionCached.GetPropertyOffset(ConvertCubeInLevelToBlockingVolume_FunctionAddress, "InAssets");
		ConvertCubeInLevelToBlockingVolume_InAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertCubeInLevelToBlockingVolume_FunctionAddress, "InAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_PropertyAddress, ConvertCubeInLevelToBlockingVolume_FunctionAddress, "bKeepOriginalActor");
		ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_Offset = NativeReflectionCached.GetPropertyOffset(ConvertCubeInLevelToBlockingVolume_FunctionAddress, "bKeepOriginalActor");
		ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertCubeInLevelToBlockingVolume_FunctionAddress, "bKeepOriginalActor", Classes.FBoolProperty);
		ConvertCubeInLevelToBlockingVolume_IsValid = ConvertCubeInLevelToBlockingVolume_FunctionAddress != IntPtr.Zero && ConvertCubeInLevelToBlockingVolume_InAssets_IsValid && ConvertCubeInLevelToBlockingVolume_bKeepOriginalActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ConvertCubeInLevelToBlockingVolume", ConvertCubeInLevelToBlockingVolume_IsValid);
		ClearSelectedActorsCustomPrimitiveData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearSelectedActorsCustomPrimitiveData");
		ClearSelectedActorsCustomPrimitiveData_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearSelectedActorsCustomPrimitiveData_FunctionAddress);
		ClearSelectedActorsCustomPrimitiveData_IsValid = ClearSelectedActorsCustomPrimitiveData_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:ClearSelectedActorsCustomPrimitiveData", ClearSelectedActorsCustomPrimitiveData_IsValid);
		CleanObsoleteAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanObsoleteAssets");
		CleanObsoleteAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanObsoleteAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CleanObsoleteAssets_SourceRootDirectory_PropertyAddress, CleanObsoleteAssets_FunctionAddress, "SourceRootDirectory");
		CleanObsoleteAssets_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(CleanObsoleteAssets_FunctionAddress, "SourceRootDirectory");
		CleanObsoleteAssets_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(CleanObsoleteAssets_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		CleanObsoleteAssets_IsValid = CleanObsoleteAssets_FunctionAddress != IntPtr.Zero && CleanObsoleteAssets_SourceRootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanObsoleteAssets", CleanObsoleteAssets_IsValid);
		CleanLevelNameDecorateLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanLevelNameDecorateLevelActor");
		CleanLevelNameDecorateLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanLevelNameDecorateLevelActor_FunctionAddress);
		CleanLevelNameDecorateLevelActor_IsValid = CleanLevelNameDecorateLevelActor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanLevelNameDecorateLevelActor", CleanLevelNameDecorateLevelActor_IsValid);
		CleanIllegalNoSMLandTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanIllegalNoSMLandTags");
		CleanIllegalNoSMLandTags_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanIllegalNoSMLandTags_FunctionAddress);
		CleanIllegalNoSMLandTags_IsValid = CleanIllegalNoSMLandTags_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanIllegalNoSMLandTags", CleanIllegalNoSMLandTags_IsValid);
		CleanAllOldIKMeshTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CleanAllOldIKMeshTags");
		CleanAllOldIKMeshTags_ParamsSize = NativeReflection.GetFunctionParamsSize(CleanAllOldIKMeshTags_FunctionAddress);
		CleanAllOldIKMeshTags_IsValid = CleanAllOldIKMeshTags_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CleanAllOldIKMeshTags", CleanAllOldIKMeshTags_IsValid);
		CheckSkylightCubemapResolution_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckSkylightCubemapResolution");
		CheckSkylightCubemapResolution_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckSkylightCubemapResolution_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckSkylightCubemapResolution_SrcFolderPath_PropertyAddress, CheckSkylightCubemapResolution_FunctionAddress, "SrcFolderPath");
		CheckSkylightCubemapResolution_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(CheckSkylightCubemapResolution_FunctionAddress, "SrcFolderPath");
		CheckSkylightCubemapResolution_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckSkylightCubemapResolution_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		CheckSkylightCubemapResolution_IsValid = CheckSkylightCubemapResolution_FunctionAddress != IntPtr.Zero && CheckSkylightCubemapResolution_SrcFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckSkylightCubemapResolution", CheckSkylightCubemapResolution_IsValid);
		CheckForUmappedFoliageCompsInLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckForUmappedFoliageCompsInLevels");
		CheckForUmappedFoliageCompsInLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckForUmappedFoliageCompsInLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckForUmappedFoliageCompsInLevels_SrcFolderPath_PropertyAddress, CheckForUmappedFoliageCompsInLevels_FunctionAddress, "SrcFolderPath");
		CheckForUmappedFoliageCompsInLevels_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(CheckForUmappedFoliageCompsInLevels_FunctionAddress, "SrcFolderPath");
		CheckForUmappedFoliageCompsInLevels_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckForUmappedFoliageCompsInLevels_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		CheckForUmappedFoliageCompsInLevels_IsValid = CheckForUmappedFoliageCompsInLevels_FunctionAddress != IntPtr.Zero && CheckForUmappedFoliageCompsInLevels_SrcFolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageCompsInLevels", CheckForUmappedFoliageCompsInLevels_IsValid);
		CheckForUmappedFoliageComps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckForUmappedFoliageComps");
		CheckForUmappedFoliageComps_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckForUmappedFoliageComps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckForUmappedFoliageComps_InAsset_PropertyAddress, CheckForUmappedFoliageComps_FunctionAddress, "InAsset");
		CheckForUmappedFoliageComps_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(CheckForUmappedFoliageComps_FunctionAddress, "InAsset");
		CheckForUmappedFoliageComps_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckForUmappedFoliageComps_FunctionAddress, "InAsset", Classes.FStructProperty);
		CheckForUmappedFoliageComps_IsValid = CheckForUmappedFoliageComps_FunctionAddress != IntPtr.Zero && CheckForUmappedFoliageComps_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckForUmappedFoliageComps", CheckForUmappedFoliageComps_IsValid);
		CheckDuplicatedActorsForRemoval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckDuplicatedActorsForRemoval");
		CheckDuplicatedActorsForRemoval_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckDuplicatedActorsForRemoval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckDuplicatedActorsForRemoval_SrcFolderPath_PropertyAddress, CheckDuplicatedActorsForRemoval_FunctionAddress, "SrcFolderPath");
		CheckDuplicatedActorsForRemoval_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(CheckDuplicatedActorsForRemoval_FunctionAddress, "SrcFolderPath");
		CheckDuplicatedActorsForRemoval_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckDuplicatedActorsForRemoval_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckDuplicatedActorsForRemoval_SettingPtr_PropertyAddress, CheckDuplicatedActorsForRemoval_FunctionAddress, "SettingPtr");
		CheckDuplicatedActorsForRemoval_SettingPtr_Offset = NativeReflectionCached.GetPropertyOffset(CheckDuplicatedActorsForRemoval_FunctionAddress, "SettingPtr");
		CheckDuplicatedActorsForRemoval_SettingPtr_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckDuplicatedActorsForRemoval_FunctionAddress, "SettingPtr", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckDuplicatedActorsForRemoval_bScanOnly_PropertyAddress, CheckDuplicatedActorsForRemoval_FunctionAddress, "bScanOnly");
		CheckDuplicatedActorsForRemoval_bScanOnly_Offset = NativeReflectionCached.GetPropertyOffset(CheckDuplicatedActorsForRemoval_FunctionAddress, "bScanOnly");
		CheckDuplicatedActorsForRemoval_bScanOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckDuplicatedActorsForRemoval_FunctionAddress, "bScanOnly", Classes.FBoolProperty);
		CheckDuplicatedActorsForRemoval_IsValid = CheckDuplicatedActorsForRemoval_FunctionAddress != IntPtr.Zero && CheckDuplicatedActorsForRemoval_SrcFolderPath_IsValid && CheckDuplicatedActorsForRemoval_SettingPtr_IsValid && CheckDuplicatedActorsForRemoval_bScanOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckDuplicatedActorsForRemoval", CheckDuplicatedActorsForRemoval_IsValid);
		CheckActorsNumAfterSplit_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckActorsNumAfterSplit");
		CheckActorsNumAfterSplit_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckActorsNumAfterSplit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckActorsNumAfterSplit_SourceRootDirectory_PropertyAddress, CheckActorsNumAfterSplit_FunctionAddress, "SourceRootDirectory");
		CheckActorsNumAfterSplit_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorsNumAfterSplit_FunctionAddress, "SourceRootDirectory");
		CheckActorsNumAfterSplit_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorsNumAfterSplit_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorsNumAfterSplit_bDebug_PropertyAddress, CheckActorsNumAfterSplit_FunctionAddress, "bDebug");
		CheckActorsNumAfterSplit_bDebug_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorsNumAfterSplit_FunctionAddress, "bDebug");
		CheckActorsNumAfterSplit_bDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorsNumAfterSplit_FunctionAddress, "bDebug", Classes.FBoolProperty);
		CheckActorsNumAfterSplit_IsValid = CheckActorsNumAfterSplit_FunctionAddress != IntPtr.Zero && CheckActorsNumAfterSplit_SourceRootDirectory_IsValid && CheckActorsNumAfterSplit_bDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CheckActorsNumAfterSplit", CheckActorsNumAfterSplit_IsValid);
		CalculateLevelBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateLevelBounds");
		CalculateLevelBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateLevelBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateLevelBounds_InLevel_PropertyAddress, CalculateLevelBounds_FunctionAddress, "InLevel");
		CalculateLevelBounds_InLevel_Offset = NativeReflectionCached.GetPropertyOffset(CalculateLevelBounds_FunctionAddress, "InLevel");
		CalculateLevelBounds_InLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateLevelBounds_FunctionAddress, "InLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateLevelBounds_Origin_PropertyAddress, CalculateLevelBounds_FunctionAddress, "Origin");
		CalculateLevelBounds_Origin_Offset = NativeReflectionCached.GetPropertyOffset(CalculateLevelBounds_FunctionAddress, "Origin");
		CalculateLevelBounds_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateLevelBounds_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateLevelBounds_BoxExtent_PropertyAddress, CalculateLevelBounds_FunctionAddress, "BoxExtent");
		CalculateLevelBounds_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(CalculateLevelBounds_FunctionAddress, "BoxExtent");
		CalculateLevelBounds_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateLevelBounds_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		CalculateLevelBounds_IsValid = CalculateLevelBounds_FunctionAddress != IntPtr.Zero && CalculateLevelBounds_InLevel_IsValid && CalculateLevelBounds_Origin_IsValid && CalculateLevelBounds_BoxExtent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateLevelBounds", CalculateLevelBounds_IsValid);
		CalculateActorClassAndCount_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateActorClassAndCount");
		CalculateActorClassAndCount_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateActorClassAndCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateActorClassAndCount_SourceRootDirectory_PropertyAddress, CalculateActorClassAndCount_FunctionAddress, "SourceRootDirectory");
		CalculateActorClassAndCount_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(CalculateActorClassAndCount_FunctionAddress, "SourceRootDirectory");
		CalculateActorClassAndCount_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateActorClassAndCount_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		CalculateActorClassAndCount_IsValid = CalculateActorClassAndCount_FunctionAddress != IntPtr.Zero && CalculateActorClassAndCount_SourceRootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CalculateActorClassAndCount", CalculateActorClassAndCount_IsValid);
		CacheConsoleHistoryBuffer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CacheConsoleHistoryBuffer");
		CacheConsoleHistoryBuffer_ParamsSize = NativeReflection.GetFunctionParamsSize(CacheConsoleHistoryBuffer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CacheConsoleHistoryBuffer_ReturnValue_PropertyAddress, CacheConsoleHistoryBuffer_FunctionAddress, "ReturnValue");
		CacheConsoleHistoryBuffer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CacheConsoleHistoryBuffer_FunctionAddress, "ReturnValue");
		CacheConsoleHistoryBuffer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CacheConsoleHistoryBuffer_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CacheConsoleHistoryBuffer_IsValid = CacheConsoleHistoryBuffer_FunctionAddress != IntPtr.Zero && CacheConsoleHistoryBuffer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:CacheConsoleHistoryBuffer", CacheConsoleHistoryBuffer_IsValid);
		BuildNavDataNoWC_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildNavDataNoWC");
		BuildNavDataNoWC_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildNavDataNoWC_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildNavDataNoWC_MapName_PropertyAddress, BuildNavDataNoWC_FunctionAddress, "MapName");
		BuildNavDataNoWC_MapName_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavDataNoWC_FunctionAddress, "MapName");
		BuildNavDataNoWC_MapName_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavDataNoWC_FunctionAddress, "MapName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNavDataNoWC_bNeedCheckout_PropertyAddress, BuildNavDataNoWC_FunctionAddress, "bNeedCheckout");
		BuildNavDataNoWC_bNeedCheckout_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavDataNoWC_FunctionAddress, "bNeedCheckout");
		BuildNavDataNoWC_bNeedCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavDataNoWC_FunctionAddress, "bNeedCheckout", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNavDataNoWC_ReturnValue_PropertyAddress, BuildNavDataNoWC_FunctionAddress, "ReturnValue");
		BuildNavDataNoWC_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavDataNoWC_FunctionAddress, "ReturnValue");
		BuildNavDataNoWC_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavDataNoWC_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BuildNavDataNoWC_IsValid = BuildNavDataNoWC_FunctionAddress != IntPtr.Zero && BuildNavDataNoWC_MapName_IsValid && BuildNavDataNoWC_bNeedCheckout_IsValid && BuildNavDataNoWC_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavDataNoWC", BuildNavDataNoWC_IsValid);
		BuildNavData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildNavData");
		BuildNavData_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildNavData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildNavData_MapName_PropertyAddress, BuildNavData_FunctionAddress, "MapName");
		BuildNavData_MapName_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavData_FunctionAddress, "MapName");
		BuildNavData_MapName_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavData_FunctionAddress, "MapName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNavData_bNeedCheckout_PropertyAddress, BuildNavData_FunctionAddress, "bNeedCheckout");
		BuildNavData_bNeedCheckout_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavData_FunctionAddress, "bNeedCheckout");
		BuildNavData_bNeedCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavData_FunctionAddress, "bNeedCheckout", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNavData_ReturnValue_PropertyAddress, BuildNavData_FunctionAddress, "ReturnValue");
		BuildNavData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BuildNavData_FunctionAddress, "ReturnValue");
		BuildNavData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNavData_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BuildNavData_IsValid = BuildNavData_FunctionAddress != IntPtr.Zero && BuildNavData_MapName_IsValid && BuildNavData_bNeedCheckout_IsValid && BuildNavData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:BuildNavData", BuildNavData_IsValid);
		AssembleTilesNamesForParallelTasks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AssembleTilesNamesForParallelTasks");
		AssembleTilesNamesForParallelTasks_ParamsSize = NativeReflection.GetFunctionParamsSize(AssembleTilesNamesForParallelTasks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AssembleTilesNamesForParallelTasks_RootDirectory_PropertyAddress, AssembleTilesNamesForParallelTasks_FunctionAddress, "RootDirectory");
		AssembleTilesNamesForParallelTasks_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(AssembleTilesNamesForParallelTasks_FunctionAddress, "RootDirectory");
		AssembleTilesNamesForParallelTasks_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(AssembleTilesNamesForParallelTasks_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AssembleTilesNamesForParallelTasks_InMapFilterNames_PropertyAddress, AssembleTilesNamesForParallelTasks_FunctionAddress, "InMapFilterNames");
		AssembleTilesNamesForParallelTasks_InMapFilterNames_Offset = NativeReflectionCached.GetPropertyOffset(AssembleTilesNamesForParallelTasks_FunctionAddress, "InMapFilterNames");
		AssembleTilesNamesForParallelTasks_InMapFilterNames_IsValid = NativeReflectionCached.ValidatePropertyClass(AssembleTilesNamesForParallelTasks_FunctionAddress, "InMapFilterNames", Classes.FArrayProperty);
		AssembleTilesNamesForParallelTasks_IsValid = AssembleTilesNamesForParallelTasks_FunctionAddress != IntPtr.Zero && AssembleTilesNamesForParallelTasks_RootDirectory_IsValid && AssembleTilesNamesForParallelTasks_InMapFilterNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:AssembleTilesNamesForParallelTasks", AssembleTilesNamesForParallelTasks_IsValid);
		AddFoliageTypeToLevelByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFoliageTypeToLevelByLevelName");
		AddFoliageTypeToLevelByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFoliageTypeToLevelByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevelByLevelName_LevelName_PropertyAddress, AddFoliageTypeToLevelByLevelName_FunctionAddress, "LevelName");
		AddFoliageTypeToLevelByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevelByLevelName_FunctionAddress, "LevelName");
		AddFoliageTypeToLevelByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevelByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevelByLevelName_type_PropertyAddress, AddFoliageTypeToLevelByLevelName_FunctionAddress, "type");
		AddFoliageTypeToLevelByLevelName_type_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevelByLevelName_FunctionAddress, "type");
		AddFoliageTypeToLevelByLevelName_type_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevelByLevelName_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevelByLevelName_ReturnValue_PropertyAddress, AddFoliageTypeToLevelByLevelName_FunctionAddress, "ReturnValue");
		AddFoliageTypeToLevelByLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevelByLevelName_FunctionAddress, "ReturnValue");
		AddFoliageTypeToLevelByLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevelByLevelName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFoliageTypeToLevelByLevelName_IsValid = AddFoliageTypeToLevelByLevelName_FunctionAddress != IntPtr.Zero && AddFoliageTypeToLevelByLevelName_LevelName_IsValid && AddFoliageTypeToLevelByLevelName_type_IsValid && AddFoliageTypeToLevelByLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevelByLevelName", AddFoliageTypeToLevelByLevelName_IsValid);
		AddFoliageTypeToLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFoliageTypeToLevel");
		AddFoliageTypeToLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFoliageTypeToLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevel_Level_PropertyAddress, AddFoliageTypeToLevel_FunctionAddress, "Level");
		AddFoliageTypeToLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevel_FunctionAddress, "Level");
		AddFoliageTypeToLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevel_type_PropertyAddress, AddFoliageTypeToLevel_FunctionAddress, "type");
		AddFoliageTypeToLevel_type_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevel_FunctionAddress, "type");
		AddFoliageTypeToLevel_type_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevel_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageTypeToLevel_ReturnValue_PropertyAddress, AddFoliageTypeToLevel_FunctionAddress, "ReturnValue");
		AddFoliageTypeToLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageTypeToLevel_FunctionAddress, "ReturnValue");
		AddFoliageTypeToLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageTypeToLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddFoliageTypeToLevel_IsValid = AddFoliageTypeToLevel_FunctionAddress != IntPtr.Zero && AddFoliageTypeToLevel_Level_IsValid && AddFoliageTypeToLevel_type_IsValid && AddFoliageTypeToLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageTypeToLevel", AddFoliageTypeToLevel_IsValid);
		AddFoliageInstanceDataToLevelByLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFoliageInstanceDataToLevelByLevelName");
		AddFoliageInstanceDataToLevelByLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevelByLevelName_LevelName_PropertyAddress, AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "LevelName");
		AddFoliageInstanceDataToLevelByLevelName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "LevelName");
		AddFoliageInstanceDataToLevelByLevelName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "LevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevelByLevelName_type_PropertyAddress, AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "type");
		AddFoliageInstanceDataToLevelByLevelName_type_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "type");
		AddFoliageInstanceDataToLevelByLevelName_type_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevelByLevelName_InstanceData_PropertyAddress, AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "InstanceData");
		AddFoliageInstanceDataToLevelByLevelName_InstanceData_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "InstanceData");
		AddFoliageInstanceDataToLevelByLevelName_InstanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevelByLevelName_FunctionAddress, "InstanceData", Classes.FArrayProperty);
		AddFoliageInstanceDataToLevelByLevelName_IsValid = AddFoliageInstanceDataToLevelByLevelName_FunctionAddress != IntPtr.Zero && AddFoliageInstanceDataToLevelByLevelName_LevelName_IsValid && AddFoliageInstanceDataToLevelByLevelName_type_IsValid && AddFoliageInstanceDataToLevelByLevelName_InstanceData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevelByLevelName", AddFoliageInstanceDataToLevelByLevelName_IsValid);
		AddFoliageInstanceDataToLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFoliageInstanceDataToLevel");
		AddFoliageInstanceDataToLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFoliageInstanceDataToLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevel_Level_PropertyAddress, AddFoliageInstanceDataToLevel_FunctionAddress, "Level");
		AddFoliageInstanceDataToLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevel_FunctionAddress, "Level");
		AddFoliageInstanceDataToLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevel_type_PropertyAddress, AddFoliageInstanceDataToLevel_FunctionAddress, "type");
		AddFoliageInstanceDataToLevel_type_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevel_FunctionAddress, "type");
		AddFoliageInstanceDataToLevel_type_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevel_FunctionAddress, "type", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFoliageInstanceDataToLevel_InstanceData_PropertyAddress, AddFoliageInstanceDataToLevel_FunctionAddress, "InstanceData");
		AddFoliageInstanceDataToLevel_InstanceData_Offset = NativeReflectionCached.GetPropertyOffset(AddFoliageInstanceDataToLevel_FunctionAddress, "InstanceData");
		AddFoliageInstanceDataToLevel_InstanceData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFoliageInstanceDataToLevel_FunctionAddress, "InstanceData", Classes.FArrayProperty);
		AddFoliageInstanceDataToLevel_IsValid = AddFoliageInstanceDataToLevel_FunctionAddress != IntPtr.Zero && AddFoliageInstanceDataToLevel_Level_IsValid && AddFoliageInstanceDataToLevel_type_IsValid && AddFoliageInstanceDataToLevel_InstanceData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorLevelLibrary:AddFoliageInstanceDataToLevel", AddFoliageInstanceDataToLevel_IsValid);
	}
}
